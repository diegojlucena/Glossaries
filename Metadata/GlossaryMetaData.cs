using System;
using System.Collections.Generic;
using MrCMS.Entities.Documents.Metadata;
using MrCMS.Web.Apps.Glossaries.Pages;

namespace MrCMS.Web.Apps.Glossaries.Metadata
{
    public class GlossaryMetaData : DocumentMetadataMap<Glossary>
    {
        public override string WebGetController
        {
            get { return "Glossary"; }
        }
        public override string IconClass
        {
            get { return "glyphicon glyphicon-book"; }
        }


        public override IEnumerable<Type> ChildrenList
        {
            get { yield break; }
        }

    }
}

