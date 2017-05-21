using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WbLib.Helpers;

namespace WbLib
{
    public class WbEnv
    {
        #region fields
        private static WbEnv _current;
        private static string spName = string.Empty;
        #endregion
        #region Environment
        public int envUserId { get; set; }
        public string envLoginName { get; set; }
        public string envUserName { get; set; }
        public int envRoleId { get; set; }
        public WBRole envRole { get; set; }
        public int envCenterId { get; set; }
        public string envCenterName { get; set; }
        public string envVersion { get; set; }
        public string envMachineName { get; set; }
        public DateTime envTodaysDate { get; set; }
        #endregion
             #region methods
        public WbEnv()
        {
            DataTable dt = Common.GetCurrentWb();
            if (dt != null & dt.Rows.Count > 0)
            {
                envCenterId = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                envCenterName = dt.Rows[0].ItemArray[1].ToString();
                envVersion = dt.Rows[0].ItemArray[5].ToString();
            }
            envMachineName = Environment.MachineName;
            envTodaysDate = CommonHelper.GetToday();
        }
        public static WbEnv Current
        {
            get
            {
                return _current ?? (_current = new WbEnv());
            }

        }

        #endregion
    }
    public enum WBRole
    {
        Admin = 1,
        Manager = 2,
        Employee = 3,
        DummyManager = 4,
        TaxUser = 5,
    }
}
