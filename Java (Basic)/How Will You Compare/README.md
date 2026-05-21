# How Will You Compare?

## Descrição

Classe Java com três métodos `compare` sobrecarregados para comparar strings, inteiros e arrays de inteiros. Retorna `"Same"` se os valores forem iguais ou `"Different"` caso contrário.

## Métodos

| Método | Parâmetros | Retorna `true` se... |
|--------|------------|----------------------|
| `compare(String a, String b)` | Duas strings | `a` é igual a `b` |
| `compare(int a, int b)` | Dois inteiros | `a` é igual a `b` |
| `compare(int[] a, int[] b)` | Dois arrays | Mesmo tamanho e `a[i] == b[i]` para todo `i` |

## Formato de Entrada

A primeira linha contém `T`, o número de casos de teste. Cada caso começa com um `type`:

- **type 1** → comparação de strings: próximas duas linhas são as strings `a` e `b`
- **type 2** → comparação de inteiros: próximas duas linhas são os inteiros `a` e `b`
- **type 3** → comparação de arrays: próxima linha contém `n` e `m` (tamanhos), seguida de uma linha com os elementos de `a` e outra com os de `b`

## Exemplo

### Entrada
```
4
1
hello world
hello world
2
3
4
3
3 3
1 2 3
1 2 3
1
Abc
abc
```

### Saída
```
Same
Different
Same
Different
```

### Explicação

| Caso | Tipo | a | b | Saída | Motivo |
|------|------|---|---|-------|--------|
| 1 | String | "hello world" | "hello world" | Same | Strings iguais |
| 2 | int | 3 | 4 | Different | 3 ≠ 4 |
| 3 | array | {1,2,3} | {1,2,3} | Same | Mesmo tamanho e elementos iguais |
| 4 | String | "Abc" | "abc" | Different | Case-sensitive |

## Constraints

- Strings: `1 ≤ length(a), length(b) ≤ 2000`
- Inteiros: `0 ≤ a, b ≤ 10000000`
- Arrays: `1 ≤ length(a), length(b) ≤ 10`

## Como executar

```bash
javac Main.java
java Main
```
