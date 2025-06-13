---
title: VSIX Color Compiler
description: Learn about the Visual Studio Extension Color Compiler tool, which is a console application that coverts colors in Visual Studio themes to a .pkgdef file.
ms.date: 11/04/2016
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSIX Color Compiler

The Visual Studio Extension Color Compiler tool is a console application that takes an .xml file representing colors for existing Visual Studio themes and coverts it to a .pkgdef file so that those colors can be used in Visual Studio. Because it's easy to compare differences between .xml files, this tool is useful for managing custom colors in source control. It also can be hooked into build environments so that the output of the build is a valid .pkgdef file.

 **Theme XML schema**

 A complete theme .xml file looks like this:

```xml
<Themes>
      <!—one or Theme elements -->
      <Theme>
        <!-- one or more Category elements -->
        <Category>
          <!-- one or more Color elements -->
          <Color>
            <!-- zero or one Background element -->
            <Background />
            <!-- zero or one Foreground element -->
            <Foreground />
          </Color>
        </Category>
      </Theme>
</Themes>
```

 **Theme**

 The \<Theme> element defines an entire theme. A theme must contain at least one \<Category> element. Theme elements are defined like this:

```xml
<Theme Name="name" GUID="guid">
      <!-- one or more Category elements -->
</Theme>
```

|**Attribute**|**Definition**|
|-|-|
|Name|[Required] The name of the theme|
|GUID|[Required] The theme's GUID (must match GUID formatting)|

 When creating custom colors for Visual Studio, those colors need to be defined for the following themes. If no colors exist for a particular theme, Visual Studio attempts to load the missing colors from the Light theme.

|**Theme name**|**Theme GUID**|
|-|-|
|Light|{de3dbbcd-f642-433c-8353-8f1df4370aba}|
|Dark|{1ded0138-47ce-435e-84ef-9ec1f439b749}|
|Blue|{a4d6a176-b948-4b29-8c66-53c97a1ed7d0}|
|High Contrast|{a4d6a176-b948-4b29-8c66-53c97a1ed7d0}|

 **Category**

 The \<Category> element defines a collection of colors in a theme. Category names provide logical groupings, and should be defined as narrowly as possible. A category must contain at least one \<Color> element. Category elements are defined like this:

```xml
<Category Name="name" GUID="guid">
      <!-- one or more Color elements -->
 </Category>
```

|**Attribute**|**Definition**|
|-|-|
|Name|[Required] The name of the category|
|GUID|[Required] The category's GUID (must match GUID formatting)|

 **Color**

 The \<Color> element defines a color for a component or state of UI. The preferred naming scheme for a color is [UI type] [State]. Do not use the word "color," as it is redundant. A color should clearly indicate the element type and the situations, or "state," for which the color will be applied. A color must not be empty, and must contain either one or both of a \<Background> and \<Foreground> element. Color elements are defined like this:

```xml
<Color Name="name">
        <Background /> <!-- zero or one Background element -->
        <Foreground /> <!-- zero or one Foreground element -->
 </Color>
```

|**Attribute**|**Definition**|
|-|-|
|Name|[Required] The name of the color|

 **Background and/or Foreground**

 The \<Background> and \<Foreground> elements define a color's value and type for either the background or foreground of a UI element. These elements have no children.

```xml
<Background Type="type" Source="int" />
<Foreground Type="type" Source="int" />
```

|**Attribute**|**Definition**|
|-|-|
|Type|[Required] The type of the color. It can be one of the following:<br /><br /> *CT_INVALID:* The color is invalid or not set.<br /><br /> *CT_RAW:* A raw ARGB value.<br /><br /> *CT_COLORINDEX:* DO NOT USE.<br /><br /> *CT_SYSCOLOR:* A Windows system color from SysColor.<br /><br /> *CT_VSCOLOR:* A Visual Studio color from __VSSYSCOLOREX.<br /><br /> *CT_AUTOMATIC:* The automatic color.<br /><br /> *CT_TRACK_FOREGROUND:* DO NOT USE.<br /><br /> *CT_TRACK_BACKGROUND:* DO NOT USE.|
|Source|[Required] The value of the color represented in hexadecimal|

 All values supported by the __VSCOLORTYPE enumeration are supported by the schema in the Type attribute. However, we recommend that you use only CT_RAW and CT_SYSCOLOR.

 **All together**

 This is a simple example of a valid theme .xml file:

```xml
<Themes>
  <Theme Name="Light" GUID="{de3dbbcd-f642-433c-8353-8f1df4370aba}">
    <Category Name="MyCategory" GUID="{0A96238B-70CE-4479-9170-EECEAA3FCD58}">
      <Color Name="MyActiveBorder">
        <Background Type="CT_RAW" Source="FFCCCEDB" />
      </Color>
    </Category>
  </Theme>
</Themes>
```

## How to use the tool
 **Syntax**

 VsixColorCompiler \<XML file> \<PkgDef file> \<Optional Args>

 **Arguments**

|**Switch name**|**Notes**|**Required or Optional**|
|-|-|-|
|Unnamed (.xml file)|This is the first unnamed parameter and is the path to the XML file to convert.|Required|
|Unnamed (.pkgdef file)|This is the second unnamed parameter and is the output path for the generated .pkgdef file.<br /><br /> Default: \<XML Filename>.pkgdef|Optional|
|/noLogo|Setting this flag stops product and copyright information from printing.|Optional|
|/?|Print out Help information.|Optional|
|/help|Print out Help information.|Optional|

 **Examples**

- VsixColorCompiler D:\xml\colors.xml D:\pkgdef\colors.pkgdef

- VsixColorCompiler D:\xml\colors.xml /noLogo

## Notes

- This tool requires that the latest version of the VC++ runtime be installed.

- Only single files are supported. Bulk conversion via folder paths is not supported.

- The tool can be found in `<VS Install Path>\VSSDK\VisualStudioIntegration\Tools\Bin\`

## Sample output
 The .pkgdef file generated by the tool will be similar to the below keys:

```
[$RootKey$\Themes\{de3dbbcd-f642-433c-8353-8f1df4370aba}\Environment]
"Data"=hex:3a,00,00,00,0b,00,00,00,01,00,00,00,c3,d9,4e,62,fd,bd,fa,41,96,c3,7c,82,4e,a3,2e,3d,01,00,00,00,0c,00,00,00,41,63,74,69,76,65,42,6f,72,64,65,72,01,cc,ce,db,ff,01,33,31,24,ff

[$RootKey$\Themes\{de3dbbcd-f642-433c-8353-8f1df4370aba}\TreeView]
"Data"=hex:38,00,00,00,0b,00,00,00,01,00,00,00,8e,f0,ec,92,13,8b,f4,4c,99,e9,ae,26,92,38,21,85,01,00,00,00,0a,00,00,00,42,61,63,6b,67,72,6f,75,6e,64,01,f5,f5,f5,ff,01,1e,1e,1e,ff
```
