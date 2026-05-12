claveCorrecta = "UPN2026"
maxIntentos = 3
intentos = 0
acceso = False

while True:

    intentos = intentos + 1

    clave = input(f"Intento {intentos}/{maxIntentos} - Clave: ")

    if clave == claveCorrecta:
        acceso = True

    else:
        restantes = maxIntentos - intentos

        if restantes > 0:
            print(f"Clave incorrecta. Quedan {restantes} intentos.")

    # Se sale si ya accedió o si agotó los intentos
    if acceso or intentos >= maxIntentos:
        break


if acceso:
    print("Acceso concedido. Bienvenido.")
else:
    print("Cuenta bloqueada. Contacte al administrador.")
