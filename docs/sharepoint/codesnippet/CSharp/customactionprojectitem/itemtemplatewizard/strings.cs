
//<Snippet6>
namespace ItemTemplateWizard
{
    // This sample only supports several custom action locations and their group IDs. 
    internal class CustomActionLocations
    {
        internal const string ListEdit = "Microsoft.SharePoint.ListEdit";
        internal const string StandardMenu = "Microsoft.SharePoint.StandardMenu";
    }

    internal class StandardMenuGroupIds
    {
        internal const string Actions = "ActionsMenu";
        internal const string ActionsSurvey = "ActionsMenuForSurvey";
        internal const string NewMenu = "NewMenu";
        internal const string Settings = "SettingsMenu";
        internal const string SettingsSurvey = "SettingsMenuForSurvey";
        internal const string SiteActions = "SiteActions";
        internal const string Upload = "UploadMenu";
        internal const string ViewSelector = "ViewSelectorMenu";
    }

    internal class ListEditGroupIds
    {
        internal const string Communications = "Communications";
        internal const string GeneralSettings = "GeneralSettings";
        internal const string Permissions = "Permissions";
    }

    internal class DefaultTextBoxStrings
    {
        internal const string TitleText = "Replace this with your title";
        internal const string DescriptionText = "Replace this with your description";
        internal const string UrlText = "~site/Lists/Tasks/AllItems.aspx";
    }
}
//</Snippet6>
