# Employees Management — C# Challenge Solution

A class that manages a list of employees and provides LINQ-based analytics grouped by company.

---

## Employee Class

| Property | Type | Description |
|----------|------|-------------|
| `FirstName` | `string` | First name of the employee |
| `LastName` | `string` | Last name of the employee |
| `Company` | `string` | Company the employee belongs to |
| `Age` | `int` | Age of the employee |

---

## Methods

### `AverageAgeForEachCompany()`
Returns a `Dictionary<string, int>` sorted by company name (key), where the value is the **average age** of employees in that company, rounded to the nearest whole number.

### `CountOfEmployeesForEachCompany()`
Returns a `Dictionary<string, int>` sorted by company name (key), where the value is the **total number of employees** in that company.

### `OldestAgeForEachCompany()`
Returns a `Dictionary<string, Employee>` sorted by company name (key), where the value is the **oldest employee** in that company.

> All dictionaries are sorted alphabetically by company name.

---

## Example

**Input:**
```
12
Ainslee Ginsie Galaxy 28
Libbey Apdell Starbucks 44
Illa Stebbings Berkshire 49
Laina Sycamore Berkshire 20
Abbe Parnell Amazon 20
Ludovika Reveley Berkshire 30
Rene Antos Galaxy 44
Vinson Beckenham Berkshire 45
Reed Lynock Amazon 41
Wyndham Bamfield Berkshire 34
Loraine Sappson Amazon 49
Abbe Antonutti Starbucks 47
```

**Output:**
```
The average age for company Amazon is 37
The average age for company Berkshire is 36
The average age for company Galaxy is 36
The average age for company Starbucks is 46
The count of employees for company Amazon is 3
The count of employees for company Berkshire is 5
The count of employees for company Galaxy is 2
The count of employees for company Starbucks is 2
The oldest employee of company Amazon is Loraine Sappson having age 49
The oldest employee of company Berkshire is Illa Stebbings having age 49
The oldest employee of company Galaxy is Rene Antos having age 44
The oldest employee of company Starbucks is Abbe Antonutti having age 47
```

---

## Implementation Notes

- All three methods use **LINQ** (`GroupBy`, `OrderBy`, `ToDictionary`).
- Average age uses `Math.Round` for proper rounding.
- Oldest employee is found with `OrderByDescending(e => e.Age).First()`.
- `Main` reads `n` employees from stdin, then calls all 3 methods and prints results in the expected format.
