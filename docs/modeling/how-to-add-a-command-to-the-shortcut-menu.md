---
title: "How to: Add a command to the shortcut menu"
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language Tools, walkthroughs"
  - "walkthroughs [Domain-Specific Language Tools]"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Add a command to the shortcut menu

You can add menu commands to your domain-specific language (DSL) so that your users can perform tasks that are specific to your DSL. The commands appear on the context (shortcut) menu when users right-click on the diagram. You can define a command so that it only appears in the menu in specific circumstances. For example, you can make the command visible only when the user clicks specific types of element, or elements in specific states.

In summary, the steps are performed in the DslPackage project as follows:

1. [Declare the command in Commands.vsct](#VSCT)

2. [Update the package version number in Package.tt](#version). You have to do this whenever you change Commands.vsct

3. [Write methods in the CommandSet class](#CommandSet) to make the command visible and to define what you want the command to do.

> [!NOTE]
> You can also modify the behavior of some existing commands such as Cut, Paste, Select All, and Print by overriding methods in CommandSet.cs. For more information, see [How to: Modify a Standard Menu Command](../modeling/how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md).

## Define a Command using MEF

Managed Extension Framework (MEF) provides an alternative method of defining menu commands on the diagram menu. Its primary purpose is to enable a DSL to be extended by you or by other parties. Users can choose to install just the DSL, or can install both the DSL and extensions. However, MEF also reduces the work of defining shortcut menu commands, after the initial work to enable MEF on the DSL.

Use the method in this topic if:

1. You want to define menu commands on menus other than the right-click shortcut menu.

2. You want to define specific groupings of commands in the menu.

3. You do not want to enable others to extend the DSL with their own commands.

4. You only want to define one command.

   Otherwise, consider using the MEF method to define commands. For more information, see [Extend your DSL by using MEF](../modeling/extend-your-dsl-by-using-mef.md).

## <a name="VSCT"></a> Declare the Command in Commands.Vsct
 Menu commands are declared in DslPackage\Commands.vsct. These definitions specify the labels of the menu items and where they appear on the menus.

 The file that you edit, Commands.vsct, imports definitions from several .h files, which are located in the directory *Visual Studio SDK install path*\VisualStudioIntegration\Common\Inc. It also includes GeneratedVsct.vsct, which is generated from your DSL definition.

 For more information about .vsct files, see [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md).

### To add the command

1. In **Solution Explorer**, under the **DslPackage** project, open Commands.vsct.

2. In the `Commands` element, define one or more buttons and a group. A *button* is an item on the menu. A *group* is a section in the menu. To define these items, add the following elements:

    ```xml
    <!-- Define a group - a section in the menu -->
    <Groups>
      <Group guid="guidCustomMenuCmdSet" id="grpidMyMenuGroup" priority="0x0100">
        <!-- These symbols are defined in GeneratedVSCT.vsct -->
        <Parent guid="guidCmdSet" id="menuidContext" />
      </Group>
    </Groups>
    <!-- Define a button - a menu item - inside the Group -->
    <Buttons>
      <Button guid="guidCustomMenuCmdSet" id="cmdidMyContextMenuCommand"
        priority="0x0100" type="Button">
        <Parent guid="guidCustomMenuCmdSet" id="grpidMyMenuGroup"/>
        <!-- If you do not want to place the command in your own Group,
             use Parent guid="guidCmdSet" id="grpidContextMain".
             These symbols are defined in GeneratedVSCT.vsct -->
        <CommandFlag>DynamicVisibility</CommandFlag>
        <Strings>
          <ButtonText>My Context Menu Command</ButtonText>
        </Strings>
      </Button>
    </Buttons>
    ```

    > [!NOTE]
    > Each button or group is identified by a GUID and an integer ID. You can create several groups and buttons with the same GUID. However, they must have different IDs. The GUID names and ID names are translated to actual GUIDs and numeric IDs in the `<Symbols>` node.

3. Add a visibility constraint for the command so that it is loaded only in the context of your domain-specific language. For more information, see [VisibilityConstraints Element](../extensibility/visibilityconstraints-element.md).

     To do this, add the following elements in the `CommandTable` element after the `Commands` element.

    ```xml
    <VisibilityConstraints>
      <!-- Ensures the command is only loaded for this DSL -->
      <VisibilityItem guid="guidCustomMenuCmdSet" id="cmdidMyContextMenuCommand"
        context="guidEditor"/>
    </VisibilityConstraints>
    ```

4. Define the names that you used for the GUIDs and IDs. To do this, add a `Symbols` element in the `CommandTable` element after the `Commands` element.

    ```xml
    <Symbols>
      <!-- Substitute a unique GUID for the placeholder: -->
      <GuidSymbol name="guidCustomMenuCmdSet"
        value="{00000000-0000-0000-0000-000000000000}" >
        <IDSymbol name="grpidMyMenuGroup" value="0x01001"/>
        <IDSymbol name="cmdidMyContextMenuCommand" value="0x00001"/>
      </GuidSymbol>
    </Symbols>
    ```

5. Replace `{000...000}` with a GUID that identifies your groups and menu items. To obtain a new GUID, use the **Create GUID** tool on the **Tools** menu.

    > [!NOTE]
    > If you add more groups or menu items, you can use the same GUID. However, you must use new values for the `IDSymbols`.

6. In the code you have copied from this procedure, replace each occurrence of the following strings with your own strings:

    - `grpidMyMenuGroup`

    - `cmdidMyContextMenuCommand`

    - `guidCustomMenuCmdSet`

    - `My Context Menu Command`

## <a name="version"></a> Update the Package Version in Package.tt
 Whenever you add or change a command, update the `version` parameter of the <xref:Microsoft.VisualStudio.Shell.ProvideMenuResourceAttribute> that is applied to the package class before you release the new version of your domain-specific language.

 Because the package class is defined in a generated file, update the attribute in the text template file that generates the Package.cs file.

### To update the Package.tt file

1. In **Solution Explorer**, in the **DslPackage** project, in the **GeneratedCode** folder, open the Package.tt file.

2. Locate the `ProvideMenuResource` attribute.

3. Increment the `version` parameter of the attribute, which is the second parameter. If you want, you can write the parameter name explicitly to remind you of its purpose. For example:

     `[VSShell::ProvideMenuResource("1000.ctmenu", version: 2 )]`

## <a name="CommandSet"></a> Define the Behavior of the Command

Your DSL already has some commands that are implemented in a partial class that is declared in DslPackage\GeneratedCode\CommandSet.cs. To add new commands, you must extend this class by creating a new file that contains a partial declaration of the same class. The name of the class is usually *\<YourDslName>*`CommandSet`. It's useful to begin by verifying the name of the class and inspecting its contents.

The command set class is derived from <xref:Microsoft.VisualStudio.Modeling.Shell.CommandSet>.

### Extend the CommandSet class

1. In Solution Explorer, in the DslPackage project, open the GeneratedCode folder and then look under CommandSet.tt and open its generated file CommandSet.cs. Note the namespace and the name of the first class that is defined there. For example, you might see:

     `namespace Company.Language1`

     `{ ...  internal partial class Language1CommandSet : ...`

2. In **DslPackage**, create a folder that is named **Custom Code**. In this folder, create a new class file that is named `CommandSet.cs`.

3. In the new file, write a partial declaration that has the same namespace and name as the generated partial class. For example:

     `namespace Company.Language1 /* Make sure this is correct */`

     `{ internal partial class Language1CommandSet { ...`

     > [!NOTE]
     > If you used the class template to create the new file, you must correct both the namespace and the class name.

Your command set code will typically need to import the following namespaces:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
using Microsoft.VisualStudio.Modeling.Shell;
```

Adjust the namespace and the class name to match those in the generated CommandSet.cs:

```csharp
namespace Company.Language1 /* Make sure this is correct */
{
  // Same class as the generated class.
  internal partial class Language1CommandSet
  {
```

You must define two methods, one to determine when the command will be visible on the right-click (context) menu, and the other to perform the command. These methods are not overrides; instead, you register them in a list of commands.

### Define when the command will be visible
 For each command, define an `OnStatus...` method that determines whether the command will appear on the menu, and whether it will be enabled or greyed out. Set the `Visible` and `Enabled` properties of the `MenuCommand`, as shown in the following example. This method is called in order to construct the shortcut menu every time that the user right-clicks the diagram, so it must work quickly.

 In this example, the command is visible only when the user has selected a particular type of shape, and is enabled only when at least one of the selected elements is in a particular state. The example is based on the Class Diagram DSL template, and ClassShape and ModelClass are types that are defined in the DSL:

```csharp
private void OnStatusMyContextMenuCommand(object sender, EventArgs e)
{
  MenuCommand command = sender as MenuCommand;
  command.Visible = command.Enabled = false;
  foreach (object selectedObject in this.CurrentSelection)
  {
    ClassShape shape = selectedObject as ClassShape;
    if (shape != null)
    {
      // Visibility depends on what is selected.
      command.Visible = true;
      ModelClass element = shape.ModelElement as ModelClass;
      // Enabled depends on state of selection.
      if (element != null && element.Comments.Count == 0)
      {
        command.Enabled = true;
        return; // seen enough
} } } }
```

The following fragments are frequently useful in OnStatus methods:

- `this.CurrentSelection`. The shape that the user right-clicked is always included in this list. If the user clicks on a blank part of the diagram, the Diagram is the only member of the list.

- `this.IsDiagramSelected()` - `true` if the user clicked a blank part of the diagram.

- `this.IsCurrentDiagramEmpty()`

- `this.IsSingleSelection()` - the user did not select multiple objects

- `this.SingleSelection` - the shape or diagram that the user right-clicked

- `shape.ModelElement as MyLanguageElement` - the model element represented by a shape.

As a general guideline, make the `Visible` property depend on what is selected, and make the `Enabled` property depend on the state of the selected elements.

An OnStatus method should not change the state of the Store.

### Define what the command does
 For each command, define an `OnMenu...` method that performs the required action when the user clicks the menu command.

 If you make changes to model elements, you must do so inside a transaction. For more information, see [How to: Modify a Standard Menu Command](../modeling/how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md).

 In this example, `ClassShape`, `ModelClass`, and `Comment` are types that are defined in the DSL, which is derived from the Class Diagram DSL template.

```csharp
private void OnMenuMyContextMenuCommand(object sender, EventArgs e)
{
  MenuCommand command = sender as MenuCommand;
  Store store = this.CurrentDocData.Store;
  // Changes to elements and shapes must be performed in a Transaction.
  using (Transaction transaction =
       store.TransactionManager.BeginTransaction("My command"))
  {
    foreach (object selectedObject in this.CurrentSelection)
    {
      // ClassShape is defined in my DSL.
      ClassShape shape = selectedObject as ClassShape;
      if (shape != null)
      {
        // ModelClass is defined in my DSL.
        ModelClass element = shape.ModelElement as ModelClass;
        if (element != null)
        {
          // Do required action here - for example:

          // Create a new element. Comment is defined in my DSL.
          Comment newComment = new Comment(element.Partition);
          // Every element must be the target of an embedding link.
          element.ModelRoot.Comments.Add(newComment);
          // Set properties of new element.
          newComment.Text = "This is a comment";
          // Create a reference link to existing object.
          element.Comments.Add(newComment);
        }
      }
    }
    transaction.Commit(); // Don't forget this!
  }
}
```

 For more information about how to navigate from object to object in the model, and about how to create objects and links, see [How to: Modify a Standard Menu Command](../modeling/how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md).

### Register the command
 Repeat in C# the declarations of the GUID and ID values that you made in the Symbols section of CommandSet.vsct:

```csharp
private Guid guidCustomMenuCmdSet =
    new Guid("00000000-0000-0000-0000-000000000000");
private const int grpidMyMenuGroup = 0x01001;
private const int cmdidMyContextMenuCommand = 1;
```

 Use the same GUID value as you inserted in **Commands.vsct**.

> [!NOTE]
> If you change the Symbols section of the VSCT file, you must also change these declarations to match. You should also increment the version number in Package.tt

 Register your menu commands as part of this command set. `GetMenuCommands()` is called once when the diagram is initialized:

```csharp
protected override IList<MenuCommand> GetMenuCommands()
{
  // Get the list of generated commands.
  IList<MenuCommand> commands = base.GetMenuCommands();
  // Add a custom command:
  DynamicStatusMenuCommand myContextMenuCommand =
    new DynamicStatusMenuCommand(
      new EventHandler(OnStatusMyContextMenuCommand),
      new EventHandler(OnMenuMyContextMenuCommand),
      new CommandID(guidCustomMenuCmdSet, cmdidMyContextMenuCommand));
  commands.Add(myContextMenuCommand);
  // Add more commands here.
  return commands;
}
```

## Test the Command
 Build and run the DSL in an experimental instance of Visual Studio. The command should appear in the shortcut menu in the situations you have specified.

### To exercise the command

1. On the **Solution Explorer** toolbar, click **Transform All Templates**.

2. Press **F5** to rebuild the solution, and start debugging the domain-specific language in the experimental build.

3. In the experimental build, open a sample diagram.

4. Right-click various items in the diagram to verify that the command is correctly enabled or disabled, and appropriately shown or hidden, depending on the selected item.

## Troubleshoot

**Command does not appear in menu:**

- The command will appear only in debugging instances of Visual Studio, until you install the DSL package. For more information, see [Deploying Domain-Specific Language Solutions](msi-and-vsix-deployment-of-a-dsl.md).

- Make sure that your experimental sample has the correct file name extension for this DSL. To check the file name extension, open DslDefinition.dsl in the main instance of Visual Studio. Then in DSL Explorer, right-click the Editor node, and then click Properties. In the Properties window, examine the FileExtension property.

- Did you [increment the package version number](#version)?

- Set a breakpoint at the beginning of your OnStatus method. It should break when you right-click over any part of the diagram.

**OnStatus method is not called**:

- Make sure that the GUIDs and IDs in your CommandSet code match those in the Symbols section of Commands.vsct.

- In Commands.vsct, make sure that the GUID and ID in every Parent node identify the correct parent Group.

- In a Visual Studio command prompt, type devenv /rootsuffix exp /setup. Then restart the debugging instance of Visual Studio.

- Step through the OnStatus method to verify that command.Visible and command.Enabled are set to true.

**Wrong menu text appears, or command appears in the wrong place**:

- Make sure that the combination of GUID and ID is unique to this command.

- Make sure that you have uninstalled earlier versions of the package.

## See also

- [Writing code to customize a domain-specific language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
- [How to: Modify a standard menu command](../modeling/how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md)
- [Deploying domain-specific language solutions](msi-and-vsix-deployment-of-a-dsl.md)
- [Sample code: Circuit diagrams](https://code.msdn.microsoft.com/Visualization-Modeling-SDK-763778e8)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]
