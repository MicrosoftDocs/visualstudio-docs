---
title: "MSBuild Items"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d762eff4-c92a-4b5f-a944-1ca30aa22319
caps.latest.revision: 32
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# MSBuild Items
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <?Comment AT: What goal/s should this topic help users achieve?ALB: Obtain an introduction on how to use items and how to workwith variousattributes of an item.From AT: Rework intro with some second person? 2012-07-27T17:40:00Z  Id='0?>MSBuild<?CommentEnd Id='0'
    ?> items are inputs into the build system, and they typically represent files. Items are grouped into item types based on their element names. Item types are named lists of items that can be used as parameters for tasks. The tasks use the item values to perform the steps of the build process.</para>
    <para>Because items are named by the item type to which they belong, the terms "item" and "item value" can be used interchangeably.</para>
    <para>
      <embeddedLabel>In this topic</embeddedLabel>
    </para>
    <list class="bullet">
      <listItem>
        <para>
          <link xlink:href="#BKMK_Creating1">Creating Items in a Project File</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_Creating2">Creating Items During Execution</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_ReferencingItems">Referencing Items in a Project File</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_Wildcards">Using Wildcards to Specify Items</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_ExcludeAttribute">Using the Exclude Attribute</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_ItemMetadata">Item Metadata</link>
        </para>
        <list class="bullet">
          <listItem>
            <para>
              <link xlink:href="#BKMK_ReferencingItemMetadata">Referencing Item Metadata in a Project File</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_WellKnownItemMetadata">Well-known Item Metadata</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_Transforming">Transforming Item Types Using Metadata</link>
            </para>
          </listItem>
        </list>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_ItemDefinitions">Item Definitions</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_AttributesWithinTargets">Attributes for Items in an ItemGroup of a Target</link>
        </para>
        <list class="bullet">
          <listItem>
            <para>
              <link xlink:href="#BKMK_RemoveAttribute">Remove Attribute</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_KeepMetadata">KeepMetadata Attribute</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_RemoveMetadata">RemoveMetadata Attribute</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_KeepDuplicates">KeepDuplicates Attribute</link>
            </para>
          </listItem>
        </list>
      </listItem>
    </list>
  </introduction>
  <section address="BKMK_Creating1">
    <title>Creating Items in a Project File</title>
    <content>
      <para>You declare items in the project file as child elements of an <legacyLink xlink:href="aac894e3-a9f1-4bbc-a796-6ef07001f35b">ItemGroup</legacyLink> element. The name of the child element is the type of the item. The <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> attribute of the element specifies the items (files) to be included with that item type. For example, the following XML creates an item type that’s named <codeInline>Compile</codeInline>, which includes two files.</para>
      <code>&lt;ItemGroup&gt;
    &lt;Compile Include = "file1.cs"/&gt;
    &lt;Compile Include = "file2.cs"/&gt;
&lt;/ItemGroup&gt;</code>
      <para>The item "file2.cs" doesn’t replace the item "file1.cs"; instead, the file name is appended to the list of values for the <codeInline>Compile</codeInline> item type. You can’t remove an item from an item type during the evaluation phase of a build.</para>
      <para>The following XML creates the same item type by declaring both files in one <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> attribute. Notice that the file names are separated by a semicolon.</para>
      <code>&lt;ItemGroup&gt;
    &lt;Compile Include = "file1.cs;file2.cs"/&gt;
