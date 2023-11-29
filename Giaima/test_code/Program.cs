using System;
using System.Security.Cryptography;

class SaltDecoder
{
    public static string DecodeSalt(string hashPassword)
    {
        try
        {
            // Chuyển đổi chuỗi Base64 thành mảng byte.
            byte[] hashBytes = Convert.FromBase64String(hashPassword);

            // Trích xuất salt từ mảng byte.
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Chuyển đổi salt thành chuỗi Base64.
            string saltBase64 = Convert.ToBase64String(salt);

            return saltBase64;
        }
        catch (Exception ex)
        {
            // Xử lý lỗi nếu có.
            Console.WriteLine("Lỗi: " + ex.Message);
            return null;
        }
    }

    static void Main()
    {
        string hashPassword = "jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V"; // Chuỗi đã mã hóa

        string saltBase64 = DecodeSalt(hashPassword);

        if (saltBase64 != null)
        {
            Console.WriteLine("Salt giải mã: " + saltBase64);
        }
        else
        {
            Console.WriteLine("Giải mã salt thất bại.");
        }
    }
}
