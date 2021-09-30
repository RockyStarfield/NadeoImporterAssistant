using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NadeoImporter
{
    public partial class Form3 : Form
    {
        private string tm_path, item_path, fbx_path;

        public Form3(string path)
        {
            InitializeComponent();

            tm_path = path;
            item_path = path + "\\Work\\Items";
            
        }

  

        private void b_fbx_Click(object sender, EventArgs e)
        {
            using (var filediag = new OpenFileDialog())
            {
                filediag.Filter = "FBX files|*.fbx";
                filediag.InitialDirectory = item_path;
                DialogResult result = filediag.ShowDialog();

                if (result == DialogResult.OK)
                {
                    fbx_path = filediag.FileName;
                    tb.Text = fbx_path;
                }
            }
        }

        private void tb3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files) tb.Text = file;

            }
        }

        private void rb_mesh_Click(object sender, EventArgs e)
        {
            rb_item.Checked = false;
        }

        private void rb_item_Click(object sender, EventArgs e)
        {
            rb_mesh.Checked = false;
        }

        private void b_run_Click(object sender, EventArgs e)
        {

            if (tb.Text == "")
            {
                Program.Throw("No file selected", 1);
                return;
            }

            if (!Program.FileExists(tb.Text))
            {
                Program.Throw("Couldn't find specified FBX file", 1);
                return;
            }

            string workfile = Program.GetWorkFile(tm_path, tb.Text, rb_item.Checked);
            Program.NadeoImporterRun(rb_item.Checked, workfile, cb_log.Checked);
        }

        private void tb3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
