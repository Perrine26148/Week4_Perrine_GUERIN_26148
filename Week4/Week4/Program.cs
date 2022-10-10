using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise1
            Console.WriteLine("What is your string to change ? ");
            string s = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The result is :" + Exercise1(s));

            //Exercise2
            Console.WriteLine("How many numbers do you want ?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nChoose " + n + " number(s) :");
            int[] tab = new int[n];
            for(int i =0; i<n; i++ )
            {
                int r = Convert.ToInt32(Console.ReadLine());
                r = tab[i];
            }
            Console.Clear();
            Console.WriteLine("How many numbers do you want to verify ?");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nChoose " + v + " numbers that you want to verify :");
            int[] tab1 = new int[v];
            for (int j =0; j<v;j++ )
            {
                int t = Convert.ToInt32(Console.ReadLine());
                t = tab1[j];
            }
            Console.WriteLine("The result is : " + Exercise2(tab, tab1));
            //Exercise 2 doesn't work and I don't know why

            //Exercise3a
            Console.WriteLine("Enter a word :");
            int w = Convert.ToInt32(Console.ReadLine());

            //Exercise3
            Console.WriteLine("How many characters do you want to write ?");
            int chr = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[chr];
            Console.WriteLine("\nChoose " + chr + " characters that you want to have a descending order :");
            for (int i = 0; i<chr;i++)
            {
                array[i]= Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("The result is :");
            Exercise3(array);

            //Exercise4
            Console.WriteLine("What is the string that you want to analyse ?");
            string m = Console.ReadLine();
            Console.WriteLine("The result is : "+Exercise4(m));

            //Exercise5
            //Exercise5();

            //Exercise7
            Console.WriteLine("What is the number that you want a factorial ?");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe factorial of " + f + " is : " + Exercise7(f));

            //Exercise8
            Exercise8();

        }
        static string Exercise1(string s)
        {
            string finalS = "";
            int size = s.Length;
            if (size ==1)
            {
                return s;
            }
            else if (size ==0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (i==0)
                    {
                        finalS = finalS + s[size - 1];
                    }
                    else if (i==size -1)
                    {
                        finalS = finalS + s[0];
                    }
                    else
                    {
                        finalS = finalS + s[i];
                    }
                }
                return finalS;
            }
        }
        static bool Exercise2(int[]tab, int []tab1)
        {
            bool result = false;
            bool f = false;
            bool t = true;
            int index = 0;
            if (tab == null || tab.Length == 0 || tab1 == null|| tab1.Length ==0)
            {
                return result;
            }
            else
            {
                for (int i = 0; i < tab.Length && f== false; i++)
                {
                    if (tab[i] == tab1[0])
                    {
                        index = i;
                        f = true;
                    }
                    /*for (int j = 0; j < tab1.Length; j++)
                    {
                        if ()
                        {
                            return true;
                        }
                    }*/
                }
                if (f == true)
                {
                    for (int j = index; (j < tab1.Length + index) && t == true; j++)
                    {
                        if (tab[j] != tab1[j - index])
                        {
                            t = false;
                        }
                    }
                    if (t == true)
                    {
                        result = true;
                    }
                }
                return result;
            }
        }
        static void Exercise3(char[]array)
        {
            Console.WriteLine("");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            char chr;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (ASCII(array[j]) < ASCII(array[j + 1]))
                    {
                        chr = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = chr;
                    }
                }

            }
            Console.WriteLine("");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }
        static int ASCII(char c)
        {
            int a = 0;
            a = Convert.ToInt32(c);
            return a;
        }
        static string Exercise4(string m)
        {
            int p = 1;
            string tot = Convert.ToString(m[0]);
            for (int j = 0; j < m.Length - 1; j++)
            {
                if (m[j + 1] == m[j])
                {
                    p++;
                }
                else
                {
                    tot = tot + Convert.ToString(p);
                    p = 1;
                    tot = tot + Convert.ToString(m[j + 1]);
                }

            }
            tot = tot + Convert.ToString(p);
            Console.WriteLine(tot);
            return tot;
        }
        static void Exercise5()
        {
            for (int result = 0; result < 1000; result++)
            {
                int u = 0;
                string armstrong = Convert.ToString(result);
                for (int i = 0; i < armstrong.Length; i++)
                {
                    u= u + (int)Math.Pow(Convert.ToInt32(armstrong[i]) - 48, 3);
                }
                if (u == result)
                {
                    Console.WriteLine(result + " is an exemple of Armstrong number.");
                }
            }
        }
        
        static int Exercise7(int f)
        {
            int result = 0;
            for (int i = f; i >= 1; i--)
            {
                if (i==f)
                {
                    result = f;
                }
                else
                {
                    result = result * i;
                }
            }
            return result;
        }
        static void Exercise8()
        {
            Person[] tab = new Person[3];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("What is the name do you want ?");
                tab[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i].ToString());
            }
        }

    }
}
