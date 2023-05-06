USE MASTER
Create Database UH2
GO

Use UH2
GO

CREATE TABLE usuario (
id int identity(1,1),
email varchar(200) not null unique,
clave varchar(200) not null,
CONSTRAINT PK_ID PRIMARY KEY(ID),
CONSTRAINT UQ_EMAIL UNIQUE (EMAIL)
)
GO

INSERT INTO usuario
 VALUES 
(
'caromope@gmail.com', '12octubre'
), 
(
'stephencespe@gmail.com', '23marzo'
)
GO

SELECT * FROM usuario

ALTER PROCEDURE validarLogin
@email varchar(200) = '',
@clave varchar(200) = ''

	as
		begin
		
		SELECT email, clave FROM usuario where email = @email AND
			clave = @clave
		end

EXEC validarLogin 'caromope@gmail.com', '12octubre'