&lt;/ItemGroup&gt;</code>
    </content>
  </section>
  <section address="BKMK_Creating2">
    <title>Creating Items During Execution</title>
    <content>
      <para>Items that are outside <legacyLink xlink:href="350f6fc2-86b3-45f2-a31e-ece0e6bd4dca">Target</legacyLink> elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, items can be created or modified in the following ways:</para>
      <list class="bullet">
        <listItem>
          <para>Any task can emit an item. To emit an item, the <legacyLink xlink:href="d82e2485-e5f0-4936-a357-745bacccc299">Task</legacyLink> element must have a child <legacyLink xlink:href="34bc7cd1-efd3-4b57-b691-4584eeb6a0e9">Output</legacyLink> element that has an <unmanagedCodeEntityReference>ItemName</unmanagedCodeEntityReference> attribute.</para>
        </listItem>
        <listItem>
          <para>The <legacyLink xlink:href="c4311f38-979e-4324-b524-9e8c1cbdc41a">CreateItem</legacyLink> task can emit an item. This usage is deprecated. </para>
        </listItem>
        <listItem>
          <para>Starting in the .NET Framework 3.5, <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> elements may contain <legacyLink xlink:href="aac894e3-a9f1-4bbc-a796-6ef07001f35b">ItemGroup</legacyLink> elements that may contain item elements. </para>
        </listItem>
      </list>
    </content>
  </section>
  <section address="BKMK_ReferencingItems">
    <title>Referencing Items in a Project File</title>
    <content>
      <para>To reference item types throughout the project file, you use the syntax @(<parameterReference>ItemType</parameterReference>). For example, you would reference the item type in the previous example by using <codeInline>@(Compile)</codeInline>. By using this syntax, you can pass items to tasks by specifying the item type as a parameter of that task. For more information, see <link xlink:href="f5ff182f-7b3a-46fb-9335-37df54cfb8eb">How To: Build All Files in a Directory</link>.</para>
      <para>By default, the items of an item type are separated by semicolons (;) when it’s expanded. You can use the syntax @(<placeholder>ItemType</placeholder>, '<placeholder>separator</placeholder>') to specify a separator other than the default. For more information, see <link xlink:href="3cae844c-7c6d-4144-82dc-efad10ba458f">How To: Display an Item List Separated with Commas</link>.</para>
    </content>
  </section>
  <section address="BKMK_Wildcards">
    <title>Using Wildcards to Specify Items</title>
    <content>
      <para>You can use the **, *, and ? wildcard characters to specify a group of files as inputs for a build instead of listing each file separately.</para>
      <list class="bullet">
        <listItem>
          <para>The ? wildcard character matches a single character.</para>
        </listItem>
        <listItem>
          <para>The * wildcard character matches zero or more characters.</para>
        </listItem>
        <listItem>
          <para>The ** wildcard character sequence matches a partial path.</para>
        </listItem>
      </list>
      <para>For example, you can specify all the .cs files in the directory that contains the project file by using the following element in your project file.</para>
      <code>&lt;CSFile Include="*.cs"/&gt;</code>
      <para>The following element selects all .vb files on the D: drive: </para>
      <code>&lt;VBFile Include="D:/**/*.vb"/&gt;</code>
      <para>For more information about wildcard characters, see <link xlink:href="f5ff182f-7b3a-46fb-9335-37df54cfb8eb">How To: Build All Files in a Directory</link>.</para>
    </content>
  </section>
  <section address="BKMK_ExcludeAttribute">
    <title>Using the Exclude Attribute</title>
    <content>
      <para>Item elements can contain the <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference> attribute, which excludes specific items (files) from the item type. The <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference> attribute is typically used together with wildcard characters. For example, the following XML adds every .cs file in the directory to the CSFile item type, except the <codeInline>DoNotBuild.cs</codeInline> file.</para>
      <code>&lt;ItemGroup&gt;
    &lt;CSFile  Include="*.cs"  Exclude="DoNotBuild.cs"/&gt;
&lt;/ItemGroup&gt;</code>
      <para>The <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference> attribute affects only the items that are added by the <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> attribute in the item element that contains them both. The following example wouldn’t exclude the file Form1.cs, which was added in the preceding item element.</para>
      <code>&lt;Compile Include="*.cs" /&gt;
&lt;Compile Include="*.res" Exclude="Form1.cs"&gt;</code>
      <para>For more information, see <link xlink:href="1be36e45-01da-451c-972d-f9fc0e7d663c">How To: Build all Files in a Directory Except One</link>.</para>
    </content>
  </section>
  <section address="BKMK_ItemMetadata">
    <title>Item Metadata</title>
    <content>
      <para>Items may contain metadata in addition to the information in the <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> and <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference> attributes. This metadata can be used by tasks that require more information about the items or to batch tasks and targets. For more information, see <link xlink:href="d35c085b-27b8-49d7-b6f8-8f2f3a0eec38">MSBuild Batching</link>.</para>
      <para>Metadata is a collection of key-value pairs that are declared in the project file as child elements of an item element. The name of the child element is the name of the metadata, and the value of the child element is the value of the metadata. </para>
      <para>The metadata is associated with the item element that contains it. For example, the following XML adds <codeInline>Culture</codeInline> metadata that has the value <codeInline>Fr</codeInline> to both the "one.cs" and the "two.cs" items of the CSFile item type.</para>
      <code>&lt;ItemGroup&gt;
    &lt;CSFile Include="one.cs;two.cs"&gt;
        &lt;Culture&gt;Fr&lt;/Culture&gt;
    &lt;/CSFile&gt;
