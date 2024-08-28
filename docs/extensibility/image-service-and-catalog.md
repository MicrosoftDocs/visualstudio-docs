---
title: Image Service and Catalog
description: This article contains guidance and best practices for adopting the Visual Studio Image Service and Image Catalog.
ms.date: 08/21/2024
ms.topic: conceptual
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# Image service and catalog

This cookbook contains guidance and best practices for adopting the Visual Studio Image Service and Image Catalog introduced in Visual Studio 2015.

 The image service introduced in Visual Studio 2015 lets developers get the best images for the device and the user's chosen theme to display the image, including correct theming for the context in which they are displayed. Adopting the image service will help eliminate major pain points related to asset maintenance, HDPI scaling, and theming.

|**Problems today**|**Solutions**|
|-|-|
|Background color blending|Built-in alpha blending|
|Theming (some) images|Theme metadata|
|High Contrast mode|Alternate High Contrast resources|
|Need multiple resources for different DPI modes|Selectable resources with vector-based fallback|
|Duplicate images|One identifier per image concept|

 Why adopt the image service?

- Always get the latest "pixel-perfect" image from Visual Studio

- You can submit and use your own images

- No need to test your images out when Windows adds new DPI scaling

- Address old architectural hurdles in your implementations

  The Visual Studio shell toolbar before and after using the image service:

  ![Image Service Before and After](../extensibility/media/image-service-before-and-after.png "Image Service Before and After")

## How it works
 The image service can supply a bitmapped image suitable for any supported UI framework:

- WPF: BitmapSource

- WinForms: System.Drawing.Bitmap

- Win32: HBITMAP

  Image service flow diagram

  ![Image Service Flow Diagram](../extensibility/media/image-service-flow-diagram.png "Image Service Flow Diagram")

  **Image monikers**

  An image moniker (or moniker for short) is a GUID/ID pair that uniquely identifies an image asset or image list asset in the image library.

  **Known monikers**

  The set of image monikers contained in the Visual Studio Image Catalog and publicly consumable by any Visual Studio component or extension.

  **Image manifest files**

  Image manifest (*.imagemanifest*) files are XML files that define a set of image assets, the monikers that represent those assets, and the real image or images that represent each asset. Image manifests can define standalone images or image lists for legacy UI support. Additionally, there are attributes that can be set either on the asset or on the individual images behind each asset to change when and how those assets are displayed.

  **Image manifest schema**

  A complete image manifest looks like this:

```xml
<ImageManifest>
      <!-- zero or one Symbols elements -->
      <Symbols>
        <!-- zero or more Import, Guid, ID, or String elements -->
      </Symbols>
      <!-- zero or one Images elements -->
      <Images>
        <!-- zero or more Image elements -->
      </Images>
      <!-- zero or one ImageLists elements -->
      <ImageLists>
        <!-- zero or more ImageList elements -->
      </ImageLists>
</ImageManifest>
```

 **Symbols**

 As a readability and maintenance aid, the image manifest can use symbols for attribute values. Symbols are defined like this:

```xml
<Symbols>
      <Import Manifest="manifest" />
      <Guid Name="ShellCommandGuid" Value="8ee4f65d-bab4-4cde-b8e7-ac412abbda8a" />
      <ID Name="cmdidSaveAll" Value="1000" />
      <String Name="AssemblyName" Value="Microsoft.VisualStudio.Shell.UI.Internal" />
      <!-- If your assembly is strongly named, you'll need the version and public key token as well -->
      <!-- <String Name="AssemblyName" Value="Microsoft.VisualStudio.Shell.UI.Internal;v17.0.0.0;b03f5f7f11d50a3a" /> -->
</Symbols>
```

|**Subelement**|**Definition**|
|-|-|
|Import|Imports the symbols of the given manifest file for use in the current manifest|
|Guid|The symbol represents a GUID and must match GUID formatting|
|ID|The symbol represents an ID and must be a nonnegative integer|
|String|The symbol represents an arbitrary string value|

 Symbols are case-sensitive, and referenced using $(symbol-name) syntax:

```xml
<Image Guid="$(ShellCommandGuid)" ID="$(cmdidSaveAll)" >
      <Source Uri="/$(AssemblyName);Component/Resources/image.xaml" />
</Image>
```

 Some symbols are predefined for all manifests. These can be used in the Uri attribute of the \<Source> or \<Import> element to reference paths on the local machine.

|**Symbol**|**Description**|
|-|-|
|CommonProgramFiles|The value of the %CommonProgramFiles% environment variable|
|LocalAppData|The value of the %LocalAppData% environment variable|
|ManifestFolder|The folder containing the manifest file|
|MyDocuments|The full path of the My Documents folder of the current user|
|ProgramFiles|The value of the %ProgramFiles% environment variable|
|System|The *Windows\System32* folder|
|WinDir|The value of the %WinDir% environment variable|

 **Image**

 The \<Image> element defines an image that can be referenced by a moniker. The GUID and ID taken together form the image moniker. The moniker for the image must be unique across the entire image library. If more than one image has a given moniker, the first one encountered while building the library is the one that is retained.

 It must contain at least one source. Size-neutral sources will give the best results across a broad range of sizes, but they are not required. If the service is asked for an image of a size not defined in the \<Image> element and there is no size-neutral source, the service will choose the best size-specific source and scale it to the requested size.

```xml
<Image Guid="guid" ID="int" AllowColorInversion="true/false">
      <Source ... />
      <!-- optional additional Source elements -->
</Image>
```

|**Attribute**|**Definition**|
|-|-|
|Guid|[Required] The GUID portion of the image moniker|
|ID|[Required] The ID portion of the image moniker|
|AllowColorInversion|[Optional, default true] Indicates whether the image can have its colors programmatically inverted when used on a dark background.|

 **Source**

 The \<Source> element defines a single image source asset (XAML and PNG).

```xml
<Source Uri="uri" Background="background">
      <!-- optional NativeResource element -->
 </Source>
```

|**Attribute**|**Definition**|
|-|-|
|Uri|[Required] A URI that defines where the image can be loaded from. It can be one of the following:<br /><br /> -   A [Pack URI](/dotnet/framework/wpf/app-development/pack-uris-in-wpf) using the application:/// authority<br />-   An absolute component resource reference<br />-   A path to a file containing a native resource|
|Background|[Optional] Indicates what on kind of background the source is intended to be used.<br /><br /> It can be one of the following:<br /><br /> *Light:* The source can be used on a light background.<br /><br /> *Dark:* The source can be used on a dark background.<br /><br /> *HighContrast:* The source can be used on any background in High Contrast mode.<br /><br /> *HighContrastLight:* The source can be used on a light background in High Contrast mode.<br /><br /> *HighContrastDark:* The source can be used on a dark background in High Contrast mode.<br /><br /> If the Background attribute is omitted, the source can be used on any background.<br /><br /> If Background is *Light*, *Dark*, *HighContrastLight*, or *HighContrastDark*, the source's colors are never inverted. If Background is omitted or set to *HighContrast*, the inversion of the source's colors is controlled by the image's **AllowColorInversion** attribute.|

