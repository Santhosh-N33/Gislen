using System;

namespace CalculatorConsoleApp
{
    class Calculator
    {

        static void Main(String[] args)
        {
            double values;
            string continue_, chooice;


            do
            {
                Console.Clear();
                Console.WriteLine("\t! Welcome to Console Calculator Application !");
                Console.WriteLine("\t====================================================== \n");

                //Chooice of Operation
                Console.WriteLine("\tPress the Operation Number\n\t\t1.Addition\n\t\t2.Subraction\n\t\t3.Multiple\n\t\t4.Division\n\t\t5.Power\n\t\t6.Modulus \n\t\t7.Square root\n" +
                    "\t\t8.cube root\n\t\t9.Log\n\t\t10.Square\n\t\t11.Cube\n\t\t12.Exit");
                Console.WriteLine("\t====================================================== \n");
                Console.WriteLine("\tEnter the Opeation:\n");
                Console.WriteLine("\t====================================================== \n");
                chooice = Console.ReadLine();

                List<double> numbers = new List<double>();
                double inputs;
                double result = 0;

                //Geting multiple inputs from User
                if (chooice == "1" || chooice == "2" || chooice == "3" || chooice == "4" || chooice=="10" || chooice == "12" ) // Only For Additon, Subraction, Multiplication, Divison
                {
                    Console.WriteLine("\n\t--------------------------------------------------------\n");
                    Console.WriteLine("\tEnter the Values after enter values type  0 ! ");

                    while (true)
                    {
                        inputs = Convert.ToDouble(Console.ReadLine());
                        if (inputs == 000)
                        {
                            break;
                        }
                        numbers.Add(inputs);

                    }

                }
                switch (chooice)
                {
                    //Find Addition Value

                    case "1":
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        foreach (double i in numbers)
                        {
                            result += i;
                        }
                        Console.WriteLine("\t your answer is :" + result);

                        break;


                    //Find Subraction Value

                    case "2":
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        result = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            result -= numbers[i];
                        }
                        Console.WriteLine("\tYour answer is :" + result);

                        break;

                    //Find Multiplication Value

                    case "3":
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        result = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            result *= numbers[i];
                        }
                        Console.WriteLine("\tYour answer is :" + result);

                        break;

                    //Find Divition Value

                    case "4":
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        result = numbers[0];
                        if (result != 0)
                        {
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] != 0)
                                {
                                    result *= numbers[i];
                                }
                            }
                        }
                        Console.WriteLine("\tYour answer is :" + result);

                        break;

                    // Find Power Value  

                    case "5":
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        Console.WriteLine("\tEnter the value and its power with separate space (eg:2 3):");
                        string[] pow_values = Console.ReadLine().Split(' ');
                        double num = double.Parse(pow_values[0]);
                        double pow = double.Parse(pow_values[1]);
                        Console.WriteLine("\tYour Answer is :" + Math.Pow(num, pow));
                        break;

                    //Find Moudulus Value

                    case "6":
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        Console.WriteLine("\tEnter the two values to find modulus with separate space (eg:2 3):");
                        string[] mod = Console.ReadLine().Split(' ');
                        double numarator = double.Parse(mod[0]);
                        double denominator = double.Parse(mod[1]);
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        Console.WriteLine("\t The modulud of " + numarator + " and " + denominator + " is :" + (numarator % denominator));
                        break;

                    //Find Square Root

                    case "7":
                        Console.WriteLine("\n\t--------------------------------------------------------");
                        Console.WriteLine("\tEnter the Value to find Square root:");
                        double sqr_root = Convert.ToDouble(Console.ReadLine());
                        double sqr_root_answer = Math.Sqrt(sqr_root);
                        Console.WriteLine("\t The Square Root of " + sqr_root + " is " + sqr_root_answer);
                        break;

                    //Find Cube Root Value

                    case "8":
                        Console.WriteLine("\n\t--------------------------------------------------------");
                        Console.WriteLine("\tEnter the Value to find Cube root:");
                        double cube_root = Convert.ToDouble(Console.ReadLine());
                        double cube_root_answer = Math.Cbrt(cube_root);
                        Console.WriteLine("\t The Square Root of " + cube_root + " is " + cube_root_answer);
                        break;

                    //Find Log Value

                    case "9":
                        Console.WriteLine("\n\t--------------------------------------------------------");
                        Console.WriteLine("\tEnter the Value to find Log:");
                        double log = Convert.ToDouble(Console.ReadLine());
                        double log_answer = Math.Log(log);
                        Console.WriteLine("\tThe Log " + log + " is " + log_answer);
                        break;

                    //Find Square Value

                    case "10":
                        var square = numbers.Select(x => x * x);
                        Console.WriteLine("\t"+string.Join(" ", square));
                        break;

                    //Find Cube Value

                    case "11":
                        var cube = numbers.Select(x => x * x * x);
                        Console.WriteLine("\t" + string.Join(" ", cube));
                        break;

                    //Exit the Application

                    case "12":
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        Console.WriteLine("\t! Thank you !");
                        Console.WriteLine("\n\t--------------------------------------------------------\n");
                        Environment.Exit(0);
                        break;

                    //Wrong option Choose

                    default:
                        Console.WriteLine("\n\t--------------------------------------------------------");
                        Console.WriteLine("\t!! Choose correct !!");
                        break;

                }
                Console.WriteLine("\n\t--------------------------------------------------------");
                Console.WriteLine("\n\tcountinue the calculation say Yes? or No?");
                continue_ = Console.ReadLine();

            } while (continue_.ToLower() == "yes"); 

            }

    }
    }