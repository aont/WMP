using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WMP
{
    public partial class PropertyForm : Form
    {
        public PropertyForm(object Object)
        {
            InitializeComponent();
            this.propertyGrid1.SelectedObject = Object;
            this.Text = Object.ToString();
        }
    }
}
