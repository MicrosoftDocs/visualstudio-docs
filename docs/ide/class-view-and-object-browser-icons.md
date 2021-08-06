---
title: Class View and Object Browser Icons
description: Learn about Class View and the Object Browser display icons that represent code entities, for example, namespaces, classes, functions, and variables.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- icons, in Object Browser
- signal icons
- Class View tool, symbols
- graphic symbols
- IntelliSense, icons
- icons, IntelliSense
- symbols, Object Browser icons
- Object Browser, icons in Class View
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Class View and Object Browser icons

**Class View** and the **Object Browser** display icons that represent code entities, for example, namespaces, classes, functions, and variables. The following table illustrates and describes the icons.

|Icon|Description|Icon|Description|
|----------|-----------------|----------|-----------------|
|![Namespace Symbol](../ide/media/vxnamespace_icon.gif)|Namespace|![Declaration Symbol](../ide/media/vxmethod_icon.gif)|Method or Function|
|![Class Icon](../ide/media/vxclass_icon.gif)|Class|![Operator Symbol](../ide/media/vxoperator_icon.gif)|Operator|
|![Lollipop Interface Symbol](../ide/media/vxinterface_icon.gif)|Interface|![Property Symbol](../ide/media/vxproperty_icon.gif)|Property|
|![Structure Symbol](../ide/media/vxstruct_icon.gif)|Structure|![Field Icon](../ide/media/vxfield_icon.gif)|Field or Variable|
|![Union Symbol](../ide/media/vxunion_icon.gif)|Union|![Event Symbol](../ide/media/vxevent_icon.gif)|Event|
|![Enumeration Symbol](../ide/media/vxenum_icon.gif)|Enum|![Constant Icon](../ide/media/vxconstant_icon.gif)|Constant|
|![Type Definition Symbol](../ide/media/vxtypedef_icon.gif)|TypeDef|![Enumerate Item Symbol](../ide/media/vxenumitem_icon.gif)|Enum Item|
|![Visual Studio Module Symbol](../ide/media/vxmodule_icon.gif)|Module|![Map Item Symbol](../ide/media/vxmapitem_icon.gif)|Map Item|
|![Extension Method Symbol](../ide/media/extensionmethod.gif)|Extension Method|![Declaration Symbol](../ide/media/vxmethod_icon.gif)|External Declaration|
|![Delegate Symbol](../ide/media/vxdelegate_icon.gif)|Delegate|![Error Icon for Class View and Object Browser](../ide/media/erroricon.gif)|Error|
|![Exception Symbol](../ide/media/vxexception_icon.gif)|Exception|![Template Symbol](../ide/media/vxtemplate_icon.gif)|Template|
|![Map Symbol](../ide/media/vxmap_icon.gif)|Map|![Error Exclamation Point Symbol](../ide/media/vxerror_icon.gif)|Unknown|
|![Type Forwarding Symbol](../ide/media/ob_type_forward.gif)|Type Forwarding|||

> [!TIP]
> To best view the icons on this page, make sure that your Microsoft Docs theme is set to **Light**. You can toggle this color theme from the control that's located at the bottom left of the page, as shown in the following screenshot:
>
> ![Docs theme](../ide/media/toggle-docs-color-theme.png "Toggle the color theme for Microsoft Docs pages")

## Signal icons

The following signal icons apply to all the previous icons and indicate their accessibility.

|Icon|Description|
|----------|-----------------|
|\<No Signal Icon>|Public. Accessible from anywhere in this component and from any component that references it.|
|![Signal Protected Symbol](../ide/media/vxsignal_icon_key.gif)|Protected. Accessible from the containing class or type, or those derived from the containing class or type.|
|![Signal Private Symbol](../ide/media/vxsignal_icon_lock.gif)|Private. Accessible only in the containing class or type.|
|![Signal Sealed Symbol](../ide/media/vxsignal_icon_envelope.gif)|Sealed.|
|![Signal Friend&#47;Internal Symbol](../ide/media/vxsignal_icon_diamond.gif)|Friend/Internal. Accessible only from the project.|
|![Signal Icon Arrow](../ide/media/vxsignal_icon_arrow.gif)|Shortcut. A shortcut to the object.|

> [!NOTE]
> If your project is included in a source control database, additional signal icons may be displayed to indicate source-control status, such as checked in or checked out.

> [!TIP]
> To view more of the application images and icons that appear in Visual Studio, download the [**Visual Studio Image Library**](https://www.microsoft.com/download/details.aspx?id=35825).

## See also

- [Viewing the structure of code](../ide/viewing-the-structure-of-code.md)
