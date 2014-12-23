namespace SimpleProxy
{
    public class ProtectionProxy:ISubject
    {
        Subject subject;

        string password = "Abrakadabra";

        public string Authenticate(string supplied)
        {
            if(supplied != password)
            {
                return "Protection Proxy :No access";
            }
            else
            {
                subject = new Subject();

                return "Protection Proxy :Authenticated";
            }
        }
        public string Request()
        {
            if(subject==null)
            {
                return "Protection proxy: Authenticate first ";
            }
            else
            {
                return "Protection proxy: Call to " + subject.Request();
            }
        }
    }
}
