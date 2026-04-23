---
title: Customize a project ribbon with Ribbon (XML) item
description: Use the Ribbon (XML) item to customize a project ribbon in a way that the Ribbon (Visual Designer) item doesn't support.
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "VSTO.Ribbon.RibbonXMLItem"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "custom Ribbon, XML"
  - "customizing the Ribbon, XML"
  - "Ribbon [Office development in Visual Studio], XML"
  - "callback methods"
  - "custom Ribbon, displaying"
  - "custom Ribbon, defining behavior"
  - "XML [Office development in Visual Studio], Ribbon"
  - "customizing the Ribbon, defining behavior"
  - "Ribbon [Office development in Visual Studio], customizing"
  - "customizing the Ribbon, displaying"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Ribbon XML

  The Ribbon (XML) item enables you to customize a ribbon by using XML. Use the Ribbon (XML) item if you want to customize the ribbon in a way that is not supported by the Ribbon (Visual Designer) item. For a comparison of what you can do with each item, see [Ribbon overview](../vsto/Ribbon-overview.md).

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

## Add a Ribbon (XML) item to a project
 You can add a **Ribbon (XML)** item to any Office project from the **Add New Item** dialog box. Visual Studio automatically adds the following files to your project:

- A Ribbon XML file. This file defines the Ribbon user interface (UI). Use this file to add UI elements such as tabs, groups, and controls. For details, see [Ribbon XML file reference](#RibbonDescriptorFile) later in this topic.

- A Ribbon code file. This file contains the *Ribbon class*. This class has the name that you specified for the **Ribbon (XML)** item in the **Add New Item** dialog box. Microsoft Office applications use an instance of this class to load the custom ribbon. For details, see [Ribbon class reference](#RibbonExtensionClass) later in this topic.

  By default, these files add a custom group to the **Add-Ins** tab in the ribbon.

## Display the custom ribbon in a Microsoft Office application
 After you add a **Ribbon (XML)** item to your project, you must add code to the **ThisAddin**, **ThisWorkbook**, or **ThisDocument** class that overrides the `CreateRibbonExtensibilityObject` method and returns the Ribbon XML class to the Office application.

 The following code example overrides the `CreateRibbonExtensibilityObject` method and returns a Ribbon XML class named MyRibbon.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_Ribbon_Custom_Tab_XML_O12/ThisAddIn.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_Ribbon_Custom_Tab_XML_O12/ThisAddIn.vb" id="Snippet1":::
 ---

## Define the behavior of the custom ribbon
 You can respond to user actions, such as clicking a button on the ribbon, by creating *callback methods*. Callback methods resemble events in Windows Forms controls, but they are identified by an attribute in the XML of the UI element. You write methods in the Ribbon class, and a control calls the method that has the same name as the attribute value. For example, you can create a callback method that is called when a user clicks a button on the ribbon. Two steps are required to create a callback method:

- Assign an attribute to a control in the Ribbon XML file that identifies a callback method in your code.

- Define the callback method in the Ribbon class.

> [!NOTE]
> Outlook requires an additional step. For more information, see [Customize a ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md).

 For a walkthrough that demonstrates how to automate an application from the ribbon, see [Walkthrough: Create a custom tab by using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md).

### Assign callback methods to controls
 To assign a callback method to a control in the Ribbon XML file, add an attribute that specifies the type of the callback method and the name of the method. For example, the following element defines a toggle button that has an **onAction** callback method named `OnToggleButton1`.

```xml
<toggleButton id="toggleButton1" onAction="OnToggleButton1" />
```

 **onAction** is called when the user performs the main task associated with a particular control. For example, the **onAction** callback method of a toggle button is called when the user clicks the button.

 The method that you specify in the attribute can have any name. However, it must match the name of the method that you define in the Ribbon code file.

 There are many different types of callback methods that you can assign to Ribbon controls. For a complete list of the callback methods available for each control, see the technical article [Customize the Office (2007) Ribbon user interface for developers (Part 3 of 3)](/previous-versions/office/developer/office-2007/aa722523(v=office.12)).

### <a name="CallBackMethods"></a> Define callback methods
 Define your callback methods in the Ribbon class in the Ribbon code file. A callback method has several requirements:

- It must be declared as public.

- Its name must match the name of a callback method that you assigned to a control in the Ribbon XML file.

- Its signature must match the signature of a type of callback method that is available for the associated Ribbon control.

  For a complete list of the callback method signatures for Ribbon controls, see the technical article [Customize the Office (2007) Ribbon user interface for developers (Part 3 of 3)](/previous-versions/office/developer/office-2007/aa722523(v=office.12)). Visual Studio does not provide IntelliSense support for callback methods that you create in the Ribbon code file. If you create a callback method that does not match a valid signature, the code will compile, but nothing will occur when the user clicks the control.

  All callback methods have a <xref:Microsoft.Office.Core.IRibbonControl> parameter that represents the control that called the method. You can use this parameter to reuse the same callback method for multiple controls. The following code example demonstrates an **onAction** callback method that performs different tasks depending on which control the user clicks.

  ### [C#](#tab/csharp)
  :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_RibbonOutlookBasic/Ribbon1.cs" id="Snippet2":::

  ### [VB](#tab/vb)
  :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_RibbonOutlookBasic/Ribbon1.vb" id="Snippet2":::
  ---

## <a name="RibbonDescriptorFile"></a> Ribbon XML file reference
 You can define your custom ribbon by adding elements and attributes to the Ribbon XML file. By default, the Ribbon XML file contains the following XML.

```xml
<?xml version="1.0" encoding="UTF-8"?>
<customUI xmlns="http://schemas.microsoft.com/office/2006/01/customui" onLoad="OnLoad">
  <ribbon>
    <tabs>
      <tab idMso="TabAddIns">
        <group id="MyGroup"
               label="My Group">
        </group>
      </tab>
    </tabs>
  </ribbon>
</customUI>
```

 The following table describes the default elements in the Ribbon XML file.

|Element|Description|
|-------------|-----------------|
|**customUI**|Represents the custom ribbon in the VSTO Add-in project.|
|**ribbon**|Represents the ribbon.|
|**tabs**|Represents a set of Ribbon tabs.|
|**tab**|Represents a single Ribbon tab.|
|**group**|Represents a group of controls on the Ribbon tab.|

 These elements have attributes that specify the appearance and behavior of the custom ribbon. The following table describes the default attributes in the Ribbon XML file.

|Attribute|Parent element|Description|
|---------------|--------------------|-----------------|
|**onLoad**|**customUI**|Identifies a method that is called when the application loads the ribbon.|
|**idMso**|**tab**|Identifies a built-in tab to display in the ribbon.|
|**id**|**group**|Identifies the group.|
|**label**|**group**|Specifies the text that appears on the group.|

 The default elements and attributes in the Ribbon XML file are a small subset of the elements and attributes that are available. For a complete list of the available elements and attributes, see the technical article [Customize the Office (2007) Ribbon user interface for developers (Part 2 of 3)](/previous-versions/office/developer/office-2007/aa338199(v=office.12)).

## <a name="RibbonExtensionClass"></a> Ribbon class reference
 Visual Studio generates the Ribbon class in the Ribbon code file. Add the callback methods for controls on the ribbon to this class. This class implements the <xref:Microsoft.Office.Core.IRibbonExtensibility> interface.

 The following table describes the default methods in this class.

|Method|Description|
|------------|-----------------|
|`GetCustomUI`|Returns the contents of the Ribbon XML file. Microsoft Office applications call this method to obtain an XML string that defines the user interface of your custom ribbon. This method implements the <xref:Microsoft.Office.Core.IRibbonExtensibility.GetCustomUI%2A> method. **Note:**  `GetCustomUI` should be implemented only to return the contents of the Ribbon XML file; it should not be used to initialize your VSTO Add-in. In particular, you should not try to display dialog boxes or other windows in your `GetCustomUI` implementation. Otherwise, the custom ribbon might not behave correctly. If you have to run code that initializes your VSTO Add-in, add the code to the `ThisAddIn_Startup` event handler.|
|`OnLoad`|Assigns the <xref:Microsoft.Office.Core.IRibbonControl> parameter to the `Ribbon` field. Microsoft Office applications call this method when they load the custom ribbon. You can use this field to dynamically update the custom ribbon. For more information, see the technical article [Customize the Office (2007) Ribbon user interface for developers (Part 1 of 3)](/previous-versions/office/developer/office-2007/aa338202(v=office.12)).|
|`GetResourceText`|Called by the `GetCustomUI` method to obtain the contents of the Ribbon XML file.|

## Related content
- [Ribbon overview](../vsto/ribbon-overview.md)
- [Walkthrough: Create a custom tab by using Ribbon XML](../vsto/walkthrough-creating-a-custom-tab-by-using-ribbon-xml.md)
- [Office UI customization](../vsto/office-ui-customization.md)
