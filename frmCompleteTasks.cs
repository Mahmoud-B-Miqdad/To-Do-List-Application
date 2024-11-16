using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmCompleteTasks : Form
    {

        List<ListViewItem> vItems = new List<ListViewItem>();
        public frmCompleteTasks()
        {
            InitializeComponent();
        }

        public void AddCompleteTask(string TaskNAme, string Category)
        {
            DateTime date = DateTime.Now;
            date.ToLongTimeString();

            ListViewItem item = new ListViewItem(TaskNAme);

            item.SubItems.Add(Category);

            item.SubItems.Add(date.ToString());

            item.ForeColor = Color.White;

            ListView1.Items.Add(item);

            vItems.Add(item);

        }

        void ChangeMode()
        {
            if (TSMode.Checked)
            {
                ListView1.BackColor = Color.Sienna;
                this.BackColor = Color.Peru;
                cbDeadline.FillColor = Color.Sienna;
                btnBack.BackColor = Color.Peru;
                btnClose.BackColor = Color.Peru;
            }

            else
            {
                ListView1.BackColor = Color.FromArgb(255, 64, 64, 64);
                this.BackColor = Color.Black;
                cbDeadline.FillColor = Color.FromArgb(255, 64, 64, 64);
                btnBack.BackColor = Color.Black;
                btnClose.BackColor = Color.Black;
            }
        }

        void AddItemToTheListView(int i)
        {
            ListViewItem item = new ListViewItem(vItems[i].SubItems[0].Text);

            item.SubItems.Add(vItems[i].SubItems[1].Text);

            item.SubItems.Add(vItems[i].SubItems[2].Text);

            item.ForeColor = Color.White;

            ListView1.Items.Add(item);
        }
        void CheckCategory()
        {
            ListView1.Items.Clear();

            for (int i = 0; i < vItems.Count; i++)
            {
                if (cbDeadline.Text == "All")
                {
                    AddItemToTheListView(i);
                }

                else if (cbDeadline.Text == vItems[i].SubItems[1].Text)
                {
                    AddItemToTheListView(i);
                }
            }
        }

        bool MakeConfirmMessege(string Messege, string Title)
        {
            if (MessageBox.Show(Messege, Title,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void TSMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMode();
        }

        private void cbDeadline_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCategory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmToDoList.instance.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmToDoList.instance.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MakeConfirmMessege("Are You Sure ?", "Confirm"))
            {
                ListView1.Items.Remove(ListView1.SelectedItems[0]);
            }
        }
    }
}
