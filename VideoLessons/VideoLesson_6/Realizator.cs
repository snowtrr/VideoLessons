using System.Security.Cryptography.X509Certificates;

namespace VideoLesson_6
{
    public class Realizator: IOne
    {
        public object Age()
        {
            return 22;
        }

        object IOne.Age()
        {
            return 17;
        }

        public object Name()
        {
            return "Anton";
        }
    }
}