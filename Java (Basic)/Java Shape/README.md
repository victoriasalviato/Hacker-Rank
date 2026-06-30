# Java: Shape

## Description
Implementation of two Java classes to represent two-dimensional objects, using inheritance between the superclass `Shape` and the concrete class `Rectangle`.

## Classes

### `Shape` (Superclass)
| Member | Type | Description |
|--------|------|--------------|
| `length` | int | Length of the shape |
| `breadth` | int | Breadth of the shape |
| `Shape(int length, int breadth)` | Constructor | Stores the values in the member variables |
| `area()` | Method | Prints `length` and `breadth` separated by a space |

### `Rectangle` (Subclass)
| Member | Type | Description |
|--------|------|--------------|
| `Rectangle(int length, int breadth)` | Constructor | Forwards the arguments to the superclass constructor |
| `area()` | Method (override) | Calls `super.area()` and prints `length * breadth` |

## Input Format
A single line containing two space-separated integers: `length` and `breadth`.

## Output Format
```
length breadth
length*breadth
```

## Examples

### Case 0
**Input:**
```
4 5
```
**Output:**
```
4 5
20
```

### Case 1
**Input:**
```
200 200
```
**Output:**
```
200 200
40000
```

## Constraints
- `0 < length ≤ 1000`
- `0 < breadth ≤ 1000`

## How to Run
```bash
javac Main.java
java Main
```
