---
title: Validation in a Domain-Specific Language
description: Learn how you can define validation constraints to verify that the model created by the user is meaningful.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Domain-Specific Language, constraints
- Domain-Specific Language, validation
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Validation in a Domain-Specific Language

As the author of a domain-specific language (DSL), you can define validation constraints to verify that the model created by the user is meaningful. For example, if your DSL allows users to draw a family tree of people and their ancestors, you could write a constraint that ensures that children have birth dates after their parents.

 You can have the validation constraints execute when the model is saved, when it is opened, and when the user explicitly runs the **Validate** menu command. You can also execute validation under program control. For example, you could execute validation in response to a change in a property value or relationship.

 Validation is particularly important if you are writing text templates or other tools that process your users' models. Validation ensures that the models fulfill the preconditions assumed by those tools.

> [!WARNING]
> You can also allow validation constraints to be defined in separate extensions to your DSL, along with extension menu commands and gesture handlers. Users can choose to install these extensions in addition to your DSL. For more information, see [Extend your DSL by using MEF](../modeling/extend-your-dsl-by-using-mef.md).

## Running Validation
 When a user is editing a model, that is, an instance of your domain-specific language, the following actions can run validation:

- Right-click the diagram and select **Validate All**.

- Right-click the top node in the Explorer of your DSL and select **Validate All**

- Save the model.

- Open the model.

- In addition, you can write program code that runs validation, for example, as part of a menu command or in response to a change.

  Any validation errors will appear in the **Error List** window. The user can double-click an error message to select the model elements that are the cause of the error.

## Defining Validation Constraints
 You define validation constraints by adding validation methods to the domain classes or relationships of your DSL. When validation is run, either by the user or under program control, some or all of the validation methods are executed. Each method is applied to each instance of its class, and there can be several validation methods in each class.

 Each validation method reports any errors that it finds.

