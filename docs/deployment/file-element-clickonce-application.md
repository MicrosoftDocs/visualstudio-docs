---
title: "&lt;file&gt; Element (ClickOnce Application) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "http://www.w3.org/2000/09/xmldsig#Transform"
  - "urn:schemas-microsoft-com:asm.v2#file"
  - "http://www.w3.org/2000/09/xmldsig#DigestValue"
  - "http://www.w3.org/2000/09/xmldsig#DigestMethod"
  - "http://www.w3.org/2000/09/xmldsig#Transforms"
  - "urn:schemas-microsoft-com:asm.v2#hash"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "<file> element [ClickOnce application manifest]"
  - "manifests [ClickOnce], file element"
ms.assetid: 56e3490c-eed5-4841-b1bf-eefe778b6ac9
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# &lt;file&gt; element (ClickOnce application)
Identifies all nonassembly files downloaded and used by the application.

## Syntax

```xml
<file
    name
    size
    group
    optional
    writeableType
>
    <typelib
        tlbid
        version
        helpdir
        resourceid
        flags
    />
    <comClass
        clsid
        description
        threadingModel
        tlbid
        progid
        miscStatus
        miscStatusIcon
        miscStatusContent
        miscStatusDocPrint
        miscStatusThumbnail
    />
    <comInterfaceExternalProxyStub
        iid
        baseInterface
        numMethods
        name
        tlbid
        proxyStubClass32
    />
    <comInterfaceProxyStub
        iid
        baseInterface
        numMethods
        name
        tlbid
        proxyStubClass32
    />
    <windowClass
        versioned
    />
</file>
```

## Elements and attributes
 The `file` element is optional. The element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`name`|Required. Identifies the name of the file.|
|`size`|Required. Specifies the size, in bytes, of the file.|
|`group`|Optional, if the `optional` attribute is not specified or set to `false`; required if `optional` is `true`. The name of the group to which this file belongs. The name can be any Unicode string value chosen by the developer, and is used for downloading files on demand with the <xref:System.Deployment.Application.ApplicationDeployment> class.|
|`optional`|Optional. Specifies whether this file must download when the application is first run, or whether the file should reside only on the server until the application requests it on demand. If `false` or undefined, the file is downloaded when the application is first run or installed. If `true`, a `group` must be specified for the application manifest to be valid. `optional` cannot be true if `writeableType` is specified with the value `applicationData`.|
|`writeableType`|Optional. Specifies that this file is a data file. Currently the only valid value is `applicationData`.|

## typelib
 The `typelib` element is an optional child of the file element. The element describes the type library that belongs to the COM component. The element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`tlbid`|Required. The GUID assigned to the type library.|
|`version`|Required. The version number of the type library.|
|`helpdir`|Required. The directory that contains the Help files for the component. May be zero-length.|
|`resourceid`|Optional. The hexadecimal string representation of the locale identifier (LCID). It is one to four hexadecimal digits without a 0x prefix and without leading zeros. The LCID may have a neutral sublanguage identifier.|
|`flags`|Optional. The string representation of the type library flags for this type library. Specifically, it should be one of "RESTRICTED", "CONTROL", "HIDDEN" and "HASDISKIMAGE".|

## comClass
 The `comClass` element is an optional child of the `file` element, but is required if the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`clsid`|Required. The class ID of the COM component expressed as a GUID.|
|`description`|Optional. The class name.|
|`threadingModel`|Optional. The threading model used by in-process COM classes. If this property is null, no threading model is used. The component is created on the main thread of the client and calls from other threads are marshaled to this thread. The following list shows the valid values:<br /><br /> `Apartment`, `Free`, `Both`, and `Neutral`.|
|`tlbid`|Optional. GUID for the type library for this COM component.|
|`progid`|Optional. Version-dependent programmatic identifier associated with the COM component. The format of a `ProgID` is `<vendor>.<component>.<version>`.|
|`miscStatus`|Optional. Duplicates in the assembly manifest the information provided by the `MiscStatus` registry key. If values for the `miscStatusIcon`, `miscStatusContent`, `miscStatusDocprint`, or `miscStatusThumbnail` attributes are not found, the corresponding default value listed in `miscStatus` is used for the missing attributes. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires `MiscStatus` registry key values.|
|`miscStatusIcon`|Optional. Duplicates in the assembly manifest the information provided by DVASPECT_ICON. It can provide an icon of an object. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires `Miscstatus` registry key values.|
|`miscStatusContent`|Optional. Duplicates in the assembly manifest the information provided by DVASPECT_CONTENT. It can provide a compound document displayable for a screen or printer. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires `MiscStatus` registry key values.|
|`miscStatusDocPrint`|Optional. Duplicates in the assembly manifest the information provided by DVASPECT_DOCPRINT. It can provide an object representation displayable on the screen as if printed to a printer. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires `MiscStatus` registry key values.|
|`miscStatusThumbnail`|Optional. Duplicates in an assembly manifest the information provided by DVASPECT_THUMBNAIL. It can provide a thumbnail of an object displayable in a browsing tool. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires `MiscStatus` registry key values.|

