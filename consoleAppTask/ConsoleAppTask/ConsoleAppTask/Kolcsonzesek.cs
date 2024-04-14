using System;

public class Kolcsonzesek
{
	public Kolcsonzesek()
	{

         public int Id { get; set; }
    public int KolcsonzokId { get; set; }
    public string Iro { get; set; }
    public string Mufaj { get; set; }
    public string Cim { get; set; }

    public Kolcsonzesek(int id, int kolcsonzokId, string iro, string mufaj, string cim)
    {
        Id = id;
        KolcsonzokId = kolcsonzokId;
        Iro = iro;
        Mufaj = mufaj;
        Cim = cim;
    }

    public Kolcsonzesek() { }
}
}
