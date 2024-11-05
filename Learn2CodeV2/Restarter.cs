using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn2CodeV2
{
    public class Restarter
    {
        public static void RestartApplication()
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
