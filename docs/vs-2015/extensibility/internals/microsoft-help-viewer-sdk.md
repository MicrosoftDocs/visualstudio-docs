---
title: "Microsoft Help Viewer SDK | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: 620d7dcd-d462-475e-a449-fbfa06ff12c5
caps.latest.revision: 34
ms.author: gregvanl
manager: jillfra
---
# Microsoft Help Viewer SDK
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This article contains the following tasks for Visual Studio Help Viewer integrators:

- Creating a topic (F1 support)

- Creating a Help Viewer content-branding package

- Deploying a set of articles

- Adding help to the Visual Studio shell (integrated or isolated)

- Additional Resources

### Creating a topic (F1 support)
 This section provides an overview of the components of a presented topic, topic requirements, a short description for how to create a topic (including F1 support requirements) and finally, an example topic with its rendered result.

 **Help Viewer Topic Overview**

 When a topic is called for rendering, the Help Viewer gets the branding package elements that are associated with the topic at the time of install or last update, along with the topic XHTML, and combines the two to result in the presented content view (branding data + topic data).  The branding package contains logos, support for content behaviors, and branding text (copyright, etc.).  See “Creating Branding Package” below for more information about the branding package elements.  In the event there is no branding package associated with the topic, the Help Viewer will use the fallback branding package located in the Help Viewer application root (Branding_en-US.mshc).

 **Help Viewer Topic Requirements**

 To be rendered correctly within the Help Viewer, raw topic content must be W3C Basic 1.1 XHTML.

 A topic typically contains two sections:

- Metadata (see Content Metadata Reference): data about the topic, for example, the topic unique ID, keyword value, the topic TOC ID, parent node ID, etc.

- Body content: compliant with W3C Basic 1.1 XHTML, which includes supported content behaviors (collapsible area, code snippet, etc. A full list is shown below).

  Visual Studio Branding Package supported controls:

- Links

- CodeSnippet

- CollapsibleArea

- Inherited Member

- LanguageSpecificText

  Supported language strings (not case sensitive):

- javascript

- csharp or c#

- cplusplus or visualc++ or c++

- jscript

- visualbasic or vb

- f# or fsharp or fs

- other – a string that represents a language name

  **Creating a Help Viewer topic**

  Create a new XHTML document named ContosoTopic4.htm, and include the title tag (below).

```html
<html>
<head>
<title>Contoso Topic 4</title>
</head>

<body>

</body>
</html>

```

 Next, add data to define how the topic is to be presented (self branded or not), how to reference this topic for F1, where this topic exists within the TOC, its ID (for link reference by other topics), etc.  See the “Content Metadata” table below for a complete list of supported metadata.

- In this case, we will use our own branding package, a variant of the Visual Studio Help Viewer branding package.

