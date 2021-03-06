using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadeoImporter
{
    public partial class Form1 : Form
    {
        private const string warning_FBX = "Select FBX file to import";
        private const string warning_TM = "Select your Trackmania folder";
        private const string warning_MATS = "Set up Materials of your item";

        List<string[]> mat_list = new List<string[]>();

  

        public Form1()
        {
            InitializeComponent();

            tb1.Text = Properties.Settings.Default.TM_FOLDER;
            prop_author.Text = Properties.Settings.Default.AUTHOR;
            tb2.Text = Properties.Settings.Default.SUB_FOLD;
            cb_clean.Checked = Properties.Settings.Default.CLEAN;

            this.Text += " (Eternal Alpha 0.3)";

            SetItemProps(Properties.Settings.Default.PROP_PIVOT,
                         Properties.Settings.Default.PROP_GHOST,
                         Properties.Settings.Default.PROP_YAW,
                         Properties.Settings.Default.PROP_NON,
                         Properties.Settings.Default.PROP_ROT,
                         Properties.Settings.Default.PROP_FS,
                         Properties.Settings.Default.PROP_FO,
                         Properties.Settings.Default.PROP_HS,
                         Properties.Settings.Default.PROP_HO,
                         Properties.Settings.Default.PROP_VS,
                         Properties.Settings.Default.PROP_VO,
                         Properties.Settings.Default.PROP_SNAP,
                         Properties.Settings.Default.PROP_SCALE);

        }


        public void SetItemProps(bool pivot, bool ghost, bool yaw, bool non, bool rot, string fly_s, string fly_off, string h_s, string h_off, string v_s, string v_off, string snap, string scale)
        {
            prop_pivot.Checked = pivot;
            prop_ghost.Checked = ghost;
            prop_yaw.Checked = yaw;
            prop_non.Checked = non;
            prop_rot.Checked = rot;
            prop_fly_step.Text = fly_s;
            prop_fly_offset.Text = fly_off;
            prop_hor_size.Text = h_s;
            prop_hor_offset.Text = h_off;
            prop_vert_size.Text = v_s;
            prop_vert_offset.Text = v_off;
            prop_snap.Text = snap;
            prop_scale.Text = scale;
        }

        public void RedrawList()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < mat_list.Count; i++)
            {
                string[] mat = mat_list[i];

                string entry = mat[0] + " | " + mat[1];

                if (mat[2] != "")
                {
                    entry = entry + " | " + mat[2];
                }

                listBox1.Items.Add(entry);
            }
        }

        public void ShowBalloon(string text, Control element)
        {
            Balloon.Show(text, element, 3000);
        }
           

        public string CreateXMLS(bool itemmode, bool ignore_warning)
        {
            string tm_path = tb1.Text;
            string subfold = tb2.Text;
            string fbx_path = tb3.Text;
            string scale = prop_scale.Text;


            string workfile = Program.CreateStructure(tm_path, subfold, fbx_path, ignore_warning);

            if (!(String.IsNullOrEmpty(workfile)))
            {

                string path = tm_path + "\\Work\\Items\\";

                if (subfold != "")
                {
                    path = path + subfold + "\\";
                }

                Program.CreateMeshParams(path, fbx_path, scale, mat_list);

                if (itemmode)
                {
                    bool[] checkmarks = new bool[] {prop_pivot.Checked,
                                                    prop_ghost.Checked,
                                                    prop_yaw.Checked,
                                                    prop_non.Checked,
                                                    prop_rot.Checked};

                    string[] values = new string[] { prop_fly_step.Text,
                                                     prop_fly_offset.Text,
                                                     prop_hor_size.Text,
                                                     prop_hor_offset.Text,
                                                     prop_vert_size.Text,
                                                     prop_vert_offset.Text,
                                                     prop_snap.Text,
                                                     prop_author.Text};

                    Program.CreateItemParams(checkmarks, values, path, fbx_path);
                }
                return workfile;
            }
            else return null;
        }

        private void b_folder_Click(object sender, EventArgs e)
        {
            using (var folderdiag = new FolderBrowserDialog())
            {
                DialogResult result = folderdiag.ShowDialog();

                if (result == DialogResult.OK)
                {
                    tb1.Text = folderdiag.SelectedPath;
                    Properties.Settings.Default.TM_FOLDER = folderdiag.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }


        }

        private void b_subfold_Click(object sender, EventArgs e)
        {
            string tm_path = tb1.Text;
            string tm_itempath = tm_path + "\\Items\\";

            using (var folderdiag = new FolderBrowserDialog())
            {
                folderdiag.SelectedPath = tm_itempath;
                DialogResult result = folderdiag.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string short_path = "";

                    if (!folderdiag.SelectedPath.Contains(tm_path + "\\Items"))
                    {
                        Program.Throw("Sub-folder must be inside Trackmania\\Items folder", 1);
                        return;
                    }

                    if (folderdiag.SelectedPath != (tm_path + "\\Items"))
                    {
                       short_path = (folderdiag.SelectedPath).Replace(tm_itempath, "");
                    }

                    tb2.Text = short_path;
                    Properties.Settings.Default.SUB_FOLD = short_path;
                    Properties.Settings.Default.Save();

                }
            }

        }


        private void b_mat_add_Click(object sender, EventArgs e)
        {

            using (Form2 mat_select = new Form2(new string[] { }))
            {
                mat_select.StartPosition = FormStartPosition.CenterParent;

                if (mat_select.ShowDialog() == DialogResult.OK)
                {
                    mat_list.Add(mat_select.New_Mat);
                }
            }

            RedrawList();
        }

        private void b_mat_del_Click(object sender, EventArgs e)
        {

            int sel = listBox1.SelectedIndex;

            if (sel >= 0)
            {    
                mat_list.RemoveAt(sel);
            }

            RedrawList();

            if (mat_list.ElementAtOrDefault(sel) != null)
            {
                listBox1.SetSelected(sel, true);
            }
            else
            {
                if (sel > 0)
                {
                    listBox1.SetSelected(sel - 1, true);
                }
            }

        }

        private void b_mat_edit_Click(object sender, EventArgs e)
        {
            int sel = listBox1.SelectedIndex;
            if (sel >= 0)           
            {
                using (Form2 mat_select = new Form2(mat_list[sel]))
                {

                    mat_select.StartPosition = FormStartPosition.CenterParent;

                    if (mat_select.ShowDialog() == DialogResult.OK)
                    {
                        mat_list[sel] = mat_select.New_Mat;
                    }
                }
            }

            RedrawList();
        }

        private void b_import_ready_Click(object sender, EventArgs e)
        {

            string tm_path = tb1.Text;

            if (tm_path == "")
            {
                ShowBalloon(warning_TM, tb1);
                return;
            }

            using (Form3 importer = new Form3(tm_path))
            {
                importer.StartPosition = FormStartPosition.CenterParent;
                importer.ShowDialog();
            }

        }

        private void b_fbx_Click(object sender, EventArgs e)
        {
            using (var filediag = new OpenFileDialog())
            {
                filediag.Filter = "FBX files|*.fbx";
                DialogResult result = filediag.ShowDialog();

                if (result == DialogResult.OK)
                {
                    tb3.Text = filediag.FileName;
                }
            }

        }

        private void rb_mesh_Click(object sender, EventArgs e)
        {
            rb_item.Checked = false;
            groupBox1.Enabled = false;
        }

        private void rb_item_Click(object sender, EventArgs e)
        {
            rb_mesh.Checked = false;
            groupBox1.Enabled = true;
        }


        private void b_Import_Click(object sender, EventArgs e)
        {

            string tm_path = tb1.Text;
            string subfold = tb2.Text;
            string fbx_path = tb3.Text;
            bool itemmode = rb_item.Checked;
            bool clean = cb_clean.Checked;
            bool ignore_warning = false;

            if (tm_path == "")
            {
                ShowBalloon(warning_TM, tb1);
                return;
            }

            if (fbx_path == "")
            {
                ShowBalloon(warning_FBX, tb3);
                return;
            }

            if (mat_list.Count == 0)
            {
                ShowBalloon(warning_MATS, listBox1);
                return;
            }

            if (prop_scale.Text == "")
            {
                 prop_scale.Text = "1";
            }

            string gbxname = Program.ImportedAlreadyExists(tm_path, subfold, fbx_path, itemmode);

            if (!string.IsNullOrEmpty(gbxname))
            {
                DialogResult result = MessageBox.Show("\"" + gbxname + "\" already exists in Items\\" + subfold + "\nRunning Importer will overwrite that file. Continue?", "Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ignore_warning = true;
                }
                else return;
            }

            string  workfile = CreateXMLS(itemmode, ignore_warning);



            if (!string.IsNullOrEmpty(workfile))
            {
                Program.NadeoImporterRun(itemmode, Program.GetWorkFileShort(tm_path, workfile, itemmode), false);

                if (clean)
                {
                    Program.CleanUp(workfile, tm_path);
                }
            }
        }

        private void tb3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files) tb3.Text = file;

            }
        }


        private void tb3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


        private void b_clear_prop_Click(object sender, EventArgs e)
        {
            SetItemProps(false, false, false, false, false, "", "", "", "", "", "", "", prop_scale.Text);
        }

        private void b_filesonly_Click(object sender, EventArgs e)
        {
            string tm_path = tb1.Text;
            string fbx_path = tb3.Text;
            bool item_mode = rb_item.Checked;

            if (tm_path == "")
            {
                ShowBalloon(warning_TM, tb1);
                return;
            }

            if (fbx_path == "")
            {
                ShowBalloon(warning_FBX, tb3);
                return;
            }

            string workfile = CreateXMLS(item_mode, false);

            Program.Throw("Copied FBX and created XMLs\n" + workfile.Replace(tm_path, "") + "\n\nIf you want to Import that Item later use \n\"Importer Only\" option", 2);
        }



        private void b_save_Click(object sender, EventArgs e)
        {
            string[] props = new string[] { prop_fly_step.Text,
                                            prop_fly_offset.Text,
                                            prop_hor_size.Text,
                                            prop_hor_offset.Text,
                                            prop_vert_size.Text,
                                            prop_vert_offset.Text,
                                            prop_snap.Text,
                                            prop_scale.Text
                                          };

            bool[] props_b = new bool[] {prop_pivot.Checked,
                                         prop_ghost.Checked,
                                         prop_yaw.Checked,
                                         prop_non.Checked,
                                         prop_rot.Checked
                                        };

            Program.SavePreset(mat_list, props, props_b);
        }

        public static bool b(string t)
        {
            return (t == "1");
        } 

        private void b_load_Click(object sender, EventArgs e)
        {
            using (var filediag = new OpenFileDialog())
            {
                filediag.Filter = "Importer Presets|*.preset";
                DialogResult result = filediag.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string path = filediag.FileName;
                    List<string[]> templist;
                    List<string> tp;

                    if ((templist = Program.LoadPresetMat(path)) != null)
                    {
                        mat_list = templist;
                        RedrawList();
                    }

                    if ((tp = Program.LoadPresetProps(path)) != null)
                    {
                        SetItemProps(b(tp[0]), b(tp[1]), b(tp[2]), b(tp[3]), b(tp[4]), tp[5], tp[6], tp[7], tp[8], tp[9], tp[10], tp[11], tp[12]);
                    }
                }
            }
        }


        private void b_openitems_Click(object sender, EventArgs e)
        {
            Program.OpenExp(tb1.Text + "\\Items");
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Properties.Settings.Default.CLEAN = cb_clean.Checked;
            Properties.Settings.Default.SUB_FOLD = tb2.Text;

            Properties.Settings.Default.AUTHOR = prop_author.Text;

            Properties.Settings.Default.PROP_PIVOT = prop_pivot.Checked;
            Properties.Settings.Default.PROP_GHOST = prop_ghost.Checked;
            Properties.Settings.Default.PROP_YAW = prop_yaw.Checked;
            Properties.Settings.Default.PROP_NON = prop_non.Checked;
            Properties.Settings.Default.PROP_ROT = prop_rot.Checked;
            Properties.Settings.Default.PROP_FS = prop_fly_step.Text;
            Properties.Settings.Default.PROP_FO = prop_fly_offset.Text;
            Properties.Settings.Default.PROP_HS = prop_hor_size.Text;
            Properties.Settings.Default.PROP_HO = prop_hor_offset.Text;
            Properties.Settings.Default.PROP_VS = prop_vert_size.Text;
            Properties.Settings.Default.PROP_VO = prop_vert_offset.Text;
            Properties.Settings.Default.PROP_SNAP = prop_snap.Text;
            Properties.Settings.Default.PROP_SCALE = prop_scale.Text;

            Properties.Settings.Default.Save();  

        }
    }
}
