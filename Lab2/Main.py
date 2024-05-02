import jsonReader as jreader
import placeProcess as pp

#Leemos la informacion y aplicamos el filtro por cada espacio
data = jreader.readJsonFile()
for i in range(len(data)):
    pp.filterMatchPlaces(data[i]['input1'],data[i]['input2'])

