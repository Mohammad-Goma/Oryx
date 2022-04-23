using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oryx
{
    public partial class frm_Report_Store : Form
    {
        private string v1;
        private string v2;
        private string v3;


        public frm_Report_Store(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            InitializeComponent();
        }
    }
}
