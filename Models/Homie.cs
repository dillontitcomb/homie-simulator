using System.Collections.Generic;
using System;

namespace LilHomie.Models
{
  public class Homie
  {
    private int _rest;
    private int _hunger;
    private int _joy;

    public static List<Homie> Homies = new List<Homie> {};

    public Homie (int rest, int hunger, int joy)
    {
      _rest = rest;
      _hunger = hunger;
      _joy = joy;
    }

    public void Save ()
    {
      Homies.Add(this);
    }

    public void SelectRest()
    {
      _rest += 3;
      _hunger -= 2;
      _joy -= 2;
    }

    public void SelectHunger()
    {
      _rest -= 3;
      _hunger = _hunger + 2;
      _joy = _joy - 3;
    }

    public void SelectJoy()
    {
      _rest = _rest - 3;
      _hunger = _hunger - 3;
      _joy = _joy + 2;
    }

    public int GetRest()
    {
      return _rest;
    }

    public int GetHunger()
    {
      return _hunger;
    }

    public int GetJoy()
    {
      return _joy;
    }

  }
}
