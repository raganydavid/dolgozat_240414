using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public class Program
        {
            public static void ImportKolcsonzok(string filePath)
            {
                try
                {
                    using (var context = new KolcsonzokContext())
                    {
                        using (var reader = new StreamReader(filePath))
                        {
                            reader.ReadLine(); // Első sor átugrása

                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                if (values.Length < 3)
                                {
                                    Console.WriteLine("Hibás adatsor: " + line);
                                    continue;
                                }

                                int id;
                                if (!int.TryParse(values[0], out id))
                                {
                                    Console.WriteLine("Hibás ID formátum: " + values[0]);
                                    continue;
                                }

                                DateTime szulIdo;
                                if (!DateTime.TryParse(values[2], out szulIdo))
                                {
                                    Console.WriteLine("Hibás születési idő formátum: " + values[2]);
                                    continue;
                                }

                                var kolcsonzo = new Kolcsonzok
                                {
                                    Id = id,
                                    Nev = values[1],
                                    SzulIdo = szulIdo
                                };

                                context.Kolcsonzok.Add(kolcsonzo);
                            }

                            context.SaveChanges();
                        }
                    }

                    Console.WriteLine("Kölcsönzők importálása sikeresen befejeződött!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba történt az importálás során: " + ex.Message);
                }
            }

            public static void ImportKolcsonzesek(string filePath)
            {
                try
                {
                    using (var context = new KolcsonzokContext())
                    {
                        using (var reader = new StreamReader(filePath))
                        {
                            reader.ReadLine(); // Első sor átugrása

                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                                if (values.Length < 5)
                                {
                                    Console.WriteLine("Hibás adatsor: " + line);
                                    continue;
                                }

                                int id, kolcsonzokId;
                                if (!int.TryParse(values[0], out id))
                                {
                                    Console.WriteLine("Hibás ID formátum: " + values[0]);
                                    continue;
                                }
                                if (!int.TryParse(values[1], out kolcsonzokId))
                                {
                                    Console.WriteLine("Hibás kölcsönző ID formátum: " + values[1]);
                                    continue;
                                }

                                var kolcsonzes = new Kolcsonzesek
                                {
                                    Id = id,
                                    KolcsonzokId = kolcsonzokId,
                                    Iro = values[2],
                                    Mufaj = values[3],
                                    Cim = values[4]
                                };

                                context.Kolcsonzesek.Add(kolcsonzes);
                            }

                            context.SaveChanges();
                        }
                    }

                    Console.WriteLine("Kölcsönzések importálása sikeresen befejeződött!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba történt az importálás során: " + ex.Message);
                }
            }

            public static void Main()                               ??
    {
        ImportKolcsonzok("Kolcsonzok.csv");
            ImportKolcsonzesek("Kolcsonzesek.csv");
        }
    }
}
    }
}
