using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace kompen_pnj
{
    class BubbleSort
    { //sort by name desc
        public string[] bubbleNameDesc(string[] data)
        {
            for (int i = 0; i <data.Length; i++)
            {
                for (int x = 0; x <data.Length - 1; x++)
                {
                    string[] NIM1 = data[x].Split('|');
                    string[] NIM2 = data[x + 1].Split('|');
                    if (NIM1[0].CompareTo(NIM2[0]) != 1)
                    {
                        string swap = data[x];
                        data[x] = data[x + 1];
                        data[x + 1] = swap;
                    }
                }
             }
            return data;
        }

        //sort by name asc
        public string[] bubbleNameAsc(string[] data)
        {
            for (int i = 0; i <data.Length; i++)
            {
                for (int x = 0; x <data.Length - 1; x++)
                {
                    string[] NIM1 = data[x].Split('|');
                    string[] NIM2 = data[x + 1].Split('|');
                    if (Convert.ToInt32(NIM1[0]) > Convert.ToInt32(NIM2[0]))
                    {
                        string swap = data[x];
                        data[x] = data[x + 1];
                        data[x + 1] = swap;
                    }
                }
            }
            return data;
        }

      //sort by price asc
      public string[] bubblePriceAsc(string[] data)
      {
            for (int i = 0; i <data.Length; i++)
            {
                for (int x = 0; x <data.Length - 1; x++)
                {
                    string[] kompen1 = data[x].Split('|');
                    string[] kompen2 = data[x + 1].Split('|');
                    if (Convert.ToInt32(kompen1[3]) >Convert.ToInt32(kompen2[3]))
                    {
                        string swap = data[x];
                        data[x] = data[x + 1];
                        data[x + 1] = swap;
                    }
                }
            }
            return data;
      }

        //sort by price desc
    public string[] bubblePriceDesc(string[] data)
    {
        for (int i = 0; i <data.Length; i++)
        {
            for (int x = 0; x <data.Length - 1; x++)
            {
                string[] kompen1 = data[x].Split('|');
                string[] kompen2 = data[x + 1].Split('|');
                if (Convert.ToInt16(kompen1[3]) <Convert.ToInt16(kompen2[3]))
                {
                    string swap = data[x];
                    data[x] = data[x + 1];
                    data[x + 1] = swap;
                }
            }
        }
        return data;
    }
  }
}
