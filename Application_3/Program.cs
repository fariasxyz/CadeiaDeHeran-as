internal class Program
{
    private static void Main(string[] args)
    {
      A objA = new A();
      B objB = new B();
      C objC = new C();

        objA.Falar(); // Classe A está falando.
        objB.Falar(); // Classe B está falando.
        objC.Falar(); // Classe C está falando.
    }
}