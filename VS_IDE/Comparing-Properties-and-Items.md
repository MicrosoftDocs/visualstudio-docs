---
title: "Comparing Properties and Items"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b9da45ae-d6a6-4399-8628-397deed31486
caps.latest.revision: 13
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
# Comparing Properties and Items
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>MSBuild properties and items are both used to pass information to tasks, evaluate conditions, and store values that can be referenced throughout the project file.</para>
    <list class="bullet">
      <listItem>
        <para>Properties are name-value pairs. For more information, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
      </listItem>
      <listItem>
        <para>Items are objects that typically represent files. Item objects can have associated metadata collections. Metadata are name-value pairs. For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
      </listItem>
    </list>
  </introduction>
  <section>
    <title>Scalars and Vectors</title>
    <content>
      <para>Because MSBuild properties are name-value pairs that have just one string value, they are often described as <newTerm>scalar</newTerm>. Because MSBuild item types are lists of items, they are often described as <newTerm>vector</newTerm>. However, in practice, properties can represent multiple values, and item types can have zero or one items. </para>
    </content>
    <sections>
      <section>
        <title>Target Dependency Injection</title>
        <content>
          <para>To see how properties can represent multiple values, consider a common usage pattern for adding a target to a list of targets to be built. This list is typically represented by a property value, with the target names separated by semicolons.</para>
          <code>&lt;PropertyGroup&gt;
    &lt;BuildDependsOn&gt;
        BeforeBuild;
        CoreBuild;
        AfterBuild
    &lt;/BuildDependsOn&gt;
&lt;/PropertyGroup&gt;</code>
          <para>The <languageKeyword>BuildDependsOn</languageKeyword> property is typically used as the argument of a target <languageKeyword>DependsOnTargets</languageKeyword> attribute, effectively converting it to an item list. This property can be overridden to add a target or to change the target execution order. For example,</para>
          <code>&lt;PropertyGroup&gt;
    &lt;BuildDependsOn&gt;
        $(BuildDependsOn);
        CustomBuild;
    &lt;/BuildDependsOn&gt;
&lt;/PropertyGroup&gt;</code>
          <para>adds the CustomBuild target to the target list, giving <languageKeyword>BuildDependsOn</languageKeyword> the value <userInput>BeforeBuild;CoreBuild;AfterBuild;CustomBuild</userInput>.</para>
          <para>Starting with MSBuild 4.0, target dependency injection is deprecated. Use the <languageKeyword>AfterTargets</languageKeyword> and <languageKeyword>BeforeTargets</languageKeyword> attributes instead. For more information, see <link xlink:href="f4a26339-9f9a-497a-9aa6-0797183d450d">Target Build Order</link>.</para>
        </content>
      </section>
      <section>
        <title>Conversions between Strings and Item Lists</title>
        <content>
          <para>MSBuild performs conversions to and from item types and string values as needed. To see how an item list can become a string value, consider what happens when an item type is used as the value of an MSBuild property:</para>
          <code>&lt;ItemGroup&gt;
    &lt;OutputDir Include="KeyFiles\;Certificates\" /&gt;
  &lt;/ItemGroup&gt;
&lt;PropertyGroup&gt;
    &lt;OutputDirList&gt;@(OutputDir)&lt;/OutputDirList&gt;
