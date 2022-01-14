using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnek
{
    class Program
    {
        enum gunler
        {
            Pazartesi=1,
            Salı=2,
            Çarşamba=3,
            Perşembe=4,
            Cuma=5,
            Cumartesi=6,
            Pazar=7
        }
        static void Main(string[] args)
        {
            int secilengun = (int)gunler.Cuma;
            if (secilengun==(int)gunler.Cumartesi || secilengun==(int)gunler.Pazar)
            {
                Console.WriteLine("Hafta sonudur.");
            }
            else
            {
                Console.WriteLine("Hafta içidir");
            }
            Console.ReadLine();
            }
        }
    }
