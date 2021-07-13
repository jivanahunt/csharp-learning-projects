// Mage.cs
using System;
namespace MagicalInheritance
{
  public class Mage : Pupil
  {
    public Mage(string title) : base(title)
    {}
    public Mage(string title, string origin) : base(title, origin)
    {}
    public virtual Storm CastRainStorm()
    {
      Storm s = new Storm("rain", false, Title);
      return s;
    }
  }
}
