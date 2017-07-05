using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricentis.Automation.Creation;
using Tricentis.Automation.Engines.Adapters;
using Tricentis.Automation.Engines.Adapters.Attributes;
using Tricentis.Automation.Engines.Adapters.Html.Generic;
using Tricentis.Automation.Engines.Technicals.Html;

namespace Obstacle98756.Html.Adapter
{
    [SupportedTechnical(typeof(IHtmlSpanTechnical))]
    public class Anchor98756Adapter : AbstractHtmlDomNodeAdapter<IHtmlSpanTechnical>, ILinkAdapter
    {
        public Anchor98756Adapter(IHtmlSpanTechnical technical, Validator validator) : base(technical, validator)
        {
            validator.AssertTrue(() => technical.ClassName.Contains("info-link"));
        }

        public string Label => Technical.InnerText;
        public override string DefaultName => "GCCustomLink";

        public string Url => string.Empty;

        public void Follow()
        {
            Technical.Click();
        }
    }
}
