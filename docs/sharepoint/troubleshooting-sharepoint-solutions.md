---
title: "Troubleshooting SharePoint Solutions"
description: See what problems or alerts might occur when you debug SharePoint solutions by using the Visual Studio debugger.
ms.date: "02/22/2017"
ms.topic: troubleshooting-general
f1_keywords:
  - "Microsoft.VisualStudio.Tools.SharePoint.Errors.Debugging"
  - "VS.SharePointTools.errors.general"
  - "VS.SharePointTools.Project.Errors.General"
dev_langs:
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, troubleshooting"
  - "SharePoint development in Visual Studio, errors"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---

# Troubleshoot SharePoint solutions

  The following problems or alerts might occur when you debug SharePoint solutions by using the Visual Studio debugger. For more information, see [Debugging SharePoint 2007 Workflow Solutions](/previous-versions/bb386166(v=vs.100)).

## Token restrictions in sandboxed visual web parts

 Visual web parts in sandboxed solutions can't process standard tokens, such as $SPUrl, that the SharePoint runtime supports. As a result, the URL isn't resolved, and you can't preview the content in Design view in the visual web part designer if you refer to it directly in a script element, such as in the following example:

```xml
<script src="<% $SPUrl:~site/SiteAssets/ListOperations.js %>"></script>
```

 To work around this limitation and resolve the token, refer to it by using literals:

```xml
<asp:literal ID="Literal1" runat="server" Text="<script src='" />
<asp:literal ID="Literal2" runat="server" Text="<% $SPUrl:~site/SiteAssets/ListOperations.js %>" />
<asp:literal ID="Literal3" runat="server" Text="' type='text/javascript' ></script>" />
```

## Character restrictions in names of projects and project items

 Names of projects and project items can contain only characters that are valid in a deployment path in SharePoint 2010. No other characters are allowed.

### Error message

 "Invalid characters" error message.

### Resolution

 For names of SharePoint projects and project items, use only the following characters:

- Alphanumeric ASCII characters

- Space

- Period (.)

- Comma (,)

- Underscore (_)

- Dash (-)

- Backslash (\\)

  When a project is packaged, a validation rule verifies that the deployment-path property for each file you're deploying contains only these valid characters.

## Errors when creating custom fields

 In Visual Studio, custom fields are defined in XML. Errors can occur if a field isn't defined or referenced by using a specific format.

### Error message

 "Invalid characters" error message at packaging time.

### Resolution

 The ID for a field definition must be a GUID surrounded by braces, as the following example shows:

```xml
<Field ID="{5744d18c-305e-4632-8bd1-09d134f4830d}"
    Type="Note"
    Name="PatientName"
    DisplayName="Patient Name"
    Group="A Custom Group">
</Field>.
```

 As the following example shows, a field reference in a content type must be defined by using the empty element format (\<FieldRef />), not by using start/end elements (\<FieldRef>\</FieldRef>):

```xml
<FieldRef ID="{5744d18c-305e-4632-8bd1-09d134f4830d}"
    Name="PatientName"
    DisplayName="Patient Name"
    Required="TRUE"/>
```

 If the source XML for the field is malformed, isn't a valid XML file, or exhibits some other problem, the error "Cannot parse file" occurs.

## New non-English site definitions do not appear in site creation page after deployment

 After you create and deploy a site definition by using a non-English version of Visual Studio (that is, a version with a locale  ID  other than 1033), the **SharePoint Customizations** tab doesn't appear in the **Template Selection** box and the new site template doesn't appear in the **New SharePoint Site** page.

### Error message

 None.

### Resolution

 This problem occurs because of an incorrect value in the **Path** property for the webtemp site definition configuration file, such as *webtemp_SiteDefinitionProject1.xml*. In the **Path** property for the webtemp file, located under the **Deployment Location**, change 1033 to the appropriate locale  ID . For example, to use a Japanese locale change the value to 1041. For more information, see [Locale IDs Assigned by Microsoft](/openspecs/windows_protocols/ms-lcid/a9eac961-e77d-41a6-90a5-ce1a8b0cdb9c).

## Error appears when a workflow project is deployed on a clean system

 This problem occurs if you deploy a workflow project in Visual Studio on a clean system. A clean system is a computer that has a fresh installation of Visual Studio and SharePoint but no deployed workflow projects.

### Error message

 Cannot find the SharePoint list: Workflow History.

### Resolution

 This error occurs because of a missing Workflow History list. Because the development environment is a clean system, no workflows are deployed and the Workflow History list does not exist yet. To resolve this issue, reopen the workflow wizard, which causes the Workflow History list to be created.

#### To reenter the workflow wizard

1. In **Solution Explorer**, choose the workflow node.

2. In the **Properties** window, choose the ellipsis (...) button on any property that has an ellipsis button.

