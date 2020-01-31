using System;

namespace exam_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Displaymenu = true;
            while (Displaymenu)
            {
                Displaymenu = Option();
           }
        }



        public static bool Option()
        {
            Console.WriteLine(" 1.greatest value of the three values.");
            Console.WriteLine("2. Students Grade");
            Console.WriteLine("3. Integer Number");
            Console.WriteLine("4. ASCII VALUE");
            Console.WriteLine("5. Spaces");
            Console.WriteLine("Choose Option:");
          

            switch (Console.ReadLine())
            {
                case "1":
                    Greater();
                    return true;


                case "2":
                    Grade();
                    return true;

                case "3":
                    integer();
                    return true;
                case "4":
                    ascii();
                    return true;
                case "5":
                    space();
                    return true;

                case "6":
                    return false;
                default:
                    return true;

            }
        }

        private static void Greater()
        {
            Console.Clear();
            Console.WriteLine("Enter First Value");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Value");
            int value3 = Convert.ToInt32(Console.ReadLine());

            if (value1 > value2 && value1 > value3)
            { Console.WriteLine("Greater number is " + value1); }

            else if (value2 > value1 && value2 > value3)
            { Console.WriteLine("Greater number is" + value2); }

            else if (value3 > value1 && value3 > value2)
            { Console.WriteLine("Greater number is" + value3); }

            else
            { Console.WriteLine("All the value is same"); }


        }

        private static void Grade()
        {
            Console.Clear();
            Console.WriteLine("Enter Quiz Mark:");
            float quiz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mid Term Mark:");
            float mid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Final Exam Mark:");
            float final = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("total Mark:", quiz + mid + final);

            float finalresult = (quiz + mid + final) / 3;
            if (finalresult >= 90)
            {
                Console.WriteLine("Final Score:" + finalresult + " Grade A");
            }
            else if (finalresult >= 70)
            {
                Console.WriteLine("Final Score:" + finalresult + " Grade B");
            }
            else if (finalresult >= 50)
            {
                Console.WriteLine("Final Score:" + finalresult + " Grade C");
            }
            else
            {
                Console.WriteLine("Final Score:" + finalresult + " Grade F");
            }
            Console.ReadKey();
            Console.Clear();


        }

        private static void integer()
        {
            Console.Clear();
            Console.WriteLine("Insert a value: ");
            string value1 = Console.ReadLine();
            Console.WriteLine(value1 + " Has a total of: " + value1.Length + "digits");


            Console.ReadKey();
            Console.Clear();

        }

        private static void ascii()
        {
            for (int i = 1; i < 122; i++)
            {
                Console.Write(" " + i + " = " + (char)i);

                if (i % 10 == 0)
                {
                    Console.WriteLine(" ");

                }

            }

        }

        private static void space()
        {
          
        }
    }
}
