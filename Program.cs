
class MasaCorporal
// Programa que calcula el índice de masa corporal de una persona
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su peso en kg:");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese su estatura en metros:");
        double estatura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (estatura * estatura);
        imc = Math.Round(imc, 2);

        Console.WriteLine("Tu índice de masa corporal es " + imc);
    }
}

class DivisionGrupos
// Programa que divide a los alumnos en dos grupos según su nombre y sexo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su sexo (M/F):");
        char sexo = Console.ReadLine().ToUpper()[0];

        string grupo = ObtenerGrupo(nombre, sexo);
        Console.WriteLine("Usted pertenece al grupo: " + grupo);
    }

    static string ObtenerGrupo(string nombre, char sexo)
    {
        if ((sexo == 'F' && nombre.ToUpper()[0] < 'M') || (sexo == 'M' && nombre.ToUpper()[0] > 'N'))
        {
            return "A";
        }
        else
        {
            return "B";
        }
    }
}

class SerieFibonacci
// Programa que muestra la serie de Fibonacci hasta un número dado
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Serie de Fibonacci hasta el número {0}:", n);
        for (int i = 0; i <= n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

class NumerosParesEImpares
// Programa que muestra los números pares e impares hasta un número dado
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Números pares:");
        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Números impares:");
        for (int i = 1; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }
    }
}

class TrianguloEscaleno
// Programa que muestra un triángulo escaleno en base a un número dado
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el número de pisos del triángulo: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

class AbecedarioMultiplosDe3
// Programa que muestra el abecedario sin las letras que son múltiplos de 3
{
    static void Main(string[] args)
    {
        List<char> abecedario = new List<char>()
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        for (int i = abecedario.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
            {
                abecedario.RemoveAt(i);
            }
        }

        Console.WriteLine("Lista resultante:");
        foreach (char letter in abecedario)
        {
            Console.Write(letter + " ");
        }
    }
}

class DetectorPalindromos
// Programa que detecta si una palabra es un palíndromo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        string palabraSinEspacios = palabra.Replace(" ", "").ToLower();

        bool esPalindromo = EsPalindromo(palabraSinEspacios);
        if (esPalindromo)
        {
            Console.WriteLine("La palabra: " + palabra + " es un palíndromo");
        }
        else
        {
            Console.WriteLine("La palabra: " + palabra + " no es un palíndromo");
        }
    }

    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

class DiccionarioConInformacionDelUsuario
// Programa que crea un diccionario vacio y le agrega información ingresada por el usuario
{
    static void Main()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Ingresa un parametro:");
            string clave = Console.ReadLine();

            Console.WriteLine("Ingresa el valor del parametro:");
            string valor = Console.ReadLine();

            diccionario.Add(clave, valor);

            Console.WriteLine("Contenido del diccionario:");
            foreach (var item in diccionario)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("¿Desea agregar otro dato? (S/N)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() != "S")
            {
                break;
            }
        }
    }
}
