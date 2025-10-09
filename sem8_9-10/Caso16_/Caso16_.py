
import random
suma=0
cantidadPares=0
cantidadImpares=0
sumaPares=0
sumaImpares=0

while True:
    aleatorio=random.randint(1000,9999)
    print(aleatorio)
    suma += aleatorio 

    if aleatorio % 2 == 0: #Suma y cantidad de pares
        cantidadPares+=1
        sumaPares += aleatorio
   
    else:#Suma y cantidad de impares
        cantidadImpares+=1
        sumaImpares += aleatorio

    if aleatorio%2==1 and aleatorio<1800:
        break
   


print("Suma:",suma)
print("Cantidad de Pares:",cantidadPares)
print("Suma de Pares:",sumaPares)
print("Cantidad de Impares:",cantidadImpares)
print("Suma de Impares:",sumaImpares)