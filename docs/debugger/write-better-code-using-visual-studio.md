---
title: Let Visual Studio help you write C# code with less bugs
description: "Understand when to use the debugger to debug your app"
ms.custom: "debug-experiments"
ms.date: "10/17/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugger"
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload:
  - "multiple"
---
# Write better C# code using Visual Studio

As you first learn to debug using Visual Studio, ...

Common issues

TIP start with code that works

## Follow along in the sample app

If you prefer, you can create a .NET Framework or .NET Core console app that contains the exact bugs and errors that we describe here, and you can follow along and make the fixes yourself.

To create the app, open Visual Studio and choose **File > New Project**. Under **Visual C#**, choose **Windows Desktop** or **.NET Core**, and then in the middle pane choose a **Console App**. Type a name like **Console_Parse_JSON** and click **OK**. Visual Studio creates the project. Paste the [sample code](#sample-code) into the project's *Program.cs* file.

> [!NOTE]
> If you don't see the **Console Application** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. The Visual Studio Installer launches. Choose the *.NET desktop development** or **.NET Core cross-platform development** workload, then choose **Modify**.

## Find the red and green squiggles!

Before you try to start your app and run the debugger, check the code in the code editor for red and green squiggles. These represent errors and warnings that are identified by the IDE's code analyzer. The red squiggles are compile-time errors, which you must fix before you can run the code. The green squiggles are warnings. Although you can run your app without fixing the warnings, they can be a source of bugs and you can save time by investigating. These warnings and errors also show up in the **Error List** window.

In the sample app, we see several red squiggles that we need to fix, and one green one that we will look at. Here is the first one.

![Error showing as a red squiggle](../debugger/media/write-better-code-red-squiggle.png)

## Check the light bulb!

The first red squiggle represents a compile-time error. Hover over it and you see the message ```The name `Encoding` does not exist in the current context```.

Notice that this error shows a light bulb icon. Along with the screwdriver icon, this icon represents Quick Actions that can help you fix or refactor code inline. Use the first suggested fix to resolve this by clicking **using System.Text**.

![Use the light bulb to fix code](../debugger/media/write-better-code-missing-include.png)

When you click this item, Visual Studio adds the `using System.Text` statement at the top of the *Program.cs* file, and the red squiggle disappears. (If you're not sure what the fixes will do, choose the **Preview changes** link before applying the fix.)

This is a very common error that you usually fix by adding a new ```using``` statement to your code. A common, similar error to this one is ```The type or namespace `Name` cannot be found.``` This may indicate a missing assembly reference (right-click the project, choose **Add** > **Reference**) or a missing library that you need to add using NuGet (right-click the project and choose **Manage NuGet Packages**).

## Fix the squiggles

There are a few more squiggles to look at in this code. Here, we see a common type conversion error. Looking at the message shown in the IDE, the code is trying to convert a string to an int.

![Type conversion error](../debugger/media/write-better-code-conversion-error.png)

There are no light bulbs to help you out this time. To fix this, you need to identify the intent of the code. Here, it's not too hard to see that `points` should be an integer value, since you are adding `points` to `totalpoints`.

![Warning message for unassigned variable](../debugger/media/write-better-code-warning-message.png)

## Fix an exception

Now, you are ready to start the debugger and run the app.

Exception / Exception Helper 
try/catch


## Clarify your code using assert

NullReferenceException-- refactor

## Watch your code in the debugger



## Fix performance issues

Generally, optimizing performance is something you do later in your app development. However, if you run into performance issues early (for example, some part of your app is running really slow), you may need to test the performance tools early on. For more information about tools such as the CPU Usage tool and the Memory Analyzer, see TBD.

## <a name="sample-code"></a> Sample code

The following code has some bugs that you can fix using the Visual Studio IDE. The app here is a simple app that simulates getting JSON data from some operation, deserializing the data to an object, and updating a simple in-memory database with the new data.

```c#
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace Console_Parse_JSON_DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var localDB = LoadRecords();
            string data = GetJsonData();

            User[] users = ReadToObject(data);

            UpdateRecords(localDB, users);

            for (int i = 0; i < users.Length; i++)
            {
                List<User> result = localDB.FindAll(delegate (User u) { return u.lastname == users[i].lastname; });
                foreach (var item in result)
                {
                    Console.WriteLine($"Matching Record, got name={item.firstname}, lastname={item.lastname}, age={item.totalpoints}");
                }
            }

            Console.ReadKey();
        }

        // Deserialize a JSON stream to a User object.  
        public static User[] ReadToObject(string json)
        {
            User deserializedUser = new User();
            User[] users = { };
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(users.GetType());

            users = ser.ReadObject(ms) as User[];

            ms.Close();
            return users;
        }

        // Simulated operation that returns JSON data.
        public static string GetJsonData()
        {
            string str = "[{ \"points\":4o,\"firstname\":\"Fred\",\"lastname\":\"Smith\"},{\"lastName\":\"Jackson\"}]";
            return str;
        }

        public static List<User> LoadRecords()
        {
            var db = new List<User> { };
            User user1 = new User();
            user1.firstname = "Joe";
            user1.lastname = "Smith";
            user1.totalpoints = 41;

            db.Add(user1);

            User user2 = new User();
            user2.firstname = "Pete";
            user2.lastname = "Peterson";
            user2.totalpoints = 30;

            db.Add(user2);

            return db;
        }
        public static void UpdateRecords(List<User> db, User[] users)
        {
            bool existingUser = false;

            for (int i = 0; i < users.Length; i++)
            {
                foreach (var item in db)
                {
                    if (item.lastname == users[i].lastname && item.firstname == users[i].firstname)
                    {
                        existingUser = true;
                        item.totalpoints += users[i].points;

                    }
                }
                if (existingUser == false)
                {
                    User user = new User();
                    user.firstname = users[i].firstname.Trim();
                    user.lastname = users[i].lastname.Trim();
                    user.totalpoints = users[i].points;

                    db.Add(user);
                }
            }
        }
    }

    [DataContract]
    internal class User
    {
        [DataMember]
        internal string firstname;

        [DataMember]
        internal string lastname;

        [DataMember]
        // internal double points;
        internal string points;

        [DataMember]
        internal int totalpoints;
    }
}
```

## Next steps

In this article, you've learned how to avoid and fix many common bugs in your code and when to use the debugger. Next, learn more about using the Visual Studio debugger to fix bugs.

> [!div class="nextstepaction"]
> [Debugging for absolute beginners](../debugger/debugging-absolute-beginners.md)
