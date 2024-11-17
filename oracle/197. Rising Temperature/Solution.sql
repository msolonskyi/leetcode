/* Write your PL/SQL query statement below */
select id
from (select id, temperature temperature_today, lag(temperature, 1) over (order by recordDate) temperature_yesterday,
             trunc(recordDate) recordDate_today, trunc(lag(recordDate, 1) over (order by recordDate)) recordDate_yesterday
      from Weather) i
where temperature_today > temperature_yesterday
  and recordDate_today = recordDate_yesterday + 1