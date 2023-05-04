using DTO.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.User
{
    public class DAL_Role
    {
        private Role role;

        public DAL_Role(int id, string name)
        {
            role = new Role(id, name);
        }

        public void addQuery()
        {
            string query = $"INSERT INTO Role (role_id, role_name) VALUES ('{role.Id}', '{role.Name}')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = $"UPDATE Role SET role_name = '{role.Name}' WHERE role_id = {role.Id}";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"DELETE FROM Role WHERE role_id = {role.Id}";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }

}
