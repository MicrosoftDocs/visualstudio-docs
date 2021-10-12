---
title: Learn Flask tutorial in Visual Studio step 2, views and templates
titleSuffix: ""
description: A walkthrough of Flask basics in the context of Visual Studio projects, specifically steps of creating an app and using views and templates.
ms.date: 01/07/2019
ms.topic: tutorial
author: rjmolyneaux
ms.author: rmolyneaux
manager: jmartens
ms.technology: vs-python

ms.workload:
  - python
  - data-science
---

# Step 2: Create a Flask app with views and page templates

**Previous step: [Create a Visual Studio project and solution](learn-flask-visual-studio-step-01-project-solution.md)**

What you have from step 1 of this tutorial is a Flask app with one page and all the code in a single file. To allow for future development, it's best to refactor the code and create a structure for page templates. In particular, you want to separate code for the app's views from other aspects like startup code.

In this step you now learn how to:

> [!div class="checklist"]
> - Refactor the app's code to separate views from startup code (step 2-1)
> - Render a view using a page template (step 2-2)

## Step 2-1: Refactor the project to support further development

In the code created by the "Blank Flask Web Project" template, you have a single *app.py* file that contains startup code alongside a single view. To allow for further development of an app with multiple views and templates, it's best to separate these concerns.

1. In your project folder, create an app folder called `HelloFlask` (right-click the project in **Solution Explorer** and select **Add** > **New Folder**.)

2. In the *HelloFlask* folder, create a file named *\_\_init\_\_.py* with the following contents that creates the `Flask` instance and loads the app's views (created in the next step):

    ```python
    from flask import Flask
    app = Flask(__name__)

    import HelloFlask.views
    ```

3. In the *HelloFlask* folder, create a file named *views.py* with the following contents. The name *views.py* is important because you used `import HelloFlask.views` within *\_\_init\_\_.py*; you'll see an error at run time if the names don't match.

    ```python
    from flask import Flask
    from HelloFlask import app

    @app.route('/')
    @app.route('/home')
    def home():
        return "Hello Flask!"
    ```

    In addition to renaming the function and route to `home`, this code contains the page rendering code from *app.py* and imports the `app` object that's declared in *\_\_init\_\_.py*.

4. Create a subfolder in *HelloFlask* named *templates*, which remains empty for now.

5. In the project's root folder, rename *app.py* to *runserver.py*, and make the contents match the following code:

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

6. Your project structure should look like the following image:

    ![Project structure after refactoring the code](media/flask/step02-project-structure.png)

7. Select **Debug** > **Start Debugging** (**F5**) or use the **Web Server** button on the toolbar (the browser you see may vary) to start the app and open a browser. Try both the / and /home URL routes.

8. You can also set breakpoints at various parts of the code and restart the app to follow the startup sequence. For example, set a breakpoint on the first lines of *runserver.py* and *HelloFlask\_*init_*.py*, and on the `return "Hello Flask!"` line in *views.py*. Then restart the app (**Debug** > **Restart**, **Ctrl**+**Shift**+**F5**, or the toolbar button shown below) and step through (**F10**) the code, or run from each breakpoint using **F5**.

    ![Restart button on the debugging toolbar in Visual Studio](media/debugging-restart-toolbar-button.png)

9. Stop the app when you're done.

### Commit to source control

Because you've made changes to your code and have tested them successfully, now is a great time to review and commit your changes to source control. Later steps in this tutorial remind you of appropriate times to commit to source control again, and refer you back to this section.

1. Select the changes button along the bottom of Visual Studio (circled below), which navigates to **Team Explorer**.

    ![Source control changes button on the Visual Studio status bar](media/flask/step02-source-control-changes-button.png)

1. In **Team Explorer**, enter a commit message like "Refactor code" and select **Commit All**. When the commit is complete, you see a message **Commit \<hash> created locally. Sync to share your changes with the server.** If you want to push changes to your remote repository, select **Sync**, then select **Push** under **Outgoing Commits**. You can also accumulate multiple local commits before pushing to remote.

    ![Push commits to remote in Team Explorer](media/flask/step02-source-control-push-to-remote.png)

### Question: How frequently should one commit to source control?