## comInterfaceExternalProxyStub
 The `comInterfaceExternalProxyStub` element is an optional child of the `file` element, but may be required if the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element contains the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`iid`|Required. The interface ID (IID) which is served by this proxy. The IID must have braces surrounding it.|
|`baseInterface`|Optional. The IID of the interface from which the interface referenced by `iid` is derived.|
|`numMethods`|Optional. The number of methods implemented by the interface.|
|`name`|Optional. The name of the interface as it will appear in code.|
|`tlbid`|Optional. The type library that contains the description of the interface specified by the `iid` attribute.|
|`proxyStubClass32`|Optional. Maps an IID to a CLSID in 32-bit proxy DLLs.|

## comInterfaceProxyStub
 The `comInterfaceProxyStub` element is an optional child of the `file` element, but may be required if the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element contains the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`iid`|Required. The interface ID (IID) which is served by this proxy. The IID must have braces surrounding it.|
|`baseInterface`|Optional. The IID of the interface from which the interface referenced by `iid` is derived.|
|`numMethods`|Optional. The number of methods implemented by the interface.|
|`Name`|Optional. The name of the interface as it will appear in code.|
|`Tlbid`|Optional. The type library that contains the description of the interface specified by the `iid` attribute.|
|`proxyStubClass32`|Optional. Maps an IID to a CLSID in 32-bit proxy DLLs.|
|`threadingModel`|Optional. Optional. The threading model used by in-process COM classes. If this property is null, no threading model is used. The component is created on the main thread of the client and calls from other threads are marshaled to this thread. The following list shows the valid values:<br /><br /> `Apartment`, `Free`, `Both`, and `Neutral`.|

## windowClass
 The `windowClass` element is an optional child of the `file` element, but may be required if the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element refers to a window class defined by the COM component that must have a version applied to it. The element contains the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`versioned`|Optional. Controls whether the internal window class name used in registration contains the version of the assembly that contains the window class. The value of this attribute can be `yes` or `no`. The default is `yes`. The value `no` should only be used if the same window class is defined by a side-by-side component and an equivalent non-side-by-side component and you want to treat them as the same window class. Note that the usual rules about window class registration apply—only the first component that registers the window class will be able to register it, because it does not have a version applied to it.|

## hash
 The `hash` element is an optional child of the `file` element. The `hash` element has no attributes.

 [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] uses an algorithmic hash of all the files in an application as a security check, to ensure that none of the files were changed after deployment. If the `hash` element is not included, this check will not be performed. Therefore, omitting the `hash` element is not recommended.

 If a manifest contains a file that is not hashed, that manifest cannot be digitally signed, because users cannot verify the contents of an unhashed file.

## dsig:Transforms
 The `dsig:Transforms` element is a required child of the `hash` element. The `dsig:Transforms` element has no attributes.

## dsig:Transform
 The `dsig:Transform` element is a required child of the `dsig:Transforms` element. The `dsig:Transform` element has the following attributes.

| Attribute | Description |
|-------------| - |
| `Algorithm` | The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] is `urn:schemas-microsoft-com:HashTransforms.Identity`. |

## dsig:DigestMethod
 The `dsig:DigestMethod` element is a required child of the `hash` element. The `dsig:DigestMethod` element has the following attributes.

| Attribute | Description |
|-------------| - |
| `Algorithm` | The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] is `http://www.w3.org/2000/09/xmldsig#sha1`. |

## dsig:DigestValue
 The `dsig:DigestValue` element is a required child of the `hash` element. The `dsig:DigestValue` element has no attributes. Its text value is the computed hash for the specified file.

## Remarks
 This element identifies all the nonassembly files that make up the application and, in particular, the hash values for file verification. This element can also include Component Object Model (COM) isolation data associated with the file. If a file changes, the application manifest file also must be updated to reflect the change.

## Example
 The following code example illustrates `file` elements in an application manifest for an application deployed using [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)].

```xml
<file name="Icon.ico" size="9216">
  <hash>
    <dsig:Transforms>
      <dsig:Transform Algorithm="urn:schemas-microsoft-com:HashTransforms.Identity" />
    </dsig:Transforms>
    <dsig:DigestMethod Algorithm="http://www.w3.org/2000/09/xmldsig#sha1" />
    <dsig:DigestValue>lVoj+Rh6RQ/HPNLOdayQah5McrI=</dsig:DigestValue>
  </hash>
</file>
```

## See also
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)