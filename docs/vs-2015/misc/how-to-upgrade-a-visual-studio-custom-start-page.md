---
title: "How to: Upgrade a Custom Start Page | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
ms.assetid: 78342ce6-36c8-485b-a5f6-760e7a420a26
caps.latest.revision: 8
manager: jillfra
---
# How to: Upgrade a Visual Studio Custom Start Page
You can upgrade a Visual Studio 2010 or Visual Studio 2012 custom start page to Visual Studio 2015 by following the steps listed below.

> [!WARNING]
> The custom start page upgraded in this procedure is the one created with the [Custom Start Page](https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.CustomStartPageProjectTemplate) template on the Visual Studio Gallery. Your start page may have other features that need to be upgraded.

### To upgrade a custom start page to Visual Studio 2015

1. Make sure that Visual Studio 2015 and the Visual Studio 2015 SDK are installed. You can download the VSSDK from [Microsoft Visual Studio 2013 SDK](https://my.visualstudio.com/Downloads?pid=1436).

2. Open your custom template project. You will see a message notifying you that the project is to be upgraded. Click **OK** and wait for the upgrade to complete.

3. In the project properties for both the start page project and the control project, make sure that the Target Framework is at least .NET Framework 4.5.

4. In the Debug category of the project properties for the start page project, set the path to the Visual Studio 2015 version of devenv.exe.

5. In the project references for both projects, remove the references to Microsoft.VisualStudio.Shell.11.0 and add references to Microsoft.VisualStudio.Shell.14.0.

6. Open StartPage.xaml with the XML editor and make the following changes:

    1. Update the namespaces. Change the following lines:

        ```

        xmlns:vs="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.11.0"
         xmlns:vsfxim="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.Immutable.11.0"
        xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.11.0"
        ```

         to the following:

        ```

        xmlns:vs="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.142.0"
         xmlns:vsfxim="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.Immutable.14.0"
        xmlns:vsfx="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.14.0"
        ```

7. Open MyControl.xaml, and change the namespace reference `xmlns:vs="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.11.0"` to `xmlns:vs="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.14.0"` .