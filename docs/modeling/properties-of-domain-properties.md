---
title: Properties of Domain Properties
description: Learn how a domain property is a feature of a model element that can hold a value, and how domain properties are listed in the domain class box on the diagram.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
  - "Domain-Specific Language, domain properties"
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
  - "multiple"
---
# Properties of Domain Properties
A *domain property* is a feature of a model element that can hold a value. For example, the `Person` domain class could have properties `Name` and `BirthDate`. In the DSL Definition, domain properties are listed in the domain class box on the diagram and under the domain class in DSL Explorer. For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md).

> [!NOTE]
> The word "property" has two uses. A *domain property* is a feature that you define on a domain class. By contrast, many elements of a DSL have *properties*, which are listed in the **Properties** window in the DSL Definition. For example, every domain property has a set of properties, which are described in this topic.

 At run time, when a user creates instances of the domain class, the values of the domain properties can be seen in the Properties window, and can be displayed on the shapes.

 Most domain properties are implemented as ordinary CLR properties. However, from a programming point of view, domain properties have richer functionality than ordinary program properties:

- You can define rules and events that monitor the state of a property. For more information, see [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md).

- Transactions help prevent inconsistent states. For more information, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

  When you select a Domain Property in a diagram or in DSL Explorer, you can see the following items in the Properties window. For more information about how to use these items, see [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md).

|Property|Description|Default Value|
|-|-|-|
|**Description**|The description that is used to document the user interface (UI) of the generated designer.|\<none>|
|**Display Name**|The name that will be displayed in the generated designer for this domain property. It can contain spaces and punctuation, for example "Song Title".|\<none>|
|**Element Name Provider**|This is applicable only if you have set `Is Element Name` to `true`. You can write code that provides a name for a new element of a domain class, overriding the default behavior.<br /><br /> In a code file in the DSL project, create a class that is derived from <xref:Microsoft.VisualStudio.Modeling.ElementNameProvider>.<br /><br /> Then in DSL Explorer, right-click the root of the DSL, and click Add External Type. Enter the name of your class.<br /><br /> Select this domain property again, and select the name of the class in the drop-down list.|\<none>|
|**Getter Access Modifier**|The level of access of the domain class (`public` or `internal`). This controls the scope in which program code can access the property.|`public`|
|**Help Keyword**|The optional keyword that is used to index F1 help for this domain property.|\<none>|
|**Is Browsable**|If `True`, the domain property is displayed to the user in the properties window when models of this DSL are open.<br /><br /> If `False`, the domain property is hidden in the UI.<br /><br /> If you want to make the domain property visible but read-only, set **Is UI Read Only**.|`True`|
|**Is Element Name**|If `True`, this domain property will be displayed as the name of its model element in DSL Explorer.<br /><br /> New model elements will receive a unique default value for this property. If you want to control how these values are generated, set **Element Name Provider**.|`False`|
|**Is UI Read Only**|If `True`, the value of the domain property cannot be changed by using the UI. It can still be set by programs, and will be visible in the Properties window.<br /><br /> If you want to hide the domain property from the user, set **Is Browsable**. If you want to control access by programs, set **Setter Access Modifier**.|`False`|
|**Kind**|The kind of domain property (`Normal`, `Calculated`, or `CustomStorage`). For more information, see [Calculated and Custom Storage Properties](../modeling/calculated-and-custom-storage-properties.md).|`Normal`|
|**Name**|The name of this domain property. It must be a valid identifier, for example **SongTitle**.|\<none>|
|**Notes**|Informal notes that are associated with this domain property.|\<none>|
|**Setter Access Modifier**|The access modifier for the setter. This controls the scope in which program code can set the property.|`public`|
|**Type**|The type of property. To add to the list of available types, right-click the root of the DSL in DSL explorer, and click **Add External Type**.|`String`|

## See also

- [Domain-Specific Language Tools Glossary](/previous-versions/bb126564(v=vs.100))