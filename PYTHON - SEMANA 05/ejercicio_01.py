
edad = int(input("Ingrese su edad: "))

if edad < 0:
    print("ERROR!!! La edad no puede ser negativa...")

else:
    if edad <= 5:
        print("Viaja gratis, no requiere de medio pasaje...")

    else:
        if edad <= 17:
            print("Viaja con medio pasaje...")
            carnet = input("¿Presenta carnet de estudiante, S/N?:").upper()
            if carnet == "S":
                print("Si accede al medio pasaje escolar")

            else:
                print("No accede al medio pasaje escolar por que no presento carnet")

        else:
            print("No accede al medio pasaje escolar por edad")










