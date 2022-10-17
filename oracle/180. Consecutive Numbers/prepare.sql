create table LOGS
(
  id  NUMBER(10) not null,
  num VARCHAR2(100)
)
/

alter table LOGS add constraint PK_LOGS primary key (ID)
/

insert into LOGS (id, num)
values (1, 'a');
insert into LOGS (id, num)
values (2, 'a');
insert into LOGS (id, num)
values (3, 'a');
insert into LOGS (id, num)
values (4, 'b');
insert into LOGS (id, num)
values (5, 'b');
insert into LOGS (id, num)
values (6, 'a');
insert into LOGS (id, num)
values (7, 'b');
insert into LOGS (id, num)
values (8, 'b');
insert into LOGS (id, num)
values (9, 'b');
insert into LOGS (id, num)
values (10, 'c');
insert into LOGS (id, num)
values (11, 'c');
insert into LOGS (id, num)
values (12, 'b');
insert into LOGS (id, num)
values (13, 'c');
insert into LOGS (id, num)
values (14, 'c');
insert into LOGS (id, num)
values (15, 'd');
insert into LOGS (id, num)
values (16, 'd');
insert into LOGS (id, num)
values (17, 'd');
insert into LOGS (id, num)
values (18, 'd');
insert into LOGS (id, num)
values (19, 'a');
insert into LOGS (id, num)
values (20, 'a');
insert into LOGS (id, num)
values (21, 'a');
insert into LOGS (id, num)
values (22, 'c');
insert into LOGS (id, num)
values (23, 'c');
commit;
