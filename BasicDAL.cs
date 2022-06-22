using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using Wisej.Web;


namespace crud_wisej_prototipe
{
    public class BasicDAL : IDisposable
    {
        private readonly string connectionstring;

        public BasicDAL(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public MySqlConnection Connection()
        {
            MySqlConnection cnn = new MySqlConnection(connectionstring + ";convert zero datetime=True");
            cnn.Open();
            return cnn;
        }

        public DataSet FILL(string ComandoSQL)
        {
            try
            {
                using (var cnn = Connection())
                {
                    MySqlDataAdapter DA = new MySqlDataAdapter(ComandoSQL, cnn);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    return DS;
                }
            }
            catch
            {
                return new DataSet();
            }
        }

        public T First<T>(string ComandoSQL)
        {
            try
            {
                using (var cnn = Connection())
                {
                    MySqlDataAdapter DA = new MySqlDataAdapter(ComandoSQL, cnn);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        var ret = Activator.CreateInstance<T>();
                        foreach (DataColumn col in DS.Tables[0].Columns)
                        {
                            if (DS.Tables[0].Rows[0][col.ColumnName].GetType().Name != typeof(DBNull).Name)
                            {
                                try
                                {
                                    PropertyInfo prpinfo = ret.GetType().GetProperty(col.ColumnName);
                                    if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                                    {
                                        if ((UInt64)DS.Tables[0].Rows[0][col.ColumnName] == (UInt64)1)
                                        {
                                            prpinfo.SetValue(ret, true);
                                        }
                                        else
                                        {
                                            prpinfo.SetValue(ret, false);
                                        }
                                    }
                                    else if (prpinfo.PropertyType.Name == "DateTime")
                                    {
                                        prpinfo.SetValue(ret, Convert.ToDateTime(DS.Tables[0].Rows[0][col.ColumnName]));
                                    }
                                    else
                                    {
                                        prpinfo.SetValue(ret, DS.Tables[0].Rows[0][col.ColumnName]);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    var err = ex.ToString();
                                }
                            }
                        }

                        return ret;
                    }
                    else
                    {
                        return (T)Convert.ChangeType(null, typeof(T));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }

        public T Last<T>(string ComandoSQL)
        {
            try
            {
                using (var cnn = Connection())
                {
                    MySqlDataAdapter DA = new MySqlDataAdapter(ComandoSQL, cnn);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        int idx = DS.Tables[0].Rows.Count - 1;
                        var ret = Activator.CreateInstance<T>();
                        foreach (DataColumn col in DS.Tables[0].Columns)
                        {
                            try
                            {
                                PropertyInfo prpinfo = ret.GetType().GetProperty(col.ColumnName);
                                if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                                {
                                    if ((UInt64)DS.Tables[0].Rows[idx][col.ColumnName] == (UInt64)1)
                                    {
                                        prpinfo.SetValue(ret, true);
                                    }
                                    else
                                    {
                                        prpinfo.SetValue(ret, false);
                                    }
                                }
                                else
                                {
                                    prpinfo.SetValue(ret, DS.Tables[0].Rows[idx][col.ColumnName]);
                                }
                            }
                            catch (Exception ex)
                            {
                                var err = ex.ToString();
                            }
                        }
                        return ret;
                    }
                    else
                    {
                        return (T)Convert.ChangeType(null, typeof(T));
                    }
                }
            }
            catch
            {
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }

        public List<T> List<T>(string ComandoSQL, List<T> lista = null)
        {
            try
            {
                DataSet DS = new DataSet();
                using (var cnn = Connection())
                {

                    new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999; SET character_set_results = 'utf8'", cnn).ExecuteNonQuery();

                    MySqlDataAdapter DA = new MySqlDataAdapter(ComandoSQL, cnn);
                    DA.SelectCommand.CommandTimeout = 99999;

                    DS.Tables.Add("Dados");
                    DS.EnforceConstraints = false;
                    DS.Tables["Dados"].BeginLoadData();
                    DA.Fill(DS.Tables["Dados"]);
                    DS.Tables["Dados"].EndLoadData();

                    cnn.Close();
                    cnn.Dispose();
                }

                if (DS.Tables[0].Rows.Count > 0)
                {
                    if (lista == null)
                    {
                        lista = new List<T>();
                    }

                    foreach (DataRow linha in DS.Tables[0].Rows)
                    {
                        if (typeof(T) == typeof(string) || typeof(T) == typeof(Guid) || typeof(T) == typeof(long))
                        {
                            if (linha[0].GetType() != typeof(System.DBNull))
                            {
                                lista.Add((T)linha[0]);
                            }
                        }
                        else
                        {
                            var item = Activator.CreateInstance<T>();
                            foreach (DataColumn col in DS.Tables[0].Columns)
                            {
                                try
                                {
                                    if (linha[col.ColumnName].GetType() != typeof(System.DBNull))
                                    {
                                        PropertyInfo prpinfo = item.GetType().GetProperty(col.ColumnName);
                                        if (prpinfo != null)
                                            if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                                                if (linha[col.ColumnName].GetType() != typeof(System.DBNull))
                                                    try
                                                    {
                                                        if ((UInt64)linha[col.ColumnName] == (UInt64)1)
                                                            prpinfo.SetValue(item, true);
                                                        else
                                                            prpinfo.SetValue(item, false);
                                                    }
                                                    catch
                                                    {
                                                        prpinfo.SetValue(item, linha[col.ColumnName]);
                                                    }

                                                else
                                                    prpinfo.SetValue(item, false);
                                            else
                                                prpinfo.SetValue(item, linha[col.ColumnName]);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    var err = ex.ToString();
                                }


                            }
                            lista.Add(item);

                        }
                    }

                    return lista;
                }
                else
                    return new List<T>();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return new List<T>();

            }
        }


        public List<T> GetList<T>(string ComandoSQL, List<T> lista = null)
        {
            try
            {
                DataSet DS = new DataSet();

                using (var cnn = Connection())
                {

                    new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999", cnn).ExecuteNonQuery();


                    MySqlDataAdapter DA = new MySqlDataAdapter(ComandoSQL, cnn);
                    DA.SelectCommand.CommandTimeout = 99999;

                    DS.Tables.Add("Dados");
                    DS.EnforceConstraints = false;

                    DS.Tables["Dados"].BeginLoadData();
                    DA.Fill(DS.Tables["Dados"]);
                    DS.Tables["Dados"].EndLoadData();

                    cnn.Close();
                    cnn.Dispose();
                }

                if (DS.Tables[0].Rows.Count > 0)
                {


                    return lista;
                }
                else
                    return new List<T>();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return new List<T>();

            }
        }


        public List<T> ListDR<T>(string ComandoSQL)
        {
            try
            {
                using (var cnn = Connection())
                {
                    //MySqlDataAdapter DA = new MySqlDataAdapter(ComandoSQL, cnn);
                    //DataSet DS = new DataSet();

                    //DA.Fill(DS);
                    MySqlDataReader dr = new MySqlCommand(ComandoSQL, cnn).ExecuteReader(CommandBehavior.CloseConnection);

                    var ret = new List<T>();
                    //foreach (DataRow linha in DS.Tables[0].Rows)
                    var columns = Enumerable.Range(0, dr.FieldCount).Select(dr.GetName).ToList();

                    while (dr.Read())
                    {
                        var item = Activator.CreateInstance<T>();
                        int idxCol = 0;
                        foreach (string col in columns)
                        {
                            try
                            {
                                PropertyInfo prpinfo = item.GetType().GetProperty(col);
                                if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                                {
                                    prpinfo.SetValue(item, dr.GetBoolean(col));
                                }
                                else
                                {
                                    prpinfo.SetValue(item, dr.GetValue(idxCol));
                                }
                            }
                            catch (Exception ex)
                            {
                                var err = ex.ToString();
                            }
                            idxCol++;
                        }
                        ret.Add(item);
                    }
                    dr.Close();
                    cnn.Close();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return new List<T>();
            }
        }
        public DataTable ExecuteSQL(string ComandoSQL)
        {
            using (var cnn = Connection())
            {
                MySqlDataAdapter DA = new MySqlDataAdapter(ComandoSQL, cnn);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                return DS.Tables[0];
            }
        }

        public int Execute(string ComandoSQL)
        {
            try
            {
                using (var cnn = Connection())
                {
                    new MySqlCommand("set net_write_timeout=99999; set net_read_timeout=99999", cnn).ExecuteNonQuery();
                    MySqlCommand DA = new MySqlCommand(ComandoSQL, cnn)
                    {
                        CommandTimeout = 0
                    };
                    return DA.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public object ExecuteScalar(string ComandoSQL)
        {
            using (var cnn = Connection())
            {
                MySqlCommand DA = new MySqlCommand(ComandoSQL, cnn);
                return DA.ExecuteScalar();
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~BasicDAL()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    public class SqlBasicDAL : IDisposable
    {
        private readonly string connectionstring;

        public SqlBasicDAL(SqlConnection cnn)
        {
            this.cnn = cnn;
        }


        public DataSet FILL(string ComandoSQL)
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(ComandoSQL, cnn);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                return DS;
            }
            catch
            {
                return new DataSet();
            }
        }

        public T First<T>(string ComandoSQL)
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(ComandoSQL, cnn);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    var ret = Activator.CreateInstance<T>();
                    foreach (DataColumn col in DS.Tables[0].Columns)
                    {
                        if (DS.Tables[0].Rows[0][col.ColumnName].GetType().Name != typeof(DBNull).Name)
                        {
                            try
                            {
                                PropertyInfo prpinfo = ret.GetType().GetProperty(col.ColumnName);
                                if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                                {
                                    if ((UInt64)DS.Tables[0].Rows[0][col.ColumnName] == (UInt64)1)
                                    {
                                        prpinfo.SetValue(ret, true);
                                    }
                                    else
                                    {
                                        prpinfo.SetValue(ret, false);
                                    }
                                }
                                else if (prpinfo.PropertyType.Name == "DateTime")
                                {
                                    prpinfo.SetValue(ret, Convert.ToDateTime(DS.Tables[0].Rows[0][col.ColumnName]));
                                }
                                else
                                {
                                    prpinfo.SetValue(ret, DS.Tables[0].Rows[0][col.ColumnName]);
                                }
                            }
                            catch (Exception ex)
                            {
                                var err = ex.ToString();
                            }
                        }
                    }

                    return ret;
                }
                else
                {
                    return (T)Convert.ChangeType(null, typeof(T));
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }

        public T Last<T>(string ComandoSQL)
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter(ComandoSQL, cnn);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    int idx = DS.Tables[0].Rows.Count - 1;
                    var ret = Activator.CreateInstance<T>();
                    foreach (DataColumn col in DS.Tables[0].Columns)
                    {
                        try
                        {
                            PropertyInfo prpinfo = ret.GetType().GetProperty(col.ColumnName);
                            if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                            {
                                if ((UInt64)DS.Tables[0].Rows[idx][col.ColumnName] == (UInt64)1)
                                {
                                    prpinfo.SetValue(ret, true);
                                }
                                else
                                {
                                    prpinfo.SetValue(ret, false);
                                }
                            }
                            else
                            {
                                prpinfo.SetValue(ret, DS.Tables[0].Rows[idx][col.ColumnName]);
                            }
                        }
                        catch (Exception ex)
                        {
                            var err = ex.ToString();
                        }
                    }

                    return ret;
                }
                else
                {
                    return (T)Convert.ChangeType(null, typeof(T));
                }
            }
            catch
            {
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }

        public List<T> List<T>(string ComandoSQL, List<T> lista = null)
        {
            try
            {
                DataSet DS = new DataSet();
                {
                    SqlDataAdapter DA = new SqlDataAdapter(ComandoSQL, cnn);
                    DA.SelectCommand.CommandTimeout = 99999;

                    DS.Tables.Add("Dados");
                    DS.EnforceConstraints = false;
                    DS.Tables["Dados"].BeginLoadData();
                    DA.Fill(DS.Tables["Dados"]);
                    DS.Tables["Dados"].EndLoadData();

                    cnn.Close();
                    cnn.Dispose();
                }

                if (DS.Tables[0].Rows.Count > 0)
                {
                    if (lista == null)
                    {
                        lista = new List<T>();
                    }

                    foreach (DataRow linha in DS.Tables[0].Rows)
                    {
                        if (typeof(T) == typeof(string) || typeof(T) == typeof(Guid))
                        {
                            if (linha[0].GetType() != typeof(System.DBNull))
                                lista.Add((T)linha[0]);
                        }
                        else
                        {
                            var item = Activator.CreateInstance<T>();
                            foreach (DataColumn col in DS.Tables[0].Columns)
                            {
                                try
                                {
                                    if (linha[col.ColumnName].GetType() != typeof(System.DBNull))
                                    {
                                        PropertyInfo prpinfo = item.GetType().GetProperty(col.ColumnName);
                                        if (prpinfo != null)
                                        {
                                            if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                                            {
                                                if (linha[col.ColumnName].GetType() != typeof(System.DBNull))
                                                {
                                                    try
                                                    {
                                                        if ((UInt64)linha[col.ColumnName] == (UInt64)1)
                                                        {
                                                            prpinfo.SetValue(item, true);
                                                        }
                                                        else
                                                        {
                                                            prpinfo.SetValue(item, false);
                                                        }
                                                    }
                                                    catch
                                                    {
                                                        prpinfo.SetValue(item, linha[col.ColumnName]);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                prpinfo.SetValue(item, false);
                                            }
                                        }
                                        else
                                        {
                                            prpinfo.SetValue(item, linha[col.ColumnName]);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    var err = ex.ToString();
                                }
                            }
                            lista.Add(item);
                        }
                    }
                    return lista;
                }
                else
                {
                    return new List<T>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return new List<T>();
            }
        }


        public List<T> GetList<T>(string ComandoSQL, List<T> lista = null)
        {
            try
            {
                DataSet DS = new DataSet();
                {
                    SqlDataAdapter DA = new SqlDataAdapter(ComandoSQL, cnn);
                    DA.SelectCommand.CommandTimeout = 99999;

                    DS.Tables.Add("Dados");
                    DS.EnforceConstraints = false;

                    DS.Tables["Dados"].BeginLoadData();
                    DA.Fill(DS.Tables["Dados"]);
                    DS.Tables["Dados"].EndLoadData();

                    cnn.Close();
                    cnn.Dispose();
                }

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return lista;
                }
                else
                {
                    return new List<T>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return new List<T>();
            }
        }


        public List<T> ListDR<T>(string ComandoSQL)
        {
            try
            {
                {
                    SqlDataReader dr = new SqlCommand(ComandoSQL, cnn).ExecuteReader(CommandBehavior.CloseConnection);

                    var ret = new List<T>();
                    //foreach (DataRow linha in DS.Tables[0].Rows)
                    var columns = Enumerable.Range(0, dr.FieldCount).Select(dr.GetName).ToList();

                    while (dr.Read())
                    {
                        var item = Activator.CreateInstance<T>();
                        int idxCol = 0;
                        foreach (string col in columns)
                        {
                            try
                            {
                                PropertyInfo prpinfo = item.GetType().GetProperty(col);
                                if (prpinfo.PropertyType.Name == "Boolean" || prpinfo.PropertyType.Name == "Nullable`1")
                                {
                                    prpinfo.SetValue(item, dr.GetBoolean(idxCol));
                                }
                                else
                                    prpinfo.SetValue(item, dr.GetValue(idxCol));
                            }
                            catch (Exception ex)
                            {
                                var err = ex.ToString();
                            }
                            idxCol++;
                        }
                        ret.Add(item);
                    }
                    dr.Close();
                    cnn.Close();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return new List<T>();
            }
        }
        public DataTable ExecuteSQL(string ComandoSQL)
        {
            {
                SqlDataAdapter DA = new SqlDataAdapter(ComandoSQL, cnn);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                return DS.Tables[0];
            }
        }

        public int Execute(string ComandoSQL)
        {
            try
            {
                {
                    SqlCommand DA = new SqlCommand(ComandoSQL, cnn)
                    {
                        CommandTimeout = 0
                    };
                    return DA.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ComandoSQL);
                throw ex;
            }
        }

        public object ExecuteScalar(string ComandoSQL)
        {
            {
                SqlCommand DA = new SqlCommand(ComandoSQL, cnn);
                return DA.ExecuteScalar();
            }
        }

        #region IDisposable Support
        private bool disposedValue = false;
        private SqlConnection cnn;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}