- Add the F1 meta name and value (“Microsoft.Help.F1" content=" ContosoTopic4") that will match the supplied F1 value in the IDE property bag.  (See the F1 Support section for more information.)   This is the value that is matched to the F1 call from within the IDE to display this topic when F1 is chosen in the IDE.

- Add the topic ID. This is the string that is used by other topics to link to this topic.  It is the Help Viewer ID for this topic.

- For the TOC, add this topic’s parent node to define where this topic TOC node will appear.

- For the TOC, add this topic’s node order. When the parent node has n number of children nodes, define in the order of child nodes this topic's location. For example, this topic is number 4 of 4 child topics.)

  Example metadata section:

```html
<html>
<head>
<title>Contoso Topic 4</title>

<meta name="SelfBranded" content="false" />
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="Microsoft.Help.Id" content="ContosoTopic4" />
<meta name="Microsoft.Help.F1" content=" ContosoTopic4" />
    <meta name="Language" content="en-us" />
<meta name="Microsoft.Help.TocParent" content="ContosoTopic0" />
<meta name="Microsoft.Help.TocOrder" content="4" />

</head>

<body>

</body>
</html>

```

 **The Topic Body**

 The body (not including the header and footer) of the topic will contain page links, a note section, a collapsible area, a code snippet, and a section of language specific text.  See the branding section for information about those areas of the presented topic.

1. Add a topic title tag:  `<div class="title">Contoso Topic 4</div>`

2. Add a note section: `<div class="alert"> add your table tag and text </div>`

3. Add a collapsible area:  `<CollapsibleArea Expanded="1" Title="Collapsible Area Test Heading"> add text  </CollapsibleArea>`

4. Add a code snippet:  `<CodeSnippet EnableCopyCode="true" Language="CSharp" ContainsMarkup="false" DisplayLanguage="C#" > a block of code </CodeSnippet>`

5. Add code language specific text:  `<LanguageSpecificText devLangcs="CS" devLangvb="VB" devLangcpp="C++" devLangnu="F#" />` Note that devLangnu= allows you to enter other languages. For example, devLangnu=”Fortran” will display Fortran when the code snippet DisplayLanguage = Fortran

6. Add page links: `<a href="ms-xhelp://?Id=ContosoTopic1">Main Topic</a>`

> [!NOTE]
> Note: for non-supported new “Display Language” (example, F#, Cobol, Fortran) code colorization in the code snippet will be monochrome.

 **Example Help Viewer Topic** The code illustrates how to define metadata, a code snippet, a collapsible area, and language specific text.

```
<?xml version="1.0" encoding="utf-8"?>
<html>
<head>
<title>Contoso Topic 4</title>

    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="Microsoft.Help.Id" content="ContosoTopic4" />
<meta name="Microsoft.Help.F1" content=" ContosoTopic4" />
    <meta name="Language" content="en-us" />
<meta name="Microsoft.Help.TocParent" content="ContosoTopic0" />
<meta name="Microsoft.Help.TocOrder" content="4" />
<meta name="SelfBranded" content="false" />
</head>

<body>
<div class="title">Contoso Topic 4</div>

  <div id="header">
<table id="bottomTable" cellpadding="0" cellspacing="0"  width="100%">
        <tr id="headerTableRow2"><td align="left">
            <span id="nsrTitle">Contoso Topic 1</span>
          </td>
<td align="right">
</td></tr>
<tr id="headerTableRow1"><td align="left">
            <span id="runningHeaderText">Contoso Widgets & Sprockets</span>
          </td></tr>
      </table>
</div>

<h2>Table of Contents</h2>

<ul class="toc">
<li class="tocline1"><a href="#introduction" target="_self">1.0 Introduction</a></li>
<li class="tocline1"><a href="#seealso" target="_self">2.1 See Also</a></li>
</ul>

<div class="topic">

<div id="mainSection">
<div id="mainBody">

<a name="introduction"></a>
<h2>1.0 Introduction</h2>
<p>[This documentation is for sample purposes only.]</p>

<p>Contoso Topic 1 contains examples of:
<ul>
<li>Collapsible Area</li>
<li>Bookmark ("See also")</li>
<li>Code Snippets from Branding Package</li>
</ul>
 </p>
<div class="alert"><table><tr><th>
<strong>Note </strong></th></tr>
<tr><td>
<p>This is an example of a <span class="label">Note </span>section.
Call out important items for your reader in this <span class="label">Note </span>box.
</p></td></tr>
</table>
</div>
</div>

<CollapsibleArea Expanded="1" Title="Collapsible Area Test Heading">

            <a id="sectionToggle0"><!----></a>

<div>
Example of Collapsible Area
<br/>
Lorem ipsum dolor sit amet...
</div>
</CollapsibleArea>

<div id="snippetGroup" >
<CodeSnippet EnableCopyCode="true" Language="VisualBasic" ContainsMarkup="false" DisplayLanguage="Visual Basic" >
Private Sub ToolStripRenderer1_RenderGrip(sender as Object, e as ToolStripGripRenderEventArgs) _ Handles ToolStripRenderer1.RenderGrip
Dim messageBoxVB as New System.Text.StringBuilder()
    messageBoxVB.AppendFormat("{0} = {1}", "GripBounds", e.GripBounds)
    messageBoxVB.AppendLine()
 ...
    MessageBox.Show(messageBoxVB.ToString(),"RenderGrip Event")
End Sub
</CodeSnippet>

<CodeSnippet EnableCopyCode="true" Language="CSharp" ContainsMarkup="false" DisplayLanguage="C#" >
private void ToolStripRenderer1_RenderGrip(Object sender, ToolStripGripRenderEventArgs e)
{
System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
messageBoxCS.AppendFormat("{0} = {1}", "GripBounds", e.GripBounds );
messageBoxCS.AppendLine();
...
MessageBox.Show(messageBoxCS.ToString(), "RenderGrip Event" );
}
</CodeSnippet>

<CodeSnippet EnableCopyCode="true" Language="fsharp" ContainsMarkup="false" DisplayLanguage="F#" >
some F# code
</CodeSnippet>
</div>

<h4 class="subHeading">Example of code specific text</h4>Language = <LanguageSpecificText devLangcs="CS" devLangvb="VB" devLangcpp="C++" devLangnu="F#" />

<a name="seealso"></a>
<h1 class="heading">See Also</h1>

    <div id="seeAlsoSection" class="section">
    <div class="seeAlsoStyle">
        <a href="ms-xhelp://?Id=ContosoTopic1">Main Topic</a>
    </div>
 </div>
</div>
</div>
</body>
</html>

```

 **F1 Support**

 In Visual Studio, selecting F1 generates values supplied from the placement of the cursor within the IDE and populates a “property bag” with the supplied values (based on cursor location. When the cursor is over feature x, feature x is active/in focus and populates property bag with values.  When F1 is selected the property bag is populated and Visual Studio F1 code looks to see if the customers default Help source is local or online (online is the default), then creates the appropriate string based on the users setting (online is the default) – shell execute (see the Help Administrator Guide for exe launch parameters) with parameters for the local help viewer + keyword(s) from the property bag if local help is the default, or the MSDN URL with the keyword in the parameter list.

 If three strings are returned for F1, referred to as a multi-value string, take the first term, look for a hit, and if found, we are done; if not, move to the next string.  Order matters. Presentation of the multi-value keywords should be longest string to shortest string.  To verify this in the case for multi-value keywords, look at the online F1 URL string, which will include the chosen keyword.

 In Visual Studio 2012, we intentionally made a stronger divide between online and offline, so that if the user’s setting was for Online, then we simply passed the F1 request directly to our online query service on MSDN rather than routing through the Help Library Agent that we had in Visual Studio 2010. We then rely on a state of “vendor content installed = true” to determine whether to do something different in that context. If true, we then perform this parsing and routing logic depending on what you wish to support for your customers. If false, then we just go to MSDN. If the user’s setting is to Local, then all calls go to the local help engine.

 F1 Flow Diagram:

 ![F1 flow](../../extensibility/internals/media/f1flow.png "F1flow")

 When the Help Viewer default help content source is set to online (Launch in browser):

- Visual Studio Partner (VSP) features emit a value to the F1 property bag (property bag prefix.keyword and online URL for the prefix found in the registry): F1 sends a VSP URL+ parameters to the browser.

- Visual Studio features (language editor, Visual Studio specific menu items, etc.):  F1 sends  a Visual Studio URL to the browser.

  When the Help Viewer default help content source  is set to local Help (Launch in Help Viewer):

- VSP features where keyword match between F1 property bag and local store index (that is, the property bag prefix.keyword = the value found in the local store index):  F1 renders the topic in the Help Viewer.

- Visual Studio features (no option for the VSP to override the property bag emitted from Visual Studio features): F1 renders a Visual Studio topic in the Help Viewer.

  Set the following registry values to enable F1 Fallback for vendor Help content. F1 Fallback means that the Help Viewer is set to look for F1 Help content online, and the vendor content is installed locally to the users’ hard drive. The Help Viewer should look at local Help for the content even though the default setting is for online help.

1. Set the **VendorContent** value under the Help 2.1 registry key:

   - For 32-bit operating systems:

        HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\v2.1\Catalogs\VisualStudio12

        "VendorContent"=dword:00000001

   - For 64-bit operating systems:

        HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Help\v2.1\Catalogs\VisualStudio12

        "VendorContent"=dword:00000001

2. Register the partner namespace under the Help 2.1 registry key:

   - For 32-bit operating systems:

      HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\v2.1\Partner<em>\\<namespace\></em>

      "location"=”offline”

   - For 64-bit operating systems:

      HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Help\v2.1\Partner<em>\\<namespace\></em>

      "location"=”offline”

   **Base Native Namespace Parsing**

   To turn on base native namespace parsing, in the registry add a new DWORD by the name of: BaseNativeNamespaces and set its value to 1 (under the catalog key that they want to support).  For example, if you want to use the Visual Studio catalog, you could add the key to the path:

   HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Help\v2.1\Catalogs\VisualStudio12

   When an F1 keyword in the format HEADER/METHOD is encountered, the ‘/’ character will be parsed out, resulting in the following construct:

- HEADER: will be the namespace that can be used to register in the registry

- METHOD: this will become the keyword that gets passed through.

  For example, given a custom library called CustomLibrary and a method called MyTestMethod, when an F1 request comes in it will be formatted as `CustomLibrary/MyTestMethod`.

  A user can then register CustomLibrary as the namespace under the Partners hive, and provide whatever location key they desire, and the keyword passed to the query will be MyTestMethod.

  **Enable Help debugging tool in the IDE**

  Add the following registry key and value:

  HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\12.0\Dynamic Help key: Display Debug Output in Retail value: YES

  In the IDE, under the Help menu item, select “Debug Help Context”

  **Content Metadata**

  In the following table, any string that appears between brackets is a placeholder that must be replaced by a recognized value. For example, in \<meta name="Microsoft.Help.Locale" content="[language code]" />, "[language code]" must be replaced by a value such as "en-us".

|Property (HTML Representation)|Description|
|--------------------------------------|-----------------|
|\< meta name="Microsoft.Help.Locale" content="[language-code]" />|Sets a locale for this topic. If this tag is used in a topic, it must be used just once and it must be inserted above any other Microsoft Help tags. If this tag is not used, the body text of the topic is indexed by using word breaker that is associated with the product locale, if it is specified; otherwise, the en-us word breaker is used. This tag conforms to ISOC RFC 4646. To ensure that Microsoft Help works correctly, use this property instead of the general Language attribute.|
|\< meta name="Microsoft.Help.TopicLocale" content="[language-code]" />|Sets a locale for this topic when other locales are also used. If this tag is used in a topic, it must be used just once. Use this tag when the catalog contains content in more than one language. Multiple topics in a catalog can have the same ID, but each must specify a unique TopicLocale. The topic that specifies a TopicLocale that matches the locale of the catalog is the topic that is displayed in the table of contents. However, all language versions of the topic are displayed in Search results.|
|\< title>[Title]\</title>|Specifies the title of this topic. This tag is required, and must be used just once in a topic. If the body of the topic does not contain a title \<div> section, this Title is displayed in the topic and in the table of contents.|
|\< meta name=" Microsoft.Help.Keywords" content="[aKeywordPhrase]"/>|Specifies the text of a link that is displayed in the index pane of the Help Viewer. When the link is clicked, the topic is displayed.You can specify multiple index keywords for a topic, or you can omit this tag if you do not want links to this topic to appear in the index. "K" keywords from earlier versions of Help can be converted to this property.|
|\< meta name="Microsoft.Help.Id" content="[TopicID]"/>|Sets the identifier for this topic. This tag is required, and must be used just once in a topic. The ID must be unique among topics in the catalog that have the same locale setting. In another topic, you can create a link to this topic by using this ID.|
|\< meta name="Microsoft.Help.F1" content="[System.Windows.Controls.Primitives.IRecyclingItemContainerGenerator]"/>|Specifies the F1 keyword for this topic. You can specify multiple F1 keywords for a topic, or you can omit this tag if you do not want this topic to be displayed when an application user presses F1. Typically, just one F1 keyword is specified for a topic. "F" keywords from earlier versions of Help can be converted to this property.|
|\< meta name="Description" content="[topic description]" />|Provides a short summary of the content in this topic. If this tag is used in a topic, it must be used just once. This property is accessed directly by the query library; it is not stored in the index file.|
 meta name="Microsoft.Help.TocParent" content="[parent_Id]"/>|Specifies the parent topic of this topic in the table of contents. This tag is required, and must be used just once in a topic. The value is the Microsoft.Help.Id of the parent. A topic can have just one location in the table of contents. “-1” is considered the topic ID for the TOC root. In [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)], that page is Help Viewer home page. This is the same reason we specifically add TocParent=-1 to some topics to ensure that they show up at the top level.The Help Viewer home page is a system page and so non-replaceable. If a VSP tries to add a page with an ID of -1, it may get added to the content set, but Help Viewer will always use the system page – Help Viewer Home|
|\< meta name="Microsoft.Help.TocOrder" content="[positive integer]"/>|Specifies where in the table of contents this topic appears relative to its peer topics. This tag is required, and must be used just once in a topic. The value is an integer. A topic that specifies a lower-value integer appears above a topic that specifies a higher-value integer.|
|\< meta name="Microsoft.Help.Product" content="[product code]"/>|Specifies the product that this topic describes. If this tag is used in a topic, it must be used just once. This information can also be supplied as a parameter that is passed to the Help Indexer.|
|\< meta name="Microsoft.Help.ProductVersion" content="[version number]"/>|Specifies the version of the product that this topic describes. If this tag is used in a topic, it must be used just once. This information can also be supplied as a parameter that is passed to the Help Indexer.|
|\< meta name="Microsoft.Help.Category" content="[string]"/>|Used by products to identify subsections of content. You can identify multiple subsections for a topic, or you can omit this tag if you do not want links to identify any subsections. This tag is used to store the attributes for TargetOS and TargetFrameworkMoniker when a topic is converted from an earlier version of Help. The format of the content is AttributeName:AttributeValue.|
|\< meta name="Microsoft.Help.TopicVersion content="[topic version number]"/>|Specifies this version of the topic when multiple versions exist in a catalog. Because Microsoft.Help.Id is not guaranteed to be unique, this tag is required when more than one version of a topic exists in a catalog, for example, when a catalog contains a topic for the .NET Framework 3.5 and a topic for the .NET Framework 4 and both have the same Microsoft.Help.Id.|
|\< meta name="SelfBranded" content="[TRUE or FALSE]"/>|Specifies whether this topic uses the Help Library Manager start-up branding package or a branding package that is specific to the topic. This tag must be either TRUE or FALSE. If it is TRUE, then the branding package for the associated topic overrides the branding package that is set when Help Library Manager starts so that the topic is rendered as intended even if it differs from the rendering of other content. If it is FALSE, the current topic is rendered according to the branding package that is set when Help Library Manager starts. By default, Help Library Manager assumes self-branding to be false unless the SelfBranded variable is declared as TRUE; therefore, you do not have to declare \<meta name="SelfBranded" content="FALSE"/>.|

### Creating a branding package
 The Visual Studio release encompasses a number of different Visual Studio products, including the Isolated and Integrated shells for Visual Studio Partners.  Each of these products requires some degree of topic-based Help content branding support, unique to the product.  For example, Visual Studio topics need to have a consistent brand presentation, whereas SQL Studio, which wraps ISO Shell, requires its own unique Help content branding for each topic.  An Integrated Shell Partner may want their Help topics to be within the parent Visual Studio product Help content while maintaining their own topic branding.

 Branding packages are installed by the product containing the Help Viewer.  For Visual Studio products:

- A fallback branding package (Branding_\<locale>.mshc) is installed in the Help Viewer 2.1 app root (example: C:\Program Files (x86)\Microsoft Help Viewer\v2.1) by the Help Viewer language pack.  This is used for cases where either the product branding package is not installed (no content has been installed) or where the installed branding package is corrupted.  The Visual Studio elements (logo and Feedback) are ignored when the app root fallback branding package is used.

- When Visual Studio content is installed from the content package service, a branding package is also installed (for the first time content installation scenario).  If there is an update to the branding package, the update is installed when the next content update or additional package install action happens.

  The Microsoft Help Viewer supports the branding of topics based on topic metadata.

- Where topic metadata defines self branded = true, render the topic as is, do nothing (as far as branding).

- Where topic metadata defines self branded = false, use the branding package associated with TopicVendor metadata value.

- Where topic metadata defines name="Microsoft.Help.TopicVendor” content=\< branding package name in vendor MSHA>, use the branding package defined in the content value.

- Within the Visual Studio catalog, there is a priority application of Branding Packages.  First Visual Studio default branding is applied, and then, if defined in the topic metadata and supported with the associated branding package (as defined in the installation msha), the vendor defined branding is applied as an override.

  Branding elements typically fall into three main categories:

- Header elements (examples include feedback link, conditional disclaimer text, logo)

- Content behaviors (examples include expand/collapse control text elements and code snippet elements)

- Footer elements (example Copyright)

  Items considered as branded elements include (detailed in this spec):

- Catalog/product logo (example, Visual Studio)

- Feedback link and e-mail elements

- Disclaimer text

- Copyright text

  Supporting files in the Visual Studio Help Viewer branding package include:

- Graphics (logos, icons, etc.)

- Branding.js – script files supporting content behaviors

- Branding.xml – strings that are consistently used across catalog content.  Note: for Visual Studio localization text elements in the branding.xml, include _locID="\<unique value>"

- Branding.css – style definitions for presentation consistency

- Printing.css – style definitions for consistent printed presentation

  As noted above, Branding Packages are associated with the topic:

- When SelfBranded = false is defined in the metadata, the topic inherits the catalog branding package

- Or when SelfBranded = false and there is a unique Branding Package defined in the MSHA and available when the content is installed

  For VSPs implementing custom branding packages (VSP content, SelfBranded=True), one way to proceed is to start with the fallback branding package (installed with the Help Viewer), and change the name of the file as appropriate.  The Branding_\<locale>.mshc file is a zip file with the file extension changed to .mshc, so simply change the extension from .mshc to .zip and extract the contents.  See below for branding package elements and modify as appropriate (for example, change the logo to the VSP logo and the reference to the logo in the Branding.xml file, update Branding.xml per VSP specifics, etc.).

  When all modifications are done, create a zip file containing the desired branding elements and change the extension to .mshc.

  To associate the custom branding package, create the MSHA, which contains the reference to the branding mshc file along with the content mshc (containing the topics).  See below “MSHA” for how to create a basic MSHA.

  The Branding.xml file contains a list elements used for consistently rendering specific items in a topic when the topic contains \<meta name="Microsoft.Help.SelfBranded" content="false"/>.  The Visual Studio list of elements in the Branding.xml file is listed below.  This list is intended to be used as a template for ISO Shell adopters, where they modify these elements (for example logo, feedback, and Copyright) to meet their own product branding needs.

  Note: variables noted by “{n}” have code dependencies – removing or changing these values will cause errors and possibly application crash.Localization identifiers (example _locID="codesnippet.n") are included in the Visual Studio Branding Package.

  **Branding.xml**

|||
|-|-|
|Feature:|**CollapsibleArea**|
|Use:|Expand collapses content control text|
|**Element**|**Value**|
|ExpandText|Expand|
|CollapseText|Collapse|
|Feature:|**CodeSnippet**|
|Use:|Code snippet control text.  Note: Code snippet content with “Non-Breaking” space will be changed to space.|
|**Element**|**Value**|
|CopyToClipboard|Copy to Clipboard|
|ViewColorizedText|View Colorized|
|CombinedVBTabDisplayLanguage|Visual Basic (Sample)|
|VBDeclaration|Declaration|
|VBUsage|Usage|
|Feature:|**Feedback, Footer, and Logo**|
|Use:|Provide a Feedback control for customer to supply feedback on the current topic via e-mail.  Copyright text for the content.  Logo definition.|
|**Element**|**Value  (These strings can be modified to meet content adopter need.)**|
|CopyRight|© 2013 Microsoft Corporation. All rights reserved.|
|SendFeedback|\<a href="{0}" {1}>Send Feedback\</a> on this topic to Microsoft.|
|FeedbackLink||
|LogoTitle|[!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)]|
|LogoFileName|vs_logo_bk.gif|
|LogoFileNameHC|vs_logo_wh.gif|
|Feature:|**Disclaimer**|
|Use:|A set of case specific disclaimers for machine translated content.|
|**Element**|**Value**|
|MT_Editable|This article was machine translated. If you have an Internet connection, select "View this topic online" to view this page in editable mode with the original English content at the same time.|
|MT_NonEditable|This article was machine translated. If you have an Internet connection, select "View this topic online" to view this page in editable mode with the original English content at the same time.|
|MT_QualityEditable|This article was manually translated. If you have an Internet connection, select "View this topic online" to view this page in editable mode with the original English content at the same time.|
|MT_QualityNonEditable|This article was manually translated. If you have an Internet connection, select "View this topic online" to view this page in editable mode with the original English content at the same time.|
|MT_BetaContents|This article was machine translated for a preliminary release. If you have an Internet connection, select "View this topic online" to view this page in editable mode with the original English content at the same time.|
|MT_BetaRecycledContents|This article was manually translated for a preliminary release. If you have an Internet connection, select "View this topic online" to view this page in editable mode with the original English content at the same time.|
|Feature:|**LinkTable**|
|Use:|Support for online topic links|
|**Element**|**Value**|
|LinkTableTitle|Link Table|
|TopicEnuLinkText|View the English version\</a> of this topic that is available on your computer.|
|TopicOnlineLinkText|View this topic \<a href="{0}" {1}>online\</a>|
|OnlineText|Online|
|Feature:|**Video Audio control**|
|Use:|Display elements and text for video content|
|**Element**|**Value**|
|MultiMediaNotSupported|Internet Explorer 9 or greater must be installed to support {0} content.|
|VideoText|displaying video|
|AudioText|streaming audio|
|OnlineVideoLinkText|\<p>To view the video associated with this topic, click {0}\<a href="{1}">{2}here\</a>.\</p>|
|OnlineAudioLinkText|\<p>To listen to the audio associated with this topic, click {0}\<a href="{1}">{2}here\</a>.\</p>|
|Feature:|**Content Not Installed control**|
|Use:|Text elements (strings) used for the rendering of contentnotinstalled.htm|
|**Element**|**Value**|
|ContentNotInstalledTitle|No content was found on your computer.|
|ContentNotInstalledDownloadContentText|\<p>To download content to your computer, \<a href="{0}" {1}>click the Manage tab\</a>.\</p>|
|ContentNotInstalledText|\<p>No content is installed on your computer. See your Administrator for local Help content installation.\</p>|
|Feature:|**Topic Not Found control**|
|Use:|Text elements (strings) used for the rendering of topicnotfound.htm|
|**Element**|**Value**|
|TopicNotFoundTitle|Cannot find requested topic on your computer.|
|TopicNotFoundViewOnlineText|\<p>The topic you requested was not found on your computer, but you can \<a href="{0}" {1}>view the topic online\</a>.\</p>|
|TopicNotFoundDownloadContentText|\<p>See the navigation pane for links to similar topics, or \<a href="{0}" {1}>click the Manage tab\</a> to download content to your computer.\</p>|
|TopicNotFoundText|\<p>The topic you requested was not found on your computer.\</p>|
|Feature:|**Topic Corrupted Control**|
|Use:|Text elements (strings) used for the rendering of topiccorrupted.htm|
|**Element**|**Value**|
|TopicCorruptedTitle|Unable to display the requested topic.|
|TopicCorruptedViewOnlineText|\<p>Help Viewer is unable to display the requested topic. There may be an error in the topic's content or an underlying system dependency.\</p>|
|Feature:|**Home Page control**|
|Use:|Text supporting the display of the Help Viewer top level node content.|
|**Element**|**Value**|
|HomePageTitle|Help Viewer Home|
|HomePageIntroduction|\<p>Welcome to the Microsoft Help Viewer, an essential source of information for everyone who uses Microsoft tools, products, technologies, and services. The Help Viewer gives you access to how-to and reference information, sample code, technical articles, and more. To find the content you need, browse the table of contents, use full-text search, or navigate through content using the keyword index.\</p>|
|HomePageContentInstallText|\<p>\<br />Use the \<a href="{0}" {1}>Manage Content\</a> tab to do the following:\<ul>\<li>Add content to your computer.\</li>\<li>Check for updates to your local content.\</li>\<li>Remove content from your computer.\</li>\</ul>\</p>|
|HomePageInstalledBooks|Installed Books|
|HomePageNoBooksInstalled|No content was found on your computer.|
|HomePageHelpSettings|Help Content Settings|
|HomePageHelpSettingsText|\<p>Your current setting is local help. The Help Viewer displays content that you have installed on your computer.\<br />To change your source of Help content, on the Visual Studio menu bar, choose \<span style="{0}">Help, Set Help Preference\</span>.\<br />\</p>|
|MegaByte|MB|

 **branding.js**

 The branding.js file contains JavaScript used by the Visual Studio Help Viewer branding elements.  Below is a list of the branding elements and the supporting JavaScript function.  All strings to be localized for this file are defined in the “Localizable Strings” section at the top of this file.  ICL file has been created for loc strings within the branding.js file.

||||
|-|-|-|
|**Branding Feature**|**JavaScript Function**|**Description**|
|Var …||Define variables|
|Get the user code language|setUserPreferenceLang|maps an index # to code language|
|Set and Get cookie values|getCookie, setCookie||
|Inherited Member|changeMembersLabel|Expand/collapse inherited member|
|When SelfBranded=False|onLoad|Read the query string to check if it's a print request.  Set all the codesnippets to focus the user preferred tab.  If it's a print request, then set isPrinterFriendly to true. Check for high contrast mode.|
|Code Snippet|addSpecificTextLanguageTagSet||
||getIndexFromDevLang||
||ChangeTab||
||setCodesnippetLang||
||setCurrentLang||
||CopyToClipboard||
|CollapsibleArea|addToCollapsibleControlSet|write all the collapsible control object into list.|
||CA_Click|based on state of collapsible area, defines which image and text to present|
|Contrast support for Logo|isBlackBackground()|Called to determine if background is black.  Only accurate when in high contrast mode.|
||isHighContrast()|use a colored span to detect high contrast mode|
||onHighContrast(black)|Called when high contrast is detected|
|LST functionality|||
||addToLanSpecTextIdSet(id)||
||updateLST(currentLang)||
||getDevLangFromCodeSnippet(lang)||
|MultiMedia functionality|caption(begin, end, text, style)||
||findAllMediaControls(normalizedId)||
||getActivePlayer(normalizedId)||
||captionsOnOff(id)||
||toSeconds(t)||
||getAllComments(node)||
||styleRectify(styleName, styleValue)||
||showCC(id)||
||subtitle(id)||

 **HTM FILES**

 The branding package contains a set of HTM files that support scenarios for communicating key information to Help content users, for example a homepage that contains a section describing which content sets are installed and pages telling the user when topics cannot be found in the local set of topics. These HTM files can be modified per product.  ISO Shell vendors are able to take the default branding package and change the behavior and content of these pages to suite their need.  These files refer to their respective branding package in order for the branding tags to get the corresponding content from the branding.xml file.

||||
|-|-|-|
|**File**|**Use**|**Displayed Content Source**|
|homepage.htm|This is a page that displays currently installed content, and any other message appropriate to present to the user about their content.  This file has the additional meta data attribute "Microsoft.Help.Id" content="-1"  which places this content at the top of the local content TOC.||
||<META_HOME_PAGE_TITLE_ADD />|Branding.xml, tag \<HomePageTitle>|
||<HOME_PAGE_INTRODUCTION_SECTION_ADD />|Branding.xml, tag \<HomePageIntroduction>|
||<HOME_PAGE_CONTENT_INSTALL_SECTION_ADD />|Branding.xml, tag \<HomePageContentInstallText>|
||<HOME_PAGE_BOOKS_INSTALLED_SECTION_ADD />|Heading section Branding.xml tag\<HomePageInstalledBooks>, the data generated from application,  \<HomePageNoBooksInstalled> when no books are installed.|
||<HOME_PAGE_SETTINGS_SECTION_ADD />|Heading section Branding.xml tag \<HomePageHelpSettings>, section text \<HomePageHelpSettingsText>.|
|topiccorrupted.htm|When a topic exists in the local set, but for some reason cannot be displayed (corrupted content).||
||<META_TOPIC_CORRUPTED_TITLE_ADD />|Branding.xml, tag \<TopicCorruptedTitle>|
||<TOPIC_CORRUPTED_SECTION_ADD />|Branding.xml, tag \<TopicCorruptedViewOnlineText>|
|topicnotfound.htm|When a topic is not found in the local content set, nor available online||
||<META_TOPIC_NOT_FOUND_TITLE_ADD />|Branding.xml, tag \<TopicNotFoundTitle>|
||<META_TOPIC_NOT_FOUND_ID_ADD />|Branding.xml, tag \<TopicNotFoundViewOnlineText> + \<TopicNotFoundDownloadContentText>|
||<TOPIC_NOT_FOUND_SECTION_ADD />|Branding.xml, tag \<TopicNotFoundText>|
|contentnotinstalled.htm|When there is no local content installed for the product.||
||<META_CONTENT_NOT_INSTALLED_TITLE_ADD />|Branding.xml, tag \<ContentNotInstalledTitle>|
||<META_CONTENT_NOT_INSTALLED_ID_ADD />|Branding.xml, tag \<ContentNotInstalledDownloadContentText>|
||<CONTENT_NOT_INSTALLED_SECTION_ADD />|Branding.xml, tag \<ContentNotInstalledText>|

 **CSS Files**

 The Visual Studio Help Viewer Branding Package contains two css files to support consistent Visual Studio Help content presentation:

- Branding.css – contains css elements for rendering where SelfBranded=false

- Printer.css – contains css elements for rendering where SelfBranded=false

  Branding.css files includes definitions for Visual Studio topic presentation (caveat is that the branding.css contained in the Branding_\<locale>.mshc from the package service may change).

  **Graphic Files**

  Visual Studio content displays a Visual Studio logo as well as other graphics.  The complete list of graphic files in the Visual Studio Help Viewer branding package is shown below.

||||
|-|-|-|
|**File**|**Use**|**Examples**|
|clear.gif|Used to render Collapsible Area||
|footer_slice.gif|Footer presentation||
|info_icon.gif|Used when displaying information|Disclaimer|
|online_icon.gif|This icon is to be associated with online links||
|tabLeftBD.gif|Used to render the code snippet container||
|tabRightBD.gif|Used to render the code snippet container||
|vs_logo_bk.gif|Used for normal contrast logo references as defined in Branding.xml tag \<LogoFileName>.  For Visual Studio products, logo name is vs_logo_bk.gif.||
|vs_logo_wh.gif|Used for normal high logo references as defined in Branding.xml tag \<LogoFileNameHC>.  For Visual Studio products, logo name is vs_logo_wh.gif.||
|ccOff.png|Captioning graphic||
|ccOn.png|Captioning graphic||
|ImageSprite.png|Used to render Collapsible Area|expanded or collapse graphic|

### Deploying a set of topics
 This is a simple and quick tutorial for creating a Help Viewer content deployment set comprised of an MSHA file and the set of cabs or MSHCs containing the topics. The MSHA is an XML file that describes a set of cabs or MSHC files. The Help Viewer can read the MSHA to obtain a list of content (the .CAB or .MSHC files) available for local installation.

 This is only a primer describing the very basic XML schema for the Help Viewer MSHA.  There is an example implementation below this brief overview and sample HelpContentSetup.msha.

 The name of the MSHA, for the purposes of this primer, is HelpContentSetup.msha (the name of the file can be anything, with the extension .MSHA). HelpContentSetup.msha (example below) should contain a list of the cabs or MSHCs available.  The file type must be consistent within the MSHA (does not support a combination of MSHA and CAB file types). For each CAB or MSHC, there should be a \<div class="package">…\</div> (see example below).

 Note: in the implementation example below, we have included the branding package. This is critical to include in order to get the needed Visual Studio content rendering elements and content behaviors.

 Sample HelpContentSetup.msha file: (Replace “content set name 1” and “content set name 2” etc. with your file names.)

```
<html>
<head />
<body class="vendor-book">
<div class="details">
<span class="vendor">Your Company</span>
<span class="locale">en-us</span>
<span class="product">Your Company Help Content</span>
<span class="name">Your Company Help Content</span>
</div>
<div class="package-list">
<div class="package">
<span class="name">Your_Company _Content_Set_1</span>
<span class="deployed">True</span>
<a class="current-link" href="Your_Company _Content_Set_1.mshc">Your_Company _Content_Set_1.mshc </a>
</div>
<div class="package">
<span class="name">Your_Company _Content_Set_2</span>
<span class="deployed">True</span>
<a class="current-link"href=" Your_Company _Content_Set_2.mshc "> Your_Company _Content_Set_2.mshc </a>
</div>.

```

1. Create local folder, something like “C:\SampleContent”

2. For this example, we will use MSHC files to contain the topics.  An MSHC is a zip with the file extension changed from .zip to .MSHC.

3. Create the below HelpContentSetup.msha as a text file (notepad was used to create the file) and save it to the above noted folder (see step 1).

   The class “Branding” exists and is unique. The Branding mshc is included in this primer so that the installed content will have branding, and the content behaviors that are contained in the MSHCs will have the appropriate support elements contained in the branding package. Without this, errors will result when the system looks for support items that are not part of the ripped (installed) content.

   To obtain the Visual Studio branding package, copy Branding_en-US.mshc file at C:\Program Files (x86)\Microsoft Help Viewer\v2.1\ to your working folder.

```html
<html>
<head />
<body class="vendor-book">
<div class="details">
<span class="vendor">Your Company</span>
<span class="locale">en-us</span>
<span class="product">Your Company Help Content</span>
<span class="name">Your Company Help Content</span>
</div>
<div class="package-list">
<div class="package">
<span class="name">Your_Company _Content_Set_1</span>
<span class="deployed">True</span>
<a class="current-link" href="Your_Company _Content_Set_1.mshc">Your_Company _Content_Set_1.mshc </a>
</div>
<div class="package">
<span class="name">Your_Company _Content_Set_2</span>
<span class="deployed">True</span>
<a class="current-link"href=" Your_Company _Content_Set_2.mshc "> Your_Company _Content_Set_2.mshc </a>
</div>
<div class="package">
<span class="packageType">branding</span>
<span class="name">Branding_en-US</span>
<span class="deployed">True</span>
<a class="current-link" href="Branding_en-US.mshc">Branding_en-US.mshc</a>
</div>
</div>
</body>
</html>

```

 **Summary**

 Using and extending the above steps will enable VSPs to deploy their content sets for the Visual Studio Help Viewer.

### Adding help to the Visual Studio Shell (Integrated and Isolated)
 **Introduction**

 This walkthrough demonstrates how to incorporate Help content into a Visual Studio Shell application and then deploy it.

 **Requirements**

1. [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)]