A \<Source> element can have exactly one of the following optional subelements:

|**Element**|**Attributes (all required)**|**Definition**|
|-|-|-|
|\<Size>|Value|The source will be used for images of the given size (in device units). The image will be square.|
|\<SizeRange>|MinSize, MaxSize|The source will be used for images from MinSize to MaxSize (in device units) inclusively. The image will be square.|
|\<Dimensions>|Width, Height|The source will be used for images of the given width and height (in device units).|
|\<DimensionRange>|MinWidth, MinHeight,<br /><br /> MaxWidth, MaxHeight|The source will be used for images from the minimum width/height to the maximum width/height (in device units) inclusively.|

 A \<Source> element can also have an optional \<NativeResource> subelement, which defines a \<Source> that is loaded from a native assembly rather than a managed assembly.

```xml
<NativeResource Type="type" ID="int" />
```

|**Attribute**|**Definition**|
|-|-|
|Type|[Required] The type of the native resource, either XAML or PNG|
|ID|[Required] The integer ID portion of the native resource|

 **ImageList**

 The \<ImageList> element defines a collection of images that can be returned in a single strip. The strip is built on demand, as needed.

```xml
<ImageList>
      <ContainedImage Guid="guid" ID="int" External="true/false" />
      <!-- optional additional ContainedImage elements -->
 </ImageList>
```

|**Attribute**|**Definition**|
|-|-|
|Guid|[Required] The GUID portion of the image moniker|
|ID|[Required] The ID portion of the image moniker|
|External|[Optional, default false] Indicates whether the image moniker references an image in the current manifest.|

 The moniker for the contained image does not have to reference an image defined in the current manifest. If the contained image cannot be found in the image library, a blank placeholder image will be used in its place.

## Using the image service

### First steps (managed)
 To use the image service, you need to add references to some or all of the following assemblies to your project:

- *Microsoft.VisualStudio.ImageCatalog.dll*

  - Required if you use the built-in image catalog **KnownMonikers**.

- *Microsoft.VisualStudio.Imaging.dll*

  - Required if you use **CrispImage** and **ImageThemingUtilities** in your WPF UI.

- *Microsoft.VisualStudio.Imaging.Interop.14.0.DesignTime.dll*

  - Required if you use the **ImageMoniker** and **ImageAttributes** types.

  - **EmbedInteropTypes** should be set to true.

- *Microsoft.VisualStudio.Shell.Interop.14.0.DesignTime*

  - Required if you use the **IVsImageService2** type.

  - **EmbedInteropTypes** should be set to true.

- *Microsoft.VisualStudio.Utilities.dll*

  - Required if you use the **BrushToColorConverter** for the **ImageThemingUtilities.ImageBackgroundColor** in your WPF UI.

- *Microsoft.VisualStudio.Shell.\<VSVersion>.0*

  - Required if you use the **IVsUIObject** type.

- *Microsoft.VisualStudio.Shell.Interop.10.0.dll*

  - Required if you use the WinForms-related UI helpers.

  - **EmbedInteropTypes** should be set to true

### First steps (native)
 To use the image service, you need to include some or all of the following headers to your project:

- **KnownImageIds.h**

  - Required if you use the built-in image catalog **KnownMonikers**, but cannot use the **ImageMoniker** type, such as when returning values from **IVsHierarchy GetGuidProperty** or **GetProperty** calls.

- **KnownMonikers.h**

  - Required if you use the built-in image catalog **KnownMonikers**.

- **ImageParameters140.h**

  - Required if you use the **ImageMoniker** and **ImageAttributes** types.

- **VSShell140.h**

  - Required if you use the **IVsImageService2** type.

- **ImageThemingUtilities.h**

  - Required if you are unable to let the image service handle theming for you.

  - Do not use this header if the image service can handle your image theming.

- **VsDpiAwareness.h**

  - Required if you use the DPI awareness helpers to get the current DPI.

## How do I write new WPF UI?

1. Start by adding the assembly references required in the above first steps section to your project. You don't need to add all of them, so add just the references you need. (Note: if you are using or have access to **Colors** instead of **Brushes**, then you can skip the reference to **Utilities**, since you won't need the converter.)

2. Select the desired image and get its moniker. Use a **KnownMoniker**, or use your own if you have your own custom images and monikers.

3. Add **CrispImages** to your XAML. (See below example.)

4. Set the **ImageThemingUtilities.ImageBackgroundColor** property in your UI hierarchy. (This should be set at the location where the background color is known, not necessarily on the **CrispImage**.) (See below example.)

```xaml
<Window
  x:Class="WpfApplication.MainWindow"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:imaging="clr-namespace:Microsoft.VisualStudio.Imaging;assembly=Microsoft.VisualStudio.Imaging"
  xmlns:theming="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Imaging"
  xmlns:utilities="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Utilities"
  xmlns:catalog="clr-namespace:Microsoft.VisualStudio.Imaging;assembly=Microsoft.VisualStudio.ImageCatalog"
  Title="MainWindow" Height="350" Width="525" UseLayoutRounding="True">
  <Window.Resources>
    <utilities:BrushToColorConverter x:Key="BrushToColorConverter"/>
  </Window.Resources>
  <StackPanel Background="White" VerticalAlignment="Center"
    theming:ImageThemingUtilities.ImageBackgroundColor="{Binding Background, RelativeSource={RelativeSource Self}, Converter={StaticResource BrushToColorConverter}}">
    <imaging:CrispImage Width="16" Height="16" Moniker="{x:Static catalog:KnownMonikers.MoveUp}" />
  </StackPanel>
</Window>
```

 **How do I update existing WPF UI?**

 Updating existing WPF UI is a relatively simple process that consists of three basic steps:

1. Replace all \<Image> elements in your UI with \<CrispImage> elements.

2. Change all the Source attributes to Moniker attributes.

    - If the image never changes and you are using **KnownMonikers**, then statically bind that property to the **KnownMoniker**. (See the above example.)

    - If the image never changes and you are using your own custom image, then statically bind to your own moniker.

    - If the image can change, bind the Moniker attribute to a code property that notifies on property changes.

3. Somewhere in the UI hierarchy, set **ImageThemingUtilities.ImageBackgroundColor** to make sure color inversion works correctly.

    - This might require the use of the **BrushToColorConverter** class. (See the above example.)

## How do I update Win32 UI?
 Add the following to your code wherever appropriate to replace the raw loading of images. Switch values for returning HBITMAPs versus HICONs versus HIMAGELIST as needed.

 **Get the image service**

```cpp
CComPtr<IVsImageService2> spImgSvc;
CGlobalServiceProvider::HrQueryService(SID_SVsImageService, &spImgSvc);
```

 **Requesting the image**

