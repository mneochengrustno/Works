using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminManagerApp
{
    public partial class Form1 : Form
    {
        private readonly DatabaseHelper dbHelper;
        private readonly string role;

        public Form1(string role)
        {
            InitializeComponent();

            dbHelper = new DatabaseHelper(ConfigurationManager.ConnectionStrings["hotel_managment"].ConnectionString);
            
            this.role = role;

            

            if (role == "A")
            {

            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button7.Visible = false;
                button6.Visible = false;
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT *
                    FROM stay";


            DataTable dataTable = dbHelper.ExecuteQuery(query);

            dataGridView1.DataSource = dataTable;

            button5.Enabled = false;

            button8.Enabled = true;
            button4.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT *
                    FROM invoice";


            DataTable dataTable = dbHelper.ExecuteQuery(query);

            dataGridView1.DataSource = dataTable;

            

            button8.Enabled = false;

            button5.Enabled = true;
            button4.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT *
                    FROM public.user";


            DataTable dataTable = dbHelper.ExecuteQuery(query);

            dataGridView1.DataSource = dataTable;

            button4.Enabled = false;

            button5.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT *
                    FROM room_class";


            DataTable dataTable = dbHelper.ExecuteQuery(query);

            dataGridView1.DataSource = dataTable;

            button7.Enabled = false;

            button5.Enabled = true;
            button8.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT *
                    FROM room";


            DataTable dataTable = dbHelper.ExecuteQuery(query);

            dataGridView1.DataSource = dataTable;

            button6.Enabled = false;

            button5.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button4.Enabled = true;
        }

        private void ApplicationButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) // Проверяем, что выделена только одна строка
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Получаем выделенную строку

                // Пытаемся преобразовать значение в int
                if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int firstCellValue))
                {
                    string query = @"
                    UPDATE stay
                    SET is_occupied = True
                    WHERE stay_id = @firstCellValue";

                    var parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@firstCellValue", firstCellValue)
                    };

                    dbHelper.ExecuteNonQuery(query, parameters);

                    button5.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Выделите одну строку, чтобы получить данные!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.PerformClick();
        }
    }
}
