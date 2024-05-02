# Main.py
import jsonReader as jreader
import placeProcess as pp
import json

# Leemos la informacion y aplicamos el filtro por cada espacio
data = jreader.readJsonFile()
filtered_data = []
for i in range(len(data)):
    filtered_places = pp.filterMatchPlaces(data[i]['input1'], data[i]['input2'])
    filtered_data.extend(filtered_places)

# Guardamos los datos filtrados en un archivo .json
with open("filtered_data.json", "w") as json_file:
    json.dump(filtered_data, json_file, indent=4)

# Imprimimos los datos formateados en la consola
for place in filtered_data:
    print(place)
