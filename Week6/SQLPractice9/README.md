# INNER JOIN

## Overview
This repository contains SQL queries that demonstrate the use of `INNER JOIN` to combine data from multiple related tables. The following queries address three specific scenarios involving `city`, `country`, `customer`, `payment`, and `rental` tables.

## SQL Queries

### 1. Joining `city` and `country` Tables
**Purpose:** Retrieve a list of cities and their corresponding countries by joining the `city` table with the `country` table using their foreign key relationship.

**Query:**
```sql
SELECT city, country
FROM city
INNER JOIN country
ON city.country_id = country.country_id;
```

**Explanation:**
- The `INNER JOIN` combines rows from the `city` and `country` tables where `city.country_id` matches `country.country_id`.
- The result includes columns `city` (from the `city` table) and `country` (from the `country` table).

---

### 2. Joining `customer` and `payment` Tables
**Purpose:** Retrieve a list of payment IDs along with the first and last names of customers who made those payments.

**Query:**
```sql
SELECT payment_id, first_name, last_name
FROM customer
INNER JOIN payment
ON customer.customer_id = payment.customer_id;
```

**Explanation:**
- The `INNER JOIN` combines rows from the `customer` and `payment` tables where `customer.customer_id` matches `payment.customer_id`.
- The result includes columns `payment_id` (from the `payment` table), `first_name`, and `last_name` (from the `customer` table).

---

### 3. Joining `customer` and `rental` Tables
**Purpose:** Retrieve a list of rental IDs along with the first and last names of customers who made those rentals.

**Query:**
```sql
SELECT rental_id, first_name, last_name
FROM customer
INNER JOIN rental
ON customer.customer_id = rental.customer_id;
```

**Explanation:**
- The `INNER JOIN` combines rows from the `customer` and `rental` tables where `customer.customer_id` matches `rental.customer_id`.
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
