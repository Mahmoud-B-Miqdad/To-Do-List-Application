using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace WindowsFormsApp2
{
    public partial class frmToDoList : Form
    {
        public static frmToDoList instance;

        private frmCompleteTasks CompleteTasks = new frmCompleteTasks();

        public frmToDoList()
        {
            InitializeComponent();
            instance = this;
        }

        void ChangeMode()
        {
            if(TSMode.Checked)
            {
                ListView1.BackColor = Color.Sienna;
                this.BackColor = Color.Peru;
                txtTaskName.FillColor = Color.Sienna;
                cbDeadline.FillColor = Color.Sienna;
                btnAdd.BackColor = Color.Sienna;
                btnCompleteTasks.BackColor = Color.Sienna;
            }

            else
            {
                ListView1.BackColor = Color.FromArgb(255, 64, 64, 64);
                this.BackColor = Color.Black;
                txtTaskName.FillColor = Color.FromArgb(255, 64, 64, 64);
                cbDeadline.FillColor = Color.FromArgb(255, 64, 64, 64);
                btnAdd.BackColor = Color.FromArgb(255, 64, 64, 64);
                btnCompleteTasks.BackColor = Color.FromArgb(255, 64, 64, 64);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text) || string.IsNullOrEmpty(cbDeadline.Text))
                return;

            ListViewItem item = new ListViewItem(txtTaskName.Text.Trim());

            item.SubItems.Add(cbDeadline.Text.Trim());
            item.ForeColor = Color.White;
            ListView1.Items.Add(item);



            txtTaskName.Clear();
            cbDeadline.StartIndex = -1;
            txtTaskName.Focus();
        }

        bool MakeConfirmMessege(string Messege,string Title)
        {
            if (MessageBox.Show(Messege, Title,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {

            txtTaskName.Text = ListView1.SelectedItems[0].Text;
            ListView1.Items.Remove(ListView1.SelectedItems[0]);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtTaskName.Clear();
        }

        private void btnCompleteTasks_Click(object sender, EventArgs e)
        {
            CompleteTasks.Show();
            this.Visible = false;
        }

        private void TSMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMode();
        }
        private void CSTcomplete_Click(object sender, EventArgs e)
        {
            if (MakeConfirmMessege("Are You Sure ?", "Confirm"))
            {
                string Task = ListView1.SelectedItems[0].Text;
                string Category = ListView1.SelectedItems[0].SubItems[1].Text;
                CompleteTasks.AddCompleteTask(Task, Category);
                ListView1.Items.Remove(ListView1.SelectedItems[0]);
            }
        }

        private void CSTdelete_Click(object sender, EventArgs e)
        {
            if (MakeConfirmMessege("Are You Sure ?", "Confirm"))
            {
                ListView1.Items.Remove(ListView1.SelectedItems[0]);
            }
        }
    }
}
