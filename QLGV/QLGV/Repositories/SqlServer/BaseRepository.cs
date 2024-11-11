using QLGV.Repositories.Creterias;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Repositories.SqlServer
{
    public abstract class BaseRepository<T>
    {
        abstract public string TableName { get; }

        public virtual string PrimaryKey
        {
            get => TableName + "Id";
        }

        abstract public string[] ColumnList { get; }

        protected virtual string[] HasMany { get; }

        protected virtual string[] BelongsTo { get; }

        protected virtual Dictionary<string, string> HasManyWithPivot { get; }

        public string AllColumnString
        {
            get => string.Join(", ", ColumnList.Select(i => string.Format("{0}.{1}",TableName,i)));
        }

        public abstract T ReaderMapper(SqlDataReader reader, int offset);

        public IEnumerable<T> Find(BaseFindCreterias creterias)
        {
            List<T> listOfModel = new List<T>();
            try
            {

                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder("SELECT ");
                    // select top
                    sql.Append(AllColumnString);
                    sql.Append($" FROM {TableName}");

                    sql.Append(" WHERE (1=1)");

                    if (creterias.Ids.Length != 0) 
                    {
                        sql.Append($" AND {PrimaryKey} IN (");
                        sql.Append(string.Join(", ", creterias.Ids.Select(id => $"'{id}'")));
                        sql.Append(')');
                    }
                    Console.WriteLine(sql.ToString());
                    cmd.CommandText = sql.ToString();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                listOfModel.Add(ReaderMapper(reader,0));
                            }
                        }
                    }
                };
                return listOfModel;

            }
            catch (SqlException)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
                return listOfModel;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return listOfModel;
            }
        }

        public IEnumerable<T> FindIncludeOne<M>(BaseFindCreterias creterias, BaseRepository<M> relationshipRepo)
        {
            List<T> listOfModel = new List<T>();
            try
            {

                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder("SELECT ");
                    // select top
                    sql.Append(AllColumnString);
                    sql.Append(", ");
                    sql.Append(relationshipRepo.AllColumnString);
                    sql.Append($" FROM {TableName}");

                    sql.Append($" LEFT JOIN {relationshipRepo.TableName} ON {this.TableName}.{relationshipRepo.PrimaryKey} = {relationshipRepo.TableName}.{relationshipRepo.PrimaryKey} WHERE (1=1)");

                    if (creterias.Ids.Length != 0)
                    {
                        sql.Append($" AND {PrimaryKey} IN (");
                        sql.Append(string.Join(", ", creterias.Ids.Select(id => $"'{id}'")));
                        sql.Append(')');
                    }

                    cmd.CommandText = sql.ToString();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                T model = ReaderMapper(reader, 0);
                                model.GetType().GetProperty(relationshipRepo.TableName).SetValue(model, relationshipRepo.ReaderMapper(reader, this.ColumnList.Length));
                                listOfModel.Add(model);
                            }
                        }
                    }
                };
                return listOfModel;

            }
            catch (SqlException)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
                return listOfModel;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return listOfModel;
            }
        }
    }
}
