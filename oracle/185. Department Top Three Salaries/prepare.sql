create table DEPARTMENT
(
  id   NUMBER(10) not null,
  name VARCHAR2(50)
)
/

alter table DEPARTMENT
  add constraint PK_DEPARTMENT primary key (ID)
/

insert into DEPARTMENT (id, name)
values (1, 'Sales');
insert into DEPARTMENT (id, name)
values (2, 'IT');
insert into DEPARTMENT (id, name)
values (3, 'Infrastructure');

create table EMPLOYEE
(
  id           NUMBER(10) not null,
  name         VARCHAR2(50),
  salary       NUMBER(10),
  departmentid NUMBER(10)
)
/

alter table EMPLOYEE
  add constraint PK_EMPLOYEE primary key (ID)
/

alter table EMPLOYEE
  add constraint FK_EMPLOYEE foreign key (DEPARTMENTID)
  references DEPARTMENT (ID)
/

insert into EMPLOYEE (id, name, salary, departmentid)
values (1, 'Joe', 85000, 1);
insert into EMPLOYEE (id, name, salary, departmentid)
values (2, 'Henry', 80000, 2);
insert into EMPLOYEE (id, name, salary, departmentid)
values (3, 'Sam', 60000, 2);
insert into EMPLOYEE (id, name, salary, departmentid)
values (4, 'Max', 90000, 1);
insert into EMPLOYEE (id, name, salary, departmentid)
values (5, 'Janet', 69000, 1);
insert into EMPLOYEE (id, name, salary, departmentid)
values (6, 'Randy', 85000, 1);
insert into EMPLOYEE (id, name, salary, departmentid)
values (7, 'Will', 70000, 1);
commit;
