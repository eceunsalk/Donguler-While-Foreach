internal class Program
{
    private static void Main(string[] args)
    {
        //while - parantez içine yazılan ifade true olduğu sürece süslü parantez {} içine yazılan ifadeyi tekrar eder. 
        // 1'den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program.
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0; //ilk değer
    
        while (sayac<=sayi)
        {
            toplam+= sayac;
            sayac ++;

        }
        Console.WriteLine(toplam/sayi);
        // a'dan z'ye kadar tüm harfleri console'a yazdıralım.

        char character = 'a';
        while (character< 'z')
        {
            Console.Write(character);
            character ++;
        }
        // Foreach
        string[] arabalar = {"BMW","Ford","Toyota","Nissan"}; // string tipinde elemanları olan bir dizimiz var. bunu collection'a verdik.

        foreach (var araba in arabalar) //arabalar dizisinde dön, bu kod bloğu içerisinde arabaların her bir nesnesine item (örnekte araba dedik) ismiyle eriş. var tipi belli olmayan genel bir veri tipi. obje alabiliyor, tüm veri türlerini kapsıyor.
        {
            Console.WriteLine(araba);
        }
    }
}