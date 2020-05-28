using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial02_001591619_JESA
{
    static class ControlDeUsuario
    {
        private static string userName = "";

        public static void DeclararUserName(string un)
        {
            userName = un;
        }
        public static string DevolverUserName()
        {
            return userName;
        }
    }
}
