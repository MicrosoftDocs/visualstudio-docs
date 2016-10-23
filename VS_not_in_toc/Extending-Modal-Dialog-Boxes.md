---
title: "Extending Modal Dialog Boxes"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 478743dc-9fd9-46d7-9739-859fb8841a4f
caps.latest.revision: 11
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Extending Modal Dialog Boxes
To guarantee functional and visual compatibility with Visual Studio, create modal dialog boxes for Visual Studio extensions by deriving dialog box windows from the <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow?qualifyHint=True> object. Dialog boxes derived in this manner can also provide additional functionality; for example, you can set F1 Help targets and enable minimize and maximize on the window.  
  
## Creating Modal Dialog Boxes  
  
1.  In your project, add a reference to System.XAML.  
  
2.  In **Solution Explorer**, right-click the project, click **Add**, and then click **Window**.  
  
3.  Name the window, and then click **Add**.  
  
     An empty XAML window appears in the designer.  
  
4.  In the top-level `Window` element, add a namespace declaration for <xref:Microsoft.VisualStudio.PlatformUI?qualifyHint=False>, and change the `Window` element to a <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow?qualifyHint=True> element, as shown in the following example.  
  
     [!CODE [VSModalDialog#02](../CodeSnippet/VS_Snippets_VSSDK/vsmodaldialog#02)]  
  
5.  Add buttons, labels, and other controls from the **Toolbox**, type the text labels, and adjust the appearance of the dialog box.  
  
6.  Switch to code view.  
  
7.  In the class definition, set the class to inherit from <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow?qualifyHint=False>. (By default, the class inherits from <xref:System.Windows.Window?qualifyHint=True>.)  
  
8.  Add event handlers for buttons and other controls.  
  
#### To add F1 Help to a modal dialog box  
  
1.  To the constructor, add a parameter that takes a string as its argument and set the constructor to inherit from the base constructor by using the same parameter, as shown in the following example.  
  
     [!CODE [VSModalDialog#12](../CodeSnippet/VS_Snippets_VSSDK/vsmodaldialog#12)]  
  
     This constructor sets the <xref:Microsoft.VisualStudio.PlatformUI.DialogWindowBase.HasHelpButton?qualifyHint=False> property to `true` and enables the received string to be used as a keyword when a user presses F1 or clicks the **Help** button.  
  
#### To add Minimize and Maximize buttons to a modal dialog box  
  
1.  In the constructor function, set the <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow.hasMinimizeButton?qualifyHint=False> and <xref:Microsoft.VisualStudio.PlatformUI.DialogWindow.hasHMaximizeButton?qualifyHint=False> properties to `true`, as shown in the following example.  
  
     [!CODE [VSModalDialog#13](../CodeSnippet/VS_Snippets_VSSDK/vsmodaldialog#13)]  
  
    > [!WARNING]
    >  When **Minimize** and **Maximize** buttons are shown, the **Help** button is hidden, even if the <xref:Microsoft.VisualStudio.PlatformUI.DialogWindowBase.HasHelpButton?qualifyHint=False> property is set to `true`.  
  
## Example  
 The following example shows a modal dialog box that has two constructors. The first constructor takes an F1 keyword as an argument and displays a **Help** button. The second constructor takes no arguments, but displays **Minimize** and **Maximize** buttons. When you click the **Yes** button, a second instance of the dialog box is invoked and has Help enabled.  
  
 [!CODE [VSModalDialog#01](../CodeSnippet/VS_Snippets_VSSDK/vsmodaldialog#01)]  
  
 [!CODE [VSModalDialog#11](../CodeSnippet/VS_Snippets_VSSDK/vsmodaldialog#11)]  
  
 The following code invokes the dialog box from an event handler.  
  
 [!CODE [VSModalDialog#21](../CodeSnippet/VS_Snippets_VSSDK/vsmodaldialog#21)]  
  
## See Also  
 [Creating and Managing Modal Dialog Boxes](../Topic/Creating%20and%20Managing%20Modal%20Dialog%20Boxes.md)