namespace Proxy
{
    public interface Image
    {
        void Display();
    }

    public class RealImage : Image
    {
        private string fileName;
        public RealImage(string fileName)
        {
            this.fileName = fileName;
        }
        public void Display()
        {
            Console.WriteLine("RealImage");
        }
    }

    public class ProxyImage : Image
    {
        private string fileName;
        private RealImage? realImage;
        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
            realImage = null;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            Console.WriteLine("代理");
            realImage.Display();
        }
    }
}