internal class Program
{
    private static void Main(string[] args)
    {
        // //1.Soru

        // Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
        // int sayi1 = int.Parse(Console.ReadLine());
        // int[] sayiDizisi1 = new int[sayi1];
        // Console.WriteLine("{0} adet pozitif sayı girmeniz istenecek.",sayi1);
        // for (int i = 0; i < sayiDizisi1.Length; i++)
        // {
        //     Console.WriteLine("Lütfen {0}. sayıyı giriniz.",(i+1));
        //     sayiDizisi1[i] = int.Parse(Console.ReadLine());
        // }
        // Console.WriteLine("Girmiş olduğunuz sayılar arasında çift olanlar:");
        // for (int i = 0; i < sayiDizisi1.Length; i++)
        // {
        //     if(sayiDizisi1[i] % 2 == 0)
        //     {
        //         Console.WriteLine(sayiDizisi1[i]);
        //     }
        // }
        // //1.Soru sonu

        // //2.Soru
        // Console.WriteLine("Lütfen iki adet pozitif sayı giriniz.");
        // Console.WriteLine("Lütfen birinci pozitif sayıyı giriniz.");
        // int sayi2 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Lütfen ikinci pozitif sayıyı giriniz.");
        // int sayi3 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Lütfen {0} adet pozitif sayı daha giriniz.", sayi2);
        // int[] sayiDizisi2 = new int[sayi2];
        // for (int i = 0; i < sayiDizisi2.Length; i++)
        // {
        //     Console.WriteLine("Lütfen {0}. sayıyı giriniz.",(i+1));
        //     sayiDizisi2[i] = int.Parse(Console.ReadLine()); 
        // }
        // Console.WriteLine("Girdiğiniz sayılardan {0}'ye eşit olanlar ve tam bölenleri aşağıdadır.",sayi3);
        // for (int i = 0; i < sayiDizisi2.Length; i++)
        // {
        //     if(sayiDizisi2[i] == sayi2)
        //     {
        //         Console.WriteLine(sayiDizisi2[i]);
        //     }
        //     else if(sayi2 % sayiDizisi2[i] == 0 )
        //     {
        //         Console.WriteLine(sayiDizisi2[i]);
        //     }
        // }
        // //2.Soru sonu


        // //3.Soru
        // Console.WriteLine("Lütfen bir adet pozitif sayı giriniz");
        // int sayi4 = int.Parse(Console.ReadLine());
        // string[] kelimeDizisi1 = new string[sayi4];
        // Console.WriteLine("Lütfen {0} adet kelime giriniz",sayi4);
        
        // for (int i = 0; i < kelimeDizisi1.Length; i++)
        // {
        //     Console.WriteLine("{0}. kelimeyi giriniz.", (i+1));
        //     kelimeDizisi1[i] = Console.ReadLine();
        // }
        // Console.WriteLine("Girdiğiniz kelimeler sondan başa tekrar yazdırılıyor.");
        // Array.Reverse(kelimeDizisi1);
        // for (int i = 0; i < kelimeDizisi1.Length; i++)
        // {
        //     Console.WriteLine(kelimeDizisi1[i]);
        // }
        // //3.Soru sonu


        //4.Soru
        Console.WriteLine("Lütfen bir cümle giriniz.");  
        string cumle = Console.ReadLine();
        char[] karakterler = new char[cumle.Length];
        int[] charsTemp = new int[karakterler.Length];
        int lastSpaces = 0;
        int spaces = 0;
        int kelime = 0;
        int harf = 0;
        for (int i = 0; i < karakterler.Length; i++)
        {
            karakterler[i] = cumle[i];
        }  
        for (int i = 0; i < karakterler.Length; i++)
        {

            charsTemp[i] = (int)karakterler[i];

        }    
        for (int i = (charsTemp.Length - 1); i>= 0; i--)
        {

            if(charsTemp[i] == 32)
            {
                charsTemp[i] = 0;
                lastSpaces++;
            }
            else
            {
                break;
            }

        } 
        for (int i = 0; i < charsTemp.Length; i++)
        {

            if(charsTemp[i] == 32)
            {
                charsTemp[i] = 0;
                spaces++;
            }
            if(charsTemp[i] != 32 && charsTemp[i] != 0)
            {
                harf++;
            }

        }
        kelime = spaces+1;

        Console.WriteLine("Cümleniz {0} kelime, {1} harften oluşmaktadır.", kelime, harf);
        
         

        
        //4.Soru sonu

    }
}