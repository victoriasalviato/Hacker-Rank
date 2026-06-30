# How Will You Compare?

## Description
Java class with three overloaded `compare` methods to compare strings, integers, and integer arrays. Returns `"Same"` if the values are equal or `"Different"` otherwise.

## Methods
| Method | Parameters | Returns `true` if... |
|--------|------------|----------------------|
| `compare(String a, String b)` | Two strings | `a` equals `b` |
| `compare(int a, int b)` | Two integers | `a` equals `b` |
| `compare(int[] a, int[] b)` | Two arrays | Same length and `a[i] == b[i]` for every `i` |

## Input Format
The first line contains `T`, the number of test cases. Each case begins with a `type`:
- **type 1** → string comparison: the next two lines are the strings `a` and `b`
- **type 2** → integer comparison: the next two lines are the integers `a` and `b`
- **type 3** → array comparison: the next line contains `n` and `m` (sizes), followed by a line with the elements of `a` and another with the elements of `b`

## Example
### Input
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
### Output
```
Same
Different
Same
Different
```
### Explanation
| Case | Type | a | b | Output | Reason |
|------|------|---|---|--------|--------|
| 1 | String | "hello world" | "hello world" | Same | Equal strings |
| 2 | int | 3 | 4 | Different | 3 ≠ 4 |
| 3 | array | {1,2,3} | {1,2,3} | Same | Same length and equal elements |
| 4 | String | "Abc" | "abc" | Different | Case-sensitive |

## Constraints
- Strings: `1 ≤ length(a), length(b) ≤ 2000`
- Integers: `0 ≤ a, b ≤ 10000000`
- Arrays: `1 ≤ length(a), length(b) ≤ 10`

## How to Run
```bash
javac Main.java
java Main
```
