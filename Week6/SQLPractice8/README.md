# Employee Table - SQL Project

## Project Description
This project involves the creation and manipulation of an `employee` table in a test database. The table contains information about employees such as their ID, name, birthday, and email. The project follows these steps:

1. **Table Creation**: Create the `employee` table with the specified schema.
2. **Data Population**: Insert 50 rows of sample data into the table using the Mockaroo service.
3. **Data Updates**: Perform five `UPDATE` operations to modify rows based on specific criteria.
4. **Data Deletions**: Perform five `DELETE` operations to remove rows based on specific criteria.

---

## Steps and SQL Scripts

### 1. Table Creation
The following SQL script creates the `employee` table with the following schema:

- `id`: A unique identifier for each employee (INTEGER, Primary Key).
- `name`: The employee's name (VARCHAR(50), Not Null).
- `birthday`: The employee's date of birth (DATE).
- `email`: The employee's email address (VARCHAR(100)).

```sql
CREATE TABLE employee (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    birthday DATE,
    email VARCHAR(100)
);
```

### 2. Data Population
Using the Mockaroo service, we generated 50 rows of sample data. Below is a snippet of the `INSERT` statements used to populate the `employee` table:

```sql
INSERT INTO employee (name, birthday, email) VALUES ('Pietrek', '2024-04-05', 'pleet0@studiopress.com');
INSERT INTO employee (name, birthday, email) VALUES ('Lucilia', '2025-01-06', 'lilliston1@bloglines.com');
INSERT INTO employee (name, birthday, email) VALUES ('Benedetta', '2024-09-29', 'ballpress2@exblog.jp');
-- Additional rows omitted for brevity.
```

### 3. Data Updates
Five `UPDATE` operations were performed to modify the rows in the table. An example is shown below:

```sql
UPDATE employee
SET name = 'Mehmet', birthday = '2010-11-08', email = 'mehmet@gmail.com'
WHERE id = 5;
```

This operation was repeated with slight variations for different rows.

### 4. Data Deletions
Five `DELETE` operations were performed to remove rows based on specific criteria. An example is shown below:

```sql
DELETE FROM employee
WHERE name = 'Mehmet';
```

This operation was repeated for other rows meeting the same condition.

---

## Prerequisites
- A PostgreSQL database.
- A SQL client (e.g., pgAdmin, DBeaver, or psql command-line tool).

---

## How to Run the Project

1. **Setup the Database**:
   - Ensure you have a PostgreSQL database set up.
   - Create a new database (if not already created).

2. **Run the Scripts**:
   - Execute the table creation script in your SQL client.
   - Populate the table with the `INSERT` statements provided.
   - Perform the `UPDATE` and `DELETE` operations as described.

3. **Verify Results**:
   - Query the `employee` table to confirm that the data has been successfully inserted, updated, and deleted as expected.

---

## Example Queries
Here are some sample queries you can use to verify the data:

- Retrieve all rows:

  ```sql
  SELECT * FROM employee;
  ```

- Count the number of employees:

  ```sql
  SELECT COUNT(*) FROM employee;
  ```

- Find employees with a specific name:

  ```sql
  SELECT * FROM employee WHERE name = 'Mehmet';
  ```

---

## Notes
- The sample data was generated using [Mockaroo](https://www.mockaroo.com/).
- Ensure that your PostgreSQL version supports the `SERIAL` type.

---
