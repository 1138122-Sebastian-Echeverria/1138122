import json
def filterMatchTypeBuilder(input1, typeBuilder):
    #Comprobamos que el espacio sea del tipo de 
    #construccion buscado, si es asi lo agregamos a la lista y lo devolvemos
    matching = []
    matchingFinal = []
    for i in range(len(input1)):
        for j in input1[i]['builds'].keys():
            if(j == typeBuilder):
                matching.append(input1[i]['builds'][j])

    for i in matching:
        for j in i:
            matchingFinal.append(j)
    return matchingFinal

def getDangerList(danger):
    #Funcion para devolver los niveles de peligros 
    #admitidos por cada tipo de peligro seleccionado
    outputList = []
    match danger:
        case "Red":
            outputList = ["Red"]
        case "Orange":
            outputList = ["Red","Orange"]
        case "Yellow":
            outputList = ["Red","Orange","Yellow"]
        case "Green":
            outputList = ["Red","Orange","Yellow","Green"]
    return outputList

def filterMinDanger(CurrentList,danger):
    #Se devuelven los lugares cuyo nivel de peligro 
    #admitido se encuentra en la lista de dangerList
    matching = []
    dangerList = []
    dangerList = getDangerList(danger)
    for i in range(len(CurrentList)):
        if any(elem in CurrentList[i]['zoneDangerous'] for elem in dangerList):
            matching.append(CurrentList[i])
    return matching

def filterPetFriendly(CurrentList,wannaPetFriendly):
    #Se devuelven los lugares que coinciden con el valor de busqueda del usuario
    matching = []
    for i in range(len(CurrentList)):
        if(CurrentList[i]['isPetFriendly'] == wannaPetFriendly):
            matching.append(CurrentList[i])
    return matching

def filterComercialActivity(CurrentList, ComercialActivity):
    #Se devuelven los lugares que cuentan con la actividad comercial que desea el usuario
    matching = []
    for i in range(len(CurrentList)):
        if(ComercialActivity in CurrentList[i]['commercialActivities']):
            matching.append(CurrentList[i])
    return matching

def filterPrice(CurrentList, budget):
    #Se devuelven los precios que son menores o iguales al del usuario
    matching = []
    for i in range(len(CurrentList)):
        if(CurrentList[i]['price']<=budget):
            matching.append(CurrentList[i])
    return matching

def prepareToPrint(CurrentList):
    #Se formatea para poder imprimir en pantalla
    outputList = []
    for i in range(len(CurrentList)):
        outputList.append(CurrentList[i]['id'])
    return outputList

#Funcion principal que filtra los lugares
def filterMatchPlaces(input1, input2, output_file='output.json'):
    MatchTypeBuilderList = []
    # Filtramos por tipo de construccion
    MatchTypeBuilderList = filterMatchTypeBuilder(input1, input2['typeBuilder'])

    # Comprobamos qu� tipo de construcci�n se busca y se vuelve a filtrar las cosas espec�ficas de cada lugar
    if input2['typeBuilder'] == "Houses":
        SecondFilterList = filterMinDanger(MatchTypeBuilderList, input2['minDanger'])
    elif input2['typeBuilder'] == "Apartments":
        SecondFilterList = filterPetFriendly(MatchTypeBuilderList, input2['wannaPetFriendly'])
    elif input2['typeBuilder'] == "Premises":
        SecondFilterList = filterComercialActivity(MatchTypeBuilderList, input2['commercialActivity'])

    # Filtramos por precio
    FilterPriceList = filterPrice(SecondFilterList, input2['budget'])

    # Ordenamos los lugares por precio de menor a mayor y los guardamos en el archivo JSON
    FilterPriceList.sort(key=lambda elem: elem['price'])
    with open(output_file, 'w') as outfile:
        json.dump(FilterPriceList, outfile)
