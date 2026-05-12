import random

puntaje_j = 0
puntaje_pc = 0
ronda = 0

while puntaje_j < 3 and puntaje_pc < 3:
    ronda += 1

    print(f"\n--- Ronda {ronda} ---")
    jugador = int(input("1=Piedra, 2=Papel, 3=Tijera: "))

    pc = random.randint(1, 3)

    print(f"La PC eligió: {pc}")

    if jugador < 1 or jugador > 3:
        print("Opción no válida. La ronda no cuenta.")
        ronda -= 1

    elif jugador == pc:
        print("Empate.")

    elif ((jugador == 1 and pc == 3) or
          (jugador == 2 and pc == 1) or
          (jugador == 3 and pc == 2)):

        print("Ganaste esta ronda.")
        puntaje_j += 1

    else:
        print("Gana la PC.")
        puntaje_pc += 1

    print(f"Marcador: Tú {puntaje_j} - PC {puntaje_pc}")

if puntaje_j == 3:
    print("GANASTE EL JUEGO.")
else:
    print("GANÓ LA COMPUTADORA.")
