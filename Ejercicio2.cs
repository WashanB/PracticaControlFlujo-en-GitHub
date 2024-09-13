using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear un diccionario para almacenar los usuarios registrados
        Dictionary<string, string> usuarios = new Dictionary<string, string>();
        
        // Registrar hasta 100 usuarios
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Ingrese el nick del usuario:");
            string nick = Console.ReadLine();
            
            // Verificar si el nick ya está registrado
            if (usuarios.ContainsKey(nick))
            {
                Console.WriteLine("El nick ya está registrado. Intente con otro nick.");
                i--; // Decrementar el índice para que el usuario pueda intentar de nuevo
                continue;
            }
            
            Console.WriteLine("Ingrese la contraseña del usuario:");
            string contrasena = Console.ReadLine();
            
            // Registrar el usuario en el diccionario
            usuarios[nick] = contrasena;
            
            Console.WriteLine("Usuario registrado exitosamente.");
        }
        
        // Consultar si un usuario está registrado
        while (true)
        {
            Console.WriteLine("\nIngrese el nick para verificar si está registrado:");
            string nickConsulta = Console.ReadLine();
            
            if (usuarios.ContainsKey(nickConsulta))
            {
                Console.WriteLine("El usuario está registrado.");
            }
            else
            {
                Console.WriteLine("El usuario no está registrado.");
            }

            // Opción para salir del bucle de consulta
            Console.WriteLine("¿Desea verificar otro usuario? (si/no):");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() != "si")
            {
                break;
            }
        }
    }
}
