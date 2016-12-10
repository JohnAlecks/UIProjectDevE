using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProject
{
    class LoginInfo {
        private String email;
        private String password;
        private int user_login;

        public int UserLogin {
            get {
                return user_login;
            }
            set {
                user_login = value;
            }
        }
        public String Email {
            get {
                return email;
            }
            set {
                if (value != null && value != "") {
                    email = value;
                }
            }
        }

        public String Password {
            get {
                return password;
            }
            set {
                if (value.ToString().Length >= 6)
                {
                    password = value;
                }
                else {
                    throw (new PasswordIsTooShort("Password is too short. Password must be longer than 6 characters"));
                }
            }
        }
    }
    class Deparment {
        private String departmentName;
        private String location;
        private String departmentID;

        public String DepartmentID {
            get {
                return departmentID;
            }

            set {
                departmentID = value;
            }
        }
        public String DepartmentName {
            get {
                return departmentName;
            }
            set {
                departmentName = value;
            }
        }

        public String Location {
            get {
                return location;
            }

            set {
                location = value;
            }
        }

    }

    class UserInfo {
        private String fullname;
        private String address;
        private String phone;
        private int userinfo_id;

       public String Fullname {
            get {
                return fullname;
            }
            set {
                fullname = value;
            }

        }

        public String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }

        public String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }

        }

        public int UserInfoID
        {
            get
            {
                return userinfo_id;
            }
            set
            {
                userinfo_id = value;
            }

        }

    }
}
