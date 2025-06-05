using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS2.Class
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
        public static bool CheckLogin(string username, string password)
        {
            Connect();
            string sql = "SELECT COUNT(*) FROM TAI_KHOAN WHERE TAIKHOAN=@username AND MATKHAU=@password";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int count = 0;
            try
            {
                count = (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra đăng nhập: " + ex.Message);
            }

            cmd.Dispose();
            Disconnect();

            return count > 0;
        }
        public static bool RegisterAccount(string username, string password, string role)
        {
            try
            {
                Connect();

                // Kiểm tra username đã tồn tại chưa
                string checkSql = "SELECT COUNT(*) FROM Tai_khoan WHERE TAIKHOAN = @username";
                SqlCommand checkCmd = new SqlCommand(checkSql, con);
                checkCmd.Parameters.AddWithValue("@username", username);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Thêm tài khoản mới
                string insertSql = "INSERT INTO Tai_khoan (TAIKHOAN, MATKHAU, QUYENHAN) VALUES (@username, @password, @role)";
                SqlCommand insertCmd = new SqlCommand(insertSql, con);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@role",role );
                int rows = insertCmd.ExecuteNonQuery();

                Disconnect();

                return rows > 0; // Nếu thêm thành công trả về true
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi đăng ký tài khoản: " + ex.Message);
                return false;
            }
        }

        public static string AddCustomerAuto(string tenKH, string sdtKH, string diaChiKH)
        {
            string maKH = null;

            Connect();
            using (SqlCommand cmd = new SqlCommand("sp_ThemKhachHang", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ten_KH", tenKH);
                cmd.Parameters.AddWithValue("@SDT_KH", sdtKH);
                cmd.Parameters.AddWithValue("@DiaChi_KH", diaChiKH);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maKH = result.ToString(); // Mã KH được tạo tự động trả về
                }
            }
            Disconnect();
            return maKH;
        }

        public static bool DeleteCustomer(string maKH)
        {
            try
            {
                Connect();
                string sql = "DELETE FROM Khach_Hang WHERE Ma_KH = @Ma_KH";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Ma_KH", maKH);

                int rows = cmd.ExecuteNonQuery();
                Disconnect();

                return rows > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
                return false;
            }
        }



        public static DataTable GetDataUsingStoredProc(string storedProcName, SqlParameter[] parameters = null)
        {
            Connect();
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(storedProcName, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            Disconnect();
            return dt;
        }
        public static bool ExecuteStoredProc(string storedProcName, SqlParameter[] parameters)
        {
            Connect();
            using (SqlCommand cmd = new SqlCommand(storedProcName, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);

                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi thực thi: " + ex.Message);
                    return false;
                }
                finally
                {
                    Disconnect();
                }
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
        public static DataTable GetDataToTable(string sql, SqlParameter[] parameters)
        {
            Connect();
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            Disconnect();
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

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            cbo.DataSource = dt;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ma;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static bool CheckDuplicateMaLoaiPhong(string maLoaiPhong)
        {
            Connect();
            string sql = "SELECT COUNT(*) FROM Loai_phong WHERE Ma_loaiphong = @ma";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ma", maLoaiPhong);
            int count = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            Disconnect();
            return count > 0;
        }

    }
}
