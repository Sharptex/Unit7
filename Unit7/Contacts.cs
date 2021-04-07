namespace Unit7
{
    public class Contacts
    {
        private string _phoneNumber;
        private string _address;

        public Contacts(string phoneNumber, string address)
        {
            _phoneNumber = phoneNumber;
            _address = address;
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string Address
        {
            get { return _address; }
        }
    }
}