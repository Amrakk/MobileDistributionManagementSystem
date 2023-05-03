using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.User;


namespace DAL.User
{
    public class DAL_Profile
    {
        private Profile profile;

        public DAL_Profile(int profile_id, string firstname, string lastname, string email, string phone_number, int role_id)
        {
            profile = new Profile(profile_id, firstname, lastname, email, phone_number, role_id);
        }

        public void addQuery()
        {
            string query = "insert into Profile (profile_id, first_name, last_name , email, phone, role_id) values ('"
                                + profile.Profile_id + "', '"
                                + profile.Firstname + "', '"
                                + profile.Lastname + "', '"
                                + profile.Email + "', '"
                                + profile.Phone_number + "', '"
                                + profile.Role_id + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update Profile set "
                                + "first_name = " + profile.Firstname + "', '"
                                + "last_name = " + profile.Lastname + "', '"
                                + "email = " + profile.Email + "', '"
                                + "phone = " + profile.Phone_number + "', '"
                                + "where profile_id = " + profile.Profile_id;
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from Profile where profile_id = " + profile.Profile_id;
            Connection.actionQuery(query);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }
}
