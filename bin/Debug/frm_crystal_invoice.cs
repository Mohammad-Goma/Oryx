﻿using System;
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
    public partial class frm_crystal_invoice : Form
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;

        public frm_crystal_invoice(string v1, string v2, string v3, string v4, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            InitializeComponent();
        }
    }
}
