insert usuarios (id, nome, email, senha, nivel) 
values (1001,'Wellington Vieira dos Santos', 'wellington.vsantos@gmail.com', 'seanc@itq', 'M');

-- alterando o número de bytes do campo senha para usar MD5
alter table usuarios modify column senha varchar(32) not null;

-- criando procedure para inserir Usuário
delimiter $$
create procedure sp_usuario_insert(
-- parâmetros da procedure
spnome varchar(60), spemail varchar(60), spsenha varchar(32))
begin
	insert into usuarios 
	values (0,spnome, spemail, md5(spsenha), 'A');
    select * from usuarios where id = last_insert_id();
end $$

call sp_usuario_insert( 'Zé das Couves','ze@gmail.com', '1234');

-- criando procedure venda terminal, com apenas o cpf(19155566863) do cliente e o id do produto(7894541258876)
delimiter $$
-- drop procedure sp_venda_terminal;
create procedure sp_venda_terminal(spusuario_id int,spcpf char(11), spcodbar varchar(60))
begin
	insert pedidos values(0,spusuario_id,(select id from clientes where cpf = spcpf), default, 'A', 0);
		insert itempedido values (
			0,
			last_insert_id(),
			(select id from produtos where cod_barras = spcodbar),
            (select valor_unit from produtos where cod_barras = spcodbar),
            1,
            0);
	select * from itempedido where id = last_insert_id();
end
$$ 
call sp_venda_terminal(1001,'19155566863','7894541258876');

-- Procedures Cliente
	--  insert 
    delimiter $$
    create procedure sp_cliente_insert(
    spnome varchar(100), 
    spcpf char(11),
    sptelefone char(14),
    spemail varchar(60),
    spdata_nasc datetime
    ) 
    begin
		insert into clientes values (0,spnome, spcpf, sptelefone, spemail, spdata_nasc, default, '1');
        select @@identity as id;
    end
    $$
 
     delimiter $$ 
     -- update 
    create procedure sp_cliente_altera(
    spid int, 
    spnome varchar(100), 
    sptelefone char(14),
    spdata_nasc datetime
    ) 
    begin
		update clientes 
        set nome = spnome, cpf = spcpf, telefone = sptelefone, data_nasc = spdata_nasc
        where id = spid;
    end
    $$

    -- delete (inatiando)
    create procedure sp_cliente_delete(spid int) 
    begin
		update clientes 
        set ativo = '0'
        where id = spid;
    end
    $$    
    
-- Procedures endereço
	--  insert 
    delimiter $$
    create procedure sp_endereco_insert(
    spcliente_id int, 
    spcep char(8), 
    splogradouro varchar(100),
    spnumero varchar(40),
    spcomplemento varchar(60),
    spbairro varchar(60),
    spcidade varchar(60),
    spuf char(2),
    sptipo_endereco char(3)
    ) 
    begin
		insert into enderecos 
        values (0,spcliente_id, spcep, splogradouro, spnumero, spcomplemento, spbairro, spcidade, spuf, sptipo_endereco);
        select @@identity as id;
    end
    $$
    
-- call sp_endereco_insert(22,'74494322','Rua dos Gonça Alves de Oliveira lima','301','','Residencial São Bernardo','São Paulo','SP','RES')
-- drop procedure sp_endereco_insert;

 -- 3 ( insere, altera, deleta)
 -- alterar clientes (sp_enderecos_update)
 delimiter $$
 create procedure sp_endereco_update(
spid int,
spcep char(8), 
splogradouro varchar(100),
spnumero varchar(40),
spcomplemento varchar(60),
spbairro varchar(60),
spcidade varchar(60),
spuf char(2),
sptipo_endereco char(3))
 begin
	 update enderecos set cep = spcep, 
     logradouro = splogradouro, 
     numero = spnumero, 
	 complemento = spcomplemento, 
	 bairro = spbairro, 
	 cidade = spcidade, 
	 uf = spuf,
	 tipo_endereco = sptipo_endereco 
	 where id = spid;
 end
 $$
 
-- call sp_endereco_update (21,'74494322','Rua Manoel Dos Reis','252','','Residencial São Bernardo','São Paulo','SP','RES')
-- drop procedure sp_endereco_update

select * from enderecos;

-- EX deletar endereços (sp_endereco_delete)
delimiter $$
create procedure sp_endereco_delete(spid int)
begin
delete from enderecos
where id = spid;
end
$$

-- call sp_endereco_delete(21)
-- drop procedure sp_endereco_delete;

-- Procedures usuarios
	-- alterando o número de bytes do campo senha para usar MD5
alter table usuarios modify column senha varchar(32) not null;

-- >>>>>>>>>>>>>>>>>>>>  criando procedure para inserir Usuário
delimiter $$
create procedure sp_usuario_insert(
-- parâmetros da procedure
spnome varchar(60), spemail varchar(60), spsenha varchar(32))
begin
	insert into usuarios 
	values (0,spnome, spemail, md5(spsenha), 'A');
    select * from usuarios where id = last_insert_id();
end $$
-- call sp_usuario_insert( 'Zé das Couves','ze@gmail.com', '1234');

