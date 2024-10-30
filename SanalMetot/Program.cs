using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Musteri M1 = new Musteri();
			string toMesaj = M1.ToString();
			Console.WriteLine(toMesaj);
			M1.isim = "cengiz";
			M1.soyisim = "dağlı";

			// sanal metod: virtual anahtar kelimesş kullandığımız zaman sanal metot olur override ile bu sınıfı ezip kendi içerisindeki methpdu çalıştırır
			//abstract / interface olduğu zaman sınıfım örneklenemez
			//interface içeriisnde yapıcı metot kullanılmaz . şablondur
			// field methodlar delegate olur 
			//interface içerisinde değişken tanımı yapamayız ama property olur.
			//interface de hiçbir tanımın bodysi yok
		}
	}
}
