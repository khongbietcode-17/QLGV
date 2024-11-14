using QLGV.Factories;
using QLGV.Models;
using QLGV.Repositories.Creterias;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Repositories.SqlServer
{
    public abstract class BaseRepository<T>: IRepository where T : BaseModel
    {
        private readonly IFactory<IRepository> _factory;

        protected virtual bool IsAutoIncreasementKey => true;
        
        abstract public string TableName { get; }

        public virtual string PrimaryKey
        {
            get => TableName + "Id";
        }
        abstract public string[] ColumnList { get; }

        public string AllColumnString
        {
            get => string.Join(", ", ColumnList.Select(i => string.Format("{0}.{1}",TableName,i)));
        }

        public string ColumnAddString
        {
            get
            {
                if (IsAutoIncreasementKey)
                {
                   return "(" + string.Join(", ", ColumnList.Select(i => i == PrimaryKey ? "" : string.Format("@{0}", i))) + ")";
                } 
                else
                {
                    return "(" + string.Join(", ", ColumnList.Select(i => string.Format("@{0}", i))) + ")";
                } 

            }
        }

        public string ColumnUpdateString
        {
            get => string.Join(", ", ColumnList.Select(i => i == PrimaryKey ? "" : string.Format("{0} = @{0}", i))) + " WHERE " + PrimaryKey + " =  @" + PrimaryKey;
        }

        public abstract BaseModel ReaderMapper(SqlDataReader reader, int offset);

        public abstract void AddParameter(ref SqlCommand cmd, T model);

        public BaseRepository()
        {
            _factory = new RepositoryFactory();
        }
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
                    
                    cmd.CommandText = sql.ToString();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                listOfModel.Add((T) ReaderMapper(reader,0));
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
        public T FindById(int id)
        {   
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

                    sql.Append(" WHERE ");
                    sql.Append(PrimaryKey);
                    sql.Append(" = ");
                    sql.Append("@" + PrimaryKey);

                   
                    Console.WriteLine(sql.ToString());
                    cmd.CommandText = sql.ToString();

                    cmd.Parameters.Add(new SqlParameter("@" + PrimaryKey, System.Data.SqlDbType.Int)).Value = id;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.Read())
                        {
                            return (T) ReaderMapper(reader,0);
                        } else
                        {
                            return null;
                        }
                    }
                };

            }
            catch (SqlException)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return null;
            }
        }
        public T Add(T model)
        {
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder("INSERT INTO ");
                    sql.Append(TableName);
                    sql.Append(" VALUES ");
                    sql.Append(ColumnAddString);
                 
                    cmd.CommandText = sql.ToString();   
                    
                    AddParameter(ref cmd, model);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return model;
                    }
                    else
                    {
                        return null;
                    }
                };

            }
            catch (SqlException)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return null;
            }
        }

        public int Update(T model)
        {
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder("UPDATE ");
                    sql.Append(TableName);
                    sql.Append(" SET ");
                    sql.Append(ColumnUpdateString);

                    cmd.CommandText = sql.ToString();

                    AddParameter(ref cmd, model);

                    return cmd.ExecuteNonQuery();
                    
                };

            }
            catch (SqlException)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return 0;
            }
        }

        public int Delete(int id)
        {
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder("DELETE FROM ");
                    sql.Append(TableName);
                    sql.Append(" WHERE ");
                    sql.Append(PrimaryKey);
                    sql.Append(" = @");
                    sql.Append(PrimaryKey);

                    cmd.CommandText = sql.ToString();

                    cmd.Parameters.Add(new SqlParameter("@" + PrimaryKey, System.Data.SqlDbType.Int)).Value = id;

                    return cmd.ExecuteNonQuery();

                };

            }
            catch (SqlException)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return 0;
            }
        }

        //public int Delete(int[] id)
        //{
        //    try
        //    {
        //        using (SqlConnection conn = Connection.CreateConnection())
        //        {
        //            conn.Open();

        //            SqlCommand cmd = conn.CreateCommand();
        //            StringBuilder sql = new StringBuilder("DELETE FROM ");
        //            sql.Append(TableName);
        //            sql.Append(" WHERE ");
        //            sql.Append(PrimaryKey);
        //            sql.Append(" IN ");
        //            sql.Append("(" + string.Join(", ", id) + ")");

        //            cmd.CommandText = sql.ToString();

        //            return cmd.ExecuteNonQuery();

        //        };

        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
        //        return 0;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
        //        return 0;
        //    }
        //}

        public IEnumerable<T> FindIncludeOne<M>(BaseFindCreterias creterias) where M : BaseModel
        {
            IRepository relationshipRepo = _factory.GetInstance(typeof(M).Name);
            List<T> listOfModel = new List<T>();
            try
            {

                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder("SELECT ");
                    // select top
                    sql.Append($"{AllColumnString}, {relationshipRepo.AllColumnString} FROM {TableName}");
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
                                T model = (T) ReaderMapper(reader, 0);
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

        //public IEnumerable<T> FindIncludeMany<M>(BaseFindCreterias creterias, string pivotTable) where M : BaseModel
        //{
        //    IRepository relationshipRepo = _factory.GetInstance(typeof(M).Name);
        //    List<T> listOfModel = new List<T>();
        //    try
        //    {

        //        using (SqlConnection conn = Connection.CreateConnection())
        //        {
        //            conn.Open();

        //            SqlCommand cmd = conn.CreateCommand();
        //            StringBuilder sql = new StringBuilder("SELECT ");
        //            // select top
        //            sql.Append(AllColumnString);

        //            sql.Append(", ");

        //            sql.Append(relationshipRepo.AllColumnString);

        //            sql.Append($" FROM {TableName}");

        //            sql.Append($" LEFT JOIN {pivotTable} ON {pivotTable}.{this.PrimaryKey} = {this.TableName}.{this.PrimaryKey}");

        //            sql.Append($" LEFT JOIN {relationshipRepo.TableName} ON {pivotTable}.{relationshipRepo.PrimaryKey} = {relationshipRepo.TableName}.{relationshipRepo.PrimaryKey} WHERE(1 = 1)");

        //            if (creterias.Ids.Length != 0)
        //            {
        //                sql.Append($" AND {PrimaryKey} IN (");
        //                sql.Append(string.Join(", ", creterias.Ids.Select(id => $"'{id}'")));
        //                sql.Append(')');
        //            }

        //            Console.WriteLine(sql.ToString());
        //            cmd.CommandText = sql.ToString();

        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader != null && reader.Read())
        //                {
        //                    int index = 0;
        //                    T currentModel = (T) ReaderMapper(reader, 0);
        //                    List<M> list = new List<M>();
        //                    while (reader.Read())
        //                    {
        //                        int id = reader.GetInt32(0);
        //                        if(id != index)
        //                        {
        //                            T model = (T) ReaderMapper(reader, 0);

        //                            model.GetType().GetProperty(relationshipRepo.TableName).SetValue(model, relationshipRepo.ReaderMapper(reader, this.ColumnList.Length));
        //                            listOfModel.Add(model);
        //                            index = id;
        //                        } esle {

        //                        }
        //                    }
        //                }
        //            }
        //        };
        //        return listOfModel;

        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
        //        return listOfModel;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
        //        return listOfModel;
        //    }
        //}
    }
}
