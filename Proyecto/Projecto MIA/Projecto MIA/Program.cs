/*/Sebastian Echeverria Flores - 1138122
 * Samuel Alejandro Ruiz Escalona - 1228722/*/
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FileManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar Carrera");
                Console.WriteLine("2. Agregar Estudiante");
                Console.WriteLine("3. Mostrar Carreras");
                Console.WriteLine("4. Mostrar Estudiantes");
                Console.WriteLine("5. Reinicio (Borrar todos los datos)");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese su opción: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        FileManager.AddCareer();
                        break;
                    case "2":
                        FileManager.AddStudent();
                        break;
                    case "3":
                        FileManager.DisplayCareers();
                        break;
                    case "4":
                        FileManager.DisplayStudents();
                        break;
                    case "5":
                        FileManager.ClearData();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }

    public static class FileManager
    {
        private static string CareersFile = "careers.dat";
        private static string StudentsFile = "students.dat";

        public static void AddCareer()
        {
            Console.Write("Código de la carrera: ");
            string code = Console.ReadLine();
            Console.Write("Nombre de la carrera: ");
            string name = Console.ReadLine();

            using (BinaryWriter writer = new BinaryWriter(File.Open(CareersFile, FileMode.Append)))
            {
                writer.Write(code);
                writer.Write(name);
            }

            Console.WriteLine("Carrera agregada correctamente.");
        }

        public static void AddStudent()
        {
            string carnet;
            do
            {
                Console.Write("Carnet del estudiante (número único): ");
                carnet = Console.ReadLine();
            } while (!IsUniqueCarnet(carnet) || !IsNumeric(carnet));

            Console.Write("Nombre del estudiante: ");
            string name = Console.ReadLine();

            string color;
            do
            {
                Console.Write("Color favorito del estudiante: ");
                color = Console.ReadLine();
            } while (!IsValidColor(color));

            string careerCode;
            do
            {
                Console.Write("Código de la carrera del estudiante: ");
                careerCode = Console.ReadLine();
            } while (!CareerExists(careerCode));

            using (BinaryWriter writer = new BinaryWriter(File.Open(StudentsFile, FileMode.Append)))
            {
                writer.Write(carnet);
                writer.Write(name);
                writer.Write(color);
                writer.Write(careerCode);
            }

            Console.WriteLine("Estudiante agregado correctamente.");
        }

        public static void DisplayCareers()
        {
            if (!File.Exists(CareersFile))
            {
                Console.WriteLine("No hay carreras para mostrar.");
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(CareersFile, FileMode.Open)))
            {
                Console.WriteLine("\nCarreras actuales:");
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string code = reader.ReadString();
                    string name = reader.ReadString();
                    Console.WriteLine($"Código: {code}, Nombre: {name}");
                }
            }
        }

        public static void DisplayStudents()
        {
            if (!File.Exists(StudentsFile))
            {
                Console.WriteLine("No hay estudiantes para mostrar.");
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(StudentsFile, FileMode.Open)))
            {
                Console.WriteLine("\nEstudiantes actuales:");
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string carnet = reader.ReadString();
                    string name = reader.ReadString();
                    string color = reader.ReadString();
                    string careerCode = reader.ReadString();
                    Console.WriteLine($"Carnet: {carnet}, Nombre: {name}, Color: {color}, Carrera Código: {careerCode}");
                }
            }
        }

        public static void ClearData()
        {
            if (File.Exists(CareersFile))
            {
                File.Delete(CareersFile);
            }

            if (File.Exists(StudentsFile))
            {
                File.Delete(StudentsFile);
            }

            Console.WriteLine("Todos los datos han sido borrados.");
        }

        private static bool IsUniqueCarnet(string carnet)
        {
            if (!File.Exists(StudentsFile))
                return true;

            using (BinaryReader reader = new BinaryReader(File.Open(StudentsFile, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string existingCarnet = reader.ReadString();
                    reader.ReadString(); // Skip Name
                    reader.ReadString(); // Skip Color
                    reader.ReadString(); // Skip CareerCode

                    if (existingCarnet == carnet)
                    {
                        Console.WriteLine("Error: Carnet ya existe. Intente con otro.");
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsNumeric(string carnet)
        {
            if (!Regex.IsMatch(carnet, @"^\d+$"))
            {
                Console.WriteLine("Error: Carnet debe ser un número.");
                return false;
            }
            return true;
        }

        private static bool IsValidColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                Console.WriteLine("Error: Color no puede estar vacío.");
                return false;
            }
            return true;
        }

        private static bool CareerExists(string careerCode)
        {
            if (!File.Exists(CareersFile))
            {
                Console.WriteLine("Error: No existen carreras registradas.");
                return false;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(CareersFile, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string code = reader.ReadString();
                    reader.ReadString(); // Skip career name

                    if (code == careerCode)
                        return true;
                }
            }

            Console.WriteLine("Error: Código de carrera no encontrado. Intente nuevamente.");
            return false;
        }
    }
}