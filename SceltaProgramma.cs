using System.Reflection.PortableExecutable;

class SceltaProgramma
{

    public void Scelta()
    {
        bool finishChoice = false;
        while (!finishChoice)
        {
            Console.WriteLine("prema il numero corrispondente per iniziare l'operazione: \n1-Prelievo\n2-sostituzione");
            string sceltaS = Console.ReadLine();


            if (int.TryParse(sceltaS, out int scelta))
            {
                if (scelta != 1 && scelta != 2)
                {
                    Console.WriteLine("\nhai digitato un numero senza opzione\n");
                }
                else
                {
                    if (scelta == 1)
                    {
                        Prelievo p = new Prelievo();
                        Console.WriteLine("\nhai premuto il tasto per scegliere la bevanda");
                        p.SceltaBibita();
                        finishChoice = true;
                    }
                    else
                    {
                        Sostituzione s = new Sostituzione();
                        Console.WriteLine("\nhai premuto il tasto per la sostituzione delle bibite");
                        s.Identificazione();
                        finishChoice = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("\ninserire valore valido\n");
            }

        }
    }
}