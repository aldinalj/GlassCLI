using System;
namespace Glass {
        public static class Meny {            
            public static void meny() {
                Console.Clear();
                Console.WriteLine("Glasspriser:\nVaniljglass 32kr/L\nChokladglass 34kr/L\nJordgubbsglass 31kr/L\nLakritsglass 35kr/L\n" + 
                    "Päronglass 30kr/L\nRocky road 37kr/L\nMangosorbet 39kr/L\nHallonsorbet 39kr/L\nRomrussin 36kr/L");

                Console.WriteLine("\nTryck enter för att gå tillbaka till menyn!");
                Console.ReadKey();
         }
    }
}

