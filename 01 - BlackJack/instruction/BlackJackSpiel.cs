using System;

///
/// Diese Klasse beinhaltet die Spiel Logik
///
public class BlackJackSpiel
{
	KartenDeck KartenDeck;
	static short maximalKartenProSpieler = 6;
	Karte[] SpielerKarten = new Karte[maximalKartenProSpieler];
	Karte[] DealerKarten = new Karte[maximalKartenProSpieler];

	public BlackJackSpiel()
	{
		this.KartenDeck = new KartenDeck();
	}
	
	///
	/// In dieser Methode befindet sich die Haupt Logik
	///
	public void spiele()
	{
		// TODO implement

		// Gib dem Spieler eine Karte
		// Teile dem Spieler mit, welche Karte er gezogen hat

		// Gib dem Dealer eine Karte
		// Teile dem Spieler mit, welche Karte er gezogen hat

		// Gib dem Spieler eine zweite Karte
		// Teile dem Spieler mit, welche Karte er gezogen hat

		// Gib dem Dealer eine zweite Karte
		// Teile dem Spieler *nicht* mit, welche Karte er gezogen hat
		// Wenn der Dealer das nächste mal an der Reihe ist, teilt er
		// dem Spieler mit, welche Karte er gezogen hat

		// Dealer und Spieler sind abwechselnd am Zug
		// Spieler zieht solange er will
		// Dealer zieht immer, wenn er weniger als 17 Punkte hat

		// Das Spiel ist vorbei, wenn Spieler oder Dealer > 21 Punkte haben
		// oder wenn der Spieler keine Karte mehr ziehen will

	}
	
	///
	/// Gibt true zurück, wenn das Spiel vorbei ist, false ansonsten
	///
	bool überprüfeSpielEnde()
	{
		// TODO implement
		return false;
	}

	///
	/// Gibt die Anzahl der Punkte zurück,
	/// die die übergebenen Karten besitzen
	///
	int berechnePunkte(Karte[] karten)
	{
		// TODO implement
		return 0;
	}
}