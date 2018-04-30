---
ms.topic: include
---
### Create a project using Django 2.0

At present, the Blank Django Web Project template uses the latest Django 1.x version. To use Django 2.x, the quickest means is import Django 2.x files into a Django 1.x project. By following that process, you take advantage of other details handled by the Visual Studio project template.

1. Create a Django 1.x project using the "Blank Django Web Project" template as described in the previous section. However, at the "This project requires external dependencies" prompt, select **I will install them myself**. You choose this option to avoid installing dependencies that are uninstalled in a later step.

1. Open a command prompt and navigate to a temporary folder.

1. Run `pip install django` to install the latest Django package in your global Python environment.

1. Run `django-admin startproject <project_name>` replacing `<project_name>` with the same project name used in Step 1, such as "HelloDjango". The `startproject` command creates a `manage.py` file along with a folder matching `<project_name>` that contains the files `__init.py__`, `settings.py`, `urls.py`, and `wsgi.py`.

1. In Visual Studio, replace the Django 1.x files in the project with the Django 2.x files as follows:

  a. In **Solution Explorer**, delete `manage.py` and the Django app folder.
  b. Right-click the project, select the **Add > Existing Item...** command, navigate to and select the `manage.py` file created in Step 4, and select **OK**. Visual Studio then copies that file into the project.
  c. Right-click the project again, select the **Add > Existing Folder...** command, navigate to and select the app folder created in Step 4, and select **OK**. Visual Studio then copies that entire folder and its four files into the project.
  d. Right-click `manage.py` and select **Set as Startup File**.

  > [!Important]
  > The app name shown in the Visual Studio project must match the `<project_name>` used with the `django-admin` utility because the utility uses that name as a namespace inside the Python code files.

1. Open `requirements.txt`, change its contents to `django >=2.0, <3`, and save the file.

1. In **Solution Explorer**, right-click the **Python Environments** node and select **Add Virtual Environment...**. Accept the defaults in the dialog that appears and select **Create**. Accept any prompts for administrator privileges.