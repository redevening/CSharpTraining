using System;

public class KartenDeck
{
	static int DeckGröße = 52;
	Karte[] Deck = new Karte[DeckGröße];
	int AnzahlGezogenerKarten = 0;
	
	
	public KartenDeck()
	{
		int counter = 0;
		for(int i = 0; i < 4; i++)
		{
			KartenFarbe farbe = (KartenFarbe) i;
			for(int j = 2; j < 15; j++)
			{
				KartenWert wert = (KartenWert) j;
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