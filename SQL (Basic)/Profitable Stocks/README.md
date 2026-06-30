# Profitable Stocks

## Description
SQL query to identify profitable stocks, returning the `stock_code` of every stock whose predicted price for tomorrow is **strictly greater** than its current price. The result is sorted in ascending order.

## Tables

### `price_today`
| Column     | Type    | Description                       |
|------------|---------|-------------------------------------|
| stock_code | STRING  | Stock code (primary key)            |
| price      | INTEGER | Current stock price                 |

### `price_tomorrow`
| Column     | Type    | Description                       |
|------------|---------|-------------------------------------|
| stock_code | STRING  | Stock code (primary key)            |
| price      | INTEGER | Predicted stock price for tomorrow  |

> **Note:** Both tables contain every stock listed on the stock exchange.

## Query
```sql
SELECT pt.stock_code
FROM price_today pt
JOIN price_tomorrow pm ON pt.stock_code = pm.stock_code
WHERE pm.price > pt.price
ORDER BY pt.stock_code ASC;
```

## How It Works
1. Performs a `JOIN` between the two tables using `stock_code`
2. Filters only the stocks where tomorrow's price is **strictly greater** than today's price
3. Sorts the result in **ascending order** by `stock_code`

## Example
| stock_code | Today | Tomorrow | Profitable? |
|------------|-------|----------|--------------|
| TITAN      | 560   | 750      | ✅ Yes        |
| MRF        | 950   | 800      | ❌ No         |
| GOOGL      | 200   | 210      | ✅ Yes        |

**Expected output:**
```
GOOGL
TITAN
```
