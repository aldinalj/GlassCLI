using System;
namespace Glass {
    class MainClass {
        public static void Main (string[] args) {
            
            Console.Clear();
            Console.WriteLine("Hej och välkommen till Glass i Stora Lass! Tryck enter för att gå vidare.");
            Console.ReadKey();

            // Skapar en array av menyalternativen
            string[] menuOptions = new string[] {"Meny/våra priser\t", "Beställa\t", "Recept med glass\t", "Kundomdöme\t", "Kontaktinfo\t", "Avsluta\t"};

            // Väljer första indexet i arrayen vilket är valet "Meny/våra priser"
            int menuSelect = 0;

            //Döljer cursor
            Console.CursorVisible = false;

            while (true) {

                Console.Clear();

                if (menuSelect == 0) {
                    Console.WriteLine(menuOptions[0] + "<--");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }

                else if (menuSelect == 1) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1] + "<--");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }

                else if (menuSelect == 2) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2] + "<--");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }

                else if (menuSelect == 3) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3] + "<--");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }

                else if (menuSelect == 4) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4] + "<--");
                    Console.WriteLine(menuOptions[5]);
                }

                else if (menuSelect == 5) { 
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5] + "<--");
                }

                // Inväntar knapptryckning
                ConsoleKeyInfo keyPressed = Console.ReadKey();


                // Ökar menuselect så länge värdet inte stiger över högsta meny alternativet
                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1) {
                    menuSelect++;
                }

                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1) {
                    menuSelect--;
                }

                else if (keyPressed.Key == ConsoleKey.Enter) {
                    switch (menuSelect) {
                        case 0:
                            Meny.meny();
                            break;
                        case 1:
                            Bestalla.bestalla();
                            break;
                        case 2: 
                            Recept.recept();
                            break;
                        case 3:
                            Kundomdome.omdome();
                            break;
                        case 4:
                            Kontakt.kontaktinfo();
                            break;
                        case 5:
                            terminateProgram();
                            break;
                    }
                }
            }
        }
        public static void terminateProgram() {
            Console.WriteLine("Tryck enter för att avsluta programmet");
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(1);
        }
    }
}