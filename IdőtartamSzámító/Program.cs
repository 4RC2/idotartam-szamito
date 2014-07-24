using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdőtartamSzámító
{
    class Program
    {
        public static Boolean márVolt = false;
        public static Boolean másodpercÍrás = false;

        public static DateTime jelenlegiIdő = DateTime.Now;

        public static Int32 programMód;
        public static String programMódNév;

        public static String bevittKarakterek;
        public static Boolean típusMegfelelő;

        public static Int32 eseményÉv;
        public static Int32 eseményHónap;
        public static Int32 eseményNap;
        public static Int32 eseményÓra;
        public static Int32 eseményPerc;
        public static DateTime eseményIdő;

        public static TimeSpan elteltIdő;
        public static TimeSpan hátralévőIdő;

        public static void InfóKiírás()
        {
            Console.Clear();

            if (programMód > 0 && programMód < 3)
            {
                Console.WriteLine("[ Programmód: (" + programMód + "): " + programMódNév + " ]");
            }

            if (másodpercÍrás == false)
            {
                Console.WriteLine("[ Jelenlegi idő: kb. " + jelenlegiIdő.ToString("yyyy.MM.dd HH:mm") + " ]");
            }
            else if (másodpercÍrás == true)
            {
                Console.WriteLine("[ Jelenlegi idő: " + jelenlegiIdő.ToString("yyyy.MM.dd HH:mm:ss") + " ]");
            }

            if (eseményIdő.Ticks > 0 )
            {
                Console.WriteLine("[ Esemény ideje: " + eseményIdő.ToString("yyyy.MM.dd HH:mm") + " ]");
            }

            Console.WriteLine("");
        }

        public static void ProgramMódVálasztás()
        {
            Console.WriteLine("Programmód választása:");
            Console.WriteLine("(1): Eltelt idő kiszámítása");
            Console.WriteLine("(2): Hátralévő idő kiszámítása");
            Console.Write("> ");
            bevittKarakterek = Console.ReadLine();

            típusMegfelelő = Int32.TryParse(bevittKarakterek, out programMód);

            if (típusMegfelelő == true && Int32.Parse(bevittKarakterek) > 0 && Int32.Parse(bevittKarakterek) < 3)
            {
                programMód = Int32.Parse(bevittKarakterek);

                if (programMód == 1)
                {
                    programMódNév = "Eltelt idő kiszámítása";
                }
                else if (programMód == 2)
                {
                    programMódNév = "Hátralévő idő kiszámítása";
                }
            }
            else if (típusMegfelelő == false)
            {
                Hiba_TípusNemInt32();
                InfóKiírás();
                ProgramMódVálasztás();
            }
            else
            {
                Hiba_ÉrtékNemMegfelelő();
                InfóKiírás();
                ProgramMódVálasztás();
            }
        }

        public static void EseményÉvBevitel()
        {
            Console.WriteLine("Esemény megadása : év");
            Console.Write("> ");
            bevittKarakterek = Console.ReadLine();

            típusMegfelelő = int.TryParse(bevittKarakterek, out eseményÉv);

            if (típusMegfelelő == true && Int32.Parse(bevittKarakterek) > 0 && Int32.Parse(bevittKarakterek) < 10000)
            {
                eseményÉv = Int32.Parse(bevittKarakterek);
            }
            else if (típusMegfelelő == false)
            {
                Hiba_TípusNemInt32();
                InfóKiírás();
                EseményÉvBevitel();
            }
            else
            {
                Hiba_ÉrtékNemMegfelelő();
                InfóKiírás();
                EseményÉvBevitel();
            }
        }

        public static void EseményHónapBevitel()
        {
            Console.WriteLine("Esemény megadása : hónap");
            Console.Write("> ");
            bevittKarakterek = Console.ReadLine();

            típusMegfelelő = int.TryParse(bevittKarakterek, out eseményHónap);

            if (típusMegfelelő == true && Int32.Parse(bevittKarakterek) > 0 && Int32.Parse(bevittKarakterek) < 13)
            {
                eseményHónap = Int32.Parse(bevittKarakterek);
            }
            else if (típusMegfelelő == false)
            {
                Hiba_TípusNemInt32();
                InfóKiírás();
                EseményHónapBevitel();
            }
            else
            {
                Hiba_ÉrtékNemMegfelelő();
                InfóKiírás();
                EseményHónapBevitel();
            }
        }

        public static void EseményNapBevitel()
        {
            Console.WriteLine("Esemény megadása : nap");
            Console.Write("> ");
            bevittKarakterek = Console.ReadLine();

            típusMegfelelő = int.TryParse(bevittKarakterek, out eseményNap);

            if (típusMegfelelő == true && Int32.Parse(bevittKarakterek) > 0 && Int32.Parse(bevittKarakterek) < 32)
            {
                eseményNap = Int32.Parse(bevittKarakterek);
            }
            else if (típusMegfelelő == false)
            {
                Hiba_TípusNemInt32();
                InfóKiírás();
                EseményNapBevitel();
            }
            else
            {
                Hiba_ÉrtékNemMegfelelő();
                InfóKiírás();
                EseményNapBevitel();
            }
        }

        public static void EseményÓraBevitel()
        {
            Console.WriteLine("Esemény megadása : óra");
            Console.Write("> ");
            bevittKarakterek = Console.ReadLine();

            típusMegfelelő = int.TryParse(bevittKarakterek, out eseményÓra);

            if (típusMegfelelő == true && Int32.Parse(bevittKarakterek) >= 0 && Int32.Parse(bevittKarakterek) < 24)
            {
                eseményÓra = Int32.Parse(bevittKarakterek);
            }
            else if (típusMegfelelő == false)
            {
                Hiba_TípusNemInt32();
                InfóKiírás();
                EseményÓraBevitel();
            }
            else
            {
                Hiba_ÉrtékNemMegfelelő();
                InfóKiírás();
                EseményÓraBevitel();
            }
        }

        public static void EseményPercBevitel()
        {
            Console.WriteLine("Esemény megadása : perc");
            Console.Write("> ");
            bevittKarakterek = Console.ReadLine();

            típusMegfelelő = int.TryParse(bevittKarakterek, out eseményPerc);

            if (típusMegfelelő == true && Int32.Parse(bevittKarakterek) >= 0 && Int32.Parse(bevittKarakterek) < 60)
            {
                eseményPerc = Int32.Parse(bevittKarakterek);
            }
            else if (típusMegfelelő == false)
            {
                Hiba_TípusNemInt32();
                InfóKiírás();
                EseményPercBevitel();
            }
            else
            {
                Hiba_ÉrtékNemMegfelelő();
                InfóKiírás();
                EseményPercBevitel();
            }
        }

        public static void Hiba_TípusNemInt32()
        {
            Console.WriteLine("");
            Console.Write("<( A bevitt adat típusa nem megfelelő. ) ");
            Console.ReadKey();
        }

        public static void Hiba_ÉrtékNemMegfelelő()
        {
            Console.WriteLine("");
            Console.Write("<( A bevitt szám értéke nem megfelelő. ) ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ElteltIdőSzámítás()
        {
            jelenlegiIdő = DateTime.Now;
            elteltIdő = jelenlegiIdő - eseményIdő;

            Console.Clear();
            InfóKiírás();
            Console.WriteLine("Eltelt idő:");
            Console.WriteLine("");
            if (elteltIdő.Ticks > 0)
            {
                if (DateTime.IsLeapYear(eseményÉv))
                {
                    Console.WriteLine((elteltIdő.TotalDays / 366).ToString("0.#####0") + " év");
                }
                else if (!DateTime.IsLeapYear(eseményÉv))
                {
                    Console.WriteLine((elteltIdő.TotalDays / 365).ToString("0.#####0") + " év");
                }
                Console.WriteLine(elteltIdő.TotalDays.ToString("0.####0") + " nap");
                Console.WriteLine(elteltIdő.TotalHours.ToString("0.###0") + " óra");
                Console.WriteLine(elteltIdő.TotalMinutes.ToString("0.##0") + " perc");
                Console.WriteLine(elteltIdő.TotalSeconds.ToString("0.#0") + " másodperc");
            }
            else
            {
                Console.WriteLine("0 év");
                Console.WriteLine("0 nap");
                Console.WriteLine("0 óra");
                Console.WriteLine("0 perc");
                Console.WriteLine("0 másodperc");
            }
            Console.WriteLine("");
            Console.Write("<( Tartsa lenyomva valamelyik billentyűt az automatikus újraszámításhoz! ) ");
            Console.ReadKey();
            ElteltIdőSzámítás();
        }

        public static void HátralévőIdőSzámítás()
        {
            jelenlegiIdő = DateTime.Now;
            hátralévőIdő = eseményIdő - jelenlegiIdő;

            InfóKiírás();
            Console.WriteLine("Hátralévő idő:");
            Console.WriteLine("");
            if (hátralévőIdő.Ticks > 0)
            {
                if (DateTime.IsLeapYear(eseményÉv))
                {
                    Console.WriteLine((hátralévőIdő.TotalDays / 366).ToString("0.#####0") + " év");
                }
                else if (!DateTime.IsLeapYear(eseményÉv))
                {
                    Console.WriteLine((hátralévőIdő.TotalDays / 365).ToString("0.#####0") + " év");
                }
                Console.WriteLine(hátralévőIdő.TotalDays.ToString("0.####0") + " nap");
                Console.WriteLine(hátralévőIdő.TotalHours.ToString("0.###0") + " óra");
                Console.WriteLine(hátralévőIdő.TotalMinutes.ToString("0.##0") + " perc");
                Console.WriteLine(hátralévőIdő.TotalSeconds.ToString("0.#0") + " másodperc");
            }
            else
            {
                Console.WriteLine("0 év");
                Console.WriteLine("0 nap");
                Console.WriteLine("0 óra");
                Console.WriteLine("0 perc");
                Console.WriteLine("0 másodperc");
            }
            Console.WriteLine("");
            Console.Write("<( Tartsa lenyomva valamelyik billentyűt az automatikus újraszámoláshoz! ) ");
            Console.ReadKey();
            HátralévőIdőSzámítás();
        }

        static void Main(string[] args)
        {
            másodpercÍrás = false;

            if (márVolt == false)
            {
                InfóKiírás();
                ProgramMódVálasztás();
            }

            InfóKiírás();
            EseményÉvBevitel();

            InfóKiírás();
            EseményHónapBevitel();

            InfóKiírás();
            EseményNapBevitel();

            InfóKiírás();
            EseményÓraBevitel();

            InfóKiírás();
            EseményPercBevitel();

            if (eseményÉv == 1 && eseményHónap == 1 && eseményNap == 1 && eseményÓra == 0 && eseményPerc == 0)
            {
                Console.WriteLine("");
                Console.Write("<( A megadott dátum (0001.01.01. 00:00) nem megfelelő. ) ");
                Console.ReadKey();
                márVolt = true;
                Main(args);
            }
            else
            {
                eseményIdő = new DateTime(eseményÉv, eseményHónap, eseményNap, eseményÓra, eseményPerc, 0);
                másodpercÍrás = true;

                if (programMód == 1)
                {
                    ElteltIdőSzámítás();
                }
                else if (programMód == 2)
                {
                    HátralévőIdőSzámítás();
                }
            }
        }
    }
}
