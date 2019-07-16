---
title: "Unsupported Edits in Visual Basic Edit and Continue | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
helpviewer_keywords: 
  - "Edit and Continue [Visual Basic], unsupported method and property body edits"
ms.assetid: 9b8fdc41-a193-49ad-ad72-dfcadd46f4b3
caps.latest.revision: 31
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Unsupported Edits in Visual Basic Edit and Continue
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Edit and Continue les you stop program execution in Break mode, make changes to the executing code, and resume program execution with the newly incorporated changes. Declarative code edits that affect the public structure of a class are generally prohibited, but many edits that you might make to a method, property body, or private declarations within a class are allowed.  
  
 If you need to make a change that is not supported, you must stop debugging, make the changes, and start a new debugging session.  
  
### <a name="BKMK_MethodandPropertyBodyEdits"></a> Method and Property Body Edits  
 **Unsupported Changes to Static Local Variables**: Adding or updating a local variable, or removing a static local variable if that would cause a compilation error.  
  
 **Unsupported Changes to Generics**: Changes to the generic method itself or generic method body are not supported. Instantiation of a generic type or calls to existing generic methods can be added, deleted, or changed.  
  
 **Other Unsupported Changes**  
  
- Changing the invocation statement of a method that is on the call stack.  
  
- Adding a `Try...Catch` block, when the instruction pointer ends up in the `Catch` block or the `Finally` block.  
  
- Removing a `Try...Catch` block, when the instruction pointer is in a `Catch`block or the `Finally` block.  
  
- Adding a `Using` block around the current instruction pointer.  
  
- Adding a `SynchLock` block around the current instruction pointer.  
  
### <a name="BKMK_AttributeEdits"></a> Attribute Edits  
 Edit and Continue does not support modifying attributes. Specifically, Edit and Continue does not support the following changes:  
  
- Defining, editing, or deleting an attribute class.  
  
- Adding an attribute.  
  
- Editing or removing an existing attribute.  
  
### <a name="BKMK_ClassDeclarationEdits"></a> Class Declaration Edits  
 Most changes to class declarations are not allowed by Edit and Continue while in Break mode. Specifically, Edit and Continue does not support the following changes:  
  
- Renaming, deleting, or changing the inheritance of an existing class.  
  
- Implementing a new interface or removing the implementation of an interface.  
  
- Changing modifiers on a class.  
  
- Adding, changing, or removing `ComClass` status.  
  
- Editing any generic class declaration.  
  
### <a name="BKMK_ClassMemberDeclarationEdits"></a> Class Member Declaration Edits  
 Changes to member declarations are prohibited in most Edit and Continue cases. For example, you cannot change the signature or access level of a member, and you cannot completely remove members if that would cause a compilation error. Specifically, Edit and Continue does not support the following changes:  
  
- Shadowing an existing member variable by declaring a global or member variable of the same name in the containing block.  
  
- Shadowing a static local variable by declaring a new instance inside a block.  
  
- Removing handlers for an event. Adding an event handler is allowed.  
  
- Adding a new overloading property or method, unless the property or method is `Private` and there are no occurrences of the name in any active statement.  
  
- Adding or removing the `WithEvents` clause on a member variable.  
  
- Deleting a member.  
  
- Changing a property or method declaration to stop implementing an interface.  
  
- Editing any method that uses generics.  
  
- Changing the signature or return type of a non-private property or method.  
  
- Overriding or shadowing a member in a base class.  
  
- Adding a new field in any class marked with `SequentialLayout` or `ExplicitLayout`.  
  
- Changing the `MustInherit` or `NotOverridable` status of a method.  
  
- Changing the access modifiers for a property or method.  
  
- Changing the type or read-only status of a field.  
  
- Changing a public field.  
  
### <a name="BKMK_CompilerOptionEdits"></a> Compiler Option Edits  
 While using Edit and Continue in Break mode, you cannot change, add, or remove the following compiler options:  
  
- **Option Strict**  
  
- **Option Explicit**  
  
- **Option Compare**  
  
### <a name="BKMK_ConstantsEdits"></a> Constants Edits  
 Changes to constants while in Edit and Continue mode are very limited. Specifically, Edit and Continue does not support the following changes:  
  
- Adding or updating a constant variable.  
  
- Changing the type or value of a constant.  
  
- Removing a constant.  
  
