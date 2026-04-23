---
title: "Use WPF controls in Office solutions"
description: Learn how you can use Windows Presentation Foundation (WPF) controls for designing user interfaces in Visual Studio.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "WPF [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Use WPF controls in Office solutions

Although solutions created by using the Office development tools in Visual Studio are designed to work with directly with Windows Forms controls, you can also use WPF controls in your solutions. Windows Presentation Foundation (WPF) is an alternative to Windows Forms for designing user interfaces. WPF uses a markup language called Extensible Application Markup Language (XAML) to provide new techniques for incorporating UI, media, and documents. For more information, see [WPF overview](/dotnet/framework/wpf/introduction-to-wpf).

[!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

Any UI element that can host Windows Forms controls in an Office solution can also host WPF controls. These include the following elements:

- Documents and worksheets in document-level customizations.

- Actions panes in document-level customizations.

- Custom task panes in VSTO Add-ins.

- Form regions in VSTO Add-ins for Outlook.

## Add WPF controls to Office projects at design time

You cannot add WPF controls directly to UI elements in Office solutions. Instead, add a **User Control (WPF)** item to your project, and use it as the design surface for WPF controls. Then, add the WPF user control to a UI element in your project.

### To add WPF controls to an actions pane, custom task pane, or form region

1. Open a project to which you want to add a custom task pane, an actions pane, or a form region.

2. Add a **User Control (WPF)** item to your project.

3. From the **Toolbox**, add WPF controls to the WPF user control design surface.

     By default, when the WPF user control designer is open, the **Toolbox** contains only WPF controls.

4. Build the project.

5. Add an actions pane, form region, or custom task pane to your project:

    - For form regions, add an **Outlook Form Region** item to the project. For more information, see [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md).

    - For actions panes, add an **Actions Pane Control** or **User Control** item to the project. For more information, see [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md).

    - For custom task panes, add a **User Control** item to the project. For more information, see [How to: Add a custom task pane to an application](../vsto/how-to-add-a-custom-task-pane-to-an-application.md).

6. From the *ProjectName* **WPF User Controls** tab of the **Toolbox**, drag the WPF user control to the designer for the actions pane, form region, or custom task pane.

     Visual Studio automatically creates an <xref:System.Windows.Forms.Integration.ElementHost> object that hosts the WPF user control on the UI element.

7. Rebuild the project.

#### To add WPF controls to a document or worksheet in a document-level project

1. Open a document-level project for Word or Excel.

2. Add a **User Control (WPF)** item to your project.

3. From the **Toolbox**, add WPF controls to the WPF user control design surface.

4. Build the project.

5. Add a **User Control** item (that is, a Windows Forms user control) to the project.

6. Open the designer for the Windows Forms user control.

7. From the *ProjectName* **WPF User Controls** tab of the **Toolbox**, drag the WPF user control to the designer.

     Visual Studio automatically creates an <xref:System.Windows.Forms.Integration.ElementHost> object that hosts the WPF user control in the Windows Forms user control.

8. Write code that programmatically adds the Windows Forms user control to the document or workbook. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

    > [!NOTE]
    > You cannot drag the Windows Forms user control to the document or worksheet in the designer.

9. Rebuild the project.

## Host WPF controls by using the ElementHost class

Visual Studio provides features that help you use Windows Forms controls in your Office solutions, but it does not provide similar features for WPF controls. For example, you can add Windows Forms controls to documents and worksheets at design time by dragging controls from the **Toolbox**, or at run time by using helper methods. However, these tools are not available for WPF controls.

WPF controls use the <xref:System.Windows.Forms.Integration.ElementHost> class as an integration layer between a Windows Forms control or form and the WPF controls. When you add WPF controls to your solution at design time, Visual Studio automatically generates an <xref:System.Windows.Forms.Integration.ElementHost> object for you.

## WPF resources

For more information about architectural and design issues for hosting WPF controls on Windows Forms controls and forms, see the following topics:

- [Windows Forms and WPF interoperability input architecture](/dotnet/framework/wpf/advanced/windows-forms-and-wpf-interoperability-input-architecture)

- [Windows Forms and WPF property mapping](/dotnet/framework/wpf/advanced/windows-forms-and-wpf-property-mapping)

- [WPF and Windows Forms interoperation](/dotnet/framework/wpf/advanced/wpf-and-windows-forms-interoperation)

- [Windows Forms controls and equivalent WPF controls](/dotnet/framework/wpf/advanced/windows-forms-controls-and-equivalent-wpf-controls)

For more information about adding WPF controls to Windows Forms controls and forms in Visual Studio at design time, see the following topics:

- [Walkthrough: Create new WPF content on Windows Forms at design time](/dotnet/framework/winforms/advanced/walkthrough-creating-new-wpf-content-on-windows-forms-at-design-time)

- [Walkthrough: Arrange WPF content on Windows Forms at design time](/dotnet/framework/winforms/advanced/walkthrough-arranging-wpf-content-on-windows-forms-at-design-time)

- [Walkthrough: Style WPF content](/dotnet/framework/winforms/advanced/walkthrough-styling-wpf-content)

## Related content

- [Office UI customization](../vsto/office-ui-customization.md)
- [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)
- [Actions pane overview](../vsto/actions-pane-overview.md)
- [Custom task panes](../vsto/custom-task-panes.md)
- [Create Outlook form regions](../vsto/creating-outlook-form-regions.md)
- [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)
- [How to: Add a custom task pane to an application](../vsto/how-to-add-a-custom-task-pane-to-an-application.md)
- [How to: Add a form region to an Outlook Add-in project](../vsto/how-to-add-a-form-region-to-an-outlook-add-in-project.md)
