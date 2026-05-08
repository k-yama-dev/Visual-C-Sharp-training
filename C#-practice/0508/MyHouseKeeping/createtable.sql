create table moneyTable (
    id int AUTO_INCREMENT,
    日付 date not null,
    分類 varchar(30) not null,
    品名 varchar(30),
    金額 int,
    備考 varchar(50),
    primary key(id)
);

CREATE table categoryTable (
    分類 varchar(10) not null,
    入出金分類 varchar(10),
    primary key(分類)
);

insert into moneytable
values (null,'2026-4-1','住居','3月分家賃',72000,'');

INSERT into categorytable
values('給料','入金'),('雑費','出金'),('住居','出金'),('食費','出金'),('電気代','出金');