2. [Visual Studio 2013 Isolated Shell Redist](https://aka.ms/VS2013/IsoShell-LP/all)

   **Overview**

   The [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] Shell is a version of the [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] IDE on which you can base an application. Such applications contain the Isolated Shell together with extensions that you create. Use Isolated Shell project templates, which are included in the [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] SDK, to build extensions.

   The basic steps for creating an Isolated Shell-based application and its Help:

3. Obtain the [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] ISO Shell redistributable (a Microsoft download).

4. In Visual Studio, create a Help extension that is based on the Isolated Shell, for example, the Contoso Help extension that is described later in this walkthrough.

5. Wrap the extension and the ISO Shell redistributable into a deployment MSI (an application setup). This Walkthrough does not include a setup step.

   Create a Visual Studio content store. For the Integrated Shell scenario, change Visual Studio12 to the product catalog name as follows:

- Create folder C:\ProgramData\Microsoft\HelpLibrary2\Catalogs\VisualStudio12.

- Create a file named CatalogType.xml and add it to the folder. The file should contain the following lines of code:

  ```
  <?xml version="1.0" encoding="UTF-8"?>
  <catalogType>UserManaged</catalogType>
  ```

  Define the content store in the registry. For the Integrated Shell, change VisualStudio12 to the product catalog name:

- HKLM\SOFTWARE\Wow6432Node\Microsoft\Help\v2.1\Catalogs\VisualStudio12

   Key: LocationPath  String value: C:\ProgramData\Microsoft\HelpLibrary2\Catalogs\VisualStudio12\

- HKLM\SOFTWARE\Wow6432Node\Microsoft\Help\v2.1\Catalogs\VisualStudio12\en-US

   Key: CatalogName String value: [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] Documentation

  **Create the Project**

  To create an Isolated Shell extension:

1. In Visual Studio, under **File**, choose **New Project**, under **Other Project Types** choose **Extensibility**, and then choose  **Visual Studio Shell Isolated**. Name the project `ContosoHelpShell`) to create an extensibility project based on the Visual Studio Isolated Shell template.

