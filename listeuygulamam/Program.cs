using System;

class Program
{
    static void Main()
    {
        // Davetliler dizisi tanımlandı
        string[] davetliler = {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        // Başlık
        Console.WriteLine("** Davetliler **\n");

        // Foreach döngüsü ile davetliler listeleniyor
        int sira = 1;
        foreach (string kisi in davetliler)
        {
            Console.WriteLine($"{sira} - {kisi}");
            sira++;
        }

        // Programın sonu
        Console.WriteLine("\nPatika Plus gala gecesine davetlisiniz! 🎤✨");
    }
}
