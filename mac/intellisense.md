---
title: "IntelliSense"
description: "Information on using IntelliSense in Visual Studio for Mac"
author: cobey
ms.author: cobey
ms.date: 08/16/2019
---

<!---Recommended: Remove all the comments in this template before you sign-off or merge to master.--->

<!---overview articles are for new customers and explain the service from a technical point of view.
They are not intended to define benefits or value prop; that would be in marketing content.
--->

# IntelliSense

IntelliSense provides several features to help enhance the experience of writing and editing code. For example, the IntelliSense engine provides not only code completion but also member lists, parameter info and quick info. 

In Visual Studio for Mac, IntelliSense is provided by the core editor service, and is supported in many languages, such as C#, XAML, F#, JavaScript and more. Visual Studio for Mac also features advanced IntelliSense features, such as the ability to show completions from libraries which are not yet imported into the project.

## Code Completion

When typing within a supported file, such as a C# code file, valid completion for the string you are currently typing will be displayed in a completion list. As you type, the list will automatically update to include only completions which are still valid for the string as entered. Furthermore, if you delete text, the list will again auto-update to include the wider range of possibilities for completing the given string. 

The completion window also offers support for filtering the included completions by type. That is to say, it is possible to limit the members of the list to only represent types such as classes or delegates. This filtering processes can be enabled either through clicking on a specific icon representing the type which will be filtered or via keyboard shortcuts corresponding with a given type. The icons are as follows:

| Icon                         | Name          | Keyword    | Hotkey |
| -----------------------------|---------------| -----------|--------|
| ![](media/classes-icon.png)  | class         | `class`    |  ⌥C
| ![](media/constant-icon.png) | constant      | `const`    |  ⌥O
| ![](media/delegate-icon.png) | delegate      | `delegate` |  ⌥D
| ![](media/enums-icon.png)    | enum          | `enum`     |  ⌥E
| ![](media/event-icon.png)    | event         |            |  ⌥V
| ![](media/fields-icon.png)   | field         |            |  ⌥F
| ![](media/interface-icon.png)| interface     | `interface`|  ⌥I
| ![](media/keyword-icon.png)  | keyword       |            |  ⌥K
| ![](media/method-icon.png)   | method        |            |  ⌥M
| ![](media/namespace-icon.png)| namespace     | `namespace`|  ⌥N
| ![](media/props-icon.png)    | property      |            |  ⌥P
| ![](media/snippet-icon.png)  | snippet       | `class`    |  ⌥S
| ![](media/struct-icon.png)   | structure     | `struct`   |  ⌥S
|                              |                |            |  

By clicking on any of the icons, or by pressing the corresponding hotkeys, the completion list will limit to only types as defined by the filter set.  


![Intellisense Type Filtering](media/intellisense-typefiltering.gif)

## Show Import Items

By default, IntelliSense completion will only display completions from libraries which you do not have imported into your project. That is to say, if you do not have `System.Collections.Generic` imported via `using` then you would not have a completion for `List<>`. In order to display completions from libraries which are you not imported, you must enable Show Import Items within the Preferences for Visual Studio for Mac. This can be found under Preferences > Text Edtior > IntelliSense:

![IntelliSense Show Import Items](media/intellisense-showimport.png)

Once Show Import Items is enabled, the completion list will include completions that you have not yet imported. Upon selecting an item which corresponds to an un-imported library, the `using` statement for that library will automatically be added to the header of the code file. The name of the library to which the completion belongs is also listed along with the completion itself.

![Show Import Items List](media/intellisense-importaction.png)

## Parameter Window

Another feature of IntelliSense is the ability to provide a parameter list where appropriate. The parameter list provides details as to the method signatures for the code being called. You can cycle through each of the available parameter signatures to determine the most appropriate for your needs. In addition to the details of the types of data allowed, there may also be a description as defined in the target method via XML comments.

![Parameter List](media/intellisense-parameter.png)

As you fill in the parameters, the parameter that you are currently editing will be bolded, while the inactive parameters will have the standard weight. 

![Bold Parameter](media/intellisense-parameter-bold.png)

## Triggering Completion Window and Parameter Window

The completion window will be triggered automatically as you type within your source file. However, you can also trigger the completion window by using the shortcut `control-space`. This will cause the completion list to appear at the current position of your caret. 

You can also manually trigger the appearance of the parameter window by typing `control-shift-space`. When your caret is in the position that is valid for a parameter list, the parameter list will appear near the caret position.




## Next steps

<!---Some context for the following links goes here--->
- [link to next logical step for the customer](global-quickstart-template.md)

<!--- Required:
In Overview articles, provide at least one next step and no more than three.
Next steps in overview articles will often link to a quickstart.
Use regular links; do not use a blue box link. What you link to will depend on what is really a next step for the customer.
Do not use a "More info section" or a "Resources section" or a "See also section".
--->