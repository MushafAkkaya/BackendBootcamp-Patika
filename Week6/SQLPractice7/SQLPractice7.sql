--1.madde
select rating from film
group by rating;

--2.madde
select replacement_cost, count(*) from film
group by replacement_cost
having count(*) > 50

--3.madde
select store_id, count(*) from customer
group by store_id

--4.madde
select country_id, count(*) from city
group by country_id
order by count(*) desc
limit 1