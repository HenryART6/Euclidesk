Algoritmo numeros_perfectos
	Definir num,suma,i,res,num2 Como Entero
	Leer num
	Leer num2
	Mientras num <= num2 Hacer
		Para i=1 Hasta num-1 Hacer
			res = num MOD i
			Si res = 0 Entonces
				suma = suma+i
			FinSi
		FinPara
		Si suma = num Entonces
			Escribir num
		FinSi
		num = num + 1
		suma = 0
	FinMientras
FinAlgoritmo
