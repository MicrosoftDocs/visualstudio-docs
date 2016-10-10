---
title: "Writing Code to Customise a Domain-Specific Language"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a4a17f5b-9c97-4575-b2d1-3182c1896b72
caps.latest.revision: 29
manager: kamrani
translation.priority.mt: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Writing Code to Customise a Domain-Specific Language
This section shows you how to use custom code to access, modify, or create a model in a domain-specific language.  
  
 There are several contexts in which you can write code that works with a DSL:  
  
-   **Custom commands.** You can create a command that users can invoke by right-clicking on the diagram, and which can modify the model. For more information, see [How to: Add a Command to the Shortcut Menu](../VS_IDE/How-to--Add-a-Command-to-the-Shortcut-Menu.md).  
  
-   **Validation.** You can write code that verifies that the model is in a correct state. For more information, see [Validation in a Domain-Specific Language](../VS_IDE/Validation-in-a-Domain-Specific-Language.md).  
  
-   **Overriding the default behavior.** You can modify many aspects of the code that is generated from DslDefinition.dsl. For more information, see [Overriding and Extending the Generated Classes](../VS_IDE/Overriding-and-Extending-the-Generated-Classes.md).  
  
-   **Text Transformation.** You can write text templates that contain code that accesses a model and generates a text file, for example to generate program code. For more information, see [Generating Code from a Domain-Specific Language](../VS_IDE/Generating-Code-from-a-Domain-Specific-Language.md).  
  
-   **Other Visual Studio extensions.** You can write separate VSIX extensions that read and modify models. For more information, see [How to: Open a Model from File in Program Code](../VS_IDE/How-to--Open-a-Model-from-File-in-Program-Code.md)  
  
 Instances of the classes that you define in DslDefinition.dsl are kept in a data structure called the *In-Memory Store* (IMS) or *Store*. The classes you define in a DSL always take a Store as an argument to the constructor. For example, if your DSL defines a class called Example:  
  
 `Example element = new Example (theStore);`  
  
 keeping objects in the Store (instead of just as ordinary objects) provides several benefits.  
  
-   **Transactions**. You can group a series of related changes into a transaction:  
  
     `using (Transaction t = store.TransactionManager.BeginTransaction("updates"))`  
  
     `{`  
  
     `// make several changes to Store elements here`  
  
     `t.Commit();`  
  
     `}`  
  
     If an exception occurs during the changes, so that the final Commit() is not performed, the Store will be reset to its previous state. This helps you to make sure that errors do not leave the model in an inconsistent state. For more information, see [Navigating and Updating a Model in Program Code](../VS_IDE/Navigating-and-Updating-a-Model-in-Program-Code.md).  
  
-   **Binary relationships**. If you define a relationship between two classes, instances at both ends have a property that navigates to the other end. The two ends are always synchronized. For example, if you define a parenthood relationship with roles named Parents and Children, you could write:  
  
     `John.Children.Add(Mary)`  
  
     Both of the following expressions are now true:  
  
     `John.Children.Contains(Mary)`  
  
     `Mary.Parents.Contains(John)`  
  
     You could also achieve the same effect by writing:  
  
     `Mary.Parents.Add(John)`  
  
     For more information, see [Navigating and Updating a Model in Program Code](../VS_IDE/Navigating-and-Updating-a-Model-in-Program-Code.md).  
  
-   **Rules and Events**. You can define rules that fire whenever specified changes are made. Rules are used, for example, to keep shapes on the diagram up to date with the model elements they present. For more information, see [Responding to and Propagating Changes](../VS_IDE/Responding-to-and-Propagating-Changes.md).  
  
-   **Serialization**. The Store provides a standard way to serialize the objects it contains to a file. You can customize the rules for serializing and deserializing. For more information, see [Customizing File Storage and XML Serialization](../VS_IDE/Customizing-File-Storage-and-XML-Serialization.md).  
  
## See Also  
 [Customizing and Extending a Domain-Specific Language](../VS_IDE/Customizing-and-Extending-a-Domain-Specific-Language.md)