---
title: "Improve the performance of a VSTO Add-in"
description: Learn how to optimize VSTO Add-ins that you create for Office applications so that they quickly start up, shut down, open items, and perform other tasks.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Improve the performance of a VSTO add-in

  You can give your users a better experience by optimizing VSTO Add-ins that you create for Office applications so that they quickly start up, shut down, open items, and perform other tasks. If your VSTO Add-in is for Outlook, you can also reduce the chance that your VSTO Add-in will be disabled because of poor performance. You can increase the performance of your VSTO Add-in by implementing the following strategies:

- [Load VSTO Add-ins on demand](#Load).

- [Publish Office solutions by using Windows Installer](#Publish).

- [Bypass Ribbon reflection](#Bypass).

- [Perform expensive operations in a separate execution thread](#Perform).

  For more information about how to optimize an Outlook VSTO Add-in, see [Performance criteria to keep VSTO Add-ins enabled](/previous-versions/office/jj228679(v=office.15)#performance-criteria-for-keeping-add-ins-enabled).

## <a name="Load"></a> Load VSTO Add-ins on demand
 You can configure a VSTO Add-in to load only under the following circumstances:

- The first time that the user starts the application after the VSTO Add-in is installed.

- The first time that the user interacts with the VSTO Add-in after starting the application any subsequent time.

  For example, your VSTO Add-in might populate a worksheet with data when the user chooses a custom button that's labeled **Get My Data**. The application must load your VSTO Add-in at least one time so that the **Get My Data** button can appear in the Ribbon. However, the VSTO Add-in doesn't load again when the user starts the application the next time. The VSTO Add-in loads only when the user chooses the **Get My Data** button.

### To configure a ClickOnce solution to load VSTO Add-ins on demand

1. In **Solution Explorer**, choose the project node.

2. On the menu bar, choose **View** > **Property Pages**.

3. On the **Publish** tab, choose the **Options** button.

4. In the **Publish Options** dialog box, choose the **Office Settings** list item, choose the **Load on Demand** option, and then choose the **OK** button.

### To configure a Windows Installer solution to load VSTO Add-ins on demand

1. In the registry, set the `LoadBehavior` entry of the **_Root_\Software\Microsoft\Office\\_ApplicationName_\Addins\\_Add-in ID_** key to **0x10**.

     For more information, see [Registry entries for VSTO Add-ins](../vsto/registry-entries-for-vsto-add-ins.md).

### To configure a solution to load VSTO Add-ins on demand while you debug the solution

1. Create a script that sets the `LoadBehavior` entry of the **_Root_\Software\Microsoft\Office\\_ApplicationName_\Addins\\_Add-in ID_** key to **0x10**.

     The following code shows an example of this script.

    ```cmd/sh
    [HKEY_CURRENT_USER\Software\Microsoft\Office\Excel\Addins\MyAddIn]
    "Description"="MyAddIn"
    "FriendlyName"="MyAddIn"
    "LoadBehavior"=dword:00000010
    "Manifest"="c:\\Temp\\MyAddIn\\bin\\Debug\\MyAddIn.vsto|vstolocal"

    ```

2. Create a post-build event that updates the registry by using the script.

     The following code shows an example of a command string that you might add to a post-build event.

    ```cmd/sh
    regedit /s "$(SolutionDir)$(SolutionName).reg"

    ```

     For information about how to create post-build event in a C# project, see [How to: Specify build events &#40;C&#35;&#41;](../ide/how-to-specify-build-events-csharp.md).

     For information about how to create a post-build event in a Visual Basic project, see [How to: Specify build events &#40;Visual Basic&#41;](../ide/how-to-specify-build-events-visual-basic.md).

## <a name="Publish"></a> Publish Office solutions by using Windows Installer
 If you publish your solution by using Windows Installer, the Visual Studio 2010 Tools for Office runtime bypasses the following steps when the VSTO Add-in loads.

- Validating the manifest schema.

- Automatically checking for updates.

- Validating the digital signatures of the deployment manifests.

  > [!NOTE]
  > This approach isn't necessary if you deploy your VSTO Add-in to a secure location on the users' computers.

  For more information, see [Deploy an Office solution by using Windows Installer](../vsto/deploying-a-vsto-solution-by-using-windows-installer.md).

## <a name="Bypass"></a> Bypass Ribbon reflection
 If you build a solution by using Visual Studio 2012, ensure that your users have installed the most recent version of the Visual Studio 2010 Tools for Office runtime when you deploy the solution. Older versions of the VSTO runtime reflected into solution assemblies to locate Ribbon customizations. This process can cause the VSTO Add-in to load more slowly.

 As an alternative, you can prevent any version of the Visual Studio 2010 Tools for Office runtime from using reflection to identify Ribbon customizations. To follow this strategy, override the `CreateRibbonExtensibility` method, and explicitly return Ribbon objects. If your VSTO Add-in doesn't contain any Ribbon customizations, return `null` inside of the method.

 The following example returns a Ribbon object based on the value of a field.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_ribbon_choose_ribbon_4/ThisWorkbook.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_ribbon_choose_ribbon_4/ThisWorkbook.vb" id="Snippet1":::
 ---

## <a name="Perform"></a> Perform expensive operations in a separate execution thread
 Consider performing time-consuming tasks (such as long running tasks, database connections, or other sorts of network calls) in a separate thread. For more information, see [Threading support in Office](../vsto/threading-support-in-office.md).

> [!NOTE]
> All code that calls into the Office object model must execute in the main thread.

## Related content

- [Demand-loading VSTO Add-ins](/archive/blogs/andreww/demand-loading-vsto-add-ins)
- [Delay-loading the CLR in Office Add-ins](/archive/blogs/andreww/delay-loading-the-clr-in-office-add-ins)
- [Create VSTO Add-ins for Office by using Visual Studio](create-vsto-add-ins-for-office-by-using-visual-studio.md)
