using System;

public class BlackJackSpiel
{
	KartenDeck KartenDeck;
	Karte[] SpielerKarten = new Karte[10];
	int SpielerPunkte = 0;
	Karte[] DealerKarten = new Karte[10];
	int DealerPunkte = 0;

	public BlackJackSpiel()
	{
		this.KartenDeck = new KartenDeck();
	}
	
	public void spiele()
	{
		Console.WriteLine("Ziehe eine Karte:");
		Console.ReadLine();
		SpielerKarten[0] = this.KartenDeck.zieheKarte();
		SpielerPunkte += SpielerKarten[0].Punkte();
		Console.WriteLine("Du hast " + SpielerKarten[0] + " gezogen");
		
		Console.WriteLine("Das Casino zieht eine Karte:");
		Console.ReadLine();
		DealerKarten[0] = this.KartenDeck.zieheKarte();
		DealerPunkte += DealerKarten[0].Punkte();
		Console.WriteLine("Das Casino hat " + DealerKarten[0] + " gezogen");
		
		Console.WriteLine("Ziehe eine Karte:");
		Console.ReadLine();
		SpielerKarten[1] = this.KartenDeck.zieheKarte();
		SpielerPunkte += SpielerKarten[1].Punkte();

		Console.WriteLine("Du hast " + SpielerKarten[1] + " gezogen");
		
		Console.WriteLine("Das Casino zieht eine Karte:");
		Console.ReadLine();
		DealerKarten[1] = this.KartenDeck.zieheKarte();
		DealerPunkte += DealerKarten[1].Punkte();

		Console.WriteLine("Die Karte, die das Casino gezogen hat, bleibt geheim.");
		
		string antwort = "";
		int spielerZähler = 1;
		int dealerZähler = 1;
		
		Console.WriteLine("Du hast folgende Karten: " + String.Join<Karte>(", ", SpielerKarten));
		Console.WriteLine("Willst du eine weitere Karte ziehen? Ja/Nein?");
		antwort = Console.ReadLine();

		bool spielEnde = false;
		while(antwort.ToLower().Equals("ja") && !spielEnde)
		{
			spielerZähler++;
			SpielerKarten[spielerZähler] = this.KartenDeck.zieheKarte();
			SpielerPunkte += SpielerKarten[spielerZähler].Punkte();
		    Console.WriteLine("Du hast " + SpielerKarten[spielerZähler++] + " gezogen");
			spielEnde = überprüfeSpielEnde();
			
			if(DealerPunkte < 17 && !spielEnde){
				Console.WriteLine("Das Casino zieht eine Karte:");
		 		Console.ReadLine();
				dealerZähler++;
				DealerKarten[dealerZähler] = this.KartenDeck.zieheKarte();
				DealerPunkte += DealerKarten[dealerZähler].Punkte();
				Console.WriteLine("Das Casino hat " + DealerKarten[dealerZähler] + " gezogen");
       			spielEnde = überprüfeSpielEnde();

			}
			else
			{
				Console.WriteLine("Das Casino zieht keine Karten mehr!");
			}

            if(!spielEnde)
            {
       		    Console.WriteLine("Du hast folgende Karten: " + String.Join<Karte>(", ", SpielerKarten));
	    	    Console.WriteLine("Willst du eine weitere Karte ziehen? Ja/Nein?");
		        antwort = Console.ReadLine();
            }
		}
		
		Console.WriteLine("Das Spiel ist vorbei, doch wer hat gewonnen?");
		Console.ReadLine();
		Console.WriteLine("Du hast folgende Karten: " + String.Join<Karte>(", ", SpielerKarten));
		Console.WriteLine("Das Casino hat folgende Karten: " + String.Join<Karte>(", ", DealerKarten));

        if(SpielerPunkte > 21){
            Console.WriteLine("Du hast mit " + SpielerPunkte + " mehr als 21 Punkte! Du hast verloren");
            return;
        }
        else if(DealerPunkte > 21)
        {
            Console.WriteLine("Das Casino hat mit " + DealerPunkte + " mehr als 21 Punkte! Du hast gewonnen!");
            return;
        }	

		if(SpielerPunkte > DealerPunkte)
		{
			Console.WriteLine("Du hast mit " + SpielerPunkte + " Punkten gewonnen!");
			Console.WriteLine("Das Casino hat nur " + DealerPunkte + " Punkte.");
		}
		else if(SpielerPunkte == DealerPunkte)
		{
			Console.WriteLine("Es ist unentschieden! Beide Parteien haben " + SpielerPunkte + " Punkte! ");
		}
		else
		{
			Console.WriteLine("Das Casino hat mit " + DealerPunkte + " Punkten gewonnen!");
			Console.WriteLine("Du hast nur " + SpielerPunkte + " Punkte.");
		}
	}
	
	bool überprüfeSpielEnde()
	{
		if(SpielerPunkte > 21 || DealerPunkte > 21)
		{
			return true;
		}
        return false;
	}
}