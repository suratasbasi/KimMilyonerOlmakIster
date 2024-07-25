
using System.Threading.Channels;
int dogruCevap = 0;       // Verilen doğru cevapların sayısını kontrol etmek için int değişkeni olarak atama yapıyorum.


// Metinlerin sıkışık görünmemesi için aralara boş satırlar ekledim.
Console.WriteLine("Kim Milyoner Olmak İster yarışmasına hoş geldiniz.");
Console.WriteLine("");
Console.WriteLine("2 cevap şıklı toplam 3 adet sorudan oluşan yarışmamızda en az 2 adet soruya doğru cevap verdiğiniz takdirde 1 Milyon TL'lik büyük ödülün sahibi sizsiniz! ");
Console.WriteLine("");
Console.WriteLine("Hazırsanız yarışma başlasın!");
Console.WriteLine("");
Console.WriteLine("İşte ilk sorunuz geliyor: ");



// 1.soru
Console.WriteLine("Kızınca güneşe tüküren hayvan hangisidir ? ");
Console.WriteLine("");
Console.WriteLine("a) Lama        b) Deve");
Console.WriteLine("");
Console.Write("Cevabınız: ");
string cevap = Console.ReadLine().ToLower();      // Kullanıcı sorunun cevabını girerken hatasız algılanması için büyük/küçük harf duyarlılığını kaldırıyorum.

if (cevap == "a")
{   dogruCevap++;         // En başta doğru cevaba yaptığımız 0 atamaya şimdi soru doğru yanıtlanınca +1 ekliyoruz.
    Console.WriteLine("Doğru cevap");}

else
{ Console.WriteLine("Yanlış cevap"); }



// 2.soru
Console.WriteLine("");
Console.WriteLine("Dünya'ya en yakın gezegen hangisidir ? ");
Console.WriteLine("");
Console.WriteLine("a) Venüs        b) Mars");
Console.WriteLine("");
Console.Write("Cevabınız: ");
string cevap2 = Console.ReadLine().ToLower();

if (cevap2 == "a")
{   dogruCevap++;
    Console.WriteLine("Doğru cevap"); }

else
{ Console.WriteLine("Yanlış cevap"); }




// 3.soru
if (dogruCevap >= 1)       // Eğer doğru cevap sayısı en az 1 ise 3. sorunun açılması için koşul oluşturuyoruz. 2 soruya da yanlış cevap verilmişse 3. soru açılmayacak ve direkt son kısımdaki yarışma sonucu mesajları yayınlanacak.
{

    Console.WriteLine("");
    Console.WriteLine("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? ");
    Console.WriteLine("");
    Console.WriteLine("a) 7       b) 12");
    Console.WriteLine("");
    Console.Write("Cevabınız: ");
    string cevap3 = Console.ReadLine().ToLower();

    if (cevap3 == "b")
    {
        dogruCevap++;
        Console.WriteLine("Doğru cevap");
    }

    else     
    {
        Console.WriteLine("Yanlış cevap");
    }
}



// Yarışma sonucu mesajlarında kaç soruya doğru yanıt verdiyse ona göre mesaj yayınlanması için ayrı ayrı koşul oluşturuyorum.

if (dogruCevap > 2)   
{
    Console.WriteLine("");
    Console.WriteLine("Tebrikler! Tüm soruları doğru cevaplayarak yarışmayı kazandınız ve büyük ödülün sahibi sizsiniz."); }

else if (dogruCevap == 2)
{
    Console.WriteLine("");
    Console.WriteLine("Tebrikler! 2 soruya doğru yanıt vererek yarışmayı kazandınız ve büyük ödülün sahibi sizsiniz."); }

else
{
    Console.WriteLine(""); 
    Console.WriteLine("Maalesef yarışmayı kaybettiniz."); }


