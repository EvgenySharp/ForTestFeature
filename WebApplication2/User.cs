using System.Data;

namespace WebApplication2
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DataSetDateTime Data {  get; set; }
        public string Email { get; set; }
        public  string PhonNumber { get; set; }
        public string Address { get; set; }
    }
}
