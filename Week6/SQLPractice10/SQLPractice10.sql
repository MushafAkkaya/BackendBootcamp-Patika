--1.madde
select city, country from city
left join country on country.country_id = city.country_id

--2.madde
select payment_id, first_name, last_name from customer
right join payment on customer.customer_id = payment.customer_id

--3.madde
select rental_id, first_name, last_name from customer
full join rental on customer.customer_id = rental.customer_id