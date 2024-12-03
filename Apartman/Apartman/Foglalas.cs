using Apartman.Classes;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Apartman
{
    public partial class Foglalas : Form
    {
        public Foglalas()
        {
            InitializeComponent();
        }
        Foglalasok f = new Foglalasok();

        private void Foglalas_Load(object sender, EventArgs e)
        {
            DataTable dt = f.Select();
            foglalasDataGridView.DataSource = dt;

            foglalasDataGridView.Columns[0].HeaderText = "Apartman Neve";
            foglalasDataGridView.Columns[1].HeaderText = "Szoba Neve";
            foglalasDataGridView.Columns[2].HeaderText = "Vendég Neve";
            foglalasDataGridView.Columns[3].HeaderText = "Foglalás Kezdete";
            foglalasDataGridView.Columns[4].HeaderText = "Foglalás Vége";
            foglalasDataGridView.Columns[5].HeaderText = "Foglalás Id";

            foglalasKezdeteTimePicker.Format = DateTimePickerFormat.Custom;
            foglalasKezdeteTimePicker.CustomFormat = "yyyy-MM-dd";
            foglalasVegeTimePicker.Format = DateTimePickerFormat.Custom;
            foglalasVegeTimePicker.CustomFormat = "yyyy-MM-dd";
            foglalasVegeTimePicker.Value = DateTime.Now.AddDays(7);
        }

        private void foglalasHozzaadasaButton_Click(object sender, EventArgs e)
        {
            f.apartmanNeve = apartmanNeveComboBox.Text;
            f.szobaNeve = szobaNeveComboBox.Text;
            f.vendegNeve = vendegNeveTextBox.Text;
            f.foglalasKezdete = foglalasKezdeteTimePicker.Text;
            f.foglalasVege = foglalasVegeTimePicker.Text;

            bool success = f.Insert(f);
            if (success)
            {
                MessageBox.Show("Új Foglalás Sikeresen Hozzáadva!");
                Clear();
            }
            else
            {
                MessageBox.Show("Sikertelen Foglalás!");
            }
            DataTable dt = f.Select();
            foglalasDataGridView.DataSource = dt;
        }

        public void Clear()
        {
            foglalasIdTextBox.Text = "";
            apartmanNeveComboBox.Text = "";
            szobaNeveComboBox.Text = "";
            vendegNeveTextBox.Text = "";
            foglalasKezdeteTimePicker.Text = "";
            foglalasVegeTimePicker.Text = "";
        }

        private void foglalasDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < foglalasDataGridView.Rows.Count)
            {
                var row = foglalasDataGridView.Rows[rowIndex];

                if (row.Cells.Count > 5)
                {
                    apartmanNeveComboBox.Text = row.Cells[0].Value.ToString();
                    szobaNeveComboBox.Text = row.Cells[1].Value.ToString();
                    vendegNeveTextBox.Text = row.Cells[2].Value.ToString();
                    foglalasKezdeteTimePicker.Text =row.Cells[3].Value.ToString();
                    foglalasVegeTimePicker.Text = row.Cells[4].Value.ToString();
                    foglalasIdTextBox.Text = row.Cells[5].Value.ToString();

                }
            }
        }

        private void foglalasModositasaButton_Click(object sender, EventArgs e)
        {
            f.foglalasId = int.Parse(foglalasIdTextBox.Text);
            f.apartmanNeve = apartmanNeveComboBox.Text;
            f.szobaNeve = szobaNeveComboBox.Text;
            f.vendegNeve = vendegNeveTextBox.Text;
            f.foglalasKezdete = foglalasKezdeteTimePicker.Text;
            f.foglalasVege = foglalasVegeTimePicker.Text;

            bool success = f.Update(f);
            if (success)
            {
                MessageBox.Show("A Foglalás Sikeresen Módosítva!");
                Clear();
                DataTable dt = f.Select();
                foglalasDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Sikertelen Módosítás!");
            }
        }

        private void mezokTorleseButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void vendegKijelentkezteteseButton_Click(object sender, EventArgs e)
        {
            try
            {
                f.foglalasId = int.Parse(foglalasIdTextBox.Text);
            }
            catch (Exception ex) { 
            
            }
            finally
            {
                bool success = f.Delete(f);
                if (success)
                {
                    MessageBox.Show("A Vendég Sikeresen Kijelentkeztetve!");
                    Clear();
                    DataTable dt = f.Select();
                    foglalasDataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Sikertelen Kijelentkeztetés!");
                }
            }


        }
        private void keresesTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = keresesTextBox.Text;
            string dbString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;


            SqlConnection connection = new SqlConnection(dbString);
            try
            {
                connection.Open();

                string sql = "SELECT * FROM foglalasTabla WHERE vendegNeve LIKE @vendegNeve";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@vendegNeve", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                foglalasDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}  