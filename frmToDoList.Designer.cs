namespace WindowsFormsApp2
{
    partial class frmToDoList
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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CSListView = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.CSTdelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CSTcomplete = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbDeadline = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.CSTaskName = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnCompleteTasks = new System.Windows.Forms.Button();
            this.CSListView.SuspendLayout();
            this.CSTaskName.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.Sienna;
            this.ListView1.BackgroundImageTiled = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clDeadline});
            this.ListView1.ContextMenuStrip = this.CSListView;
            this.ListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(9, 61);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListView1.Size = new System.Drawing.Size(339, 199);
            this.ListView1.TabIndex = 14;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task Name";
            this.columnHeader1.Width = 220;
            // 
            // clDeadline
            // 
            this.clDeadline.Text = "Deadline";
            this.clDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDeadline.Width = 115;
            // 
            // CSListView
            // 
            this.CSListView.BackColor = System.Drawing.Color.Silver;
            this.CSListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSTdelete,
            this.CSTcomplete});
            this.CSListView.Name = "CSListView";
            this.CSListView.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CSListView.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CSListView.RenderStyle.ColorTable = null;
            this.CSListView.RenderStyle.RoundedEdges = true;
            this.CSListView.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CSListView.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CSListView.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CSListView.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CSListView.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CSListView.Size = new System.Drawing.Size(181, 78);
            // 
            // CSTdelete
            // 
            this.CSTdelete.Image = global::WindowsFormsApp2.Properties.Resources.close;
            this.CSTdelete.Name = "CSTdelete";
            this.CSTdelete.Size = new System.Drawing.Size(180, 26);
            this.CSTdelete.Text = "Delete";
            this.CSTdelete.Click += new System.EventHandler(this.CSTdelete_Click);
            // 
            // CSTcomplete
            // 
            this.CSTcomplete.Image = global::WindowsFormsApp2.Properties.Resources.icon_correct_24_1;
            this.CSTcomplete.Name = "CSTcomplete";
            this.CSTcomplete.Size = new System.Drawing.Size(180, 26);
            this.CSTcomplete.Text = "Complete";
            this.CSTcomplete.Click += new System.EventHandler(this.CSTcomplete_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gold;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(93, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(170, 49);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "To Do List";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gold;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(120, 266);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(114, 30);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "Task Name";
            // 
            // cbDeadline
            // 
            this.cbDeadline.AutoRoundedCorners = true;
            this.cbDeadline.BackColor = System.Drawing.Color.Transparent;
            this.cbDeadline.BorderRadius = 17;
            this.cbDeadline.BorderThickness = 2;
            this.cbDeadline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeadline.FillColor = System.Drawing.Color.Sienna;
            this.cbDeadline.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDeadline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbDeadline.ForeColor = System.Drawing.Color.White;
            this.cbDeadline.ItemHeight = 30;
            this.cbDeadline.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month",
            "This Year"});
            this.cbDeadline.Location = new System.Drawing.Point(93, 376);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(164, 36);
            this.cbDeadline.TabIndex = 19;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gold;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(80, 340);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(189, 30);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "Completion Period";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Sienna;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(120, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 40);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.BorderRadius = 3;
            this.txtTaskName.BorderThickness = 2;
            this.txtTaskName.ContextMenuStrip = this.CSTaskName;
            this.txtTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskName.DefaultText = "";
            this.txtTaskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.FillColor = System.Drawing.Color.Sienna;
            this.txtTaskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTaskName.ForeColor = System.Drawing.Color.White;
            this.txtTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Location = new System.Drawing.Point(41, 304);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(5);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.PlaceholderText = "";
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.Size = new System.Drawing.Size(272, 28);
            this.txtTaskName.TabIndex = 23;
            // 
            // CSTaskName
            // 
            this.CSTaskName.BackColor = System.Drawing.Color.Silver;
            this.CSTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSTaskName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CSTaskName.Name = "CSListView";
            this.CSTaskName.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CSTaskName.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CSTaskName.RenderStyle.ColorTable = null;
            this.CSTaskName.RenderStyle.RoundedEdges = true;
            this.CSTaskName.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CSTaskName.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CSTaskName.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CSTaskName.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CSTaskName.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CSTaskName.Size = new System.Drawing.Size(117, 30);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::WindowsFormsApp2.Properties.Resources._360_F_577953883_zBPvFb7h53kH4EORs7Cy8C1iTlrBP6lQ_removebg_preview;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem1.Text = "Clear";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // TSMode
            // 
            this.TSMode.Checked = true;
            this.TSMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TSMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TSMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSMode.Location = new System.Drawing.Point(303, 13);
            this.TSMode.Name = "TSMode";
            this.TSMode.Size = new System.Drawing.Size(45, 27);
            this.TSMode.TabIndex = 24;
            this.TSMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TSMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TSMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSMode.CheckedChanged += new System.EventHandler(this.TSMode_CheckedChanged);
            // 
            // btnCompleteTasks
            // 
            this.btnCompleteTasks.BackColor = System.Drawing.Color.Sienna;
            this.btnCompleteTasks.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCompleteTasks.FlatAppearance.BorderSize = 2;
            this.btnCompleteTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteTasks.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteTasks.ForeColor = System.Drawing.Color.White;
            this.btnCompleteTasks.Location = new System.Drawing.Point(79, 473);
            this.btnCompleteTasks.Name = "btnCompleteTasks";
            this.btnCompleteTasks.Size = new System.Drawing.Size(193, 40);
            this.btnCompleteTasks.TabIndex = 28;
            this.btnCompleteTasks.Text = "Complete Tasks";
            this.btnCompleteTasks.UseVisualStyleBackColor = false;
            this.btnCompleteTasks.Click += new System.EventHandler(this.btnCompleteTasks_Click);
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(356, 527);
            this.Controls.Add(this.btnCompleteTasks);
            this.Controls.Add(this.TSMode);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cbDeadline);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ListView1);
            this.Name = "frmToDoList";
            this.Text = "To Do List";
            this.CSListView.ResumeLayout(false);
            this.CSTaskName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbDeadline;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskName;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSMode;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader clDeadline;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CSListView;
        private System.Windows.Forms.ToolStripMenuItem CSTdelete;
        private System.Windows.Forms.ToolStripMenuItem CSTcomplete;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CSTaskName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnCompleteTasks;
    }
}

