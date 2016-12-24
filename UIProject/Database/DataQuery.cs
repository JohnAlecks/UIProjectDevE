using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject.Database.Database_Controller
{
    class DataQuery
    {
        public static List<UserInfo> runQuery(string input)
        {
            List<UserInfo> users = new List<UserInfo>();
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);
            string sql = "";
            if (input == "")
            {
                sql = "SELECT * FROM UserInformations";
            }
            else
            {
                sql = "SELECT * FROM UserInformations WHERE UserInfo_ID =" + input;
            }
            var com = new SqlCommand(sql, con);
            con.Open();
            var read = com.ExecuteReader();
            while (read.Read())
            {
                var temp = new UserInfo();
                temp.UserInfoID = read.GetInt32(0);
                temp.First_name = read.GetString(1);
                temp.Last_name = read.GetString(2);
                temp.Officer_Department = read.GetInt32(5);
                temp.Link = read.GetString(6);
                users.Add(temp);
            }
            con.Close();
            return users;
        }

    }
}
