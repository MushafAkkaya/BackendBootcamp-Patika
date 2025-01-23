--1.madde
select distinct replacement_cost from film

--2.madde
select count(distinct replacement_cost) from film

--3.madde
select count(title) from film where title like 'T%' and rating = 'G'

--4.madde
select count(*) from country where country like '_____'

--5.madde
select count(*) from city where city ilike '%r'