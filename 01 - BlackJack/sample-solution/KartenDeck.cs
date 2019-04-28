using System;

public class KartenDeck
{
	static int DeckGröße = 52;
	Karte[] Deck = new Karte[DeckGröße];
	int AnzahlGezogenerKarten = 0;
	
	
	public KartenDeck()
	{
		int counter = 0;
		foreach (KartenFarbe farbe in (KartenFarbe[]) Enum.GetValues(typeof(KartenFarbe)))
		{
			foreach(KartenWert wert in (KartenWert[]) Enum.GetValues(typeof(KartenWert)))
			{
				Deck[counter] = new Karte(farbe, wert);
				counter++;
			}
		}
		
		// Deck mischen
		Random random = new Random();
		int n = DeckGröße - 1;
		while (n > 1) 
        {
            int k = random.Next(n--);
            Karte temp = Deck[n];
            Deck[n] = Deck[k];
            Deck[k] = temp;
        }
		
	}
	
	public Karte zieheKarte()
	{		
		Karte gezogeneKarte = Deck[AnzahlGezogenerKarten];
		Deck[AnzahlGezogenerKarten] = null;
		AnzahlGezogenerKarten = AnzahlGezogenerKarten + 1;
		return gezogeneKarte;
	}
}