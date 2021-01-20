using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify1
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri($"https://accounts.spotify.com/authorize?client_id={Program.spotifyClient}&redirect_uri=http://localhost/&response_type=code");
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string[] split = webBrowser1.Url.ToString().Split('?');
            
            string code = split[1];

            if (code.Contains("code="))
            {
                // System.Console.WriteLine(code);

                code = code.Remove(0, 5);
                code = code.Remove(code.Length - 3);
                code = code.Trim(' ');
                code = code.Trim('#');

                System.Console.WriteLine(code);

                Program.GlobalAuthCode = code;

                this.Close();
                this.Dispose();
            }

        }
    }
}
