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

namespace Obstacle98754.Html.Adapter
{
    [SupportedTechnical(typeof(IHtmlDivTechnical))]
    public class Button98754Adapter : AbstractHtmlDomNodeAdapter<IHtmlDivTechnical>, IPushButtonAdapter
    {
        public Button98754Adapter(IHtmlDivTechnical technical, Validator validator) : base(technical, validator)
        {
            validator.AssertTrue(() => technical.Id == "navigationButton");
        }

        public string Label => "Next";

        public override string DefaultName => "GCButton - " + Technical.Id;

        public void Push()
        {
            Technical.Click();
        }
    }
}
