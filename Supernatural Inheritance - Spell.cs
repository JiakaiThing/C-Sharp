// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm : Spell
  {
    /* don't need this anymore as it has been defined in the Spell class. Has been inherited from the Spell class
    public string Essence
    { get; private set; }
    
    public bool IsStrong
    { get; private set; }

    public string Caster
    { get; private set; }
    */

    //Storm s = new Storm("wind", true, "your name")
    public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    public override string Announce()
    {
      if(IsStrong == true)
      {
        return $"{Caster} casts a strong {Essence} storm!";
      }
      else
      {
        return $"{Caster} casts a weak {Essence} storm!";
      }
    }

  }

}
