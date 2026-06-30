# Student Analysis

## Description
SQL query to identify students with low academic performance, returning the roll number and name of students whose total score across 3 subjects was below 100 points.

## Tables

### `student_information`
| Column      | Type    | Description                          |
|-------------|---------|----------------------------------------|
| roll_number | INTEGER | Student roll number (primary key)      |
| name        | STRING  | Student's name                         |

### `examination_marks`
| Column        | Type    | Description                          |
|---------------|---------|----------------------------------------|
| roll_number   | INTEGER | Student roll number (primary key)      |
| subject_one   | INTEGER | Score for the first subject            |
| subject_two   | INTEGER | Score for the second subject           |
| subject_three | INTEGER | Score for the third subject            |

## Query
```sql
SELECT si.roll_number, si.name
FROM student_information si
JOIN examination_marks em ON si.roll_number = em.roll_number
WHERE (em.subject_one + em.subject_two + em.subject_three) < 100;
```

## How It Works
1. Performs a `JOIN` between the two tables using `roll_number`
2. Sums each student's scores across the 3 subjects
3. Filters only the students whose total is **less than 100**

## Example
| roll_number | name        | Total |
|-------------|-------------|-------|
| 1           | Sheila      | 144   |
| 2           | Rachel      | 70    | ← returned
| 3           | Christopher | 77    | ← returned

**Expected output:**
```
2 Rachel
3 Christopher
```
