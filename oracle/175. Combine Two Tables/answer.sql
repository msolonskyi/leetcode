select firstName, lastName, city, state
from person p, address a
where p.personid = a.personid(+)