```cpp
UINT dpiX, dpiY;
HWND hwnd = // get the HWND where the image will be displayed
VsUI::CDpiAwareness::GetDpiForWindow(hwnd, &dpiX, &dpiY);

ImageAttributes attr = { 0 };
attr.StructSize      = sizeof(attributes);
attr.Format          = DF_Win32;
// IT_Bitmap for HBITMAP, IT_Icon for HICON, IT_ImageList for HIMAGELIST
attr.ImageType       = IT_Bitmap;
attr.LogicalWidth    = 16;
attr.LogicalHeight   = 16;
attr.Dpi             = dpiX;
// Desired RGBA color, if you don't use this, don't set IAF_Background below
attr.Background      = 0xFFFFFFFF;
attr.Flags           = IAF_RequiredFlags | IAF_Background;

CComPtr<IVsUIObject> spImg;
// Replace this KnownMoniker with your desired ImageMoniker
spImgSvc->GetImage(KnownMonikers::Blank, attributes, &spImg);
```

## How do I update WinForms UI?
 Add the following to your code wherever appropriate to replace the raw loading of images. Switch values for returning Bitmaps versus Icons as needed.

 **Helpful using statement**

```csharp
using GelUtilities = Microsoft.Internal.VisualStudio.PlatformUI.Utilities;
```

 **Get the image service**

```csharp
// This or your preferred way of querying for Visual Studio services
IVsImageService2 imageService = (IVsImageService2)Package.GetGlobalService(typeof(SVsImageService));

```

 **Request the image**

```csharp
Control control = // get the control where the image will be displayed

ImageAttributes attributes = new ImageAttributes
{
    StructSize    = Marshal.SizeOf(typeof(ImageAttributes)),
    // IT_Bitmap for Bitmap, IT_Icon for Icon, IT_ImageList for ImageList
    ImageType     = (uint)_UIImageType.IT_Bitmap,
    Format        = (uint)_UIDataFormat.DF_WinForms,
    LogicalWidth  = 16,
    LogicalHeight = 16,
    Dpi           = (int)DpiAwareness.GetWindowDpi(control.Handle);
    // Desired RGBA color, if you don't use this, don't set IAF_Background below
    Background    = 0xFFFFFFFF,
    Flags         = unchecked((uint)_ImageAttributesFlags.IAF_RequiredFlags | _ImageAttributesFlags.IAF_Background),
};

// Replace this KnownMoniker with your desired ImageMoniker
IVsUIObject uIObj = imageService.GetImage(KnownMonikers.Blank, attributes);

Bitmap bitmap = (Bitmap)GelUtilities.GetObjectData(uiObj); // Use this if you need a bitmap
// Icon icon = (Icon)GelUtilities.GetObjectData(uiObj);    // Use this if you need an icon
```

## How do I use image monikers in a new tool window?
 The VSIX package project template was updated for Visual Studio 2015. To create a new tool window, right-click on the VSIX project and select **Add** > **New Item** (**Ctrl**+**Shift**+**A**). Under the Extensibility node for the project language, select **Custom Tool Window**, give the tool window a name, and press the **Add** button.

 These are the key places to use monikers in a tool window. Follow the instructions for each:

1. The tool window tab when the tabs get small enough (also used in the **Ctrl**+**Tab** window switcher).

    Add this line to the constructor for the class that derives from the **ToolWindowPane** type:

   ```csharp
   // Replace this KnownMoniker with your desired ImageMoniker
   this.BitmapImageMoniker = KnownMonikers.Blank;
   ```

2. The command to open the tool window.

   In the `.vsct` file for the package, edit the tool window's command button:

   ```xml
   <Button guid="guidPackageCmdSet" id="CommandId" priority="0x0100" type="Button">
     <Parent guid="guidSHLMainMenu" id="IDG_VS_WNDO_OTRWNDWS1"/>
     <!-- Replace this KnownMoniker with your desired ImageMoniker -->
     <Icon guid="ImageCatalogGuid" id="Blank" />
     <!-- Add this -->
     <CommandFlag>IconIsMoniker</CommandFlag>
     <Strings>
       <ButtonText>MyToolWindow</ButtonText>
     </Strings>
   </Button>
   ```

   Ensure the following also exists at the top of the file, after the `<Extern>` elements:
   
   ```xml
   <Include href="KnownImageIds.vsct"/>
   ```

## How do I use image monikers in an existing tool window?

Updating an existing tool window to use image monikers is similar to the steps for creating a new tool window.

These are the key places to use monikers in a tool window. Follow the instructions for each:

1. The tool window tab when the tabs get small enough (also used in the **Ctrl**+**Tab** window switcher).

   1. Remove these lines (if they exist) in the constructor for the class that derives from the **ToolWindowPane** type:

       ```csharp
       this.BitmapResourceID = <Value>;
       this.BitmapIndex = <Value>;
       ```

   2. See step #1 of the "How do I use image monikers in a new tool window?" section above.

2. The command to open the tool window.

   - See step #2 of the "How do I use image monikers in a new tool window?" section above.

## How do I use image monikers in a .vsct file?
 Update your `.vsct` file as indicated by the commented lines below:

```xml
<?xml version="1.0" encoding="utf-8"?>
<CommandTable xmlns="http://schemas.microsoft.com/VisualStudio/2005-10-18/CommandTable" xmlns:xs="http://www.w3.org/2001/XMLSchema">
  <!--  Include the definitions for images included in the VS image catalog -->
  <Include href="KnownImageIds.vsct"/>
  <Commands package="guidMyPackage">
    <Buttons>
      <Button guid="guidMyCommandSet" id="cmdidMyCommand" priority="0x0000" type="Button">
        <!-- Add an Icon element, changing the attributes to match the image moniker you want to use.
             In this case, we're using the Guid for the VS image catalog.
             Change the id attribute to be the ID of the desired image moniker. -->
        <Icon guid="ImageCatalogGuid" id="OpenFolder" />
        <CommandFlag>DynamicVisibility</CommandFlag>
        <CommandFlag>DefaultInvisible</CommandFlag>
        <CommandFlag>DefaultDisabled</CommandFlag>
        <CommandFlag>CommandWellOnly</CommandFlag>
        <CommandFlag>IconAndText</CommandFlag>
        <!-- Add the IconIsMoniker CommandFlag -->
        <CommandFlag>IconIsMoniker</CommandFlag>
        <Strings>
          <ButtonText>Quick Fixes...</ButtonText>
          <CommandName>Show Quick Fixes</CommandName>
          <CanonicalName>ShowQuickFixes</CanonicalName>
          <LocCanonicalName>ShowQuickFixes</LocCanonicalName>
        </Strings>
      </Button>
    </Buttons>
  </Commands>
  <!-- It is recommended that you remove <Bitmap> elements that are no longer used in the vsct file -->
  <Symbols>
    <GuidSymbol name="guidMyPackage"    value="{1491e936-6ffe-474e-8371-30e5920d8fdd}" />
    <GuidSymbol name="guidMyCommandSet" value="{10347de4-69a9-47f4-a950-d3301f6d2bc7}">
      <IDSymbol name="cmdidMyCommand" value="0x9437" />
    </GuidSymbol>
  </Symbols>
</CommandTable>
```

 **What if my .vsct file also needs to be read by older versions of Visual Studio?**

 Older versions of Visual Studio do not recognize the **IconIsMoniker** command flag. You can use images from the image service on versions of Visual Studio that support it, but continue to use old-style images on older versions of Visual Studio. To do this, you'd leave the `.vsct` file unchanged (and therefore compatible with older versions of Visual Studio), and create a CSV (comma-separated values) file that maps from GUID/ID pairs defined in a `.vsct` file's \<Bitmaps> element to image moniker GUID/ID pairs.

 The format of the mapping CSV file is:

