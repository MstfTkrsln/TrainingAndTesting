using System.Runtime.Serialization;

namespace SurrogeteLibrary
{
    [DataContract]
    public class SurrogateProduct
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public int? CategoryId { get; set; }
    }
}
