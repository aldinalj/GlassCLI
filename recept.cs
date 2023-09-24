using System;
namespace Glass {
    public static class Recept {
        
        static Boolean running;

        public static void recept () {
            running = true;
            string[] menuOptions = new string[] {"Milkshake\t", "Marängsviss\t", "Glasstårta\t", "Gå tillbaka till meny\t"};

            // Väljer första indexet i arrayen vilket är valet "Utföra service"
            int menuSelect = 0;

            // Döljer cursor
            Console.CursorVisible = false;

            while (running) {

                Console.Clear();

                if(menuSelect == 0) {
                    Console.WriteLine(menuOptions[0] + "<--");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                }

                else if(menuSelect == 1) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1] + "<--");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                }

                else if(menuSelect == 2) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2] + "<--");
                    Console.WriteLine(menuOptions[3]);
                }

                else if(menuSelect == 3) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3] + "<--");
                }

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length -1) {
                    menuSelect++;
                }

                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1) {
                    menuSelect--;
                }

                else if (keyPressed.Key == ConsoleKey.Enter) {
                    switch (menuSelect) {
                        case 0:
                            FirstChoice();
                            break;
                        case 1:
                            SecondChoice();
                            break;
                        case 2: 
                            ThirdChoice();
                            break;
                        case 3:
                            FourthChoice();
                            break;
                    }
                }
            }
        }
        public static void FirstChoice() {
            Console.Clear();
            Console.WriteLine("Milkshake (2 glas):\n\nIngredienser:\n5dl mjölk\n0,5L vaniljglass(eller annan valfri glass)\n1dl grädde\n\nHur man gör:\n1. Blanda glass och mjölk i mixer.\n" +
                "2. Häll upp i glas.\n3. Vispa grädde.\n4. Häll grädde i samma glas och toppa med strössel, kolasås eller annan önskad garnering!");
            Console.WriteLine("\nTryck enter för att gå tillbaka till recept!");
            Console.ReadKey();
        }
        public static void SecondChoice() {
            Console.Clear();
            Console.WriteLine("Marängsviss (6 portioner):\n\nIngredienser:\n3 dl vispgrädde\n120 g maränger\n1L vaniljglass\n2 skivade bananer\n1 dl rostade mandelspån\n\nHur man gör:\n" + 
                "1. Vispa grädde.\n2. Ta fram en stor skål och häll i glass, maränger, grädde, bananer och mandelspån. 3. Strö över strössel, choklasås, marshmallows eller annan önskad garnering!");
            Console.WriteLine("\nTryck enter för att gå tillbaka till recept!");
            Console.ReadKey();
        }

        public static void ThirdChoice() {
            Console.Clear();
            Console.WriteLine("Glasstårta (8 bitar):\n\nIngredienser:\n5dl chokladglass(eller annan valfri glass)\n2 marängbottnar\n0,5msk hallon\n0,5dl hackade rostade hasselnötter\n\n" +
                "Hur man gör 1. Vispa glassen tills den blir mjuk. 2. Lägg ihop marändbottnarna med hälften av glassmeten emellan och resten ovanpå. 3. Låt stå i frys i minst 4 timmar. " +
                    "4. Ta fram tårtan och ställ in kylen i 30 minuter innan servering. 5. Garnera med hallonen och hasselnötterna eller annan önskad garnering!");
            Console.WriteLine("\nTryck enter för att gå tillbaka till recept!");
            Console.ReadKey();
        }

        public static void FourthChoice() {
            // Gör så att loopen avslutas och därmed funktionen
            running = false;
        }
    }
}
