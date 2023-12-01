namespace AbstractANDInterface
{
    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine("kopyalandı");
        }

        public void Move(string from, string to)
        {
            Console.WriteLine("taşındı");
        }

        public abstract void Save();
        public abstract void Load();

        public abstract void Print();

    }

    public class PDFDocument : Document
    {

    }



}
