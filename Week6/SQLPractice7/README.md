# SQL Queries for Grouping and Analysis

This README file describes the SQL queries created to fulfill specific requirements for analyzing and grouping data from the `film`, `customer`, and `city` tables in a database.

## Requirements and Queries

### 1. Group Films by Rating
Group all films in the `film` table based on their `rating` values.

#### SQL Query:
```sql
SELECT rating
FROM film
GROUP BY rating;
```

### 2. Find Replacement Costs with More Than 50 Films
Group films by their `replacement_cost` values and identify the `replacement_cost` values that are associated with more than 50 films. Also, display the corresponding film count.

#### SQL Query:
```sql
SELECT replacement_cost, COUNT(*)
FROM film
GROUP BY replacement_cost
HAVING COUNT(*) > 50;
```

### 3. Count Customers by Store ID
Determine the number of customers for each `store_id` in the `customer` table.

#### SQL Query:
```sql
SELECT store_id, COUNT(*)
FROM customer
GROUP BY store_id;
```

### 4. Find Country ID with the Most Cities
Group the cities in the `city` table by their `country_id` values and find the `country_id` with the highest number of cities. Display the `country_id` and the corresponding city count.

#### SQL Query:
```sql
SELECT country_id, COUNT(*)
FROM city
GROUP BY country_id
ORDER BY COUNT(*) DESC
LIMIT 1;
```

## How to Use the Queries
1. Ensure the `film`, `customer`, and `city` tables exist in the database and contain relevant data.
2. Run the queries in your preferred SQL client or database management tool.
3. Verify the results to match the specified requirements.

## Notes
- Adjust table names or column names if they differ in your database schema.
- Test queries in a non-production environment to ensure accuracy and prevent unintended modifications.
