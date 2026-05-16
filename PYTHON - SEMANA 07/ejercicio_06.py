
votos_ana = 0
votos_carlos = 0
votos_lucia = 0
votos_nulos = 0

while True:
    print("\n=== SISTEMA DE VOTACIÓN ===")
    print("1. Ana Torres")
    print("2. Carlos Mendoza")
    print("3. Lucía Paredes")
    print("0. Cerrar votación")

    voto = int(input("Ingrese voto: "))

    if voto == 1:
        votos_ana = votos_ana + 1

    elif voto == 2:
        votos_carlos = votos_carlos + 1

    elif voto == 3:
        votos_lucia = votos_lucia + 1

    elif voto == 0:
        break

    else:
        votos_nulos = votos_nulos + 1

total_votantes = votos_ana + votos_carlos + votos_lucia + votos_nulos

print("\n=== RESULTADOS ===")
print(f"Ana Torres: {votos_ana}")
print(f"Carlos Mendoza: {votos_carlos}")
print(f"Lucía Paredes: {votos_lucia}")
print(f"Votos nulos: {votos_nulos}")
print(f"Total de votantes: {total_votantes}")

if votos_ana > votos_carlos and votos_ana > votos_lucia:
    print("Ganadora: Ana Torres")

elif votos_carlos > votos_ana and votos_carlos > votos_lucia:
    print("Ganador: Carlos Mendoza")

elif votos_lucia > votos_ana and votos_lucia > votos_carlos:
    print("Ganadora: Lucía Paredes")

else:
    print("Resultado: EMPATE")