delimiter $$
create procedure sp_usuario_altera(
-- parâmetros da procedure
spid int, spnome varchar(60), spsenha varchar(32), spnivel char(1))
begin
	update usuarios 
	set nome = spnome, senha = md5(spsenha), nivel = spnivel where id = spid;
end $$
-- call sp_usuario_altera(1001,'Well Santos', '123456', 'G'); 
-- select * from usuarios;

-- Procedures categorias
-- 3 (insere, alterar, deleta)

-- inserir categorias
delimiter $$
create procedure sp_categoria_insert (spnome varchar(40), spsigla char(3))
begin
	insert into categorias
    values(0,spnome,spsigla);
    select last_insert_id();
end
$$
-- call sp_categoria_insert ("acessorios engraçados", "ACE")
-- drop procedure sp_categoria_insert;

-- alterar categorias
delimiter $$
create procedure sp_categoria_update (spid int, spnome varchar(40), spsigla char(3))
begin
	update categorias set nome = spnome, sigla = spsigla
    where id = spid;
end
$$

-- call sp_categoria_update (245,"Acessorios malucos", null);
-- drop procedure sp_categoria_update;

-- EX deletar categorias
delimiter $$
create procedure sp_categoria_delete (spid int)
begin
	delete from categorias
    where id = spid;
end
$$

-- call sp_categoria_delete(245)
-- drop procedure sp_categotia_delete;

-- Procedures produtos
--  2 (insere, altera)
-- Inserir produto
delimiter $$
create procedure sp_produto_insert (
spcod_barras varchar(60), 
spdescricao varchar(60),
spvalor_unit decimal(10,2),
spunidade_venda varchar(12),
spcategoria_id int,
spestoque_minimo decimal(10,2),
spclasse_desconto decimal(10,2))
begin
	insert into produtos
    values(
    0,
    spcod_barras, 
    spdescricao, 
    spvalor_unit, 
    spunidade_venda,
    spcategoria_id, 
    spestoque_minimo,
    spclasse_desconto,
    null,
    default);
    select last_insert_id();
end
$$

-- call sp_produto_insert('7894595425874','Para Brisa', 924.54,'unidade',18,0,0);
-- drop procedure sp_produto_insert;

-- alterando produtos
delimiter $$
create procedure sp_produto_update (
spid int,
spcod_barras varchar(60), 
spdescricao varchar(60),
spvalor_unit decimal(10,2),
spunidade_venda varchar(12),
spcategoria_id int,
spestoque_minimo decimal(10,2),
spclasse_desconto decimal(10,2))
begin
	update produtos set cod_barras = spcod_barras, descricao = spdescricao,
    valor_unit = spvalor_unit, unidade_venda = spunidade_venda, categoria_id = spcategoria_id,
    estoque_minimo = spestoque_minimo, classe_desconto = spclasse_desconto
    where id = spid;
end
$$

-- call sp_produto_update (9,'7894595425874','Para Brisa', 900,'unidade',20,0,0)
-- drop procedure sp_produto_update;

-- Procedures pedidos
-- 2 (insere e altera)
-- inserir pedidos
delimiter $$
create procedure sp_pedido_insert (spusuario_id int, spcliente_id int, spstatus char(1), spdesconto decimal(10,2))
begin
	insert into pedidos
    values(0, spusuario_id, spcliente_id,default , spstatus, spdesconto);
    select last_insert_id();
end
$$

-- call sp_pedido_insert (1001, 16, 'A',0);
-- drop procedure sp_pedido_insert;

-- alterar pedidos
delimiter $$
create procedure sp_pedido_update (spid int,spusuario_id int, spcliente_id int, spstatus char(1), spdesconto decimal(10,2))
begin
	update pedidos set usuario_id = spusuario_id, cliente_id = spcliente_id, status = spstatus, desconto = spdesconto
    where id = spid;
end
$$

-- call sp_pedido_update (100125,1001, 20, 'A',0);
-- drop procedure sp_pedido_update;
select * from pedidos;
-- Procedures Itempedido
-- 3 (insere, altera e deleta)

-- inserir itempedido

delimiter $$
create procedure sp_itempedido_insert (sppedido_id int, spproduto_id int, spquantidade decimal (10,2), spdesconto decimal(10,2))
begin
	insert into itempedido
    values (0, sppedido_id, spproduto_id, (select valor_unit from produtos where id = spproduto_id), spquantidade, spdesconto);
    select last_insert_id() as id;
end
$$

-- call sp_itempedido_insert (100125, 9, 3, 0)
-- drop procedure sp_itempedido_insert;

-- alterar itempedido
delimiter $$
create procedure sp_itempedido_update (spid int,spquantidade decimal(10,2), spdesconto decimal(10,2))
begin
	update itempedido set quantidade = spquantidade, desconto = spdesconto
    where id = spid;
end
$$

-- call sp_itempedido_update (12,6,125.15);
-- select * from itempedido;
-- drop procedure sp_itempedido_update;

-- deletar itempedido
delimiter $$
create procedure sp_itempedido_delete (spid int)
begin
	delete from itempedido
    where id = spid;
end
$$

-- call sp_itempedido_delete (1)
-- drop procedure sp_itempedido_delete;