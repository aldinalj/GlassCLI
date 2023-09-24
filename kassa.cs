using System;
using System.Collections.Generic;
namespace Glass {
    public static class Kassa {     
        public static Boolean kassa(List<string> products, List<int> prices) {
            Console.Clear();
            
            int totalPrice = 0;
            
            for (int i = 0; i < products.Count; i++) {
                totalPrice += prices[i];
            }

            string[] menuOptions = new string[] {"Godkänn\t", "Avbryt\t"};
            int menuSelect = 0;

            while (true) {
                Console.Clear();
                for (int i = 0; i < products.Count; i++) {

                    // Vi skriver ut valda produkter samt respektive pris (lägger ihop olika strings - konkatenerar) 
                    Console.WriteLine(products[i] + " " + prices[i] + "kr");
                }
                Console.WriteLine("\nDin slutsumma blir: " + totalPrice + "kr");

                for (int i = 0; i < menuOptions.Length; i++) {
                    if (menuSelect == i) {
                        Console.WriteLine(menuOptions[i] + "<--");
                    }
                    else {
                        Console.WriteLine(menuOptions[i]);
                    }
                }

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length -1) {
                    menuSelect++;
                }

                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1) {
                    menuSelect--;
                }

                else if (keyPressed.Key == ConsoleKey.Enter) {
                    if (menuSelect == 0) {
                        Console.Clear();
                        Console.WriteLine("Din beställning är nu gjord!");
                        Console.WriteLine("\nTryck enter för att gå tillbaka till menyn!");
                        Console.ReadKey();
                        return true;
                    }       
                    else if (menuSelect == 1) {
                        return false;
                    } 
                }
            }
        }
    }
}