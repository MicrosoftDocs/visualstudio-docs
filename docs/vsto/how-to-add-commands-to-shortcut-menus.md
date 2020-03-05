---
title: "How to: Add Commands to shortcut menus"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office menus, creating"
  - "Office development in Visual Studio, context menus"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add commands to shortcut menus
  This topic demonstrates how to add commands to a shortcut menu in an Office application by using a VSTO Add-in.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

### To add commands to shortcut menus in Office

1. Add a **Ribbon XML** item to a document-level or VSTO Add-in project. For more information, see [How to: Get started customizing the Ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md). In

2. **Solution Explorer**, select **ThisAddin.cs** or **ThisAddin.vb**.

3. On the menu bar, choose **View** > **Code**.

     The **ThisAddin** class file opens in the Code Editor.

4. Add the following code to the **ThisAddin** class. This code overrides the `CreateRibbonExtensibilityObject` method and returns the Ribbon XML class to the Office application.

     [!code-csharp[Trin_WordAddIn_Menus#1](../vsto/codesnippet/CSharp/trin_wordaddin_menus.cs/thisaddin.cs#1)]
     [!code-vb[Trin_WordAddIn_Menus#1](../vsto/codesnippet/VisualBasic/trin_wordaddin_menus.vb/thisaddin.vb#1)]

5. In **Solution Explorer**, select the Ribbon XML file. By default, the Ribbon XML file is named *Ribbon1.xml*.

6. On the menu bar, choose **View** > **Code**.

     The Ribbon xml file opens in the Code Editor.

7. In the Code Editor, add XML that describes the shortcut menu and the control that you want to add to the shortcut menu.

     The following example adds a button, a menu, and a gallery control to the shortcut menu for a word document. The control ID of this shortcut menu is ContextMenuText. For a complete list of Office 2010 shortcut control ID's, see [Office 2010 help files: Office fluent user interface control identifiers](https://www.microsoft.com/download/details.aspx?id=6627).

    ```xml
    <?xml version="1.0" encoding="UTF-8"?>
    <customUI xmlns="http://schemas.microsoft.com/office/2009/07/customui">
      <contextMenus>
        <contextMenu idMso="ContextMenuText">
          <button id="MyButton" label="My Button" insertBeforeMso="HyperlinkInsert" onAction="GetButtonID" />
          <menu id="MySubMenu" label="My Submenu" >
            <button id="MyButton2" label="Button on submenu" />
          </menu>
          <gallery id="galleryOne" label="My Gallery">
            <item id="item1" imageMso="HappyFace" />
            <item id="item2" imageMso="HappyFace" />
            <item id="item3" imageMso="HappyFace" />
            <item id="item4" imageMso="HappyFace" />
          </gallery>
        </contextMenu>
      </contextMenus>
    </customUI>
    ```

8. In **Solution Explorer**, choose **MyRibbon.cs** or **MyRibbon.vb**.

9. Add a callback method to the `Ribbon1` class for each control that you want to handle.

     The following callback method handles the **My Button** button. This code adds a string to the active document at the current location of the curser.

     [!code-vb[Trin_WordAddIn_Menus#2](../vsto/codesnippet/VisualBasic/trin_wordaddin_menus.vb/ribbon1.vb#2)]
     [!code-csharp[Trin_WordAddIn_Menus#2](../vsto/codesnippet/CSharp/trin_wordaddin_menus.cs/ribbon1.cs#2)]

## See also
- [Office UI customization](../vsto/office-ui-customization.md)
- [Walkthrough: Create Shortcut menus for bookmarks](../vsto/walkthrough-creating-shortcut-menus-for-bookmarks.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Customize context menus in Office 2010](/previous-versions/office/developer/office-2010/ee691832(v=office.14))
