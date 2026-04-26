
numero_empleados = int(input("Ingrese la cantidad de empleados: "))

total_planilla = 0
horas_normales = 0
horas_extra = 0

for i in range(1, numero_empleados + 1):
    print("\nEmpleado", i)
    nombre = input("Nombre: ")
    horas = float(input("Horas trabajadas: "))
    print("----- BOLETA DEL EMPLEADO -----")
    if horas <= 160:
        sueldo_bruto = horas * 12.5
        horas_extra = 0
    else:
        horas_extras = horas - 160
        sueldo_bruto = 160 * 12.50 + horas_extras * 25
    
    descuento = sueldo_bruto * 0.05
    sueldo_neto = sueldo_bruto - descuento
    total_planilla = total_planilla + sueldo_neto
    
    print(f"Nombre: {nombre}")
    print(f"Horas normales: {horas}")
    print(f"Horas extras: {horas_extra}")
    print(f"Sueldo bruto: S/ {round(sueldo_bruto, 2)}")
    print(f"Descuento: S/ {round(descuento, 2)}")
    print(f"Sueldo neto: S/ {round(sueldo_neto, 2)}")
    print("----- BOLETA DEL EMPLEADO -----")
print("\nTOTAL DE LA PLANILLA: S/", round(total_planilla, 2))
































