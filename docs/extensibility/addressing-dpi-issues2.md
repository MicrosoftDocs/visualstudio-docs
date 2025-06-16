---
title: Addressing DPI Issues2
description: Learn about the issues involved in programming for high-resolution screens, such as scaling up content, layout issues, and using DPI-scaling APIs.
ms.date: 11/04/2016
ms.topic: conceptual
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Address DPI issues

An increasing number of devices are shipping with "high-resolution" screens. These screens typically have over 200 pixels per inch (ppi). Working with an application on these computers will require content to be scaled up to meet the needs of viewing the content at a normal viewing distance for the device. As of 2014, the primary target for high-density displays is mobile computing devices (tablets, clamshell laptops, and phones).

Windows 8.1 and higher contains several features to enable these machines to work with displays and environments where the machine is attached to both high-density and standard-density displays at the same time.

- Windows can allow you to scale content to the device using the "Make text and other items larger or smaller" setting (available since Windows XP).

- Windows 8.1 and higher will automatically scale content for most applications to be consistent when moved between displays of differing pixel densities. When the primary display is high density (200% scaling) and the secondary display is standard density (100%), Windows will automatically scale the application window contents down on the secondary display (1 pixel displayed for every 4 pixels rendered by the application).

- Windows will default to the right scaling for the pixel density and viewing distance for the display (Windows 7 and higher, OEM-configurable).

- Windows can automatically scale content up to 250% on new devices that exceed 280 ppi (as of Windows 8.1 S14).

  Windows has a way of dealing with scaling up UI to take advantage of increased pixel counts. An application opts in to this system by declaring itself "system DPI aware." Applications that do not do this are scaled up by the system. This can result in a "fuzzy" user experience where the entire application is uniformly pixel-stretched. For example:

  ![DPI Issues Fuzzy](../extensibility/media/dpi-issues-fuzzy.png "DPI Issues Fuzzy")

  Visual Studio opts in to being DPI scaling-aware, and therefore is not "virtualized."

  Windows (and Visual Studio) leverage several UI technologies, which have differing ways of dealing with scaling factors set by the system. For example:

- WPF measures controls in a device-independent way (units, not pixels). WPF UI automatically scales up for the current DPI.

- All text sizes regardless of UI framework are expressed in points, and so are treated by the system as DPI-independent. Text in Win32, WinForms, and WPF already scale up correctly when drawn to the display device.

- Win32/WinForms dialogs and windows have means for enabling layout that resizes with text (for example, through grid, flow, and table layout panels). These enable avoiding hard-coded pixel locations that are not scaled when the font sizes are increased.

- Icons provided by the system or resources based on system metrics (for example, SM_CXICON and SM_CXSMICON) are already scaled up.

## Older Win32 (GDI, GDI+) and WinForms-based UI
While WPF is already high DPI-aware, much of our Win32/GDI-based code was not originally written with DPI awareness in mind. Windows has provided DPI-scaling APIs. Fixes to Win32 issues should use these consistently across the product. Visual Studio has provided a helper class library to avoid duplicating functionality and ensuring consistency across the product.

## High-resolution images
This section is primarily for developers extending Visual Studio 2013. For Visual Studio 2015, use image service which is built into Visual Studio. You may also find that you need to support/target many versions of Visual Studio and therefore using the image service in 2015 is not an option since it does not exist in previous versions. This section is also for you then.

## Scaling up images that are too small
Images that are too small can be scaled up and rendered on GDI and WPF using some common methods. Managed DPI helper classes are available to internal and external Visual Studio integrators to address scaling icons, bitmaps, imagestrips, and imagelists. Win32-based native C/C++helpers are available for scaling HICON, HBITMAP, HIMAGELIST, and VsUI::GdiplusImage. Scaling of a bitmap typically only requires a one-line change after including a reference to the helper library. For example:

### [C#](#tab/csharp)
```csharp
(WinForms) DpiHelper.LogicalToDeviceUnits(ref image);
```

