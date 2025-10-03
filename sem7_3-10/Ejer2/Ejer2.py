
import random

secreto=random.randint(1,20)
intentos= 3


print("***********************************************************************************")         
print("*                                                                                 *") 
print("*                    BIENVENIDOS  AL  JUEGO  ADIVINADOR                           *")
print("*                                                                                 *")
print("*  1. Usted deberá adivinar el numero entre 1 y 20                                *")
print("*  2. Usted tiene tres intentos                                                   *")
print("*  3. Por cada falla se ortorgará una pista                                       *")
print("*                                                                                 *")
print("***********************************************************************************")


while (intentos >0):
    num=int(input(f"\nIngrese un número (Intento {intentos}):"))

    if num==secreto:
        print("\nFelicidades.Adivinaste!") 
        break
    else:
        intentos-=1

        if num<secreto: print("El número es mayor.")
        else: print("El número es menor.")
else: print:(f"\nNo lograste adivinar el número, el cual es {secreto}")