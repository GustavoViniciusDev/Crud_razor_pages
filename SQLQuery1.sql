create database RazorPagesCruds

use RazorPagesCruds

create table Produtos(
Id int primary key identity(1,1) not null,
NomeProduto varchar(255) not null,
Descricao varchar(255) not null,
Preco decimal(12,2) not null
)

select * from Produtos