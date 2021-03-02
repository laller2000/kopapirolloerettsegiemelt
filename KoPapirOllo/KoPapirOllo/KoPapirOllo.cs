using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KoPapirOllo
{
    class KoPapirOllo
    {
        static int elsokod;
        static int masodikod;
        static int elsojatekosscore = 0;
        static int masodikjatekosscore = 0;
        static int dontetlen = 0;
        static int eredmeny;
        static List<Jatek> jatek = new List<Jatek>();
        static void Main(string[] args)
        {
            
            Console.WriteLine("1.feladat:");
            elso();
            masodik();
            gyoztes();
            Console.WriteLine("2.feladat:");
            Beolvas("jatek.txt");
            Console.WriteLine("\n3.feladat:");
            Console.WriteLine($"\tTovábbi játékok száma:{jatek.Count} db");
            Console.WriteLine("\n4.feladat:Statisztika");
            List<int> szamok = new List<int>();
            for (int i = 0; i < jatek.Count; i++)
            {
                if (jatek[i].Kod1.Equals(elsokod) && jatek[i].Kod2.Equals(masodikod) && jatek[i].Donto.Equals(dontetlen))
                {
                    szamok.Add(jatek[i].Kod1);
                    szamok.Add(jatek[i].Kod2);
                    szamok.Add(jatek[i].Donto);
                }
            }
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine($"\tDöntetlen:{szamok[i]}db\n\tElső játékos nyert:{szamok[i]} db\n\tMásodik játékos nyert:{szamok[i]}db ");
            }
            Console.WriteLine("\nProgram Vége!");
            Console.ReadLine();
        }
        static void elso()
        {
            
            
            do
            {
                Console.Write("\nKérem az első játékos választását kódolva (0-kő,1-papír,2-olló):");
                elsokod = Convert.ToInt32(Console.ReadLine());
                break;
                
            } while (elsokod==0 || elsokod==1 || elsokod==2 ||elsokod!=0 || elsokod!=0 || elsokod!=2);
            
            
        }
        static void masodik()
        {
            
            do
            {
                Console.Write("\nKérem a második játékos választását kódolva (0-kő,1-papír,2-olló):");
                masodikod = Convert.ToInt32(Console.ReadLine());
                break;
            } while (masodikod==0 || masodikod==1 || masodikod==2 || masodikod!=0 || masodikod!=1 || masodikod!=2);

        }
        static void gyoztes()
        {
            if (elsokod==0 && masodikod==2 || masodikod==0 && elsokod==2)
            {
                elsojatekosscore++;
                masodikjatekosscore++;
            }
            else if(elsokod==2 && masodikod==1 || masodikod==2 && elsokod==1)
            {
                elsojatekosscore++;
       
                masodikjatekosscore++;
            }
            else if(elsokod==1 && masodikod==0 || masodikod==1 && elsokod==0)
            {
                elsojatekosscore++;
                masodikjatekosscore++;
            }
            else if(elsokod==masodikod)
            {
                dontetlen++;
            }
            Console.WriteLine($"\tEredmény kódolva (0-döntetlen,1-első nyert,2-második nyert:){eredmeny+=elsojatekosscore+masodikjatekosscore+dontetlen}");
        }
        static void Beolvas(string filenev)
        {
            using (StreamReader sr=new StreamReader(filenev))
            {
                while(!sr.EndOfStream)
                {
                    Jatek jatekos = new Jatek(sr.ReadLine());
                    jatek.Add(jatekos);
                }
            }
        }
    }
}
