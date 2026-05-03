
saldo = 1000
retiros = 0

monto = float(input("Ingrese el monto a retirar: "))

while monto!= 0:
    if monto < 0:
        print("Monto invalido, Intente nuevamente.")

    if monto > saldo:
        print("Saldo insuficiente, Intente nuevamente.")
    else:
        saldo = saldo - monto
        retiros = retiros + 1
        print(f"Retiro exitoso. Saldo actual: S/. {saldo:.2f}")
    
    monto = float(input("Ingrese el monto a retirar (0 para finalizar): "))

print("---RESUMEN---")
print(f"Retiros realizados: {retiros}")
print(f"Saldo final: S/. {saldo:.2f}")




