### <a name="BKMK_DelegateandEventDeclarationEdits"></a> Delegate and Event Declaration Edits  
 Some changes to delegates and events are not allowed by Edit and Continue during Break mode. Specifically, Edit and Continue does not support the following changes:  
  
- Changing or deleting a delegate definition.  
  
- Deleting an event.  
  
### <a name="BKMK_EnumerationEdits"></a> Enumeration Edits  
 Changes to enumerations (`Enums`) are not allowed by Edit and Continue during Break Mode. Specifically, Edit and Continue does not support the following changes:  
  
- Modifying the underlying type of an `Enum`.  
  
- Adding, changing, or removing an `Enum` member.  
  
- Changing the access modifier of an `Enum`.  
  
### <a name="BKMK_ExternalDeclarationsEdits"></a> External Declarations Edits  
 In general, you cannot change the declarations of external methods during Edit and Continue. Specifically, Edit and Continue does not support the following changes:  
  
- Adding or removing an external declaration.  
  
- Changing the signature or marshaling attributes of an external declaration.  
  
### <a name="BKMK_ImportsEdits"></a> Imports Edits  
 Edit and Continue does not allow adding, changing, or removing `Imports` statements while in Break mode.  
  
### <a name="BKMK_InterfaceDefinitionEdits"></a> Interface Definition Edits  
 Although you are frequently allowed to make changes to members that implement interfaces, changes to the actual interface definitions are generally not allowed by Edit and Continue. Specifically, Edit and Continue does not support the following changes:  
  
- Adding, changing, or removing interface members.  
  
- Deleting an existing interface.  
  
- Changing the access modifier of an interface.  
  
- Changing the interface inheritance hierarchy.  
  
### <a name="BKMK_ModuleDeclarationEdits"></a> Module Declaration Edits  
 Most changes to module declarations are not allowed by Edit and Continue while in Break mode. Specifically, Edit and Continue does not support the following changes:  
  
- Creating a new module.  
  
- Renaming or deleting an existing module.  
  
- Changing the access modifier for a module.  
  
### <a name="BKMK_ModuleMemberDeclarationEdits"></a> Module Member Declaration Edits  
 Using Edit and Continue, you can make a variety of changes to module members, such as properties, methods, and fields, while in Break mode. Some changes, however, are not supported. Most notably, Edit and Continue does not support adding, deleting, or changing the type or signature of any members.  
  
 Specifically, Edit and Continue does not support the following changes:  
  
- Adding a new member unless there are no occurrences of the name in any active statement.  
  
- Removing a property or method.  
  
- Changing the signature of a property or method.  
  
- Adding, renaming, moving, or deleting a field.  
  
- Editing any method that uses generics.  
  
- Changing the access modifiers for a property or method, for example, changing `Public` to `Private`.  
  
- Deleting or changing the type of an existing field.  
  
### <a name="BKMK_NestedTypeDeclarationEdits"></a> Nested Type Declaration Edits  
 Edit and Continue does not support moving a nested type to another namespace or type.  
  
### <a name="BKMK_StructureDeclarationEdits"></a> Structure Declaration Edits  
 Most changes to structure declarations are not allowed by Edit and Continue while in **Break** mode. Specifically, Edit and Continue does not support the following changes:  
  
- Renaming or deleting an existing structure.  
  
- Implementing a new interface or removing the implementation of an interface.  
  
- Changing the access modifier for a structure.  
  
### <a name="BKMK_StructureMemberDeclarationEdits"></a> Structure Member Declaration Edits  
 Using Edit and Continue, you can make a variety of changes to structure members (properties, methods, and fields) while in Break mode. Some changes, however, are not supported, most notably changes that affect the declaration of structure members. Specifically, Edit and Continue does not support the following changes:  
  
- Removing a property or method.  
  
- Adding or removing a field.  
  
- Changing the signature of a property or method.  
  
- Editing any method that uses generics.  
  
- Changing whether a property or method declaration implements an interface.  
  
- Changing the access modifiers of a property or method (for example, changing `Public` to **Private**).  
  
- Removing a field.  
  
- Changing the type of a field.  
  
## See Also  
 [How to: Apply Edits in Break Mode with Edit and Continue](../debugger/how-to-apply-edits-in-break-mode-with-edit-and-continue.md)   
 [Edit and Continue (Visual Basic)](../debugger/edit-and-continue-visual-basic.md)
