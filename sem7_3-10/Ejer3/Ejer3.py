

while True:                                                                                     
    num=int(input("Ingrese un número:"))
    suma=0


    for i in range(1,num+1):
        suma+=1
        print(i,end=" ")
    print("\n\nSuma:",suma)

    opción=input("\n¿Desea continuar? (presione N para salir):")

    if (opción=="N"):break