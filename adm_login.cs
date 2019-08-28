using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kompen_pnj
{
    public partial class adm_login : Form
    {
        string uname;
        string pass;

        public adm_login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            uname = userBox.Text;
            pass = Passbox.Text;

            if ((uname == "") || (uname == null))
            {
                MessageBox.Show("Mohon masukkan username");
                if (DialogResult == DialogResult.OK)
                    uname = null;
            }

            if ((pass == "") || (pass == null))
            {
                MessageBox.Show("Mohon masukkan password");
                if (DialogResult == DialogResult.OK)
                    pass = null;
            }
            else
            {
                FileStream logstream = new FileStream("akun.txt", FileMode.Open, FileAccess.Read);
                StreamReader readlog = new StreamReader(logstream);

                string text;
                
                while ((text = readlog.ReadLine()) != null)
                {
                    string[] split = text.Split('|');
                    if (split[0] == userBox.Text && split[1] == Passbox.Text)
                    {
                        admin_form adm = new admin_form();
                        adm.Show();
                        this.Close();
                    }
                    else if(split[2] == userBox.Text && split[3] == Passbox.Text)
                    {
                        admin_form adm = new admin_form();
                        adm.Show();
                        this.Close();
                    }
                    else
                    {
                        DialogResult dial = MessageBox.Show("Username atau password salah!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if(dial == DialogResult.OK)
                        {
                            
                        }
                        
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
