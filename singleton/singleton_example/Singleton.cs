namespace singleton_example
{
    public class Singleton
    {
        private static Singleton _instance;

        private static object lockObject = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public string Info()
        {
            return "Singleton instance";
        }
    }
}
