# Profitable Stocks

## Descrição

Query SQL para identificar ações lucrativas, retornando os `stock_code` de todas as ações cujo preço previsto para amanhã é **estritamente maior** que o preço atual. O resultado é ordenado em ordem ascendente.

## Tabelas

### `price_today`
| Coluna     | Tipo    | Descrição                              |
|------------|---------|----------------------------------------|
| stock_code | STRING  | Código da ação (chave primária)        |
| price      | INTEGER | Preço atual da ação                    |

### `price_tomorrow`
| Coluna     | Tipo    | Descrição                              |
|------------|---------|----------------------------------------|
| stock_code | STRING  | Código da ação (chave primária)        |
| price      | INTEGER | Preço previsto da ação para amanhã     |

> **Nota:** Ambas as tabelas contêm todas as ações listadas na bolsa de valores.

## Query

```sql
SELECT pt.stock_code
FROM price_today pt
JOIN price_tomorrow pm ON pt.stock_code = pm.stock_code
WHERE pm.price > pt.price
ORDER BY pt.stock_code ASC;
```

## Como funciona

1. Faz um `JOIN` entre as duas tabelas usando `stock_code`
2. Filtra apenas as ações onde o preço de amanhã é **estritamente maior** que o preço de hoje
3. Ordena o resultado em **ordem ascendente** por `stock_code`

## Exemplo

| stock_code | Hoje | Amanhã | Lucrativa? |
|------------|------|--------|------------|
| TITAN      | 560  | 750    | ✅ Sim     |
| MRF        | 950  | 800    | ❌ Não     |
| GOOGL      | 200  | 210    | ✅ Sim     |

**Saída esperada:**
```
GOOGL
TITAN
```
