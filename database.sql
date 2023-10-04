DROP DATABASE IF EXISTS AirportSIM;
CREATE DATABASE AirportSIM;
USE AirportSIM;
CREATE TABLE Jugador(
	ID INTEGER PRIMARY KEY NOT NULL,
	Usuario TEXT NOT NULL,
	Password TEXT NOT NULL,
	Mail TEXT NOT NULL,
	Genero CHAR NOT NULL
);

CREATE TABLE Partidas(
	ID INTEGER PRIMARY KEY NOT NULL,
	Hinicio DATETIME NOT NULL,
	Hfin DATETIME,
	TimePlayed FLOAT NOT NULL
);

CREATE TABLE Jug_Part(
	Jugador INTEGER PRIMARY KEY NOT NULL,
	Partida INTEGER NOT NULL,
	Dinero INTEGER NOT NULL,
	FOREIGN KEY (Jugador) REFERENCES ID(Jugador),
	FOREIGN KEY (Partida) REFERENCES ID(Partidas)
);


INSERT INTO Jugador VALUE(1,"PauSerrano","pauserrano","pau.serrano@gmail.com","M");
INSERT INTO Jugador VALUE(2,"CarlosMunoz","carlosmunoz","carlos.munoz@gmail.com","M");
INSERT INTO Jugador VALUE(3,"JanVinas","janvinas","jan.vinas@gmail.com","M");

INSERT INTO Partidas (ID, Hinicio, TimePlayed) VALUES (1, '2023-09-03 17:09:00', 0);
INSERT INTO Partidas (ID, Hinicio, TimePlayed) VALUES (2, '2023-09-15 22:15:00', 0);
INSERT INTO Partidas (ID, Hinicio, TimePlayed) VALUES (3, '2023-09-27 02:15:00', 0);

INSERT INTO Part_Const VALUES (1,1,0);
INSERT INTO Part_Const VALUES (2,2,0);
INSERT INTO Part_Const VALUES (3,3,0);

	
	
	