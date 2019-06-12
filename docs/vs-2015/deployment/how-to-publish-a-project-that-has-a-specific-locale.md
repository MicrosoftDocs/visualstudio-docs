---
title: "How to: Publish a Project That Has a Specific Locale | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "publishing, localized projects"
  - "locales, publishing for"
  - "deploying applications [ClickOnce], localized projects"
  - "locales, deploying for"
  - "publishing localized projects"
  - "macros, deploying with"
  - "macros, publishing with"
ms.assetid: 7c4cd83a-f985-4c85-9022-fadb5dbd2b39
caps.latest.revision: 13
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Publish a Project That Has a Specific Locale
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

It is not uncommon for an application to contain components that have different locales. In this scenario, you would create a solution that has several projects, and then publish separate projects for each locale. This procedure shows how to use a macro to publish the first project in a solution by using the 'en' locale. If you want to try this procedure with a locale other than 'en', make sure to set `localeString` in the macro to match the locale that you are using (for example, 'de' or 'de-DE').  
  
> [!NOTE]
> When you use this macro, the Publish Location should be a valid URL or Universal Naming Convention (UNC) share. Also, Internet Information Services (IIS) has to be installed on your computer. To install IIS, on the **Start** menu, click **Control Panel**. Double-click **Add or Remove Programs**. In **Add or Remove Programs**, click **Add/Remove Windows Components**. In the **Windows Components Wizard**, select the **Internet Information Services (IIS)** check box in the **Components** list. Then click **Finish** to close the wizard.  
  
### To create the publishing macro  
  
1. To open the Macro Explorer, on the **Tools** menu, point to **Macros**, and then click **Macro Explorer**.  
  
2. Create a new macro module. In the Macro Explorer, select **MyMacros**. On the **Tools** menu, point to **Macros**, and then click **New Macro Module**. Name the module **PublishSpecificCulture**.  
  
3. In the Macro Explorer, expand the **MyMacros** node, and then open the **PublishAllProjects** module by double-clicking it (or, from the **Tools** menu, point to **Macros**, and then click **Macros IDE**).  
  
4. In the Macros IDE, add the following code to the module, after the `Import` statements:  
  
    ```vb  
    Module PublishSpecificCulture  
        Sub PublishProjectFirstProjectWithEnLocale()  
            ' Note: You should publish projects by using the IDE at least once  
            ' before you use this macro. Items such as the certificate and the   
            ' security zone must be set.  
            Dim localeString As String = "en"  
  
            ' Get first project.  
            Dim proj As Project = DTE.Solution.Projects.Item(1)  
            Dim publishProperties As Object = proj.Properties.Item("Publish").Value  
  
            ' GenerateManifests and SignManifests must always be set to  
            ' True for publishing to work.   
            proj.Properties.Item("GenerateManifests").Value = True  
            proj.Properties.Item("SignManifests").Value = True  
  
            'Set the publish language.  
            'This will set the deployment language and pick up all   
            ' en resource dlls:  
            Dim originalTargetCulture As String = _  
                publishProperties.Item("TargetCulture").Value  
            publishProperties.Item("TargetCulture").Value = localeString  
  
            'Append 'en' to end of publish, install, and update URLs if needed:  
            Dim originalPublishUrl As String = _  
                publishProperties.Item("PublishUrl").Value  
            Dim originalInstallUrl As String = _  
                publishProperties.Item("InstallUrl").Value  
            Dim originalUpdateUrl As String = _  
                publishProperties.Item("UpdateUrl").Value  
            publishProperties.Item("PublishUrl").Value = _  
                AppendStringToUrl(localeString, New Uri(originalPublishUrl))  
            If originalInstallUrl <> String.Empty Then  
                publishProperties.Item("InstallUrl").Value = _  
                    AppendStringToUrl(localeString, New Uri(originalInstallUrl))  
            End If  
            If originalUpdateUrl <> String.Empty Then  
                publishProperties.Item("UpdateUrl").Value = _  
                    AppendStringToUrl(localeString, New Uri(originalUpdateUrl))  
            End If  
            proj.Save()  
  
            Dim slnbld2 As SolutionBuild2 = _  
                CType(DTE.Solution.SolutionBuild, SolutionBuild2)  
            slnbld2.Clean(True)  
  
            slnbld2.BuildProject( _  
            proj.ConfigurationManager.ActiveConfiguration.ConfigurationName, _  
            proj.UniqueName, True)  
  
            ' Only publish if build is successful.  
            If slnbld2.LastBuildInfo <> 0 Then  
                MsgBox("Build failed for " & proj.UniqueName)  
            Else  
                slnbld2.PublishProject( _  
                proj.ConfigurationManager.ActiveConfiguration.ConfigurationName, _  
                proj.UniqueName, True)  
                If slnbld2.LastPublishInfo = 0 Then  
                    MsgBox("Publish succeeded for " & proj.UniqueName _  
                    & vbCrLf & "." _  
                    & " Publish Language was '" & localeString & "'.")  
                Else  
                    MsgBox("Publish failed for " & proj.UniqueName)  
                End If  
            End If  
  
            ' Return URLs and target culture to their previous state.  
            publishProperties.Item("PublishUrl").Value = originalPublishUrl  
            publishProperties.Item("InstallUrl").Value = originalInstallUrl  
            publishProperties.Item("UpdateUrl").Value = originalUpdateUrl  
            publishProperties.Item("TargetCulture").Value = originalTargetCulture  
            proj.Save()  
        End Sub  
  
        Private Function AppendStringToUrl(ByVal str As String, _  
        ByVal baseUri As Uri) As String  
            Dim returnValue As String = baseUri.OriginalString  
            If baseUri.IsFile OrElse baseUri.IsUnc Then  
                returnValue = IO.Path.Combine(baseUri.OriginalString, str)  
            Else  
                If Not baseUri.ToString.EndsWith("/") Then  
                    returnValue = baseUri.OriginalString & "/" & str  
                Else  
                    returnValue = baseUri.OriginalString & str  
                End If  
            End If  
            Return returnValue  
        End Function  
    End Module  
    ```  
  
