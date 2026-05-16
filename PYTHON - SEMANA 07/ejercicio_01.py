
subtotal = 0

platos = 0

while True:
    print("===== MENU DEL RESTAURANTE =====")
    print("1. lOMO SALTADO - 25 soles")
    print("2. CEVICHE - 30 soles")
    print("3. AJI DE GALLINA - 20 soles")
    print("4. POLLO A LA BRASA - 35 soles")
    print("0. pedir la cuenta")

    opcion = int(input("Seleccione un plato (0 para pedir la cuenta): "))

    if opcion == 1:
        subtotal = subtotal + 25
        platos = platos + 1
    elif opcion == 2:
        subtotal = subtotal + 30
        platos = platos + 1
    elif opcion == 3:
        subtotal = subtotal + 20
        platos = platos + 1
    elif opcion == 4:
        subtotal = subtotal + 35
        platos = platos + 1
    elif opcion == 0:
        break
    else:
        print("Opción inválida. Por favor, seleccione una opción válida.")

igv = subtotal * 0.18
total = subtotal + igv

print("===== CUENTA =====")
print(f"Número de platos pedidos: {platos}")
print(f"Subtotal: {subtotal} soles")
print(f"IGV (18%): {igv} soles")
print(f"Total a pagar: {total} soles")












