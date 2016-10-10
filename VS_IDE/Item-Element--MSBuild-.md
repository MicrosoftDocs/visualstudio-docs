---
title: "Item Element (MSBuild)"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dcef5f91-0613-4bfc-8ee9-d7004bb6d3a9
caps.latest.revision: 28
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
# Item Element (MSBuild)
<?xml version="1.0" encoding="utf-8"?>
<developerXmlReference xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Contains a user-defined item and its metadata. Every item that is used in a <token>vstecmsbuild</token> project must be specified as a child of an <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> element.</para>
  </introduction>
  <schemaHierarchy>
    <link xlink:href="">&lt;Project&gt;</link>
    <link xlink:href="">    &lt;ItemGroup&gt;</link>
    <link xlink:href="">        &lt;Item&gt;</link>
  </schemaHierarchy>
  <syntaxSection>
    <legacySyntax>&lt;<parameterReference>Item</parameterReference> Include="*.cs"
        Exclude="MyFile.cs"
        Remove="RemoveFile.cs"
        Condition="'String A'=='String B'" &gt;
    &lt;<parameterReference>ItemMetadata1</parameterReference>&gt;...&lt;/<parameterReference>ItemMetadata1</parameterReference>&gt;
    &lt;<parameterReference>ItemMetadata2</parameterReference>&gt;...&lt;/<parameterReference>ItemMetadata2</parameterReference>&gt;
&lt;/<parameterReference>Item</parameterReference>&gt;</legacySyntax>
  </syntaxSection>
  <attributesandElements>
    <para>The following sections describe attributes, child elements, and parent elements.</para>
    <attributes>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Attribute</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Required attribute.</para>
              <para>The file or wildcard to include in the list of items.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>The file or wildcard to exclude from the list of items.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>The condition to be evaluated. For more information, see <link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>Remove</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>The file or wildcard to remove from the list of items. </para>
              <para>This attribute is valid only if it's specified for an item in an <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> that's in a <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference>.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>KeepMetadata</unmanagedCodeEntityReference> </para>
            </TD>
            <TD>
              <para>Optional attribute. </para>
              <para>The metadata for the source items to add to the target items. Only the metadata whose names are specified in the semicolon-delimited list are transferred from a source item to a target item. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
              <para>This attribute is valid only if it's specified for an item in an <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> that's in a <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference>.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>RemoveMetadata</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>The metadata for the source items to not transfer to the target items. All metadata is transferred from a source item to a target item except metadata whose names are contained in the semicolon-delimited list of names. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
              <para>This attribute is valid only if it's specified for an item in an <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> that's in a <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference>.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>KeepDuplicates</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>Specifies whether an item should be added to the target group if it's an exact duplicate of an existing item. If the source and target item have the same <languageKeyword>Include</languageKeyword> value but different metadata, the item is added even if <languageKeyword>KeepDuplicates</languageKeyword> is set to <languageKeyword>false</languageKeyword>. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
              <para>This attribute is valid only if it's specified for an item in an <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> that's in a <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference>.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </attributes>
    <childElement>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Element</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="e3db5122-202d-43a9-b2f4-3e0ec4ed3d08">ItemMetadata</legacyLink>
              </para>
            </TD>
            <TD>
              <para>A user-defined item metadata key, which contains the item metadata value. There may be zero or more <unmanagedCodeEntityReference>ItemMetadata</unmanagedCodeEntityReference> elements in an item.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </childElement>
    <parentElement>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Element</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="aac894e3-a9f1-4bbc-a796-6ef07001f35b">ItemGroup</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Grouping element for items.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </parentElement>
  </attributesandElements>
  <remarks>
    <content>
      <para>
        <unmanagedCodeEntityReference>Item</unmanagedCodeEntityReference> elements define inputs into the build system, and are grouped into item collections based on their user-defined collection names. These item collections can be used as parameters for <legacyLink xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">tasks</legacyLink>, which use the individual items in the collections to perform the steps of the build process. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
      <para>Using the notation <codeInline>@(</codeInline><placeholder>myType</placeholder><codeInline>)</codeInline> enables a collection of items of type <placeholder>myType</placeholder> to be expanded into a semicolon-delimited list of strings, and passed to a parameter. If the parameter is of type <unmanagedCodeEntityReference>string</unmanagedCodeEntityReference>, then the value of the parameter is the list of elements, separated by semicolons. If the parameter is an array of strings (<unmanagedCodeEntityReference>string[]</unmanagedCodeEntityReference>), then each element is inserted into the array based on the location of the semicolons. If the task parameter is of type <codeEntityReference autoUpgrade="true">T:Microsoft.Build.Framework.ITaskItem</codeEntityReference><unmanagedCodeEntityReference>[]</unmanagedCodeEntityReference>, then the value is the contents of the item collection together with any metadata attached. To delimit each item by using a character other than a semicolon, use the syntax <codeInline>@(</codeInline><placeholder>myType</placeholder><codeInline>, '</codeInline><placeholder>separator</placeholder><codeInline>')</codeInline>.</para>
      <para>The <token>vstecmsbuild</token> engine can evaluate wildcards such as <codeInline>*</codeInline> and <codeInline>?</codeInline> and recursive wildcards such as <codeInline>/**/*.cs</codeInline>. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
    </content>
  </remarks>
  <codeExample>
    <description>
      <content>
        <para>The following code example shows how to declare two items of type <codeInline>CSFile</codeInline>. The second declared item contains metadata that has <codeInline>MyMetadata</codeInline> set to <codeInline>HelloWorld</codeInline>.</para>
      </content>
    </description>
    <code>&lt;ItemGroup&gt;
    &lt;CSFile Include="engine.cs; form.cs" /&gt;
    &lt;CSFile Include="main.cs" &gt;
        &lt;MyMetadata&gt;HelloWorld&lt;/MyMetadata&gt;
    &lt;/CSFile&gt;
&lt;/ItemGroup&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
<link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>
<link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>
<link xlink:href="d9a68146-1f43-4621-ac78-2c8c3f400936">MSBuild Project File Schema Reference</link>
</relatedTopics>
</developerXmlReference>