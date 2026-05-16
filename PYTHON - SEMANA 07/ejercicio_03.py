

# Validar entrada simulando do-while
while True:
    nota = int(input("Ingrese nota (0-20): "))

    if nota >= 0 and nota <= 20:  # Nota válida: salir del bucle
        break
    else:
        print("Error: nota debe ser entre 0 y 20.")

# Clasificar la nota válida
if nota >= 18 and nota <= 20:  # Excelente
    print("Clasificación: EXCELENTE")

elif nota >= 14 and nota <= 17:  # Bueno
    print("Clasificación: BUENO")

elif nota >= 11 and nota <= 13:  # Regular
    print("Clasificación: REGULAR")

else:
    print("Clasificación: DESAPROBADO")



    