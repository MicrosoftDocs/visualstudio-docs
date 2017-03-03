---
title: "Displaying Text in a Webpage (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "JavaScript, write"
  - "JavaScript, writing text"
ms.assetid: 3c2455e7-2402-45f2-9545-77a2b2490527
caps.latest.revision: 30
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Displaying Text in a Webpage (JavaScript)
There are a number of ways to display text in a webpage. Each has advantages and disadvantages and supports specific uses.  
  
## Displaying Text  
  
-   The recommended way to display text is to create an element and write to its textContent property.  
  
    ```javascript  
    <div id="textDiv"></div>  
    <script type="text/javascript">  
        var div = document.getElementById("textDiv");  
        div.textContent = "my text";  
        var text = div.textContent;  
    </script>  
    ```  
  
     In this example, the value of `text` is "my text". However, the value resulting from getting or setting the `textContent` property on a parent node might include text content from the node's children. The following example shows that the `textContent` that is set on a child node is included in the value of `textContent` of the parent node:  
  
    ```javascript  
    <div id="textDiv">  
        <div id="nested"></div>  
    </div>  
    <script type="text/javascript">  
        var div = document.getElementById("textDiv");  
        var nestedDiv = document.getElementById("nested");  
        nestedDiv.textContent = "nested";  
  
        var text = "[" + div.textContent + "]";  
    </script>  
    ```  
  
     In this example, the value of `text` is "[nested]".  
  
-   You can also create an element and write to its [innerHTML](http://msdn.microsoft.com/library/ie/ms533897\(v=vs.85\).aspx) or [innerText](http://msdn.microsoft.com/library/ie/ms533899\(v=vs.85\).aspx) properties. Setting these properties affects only the text in the element itself, not in its children. However, these properties also have some disadvantages:  
  
    -   The [innerText](http://msdn.microsoft.com/library/ie/ms533899\(v=vs.85\).aspx) property doesn't work in all browsers, so you might want to avoid it for reasons of compatibility.  
  
    -   The [innerText](http://msdn.microsoft.com/library/ie/ms533899\(v=vs.85\).aspx) property is affected by CSS styles, and doesn't appear if the element is hidden.  
  
    -   The [innerHTML](http://msdn.microsoft.com/library/ie/ms533897\(v=vs.85\).aspx) property gets and sets both nested nodes and text. If it isn't secured, it could be used for script-injection attacks. In addition, setting it to text without HTML tags removes all previously set nodes.  
  
-   You can use the `document.write` method without having to create an element. However, using this method causes the entire web page to be cleared, which might not be what you want.  
  
     The following example shows one of the disadvantages of using `document.write`. The script is intended to display the time every 5 seconds, but it shows the time just twice. By the time `document.write` is called the second time, the page has finished loading, and `document.write` then clears the entire page (it calls `document.open`). At this point, the `ShowTime` function no longer exists.  
  
    ```html  
    <!DOCTYPE html>  
    <html>  
    <head>  
    <script type="text/javascript">  
        function ShowTime()  
        {  
            var dt = new Date();  
            document.write(dt.toTimeString());  
            // var elem = document.getElementById("divElem");  
            // elem.textContent = dt.toTimeString();  
            window.setTimeout("ShowTime();", 5000);  
        }  
    </script>  
    </head>  
  
    <body>  
    <script type="text/javascript">  
        ShowTime();  
    </script>  
    <div id="myDiv"></div>  
    </body>  
    </html>  
  
    ```  
  
     To fix the preceding code, remove the line of code that contains `document.write` and uncomment the two commented lines of code that follow.  
  
-   You can also use an `alert``prompt`, or `confirm` function, which displays a message in a pop-up window. In most cases it's not a good idea to use a pop-up window in a web browser. Most modern browsers have settings that automatically block pop-up windows, so your message might not be seen. Moreover, it is possible to enter an infinite loop when you use pop-up windows, which makes it impossible for the user to close the web page in the usual way.