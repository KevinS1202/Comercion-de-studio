﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab7
{
    public partial class Form4 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevin\Desktop\ЮЗГУ\Visual Studio\2do año\1 er semestre\Lab7\Lab7\Lab7\Коммерческое обучение в вузе.mdf;Integrated Security=True";
        string sql = "SELECT * FROM ОБУЧЕНИЕ";
        public Form4()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void agreeBtn_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);

                adapter.InsertCommand = new SqlCommand("ОБУЧЕНИЕ", connection);
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@№_зачетной_книжки", SqlDbType.NVarChar, 50, "№ зачетной книжки"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Шифр_специальности", SqlDbType.NVarChar, 50, "Шифр специальности"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Дата_зачисления", SqlDbType.Date, 0, "Дата зачисления"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Форма_обучения ", SqlDbType.NChar, 10, "Форма обучения "));

                connection.Close();
            }
        }
    }
}
