create database agenda;
use agenda;

create table tbcontato(
codcontato int not null primary	key auto_increment
, nome varchar(100)
, telefone char(14)
, celular char(15)
, email varchar(100)
);

insert into tbcontato(nome, telefone, celular, email)
values('Samara Pereira', '(11) 5555-4444', '(11) 97777-8888', 'samara.ferreira27@gmail.com'),
('Samara Oliveira', '(11) 5555-4444', '(11) 97777-8888', 'samara.ferreira27@gmail.com');

select * from tbcontato;