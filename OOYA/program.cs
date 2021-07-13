using System;
namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("john", 7, "Budapest");
      Console.WriteLine(sam.ViewProfile());
      sam.SetHobbies(new string[] {"listening to audio books and podcasts", "playing jazz double bass", "going to art galleries", "playing sudoku"});
      Console.WriteLine(sam.ViewProfile());
    }
  }
}