2. In Solution Explorer, in the ContosoHelpShellUI project, in the Resource Files folder, open ApplicationCommands.vsct. Make sure this line is commented out (search for "No_Help"): `<!-- <define name=“No_HelpMenuCommands”/> -->`

3. Choose the F5 key to compile and run **Debug**. In the experimental instance of the Isolated Shell IDE, choose the **Help** menu. Make sure that the **View Help**, **Add and Remove Help Content**, and **Set Help Preference** commands appear.

4. In Solution Explorer, in the ContosHelpShell project, in the Shell Customization folder, open ContosoHelpShell.pkgdef. To define the Contoso Help catalog, add the following lines:

   ```
    [$RootKey$\Help]
   "Product"="Contoso"
   "Catalog"="Contoso"
   “Version"="100"
   "BrandingPackage"="ContosoBrandingPackage.mshc"
   ```

5. In Solution Explorer, in the ContosHelpShell project, in the Shell Customization folder, open ContosoHelpShell.Application.pkgdef. To enable F1 Help, add the following lines:

   ```
   // F1 Help Provider

   [$RootKey$\HelpProviders\{C99BDC23-FF29-46bf-9658-ADD634CCAED8}]
   "Name"="13407"
   "Package"="{DA9FB551-C724-11d0-AE1F-00A0C90FFFC3}"
   @="Help3 Provider"
   [$RootKey$\HelpProviders]
   @="{C99BDC23-FF29-46bf-9658-ADD634CCAED8}"
   [$RootKey$\Services\{C99BDC23-FF29-46bf-9658-ADD634CCAED8}]
   "Name"="Help3 Provider"
   @="{4A791146-19E4-11D3-B86B-00C04F79F802}"
   ```

