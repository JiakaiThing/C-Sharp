// Mage.cs
using System;

namespace MagicalInheritance 
{
  //inheriting Title property from Pupil class
  class Mage : Pupil
  {
    public Mage(string title) : base(title)
    {
      
    }

    public Mage(string title, string origin) : base(title, origin)
    {
      
    }

    public virtual Storm CastRainStorm()
    {
      return new Storm("rain", false, Title);
    }
  }

}
