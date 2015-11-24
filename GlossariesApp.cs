using MrCMS.Apps;
using Ninject;

namespace MrCMS.Web.Apps.Glossaries
{
    public class GlossariesApp : MrCMSApp
    {
        public override string AppName
        {
            get { return "Glossaries"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        protected override void RegisterServices(IKernel kernel)
        {
            
        }

        protected override void RegisterApp(MrCMSAppRegistrationContext context)
        {
        }
    }
}