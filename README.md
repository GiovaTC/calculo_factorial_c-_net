# 📘 Programa: Factorial desde 32 hasta N

<img width="2554" height="1078" alt="image" src="https://github.com/user-attachments/assets/eb9b31a2-fb39-4e00-85f5-59233f58f78c" />

Este programa en **C#**, compatible con **Visual Studio 2022**, calcula los factoriales desde **0 o 1 hasta `n`**, pero **solo imprime los resultados desde 32! en adelante**. Utiliza la clase `BigInteger` para manejar grandes cantidades.

---

## 🛠 Requisitos

- Visual Studio 2022
- .NET 6 o superior
- Espacio suficiente en consola (la salida de los factoriales grandes puede ser extensa)

---

## 🚀 Cómo Ejecutar

1. Abre **Visual Studio 2022**.
2. Crea un nuevo proyecto de tipo:
   - `Aplicación de consola` (.NET 6 o superior)
   - Nombre sugerido: `FactorialDesde32`
3. Reemplaza el contenido de `Program.cs` con el siguiente código:

---

## 💻 Código en `Program.cs`

```csharp
using System;
using System.Numerics; // Necesario para BigInteger

namespace FactorialDesde32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero n (n >= 32):");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 32)
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número entero mayor o igual a 32.");
                return;
            }

            Console.WriteLine($"\nFactoriales desde 32 hasta {n}:\n");

            for (int i = 0; i <= n; i++)
            {
                if (i < 32) continue;

                BigInteger factorial = CalcularFactorial(i);
                Console.WriteLine($"{i}! = {factorial}");
            }
        }

        static BigInteger CalcularFactorial(int numero)
        {
            BigInteger resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
🧠 Detalles Técnicos
Tipo de dato: Usa BigInteger porque factoriales como 32! exceden los límites de long.

Validación de entrada: Solo se aceptan valores n >= 32.

Rango calculado: Desde 0 hasta n, pero solo se imprime desde 32!.

📌 Ejemplo de salida
Si se ingresa n = 35, la salida será:

32! = 263130836933693530167218012160000000
33! = 8683317618811886495518194401280000000
34! = 295232799039604140847618609643520000000
35! = 10333147966386144929666651337523200000000
📝 Notas
Si necesitas guardar los resultados en un archivo .txt, imprimir desde un número distinto, o implementar una interfaz gráfica, el código puede extenderse fácilmente.

Se puede adaptar para calcular en paralelo si se necesita optimización.
