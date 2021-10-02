
namespace NadeoImporter
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b_fbx = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_item = new System.Windows.Forms.RadioButton();
            this.rb_mesh = new System.Windows.Forms.RadioButton();
            this.b_run = new System.Windows.Forms.Button();
            this.cb_log = new System.Windows.Forms.CheckBox();
            this.Balloon = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_fbx
            // 
            this.b_fbx.Location = new System.Drawing.Point(571, 27);
            this.b_fbx.Name = "b_fbx";
            this.b_fbx.Size = new System.Drawing.Size(75, 23);
            this.b_fbx.TabIndex = 15;
            this.b_fbx.Text = "Browse...";
            this.b_fbx.UseVisualStyleBackColor = true;
            this.b_fbx.Click += new System.EventHandler(this.b_fbx_Click);
            // 
            // tb
            // 
            this.tb.AllowDrop = true;
            this.tb.Location = new System.Drawing.Point(12, 27);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(553, 23);
            this.tb.TabIndex = 14;
            this.tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb3_DragDrop);
            this.tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb3_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select FBX from Work folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_item);
            this.groupBox2.Controls.Add(this.rb_mesh);
            this.groupBox2.Location = new System.Drawing.Point(12, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 55);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import As";
            // 
            // rb_item
            // 
            this.rb_item.AutoSize = true;
            this.rb_item.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_item.Checked = true;
            this.rb_item.Location = new System.Drawing.Point(6, 23);
            this.rb_item.Name = "rb_item";
            this.rb_item.Size = new System.Drawing.Size(49, 19);
            this.rb_item.TabIndex = 14;
            this.rb_item.TabStop = true;
            this.rb_item.Text = "Item";
            this.rb_item.UseVisualStyleBackColor = true;
            this.rb_item.Click += new System.EventHandler(this.rb_item_Click);
            // 
            // rb_mesh
            // 
            this.rb_mesh.AutoSize = true;
            this.rb_mesh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_mesh.Location = new System.Drawing.Point(71, 23);
            this.rb_mesh.Name = "rb_mesh";
            this.rb_mesh.Size = new System.Drawing.Size(54, 19);
            this.rb_mesh.TabIndex = 13;
            this.rb_mesh.Text = "Mesh";
            this.rb_mesh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_mesh.UseVisualStyleBackColor = true;
            this.rb_mesh.Click += new System.EventHandler(this.rb_mesh_Click);
            // 
            // b_run
            // 
            this.b_run.Location = new System.Drawing.Point(170, 66);
            this.b_run.Name = "b_run";
            this.b_run.Size = new System.Drawing.Size(75, 42);
            this.b_run.TabIndex = 20;
            this.b_run.Text = "Run";
            this.b_run.UseVisualStyleBackColor = true;
            this.b_run.Click += new System.EventHandler(this.b_run_Click);
            // 
            // cb_log
            // 
            this.cb_log.AutoSize = true;
            this.cb_log.Location = new System.Drawing.Point(264, 79);
            this.cb_log.Name = "cb_log";
            this.cb_log.Size = new System.Drawing.Size(106, 19);
            this.cb_log.TabIndex = 21;
            this.cb_log.Text = "Log Mesh Stats";
            this.cb_log.UseVisualStyleBackColor = true;
            // 
            // Balloon
            // 
            this.Balloon.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Balloon.ToolTipTitle = "Reminder";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 124);
            this.Controls.Add(this.cb_log);
            this.Controls.Add(this.b_run);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_fbx);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Nadeo Importer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_fbx;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_item;
        private System.Windows.Forms.RadioButton rb_mesh;
        private System.Windows.Forms.Button b_run;
        private System.Windows.Forms.CheckBox cb_log;
        private System.Windows.Forms.ToolTip Balloon;
    }
}