Answer: Committing changes to source control creates a record in the change log and a point to which you can revert the repository if necessary. Each commit can also be examined for its specific changes. Because commits in Git are inexpensive, it's better to do frequent commits than to accumulate a larger number of changes into a single commit. Clearly, you don't need to commit every small change to individual files. Typically you make a commit when adding a feature, changing a structure like you've done in this step, or done some code refactoring. Also check with others in your team for the granularity of commits that work best for everyone.

How often you commit and how often you push commits to a remote repository are two different concerns. You may accumulate multiple commits in your local repository before pushing them to the remote repository. Again, how frequently you commit depends on how your team wants to manage the repository.

## Step 2-2: Use a template to render a page

The `home` function that you have so far in *views.py* generates nothing more than a plain-text HTTP response for the page. However, most real-world web pages, respond with rich HTML pages that often incorporate live data. Indeed, the primary reason to define a view using a function is to generate content dynamically.

Because the return value for the view is just a string, you can build up any HTML you like within a string, using dynamic content. However, because it's best to separate markup from data, it's much better to place the markup in a template and keep the data in code.

1. For starters, edit *views.py* to contain the following code that uses inline HTML for the page with some dynamic content:

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

1. Run the app and refresh the page a few times to see that the date/time is updated. Stop the app when you're done.

1. To convert the page rendering to use a template, create a file named *index.html* in the *templates* folder with the following content, where `{{ content }}` is a placeholder or replacement token (also called a *template variable*) for which you supply a value in the code:

    ```html
    <html>
        <head><title>Hello Flask</title></head>

        <body>
            {{ content }}
        </body>
    </html>
    ```

1. Modify the `home` function to use `render_template` to load the template and supply a value for "content", which is done using a named argument matching the name of the placeholder. Flask automatically looks for templates in the *templates* folder, so the path to the template is relative to that folder:

    ```python
    def home():
        now = datetime.now()
        formatted_now = now.strftime("%A, %d %B, %Y at %X")

        return render_template(
            "index.html",
            content = "<strong>Hello, Flask!</strong> on " + formatted_now)
    ```

1. Run the app the see the results, and observe that the inline HTML in the `content` value doesn't render *as* HTML because the templating engine (Jinja) automatically escapes HTML content. Automatic escaping prevents accidental vulnerabilities to injection attacks: developers often gather input from one page and use it as a value in another through a template placeholder. Escaping also serves as a reminder that it's again best to keep HTML out of the code.

    Accordingly, review *templates\index.html* to contain distinct placeholders for each piece of data within the markup:

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

    Then update the `home` function to provide values for all the placeholders:

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

1. Run the app again to see the properly rendered output.

    ![Running app using the template](media/flask/step02-result.png)

1. Commit your changes to source control and update your remote repository, if desired, as described under [step 2-1](#commit-to-source-control).

### Question: Do page templates have to be in a separate file?

Answer: Although templates are usually maintained in separate HTML files, you can also use an inline template. Using a separate file is recommended, however, to maintain a clean separation between markup and code.

### Question: Must templates use the .html file extension?

Answer: The *.html* extension for page template files is entirely optional, because you always identify the exact relative path to the file in the first argument to the `render_template` function. However, Visual Studio (and other editors) typically give you features like code completion and syntax coloration with *.html* files, which outweighs the fact that page templates are not strictly HTML.

In fact, when you're working with a Flask project, Visual Studio automatically detects when the HTML file you're editing is actually a Flask template, and provides certain auto-complete features. For example, when you start typing a Flask page template comment, `{#`, Visual Studio automatically gives you the closing `#}` characters. The **Comment Selection** and **Uncomment Selection** commands (on the **Edit** > **Advanced** menu and on the toolbar) also use template comments instead of HTML comments.

### Question: Can templates be organized into further subfolders?

Answer: Yes, you can use subfolders and then refer to the relative path under *templates* in calls to `render_template`. Doing so is a great way to effectively create namespaces for your templates.

## Next steps

> [!div class="nextstepaction"]
> [Serve static files, add pages, and use template inheritance](learn-flask-visual-studio-step-03-serve-static-files-add-pages.md)

## Go deeper

- [Flask Quickstart - Rendering Templates](https://flask.palletsprojects.com/en/1.0.x/quickstart/#rendering-templates) (flask.pocoo.org)
- Tutorial source code on GitHub: [Microsoft/python-sample-vs-learning-flask](https://github.com/Microsoft/python-sample-vs-learning-flask)
