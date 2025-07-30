---
title: Flask in Visual Studio tutorial Step 2, views and templates
titleSuffix: ""
description: Step 2 of a core walkthrough of Flask capabilities in Visual Studio, including procedures to create an application with multiple views by using inline HTML templates.
ms.date: 04/18/2024
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to create Flask applications in Visual Studio so I can develop apps with multiple views and render views with templates.
---

# Tutorial: Create a Flask app with views and page templates in Visual Studio

This article presents Step 2 in the tutorial series *Work with the Flask web framework in Visual Studio*.

Visual Studio allows you to create Flask applications from project templates that provide a more extensive starting point for your projects. [Step 1 in the tutorial](learn-flask-visual-studio-step-01-project-solution.md) describes how to create a Flask app with one page, where all the code is in a single file. In Step 2, you refactor the code and create a structure for page templates to enable further development. In particular, you want to separate code for the application views from other aspects like startup code.

In Step 2 of the tutorial, you learn how to:

> [!div class="checklist"]
> - Refactor application code to separate views from startup code
> - Render a view by using a page template

## Prerequisites

- A Visual Studio solution and Flask application project created in [Step 1: Create Visual Studio solution and Flask project](learn-flask-visual-studio-step-01-project-solution.md).

## Refactor Flask project for further development

The **Blank Flask Web Project** template lets you create a project with a single _app.py_ file that contains startup code alongside a single view. To allow further development of an app with multiple views and templates, you need to separate these functions.

Follow these steps to adjust your Flask project to allow for further development:

1. In **Solution Explorer**, right-click your Flask project folder (_BasicProject_), and select **Add** > **New Folder**. 

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/flask/vs-2022/step-02-add-hello-flask-folder.png" alt-text="Screenshot that shows how to add the Hello Flask folder in Visual Studio." border="false" lightbox="media/flask/vs-2022/step-02-add-hello-flask-folder.png"::: 

   ::: moniker-end

1. Name the new application folder *HelloFlask*.

1. Right-click the *HelloFlask* folder, and select **Add** > **New Item** to create a new file.

1. In the **Add New Item** dialog, select the **Empty Python File** file template:

   1. Name the file _\_\_init\_\_.py_. The file name should include two leading and two ending underscore characters (`_`) around the word _init_.

   1. Select **Add**.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/flask/vs-2022/step-02-add-init-file.png" alt-text="Screenshot that shows how to add the init python file in Visual Studio." border="false" lightbox="media/flask/vs-2022/step-02-add-init-file.png"::: 

   ::: moniker-end

1. Add the following code to the new file, which creates the `Flask` instance and loads the application views:

   ```python
   from flask import Flask
   app = Flask(__name__)

   import HelloFlask.views
   ```

1. In the *HelloFlask* folder, create another new Python file named _views.py_.

   > [!IMPORTANT]
   > Be sure to specify the file name as _views.py_. The name _views_ is important because of the `import HelloFlask.views` statement in the _\_\_init\_\_.py_ file. If the name _views_ isn't the same in both instances, Visual Studio shows an error at runtime.

1. Add the following code to the _views.py_ file. This code renames the function and defines the return route to the `/home` endpoint:

   ```python
   from flask import Flask
   from HelloFlask import app

   @app.route('/')
   @app.route('/home')
   def home():
       return "Hello Flask!"
   ```

   This code also contains the page rendering code from the _app.py_ file and imports the `app` object declared in the _\_\_init\_\_.py_ file.

1. In the *HelloFlask* folder, create a subfolder named *templates*. The folder is empty for now.

1. In the Flask project folder (_BasicProject_), replace the contents of the _app.py_ file with the following code:

   ```python
   import os
   from HelloFlask import app    # Imports the code from HelloFlask/__init__.py

   if __name__ == '__main__':
       HOST = os.environ.get('SERVER_HOST', 'localhost')

       try:
           PORT = int(os.environ.get('SERVER_PORT', '5555'))
       except ValueError:
           PORT = 5555

       app.run(HOST, PORT)
   ```

1. After you update the code, rename the _app.py_ file to _runserver.py_.

1. Confirm your refactored Flask project structure looks like the following example:

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/flask/vs-2022/step-02-project-structure.png" alt-text="Screenshot that shows the updated Flask project structure in Solution Explorer in Visual Studio." border="false" lightbox="media/flask/vs-2022/step-02-project-structure.png"::: 

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/flask/step-02-project-structure.png" alt-text="Screenshot that shows the updated Flask project structure in Solution Explorer in earlier versions of Visual Studio." border="false" lightbox="media/flask/step-02-project-structure.png":::

   ::: moniker-end

### Run refactored program and check routes

Now you're ready to run your project in Visual Studio:

1. In Visual Studio, select **Debug** > **Start Debugging** (**F5**) or select **Web Server** on the main toolbar (the browser you see might vary):

