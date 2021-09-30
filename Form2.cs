using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NadeoImporter
{
    public partial class Form2 : Form
    {
        public string[] New_Mat
        {
            get 
            { 
                return new string[] { tbMat.Text, comboBox1.Text, tbColor.Text };
            }
        }

        private string[] mat; 

        public Form2(string[] edit_mat)
        {
            InitializeComponent();

            mat = edit_mat;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Nadeo.mat_lib;
            button_cancel.DialogResult = DialogResult.Cancel;

            if (mat.Length > 0)
            {
                button_add.Text = "Save";
                tbMat.Text = mat[0];
                comboBox1.Text = mat[1];
                tbColor.Text = mat[2];
                this.Text = "Edit Material";
            }
        }



        private void button_add_Click(object sender, EventArgs e)
        {
            if (tbMat.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                Program.Throw("Material must have a name", 2);
            }
        }
    }
}
