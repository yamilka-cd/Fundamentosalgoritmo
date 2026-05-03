
suma = 0
contador = 0
mayor = 0

menor = float("inf")
nota = float(input("Ingrese una nota (-1 para terminar): "))

while nota != -1:
    if nota < 0 or nota > 20:
        print("Nota invalida, ingrese una nota de 0 a 20.")
    else:
        suma = suma + nota
        contador = contador + 1

        if nota > mayor:
            mayor = nota

        if nota < menor:
            menor = nota
    nota = float(input("Ingrese una nota (-1 para terminar): "))

if contador > 0:
    promedio = suma / contador
    print(f"Promedio: {promedio:.2f}")
    print(f"Nota mayor: {mayor:.2f}")
    print(f"Nota menor: {menor:.2f}")
    print(f"Cantidad de notas: {contador}")

else:
    print("No se ingresaron notas válidas.")



















