using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinaptik
{
    static class Program
    {
        public static SinaptikEntities2 sinDB = new SinaptikEntities2();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
    }
    static class Coloring
    {
        public static int Fore { get; set; }
        public static int Back { get; set; }
    }
    static class Author
    {
        public static int OnOff { get; set; }
        public static int Name { get; set; }
    }
    static class AdvSys
    {
        public static int Sys { get; set; }
        public static int Google { get; set; }
        public static int Yandex { get; set; }
        public static int VK { get; set; }

    }

}
