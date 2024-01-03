using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;
      
      /* Won't be using this anymore, will instead use the one below as it is in an array and will go through the array. 
      Console.WriteLine not needed as well as it will iterate through the array and calling .Announce on each elements as each elements stored in the array is an instance of the class Storm.
      Storm has access to the Announce method. We can call .Announce on each element of the array.
      Storm windStorm = p.CastWindStorm();
      Console.WriteLine(windStorm.Announce());
      */
      Pupil p = new Pupil("Mezil-kree", "Icecrown");
      //storms[0]
      storms[stormsIndex] = p.CastWindStorm();
      stormsIndex++;  //so the index goes to the next one and current data won't be overwritten by the next set of data

      Mage m = new Mage("Gul'dan", "Draenor");
      //storms[1]
      storms[stormsIndex] = m.CastRainStorm();
      stormsIndex++;

      Archmage a = new Archmage("Nielas Aran", "Stormwind");
      //storms[2]
      storms[stormsIndex] = a.CastWindStorm();
      stormsIndex++;
      //storms[3]
      storms[stormsIndex] = a.CastRainStorm();
      stormsIndex++;
      //storms[4]
      storms[stormsIndex] = a.CastLightningStorm();
      stormsIndex++;

      //for loop to iterate over all the elements of storms array, each element in there will have acces to .Announce property as each elements is a data type of storm
      for(int i = 0; i < stormsIndex; i++)
      {
        //storms[0]
        Console.WriteLine(storms[i].Announce());
      }

    }
  }
  
}