### [C++](#tab/cpp)
```cpp
(Unmanaged) VsUI::DpiHelper::LogicalToDeviceUnits(&hBitmap);
```
---

Scaling an imagelist depends on whether the imagelist is complete at load time, or is appended at run time. If complete at load time, call `LogicalToDeviceUnits()` with the imagelist as you would a bitmap. When the code needs to load an individual bitmap before composing the imagelist, make sure to scale the image size of the imagelist:

```csharp
imagelist.ImageSize = DpiHelper.LogicalToDeviceUnits(imagelist.ImageSize);
```

In native code, the dimensions can be scaled when creating the imagelist as follows:

```cpp
ImageList_Create(VsUI::DpiHelper::LogicalToDeviceUnitsX(16),VsUI::DpiHelper::LogicalToDeviceUnitsY(16), ILC_COLOR32|ILC_MASK, nCount, 1);
```

Functions in the library allow specifying the resizing algorithm. When scaling images to be placed in imagelists, make sure to specify the background color that is used for transparency, or use NearestNeighbor scaling (which will cause distortions at 125% and 150%).

Consult the <xref:Microsoft.VisualStudio.PlatformUI.DpiHelper> documentation on MSDN.

The following table shows examples of how images should be scaled at corresponding DPI scaling factors. The images outlined in orange denote our best practice as of Visual Studio 2013 (100%-200% DPI scaling):

![DPI Issues Scaling](../extensibility/media/dpi-issues-scaling.png "DPI Issues Scaling")

## Layout issues
Common layout issues can be avoided primarily by keeping points in the UI scaled and relative to one another rather than by using absolute locations (specifically, in pixel units). For example:

- Layout/text positions need to adjust to account for scaled-up images.

- Columns in grids need to have widths adjusted for the scaled-up text.

- Hard-coded sizes or space between elements will also need to be scaled up. Sizes that are based only on text dimensions are typically fine, because fonts are automatically scaled up.

  Helper functions are available in the <xref:Microsoft.VisualStudio.PlatformUI.DpiHelper> class to allow scaling on the X and Y axis:

- LogicalToDeviceUnitsX/LogicalToDeviceUnitsY (functions allow scaling on X/Y axis)

- int space = DpiHelper.LogicalToDeviceUnitsX (10);

- int height = VsUI::DpiHelper::LogicalToDeviceUnitsY(5);

  There are LogicalToDeviceUnits overloads to allow scaling objects such as Rect, Point, and Size.

## Using the DPIHelper library/class to scale images and layout
The Visual Studio DPI helper library is available in native and managed forms and can be used outside of the Visual Studio shell by other applications.

