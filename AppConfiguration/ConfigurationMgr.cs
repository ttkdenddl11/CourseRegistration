using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfiguration
{
    public class ConfigurationMgr
    {
        private static ConfigurationMgr instance;

        private IDbConnection connection;
        public string ConnectionString { get; set; }

        public IDbConnection Connection 
        {
            get
            {
                try
                {
                    if (connection == null)
                    connection = new SqlConnection(ConnectionString);
                
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return connection;
            }
            private set
            {
            }
        }

        private ConfigurationMgr()
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                LoadConfiguration();
            }
        }

        private void LoadConfiguration()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionString = config.ConnectionStrings.ConnectionStrings["WinConnection"].ConnectionString;
        }

        public static ConfigurationMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationMgr();
                }
                return instance;
            }
        }
    }
}
