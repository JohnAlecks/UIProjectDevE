using System;
using System.Collections.Generic;
using System.Linq;

namespace UIProject
{
    internal class LoginInfo
    {
        private String email;
        private String password;

        public int UserLogin { get; set; }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != null && value != string.Empty)
                {
                    email = value;
                }
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.ToString().Length >= 6)
                {
                    password = value;
                }
                else
                {
                    throw (new PasswordIsTooShort("Password is too short. Password must be longer than 6 characters"));
                }
            }
        }
    }
    internal class Deparment
    {
        public String DepartmentID { get; set; }
        public String DepartmentName { get; set; }

        public String Location { get; set; }
    }

    internal class UserInfo
    {
        public String Email { get; set; }
        public String First_name { get; set; }
        public String Last_name { get; set; }
       
        public String Address { get; set; }

        public String Phone { get; set; }
        public int Officer_Department { get; set; }
        public String Link { get; set; }
        public int UserInfoID { get; set; }
    }


}
