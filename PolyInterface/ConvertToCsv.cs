﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInterface
{
    public class ConvertToCsv : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            string csv = string.Format("{0},{1},{2}", mhs.npm, mhs.nama, mhs.email);

            Console.WriteLine("Hasil Konversi ke csv :\n");
            Console.WriteLine(csv);
        }
    }
}
