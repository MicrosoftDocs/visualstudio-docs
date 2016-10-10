---
title: "Validate code with layer diagrams"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 70cbe55d-4b33-4355-b0a7-88c770a6f75c
caps.latest.revision: 80
manager: kamrani
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
# Validate code with layer diagrams
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://dduestorage.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>To make sure that code doesn't conflict with its design, validate your code with layer diagrams in Visual Studio. This can help you:</para>
    <list class="bullet">
      <listItem>
        <para>Find conflicts between dependencies in your code and dependencies on the layer diagram.</para>
      </listItem>
      <listItem>
        <para>Find dependencies that might be affected by proposed changes.</para>
        <para>For example, you can edit the layer diagram to show potential architecture changes and then validate the code to see the affected dependencies.</para>
      </listItem>
      <listItem>
        <para>Refactor or migrate code to a different design.</para>
        <para>Find code or dependencies that require work when you move the code to a different architecture.</para>
      </listItem>
    </list>
    <para>
      <embeddedLabel>Requirements</embeddedLabel>
    </para>
    <list class="bullet">
      <listItem>
        <para>Visual Studio</para>
      </listItem>
      <listItem>
        <para>Visual Studio on your Team Foundation Build server to validate code automatically with Team Foundation Build</para>
      </listItem>
      <listItem>
        <para>A solution that has a modeling project with a layer diagram. This layer diagram must be linked to artifacts in Visual C# .NET or Visual Basic .NET projects that you want to validate. See <link xlink:href="58c3ea71-2dbc-4963-bf82-40f1924cf973">How to: Create Layer Diagrams from Code</link>.</para>
      </listItem>
    </list>
    <para>To see which versions of Visual Studio support this feature, see <link xlink:href="36ab5c17-6dc0-4075-a28e-a0fa49b11260#VersionSupport">Version support for architecture and modeling tools</link>.</para>
    <para>You can validate code manually from an open layer diagram in Visual Studio or from a command prompt. You can also validate code automatically when running local builds or Team Foundation Build. See <externalLink><linkText>Channel 9 Video: Design and validate your architecture using layer diagrams</linkText><linkUri>http://go.microsoft.com/fwlink/?LinkID=252073</linkUri></externalLink>.</para>
    <alert class="important">
      <para>If you want to run layer validation with Team Foundation Build, you must also install the same version of Visual Studio on your build server.</para>
    </alert>
    <list class="bullet">
      <listItem>
        <para>
          <legacyLink xlink:href="#SupportsValidation">See if an item supports validation</legacyLink>
        </para>
      </listItem>
      <listItem>
        <para>
          <legacyLink xlink:href="#IncludeReferences">Include other .NET assemblies and projects for validation</legacyLink>
        </para>
      </listItem>
      <listItem>
        <para>
          <legacyLink xlink:href="#ValidateManually">Validate code manually</legacyLink>
        </para>
      </listItem>
      <listItem>
        <para>
          <legacyLink xlink:href="#ValidateAuto">Validate code automatically</legacyLink>
        </para>
      </listItem>
      <listItem>
        <para>
          <legacyLink xlink:href="#TroubleshootingValidation">Troubleshoot layer validation issues</legacyLink>
        </para>
      </listItem>
      <listItem>
        <para>
          <legacyLink xlink:href="#UnderstandingValidationErrors">Understand and resolve layer validation errors</legacyLink>
        </para>
      </listItem>
    </list>
  </introduction>
  <section address="SupportsValidation" DoNotNumber="false">
    <title>See if an item supports validation</title>
    <content>
      <para>You can link layers to Web sites, Office documents, plain text files, and files in projects that are shared across multiple apps, but the validation process won't include them. Validation errors won't appear for references to projects or assemblies that are linked to separate layers when no dependencies appear between those layers. Such references are not considered dependencies unless the code uses those references.</para>
      <procedure>
        <title/>
        <steps class="ordered">
          <step>
            <content>
              <para>On the layer diagram, select one or more layers, right-click your selection, and then click <ui>View Links</ui>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>In <ui>Layer Explorer</ui>, look at the <ui>Supports Validation</ui> column. If the value is false, the item does not support validation.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section address="IncludeReferences">
    <title>Include other .NET assemblies and projects for validation</title>
    <content>
      <para>When you drag items to the layer diagram, references to the corresponding .NET assemblies or projects are added automatically to the <ui>Layer References</ui> folder in the modeling project. This folder contains references to the assemblies and projects that are analyzed during validation. You can include other .NET assemblies and projects for validation without manually dragging them to the layer diagram. </para>
      <procedure>
        <title/>
        <steps class="ordered">
          <step>
            <content>
              <para>In <ui>Solution Explorer</ui>, right-click the modeling project or the <ui>Layer References</ui> folder, and then click <ui>Add Reference</ui>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>In the <ui>Add Reference</ui> dialog box, select the assemblies or projects, and then click <ui>OK</ui>.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section address="ValidateManually">
    <title>Validate code manually</title>
    <content>
      <para>If you have an open layer diagram that is linked to solution items, you can run the <ui>Validate</ui> shortcut command from the diagram. You can also use the command prompt to run the <system>msbuild</system> command with the <system>/p:ValidateArchitecture</system> custom property set to <system>True</system>. For example, as you make changes in the code, perform layer validation regularly so that you can catch dependency conflicts early.</para>
      <procedure>
        <title>To validate code from an open layer diagram</title>
        <steps class="ordered">
          <step>
            <content>
              <para>Right-click the diagram surface, and then click <ui>Validate Architecture</ui>.</para>
              <alert class="note">
                <para>By default, the <ui>Build Action</ui> property on the layer diagram (.layerdiagram) file is set to <ui>Validate</ui> so that the diagram is included in the validation process.</para>
              </alert>
              <para>The <ui>Error List</ui> window reports any errors that occur. For more information about validation errors, see <legacyLink xlink:href="#UnderstandingValidationErrors">Understand and resolve layer validation errors</legacyLink>. </para>
            </content>
          </step>
          <step>
            <content>
              <para>To view the source of each error, double-click the error in the <ui>Error List</ui> window.</para>
              <alert class="note">
                <para>
                  <token>vsprvs</token> might show a code map instead of the source of the error. This occurs when either the code has a dependency on an assembly that is not specified by the layer diagram, or the code is missing a dependency that is specified by the layer diagram. Review the code map or the code to determine whether the dependency should exist. For more information about code maps, see <link xlink:href="e04850a2-17c5-459b-93ec-6c74143b3292">Map dependencies across your code</link>.</para>
              </alert>
            </content>
          </step>
          <step>
            <content>
              <para>To manage errors, see <legacyLink xlink:href="#ManageErrors">Manage validation errors</legacyLink>.</para>
            </content>
          </step>
        </steps>
      </procedure>
      <procedure>
        <title>To validate code at the command prompt</title>
        <steps class="ordered">
          <step>
            <content>
              <para>Open the <token>vsprvs</token> command prompt.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Choose one of the following:</para>
              <list class="bullet">
                <listItem>
                  <para>To validate code against a specific modeling project in the solution, run <token>vstecmsbuild</token> with the following custom property.</para>
                  <code>msbuild &lt;<placeholder>FilePath+ModelProjectFileName</placeholder>&gt;.modelproj /p:ValidateArchitecture=true</code>
                  <para>- or -</para>
                  <para>Browse to the folder that contains the modeling project (.modelproj) file and the layer diagram and then run <token>vstecmsbuild</token> with the following custom property:</para>
                  <code>msbuild /p:ValidateArchitecture=true </code>
                </listItem>
                <listItem>
                  <para>To validate code against all modeling projects in the solution, run <token>vstecmsbuild</token> with the following custom property:</para>
                  <code>msbuild &lt;<placeholder>FilePath+SolutionName</placeholder>&gt;.sln /p:ValidateArchitecture=true </code>
                  <para>- or -</para>
                  <para>Browse to the solution folder, which must contain a modeling project that contains a layer diagram, and then run <token>vstecmsbuild</token> with the following custom property:</para>
                  <code>msbuild /p:ValidateArchitecture=true</code>
                </listItem>
              </list>
              <para>Any errors that occur will be listed. For more information about <token>vstecmsbuild</token>, see MSBuild and <link xlink:href="76577f6c-7669-44ad-a840-363e37a04d34">MSBuild Task</link>. </para>
            </content>
          </step>
        </steps>
        <conclusion>
          <content>
            <para>For more information about validation errors, see <legacyLink xlink:href="#UnderstandingValidationErrors">Understand and resolve layer validation errors</legacyLink>.</para>
          </content>
        </conclusion>
      </procedure>
    </content>
    <sections>
      <section address="ManageErrors">
        <title>Manage validation errors</title>
        <content>
          <para>During the development process, you might want to suppress some of the reported conflicts during validation. For example, you might want to suppress errors that you are already addressing or that are not relevant to your particular scenario. When you suppress an error, it is a good practice to log a work item in <token>esprfound</token>. </para>
          <alert class="warning">
            <para>You must already be connected to TFS Source Code Control (SCC) to create or link to a work item. If you try to open a connection to a different TFS SCC, Visual Studio closes the current solution automatically. Ensure that you are already connected to the appropriate SCC before attempting to create or link to a work item. In later releases of Visual Studio, the menu commands are not available if you are not connected to an SCC.</para>
          </alert>
          <procedure>
            <title>To create a work item for a validation error</title>
            <steps class="bullet">
              <step>
                <content>
                  <para>In the <ui>Error List</ui> window, right-click the error, point to <ui>Create Work Item</ui>, and then click the type of work item that you want to create.</para>
                </content>
              </step>
            </steps>
          </procedure>
          <para>Use these tasks to manage validation errors in the <ui>Error List</ui> window: </para>
          <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
            <thead>
              <tr>
                <TD>
                  <para>
                    <embeddedLabel>To</embeddedLabel>
                  </para>
                </TD>
                <TD>
                  <para>
                    <embeddedLabel>Follow these steps</embeddedLabel>
                  </para>
                </TD>
              </tr>
            </thead>
            <tbody>
              <tr>
                <TD>
                  <para>Suppress selected errors during validation</para>
                </TD>
                <TD>
                  <para>Right-click the one or multiple selected errors, point to <ui>Manage Validation Errors</ui>, and then click <ui>Suppress Errors</ui>.</para>
                  <para>The suppressed errors appear with strikethrough formatting. When you run validation the next time, these errors will not appear.</para>
                  <para>Suppressed errors are tracked in a .suppressions file for the corresponding layer diagram file.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>Stop suppressing selected errors</para>
                </TD>
                <TD>
                  <para>Right-click the selected suppressed error or errors, point to <ui>Manage Validation Errors</ui>, and then click <ui>Stop Suppressing Errors</ui>.</para>
                  <para>The selected suppressed errors will appear when you run validation the next time.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>Restore all suppressed errors in the <ui>Error List</ui> window</para>
                </TD>
                <TD>
                  <para>Right-click anywhere in the <ui>Error List</ui> window, point to <ui>Manage Validation Errors</ui>, and then click <ui>Show All Suppressed Errors</ui>.</para>
                </TD>
              </tr>
              <tr>
                <TD>
                  <para>Hide all suppressed errors from the <ui>Error List</ui> window</para>
                </TD>
                <TD>
                  <para>Right-click anywhere in the <ui>Error List</ui> window, point to <ui>Manage Validation Errors</ui>, and then click <ui>Hide All Suppressed Errors</ui>.</para>
                </TD>
              </tr>
            </tbody>
          </table>
        </content>
      </section>
    </sections>
  </section>
  <section address="ValidateAuto">
    <title>Validate code automatically</title>
    <content>
      <para>You can perform layer validation every time that you run a local build. If your team uses Team Foundation Build, you can perform layer validation with gated check-ins, which you can specify by creating a custom MSBuild task, and use build reports to collect validation errors. To create gated check-in builds, see <legacyLink xlink:href="9cfc8b9c-1023-40fd-8ab5-1b1bd9c172ec">Use a gated check-in build process to validate changes</legacyLink>.</para>
      <procedure>
        <title>To validate code automatically during a local build</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use a text editor to open the modeling project (.modelproj) file, and then include the following property:</para>
            </content>
          </step>
        </steps>
        <conclusion>
          <content>
            <code>&lt;ValidateArchitecture&gt;true&lt;/ValidateArchitecture&gt;</code>
            <para>- or -</para>
            <list class="ordered">
              <listItem>
                <para>In <ui>Solution Explorer</ui>, right-click the modeling project that contains the layer diagram or diagrams, and then click <ui>Properties</ui>.</para>
              </listItem>
              <listItem>
                <para>In the <ui>Properties</ui> window, set the modeling project's <ui>Validate Architecture</ui> property to <ui>True</ui>. </para>
                <para>This includes the modeling project in the validation process.</para>
              </listItem>
              <listItem>
                <para>In <ui>Solution Explorer</ui>, click the layer diagram (.layerdiagram) file that you want to use for validation.</para>
              </listItem>
              <listItem>
                <para>In the <ui>Properties</ui> window, make sure that the diagram's <ui>Build Action</ui> property is set to <ui>Validate</ui>.</para>
                <para>This includes the layer diagram in the validation process.</para>
              </listItem>
            </list>
            <para>To manage errors in the Error List window, see <legacyLink xlink:href="#ManageErrors">Manage Validation Errors</legacyLink>.</para>
          </content>
        </conclusion>
      </procedure>
      <procedure>
        <title>To validate code automatically during a Team Foundation Build </title>
        <steps class="ordered">
          <step>
            <content>
              <para>In <ui>Team Explorer</ui>, double-click the build definition, and then click <ui>Process</ui>. </para>
            </content>
          </step>
          <step>
            <content>
              <para>Under <ui>Build process parameters</ui>, expand <ui>Compilation</ui>, and type the following in the <ui>MSBuild Arguments</ui> parameter:</para>
              <para>
                <userInput>/p:ValidateArchitecture=true</userInput>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>For more information about validation errors, see <legacyLink xlink:href="#UnderstandingValidationErrors">Understand and resolve layer validation errors</legacyLink>. For more information about <token>esprbuild</token>, see:</para>
      <list class="bullet">
        <listItem>
          <para>
            <legacyLink xlink:href="a971b0f9-7c28-479d-a37b-8fd7e27ef692">Build the application</legacyLink>
          </para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="43930b12-c21b-4599-a980-2995e3d16e31">Use the Default Template for your build process</legacyLink>
          </para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="ee1a8259-1dd1-4a10-9563-66c5446ef41c">Modify a Legacy Build that is Based on UpgradeTemplate.xaml</legacyLink>
          </para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="b94c58f2-ae6f-4245-bedb-82cd114f6039">Customize your build process template</legacyLink>
          </para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="e51e3bad-2d1d-4b7b-bfcc-c43439c6c8ef">Monitor Progress of a Running Build</legacyLink>
          </para>
        </listItem>
      </list>
    </content>
  </section>
  <section address="TroubleshootingValidation">
    <title>Troubleshoot layer validation issues</title>
    <content>
      <para>The following table describes layer validation issues and their resolution. These issues differ from errors that result from conflicts between the code and the design. For more information about these errors, see <legacyLink xlink:href="#UnderstandingValidationErrors">Understand and resolve layer validation errors</legacyLink>.</para>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>
                <embeddedLabel>Issue</embeddedLabel>
              </para>
            </TD>
            <TD>
              <para>
                <embeddedLabel>Possible Cause</embeddedLabel>
              </para>
            </TD>
            <TD>
              <para>
                <embeddedLabel>Resolution</embeddedLabel>
              </para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>Validation errors do not occur as expected.</para>
            </TD>
            <TD>
              <para>Validation does not work on layer diagrams that are copied from other layer diagrams in Solution Explorer and that are in the same modeling project. Layer diagrams that are copied in this way contain the same references as the original layer diagram.</para>
            </TD>
            <TD>
              <para>Add a new layer diagram to the modeling project.</para><para>Copy the elements from the source layer diagram to the new diagram.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <section address="UnderstandingValidationErrors">
    <title>Understanding and Resolving Layer Validation Errors</title>
    <content>
      <para>When you validate code against a layer diagram, validation errors occur when the code conflicts with the design. For example, the following conditions might cause validation errors to occur:</para>
      <list class="bullet">
        <listItem>
          <para>An artifact is assigned to the wrong layer. In this case, move the artifact. </para>
        </listItem>
        <listItem>
          <para>An artifact, such as a class, uses another class in a way that conflicts with your architecture. In this case, refactor the code to remove the dependency. </para>
        </listItem>
      </list>
      <para>To resolve these errors, update the code until no more errors appear during validation. You can perform this task in an iterative manner. </para>
      <para>The following section describes the syntax that is used in these errors, explains the meaning of these errors, and suggests what you can do to resolve or manage them.</para>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>
                <embeddedLabel>Syntax</embeddedLabel>
              </para>
            </TD>
            <TD>
              <para>
                <embeddedLabel>Description</embeddedLabel>
              </para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <placeholder>ArtifactN</placeholder>(<placeholder>ArtifactTypeN</placeholder>)</para>
            </TD>
            <TD>
              <para>
                <placeholder>ArtifactN</placeholder> is an artifact that is associated with a layer on the layer diagram. </para>
              <para>
                <placeholder>ArtifactTypeN</placeholder> is the type of <placeholder>ArtifactN</placeholder>, such as a <ui>Class</ui> or <ui>Method</ui>, for example: </para>
              <para>MySolution.MyProject.MyClass.MyMethod(Method)</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <placeholder>NamespaceNameN</placeholder>
              </para>
            </TD>
            <TD>
              <para>The name of a namespace.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <placeholder>LayerNameN</placeholder>
              </para>
            </TD>
            <TD>
              <para>The name of a layer on the layer diagram.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <placeholder>DependencyType</placeholder>
              </para>
            </TD>
            <TD>
              <para>The type of dependency relationship between <placeholder>Artifact1</placeholder> and <placeholder>Artifact2</placeholder>. For example, <placeholder>Artifact1</placeholder> has a <ui>Calls</ui> relationship with <placeholder>Artifact2</placeholder>.</para>
            </TD>
          </tr>
        </tbody>
      </table>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>
                <embeddedLabel>Error Syntax</embeddedLabel>
              </para>
            </TD>
            <TD>
              <para>
                <embeddedLabel>Error Description</embeddedLabel>
              </para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>AV0001: Invalid Dependency: <placeholder>Artifact1</placeholder>(<placeholder>ArtifactType1</placeholder>) --&gt; <placeholder>Artifact2</placeholder>(<placeholder>ArtifactType2</placeholder>)</para>
              <para>   Layers: <placeholder>LayerName1</placeholder>, <placeholder>LayerName2</placeholder> | Dependencies: <placeholder>DependencyType</placeholder></para>
            </TD>
            <TD>
              <para>
                <placeholder>Artifact1</placeholder> in <placeholder>LayerName1</placeholder> should not have a dependency on <placeholder>Artifact2 </placeholder>in <placeholder>LayerName2</placeholder> because <placeholder>LayerName1</placeholder> does not have a direct dependency on <placeholder>LayerName2</placeholder>. </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>AV1001: Invalid Namespace: <placeholder>Artifact</placeholder></para>
              <para>   Layer: <placeholder>LayerName</placeholder> | Required Namespace: <placeholder>NamespaceName1</placeholder> | Current Namespace: <placeholder>NamespaceName2</placeholder></para>
            </TD>
            <TD>
              <para>
                <placeholder>LayerName</placeholder> requires that its associated artifacts must belong to <placeholder>NamespaceName1</placeholder>. <placeholder>Artifact</placeholder> is in <placeholder>NamespaceName2</placeholder>, not <placeholder>NamespaceName1</placeholder>. </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>AV1002: Depends on Forbidden Namespace: <placeholder>Artifact1</placeholder>(<placeholder>ArtifactType1</placeholder>) | <placeholder>Artifact2</placeholder>(<placeholder>ArtifactType2</placeholder>)</para>
              <para>   Layer: <placeholder>LayerName</placeholder> | Forbidden Namespace: <placeholder>NamespaceName</placeholder> | Dependencies: <placeholder>DependencyType</placeholder></para>
            </TD>
            <TD>
              <para>
                <placeholder>LayerName</placeholder> requires that its associated artifacts must not depend on <placeholder>NamespaceName</placeholder>. <placeholder>Artifact1</placeholder> cannot depend on <placeholder>Artifact2</placeholder> because <placeholder>Artifact2</placeholder> is in <placeholder>NamespaceName</placeholder>. </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>AV1003: In Forbidden Namespace: <placeholder>Artifact</placeholder>(<placeholder>ArtifactType</placeholder>)</para>
              <para>   Layer: <placeholder>LayerName</placeholder> | Forbidden Namespace: <placeholder>NamespaceName</placeholder></para>
            </TD>
            <TD>
              <para>
                <placeholder>LayerName</placeholder> requires that its associated artifacts cannot belong to <placeholder>NamespaceName</placeholder>. <placeholder>Artifact</placeholder> belongs to <placeholder>NamespaceName</placeholder>.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>AV3001: Missing Link: Layer '<placeholder>LayerName</placeholder>' links to '<placeholder>Artifact</placeholder>' which cannot be found. Are you missing an assembly reference?</para>
            </TD>
            <TD>
              <para>
                <placeholder>LayerName</placeholder> links to an artifact that cannot be found. For example, a link to a class might be missing because the modeling project is missing a reference to the assembly that contains the class.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>AV9001: Architectural analysis found internal errors. Results might not be complete. For more information, see the detailed build event log or output window.</para>
            </TD>
            <TD>
              <para>See the build event log or output window for more details.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <section>
    <title>Security</title>
    <content/>
  </section>
  <relatedTopics>
<link xlink:href="c9dafb47-7b1d-4c72-9432-d43be3db1799">Validating Your System During Development</link>
</relatedTopics>
</developerConceptualDocument>
