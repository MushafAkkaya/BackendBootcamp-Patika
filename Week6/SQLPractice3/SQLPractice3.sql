--1.madde
select country from country where country like 'A%a'

--2.madde
select country from country where country like '%_____n'

--3.madde
select title from film where title ilike '%T%'

--4.madde
select * from film where title like 'C%' and length > 90 and rental_rate = 2.99