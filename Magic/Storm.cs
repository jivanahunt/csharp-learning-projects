// Storm.cs
using System;
namespace MagicalInheritance
{
  public class Storm : Spell
  {
    public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }
    public override string Announce()
    {
      string strength;
      if (IsStrong == true) { strength = "strong"; }
      else { strength = "weak"; }
      return $"{Caster} cast a {strength} {Essence} storm!";
    }
  }
}
