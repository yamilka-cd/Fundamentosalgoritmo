
stock = 500
total_vendido = 0

venta = int(input("Ingrese la cantidad a vender (0 para salir): "))
while venta != 0:
    if venta < 0:
        print("La cantidad a vender no puede ser negativa.")
    elif venta > stock:
        print("No hay suficiente stock para esa cantidad.")
    else:
        stock = stock - venta
        total_vendido = total_vendido + 1
        print(f"Venta realizada. Stock restante: {stock}")

    venta = int(input("Unidades vendidas (0 para salir): "))

print(f"Stock restante: {stock}")
print(f"Total de ventas realizadas: {total_vendido}")
























