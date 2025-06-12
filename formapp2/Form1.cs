using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                listBoxTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                listBoxTasks.Items.Remove(listBoxTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                string selectedTask = listBoxTasks.SelectedItem.ToString();
                txtTask.Text = selectedTask;
                listBoxTasks.Items.Remove(selectedTask);
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                string selectedTask = listBoxTasks.SelectedItem.ToString();
                txtTask.Text = selectedTask;
                listBoxTasks.Items.Remove(selectedTask);
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
