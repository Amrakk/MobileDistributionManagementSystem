using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.User
{
    class Profile
    {
        private int profile_id;
        private string firstname;
        private string lastname;
        private string email;
        private string phone_number;
        private int role_id;

        public Profile(int profile_id, string firstname, string lastname, string email, string phone_number, int role_id)
        {
            this.profile_id = profile_id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone_number = phone_number;
            this.role_id = role_id;
        }

        public int Profile_id { get => profile_id; set => profile_id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public int Role_id { get => role_id; set => role_id = value; }
    }
}
