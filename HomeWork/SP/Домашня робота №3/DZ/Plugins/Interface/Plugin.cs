using System.Drawing;


namespace Interface
{
    public interface IPlugin
    {
        string Name { get; }
        string Version { get; }
        string Author { get; }
        void Transform(IMainApp app);
    }


    public interface IMainApp
    {
        Bitmap Image { get; set; }
    }
}