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
    public partial class input_data : Form
    {
        string nim;
        string nama;
        string kelas;
        string kmpen;
        string str;
        string kodebaru;
        int kode = 0;

        string[] line;
        string[,] arr;
        int x, y, i;
        admin_form adm = new admin_form();
        DataTable table = new DataTable();

        public input_data()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string generateNIM()
        {
            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while  ((str = sr.ReadLine()) != null)
            {
                string lastLine = File.ReadLines("data_mhs.txt").Last();
                if (lastLine != null)
                {
                    string[] isi = lastLine.Split('#');
                    kode = Convert.ToInt32(isi[0].Substring(4, 3));
                    kode = kode + 1;
                    if (kode < 10)
                    {
                        kodebaru = "4816" + kode;
                    }
                    else if (kode >= 10 && kode < 200)
                    {
                        kodebaru = "4816" + kode;
                    }
                    else if (kode >= 200)
                    {
                        kodebaru = "Full";
                    }

                    sr.Close();
                    fs.Close();
                    return kodebaru;
                }
                
            }
            kodebaru = "4816115";
            sr.Close();
            fs.Close();
            return kodebaru;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDATE
            string[] arr = new string[5];
            int pos;
            string text ="";
            string[,] artext;
            string savetxt="";

            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while((str = sr.ReadLine()) != null)
            {
                pos = str.IndexOf('|');
                string check = str.Substring(0, pos);
                if(NIM_txtbox.Text.CompareTo(check) == 0)
                {
                    savetxt = (NIM_txtbox.Text + "|" + nama_txtbox.Text + "|" + kelas_txtbox.Text + "|" + kompen_txtbox.Text + "|" + "\n");
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

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE
            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string newline = "";
            string text = "";
            int pos;
            
            DialogResult di = MessageBox.Show("Apakah Anda yakin menghapus data ini?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(di == DialogResult.Yes)
            {
                while((str = sr.ReadLine()) != null)
                {
                    pos = str.IndexOf('|');
                    string check = str.Substring(0, pos);
                    if((NIM_txtbox.Text.CompareTo(check) == 0) || (nama_txtbox.Text.CompareTo(check) == 0))
                    {
                        string[] line = str.Split('|');
                        if ((!str.Contains(NIM_txtbox.Text)) || (!str.Contains(nama_txtbox.Text)))
                        {
                            for(int i = 0; i < line.Length; i++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERT
            nim = NIM_txtbox.Text;
            nama = nama_txtbox.Text;
            kelas = kelas_txtbox.Text;
            kmpen = kompen_txtbox.Text;

           
            
              
            
            {
                try
                {
                    FileStream fs = new FileStream("data_mhs.txt", FileMode.Append, FileAccess.Write); //File Modenya Append yaitu Menambahkan, dan file acses nya Write = Ditulis jadi data yang baru aja di tulis akan di tambahin ke File txtnya
                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(nim + "|" + nama + "|" + kelas + "|" + kmpen + "|" + "\n");
                    //sw.WriteLine("");
                    sw.Close();
                    fs.Close();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Tidak bisa memasukkan data dan refresh sekaligus\nSilahkan masukkan data lagi", "Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            nama = "";
            kelas = "";
            kmpen = "";
            
           
        }

        private void input_data_Load(object sender, EventArgs e)
        {
            //line = File.ReadAllLines("data_mhs.txt");
            //arr = new string[line.Length, 4];

            //foreach(string u in line)
            //{
            //    for(x = 0; x < line.Length; x++)
            //    {
            //        string arr2 = line[x];
            //        string[] split = arr2.Split('|');
            //        for(y = 0; y < line.Length; y++)
            //        {
            //            arr[x, y] = split[y];
            //        }
            //    }
            //}

            NIM_txtbox.Text = generateNIM();
        }

        private void nama_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIM_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Harap Masukkan Angka!");
                e.Handled = true;
            }
        }
    }
}
