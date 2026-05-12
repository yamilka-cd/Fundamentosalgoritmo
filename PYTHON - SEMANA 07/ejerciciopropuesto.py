votos_ana = 0
votos_carlos = 0
votos_lucia = 0
nulos = 0

while True:

    print("\n--- ELECCIONES ---")
    print("1. Ana Torres")
    print("2. Carlos Mendoza")
    print("3. Lucía Paredes")
    print("0. Cerrar votación")

    voto = int(input("Ingrese su voto: "))

    if voto == 1:
        votos_ana += 1
    elif voto == 2:
        votos_carlos += 1
    elif voto == 3:
        votos_lucia += 1
    elif voto == 0:
        break
    else:
        nulos += 1
        print("Voto nulo")

total = votos_ana + votos_carlos + votos_lucia + nulos

print("\n--- RESULTADOS ---")
print(f"Votos Ana Torres: {votos_ana}")
print(f"Votos Carlos Mendoza: {votos_carlos}")
print(f"Votos Lucía Paredes: {votos_lucia}")
print(f"Votos nulos: {nulos}")
print(f"Total de votantes: {total}")

if votos_ana > votos_carlos and votos_ana > votos_lucia:
    print("Ganador: Ana Torres")
elif votos_carlos > votos_ana and votos_carlos > votos_lucia:
    print("Ganador: Carlos Mendoza")
elif votos_lucia > votos_ana and votos_lucia > votos_carlos:
    print("Ganadora: Lucía Paredes")
else:
    print("Resultado: EMPATE")