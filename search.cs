using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;
namespace kompen_pnj
{
    class LinearSearch
    {
        public void SearchKelas(String kw, DataTable obj, string[] data)
        {
            foreach (var x in data)
            {
                string[] isi = x.Split('|');
                if (isi[2].Contains(kw))
                {
                    obj.Rows.Add(isi[0], isi[1], isi[2], isi[3]);
                }
            }
        }

        public void SearchNama(String kw, DataTable obj, string[] data)
        {
            foreach (var x in data)
             {
                string[] isi = x.Split('|');
                if (isi[1].Contains(kw))
                {
                    obj.Rows.Add(isi[0], isi[1], isi[2], isi[3]);
                }
              }
        }

        //public void SearchNama2(String kw, TextBox text,TextBox text1,TextBox text2,TextBox text3, string[] data)
        //{
        //    foreach(var x in data)
        //    {
        //        string[] isi = x.Split('|');
        //        if (isi[1].Contains(kw))
        //        {
        //            text.AppendText(isi[0]);
        //            text1.AppendText(isi[1]);
        //            text2.AppendText(isi[2]);
        //            text3.AppendText(isi[3]);
        //        }
        //    }
        //}

        public void SearchNama3(String kw, TextBox text, TextBox text1, TextBox text2, TextBox text3, string[] data)
        {
            foreach (var x in data)
            {
                string[] isi = x.Split('|');
                if (isi[1].Contains(kw))
                {
                    text.AppendText(isi[0]);
                    text1.AppendText(isi[1]);
                    text2.AppendText(isi[2]);
                    text3.AppendText(isi[3]);
                }
            }
        }

        public void SearchNIM(String kw, TextBox text, TextBox text1, TextBox text2, TextBox text3, string[] data)
        {
            foreach (var x in data)
            {
                string[] isi = x.Split('|');
                if (isi[0].Contains(kw))
                {
                    text.AppendText(isi[0]);
                    text1.AppendText(isi[1]);
                    text2.AppendText(isi[2]);
                    text3.AppendText(isi[3]);
                }
            }
        }

       
     }
}

