using System;
using System.Collections.Generic;

class Program
{
  static Random rng = new Random();

  static void Main()
  {
      Console.WriteLine("Vítej v Cichnamon Arene!");
      Console.Write("Zadej sve jmeno: ");
      string jmenoHrace = Console.ReadLine();

      Trener hrac = new Trener(jmenoHrace);
      Trener pocitac = new Trener("Pocitac");


      Cichnamon ohnosko = new Cichnamon("Eduard Ohnosko", 100, 5,
          new Utok("Známka z ohně", 15, "Ohnosko vypaluje znamku primo do duse!"),
          new Utok("Hoska v plamenech", 30, "Ohnosko se vznítil a sežehl vsechno kolem!"));


      Cichnamon skalka = new Cichnamon("Skalka Skalnaty", 120, 3,
          new Utok("Kamenný test", 12, "Skalka hodi tezky test primo do obliceje!"),
          new Utok("Lavina úkolů", 28, "Skalka spousti nekonecnou lavinu ukolu!"));


      Cichnamon rakosnicek = new Cichnamon("Rákosníček", 95, 7,
          new Utok("Mokry rukav", 16, "Rakosnicek pleskne mokrym rukavem!"),
          new Utok("Bahno z rybníka", 32, "Rakosnicek te pohltí bahnem!"));


      Cichnamon hroznyman = new Cichnamon("Jan Hroznyman", 110, 4,
          new Utok("Hrózný pohled", 13, "Hroznyman te prorte svym nezapomenutelnym pohledem!"),
          new Utok("Grossman kombo", 29, "Hroznyman spousti legendarni kombo ukolu a zkoušek!"));


      Cichnamon vojtkulak = new Cichnamon("Vojtkulak", 105, 6,
          new Utok("Pěstní rovnice", 14, "Vojtkulak te udeří rovnici primo do mozku!"),
          new Utok("Kulacky z fyziky", 31, "Vojtkulak spousti krupobiti fyzikalnich prikladu!"));

      hrac.PridejCichnamona(ohnosko);
      hrac.PridejCichnamona(skalka);
      hrac.PridejCichnamona(rakosnicek);
      hrac.PridejCichnamona(hroznyman);
      hrac.PridejCichnamona(vojtkulak);


      Console.WriteLine("\nVyber si sveho Cichnamona:");
      for (int i = 0; i < hrac.Cichnamoni.Count; i++)
      {
          Console.Write($"{i + 1} - ");
          hrac.Cichnamoni[i].VypisInfo();
      }
      Console.Write("Tvoje volba: ");
      int volba = int.Parse(Console.ReadLine()) - 1;
      hrac.VyberCichnamona(volba);
      Console.WriteLine($"Vybral sis: {hrac.AktualniCichnamon.Jmeno}");


      Cichnamon zlomysl = new Cichnamon("Zlomysl", 100, 4,
          new Utok("Temny uder", 14, "Zlomysl uderil temnou silou!"),
          new Utok("Prokletí", 27, "Zlomysl seslal prokletí!"));
      pocitac.PridejCichnamona(zlomysl);
      pocitac.VyberCichnamona(0);
      Console.WriteLine($"Protivnik je: {pocitac.AktualniCichnamon.Jmeno}\n");


      bool hracNaTahu = true;

      while (hrac.AktualniCichnamon.JeNazivu() && pocitac.AktualniCichnamon.JeNazivu())
      {
          if (hracNaTahu)
          {
              Console.WriteLine("\n--- TVUJ TAH ---");
              Console.WriteLine($"Ty: {hrac.AktualniCichnamon.Jmeno} | HP: {hrac.AktualniCichnamon.Zdravi}/{hrac.AktualniCichnamon.MaxZdravi}");
              Console.WriteLine($"Protivnik: {pocitac.AktualniCichnamon.Jmeno} | HP: {pocitac.AktualniCichnamon.Zdravi}/{pocitac.AktualniCichnamon.MaxZdravi}");
              Console.WriteLine($"1 - Zakladni utok: {hrac.AktualniCichnamon.ZakladniUtok.Nazev}");
              Console.WriteLine($"2 - Specialni utok: {hrac.AktualniCichnamon.SpecialniUtok.Nazev}");
              Console.WriteLine("3 - Leceni (+30 HP)");
              Console.Write("Tvoje volba: ");
              string tah = Console.ReadLine();

              if (tah == "1")
                  hrac.AktualniCichnamon.ProvedZakladniUtok(pocitac.AktualniCichnamon);
              else if (tah == "2")
                  hrac.AktualniCichnamon.ProvedSpecialniUtok(pocitac.AktualniCichnamon);
              else if (tah == "3")
                  hrac.AktualniCichnamon.Uzdravi(30);
              else
                  Console.WriteLine("Neplatna volba, preskakuji tah.");
          }
          else
          {
              Console.WriteLine("\n--- TAH POCITACE ---");
              int tahPocitace = rng.Next(0, 2);
              if (tahPocitace == 0)
                  pocitac.AktualniCichnamon.ProvedZakladniUtok(hrac.AktualniCichnamon);
              else
                  pocitac.AktualniCichnamon.ProvedSpecialniUtok(hrac.AktualniCichnamon);
          }

          hracNaTahu = !hracNaTahu;
      }


      Console.WriteLine("\n--- KONEC SOUBOJE ---");
      if (hrac.AktualniCichnamon.JeNazivu())
          Console.WriteLine($"{hrac.Jmeno} vyhral! Gratulace!");
      else
          Console.WriteLine("Prohral jsi. Nevzdavej to!");

      Console.WriteLine("\nStav tveho Cichnamona:");
      hrac.AktualniCichnamon.VypisInfo();
  }
}