```
Icon guid, Icon id, Moniker guid, Moniker id
b714fcf7-855e-4e4c-802a-1fd87144ccad,1,fda30684-682d-421c-8be4-650a2967058e,100
b714fcf7-855e-4e4c-802a-1fd87144ccad,2,fda30684-682d-421c-8be4-650a2967058e,200
```

 The CSV file is deployed with the package and its location is specified by the **IconMappingFilename** property of the **ProvideMenuResource** package attribute:

```csharp
[ProvideMenuResource("MyPackage.ctmenu", 1, IconMappingFilename="IconMappings.csv")]
```

 The **IconMappingFilename** is either a relative path implicitly rooted at $PackageFolder$ (as in the example above), or an absolute path explicitly rooted at a directory defined by an environment variable, such as *@"%UserProfile%\dir1\dir2\MyMappingFile.csv"*.

## How do I port a project system?
 **How to supply ImageMonikers for a project**

1. Implement **VSHPROPID_SupportsIconMonikers** on the project's **IVsHierarchy**, and return true.

2. Implement either **VSHPROPID_IconMonikerImageList** (if the original project used **VSHPROPID_IconImgList**) or **VSHPROPID_IconMonikerGuid**, **VSHPROPID_IconMonikerId**, **VSHPROPID_OpenFolderIconMonikerGuid**, **VSHPROPID_OpenFolderIconMonikerId** (if the original project used **VSHPROPID_IconHandle** and **VSHPROPID_OpenFolderIconHandle**).

