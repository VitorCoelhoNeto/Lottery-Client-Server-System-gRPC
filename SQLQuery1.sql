create table Utilizador(
	Id int identity primary key,
    Nome nvarchar(200) not null
    )




create table Aposta(
	Id int identity primary key,
    Chave nvarchar(200) not null,
    DataRegisto nvarchar(200) not null,
    Arquivada BIT,
    UtilizadorId int references Utilizador(Id),
)



