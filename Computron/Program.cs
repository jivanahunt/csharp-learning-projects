using System;
namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      Console.WriteLine(tdl.Header);
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      tdl.Add("Stretch");
      tdl.Add("Get dressed");
      tdl.Add("Eat a sandwich");
      tdl.Display();
      tdl.Reset();
      tdl.Display();
      PasswordManager pm = new PasswordManager("iluvpie", false);
      Console.WriteLine(pm.Header);
      pm.Display();
      // pm.Reset();
      pm.Display();
      Console.WriteLine(pm.ChangePassword("iluvpieed", "iluvcheese"));
      pm.Display();
    }
  }
}
