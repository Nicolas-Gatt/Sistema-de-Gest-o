create database GestaoEstoque;
use GestaoEstoque;

create table Produtos(
	ID int primary key,
    Nome nvarchar(100),
    CodigoPd nvarchar(25),
    Quantidade int,
    Preco decimal(10,2),
    Fornecedor nvarchar(100)
);

create table Clientes(
	ID int primary key,
	Nome nvarchar(100),
    Documento nvarchar(20),
    Telefone nvarchar(15),
    Endereco nvarchar(200)
);

create table Vendas(
	ID int primary key,
    ClienteID int,
    DataVenda datetime,
    Total decimal(10,2),
    foreign key(ClienteID) references Clientes(ID)
);

create table ItensVenda(
	ID int primary key,
    VendaID int,
    ProdutoID int,
    Quantidade int,
    PrecoUnitario decimal(10,2),
	foreign key(ProdutoID) references Produtos(ID),
    Foreign key(VendaID) references Vendas(ID)
);


