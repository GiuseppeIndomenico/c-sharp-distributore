class Sostituzione
{
    string codice = "123456";
    public void Identificazione()
    {
        bool finishIdentify = false;
        while (!finishIdentify)
        {
            Console.WriteLine("inserire codice numerico da 6 cifre per avviare la sostituzione della merce:");
            string codiceUtente = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(codiceUtente))
            {
                Console.WriteLine("\nInserimento vuoto non consentito. Si prega di inserire un codice numerico da 6 cifre.\n");
            }
            else if (codiceUtente != codice)
            {
                Console.WriteLine("\ncodice inserito non valido");
            }
            else
            {
                finishIdentify = true;
                Console.WriteLine("\nCodice Corretto, sportello aperto per la sostituzione\n");
            }
        }
    }
}