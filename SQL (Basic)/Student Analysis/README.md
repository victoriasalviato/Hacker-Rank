# Student Analysis

## Descrição

Query SQL para identificar alunos com baixo desempenho acadêmico, retornando o número de matrícula e nome dos alunos que obtiveram menos de 100 pontos no total das 3 matérias.

## Tabelas

### `student_information`
| Coluna      | Tipo    | Descrição                        |
|-------------|---------|----------------------------------|
| roll_number | INTEGER | Número de matrícula (chave primária) |
| name        | STRING  | Nome do aluno                    |

### `examination_marks`
| Coluna        | Tipo    | Descrição                        |
|---------------|---------|----------------------------------|
| roll_number   | INTEGER | Número de matrícula (chave primária) |
| subject_one   | INTEGER | Nota da primeira matéria         |
| subject_two   | INTEGER | Nota da segunda matéria          |
| subject_three | INTEGER | Nota da terceira matéria         |

## Query

```sql
SELECT si.roll_number, si.name
FROM student_information si
JOIN examination_marks em ON si.roll_number = em.roll_number
WHERE (em.subject_one + em.subject_two + em.subject_three) < 100;
```

## Como funciona

1. Faz um `JOIN` entre as duas tabelas usando `roll_number`
2. Soma as notas das 3 matérias de cada aluno
3. Filtra apenas os alunos com total **menor que 100**

## Exemplo

| roll_number | name        | Total |
|-------------|-------------|-------|
| 1           | Sheila      | 144   |
| 2           | Rachel      | 70    | ← retornado
| 3           | Christopher | 77    | ← retornado

**Saída esperada:**
```
2 Rachel
3 Christopher
```
