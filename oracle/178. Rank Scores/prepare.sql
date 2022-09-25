create table SCORES
(
  id    NUMBER(10) not null,
  score NUMBER(10,2)
)
/

alter table SCORES add constraint PK_SCORES primary key (ID)
/

insert into SCORES (id, score)
values (1, 3.5);
insert into SCORES (id, score)
values (2, 3.65);
insert into SCORES (id, score)
values (3, 4);
insert into SCORES (id, score)
values (4, 3.85);
insert into SCORES (id, score)
values (6, 3.65);
insert into SCORES (id, score)
values (5, 4);
commit;
