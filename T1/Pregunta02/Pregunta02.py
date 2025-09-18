

cat=input("Ingrese la categoria:")
prom=float(input("Ingrese el promedio:"))

#Calcular pension

if cat == "A":
    pension = 550
elif cat == "B":
    pension = 500
elif cat == "C":
    pension = 460
else:
    pension = 400

#Calcular promedio

if prom >= 0 and prom <= 13.99:
    descuento = 0
elif prom <= 15.99:
    descuento = 0.10 * pension
elif prom <= 17.99:
    descuento = 0.12 * pension;
else:
    descuento =0.15*pension;

#Calcular nueva pension
nuevaPension = pension - descuento

#Resultados
print("Pension:",pension)
print("Descuento:" ,descuento)
print("Nueva Pension:" , nuevaPension)
