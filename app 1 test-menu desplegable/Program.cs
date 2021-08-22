using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
 using System.Drawing;
 using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace app_1_test_menu_desplegable
{
    static class Program
    {

       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pan_cabecera());
        }
    }
}
