
class Cichnamon
{
  public string Jmeno;
  public int Zdravi;
  public int MaxZdravi;
  public int BonusUtok;
  public Utok ZakladniUtok;
  public Utok SpecialniUtok;
  private bool UzdraveniPouzito = false;
  private int TahyOdSpecialniho = 2;

  public Cichnamon(string jmeno, int zdravi, int bonusUtok, Utok zakladni, Utok specialni)
  {
      Jmeno = jmeno;
      Zdravi = zdravi;
      MaxZdravi = zdravi;
      BonusUtok = bonusUtok;
      ZakladniUtok = zakladni;
      SpecialniUtok = specialni;
  }

  public void ProvedZakladniUtok(Cichnamon protivnik)
  {
      int poskozeni = ZakladniUtok.GetPoskozeni() + BonusUtok;
      Console.WriteLine($"{Jmeno} pouzil {ZakladniUtok.Nazev}!");
      Console.WriteLine($"{ZakladniUtok.Popis}");
      protivnik.SnizZdravi(poskozeni);
      TahyOdSpecialniho++;
  }

  public void ProvedSpecialniUtok(Cichnamon protivnik)
  {
      if (TahyOdSpecialniho < 2)
      {
          Console.WriteLine("Specialni utok lze pouzit az kazdy druhy tah! Pouzivam zakladni.");
          ProvedZakladniUtok(protivnik);
          return;
      }
      int poskozeni = SpecialniUtok.GetPoskozeni() + BonusUtok;
      Console.WriteLine($"{Jmeno} pouzil {SpecialniUtok.Nazev}!");
      Console.WriteLine($"{SpecialniUtok.Popis}");
      protivnik.SnizZdravi(poskozeni);
      TahyOdSpecialniho = 0;
  }

  public void SnizZdravi(int poskozeni)
  {
      Zdravi -= poskozeni;
      if (Zdravi < 0) Zdravi = 0;
      Console.WriteLine($"{Jmeno} ztratil {poskozeni} zivotu. Zbýva: {Zdravi}/{MaxZdravi}");
  }

  public void Uzdravi(int pocet)
  {
      if (UzdraveniPouzito)
      {
          Console.WriteLine("Uzdraveni uz bylo pouzito!");
          return;
      }
      Zdravi += pocet;
      if (Zdravi > MaxZdravi) Zdravi = MaxZdravi;
      Console.WriteLine($"{Jmeno} se uzdravil o {pocet} zivotu. Zbýva: {Zdravi}/{MaxZdravi}");
      UzdraveniPouzito = true;
  }

  public bool JeNazivu()
  {
      return Zdravi > 0;
  }

  public void VypisInfo()
  {
      Console.WriteLine($"{Jmeno} | Zdravi: {Zdravi}/{MaxZdravi} | Bonus utok: +{BonusUtok}");
      Console.Write("  Zakladni: "); ZakladniUtok.VypisInfo();
      Console.Write("  Specialni: "); SpecialniUtok.VypisInfo();
  }
}

