#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int main(int argc, char *argv[]) {
	
	char peticion [100];
	char resultado [100];
	
	strcpy(peticion,"Pau/20/Albert/22/Anna/56/Jesus/58");
	
	char nombre[20];
	int edad;
	char *p=strtok(peticion,"/");
	
	while(p!=NULL){
		strcpy(nombre,p);
		p=strtok(NULL,"/");
		edad=atoi(p);
		p=strtok(NULL,"/");
		if(edad>18)
			sprintf(resultado,"%s%s*%d-",resultado,nombre,edad);
	}
	resultado[strlen(resultado)-1] = '\0';
	printf("Respuesta: %s",resultado);
}