To use the library, go to the [Visual Studio VSSDK extensibility samples](https://github.com/Microsoft/VSSDK-Extensibility-Samples) and clone the High-DPI_Images_Icons sample.

In source files, include *VsUIDpiHelper.h* and call the static functions of `VsUI::DpiHelper` class:

```cpp
#include "VsUIDpiHelper.h"

int cxScaled = VsUI::DpiHelper::LogicalToDeviceUnitsX(cx);
VsUI::DpiHelper::LogicalToDeviceUnits(&hBitmap);

```

> [!NOTE]
> Do not use the helper functions in module-level or class-level static variables. The library also uses statics for thread synchronization and you might run into order-initialization problems. Either convert those statics to nonstatic member-variables, or wrap them into a function (so they get constructed on first access).

To access the DPI helper functions from managed code that will run inside the Visual Studio environment:

- The consuming project must reference the latest version of Shell MPF. For example:

    ```csharp
    <Reference Include="Microsoft.VisualStudio.Shell.14.0.dll" />
    ```

- Ensure the project has references to **System.Windows.Forms**, **PresentationCore**, and **PresentationUI**.

- In code, use the **Microsoft.VisualStudio.PlatformUI** namespace and call static functions of DpiHelper class. For supported types (points, sizes, rectangles, and so on), there are provided extension functions that return new scaled objects. For example:

    ```csharp
    using Microsoft.VisualStudio.PlatformUI;
    double x = DpiHelper.LogicalToDeviceUnitsX(posX);
    Point ptScaled = ptOriginal.LogicalToDeviceUnits();
    DpiHelper.LogicalToDeviceUnits(ref bitmap);

    ```

## Dealing with WPF image fuzziness in zoomable UI
In WPF, bitmaps are resized automatically by WPF for the current DPI zoom level using a high-quality bicubic algorithm (default), which works well for pictures or large screenshots, but is inappropriate for menu item icons because it introduces perceived fuzziness.

Recommendations:

- For logo image and banners artwork, the default <xref:System.Windows.Media.BitmapScalingMode> resizing mode could be used.

- For menu items and iconography images, the <xref:System.Windows.Media.BitmapScalingMode> should be used when it doesn't cause other distortion artifacts to eliminate fuzziness (at 200% and 300%).

- For large zoom levels not multiples of 100% (for example, 250% or 350%), scaling iconography images with bicubic results in fuzzy, washed-out UI. A better result is obtained by first scaling the image with NearestNeighbor to the largest multiple of 100% (for example, 200% or 300%) and scaling with bicubic from there. See Special case: prescaling WPF images for large DPI levels for more information.

  The DpiHelper class in the Microsoft.VisualStudio.PlatformUI namespace provides a member <xref:System.Windows.Media.BitmapScalingMode> that can be used for binding. It will allow the Visual Studio shell to control the bitmap scaling mode across the product uniformly, depending on the DPI scaling factor.

  To use it in XAML, add:

```xaml
xmlns:vsui="clr-namespace:Microsoft.VisualStudio.PlatformUI;assembly=Microsoft.VisualStudio.Shell.14.0"

<Setter Property="RenderOptions.BitmapScalingMode" Value="{x:Static vs:DpiHelper.BitmapScalingMode}" />

```

The Visual Studio shell already sets this property on top-level windows and dialogs. WPF-based UI running in Visual Studio will already inherit it. If the setting does not propagate to your particular pieces of UI, it can be set on the root element of the XAML/WPF UI. Places where this happens include pop-ups, on elements with Win32 parents, and designer windows that run out of process, such as Blend.

Some UI can scale independently of the system-set DPI zoom level, such as the Visual Studio text editor and WPF-based designers (WPF Desktop and Windows Store). In these cases, DpiHelper.BitmapScalingMode should not be used. To fix this issue in the editor, the IDE team created a custom property titled RenderOptions.BitmapScalingMode. Set that property value to HighQuality or NearestNeighbor depending on the combined zoom level of the system and your UI.

## Special case: prescaling WPF images for large DPI levels
For very large zoom levels that are not multiples of 100% (for example, 250%, 350%, and so on), scaling iconography images with bicubic results in fuzzy, washed-out UI. The impression of these images alongside crisp text is almost like that of an optical illusion. The images appear to be closer to the eye and out of focus in relation to the text. The scaling result at this magnified size can be improved by first scaling the image with NearestNeighbor to the largest multiple of 100% (for example, 200% or 300%) and scaling with bicubic to the remainder (an additional 50%).

The following is an example of the differences in results, where the first image is scaled with the improved double-scaling algorithm 100%->200%->250%, and the second one just with bicubic 100%->250%.

![DPI Issues Double Scaling Example](../extensibility/media/dpi-issues-double-scaling-example.png "DPI Issues Double Scaling Example")

In order to enable UI to use this double-scaling, XAML markup for displaying each Image element will need to be modified. The following examples demonstrate how to use double-scaling in WPF in Visual Studio using the DpiHelper library and Shell.12/14.

Step 1: Prescale the image to 200%, 300%, and so on using NearestNeighbor.

Prescale the image using either a converter applied on a binding, or with a XAML markup extension. For example:

```xaml
<vsui:DpiPrescaleImageSourceConverter x:Key="DpiPrescaleImageSourceConverter" />

<Image Source="{Binding Path=SelectedImage, Converter={StaticResource DpiPrescaleImageSourceConverter}}" Width="16" Height="16" />

<Image Source="{vsui:DpiPrescaledImage Images/Help.png}" Width="16" Height="16" />

```

If the image also needs to be themed (most, if not all, should), the markup can use a different converter that first does theming of the image and then pre-scaling. The markup can use either <xref:Microsoft.VisualStudio.PlatformUI.DpiPrescaleThemedImageConverter> or <xref:Microsoft.VisualStudio.PlatformUI.DpiPrescaleThemedImageSourceConverter>, depending on the desired conversion output.

```xaml
<vsui:DpiPrescaleThemedImageSourceConverter x:Key="DpiPrescaleThemedImageSourceConverter" />

<Image Width="16" Height="16">
  <Image.Source>
    <MultiBinding Converter="{StaticResource DpiPrescaleThemedImageSourceConverter}">
      <Binding Path="Icon" />
      <Binding Path="(vsui:ImageThemingUtilities.ImageBackgroundColor)"
               RelativeSource="{RelativeSource Self}" />
      <Binding Source="{x:Static vsui:Boxes.BooleanTrue}" />
    </MultiBinding>
  </Image.Source>
</Image>
```

Step 2: Ensure the final size is correct for the current DPI.

Because WPF will scale the UI for the current DPI using the BitmapScalingMode property set on the UIElement, an Image control using a prescaled image as its source will look two or three times larger than it should. The following are a couple ways to counter this effect:

- If you know the dimension of the original image at 100%, you can specify the exact size of the Image control. These sizes will reflect the size of the UI before scaling is applied.

    ```xaml
    <Image Source="{Binding Path=SelectedImage, Converter={StaticResource DpiPrescaleImageSourceConverter}}" Width="16" Height="16" />
    ```

- If the size of the original image is not known, a LayoutTransform can be used to scale down the final Image object. For example:

    ```xaml
    <Image Source="{Binding Path=SelectedImage, Converter={StaticResource DpiPrescaleImageSourceConverter}}" >
        <Image.LayoutTransform>
            <ScaleTransform
                ScaleX="{x:Static vsui:DpiHelper.PreScaledImageLayoutTransformScale}"
                ScaleY="{x:Static vsui:DpiHelper.PreScaledImageLayoutTransformScale}" />
        </Image.LayoutTransform>
    </Image>
    ```

## Enabling HDPI support to the WebOC
By default, WebOC controls (such as the WebBrowser control in WPF, or the IWebBrowser2 interface) don't enable HDPI detection and support. The result will be an embedded control with display content that is too small on a high-resolution display. The following describes how to enable high-DPI support in a specific web WebOC instance.

Implement the IDocHostUIHandler interface (see the MSDN article on the [IDocHostUIHandler](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa753260(v=vs.85)):

```idl
[ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
 Guid("BD3F23C0-D43E-11CF-893B-00AA00BDCE1A")]
public interface IDocHostUIHandler
{
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int ShowContextMenu(
        [In, MarshalAs(UnmanagedType.U4)] int dwID,
        [In] POINT pt,
        [In, MarshalAs(UnmanagedType.Interface)] object pcmdtReserved,
        [In, MarshalAs(UnmanagedType.IDispatch)] object pdispReserved);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int GetHostInfo([In, Out] DOCHOSTUIINFO info);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int ShowUI(
        [In, MarshalAs(UnmanagedType.I4)] int dwID,
        [In, MarshalAs(UnmanagedType.Interface)] object activeObject,
        [In, MarshalAs(UnmanagedType.Interface)] object commandTarget,
        [In, MarshalAs(UnmanagedType.Interface)] object frame,
        [In, MarshalAs(UnmanagedType.Interface)] object doc);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int HideUI();
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int UpdateUI();
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int EnableModeless([In, MarshalAs(UnmanagedType.Bool)] bool fEnable);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int OnDocWindowActivate([In, MarshalAs(UnmanagedType.Bool)] bool fActivate);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int OnFrameWindowActivate([In, MarshalAs(UnmanagedType.Bool)] bool fActivate);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int ResizeBorder(
        [In] COMRECT rect,
        [In, MarshalAs(UnmanagedType.Interface)] object doc,
        bool fFrameWindow);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int TranslateAccelerator(
        [In] ref MSG msg,
        [In] ref Guid group,
        [In, MarshalAs(UnmanagedType.I4)] int nCmdID);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int GetOptionKeyPath(
        [Out, MarshalAs(UnmanagedType.LPArray)] string[] pbstrKey,
        [In, MarshalAs(UnmanagedType.U4)] int dw);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int GetDropTarget(
        [In, MarshalAs(UnmanagedType.Interface)] IOleDropTarget pDropTarget,
        [MarshalAs(UnmanagedType.Interface)] out IOleDropTarget ppDropTarget);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int GetExternal([MarshalAs(UnmanagedType.IDispatch)] out object ppDispatch);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int TranslateUrl(
        [In, MarshalAs(UnmanagedType.U4)] int dwTranslate,
        [In, MarshalAs(UnmanagedType.LPWStr)] string strURLIn,
        [MarshalAs(UnmanagedType.LPWStr)] out string pstrURLOut);
    [return: MarshalAs(UnmanagedType.I4)]
    [PreserveSig]
    int FilterDataObject(
        IDataObject pDO,
        out IDataObject ppDORet);
    }
```

Optionally, implement the ICustomDoc interface (see the MSDN article on the [ICustomDoc](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa753272(v=vs.85)):

```idl
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
 Guid("3050F3F0-98B5-11CF-BB82-00AA00BDCE0B")]
public interface ICustomDoc
{
    void SetUIHandler(IDocHostUIHandler pUIHandler);
}
```

Associate the class that implements IDocHostUIHandler with the WebOC's document. If you implemented the ICustomDoc interface above, then as soon as the WebOC's document property is valid, cast it to an ICustomDoc and call the SetUIHandler method, passing the class that implements IDocHostUIHandler.

```csharp
// "this" references that class that owns the WebOC control and in this case also implements the IDocHostUIHandler interface
ICustomDoc customDoc = (ICustomDoc)webBrowser.Document;
customDoc.SetUIHandler(this);

```

If you did NOT implement the ICustomDoc interface, then as soon as the WebOC's document property is valid, you'll need to cast it to an IOleObject, and call the `SetClientSite` method, passing in the class that implements IDocHostUIHandler. Set the DOCHOSTUIFLAG_DPI_AWARE flag on the DOCHOSTUIINFO passed to the `GetHostInfo` method call:

```csharp
public int GetHostInfo(DOCHOSTUIINFO info)
{
    // This is what the default site provides.
    info.dwFlags = (DOCHOSTUIFLAG)0x5a74012;
    // Add the DPI flag to the defaults
    info.dwFlags |=.DOCHOSTUIFLAG.DOCHOSTUIFLAG_DPI_AWARE;
    return S_OK;
}
```

This should be all that you need to get your WebOC control to support HPDI.

## Tips

1. If the document property on the WebOC control changes, you might need to reassociate the document with the IDocHostUIHandler class.

2. If the above does not work, there is a known issue with the WebOC not picking up the change to the DPI flag. The most reliable way of fixing this is to toggle the optical zoom of the WebOC, meaning two calls with two different values for the zoom percentage. Additionally, if this workaround is required, it might be necessary to perform it on every navigate call.

    ```csharp
    // browser2 is a SHDocVw.IWebBrowser2 in this case
    // EX: Call the Exec twice with DPI%-1 and then DPI% as the zoomPercent values
    IOleCommandTarget cmdTarget = browser2.Document as IOleCommandTarget;
    if (cmdTarget != null)
    {
        object commandInput = zoomPercent;
        cmdTarget.Exec(IntPtr.Zero,
                       OLECMDID_OPTICAL_ZOOM,
                       OLECMDEXECOPT_DONTPROMPTUSER,
                       ref commandInput,
                       ref commandOutput);
    }
    ```