1. When the application opens in the browser, try both the `/` (root) and `/home` URL route endpoints in the browser:

   :::image type="content" source="media/flask/step-02-check-url-app-routes.png" alt-text="Screenshot that shows how to check the slash home route for the refactored Flask application in the browser." border="false" lightbox="media/flask/step-02-check-url-app-routes.png":::

### Run updated program in Debugger

You can also set breakpoints at various parts of the code and follow the app startup sequence in the **Debugger**:

1. Set several breakpoints, such as the following points:
      
   - The first line of the _runserver.py_ file
   - The first line of the _\_\_init\_\_.py_ file
   - The `return "Hello Flask!"` line in the _views.py_ file

1. Start the app in the **Debugger** by selecting **Debug** > **Start Debugging** or **F5**.

1. While the **Debugger** is running, step through the code with **F10**, or run the code from each breakpoint with **F5**. You can also use debugging controls on the main toolbar in Visual Studio, such as **Continue**, **Stop**, **Restart**, and **Step** options:

   :::image type="content" source="media/debug-actions-toolbar.png" alt-text="Screenshot that shows debugging controls on the main toolbar in Visual Studio, such as continue, restart, and step options." border="false" lightbox="media/debug-actions-toolbar.png":::

1. When you're done, select **Ctrl**+**C** followed by any key to stop the application. You can also close any open browser windows for the routes.

### Commit changes to source control

After you refactor the code and test the updates, you can review and commit your changes to source control:

::: moniker range=">=vs-2022"

1. Save the changes to your project files, such as with the **Ctrl**+**S** keyboard shortcut.

1. On the Git controls bar, select the uncommitted changes (pencil 5) to open the **Git Changes** window:

   :::image type="content" source="media/flask/vs-2022/step-02-refactor-uncommitted-changes.png" alt-text="Screenshot that shows the uncommitted changes option on the Visual Studio status bar." border="false" lightbox="media/flask/vs-2022/step-02-refactor-uncommitted-changes.png"::: 

1. In the **Git Changes** window, enter a commit message, and select **Commit All**: 

   :::image type="content" source="media/flask/vs-2022/step-02-commit-all-refactor-changes.png" alt-text="Screenshot that shows how to edit the commit message and commit all changes for the refactored code in the Git Changes window." border="false" lightbox="media/flask/vs-2022/step-02-commit-all-refactor-changes.png"::: 

   When the commit completes, Visual Studio displays the message **Commit \<hash> created locally**.

1. (Optional) Push the committed changes to your remote repository:

   1. On the Git controls bar, select the outgoing/incoming commits (arrows 1/0).
   
   1. Select **Sync** (Pull then Push) or **Push**.

   :::image type="content" source="media/flask/vs-2022/step-02-push-commits-remote.png" alt-text="Screenshot that shows how to push commits to a remote repository in Visual Studio 2022." border="false" lightbox="media/flask/vs-2022/step-02-push-commits-remote.png":::
   
   You can also accumulate multiple local commits before you push them to the remote repository.

::: moniker-end
::: moniker range="<=vs-2019"

1. Save the changes to your project files, such as with the **Ctrl**+**S** keyboard shortcut.

1. Select the uncommitted changes (pencil 5) at the bottom right in Visual Studio, which opens **Team Explorer**:

   :::image type="content" source="media/flask/step-02-source-control-changes-button.png" alt-text="Screenshot that shows the source control changes option on the Visual Studio status bar." border="false" lightbox="media/flask/step-02-source-control-changes-button.png":::

1. In **Team Explorer**, enter a commit message like "Refactor code" and select **Commit All**.

   When the commit completes, Visual Studio displays the message **Commit \<hash> created locally. Sync to share your changes with the server.**

1. (Optional) Push the committed changes to your remote repository:

   1. In **Team Explorer**, select **Sync**.
   
   1. Expand the **Outgoing Commits** and select **Push**.

   :::image type="content" source="media/flask/step-02-source-control-push-to-remote.png" alt-text="Screenshot that shows how to sync and push commits to a remote repository in Team Explorer." border="false" lightbox="media/flask/step-02-source-control-push-to-remote.png":::

   You can also accumulate multiple local commits before you push them to the remote repository.

::: moniker-end

For subsequent procedures in this tutorial series, you can refer to this section for the steps to commit changes to source control.

### Determine frequency of commits and pushes

Committing changes to source control creates a record in the change log and a point to which you can revert the repository, as needed. You can also examine each commit to review the specific changes.

Commits in Git are inexpensive. It can be preferable to submit your changes in small amounts with frequent commits, rather than accumulate a large number of changes and submit them as a single commit.

You don't need to commit every small change to individual files. It's common to make a commit when you add a feature, change a structure as shown in this Step of the tutorial series, or refactor some code. It's also a good practice to check with your collaborators to agree on the granularity of commits that work best for everyone.

How often you commit and how often you push commits to a remote repository are two different concerns. You might accumulate multiple commits in your local repository before you push them to the remote repository. The frequency of your commits depends on how your team wants to manage the repository.

## Use templates to render pages and views

