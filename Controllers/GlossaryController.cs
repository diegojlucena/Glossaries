using System.Web.Mvc;
using MrCMS.Web.Apps.Glossaries.ModelBinders;
using MrCMS.Web.Apps.Glossaries.Models;
using MrCMS.Web.Apps.Glossaries.Pages;
using MrCMS.Web.Apps.Glossaries.Services;
using MrCMS.Website.Binders;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.Glossaries.Controllers
{
    public class GlossaryController : MrCMSAppUIController<GlossariesApp>
    {
        private readonly IGlossaryService _glossaryService;

        public GlossaryController(IGlossaryService glossaryService)
        {
            _glossaryService = glossaryService;
        }

        public ActionResult Show(Glossary page, [IoCModelBinder(typeof(GlossaryModelBinder))]GlossarySearchModel model)
        {
            ViewData["paged-glossaryItems"] = _glossaryService.GetGlossaryItems(page,model);
            return View(page);
        }
    }
}