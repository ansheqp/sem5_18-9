
def SumaNumeros():
    a = 5
    b = 10
    suma=a+b
    return suma

def RestaNumeros(a,b):
    return a-b

def MultiNumeros():
    a = 5
    b = 10
    multi=a*b
    return multi

def DiviNumeros():
    a = 5
    b = 10
    divi=a//b
    return divi

#Llamamos o invocamos a la función
sumaNum=SumaNumeros()
print("Suma:",sumaNum)

restaNum=RestaNumeros(5,10)
print("Resta:",restaNum)

multiNum=MultiNumeros()
print("Multiplicación:",multiNum)

diviNum=DiviNumeros()
print("División:",diviNum)
