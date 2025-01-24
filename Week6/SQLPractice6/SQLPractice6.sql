--1.madde
select avg(rental_rate) from film

--2.madde
select count(*) from film where title like 'C%'

--3.madde
select max(length) from film where rental_rate = 0.99

--4.madde
select count(distinct replacement_cost) from film where length > 150