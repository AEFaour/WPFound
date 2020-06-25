
-- Créer les tables
/*
create table Activity (
id int identity primary key, 
libelle nvarchar(50)
);

create table Adherent (
numero int identity primary key,
idActivity int foreign key references Activity(id),
nom nvarchar(50),
prenom nvarchar(50),
photo nvarchar(100),
);*/
use MaDatabaseAdherent;
select * from Activity;