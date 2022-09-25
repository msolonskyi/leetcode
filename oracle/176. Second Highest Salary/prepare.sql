create table EMPLOYEE
(
  id     NUMBER(20) not null,
  salary NUMBER(20)
)
/

alter table EMPLOYEE add constraint PK_EMPLOYEE primary key (ID)
/

insert into EMPLOYEE (id, salary)
values (1, 100);
insert into EMPLOYEE (id, salary)
values (2, 200);
insert into EMPLOYEE (id, salary)
values (3, 300);
commit;
