

dias = int(input("Ingrese número de días: "))

total = 0

excelente = 0
bueno = 0
regular = 0
malo = 0

mayor_venta = float('-inf')
menor_venta = float('inf')

dia_mayor = 0
dia_menor = 0

for i in range(1, dias + 1):
    venta = float(input(f"Día {i} - Venta: "))

    # Acumular total
    total = total + venta

    # Clasificación
    if venta >= 500:
        excelente = excelente + 1
    elif venta >= 200:
        bueno = bueno + 1
    elif venta >= 50:
        regular = regular + 1
    else:
        malo = malo + 1

    if venta > mayor_venta:
        mayor_venta = venta
        dia_mayor = i

    if venta < menor_venta:
        menor_venta = venta
        dia_menor = i

promedio = total / dias

print("\n----- RESULTADOS -----")
print(f"Total de ventas: S/ {total:.2f}")
print(f"Promedio diario: S/ {promedio:.2f}")

print(f"Mayor venta: Día {dia_mayor} con S/ {mayor_venta:.2f}")
print(f"Menor venta: Día {dia_menor} con S/ {menor_venta:.2f}")

print("\nClasificación:")
print(f"Excelente: {excelente}")
print(f"Bueno: {bueno}")
print(f"Regular: {regular}")
print(f"Malo: {malo}")























