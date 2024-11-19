CREATE DATABASE DB_REGISTROS_CUN;
USE DB_REGISTROS_CUN;

CREATE TABLE Tipos_documentos(
	id_tipo_documento INT PRIMARY KEY,
	tipo_documento VARCHAR (25)
);

CREATE TABLE Roles(
	id_rol INT PRIMARY KEY,
	rol VARCHAR (15)
);

CREATE TABLE Tipo_material(
	id_tipo_material INT IDENTITY(1,1) PRIMARY KEY,
	tipo_material VARCHAR (20)
);

CREATE TABLE Personas(
		id_persona INT IDENTITY(1,1) PRIMARY KEY,
		nombres VARCHAR (30),
		apellidos VARCHAR (30),
		id_tipo_documento INT,
		numero_documento VARCHAR (25),
		id_rol INT,
		FOREIGN KEY (id_tipo_documento) REFERENCES Tipos_documentos (id_tipo_documento),
		FOREIGN KEY (id_rol) REFERENCES Roles (id_rol)
);

CREATE TABLE Materiales(
    id_material INT IDENTITY(1,1) PRIMARY KEY,
    id_persona INT,
    id_tipo_material INT,
    serial VARCHAR (30),
    color VARCHAR (15),
    marca VARCHAR (20),
    observaciones VARCHAR (40),
    estado BIT, -- false = Fuera true = Dentro
    FOREIGN KEY (id_persona) REFERENCES Personas(id_persona),
    FOREIGN KEY (id_tipo_material) REFERENCES Tipo_material(id_tipo_material)
);

CREATE TABLE Registros(
	id_registro INT IDENTITY(1,1) PRIMARY KEY,
	id_material INT,
	id_persona INT,
	estado BIT,
	fecha DATE,
	hora TIME,
	FOREIGN KEY (id_persona) REFERENCES Personas (id_persona),
	FOREIGN KEY (id_material) REFERENCES Materiales (id_material)
);

--Ingreso de tipos de documentos
INSERT INTO Tipos_documentos (id_tipo_documento, tipo_documento)
    VALUES 
	(1, 'Registro civil'),
    (2, 'Cédula de ciudadanía'),
    (3, 'Tarjeta de identidad'),
    (4, 'Cédula de extranjería'),
    (5, 'Pasaporte'),
    (6, 'NIT');

-- Ingreso de roles
INSERT INTO Roles (id_rol, rol)
	VALUES
	(1, 'Estudiante'),
	(2, 'Docente'),
	(3, 'Funcionario'),
	(4, 'Visitante');

--Ingreso de tipo de material
INSERT INTO Tipo_material (tipo_material)
	VALUES
	('Computador portátil'),
	('Computador Torre'),
	('Equipo de computo'),
	('Otro');

