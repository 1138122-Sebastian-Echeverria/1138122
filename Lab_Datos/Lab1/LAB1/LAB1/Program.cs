//"C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\input_challenge.jsonl"
//"C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\Output.json"
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Apartment
{
    public List<string> Businesses { get; set; }

    public Apartment(List<string> businesses)
    {
        Businesses = businesses;
    }
}

class Program
{
    static int SearchApartment(List<Apartment> map, string business, int index)
    {
        int stepsBack = -1;
        int stepsFront = -1;

        for (int i = index; i >= 0; i--)
        {
            if (map[i].Businesses.Contains(business))
            {
                stepsBack = index - i;
                break;
            }
        }

        for (int i = index; i < map.Count; i++)
        {
            if (map[i].Businesses.Contains(business))
            {
                stepsFront = i - index;
                break;
            }
        }

        int resultBack = stepsBack == -1 ? int.MaxValue : stepsBack;
        int resultFront = stepsFront == -1 ? int.MaxValue : stepsFront;

        return resultBack == int.MaxValue && resultFront == int.MaxValue ? -1 : Math.Min(resultBack, resultFront);
    }

    static int Recommendation(List<Apartment> map, List<string> businesses)
    {
        if (businesses.Count == 0)
            return -1; // No businesses required, no apartments needed.

        int minSteps = int.MaxValue;
        int bestIndex = -1;
        int bestMaxSteps = int.MaxValue;

        for (int i = 0; i < map.Count; i++)
        {
            int totalSteps = 0;
            int maxSteps = 0;
            bool anyBusinessFound = false;

            foreach (string business in businesses)
            {
                int steps = SearchApartment(map, business, i);
                if (steps == -1) // Business not found in any apartment.
                {
                    totalSteps = int.MaxValue;
                    break;
                }

                anyBusinessFound = true;
                totalSteps += steps;
                if (steps > maxSteps)
                    maxSteps = steps;
            }

            if (anyBusinessFound && (totalSteps < minSteps || (totalSteps == minSteps && maxSteps < bestMaxSteps)))
            {
                minSteps = totalSteps;
                bestIndex = i;
                bestMaxSteps = maxSteps;
            }
        }

        return bestIndex;
    }

    static void Main(string[] args)
    {
        string filePath = @"C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\input_challenge.jsonl";
        string outputFilePath = @"C:\\Users\\Virtu\\Documents\\Github\\1138122\\Lab_Datos\\Output.json";

        using (StreamReader file = new StreamReader(filePath))
        using (StreamWriter outputFile = new StreamWriter(outputFilePath))
        {
            string line;

            while ((line = file.ReadLine()) != null)
            {
                using (JsonDocument document = JsonDocument.Parse(line))
                {
                    var root = document.RootElement;
                    var input1Array = root.GetProperty("input1").EnumerateArray();
                    var input2Array = root.GetProperty("input2").EnumerateArray();

                    var map = new List<Apartment>();
                    var input2 = new List<string>();

                    foreach (var item in input1Array)
                    {
                        var businesses = new List<string>();
                        foreach (var prop in item.EnumerateObject())
                        {
                            if (prop.Value.GetBoolean())
                                businesses.Add(prop.Name);
                        }
                        map.Add(new Apartment(businesses));
                    }

                    foreach (var item in input2Array)
                    {
                        input2.Add(item.GetString());
                    }

                    int result = Recommendation(map, input2);
                    string outputResult = result == -1 ? "[]" : $"[{result}]";

                    outputFile.WriteLine(outputResult);
                    Console.WriteLine(outputResult);

                    map.Clear();
                    input2.Clear();
                }
            }
        }

        Console.WriteLine("Proceso completado. Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
