/*drop table ejemplo
create TABLE ejemplo
(  
 id uniqueidentifier NOT NULL primary key,
 nombre varchar(50)
);  

insert into ejemplo(id,nombre)values(NEWID(),'jordaly');
insert into ejemplo(id,nombre)values(NEWID(),'jeremy');
insert into ejemplo(id,nombre)values(NEWID(),'marines');
*/
/*create database SGF*/
select * from ejemplo
create table casa{}
create table direccion
(
idDireccion UNIQUEIDENTIFIER not null primary key,
idcasa UNIQUEIDENTIFIER not null,
constraint FK_casa_direccion_idCasa FOREIGN KEY (idCasa)
        REFERENCES casa (idCasa) 
		ON DELETE CASCADE 
		ON UPDATE CASCADE
);

create table clientes
(
	idClientes uniqueidentifier NOT NULL primary key,
	nombre varchar(100) not null,
	numero varchar(20),
	correo varchar(100),
	idDireccion UNIQUEIDENTIFIER not null,
	
	constraint FK_direccion_clientes_idDireccion FOREIGN KEY (idDireccion)
        REFERENCES direccion (idDireccion) 
		ON DELETE CASCADE 
		ON UPDATE CASCADE
	

);


