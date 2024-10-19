using System.Numerics;
using System;

namespace program
{
    class Calculation
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("fatel Error, Cannot divide by zero");
                return 0;
            }
            return num1 / num2;
        }

        public int Remainder(int num1, int num2)
        {
            if (num2 == 0) // divisor is equal zero quotient is undefined, then remainder is undefined too
                return 0;
            return num1 % num2;
        }

        public double Exponentiation(double num1, int num2)
        {
            double product = 1;
            int count = 0;
            if (num2 < 0)
            {
                Console.WriteLine("Exponent Should Be Positive Integer");
                return 0; // if number is not a positive integer return zero (function will only support positive integers)
            }
            while (count < num2)
            {
                product = product * num1;
                count++;
            }
            return product;
        }

        public double Squareroot(double num1)
        {
            double i = 0.0;
            if (num1 >= 0)
            {
                while (i * i != num1)
                {
                    i++;
                }
                return i;
            }
            return 0; // negative numbers does not have a real square roots
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(" Key \t Triggers ");
            Console.WriteLine(" + \t Sum operation");
            Console.WriteLine(" - \t Subtraction operation");
            Console.WriteLine(" * \t Division operation ");
            Console.WriteLine(" / \t Multiplication operation ");
            Console.WriteLine(" % \t Reminder operation ,  calculate remainder of integer division");
            Console.WriteLine(" ^ \t Exponentiation function ");
            Console.WriteLine(" s \t Square root operation ,operation having one operand");
            Console.WriteLine(" = \t Operator that triggers particular operation (above) to execute ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("after each input 'entry' PRESS ENTER, then Enter '=' to get the value");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("To save the last Input Press M after entering the number, if it was first Input (num1) it will be stored but no calculation afer it");
            Console.WriteLine("If M entered after the second Input, it will be stored and you can continue the calculation if you wish.");
            Console.WriteLine("------------------------------------------------------------------------");

            double result = 0.0;
            Calculation calc = new Calculation();

            string firstInput = "0";
            double num1 = 0;
            string operation = "+";
            double num2 = 0;
            string equal = "=";
            bool inputType;
            double[] Mem = {};
            String toSave;
            int i;
            List<double> list = new List<double>();

            while (true)
            {
                Console.WriteLine("To save the last Result Press P, Press Enter to skip");
                String toDisplay = Console.ReadLine();
                if (String.Equals(toDisplay, "P"))
                {
                    foreach (double a in list)
                        Console.WriteLine(a);
                }

                Console.WriteLine("To retrieve and continue with any number they want from the list Press Rn (n any number from the list larger than 0)");
                Console.WriteLine("To save Result of the calculation Press M");
                Console.WriteLine("if not, contiue normally");

                firstInput = Console.ReadLine();
                string fs = firstInput.Substring(0, 1);
                if (fs == "R")
                {
                    int x = (firstInput.Length) - 1; 
                    int n;
                    if (int.TryParse(firstInput.Substring(1, x), out n)) // to parse and get the element index 
                    {
                        num1 = list[n]; // get the element at that index, then continue
                        operation = Console.ReadLine();
                        switch (operation)
                        {
                            case "+":
                                string n2_s = Console.ReadLine();
                                inputType = double.TryParse(n2_s, out num2);
                                if (inputType == true)
                                {
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Add(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if(equal == "=") { 
                                            result = calc.Add(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Add(num1, num2);
                                    }
                                }
                                else
                                {
                                    num2 = num1;
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Add(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Add(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Add(num1, num2);
                                    }
                                }
                                Console.WriteLine(num1 + operation + num2 + equal + result);
                                break;

                            case "-":
                                n2_s = Console.ReadLine();
                                inputType = double.TryParse(n2_s, out num2);
                                if (inputType == true)
                                {
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Subtract(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Subtract(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Subtract(num1, num2);
                                    }
                                }
                                else
                                {
                                    num2 = num1;
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Subtract(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Subtract(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Subtract(num1, num2);
                                    }
                                }
                                Console.WriteLine(num1 + operation + num2 + equal + result);
                                break;

                            case "*":
                                n2_s = Console.ReadLine();
                                inputType = double.TryParse(n2_s, out num2);
                                if (inputType == true)
                                {
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Multiply(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Multiply(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Multiply(num1, num2);
                                    }
                                }
                                else
                                {
                                    num2 = num1;
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Multiply(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Multiply(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Multiply(num1, num2);
                                    }
                                }
                                Console.WriteLine(num1 + operation + num2 + equal + result);
                                break;

                            case "/":
                                n2_s = Console.ReadLine();
                                inputType = double.TryParse(n2_s, out num2);
                                if (inputType == true)
                                {
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Divide(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Divide(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Divide(num1, num2);
                                    }
                                }
                                else
                                {
                                    num2 = num1;
                                    equal = Console.ReadLine();
                                    if (equal == "=") // equal sign trigger the operation
                                    {
                                        result = calc.Divide(num1, num2);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Divide(num1, num2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Divide(num1, num2);
                                    }
                                }
                                Console.WriteLine(num1 + operation + num2 + equal + result);
                                break;

                            case "%":
                                int numx1 = ((int)num1);
                                int numx2;
                                n2_s = Console.ReadLine();
                                inputType = int.TryParse(n2_s, out numx2);
                                if (inputType == true)
                                {
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Remainder(numx1, numx2);
                                        Console.WriteLine(result);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Remainder(numx1, numx2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Remainder(numx1, numx2);
                                    }
                                }
                                else
                                {
                                    numx2 = (int)num1;
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Remainder(numx1, numx2);
                                        Console.WriteLine(result);
                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Remainder(numx1, numx2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Remainder(numx1, numx2);
                                    }

                                }
                                Console.WriteLine(numx1 + operation + numx2 + equal + result);
                                break;

                            case "^":
                                int n2;
                                n2_s = Console.ReadLine();
                                inputType = int.TryParse(n2_s, out n2);
                                if (inputType == true)
                                {
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Exponentiation(num1, n2);

                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Subtract(num1, n2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Exponentiation(num1, n2);
                                    }
                                }
                                else
                                {
                                    n2 = (int)num1;
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Exponentiation(num1, n2);

                                    }
                                    else if (equal == "M")
                                    {
                                        list.Add(num2);
                                        Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                        equal = Console.ReadLine();
                                        if (equal == "=")
                                        {
                                            result = calc.Subtract(num1, n2);
                                        }
                                    }
                                    else
                                    {
                                        equal = "=";
                                        result = calc.Exponentiation(num1, n2);
                                    }
                                }
                                Console.WriteLine(num1 + operation + n2 + equal + result);
                                break;

                            case "s":
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Squareroot(num1);

                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Squareroot(num1);
                                }
                                Console.WriteLine(num1 + operation + equal + result);
                                break;

                            case "M":
                                list.Add(num1);
                                break;

                            default:
                                Console.WriteLine(result);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("failed");
                    }
                   
                }
                // if user first input is a number, then convert it to double
                inputType = double.TryParse(firstInput, out num1);
                if (inputType == true )
                {
                    operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            string n2_s = Console.ReadLine();
                            inputType = double.TryParse(n2_s, out num2);
                            if (inputType == true)
                            {
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Add(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Add(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Add(num1, num2);
                                }
                            }
                            else
                            {
                                num2 = num1;
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Add(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Add(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Add(num1, num2);
                                }
                            }
                            Console.WriteLine(num1 + operation + num2 + equal + result);
                            break;

                        case "-":
                            n2_s = Console.ReadLine();
                            inputType = double.TryParse(n2_s, out num2);
                            if (inputType == true)
                            {
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Subtract(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Subtract(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Subtract(num1, num2);
                                }
                            }
                            else
                            {
                                num2 = num1;
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Subtract(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Subtract(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Subtract(num1, num2);
                                }
                            }
                            Console.WriteLine(num1 + operation + num2 + equal + result);
                            break;

                        case "*":
                            n2_s = Console.ReadLine();
                            inputType = double.TryParse(n2_s, out num2);
                            if (inputType == true)
                            {
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Multiply(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Multiply(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Multiply(num1, num2);
                                }
                            }
                            else
                            {
                                num2 = num1;
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Multiply(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Multiply(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Multiply(num1, num2);
                                }
                            }
                            Console.WriteLine(num1 + operation + num2 + equal + result);
                            break;

                        case "/":
                            n2_s = Console.ReadLine();
                            inputType = double.TryParse(n2_s, out num2);
                            if (inputType == true)
                            {
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Divide(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Divide(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Divide(num1, num2);
                                }
                            }
                            else
                            {
                                num2 = num1;
                                equal = Console.ReadLine();
                                if (equal == "=") // equal sign trigger the operation
                                {
                                    result = calc.Divide(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Divide(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Divide(num1, num2);
                                }
                            }
                            Console.WriteLine(num1 + operation + num2 + equal + result);
                            break;

                        case "%":
                            int numx1 = ((int)num1);
                            int numx2;
                            n2_s = Console.ReadLine();
                            inputType = int.TryParse(n2_s, out numx2);
                            if (inputType == true)
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Remainder(numx1, numx2);
                                    Console.WriteLine(result);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Remainder(numx1, numx2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Remainder(numx1, numx2);
                                }
                            }
                            else
                            {
                                numx2 = (int)num1;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Remainder(numx1, numx2);
                                    Console.WriteLine(result);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Remainder(numx1, numx2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Remainder(numx1, numx2);
                                }

                            }
                            Console.WriteLine(numx1 + operation + numx2 + equal + result);
                            break;

                        case "^":
                            int n2;
                            n2_s = Console.ReadLine();
                            inputType = int.TryParse(n2_s, out n2);
                            if (inputType == true)
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Exponentiation(num1, n2);

                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Exponentiation(num1, n2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Exponentiation(num1, n2);
                                }
                            }
                            else
                            {
                                n2 = (int)num1;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Exponentiation(num1, n2);

                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Exponentiation(num1, n2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Exponentiation(num1, n2);
                                }
                            }
                            Console.WriteLine(num1 + operation + n2 + equal + result);
                            break;

                        case "s":
                            equal = Console.ReadLine();
                            if (equal == "=")
                            {
                                result = calc.Squareroot(num1);

                            }
                            else
                            {
                                equal = "=";
                                result = calc.Squareroot(num1);
                            }
                            Console.WriteLine(num1 + operation  + equal + result);
                            break;

                        case "M":
                            list.Add(num1);
                            break;

                        default:
                            Console.WriteLine( result);
                            break;
                    }
                }
                else if (inputType == false && (firstInput == "Q" || firstInput == "q"))
                { // if input is equal to q exit
                    System.Environment.Exit(1);
                }
                else if(inputType == false && firstInput == "M")
                {
                    list.Add(result);
                }
                else
                { // if input is a char then it is operation sign (calculation will be based on previous result) or not valid char
                    num1 = result;
                    operation = firstInput;
                    switch (operation)
                    {
                        case "+":
                            string n2s = Console.ReadLine();
                            if (double.TryParse(n2s, out num2))
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Add(num1, num2);
                                }
                                else if(equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Add(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Add(num1, num2);
                                }
                            }
                            else
                            {   
                                num2 = num1;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Add(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Add(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Add(num1, num2);
                                }
                            }
                            Console.WriteLine( num1 + operation + num2 + equal + result);
                            break;

                        case "-":
                            n2s = Console.ReadLine();
                            if (double.TryParse(n2s, out num2))
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Subtract(num1, num2);
                                }
                                else if(equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Subtract(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Subtract(num1, num2);
                                }
                            }
                            else
                            {
                                num2 = num1;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Subtract(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Subtract(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Subtract(num1, num2);
                                }
                            }
                            Console.WriteLine(num1 + operation + num2 + equal + result);
                            break;

                        case "*":
                            n2s = Console.ReadLine();
                            if (double.TryParse(n2s, out num2))
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Multiply(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Multiply(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Multiply(num1, num2);
                                }
                            }
                            else
                            {
                                num2 = num1;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Multiply(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Multiply(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Multiply(num1, num2);
                                }
                            }
                            Console.WriteLine(num1 + operation + num2 + equal + result);
                            break;

                        case "/":
                            n2s = Console.ReadLine();
                            if (double.TryParse(n2s, out num2))
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Divide(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Divide(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Divide(num1, num2);
                                }
                            }
                            else
                            {
                                num2 = result;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Divide(num1, num2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(num2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Divide(num1, num2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Divide(num1, num2);
                                }
                            }
                            Console.WriteLine(num1 + operation + num2 + equal + result);
                            break;

                        case "%":
                            int nx1 = (int)num1;
                            int nx2;
                            n2s = Console.ReadLine();
                            if (int.TryParse(n2s, out nx2))
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Remainder(nx1, nx2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(nx2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Remainder(nx1, nx2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Remainder(nx1, nx2);
                                }
                            }
                            else
                            {
                                nx2 = (int)result;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Remainder(nx1, nx2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(nx2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Remainder(nx1, nx2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Remainder(nx1, nx2);
                                }
                            }
                            Console.WriteLine(nx1 + operation + nx2 + equal + result);
                            break;

                        case "^":
                            int n2;
                            n2s = Console.ReadLine();
                            if (int.TryParse(n2s, out n2))
                            {
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Exponentiation(num1, n2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(n2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Exponentiation(num1, n2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Exponentiation(num1, n2);
                                }
                            }
                            else
                            {
                                n2 = (int)num1;
                                equal = Console.ReadLine();
                                if (equal == "=")
                                {
                                    result = calc.Exponentiation(num1, n2);
                                }
                                else if (equal == "M")
                                {
                                    list.Add(n2);
                                    Console.WriteLine("You stored the Second Input (num2), if you want to get result enter '=' , if you not Press Enter to continue");
                                    equal = Console.ReadLine();
                                    if (equal == "=")
                                    {
                                        result = calc.Exponentiation(num1, n2);
                                    }
                                }
                                else
                                {
                                    equal = "=";
                                    result = calc.Exponentiation(num1, n2);
                                }

                            }
                            Console.WriteLine(num1 + operation + n2 + equal + result);
                            break;
                            
                        case "s":
                            equal = Console.ReadLine();
                            if (equal == "=")
                            {
                                result = calc.Squareroot(num1);
                            }
                            else
                            {
                                equal = "=";
                                result = calc.Squareroot(num1);
                            }
                            Console.WriteLine(num1 + operation + equal + result);
                            break;

                        case "M":
                            list.Add(num1);
                            break;

                        default:
                            Console.WriteLine(result);
                            break;

                    }
                }
            }
        }
    }
}
