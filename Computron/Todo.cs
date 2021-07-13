using System;
namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }
    public string Header
    {
      get { return "Todos\n--------"; }
    }
    private int nextOpenIndex;
    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
    public void Add(string todo)
    {
      if (nextOpenIndex < 5)
      {
        Todos[nextOpenIndex] = todo;
        nextOpenIndex++;
      }
      else
      {
        Console.WriteLine("ERROR! You cannot have more than 5 to-dos in your list. You will be overwhelmed!");
      }
    }
    public void Display()
    {
      foreach (string todo in Todos)
      {
        if (string.IsNullOrEmpty(todo))
        {
          Console.WriteLine("[]");
        }
        else
        {
          Console.WriteLine(todo);
        }
      }
    }
    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
  }
}
