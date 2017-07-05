using Tricentis.Automation.Creation;
using Tricentis.Automation.Engines;
using Tricentis.Automation.Engines.Adapters;
using Tricentis.Automation.Engines.Adapters.Attributes;
using Tricentis.Automation.Engines.Adapters.Html.Generic;
using Tricentis.Automation.Engines.Technicals.Html;

namespace Obstacle98758.Html.Adapter
{
    [SupportedTechnical(typeof(IHtmlDivTechnical))]
    public class CheckBox98758Adapter : AbstractHtmlDomNodeAdapter<IHtmlDivTechnical>, ICheckBoxAdapter
    {
        public CheckBox98758Adapter(IHtmlDivTechnical technical, Validator validator) : base(technical, validator)
        {
            validator.AssertTrue(() => technical.Id == "custom-check-box");
        }

        public string Label => string.Empty;

        public CheckState Selected
        {
            get
            {
                return Technical.ClassName.Contains("unchecked") ? CheckState.False : CheckState.True;
            }
            set
            {
                Technical.Click();
            }
        }

        public bool TriState => false;
        public override string DefaultName => "GCCheckbox - " + base.DefaultName;
    }
}