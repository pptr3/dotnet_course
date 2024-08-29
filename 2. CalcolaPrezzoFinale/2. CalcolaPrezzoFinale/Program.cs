using System;

namespace GestioneScontiNegozio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chiamate di test con verifica
            VerificaCalcoloPrezzoFinale(50.0, 12, "", 540.0); // Test 1
            VerificaCalcoloPrezzoFinale(30.0, 7, "PROMO20", 159.6); // Test 2
            VerificaCalcoloPrezzoFinale(15.0, 3, "", 45.0); // Test 3
        }

        public static double CalcolaPrezzoFinale(double prezzoIniziale, int quantita, string codiceSconto = "")
        {
           
        }

        public static void VerificaCalcoloPrezzoFinale(double prezzoIniziale, int quantita, string codiceSconto, double risultatoAtteso)
        {
            double risultatoCalcolato = CalcolaPrezzoFinale(prezzoIniziale, quantita, codiceSconto);

            if (risultatoCalcolato == risultatoAtteso)
            {
                Console.WriteLine($"Test riuscito: Prezzo finale calcolato {risultatoCalcolato} è uguale al risultato atteso {risultatoAtteso}.");
            }
            else
            {
                Console.WriteLine($"Test fallito: Prezzo finale calcolato {risultatoCalcolato} non è uguale al risultato atteso {risultatoAtteso}.");
            }
        }
    }
}
