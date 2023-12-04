class Calculadora4
{
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu calculadora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Exponente");
            Console.WriteLine("6. Raiz");
            Console.WriteLine("7. Salir");
            Console.Write("Ingresa una opcion: ");
            string seleccion = Console.ReadLine();

            switch (seleccion)
            {
                case "1":
                    Suma();
                    break;
                case "2":
                    Resta();
                    break;
                case "3":
                    Multiplicacion();
                    break;
                case "4":
                    Division();
                    break;
                case "5":
                    Exponente();
                    break;
                case "6":
                    Raiz();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opcion invalida, intenta nuevamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Suma()
    {
        Console.Write("Ingresa el primer numero: ");
        string input1 = Console.ReadLine();
        Console.Write("Ingresa el segundo numero: ");
        string input2 = Console.ReadLine();

        if (IsNumeric(input1) && IsNumeric(input2))
        {
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);
            double result = num1 + num2;
            Console.WriteLine($"Resultado: {result}");
        }
        else
        {
            Console.WriteLine("Valor invalido. Ingresa valores numericos.");
        }
    }

    static void Resta()
    {
        Console.Write("Ingresa el primer numero: ");
        string input1 = Console.ReadLine();
        Console.Write("Ingresa el segundo numero: ");
        string input2 = Console.ReadLine();

        if (IsNumeric(input1) && IsNumeric(input2))
        {
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);
            double result = num1 - num2;
            Console.WriteLine($"Resultado: {result}");
        }
        else
        {
            Console.WriteLine("Valor invalido. Ingresa valores numericos.");
        }
    }

    static void Multiplicacion()
    {
        Console.Write("Ingresa el primer numero: ");
        string input1 = Console.ReadLine();
        Console.Write("Ingresa el segundo numero: ");
        string input2 = Console.ReadLine();

        if (IsNumeric(input1) && IsNumeric(input2))
        {
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);
            double result = num1 * num2;
            Console.WriteLine($"Resultado: {result}");
        }
        else
        {
            Console.WriteLine("Valor invalido. Ingresa valores numericos.");
        }
    }

    static void Division()
    {
        Console.Write("Ingresa el dividendo: ");
        string input1 = Console.ReadLine();
        Console.Write("Ingresa el divisor: ");
        string input2 = Console.ReadLine();

        if (IsNumeric(input1) && IsNumeric(input2))
        {
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);

            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine($"Resultado: {result}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0.");
            }
        }
        else
        {
            Console.WriteLine("Valor invalido. Ingresa valores numericos.");
        }
    }

    static void Exponente()
    {
        Console.Write("Ingresa la base: ");
        string input1 = Console.ReadLine();
        Console.Write("Ingresa el exponente: ");
        string input2 = Console.ReadLine();

        if (IsNumeric(input1) && IsNumeric(input2))
        {
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);
            double result = Math.Pow(num1, num2);
            Console.WriteLine($"Resultado: {result}");
        }
        else
        {
            Console.WriteLine("Valor invalido. Ingresa valores numericos.");
        }
    }

    static void Raiz()
    {
        Console.Write("Ingresa el numero: ");
        string input1 = Console.ReadLine();

        if (IsNumeric(input1))
        {
            double num1 = double.Parse(input1);
            double result = Math.Sqrt(num1);
            Console.WriteLine($"Resultado: {result}");
        }
        else
        {
            Console.WriteLine("Valor invalido. Ingresa valores numericos.");
        }
    }
    static bool IsNumeric(string input)
    {
        return double.TryParse(input, out _);
    }
}