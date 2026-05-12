# Validar entrada simulando do-while
while True:
    nota = int(input("Ingrese nota (0-20): "))

    if 0 <= nota <= 20:   # Nota válida: salir del bucle
        break
    else:
        print("Error: nota debe ser entre 0 y 20.")

# Clasificar la nota válida
if 18 <= nota <= 20:   # Excelente
    print("Clasificación: EXCELENTE")

elif 14 <= nota <= 17:   # Bueno
    print("Clasificación: BUENO")

elif 11 <= nota <= 13:   # Regular
    print("Clasificación: REGULAR")

else:
    print("Clasificación: DESAPROBADO")
