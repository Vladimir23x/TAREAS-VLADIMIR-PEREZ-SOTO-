using System;
using Escuela.Modelos;

class Program
{
    static void Main()
    {
        Escuela.Modelos.Escuela escuela = new Escuela.Modelos.Escuela();
        Clase clase1 = new Clase("CLASE P2");
        escuela.AgregarClase(clase1);

        // AGREGANDO LOS ESTUDIANTES
        Estudiante estudiante1 = new Estudiante("VLADIMIR PEREZ SOTO", 2024-0061);
        Estudiante estudiante2 = new Estudiante("MARCOZ MARTINEZ", 2022-0012);
        Estudiante estudiante3 = new Estudiante("VALERIA ROSARIO", 2023-0134);
        clase1.AgregarEstudiante(estudiante1);
        clase1.AgregarEstudiante(estudiante2);
        clase1.AgregarEstudiante(estudiante3);

        // AGREGANDO LOS PROFESORES
        Profesor profesor1 = new Profesor("FRANCIS RAMIREZ");
        Curso curso1 = new Curso("PROGRAMACION II", 4, 9);
        Profesor profesor2 = new Profesor("MICHAEL GARCIA");
        Curso curso2 = new Curso("CALCULO INTEGRAL", 2, 11);
        profesor1.AsignarCurso(curso1);
        clase1.AgregarProfesor(profesor1);
        profesor2.AsignarCurso(curso2);
        clase1.AgregarProfesor(profesor2);
        
        Console.WriteLine($"Clase: {clase1.Identificador}");
        Console.WriteLine($"NUMERO DE ESTUDIANTES: {clase1.Estudiantes.Count}");
        Console.WriteLine($"NUMERO DE PROFESORES: {clase1.Profesores.Count}");

        Console.WriteLine("\n ESTUDIANTES EN LA CLASE:");
        foreach (var estudiante in clase1.Estudiantes)
        {
            Console.WriteLine($"- {estudiante.Nombre} (ID: {estudiante.NumeroUnico})");
        }

        Console.WriteLine("\n PROFESORES Y CURSOS:");
        foreach (var profesor in clase1.Profesores)
        {
            Console.WriteLine($"- PROFESOR: {profesor.Nombre}");
            Console.WriteLine("  CURSOS IMPARTIDOS:");
            foreach (var curso in profesor.Cursos)
            {
                Console.WriteLine($"    • {curso.Nombre} (Clases: {curso.RecuentoClases}, Ejercicios: {curso.RecuentoEjercicios})");
            }
        }
    }
}
