using AppConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWinform
{
    public partial class AplicationRoot : Form
    {
        protected ConfigurationMgr instance;
        public AplicationRoot()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                instance = ConfigurationMgr.Instance;
            }
        }
    }
}
