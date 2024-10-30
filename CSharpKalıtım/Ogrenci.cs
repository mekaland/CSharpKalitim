using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKalıtım
{
	public class Ogrenci: temelTip
	{
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("öğrenci nesnesi çalıştı");
        }

    }
}
