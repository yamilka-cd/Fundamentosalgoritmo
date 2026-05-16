
clave_correcta = "UPN2026"
max_intentos = 3
intentos = 0
acceso = False

while True:
    intentos = intentos + 1

    clave = input(f"Intento {intentos}/{max_intentos} - Clave: ")

    if clave == clave_correcta:
        acceso = True

    else:
        restantes = max_intentos - intentos

        if restantes > 0:
            print(f"Clave incorrecta. Quedan {restantes} intentos.")

    if acceso or intentos >= max_intentos:
        break

if acceso:
    print("Acceso concedido. Bienvenido.")
else:
    print("Cuenta bloqueada. Contacte al administrador.")
























