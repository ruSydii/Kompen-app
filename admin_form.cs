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
    public partial class admin_form : Form
    {
        
        DataTable table = new DataTable();
        public admin_form()
        {
            InitializeComponent();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_form_Load(object sender, EventArgs e)
        {
            table.Columns.Add("NIM", typeof(int));
            table.Columns.Add("Nama", typeof(string));
            table.Columns.Add("Kelas", typeof(string));
            table.Columns.Add("Jumlah Kompen", typeof(int));
            

            using (StreamReader sr = new StreamReader("data_mhs.txt"))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('|');
                    table.Rows.Add(line[0], line[1], line[2], line[3]);
                }
            }
                data_mahasiswa.DataSource = table;

            
        }

        private void button1_Click(object sender, EventArgs e) // Tombol Refresh 
        {
            table.Clear();
            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split('|');
                table.Rows.Add(line[0], line[1], line[2], line[3]);
            }
            data_mahasiswa.DataSource = table;
            sr.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void buatReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("data_mhs temp.txt");
            for (int i = 0; i < data_mahasiswa.Rows.Count - 1; i++)
            {
                for (int j = 0; j < data_mahasiswa.Columns.Count; j++)
                {
                    writer.Write(data_mahasiswa.Rows[i].Cells[j].Value.ToString() + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            report repor = new report();
            repor.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void data_mahasiswa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private string[] getData()
        {
            FileStream fs = new FileStream("data_mhs.txt", FileMode.Open, FileAccess.Read);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            table.Clear();
            string src = cmbSearch.Text;
            string key = SearchBox.Text;
            if (src == "Nama")
            {
                LinearSearch lsc = new LinearSearch();
                lsc.SearchNama(key, table, getData());
            }

            else if (src == "Kelas")
            {
                LinearSearch lsc = new LinearSearch();
                lsc.SearchKelas(key, table, getData());
            }

            data_mahasiswa.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table.Clear();
            string sortby = cmbSort.Text; //Variable nya Si Urutan
            string filter = cmbSort2.Text; // Variable nya Si Filter
            int jml = File.ReadAllLines("data_mhs.txt").Count();
            string[] hasil = new string[jml];

            if (sortby == "NIM")
            {
                if (filter == "Descending")
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubbleNameDesc(data);
                }
                
                if (filter == "Ascending")
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubbleNameAsc(data);
                }
            }

            if (sortby == "Jumlah Kompen")
            {
                if (filter == "Descending")
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubblePriceDesc(data);
                }
                if (filter == "Ascending")
                {
                    string[] data = getData();
                    BubbleSort bs = new BubbleSort();
                    hasil = bs.bubblePriceAsc(data);
                }
            }
            try
            {
                foreach (var x in hasil)
                {
                    string[] isi = x.Split('|');
                    table.Rows.Add(isi[0], isi[1], isi[2], isi[3]);
                }
                data_mahasiswa.DataSource = table;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Pilih Urutkan Berdasarkan!", "Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpanDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input_data inp = new input_data();
            inp.Show();
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updelete_form obj = new updelete_form();
            obj.Show();
        }
    }
}
