using DAL.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.User
{
    public class BUS_Role
    {
        private readonly DAL_Role DRole;

        public BUS_Role(int id, string name)
        {
            DRole = new DAL_Role(id, name);
        }

        public void AddRole()
        {
            DRole.addQuery();
        }

        public void UpdateRole()
        {
            DRole.updateQuery();
        }

        public void DeleteRole()
        {
            DRole.deleteQuery();
        }

        public DataTable SelectRoles()
        {
            string query = "SELECT * FROM Role";
            return DRole.selectQuery(query);
        }

        public DataTable SearchRoleById(int roleId)
        {
            string query = $"SELECT * FROM Role WHERE role_id = {roleId}";
            return DRole.selectQuery(query);
        }

        public DataTable SearchRoleByName(string roleName)
        {
            string query = $"SELECT * FROM Role WHERE role_name LIKE '%{roleName}%'";
            return DRole.selectQuery(query);
        }
    }

}
