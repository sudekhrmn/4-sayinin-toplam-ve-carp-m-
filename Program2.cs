Console.WriteLine("1. sayıyı giriniz");
int sayi1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz");
int sayi2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("3. sayıyı giriniz");
int sayi3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("4. sayıyı giriniz");
int sayi4 = Int32.Parse(Console.ReadLine());

int toplam = sayi1 + sayi2 + sayi3 + sayi4;
int carpım = sayi1 * sayi2 * sayi3 * sayi4;

Console.WriteLine("girilen sayıların toplamı: " + toplam);
Console.WriteLine("girilen sayıların çarpımı: " + carpım);

Console.ReadKey();