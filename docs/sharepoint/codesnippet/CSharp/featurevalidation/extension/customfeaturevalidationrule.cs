//<Snippet1>
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Validation;
using System.ComponentModel.Composition;

namespace Extension
{
    [Export(typeof(IFeatureValidationRule))]
    internal class CustomFeatureValidationRule : IFeatureValidationRule
    {
        public void ValidateFeature(IFeatureValidationContext context)
        {
            foreach (var projectItem in context.Feature.ProjectItems)
            {
                ValidateProjectItem(context, projectItem);
            }
        }

        public void ValidateProjectItem(
            IFeatureValidationContext context,
            ISharePointProjectItem projectItem)
        {
            if (projectItem.Name == "")
            {
                context.RuleViolations.Add(
                    "CustomFeatureValidationRule001",
                    ValidationRuleViolationSeverity.Warning,
                    "SharePoint project items must have a name.");
            }
        }
    }
}
//</Snippet1>

