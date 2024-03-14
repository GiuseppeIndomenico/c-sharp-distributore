

class Distributore
{
    static void Main(string[] args)
    {
        SceltaProgramma sP = new SceltaProgramma();
        Console.Write("bevenuto al nostro distributore automatico! ");
        sP.Scelta();

        Console.WriteLine("grazie! e buona giornata");
    }
}