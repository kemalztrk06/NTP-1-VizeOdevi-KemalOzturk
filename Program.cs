using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev evim = new Ev();
            evim.SetOdasayisi(-4);
            evim.Alan = 185;
            evim.Katno = 2;
            evim.Semt = "Sincan";

            Console.WriteLine(evim.EvBilgileriGetir());
            //FileStream fs = new FileStream("C:\\abc.txt", FileMode.Append);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("Deneme\r\n");
            //fs.Flush();
            //sw.Close();
            //fs.Close();
        
        }
    }
}
