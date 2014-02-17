using System.Collections.Generic;
using MrCMS.Entities.Documents.Web;
using MrCMS.Entities.Indexes;
using MrCMS.Indexing.Management;

namespace MrCMS.Indexing.Definitions
{
    public class MetaDescriptionFieldDefinition : StringFieldDefinition<WebpageIndexDefinition, Webpage>
    {
        public MetaDescriptionFieldDefinition(ILuceneSettingsService luceneSettingsService)
            : base(luceneSettingsService, "metadescription")
        {
        }

        protected override IEnumerable<string> GetValues(Webpage obj)
        {
            yield return obj.MetaDescription;
        }
    }
}