&lt;/ItemGroup&gt;</code>
      <para>An item can have zero or more metadata values. You can change metadata values at any time. If you set metadata to an empty value, you effectively remove it from the build.</para>
    </content>
    <sections>
      <section address="BKMK_ReferencingItemMetadata">
        <title>Referencing Item Metadata in a Project File</title>
        <content>
          <para>You can reference item metadata throughout the project file by using the syntax %(<parameterReference>ItemMetadataName</parameterReference>). If ambiguity exists, you can qualify a reference by using the name of the item type. For example, you can specify %(<placeholder>ItemType.ItemMetaDataName</placeholder>).The following example uses the Display metadata to batch the Message task. For more information about how to use item metadata for batching, see <link xlink:href="31e480f8-fe4d-4633-8c54-8ec498e2306d">How To: Batch Targets and Tasks with Item Metadata</link>.</para>
          <code>&lt;Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;
    &lt;ItemGroup&gt;
        &lt;Stuff Include="One.cs" &gt;
            &lt;Display&gt;false&lt;/Display&gt;
        &lt;/Stuff&gt;
        &lt;Stuff Include="Two.cs"&gt;
            &lt;Display&gt;true&lt;/Display&gt;
        &lt;/Stuff&gt;
    &lt;/ItemGroup&gt;
    &lt;Target Name="Batching"&gt;
        &lt;Message Text="@(Stuff)" Condition=" '%(Display)' == 'true' "/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
        </content>
      </section>
      <section address="BKMK_WellKnownItemMetadata">
        <title>Well-known Item Metadata</title>
        <content>
          <para>When an item is added to an item type, that item is assigned some well-known metadata. For example, all items have the well-known metadata <codeInline>%(Filename)</codeInline>, whose value is the file name of the item. For more information, see <link xlink:href="b5e791b5-c68f-4978-ad8a-9247d03bb6c0">MSBuild Well-known Item Metadata</link>.</para>
        </content>
      </section>
      <section address="BKMK_Transforming">
        <title>Transforming Item Types By Using Metadata</title>
        <content>
          <para>You can transform item lists into new item lists by using metadata. For example, you can transform an item type <codeInline>CppFiles</codeInline> that has items that represent .cpp files into a corresponding list of .obj files by using the expression <codeInline>@(CppFiles -&gt; '%(Filename).obj')</codeInline>. </para>
          <para>The following code creates a <codeInline>CultureResource</codeInline> item type that contains copies of all <codeInline>EmbeddedResource</codeInline> items with <codeInline>Culture</codeInline> metadata. The <codeInline>Culture</codeInline> metadata value becomes the value of the new metadata <codeInline>CultureResource.TargetDirectory</codeInline>.</para>
          <code>&lt;Target Name="ProcessCultureResources"&gt;
    &lt;ItemGroup&gt;
        &lt;CultureResource Include="@(EmbeddedResource)"
            Condition="'%(EmbeddedResource.Culture)' != ''"&gt;
            &lt;TargetDirectory&gt;%(EmbeddedResource.Culture) &lt;/TargetDirectory&gt;
        &lt;/CultureResource&gt;
    &lt;/ItemGroup&gt;
&lt;/Target&gt;</code>
          <para>For more information, see <link xlink:href="d0bcfc3c-14fa-455e-805c-63ccffa4a3bf">MSBuild Transforms</link>.</para>
        </content>
      </section>
    </sections>
  </section>
  <section address="BKMK_ItemDefinitions">
    <title>Item Definitions</title>
    <content>
      <para>Starting in the .NET Framework 3.5, you can add default metadata to any item type by using the <legacyLink xlink:href="4e9fb04b-5148-4ae5-a394-42861dd62371">ItemDefinitionGroup element</legacyLink>. Like well-known metadata, the default metadata is associated with all items of the item type that you specify. You can explicitly override default metadata in an item definition. For example, the following XML gives the <codeInline>Compile</codeInline> items "one.cs" and "three.cs" the metadata <codeInline>BuildDay</codeInline> with the value "Monday". The code gives the item "two.cs" the metadata <codeInline>BuildDay</codeInline> with the value "Tuesday".</para>
      <code>&lt;ItemDefinitionGroup&gt;
    &lt;Compile&gt;
        &lt;BuildDay&gt;Monday&lt;/BuildDay&gt;
    &lt;/Compile&gt;
&lt;/ItemDefinitionGroup&gt;
&lt;ItemGroup&gt;
    &lt;Compile Include="one.cs;three.cs" /&gt;
    &lt;Compile Include="two.cs"&gt;
        &lt;BuildDay&gt;Tuesday&lt;/BuildDay&gt;
    &lt;/Compile&gt;
