internal class Program
{
    private static void Main(string[] args)
    {

        Yonetici y1 = new Yonetici("Mehmet");
        Tasarimci t1 = new Tasarimci("Ezel");
        Gelistirici g1 = new Gelistirici("Eyşan");
        Gelistirici g2 = new Gelistirici("Tefo");

        Ekip e1 = new Ekip(y1);
        e1.ekle(t1);
        e1.ekle(g1);
        e1.ekle(g2);
        e1.bilgiGoster();

        Yonetici y2 = new Yonetici("Holt");
        Tasarimci t2 = new Tasarimci("Peralta");
        Gelistirici g12 = new Gelistirici("Santiago");
        Gelistirici g22 = new Gelistirici("Boyle");

        Ekip e2 = new Ekip(y2);
        e2.ekle(t2);
        e2.ekle(g2);
        e2.ekle(g22);
        e2.bilgiGoster();

    }
}

abstract class Personel
{
    private string name;

    protected Personel() { }

    protected Personel(string name) {
        Name = name;
    }

    public string Name { get => name; set => name = value; }

    public virtual void bilgiGoster() { }
}

class Ekip : Personel
{
    private Personel personel;
    List<Personel> Personellist;

  
   

    public Ekip(Personel personel)
    {
        Personel = personel;
        Name=Personel.Name;
        Personellist1= new List<Personel>();
    }
    internal Personel Personel { get => personel; set => personel = value; }
    internal List<Personel> Personellist1 { get => Personellist; set => Personellist = value; }

    public void ekle(Personel p) { 
    Personellist.Add(p);
    }
    public void sil(Personel p ){
    Personellist.Remove(p);
    }
    public override void bilgiGoster() {

        Console.WriteLine("Isim: "+Name);

        foreach(Personel p in Personellist)
        {
            Console.WriteLine("-->Isim: "+p.Name);
        }
        Console.WriteLine("***********");

    }
}

class Yonetici : Personel
{
    public Yonetici(string name) : base(name)
    {
    }

    public override void bilgiGoster()
    {
        Console.WriteLine("İsim: "+Name);
    }

   
}
class Gelistirici : Personel
{
    public Gelistirici(string name) : base(name)
    {
    }

    public override void bilgiGoster()
    {
        Console.WriteLine("İsim: " + Name );
    }
}

class Tasarimci : Personel
{
    public Tasarimci(string name) : base(name)
    {
    }

    public override void bilgiGoster()
    {
        Console.WriteLine("İsim: " + Name);
    }
}