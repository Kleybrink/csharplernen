using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        public static int a = 10;

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    
    namespace Namensraum
    {
        class NamensraumKlasse
        {
            public static int b = 20;
        }

        namespace Namensraum2
        {
            class Namensraum2Klasse
            {
                public static int c = 30;
            }
        }
    }
}