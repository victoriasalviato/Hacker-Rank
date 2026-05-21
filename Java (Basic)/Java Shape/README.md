# Java: Shape

## Descrição

Implementação de duas classes Java para representar objetos bidimensionais, usando herança entre a superclasse `Shape` e a classe concreta `Rectangle`.

## Classes

### `Shape` (Superclasse)
| Membro | Tipo | Descrição |
|--------|------|-----------|
| `length` | int | Comprimento da forma |
| `breadth` | int | Largura da forma |
| `Shape(int length, int breadth)` | Construtor | Armazena os valores nas variáveis membro |
| `area()` | Método | Imprime `length` e `breadth` separados por espaço |

### `Rectangle` (Subclasse)
| Membro | Tipo | Descrição |
|--------|------|-----------|
| `Rectangle(int length, int breadth)` | Construtor | Repassa os argumentos ao construtor da superclasse |
| `area()` | Método (override) | Chama `super.area()` e imprime `length * breadth` |

## Formato de Entrada

Uma única linha com dois inteiros separados por espaço: `length` e `breadth`.

## Formato de Saída

```
length breadth
length*breadth
```

## Exemplos

### Caso 0
**Entrada:**
```
4 5
```
**Saída:**
```
4 5
20
```

### Caso 1
**Entrada:**
```
200 200
```
**Saída:**
```
200 200
40000
```

## Constraints

- `0 < length ≤ 1000`
- `0 < breadth ≤ 1000`

## Como executar

```bash
javac Main.java
java Main
```
