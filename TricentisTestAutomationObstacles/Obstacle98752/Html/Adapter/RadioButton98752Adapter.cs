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

namespace Obstacle98752.Html.Adapter
{
    [SupportedTechnical(typeof(IHtmlDivTechnical))]
    public class RadioButton98752Adapter : AbstractHtmlDomNodeAdapter<IHtmlDivTechnical>, IRadioButtonAdapter
    {
        public RadioButton98752Adapter(IHtmlDivTechnical technical, Validator validator) : base(technical, validator)
        {
            validator.AssertTrue(() => technical.ClassName.Contains("radio-button "));
        }

        public string Label => "GCLabel";
        public override string DefaultName => "GCCustomRadio - " + Technical.Id;

        public bool Selected => Technical.ClassName.Contains("off") ? false : true;

        public void Select()
        {
            Technical.Click();
        }
    }
}
