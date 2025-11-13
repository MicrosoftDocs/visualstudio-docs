---
title: Resources in VSPackages
description: Learn which types of localized resources can be embedded in VSPackages. You can also embed resources in native satellite UI DLLs or managed satellite DLLs.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- managed VSPackages, resources in
- resources, managed VSPackages
- VSPackages, managed resources
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
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

You can use the <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute> attribute to indicate to Visual Studio that managed resources are available.

### [C#](#tab/csharp)
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/vssdkresources/cs/vssdkresourcespackage.cs" id="Snippet1":::

### [VB](#tab/vb)
:::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/vssdkresources/vb/vssdkresourcespackage.vb" id="Snippet1":::
---

Setting <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute> in this manner indicates that Visual Studio should ignore unmanaged satellite DLLs when it searches for resources, for example, by using <xref:Microsoft.VisualStudio.Shell.Interop.IVsShell.LoadPackageString%2A>. If Visual Studio encounters two or more resources that have the same resource ID, it uses the first resource it finds.

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
Visual Studio delays loading of VSPackages whenever possible. A consequence of embedding a CTO file in a VSPackage is that Visual Studio must load all such VSPackages in memory during Setup, which is when it builds a merged command table. Resources can be extracted from a VSPackage by examining the metadata without running code in the VSPackage. The VSPackage is not initialized at this time, so the performance loss is minimal.

When Visual Studio requests a resource from a VSPackage after Setup, that package is likely to be already loaded and initialized, so the performance loss is minimal.

## Related content
- [Managing VSPackages](../../extensibility/managing-vspackages.md)
- [Localized Resources in MFC Applications: Satellite DLLs](/cpp/build/localized-resources-in-mfc-applications-satellite-dlls)
