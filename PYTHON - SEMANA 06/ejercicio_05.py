
deposito_inicial = float(input("Ingrese el depósito inicial: S/. "))
meta = float(input("Ingrese la meta de ahorro: S/. "))

ahorro = deposito_inicial
tasa_interes = 0.015
meses = 0

while ahorro < meta:
    ahorro = ahorro + (ahorro * tasa_interes)
    meses = meses + 1

print("===RESULTADOS===")
print(f"Depósito inicial: S/. {deposito_inicial:.2f}")
print(f"Meta: S/. {meta:.2f}")
print(f"Monto final: S/. {ahorro:.2f}")
print(f"Alcanza la meta en {meses} meses")






















