using System.IO;
using Razor;

namespace FridgeApp
{
    public class FridgePage
    {
        public Fridge Fridge { get; set; }

        public FridgePage(Fridge fridge)
        {
            Fridge = fridge;
        }

        public void Render(string path)
        {
            string html = Razor.Parse(File.ReadAllText("template.cshtml"), this);
            File.WriteAllText(path, html);
        }
    }
}
