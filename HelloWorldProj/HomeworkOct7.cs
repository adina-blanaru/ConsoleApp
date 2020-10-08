using System;
using System.Linq;

namespace HelloWorldProj
{
    class HomeworkOct7
    {
        //Exercitii22

        public static void Ex22_1_8()
        {
            //1.	Cititi de la tastatura un numar.Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!
            //8.	Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.
            //Console.Write("Introdu un numar: ");
            int i = int.Parse(Console.ReadLine());
            if (i == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
            else
            {
                Console.WriteLine("Numarul tau este diferit de 20!");
            }
        }

        public static void Ex22_2_9()
        {
            //2.	Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.
            //9.	Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””. In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.
            Console.Write("Introdu un cuvant: ");
            string s = Console.ReadLine();
            if (s == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este \"automation\"");
            }
            else
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit nu este \"automation\"");
            }
        }

        public static void Ex22_3_10()
        {
            //3.	Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul* character* pe care l-ai introdus este cifra!”
            //10.	Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul* character* pe care l-ai introdus este cifra!”, in caz contrat afisati “Caracterul* character* pe care l-ai introdus nu este cifra.
            Console.Write("Introdu un caracter (litera, cifra, caracter special etc): ");
            char c = char.Parse(Console.ReadLine());
            if (Char.IsDigit(c))
            {
                Console.WriteLine($"Caracterul {c} pe care l-ai introdus este cifra!");
            }
            else
            {
                Console.WriteLine($"Caracterul {c} pe care l-ai introdus nu este cifra!");
            }
        }

        public static void Ex22_4_11()
        {
            //4.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.
            //11.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. In caz contrar scadeti numarul cu 5 si afisati rezultatul final.
            Console.Write("Introdu un numar: ");
            int i = int.Parse(Console.ReadLine());
            int j;
            if (i < 20)
            {
                j = i + 5;
            }
            else
            {
                j = i - 5;
            }
            Console.WriteLine($"Numarul introdus este {i} iar rezultatul este {j}");
        }

        public static void Ex22_5_12()
        {
            //5.	Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul* numar* este pozitiv”.
            //12.	Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul* numar* este pozitiv”. In caz contrar afisati “Numarul* numar* este negativ!.
            Console.Write("Introdu un numar: ");
            int i = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                Console.WriteLine($"Numarul {i} este zero, nici pozitiv, nici negativ.");
            }
            else
            {
                if (i > 0)
                {
                    Console.WriteLine($"Numarul {i} este pozitiv.");
                }
                else
                {
                    Console.WriteLine($"Numarul {i} este negativ.");
                }
            }
        }

        public static void Ex22_6_13()
        {
            //6.	Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.
            //13.	Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”
            Console.Write("Introdu un numar: ");
            int i = int.Parse(Console.ReadLine());
            if (i < 20 || i > 40)
            {
                Console.WriteLine("Numarul este mai mic de 20 sau mai mare de 40!");
            }
            else
            {
                Console.WriteLine("Numarul este intre 20 si 40!");
            }
        }

        public static void Ex22_7_14()
        {
            //7.	Cititi de la tastaura un numar. Verificati daca numarul este par.Daca numarul este par afisati :”Numarul* numar* pe care l’ati introdus este par!”. In caz contrar nu afisati nimic
            //14.	Cititi de la tastaura un numar. Verificati daca numarul este par.Daca numarul este par afisati :”Numarul* numar* pe care l’ati introdus este par!”. In caz contrar afisati “Numarul* numar* pe care l’ati introdus este impar!”.
            Console.Write("Introdu un numar: ");
            int i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine($"Numarul {i} pe care l-ati introdus este par!");
            }
            else
            {
                Console.WriteLine($"Numarul {i} pe care l-ati introdus este impar!");
            }
        }

        public static void Ex22_15()
        {
            //15.	Cititi de la tastatura un caracter. Daca acel caracter este litera afisati mesajul :”Caracterul* caracter* este litera!”. In cazul in care este o cifra afisati mesajul :”Caracterul* caracter* este o cifra!”. In cazul contrar afisati mesajul: “Caracterul* caracter* nu este nici cifra nici litera
            Console.Write("Introdu un caracter (litera, cifra, caracter special etc): ");
            char c = char.Parse(Console.ReadLine());
            if (Char.IsLetter(c))
            {
                Console.WriteLine($"Caracterul {c} este litera!");
            }
            else if (Char.IsDigit(c))
            {
                Console.WriteLine($"Caracterul {c} este cifra!");
            }
            else
            {
                Console.WriteLine($"Caracterul {c} nu este nici cifra nici litera!");
            }
        }

        public static void Ex22_16()
        {
            //16.	Cititi de la tastatura o ora a zilei. In cazul in care ora respectiva este mai mica de 12 afisati: “Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”. In caz contrar afisati mesajul :”Buna seara!”
            Console.Write("Introdu o ora a zilei, intre 0 si 23: ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case var j when j < 0 || j > 23:
                    Console.WriteLine($"{i} nu este o ora valida!");
                    break;
                case var j when j < 12:
                    Console.WriteLine("Buna dimineata!");
                    break;
                case var j when j < 17:
                    Console.WriteLine("Buna ziua!");
                    break;
                case var j when j < 24:
                    Console.WriteLine("Buna seara!");
                    break;
            }
        }

        public static void Ex22_17()
        {
            //17.	Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este<150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si<195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.
            Console.Write("Introdu inaltimea unei persoane in cm: ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case var j when j < 12:
                    Console.WriteLine("Buna dimineata!");
                    break;
                case var j when j < 17:
                    Console.WriteLine("Buna ziua!");
                    break;
                case var j when j < 24:
                    Console.WriteLine("Buna seara!");
                    break;
                default:
                    Console.WriteLine($"{i} nu este o ora valida!");
                    break;
            }
        }

        public static void Ex22_18()
        {
            //18.   Cititi 3 numere de la tastatura si afisati cel mai mare numar.
            int[] numere = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Introdu un numar: ");
                numere[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Maximul din cele 3 numere introduse este: {numere.Max()}");
        }

        public static void Ex22_19()
        {
            //19.	Cititi de la tastatura 2 numere.Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul: 
            double a, b;
            double r = 0;
            char c;

            Console.Write("Introdu primul numar: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Introdu al doilea numar: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Introdu un operator matematic (+ - * /): ");
            c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    r = a + b;
                    break;
                case '-':
                    r = a - b;
                    break;
                case '*':
                    r = a * b;
                    break;
                case '/':
                    r = a / b;
                    break;
                default:
                    Console.WriteLine($"{c} nu este un operator valid!");
                    break;
            }

            Console.Write($"{a} {c} {b} = {r}");
        }

        //----------------------------------------------------------------------------------------

        //Exercitii23

        public static void Ex23_1_8_15()
        {
            //1.	Scrieti un program care sa afiseze primele 10 numere naturale.
            Console.WriteLine("while - Primele 10 numere naturale sunt:");
            int x = 1;
            while (x <= 10)
            {
                Console.Write($"{x} "); 
                x++;
            }

            //8.	Scrieti un program care sa afiseze primele 10 numere naturale.( do while)
            Console.WriteLine("\ndo while - Primele 10 numere naturale sunt:");
            int j = 1;
            do
            {
                Console.Write($"{j} ");
                j++;
            }
            while (j <= 10);

            //15.	Scrieti un program care sa afiseze primele 10 numere naturale. (for)
            Console.WriteLine("\nfor loop - Primele 10 numere naturale sunt:");
            for (int i = 1; i <= 10; Console.Write($"{i} "), i++) ;
        }

        public static void Ex23_2_9_16()
        {
            //2.	Scrieti un program care sa afiseze suma primelor 10 numere naturale.
            int x = 0;
            int sum1 = 0;
            while (x <= 10)
            {
                sum1 += x;
                x++;
            }
            Console.WriteLine($"while - Suma primelor 10 numere naturale este: {sum1}");

            //9.	Scrieti un program care sa afiseze suma primelor 10 numere naturale. ( do while)
            int j = 1;
            int sum2 = 0;
            do
            {
                sum2 += j;
                j++;
            }
            while (j <= 10);
            Console.WriteLine($"do while - Suma primelor 10 numere naturale este: {sum2}");

            //16.	Scrieti un program care sa afiseze suma primelor 10 numere naturale. (for)
            int sum3 = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum3 += i;
            }
            Console.WriteLine($"for loop - Suma primelor 10 numere naturale este: {sum3}");
        }

        public static void Ex23_3_10_17()
        {
            //3.	Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi.
            Console.Write("Introduceti un numar: ");
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                a--;
                Console.Write($"{a} ");
            }

            //10.	Cititi un numar de la tastatura.Afisati toate numerele mai mici decat numarul citit de voi. .( do while)
            Console.Write("\nIntroduceti un numar: ");
            int b = int.Parse(Console.ReadLine());
            if (b > 0)
            {
                do
                {
                    b--;
                    Console.Write($"{b} ");
                }
                while (b > 0);
            }

            //17.	Cititi un numar de la tastatura.Afisati toate numerele mai mici decat numarul citit de voi. (for)
            Console.Write("\nIntroduceti un numar: ");
            int c = int.Parse(Console.ReadLine());
            for (; c > 0; c--, Console.Write($"{c} ")) ;
        }

        public static void Ex23_4_11_18()
        {
            //4.	Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi.
            Console.Write("Introduceti un numar: ");
            int a = int.Parse(Console.ReadLine());
            int x = 3;
            while (x <= a)
            {
                Console.Write($"{x++} ");
            }

            //11.	Cititi un numar de la tastatura.Afisati toate numerele de la 3 pana la numarul citit de voi. .( do while)
            Console.Write("\nIntroduceti un numar: ");
            int b = int.Parse(Console.ReadLine());
            int j = 3;
            if (b >= j)
            {
                do
                {
                    Console.Write($"{j++} ");
                }
                while (j <= b);
            }

            //18.	Cititi un numar de la tastatura.Afisati toate numerele de la 3 pana la numarul citit de voi. (for)
            Console.Write("\nIntroduceti un numar: ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 3; i <= c; Console.Write($"{i++} ")) ;
        }

        public static void Ex23_5_12_19()
        {
            //5.	Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi.
            Console.Write("Introduceti un numar: ");
            int a = int.Parse(Console.ReadLine());
            int sum1 = 0;
            while (a > 0)
            {
                a--;
                sum1 += a;
            }
            Console.WriteLine($"while - Suma este: {sum1}");

            //12.	Cititi un numar de la tastatura.Afisati suma numerelor mai mici decat numarul citit de voi. .( do while)
            Console.Write("Introduceti un numar: ");
            int b = int.Parse(Console.ReadLine());
            int sum2 = 0;
            if (b > 0)
            {
                do
                {
                    b--;
                    sum2 += b;
                }
                while (b > 0);
            }
            Console.WriteLine($"do while - Suma este: {sum2}");

            //19.	Cititi un numar de la tastatura.Afisati suma numerelor mai mici decat numarul citit de voi. (for)
            Console.Write("Introduceti un numar: ");
            int c = int.Parse(Console.ReadLine());
            int sum3 = 0;
            for (; c > 0; c--, sum3 += c) ;
            Console.WriteLine($"for loop - Suma este: {sum3}");
        }

        public static void Ex23_6_13_20()
        {
            //6.	Afisati cubul primelor 5 numere naturale.
            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine($"Cubul lui {x} este {Math.Pow(x, 3)}");
                x++;
            }

            //13.	Afisati cubul primelor 5 numere naturale. .( do while)
            int j = 1;
            do
            {
                Console.WriteLine($"Cubul lui {j} este {Math.Pow(j, 3)}");
                j++;
            }
            while (j <= 5);

            //20.	Afisati cubul primelor 5 numere naturale. (for)
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Cubul lui {i} este {Math.Pow(i, 3)}");
            }
        }

        public static void Ex23_7_14_21()
        {
            //7.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.
            Console.Write("Introduceti un numar: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 1)
            { 
                a += 1;
            }
            while (a > 0)
            {
                a -= 2;
                Console.Write($"{a} ");
            }

            //14.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. .( do while)
            Console.Write("\nIntroduceti un numar: ");
            int b = int.Parse(Console.ReadLine());
            if (b % 2 == 1)
            { 
                b += 1;
            }
            if (b > 0)
            {
                do
                {
                    b -= 2;
                    Console.Write($"{b} ");
                }
                while (b > 0);
            }

            //21.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. (for)
            Console.Write("\nIntroduceti un numar: ");
            int c = int.Parse(Console.ReadLine());
            if (c % 2 == 1)
            { 
                c += 1;
            }
            for (; c > 0; c -= 2, Console.Write($"{c} ")) ;
        }

        public static void Ex23_22_23_24_25()
        {
            //22.	Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.
            string[] test = { "sun", "moon", "clouds" };
            Console.WriteLine($"Al doilea element este: {test[1]}");

            //23.	Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”
            string[] fruits = { "lemons", "watermelod", "cherry" };
            foreach (string fruit in fruits)
            {
                if (fruit.Equals("cherry"))
                {
                    Console.WriteLine($"cherry trebuie afisat: {fruit}");
                    break;
                }

            }

            //24.	Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.
            //25.	Afisati array-ul sortat: “mom”, “dad”, “child”.
            string[] family = { "dad", "mom", "child" };
            int i;

            Array.Sort(family);
            Array.Reverse(family);
            for (Console.Write("\nSortat invers: "), i = 0; i < family.Length; i++)
            {
                Console.Write($"{family[i]} ");
            }

            Array.Sort(family);
            for (Console.Write("\nSortat alfabetic: "), i = 0; i < family.Length; i++)
            {
                Console.Write($"{family[i]} ");
            }
        }

        public static void Ex23_26_27()
        {
            //26.	Cititi de la tastatura elementele unui array de marime 5. (string)
            string[] cuvinte = new string[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write($"Introdu cuvantul {i + 1}: ");
                cuvinte[i] = Console.ReadLine();
            }

            for (Console.Write("Cuvintele sunt: "), i = 0; i < 5; i++)
            {
                Console.Write($"{cuvinte[i]} ");
            }

            //27.	Cititi de la tastatura elementele unui array de marime 5.(int)
            int[] numere = new int[5];
            int j;
            for (Console.WriteLine(), j = 0; j < 5; j++)
            {
                Console.Write($"Introdu numarul {j + 1}: ");
                numere[j] = int.Parse(Console.ReadLine());
            }

            for (Console.Write("Numerere sunt: "), j = 0; j < 5; j++)
            {
                Console.Write($"{numere[j]} ");
            }

        }
    }
}
