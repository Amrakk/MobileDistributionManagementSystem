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
        private DAL_Profile DProfile;

        public BUS_Profile(int profile_id, string firstname, string lastname, string email, string phone_number, int role_id)
        {
            DProfile = new DAL_Profile(profile_id, firstname, lastname, email, phone_number, role_id);
        }

        public void addQuery()
        {
            DProfile.addQuery();
        }

        public void updateQuere()
        {
            DProfile.updateQuery();
        }

        public void deleteQuery()
        {
            DProfile.deleteQuery();
        }

        public DataTable selectQuery(string query)
        {
            return DProfile.selectQuery(query);
        }

    }
}