&lt;/ItemGroup&gt;</code>
      <para>For more information, see <link xlink:href="8e3dc223-f9e5-4974-aa0e-5dc7967419cb">Item Definitions</link>.</para>
    </content>
  </section>
  <section address="BKMK_AttributesWithinTargets">
    <title>Attributes for Items in an ItemGroup of a Target</title>
    <content>
      <para>Starting in the .NET Framework 3.5, <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> elements may contain <legacyLink xlink:href="aac894e3-a9f1-4bbc-a796-6ef07001f35b">ItemGroup</legacyLink> elements that may contain item elements. The attributes in this section are valid when they are specified for an item in an <languageKeyword>ItemGroup</languageKeyword> that's in a <languageKeyword>Target</languageKeyword>.</para>
    </content>
    <sections>
      <section address="BKMK_RemoveAttribute">
        <title>Remove Attribute</title>
        <content>
          <para>Items in an <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> of a target may contain the <unmanagedCodeEntityReference>Remove</unmanagedCodeEntityReference> attribute, which removes specific items (files) from the item type. This attribute was introduced in the .NET Framework 3.5.</para>
          <para>The following example removes every .config file from the Compile item type.</para>
          <code>&lt;Target&gt;
    &lt;ItemGroup&gt;
        &lt;Compile Remove="*.config"/&gt;
    &lt;/ItemGroup&gt;
&lt;/Target&gt;</code>
        </content>
      </section>
      <section address="BKMK_KeepMetadata">
        <title>KeepMetadata Attribute</title>
        <content>
          <para>If an item is generated within a target, the item element can contain the <languageKeyword>KeepMetadata</languageKeyword> attribute. If this attribute is specified, only the metadata that is specified in the semicolon-delimited list of names will be transferred from the source item to the target item. An empty value for this attribute is equivalent to not specifying it. The <languageKeyword>KeepMetadata</languageKeyword> attribute was introduced in the .NET Framework 4.5.</para>
          <para>The following example illustrates how to use the <languageKeyword>KeepMetadata</languageKeyword> attribute.</para>
          <code>&lt;Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"
ToolsVersion="4.0"&gt;

    &lt;ItemGroup&gt;
        &lt;FirstItem Include="rhinoceros"&gt;
            &lt;Class&gt;mammal&lt;/Class&gt;
            &lt;Size&gt;large&lt;/Size&gt;
        &lt;/FirstItem&gt;

    &lt;/ItemGroup&gt;
    &lt;Target Name="MyTarget"&gt;
        &lt;ItemGroup&gt;
            &lt;SecondItem Include="@(FirstItem)" KeepMetadata="Class" /&gt;
        &lt;/ItemGroup&gt;

        &lt;Message Text="FirstItem: %(FirstItem.Identity)" /&gt;
        &lt;Message Text="  Class: %(FirstItem.Class)" /&gt;
        &lt;Message Text="  Size:  %(FirstItem.Size)"  /&gt;

        &lt;Message Text="SecondItem: %(SecondItem.Identity)" /&gt;
        &lt;Message Text="  Class: %(SecondItem.Class)" /&gt;
        &lt;Message Text="  Size:  %(SecondItem.Size)"  /&gt;
    &lt;/Target&gt;
&lt;/Project&gt;

&lt;!--
Output:
  FirstItem: rhinoceros
    Class: mammal
    Size:  large
  SecondItem: rhinoceros
    Class: mammal
    Size: 
