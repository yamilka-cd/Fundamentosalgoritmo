
kwh = int(input("Ingrese la cantidad de kWh consumidos: "))
monto = 0

if kwh < 0:
    print("ERROR!!! el consumo debe ser positivo...")
elif kwh <= 100:
    monto = kwh * 0.5
elif kwh <= 300:
    monto = 100 * 0.5 + (kwh - 100) * 0.75
else:
    monto = 100 * 0.5 + 200 * 0.75 + (kwh - 300) * 1.20

print(f"El monto a pagar por el consumo de {kwh} kWh es: ${monto:.2f}")    


















