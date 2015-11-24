using System;
using MrCMS.Helpers;
using MrCMS.Paging;
using MrCMS.Web.Apps.Glossaries.Entities;
using MrCMS.Web.Apps.Glossaries.Models;
using MrCMS.Web.Apps.Glossaries.Pages;
using NHibernate;
using NHibernate.Criterion;

namespace MrCMS.Web.Apps.Glossaries.Services
{
    public class GlossaryItemService : IGlossaryItemService
    {
        private readonly ISession _session;

        public GlossaryItemService(ISession session)
        {
            _session = session;
        }

        public void Add(GlossaryItem item)
        {
            _session.Transact(session => session.Save(item));
        }

        public void Update(GlossaryItem item)
        {
            _session.Transact(session => session.Update(item));
        }

        public void Delete(GlossaryItem item)
        {
            _session.Transact(session => session.Delete(item));
        }

        public IPagedList<GlossaryItem> GetGlossaryItems(Glossary page, GlossarySearchModel model)
        {
            var query = _session.QueryOver<GlossaryItem>()
                                .Where(a => a.Glossary == page);

            if (!String.IsNullOrEmpty(model.Term))
            {
                query = query.Where(m => m.Term.IsInsensitiveLike(model.Term, MatchMode.Anywhere));
            }

            if (model.FirstLetter.HasValue)
            {
                query =
                    query.Where(
                        item => item.Term.IsInsensitiveLike(model.FirstLetter.ToString(), MatchMode.Start));
            }
           

            return query.OrderBy(x => x.Term).Asc.Paged(model.Page, page.PageSize);
        }

       
    }
}