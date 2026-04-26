
precio_unitario = 5

print("Cantidad | Subtotal | descuento | total")
print("-------- | -------- | --------- | -----")

for cantidad in range(1, 20 + 1):
    subtotal = cantidad * precio_unitario
    
    if cantidad <= 5:
        descuento = 0
    elif cantidad <= 12:
        descuento = subtotal * 0.10
    else:
        descuento = subtotal * 0.20
    
    total = subtotal - ( 1 - descuento)

    print(f"{cantidad:8} | ${subtotal:8.2f} | ${descuento:9.2f} | ${total:5.2f}")










