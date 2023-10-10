#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[]) {
	char peticion [100];
	
	strcpy(peticion,"3/Pau/20/1.85");
	
	int codigo;
	char nombre[20];
	int edad;
	float altura;
	
	char *p = strtok(peticion,"/");
	
	codigo = atoi(p);
	p=strtok(NULL, "/");
	strcpy(nombre, p);
	p=strtok(NULL, "/");
	edad=atoi(p);
	p=strtok(NULL, "/");
	altura=atof(p);
	
	printf("Codigo: %d, Nombre: %s, Edad: %d, Altura: %f\n",codigo,nombre,edad,altura);
	
	char respuesta [100];
	if (edad>18)
		sprintf(respuesta,"%s es major d'edat perque te %d anys",nombre,edad);
	else
		sprintf(respuesta,"%s no es major d'edat ",nombre,edad);
	
	printf("Resposta: %s", respuesta);
}

