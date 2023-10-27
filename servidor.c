#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>
#include <pthread.h>


int contador;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente(void *socket)
{
	int sock_conn;
	int *s;
	s=(int *) socket;
	sock_conn=*s;
	
	char buff[512];
	char buff2[512];
	
	
	int terminar =0;
	while (terminar == 0){
		// Ahora recibimos su nombre, que dejamos en buff
		int ret=read(sock_conn,buff, sizeof(buff));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		buff[ret]='\0';
		
		//Escribimos el nombre en la consola
		
		printf ("Se ha conectado: %s\n",buff);
		
		
		char *p = strtok( buff, "/");
		int codigo =  atoi (p);
		char nombre[20];
		
		if(codigo!=0 && codigo!=6){
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		
		if(codigo==0)
		   terminar =1;
		else if (codigo ==1) //piden la longitd del nombre
			sprintf (buff2,"%d\0",strlen (nombre));
		else if (codigo ==2)
			// quieren saber si el nombre es bonito
			if((nombre[0]=='M') || (nombre[0]=='S'))
			strcpy (buff2,"SI\0");
			else
				strcpy (buff2,"NO\0");
			else if (codigo ==3) {//decir si es alto
				p = strtok( NULL, "/");
				float altura =  atof (p);
				if (altura > 1.70)
					sprintf(buff2,"%s: Eres alto\0",nombre);
				else 
					sprintf(buff2,"%s: No eres alto\0",nombre);
			}
			else if(codigo==4){
				int i =0;
				int izq=0;
				int para=1;
				int der=strlen(nombre)-1;
				
				while(i<strlen(nombre)/2){
					if(tolower(nombre[izq])!=tolower(nombre[der])){
						para=0;
						break;
					}
					izq+=1;
					der-=1;
					i+=1;
				}
				if(para==1)
					  sprintf(buff2,"%s: Es Palindromo\0",nombre);
				else
					sprintf(buff2,"%s: No es Palindromo\0",nombre);
			}
			else if (codigo == 5){
				int i=0;
				while (i<strlen(nombre)){
					nombre[i]=toupper(nombre[i]);
					i++;
				}
				sprintf(buff2,"%s",nombre);
			}
			else if (codigo == 6){
				sprintf(buff2,"%d",contador);
			}
			
			if (codigo !=0){
				printf ("%s\n", buff2);
				// Y lo enviamos
				write (sock_conn,buff2, strlen(buff2));
			}
			if(codigo==1 ||codigo==2 ||codigo==3 ||codigo==4 ||codigo==5){
				pthread_mutex_lock(&mutex);
				contador++;
				pthread_mutex_unlock(&mutex);
			}
			
	}
	// Se acabo el servicio para este cliente
	close(sock_conn);
}



int main(int argc, char *argv[])
{
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9040);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	
	contador=0;
	int i=0;
	int sockets[100];
	pthread_t thread;
	// Atenderemos solo 7 peticione
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		
		//sock_conn es el socket que usaremos para este cliente
		sockets[i] = sock_conn;
		//Bucle atencion al cliente
		
		pthread_create (&thread, NULL, AtenderCliente, &sockets[i]);
		i=i+1;
	}
}
