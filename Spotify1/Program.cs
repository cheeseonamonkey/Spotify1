using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string GlobalAuthCode { get; set; }
        public static AccessToken GlobalAccessToken { get; set; }

        public static string spotifyClient = "66e1cc6f62154340966581033cbe84e8";
        public static string spotifySecret = "1142189b8c504c07a1ddfc088eeb361b";



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
