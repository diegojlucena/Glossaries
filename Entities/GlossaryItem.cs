using System.ComponentModel.DataAnnotations;
using MrCMS.Entities;
using MrCMS.Web.Apps.Glossaries.Pages;

namespace MrCMS.Web.Apps.Glossaries.Entities
{
    public class GlossaryItem : SiteEntity
    {
       
        [Required]
        [MaxLength(500)]
        public virtual string Term { get; set; }

        [Required]
        public virtual string Definition { get; set; }


        public virtual Glossary Glossary { get; set; }
    }
}