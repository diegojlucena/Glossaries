
namespace MrCMS.Web.Apps.Glossaries.Models
{
    public class GlossarySearchModel
    {
        public GlossarySearchModel()
        {
            Page = 1;
        }
        public int Page { get; set; }

        public string Term { get; set; }

        public char? FirstLetter { get; set; }
    }
}