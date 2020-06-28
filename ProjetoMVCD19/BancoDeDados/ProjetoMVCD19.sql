create database ProjetoMVCD19;
Use ProjetoMVCD19;

create table tbl_cliente(
id_cliente int(11) NOT NULL,
nome_cliente varchar(50) NOT NULL,
sobrenome_cliente varchar(50) NOT NULL,
cpf_cliente varchar(11) NOT NULL,
email_cliente varchar(50) NOT NULL,
senha_cliente varchar(50) NOT NULL,
nome_mae varchar(50) NOT NULL,
tp_usuario int(1) NOT NULL,
beneficio boolean NOT NULL,
primary key (id_cliente)
);

insert into tbl_cliente (id_cliente, nome_cliente, sobrenome_cliente, cpf_cliente, email_cliente, senha_cliente, nome_mae, tp_usuario, beneficio)
       values("21800812", "pedro", "augustos", "30150200", "pedro@pedro", "01121973p", "marta", "2", false);
       
       insert into tbl_cliente (id_cliente, nome_cliente, sobrenome_cliente, cpf_cliente, email_cliente, senha_cliente, nome_mae, tp_usuario, beneficio)
       values("31800813", "joao", "marcos", "30150100", "joao@joao", "01121973j", "marta", "1", true);

select * from tbl_cliente where email_cliente = 'pedro@pedro' and nome_mae = 'marta' and cpf_cliente = '30150200';


drop table tbl_cliente;
select * from tbl_cliente;