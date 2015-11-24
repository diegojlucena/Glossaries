using MrCMS.Entities;
using MrCMS.Entities.Documents.Web;
using MrCMS.Helpers;
using MrCMS.Paging;
using MrCMS.Website;
using NHibernate;
using NHibernate.Criterion;

namespace MrCMS.Web.Apps.Glossaries.Helpers
{
    public static class WebpageExtensions
    {

        public static IPagedList<T> PagedChildrenSiteEntity<T>(this Webpage webpage, QueryOver<T> query, int pageNum = 1,
            int pageSize = 10) where T : SiteEntity
        {
            return MrCMSApplication.Get<ISession>().Paged(query, pageNum, pageSize);
        }
    }
}