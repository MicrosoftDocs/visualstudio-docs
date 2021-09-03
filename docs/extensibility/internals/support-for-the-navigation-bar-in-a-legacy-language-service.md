---
title: Support Navigation bar in a legacy language service
description: Learn how to support the Navigation Bar in a legacy language service. The Navigation bar in the editor view displays the types and members in the file.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Navigation bar, supporting in language services [managed package framework]
- language services [managed package framework], Navigation bar
ms.assetid: 2d301ee6-4523-4b82-aedb-be43f352978e
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Support for the Navigation Bar in a Legacy Language Service
The Navigation bar at the top of the editor view displays the types and members in the file. Types are shown in the left drop-down, and members are shown in the right drop-down. When the user selects a type, the caret is placed on the first line of the type. When the user selects a member, the caret is placed on the definition of the member. The drop-down boxes are updated to reflect the current location of the caret.

## Displaying and Updating the Navigation bar
 To support the Navigation bar, you must derive a class from the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> class and implement the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method. When your language service is given a code window, the base <xref:Microsoft.VisualStudio.Package.LanguageService> class instantiates the <xref:Microsoft.VisualStudio.Package.CodeWindowManager>, which contains the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow> object representing the code window. The <xref:Microsoft.VisualStudio.Package.CodeWindowManager> object is then given a new <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> object. The <xref:Microsoft.VisualStudio.Package.LanguageService.CreateDropDownHelper%2A> method gets a <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> object. If you return an instance of your <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> class, the <xref:Microsoft.VisualStudio.Package.CodeWindowManager> calls your <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method to populate the internal lists and passes your <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> object to the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] drop-down bar manager. The drop-down bar manager, in turn, calls the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.SetDropdownBar%2A> method on your <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> object to establish the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsDropdownBar> object that holds the two drop-down bars.

 When the caret moves, the <xref:Microsoft.VisualStudio.Package.LanguageService.OnIdle%2A> method calls the <xref:Microsoft.VisualStudio.Package.LanguageService.OnCaretMoved%2A> method. The base <xref:Microsoft.VisualStudio.Package.LanguageService.OnCaretMoved%2A> method calls the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method in your <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> class to update the state of the Navigation bar. You pass a set of <xref:Microsoft.VisualStudio.Package.DropDownMember> objects to this method. Each object represents an entry in the drop-down.

## The Contents of the Navigation Bar
 The Navigation bar usually contains a list of types and a list of members. The list of types includes all types available in the current source file. The type names include the complete namespace information. The following is an example of C# code with two types:

```csharp
namespace TestLanguagePackage
{
    public class TestLanguageService
    {
        internal struct Token
        {
            int tokenID;
        }
        private Tokens[] tokens;
        private string serviceName;
    }
}
```

 The type list will display `TestLanguagePackage.TestLanguageService` and `TestLanguagePackage.TestLanguageService.Tokens`.

 The members list displays the available members of the type that is selected in the types list. Using the code example above, if `TestLanguagePackage.TestLanguageService` is the type that is selected, the members list would contain the private members `tokens` and `serviceName`. The internal structure `Token` is not displayed.

 You can implement the members list to make the name of a member bold when the caret is placed inside it. Members can also be displayed in grayed out text, indicating that they are not within the scope where the caret is currently positioned.

## Enabling Support for the Navigation Bar
 To enable support for the Navigation bar, you must set the `ShowDropdownBarOption` parameter of the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute> attribute to `true`. This parameter sets the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.ShowNavigationBar%2A> property. To support the Navigation bar, you must implement the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> object in the <xref:Microsoft.VisualStudio.Package.LanguageService.CreateDropDownHelper%2A> method on the <xref:Microsoft.VisualStudio.Package.LanguageService> class.

 In your implementation of the <xref:Microsoft.VisualStudio.Package.LanguageService.CreateDropDownHelper%2A> method, if the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.ShowNavigationBar%2A> property is set to `true`, you can return a <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars> object. If you do not return the object, the Navigation bar is not displayed.

 The option to show the Navigation bar can be set by the user, so it is possible for this control to be reset while the editor view is open. The user must close and reopen the editor window before the change takes place.

## Implementing Support for the Navigation Bar
 The <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method takes two lists (one for each drop-down) and two values representing the current selection in each list. The lists and the selection values can be updated, in which case the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method must return `true` to indicate that the lists have changed.

 As the selection changes in the types drop-down, the members list must be updated to reflect the new type. What is shown in the members list can be either:

- The list of members for the current type.

- All the members available in the source file, but with all members not in the current type displayed in grayed-out text. The user can still select the grayed-out members, so they can be used for quick navigation, but the color indicates that they are not part of the currently selected type.

  An implementation of the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method typically performs the following steps:

1. Get a list of current declarations for the source file.

     There are a number of ways to populate the lists. One approach is to create a custom method on your version of the <xref:Microsoft.VisualStudio.Package.LanguageService> class that calls the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method with a custom parse reason that returns a list of all declarations. Another approach might be to call the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method directly from the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method with the custom parse reason. A third approach might be to cache the declarations in the <xref:Microsoft.VisualStudio.Package.AuthoringScope> class returned by the last full parsing operation in the <xref:Microsoft.VisualStudio.Package.LanguageService> class and retrieve that from the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method.

2. Populate or update the list of types.

     The contents of the types list may to be updated when the source has changed or if you have chosen to change the text styling of the types based on the current caret position. Note that this position is passed to the <xref:Microsoft.VisualStudio.Package.TypeAndMemberDropdownBars.OnSynchronizeDropdowns%2A> method.

3. Determine the type to select in the types list based on the current caret position.

     You can search the declarations that were obtained in step 1 to find the type that encloses the current caret position, and then search the types list for that type to determine its index into the types list.

4. Populate or update the list of members based on the selected type.

     The members list reflects what is currently displayed in the **Members** drop-down. The contents of the members list may need to be updated if the source has changed or if you are displaying only the members of the selected type and the selected type has changed. If you choose to display all the members in the source file, then the text styling of each member in the list needs to be updated if the currently selected type has changed.

5. Determine the member to select in the members list based on the current caret position.

     Search the declarations that were obtained in step 1 for the member that contains the current caret position, then search the members list for that member to determine its index into the member list.

6. Return `true` if any changes have been made to the lists or the selections in either list.
