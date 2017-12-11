'<Snippet1>
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Validation
Imports System.ComponentModel.Composition

<Export(GetType(IFeatureValidationRule))> _
Public Class CustomFeatureValidationRule
    Implements IFeatureValidationRule

    Public Sub ValidateFeature(ByVal context As IFeatureValidationContext) _
        Implements IFeatureValidationRule.ValidateFeature
        For Each projectItem In context.Feature.ProjectItems
            ValidateProjectItem(context, projectItem)
        Next projectItem
    End Sub

    Public Sub ValidateProjectItem(ByVal context As IFeatureValidationContext, _
        ByVal projectItem As ISharePointProjectItem) _
        Implements IFeatureValidationRule.ValidateProjectItem
        If projectItem.Name = "" Then
            context.RuleViolations.Add( _
                "CustomFeatureValidationRule001", _
                ValidationRuleViolationSeverity.Warning, _
                "SharePoint project items must have a name.")
        End If
    End Sub
End Class
'</Snippet1>