6. In Solution Explorer, on the context menu of the ContosoHelpShell solution, choose the **Properties** menu item. Under **Configuration Properties**, select **Configuration Manager**. In the **Configuration** column, change every "Debug" value to "Release".

7. Build the solution. This creates a set of files in a release folder, which will be used in the next section.

   To test this as if deployed:

8. On the machine you are deploying Contoso to, install the downloaded (from above) ISO Shell.

9. Create a folder in \\\Program Files (x86)\\, and name it `Contoso`.

10. Copy the contents from the ContosoHelpShell release folder to \\\Program Files (x86)\Contoso\ folder.

11. Start Registry Editor by choosing  **Run** in the **Start** menu and entering `Regedit`. In the registry editor, choose **File**, and then **Import**. Browse to the ContosoHelpShell project folder. In the ContosoHelpShell subfolder, choose ContosoHelpShell.reg.

12. Create a content store:

     For ISO Shell - create a Contoso content store C:\ProgramData\Microsoft\HelpLibrary2\Catalogs\ContosoDev12

     For [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] Integrated Shell, create folder C:\ProgramData\Microsoft\HelpLibrary2\Catalogs\VisualStudio12

13. Create CatalogType.xml and add to the content store (previous step) containing:

    ```
    <?xml version="1.0" encoding="UTF-8"?>
    <catalogType>UserManaged</catalogType>
    ```

