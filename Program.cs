using System.Text;

namespace milliomos
{
    internal class Program
    {

        static Random rnd = new Random();
        static List<Kerdes> Kerdesek_List = new List<Kerdes>();
        static int kor = 0;

        static bool felezes = false;
        static bool kozonseg = false;
        static bool telefon = false;

        static void beolvasas()
        {
            StreamReader sr = new StreamReader(@"LOM.txt", encoding: Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                Kerdesek_List.Add(new Kerdes(sr.ReadLine()));
            }

            sr.Close();

        }

        static void korok()
        {
            Console.Clear();
            kor++;
            Kerdes kerd = Kerdesek_List[rnd.Next(0, Kerdesek_List.Count())];

            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("14:       40.000.000");
            Console.WriteLine("13:       20.000.000");
            Console.WriteLine("12:       10.000.000");
            Console.WriteLine("11:       5.000.000");
            Console.WriteLine("10:       3.000.000");
            Console.WriteLine("9 :       1.500.000");
            Console.WriteLine("8 :       800.000");
            Console.WriteLine("7 :       300.000");
            Console.WriteLine("6 :       200.000");
            Console.WriteLine("5 :       100.000");
            Console.WriteLine("4 :       50.000");
            Console.WriteLine("3 :       25.000");
            Console.WriteLine("2 :       10.000");
            Console.WriteLine("1 :       5.000\n");
            Console.WriteLine("------------------------------------\n");

            Console.WriteLine($"{kor}.\t{kerd.kerd}");

            Console.WriteLine($"\nA) {kerd.Aop}\nB) {kerd.Bop} \nC) {kerd.Cop} \nD) {kerd.Dop}");
            if (felezes == false)
            {
                Console.Write("Felezés(F) ");
            }
            if (telefon == false)
            {
                Console.Write("Telefonos(T) ");
            }
            if (kozonseg == false)
            {
                Console.Write("Közönség(K) ");
            }
            Console.WriteLine("\n");

            Console.Write("\nKérlek add meg a válaszodat vagy a felhasználni kívánt segítség betű jelét: ");
            string bekert = Console.ReadLine();
            if (bekert.ToUpper() == "F")
            {
                felezes = true;
                List<string> felezett = new List<string>();
                if (kerd.helyes == "A")
                {
                    felezett.Add(kerd.Aop);
                    int generalt = rnd.Next(0, 3);
                    if (generalt == 0)
                    {
                        felezett.Add(kerd.Bop);
                    }
                    if (generalt == 1)
                    {
                        felezett.Add(kerd.Cop);
                    }
                    if (generalt == 2)
                    {
                        felezett.Add(kerd.Dop);
                    }
                }
                else if (kerd.helyes == "B")
                {
                    felezett.Add(kerd.Bop);
                    int generalt = rnd.Next(0, 3);
                    if (generalt == 0)
                    {
                        felezett.Add(kerd.Aop);
                    }
                    if (generalt == 1)
                    {
                        felezett.Add(kerd.Cop);
                    }
                    if (generalt == 2)
                    {
                        felezett.Add(kerd.Dop);
                    }
                }
                else if (kerd.helyes == "C")
                {
                    felezett.Add(kerd.Cop);
                    int generalt = rnd.Next(0, 3);
                    if (generalt == 0)
                    {
                        felezett.Add(kerd.Aop);
                    }
                    if (generalt == 1)
                    {
                        felezett.Add(kerd.Bop);
                    }
                    if (generalt == 2)
                    {
                        felezett.Add(kerd.Dop);
                    }
                }
                else if (kerd.helyes == "D")
                {
                    felezett.Add(kerd.Dop);
                    int generalt = rnd.Next(0, 3);
                    if (generalt == 0)
                    {
                        felezett.Add(kerd.Aop);
                    }
                    if (generalt == 1)
                    {
                        felezett.Add(kerd.Bop);
                    }
                    if (generalt == 2)
                    {
                        felezett.Add(kerd.Cop);
                    }
                }
                List<string> Kerdesek = new List<string> { kerd.Aop, kerd.Bop, kerd.Cop, kerd.Dop };
                if (Kerdesek.IndexOf(felezett[1]) < Kerdesek.IndexOf(felezett[0]))
                {
                    string tmp = Kerdesek[0];
                    Kerdesek[0] = felezett[1];
                    Kerdesek[1] = tmp;
                }

                Console.Clear();

                Console.WriteLine("------------------------------------\n");
                Console.WriteLine("14:       40.000.000");
                Console.WriteLine("13:       20.000.000");
                Console.WriteLine("12:       10.000.000");
                Console.WriteLine("11:       5.000.000");
                Console.WriteLine("10:       3.000.000");
                Console.WriteLine("9 :       1.500.000");
                Console.WriteLine("8 :       800.000");
                Console.WriteLine("7 :       300.000");
                Console.WriteLine("6 :       200.000");
                Console.WriteLine("5 :       100.000");
                Console.WriteLine("4 :       50.000");
                Console.WriteLine("3 :       25.000");
                Console.WriteLine("2 :       10.000");
                Console.WriteLine("1 :       5.000\n");
                Console.WriteLine("------------------------------------\n");

                Console.WriteLine($"{kor}.\t{kerd.kerd}");

                string valasz1 = "";
                string valasz2 = "";

                if (Kerdesek.IndexOf(felezett[0]) == 0)
                {
                    valasz1 = "A";
                }
                else if (Kerdesek.IndexOf(felezett[0]) == 1)
                {
                    valasz1 = "B";
                }
                else if (Kerdesek.IndexOf(felezett[0]) == 2)
                {
                    valasz1 = "C";
                }
                if (Kerdesek.IndexOf(felezett[0]) == 3)
                {
                    valasz1 = "D";
                }

                if (Kerdesek.IndexOf(felezett[1]) == 0)
                {
                    valasz2 = "A";
                }
                else if (Kerdesek.IndexOf(felezett[1]) == 1)
                {
                    valasz2 = "B";
                }
                else if (Kerdesek.IndexOf(felezett[1]) == 2)
                {
                    valasz2 = "C";
                }
                if (Kerdesek.IndexOf(felezett[1]) == 3)
                {
                    valasz2 = "D";
                }

                Console.WriteLine($"\n{valasz1}) {felezett[0]} {valasz2}) {felezett[1]} ");
                if (felezes == false)
                {
                    Console.Write("Felezés(F) ");
                }
                if (telefon == false)
                {
                    Console.Write("Telefonos(T) ");
                }
                if (kozonseg == false)
                {
                    Console.Write("Közönség(K) ");
                }
                Console.WriteLine("\n");

                Console.Write("\nKérlek add meg a válaszodat: ");
                bekert = Console.ReadLine();

                if (bekert.ToUpper() == "A")
                {
                    if (kerd.helyes == "A")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "B")
                {
                    if (kerd.helyes == "B")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "C")
                {
                    if (kerd.helyes == "C")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "D")
                {
                    if (kerd.helyes == "D")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }

            }
            else if (bekert.ToUpper() == "T")
            {
                telefon = true;
                Console.WriteLine($"A telefonos segítség eredménye: {kerd.helyes}");
                Console.Write("\nKérlek add meg a válaszodat: ");
                bekert = Console.ReadLine();
                if (bekert.ToUpper() == "A")
                {
                    if (kerd.helyes == "A")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "B")
                {
                    if (kerd.helyes == "B")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "C")
                {
                    if (kerd.helyes == "C")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "D")
                {
                    if (kerd.helyes == "D")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
            }
            else if (bekert.ToUpper() == "K")
            {
                kozonseg = true;
                int szazalek = 100;
                int generalt = 0;
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;

                if (kerd.helyes == "A")
                {
                    generalt = rnd.Next(50, szazalek);
                    a = +generalt;
                    szazalek -= generalt;
                }
                else if (kerd.helyes == "B")
                {
                    generalt = rnd.Next(50, szazalek);
                    b = +generalt;
                    szazalek -= generalt;
                }
                else if (kerd.helyes == "C")
                {
                    generalt = rnd.Next(50, szazalek);
                    c = +generalt;
                    szazalek -= generalt;
                }
                else if (kerd.helyes == "D")
                {
                    generalt = rnd.Next(50, szazalek);
                    d = +generalt;
                    szazalek -= generalt;
                }

                while (szazalek > 0)
                {

                    generalt = rnd.Next(0, (szazalek + 1));
                    a += generalt;
                    szazalek -= generalt;


                    generalt = rnd.Next(0, (szazalek + 1));
                    b += generalt;
                    szazalek -= generalt;

                    generalt = rnd.Next(0, (szazalek + 1));
                    c += generalt;
                    szazalek -= generalt;

                    generalt = rnd.Next(0, (szazalek + 1));
                    d += generalt;
                    szazalek -= generalt;
                }

                Console.WriteLine($"A:{a}%, B:{b}%, C:{c}%, D:{d}%");

                Console.Write("\nKérlek add meg a válaszodat: ");
                bekert = Console.ReadLine();
                if (bekert.ToUpper() == "A")
                {
                    if (kerd.helyes == "A")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "B")
                {
                    if (kerd.helyes == "B")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "C")
                {
                    if (kerd.helyes == "C")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }
                else if (bekert.ToUpper() == "D")
                {
                    if (kerd.helyes == "D")
                    {
                        korok();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Rossz választ adtál! Veszítettél!");
                    }
                }

            }
            if (bekert.ToUpper() == "A")
            {
                if (kerd.helyes == "A")
                {
                    korok();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Rossz választ adtál! Veszítettél!");
                }
            }
            else if (bekert.ToUpper() == "B")
            {
                if (kerd.helyes == "B")
                {
                    korok();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Rossz választ adtál! Veszítettél!");
                }
            }
            else if (bekert.ToUpper() == "C")
            {
                if (kerd.helyes == "C")
                {
                    korok();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Rossz választ adtál! Veszítettél!");
                }
            }
            else if (bekert.ToUpper() == "D")
            {
                if (kerd.helyes == "D")
                {
                    korok();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Rossz választ adtál! Veszítettél!");
                }
            }
        }

        static void Main(string[] args)
        {
            beolvasas();
            korok();
        }
    }
}