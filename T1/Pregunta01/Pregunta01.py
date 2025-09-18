
ang = float(input("angulo"));

if ang >= 0 and ang <= 360:

    if ang == 0:
        clasi = "Nulo"
    elif ang < 90:
        clasi = "Agudo"
    elif ang == 90:
        clasi = "Agudo"
    elif ang == 180:
        clasi = "Llano"
    elif ang < 360:
        clasi = "Concavo"
    else:
        clasi = "Completo";

    print("El angulo es:", clasi);

else:
    print("Angulo incorrecto!!!")





