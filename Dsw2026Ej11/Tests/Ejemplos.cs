using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var casoList = new CasoList();
        var a1 = new Alumno(0, "Manuel", 10);
        var a2 = new Alumno(1, "Pablo", 9);
        var a3 = new Alumno(2, "Joel", 8);
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        void MostrarAlumnos()
        {
            foreach (var alumno in casoList.ObtenerAlumnos())
            {
                Console.WriteLine(alumno.ToString());
            }
        }

        MostrarAlumnos();

        Console.WriteLine("\nMostrar alumno buscado por nombre:");
        var a4 = casoList.BuscarAlumno("Manuel");
        Console.WriteLine(a4.ToString());

        Console.WriteLine("\nMostrar búsqueda de alumno que no existe:");
        var a5 = casoList.BuscarAlumno("Milton");
        if (a5 == null)
        {
            Console.WriteLine("No existe");
        }

        casoList.EliminarAlumno(a2);
        MostrarAlumnos();

        casoList.EliminarAlumnoEnPosicion(0);
        MostrarAlumnos();
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var casoDic = new CasoDictionary();
        var a1 = new Alumno(0, "Manuel", 10);
        var a2 = new Alumno(1, "Pablo", 9);
        var a3 = new Alumno(2, "Joel", 8);
        casoDic.AgregarAlumno(111, a1);
        casoDic.AgregarAlumno(222, a2);
        casoDic.AgregarAlumno(333, a3);

        void MostrarAlumnos()
        {
            foreach (var alumno in casoDic.ObtenerAlumnos())
            {
                Console.WriteLine(alumno.Value.ToString());
            }
        }

        MostrarAlumnos();

        Console.WriteLine("\nMostrar alumno buscado por clave:");
        Console.WriteLine(casoDic.BuscarAlumno(111).ToString());

        Console.WriteLine("\nMostrar búsqueda de alumno por clave que no existe:");
        var a4 = casoDic.BuscarAlumno(000);
        if (a4 == null)
        {
            Console.WriteLine("No existe");
        }

        casoDic.EliminarAlumnos(333);
        MostrarAlumnos();
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var casoLinq = new CasoLinq();

        Console.WriteLine("\nMostrar el primer libro:");
        var l1 = casoLinq.GetPrimero();
        Console.WriteLine(l1.ToString());

        Console.WriteLine("\nMostrar el último libro:");
        var l2 = casoLinq.GetUltimo();
        Console.WriteLine(l2.ToString());

        Console.WriteLine("\nMostrar el total de los precios:");
        var totalPrecios = casoLinq.GetTotalPrecios();
        Console.WriteLine(totalPrecios);

        Console.WriteLine("\nMostrar el promedio de los precios:");
        var promedio = casoLinq.GetPromedioPrecios();
        Console.WriteLine($"{promedio:C}");

        Console.WriteLine("\nMostrar libros con ID mayor a 15:");
        var librosById = casoLinq.GetListById();
        foreach (var libro in librosById)
        {
            Console.WriteLine(libro.ToString());
        }

        Console.WriteLine("\nMostrar títulos y precios de los libros:");
        var listaStrings = casoLinq.GetLibros();
        foreach (var libro in listaStrings)
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nMostrar el libro con el mayor precio:");
        var libroMayorPrecio = casoLinq.GetMayorPrecio();
        Console.WriteLine(libroMayorPrecio.ToString());

        Console.WriteLine("\nMostrar el libro con el menor precio:");
        var libroMenorPrecio = casoLinq.GetMenorPrecio();
        Console.WriteLine(libroMenorPrecio.ToString());

        Console.WriteLine("\nMostrar libros con precio mayor al promedio:");
        var librosMayorPromedio = casoLinq.GetMayorPromedio();
        foreach (var libro in librosMayorPromedio)
        {
            Console.WriteLine(libro.ToString());
        }

        Console.WriteLine("\nMostrar libros ordenados por título:");
        var librosOrdenados = casoLinq.GetOrdenadoPorTitulo();
        foreach (var libro in librosOrdenados)
        {
            Console.WriteLine(libro.ToString());
        }
    }
}
