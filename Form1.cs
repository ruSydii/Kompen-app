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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void admLinklbl_MouseHover(object sender, EventArgs e)
        {
            admLinklbl.LinkColor = Color.RoyalBlue;
        }

        private void admLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adm_login admlog = new adm_login();
            admlog.Show();
            this.Hide();
        }

        private void admLinklbl_MouseEnter(object sender, EventArgs e)
        {
            admLinklbl.LinkColor = Color.MidnightBlue;
        }

        private void admLinklbl_MouseLeave(object sender, EventArgs e)
        {
            admLinklbl.LinkColor = Color.MidnightBlue;
        }

        private void help_linkLbl_MouseEnter(object sender, EventArgs e)
        {
            help_linkLbl.LinkColor = Color.MidnightBlue;
        }

        private void help_linkLbl_MouseLeave(object sender, EventArgs e)
        {
            help_linkLbl.LinkColor = Color.MidnightBlue;
        }

        private void help_linkLbl_MouseHover(object sender, EventArgs e)
        {
            help_linkLbl.LinkColor = Color.RoyalBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.Clear();
            string sortby = cbSort.Text;
            string filter = cbFilter.Text;
            int jml = File.ReadAllLines("data_mhs.txt").Count();
            string[] hasil = new string[jml];

            if (sortby == "NIM")
            {
                if (filter == "Ascending")
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubbleNameAsc(data);
                }
                else
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubbleNameDesc(data);
                }
            }

            if (sortby == "Jumlah Kompen")
            {
                if (filter == "Ascending")
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubblePriceAsc(data);
                }
                else
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubblePriceDesc(data);
                }
            }
            try
            {
                foreach (var x in hasil)
                {
                    string[] isi = x.Split('|');
                    obj.Rows.Add(isi[0], isi[1], isi[2], isi[3]);
                }
                dataGridView1.DataSource = obj;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Pilih Urutkan Berdasarkan!", "Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


                
        }


        DataTable obj = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

            obj.Columns.Add("NIM");
            obj.Columns.Add("Nama");
            obj.Columns.Add("Kelas");
            obj.Columns.Add("Jumlah Kompen");

            using (StreamReader sr = new StreamReader("data_mhs.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('|');
                    obj.Rows.Add(line[0], line[1], line[2], line[3]);
                }
            }

            dataGridView1.DataSource = obj;
        }

        private string[] getData()
        {
            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int jml = File.ReadAllLines("data_mhs.txt").Count();
            string[] data = new string[jml];
            string line = sr.ReadLine();
            int i = 0;
            while (line != null)
            {
                data[i] = line;
                i++;
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.Clear();
            string src = cbKelas.Text;
            string key = textBox1.Text;
            if(src=="Nama")
            {
                LinearSearch lsc = new LinearSearch();
                lsc.SearchNama(key, obj, getData());
            }

            else if (src == "Kelas")
            {
                LinearSearch lsc = new LinearSearch();
                lsc.SearchKelas(key, obj, getData());
            }

            
            
            dataGridView1.DataSource = obj;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
