using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading;
using Microsoft.VisualStudio.SharePoint;

namespace GetProjectService
{
    //<Snippet1>
    [Export(typeof(ISharePointProjectExtension))]
    internal class GetServiceInProject : ISharePointProjectExtension
    {
        public void Initialize(ISharePointProjectService projectService)
        {
            projectService.Logger.WriteLine("This message was written by using the " +
                "project service in a project extension.", LogCategory.Message);
        }
    }
    //</Snippet1>

    //<Snippet2>
    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListDefinition")]
    internal class GetServiceInProjectItem : ISharePointProjectItemTypeExtension
    {
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.ProjectService.Logger.WriteLine("This message was written " +
                "by using the project service in an extension for the ListDefinition project item.", 
                LogCategory.Message);
        }
    }
    //</Snippet2>

    //<Snippet3>
    [Export(typeof(ISharePointProjectItemTypeProvider))]
    [SharePointProjectItemType("Contoso.CustomAction")]
    internal class CustomActionProvider : ISharePointProjectItemTypeProvider
    {
        public void InitializeType(ISharePointProjectItemTypeDefinition projectItemTypeDefinition)
        {
            projectItemTypeDefinition.ProjectService.Logger.WriteLine("This message was written " +
                "by using the project service in the Custom Action project item type definition.",
                LogCategory.Message);
        }
    }
    //</Snippet3>
}
