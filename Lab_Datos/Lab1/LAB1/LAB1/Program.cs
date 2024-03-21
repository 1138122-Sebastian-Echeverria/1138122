using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\input_challenge.jsonl";
        string outputFile = "C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\output.json";

        // Leer el archivo de entrada línea por línea
        string[] inputLines = File.ReadAllLines(inputFile);

        // Procesar cada línea del archivo de entrada
        List<int[]> recommendations = new List<int[]>();
        foreach (string line in inputLines)
        {
            // Convertir la línea JSON en un objeto JsonDocument
            using (JsonDocument doc = JsonDocument.Parse(line))
            {
                // Obtener root element del documento JSON
                JsonElement root = doc.RootElement;

                // Obtener input1 y input2 del objeto JSON
                JsonElement input1 = root.GetProperty("input1");
                JsonElement input2 = root.GetProperty("input2");

                // Procesar input1 y input2
                int[] recommendation = GetRecommendation(input1, input2);

                // Agregar la recomendación a la lista de recomendaciones
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

        // Iterar sobre los apartamentos en input1
        for (int i = 0; i < input1.GetArrayLength(); i++)
        {
            JsonElement apartment = input1[i];

            // Verificar si el apartamento cumple con los requerimientos del cliente
            bool meetsRequirements = true;
            foreach (JsonElement requirement in input2.EnumerateArray())
            {
                if (!apartment.TryGetProperty(requirement.GetString(), out JsonElement value) || !value.GetBoolean())
                {
                    meetsRequirements = false;
                    break;
                }
            }

            if (meetsRequirements)
            {
                matchingIndices.Add(i);
            }
        }

        return matchingIndices.ToArray();
    }
}