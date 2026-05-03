
import random

secreto = random.randint(1, 51)

intentos = 0
max_intentos = 7
adivino = False

print("Adivina el número secreto entre 1 y 50. Tienes 7 intentos.")

while intentos <= max_intentos and adivino == False:
    intentos = intentos + 1
    intento = int(input(f"Intento {intentos}: "))

    if intento == adivino:
        adivino = True
        print("Felicidades, Has adivinado el numero")
    elif intento < secreto:
        print("El número secreto es mayor.")
    else:
        print("El número secreto es menor.")

if adivino == True:
    print(f"Has adivinado el número en {intentos} intentos")
else:
    print(f"Lo siento, no has adivinado el número. El número secreto era {secreto}")
























