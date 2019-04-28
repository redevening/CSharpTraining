public class Karte
{
	KartenFarbe farbe;
	KartenWert wert;
	
	public Karte(KartenFarbe farbe, KartenWert wert)
	{
		this.farbe = farbe;
		this.wert = wert;
	}
	
	public override string ToString()
	{
		return farbe + " " + wert + " (" + this.Punkte() + ")";
	}
	
	public int Punkte()
	{
		switch(this.wert)
		{
			case KartenWert.Bube:
			case KartenWert.Dame:
			case KartenWert.König:
			case KartenWert.Ass:
				return 10;
			default:
				return (int) this.wert;
		}
	}
		
}