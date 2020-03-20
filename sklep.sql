insert into pracownicy(id,imie,nazwisko,pesel,plec,data_urodzenia,pensja)
values(11,'Grzegorz',null,12345678901,'M','70/05/18',1000); 

alter table pracownicy 
modify nazwisko not null;

select * from pracownicy;