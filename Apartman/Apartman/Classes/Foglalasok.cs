using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartman.Classes
{
    class Foglalasok
    {
        public string apartmanNeve { get; set; }
        public string szobaNeve { get; set; }
        public string vendegNeve { get; set; }
        public string foglalasKezdete { get; set; }
        public string foglalasVege { get; set; }
        public int foglalasId { get; set; }

        static string dbString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection connection = new SqlConnection(dbString);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM foglalasTabla";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) { 
            
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public bool Insert (Foglalasok f)
        {
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(dbString);
            try
            {
                string checkSql = "SELECT COUNT(*) FROM foglalasTabla WHERE apartmanNeve = @apartmanNeve AND szobaNeve = @szobaNeve";
                SqlCommand checkCommand = new SqlCommand(checkSql, connection);
                checkCommand.Parameters.AddWithValue("@apartmanNeve", f.apartmanNeve);
                checkCommand.Parameters.AddWithValue("@szobaNeve", f.szobaNeve);

                connection.Open();
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    isSuccess = false;
                }
                else
                {


                    string sql = "INSERT INTO foglalasTabla (apartmanNeve, szobaNeve, vendegNeve, foglalasKezdete, foglalasVege) VALUES (@apartmanNeve, @szobaNeve, @vendegNeve, @foglalasKezdete, @foglalasVege)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@apartmanNeve", f.apartmanNeve);
                    command.Parameters.AddWithValue("@szobaNeve", f.szobaNeve);
                    command.Parameters.AddWithValue("@vendegNeve", f.vendegNeve);
                    command.Parameters.AddWithValue("@foglalasKezdete", f.foglalasKezdete);
                    command.Parameters.AddWithValue("@foglalasVege", f.foglalasVege);

                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }

        public bool Update(Foglalasok f)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(dbString);
            try
            {
                string sql = "UPDATE foglalasTabla SET apartmanNeve=@apartmanNeve, szobaNeve=@szobaNeve, vendegNeve=@vendegNeve, foglalasKezdete=@foglalasKezdete, foglalasVege=@foglalasVege WHERE foglalasId=@foglalasId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@apartmanNeve", f.apartmanNeve);
                command.Parameters.AddWithValue("@szobaNeve", f.szobaNeve);
                command.Parameters.AddWithValue("@vendegNeve", f.vendegNeve);
                command.Parameters.AddWithValue("@foglalasKezdete", f.foglalasKezdete);
                command.Parameters.AddWithValue("@foglalasVege", f.foglalasVege);
                command.Parameters.AddWithValue("@foglalasId", f.foglalasId);

                connection.Open();
                int rows = command.ExecuteNonQuery();

                if (rows > 0) { 
                    isSuccess= true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }

        public bool Delete(Foglalasok f) { 
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(dbString);
            try
            {
                string sql = "DELETE FROM foglalasTabla WHERE foglalasId=@foglalasId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@foglalasId", f.foglalasId);
                
                connection.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0) {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally { 
            
            }

            return isSuccess;
        }
    }
}
