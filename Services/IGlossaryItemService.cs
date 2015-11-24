using MrCMS.Paging;
using MrCMS.Web.Apps.Glossaries.Entities;
using MrCMS.Web.Apps.Glossaries.Models;
using MrCMS.Web.Apps.Glossaries.Pages;

namespace MrCMS.Web.Apps.Glossaries.Services
{
    public interface IGlossaryItemService
    {
        void Add(GlossaryItem item);
        void Update(GlossaryItem item);
        void Delete(GlossaryItem item); 
        IPagedList<GlossaryItem> GetGlossaryItems(Glossary page, GlossarySearchModel model);     
    }
}
