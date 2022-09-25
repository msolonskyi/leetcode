create table PERSON
(
  personid  NUMBER(20) not null,
  lastname  VARCHAR2(100) not null,
  firstname VARCHAR2(100) not null
)
/
alter table PERSON add constraint PK_PERSON primary key (PERSONID)
/

create table ADDRESS
(
  addressid NUMBER(20) not null,
  personid  NUMBER(20) not null,
  city      VARCHAR2(100),
  state     VARCHAR2(100)
)
/

alter table ADDRESS add constraint PK_ADDRESS primary key (ADDRESSID)
/

insert into PERSON (personid, lastname, firstname)
values (1, 'Wang', 'Allen');
insert into PERSON (personid, lastname, firstname)
values (2, 'Alice', 'Bob');

insert into ADDRESS (addressid, personid, city, state)
values (1, 2, 'New York City', 'New York');
insert into ADDRESS (addressid, personid, city, state)
values (2, 3, 'Leetcode', 'California');
commit;
