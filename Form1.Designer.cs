
namespace NadeoImporter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.b_mat_add = new System.Windows.Forms.Button();
            this.b_mat_del = new System.Windows.Forms.Button();
            this.b_mat_edit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.b_folder = new System.Windows.Forms.Button();
            this.b_fbx = new System.Windows.Forms.Button();
            this.rb_mesh = new System.Windows.Forms.RadioButton();
            this.rb_item = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_clear_prop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.prop_snap = new System.Windows.Forms.TextBox();
            this.prop_rot = new System.Windows.Forms.CheckBox();
            this.prop_non = new System.Windows.Forms.CheckBox();
            this.prop_yaw = new System.Windows.Forms.CheckBox();
            this.prop_ghost = new System.Windows.Forms.CheckBox();
            this.prop_vert_offset = new System.Windows.Forms.TextBox();
            this.prop_vert_size = new System.Windows.Forms.TextBox();
            this.prop_hor_offset = new System.Windows.Forms.TextBox();
            this.prop_hor_size = new System.Windows.Forms.TextBox();
            this.prop_fly_offset = new System.Windows.Forms.TextBox();
            this.prop_fly_step = new System.Windows.Forms.TextBox();
            this.prop_pivot = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prop_author = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prop_scale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b_Import = new System.Windows.Forms.Button();
            this.b_openitems = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.b_filesonly = new System.Windows.Forms.Button();
            this.b_import_ready = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "FBX file to import";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(97, 58);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(247, 23);
            this.tb2.TabIndex = 1;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 27);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(456, 23);
            this.tb1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tb1, "Root trackmania folder in Documents");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "TM2020 folder (Documents)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "\\Work\\Items\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pivot Snap Distance";
            // 
            // tb3
            // 
            this.tb3.AllowDrop = true;
            this.tb3.Location = new System.Drawing.Point(12, 108);
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.Size = new System.Drawing.Size(456, 23);
            this.tb3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tb3, "Drag your file into this field or use \"Browse...\" button");
            this.tb3.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb3_DragDrop);
            this.tb3.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb3_DragEnter);
            // 
            // b_mat_add
            // 
            this.b_mat_add.Location = new System.Drawing.Point(269, 164);
            this.b_mat_add.Name = "b_mat_add";
            this.b_mat_add.Size = new System.Drawing.Size(59, 23);
            this.b_mat_add.TabIndex = 7;
            this.b_mat_add.Text = "Add";
            this.b_mat_add.UseVisualStyleBackColor = true;
            this.b_mat_add.Click += new System.EventHandler(this.b_mat_add_Click);
            // 
            // b_mat_del
            // 
            this.b_mat_del.Location = new System.Drawing.Point(269, 194);
            this.b_mat_del.Name = "b_mat_del";
            this.b_mat_del.Size = new System.Drawing.Size(59, 23);
            this.b_mat_del.TabIndex = 8;
            this.b_mat_del.Text = "Remove";
            this.b_mat_del.UseVisualStyleBackColor = true;
            this.b_mat_del.Click += new System.EventHandler(this.b_mat_del_Click);
            // 
            // b_mat_edit
            // 
            this.b_mat_edit.Location = new System.Drawing.Point(269, 224);
            this.b_mat_edit.Name = "b_mat_edit";
            this.b_mat_edit.Size = new System.Drawing.Size(59, 23);
            this.b_mat_edit.TabIndex = 9;
            this.b_mat_edit.Text = "Edit";
            this.b_mat_edit.UseVisualStyleBackColor = true;
            this.b_mat_edit.Click += new System.EventHandler(this.b_mat_edit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 199);
            this.listBox1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBox1, "Set up model materials using buttons on the right");
            // 
            // b_folder
            // 
            this.b_folder.Location = new System.Drawing.Point(474, 27);
            this.b_folder.Name = "b_folder";
            this.b_folder.Size = new System.Drawing.Size(75, 23);
            this.b_folder.TabIndex = 11;
            this.b_folder.Text = "Browse...";
            this.b_folder.UseVisualStyleBackColor = true;
            this.b_folder.Click += new System.EventHandler(this.b_folder_Click);
            // 
            // b_fbx
            // 
            this.b_fbx.Location = new System.Drawing.Point(474, 108);
            this.b_fbx.Name = "b_fbx";
            this.b_fbx.Size = new System.Drawing.Size(75, 23);
            this.b_fbx.TabIndex = 12;
            this.b_fbx.Text = "Browse...";
            this.b_fbx.UseVisualStyleBackColor = true;
            this.b_fbx.Click += new System.EventHandler(this.b_fbx_Click);
            // 
            // rb_mesh
            // 
            this.rb_mesh.AutoSize = true;
            this.rb_mesh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_mesh.Location = new System.Drawing.Point(9, 47);
            this.rb_mesh.Name = "rb_mesh";
            this.rb_mesh.Size = new System.Drawing.Size(54, 19);
            this.rb_mesh.TabIndex = 13;
            this.rb_mesh.Text = "Mesh";
            this.rb_mesh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rb_mesh, "Imports Mesh that can be imported as Crystal in meshmod");
            this.rb_mesh.UseVisualStyleBackColor = true;
            this.rb_mesh.Click += new System.EventHandler(this.rb_mesh_Click);
            // 
            // rb_item
            // 
            this.rb_item.AutoSize = true;
            this.rb_item.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_item.Checked = true;
            this.rb_item.Location = new System.Drawing.Point(14, 22);
            this.rb_item.Name = "rb_item";
            this.rb_item.Size = new System.Drawing.Size(49, 19);
            this.rb_item.TabIndex = 14;
            this.rb_item.TabStop = true;
            this.rb_item.Text = "Item";
            this.toolTip1.SetToolTip(this.rb_item, "Imports as ready-to-use Item that will not be editable in meshmod");
            this.rb_item.UseVisualStyleBackColor = true;
            this.rb_item.Click += new System.EventHandler(this.rb_item_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_clear_prop);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.prop_snap);
            this.groupBox1.Controls.Add(this.prop_rot);
            this.groupBox1.Controls.Add(this.prop_non);
            this.groupBox1.Controls.Add(this.prop_yaw);
            this.groupBox1.Controls.Add(this.prop_ghost);
            this.groupBox1.Controls.Add(this.prop_vert_offset);
            this.groupBox1.Controls.Add(this.prop_vert_size);
            this.groupBox1.Controls.Add(this.prop_hor_offset);
            this.groupBox1.Controls.Add(this.prop_hor_size);
            this.groupBox1.Controls.Add(this.prop_fly_offset);
            this.groupBox1.Controls.Add(this.prop_fly_step);
            this.groupBox1.Controls.Add(this.prop_pivot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(350, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 321);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Properties (optional)";
            // 
            // b_clear_prop
            // 
            this.b_clear_prop.Location = new System.Drawing.Point(16, 203);
            this.b_clear_prop.Name = "b_clear_prop";
            this.b_clear_prop.Size = new System.Drawing.Size(53, 43);
            this.b_clear_prop.TabIndex = 25;
            this.b_clear_prop.Text = "Clear";
            this.toolTip1.SetToolTip(this.b_clear_prop, "Clears all \"Item Properties\"");
            this.b_clear_prop.UseVisualStyleBackColor = true;
            this.b_clear_prop.Click += new System.EventHandler(this.b_clear_prop_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Offset";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Offset";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Offset";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Grid Vertical";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Grid Horizontal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fly Step";
            // 
            // prop_snap
            // 
            this.prop_snap.Location = new System.Drawing.Point(155, 288);
            this.prop_snap.Name = "prop_snap";
            this.prop_snap.Size = new System.Drawing.Size(31, 23);
            this.prop_snap.TabIndex = 21;
            this.prop_snap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prop_rot
            // 
            this.prop_rot.AutoSize = true;
            this.prop_rot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prop_rot.Location = new System.Drawing.Point(86, 259);
            this.prop_rot.Name = "prop_rot";
            this.prop_rot.Size = new System.Drawing.Size(100, 19);
            this.prop_rot.TabIndex = 20;
            this.prop_rot.Text = "Auto Rotation";
            this.prop_rot.UseVisualStyleBackColor = true;
            // 
            // prop_non
            // 
            this.prop_non.AutoSize = true;
            this.prop_non.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prop_non.Location = new System.Drawing.Point(83, 234);
            this.prop_non.Name = "prop_non";
            this.prop_non.Size = new System.Drawing.Size(103, 19);
            this.prop_non.TabIndex = 19;
            this.prop_non.Text = "Not On Object";
            this.prop_non.UseVisualStyleBackColor = true;
            // 
            // prop_yaw
            // 
            this.prop_yaw.AutoSize = true;
            this.prop_yaw.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prop_yaw.Location = new System.Drawing.Point(111, 209);
            this.prop_yaw.Name = "prop_yaw";
            this.prop_yaw.Size = new System.Drawing.Size(75, 19);
            this.prop_yaw.TabIndex = 18;
            this.prop_yaw.Text = "Yaw Only";
            this.prop_yaw.UseVisualStyleBackColor = true;
            // 
            // prop_ghost
            // 
            this.prop_ghost.AutoSize = true;
            this.prop_ghost.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prop_ghost.Location = new System.Drawing.Point(95, 184);
            this.prop_ghost.Name = "prop_ghost";
            this.prop_ghost.Size = new System.Drawing.Size(91, 19);
            this.prop_ghost.TabIndex = 17;
            this.prop_ghost.Text = "Ghost Mode";
            this.prop_ghost.UseVisualStyleBackColor = true;
            // 
            // prop_vert_offset
            // 
            this.prop_vert_offset.Location = new System.Drawing.Point(155, 147);
            this.prop_vert_offset.Name = "prop_vert_offset";
            this.prop_vert_offset.Size = new System.Drawing.Size(31, 23);
            this.prop_vert_offset.TabIndex = 16;
            this.prop_vert_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prop_vert_size
            // 
            this.prop_vert_size.Location = new System.Drawing.Point(70, 147);
            this.prop_vert_size.Name = "prop_vert_size";
            this.prop_vert_size.Size = new System.Drawing.Size(32, 23);
            this.prop_vert_size.TabIndex = 5;
            this.prop_vert_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prop_hor_offset
            // 
            this.prop_hor_offset.Location = new System.Drawing.Point(155, 97);
            this.prop_hor_offset.Name = "prop_hor_offset";
            this.prop_hor_offset.Size = new System.Drawing.Size(31, 23);
            this.prop_hor_offset.TabIndex = 4;
            this.prop_hor_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prop_hor_size
            // 
            this.prop_hor_size.Location = new System.Drawing.Point(70, 97);
            this.prop_hor_size.Name = "prop_hor_size";
            this.prop_hor_size.Size = new System.Drawing.Size(32, 23);
            this.prop_hor_size.TabIndex = 3;
            this.prop_hor_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prop_fly_offset
            // 
            this.prop_fly_offset.Location = new System.Drawing.Point(155, 47);
            this.prop_fly_offset.Name = "prop_fly_offset";
            this.prop_fly_offset.Size = new System.Drawing.Size(31, 23);
            this.prop_fly_offset.TabIndex = 2;
            this.prop_fly_offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prop_fly_step
            // 
            this.prop_fly_step.Location = new System.Drawing.Point(70, 47);
            this.prop_fly_step.Name = "prop_fly_step";
            this.prop_fly_step.Size = new System.Drawing.Size(32, 23);
            this.prop_fly_step.TabIndex = 1;
            this.prop_fly_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prop_pivot
            // 
            this.prop_pivot.AutoSize = true;
            this.prop_pivot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prop_pivot.Location = new System.Drawing.Point(43, 22);
            this.prop_pivot.Name = "prop_pivot";
            this.prop_pivot.Size = new System.Drawing.Size(143, 19);
            this.prop_pivot.TabIndex = 0;
            this.prop_pivot.Text = "Switch pivot manually";
            this.prop_pivot.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Materials";
            // 
            // prop_author
            // 
            this.prop_author.Location = new System.Drawing.Point(97, 369);
            this.prop_author.Name = "prop_author";
            this.prop_author.Size = new System.Drawing.Size(152, 23);
            this.prop_author.TabIndex = 17;
            this.prop_author.TextChanged += new System.EventHandler(this.prop_author_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 16;
            this.label15.Text = "Author Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_item);
            this.groupBox2.Controls.Add(this.rb_mesh);
            this.groupBox2.Location = new System.Drawing.Point(271, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(73, 79);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import As";
            // 
            // prop_scale
            // 
            this.prop_scale.Location = new System.Drawing.Point(299, 369);
            this.prop_scale.Name = "prop_scale";
            this.prop_scale.Size = new System.Drawing.Size(45, 23);
            this.prop_scale.TabIndex = 19;
            this.prop_scale.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Scale";
            // 
            // b_Import
            // 
            this.b_Import.Location = new System.Drawing.Point(12, 405);
            this.b_Import.Name = "b_Import";
            this.b_Import.Size = new System.Drawing.Size(66, 54);
            this.b_Import.TabIndex = 21;
            this.b_Import.Text = "Quick Import";
            this.toolTip1.SetToolTip(this.b_Import, "Creates all required files with your parameters and runs Importer ");
            this.b_Import.UseVisualStyleBackColor = true;
            this.b_Import.Click += new System.EventHandler(this.b_Import_Click);
            // 
            // b_openitems
            // 
            this.b_openitems.Location = new System.Drawing.Point(197, 405);
            this.b_openitems.Name = "b_openitems";
            this.b_openitems.Size = new System.Drawing.Size(66, 54);
            this.b_openitems.TabIndex = 22;
            this.b_openitems.Text = "Open Items Folder";
            this.toolTip1.SetToolTip(this.b_openitems, "Quick access to TM Item folder");
            this.b_openitems.UseVisualStyleBackColor = true;
            this.b_openitems.Click += new System.EventHandler(this.b_openitems_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(269, 405);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 23;
            this.b_save.Text = "Save";
            this.toolTip1.SetToolTip(this.b_save, "Save current config as...");
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_load
            // 
            this.b_load.Location = new System.Drawing.Point(269, 436);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(75, 23);
            this.b_load.TabIndex = 24;
            this.b_load.Text = "Load";
            this.toolTip1.SetToolTip(this.b_load, "Load config from file");
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // b_filesonly
            // 
            this.b_filesonly.Location = new System.Drawing.Point(84, 405);
            this.b_filesonly.Name = "b_filesonly";
            this.b_filesonly.Size = new System.Drawing.Size(107, 23);
            this.b_filesonly.TabIndex = 26;
            this.b_filesonly.Text = "Prepare Only";
            this.toolTip1.SetToolTip(this.b_filesonly, "Sets up all files with your parameters without running Importer process");
            this.b_filesonly.UseVisualStyleBackColor = true;
            this.b_filesonly.Click += new System.EventHandler(this.b_filesonly_Click);
            // 
            // b_import_ready
            // 
            this.b_import_ready.Location = new System.Drawing.Point(84, 436);
            this.b_import_ready.Name = "b_import_ready";
            this.b_import_ready.Size = new System.Drawing.Size(107, 23);
            this.b_import_ready.TabIndex = 27;
            this.b_import_ready.Text = "Importer Only";
            this.toolTip1.SetToolTip(this.b_import_ready, "No XML file creation — basically an interface for Importer");
            this.b_import_ready.UseVisualStyleBackColor = true;
            this.b_import_ready.Click += new System.EventHandler(this.b_import_ready_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(350, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Sub-folder (optional)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 477);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.b_import_ready);
            this.Controls.Add(this.b_filesonly);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_openitems);
            this.Controls.Add(this.b_Import);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prop_scale);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.prop_author);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.b_fbx);
            this.Controls.Add(this.b_folder);
            this.Controls.Add(this.b_mat_edit);
            this.Controls.Add(this.b_mat_del);
            this.Controls.Add(this.b_mat_add);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = global::NadeoImporter.Properties.Resources.arrows;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nadeo Importer Assistant (Eternal Alpha 0.2.1)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button b_mat_add;
        private System.Windows.Forms.Button b_mat_del;
        private System.Windows.Forms.Button b_mat_edit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b_folder;
        private System.Windows.Forms.Button b_fbx;
        private System.Windows.Forms.RadioButton rb_mesh;
        private System.Windows.Forms.RadioButton rb_item;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prop_snap;
        private System.Windows.Forms.CheckBox prop_rot;
        private System.Windows.Forms.CheckBox prop_non;
        private System.Windows.Forms.CheckBox prop_yaw;
        private System.Windows.Forms.CheckBox prop_ghost;
        private System.Windows.Forms.TextBox prop_vert_offset;
        private System.Windows.Forms.TextBox prop_vert_size;
        private System.Windows.Forms.TextBox prop_hor_offset;
        private System.Windows.Forms.TextBox prop_hor_size;
        private System.Windows.Forms.TextBox prop_fly_offset;
        private System.Windows.Forms.TextBox prop_fly_step;
        private System.Windows.Forms.CheckBox prop_pivot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prop_author;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox prop_scale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_Import;
        private System.Windows.Forms.Button b_openitems;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_clear_prop;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Button b_filesonly;
        private System.Windows.Forms.Button b_import_ready;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label16;
    }
}

