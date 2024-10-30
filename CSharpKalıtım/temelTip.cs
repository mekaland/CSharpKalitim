using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKalıtım
{
	public class temelTip
	{
		public int id { get; set; }
		public string referansKod { get; set; }
		public string tcKimlikNumarasi { get; set; }
		public string isim {  get; set; }
		public string soyisim { get; set; }
		public int cinsiyet {  get; set; }
		public DateTime kayitTarih { get; set; }
		public int kayitKullanici { get; set; }
		public DateTime guncellemeTarih { get; set; }
		public int guncellemeKullanci { get; set; }
		public bool silindi { get; set; }

        public temelTip()
        {
			Console.WriteLine("temel tip nesnesinin yapıcı metodu çalıştı");
        }
		public void TemelTipMetot1()
		{
			Console.WriteLine("temel tip metot1");
		}
    }
}
