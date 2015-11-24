using System.Web.Mvc;
using MrCMS.Web.Apps.Glossaries.Entities;
using MrCMS.Web.Apps.Glossaries.Pages;
using MrCMS.Web.Apps.Glossaries.Services;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.Glossaries.Areas.Admin.Controllers
{
    public class GlossaryItemsController : MrCMSAppAdminController<GlossariesApp> 
    {
        private readonly IGlossaryItemService _glossaryService;
        public GlossaryItemsController(IGlossaryItemService glossaryService)
        {
            _glossaryService = glossaryService;
        }

        [HttpGet]
        public PartialViewResult Add(Glossary glossaryPage)
        {
            return PartialView(new GlossaryItem { Glossary = glossaryPage });
        }

        [HttpPost]
        [ActionName("Add")]
        public RedirectToRouteResult Add_POST(GlossaryItem item)
        {
            _glossaryService.Add(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Glossary.Id });
        }

        [HttpGet]
        public PartialViewResult Edit(GlossaryItem item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Edit")]
        public RedirectToRouteResult Edit_POST(GlossaryItem item)
        {
            _glossaryService.Update(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Glossary.Id });
        }

        [HttpGet]
        public PartialViewResult Delete(GlossaryItem item)
        {
            return PartialView(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        public RedirectToRouteResult Delete_POST(GlossaryItem item)
        {
            _glossaryService.Delete(item);
            return RedirectToAction("Edit", "Webpage", new { id = item.Glossary.Id });
        }
    }
}