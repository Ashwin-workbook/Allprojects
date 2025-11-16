public abstract class Document
{
    public abstract void Print();
}

public abstract class DocumentCreator 
{
    public abstract Document CreateDocument();
}

public class ResumeCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Resume();
    }
}

public class ReportCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Report();
    }
}

public class Resume : Document
{
    public override void Print()
    {
        Console.WriteLine("Printing resume");
    }
}

public class Report : Document
{
    public override void Print()
    {
        Console.WriteLine("Printing Report");
    }
}

class Program 
{
    public static void Main()
    {
        DocumentCreator creator;
        creator = new ResumeCreator();
        Document doc1 = creator.CreateDocument();
        doc1.Print();

        creator = new ReportCreator();
        Document doc2 = creator.CreateDocument();
        doc2.Print();

        Console.ReadKey();
    }
}


