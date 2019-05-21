using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "18.11.2350";
            mhs.nama = "Thariq Aulia Akbar";
            mhs.email = "thariq.2712@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data:");
            Console.WriteLine("1. JSON");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. CSV \n");

            Console.WriteLine("Nomor Format Data [1..3]: ");
            int formatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert;

            if (formatData == 1)
                convert = new ConvertToJson();
            else if (formatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            convert.Convert(mhs);
            Console.ReadKey();
        }
    }
}
