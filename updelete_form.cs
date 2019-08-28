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
    public partial class updelete_form : Form
    {
        TextBox nims = new TextBox();
        TextBox names = new TextBox();
        TextBox kls = new TextBox();
        TextBox kompen = new TextBox();


        string nim;
        string nama;
        string kelas;
        string kmpen;
        string str;
        string srch;
        string key;

       
        public updelete_form()
        {
            InitializeComponent();
        }

        private void Cari_Click(object sender, EventArgs e)
        {

        }

        private string[] getData()
        {
            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
            StreamReader obj = new StreamReader(fs);
            int jml = File.ReadAllLines("data_mhs.txt").Count();
            string[] data = new string[jml];
            string line = obj.ReadLine();
            int i = 0;
            while(line!=null)
            {
                data[i] = line;
                i++;
                line = obj.ReadLine();
            }
            obj.Close();
            fs.Close();
            return data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //SEARCH
            srch = searchBox.Text;
            key = key_txtBox.Text;

            nims = textBox1;
            names = textBox2;
            kls = textBox3;
            kompen = textBox4;

            //Biar pas awalan di buka text boxnya kosong dulu
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            if (srch == "Nama") //Karena List nama itu ada di dlm combo box makannya dimasukin if
            {
                LinearSearch obj = new LinearSearch();
                obj.SearchNama3(key, nims, names, kls, kompen, getData());
            }
            if (srch == "Nim")
            {
                LinearSearch NE = new LinearSearch();
                NE.SearchNIM(key, nims, names, kls, kompen, getData());
            }
           
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            //UPDATE
            string[] arr = new string[5];
            int pos;
            string text = "";
            string[,] artext;
            string savetxt = "";

            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((str = sr.ReadLine()) != null)
            {
                pos = str.IndexOf('|');
                string check = str.Substring(0, pos);
                if (textBox1.Text.CompareTo(check) == 0)
                {
                    savetxt = (textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + "\n");
                    text += savetxt;

                }
                else
                {
                    text = text + str + "\n";
                }

            }
            fs.Close();
            sr.Close();
            File.WriteAllText("data_mhs.txt", text);
            MessageBox.Show("Data telah diperbarui");
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            //DELETE
            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string newline = "";
            string text = "";
            int pos;

            DialogResult di = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (di == DialogResult.Yes)
            {
                while ((str = sr.ReadLine()) != null)
                {
                    pos = str.IndexOf('|');
                    string check = str.Substring(0, pos);
                    if ((textBox1.Text.CompareTo(check) == 0) || (textBox3.Text.CompareTo(check) == 0))
                    {
                        string[] line = str.Split('|');
                        if ((!str.Contains(textBox1.Text)) || (!str.Contains(textBox3.Text)))
                        {
                            for (int i = 0; i < line.Length; i++)
                            {
                                newline = newline + '|' + line[i];
                            }
                            text += newline;
                            str = sr.ReadLine();
                        }
                    }
                    else
                    {
                        text = text + str + "\n";
                    }
                }
                sr.Close();
                File.WriteAllText("data_mhs.txt", text);
                MessageBox.Show("Data telah dihapus");
                //fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            key_txtBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updelete_form_Load(object sender, EventArgs e)
        {

        }
    }
}


    
