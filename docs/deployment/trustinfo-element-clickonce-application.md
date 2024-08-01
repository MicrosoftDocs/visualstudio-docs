---
title: "&lt;trustInfo&gt; element (ClickOnce application)"
description: The trustInfo element describes the minimum security permissions required for the application to run on the client computer. The trustInfo element is required.
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "urn:schemas-microsoft-com:asm.v2#IPermission"
  - "urn:schemas-microsoft-com:asm.v2#PermissionSet"
  - "urn:schemas-microsoft-com:asm.v2#assemblyRequest"
  - "urn:schemas-microsoft-com:asm.v2#trustInfo"
  - "urn:schemas-microsoft-com:asm.v2#defaultAssemblyRequest"
  - "urn:schemas-microsoft-com:asm.v2#security"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "manifests [ClickOnce], trustInfo element"
  - "<trustInfo> element [ClickOnce application manifest]"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# &lt;trustInfo&gt; element (ClickOnce application)

Describes the minimum security permissions required for the application to run on the client computer.

## Syntax

```xml

      <trustInfo>
   <security>
      <applicationRequestMinimum>
         <PermissionSet
            ID
            Unrestricted>
            <IPermission
               class
               version
               Unrestricted
            />
         </PermissionSet>
         <defaultAssemblyRequest
            permissionSetReference
         />
         <assemblyRequest
            name
            permissionSetReference
         />
      </applicationRequestMinimum>
      <requestedPrivileges>
         <requestedExecutionLevel
            level
            uiAccess
         />
      </requestedPrivileges>
   </security>
</trustInfo>
```

## Elements and attributes
 The `trustInfo` element is required and is in the `asm.v2` namespace. It has no attributes and contains the following elements.

## security
 Required. This element is a child of the `trustInfo` element. It contains the `applicationRequestMinimum` element and has no attributes.

## applicationRequestMinimum
 Required. This element is a child of the `security` element and contains the `PermissionSet`, `assemblyRequest`, and `defaultAssemblyRequest` elements. This element has no attributes.

## PermissionSet
 Required. This element is a child of the `applicationRequestMinimum` element and contains the `IPermission` element. This element has the following attributes.

- `ID`

     Required. Identifies the permission set. This attribute can be any value. The ID is referenced in the `defaultAssemblyRequest` and `assemblyRequest` attributes.

- `version`

     Required. Identifies the version of the permission. Normally this value is `1`.

## IPermission
 Optional. This element is a child of the `PermissionSet` element. The `IPermission` element fully identifies a permission class in the .NET Framework. The `IPermission` element has the following attributes, but can have additional attributes that correspond to properties on the permission class. To find out the syntax for a specific permission, see the examples listed in the Security.config file.

- `class`

     Required. Identifies the permission class by strong name. For example, the following code identifies the `FileDialogPermission` type.

     `System.Security.Permissions.FileDialogPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089`

- `version`

     Required. Identifies the version of the permission. Usually this value is `1`.

- `Unrestricted`

     Required. Identifies whether the application needs an unrestricted grant of this permission. If `true`, the permission grant is unconditional. If `false`, or if this attribute is undefined, it is restricted according to the permission-specific attributes defined on the `IPermission` tag. Take the following permissions:

    ```xml
    <IPermission
      class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
      version="1"
      Read="USERNAME" />
    <IPermission
      class="System.Security.Permissions.FileDialogPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
      version="1"
      Unrestricted="true" />
    ```

     In this example, the declaration for <xref:System.Security.Permissions.EnvironmentPermission> restricts the application to reading only the environment variable USERNAME, whereas the declaration for <xref:System.Security.Permissions.FileDialogPermission> gives the application unrestricted use of all <xref:System.Windows.Forms.FileDialog> classes.

## defaultAssemblyRequest
 Optional. Identifies the set of permissions granted to all assemblies. This element is a child of the `applicationRequestMinimum` element and has the following attribute.

- `permissionSetReference`

     Required. Identifies the ID of the permission set that is the default permission. The permission set is declared in the `PermissionSet` element.

## assemblyRequest
 Optional. Identifies permissions for a specific assembly. This element is a child of the `applicationRequestMinimum` element and has the following attributes.

- `Name`

     Required. Identifies the assembly name.

- `permissionSetReference`

     Required. Identifies the ID of the permission set that this assembly requires. The permission set is declared in the `PermissionSet` element.

