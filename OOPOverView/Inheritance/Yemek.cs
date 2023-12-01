namespace Inheritance
{
    public class Yemek
    {

        public List<string> Malzemeler { get; set; }
        public int PismeSuresi { get; set; }
        public string Ad { get; set; }
        public void Pisir()
        {
            Console.WriteLine($"{Ad} yemeği {PismeSuresi} dakikada pişti");
        }
        public virtual void SunumYap()
        {
            Console.WriteLine($"{Ad} yanında pilav ile sunuldu");
        }

    }

    public class EtYemek : Yemek
    {
        public int PismeModu { get; set; }

    }

    public class Kofte : EtYemek
    {
        public bool KasarliMi { get; set; }
    }
    public class SebzeYemegi : Yemek
    {
        public bool ZeytinyagliMi { get; set; }

    }

    public class PirasaYemegi : SebzeYemegi
    {
        public bool SogukMu { get; set; }
        public override void SunumYap()
        {
            Console.WriteLine("sadece pırasa :)");
        }
        public override string ToString()
        {
            return "Pırasanın birkaç usulü vardır....";
        }

    }

    public class Tatli : Yemek
    {
        public bool SerbetliMi { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine($"{Ad} yanında dondurma ile sunuldu");
        }
    }
    public class TulumbaTatlisi : Tatli
    {

    }



}
