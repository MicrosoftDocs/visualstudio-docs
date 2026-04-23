---
title: Code cleanup refactorings
description: Learn how to use Quick Actions and Refactorings to add null checks, remove unreachable code, remove unused references, handle unused values and parameters, and sort usings in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Code cleanup refactorings

Visual Studio provides several refactorings for cleaning up and improving code quality. You can access these refactorings through the **Quick Actions and Refactorings** menu (**Ctrl**+**.**).

## Add null checks for all parameters

**Applies to:** C#

This refactoring creates and adds `if` statements that check nullity of all the nullable, non-checked parameters in a method, making the program more robust.

1. Place your cursor on any parameter within the method.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Quick actions and refactorings.](media/add-null-checks-for-all-parameters.png)

1. Select the option to **Add null checks for all parameters**.

   ![Screenshot of Add null checks for all.](media/add-null-checks-for-all.png)

## Remove unreachable code

**Applies to:** C#, Visual Basic

This refactoring removes code that will never be executed because there's no path to the code snippet, improving readability and maintainability.

1. Place your cursor anywhere in the faded out code that is unreachable:

![Screenshot of Faded unreachable code.](media/unreachablecode-faded-cs.png)

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Remove unreachable code** from the Preview window popup.
   - **Mouse**
      - Right-click the code, select the **Quick Actions and Refactorings** menu and select **Remove unreachable code** from the Preview window popup.

1. When you're happy with the change, press **Enter** or click the fix in the menu and the changes will be committed.

Example:

```csharp
// Before
private void Method()
{
    throw new Exception(nameof(Method));
    Console.WriteLine($"Exception for method {nameof(Method)}");
}

// After
private void Method()
{
    throw new Exception(nameof(Method));
}
```

## Remove unused references

**Applies to:** C#, Visual Basic

For [SDK style projects](../../msbuild/how-to-use-project-sdk.md) only, this refactoring removes unused project references and NuGet packages, helping save space and reduce startup time.

> [!NOTE]
> You can use the [.NET Upgrade Assistant](https://dotnet.microsoft.com/platform/upgrade-assistant) right from Visual Studio to upgrade your app to the latest .NET versions.

1. Verify that the option is enabled.

   Select **Tools** > **Options** > **Text Editor** > **C#** > **Advanced**, and enable **Show "Removed Unused References" command in Solution Explorer**.

1. In Solution Explorer, right click on a project name or the **Dependencies** node.

1. Select **Remove Unused References**.

   ::: moniker range=">= vs-2022"
   ![Screenshot of Remove Unused References command.](media/vs-2022/remove-unused-references-command.png)
   ::: moniker-end

1. The **Remove Unused References** dialog opens, displaying references that have no usage in source code. Unused references are pre-selected for removal with an option to preserve references by selecting `Keep` from the Action drop down.

   ::: moniker range=">= vs-2022"
   ![Screenshot of Remove Unused References dialog.](media/vs-2022/remove-unused-references-dialog.png)
   ::: moniker-end

1. Click `Apply` to remove selected references.

## Unused value assignments, variables, and parameters

**Applies to:** C#, Visual Basic

This feature fades out unused parameters and generates a warning for unused expression values. The compiler also performs a flow analysis to find any unused value assignments. Unused value assignments fade out and a light bulb appears with a [Quick Action](../quick-actions.md) to remove the redundant assignment. Unused variables with unknown values show a [Quick Action](../quick-actions.md) suggestion to use [discards](/dotnet/csharp/discards) instead.

  ![Screenshot of Unused parameter.](media/unused-parameter.png)
  ![Screenshot of Unused value.](media/unused-value.png)
  ![Screenshot of Unused value assignment.](media/unused-value-assignment.png)
  ![Screenshot of Unused value discard.](media/unused-value-discard.png)

## Sort usings

**Applies to:** C#, Visual Basic

This refactoring sorts `using` directives at the top of your file alphabetically, making it easier to find a specific using directive.

1. Select **Edit** from the menu bar.
1. Select **Intellisense** > **Sort Usings**.

   ![Screenshot of Sort usings.](media/sort-usings.png)

1. You can also configure different settings for `using` directives in **Tools** > **Options** > **Text Editor** > **C#** > **Advanced**.

   ![Screenshot of Sort usings configuration options.](media/sort-usings-configuration-options.png)

## Related content

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
