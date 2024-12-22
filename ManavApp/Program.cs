// Hoşgeldiniz ile karşılıyoruz.
using System.Linq.Expressions;

Console.WriteLine("Rüya Manavına Hoş Geldiniz.");

//Ürünlerin fiyatlarını giriyoruz.
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

//Hangi meyvei satın almak istediğini soruyoruz.
Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
//Burada da konsol ekranından meyve ismi girmesini bekliyoruz ve oluşturduğumuz fruit değişkenine atıp ramde tutuyoruz.
string fruit = Console.ReadLine().ToLower(); //Girilen verinin hepsini küçük harfe çeviriyoruz ki karşılaştırabilelim.

//Burada karar yapıları blokları ile seçilen meyveyi bulıup fiyatı yazdırıyoruz.
//switch-case bloğu

switch (fruit)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyve Elma ve fiyatı 2 TL.");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyve Armut ve fiyatı 3 TL.");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyve Çilek ve fiyatı 2 TL.");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyve Muz ve fiyatı 3 TL.");
        break;
    default:
        Console.WriteLine("Seçimiz diğer meyvelere giriyor ve fiyatı 4 TL");
        break;
}
//if-else bloğu
//Bu iki bloktan birini kullanmamız gerekir.
//Birden fazla seçim şansı olduğu için switch-case bloğu kullanmak daha hızlı olacaktır.

//if (fruit == "elma")
//{
//    Console.WriteLine("Seçtiğiniz meyve Elma ve fiyatı 2 TL.");
//}
//else if (fruit == "armut")
//{
//    Console.WriteLine("Seçtiğiniz meyve Armut ve fiyatı 3 TL.");
//}
//else if (fruit == "çilek")
//{
//    Console.WriteLine("Seçtiğiniz meyve Çilek ve fiyatı 2 TL.");
//}
//else if (fruit == "muz")
//{
//    Console.WriteLine("Seçtiğiniz meyve Muz ve fiyatı 3 TL.");
//}
//else
//    Console.WriteLine("Seçimiz diğer meyvelere giriyor ve fiyatı 4 TL");

//En sonda teşekkür ekranı ile bitiriyoruz.
Console.WriteLine("Rüya manavı tercih etiğiniz için teşekkür ederiz.");
