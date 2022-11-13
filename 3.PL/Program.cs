using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.PL.Views;

namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// Scaffold-DbContext 'Data Source=DUNGNAPC\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041;Persist Security Info=True;User ID=dungna29;Password=123456' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmChiTietGiay());
=======
            Application.Run(new FrmMauSac());
>>>>>>> d3f6a0910eab86e3e9c5e6f2b3418b8af5af298e
        }
    }
}
