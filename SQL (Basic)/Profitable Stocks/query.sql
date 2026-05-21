SELECT pt.stock_code
FROM price_today pt
JOIN price_tomorrow pm ON pt.stock_code = pm.stock_code
WHERE pm.price > pt.price
ORDER BY pt.stock_code ASC;
