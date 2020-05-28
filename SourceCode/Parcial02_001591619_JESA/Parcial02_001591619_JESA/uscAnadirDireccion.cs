using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02_001591619_JESA
{
    public partial class uscAnadirDireccion : UserControl
    {
        private string username = "";
        public uscAnadirDireccion()
        {
            InitializeComponent();
        }
        public uscAnadirDireccion(string un)
        {
            InitializeComponent();
            username = un;
        }


    }
}
