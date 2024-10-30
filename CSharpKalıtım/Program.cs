using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKalıtım
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Egitmen E1 = new Egitmen();
			//Console.WriteLine("eğitmen nesnesi örneklendi");

			//boxing - object o1 = E1;  Ana tip kendisinden türüyen değeri tanır. kendi içerisinde parametre olarak kabul eder.
			//unboxing - E1 =(egitmen)o1; bunu tekrar temel tipe çevirmeye de unboxing diyoruz

			//object bütün classların kendisinden türediği bir nesnedir
			Personel P1 = new Personel();
			P1.TemelTipMetot1();

			Ogrenci O1 = new Ogrenci();
			O1.TemelTipMetot1();

			Object obj1 = O1; //tür dönüşümlerinde boxing uyuglamış olduk
			O1 = (Ogrenci)obj1; //unboxing

			TEST t1 = new TEST();
			//Sealed : bu nesnenin kalıtımı yapılamaz publicden sonre ekle

			//protected :Normal kullanımda private olarak tanımlanır. Kalıtım yolu  ile başka bir class içerisinde
		    //	Public olarak kullanılır.


		}

	}
}
