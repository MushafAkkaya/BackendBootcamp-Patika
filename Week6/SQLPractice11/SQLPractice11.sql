--1.madde
SELECT first_name FROM actor
UNION 
SELECT first_name FROM customer ORDER BY first_name;

--2.madde
SELECT first_name FROM actor
INTERSECT
SELECT first_name FROM customer ORDER BY first_name;

--3.madde
SELECT first_name FROM actor
EXCEPT
SELECT first_name FROM customer ORDER BY first_name;

--4.madde
SELECT first_name FROM actor
UNION ALL
SELECT first_name FROM customer ORDER BY first_name;
