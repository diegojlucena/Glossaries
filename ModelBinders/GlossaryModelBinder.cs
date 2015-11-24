using System.Web.Mvc;
using MrCMS.Web.Apps.Glossaries.Models;
using MrCMS.Website.Binders;
using Ninject;

namespace MrCMS.Web.Apps.Glossaries.ModelBinders
{
    public class GlossaryModelBinder : MrCMSDefaultModelBinder
    {
        public GlossaryModelBinder(IKernel kernel)
            : base(kernel)
        {
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int page;

            int.TryParse(GetValueFromContext(controllerContext, "page"), out page);


            var term = GetValueFromContext(controllerContext, "term");


            char? firstLetter = null;
            char tryLetter;

            if (char.TryParse(GetValueFromContext(controllerContext, "firstLetter"), out tryLetter))
            {
                firstLetter = tryLetter;
            }


            return new GlossarySearchModel
                       {
                           Page = page,
                           FirstLetter = firstLetter,
                           Term = term
                       };
        }
    }
}