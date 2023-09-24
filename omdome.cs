using System;
namespace Glass {
    public static class Kundomdome {
        public static void omdome() {
            while (true) {
                Console.Clear();
                try {
                    Console.WriteLine("Hur skulle du bedöma din upplevelse på en skala 1-5?");
                    int review = Convert.ToInt32(Console.ReadLine());
                    if (review >= 1 && review <= 5) {
                        Console.WriteLine("Du har gett omdömet: " + review + "! Tack för din åsikt!\nTryck enter för att gå tillbaka till menyn.");
                        Console.ReadKey();
                        return;
                    }
                    else {
                        felinmatning();
                    }
                }
                catch {
                    felinmatning();
                }
            }
        }

        public static void felinmatning() {
            Console.WriteLine("Du har skrivit in något felaktigt. Kolla så ditt tal är ett heltal och inom skalan. Tryck enter för att försöka igen");
            Console.ReadKey();
        }
    }
}