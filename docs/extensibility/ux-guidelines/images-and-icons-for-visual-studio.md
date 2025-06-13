---
title: Images and Icons for Visual Studio
description: Learn about the design concepts used to create the images and icons for Visual Studio. 
ms.date: 04/26/2017
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Images and Icons for Visual Studio

## <a name="BKMK_ImageUseInVisualStudio"></a> Image use in Visual Studio
 Before creating artwork, consider making use of the 1,000+ images in the [Visual Studio Image Library](https://www.microsoft.com/download/details.aspx?id=35825).

### Types of images

- **Icons**. Small images that appear in commands, hierarchies, templates, and so on. The default icon size used in Visual Studio is a 16x16 PNG. Icons produced by the image service automatically generate the XAML format for HDPI support.

    > [!NOTE]
    > While images are used in the menu system, you should not create an icon for every command. Consult [Menus and Commands for Visual Studio](../../extensibility/ux-guidelines/menus-and-commands-for-visual-studio.md) to see whether your command should get an icon.

- **Thumbnails.** Images used in the preview area of a dialog, such as the New Project dialog.

- **Dialog images.** Images that appear in dialogs or wizards, either as descriptive graphics or message indicators. Use infrequently and only when necessary to illustrate a difficult concept or gain the user's attention (alert, warning).

- **Animated images.** Used in progress indicators, status bars, and operation dialogs.

- **Cursors.** Used to indicate whether an operation is allowed using the mouse, where an object may be dropped, and so on.

## <a name="BKMK_IconDesign"></a> Icon design

 Visual Studio uses modern-style icons, which have clean geometry and a 50/50 balance of positive/negative (light/dark), and use direct, understandable metaphors. Crucial icon design points center around clarity, simplification, and context.

- **Clarity:** focus on the core metaphor that gives an icon its meaning and individuality.

- **Simplification:** reduce the icon to its core meaning - get the theme across with just the necessary element(s) and no frills.

- **Context:** consider all aspects of an icon's role during concept development, which is crucial when deciding which elements constitute the icon's core metaphor.

  With icons, there are a number of design points to avoid:

- Don't use icons that signify UI elements except when appropriate. Choose a more abstract or symbolic approach when the UI element is neither common, evident, nor unique.

- Don't overuse common elements like documents, folders, arrows, and the magnifying glass. Use such elements only when essential to the icon's meaning. For example, the right-facing magnifying glass should indicate only Search, Browse, and Find.

- Although some legacy icon elements maintain the use of perspective, don't create new icons with perspective unless the element lacks clarity without it.

- Don't cram too much information into an icon. A simple image that can be easily recognized or learned as a recognizable symbol is much more useful than an overly complex image. An icon cannot tell the whole story.

### Icon creation

#### Concept development
 Visual Studio has within its UI a wide variety of icon types. Carefully consider the icon type during development. Don't use unclear or uncommon UI objects for your icon elements. Opt for the symbolic in these cases, such as with the Smart Tag icon. Note that the meaning of the abstract tag on the left is more obvious than the vague, UI-based version on the right:

|**Correct use of symbolic imagery**|**Incorrect use of symbolic imagery**|
|-|-|
|![Correct Smart Tag icon](../../extensibility/ux-guidelines/media/0404-01_smarttagcorrect.png "0404-01_SmartTagCorrect")|![Incorrect Smart Tag icon](../../extensibility/ux-guidelines/media/0404-02_smarttagincorrect.png "0404-02_SmartTagIncorrect")|

 There are instances in which standard, easily recognizable UI elements do work well for icons. Add Window is one such example:

|**Correct UI element in an icon**|**Incorrect UI element in an icon**|
|-|-|
|![Correct Add Window icon](../../extensibility/ux-guidelines/media/0404-03_addwindowcorrect.png "0404-03_AddWindowCorrect")|![Incorrect Add Window icon](../../extensibility/ux-guidelines/media/0404-04_addwindowincorrect.png "0404-04_AddWindowIncorrect")|

 Don't use a document as a base element unless it is essential to the icon's meaning. Without the document element on Add Document (below) the meaning is lost, whereas with Refresh the document element is unnecessary to communicate the meaning.

|**Correct use of document icon**|**Incorrect use of document icon**|
|-|-|
|![Correct Document icon](../../extensibility/ux-guidelines/media/0404-05_documenticoncorrect.png "0404-05_DocumentIconCorrect")|![Incorrect Document icon](../../extensibility/ux-guidelines/media/0404-06_documenticonincorrect.png "0404-06_DocumentIconIncorrect")|

 The concept of "show" should be represented by the icon which best illustrates what is being shown, such as with the Show All Files example. A lens metaphor may be used to indicate the concept of "view" if necessary, such as with the Resource View example.

|**"Show"**|**"View"**|
|-|-|
|![Show icon](../../extensibility/ux-guidelines/media/0404-07_show.png "0404-07_Show")|![View icon](../../extensibility/ux-guidelines/media/0404-08_view.png "0404-08_View")|

 The right-facing magnifying glass icon should represent only Search, Find, and Browse. The left-facing variant with the plus sign or minus sign should represent only zoom in/zoom out.

|**"Search"**|**"Zoom"**|
|-|-|
|![Search icon](../../extensibility/ux-guidelines/media/0404-09_search.png "0404-09_Search")|![Zoom icon](../../extensibility/ux-guidelines/media/0404-10_zoom.png "0404-10_Zoom")|

 In tree views, do not use both the folder icon and a modifier. When available, use only the modifier.

|**Correct tree view icons**|**Incorrect tree view icons**|
|-|-|
|![Correct tree view icon &#40;1&#41;](../../extensibility/ux-guidelines/media/0404-11_treeviewcorrect1.png "0404-11_TreeViewCorrect1") ![Correct tree view icon &#40;2&#41;](../../extensibility/ux-guidelines/media/0404-12_treeviewcorrect2.png "0404-12_TreeViewCorrect2")|![Incorrect tree view icon &#40;1&#41;](../../extensibility/ux-guidelines/media/0404-13_treeviewincorrect1.png "0404-13_TreeViewIncorrect1") ![Incorrect tree view icon &#40;2&#41;](../../extensibility/ux-guidelines/media/0404-14_treeviewincorrect2.png "0404-14_TreeViewIncorrect2")|

### Style details

#### Layout
 Stack elements as shown for standard 16x16 icons:

 ![Layout stack for 16x16 icons](../../extensibility/ux-guidelines/media/0404-15_layoutstack.png "0404-15_LayoutStack")<br />Layout stack for 16x16 icons

 Status notification elements are better used as standalone icons. There are contexts, however, in which a notification should be stacked on the base element, such as with the Task Complete icon:

 ![Standalone notifications in Visual Studio](../../extensibility/ux-guidelines/media/0404-16_standalonenotificationicons.png "0404-16_StandaloneNotificationIcons")<br />Standalone notification icons

 ![Task complete icon](../../extensibility/ux-guidelines/media/0404-17_taskcomplete.png "0404-17_TaskComplete")<br />Task Complete icon

 Project icons are typically .ico files that contain multiple sizes. Most 16x16 icons contain the same elements. The 32x32 versions have more details, including the project type when applicable.

 ![Project icons in Visual Studio](../../extensibility/ux-guidelines/media/0404-18_iconprojectthreesizes.png "0404-18_IconProjectThreeSizes")<br />VB Windows Control Library Project icons, 16x16 and 32x32

 Center an icon within its pixel frame. If that is not possible, align the icon to the top and/or right of the frame.

 ![Icon centered within the pixel frame](../../extensibility/ux-guidelines/media/0404-19_iconcentered.png "0404-19_IconCentered")<br />Icon centered within the pixel frame

 ![Icon aligned to top right of pixel frame](../../extensibility/ux-guidelines/media/0404-20_icontopright.png "0404-20_IconTopRight")<br />Icon aligned to the top right of the frame

 ![Icon centered and aligned to top of pixel frame](../../extensibility/ux-guidelines/media/0404-21_icontopalign.png "0404-21_IconTopAlign")<br />Icon centered and aligned to the top of the frame

 To achieve ideal alignment and balance, avoid obstructing the icon's base element with action glyphs. Place the glyph near the top left of the base element. When adding an additional element, consider the alignment and balance of the icon.

|**Correct alignment and balance**|**Incorrect alignment and balance**|
|-|-|
|![Correct icon balance and alignment](../../extensibility/ux-guidelines/media/0404-22_alignbalancecorrect.png "0404-22_AlignBalanceCorrect")|![Incorrect icon balance and alignment](../../extensibility/ux-guidelines/media/0404-23_alignbalanceincorrect.png "0404-23_AlignBalanceIncorrect")|

 Ensure size parity for icons that share elements and are used in sets. Note that in the incorrect pairing, the circle and arrow are oversized and don't match.

|**Correct size parity**|**Incorrect size parity**|
|-|-|
|![Correct icon size and parity](../../extensibility/ux-guidelines/media/0404-24_sizeparitycorrect.png "0404-24_SizeParityCorrect")|![Incorrect icon size and parity](../../extensibility/ux-guidelines/media/0404-25_sizeparityincorrect.png "0404-25_SizeParityIncorrect")|

 Use consistent line and visual weights. Evaluate how the icon you are building compares to other icons by using a side-by-side comparison. Never use the entire 16x16 frame, use 15x15 or smaller. The negative-to-positive (dark-to-light) ratio should be 50/50.

|**Correct negative-to-positive ratio**|**Incorrect negative-to-positive ratio**|
|-|-|
|![Correct visual weight for icons &#40;1&#41;](../../extensibility/ux-guidelines/media/0404-26_visualweightcorrect1.png "0404-26_VisualWeightCorrect1")<br /><br /> ![Correct visual weight for icons &#40;2&#41;](../../extensibility/ux-guidelines/media/0404-27_visualweightcorrect2.png "0404-27_VisualWeightCorrect2")<br /><br /> ![Correct visual weight for icons &#40;3&#41;](../../extensibility/ux-guidelines/media/0404-28_visualweightcorrect3.png "0404-28_VisualWeightCorrect3")|![Incorrect visual weight for icons](../../extensibility/ux-guidelines/media/0404-29_visualweightincorrect.png "0404-29_VisualWeightIncorrect")|

 Use simple, comparable shapes and complementary angles to build your elements without sacrificing element integrity. Use 45° or 90° angles where possible.

 ![Correct icon angles](../../extensibility/ux-guidelines/media/0404-30_iconanglescorrect.png "0404-30_IconAnglesCorrect")

#### Perspective
 Keep the icon clear and understandable. Use perspective and a light source only when necessary. Although using perspective on icon elements should be avoided, some elements are unrecognizable without it. In such cases, a stylized perspective communicates the element's clarity.

 ![3-point perspective](../../extensibility/ux-guidelines/media/0404-31_3pointperspective.png "0404-31_3PointPerspective")<br />3-point perspective

 ![1-point perspective](../../extensibility/ux-guidelines/media/0404-32_1pointperspective.png "0404-32_1PointPerspective")<br />1-point perspective

 Most elements should be facing or angled to the right:

 ![Icons angled right](../../extensibility/ux-guidelines/media/0404-33_angledright.png "0404-33_AngledRight")

 Use light sources only when adding necessary clarity to an object.

|**Correct light source**|**Incorrect light source**|
|-|-|
|![Correct light sources for icons](../../extensibility/ux-guidelines/media/0404-34_lightsourcescorrect.png "0404-34_LightSourcesCorrect")|![Incorrect light sources for icons](../../extensibility/ux-guidelines/media/0404-35_lightsourcesincorrect.png "0404-35_LightSourcesIncorrect")|

 Use outlines only to enhance legibility or to better communicate the metaphor. The negative-positive (dark-light) balance should be 50/50.

|**Correct use of outlines**|**Incorrect use of outlines**|
|-|-|
|![Correct outlines](../../extensibility/ux-guidelines/media/0404-36_outlinescorrect.png "0404-36_OutlinesCorrect")|![Incorrect outlines](../../extensibility/ux-guidelines/media/0404-37_outlinesincorrect.png "0404-37_OutlinesIncorrect")|

#### Icon types
 **Shell and command bar** icons consist of no more than three of the following elements: one base, one modifier, one action, or one status.

 ![Examples of shell and command bar icons](../../extensibility/ux-guidelines/media/0404-38_shellicons.png "0404-38_ShellIcons")<br />Examples of shell and command bar icons

 **Tool window command bar** icons consist of no more than three of the following elements: one base, one modifier, one action, or one status.

 ![Examples of tool window command bar icons](../../extensibility/ux-guidelines/media/0404-39_toolwindowcommandbaricons.png "0404-39_ToolWindowCommandBarIcons")<br />Examples of tool window command bar icons

 **Tree view disambiguator** icons consist of no more than three of the following elements: one base, one modifier, one action, or one status.

 ![Examples of tree view disambiguator icons](../../extensibility/ux-guidelines/media/0404-40_treeviewicons.png "0404-40_TreeViewIcons")<br />Examples of tree view disambiguator icons

 **State-based value taxonomy** icons exist in the following states: active, active disabled, and inactive disabled.

 ![Examples of state-based value taxonomy icons](../../extensibility/ux-guidelines/media/0404-41_statebasedtaxonomy.png "0404-41_StateBasedTaxonomy")<br />Examples of state-based value taxonomy icons

 **IntelliSense** icons consist of no more than three of the following elements: one base, one modifier, and one status.

 ![Examples of IntelliSense icons](../../extensibility/ux-guidelines/media/0404-42_intellisenseicons.png "0404-42_IntelliSenseIcons")<br />Examples of IntelliSense icons

 **Small (16x16) project** icons should have no more than two elements: one base and one modifier.

 ![Examples of small (16x16) project icons](../../extensibility/ux-guidelines/media/0404-43_16x16project1.png "0404-43_16x16Project1") ![16x16 project icon &#40;2&#41;](../../extensibility/ux-guidelines/media/0404-44_16x16project2.png "0404-44_16x16Project2") ![16x16 project icon &#40;3&#41;](../../extensibility/ux-guidelines/media/0404-45_16x16project3.png "0404-45_16x16Project3")<br />Examples of small (16x16) project icons

 **Large (32x32) project** icons consist of no more than four of the following elements: one base, one to two modifiers, and one language overlay.

 ![Examples of large (32x32) project icons](../../extensibility/ux-guidelines/media/0404-46_32x32project.png "0404-46_32x32Project")<br />Examples of large (32x32) project icons

### Production details
 All new UI elements should be created using Windows Presentation Foundation (WPF) and all new icons for WPF should be in 32-bit PNG format. The 24-bit PNG is a legacy format that does not support transparency and is therefore not recommended for icons.

 Save the resolution at 96 DPI.

#### File types

- **32-bit PNG:** the preferred format for icons. A lossless data compression file format that can store a single raster (pixel) image. 32-bit PNG files support alpha-channel transparency, gamma correction, and interlacing.

- **32-bit BMP:** for non-WPF controls. Also called XP or high color, 32-bit BMP is an RGB/A image format, a true-color image with an alpha-channel transparency. The alpha channel is a layer of transparency designated in Adobe Photoshop that is then saved within the bitmap as an additional (fourth) color channel. A black background is added during artwork production to all 32-bit BMP files to provide a quick visual cue about the color depth. This black background represents the area to be masked out in the UI.

- **32-bit ICO:** for Project icons and Add Item. All ICO files are 32-bit true color with alpha-channel transparency (RGB/A). Because ICO files can store multiple sizes and color depths, Vista icons are often in an ICO format containing 16x16, 32x32, 48x48, and 256x256 image sizes. In order to display properly in Windows Explorer, ICO files must be saved-down to 24-bit and 8-bit color depths for each image size.

- **XAML:** for design surfaces and Windows adorners. XAML icons are vector-based image files that support scaling, rotating, filing, and transparency. They are not common in Visual Studio today but are becoming more popular because of their flexibility.

- **SVG**

- **24-bit BMP:** for the Visual Studio command bar. A true-color RGB image format, 24-bit BMP is an icon convention that creates a layer of transparency by using magenta (R=255, G=0, B=255) as a color key for a knock-out transparency layer. In a 24-bit BMP, all magenta surfaces are displayed using the background color.

- **24-bit GIF:** for the Visual Studio command bar. A true-color RGB image format that supports transparency. GIF files are often used in Wizard artwork and GIF animations.

### Icon construction
 The smallest icon size in Visual Studio is 16x16. The largest in common use is 32x32. Keep in mind not to fill up the entire 16x16, 24x24, or 32x32 frame when designing an icon. Legible, uniform icon construction is essential to user recognition. Adhere to the following points when building icons.

- Icons should be clear, understandable, and consistent.

- It is better to use the status notification elements as single icons and not to stack them on top of an icon base element. In certain contexts, the UI might require the status element to be paired with a base element.

- Project icons are usually .ico files that contain several sizes. Only the 16x16, 24x24, and 32x32 icons are being updated. Most 16x16 and 24x24 icons will contain the same elements. The 32x32 icons contain more details, including the project language type when applicable.

- For 32x32 icons, the base elements generally have a 2-pixel line weight. A 1- or 2-pixel line weight can be used for detail elements. Use your best judgment to determine which is more suitable.

- Have at least a 1-pixel spacing between elements for 16x16 and 24x24 icons. For 32x32 icons, use 2-pixel spacing between elements and between the modifier and base element.

  ![Element spacing for icons sized 16x16, 24x24, and 32x32](../../extensibility/ux-guidelines/media/0404-47_elementspacing.png "0404-47_ElementSpacing")<br />Element spacing for icons sized 16x16, 24x24, and 32x32

#### Color and accessibility
 Visual Studio compliance guidelines require that all icons in the product pass the accessibility requirements for color and contrast. This is achieved through icon inversion, and when you are designing, you should be aware they will be inverted programmatically in the product.

 For more information on using color in Visual Studio icons, see [Using color in images](../../extensibility/ux-guidelines/images-and-icons-for-visual-studio.md#BKMK_UsingColorInImages).

## <a name="BKMK_UsingColorInImages"></a> Using color in images

 Icons in Visual Studio are primarily monochromatic. Color is reserved to convey specific information and never for decoration. Color is used:

- to indicate an action

- to alert the user to a status notification

- to designate language affiliation

- to differentiate items within IntelliSense

### Accessibility
 Visual Studio compliance guidelines require that all icons checked into the product pass the accessibility requirements for color and contrast. Colors in the visual language palette have been tested and meet these requirements.

#### Color inversion for dark themes
 In order to make icons appear with the correct contrast ratio in the Visual Studio dark theme, an inversion is applied programmatically. The colors in this guide have been chosen in part so that they invert correctly. Restrict your use of color to this palette, or you will get unpredictable results when the inversion is applied.

 ![Examples of icons that have had their colors inverted](../../extensibility/ux-guidelines/media/0405-01_darkthemeinversion.png "0405-01_DarkThemeInversion")<br />Examples of icons that have had their colors inverted

### Base palette
 All standard icons contain three base colors. Icons contain no gradients or drop shadows, with one or two exceptions for 3D-tool icons.

|Usage|Name|Value (Light theme)|Swatch|Example|
|-----------|----------|---------------------------|------------|-------------|
|Background/Dark|VS BG|424242 / 66,66,66|![Swatch 424242](../../extensibility/ux-guidelines/media/0405_424242.png "0405_424242")|![Base palette example](../../extensibility/ux-guidelines/media/0405-02_basepaletteexample.png "0405-02_BasePaletteExample")|
|Foreground/Light|VS FG|F0EFF1 / 240,239,241|![Swatch F0EFF1](../../extensibility/ux-guidelines/media/0405_f0eff1.png "0405_F0EFF1")||
|Outline|VS Out|F6F6F6 / 246,246,246|![Swatch F6F6F6](../../extensibility/ux-guidelines/media/0405_f6f6f6.png "0405_F6F6F6")||

 In addition to the base colors, each icon may contain one additional color from the extended palette.

### Extended palette

#### Action modifiers
 The four colors below indicate the types of actions required by action modifiers:

|Usage|Name|Value (all themes)|Swatch|
|-----------|----------|--------------------------|------------|
|Positive|VS Action Green|388A34 / 56,138,52|![Swatch 388A34](../../extensibility/ux-guidelines/media/0405_388a34.png "0405_388A34")|
|Negative|VS Action Red|A1260D / 161,38,13|![Swatch A1260D](../../extensibility/ux-guidelines/media/0405_a1260d.png "0405_A1260D")|
|Neutral|VS Action Blue|00539C / 0,83,156|![Swatch 00539C](../../extensibility/ux-guidelines/media/0405_00539c.png "0405_00539C")|
|Create/New|VS Action Orange|C27D1A / 194,156,26|![Swatch C27D1A](../../extensibility/ux-guidelines/media/0405_c27d1a.png "0405_C27D1A")|

##### Examples
 Green is used for positive action modifiers like "Add," "Run," "Play," and "Validate."

|Run|Execute query|Play all steps|Add Control|
|-|-|-|-|
|![Run icon](../../extensibility/ux-guidelines/media/0405-03_actionmodifierrun.png "0405-03_ActionModifierRun")|![Execute query icon](../../extensibility/ux-guidelines/media/0405-04_executequery.png "0405-04_ExecuteQuery")|![Play all steps icon](../../extensibility/ux-guidelines/media/0405-05_playallsteps.png "0405-05_PlayAllSteps")|![Add control icon](../../extensibility/ux-guidelines/media/0405-06_addcontrol.png "0405-06_AddControl")|

 Red is used for negative action modifiers like "Delete," "Stop," "Cancel," and "Close."

|Delete Relationship|Delete Column|Stop Query|Connection Offline|
|-|-|-|-|
|![Delete relationship icon](../../extensibility/ux-guidelines/media/0405-07_deleterelationship.png "0405-07_DeleteRelationship")|![Delete column icon](../../extensibility/ux-guidelines/media/0405-08_deletecolumn.png "0405-08_DeleteColumn")|![Stop query icon](../../extensibility/ux-guidelines/media/0405-09_stopquery.png "0405-09_StopQuery")|![Connection offline icon](../../extensibility/ux-guidelines/media/0405-10_connectionoffline.png "0405-10_ConnectionOffline")|

 Blue is applied to neutral action modifiers most commonly represented as arrows, like "Open," "Next," "Previous," "Import," and "Export."

|Go to Field|Batched Check-In|Address Editor|Association Editor|
|-|-|-|-|
|![Go to field icon](../../extensibility/ux-guidelines/media/0405-11_gotofield.png "0405-11_GoToField")|![Batched check&#45;in icon](../../extensibility/ux-guidelines/media/0405-12_batchedcheckin.png "0405-12_BatchedCheckIn")|![Address editor icon](../../extensibility/ux-guidelines/media/0405-13_addresseditor.png "0405-13_AddressEditor")|![Association editor icon](../../extensibility/ux-guidelines/media/0405-14_associationeditor.png "0405-14_AssociationEditor")|

 Dark gold is primarily used for the "New" modifier.

|New Project|Create New Graph|New Unit Test|New List Item|
|-|-|-|-|
|![New project icon](../../extensibility/ux-guidelines/media/0405-15_newproject.png "0405-15_NewProject")|![Create new graph icon](../../extensibility/ux-guidelines/media/0405-16_createnewgraph.png "0405-16_CreateNewGraph")|![New unit test icon](../../extensibility/ux-guidelines/media/0405-17_newunittest.png "0405-17_NewUnitTest")|![New list item icon](../../extensibility/ux-guidelines/media/0405-18_newlistitem.png "0405-18_NewListItem")|

#### Special cases
 In special cases, a colored action modifier may be used independently as a standalone icon. The color used for the icon reflects the actions that the icon is associated with. This use is limited to a small subset of icons, including:

|Run|Stop|Delete|Save|Navigate Back|
|-|-|-|-|-|
|![Run icon](../../extensibility/ux-guidelines/media/0405-03_actionmodifierrun.png "0405-03_ActionModifierRun")|![Stop icon - Solid red square.](../../extensibility/ux-guidelines/media/0405-19_stop.png "0405-19_Stop")|![Delete icon](../../extensibility/ux-guidelines/media/0405-20_delete.png "0405-20_Delete")|![Save icon](../../extensibility/ux-guidelines/media/0405-21_save.png "0405-21_Save")|![Navigate back icon](../../extensibility/ux-guidelines/media/0405-22_navigateback.png "0405-22_NavigateBack")|

### Code hierarchy palette

#### Folder

|Usage|Name|Value (all themes)|Swatch|Example|
|-----------|----------|--------------------------|------------|-------------|
|Folders|Folder|DCB67A / 220,182,122|![Swatch DCB67A](../../extensibility/ux-guidelines/media/0405_dcb67a.png "0405_DCB67A")|![Folder color icon](../../extensibility/ux-guidelines/media/0405-23_foldercolor.png "0405-23_FolderColor")|

#### Visual Studio languages
 Each of the common languages or platforms available in Visual Studio has an associated color. These colors are used on the base icon, or on language modifiers that appear in the upper right corner of compound icons.

|Usage|Name|Value (all themes)|Swatch|
|-----------|----------|--------------------------|------------|
|ASP, HTML, WPF|ASP HTML WPF Blue|0095D7 / 0,149,215|![Swatch 0095D7](../../extensibility/ux-guidelines/media/0405_0096d7.png "0405_0096D7")|
|C++|CPP Purple|9B4F96 / 155,79,150|![Swatch 9B4F96](../../extensibility/ux-guidelines/media/0405_9b4f96.png "0405_9B4F96")|
|C#|CS Green (VS Action Green)|388A34 / 56,138,52|![Swatch 388A34](../../extensibility/ux-guidelines/media/0405_388a34.png "0405_388A34")|
|CSS|CSS Red|BD1E2D / 189,30,45|![Swatch BD1E2D](../../extensibility/ux-guidelines/media/0405_bd1e2d.png "0405_BD1E2D")|
|F#|FS Purple|672878 / 103,40,120|![Swatch 672878](../../extensibility/ux-guidelines/media/0405_672878.png "0405_672878")|
|JavaScript|JS Orange|F16421 / 241,100,33|![Swatch F16421](../../extensibility/ux-guidelines/media/0405_f16421.png "0405_F16421")|
|VB|VB Blue (VS Action Blue)|00539C / 0,83,156|![Swatch 00539C](../../extensibility/ux-guidelines/media/0405_00539c.png "0405_00539C")|
|TypeScript|TS Orange|E04C06 / 224,76,6|![Swatch E04C06](../../extensibility/ux-guidelines/media/0405_e04c06.png "0405_E04C06")|
|Python|PY Green|879636 / 135,150,54|![Swatch 879636](../../extensibility/ux-guidelines/media/0405_879636.png "0405_879636")|

##### Examples of icons with language modifiers

|VB|C#|C++|F#|JavaScript|Python|
|-|-|-|-|-|-|
|![Visual Basic icon](../../extensibility/ux-guidelines/media/0405-25_vb.png "0405-25_VB")|![C&#35; icon](../../extensibility/ux-guidelines/media/0405-26_csharp.png "0405-26_CSharp")|![C&#43;&#43; icon](../../extensibility/ux-guidelines/media/0405-27_cplusplus.png "0405-27_CPlusPlus")|![F&#35; icon](../../extensibility/ux-guidelines/media/0405-28_fsharp.png "0405-28_FSharp")|![JavaScript icon](../../extensibility/ux-guidelines/media/0405-29_javascript.png "0405-29_JavaScript")|![Python icon](../../extensibility/ux-guidelines/media/0405-30_python.png "0405-30_Python")|

|HTML|WPF|ASP|CSS|TypeScript|
|-|-|-|-|-|
|![HTML icon](../../extensibility/ux-guidelines/media/0405-31_html.png "0405-31_HTML")<br />HTML|![WPF icon](../../extensibility/ux-guidelines/media/0405-32_wpf.png "0405-32_WPF")<br />WPF|![ASP icon](../../extensibility/ux-guidelines/media/0405-33_asp.png "0405-33_ASP")<br />ASP|![CSS icon](../../extensibility/ux-guidelines/media/0405-34_css.png "0405-34_CSS")<br />CSS|![TypeScript icon](../../extensibility/ux-guidelines/media/0405-35_typescript.png "0405-35_TypeScript")<br />TypeScript|

#### IntelliSense
 IntelliSense icons use an exclusive color palette. These colors are used to help users quickly distinguish between the different items in the IntelliSense popup list.

|Usage|Name|Value (all themes)|Swatch|
|-----------|----------|--------------------------|------------|
|Class, Event|VS Action Orange|C27D1A / 194,125,26|![Swatch C27D1A](../../extensibility/ux-guidelines/media/0405_c27d1a.png "0405_C27D1A")|
|Extension Method, Method, Module, Delegate|VS Action Purple|652D90 / 101,45,144|![Swatch 652D90](../../extensibility/ux-guidelines/media/0405_652d90.png "0405_652D90")|
|Field, Enum Item, Macro, Structure, Union Value Type, Operator, Interface|VS Action Blue|00539C / 0,83,156|![Swatch 00539C](../../extensibility/ux-guidelines/media/0405_00539c.png "0405_00539C")|
|Object|VS Action Green|388A34 / 56,138,52|![Swatch 388A34](../../extensibility/ux-guidelines/media/0405_388a34.png "0405_388A34")|
|Constant, Exception, Enum Item, Map, Map Item, Namespace, Template, Type Definition|Background (VS BG)|424242 / 66,66,66|![Swatch 424242](../../extensibility/ux-guidelines/media/0405_424242.png "0405_424242")|

##### Examples of IntelliSense icons

|Class|Private Event|Delegate|Method Friend|Field|
|-|-|-|-|-|
|![IntelliSense class icon](../../extensibility/ux-guidelines/media/0405-36_intellisenseclass.png "0405-36_IntelliSenseClass")|![IntelliSense private event icon](../../extensibility/ux-guidelines/media/0405-37_intellisenseprivateevent.png "0405-37_IntelliSensePrivateEvent")|![IntelliSense delegate icon](../../extensibility/ux-guidelines/media/0405-38_intellisensedelegate.png "0405-38_IntelliSenseDelegate")|![IntelliSense method friend icon](../../extensibility/ux-guidelines/media/0405-39_intellisensemethodfriend.png "0405-39_IntelliSenseMethodFriend")|![Field icon](../../extensibility/ux-guidelines/media/0405-40_field.png "0405-40_Field")|

|Protected Enum Item|Object|Template|Exception Shortcut|
|-|-|-|-|
|![IntelliSense protected enum item icon](../../extensibility/ux-guidelines/media/0405-41_intellisenseprotectedenumitem.png "0405-41_IntelliSenseProtectedEnumItem")|![IntelliSense object icon](../../extensibility/ux-guidelines/media/0405-42_intellisenseobject.png "0405-42_IntelliSenseObject")|![IntelliSense template icon](../../extensibility/ux-guidelines/media/0405-43_intellisensetemplate.png "0405-43_IntelliSenseTemplate")|![IntelliSense exception shortcut icon](../../extensibility/ux-guidelines/media/0405-44_intellisenseexceptionshortcut.png "0405-44_IntelliSenseExceptionShortcut")|

### Notifications
 Notifications in Visual Studio are used to indicate status. The notification palette uses the following four colors, as well as black or white foreground fill options, to define notifications with the following status levels.

|Usage|Name|Value (all themes)|Swatch|
|-----------|----------|--------------------------|------------|
|Status: neutral|Notification Blue (VS Blue)|1BA1E2 / 27,161,226|![Swatch 1BA1E2](../../extensibility/ux-guidelines/media/0405_1ba1e2.png "0405_1BA1E2")|
|Status: positive|Notification Green (VS Green)|339933 / 51,153,51|![Swatch 339933](../../extensibility/ux-guidelines/media/0405_339933.png "0405_339933")|
|Status: negative|Notification Red (VS Red)|E51400 / 229,20,0|![Swatch E51400](../../extensibility/ux-guidelines/media/0405_e51400.png "0405_E51400")|
|Status: warning|Notification Yellow (VS Orange)|FFCC00 / 255,204,0|![Swatch FFCC00](../../extensibility/ux-guidelines/media/0405_ffcc00.png "0405_FFCC00")|
|Foreground fill|Notification Black (Black)|000000 / 0,0,0|![Swatch &#35;000000](../../extensibility/ux-guidelines/media/0405_000000.png "0405_000000")|
|Foreground fill|Notification White (White)|FFFFFF / 255,255,255|![Swatch FFFFFF](../../extensibility/ux-guidelines/media/0405_ffffff.png "0405_FFFFFF")|

#### Examples of notification icons

|Alert|Warning|Complete|Stop|
|-|-|-|-|
|![Alert icon](../../extensibility/ux-guidelines/media/0405-45_alert.png "0405-45_Alert")|![Warning icon](../../extensibility/ux-guidelines/media/0405-48_warning.png "0405-48_Warning")|![Complete icon](../../extensibility/ux-guidelines/media/0405-46_complete.png "0405-46_Complete")|![Stop icon - Solid red circle with a white square in the center.](../../extensibility/ux-guidelines/media/0405-47_stop.png "0405-47_Stop")|