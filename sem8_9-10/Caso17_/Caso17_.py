
import random
aleatorio=0
Cant1=0
Cant2=0
Cant3=0

while True:
    aleatorio=random.randint(5,501)
    print(aleatorio)
    
    if aleatorio < 10:
        Cant1 +=1 
    
    elif aleatorio < 100:
        Cant2+=1
    
    else:
        Cant3 +=1

    if aleatorio%3==1 and aleatorio >= 10 and aleatorio <= 99:
        break

print("Cantidad de 1 dígito:" , Cant1);
print("Cantidad de 2 dígito:" ,Cant2);
print("Cantidad de 3 dígito:" , Cant3);