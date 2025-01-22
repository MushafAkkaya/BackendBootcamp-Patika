--1.madde
select title, description from film

--2.madde
select * from film where length > 60 and length < 75

--3.madde
select * from film where rental_rate = 0.99 and (replacement_cost = 12.99
or replacement_cost = 28.99)

--4.madde
select first_name, last_name from customer where first_name = 'Mary'

--5.madde
select * from film where length <= 50 and rental_rate not in(2.99,4.99)