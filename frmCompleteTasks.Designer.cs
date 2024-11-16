namespace WindowsFormsApp2
{
    partial class frmCompleteTasks
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cbDeadline = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.TSMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.CSListView = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.CSListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gold;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(228, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(260, 49);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Complete Tasks";
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.Color.Sienna;
            this.ListView1.BackgroundImageTiled = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clDeadline,
            this.columnHeader2});
            this.ListView1.ContextMenuStrip = this.CSListView;
            this.ListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(28, 92);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListView1.Size = new System.Drawing.Size(714, 289);
            this.ListView1.TabIndex = 15;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task Name";
            this.columnHeader1.Width = 270;
            // 
            // clDeadline
            // 
            this.clDeadline.Text = "Category";
            this.clDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDeadline.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Completion Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 270;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Black;
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icon_correct_24_1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(494, 1);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(51, 58);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 16;
            this.guna2CirclePictureBox1.TabStop = false;
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
            "All",
            "Today",
            "This Week",
            "This Month",
            "This Year"});
            this.cbDeadline.Location = new System.Drawing.Point(28, 50);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(164, 36);
            this.cbDeadline.TabIndex = 20;
            this.cbDeadline.SelectedIndexChanged += new System.EventHandler(this.cbDeadline_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gold;
            this.btnBack.Location = new System.Drawing.Point(56, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 49);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gold;
            this.btnClose.Location = new System.Drawing.Point(598, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 49);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TSMode
            // 
            this.TSMode.Checked = true;
            this.TSMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TSMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TSMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TSMode.Location = new System.Drawing.Point(670, 59);
            this.TSMode.Name = "TSMode";
            this.TSMode.Size = new System.Drawing.Size(45, 27);
            this.TSMode.TabIndex = 25;
            this.TSMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TSMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TSMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TSMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TSMode.CheckedChanged += new System.EventHandler(this.TSMode_CheckedChanged);
            // 
            // CSListView
            // 
            this.CSListView.BackColor = System.Drawing.Color.Silver;
            this.CSListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
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
            this.CSListView.Size = new System.Drawing.Size(125, 30);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.close;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmCompleteTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.TSMode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbDeadline);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "frmCompleteTasks";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.CSListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader clDeadline;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Guna.UI2.WinForms.Guna2ComboBox cbDeadline;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TSMode;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CSListView;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}