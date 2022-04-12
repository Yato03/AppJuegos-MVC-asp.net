CREATE TABLE Categorias(
CategoriaId int NOT NULL IDENTITY(1,1),
Name varchar(200) NOT NULL,
PRIMARY KEY(CategoriaId));

CREATE TABLE Juegos(
GameId int NOT NULL IDENTITY(1,1),
Name varchar(200) NOT NULL,
CategoriaId int NOT NULL,
PRIMARY KEY(GameId),
FOREIGN KEY(CategoriaId) REFERENCES Categorias(CategoriaId));



