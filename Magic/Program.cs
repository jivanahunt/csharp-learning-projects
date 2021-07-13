using System;
namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm[] magicians = new Storm[6];
      
      Pupil p = new Pupil("Harry", "England");
      magicians[0] = p.CastWindStorm();
      
      Mage m = new Mage("Snape");
      magicians[1] = m.CastRainStorm();
      magicians[2] = m.CastWindStorm();
      
      ArchMage aM = new ArchMage("Dumbledore", "Iceland");
      magicians[3] = aM.CastRainStorm();
      magicians[4] = aM.CastWindStorm();
      magicians[5] = aM.CastLightningStorm();
      foreach (Storm magician in magicians)
      { Console.WriteLine(magician.Announce()); }
    }
  }
}
