using System;
using System.Collections.Generic;
namespace Glass {
    public static class Bestalla {
        
        static Boolean running;

        // Listor för att bygga varukorgen
        static List<string> choosenProducts = new List<string>();
        static List<int> pricesOfProducts = new List<int>();

        public static void bestalla () {
            running = true;
            string[] menuOptions = new string[] {"Vaniljglass\t", "Chokladglass\t", "Jordgubbsglass\t", "Lakritsglass\t",
                    "Päronglass\t", "Rocky road\t", "Mangosorbet\t", "Hallonsorbet\t", "Romrussin\t", 
                    "\nGå till kassan\t", "Gå tillbaka till meny\t"};
            // Lägger priserna i en parallell array så att vi kan komma åt dem i kassan
            int[] prices = new int[] {32, 34, 31, 35, 30, 37, 39, 39, 36};

            // Placerar pilen på första valet
            int menuSelect = 0;

            // Döljer cursor
            Console.CursorVisible = false;

            while (running) {

                Console.Clear();

                Console.WriteLine("------------------Produkter------------------");
                Console.WriteLine("             (En liter per burk)");

                for (int i = 0; i < menuOptions.Length; i++) {
                    if (menuSelect == i) {
                        // Bestämmer utskrift beroende på vilken typ av alternativ
                        if (i >= menuOptions.Length - 2) {
                            Console.WriteLine(menuOptions[i] + "<--");
                        }
                        else {
                            Console.WriteLine(menuOptions[i] + " " + prices[i] + "kr <-- Lägg till");
                        }
                    }
                    else {
                        // Bestämmer utskrift beroende på vilken typ av alternativ
                        if (i >= menuOptions.Length - 2) {
                            Console.WriteLine(menuOptions[i]);
                        }
                        else {
                            Console.WriteLine(menuOptions[i] + " " + prices[i] + "kr");
                        }

                    }
                }

                Console.WriteLine("------------------Varukorg------------------");
                for (int i = 0; i < choosenProducts.Count; i++) {
                    Console.WriteLine(choosenProducts[i]);
                }
                
                // Inväntar knapptryck
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length -1) {
                    menuSelect++;
                }

                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1) {
                    menuSelect--;
                }

                else if (keyPressed.Key == ConsoleKey.Enter) {
                    if (menuSelect == menuOptions.Length - 1) {
                        GoBack();
                    }       
                    else if (menuSelect == menuOptions.Length - 2) {
                        if (Kassa.kassa(choosenProducts, pricesOfProducts)) {
                            choosenProducts = new List<string>();
                            pricesOfProducts = new List<int>();
                            GoBack();
                        }
                    } 
                    else {
                        choosenProducts.Add(menuOptions[menuSelect]);
                        pricesOfProducts.Add(prices[menuSelect]);
                    }
                }
            }
        }

        public static void GoBack() {
            // Gör så att loopen avslutas och därmed funktionen
            running = false;
        }
    }
}

