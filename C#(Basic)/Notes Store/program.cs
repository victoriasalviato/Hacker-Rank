using System;
using System.Collections.Generic;
using System.Linq;

public class NotesStore
{
    private static readonly HashSet<string> ValidStates = new HashSet<string> { "completed", "active", "others" };
    private List<(string state, string name)> notes = new List<(string, string)>();

    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("Name cannot be empty");

        if (!ValidStates.Contains(state))
            throw new Exception($"Invalid state {state}");

        notes.Add((state, name));
    }

    public List<string> GetNotes(string state)
    {
        if (!ValidStates.Contains(state))
            throw new Exception($"Invalid state {state}");

        return notes.Where(n => n.state == state).Select(n => n.name).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Trim());
        var store = new NotesStore();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine().Trim();
            string[] parts = line.Split(' ');
            string command = parts[0];

            try
            {
                if (command == "AddNote")
                {
                    string state = parts[1];
                    string name = parts.Length > 2 ? parts[2] : "";
                    store.AddNote(state, name);
                }
                else if (command == "GetNotes")
                {
                    string state = parts[1];
                    List<string> result = store.GetNotes(state);
                    if (result.Count == 0)
                        Console.WriteLine("No Notes");
                    else
                        Console.WriteLine(string.Join(",", result));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
