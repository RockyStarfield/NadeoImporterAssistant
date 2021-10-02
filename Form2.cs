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
                return new string[] { tbMat.Text, cb_link.Text, tbColor.Text };
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
            cb_link.DataSource = Nadeo.mat_lib;
            button_cancel.DialogResult = DialogResult.Cancel;

            if (mat.Length > 0)
            {
                button_add.Text = "Save";
                tbMat.Text = mat[0];
                cb_link.Text = mat[1];
                tbColor.Text = mat[2];
                this.Text = "Edit Material";
            }
        }



        private void button_add_Click(object sender, EventArgs e)
        {

            if (tbMat.Text == "")
            {
                Balloon.Show("Material must have a name", tbMat, 3000);
                return;
            }

            if (cb_link.Text == "")
            {
                Balloon.Show("Select material Link", cb_link, 3000);
                return;
            }


            this.DialogResult = DialogResult.OK;
            
        }
    }
}
