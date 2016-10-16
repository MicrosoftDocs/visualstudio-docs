---
title: "Perform quick actions with light bulbs"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 990ee487-cf9a-4b89-9784-e7b47c220e8c
caps.latest.revision: 5
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Perform quick actions with light bulbs
Light bulbs are a new productivity feature in Visual Studio 2015. They are icons that appear in the Visual Studio editor and that you can click to perform quick actions including refactoring fixing errors. Light bulbs bring error-fixing and refactoring assistance into a single focal point, often right on the line where you are typing.  
  
 ![Small Light Bulb Icon](../ide/media/vs2015_lightbulbsmall.png "VS2015_LightBulbSmall")  
  
 In C# and Visual Basic, you will see a light bulb if there is a red squiggle and Visual Studio has a suggestion for how to fix the issue. For instance if you have an error indicated by a red squiggle, a light bulb will appear when fixes are available for that error. In C++, when you add a new function to a header file, you’ll see a light bulb that offers to create a stub implementation of that function. For any language, third parties can provide custom diagnostics and suggestions, for example as part of an SDK, and Visual Studio light bulbs will light up based on those rules.  
  
## To see a light bulb  
  
1.  In many cases, light bulbs spontaneously appear when you hover the mouse at the point of an error, or in the left margin of the editor when you move the caret into a line that has an error in it. When you see a red squiggle, you can hover over it to display the light bulb. You can also cause a light bulb to display when you use the mouse or keyboard to go to anywhere in the line where the issue occurs.  
  
2.  Press **Ctrl + .** anywhere on a line to invoke the light bulb and go directly to the list of potential fixes.  
  
 ![Light bulb with mouse hovering](../ide/media/vs2015_lightbulb_hover.png "VS2015_LightBulb_Hover")  
  
## To see potential fixes  
 Either click on the down arrow or the Show potential fixes link to display a list of quick actions that the light bulb can take for you.  
  
 ![Light bulb expanded](../ide/media/vs2015_lightbulb_hover_expanded.png "VS2015_LightBulb_hover_expanded")  
  
## To do a refactoring  
 You can still perform refactorings by right clicking to bring up the context menu, but you can also press Ctrl + . to display refactoring options. In the following illustration, the Extract Method refactoring is offered after pressing Ctrl + . somewhere on the line that contains the `Math.Abs` call:  
  
 ![Light bulb showing refactoring options](../ide/media/vs2015_lightbulbs_refactor.png "VS2015_LightBulbs_refactor")