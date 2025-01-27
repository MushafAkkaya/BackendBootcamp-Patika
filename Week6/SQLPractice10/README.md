# LEFT, RIGHT, FULL JOIN

## Overview
This repository contains SQL queries that demonstrate the use of `LEFT JOIN`, `RIGHT JOIN`, and `FULL JOIN` to combine data from multiple related tables. The following queries address three specific scenarios involving `city`, `country`, `customer`, `payment`, and `rental` tables.

## SQL Queries

### 1. Using `LEFT JOIN` with `city` and `country` Tables
**Purpose:** Retrieve a list of cities and their corresponding countries by performing a `LEFT JOIN` between the `city` table and the `country` table.

**Query:**
```sql
SELECT city, country 
FROM city
LEFT JOIN country 
ON country.country_id = city.country_id;
```

**Explanation:**
- The `LEFT JOIN` ensures that all rows from the `city` table are returned, even if there is no matching row in the `country` table.
- The result includes columns `city` (from the `city` table) and `country` (from the `country` table).

---

### 2. Using `RIGHT JOIN` with `customer` and `payment` Tables
**Purpose:** Retrieve a list of payment IDs along with the first and last names of customers who made those payments, using a `RIGHT JOIN` between the `customer` table and the `payment` table.

**Query:**
```sql
SELECT payment_id, first_name, last_name 
FROM customer
RIGHT JOIN payment 
ON customer.customer_id = payment.customer_id;
```

**Explanation:**
- The `RIGHT JOIN` ensures that all rows from the `payment` table are returned, even if there is no matching row in the `customer` table.
- The result includes columns `payment_id` (from the `payment` table), `first_name`, and `last_name` (from the `customer` table).

---

### 3. Using `FULL JOIN` with `customer` and `rental` Tables
**Purpose:** Retrieve a list of rental IDs along with the first and last names of customers who made those rentals, using a `FULL JOIN` between the `customer` table and the `rental` table.

**Query:**
```sql
SELECT rental_id, first_name, last_name 
FROM customer
FULL JOIN rental 
ON customer.customer_id = rental.customer_id;
```

**Explanation:**
- The `FULL JOIN` ensures that all rows from both the `customer` and `rental` tables are returned, even if there is no matching row in one of the tables.
- The result includes columns `rental_id` (from the `rental` table), `first_name`, and `last_name` (from the `customer` table).

---

## Prerequisites
- A relational database system such as MySQL, PostgreSQL, or SQL Server.
- Access to the `city`, `country`, `customer`, `payment`, and `rental` tables.
- Properly defined foreign key relationships between the tables.

## How to Execute
1. Open your SQL client or database management tool.
2. Copy and paste any of the provided SQL queries into the query editor.
3. Execute the query to see the results.

## License
This project is licensed under the MIT License.

