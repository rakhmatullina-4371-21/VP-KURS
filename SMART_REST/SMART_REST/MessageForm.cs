﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_REST
{
    public partial class MessageForm : Form
    {
        public MessageForm( string message)
        {
            InitializeComponent();
            label1.Text = message;
        }
        public MessageForm()
        {
            InitializeComponent();
        }
        private void save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
