using System.ServiceModel;

namespace WcfHelloWorldService
{
    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHello(Name person);
    }
}