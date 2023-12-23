using System;

class Zrakoplov
{
  
    private string Naziv;
    private double SnagaMotora;
    private int DosegLeta;

  
    public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
    {
        Naziv = naziv;
        SnagaMotora = snagaMotora;
        DosegLeta = dosegLeta;
    }


    public void IspisiPodatke()
    {
        Console.WriteLine($"Naziv: {Naziv}, Snaga motora: {SnagaMotora} kW, Doseg leta: {DosegLeta} km");
    }
}

class Program
{
    static void Main()
    {
        
        Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);


        Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);


        Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

       
        Console.WriteLine("Podaci o zrakoplovu x380:");
        x380.IspisiPodatke();

        Console.WriteLine("\nPodaci o zrakoplovu C162:");
        C162.IspisiPodatke();

        Console.WriteLine("\nPodaci o zrakoplovu PC-21:");
        PC21.IspisiPodatke();
    }
}
