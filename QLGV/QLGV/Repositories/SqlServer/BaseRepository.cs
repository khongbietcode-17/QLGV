using QLGV.Factories;
using QLGV.Models;
using QLGV.Repositories.Creterias;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLGV.Repositories.SqlServer
{
    public abstract class BaseRepository<T>: ITable where T : BaseModel
    {
        private readonly IFactory<ITable> _factory;
        
        abstract public string TableName { get; }

        public virtual string PrimaryKey
        {
            get => TableName + "Id";
        }

        public virtual string PivotTable
        {
            get => "";
        }

        abstract public string[] ColumnList { get; }

        abstract public string[] ColumnListAdd { get; }

        public string AllColumnString
        {
            get => string.Join(", ", ColumnList.Select(i => string.Format("{0}.{1}",TableName,i)));
        }

        public string ColumnAddString
        {
            get => "(" + string.Join(", ", ColumnListAdd.Select(i => string.Format("@{0}", i))) + ")";           
        }

        public string ColumnUpdateString
        {
            get => string.Join(", ", ColumnListAdd.Select(i => string.Format("{0} = @{0}", i)));
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
            catch (SqlException e)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!"+ e.ToString(), "Error");
                return listOfModel;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return listOfModel;
            }
        }

        public T FindFirst(BaseFindCreterias creterias)
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
                        if (reader != null && reader.Read())
                        {
                            
                            {
                                return (T) ReaderMapper(reader, 0);
                            }
                        }
                    }
                };
                return null;

            }
            catch (SqlException e)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!" + e.ToString(), "Error");
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return null;
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
        public T FindByIdIncludeOne<M>(int id)
        {
            ITable relationshipRepo = _factory.GetInstance(typeof(M).Name);
            try
            {

                T model = null;
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder("SELECT ");
                    // select top
                    sql.Append($"{AllColumnString}, {relationshipRepo.AllColumnString} FROM {TableName}");
                    sql.Append($" LEFT JOIN {relationshipRepo.TableName} ON {TableName}.{relationshipRepo.PrimaryKey} = {relationshipRepo.TableName}.{relationshipRepo.PrimaryKey} WHERE {TableName}.{PrimaryKey} = @{PrimaryKey}");

                    cmd.CommandText = sql.ToString();

                    cmd.Parameters.Add(new SqlParameter("@" + PrimaryKey, System.Data.SqlDbType.Int)).Value = id;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.Read())
                        {

                            model = (T)ReaderMapper(reader, 0);
                            model.GetType().GetProperty(relationshipRepo.TableName).SetValue(model, relationshipRepo.ReaderMapper(reader, this.ColumnList.Length));
                        }
                    }
                };
                return model;

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

        public T IncludeOne<M>(T model, int id) where M : BaseModel
        {
            ITable relationshipRepo = _factory.GetInstance(typeof(M).Name);
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();

                    string sql = $"SELECT {relationshipRepo.AllColumnString} FROM {relationshipRepo.TableName} JOIN {TableName} ON {relationshipRepo.TableName}.{relationshipRepo.PrimaryKey} = {TableName}.{relationshipRepo.PrimaryKey} WHERE {TableName}.{PrimaryKey} = {id}";
                    //Console.WriteLine(sql);
                    cmd.CommandText = sql;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {

                                M relaModel = (M)relationshipRepo.ReaderMapper(reader, 0);
                                model.GetType().GetProperty(relationshipRepo.TableName).SetValue(model, relaModel);
                            }
                        }
                    }
                };

                return model;

            }
            catch (SqlException e)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!" + e.ToString(), "Error");
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return null;
            }

        }


        public IEnumerable<T> IncludeOne<M>(IEnumerable<T> listOfModel, int[] ids) where M: BaseModel
        {
            if(listOfModel.Count() == 0)
            {
                return Enumerable.Empty<T>();
            }
            string idsString = string.Join(", ", ids);

            ITable relationshipRepo = _factory.GetInstance(typeof(M).Name);
            List<M> list = new List<M>();
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();

                    string sql = $"SELECT {relationshipRepo.AllColumnString} FROM {relationshipRepo.TableName} RIGHT JOIN {TableName} ON {relationshipRepo.TableName}.{relationshipRepo.PrimaryKey} = {TableName}.{relationshipRepo.PrimaryKey} WHERE  {TableName}.{PrimaryKey} IN ({idsString})";
                    
                    cmd.CommandText = sql;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                if(!reader.IsDBNull(0))
                                {
                                   M model = (M) relationshipRepo.ReaderMapper(reader, 0);
                                   list.Add(model);
                                } else
                                {
                                    list.Add(null);
                                }
                            }
                        }
                    }
                };
                 
                int i = 0;
                foreach(T model in listOfModel)
                {
                    model.GetType().GetProperty(relationshipRepo.TableName).SetValue(model, list[i++]);                
                }
                return listOfModel;

            }
            catch (SqlException e)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!" + e.Message, "Error");
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.Message);
                return null;
            }
        }

        public IEnumerable<T> IncludeManyWithPivot<M>(IEnumerable<T> listOfModel, int[] ids) where M: BaseModel
        {
            if (listOfModel.Count() == 0)
            {
                return Enumerable.Empty<T>();
            }
            string idsString = string.Join(", ", ids);
            ITable relationshipRepo = _factory.GetInstance(typeof(M).Name);
            List<List<M>> list = new List<List<M>>();
            try
            {

                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                   
                    // select top

                    string sql = $"SELECT {TableName}.{PrimaryKey}, {relationshipRepo.AllColumnString} FROM {PivotTable} " +
                        $"JOIN {relationshipRepo.TableName} ON {relationshipRepo.TableName}.{relationshipRepo.PrimaryKey} = {PivotTable}.{relationshipRepo.PrimaryKey} " +
                        $"RIGHT JOIN {TableName} ON {TableName}.{PrimaryKey} = {PivotTable}.{PrimaryKey} " +
                        $"WHERE {TableName}.{PrimaryKey} IN ({idsString})";

                    //Console.WriteLine(sql);
                    cmd.CommandText = sql;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null && reader.Read())
                        {
                            List<M> listRelation = new List<M>();
                            int previousId = reader.GetInt32(0);
                            if(!reader.IsDBNull(1))
                            {
                                M model = (M)relationshipRepo.ReaderMapper(reader, 1);
                                listRelation.Add(model);
                            }
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);

                                if(reader.IsDBNull(1))
                                {
                                    list.Add(listRelation);
                                    listRelation = new List<M>();
                                    previousId = id;
                                    continue;
                                }
                                if (id != previousId)
                                {
                                    list.Add(listRelation);
                                    listRelation = new List<M>();
                                    M model = (M)relationshipRepo.ReaderMapper(reader, 1);
                                    listRelation.Add(model);
                                    previousId = id;
                                }
                                else
                                {
                                    M model = (M)relationshipRepo.ReaderMapper(reader, 1);
                                    listRelation.Add(model);
                                }
                            }
                            list.Add(listRelation);
                        }
                    }
                };

                //Console.WriteLine(list.Count());

                int i = 0;
                foreach (T model in listOfModel)
                {
                    model.GetType().GetProperty(relationshipRepo.TableName).SetValue(model, list[i++]);
                }

                return listOfModel;

            }
            catch (SqlException e)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!" + e.ToString(), "Error");
                return listOfModel;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return listOfModel;
            }

        }
        public int Add(T model)
        {
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    string sql = $"INSERT INTO {TableName}  output INSERTED.{PrimaryKey} VALUES {ColumnAddString}";
                                   
                    cmd.CommandText = sql;
                    
                    AddParameter(ref cmd, model);
                    //Console.WriteLine(sql.ToString());
                    int id = (int) cmd.ExecuteScalar();

                    return id;
                };

            }
            catch (SqlException e)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong! " + e.Message, "Error");
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.Message);
                return 0;
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
                   
                    string sql = $"UPDATE {TableName} SET {ColumnUpdateString} WHERE {PrimaryKey} = @{PrimaryKey}"; 

                    cmd.CommandText = sql;

                    AddParameter(ref cmd, model);

                    return cmd.ExecuteNonQuery();
                    
                };

            }
            catch (SqlException e)
            {
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!" + e.Message, "Error");
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
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    MessageBox.Show("Không thể xoá do liên kết với bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!" + e.Message, "Error");
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return 0;
            }
        }

        //WARNING: sql injection 
        public int Delete(int[] id)
        {
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    string sql = $"DELETE FROM {TableName} WHERE {PrimaryKey} IN ({string.Join(",", id)})";

                    cmd.CommandText = sql;

                    return cmd.ExecuteNonQuery();

                };

            }
            catch (SqlException e)
            {
                if(e.Number == 547)
                {
                    MessageBox.Show("Không thể xoá do liên kết với bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!" + e.Message, "Error");
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return 0;
            }
        }

        public int Delete(int[] id, string byColumn)
        {
            try
            {
                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    string sql = $"DELETE FROM {TableName} WHERE {byColumn} IN ({string.Join(",", id)})";

                    cmd.CommandText = sql;

                    return cmd.ExecuteNonQuery();

                };

            }
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    MessageBox.Show("Không thể xoá do liên kết với bảng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                MessageBox.Show(this.GetType().Name + ": Cannot connect to database or sql statement wrong!", "Error");
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something wrong in " + this.GetType().Name + ": " + e.ToString());
                return 0;
            }
        }

    }
}
