using DAL.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.User
{
    public class BUS_Profile
    {
        private readonly DAL_Profile DProfile;

        public BUS_Profile(int profile_id, string firstname, string lastname, string email, string phone_number, int role_id)
        {
            DProfile = new DAL_Profile(profile_id, firstname, lastname, email, phone_number, role_id);
        }

        public void AddProfile()
        {
            DProfile.addQuery();
        }

        public void UpdateProfile()
        {
            DProfile.updateQuery();
        }

        public void DeleteProfile(int id)
        {
            DProfile.deleteQuery(id);
        }

        public DataTable SelectProfiles()
        {
            string query = "SELECT * FROM Profile";
            return DProfile.selectQuery(query);
        }

        public DataTable SelectProfileById(int id)
        {
            string query = $"SELECT * FROM Profile WHERE profile_id = {id}";
            return DProfile.selectQuery(query);
        }

        public DataTable SelectProfileByEmail(string email)
        {
            string query = $"SELECT * FROM Profile WHERE email LIKE '%{email}%'";
            return DProfile.selectQuery(query);
        }

        public DataTable SelectProfileByPhone(string phone)
        {
            string query = $"SELECT * FROM Profile WHERE phone LIKE ' %{phone}%'";
            return DProfile.selectQuery(query);
        }
        public bool SelectAlreadyExistEmail(string email)
        {
            bool exist = false;
            foreach (DataRow row in SelectProfiles().Rows)
            {
                if (row["email"].ToString() == email)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
    }
}