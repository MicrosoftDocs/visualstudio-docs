---
title: Manifest from Resources
description: Learn how to use the Manifest from Resources tool to add .png or .xaml files to an .imagemanifest file for use with the Visual Studio Image Service. 
ms.date: 08/21/2024
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Manifest from Resources

The Manifest from Resources tool is a console application that takes a list of image resources (.png or .xaml files). Using that list, it generates an .imagemanifest file that allows those images to be used with the Visual Studio Image Service. Additionally, this tool can be used to add images to an existing .imagemanifest. This tool is useful for adding high-DPI and theming support for images to a Visual Studio extension. The generated .imagemanifest file should be included in and deployed as a part of a Visual Studio extension (.vsix).

## How to use the tool
 **Syntax**

 ManifestFromResources /resources:\<Dir1>;\<Img1> /assembly:\<AssemblyName> \<Optional Args>

 **Arguments**

|**Switch name**|**Notes**|**Required or Optional**|
|-|-|-|
|/resources|A semicolon-delimited list of images or directories. This list should always contain the full list of images that will be in the manifest. If only a partial list is given, the entries not included will be lost.<br /><br /> If a given resource file is an image strip, the tool splits it into separate images before adding each subimage to the manifest.<br /><br /> If the image is a .png file, we recommended you format the name like this so that the tool can fill in the right attributes for the image: \<Name>.\<Width>.\<Height>.png.|Required|
|/assembly|The name of the managed assembly (not including the extension), or the runtime path of the native assembly that hosts the resources (relative to the manifest's runtime location). Additionally, if the assembly is strongly named, this entry should include the assembly version and public key token.|Required|
|/manifest|The name to give to the generated .imagemanifest file. This can also include an absolute or relative path to create the file in a different location. The default name matches the assembly name. Additionally, when providing the extra strong name information in the /assembly switch, this switch should be supplied with a user friendly manifest name so that the assembly strong name information isn't included in the manifest name. <br /><br /> Default: \<Current Directory>\\<Assembly\>.imagemanifest|Optional|
|/guidName|The name to give to the GUID symbol for all of the images in the generated manifest.<br /><br /> Default: AssetsGuid|Optional|
|/rootPath|The root path that needs to be stripped off before creating managed resource URIs. (This flag is to help with cases where the tool gets the relative URI path wrong, causing resources to fail to load.)<br /><br /> Default: \<Current Directory>|Optional|
|/recursive|Setting this flag tells the tool to recursively search any directories in the /resources argument. Omitting this flag results in a top-level-only search of directories.|Optional|
|/isNative|Set this flag when the assembly argument is a path for a native assembly. Omit this flag when the assembly argument is the name of a managed assembly. (For more information about this flag, see the Notes section.)|Optional|
|/newGuids|Setting this flag tells the tool to create a new value for the images' GUID symbol instead of merging the one from the existing manifest.|Optional|
|/newIds|Setting this flag tells the tool to create new ID symbol values for every image instead of merging values from the existing manifest.|Optional|
|/noLogo|Setting this flag stops product and copyright information from printing.|Optional|
|/?|Prints Help information.|Optional|
|/help|Prints out Help information.|Optional|

 **Examples**

- ManifestFromResources /resources:D:\Images /assembly:My.Assembly.Name /isNative

- ManifestFromResources /resources:D:\Images\Image1.png;D:\Images\Image1.xaml /assembly:My.Assembly.Name /manifest:MyImageManifest.imagemanifest

- ManifestFromResources /resources:D:\Images\Image1.png;D:\Images\Image1.xaml /assembly:My.Assembly.Name;v1.0.0.0;abcdef0123456789 /manifest:MyImageManifest.imagemanifest

- ManifestFromResources /resources:D:\Images\Image1.png;D:\Images\Image1.xaml /assembly:My.Assembly.Name /guidName:MyImages /newGuids /newIds

## Notes

- The tool only supports .png and .xaml files. Any other image or file types are ignored. A warning is generated for all unsupported types encountered while parsing the resources. If no supported images are found when the tool is finished parsing the resources, an error is generated

- Following the suggested format for .png images results in the tool setting the size/dimension value for the .png to the format-specified size, even if it differs from the image's actual size.

- The width/height format can be omitted for .png images, but the tool will read the image's actual width/height and use those for the image's size/dimension value.

- Running this tool on the same image strip multiple times for the same .imagemanifest will result in duplicate manifest entries. This outcome is because the tool attempts to split the image strip into standalone images and then add those to the existing manifest.

- Merging (omitting /newGuids or /newIds) should only be done for tool-generated manifests. Manifests that are customized or generated through other means might not be merged correctly.

- Manifests generated for native assemblies might need to be hand-edited after generation to make the ID symbols match the resource IDs from the native assembly's .rc file.

## Sample Output
 **Simple image manifest**

 An image manifest resembles this .xml file:

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- This file was generated by the ManifestFromResources tool.-->
<!-- Version: 14.0.15197 -->
<ImageManifest xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/VisualStudio/ImageManifestSchema/2014">
  <Symbols>
    <String Name="Resources" Value="/My.Assembly.Name;Component/Resources/Images" />
    <Guid Name="AssetsGuid" Value="{fb41b7ef-6587-480c-aa27-5b559d42cfc9}" />
    <ID Name="MyImage" Value="0" />
  </Symbols>
  <Images>
    <Image Guid="$(AssetsGuid)" ID="$(MyImage)">
      <Source Uri="$(Resources)/Xaml/MyImage.xaml" />
      <Source Uri="$(Resources)/Png/MyImage.16.16.png">
        <Size Value="16" />
      </Source>
    </Image>
  </Images>
  <ImageLists />
</ImageManifest>
```

 **Image manifest for an image strip**

 An image manifest for an image strip is similar to this .xml file:

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- This file was generated by the ManifestFromResources tool.-->
<!-- Version: 14.0.15197 -->
<ImageManifest xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/VisualStudio/ImageManifestSchema/2014">
  <Symbols>
    <String Name="Resources" Value="/My.Assembly.Name;Component/Resources/ImageStrip" />
    <Guid Name="AssetsGuid" Value="{fb41b7ef-6587-480c-aa27-5b559d42cfc9}" />
    <ID Name="MyImageStrip_0" Value="1" />
    <ID Name="MyImageStrip_1" Value="2" />
    <ID Name="MyImageStrip" Value="3" />
  </Symbols>
  <Images>
    <Image Guid="$(AssetsGuid)" ID="$(MyImageStrip_0)">
      <Source Uri="$(Resources)/MyImageStrip_0.png">
        <Size Value="16" />
      </Source>
    </Image>
    <Image Guid="$(AssetsGuid)" ID="$(MyImageStrip_1)">
      <Source Uri="$(Resources)/MyImageStrip_1.png">
        <Size Value="16" />
      </Source>
    </Image>
  </Images>
  <ImageLists>
    <ImageList Guid="$(AssetsGuid)" ID="$(MyImageStrip)">
      <ContainedImage Guid="$(AssetsGuid)" ID="$(MyImageStrip_0)" />
      <ContainedImage Guid="$(AssetsGuid)" ID="$(MyImageStrip_1)" />
    </ImageList>
  </ImageLists>
</ImageManifest>
```

 **Image manifest for native assembly image resources**

 An image manifest for native images is similar to this .xml file:

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- This file was generated by the ManifestFromResources tool.-->
<!-- Version: 14.0.15198 -->
<ImageManifest xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/VisualStudio/ImageManifestSchema/2014">
  <Symbols>
    <String Name="Resources" Value="..\Assembly\Folder\My.Assembly.Name" />
    <Guid Name="AssetsGuid" Value="{442d8739-efde-46a4-8f29-e3a1e5e7f8b4}" />
    <ID Name="MyImage1" Value="0" />
    <ID Name="MyImage2" Value="1" />
  </Symbols>
  <Images>
    <Image Guid="$(AssetsGuid)" ID="$(MyImage1)">
      <Source Uri="$(Resources)">
        <Size Value="16" />
        <NativeResource ID="$(MyImage1)" Type="PNG" />
      </Source>
    </Image>
    <Image Guid="$(AssetsGuid)" ID="$(MyImage2)">
      <Source Uri="$(Resources)">
        <Size Value="16" />
        <NativeResource ID="$(MyImage2)" Type="PNG" />
      </Source>
    </Image>
  </Images>
  <ImageLists />
</ImageManifest>
```
