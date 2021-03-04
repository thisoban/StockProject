using System;

namespace DataModel
{
    public class UserDataModel
    {
        public int IdUser { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Passsword { get; set; }
        public enum Role { admin, client}
    }
}
