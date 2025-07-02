using Humanizer; // Importa la biblioteca Humanizer para formatear cadenas de texto
Console.WriteLine("Ingresa un nombre!"); // Solicita al usuario que ingrese un nombre
var nombre = Console.ReadLine(); // Lee la entrada del usuario
Console.WriteLine("Por favor, ingrese su cargo"); // Solicita al usuario que ingrese su cargo
var cargo = Console.ReadLine(); // Lee la entrada del usuario
Console.WriteLine("Por favor, ingrese su edad"); // Solicita al usuario que ingrese su edad
var edad = int.Parse(Console.ReadLine()); // Lee la entrada del usuario

Console.WriteLine($"Hola, Mi nombre es {nombre}, mi cargo es{cargo}, y tengo {edad.ToWords()} años"); // Imprime la información ingresada por el usuario
Console.WriteLine("Presiona cualquier tecla para salir..."); // Solicita al usuario que presione una tecla para salir