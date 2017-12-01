using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniVTyzdni
{
    class DniVTyzdni
    {
        public static void VypisDenTyzdna(string cisloDna) //metoda prva
        {
            int denTyzdna = int.Parse(cisloDna); // prevedenie textu na cislo
            if (ZkontrolujVstup(denTyzdna)) //pouzitie tretej metody
            {
                switch (denTyzdna)
                {
                    case 0:
                    case 7:
                        Console.WriteLine("Nedela");
                        break;
                    case 1:
                        Console.WriteLine("Pondelok");
                        break;
                    case 2:
                        Console.WriteLine("Utorok");
                        break;
                    case 3:
                        Console.WriteLine("Streda");
                        break;
                    case 4:
                        Console.WriteLine("Stvrtok");
                        break;
                    case 5:
                        Console.WriteLine("Piatok");
                        break;
                    case 6:
                        Console.WriteLine("Sobota");
                        break;
                    default:
                        Console.WriteLine("Nespravne cislo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nespravne cislo");
            }
        }
        public static void VypisDenTyzdna(string cisloDna, bool nedeleJePrva) //metoda druha
        {
            int denTyzdna = int.Parse(cisloDna);
            if (ZkontrolujVstup(denTyzdna)) //pouzitie tretej metody
            {
                if (nedeleJePrva)
                {
                    denTyzdna--;
                }
                VypisDenTyzdna(denTyzdna.ToString());
            }
            else
            {
                Console.WriteLine("Nespravne cislo");
            }

        }
        public static bool ZkontrolujVstup(int cisloDna)  //metoda tretia
        {
            return (cisloDna >= 1 && cisloDna <= 7);  // kratka podmienka v pripade dvoch moznosti
        }
    }
}

