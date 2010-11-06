using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WMP
{
    public partial class URLInputForm : Form
    {
        public URLInputForm()
        {
            InitializeComponent();
        }
        public delegate void AddUrlEventHandler(object sender, string[] urls);
        public event AddUrlEventHandler AddUrl;
        protected override void OnResize(EventArgs e)
        {
            this.textBox1.Left = this.ClientSize.Width - this.textBox1.Width;
            this.textBox1.Top = this.ClientSize.Height - this.textBox1.Height;
            base.OnResize(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUrl.Invoke(this,
                this.textBox1.Text.Split(',', '\r', '\n')
                );
            this.textBox1.Text = null;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
            base.OnClosing(e);
        }
    }
}