&lt;/PropertyGroup&gt;</code>
          <para>The item type OutputDir has an <languageKeyword>Include</languageKeyword> attribute with the value "KeyFiles\;Certificates\". MSBuild parses this string into two items: KeyFiles\ and Certificates\. When the item type OutputDir is used as the value of the OutputDirList property, MSBuild converts or "flattens" the item type into to the semicolon-separated string "KeyFiles\;Certificates\".</para>
        </content>
      </section>
    </sections>
  </section>
  <section>
    <title>Properties and Items in Tasks</title>
    <content>
      <para>Properties and items are used as inputs and outputs to MSBuild tasks. For more information, see <link xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">MSBuild Tasks</link>. </para>
      <para>Properties are passed to tasks as attributes. Within the task, an MSBuild property is represented by a property type whose value can be converted to and from a string. The supported property types include <unmanagedCodeEntityReference>bool</unmanagedCodeEntityReference>, <unmanagedCodeEntityReference>char</unmanagedCodeEntityReference>, <unmanagedCodeEntityReference>DateTime</unmanagedCodeEntityReference>, <unmanagedCodeEntityReference>Decimal</unmanagedCodeEntityReference>, <unmanagedCodeEntityReference>Double</unmanagedCodeEntityReference>, <unmanagedCodeEntityReference>int</unmanagedCodeEntityReference>, <unmanagedCodeEntityReference>string</unmanagedCodeEntityReference>, and any type that <codeEntityReference autoUpgrade="true">M:System.Convert.ChangeType(System.Object,System.Type)</codeEntityReference> can handle.</para>
      <para>Items are passed to tasks as <codeEntityReference autoUpgrade="true">T:Microsoft.Build.Framework.ITaskItem</codeEntityReference> objects. Within the task, <codeEntityReference autoUpgrade="true">P:Microsoft.Build.Framework.ITaskItem.ItemSpec</codeEntityReference> represents the value of the item and <codeEntityReference autoUpgrade="true">M:Microsoft.Build.Framework.ITaskItem.GetMetadata(System.String)</codeEntityReference> retrieves its metadata.</para>
      <para>The item list of an item type can be passed as an array of <unmanagedCodeEntityReference>ITaskItem</unmanagedCodeEntityReference> objects. Beginning with the .NET Framework 3.5, items can be removed from an item list in a target by using the <languageKeyword>Remove</languageKeyword> attribute. Because items can be removed from an item list, it is possible for an item type to have zero items. If an item list is passed to a task, the code in the task should check for this possibility.</para>
    </content>
  </section>
  <section>
    <title>Property and Item Evaluation Order</title>
    <content>
      <para>During the evaluation phase of a build, imported files are incorporated into the build in the order in which they appear. Properties and items are defined in three passes in the following order:</para>
      <list class="bullet">
        <listItem>
          <para>Properties are defined and modified in the order in which they appear.</para>
        </listItem>
        <listItem>
          <para>Item definitions are defined and modified in the order in which they appear.</para>
        </listItem>
        <listItem>
          <para>Items are defined and modified in the order in which they appear.</para>
        </listItem>
      </list>
      <para>During the execution phase of a build, properties and items that are defined within targets are evaluated together in a single phase in the order in which they appear.</para>
      <para>However, this is not the full story. When a property, item definition, or item is defined, its value is evaluated. The expression evaluator expands the string that specifies the value. The string expansion is dependent on the build phase. Here is a more detailed property and item evaluation order:</para>
      <list class="bullet">
        <listItem>
          <para>During the evaluation phase of a build:</para>
          <list class="bullet">
            <listItem>
              <para>Properties are defined and modified in the order in which they appear. Property functions are executed. Property values in the form $(PropertyName) are expanded within expressions. The property value is set to the expanded expression.</para>
            </listItem>
            <listItem>
              <para>Item definitions are defined and modified in the order in which they appear. Property functions have already been expanded within expressions. Metadata values are set to the expanded expressions.</para>
            </listItem>
            <listItem>
              <para>Item types are defined and modified in the order in which they appear. Item values in the form @(ItemType) are expanded. Item transformations are also expanded. Property functions and values have already been expanded within expressions. The item list and metadata values are set to the expanded expressions.</para>
            </listItem>
          </list>
        </listItem>
        <listItem>
          <para>During the execution phase of a build:</para>
          <list class="bullet">
            <listItem>
              <para>Properties and items that are defined within targets are evaluated together in the order in which they appear. Property functions are executed and property values are expanded within expressions. Item values and item transformations are also expanded. The property values, item type values, and metadata values are set to the expanded expressions.</para>
            </listItem>
          </list>
        </listItem>
      </list>
    </content>
    <sections>
      <section>
        <title>Subtle Effects of the Evaluation Order</title>
        <content>
          <para>In the evaluation phase of a build, property evaluation precedes item evaluation. Nevertheless, properties can have values that appear to depend on item values. Consider the following script.</para>
          <code>&lt;ItemGroup&gt;
    &lt;KeyFile Include="KeyFile.cs"&gt;
        &lt;Version&gt;1.0.0.3&lt;/Version&gt;
    &lt;/KeyFile&gt;
