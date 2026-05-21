# NotesStore — C# Challenge Solution

A class that manages a collection of notes, each with a **name** and a **state**.

---

## Valid States

| State | Valid? |
|-----------|--------|
| `active` | ✅ |
| `completed` | ✅ |
| `others` | ✅ |
| anything else | ❌ |

> State names are **case-sensitive**.

---

## Methods

### `AddNote(string state, string name)`
Adds a note to the collection.

**Throws** `Exception` if:
- `name` is empty → `"Name cannot be empty"`
- `state` is invalid → `"Invalid state {state}"`

---

### `GetNotes(string state)`
Returns a `List<string>` of note names with the given state, in insertion order.

**Throws** `Exception` if:
- `state` is invalid → `"Invalid state {state}"`

Returns an **empty list** if no notes exist for that state.

---

## Example

```csharp
var store = new NotesStore();

store.AddNote("active", "DrinkTea");
store.AddNote("active", "DrinkCoffee");
store.AddNote("completed", "Study");

store.GetNotes("active");    // ["DrinkTea", "DrinkCoffee"]
store.GetNotes("completed"); // ["Study"]
store.GetNotes("foo");       // throws Exception: "Invalid state foo"
```

---

## Sample Cases

### Case 0
**Input:**
```
AddNote active DrinkTea
AddNote active DrinkCoffee
AddNote completed Study
GetNotes active
GetNotes completed
GetNotes foo
```
**Output:**
```
DrinkTea,DrinkCoffee
Study
Error: Invalid state foo
```

---

### Case 1
**Input:**
```
AddNote active
AddNote foo Study
GetNotes completed
```
**Output:**
```
Error: Name cannot be empty
Error: Invalid state foo
No Notes
```

---

## Implementation Notes

- Notes are stored as `(state, name)` tuples in a `List<>`, preserving insertion order.
- Valid states are stored in a `HashSet<string>` for O(1) lookup.
- In `AddNote`, the empty name check runs **before** the state validation.
