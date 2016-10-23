---
title: "MSBuild Concepts"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 083b8ba3-e4ad-45af-bb5d-3bc81d406131
caps.latest.revision: 11
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
# MSBuild Concepts
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <token>vstecmsbuild</token> provides a basic XML schema that you can use to control how the build platform builds software. To specify the components in the build and how they are to be built, use these four parts of MSBuild: properties, items, tasks, and targets.</para>
  </introduction>
  <section>
    <title>Related Topics</title>
    <content>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Title</para>
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
                MSBuild Properties
              </para>
            </TD>
            <TD>
              <para>Introduces properties and property collections. Properties are key/value pairs that you can use to configure builds.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>
              </para>
            </TD>
            <TD>
              <para>Describes the general concepts behind the <token>vstecmsbuild</token> file format and how the pieces fit together.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="8060b4d2-e4a9-48cf-a437-852649ceb417">MSBuild Targets</link>
              </para>
            </TD>
            <TD>
              <para>Explains how to group tasks together in a particular order and enable sections of the build process to be called on the command line.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">MSBuild Tasks</link>
              </para>
            </TD>
            <TD>
              <para>Shows how to create a unit of executable code that can be used by <token>vstecmsbuild</token> to perform atomic build operations.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="b9da45ae-d6a6-4399-8628-397deed31486">Comparing Properties and Items</link>
              </para>
            </TD>
            <TD>
              <para>Compares MSBuild properties and items. Both are used to pass information to tasks, evaluate conditions, and store values that can be referenced throughout the project file.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="545e6a59-1093-4514-935e-78679a46fb3c">MSBuild Special Characters</link>
              </para>
            </TD>
            <TD>
              <para>Explains how to escape some characters that <token>vstecmsbuild</token> reserves for special use in specific contexts.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="e3acff7c-cb4e-4ae1-8be2-a871bcff847b">Tutorial: How to Create a Project File from Scratch</link>
              </para>
            </TD>
            <TD>
              <para>Shows how to create a basic project file incrementally, by using only a text editor.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="b8a8b866-bb07-4abf-b9ec-0b40d281c310">Tutorial: How to Use MSBuild</link>
              </para>
            </TD>
            <TD>
              <para>Introduces the building blocks of MSBuild and shows how to write, manipulate, and debug MSBuild projects without closing the Visual Studio integrated development environment (IDE).</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
              </para>
            </TD>
            <TD>
              <para>Links to documents that contain reference information.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
               "MSBuild"
              </para>
            </TD>
            <TD>
              <para>Presents an overview of the XML schema for a project file and shows how it controls processes that builds software.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <relatedTopics />
</developerConceptualDocument>