&lt;/ItemGroup&gt;
&lt;PropertyGroup&gt;
    &lt;KeyFileVersion&gt;@(KeyFile-&gt;'%(Version)')&lt;/KeyFileVersion&gt;
&lt;/PropertyGroup&gt;
&lt;Target Name="AfterBuild"&gt;
    &lt;Message Text="KeyFileVersion: $(KeyFileVersion)" /&gt;
&lt;/Target&gt;</code>
          <para>Executing the Message task displays this message:</para>
          <code>KeyFileVersion: 1.0.0.3</code>
          <para>This is because the value of <languageKeyword>KeyFileVersion</languageKeyword> is actually the string "@(KeyFile-&gt;'%(Version)')". Item and item transformations were not expanded when the property was first defined, so the <languageKeyword>KeyFileVersion</languageKeyword> property was assigned the value of the unexpanded string. </para>
          <para>During the execution phase of the build, when it processes the Message task, MSBuild expands the string "@(KeyFile-&gt;'%(Version)')" to yield "1.0.0.3".</para>
          <para>Notice that the same message would appear even if the property and item groups were reversed in order.</para>
          <para>As a second example, consider what can happen when property and item groups are located within targets:</para>
          <code>&lt;Target Name="AfterBuild"&gt;
    &lt;PropertyGroup&gt;
        &lt;KeyFileVersion&gt;@(KeyFile-&gt;'%(Version)')&lt;/KeyFileVersion&gt;
    &lt;/PropertyGroup&gt;
    &lt;ItemGroup&gt;
        &lt;KeyFile Include="KeyFile.cs"&gt;
            &lt;Version&gt;1.0.0.3&lt;/Version&gt;
        &lt;/KeyFile&gt;
    &lt;/ItemGroup&gt;
    &lt;Message Text="KeyFileVersion: $(KeyFileVersion)" /&gt;
&lt;/Target&gt;</code>
          <para>The Message task displays this message:</para>
          <code>KeyFileVersion: </code>
          <para>This is because during the execution phase of the build, property and item groups defined within targets are evaluated top to bottom at the same time. When <languageKeyword>KeyFileVersion</languageKeyword> is defined, <languageKeyword>KeyFile</languageKeyword> is unknown. Therefore, the item transformation expands to an empty string.</para>
          <para>In this case, reversing the order of the property and item groups restores the original message:</para>
          <code>&lt;Target Name="AfterBuild"&gt;
    &lt;ItemGroup&gt;
        &lt;KeyFile Include="KeyFile.cs"&gt;
            &lt;Version&gt;1.0.0.3&lt;/Version&gt;
        &lt;/KeyFile&gt;
    &lt;/ItemGroup&gt;
    &lt;PropertyGroup&gt;
        &lt;KeyFileVersion&gt;@(KeyFile-&gt;'%(Version)')&lt;/KeyFileVersion&gt;
    &lt;/PropertyGroup&gt;
    &lt;Message Text="KeyFileVersion: $(KeyFileVersion)" /&gt;
&lt;/Target&gt;</code>
          <para>The value of <languageKeyword>KeyFileVersion</languageKeyword> is set to "1.0.0.3" and not to "@(KeyFile-&gt;'%(Version)')". The Message task displays this message:</para>
          <code>KeyFileVersion: 1.0.0.3</code>
        </content>
      </section>
    </sections>
  </section>
  <relatedTopics>
<link xlink:href="f34a558a-ebd9-49bd-8510-32a2b581a4af">MSBuild Advanced Concepts</link>
</relatedTopics>
</developerConceptualDocument>