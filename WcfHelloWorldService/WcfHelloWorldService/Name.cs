using System.Runtime.Serialization;

namespace WcfHelloWorldService
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string First;

        [DataMember]
        public string Last;
    }
}