## requestedPrivileges
 Optional. This element is a child of the `security` element and contains the `requestedExecutionLevel` element. This element has no attributes.

## requestedExecutionLevel
 Optional. Identifies the security level at which the application requests to be executed. This element has no children and has the following attributes.

- `Level`

   Required. Indicates the security level the application is requesting. Possible values are:

   `asInvoker`, requesting no additional permissions. This level requires no additional trust prompts.

   `highestAvailable`, requesting the highest permissions available to the parent process.

   `requireAdministrator`, requesting full administrator permissions.

   ClickOnce applications will only install with a value of `asInvoker`. Installing with any other value will fail.

- `uiAccess`

   Optional. Indicates whether the application requires access to protected user interface elements. Values are either `true` or `false`, and the default is false. Only signed applications should have a value of true.

## Remarks
 If a ClickOnce application asks for more permissions than the client computer will grant by default, the common language runtime's Trust Manager will ask the user if she wants to grant the application this elevated level of trust. If she says no, the application will not run; otherwise, it will run with the requested permissions.

 All permissions requested using `defaultAssemblyRequest` and `assemblyRequest` will be granted without user prompting if the deployment manifest has a valid Trust License.

 For more information about Permission Elevation, see [Securing ClickOnce Applications](../deployment/securing-clickonce-applications.md). For more information about policy deployment, see [Trusted Application Deployment Overview](../deployment/trusted-application-deployment-overview.md).

## Examples
 The following three code examples illustrate `trustInfo` elements for the default named security zones—Internet, LocalIntranet, and FullTrust—for use in a ClickOnce deployment's application manifest.

 The first example illustrates the `trustInfo` element for the default permissions available in the Internet security zone.

```xml
<trustInfo>
    <security>
      <applicationRequestMinimum>
        <PermissionSet ID="Internet">
          <IPermission
            class="System.Security.Permissions.FileDialogPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Access="Open" />
          <IPermission
           class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Allowed="DomainIsolationByUser"
            UserQuota="10240" />
          <IPermission
            class="System.Security.Permissions.SecurityPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Flags="Execution" />
          <IPermission
            class="System.Security.Permissions.UIPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Window="SafeTopLevelWindows"
            Clipboard="OwnClipboard" />
          <IPermission
            class="System.Drawing.Printing.PrintingPermission, System.Drawing, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
            version="1"
            Level="SafePrinting" />
        </PermissionSet>
        <defaultAssemblyRequest permissionSetReference="Internet" />
      </applicationRequestMinimum>
    </security>
  </trustInfo>
```

 The second example illustrates the `trustInfo` element for the default permissions available in the LocalIntranet security zone.

```xml
<trustInfo>
    <security>
      <applicationRequestMinimum>
        <PermissionSet ID="LocalIntranet">
          <IPermission
            class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Read="USERNAME" />
          <IPermission
            class="System.Security.Permissions.FileDialogPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Unrestricted="true" />
          <IPermission
            class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Allowed="AssemblyIsolationByUser"
            UserQuota="9223372036854775807"
            Expiry="9223372036854775807"
            Permanent="True" />
          <IPermission
            class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Flags="ReflectionEmit" />
          <IPermission
            class="System.Security.Permissions.SecurityPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Flags="Assertion, Execution" />
          <IPermission
            class="System.Security.Permissions.UIPermission, mscorlib, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Unrestricted="true" />
          <IPermission
            class="System.Net.DnsPermission, System, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1"
            Unrestricted="true" />
          <IPermission
            class="System.Drawing.Printing.PrintingPermission, System.Drawing, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
            version="1"
            Level="DefaultPrinting" />
          <IPermission
            class="System.Diagnostics.EventLogPermission, System, Version=1.2.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"
            version="1" />
        </PermissionSet>
        <defaultAssemblyRequest permissionSetReference="LocalIntranet" />
      </applicationRequestMinimum>
    </security>
</trustInfo>
```

 The third example illustrates the `trustInfo` element for the default permissions available in the FullTrust security zone.

```xml
<trustInfo>
  <security>
    <applicationRequestMinimum>
      <PermissionSet ID="FullTrust" Unrestricted="true" />
      <defaultAssemblyRequest permissionSetReference="FullTrust" />
    </applicationRequestMinimum>
  </security>
</trustInfo>
```

## See also
- [Trusted Application Deployment overview](../deployment/trusted-application-deployment-overview.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)