14. Add the following registry keys:

     HKLM\SOFTWARE\Wow6432Node\Microsoft\Help\v2.1\Catalogs\VisualStudio12Key: LocationPath  String value:

     For ISO Shell:

     C:ProgramDataMicrosoftHelpLibrary2CatalogsVisualStudio12

     [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] Integrated Shell:

     C:ProgramDataMicrosoftHelpLibrary2CatalogsVisualStudio12en-US

     Key: CatalogName String value: [!INCLUDE[vs_dev12](../../includes/vs-dev12-md.md)] Documentation. For ISO Shell, this is the name of your catalog.

15. Copy your content (cabs or MSHC and MSHA) to a local folder.

16. Example Integrated Shell command line for testing content store. For ISO Shell, change the catalog and launchingApp values as appropriate to match the product.

      "C:\Program Files (x86)\Microsoft Help Viewer\v2.1\HlpViewer.exe" /catalogName VisualStudio12 /helpQuery method=”page&id=ContosoTopic0” /launchingApp Microsoft,VisualStudio,12.0

17. Launch the Contoso application (from the Contoso app root). Within ISO Shell, choose the **Help** menu item, and change the **Set Help Preference** to **Use Local Help**.

18. Within the shell, choose the **Help** menu item, then **View Help**. The local Help viewer should launch. Choose the **Manage Content** tab. Under **Installation Source**, choose the **Disk** option button. Choose the **...** button and browse to the local folder containing Contoso content (copied to the local folder in the above step). Choose the HelpContentSetup.msha. Contoso should now show up as a book in the book selections. Choose **Add**, and then choose the **Update** button (bottom right corner).

19. Within the Contoso IDE, choose the F1 key to test F1 functionality.

### Additional Resources

For the Runtime API, see [Windows Help API](https://msdn.microsoft.com/library/windows/desktop/hh447318\(v=vs.85\).aspx).

For more information on how to leverage the Help API, see [Help Viewer Code Examples](https://marketplace.visualstudio.com/items?itemName=RobChandlerHelpMVP.HelpViewer20CodeExamples).

For updates on breaking issues, see the [Help Viewer Readme](https://go.microsoft.com/fwlink/?LinkID=231397&clcid=0x409).