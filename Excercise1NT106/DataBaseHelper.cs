using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Excercise1NT106
{
    public static class DatabaseHelper
    {
        private const string ChuoiKetNoi =
            @"Server=localhost\SQL2025LAB; Database=QuanLyNguoiDung; Trusted_Connection=True; TrustServerCertificate=True;";

        public static async Task<bool> KiemTraTenTonTaiAsync(string tenDangNhap)
        {
            const string sql = "SELECT COUNT(1) FROM Users WHERE TenDangNhap = @ten";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            await conn.OpenAsync();
            int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
            return count > 0;
        }

        public static async Task<bool> ThemNguoiDungAsync(string ten, string bam, string salt, string hoTen, string email)
        {
            const string sql = @"INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email) 
                                 VALUES (@ten, @bam, @salt, @hoTen, @email)";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;
            cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = bam;
            cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = hoTen;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value =
                string.IsNullOrWhiteSpace(email) ? DBNull.Value : (object)email;

            await conn.OpenAsync();
            int rows = await cmd.ExecuteNonQueryAsync();
            return rows > 0;
        }

        public static async Task<ThongTinUser> LayNguoiDungAsync(string tenDangNhap)
        {
            const string sql = @"SELECT MatKhauBam, Salt, HoTen, Email, LanDangNhapCuoi 
                                 FROM Users WHERE TenDangNhap = @ten";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new ThongTinUser
                {
                    MatKhauBam = reader["MatKhauBam"].ToString(),
                    Salt = reader["Salt"].ToString(),
                    HoTen = reader["HoTen"].ToString(),
                    Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null,
                    LanDangNhapCuoi = reader["LanDangNhapCuoi"] != DBNull.Value ? Convert.ToDateTime(reader["LanDangNhapCuoi"]) : (DateTime?)null
                };
            }
            return null;
        }
    }

    public class ThongTinUser
    {
        public string MatKhauBam { get; set; }
        public string Salt { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public DateTime? LanDangNhapCuoi { get; set; }
    }
}