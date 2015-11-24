using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using MrCMS.DbConfiguration.Types;
using MrCMS.Web.Apps.Glossaries.Entities;

namespace MrCMS.Web.Apps.Glossaries.DbConfiguration
{
    public class GlossaryItemOverride : IAutoMappingOverride<GlossaryItem>
    {
        public void Override(AutoMapping<GlossaryItem> mapping)
        {
            mapping.Map(m => m.Definition).CustomType<VarcharMax>().Length(4001);
            mapping.Map(m => m.Term).Length(500);

        }
    }
}