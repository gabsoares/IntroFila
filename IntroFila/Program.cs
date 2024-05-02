using IntroFila;

internal class Program
{
    private static void Main(string[] args)
    {
        FilaPessoa filaPessoa = new();

        filaPessoa.Push(new("Odair"));
        filaPessoa.Push(new("Alexa"));
        filaPessoa.Push(new("Tio Paulo"));

        filaPessoa.RunOver();
    }
}