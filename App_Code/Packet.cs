using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for Packet
/// </summary>
public class Packet
{
	public Packet()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    //Hàm băm mật khẩu
    public static string MD5Hash(string input)
    {
        StringBuilder hash = new StringBuilder();
        MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
        byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

        for (int i = 0; i < bytes.Length; i++)
        {
            hash.Append(bytes[i].ToString("x2"));
        }
        return hash.ToString();
    }

    //Lọc tiếng việt có dấu thàng không dấu
    public static string convertToUnSign3(string s)
    {
        Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
        string temp = s.Normalize(NormalizationForm.FormD);
        return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
    }  

    //Tạo Slug URL
    public static string GenerateSlug(string phrase)
    {
        string str = convertToUnSign3(phrase).ToLower();
        // invalid chars           
        str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
        // convert multiple spaces into one space   
        str = Regex.Replace(str, @"\s+", " ").Trim();
        // cut and trim 
        str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
        str = Regex.Replace(str, @"\s", "-"); // hyphens   
        return str;
    }

    public static List<int> toPaging(int total, int pageSize)
    {
        List<int> listPage = new List<int>();
        int totalPage = 0;
        if (total % pageSize == 0)
        {
            totalPage = total / pageSize;
        }
        else
        {
            totalPage = (total / pageSize) + 1;
        }

        for (int i = 1; i <= totalPage; i++)
        {
            listPage.Add(i);
        }

        return listPage;
    }
}