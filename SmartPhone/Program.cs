ISmartPhone hpBudi = new Iphone();

Fotografer fotografer = new Fotografer();
fotografer.Kerja(hpBudi);

hpBudi = new Samsung();
fotografer.Kerja(hpBudi);
interface ISmartPhone
{
    public void AmbilFoto();
}

class Iphone : ISmartPhone 
{
    public void AmbilFoto() 
    {
        Console.WriteLine("Iphone Mengaktifkan sensor kamera Prenium...*Cekrek");
    }

}

class Samsung : ISmartPhone
{
    public void AmbilFoto() 
    {
        Console.WriteLine("Samsung Mengaktifkan Fitur Beauty...*Cekrek!*");
    }
}

class Fotografer
{
    public void Kerja(ISmartPhone hp) 
    {
        hp.AmbilFoto();
    }
}