> [!NOTE]
> Validation methods report errors, but do not change the model. If you want to adjust or prevent certain changes, see [Alternatives to Validation](#alternatives).

#### To define a validation constraint

1. Enable validation in the **Editor\Validation** node:

   1. Open **Dsl\DslDefinition.dsl**.

   2. In DSL Explorer, expand the **Editor** node and select **Validation**.

   3. In the Properties window, set the **Uses**  properties to `true`. It is most convenient to set all these properties.

   4. Click **Transform All Templates** in the **Solution Explorer** toolbar.

2. Write partial class definitions for one or more of your domain classes or domain relationships. Write these definitions in a new code file in the **Dsl** project.

3. Prefix each class with this attribute:

   ```csharp
   [ValidationState(ValidationState.Enabled)]
   ```

   - By default, this attribute will also enable validation for derived classes. If you want to disable validation for a specific derived class, you can use `ValidationState.Disabled`.

4. Add validation methods to the classes. Each validation method can have any name, but have one parameter of type <xref:Microsoft.VisualStudio.Modeling.Validation.ValidationContext>.

    It must be prefixed with one or more `ValidationMethod` attributes:

   ```csharp
   [ValidationMethod (ValidationCategories.Open | ValidationCategories.Save | ValidationCategories.Menu ) ]
   ```

    The ValidationCategories specify when the method is executed.

   For example:

```csharp
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;

namespace Company.FamilyTree
{
// Allow validation methods in this class:
[ValidationState(ValidationState.Enabled)]
// In this DSL, ParentsHaveChildren is a domain relationship
// from Person to Person:
public partial class ParentsHaveChildren
{
  // Identify the method as a validation method:
  [ValidationMethod
  ( // Specify which events cause the method to be invoked:
    ValidationCategories.Open // On file load.
  | ValidationCategories.Save // On save to file.
  | ValidationCategories.Menu // On user menu command.
  )]
  // This method is applied to each instance of the
  // type (and its subtypes) in a model:
  private void ValidateParentBirth(ValidationContext context)
  {
    // In this DSL, the role names of this relationship
    // are "Child" and "Parent":
     if (this.Child.BirthYear < this.Parent.BirthYear
        // Allow user to leave the year unset:
        && this.Child.BirthYear != 0)
      {
        context.LogError(
             // Description:
                       "Child must be born after Parent",
             // Unique code for this error:
                       "FAB001ParentBirthError",
              // Objects to select when user double-clicks error:
                       this.Child,
                       this.Parent);
    }
  }
}
```

 Notice the following points about this code:

- You can add validation methods to domain classes or domain relationships. The code for these types is in **Dsl\Generated Code\Domain\*.cs**.

- Each validation method is applied to every instance of its class and its subclasses. In the case of a domain relationship, each instance is a link between two model elements.

- Validation methods are not applied in any specified order, and each method is not applied to the instances of its class in any predictable order.

- It is usually bad practice for a validation method to update the store content, because this would lead to inconsistent results. Instead, the method should report any error by calling `context.LogError`, `LogWarning` or `LogInfo`.

- In the LogError call, you can provide a list of model elements or relationship links that will be selected when the user double-clicks the error message.

- For information about how to read the model in program code, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

  The example applies to the following domain model. The ParentsHaveChildren relationship has roles that are named Child and Parent.

  ![DSL Definition diagram &#45; family tree model](../modeling/media/familyt_person.png)

## Validation Categories
 In the <xref:Microsoft.VisualStudio.Modeling.Validation.ValidationMethodAttribute> attribute, you specify when the validation method should be executed.

|Category|Execution|
|-|-|
|<xref:Microsoft.VisualStudio.Modeling.Validation.ValidationCategories.Menu>|When the user invokes the Validate menu command.|
|<xref:Microsoft.VisualStudio.Modeling.Validation.ValidationCategories>|When the model file is opened.|
|<xref:Microsoft.VisualStudio.Modeling.Validation.ValidationCategories>|When the file is saved. If there are validation errors, the user will be given the option of canceling the save operation.|
|<xref:Microsoft.VisualStudio.Modeling.Validation.ValidationCategories>|When the file is saved. If there are errors from methods in this category, the user is warned that it might not be possible to re-open the file.<br /><br /> Use this category for validation methods that test for duplicated names or IDs, or other conditions that might cause loading errors.|
|<xref:Microsoft.VisualStudio.Modeling.Validation.ValidationCategories>|When the ValidateCustom method is called. Validations in this category can be invoked only from program code.<br /><br /> For more information, see [Custom Validation Categories](#custom).|

## Where to Place Validation Methods
 You can often achieve the same effect by placing a validation method on a different type. For example, you could add a method to the Person class instead of the ParentsHaveChildren relationship, and have it iterate through the links:

```
[ValidationState(ValidationState.Enabled)]
public partial class Person
{[ValidationMethod
 ( ValidationCategories.Open
 | ValidationCategories.Save
 | ValidationCategories.Menu
 )
]
  private void ValidateParentBirth(ValidationContext context)
  {
    // Iterate through ParentHasChildren links:
    foreach (Person parent in this.Parents)
    {
        if (this.BirthYear <= parent.BirthYear)
        { ...
```

 **Aggregating validation constraints.** To apply validation in a predictable order, define a single validation method on an owner class, such the root element of your model. This technique also lets you aggregate multiple error reports into a single message.

 Drawbacks are that the combined method is less easy to manage, and that the constraints must all have the same `ValidationCategories`. We therefore recommend that you keep each constraint in a separate method if possible.

 **Passing values in the context cache.** The context parameter has a dictionary into which you can place arbitrary values. The dictionary persists for the life of the validation run. A particular validation method could, for example, keep an error count in the context, and use it to avoid flooding the error window with repeated messages. For example:

```csharp
List<ParentsHaveChildren> erroneousLinks;
if (!context.TryGetCacheValue("erroneousLinks", out erroneousLinks))
erroneousLinks = new List<ParentsHaveChildren>();
erroneousLinks.Add(this);
context.SetCacheValue("erroneousLinks", erroneousLinks);
if (erroneousLinks.Count < 5) { context.LogError( ... ); }
```

## Validation of Multiplicities
 Validation methods for checking minimum multiplicity are automatically generated for your DSL. The code is written to **Dsl\Generated Code\MultiplicityValidation.cs**. These methods take effect when you enable validation in the **Editor\Validation** node in DSL Explorer.

 If you set the multiplicity of a role of a domain relationship to be 1..* or 1..1, but the user does not create a link of this relationship, a validation error message will appear.

 For example, if your DSL has classes Person and Town, and a relationship PersonLivesInTown with a relationship **1..\\*** at the Town role, then for each Person that has no Town, an error message will appear.

## Running Validation from Program Code
 You can run validation by accessing or creating a ValidationController. If you want the errors to be displayed to the user in the error window, use the ValidationController that is attached to your diagram's DocData. For example, if you are writing a menu command, `CurrentDocData.ValidationController` is available in the command set class:

```csharp
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;
using Microsoft.VisualStudio.Modeling.Shell;
...
partial class MyLanguageCommandSet
{
  private void OnMenuMyContextMenuCommand(object sender, EventArgs e)
  {
   ValidationController controller = this.CurrentDocData.ValidationController;
...
```

 For more information, see [How to: Add a Command to the Shortcut Menu](../modeling/how-to-add-a-command-to-the-shortcut-menu.md).

 You can also create a separate validation controller, and manage the errors yourself. For example:

```csharp
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;
using Microsoft.VisualStudio.Modeling.Shell;
...
Store store = ...;
VsValidationController validator = new VsValidationController(s);
// Validate all elements in the Store:
if (!validator.Validate(store, ValidationCategories.Save))
{
  // Deal with errors:
  foreach (ValidationMessage message in validator.ValidationMessages) { ... }
}
```

## Running validation when a change occurs
 If you want to make sure that the user is warned immediately if the model becomes invalid, you can define a store event that runs validation. For more information about store events, see [Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md).

 In addition to the validation code, add a custom code file to your **DslPackage** project, with content similar to the following example. This code uses the `ValidationController` that is attached to the document. This controller displays the validation errors in the Visual Studio error list.

```csharp
using System;
using System.Linq;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;
namespace Company.FamilyTree
{
  partial class FamilyTreeDocData // Change name to your DocData.
  {
    // Register the store event handler:
    protected override void OnDocumentLoaded()
    {
      base.OnDocumentLoaded();
      DomainClassInfo observedLinkInfo = this.Store.DomainDataDirectory
         .FindDomainClass(typeof(ParentsHaveChildren));
      DomainClassInfo observedClassInfo = this.Store.DomainDataDirectory
         .FindDomainClass(typeof(Person));
      EventManagerDirectory events = this.Store.EventManagerDirectory;
      events.ElementAdded
         .Add(observedLinkInfo, new EventHandler<ElementAddedEventArgs>(ParentLinkAddedHandler));
      events.ElementDeleted.Add(observedLinkInfo, new EventHandler<ElementDeletedEventArgs>(ParentLinkDeletedHandler));
      events.ElementPropertyChanged.Add(observedClassInfo, new EventHandler<ElementPropertyChangedEventArgs>(BirthDateChangedHandler));
    }
    // Handler will be called after transaction that creates a link:
    private void ParentLinkAddedHandler(object sender,
                                ElementAddedEventArgs e)
    {
      this.ValidationController.Validate(e.ModelElement,
           ValidationCategories.Save);
    }
    // Called when a link is deleted:
    private void ParentLinkDeletedHandler(object sender,
                                ElementDeletedEventArgs e)
    {
      // Don't apply validation to a deleted item!
      // - Validate store to refresh the error list.
      this.ValidationController.Validate(this.Store,
           ValidationCategories.Save);
    }
    // Called when any property of a Person element changes:
    private void BirthDateChangedHandler(object sender,
                      ElementPropertyChangedEventArgs e)
    {
      Person person = e.ModelElement as Person;
      // Not interested in changes in other properties:
      if (e.DomainProperty.Id != Person.BirthYearDomainPropertyId)
          return;

      // Validate all parent links to and from the person:
      this.ValidationController.Validate(
        ParentsHaveChildren.GetLinksToParents(person)
        .Concat(ParentsHaveChildren.GetLinksToChildren(person))
        , ValidationCategories.Save);
    }
  }
}
```

 The handlers are also called after Undo or Redo operations that affect the links or elements.

## <a name="custom"></a> Custom Validation Categories
 In addition to the standard validation categories, such as Menu and Open, you can define your own categories. You can invoke these categories from program code. The user cannot invoke them directly.

 A typical use for custom categories is to define a category that tests whether the model satisfies the preconditions of a particular tool.

 To add a validation method to a particular category, prefix it with an attribute like this:

```csharp
[ValidationMethod(CustomCategory = "PreconditionsForGeneratePartsList")]
[ValidationMethod(ValidationCategory.Menu)]
private void TestForCircularLinks(ValidationContext context)
{...}
```

> [!NOTE]
> You can prefix a method with as many `[ValidationMethod()]` attributes as you want. You can add a method to both custom and standard categories.

 To invoke a custom validation:

```csharp

// Invoke all validation methods in a custom category:
validationController.ValidateCustom
  (store, // or a list of model elements
   "PreconditionsForGeneratePartsList");
```

## <a name="alternatives"></a> Alternatives to Validation
 Validation constraints report errors, but do not change the model. If, instead, you want to prevent the model becoming invalid, you can use other techniques.

 However, these techniques are not recommended. It is usually better to let the user decide how to correct an invalid model.

 **Adjust the change to restore the model to validity.** For example, if the user sets a property above the allowed maximum, you could reset the property to the maximum value. To do this, define a rule. For more information, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

 **Roll back the transaction if an invalid change is attempted.** You could also define a rule for this purpose, but in some cases it is possible to override a property handler **OnValueChanging()**, or to override a method such as `OnDeleted().` To roll back a transaction, use `this.Store.TransactionManager.CurrentTransaction.Rollback().` For more information, see [Domain Property Value Change Handlers](../modeling/domain-property-value-change-handlers.md).

> [!WARNING]
> Make sure that the user knows that the change has been adjusted or rolled back. For example, use `System.Windows.Forms.MessageBox.Show("message").`

## Related content

- [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)
- [Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md)
