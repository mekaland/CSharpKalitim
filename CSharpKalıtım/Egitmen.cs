using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKalıtım
{
	public sealed class Egitmen : temelTip
	{
        //temel tip içerisinde var olan fieldlar ve methodlar tamamiyle eğitmen classı tarafından
        //miras alınabilsin ve kullanılabilsin 
        public string Brans { get; set; }
        public int  BransSeviye { get; set; }

		public DateTime IsBaslangicTarih { get; set; }
		public DateTime IsBitisTarih { get; set; }
		public int IzinGunSayisi { get; set; }

        public Egitmen()
        {
            Console.WriteLine("eğitmen nesnesinin yapıcı metodu çalıştı");
        }
    }
}
