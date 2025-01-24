# SQL Queries for Film Data Analysis

This README file describes the SQL queries created to fulfill specific requirements for analyzing data from the `film` table in a database.

## Requirements and Queries

### 1. Calculate the Average Rental Rate
Determine the average value of the `rental_rate` column in the `film` table.

#### SQL Query:
```sql
SELECT AVG(rental_rate)
FROM film;
```

### 2. Count Films Starting with the Letter 'C'
Count the number of films in the `film` table where the title starts with the character 'C'.

#### SQL Query:
```sql
SELECT COUNT(*)
FROM film
WHERE title LIKE 'C%';
```

### 3. Find the Longest Film with a Rental Rate of 0.99
Identify the maximum length (in minutes) of films that have a `rental_rate` equal to 0.99.

#### SQL Query:
```sql
SELECT MAX(length)
FROM film
WHERE rental_rate = 0.99;
```

### 4. Count Distinct Replacement Costs for Films Longer than 150 Minutes
Count the number of distinct `replacement_cost` values for films with a length greater than 150 minutes.

#### SQL Query:
```sql
SELECT COUNT(DISTINCT replacement_cost)
FROM film
WHERE length > 150;
```

## How to Use the Queries
1. Ensure the `film` table exists in the database and contains relevant data.
2. Run the queries in your preferred SQL client or database management tool.
3. Verify the results to match the specified requirements.

## Notes
- Adjust table names or column names if they differ in your database schema.
- Test queries in a non-production environment to ensure accuracy and prevent unintended modifications.
