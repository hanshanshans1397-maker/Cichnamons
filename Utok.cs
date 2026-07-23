using System;

class Utok
{
  public string Nazev;
  public int Poskozeni;
  public string Popis;

  public Utok(string nazev, int poskozeni, string popis)
  {
      Nazev = nazev;
      Poskozeni = poskozeni;
      Popis = popis;
  }

  public int GetPoskozeni()
  {
      return Poskozeni;
  }

  public void VypisInfo()
  {
      Console.WriteLine($"  {Nazev} – poskozeni: {Poskozeni}");
  }
}
