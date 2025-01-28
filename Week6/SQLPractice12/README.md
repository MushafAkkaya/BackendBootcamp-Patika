# SQL SubQueries

This document explains the purpose and functionality of the provided SQL queries. These queries are designed to extract specific data from the `film` and `payment` tables based on the requirements listed below.

## Requirements

1. **Find the number of films whose length (`length` column) is greater than the average film length.**

2. **Identify the number of films with the highest rental rate (`rental_rate` column).**

3. **List the films that have both the lowest rental rate (`rental_rate` column) and the lowest replacement cost (`replacement_cost` column).**

4. **Sort the customers in the `payment` table who have made the highest number of transactions.**

---

## SQL Queries

### 1. Films with Length Greater than the Average Length
```sql
SELECT *
FROM film
WHERE length > (
    SELECT AVG(length)
    FROM film
);
```
- **Explanation:** This query retrieves all films from the `film` table where the `length` is greater than the average length of all films.

### 2. Films with the Highest Rental Rate
```sql
SELECT *
FROM film
WHERE rental_rate = (
    SELECT MAX(rental_rate)
    FROM film
);
```
- **Explanation:** This query fetches all films from the `film` table that have the maximum `rental_rate` value.

### 3. Films with the Lowest Rental Rate and Replacement Cost
```sql
SELECT *
FROM film
WHERE rental_rate = (
    SELECT MIN(rental_rate)
    FROM film
)
AND replacement_cost = (
    SELECT MIN(replacement_cost)
    FROM film
);
```
- **Explanation:** This query lists all films with the minimum `rental_rate` and `replacement_cost` values.

### 4. Customers with the Highest Number of Transactions
```sql
SELECT *
FROM payment
WHERE amount = (
    SELECT MAX(amount)
    FROM payment
);
```
- **Explanation:** This query identifies customers in the `payment` table who have made the highest number of transactions.

---

## Notes
- The queries are written to handle standard SQL syntax.
- Ensure that the database schema is properly set up with the `film` and `payment` tables before executing these queries.
- For better performance, consider indexing columns like `length`, `rental_rate`, and `replacement_cost` in the `film` table, as well as `amount` in the `payment` table.

---

Feel free to adapt these queries based on your specific use case!

