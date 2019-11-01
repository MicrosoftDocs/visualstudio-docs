---
title: "Resources in VSPackages | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "managed VSPackages, resources in"
  - "resources, managed VSPackages"
  - "VSPackages, managed resources"
ms.assetid: cc8c17a6-b190-4856-b001-0c1104f104b2
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Resources in VSPackages
You can embed localized resources in native satellite UI DLLs, managed satellite DLLs, or in a managed VSPackage itself.

 Some resources cannot be embedded in VSPackages. The following managed types can be embedded:

- Strings

- Package load keys (which are also strings)

- Tool window icons

- Compiled Command Table Output (CTO) files

- CTO bitmaps

- Command-line Help

- About dialog box data

  Resources in a managed package are selected by resource ID. An exception is the CTO file, which must be named CTMENU. The CTO file must appear in the resource table as a `byte[]`. All other resource items are identified by type.

  You can use the <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute> attribute to indicate to [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] that managed resources are available.

  [!code-csharp[VSSDKResources#1](../../extensibility/internals/codesnippet/CSharp/resources-in-vspackages_1.cs)]
  [!code-vb[VSSDKResources#1](../../extensibility/internals/codesnippet/VisualBasic/resources-in-vspackages_1.vb)]

  Setting <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute> in this manner indicates that [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] should ignore unmanaged satellite DLLs when it searches for resources, for example, by using <xref:Microsoft.VisualStudio.Shell.Interop.IVsShell.LoadPackageString%2A>. If [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] encounters two or more resources that have the same resource ID, it uses the first resource it finds.

## Example
 The following example is a managed representation of a tool window icon.

```
<data name="1001"
type="System.Resources.ResXFileRef,System.Windows.Forms">
     <value>
     MyToolWinIcon.bmp;
     System.Drawing.Bitmap,
     System.Drawing,
     Version=1.0.0.0,
     Culture=neutral,
     PublicKeyToken=b03f5f7f11d50a3a
     </value>
</data>
```

 The following example demonstrates how to embed the CTO byte array, which must be named CTMENU.

```
<data name="CTMENU"
type="System.Resources.ResXFileRef,System.Windows.Forms">
     <value>
     MyPackage.cto;
     System.Byte[],
     mscorlib,
     Version=1.0.0.0,
     Culture=neutral,
     PublicKeyToken=b03f5f7f11d50a3a
     </value>
</data>
```

## Implementation Notes
 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] delays loading of VSPackages whenever possible. A consequence of embedding a CTO file in a VSPackage is that [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] must load all such VSPackages in memory during Setup, which is when it builds a merged command table. Resources can be extracted from a VSPackage by examining the metadata without running code in the VSPackage. The VSPackage is not initialized at this time, so the performance loss is minimal.

 When [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] requests a resource from a VSPackage after Setup, that package is likely to be already loaded and initialized, so the performance loss is minimal.

## See also
- [Managing VSPackages](../../extensibility/managing-vspackages.md)
- [Localized Resources in MFC Applications: Satellite DLLs](/cpp/build/localized-resources-in-mfc-applications-satellite-dlls)