5. Close the Macros IDE. The focus will return to Visual Studio.  
  
### To publish a project for a specific locale  
  
1. To create a Visual Basic Windows Application project, on the **File** menu, point to **New**, and then click **Project**.  
  
2. In the **New Project** dialog box, select **Windows Application** from the **Visual Basic** node. Name the project **PublishLocales**.  
  
3. Click Form1. In the **Properties** window, under **Design**, change the **Language** property from **(Default)** to **English**. Change the **Text** property of the form to **MyForm**.  
  
     Note that the localized resource DLLs are not created until they are needed. For example, they are created when you change the text of the form or one of its controls after you have specified the new locale.  
  
4. Publish PublishLocales by using the Visual Studio IDE.  
  
     In **Solution Explorer**, select PublishLocales. On the **Project** menu, select **Properties**. In the Project Designer, on the **Publish** page, specify a publishing location of **http://localhost/PublishLocales**, and then click **Publish Now**.  
  
     When the publish Web page appears, close it. (For this step, you only have to publish the project; you do not have to install it.)  
  
5. Publish PublishLocales again by invoking the macro in the Visual Studio Command Prompt window. To view the Command Prompt window, on the **View** menu, point to **Other Windows** and then click **Command Window**, or press CTRL+ALT+A. In the Command Prompt window, type `macros`; auto-complete will provide a list of available macros. Select the following macro and press ENTER:  
  
     `Macros.MyMacros.PublishSpecificCulture.PublishProjectFirstProjectWithEnLocale`  
  
6. When the publish process succeeds, it will generate a message that says "Publish succeeded for PublishLocales\PublishLocales.vbproj. Publish language was 'en'." Click **OK** in the message box. When the publish Web page appears, click **Install**.  
  
7. Look in C:\Inetpub\wwwroot\PublishLocales\en. You should see the installed files such as the manifests, setup.exe, and the publish Web page file, in addition to the localized resource DLL. (By default ClickOnce appends a .deploy extension on EXEs and DLLs; you can remove this extension after deployment.)  
  
## See Also  
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [Macros Development Environment](https://msdn.microsoft.com/d23105d8-34fe-4ad9-8278-fae2c660aeac)   
 [Macro Explorer Window](https://msdn.microsoft.com/762169e6-f83f-44b4-bffa-d0f107cae9a3)   
 [How to: Edit and Programmatically Create Macros](https://msdn.microsoft.com/6716f820-1feb-48ad-a718-27eb6b473c5a)
