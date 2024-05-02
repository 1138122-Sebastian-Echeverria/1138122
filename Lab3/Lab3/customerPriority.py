import heapSort as heap
def orderCustomerPriority(customerList):
    #Funcion que ordena a los clientes segun su prioridad
    heap.heapSort(customerList)
    return customerList

def getCustomer(priorityList,rejections):
    #Se obtiene al cliente ganador segun la prioridad y el numero de rechazos
    return priorityList[rejections]


