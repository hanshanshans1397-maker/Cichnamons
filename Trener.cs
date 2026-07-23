class Trener
{
  public string Jmeno;
  public List<Cichnamon> Cichnamoni = new List<Cichnamon>();
  public Cichnamon AktualniCichnamon;

  public Trener(string jmeno)
  {
      Jmeno = jmeno;
  }

  public void PridejCichnamona(Cichnamon c)
  {
      Cichnamoni.Add(c);
  }

  public void VyberCichnamona(int index)
  {
      AktualniCichnamon = Cichnamoni[index];
  }
}
