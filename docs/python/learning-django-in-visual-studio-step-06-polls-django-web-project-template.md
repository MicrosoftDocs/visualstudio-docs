---
title: Tutorial - Learning Django in Visual Studio, step 6
description: A walkthrough of Django basics in the context of Visual Studio projects, specifically the features of the Polls Django Web Project template such as administrative customization.
ms.date: 04/16/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
dev_langs:
  - python
ms.tgt_pltfrm:
ms.topic: tutorial
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
---

# Tutorial step 6: Use the Polls Django Web Project template

**Previous step: [Authenticate users in Django](learning-django-in-visual-studio-step-05-django-authentication.md)**

Having understood Visual Studio's "Django Web Project" template, you can now look at the third Django template, "Polls Django Web Project", which builds upon the same code base.

In this step you learn how to:

> [!div class="checklist"]
> - Create a project from the template and initialize the database (step 6-1)
> - Understand data models (step 6-2)
> - Apply migrations (step 6-3)
> - Understand the views and page templates created by the project template (step 6-4)
> - Create a custom administration interface (step 6-5)

A project created using this template is effectively what you get by following the [Writing your first Django app](https://docs.djangoproject.com/en/2.0/intro/tutorial01/) tutorial in the Django docs. The web app consists of a public site that lets people view polls and vote in them, along with an added administrative interface through which you can manage polls. It uses the same authentication system as the "Django Web Project" template and makes more use of the database by implementing Django models as explored in the following sections.

TODO's: add source control steps, add Q&A

## Step 6-1: Create the project and initialize the database

1. In Visual Studio, select the **File > New > Project...** menu command, search for and select the "Polls Django Web Project" template, specify a name and location for the project, and select **OK**.

1. Because the template includes a `requirements.txt` file, Visual Studio prompts asks where to install those dependencies. Choose the option, **Install into a virtual environment**, and in the **Add Virtual Environment** dialog select **Create** to accept the defaults.

1. Once Python finishes setting up the virtual environment, Visual Studio displays the contents of the template's `readme.html` file. Follow the instructions in that readme to initialize the database and create a Django super user (that is, an administrator). To be specific, just right-click the Visual Studio project, select the **Python > Django Migrate** command, then right-click the project again, select the **Python > Django Create Superuser** command, and follow the prompts.

    The **Django Migrate** command specifically runs the `manage.py migrate` command, which runs any scripts in the `app/migrations` folder that haven't been run previously. In this case, the command runs rhe `0001_initial.py` script in that folder to set up the necessary schema in the database.

    The migration script itself was created by the `manage.py makemigrations` command, which scans the app's `models.py` file, compares it to the current state of the database, and then generates the necessary scripts to migrate the database schema to match the current models. This feature of Django is very powerful as you update and modify your models over time. By generating and running migrations, you keep the models and the database in sync with very little difficulty.

1. select **Debug > Start debugging** or use the **Web Server** button on the toolbar to run the server:

    ![Run web server toolbar button in Visual Studio](media/django/run-web-server-toolbar-button.png)

1. The app created by the template has three pages, Home, About, and Contact, which you navigate between using the top nav bar. Take a minute or two to examine different parts of the app (the About and Contact pages are very similar to the "Django Web Project" and aren't discussed further).

    Specifically select the **Administration** link in the nav bar, which displays a login screen to demonstrate that the administrative interface is authorized only to authenticated administrators. Use the super user credentials created in step 3 and you're routed to the /admin/ page, which is enabled by default when using this project template.

1. Stop the server when done by closing the console window.

### Examine the project contents

As noted before. much of what's in a project created from the "Polls Django Web Project" template should be familiar if you've explored the other project templates in Visual Studio. The following sections summarize the more significant changes and additions.

## Step 6-2: Understand data models

The models for the app, named Poll and Choice, are defined in `app/models.py`. Each is a Python class that derives from `django.db.models.Model`:

```python
from django.db import models
from django.db.models import Sum

class Poll(models.Model):
    """A poll object for use in the application views and repository."""
    text = models.CharField(max_length=200)
    pub_date = models.DateTimeField('date published')

    def total_votes(self):
        """Calculates the total number of votes for this poll."""
        return self.choice_set.aggregate(Sum('votes'))['votes__sum']

    def __unicode__(self):
        """Returns a string representation of a poll."""
        return self.text

class Choice(models.Model):
    """A poll choice object for use in the application views and repository."""
    poll = models.ForeignKey(Poll)
    text = models.CharField(max_length=200)
    votes = models.IntegerField(default=0)

    def votes_percentage(self):
        """Calculates the percentage of votes for this choice."""
        total = self.poll.total_votes()
        return self.votes / float(total) * 100 if total > 0 else 0

    def __unicode__(self):
        """Returns a string representation of a choice."""
        return self.text
```

As you can see, a Poll maintains a description in its `text` field and a publication date in `pub_date`. These are the only fields that exist for the Poll in the database; the `total_votes` field is calculated at runtime.

A Choice is related to a Poll through the `poll` field, contains a description in `text`, and maintains a count for that choice in `votes`. The `votes_percentage` field is calculated at runtime but is not found in the database.

You can confirm exactly what's stored in the database by examining the db.sqlite3 file in the project. There you'll see that a foreign key field like `poll` in the Choice model is actually stored as `poll_id`, but that's handled for you automatically. In general, working with your database in Django means working exclusively through your models so that Django can manage the underlying database on your behalf.

### Seeding the database from samples.json

Initially, the database contains no polls. You can use the administrative interface to add polls, and you can also visit the /seed page on the running site to add polls defined in the app's `samples.json` file.

Specifically, the Django project's `urls.py` has an added URL pattern, `url(r'^seed', app.views.seed, name='seed'),`. The `seed` view in `app/views.py` loads the `samples.json` file and creates the necessary model objects. Django then automatically creates the matching records in the underlying database.

Note the use of the `@login_required` decorator to indicate the authorization level for the view.

```python
@login_required
def seed(request):
    """Seeds the database with sample polls."""
    samples_path = path.join(path.dirname(__file__), 'samples.json')
    with open(samples_path, 'r') as samples_file:
        samples_polls = json.load(samples_file)

    for sample_poll in samples_polls:
        poll = Poll()
        poll.text = sample_poll['text']
        poll.pub_date = timezone.now()
        poll.save()

        for sample_choice in sample_poll['choices']:
            choice = Choice()
            choice.poll = poll
            choice.text = sample_choice
            choice.votes = 0
            choice.save()

    return HttpResponseRedirect(reverse('app:home'))
```

To see the effect, run the app first to see that no polls yet exist. Then visit the /seed URL, and when the app returns to the home page you should see that polls have become available.

## Step 6-3: Use migrations

When you ran the `manage.py makemigrations` command (using the context menu in the Visual Studio) after creating the project, Django created the file `app/migrations/0001_initial.py` file. This file contains a script that creates the initial database tables.

Because you'll inevitably make changes to your models over time, Django makes it easy to keep the underlying database schema up to date with those models. The general workflow is as follows:

1. Make changes to the models in your `models.py` file.
1. In Visual Studio, right-click the project in **Solution Explorer** and select the **Python > Django Make Migrations** command. As before, this command which generates scripts in `app/migrations` to migrate the database from its current state to the new state, but does not affect the database itself.
1. Right-click the project again and select the **Python > Django Migrate** command, which applies the migrations to the database.

Django tracks which migrations have been applied to any given database, such that when you run the Migrate command, it applies whichever migrations are needed. This exceptionally helpful feature makes it very easy to initialize a new database simply by running the Migrate command with all the scripts in place. It also means you can make multiple model changes and migrations on a development computer, then apply the cumulative migrations to your production database all together.

If you forget to run Migrate after making changes to your models, Django fails at runtime with appropriate exceptions.

> [!Tip]
> Although newly generated scripts exist in the `app/migrations` folder and are be applied when running the Migrate command, they don't appear automatically in **Solution Explorer** because they've not been added to the Visual Studio project. To make them visible, first select the **Project > Show All Files** menu command or the toolbar button outlined in the image below, which makes the files appear in **Solution Explorer** with an dotted outline icon. Right-click the files you want and select **Include In Project**.
>
> ![Include in Project command in Solution Explorer](media/django/include-migrations-script-in-project.png)

To see the effect of changing a model, try the following:

1. Add an optional author field to the Poll model in `app/models.py` by adding the following line after the `pub_date` field:

    ```python
    author = models.CharField(max_length=100, blank=True)
    ```

1. Save the file, then right-click the Visual Studio project in **Solution Explorer** and select the **Python > Django Make Migrations** command.
1. Select the **Project > Show All Files** command to see the newly generated script in the `migrations` folder. Right-click that file and select **Include In Project**.
1. If desired, open that file to examine how Django scripts the change from the previous model state to the new state.
1. Right-click the Visual Studio project again and select **Python > Django Migrate** to apply the changes to the database.
1. Open the database in an appropriate viewer to confirm the change.

Overall, Django's migration feature means that you need never manage your database schema manually. Just make changes to your models, generate the migration scripts, and apply them with the Migrate command.

## Step 6-4: Understand the views and page templates created by the project template

Some of the views of the Polls app as generated by the "Polls Django Web Project" template, such as those for the About and Contact pages, are quite similar to those created by the "Django Web Project" template you already know. What's different in the Polls app is its home page makes use of the models, as do several added pages for voting and viewing poll results.

To begin with, the first line in the Django project's `urlpatterns` array in `urls.py` file is more than just a simple routing to an app view: it instead pulls in the app's own `urls.py` file:

```python
from django.conf.urls import url, include
import app.views

urlpatterns = [
    url(r'^', include('app.urls', namespace="app")),
    # ..
]
```

The `app/urls.py` file then contains some more interesting routing code (the comments are added to the file as generated by the project template):

```python
urlpatterns = [
    # Home page routing
    url(r'^$',
        app.views.PollListView.as_view(
            queryset=Poll.objects.order_by('-pub_date')[:5],
            context_object_name='latest_poll_list',
            template_name='app/index.html',),
        name='home'),

    # Routing for a poll page, which use URLs in the form <poll_id>/,
    # where the id number is captured as a group named "pk".
    url(r'^(?P<pk>\d+)/$',
        app.views.PollDetailView.as_view(
            template_name='app/details.html'),
        name='detail'),

    # Routing for <poll_id>/results pages, again using a capture group
    # named pk.
    url(r'^(?P<pk>\d+)/results/$',
        app.views.PollResultsView.as_view(
            template_name='app/results.html'),
        name='results'),

    # Routing for <poll_id>/vote pages, with the capture group named
    # poll_id this time, which becomes an argument passed to the view.
    url(r'^(?P<poll_id>\d+)/vote/$', app.views.vote, name='vote'),
]
```

If you're not familiar with regular expressions as used in the first argument to the `url` method, you can paste the expression into [regex101.com](https://regex101.com/) for an explanation in plain language. (You'll need to escape the forward slashes `/` by adding a back slash, `\`h before them; escaping isn't necessary in Python because of the `r` prefix on the string, meaning "raw").

The short of it is that the poll number in the URL gets translated into a property named the same as the capture group. Those properties are passed as arguments to the view.

You can also see that most of the views are not just direct references to a view function in `app/views.py`. Instead, most refer to a class in that same file that derives from `django.views.generic.ListView` or `django.views.generic.DetailView`. The base classes provide the `as_view` methods, which take a `template_name` argument to identify the template. The `ListView` base class, as used for the home page, also expects a `queryset` property containing the data and a `context_object_name` property with the variable name by which you want to refer to the data in the template, in this case `latest_poll_list`.

Now you can examine the `PollListView` for the home page, which is defined as follows in `app/views.py`:

```python
class PollListView(ListView):
    """Renders the home page, with a list of all polls."""
    model = Poll

    def get_context_data(self, **kwargs):
        context = super(PollListView, self).get_context_data(**kwargs)
        context['title'] = 'Polls'
        context['year'] = datetime.now().year
        return context
```

All that's done here is to identify the model that the view works with (Poll), and overrides the `get_context_data` method to add `title` and `year` values to the context.

The core of the template (`templates/app/index.html`) is as follows:

``html
{% if latest_poll_list %}
<table class="table table-hover">
    <tbody>
        {% for poll in latest_poll_list %}
        <tr>
            <td>
                <a href="{% url 'app:detail' poll.id %}">{{poll.text}}</a>
            </td>
        </tr>
        {% endfor %}
    </tbody>
</table>
{% else %}
<!-- ... other content omitted ... -->
{% endif %}
```

Put simply, the template receives the list of Poll objects in `latest_poll_list`, and then iterates through that list to create a table row that contains a link to each poll using the poll's `text` value. In the `{% url %}` tag, "app:detail" refers to the url pattern in `app/urls.py` named "detail", using `poll.id` as an argument. The effect of this is that Django creates a URL using the appropriate pattern and uses that for the link. This bit of future-proofing means that you can change that URL pattern at any time and the generated links will automatically update to match.

The `PollDetailView` and `PollResultsView` classes in `app/views.py` (not shown here) look almost identical to `PollListView` except that they derive from `DetailView` instead. Their respective templates, `app/templates/details.html` and `app/templates/results.html` then place the appropriate fields from the models within various HTML controls. One unique piece in `details.html` is that the choices for a poll are contained within an HTML form that when submitted does a POST to the /vote URL. As seen earlier, that URL pattern is routed to `app.views.vote` which is implemented as follows:

```python
def vote(request, poll_id):
    """Handles voting. Validates input and updates the repository."""
    poll = get_object_or_404(Poll, pk=poll_id)
    try:
        selected_choice = poll.choice_set.get(pk=request.POST['choice'])
    except (KeyError, Choice.DoesNotExist):
        return render(request, 'app/details.html', {
            'title': 'Poll',
            'year': datetime.now().year,
            'poll': poll,
            'error_message': "Please make a selection.",
    })
    else:
        selected_choice.votes += 1
        selected_choice.save()
        return HttpResponseRedirect(reverse('app:results', args=(poll.id,)))
```

Here, the view doesn't have its own corresponding template like the other pages. Instead, it validates the selected poll, showing a 404 if the poll doesn't exist (just in case someone enters a URL like "vote/1a2b3c"). It then makes sure the voted choice is valid for the poll. If not, the `except` block just renders the details page again with an error message. If the choice is valid, then the view tallies the vote and redirects to the results page.

## Step 6-5: Create a custom administration interface

The last piece of the app that's included with the "Polls Django Web Project" template are custom extensions to the default Django administrative interface. The default interface provides for user and group management, but nothing more. The Polls project template adds features that allow you to manage polls as well.

First of all, the URL patterns in the Django project's `urls.py` has `url(r'^admin/', include(admin.site.urls)),` included by default; the admin/doc pattern is also included by commented out.

The app then contains the file `admin.py`, which Django automatically runs when you visit the administrative interface thanks to the inclusion of `djanfo.contrib.admin` in the `INSTALLED_APPS` array of `settings.py`. The code in that file, as provided by the project template, is as follows:

```python
from django.contrib import admin
from app.models import Choice, Poll

class ChoiceInline(admin.TabularInline):
    """Choice objects can be edited inline in the Poll editor."""
    model = Choice
    extra = 3

class PollAdmin(admin.ModelAdmin):
    """Definition of the Poll editor."""
    fieldsets = [
        (None, {'fields': ['text']}),
        ('Date information', {'fields': ['pub_date']}),
    ]
    inlines = [ChoiceInline]
    list_display = ('text', 'pub_date')
    list_filter = ['pub_date']
    search_fields = ['text']
    date_hierarchy = 'pub_date'

admin.site.register(Poll, PollAdmin)
```

As you can see, the `PollAdmin` class derives from `django.contrib.admin.ModelAdmin` and customizes a number of its fields using names from the `Poll` model, which it manages. These fields are described on [ModelAdmin options](https://docs.djangoproject.com/en/2.0/ref/contrib/admin/#modeladmin-options) in the Django documentaiton.

The call to `admin.site.register` then connects that class to the model (`Poll`) and includes it on the admin interface.

## Next steps

You've now explored the entirety of the "Blank Django Web Project", "Django Web Project", and "Polls Django Web Project" templates in Visual Studio. You've learned all the basics of Django such as using views and templates, and have explored routing, authentication, and using database models. You should now be able to create a web app of your own with any views and models that you need.

Running a web app on your development computer is just one step in making the app available to your customers. Next steps may include the following:

- Customize the 404 page by creating a template named `templates/404.html`. When present, Django uses this template instead of its default one. For more information, see [Error views](https://docs.djangoproject.com/en/2.0/ref/views/#error-views) in the Django documentation.

- Write unit tests in `tests.py`; the Visual Studio project templates provide starting points for these, and more information can be found on [Testing in Django](https://docs.djangoproject.com/en/2.0/topics/testing/) in the Django documentation.

- Deploy the web app to a production server, such as Azure App Service. See [Publish to Azure App Service](publishing-python-web-applications-to-azure-from-visual-studio.md), which includes specific changes needed for Django apps.

- Change the app from SQLite to a production-level data store such as PostgreSQL, MySQL, and SQL Server (all of which can be hosted on Azure). As described on [When to use SQLite](https://www.sqlite.org/whentouse.html) (sqlite.org), SQLite works fine for low to medium traffic sites with fewer than 100K hits/day, but is not recommended for higher volumes. It's also limited to a single computer, so it cannot be used in any multi-server scenario such as load-balancing and geo-replication. For information on Django's support for other databases, see [Database setup](https://docs.djangoproject.com/en/2.0/intro/tutorial02/#database-setup). You can also use the [Azure SDK for Python](azure-sdk-for-python.md) to work with Azure storage services like tables and blobs.

- Set up a continuous integration/continuous deployment pipeline on a service like Visual Studio Team Services (VSTS). In addition to working with source control (on VSTS, GitHub, or elsewhere), you can have VSTS automatically run your unit tests as a pre-requisite for release, and also configure the pipeline to deploy to a staging server for additional tests before deploying to production. VSTS, furthermore, integrates with monitoring solutions like App Insights and closes the whole cycle with agile planning tools. For more information, see:

  - [Create a CI/CD pipeline for Python with the Azure DevOps project](/vsts/build-release/apps/cd/azure/azure-devops-project-python?view=vsts)
  - [Python development in Azure with Visual Studio Team Services (video, 11m 21s)](https://azure.microsoft.com/resources/videos/connect-2017-python-development-in-azure-with-visual-studio-team-services/).


## Going deeper

- Django project code: [Writing your first Django app, part 1](https://docs.djangoproject.com/en/2.0/intro/tutorial01/) (docs.djangoproject.com)
- Administrative utility: [django-admin and manage.py](https://docs.djangoproject.com/en/2.0/ref/django-admin/) (docs.djangoproject.com)
