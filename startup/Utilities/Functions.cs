using SlugGenerator;

namespace startup.Utilities
{
    public class Functions
    {
        public static string TitleSlugGeneration(string type, string Title, long id)
        {
            string sTitle = type + "-" + SlugGenerator.SlugGenerator.GenerateSlug(Title) + "-" + id.ToString() + ".html";
            return sTitle;
        }
    }
}