--&gt;</code>
        </content>
      </section>
      <section address="BKMK_RemoveMetadata">
        <title>RemoveMetadata Attribute</title>
        <content>
          <para>If an item is generated within a target, the item element can contain the <languageKeyword>RemoveMetadata</languageKeyword> attribute. If this attribute is specified, all metadata is transferred from the source item to the target item except metadata whose names are contained in the semicolon-delimited list of names. An empty value for this attribute is equivalent to not specifying it. The <languageKeyword>RemoveMetadata</languageKeyword> attribute was introduced in the .NET Framework 4.5.</para>
          <para>The following example illustrates how to use the <languageKeyword>RemoveMetadata</languageKeyword> attribute.</para>
          <code>&lt;Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;

    &lt;PropertyGroup&gt;
        &lt;MetadataToRemove&gt;Size;Material&lt;/MetadataToRemove&gt;
    &lt;/PropertyGroup&gt;

    &lt;ItemGroup&gt;
        &lt;Item1 Include="stapler"&gt;
            &lt;Size&gt;medium&lt;/Size&gt;
            &lt;Color&gt;black&lt;/Color&gt;
            &lt;Material&gt;plastic&lt;/Material&gt;
        &lt;/Item1&gt;
    &lt;/ItemGroup&gt;

    &lt;Target Name="MyTarget"&gt;
        &lt;ItemGroup&gt;
            &lt;Item2 Include="@(Item1)" RemoveMetadata="$(MetadataToRemove)" /&gt;
        &lt;/ItemGroup&gt;

        &lt;Message Text="Item1: %(Item1.Identity)" /&gt;
        &lt;Message Text="  Size:     %(Item1.Size)" /&gt;
        &lt;Message Text="  Color:    %(Item1.Color)" /&gt;
        &lt;Message Text="  Material: %(Item1.Material)" /&gt;
        &lt;Message Text="Item2: %(Item2.Identity)" /&gt;
        &lt;Message Text="  Size:     %(Item2.Size)" /&gt;
        &lt;Message Text="  Color:    %(Item2.Color)" /&gt;
        &lt;Message Text="  Material: %(Item2.Material)" /&gt;
    &lt;/Target&gt;
&lt;/Project&gt;

&lt;!--
Output: 
  Item1: stapler
    Size:     medium
    Color:    black
    Material: plastic
  Item2: stapler
    Size:     
    Color:    black
    Material: 
--&gt;</code>
        </content>
      </section>
      <section address="BKMK_KeepDuplicates">
        <title>KeepDuplicates Attribute</title>
        <content>
          <para>If an item is generated within a target, the item element can contain the <languageKeyword>KeepDuplicates</languageKeyword> attribute. <languageKeyword>KeepDuplicates</languageKeyword> is a <languageKeyword>Boolean</languageKeyword> attribute that specifies whether an item should be added to the target group if the item is an exact duplicate of an existing item.</para>
          <para>If the source and target item have the same Include value but different metadata, the item is added even if <languageKeyword>KeepDuplicates</languageKeyword> is set to <languageKeyword>false</languageKeyword>. An empty value for this attribute is equivalent to not specifying it. The <languageKeyword>KeepDuplicates</languageKeyword> attribute was introduced in the .NET Framework 4.5.</para>
          <para>The following example illustrates how to use the <languageKeyword>KeepDuplicates</languageKeyword> attribute.</para>
          <code>&lt;Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;

    &lt;ItemGroup&gt;
        &lt;Item1 Include="hourglass;boomerang" /&gt;
        &lt;Item2 Include="hourglass;boomerang" /&gt;
    &lt;/ItemGroup&gt;

    &lt;Target Name="MyTarget"&gt;
        &lt;ItemGroup&gt;
            &lt;Item1 Include="hourglass" KeepDuplicates="false" /&gt;
            &lt;Item2 Include="hourglass" /&gt;
        &lt;/ItemGroup&gt;

        &lt;Message Text="Item1: @(Item1)" /&gt;
        &lt;Message Text="  %(Item1.Identity)  Count: @(Item1-&gt;Count())" /&gt;
        &lt;Message Text="Item2: @(Item2)" /&gt;
        &lt;Message Text="  %(Item2.Identity)  Count: @(Item2-&gt;Count())" /&gt;
    &lt;/Target&gt;
&lt;/Project&gt;

&lt;!--
Output: 
  Item1: hourglass;boomerang
    hourglass  Count: 1
    boomerang  Count: 1
  Item2: hourglass;boomerang;hourglass
    hourglass  Count: 2
    boomerang  Count: 1
--&gt;</code>
        </content>
      </section>
    </sections>
  </section>
  <relatedTopics>
    <link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="f5ff182f-7b3a-46fb-9335-37df54cfb8eb">How To: Select the Files to Build</link>
<link xlink:href="1be36e45-01da-451c-972d-f9fc0e7d663c">How To: Exclude Files from the Build</link>
<link xlink:href="3cae844c-7c6d-4144-82dc-efad10ba458f">How To: Display an Item List Separated with Commas</link>
<link xlink:href="8e3dc223-f9e5-4974-aa0e-5dc7967419cb">Item Definitions</link>
<link xlink:href="d35c085b-27b8-49d7-b6f8-8f2f3a0eec38">MSBuild Batching</link>
<link xlink:href="dcef5f91-0613-4bfc-8ee9-d7004bb6d3a9">Item Element (MSBuild)</link></relatedTopics>
</developerConceptualDocument>