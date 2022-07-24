using ConsoleEmlakApp;

mainMenu:
    Satılık s = new Satılık();
    Kiralık k = new Kiralık();
    Console.WriteLine("Emlak Programı");
    Console.WriteLine("1: Satılık Ev");
    Console.WriteLine("2: Kiralık Ev");
    string pressed = Console.ReadLine();
    switch (pressed)
    {
        case "1": goto satilikEv;
        case "2": goto kiralıkEv;
    }
satilikEv:
    Console.WriteLine("İl giriniz:");
    s.il = Console.ReadLine();
    Console.WriteLine("İlçe giriniz:");
    s.ilçe = Console.ReadLine();
    Console.WriteLine("Adres giriniz:");
    s.adress = Console.ReadLine();
    Console.WriteLine("Isınma giriniz:");
    s.ısınma = Console.ReadLine();
    Console.WriteLine("Kat sayısı giriniz:");
    s.katSayisi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Kredi çekme tutarı giriniz:");
    s.krediTutar = Convert.ToInt32(Console.ReadLine());
    goto bilgiler;

kiralıkEv:
    Console.WriteLine("İl giriniz:");
    k.il = Console.ReadLine();
    Console.WriteLine("İlçe giriniz:");
    k.ilçe = Console.ReadLine();
    Console.WriteLine("Adres giriniz:");
    k.adress = Console.ReadLine();
    Console.WriteLine("Isınma giriniz:");
    k.ısınma = Console.ReadLine();
    Console.WriteLine("Kat sayısı giriniz:");
    k.katSayisi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Depozito tutarı giriniz:");
    k.depozito = Convert.ToInt32(Console.ReadLine());
    goto bilgiler;
bilgiler:
    if (pressed == "1")
    {
        Console.WriteLine(s.il.ToUpper() + " - " + s.ilçe.ToUpper() + "\n" +
        s.adress.ToUpper() + "\n" + s.ısınma.ToUpper() + "\n" + s.katSayisi.ToString().ToUpper() + "\n" + s.krediTutar.ToString().ToUpper());
    }else
    {
        Console.WriteLine(k.il.ToUpper() + " - " + k.ilçe.ToUpper() + "\n" +
        k.adress.ToUpper() + "\n" + k.ısınma.ToUpper() + "\n" + k.katSayisi.ToString().ToUpper() + "\n" + k.depozito.ToString().ToUpper());
    }






