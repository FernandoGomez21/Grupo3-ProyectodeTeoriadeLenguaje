using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo3_ProyectodeTeoriadeLenguaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Sistema.");
            Console.WriteLine("");

            usuario();

            Console.ReadLine();
        }

        static void usuario()
        {
            // Instancia de NUsuario
            NUsuario nUsuario = new NUsuario();
            var usuarios = nUsuario.TodoslosUsuarios().Where(c=>c.Estado=true); // Obtener la lista de usuarios

            if (usuarios == null || !usuarios.Any())
            {
                Console.WriteLine("No hay usuarios disponibles.");
                return;
            }

            Console.WriteLine("Lista de Usuarios:");
            foreach (var r in usuarios)
            {
                Console.WriteLine($"ID: {r.UsuarioId} |Usuario: {r.User} |Nombre: {r.NombreU} |DNI: {r.DNI} |Estado: {r.Estado}");
            }
        }
    }
}

