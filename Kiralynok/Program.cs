using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    class Tabla
    {
        private char[,] T = new char[8, 8];
        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

        public Tabla(char ch)
        {
            T = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8 ; i++)
            {
                for (int j = 0; j < 8 ; j++)
                {
                    T[i, j] = UresCella;
                }
            }

        }

        public void Elhelyez(int N)
        {
            //random osztaly értékkészklet [0, 7]
            //véletlen sor és oszlop kell
            //elhelyezzük a  "K"-t csak akkor HA!! üres --> "#"
            Random vel = new Random();
            for (int i = 0; i < N; i++)
            {
                bool igaz = true;
                while (igaz)
                {
                    int sor = vel.Next(0, 8);
                    int oszlop = vel.Next(0, 8);
                    if (T[sor, oszlop] == '#')
                    {
                        T[sor, oszlop] = 'K';
                    }
                    igaz = false;
                }
            }
        }
        public void Fajlbair()
        {

        }
        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{T[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public int UresOszlop()
        {
            return 0;
        }
        public int UresSor()
        {
            return 0;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");
            Tabla t = new Tabla('#');
            Console.WriteLine("Üres tábla :");
            t.Megjelenit();
            t.Elhelyez(8);
            Console.WriteLine();
            t.Megjelenit();
            Console.ReadKey();
        }
    }
}