The `home` function in the _views.py_ file generates a plain-text HTTP response for the page. Most real-world web pages respond with rich HTML pages that often incorporate live data. The primary reason developers define views by using a function is to generate content dynamically.

The return value for the view is just a string. You can build up any HTML within a string by using dynamic content. Because it's best to separate markup from data, it's better to place the markup in a template and keep the data in code.

### Adjust views to use inline HTML

The first step is to convert the view processing to use inline HTML for the page with some dynamic content:

1. Replace the contents of the _views.py_ file with the following code:

   ```python
   from datetime import datetime
   from flask import render_template
   from HelloFlask import app

   @app.route('/')
   @app.route('/home')
   def home():
       now = datetime.now()
       formatted_now = now.strftime("%A, %d %B, %Y at %X")

       html_content = "<html><head><title>Hello Flask</title></head><body>"
       html_content += "<strong>Hello Flask!</strong> on " + formatted_now
       html_content += "</body></html>"

       return html_content
   ```

1. Save your changes and run your app again.

1. Refresh the page a few times to confirm that the date and time updates. When you're done, stop the app.

### Create HTML template

Next, convert the page rendering process to use an HTML template:

1. Right-click the *templates* folder, and select **Add** > **New Item** to create a new file.

1. In the **Add New Item** dialog, select the **HTML Page** file template. Name the file _index.html_ and select **Add**.

1. Replace the supplied contents of the HTML file with the following markup:

   ```html
   <html>
   <head>
      <title>Hello Flask</title>
   </head>

   <body>
      {{ content }}
   </body>
   </html>
   ```

   In this code, the `{{ content }}` statement is a placeholder or replacement token (also called a *template variable*) for which you supply a value in the code.

### Adjust home function to load template

You need to modify the `home` function to use the `render_template` method. This method loads the HTML template and supplies a value for `{{ content }}` by using a named argument that matches the name of the placeholder.

1. In the _views.py_ file, replace the `home` function definition with the following code:

   ```python
   def home():
       now = datetime.now()
       formatted_now = now.strftime("%A, %d %B, %Y at %X")

       return render_template(
           "index.html",
           content = "<strong>Hello, Flask!</strong> on " + formatted_now)
   ```

   Flask automatically looks for templates in the *templates* folder, so the path to the template is relative to that folder.

1. Save your project changes and run the app again.

   Notice that the inline HTML syntax (`\<strong>` ...) within the `content` value doesn't render *as* HTML because the templating engine (Jinja) automatically escapes HTML content. Automatic escaping prevents accidental vulnerabilities to injection attacks.
   
   Developers often gather input from one page and use it as a value in another by using a template placeholder. Escaping also serves as a reminder that it's best to keep HTML out of the code.

   When you're done, stop the app.

### Use distinct placeholders

You can use distinct placeholders for each piece of data within the HTML markup. Then, adjust your `home` function again to supply the specific placeholder values:

1. Replace the contents of the _index.html_ file with the following markup: 

   ```html
   <html>
     <head>
       <title>{{ title }}</title>
     </head>
     <body>
       <strong>{{ message }}</strong>{{ content }}
     </body>
   </html>
   ```

1. In the _views.py_ file, replace the `home` function definition with the following code to provide values for all the placeholders:

   ```python
   def home():
       now = datetime.now()
       formatted_now = now.strftime("%A, %d %B, %Y at %X")

       return render_template(
           "index.html",
           title = "Hello Flask",
           message = "Hello, Flask!",
           content = " on " + formatted_now)
   ```

1. Save your changes and run your app again. This time you should see the properly rendered output:

   :::image type="content" source="media/flask/step-02-render-page-html-template.png" alt-text="Screenshot that shows the running application that uses HTML template for the page information to render." border="false" lightbox="media/flask/step-02-render-page-html-template.png":::

1. You can commit your changes to source control and update your remote repository. For more information, see [Commit changes to source control](#commit-changes-to-source-control).

### Separate page templates

Templates are usually maintained in separate HTML files, but you can also use an inline template. Separate files are recommended to maintain a clean separation between markup and code.

### Use .html extension for templates

The _.html_ extension for page template files is entirely optional. You can always identify the exact relative path to the file in the first argument to the `render_template` function. However, Visual Studio (and other editors) typically provide features like code completion and syntax coloration with _.html_ files, which outweighs the fact that page templates aren't HTML.

When you work with a Flask project, Visual Studio automatically detects if the HTML file you're editing is actually a Flask template, and provides certain auto-complete features. If you start to enter a Flask page template comment (`{#`), Visual Studio automatically supplies the closing `#}` characters. The **Comment Selection** and **Uncomment Selection** commands (on the **Edit** > **Advanced** menu) also use template comments instead of HTML comments.

### Organize templates into subfolders

You can use subfolders and then refer to the relative path under the *templates* folder in calls to the `render_template` function. This approach is a great way to effectively create namespaces for your templates.

## Next step

> [!div class="nextstepaction"]
> [Step 3: Serve static files, add pages, and use template inheritance](learn-flask-visual-studio-step-03-serve-static-files-add-pages.md)
