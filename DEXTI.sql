
//Recomendações para utilização do SOFTWARE Dexti PDV
//--OBS: se ocorrer algum erro de conecção com o banco favor verificar no programa na pasta Dao
//--string Conexao = "server=localhost;user id=dexti;password=dexti;database=loja;SslMode=none" remover o SslMode=none
//PASSO 1:CRIAR USUÁRIO:dexti COM PASSWORD:dexti
//PASSO 2:CRIAR O SEGUINTE BANCO DE DADOS
create database loja;
//PASSO 3:SELECIONAR O SEGUINTE BANCO DE DADOS
use loja;
//PASSO 4:CRIAR AS TABELAS ABAIXO

create table funcionario(
id_func int (200) primary key auto_increment,
nome varchar(200) not null,
cpf varchar (20) not null,
rg varchar(20) not null,
email varchar(100) not null,
tituloeleitor varchar(20) not  null,
telresidencial varchar(20) not  null,
telcelular varchar (20) not null,
datanascimento datetime not null,
sexo varchar(20)not null ,
estadocivil varchar(20)not null,
funcao varchar (100)not  null,
dataadmissao datetime not null,
datademissao datetime,
ctps varchar (20) not null,
salario decimal  (10,2) not null,
comissao decimal  (10,2),
uf varchar(4) not  null,
cidade varchar(200) not  null,
endereco  varchar(200) not  null,
numero   varchar(50) not  null,
complemento varchar(100) not  null,
bairro varchar(100) not  null,
cep varchar(50) not  null,
obs varchar(200) 
);

create table cliente(
id_client int primary key auto_increment,
nome varchar(200) not null,
cpf varchar(20),
cnpj varchar(20),
rg varchar(20),
email varchar(100),
datanascimento datetime not null,
sexo varchar(20) not null,
telresidencial varchar(20),
telcelular varchar(20),
uf varchar(4),
cidade varchar(200),
endereco  varchar(200),
numero   varchar(50),
complemento varchar(100),
bairro varchar(100),
cep varchar(50),
obs varchar(200),
situacao varchar(50),
tipoCliente varchar(20)
);

create table fornecedor(
id_fornec int primary key auto_increment,
nome_contato varchar(200) not null,
razao_social varchar(200) not null,
nome_fantasia varchar(200) not null,
cnpj varchar (20) not null,
ie varchar(20) not null,
email varchar(100) not null,
website varchar(100),
telempresa varchar(20) not  null,
telcelular varchar(20) not null,
telfax varchar(20),
uf varchar(4) not  null,
cidade varchar(200) not  null,
endereco  varchar(200) not  null,
numero   varchar(50) not  null,
complemento varchar(100) not  null,
bairro varchar(100) not  null,
cep varchar(50) not  null,
obs varchar(200),
situacao varchar(50) not null
);

create table produto(
id_produto int auto_increment primary key,
nome varchar(200) not null,
descricao varchar(200) not null,
marca varchar(100) not null,
tipo varchar(50) not null,
sub_tipo varchar(50) not null,
genero varchar(100) not null,
faixa_etaria varchar(100) not null,
preco_custo decimal(10,2)  not null,
preco_venda decimal(10,2)  not null,
obs varchar(200),
qtd_min int,
qtd_max int,
id_fornecedor int not null,
data_criacao datetime not null,
foreign key(id_fornecedor) references fornecedor(id_fornec)
);

create table estoque(
 id_estoque int auto_increment primary key,
 nf varchar(200) not null,
 valor_nf decimal(10,2) not null,
 tamanho varchar(50) not null,
 qtd int not null,id_produto int,
 data_estoque datetime not null,
foreign key(id_produto) references produto(id_produto)
 );
 
create table login(
user_name varchar(256) not null primary key,
password varchar(256) not null
);

create table venda(
id_venda int auto_increment primary key, 
id_cliente int not null,
codigo int not null,
nome_cliente varchar(256) not null,
id_produto int not null,
nome_produto varchar(256) not null,
genero_produto varchar(256) not null,
tipo_produto varchar(256) not null,
data_venda datetime not null,
qtd int not null,
valor decimal(10,2) not null,
finalizada int
);




