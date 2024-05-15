using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string path = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\input_example.jsonl"; // Cambia esto por la ruta del archivo de entrada
        string outputPath = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\output.json"; // Ruta del archivo de salida
        StreamReader file = new StreamReader(path);
        StreamWriter outputFile = new StreamWriter(outputPath);

        string line;
        while ((line = file.ReadLine()) != null)
        {
            using (JsonDocument document = JsonDocument.Parse(line))
            {
                JsonElement root = document.RootElement;
                JsonElement apartments = root.GetProperty("input1");
                JsonElement requirements = root.GetProperty("input2");

                List<int> validApartments = new List<int>();
                for (int i = 0; i < apartments.GetArrayLength(); i++)
                {
                    JsonElement apartment = apartments[i];
                    bool isValid = true;
                    foreach (JsonElement req in requirements.EnumerateArray())
                    {
                        string reqBusiness = req.GetString();
                        if (!apartment.TryGetProperty(reqBusiness, out JsonElement businessExists) || businessExists.GetBoolean() == false)
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validApartments.Add(i);
                    }
                }

                outputFile.WriteLine(JsonSerializer.Serialize(validApartments));
            }
        }

        file.Close();
        outputFile.Close();
    }
}

/* 1 o mas requerimientos
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\input_example.jsonl";
        string outputFile = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\output.json";

        // Leer el archivo de entrada línea por línea
        string[] inputLines = File.ReadAllLines(inputFile);

        // Procesar cada línea del archivo de entrada
        List<int[]> recommendations = new List<int[]>();
        foreach (string line in inputLines)
        {
            using (JsonDocument doc = JsonDocument.Parse(line))
            {
                JsonElement root = doc.RootElement;
                JsonElement input1 = root.GetProperty("input1");
                JsonElement input2 = root.GetProperty("input2");

                int[] recommendation = GetRecommendation(input1, input2);
                recommendations.Add(recommendation);
            }
        }

        // Escribir las recomendaciones en el archivo de salida
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (int[] recommendation in recommendations)
            {
                string recommendationString = "[" + string.Join(",", recommendation) + "]";
                writer.WriteLine(recommendationString);
            }
        }

        Console.WriteLine("Proceso completado. Las recomendaciones se han guardado en el archivo de salida.");
    }

    static int[] GetRecommendation(JsonElement input1, JsonElement input2)
    {
        List<int> matchingIndices = new List<int>();

        // Revisar cada apartamento en input1
        for (int i = 0; i < input1.GetArrayLength(); i++)
        {
            JsonElement apartment = input1[i];
            bool meetsAtLeastOneRequirement = false;

            // Verificar si el apartamento cumple al menos con uno de los negocios en input2
            foreach (JsonElement requirement in input2.EnumerateArray())
            {
                string business = requirement.GetString();
                if (apartment.TryGetProperty(business, out JsonElement value) && value.GetBoolean())
                {
                    meetsAtLeastOneRequirement = true;
                    break;  // Salir del bucle una vez que se encuentre un requisito cumplido
                }
            }

            if (meetsAtLeastOneRequirement)
            {
                matchingIndices.Add(i);
            }
        }

        return matchingIndices.ToArray();
    }
}*/

/* 2 o mas requerimientos
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\input_example.jsonl";
        string outputFile = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\output.json";

        // Leer el archivo de entrada línea por línea
        string[] inputLines = File.ReadAllLines(inputFile);

        // Procesar cada línea del archivo de entrada
        List<int[]> recommendations = new List<int[]>();
        foreach (string line in inputLines)
        {
            using (JsonDocument doc = JsonDocument.Parse(line))
            {
                JsonElement root = doc.RootElement;
                JsonElement input1 = root.GetProperty("input1");
                JsonElement input2 = root.GetProperty("input2");

                int[] recommendation = GetRecommendation(input1, input2);
                recommendations.Add(recommendation);
            }
        }

        // Escribir las recomendaciones en el archivo de salida
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (int[] recommendation in recommendations)
            {
                string recommendationString = "[" + string.Join(",", recommendation) + "]";
                writer.WriteLine(recommendationString);
            }
        }

        Console.WriteLine("Proceso completado. Las recomendaciones se han guardado en el archivo de salida.");
    }

    static int[] GetRecommendation(JsonElement input1, JsonElement input2)
    {
        List<int> matchingIndices = new List<int>();

        // Revisar cada apartamento en input1
        for (int i = 0; i < input1.GetArrayLength(); i++)
        {
            JsonElement apartment = input1[i];
            int requirementCount = 0;  // Contador para los requisitos cumplidos

            // Verificar cuántos requisitos cumple el apartamento
            foreach (JsonElement requirement in input2.EnumerateArray())
            {
                string business = requirement.GetString();
                if (apartment.TryGetProperty(business, out JsonElement value) && value.GetBoolean())
                {
                    requirementCount++;
                }
            }

            // Si cumple con dos o más requisitos, se agrega a la lista
            if (requirementCount >= 2)
            {
                matchingIndices.Add(i);
            }
        }

        return matchingIndices.ToArray();
    }
}
 */