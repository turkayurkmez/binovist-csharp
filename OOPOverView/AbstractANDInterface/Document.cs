namespace AbstractANDInterface
{

    public interface IPrintable
    {
        void Print();
    }

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
        //public abstract void Print();

    }

    public class PDFDocument : Document
    {
        public override void Load()
        {
            Console.WriteLine("Pdf açıldı");
        }



        public override void Save()
        {
            Console.WriteLine("Pdf kaydedildi");

        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class SaveDocument
    {

        public void Save(Document document)
        {
            document.Save();
        }

    }

    public class Printer
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }



}
