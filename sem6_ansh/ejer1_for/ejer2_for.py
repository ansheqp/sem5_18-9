
cant= int(input("Ingrese la cantidad de numeros:"))
p=im = c= 0

print()

for i in range (1,cant+1):
    num= int(input(f"Ingrese numero {i}:"))

    if num ==0:
        c=+1
    elif num %2==0:
        p+=1
    else:
        im+=1

print("\nCantidad de pares:",p)
print("Cantidad de impares",im)
print("Cantidad de ceros",c)