3. Change the implementation of the original VSHPROPIDs for icons to create "legacy" versions of the icons if extension points request them. **IVsImageService2** provides functionality necessary to get those icons

   **Extra requirements for VB/C# project flavors**

   Only implement **VSHPROPID_SupportsIconMonikers** if you detect that your project is the **outermost flavor**. Otherwise, the actual outermost flavor may not support image monikers in reality, and your base flavor might effectively "hide" customized images.

   **How do I use image monikers in CPS?**

   Setting custom images in CPS (Common Project System) can be done manually or via an item template that comes with the Project System Extensibility SDK.

   **Using the Project System Extensibility SDK**

   Follow the instructions at [Provide custom icons for the Project Type/Item type](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/scenario/provide_custom_icons_for_the_project_or_item_type.md) to customize your CPS images. More information about CPS can be found at [Visual Studio Project System extensibility documentation](https://github.com/Microsoft/VSProjectSystem)

   **Manually use ImageMonikers**

4. Implement and export the **IProjectTreeModifier** interface in your project system.

5. Determine which **KnownMoniker** or custom image moniker you want to use.

6. In the **ApplyModifications** method, do the following somewhere in the method before returning the new tree, similar to the below example:

   ```csharp
   // Replace this KnownMoniker with your desired ImageMoniker
   tree = tree.SetIcon(KnownMonikers.Blank.ToProjectSystemType());
   ```

7. If you are creating a new tree, you can set the custom images by passing in the desired monikers into the NewTree method, similar to the below example:

   ```csharp
   // Replace this KnownMoniker with your desired ImageMoniker
   ProjectImageMoniker icon         = KnownMonikers.FolderClosed.ToProjectSystemType();
   ProjectImageMoniker expandedIcon = KnownMonikers.FolderOpened.ToProjectSystemType();

   return this.ProjectTreeFactory.Value.NewTree(/*caption*/<value>,
                                                /*filePath*/<value>,
                                                /*browseObjectProperties*/<value>,
                                                icon,
                                                expandedIcon);
   ```

## How do I convert from a real image strip to a moniker-based image strip?
 **I need to support HIMAGELISTs**

 If there is an already existing image strip for your code that you want to update to use the image service, but you are constrained by APIs that require passing around image lists, you can still get the benefits of the image service. To create a moniker-based image strip, follow the steps below to create a manifest from existing monikers.

1. Run the **ManifestFromResources** tool, passing it the image strip. This will generate a manifest for the strip.

   - Recommended: provide a non default name for the manifest to suit its usage.

2. If you are using only **KnownMonikers**, then do the following:

   - Replace the \<Images> section of the manifest with \<Images/>.

   - Remove all the subimage IDs (anything with \<imagestrip name>_##).

   - Recommended: rename the AssetsGuid symbol and image strip symbol to suit its usage.

   - Replace each **ContainedImage**'s GUID with $(ImageCatalogGuid), replace each **ContainedImage**'s ID with $(\<moniker>), and add the External="true" attribute to each **ContainedImage**

       - \<moniker> should be replaced with the **KnownMoniker** that matches the image but with the "KnownMonikers." removed from the name.

   - Add <Import Manifest="$(ManifestFolder)\\<Relative install dir path to *\>\Microsoft.VisualStudio.ImageCatalog.imagemanifest" /\*> to the top of the \<Symbols> section.

       - The relative path is determined by the deployment location defined in the setup authoring for the manifest.

3. Run the **ManifestToCode** tool to generate wrappers so that the existing code has a moniker it can use to query the image service for the image strip.

   - Recommended: provide nondefault names for the wrappers and namespaces to suit their usage.

4. Do all the adds, setup authoring/deployment, and other code changes to work with the image service and the new files.

   Sample manifest including both internal and external images to see what it should look like:

```xml
<?xml version="1.0"?>
<ImageManifest
  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  xmlns:xsd="http://www.w3.org/2001/XMLSchema"
  xmlns="http://schemas.microsoft.com/VisualStudio/ImageManifestSchema/2014">

  <Symbols>
    <!-- This needs to be the relative path from your manifest to the ImageCatalog's manifest
         where $(ManifestFolder) is the deployed location of this manifest. -->
    <Import Manifest="$(ManifestFolder)\<RelPath>\Microsoft.VisualStudio.ImageCatalog.imagemanifest" />

    <String Name="Resources" Value="/My.Assembly.Name;Component/Resources/ImageStrip" />
    <Guid Name="ImageGuid" Value="{fb41b7ef-6587-480c-aa27-5b559d42cfc9}" />
    <Guid Name="ImageStripGuid" Value="{9c84a570-d9a7-4052-a340-188fb276f973}" />
    <ID Name="MyImage_0" Value="100" />
    <ID Name="MyImage_1" Value="101" />
    <ID Name="InternalList" Value="1001" />
    <ID Name="ExternalList" Value="1002" />
  </Symbols>

  <Images>
    <Image Guid="$(ImageGuid)" ID="$(MyImage_0)">
      <Source Uri="$(Resources)/MyImage_0.png">
        <Size Value="16" />
      </Source>
    </Image>
    <Image Guid="$(ImageGuid)" ID="$(MyImage_1)">
      <Source Uri="$(Resources)/MyImage_1.png">
        <Size Value="16" />
      </Source>
    </Image>
  </Images>

  <ImageLists>
    <ImageList Guid="$(ImageStripGuid)" ID="$(InternalList)">
      <ContainedImage Guid="$(ImageGuid)" ID="$(MyImage_0)" />
      <ContainedImage Guid="$(ImageGuid)" ID="$(MyImage_1)" />
    </ImageList>
    <ImageList Guid="$(ImageStripGuid)" ID="$(ExternalList)">
      <ContainedImage Guid="$(ImageCatalogGuid)" ID="$(StatusError)" External="true" />
      <ContainedImage Guid="$(ImageCatalogGuid)" ID="$(StatusWarning)" External="true" />
      <ContainedImage Guid="$(ImageCatalogGuid)" ID="$(StatusInformation)" External="true" />
    </ImageList>
  </ImageLists>

</ImageManifest>
```

 **I don't need to support HIMAGELISTs**

1. Determine the set of **KnownMonikers** that match the images in your image strip, or create your own monikers for the images in your image strip.

2. Update whatever mapping you used to get the image at the required index in the image strip to use the monikers instead.

3. Update your code to use the image service to request monikers via the updated mapping. (This might mean updating to **CrispImages** for managed code, or requesting HBITMAPs or HICONs from the image service and passing them around for native code.)

## Testing your images
 You can use the Image Library Viewer tool to test your image manifests to make sure everything is authored correctly. You can find the tool in the [Visual Studio 2015 SDK](visual-studio-sdk.md). Documentation for this tool and others can be found [here](./internals/vssdk-utilities.md?view=vs-2015&preserve-view=true).

## Additional resources

### Samples
 Several of the Visual Studio samples on GitHub have been updated to show how to use the image service as part of various Visual Studio extensibility points.

 Check [`http://github.com/Microsoft/VSSDK-Extensibility-Samples`](https://github.com/Microsoft/VSSDK-Extensibility-Samples) for the latest samples.

### Tooling
 A set of support tools for the Image Service was created to aid in creating/updating UI that works with the Image Service. For more information about each tool, check the documentation that comes with the tools. The tools are included as part of the [Visual Studio 2015 SDK](visual-studio-sdk.md).

 **ManifestFromResources**

 The Manifest from Resources tool takes a list of image resources (PNG or XAML) and generates an image manifest file for using those images with the image service.

 **ManifestToCode**

 The Manifest to Code tool takes an image manifest file and generates a wrapper file for referencing the manifest values in code (C++, C#, or VB) or `.vsct` files.

 **ImageLibraryViewer**

 The Image Library Viewer tool can load image manifests and allows the user to manipulate them in the same way Visual Studio would to make sure the manifest is authored correctly. The user can alter background, sizes, DPI setting, High Contrast, and other settings. It also displays loading information to find errors in the manifests and displays source information for each image in the manifest.

## FAQ

- Are there any dependencies that you must include when loading \<Reference Include="Microsoft.VisualStudio.*.Interop.14.0.DesignTime" />?

  - Set EmbedInteropTypes="true" on all interop DLLs.

- How do I deploy an image manifest with my extension?

  - Add the `.imagemanifest` file to your project.

  - Set "Include in VSIX" to True.

- My images are still not working, how do I figure out what's wrong?

  - Visual Studio may not be finding your image manifest. For performance reasons Visual Studio limits folder search depth, so it's recommended that the image manifest be kept in the root folder of your extension.

  - You might be missing assembly information in your image manifest file. Assemblies that are strongly named require additional information in order to be loaded by Visual Studio. In order to load a strongly named assembly, you need to include (in addition to the assembly name) the assembly version and public key token in the resource URIs for the images in your image manifest.
    ```xml
    <ImageManifest xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/VisualStudio/ImageManifestSchema/2014">
      <Symbols>
        <String Name="Resources" Value="/Microsoft.VisualStudio.Shell.UI.Internal;v17.0.0.0;b03f5f7f11d50a3a;Component/Resources" />
        ...
      </Symbols>
      ...
    </ImageManifest>
    ```
  - You may be missing a codebase entry for your image assembly. If your assembly is not yet loaded by the time Visual Studio needs it, it will need to know where to find your assembly in order to load it. To add a codebase for your assembly, you can use the ProvideCodeBaseAttribute to ensure a codebase entry is generated and included in your extension's pkgdef.
    ```csharp
    [assembly: ProvideCodeBase(AssemblyName = "ClassLibrary1", Version = "1.0.0.0", CodeBase = "$PackageFolder$\\ClassLibrary1.dll")]
    ```
  - If the previous options do no resolve your image load issue, you can enable logging by dropping the following entries into a pkgdef in your extension:
    ```
    [$RootKey$\ImageLibrary]
    "TraceLevel"="Verbose"
    "TraceFilename"="ImageLibrary.log"
    ```
    This will create a log file called ImageLibrary.log in your %UserProfile% folder. Make sure to run "devenv /updateConfiguration" from a developer command prompt after adding these entries to a pkgdef. This ensures that the logging entries are enabled and that VS refreshes the image manifest cache to help find any errors that may occur when reading your image manifest. If you then run through the scenario where your image is expected to load, your log file will contain both the registration logging and request logging for your image.
    
- I am updating my CPS Project System. What happened to **ImageName** and **StockIconService**?

  - These were removed when CPS was updated to use monikers. You no longer need to call the **StockIconService**, just pass the desired **KnownMoniker** to the method or property using the **ToProjectSystemType()** extension method in the CPS utilities. You can find a mapping from **ImageName** to **KnownMonikers** below:

    |**ImageName**|**KnownMoniker**|
    |-|-|
    |ImageName.OfflineWebApp|KnownImageIds.Web|
    |ImageName.WebReferencesFolder|KnownImageIds.Web|
    |ImageName.OpenReferenceFolder|KnownImageIds.FolderOpened|
    |ImageName.ReferenceFolder|KnownImageIds.Reference|
    |ImageName.Reference|KnownImageIds.Reference|
    |ImageName.SdlWebReference|KnownImageIds.WebReferenceFolder|
    |ImageName.DiscoWebReference|KnownImageIds.DynamicDiscoveryDocument|
    |ImageName.Folder|KnownImageIds.FolderClosed|
    |ImageName.OpenFolder|KnownImageIds.FolderOpened|
    |ImageName.ExcludedFolder|KnownImageIds.HiddenFolderClosed|
    |ImageName.OpenExcludedFolder|KnownImageIds.HiddenFolderOpened|
    |ImageName.ExcludedFile|KnownImageIds.HiddenFile|
    |ImageName.DependentFile|KnownImageIds.GenerateFile|
    |ImageName.MissingFile|KnownImageIds.DocumentWarning|
    |ImageName.WindowsForm|KnownImageIds.WindowsForm|
    |ImageName.WindowsUserControl|KnownImageIds.UserControl|
    |ImageName.WindowsComponent|KnownImageIds.ComponentFile|
    |ImageName.XmlSchema|KnownImageIds.XMLSchema|
    |ImageName.XmlFile|KnownImageIds.XMLFile|
    |ImageName.WebForm|KnownImageIds.Web|
    |ImageName.WebService|KnownImageIds.WebService|
    |ImageName.WebUserControl|KnownImageIds.WebUserControl|
    |ImageName.WebCustomUserControl|KnownImageIds.WebCustomControl|
    |ImageName.AspPage|KnownImageIds.ASPFile|
    |ImageName.GlobalApplicationClass|KnownImageIds.SettingsFile|
    |ImageName.WebConfig|KnownImageIds.ConfigurationFile|
    |ImageName.HtmlPage|KnownImageIds.HTMLFile|
    |ImageName.StyleSheet|KnownImageIds.StyleSheet|
    |ImageName.ScriptFile|KnownImageIds.JSScript|
    |ImageName.TextFile|KnownImageIds.Document|
    |ImageName.SettingsFile|KnownImageIds.Settings|
    |ImageName.Resources|KnownImageIds.DocumentGroup|
    |ImageName.Bitmap|KnownImageIds.Image|
    |ImageName.Icon|KnownImageIds.IconFile|
    |ImageName.Image|KnownImageIds.Image|
    |ImageName.ImageMap|KnownImageIds.ImageMapFile|
    |ImageName.XWorld|KnownImageIds.XWorldFile|
    |ImageName.Audio|KnownImageIds.Sound|
    |ImageName.Video|KnownImageIds.Media|
    |ImageName.Cab|KnownImageIds.CABProject|
    |ImageName.Jar|KnownImageIds.JARFile|
    |ImageName.DataEnvironment|KnownImageIds.DataTable|
    |ImageName.PreviewFile|KnownImageIds.Report|
    |ImageName.DanglingReference|KnownImageIds.ReferenceWarning|
    |ImageName.XsltFile|KnownImageIds.XSLTransform|
    |ImageName.Cursor|KnownImageIds.CursorFile|
    |ImageName.AppDesignerFolder|KnownImageIds.Property|
    |ImageName.Data|KnownImageIds.Database|
    |ImageName.Application|KnownImageIds.Application|
    |ImageName.DataSet|KnownImageIds.DatabaseGroup|
    |ImageName.Pfx|KnownImageIds.Certificate|
    |ImageName.Snk|KnownImageIds.Rule|
    |ImageName.VisualBasicProject|KnownImageIds.VBProjectNode|
    |ImageName.CSharpProject|KnownImageIds.CSProjectNode|
    |ImageName.Empty|KnownImageIds.Blank|
    |ImageName.MissingFolder|KnownImageIds.FolderOffline|
    |ImageName.SharedImportReference|KnownImageIds.SharedProject|
    |ImageName.SharedProjectCs|KnownImageIds.CSSharedProject|
    |ImageName.SharedProjectVc|KnownImageIds.CPPSharedProject|
    |ImageName.SharedProjectJs|KnownImageIds.JSSharedProject|
    |ImageName.CSharpCodeFile|KnownImageIds.CSFileNode|
    |ImageName.VisualBasicCodeFile|KnownImageIds.VBFileNode|

 - I am updating my completion list provider. What **KnownMonikers** match to the old **StandardGlyphGroup** and **StandardGlyph** values?

    |Name|Name|Name|
    |-|-|-|
    |GlyphGroupClass|GlyphItemPublic|ClassPublic|
    |GlyphGroupClass|GlyphItemInternal|ClassInternal|
    |GlyphGroupClass|GlyphItemFriend|ClassInternal|
    |GlyphGroupClass|GlyphItemProtected|ClassProtected|
    |GlyphGroupClass|GlyphItemPrivate|ClassPrivate|
    |GlyphGroupClass|GlyphItemShortcut|ClassShortcut|
    |GlyphGroupConstant|GlyphItemPublic|ConstantPublic|
    |GlyphGroupConstant|GlyphItemInternal|ConstantInternal|
    |GlyphGroupConstant|GlyphItemFriend|ConstantInternal|
    |GlyphGroupConstant|GlyphItemProtected|ConstantProtected|
    |GlyphGroupConstant|GlyphItemPrivate|ConstantPrivate|
    |GlyphGroupConstant|GlyphItemShortcut|ConstantShortcut|
    |GlyphGroupDelegate|GlyphItemPublic|DelegatePublic|
    |GlyphGroupDelegate|GlyphItemInternal|DelegateInternal|
    |GlyphGroupDelegate|GlyphItemFriend|DelegateInternal|
    |GlyphGroupDelegate|GlyphItemProtected|DelegateProtected|
    |GlyphGroupDelegate|GlyphItemPrivate|DelegatePrivate|
    |GlyphGroupDelegate|GlyphItemShortcut|DelegateShortcut|
    |GlyphGroupEnum|GlyphItemPublic|EnumerationPublic|
    |GlyphGroupEnum|GlyphItemInternal|EnumerationInternal|
    |GlyphGroupEnum|GlyphItemFriend|EnumerationInternal|
    |GlyphGroupEnum|GlyphItemProtected|EnumerationProtected|
    |GlyphGroupEnum|GlyphItemPrivate|EnumerationPrivate|
    |GlyphGroupEnum|GlyphItemShortcut|EnumerationShortcut|
    |GlyphGroupEnumMember|GlyphItemPublic|EnumerationItemPublic|
    |GlyphGroupEnumMember|GlyphItemInternal|EnumerationItemInternal|
    |GlyphGroupEnumMember|GlyphItemFriend|EnumerationItemInternal|
    |GlyphGroupEnumMember|GlyphItemProtected|EnumerationItemProtected|
    |GlyphGroupEnumMember|GlyphItemPrivate|EnumerationItemPrivate|
    |GlyphGroupEnumMember|GlyphItemShortcut|EnumerationItemShortcut|
    |GlyphGroupEvent|GlyphItemPublic|EventPublic|
    |GlyphGroupEvent|GlyphItemInternal|EventInternal|
    |GlyphGroupEvent|GlyphItemFriend|EventInternal|
    |GlyphGroupEvent|GlyphItemProtected|EventProtected|
    |GlyphGroupEvent|GlyphItemPrivate|EventPrivate|
    |GlyphGroupEvent|GlyphItemShortcut|EventShortcut|
    |GlyphGroupException|GlyphItemPublic|ExceptionPublic|
    |GlyphGroupException|GlyphItemInternal|ExceptionInternal|
    |GlyphGroupException|GlyphItemFriend|ExceptionInternal|
    |GlyphGroupException|GlyphItemProtected|ExceptionProtected|
    |GlyphGroupException|GlyphItemPrivate|ExceptionPrivate|
    |GlyphGroupException|GlyphItemShortcut|ExceptionShortcut|
    |GlyphGroupField|GlyphItemPublic|FieldPublic|
    |GlyphGroupField|GlyphItemInternal|FieldInternal|
    |GlyphGroupField|GlyphItemFriend|FieldInternal|
    |GlyphGroupField|GlyphItemProtected|FieldProtected|
    |GlyphGroupField|GlyphItemPrivate|FieldPrivate|
    |GlyphGroupField|GlyphItemShortcut|FieldShortcut|
    |GlyphGroupInterface|GlyphItemPublic|InterfacePublic|
    |GlyphGroupInterface|GlyphItemInternal|InterfaceInternal|
    |GlyphGroupInterface|GlyphItemFriend|InterfaceInternal|
    |GlyphGroupInterface|GlyphItemProtected|InterfaceProtected|
    |GlyphGroupInterface|GlyphItemPrivate|InterfacePrivate|
    |GlyphGroupInterface|GlyphItemShortcut|InterfaceShortcut|
    |GlyphGroupMacro|GlyphItemPublic|MacroPublic|
    |GlyphGroupMacro|GlyphItemInternal|MacroInternal|
    |GlyphGroupMacro|GlyphItemFriend|MacroInternal|
    |GlyphGroupMacro|GlyphItemProtected|MacroProtected|
    |GlyphGroupMacro|GlyphItemPrivate|MacroPrivate|
    |GlyphGroupMacro|GlyphItemShortcut|MacroShortcut|
    |GlyphGroupMap|GlyphItemPublic|MapPublic|
    |GlyphGroupMap|GlyphItemInternal|MapInternal|
    |GlyphGroupMap|GlyphItemFriend|MapInternal|
    |GlyphGroupMap|GlyphItemProtected|MapProtected|
    |GlyphGroupMap|GlyphItemPrivate|MapPrivate|
    |GlyphGroupMap|GlyphItemShortcut|MapShortcut|
    |GlyphGroupMapItem|GlyphItemPublic|MapItemPublic|
    |GlyphGroupMapItem|GlyphItemInternal|MapItemInternal|
    |GlyphGroupMapItem|GlyphItemFriend|MapItemInternal|
    |GlyphGroupMapItem|GlyphItemProtected|MapItemProtected|
    |GlyphGroupMapItem|GlyphItemPrivate|MapItemPrivate|
    |GlyphGroupMapItem|GlyphItemShortcut|MapItemShortcut|
    |GlyphGroupMethod|GlyphItemPublic|MethodPublic|
    |GlyphGroupMethod|GlyphItemInternal|MethodInternal|
    |GlyphGroupMethod|GlyphItemFriend|MethodInternal|
    |GlyphGroupMethod|GlyphItemProtected|MethodProtected|
    |GlyphGroupMethod|GlyphItemPrivate|MethodPrivate|
    |GlyphGroupMethod|GlyphItemShortcut|MethodShortcut|
    |GlyphGroupOverload|GlyphItemPublic|MethodPublic|
    |GlyphGroupOverload|GlyphItemInternal|MethodInternal|
    |GlyphGroupOverload|GlyphItemFriend|MethodInternal|
    |GlyphGroupOverload|GlyphItemProtected|MethodProtected|
    |GlyphGroupOverload|GlyphItemPrivate|MethodPrivate|
    |GlyphGroupOverload|GlyphItemShortcut|MethodShortcut|
    |GlyphGroupModule|GlyphItemPublic|ModulePublic|
    |GlyphGroupModule|GlyphItemInternal|ModuleInternal|
    |GlyphGroupModule|GlyphItemFriend|ModuleInternal|
    |GlyphGroupModule|GlyphItemProtected|ModuleProtected|
    |GlyphGroupModule|GlyphItemPrivate|ModulePrivate|
    |GlyphGroupModule|GlyphItemShortcut|ModuleShortcut|
    |GlyphGroupNamespace|GlyphItemPublic|NamespacePublic|
    |GlyphGroupNamespace|GlyphItemInternal|NamespaceInternal|
    |GlyphGroupNamespace|GlyphItemFriend|NamespaceInternal|
    |GlyphGroupNamespace|GlyphItemProtected|NamespaceProtected|
    |GlyphGroupNamespace|GlyphItemPrivate|NamespacePrivate|
    |GlyphGroupNamespace|GlyphItemShortcut|NamespaceShortcut|
    |GlyphGroupOperator|GlyphItemPublic|OperatorPublic|
    |GlyphGroupOperator|GlyphItemInternal|OperatorInternal|
    |GlyphGroupOperator|GlyphItemFriend|OperatorInternal|
    |GlyphGroupOperator|GlyphItemProtected|OperatorProtected|
    |GlyphGroupOperator|GlyphItemPrivate|OperatorPrivate|
    |GlyphGroupOperator|GlyphItemShortcut|OperatorShortcut|
    |GlyphGroupProperty|GlyphItemPublic|PropertyPublic|
    |GlyphGroupProperty|GlyphItemInternal|PropertyInternal|
    |GlyphGroupProperty|GlyphItemFriend|PropertyInternal|
    |GlyphGroupProperty|GlyphItemProtected|PropertyProtected|
    |GlyphGroupProperty|GlyphItemPrivate|PropertyPrivate|
    |GlyphGroupProperty|GlyphItemShortcut|PropertyShortcut|
    |GlyphGroupStruct|GlyphItemPublic|StructurePublic|
    |GlyphGroupStruct|GlyphItemInternal|StructureInternal|
    |GlyphGroupStruct|GlyphItemFriend|StructureInternal|
    |GlyphGroupStruct|GlyphItemProtected|StructureProtected|
    |GlyphGroupStruct|GlyphItemPrivate|StructurePrivate|
    |GlyphGroupStruct|GlyphItemShortcut|StructureShortcut|
    |GlyphGroupTemplate|GlyphItemPublic|TemplatePublic|
    |GlyphGroupTemplate|GlyphItemInternal|TemplateInternal|
    |GlyphGroupTemplate|GlyphItemFriend|TemplateInternal|
    |GlyphGroupTemplate|GlyphItemProtected|TemplateProtected|
    |GlyphGroupTemplate|GlyphItemPrivate|TemplatePrivate|
    |GlyphGroupTemplate|GlyphItemShortcut|TemplateShortcut|
    |GlyphGroupTypedef|GlyphItemPublic|TypeDefinitionPublic|
    |GlyphGroupTypedef|GlyphItemInternal|TypeDefinitionInternal|
    |GlyphGroupTypedef|GlyphItemFriend|TypeDefinitionInternal|
    |GlyphGroupTypedef|GlyphItemProtected|TypeDefinitionProtected|
    |GlyphGroupTypedef|GlyphItemPrivate|TypeDefinitionPrivate|
    |GlyphGroupTypedef|GlyphItemShortcut|TypeDefinitionShortcut|
    |GlyphGroupType|GlyphItemPublic|TypePublic|
    |GlyphGroupType|GlyphItemInternal|TypeInternal|
    |GlyphGroupType|GlyphItemFriend|TypeInternal|
    |GlyphGroupType|GlyphItemProtected|TypeProtected|
    |GlyphGroupType|GlyphItemPrivate|TypePrivate|
    |GlyphGroupType|GlyphItemShortcut|TypeShortcut|
    |GlyphGroupUnion|GlyphItemPublic|UnionPublic|
    |GlyphGroupUnion|GlyphItemInternal|UnionInternal|
    |GlyphGroupUnion|GlyphItemFriend|UnionInternal|
    |GlyphGroupUnion|GlyphItemProtected|UnionProtected|
    |GlyphGroupUnion|GlyphItemPrivate|UnionPrivate|
    |GlyphGroupUnion|GlyphItemShortcut|UnionShortcut|
    |GlyphGroupVariable|GlyphItemPublic|FieldPublic|
    |GlyphGroupVariable|GlyphItemInternal|FieldInternal|
    |GlyphGroupVariable|GlyphItemFriend|FieldInternal|
    |GlyphGroupVariable|GlyphItemProtected|FieldProtected|
    |GlyphGroupVariable|GlyphItemPrivate|FieldPrivate|
    |GlyphGroupVariable|GlyphItemShortcut|FieldShortcut|
    |GlyphGroupValueType|GlyphItemPublic|ValueTypePublic|
    |GlyphGroupValueType|GlyphItemInternal|ValueTypeInternal|
    |GlyphGroupValueType|GlyphItemFriend|ValueTypeInternal|
    |GlyphGroupValueType|GlyphItemProtected|ValueTypeProtected|
    |GlyphGroupValueType|GlyphItemPrivate|ValueTypePrivate|
    |GlyphGroupValueType|GlyphItemShortcut|ValueTypeShortcut|
    |GlyphGroupIntrinsic|GlyphItemPublic|ObjectPublic|
    |GlyphGroupIntrinsic|GlyphItemInternal|ObjectInternal|
    |GlyphGroupIntrinsic|GlyphItemFriend|ObjectInternal|
    |GlyphGroupIntrinsic|GlyphItemProtected|ObjectProtected|
    |GlyphGroupIntrinsic|GlyphItemPrivate|ObjectPrivate|
    |GlyphGroupIntrinsic|GlyphItemShortcut|ObjectShortcut|
    |GlyphGroupJSharpMethod|GlyphItemPublic|MethodPublic|
    |GlyphGroupJSharpMethod|GlyphItemInternal|MethodInternal|
    |GlyphGroupJSharpMethod|GlyphItemFriend|MethodInternal|
    |GlyphGroupJSharpMethod|GlyphItemProtected|MethodProtected|
    |GlyphGroupJSharpMethod|GlyphItemPrivate|MethodPrivate|
    |GlyphGroupJSharpMethod|GlyphItemShortcut|MethodShortcut|
    |GlyphGroupJSharpField|GlyphItemPublic|FieldPublic|
    |GlyphGroupJSharpField|GlyphItemInternal|FieldInternal|
    |GlyphGroupJSharpField|GlyphItemFriend|FieldInternal|
    |GlyphGroupJSharpField|GlyphItemProtected|FieldProtected|
    |GlyphGroupJSharpField|GlyphItemPrivate|FieldPrivate|
    |GlyphGroupJSharpField|GlyphItemShortcut|FieldShortcut|
    |GlyphGroupJSharpClass|GlyphItemPublic|ClassPublic|
    |GlyphGroupJSharpClass|GlyphItemInternal|ClassInternal|
    |GlyphGroupJSharpClass|GlyphItemFriend|ClassInternal|
    |GlyphGroupJSharpClass|GlyphItemProtected|ClassProtected|
    |GlyphGroupJSharpClass|GlyphItemPrivate|ClassPrivate|
    |GlyphGroupJSharpClass|GlyphItemShortcut|ClassShortcut|
    |GlyphGroupJSharpNamespace|GlyphItemPublic|NamespacePublic|
    |GlyphGroupJSharpNamespace|GlyphItemInternal|NamespaceInternal|
    |GlyphGroupJSharpNamespace|GlyphItemFriend|NamespaceInternal|
    |GlyphGroupJSharpNamespace|GlyphItemProtected|NamespaceProtected|
    |GlyphGroupJSharpNamespace|GlyphItemPrivate|NamespacePrivate|
    |GlyphGroupJSharpNamespace|GlyphItemShortcut|NamespaceShortcut|
    |GlyphGroupJSharpInterface|GlyphItemPublic|InterfacePublic|
    |GlyphGroupJSharpInterface|GlyphItemInternal|InterfaceInternal|
    |GlyphGroupJSharpInterface|GlyphItemFriend|InterfaceInternal|
    |GlyphGroupJSharpInterface|GlyphItemProtected|InterfaceProtected|
    |GlyphGroupJSharpInterface|GlyphItemPrivate|InterfacePrivate|
    |GlyphGroupJSharpInterface|GlyphItemShortcut|InterfaceShortcut|
    |GlyphGroupError||StatusError|
    |GlyphBscFile||ClassFile|
    |GlyphAssembly||Reference|
    |GlyphLibrary||Library|
    |GlyphVBProject||VBProjectNode|
    |GlyphCoolProject||CSProjectNode|
    |GlyphCppProject||CPPProjectNode|
    |GlyphDialogId||Dialog|
    |GlyphOpenFolder||FolderOpened|
    |GlyphClosedFolder||FolderClosed|
    |GlyphArrow||GoToNext|
    |GlyphCSharpFile||CSFileNode|
    |GlyphCSharpExpansion||Snippet|
    |GlyphKeyword||IntellisenseKeyword|
    |GlyphInformation||StatusInformation|
    |GlyphReference||ClassMethodReference|
    |GlyphRecursion||Recursion|
    |GlyphXmlItem||Tag|
    |GlyphJSharpProject||DocumentCollection|
    |GlyphJSharpDocument||Document|
    |GlyphForwardType||GoToNext|
    |GlyphCallersGraph||CallTo|
    |GlyphCallGraph||CallFrom|
    |GlyphWarning||StatusWarning|
    |GlyphMaybeReference||QuestionMark|
    |GlyphMaybeCaller||CallTo|
    |GlyphMaybeCall||CallFrom|
    |GlyphExtensionMethod||ExtensionMethod|
    |GlyphExtensionMethodInternal||ExtensionMethod|
    |GlyphExtensionMethodFriend||ExtensionMethod|
    |GlyphExtensionMethodProtected||ExtensionMethod|
    |GlyphExtensionMethodPrivate||ExtensionMethod|
    |GlyphExtensionMethodShortcut||ExtensionMethod|
    |GlyphXmlAttribute||XmlAttribute|
    |GlyphXmlChild||XmlElement|
    |GlyphXmlDescendant||XmlDescendant|
    |GlyphXmlNamespace||XmlNamespace|
    |GlyphXmlAttributeQuestion||XmlAttributeLowConfidence|
    |GlyphXmlAttributeCheck||XmlAttributeHighConfidence|
    |GlyphXmlChildQuestion||XmlElementLowConfidence|
    |GlyphXmlChildCheck||XmlElementHighConfidence|
    |GlyphXmlDescendantQuestion||XmlDescendantLowConfidence|
    |GlyphXmlDescendantCheck||XmlDescendantHighConfidence|
    |GlyphCompletionWarning||IntellisenseWarning|
