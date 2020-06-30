using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_With_ListBox
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["csdb"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData_In_ListBox();
        }

        public void LoadData_In_ListBox() {

            SqlConnection conn = new SqlConnection(cs);
            string query = "select * from Sports";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {

                string name = reader.GetString(0);
                listBoxSports.Items.Add(name);
            }

            conn.Close();


        }

        private void buttonInsertItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "insert into Sports values(@items)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@items", textBoxItems.Text);

            conn.Open();

            int n = cmd.ExecuteNonQuery();

            if (n > 0)
            {

                MessageBox.Show("Insertion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxSports.Items.Clear();
                LoadData_In_ListBox();
            }
            else {

                MessageBox.Show("Insertion Failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
            textBoxItems.Clear();
            textBoxItems.Focus();


        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "update Sports set Name = @name where Name = @items";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", textBoxItems.Text);
            cmd.Parameters.AddWithValue("@items", listBoxSports.SelectedItem);

            conn.Open();

            int n = cmd.ExecuteNonQuery();

            if (n > 0)
            {

                MessageBox.Show("Updation Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxSports.Items.Clear();
                LoadData_In_ListBox();
            }
            else
            {

                MessageBox.Show("Updation Failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
            textBoxItems.Clear();
            textBoxItems.Focus();
        }

        private void listBoxSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxItems.Text = listBoxSports.SelectedItem.ToString();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "delete from Sports where Name = @items";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@items", textBoxItems.Text);

            conn.Open();

            int n = cmd.ExecuteNonQuery();

            if (n > 0)
            {

                MessageBox.Show("Deletion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxSports.Items.Clear();
                LoadData_In_ListBox();
            }
            else
            {

                MessageBox.Show("Deletion Failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
            textBoxItems.Clear();
            textBoxItems.Focus();
        }
    }
}
