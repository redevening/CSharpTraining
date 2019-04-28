public class Karte
{
	KartenFarbe farbe;
	KartenWert wert;
	
	public Karte(KartenFarbe farbe, KartenWert wert)
	{
		this.farbe = farbe;
		this.wert = wert;
	}
	
	///
	/// Gibt einen String zurück, der KartenFarbe,
	/// Wert und Punktzahl beinhaltet
	///
	public override string ToString()
	{
		// TODO implement
		return "";
	}
	
	///
	/// Diese Methode returnt den wert einer Karte
	///
	public int Punkte()
	{
		// TODO implement
		return 0;
	}
		
}