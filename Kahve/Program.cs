// See https://aka.ms/new-console-template for more information
Basla();

void Basla()


{

    Console.Clear();
    Console.WriteLine("İsmin ne");

    string ?ad = Console.ReadLine();
    //Console.WriteLine("Merhaba" + ad);
    Console.WriteLine($"Merhaba {ad}");
    Console.WriteLine("Kaç yaşındasın?");


    int yas = Convert.ToInt32(Console.ReadLine());
    if (yas < 18)
    {
        Console.WriteLine($"{ad} Kahveye giremezsin Daha {18 - yas} yılın var");

    }
    else if (yas >= 18)
    {
        Console.WriteLine($"{ad} kahveye hoşgeldin");

    }

    //int bekle = 18 - yas;

    Console.WriteLine("Devam için enter a basın");
    Console.ReadLine();
    Basla();
}


