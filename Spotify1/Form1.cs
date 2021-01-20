using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Task HttpResponse { get; private set; }

        private async void button1_Click(object sender, EventArgs e)
        {
            

            BrowserForm browserForm = new BrowserForm();

            browserForm.ShowDialog();

            //if auth is set
            if(Program.GlobalAuthCode != "")
            {
                Form2 form2 = new Form2();

                this.Hide();
                form2.ShowDialog();

                Application.Exit();

            }


        }
    }
}
