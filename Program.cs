namespace gg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double credito;
            Console.WriteLine("Inserisci numero di telefono dela sim");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci credito della sim");
            credito = double.Parse(Console.ReadLine());
            CSim sim = new CSim(n, credito);
            int scelta;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Aggiungi telefonata");
                Console.WriteLine("2. Mostra dati SIM");
                Console.WriteLine("3. Calcola minuti totali");
                Console.WriteLine("4. info sim");
                Console.Write("Scelta: ");

                // Leggi la scelta
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 4)
                {
                    Console.WriteLine("Scelta non valida. Riprova:");
                }

                switch (scelta)
                {
                    case 1:
                        addCall(sim);
                        break;
                    case 2:
                        mostra(sim);
                        break;
                    case 3:
                        min(sim);
                        break;
                    case 4:
                        dati(sim);
                        break;
                }

            } while (scelta != 6);
        }
            static void addCall(CSim sim) {
            int numero;
            int durata;
            Console.WriteLine("Inserisci numero da chiamare");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci durata della chiamata");
            durata = int.Parse(Console.ReadLine());
            sim.aggiungiCall(numero, durata);
        }
        static void mostra(CSim sim)
        {
            Console.WriteLine(sim.mostra());
        }
        static void min(CSim sim)
        {
            Console.WriteLine(sim.minuti());
        }
        static void dati (CSim sim)
        {
            Console.WriteLine(sim.dati());
        }
    }
}
