// Pupil.cs
using System;
namespace MagicalInheritance
{
  public class Pupil
  {
    public string Title
    { get; private set; }
    public string Origin
    { get; private set; }
    public Pupil(string title)
    {
      this.Title = title;
    }
    public Pupil(string title, string origin) : this(title)
    {
      this.Title = title;
      this.Origin = origin;
    }
    public Storm CastWindStorm()
    {
      Storm s = new Storm("wind", false, Title);
      return s;
    }
  }
}
