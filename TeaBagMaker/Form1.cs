using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class TeaBagMaker : Form
    {
        string[] SList = new string[]{"홍차","녹차","루이보스차","국화차"};
        string orgStr = "";
        public TeaBagMaker()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++) {
                this.tea.Items.Add(SList[i]);
            }
            this.orgStr = 
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
