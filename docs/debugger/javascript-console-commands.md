---
title: "JavaScript Console commands | Microsoft Docs"
ms.custom: ""
ms.date: "10/17/2019"
ms.topic: "reference"
helpviewer_keywords:
  - "JavaScript Console commands [UWP apps]"
  - "JavaScript debugging, console [UWP apps]"
  - "debugging JavaScript, console [UWP apps]"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: vs-2017
ms.workload:
  - "uwp"
  - "cordova"
---
# JavaScript Console commands in Visual Studio

You can use commands to send messages and perform other tasks in the JavaScript Console window of Visual Studio. For examples that show how to use this window, see [QuickStart: Debug JavaScript](../debugger/quickstart-debug-javascript-using-the-console.md?view=vs-2017). The information in this topic applies to Node.js app, UWP apps, and apps created using Visual Studio Tools for Apache Cordova.

If the JavaScript Console window is closed, you can open it while you're debugging in Visual Studio by choosing **Debug** > **Windows** > **JavaScript Console**.

> [!NOTE]
> If the window is not available during a debugging session, make sure that the debugger type is set to **Script** in the Debug properties for the project.

For info on using the console in Microsoft Edge Developer tools, see [this topic](/microsoft-edge/devtools-guide).

## console object commands

This table shows the syntax for the `console` object commands that you can use in the JavaScript Console window, or that you can use to send messages to the console from your code. This object provides a number of forms so that you can distinguish between informational messages and error messages, if you want to.

You can use the longer command form `window.console.[command]` if you need to avoid possible confusion with local objects named console.

> [!TIP]
> Older versions of Visual Studio do not support the complete set of commands. Use IntelliSense on the console object to get quick information about supported commands.

