int sayac = 0; //Doğru cevap sayısını toplaması için sayaç değişkeni tanımladık.
int toplam = 0; //Sayaç değişkenlerinin toplamını tutması için toplam değişkeni tanımladık.


Console.WriteLine("1- Hangisi periyodik tabloda bulunan bir element değildir?\n a) Su\n b) Azot\n");
string soru1 = (Console.ReadLine().ToLower()); //Büyük - küçük harf duyarlılığı için ToLower kullanıldı.

if (soru1 == "a") //Birinci sorunun cevabı doğru ise sayaç değişkeni 1 artacak. Değil ise "Cevap Yanlış" mesajı görülecek.
{
    Console.WriteLine("\nCevap Doğru");
    sayac = sayac + 1;
    toplam = sayac + toplam;
}
else
{
    Console.WriteLine("\nCevap Yanlış");
}


Console.WriteLine("\n1- Hangisi bir hücrede bulunan organeldir?\n a) RNA\n b) Lizozom\n");
string soru2 = (Console.ReadLine().ToLower());

if (soru2 == "b")
{
    Console.WriteLine("\nCevap Doğru");
    sayac = sayac + 1;
    toplam = sayac + toplam;
}

else
{
    Console.WriteLine("\nCevap Yanlış");
}

if (toplam == 1) //Burada, eğer iki sorudan biri doğru ise bir sonraki soruyu sorduruyoruz. Değil ise üçüncü soru hiç sorulmadan "Yarışmayı kaybettiniz" mesajı görülüyor. Ya da iki sorunun cevabı da doğru ise "Yarışmayı kazandınız" mesajı görülüyor.
{
    Console.WriteLine("\n1- Kuyucaklı Yusuf adlı eser kime aittir?\n a) Sabahattin Ali\n b) Yaşar Kemal\n");
    string soru3 = (Console.ReadLine().ToLower());

    if (soru3 == "a")
    {
        Console.WriteLine("\nCevap Doğru");
        sayac = sayac + 1;
        toplam = sayac + toplam;
    }

    else
    {
        Console.WriteLine("\nCevap Yanlış");
    }
}


Console.WriteLine(toplam == 3 ? "\nBüyük Ödülü Kazandınız!" : "\nBüyük Ödülü Kaybettiniz!"); //Son olarak toplam doğru sayısı 3 ise; "Kazandınız", değil ise; "Kaybettiniz" mesajı görülecek.