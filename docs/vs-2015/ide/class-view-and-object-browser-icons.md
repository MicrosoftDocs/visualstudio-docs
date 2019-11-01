---
title: "Class View and Object Browser Icons | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "icons, in Object Browser"
  - "signal icons"
  - "Class View tool, symbols"
  - "graphic symbols"
  - "IntelliSense, icons"
  - "icons, IntelliSense"
  - "symbols, Object Browser icons"
  - "Object Browser, icons in Class View"
ms.assetid: 58cc3f44-c296-4a88-a008-09d28598d9c0
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: jillfra
---
# Class View and Object Browser Icons
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Class View** and the **Object Browser** display icons that represent code entities, for example, namespaces, classes, functions, and variables. The following table illustrates and describes the icons.

|Icon|Description|Icon|Description|
|----------|-----------------|----------|-----------------|
|![Namespace Symbol](../ide/media/vxnamespace-icon.gif "vxNamespace_Icon")|Namespace|![Declaration Symbol](../ide/media/vxmethod-icon.gif "vxMethod_Icon")|Method or Function|
|![Class Icon](../ide/media/vxclass-icon.gif "vxClass_Icon")|Class|![Operator Symbol](../ide/media/vxoperator-icon.gif "vxOperator_Icon")|Operator|
|![Lollipop Interface Symbol](../ide/media/vxinterface-icon.gif "vxInterface_Icon")|Interface|![Property Symbol](../ide/media/vxproperty-icon.gif "vxProperty_Icon")|Property|
|![Structure Symbol](../ide/media/vxstruct-icon.gif "vxStruct_Icon")|Structure|![Field Icon](../ide/media/vxfield-icon.gif "vxField_Icon")|Field or Variable|
|![Union Symbol](../ide/media/vxunion-icon.gif "vxUnion_Icon")|Union|![Event Symbol](../ide/media/vxevent-icon.gif "vxEvent_Icon")|Event|
|![Enumeration Symbol](../ide/media/vxenum-icon.gif "vxEnum_Icon")|Enum|![Constant Icon](../ide/media/vxconstant-icon.gif "vxConstant_Icon")|Constant|
|![Type Definition Symbol](../ide/media/vxtypedef-icon.gif "vxTypeDef_Icon")|TypeDef|![Enumerate Item Symbol](../ide/media/vxenumitem-icon.gif "vxEnumItem_Icon")|Enum Item|
|![Visual Studio Module Symbol](../ide/media/vxmodule-icon.gif "vxModule_Icon")|Module|![Map Item Symbol](../ide/media/vxmapitem-icon.gif "vxMapItem_Icon")|Map Item|
|![Extension Method Symbol](../ide/media/extensionmethod.gif "ExtensionMethod")|Extension Method|![Declaration Symbol](../ide/media/vxmethod-icon.gif "vxMethod_Icon")|External Declaration|
|![Delegate Symbol](../ide/media/vxdelegate-icon.gif "vxDelegate_Icon")|Delegate|![Error Icon for Class View and Object Browser](../ide/media/erroricon.gif "ErrorIcon")|Error|
|![Exception Symbol](../ide/media/vxexception-icon.gif "vxException_Icon")|Exception|![Template Symbol](../ide/media/vxtemplate-icon.gif "vxTemplate_Icon")|Template|
|![Map Symbol](../ide/media/vxmap-icon.gif "vxMap_Icon")|Map|![Error Exclamation Point Symbol](../ide/media/vxerror-icon.gif "vxError_Icon")|Unknown|
|![Type Forwarding Symbol](../ide/media/ob-type-forward.gif "ob_type_forward")|Type Forwarding|||

## Signal Icons
 The following signal icons apply to all the previous icons and indicate their accessibility.

> [!NOTE]
> If your project is included in a source control database, additional signal icons may be displayed to indicate source-control status, such as checked in or checked out.

|Icon|Description|
|----------|-----------------|
|\<No Signal Icon>|Public. Accessible from anywhere in this component and from any component that references it.|
|![Signal Protected Symbol](../ide/media/vxsignal-icon-key.gif "vxSignal_Icon_Key")|Protected. Accessible from the containing class or type, or those derived from the containing class or type.|
|![Signal Private Symbol](../ide/media/vxsignal-icon-lock.gif "vxSignal_Icon_Lock")|Private. Accessible only in the containing class or type.|
|![Signal Sealed Symbol](../ide/media/vxsignal-icon-envelope.gif "vxSignal_Icon_Envelope")|Sealed.|
|![Signal Friend&#47;Internal Symbol](../ide/media/vxsignal-icon-diamond.gif "vxSignal_Icon_Diamond")|Friend/Internal. Accessible only from the project.|
|![Signal Icon Arrow](../ide/media/vxsignal-icon-arrow.gif "vxSignal_Icon_Arrow")|Shortcut. A shortcut to the object.|

## See Also
 [Viewing the Structure of Code](../ide/viewing-the-structure-of-code.md)