|Command|Description|Example|
|-------------|-----------------|-------------|
|`assert(expression, message)`|Sends a message if `expression` evaluates to **false**.|`console.assert((x == 1), "assert message: x != 1");`|
|`clear()`|Clears messages from the console window, including script-error messages, and also clears script that appears in the console window. Does not clear script that you entered into the console input prompt.|`console.clear();`|
|`count(title)`|Sends the number of times that the count command was called to the console window. Each call to count is uniquely identified by the optional `title`.<br /><br /> The existing entry in the console window is identified by the `title` parameter (if present) and updated by the count command. A new entry is not created.|`console.count();`<br /><br /> `console.count("inner loop");`|
|`debug(message)`|Sends `message` to the console window.<br /><br /> This command is identical to console.log.<br /><br /> Objects that are passed by using the command are converted to a string value.|`console.debug("logging message");`|
|`dir(object)`|Sends the specified object to the console window and displays it in an object visualizer. You can use the visualizer to inspect properties in the console window.|`console.dir(obj);`|
|`dirxml(object)`|Sends the specified XML node `object` to the console window and displays it as an XML node tree.|`console.dirxaml(xmlNode);`|
|`error(message)`|Sends `message` to the console window. The message text is red and prefaced by an error symbol.<br /><br /> Objects that are passed by using the command are converted to a string value.|`console.error("error message");`|
|`group(title)`|Starts a grouping for messages that are sent to the console window, and sends the optional `title` as a group label. Groups can be nested and appear in a tree view in the console window.<br /><br /> The group* commands can make it easier to view console window output in some scenarios, such as when a component model is in use.|`console.group("Level 2 Header");` <br /> `console.log("Level 2");` <br /> `console.group();` <br /> `console.log("Level 3");` <br /> `console.warn("More of level 3");` <br /> `console.groupEnd();` <br /> `console.log("Back to level 2");` <br /> `console.groupEnd();` <br /> `console.debug("Back to the outer level");`|
|`groupCollapsed(title)`|Starts a grouping for messages that are sent to the console window, and sends the optional `title` as a group label. Groups that are sent by using `groupCollapsed` appear in a collapsed view by default. Groups can be nested and appear in a tree view in the console window.|Usage is the same as the `group` command.<br /><br /> See the example for the `group` command.|
|`groupEnd()`|Ends the current group.<br /><br /> Requirements:<br /><br /> Visual Studio 2013|See the example for the `group` command.|
|`info(message)`|Sends `message` to the console window. The message is prefaced by an information symbol.|`console.info("info message");`<br /><br /> For more examples, see [Formatting console.log output](#ConsoleLog) later in this topic.|
|`log(message)`|Sends `message` to the console window.<br /><br /> If you pass an object, this command sends that object to the console window and displays it in an object visualizer. You can use the visualizer to inspect properties in the console window.|`console.log("logging message");`|
|`msIsIndependentlyComposed(element)`|Used in web apps. Not supported in UWP apps using JavaScript.|Not supported.|
|`profile(reportName)`|Used in web apps. Not supported in UWP apps using JavaScript.|Not supported.|
|`profileEnd()`|Used in web apps. Not supported in UWP apps using JavaScript.|Not supported.|
|`select(element)`|Selects the specified HTML `element` in the [DOM Explorer](../debugger/quickstart-debug-html-and-css.md).|console.select(element);|
|`time (name)`|Starts a timer that's identified by the optional `name` parameter. When used with `console.timeEnd`, calculates the time that elapses between `time` and `timeEnd`, and sends the result (measured in ms) to the console using the `name` string as a prefix. Used to enable instrumentation of app code for measuring performance.|`console.time("app start");  app.start();  console.timeEnd("app start");`|
|`timeEnd(name)`|Stops a timer that's identified by the optional `name` parameter. See the `time` console command.|`console.time("app start"); app.start(); console.timeEnd("app start");`|
|`trace()`|Sends a stack trace to the console window. The trace includes the complete call stack, and includes info such as filename, line number, and column number.|`console.trace();`|
|`warn(message)`|Sends `message` to the console window, prefaced by a warning symbol.<br /><br /> Objects that are passed by using the command are converted to a string value.|`console.warn("warning message");`|

## Miscellaneous commands
These commands are also available in the JavaScript Console window (they are not available from code).

|Command|Description|Example|
|-------------|-----------------|-------------|
|`$0`, `$1`, `$2`, `$3`, `$4`|Returns the specified element to the console window. `$0` returns the element currently selected in DOM Explorer, `$1` returns the element previously selected in DOM Explorer, and so on, up to the fourth previously selected element.|$3|
|`$(id)`|Returns an element by ID. This is a shortcut command for `document.getElementById(id)`, where `id` is a string that represents the element ID.|`$("contenthost")`|
|`$$(selector)`|Returns an array of elements that match the specified selector using CSS selector syntax. This is a shortcut command for `document.querySelectorAll()`.|`$$(".itemlist")`|
|`cd()`<br /><br /> `cd(window)`|Enables you to change the context for expression evaluation from the default top-level window of the page to the window of the specified frame. Calling `cd()` without parameters returns the context to the top-level window.|`cd();`<br /><br /> `cd(myframe);`|
|`select(element)`|Selects the specified element in [DOM Explorer](../debugger/quickstart-debug-html-and-css.md).|`select(document.getElementById("element"));`<br /><br /> `select($("element"));`<br /><br /> `select($1);`|
|`dir(object)`|Returns a visualizer for the specified object. You can use the visualizer to inspect properties in the console window.|`dir(obj);`|

## Checking whether a console command exists
You can check whether a specific command exists before attempting to use it. This example checks for the existence of the `console.log` command. If `console.log` exists, the code calls it.

```javascript
if (console && console.log) {
    console.log("msg");
}

```

## Examining objects in the JavaScript Console window
You can interact with any object that's in scope when you use the JavaScript Console window. To inspect an out-of-scope object in the console window, use `console.log` , `console.dir`, or other commands from your code. Alternatively, you can interact with the object from the console window while it is in scope by setting a breakpoint in your code (**Breakpoint** > **Insert Breakpoint**).

## <a name="ConsoleLog"></a> Formatting console.log output
If you pass multiple arguments to `console.log`, the console will treat the arguments as an array and concatenate the output.

```javascript
var user = new Object();
user.first = "Fred";
user.last = "Smith";

console.log(user.first, user.last);
// Output:
// Fred Smith

```

`console.log` also supports "printf" substitution patterns to format output. If you use substitution patterns in the first argument, additional arguments will be used to replace the specified patterns in the order they are used.

 The following substitution patterns are supported:

- %s - string
  %i - integer
  %d - integer
  %f - float
  %o - object
  %b - binary
  %x - hexadecimal
  %e - exponent

  Here are some examples of using substitution patterns in `console.log`:

```javascript
var user = new Object();
user.first = "Fred";
user.last = "Smith";
user.age = 10.01;
console.log("Hi, %s %s!", user.first, user.last);
console.log("%s is %i years old!", user.first, user.age);
console.log("%s is %f years old!", user.first, user.age);

// Output:
// Hi, Fred Smith!
// Fred is 10 years old!
// Fred is 10.01 years old!
```

## See also
- [QuickStart: Debug JavaScript](../debugger/quickstart-debug-javascript-using-the-console.md?view=vs-2017)
- [Quickstart: Debug HTML and CSS](../debugger/quickstart-debug-html-and-css.md?view=vs-2017)
