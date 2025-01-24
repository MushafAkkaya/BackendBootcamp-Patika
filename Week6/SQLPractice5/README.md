# SQL Queries for Film and Customer Data Analysis

This README file describes the SQL queries created to fulfill specific requirements for analyzing data from `film` and `customer` tables in a database.

## Requirements and Queries

### 1. Retrieve the Top 5 Longest Films Ending with 'n'
Retrieve the 5 longest films where the title ends with the character 'n', sorted by their length in descending order.

#### SQL Query:
```sql
SELECT *
FROM film
WHERE title LIKE '%n'
ORDER BY length DESC
LIMIT 5;
```

### 2. Retrieve the Next 5 Shortest Films Ending with 'n'
Retrieve the 6th to 10th shortest films (by length) where the title ends with the character 'n', sorted by their length in ascending order.

#### SQL Query:
```sql
SELECT *
FROM film
WHERE title LIKE '%n'
ORDER BY length ASC
OFFSET 5
LIMIT 5;
```

### 3. Retrieve the Top 4 Customers by Last Name in Descending Order (Store ID: 1)
Retrieve the first 4 customers sorted by `last_name` in descending order, with a condition that the `store_id` is 1.

#### SQL Query:
```sql
SELECT *
FROM customer
WHERE store_id = 1
ORDER BY last_name DESC
LIMIT 4;
```

## How to Use the Queries
1. Ensure that the `film` and `customer` tables exist in the database and contain relevant data.
2. Run the queries in your preferred SQL client or database management tool.
3. Verify the results to match the specified requirements.

## Notes
- Adjust table names or column names if they differ in your database schema.
- Test queries in a non-production environment to ensure accuracy and prevent unintended modifications.
