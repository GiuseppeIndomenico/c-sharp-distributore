class Prelievo
{
    int[] numScelta = { 1, 2, 3, 4, 5, 6 };
    string[] bibite = { "coca", "pepsi", "fanta", "monster", "redbull", "acqua" };
    bool finishP = false;
    public void SceltaBibita()
    {
        while (!finishP)
        {
            Console.WriteLine("Puoi scegliere tra:");
            for (int i = 0; i < numScelta.Length; i++)
            {
                Console.WriteLine($"{numScelta[i]}-{bibite[i]}");
            }
            Console.WriteLine("9 - Per uscire");

            string inputUtente = Console.ReadLine();

            if (string.IsNullOrEmpty(inputUtente))
            {
                Console.WriteLine("\nInput vuoto. Inserisci un numero valido o 9 per uscire.\n");
                continue;
            }

            if (!int.TryParse(inputUtente, out int sceltaUtente))
            {
                Console.WriteLine("\nInput non valido. Inserisci un numero valido o 9 per uscire.\n");
                continue;
            }

            sceltaUtente--;

            if (sceltaUtente == 8)
            {
                finishP = true;
            }
            else if (sceltaUtente >= 0 && sceltaUtente <= 5)
            {
                Console.WriteLine($"\nHai scelto: {bibite[sceltaUtente]}");
            }
            else
            {
                Console.WriteLine("Scelta non disponibile. Riprova.");
            }
        }
    }

}
