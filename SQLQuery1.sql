create table Persona(
PersonaId bigint identity(1,1) primary key,
 Cedula varchar(max),
        Nombre    nvarchar(max)   ,  
        Apellido   nvarchar(max) ,    
        FechaNacimiento DateTime2,
        Sexo  nvarchar(max)          )


		create database TareaDominio4
		use TareaDominio4



		select * from Persona

		drop table Persona

		insert into Persona values(1,'karol','monte',GETDATE(),'F')