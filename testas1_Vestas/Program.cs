using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testas1_Vestas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programos tikslas:
            -Sukurti ir užpildyti duomenimis masyvą arba sąrašą. Atlikti reikiamus skaičiavimus.Bei išvesti gautus rezultatus.
           Reikalavimai:
            -Nenaudoti "greitųjų" radimo funkcijų. Tokių kaip .Min(), .Max()., Sum(), .Average() ar pan.
           Įgyvendinkite šį funkcionalumą:
           -Sukurkite masyvą arba sąrašą, kuriame saugotumėte dienų temperatūrų duomenis.
           - Liepkite vartotojui suvesti norimą kiekį duomenų į sukurtą masyvą arba sąrašą. 
           Programos pradžioje paklauskite kiek dienų temperatūrų jis nori suvesti, tuomet įvedinėjant išveskite kelintą reikšmę jis įvedinėja ir leiskite įvesti.
           -Išveskite temperatūrų duomenis, kiekvieną skaičių atskiriant kableliu, toje pačioje eilutėje.
           - Raskite ir išveskite ekrane šiuos atsakymus:
            --Koks yra suvestų temperatūrų vidurkis?
            --Kokia temperatūra yra žemiausia ?
            --Kurią dieną buvo aukščiausia temperatūra? Pavyzdžiui: "5-a dieną buvo aukščiausia temperatūra, kuri siekė 32 laipsnius".
            -- Kiek dienų temperatūra buvo žemesnė nei bendras visų dienų temperatūrų vidurkis ?
            --Pirmą ar paskutinę dieną temperatūra buvo aukštesnė ir koks skirtumas tarp jų?
           -Atrinkite į naują masyvą ar sąrašą tas temperatūras, kurios yra nutolusios nuo vidurkio tik per vieną padalą 
           (tarkim vidurkis buvo 20, tai atrinkti temperatūras, kurios pateko tarp[19 - 21]).
           Šį masyvą ar sąrašą išvesti ekrane.*/

            List<int> TempSar = new List<int>();
            List<int> TempVid = new List<int>();
           
            int kiek = 0;
            int tempMin = 10000;
            int MinDiena = 0;
            int tempMax = -10000;
            int MaxDiena = 0;
            int tempSum = 0;
            int tempVid = 0;
            int ZvidDien = 0;
            int AvidDien = 0;
            int tempSkirt = 0;
            int kiek2 = 0;
            string diena = "Pirma";

            //Saraso formavimas

            Console.WriteLine("Kiek duomenų norėsite suvesti? Suvestas dienų skaičius turi būti teigiamas skaičius.");

            do
            {
              Console.Write("Įveskite dienų skaičių: ");
              kiek = Convert.ToInt32(Console.ReadLine());
            } while (kiek<=0);
            
            Console.WriteLine();

            for (int i = 0; i < kiek-1; i++)
            {
                if (i==0)
                {
                    Console.Write("Jums reikės suvesti kiekvienos dienos temperatūrą atskirai. Duomenis suveskite sveikais skaičiais. \n{0}-os dienos temperatūra: ", i+1);
                    TempSar.Add(Convert.ToInt32(Console.ReadLine()));
                }
                Console.Write("{0}-os dienos temperatūra: ", i+2);
                TempSar.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine();

            //Saraso isvedimas

            Console.WriteLine("Jūsų suvesti duomenys:");

            for (int i = 0; i < kiek; i++)
            {
                if (i==0)
                {
                    Console.Write("{" + TempSar[i] + ", ");
                }
                else if (i==kiek-1)
                {
                    Console.Write(TempSar[i] + "}");
                }
                else
                {
                    Console.Write(TempSar[i] + ", ");
                }
            }

            Console.WriteLine();

            //Skaiciavimai, naujo saraso formavimas   

            for (int i = 0; i < kiek; i++)
            {
                if (TempSar[i]<tempMin)
                {
                    tempMin = TempSar[i];
                    MinDiena = i + 1;
                }
                else if (TempSar[i] > tempMax)
                {
                    tempMax = TempSar[i];
                    MaxDiena = i + 1;
                }
                tempSum += TempSar[i];
            }

            tempVid = tempSum / kiek;

            foreach (var temp in TempSar)
            {
                if (temp<tempVid)
                {
                    ZvidDien++;
                }
                else if (temp>tempVid)
                {
                    AvidDien++;
                }
                if (temp==tempVid-1 || temp == tempVid + 1)
                {
                    TempVid.Add(temp);
                    kiek2++;
                }
                
            }

            if (TempSar.First() > TempSar.Last())
            {
                diena = "Pirma";
                tempSkirt = TempSar.First() - TempSar.Last();
            }
            else if (TempSar.First() < TempSar.Last())
            {
                diena = "Paskutinė";
                tempSkirt = TempSar.Last() - TempSar.First();
            }
                       
            Console.WriteLine();
                 

            //Skaiciavimu rezultatu isvedimas

            Console.WriteLine("{0} dienų temperatūrų vidurkis: {1}.", kiek, tempVid);
            Console.WriteLine();
            Console.WriteLine("Žemiausia tempertūra buvo užfiksuota {0} dieną ir buvo lygi {1}.", MinDiena, tempMin);
            Console.WriteLine();
            Console.WriteLine("Aukščiausia tempertūra buvo užfiksuota {0} dieną ir buvo lygi {1}.", MaxDiena, tempMax);
            Console.WriteLine();
            Console.WriteLine("{0} d. temperatūra buvo žemesnė už vidutinę.", ZvidDien);
            Console.WriteLine();
            Console.WriteLine("{0} d. temperatūra buvo aukštesnė uz vidutinę.", AvidDien);
            Console.WriteLine();
            switch (diena)
            {
                case "Pirma":
                    Console.WriteLine("Pirmos dienos temperatūra aukštesnė už paskutinės. Temperatūrų skirtumas tarp pirmos dienos ir paskutinės lygus {0}.", tempSkirt);
                    break;
                case "Paskutinė":
                    Console.WriteLine("Paskutinės dienos temperatūra aukštesnė už pirmos. Temperatūrų skirtumas tarp paskutinės dienos ir pirmos lygus {0}.", tempSkirt);
                    break;
                default:
                    break;
            }
            Console.WriteLine();

            //naujo saraso isvedimas

            if (kiek2==0)
            {
                Console.WriteLine("Temperatūrų, kurios yra nutolusios nuo vidurkio tik per vieną padalą, nėra.");
            }
            else
            {
                Console.WriteLine("Pateikiame sąrašą temperatūrų, kurios yra nutolusios nuo vidurkio tik per vieną padalą:");
                for (int i = 0; i < kiek2; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("{" + TempVid[i] + ", ");
                    }
                    else if (i == kiek2 - 1)
                    {
                        Console.Write(TempVid[i] + "}");
                    }
                    else
                    {
                        Console.Write(TempVid[i] + ", ");
                    }
                }
            }
            Console.WriteLine();



        }
    }
}
