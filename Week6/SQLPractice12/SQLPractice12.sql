--1.madde
select * from film where length > (
select avg(length) from film
)

--2.madde
select * from film where rental_rate = (
select max(rental_rate) from film
)

--3.madde
select * from film where rental_rate = 
(
select min(rental_rate) from film
)
and replacement_cost =
(
select min(replacement_cost) from film
)

--4.madde
select * from payment where amount = 
(
select max(amount) from payment
)