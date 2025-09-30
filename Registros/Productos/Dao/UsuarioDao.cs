using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Dao
{
    public class UsuarioDao
    {
        public String[] Users = { "admin", "user1", "user2" };

        public String[] Pass = { "admin123", "user123", "user223" };

        public Boolean Validar(String user, String pass)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Equals(user) && Pass[i].Equals(pass))
                    return true;
            }
            return false;
        }
    }
}
