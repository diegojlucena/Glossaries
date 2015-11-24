using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MrCMS.Entities.Documents.Web;

namespace MrCMS.Web.Apps.Glossaries.Pages
{
    public class Glossary : Webpage
    {
        [DisplayName("Page Size")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Page size must be a number")]
        [Range(1, 9999)]
        public virtual int PageSize { get; set; }

    }
}