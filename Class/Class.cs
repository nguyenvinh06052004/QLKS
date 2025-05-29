using System.Data;
//using Microsoft.Data.SqlClient; // Thêm thư viện SqlClient để sử dụng SqlConnection
using System.Data.SqlClient;
using System.Windows.Forms;
namespace qlksss.Class
{
    class Function
    {
        public static SqlConnection con = new SqlConnection();
        public static void Connect()
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.ConnectionString = "Data Source = DESKTOP-392TCLG\\SQLEXPRESS01; Initial Catalog = QuanLyKS; Integrated Security = True; Encrypt = True; TrustServerCertificate = True";


            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
        public static void Disconnect()
        {
            if (con?.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                // con = null;

            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true; //Trả về true nếu có dữ liệu
            else
                return false; //Trả về false nếu không có dữ liệu
        }
        public static void RunSQL(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh SQL: " + ex.Message);
            }
           
            cmd.Dispose();
           
        }
    }
}
