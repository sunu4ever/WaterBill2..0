using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WbLib.SQL
{
    public static class SqlUtility
    {
        public static string ConnectionString = Properties.Settings.Default.ConnectionString;
        #region Public methods
        /// <summary>
        /// Sql utility to execute stored procedure 
        /// </summary>
        /// <param name="spName">Name of the stored procedure</param>
        public static T ExecuteSP<T>(string spName)
        {
            if (typeof(T) == typeof(bool))
            {
                SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, spName);
                return (T)Convert.ChangeType(true, typeof(T));
            }
            else if (typeof(T) == typeof(DataTable))
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionString, CommandType.StoredProcedure, spName);
                if (ds.Tables[0].Rows.Count > 0)
                    return (T)Convert.ChangeType(ds.Tables[0], typeof(T));
                else
                    return (T)Convert.ChangeType(null, typeof(T));
            }
            return (T)Convert.ChangeType(false, typeof(T));
        }
        /// <summary>
        /// Sql utility to execute stored procedure 
        /// </summary>
        /// <param name="spName">Name of the stored procedure</param>
        /// <param name="param">List of parameters</param>
        public static T ExecuteSP<T>(string spName, SqlParameter[] param)
        {

            if (typeof(T) == typeof(bool))
            {
                SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, spName, param);
                return (T)Convert.ChangeType(true, typeof(T));
            }
            else if (typeof(T) == typeof(string) || typeof(T) == typeof(int))
            {
                bool hasOutPutParam = false;
                int outPutParamIndex = 0;
                int i = 0;
                foreach (SqlParameter p in param)
                {
                    if (p.Direction == ParameterDirection.Output)
                    {
                        hasOutPutParam = true;
                        outPutParamIndex = i;
                    }
                    i++;
                }
                SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, spName, param);
                if (hasOutPutParam)
                    return (T)Convert.ChangeType(param[outPutParamIndex].Value, typeof(T));
                else
                    return (T)Convert.ChangeType(true, typeof(T));
            }

            else if (typeof(T) == typeof(DataTable))
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionString, CommandType.StoredProcedure, spName, param);
                if (ds.Tables[0].Rows.Count > 0)
                    return (T)Convert.ChangeType(ds.Tables[0], typeof(T));
                else
                    return (T)Convert.ChangeType(null, typeof(T));
            }
            return (T)Convert.ChangeType(false, typeof(T));
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