## User must refresh application page in browser while debugging to view updated image

 If you are debugging a SharePoint solution that contains an application page with a control that displays an image, such as an HTML Image control, you must refresh the page in the browser to display any changes that were made to the image.

## Error: The site location is not valid

 This problem can occur if  SharePoint Server is not installed. It might also occur if you do not have administrator access to the SharePoint Web site that is specified in the **SharePoint Customization Wizard**.

### Error message

- SharePoint site location is not valid.

### Resolution

- Install  SharePoint Server.

- Ensure that you have administrator access to the SharePoint Web site. For more information, see the  Office  Online article [Assign or remove administrators of service applications in SharePoint Server](/sharepoint/administration/assign-or-remove-administrators-of-service-applications).

## Site deletion web event does not occur in event receiver project

 When you create an event receiver project and you select certain Web events such as "a site is being deleted," the event never occurs.

### Error message

 None.

### Resolution

 This problem occurs because the feature scope must be "Site" to handle site-level events, but the default feature scope for event receiver projects is "Web". The Web events affected are:

- A site is being deleted (WebDeleting)

- A site was deleted (WebDeleted)

- A site is being moved (WebMoving)

- A site was moved (WebMoved)

  To fix the problem, change the feature scope of the event receiver, as follows.

#### To change the feature scope of the event receiver

1. In **Solution Explorer**, open the event receiver's *.feature* file in the **Feature Designer** by either double-clicking the file or opening its shortcut menu and then choosing **Open**.

2. Choose the arrow next to **Scope**, and then choose **Site** in the list that appears.

## Deployment error appears after the name of an identifier in a business data connectivity model project is changed

 This problem occurs if you change the identifier name of an entity in a Business Data Connectivity (BDC) model and then try to deploy the solution.

### Error messages

- \<*model name*> has the following External Content Type activation errors ...

- The IMetadataObject with Name '\<*model name*>' has a value in Field 'name' that is duplicated ...

### Resolution

 To resolve this issue, delete the model manually, and then deploy the solution again.  You can delete the model by using either of the following tools:

