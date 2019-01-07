namespace WcfHelloWorldService
{
    public class HelloWorldService : IHelloWorld
    {
        public string SayHello(Name person)
        {
            return $"Hello {person.First} {person.Last}";
        }
    }
}