
create database cruddao;
use cruddao;
create table Item
(
Id_Item int auto_increment,
Nome_Item varchar(50) not null,
Descricao_Item varchar(200) not null,
Observacao_Item varchar(200)not null,
primary key (Id_Item)
);

insert into Item values(default,"Cardarço desamarrado","Um tênis está desamarrado", "É urgente a correção, pois pode machucar"); 
insert into Item values(default,"Amarrar Cadarço","deve-se abaixar e dar um no ", "fazer isso sentado para segurança"); 

create table Indicador
(
Id_Indicador int auto_increment,
Nome_Indicador varchar(50) not null,
Descricao_Indicador varchar(200) not null,
Observacao_Indicador varchar(200) not null,
primary key (Id_Indicador)
);

insert into Indicador values(default,"Problema","Apresenta os problemas que podem surgir em um software", "");
insert into Indicador values(default,"Solução","Apresenta solução de um problema", "");

create table Item_Indicador
(
Id_ItemIndicador int auto_increment primary key,
Nome_ItemIndicador varchar(50) not null,
Codigo_Item int not null,
Codigo_Indicador int not null,
Descricao_ItemIndicador varchar(200) not null,
Observacao_ItemIndicador varchar(200) not null,
foreign key (Codigo_Item) references Item (Id_Item) on delete cascade,
foreign key (Codigo_Indicador) references Indicador (Id_Indicador) on delete cascade
);
insert into Item_Indicador values(default,"",1,1,"Problema de cadarço desamarrado","URGENTE");
insert into Item_Indicador values(default,"",2,2,"Solução para cadarço desamarrado","");

DELIMITER $$
CREATE PROCEDURE atualizar_item_indicador(in id int, nome varchar(50), cod_item int,
cod_indica int, descricao varchar(200), observacao varchar(200))
begin 
	update Item_Indicador set Nome_ItemIndicador = nome, Codigo_Item = cod_item,
    Codigo_Indicador = cod_indica, Descricao_ItemIndicador = descricao, Observacao_ItemIndicador = observacao
    where(Id_ItemIndicador = id);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE inserir_item_indicador(in Nome_ItemIndicador varchar(50), Codigo_Item int,
Codigo_Indicador int, Descricao_ItemIndicador varchar(200), Observacao_ItemIndicador varchar(200))
begin 
	insert into Item_Indicador values(null,Nome_ItemIndicador,Codigo_Item,Codigo_Indicador,
    Descricao_ItemIndicador,Observacao_ItemIndicador);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE delete_item_indicador(in id int)
begin 
	delete from Item_Indicador where(Id_ItemIndicador = id);
end $$
DELIMITER ;


create table Relacao_Item_Indicador
(
Id_Relacao_Item_Indicador int AUTO_INCREMENT,
Nome_Relacao_ItemIndicador varchar(50) not null,
Codigo1_ItemIndicador int not null,
Codigo2_ItemIndicador int not null,
Descricao_Relacao_ItemIndicador varchar(200) not null,
Observacao_Relacao_ItemIndicador varchar(200) not null,
primary key (Id_Relacao_Item_Indicador),
foreign key (Codigo1_ItemIndicador) references Item_Indicador (Id_ItemIndicador) on delete cascade,
foreign key (Codigo2_ItemIndicador) references Item_Indicador (Id_ItemIndicador) on delete cascade
);

insert into Relacao_Item_Indicador values(null,"Solução do problema cadarço desamarrado", 1,2,"Descreve como realizar a correção do problema","");
DELIMITER $$
CREATE PROCEDURE atualizar_Relacao_Item_Indicador(in id int, nome varchar(50),cod1 int, cod2 int, descricao varchar(200), observacao varchar(200))
begin 
	update Relacao_Item_Indicador set Nome_Relacao_ItemIndicador = nome, Codigo1_ItemIndicador = cod1,
    Codigo2_ItemIndicador = cod2, Descricao_Relacao_ItemIndicador = descricao, Observacao_Relacao_ItemIndicador = observacao
    where(Id_Relacao_Item_Indicador = id);
end $$
DELIMITER ;

DELIMITER $$

CREATE PROCEDURE inserir_Relacao_Item_Indicador(nome varchar(50),cod1 int, cod2 int, descricao varchar(200), observacao varchar(200))
begin 
	insert into Relacao_Item_Indicador value(default,nome,cod1,cod2,
    descricao,observacao);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE delete_relacao_item_indicador(in id int)
begin 
	delete from Relacao_Item_Indicador where(Id_Relacao_Item_Indicador = id);
end $$
DELIMITER ;


create table Usuario
(
Id_Usuario int auto_increment,
Nome_Usuario varchar(100) not null,
Sobrenome_Usuario varchar(100) not null,
Email_Usuario varchar(100) not null,
Senha_Usuario varchar(20) not null,
primary key (Id_Usuario)
);

insert into Usuario values(null,"matheus","Lucena", "matheus.giovanni.lu@gmail.com",123456);
DELIMITER $$
CREATE PROCEDURE atualizar_usuario(in id int, nome varchar(100), sobrenome varchar(100), email varchar(100), senha varchar(20))
begin 
	update Usuario set Nome_Usuario = nome, Sobrenome_Usuario = sobrenome, Email_Usuario = email, Senha_Usuario = senha  where(Id_Usuario = id);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE inserir_usuario(in nome varchar(100),
 sobrenome varchar(100),email varchar(100), senha varchar(100))
begin 
	insert into usuario values(null,nome,sobrenome,email,senha);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE delete_usuario(in id int)
begin 
	delete from usuario where(Id_Usuario = id);
end $$
DELIMITER ;

create table Log
(
id_log int primary key auto_increment,
Id_User int not null,
Data_Alteracao datetime not null,
Descricao_Registro varchar(200) not null,
foreign key(Id_User) references Usuario (Id_Usuario)
);


DELIMITER $$
CREATE PROCEDURE inserir_log(in Id_User int, Data_Alteracao datetime, Descricao_Registro varchar(200))
begin 
	insert into Log values(default,Id_User,Data_Alteracao,Descricao_Registro);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE inserir_indicador(in nome varchar(50), descricao varchar(200), observacao varchar(200))
begin 
	insert into Indicador values(default,nome,descricao,observacao);
end $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE inserir_item(in nome varchar(50), descricao varchar(200), observacao varchar(200))
begin 
	insert into Item values(default,nome,descricao,observacao);
end $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE atualizar_indicador(in id int, nome varchar(50), descricao varchar(200), observacao varchar(200))
begin 
	update Indicador set Nome_indicador = nome, Descricao_Indicador = descricao, Observacao_Indicador = observacao where(Id_Indicador = id);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE atualizar_item(in id int, nome varchar(50), descricao varchar(200), observacao varchar(200))
begin 
	update Item set Nome_Item = nome, Descricao_Item = descricao, Observacao_Item = observacao where(Id_Item = id);
end $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE delete_item(in id int)
begin 
	delete from Item where(Id_Item = id);
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE delete_indicador(in id int)
begin 
	delete from Indicador where(Id_Indicador = id);
end $$
DELIMITER ;