- SharePoint 2010 Central Administration. For more information, see [BDC Model Management](/previous-versions/office/sharepoint-server-2010/ee524073(v=office.14)#delete-a-bdc-model) on the Microsoft TechNet Web site.

- Windows PowerShell. You can delete the model by typing this command at the command prompt: **Remove-SPBusinessDataCatalogModel**. For more information, see [General cmdlets (SharePoint Server 2010)](/archive/technet-wiki/34284.sharepoint-2016-list-of-powershell-cmdlets) on the Microsoft TechNet Web site.

## Deployment error occurred trying to recycling the IIS Application Pool on the SharePoint Server

 This problem occurs if the IIS 6 WMI Compatibility feature and .NET Framework 3.5 are not installed on the SharePoint Server machine.

### Error messages

- Error occurred in deployment step 'Recycle IIS Application Pool': Invalid namespace
- Error occurred in deployment step 'Recycle IIS Application Pool': A task was canceled.

### Resolution

 To resolve this issue, on the SharePoint Server machine, check to see if the Windows feature **IIS 6 WMI Compatibility** is installed,

- Windows PowerShell.  You can check if the feature is installed by running this PowerShell command:
    **get-windowsfeature -name Web-WMI**. If it does not show as being Installed, you can install it by running the following PowerShell command:
    **install-windowsfeature -name Web-WMI**.  If you still see errors trying to recycle the Application Pool, make sure .NET Framework 3.5 is also installed on the machine by running **get-windowsfeature -name NET-Framework-Core** and **install-windowsfeature -name NET-Framework-Core** if it is not.

## An error appears when you try to view a visual web part in SharePoint

 This problem occurs when the **Path** property of the user control does not begin with the string "CONTROLTEMPLATES\\".

### Error messages

- The file '/_CONTROLTEMPLATES/*\<project name>*/*\<Web Part name>*/*\<user control name>*.ascx' does not exist.

- Server Error in '/' Application.

### Resolution

#### To resolve this issue

1. In **Solution Explorer**, choose the user control file, whose file name extension is *.ascx*.

2. On the menu bar, choose **View** > **Properties Window**.

3. In the **Properties** window, expand the **Deployment Location** node.

4. Ensure that the value of the **Path** property starts with the string "CONTROLTEMPLATES\\".

## Error appears when an imported reusable workflow that contains a task form field is run

 This problem occurs if you import a workflow that contains a task form that has a field, and then run the new workflow on the same system from which you imported it.

### Error message

 Error occurred in deployment step 'Activate Features': The field with Id [*Guid*] defined in feature [*Guid*] was found in the current site collection or in a subsite.

### Resolution

 This error is the result of field ID collisions that occur because the Import Reusable Workflow project in Visual Studio does not change task form field IDs. If you deploy an imported workflow on the same server that contains the original workflow, field ID collisions occur.

 To resolve this issue, use the Find and Replace feature to change the value of the Field ID attribute in all of the imported workflow files.

## Error appears when a renamed imported list instance is run

 This problem occurs if you rename an imported list instance and then run it in Visual Studio.

### Error message

 Build error: Error occurred in deployment step 'Activate Features': The file Template\Features\\[*import project*<em>feature</em>*name*]\Files\Lists\\[*old*<em>list name</em>]\Schema.xml does not exist.

### Resolution

 When you import a list instance, an attribute named CustomSchema is added to the Elements.xml file of the list instance. Elements.xml includes the path of a custom schema.xml for the list instance. When you rename the list instance in Visual Studio, the deployment path for the custom schema.xml changes, but the path value of the CustomSchema attribute is not updated. As a result, the list instance cannot find the *schema.xml* file in the old path that is specified by the CustomSchema attribute when the feature is activated.

 To resolve this issue, update the path of the deployment location of the *schema.xml* file in the CustomSchema attribute.

## SharePoint debugging session terminated by IIS

 This problem occurs if you set a breakpoint in a Visual Studio SharePoint solution, choose the **F5** key to run it, and then remain at a breakpoint longer than 90 seconds.

### Error message

 The Web server process that was being debugged has been terminated by Internet Information Services (IIS). You can avoid this problem by configuring Application Pool ping settings in IIS. See help for further details.

### Resolution

 By default, the IIS application pool waits 90 seconds for an application to respond before it closes the application. This process is known as "pinging" the application. To resolve this issue, you can either increase the wait time or disable application pinging entirely.

#### To access the IIS app pool settings

1. Open IIS Manager.

2. In the **Connections** pane, expand the SharePoint server node, and then choose the **Application Pools** node.

3. On the **Application Pools** page, choose the SharePoint application pool (typically "SharePoint - 80"), and then, in the **Actions** pane, choose the **Advanced Settings** link.

4. To increase the wait time before IIS timeout, change the value of **Ping Maximum Response Time (seconds)** to a value that's larger than 90 seconds.

5. To disable IIS pinging, set **Ping Enabled** to **False**.

## Auto-retract leaves orphaned list instance in SharePoint

 This problem occurs if you take the following steps.

1. Create a list definition that has a list instance in Visual Studio.

2. Choose the **F5** key to run the solution.

3. Stop debugging, or close the SharePoint site.

4. Reopen the SharePoint site and open the list instance.

### Error message

 Server Error in '/' Application.

### Resolution

 This happens because after you close a debug session of a SharePoint solution, the auto-retract feature retracts the solution. The retraction deletes the list definition from SharePoint but does not delete the instance of the list. The underlying list definition is required by the list instance.

 To resolve this issue, deploy the solution by, on the menu bar, choosing **Build** > **Deploy**. (Don't debug the solution by choosing the **F5** key.) Then, delete the list instance in SharePoint.

## Original SharePoint solution is replaced by an exported version

 If you export a SharePoint solution, import the solution into Visual Studio, and then deploy the solution back to the same site from which it was exported, the original SharePoint solution is replaced. This problem does not occur if you deploy the solution to a server that does not have the original solution activated on it.

### Error message

 None.

### Resolution

 To avoid overwriting a solution on the site from which it was exported, change the GUIDs of the SolutionID and the Feature IDs of all the imported features in the Visual Studio project.

## Error appears when debugging starts

 When you start to debug a SharePoint solution in Visual Studio, an error indicates that Visual Studio couldn't load the Web.config file because the given key wasn't in the dictionary.

### Error message

 Could not load the Web.config configuration file. Check the file for any malformed XML elements and try again. The following error occurred: The given key was not present in the dictionary.

### Resolution

 To resolve this problem, make sure that the Site URL property value of the SharePoint project in Visual Studio matches the URL that's assigned to the Default Zone for the alternate access mappings of the web application. You can't resolve the error by using another zone, such as Intranet, for the URL. The site URL for the project and the URL in the default zone must match. To access alternate access mappings, open the SharePoint 2010 Central Administration utility, choose the **Application Management** link , and then, under **Web Applications**, choose the **Configure alternate access mappings** link. For more information, see [Create zones for Web applications](/previous-versions/office/sharepoint-2007-products-and-technologies/cc263087(v=office.12)).

## Related content

- [Troubleshoot SharePoint packaging and deployment](../sharepoint/troubleshooting-sharepoint-packaging-and-deployment.md)
- [Build and debug SharePoint solutions](../sharepoint/building-and-debugging-sharepoint-solutions.md)
- [Debugging in Visual Studio](../debugger/debugger-feature-tour.md)
