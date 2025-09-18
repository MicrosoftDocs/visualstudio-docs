---
title: Create a React app in Visual Studio
description: Create, build, and run a React to-do list web application project from a Visual Studio template.
ms.date: 9/17/2025
ms.topic: tutorial
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
monikerRange: '>= vs-2022'
---

# Create a React app in Visual Studio

In this tutorial, you create a React front-end for a to-do list web app using JavaScript and Visual Studio 2022. The code for this app can be found at [ToDoJSWebApp](https://go.microsoft.com/fwlink/?linkid=2291103&clcid=0x409).

## Prerequisites

Make sure to install the following:

- Visual Studio 2022 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page to install it for free.
- npm ([`https://www.npmjs.com/`](https://www.npmjs.com/package/npm)), which is included with Node.js.

## Create the React ToDo List app

1. In Visual Studio, select **File > New > Project** to open the Create a New Project dialog, select the **React App** JavaScript template, and then choose **Next**.

   :::image type="content" source="media/vs-2022/react-choose-standalone-template.png" alt-text="Screenshot showing choosing a template.":::

1. Name the project `TodoWebApp` and select **Create**.

   This creates the JavaScript project using the [vite command line tool](https://vitejs.dev/). 

1. In Solution Explorer, right-click the `src` folder and choose **Add > New Folder**. and create a new folder named `components`.

   It’s a common convention to place components in a components folder, but this is not required. 

1. Right-click the new folder, select **Add > New Item**, then choose **React JSX Component File** in the dialog box, name it `TodoList`, and click **Add**. If you don't see a list of item templates, select **Show All Templates**.

   :::image type="content" source="media/vs-2022/react-add-jsx-component.png" alt-text="Screenshot showing adding a JSX component.":::

   This creates a new JSX file in the components folder.

1. Open the `TodoList` component and replace the default content with the following:

     ```jsx
     export default function TodoList() {
       return (
         <h2>TODO app contents</h2>
       );
     }
     ```

   This component displays a header, which you will replace later.

   Next, wire up this component in the app. `App.jsx` is the main component that is loaded, which represents the to-do list application. This component is used in the `main.jsx` file. 

1. In Solution Explorer, open `App.jsx`, remove all imports from the top, and clear out the contents of the return statement. The file should look like the following.

     ```jsx
     function App() {
       return (
         <>
           <TodoList />
         </>
       );
     }
     export default App;
     ```

1. To add the TodoList component, place your cursor inside the fragment and then type `<TodoL RETURN` or `<TodoL TAB`. This adds the component. It might also automatically add the import statement.

   :::image type="content" source="media/vs-2022/react-add-jsx-component-to-app.gif" alt-text="Screenshot showing adding a JSX component to the app.":::

   If the import statement is not added automatically, add it at the beginning of the file by typing `import TodoL` and pressing the **TAB** key.

   Next, clear out the CSS files.

1. Open `App.css` and delete all contents.

1. Open `Index.css` and remove all contents except the styles for `:root`:

     ```css
     :root {
       font-family: Inter, system-ui, Avenir, Helvetica, Arial, sans-serif;
       line-height: 1.5;
       font-weight: 400;
       color-scheme: light dark;
       color: rgba(255, 255, 255, 0.87);
       background-color: #242424;
     }
     ```

## Run the app

Select the **Start Debugging** button from the toolbar or press the F5 keyboard shortcut.

The app opens in a browser window.

:::image type="content" source="media/vs-2022/react-running-app.png" alt-text="Screenshot showing the app running in the browser.":::

## Add to-do list functions to the app

You can leave the app running. As you make changes, the app automatically refreshes with the latest content using Vite's hot module replacement support. Some actions, such as adding folders or renaming files, require that you stop debugging and then restart the app, but in general you can leave it running in the background as you develop your app. Open the `TodoList.jsx` component so that we can start to define it.

1. In Solution Explorer, open `TodoList.jsx` and add the UI needed to show and manage to-do list entries. Replace the content with the following code:

     ```jsx
     function TodoList() {
       return (
         <div>
           <h1>TODO</h1>
           <div>
             <input type="text" placeholder="Enter a task" required aria-label="Task text" />
             <button className="add-button" aria-label="Add task">Add</button>
           </div>
           <ol id="todo-list">
             <p>existing tasks will be shown here</p>
           </ol>
         </div>
       );
     }
     export default TodoList;
     ```

   The preceding code adds an input box for the new to-do task and a button to submit the input. Next, you wire up the Add button. Use the [useState](https://react.dev/reference/react/useState) React hook to add two state variables, one for the task that is getting added, and another to store the existing tasks. For this tutorial, the tasks get stored in memory and not persistent storage.

1. Add the following import statement to `TodoList.jsx` to import `useState`.

   ```jsx
   import { useState } from 'react'
   ```

1. Next, use that hook to create the state variables. Add the following code in the `TodoList` function above the return statement.

   ```jsx
   const [tasks, setTasks] = useState(["Drink some coffee", "Create a TODO app", "Drink some more coffee"]);
   const [newTaskText, setNewTaskText] = useState("");
   ```

   This sets up two variables, `tasks` and `newTaskText`, for the data and two functions that you can call to update those variables, `setTasks` and `setNewTasks`. When a value for a state variable is changed, React automatically re-renders the component.

   You're almost ready to update *TodoList.jsx* to show the to-do items as a list, but there is an important React concept to learn first.

   In React, when you display a list of items you need to add a key to uniquely identify each item in the list. This feature is explained in depth in the React docs at [Rendering Lists](https://react.dev/learn/rendering-lists), but here you'll learn the basics. You have a list of to-do items to display, and you need to associate a unique key for each item. The key for each item should not change, and for this reason you can't use the index of the item in the array as the key. You need an ID that won't change throughout the lifetime of those values. You'll use [randomUUID()](https://developer.mozilla.org/en-US/docs/Web/API/Crypto/randomUUID) to create a unique ID for each to-do item.

1. Create *TodoList.jsx* using a UUID as the key for each to-do item. Update *TodoList.jsx* with the following code.

    ```jsx
    import React, { useState } from 'react';
    
    const initialTasks = [
        { id: self.crypto.randomUUID(), text: 'Drink some coffee' },
        { id: self.crypto.randomUUID(), text: 'Create a TODO app' },
        { id: self.crypto.randomUUID(), text: 'Drink some more coffee' }
    ];
    
    function TodoList() {
        const [tasks, setTasks] = useState(initialTasks);
        const [newTaskText, setNewTaskText] = useState("");
    
        return (
            <article
                className="todo-list"
                aria-label="task list manager">
                <header>
                    <h1>TODO</h1>
                    <form className="todo-input" aria-controls="todo-list">
                        <input
                            type="text"
                            placeholder="Enter a task"
                            value={newTaskText} />
                        <button
                            className="add-button">
                            Add
                        </button>
                    </form>
                </header>
                <ol id="todo-list" aria-live="polite" aria-label="task list">
                    {tasks.map((task, index) =>
                        <li key={task.id}>
                            <span className="text">{task.text}</span>
                        </li>
                    )}
                </ol>
            </article>
        );
    }
    export default TodoList;
    ```

   Since the ID values are assigned outside the TodoList function, you can be sure the values won't change if the page is re-rendered. When you try the app in this state, you'll notice that you can't type into the todo input element. This is because the input element is bound to `newTaskText`, which has been initialized to a blank string. To allow users to add new tasks, you need to handle the `onChange` event on that control. You also need to implement the Add button support.

1. Add the required functions immediately before the return statement in the TodoList function.

    ```jsx
    function handleInputChange(event) {
        setNewTaskText(event.target.value);
    }
    
    function addTask() {
        if (newTaskText.trim() !== "") {
            setTasks(t => [...t, { id: self.crypto.randomUUID(), text: newTaskText }]);
            setNewTaskText("");
        }
        event.preventDefault();
    }
    ```

   In the `handleInputChanged` function, the new value from the input field is passed in through `event.target.value`, and that value is used to update the value for the `newTaskText` variable with `setNewTaskText`. In the `addTask` function, add the new task to the list of existing tasks using `setTasks` and set the ID of the item as a new UUID value. Update the input element to include `onChange={handleInputChange}` and update the Add button to include `onClick={addTask}`. This code wires up the event to the function that handles that event. Following this, you should be able to add a new task to the task list. New tasks are added to the bottom of the list. To make this app more useful, you need to add support to delete tasks and to move a task up or down.

1. Add the functions to support delete, move up and move down, and then update the markup to show a button for each action. Add the following code in the TodoList function above the return statement.

    ```jsx
    function deleteTask(id) {
        const updatedTasks = tasks.filter(task => task.id != id);
        setTasks(updatedTasks);
    }
    
    function moveTaskUp(index) {
        if (index > 0) {
            const updatedTasks = [...tasks];
            [updatedTasks[index], updatedTasks[index - 1]] = [updatedTasks[index - 1], updatedTasks[index]];
            setTasks(updatedTasks);
        }
    }
    
    function moveTaskDown(index) {
        if (index < tasks.length) {
            const updatedTasks = [...tasks];
            [updatedTasks[index], updatedTasks[index + 1]] = [updatedTasks[index + 1], updatedTasks[index]];
            setTasks(updatedTasks);
        }
    }
    ```

   The delete function takes in the task ID and deletes that one from the list and uses the [Array filter()](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/filter) method to create a new array excluding the selected item and then calls `setTasks()`. The other two functions take in the index of the item because this work is specific to the item ordering. Both `moveTaskUp()` and `moveTaskDown()` use [array destructuring assignment](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Destructuring_assignment) to swap the selected task with its neighbor.

1. Next, update the view to include these three buttons. Update the return statement to contain the following.

    ```jsx
    return (
        <article
            className="todo-list"
            aria-label="task list manager">
            <header>
                <h1>TODO</h1>
                <form className="todo-input" onSubmit={addTask} aria-controls="todo-list">
                    <input
                        type="text"
                        required
                        autoFocus
                        placeholder="Enter a task"
                        value={newTaskText}
                        aria-label="Task text"
                        onChange={handleInputChange} />
                    <button
                        className="add-button"
                        aria-label="Add task">
                        Add
                    </button>
                </form>
            </header>
            <ol id="todo-list" aria-live="polite">
                {tasks.map((task, index) =>
                    <li key={task.id}>
                        <span className="text">{task.text}</span>
                        <button className="delete-button" onClick={() => deleteTask(task.id)}>
                            🗑️
                        </button>
                        <button className="up-button" onClick={() => moveTaskUp(index)}>
                            ⇧
                        </button>
                        <button className="down-button" onClick={() => moveTaskDown(index)}>
                            ⇩
                        </button>
                    </li>
                )}
            </ol>
        </article>
    );
    ```

   You've added the buttons needed to perform the tasks we discussed previously. You're using Unicode characters as icons on the buttons. In the markup, there are some attributes added to support adding some CSS later. You might also notice the use of [aria attributes](https://www.w3.org/WAI/standards-guidelines/aria/) to improve accessibility, which are optional but highly recommended. If you run the app, it should look like the following illustration.

   :::image type="content" source="media/vs-2022/react-running-app-with-list.png" alt-text="Screenshot showing the app running and showing a list":::

   You should now be able to perform the following in the TODO web app.

   - Add task
   - Delete task
   - Move task up
   - Move task down

   These functions work, but you can refactor to build a reusable component to display the to-do items. The markup for the to-do item goes into a new component, TodoItem. Because the management of the list stays in the Todo component, you can pass callbacks to the Delete and Move buttons.

1. To get started, right-click the *components* folder in Solution Explorer and select **Add > New Item**.

1. In the dialog that opens, select the **React JSX Component File**, give it the name TodoItem, and select **Add**.

1. Add the following code to the TodoItem.

   In this code, you pass in the task and callbacks as properties to this new component. 

    ```jsx
    import PropTypes from 'prop-types';
    
    function TodoItem({ task, deleteTaskCallback, moveTaskUpCallback, moveTaskDownCallback }) {
        return (
            <li aria-label="task" >
                <span className="text">{task}</span>
                <button
                    type="button"
                    aria-label="Delete task"
                    className="delete-button"
                    onClick={() => deleteTaskCallback()}>
                    🗑️
                </button>
                <button
                    type="button"
                    aria-label="Move task up"
                    className="up-button"
                    onClick={() => moveTaskUpCallback()}>
                    ⇧
                </button>
                <button
                    type="button"
                    aria-label="Move task down"
                    className="down-button"
                    onClick={() => moveTaskDownCallback()}>
                    ⇩
                </button>
            </li>
        );
    }
    
    TodoItem.propTypes = {
        task: PropTypes.string.isRequired,
        deleteTaskCallback: PropTypes.func.isRequired,
        moveTaskUpCallback: PropTypes.func.isRequired,
        moveTaskDownCallback: PropTypes.func.isRequired,
    };
    
    export default TodoItem;
    ```

   The preceding code contains the markup from the Todo component and at the end of it you declare the `PropTypes`. Props are used to pass data from a parent component to child components. For more info on Props, see [Passing Props to a Component – React](https://react.dev/learn/passing-props-to-a-component). Because the delete and move functions are being passed in as callbacks, the `onClick` handler needs to be updated to call into those callbacks.

1. Add the required code. The full code for TodoList that uses the TodoItem component is shown here.

    ```jsx
    import React, { useState } from 'react'
    import TodoItem from './TodoItem'
    
    const initialTasks = [
        { id: self.crypto.randomUUID(), text: 'Drink some coffee' },
        { id: self.crypto.randomUUID(), text: 'Create a TODO app' },
        { id: self.crypto.randomUUID(), text: 'Drink some more coffee' }
    ];
    
    function TodoList() {
        const [tasks, setTasks] = useState(initialTasks);
        const [newTaskText, setNewTaskText] = useState("");
        function handleInputChange(event) {
            setNewTaskText(event.target.value);
        }
        function addTask() {
            if (newTaskText.trim() !== "") {
                setTasks(t => [...t, { id: self.crypto.randomUUID(), text: newTaskText }]);
                setNewTaskText("");
            }
            event.preventDefault();
        }
        function deleteTask(id) {
            const updatedTasks = tasks.filter(task => task.id !== id);
            setTasks(updatedTasks);
        }
        function moveTaskUp(index) {
            if (index > 0) {
                const updatedTasks = [...tasks];
                [updatedTasks[index], updatedTasks[index - 1]] = [updatedTasks[index - 1], updatedTasks[index]];
                setTasks(updatedTasks);
            }
        }
        function moveTaskDown(index) {
            if (index < tasks.length) {
                const updatedTasks = [...tasks];
                [updatedTasks[index], updatedTasks[index + 1]] = [updatedTasks[index + 1], updatedTasks[index]];
                setTasks(updatedTasks);
            }
        }
        return (
            <article
                className="todo-list"
                aria-label="task list manager">
                <header>
                    <h1>TODO</h1>
                    <form onSubmit={addTask} aria-controls="todo-list">
                        <input
                            type="text"
                            required
                            placeholder="Enter a task"
                            value={newTaskText}
                            aria-label="Task text"
                            onChange={handleInputChange} />
                        <button
                            className="add-button"
                            aria-label="Add task">
                            Add
                        </button>
                    </form>
                </header>
                <ol id="todo-list" aria-live="polite">
                    {tasks.map((task, index) =>
                        <TodoItem
                            key={task.id}
                            task={task.text}
                            deleteTaskCallback={() => deleteTask(task.id)}
                            moveTaskUpCallback={() => moveTaskUp(index)}
                            moveTaskDownCallback={() => moveTaskDown(index)}
                        />
                    )}
                </ol>
            </article>
        );
    }
    
    export default TodoList;
    ```

   Now, the TodoItem component is used to render each to-do item. Notice that the key is set to `task.id`, which contains the UUID value for that task. When you run the app, you shouldn’t see any changes to the look or behavior of the app because you refactored it to use TodoItem.

   Now that you have all the basic functions supported, it’s time to start adding some styling to this to make it look nice. Start by adding a link in *Index.html* for a font family, Inter, that you will use for this app. In *Index.html*, there are some other items that need to be cleaned up. Specifically, the title should be updated and you want to replace the *vite.svg* file that is currently used as the icon.

1. Update *Index.html* with the following content.

    ```html
    <!doctype html>
    <html lang="en">
        <head>
            <meta charset="UTF-8" />
            <link rel="icon" type="image/svg+xml" href="/checkmark-square.svg" />
            <meta name="viewport" content="width=device-width, initial-scale=1.0" />
            <title>TODO app</title>
            <link href='https://fonts.googleapis.com/css?family=Inter' rel='stylesheet'>
            <script type="module" defer src="/src/main.jsx"></script>
        </head>
        <body>
        </body>
    </html>
    ```

1. Edit *main.jsx* file to replace `root` with `main` when calling `createRoot`.

   The complete code for *main.jsx* is shown here.

    ```jsx
    import { StrictMode } from 'react'
    import { createRoot } from 'react-dom/client'
    import App from './App.jsx'
    import './index.css'
    
    createRoot(document.querySelector('main')).render(
        <StrictMode>
            <App />
        </StrictMode>,
    )
    ```

   In addition to these changes, the file *checkmark-square.svg* was added to the public folder. This is an SVG from the FluentUI checkmark square image, which you can download directly. (There's a package that you can use for a more integrated experience, but that’s outside the scope of this article.)

   Next, update the styles of the TodoList component.

1. In the components folder, add a new CSS file named *TodoList.css*. You can right-click on the project and select **Add > New Item** and then select **Style Sheet**. Give the file the name *TodoList.css*.

1. Add the following code to *TodoList.css*.

    ```css
    .todo-list {
        background-color: #1e1e1e;
        padding: 1.25rem;
        border-radius: 0.5rem;
        box-shadow: 0 0.25rem 0.5rem rgba(0, 0, 0, 0.3);
        width: 100%;
        max-width: 25rem;
    }
    
    .todo-list h1 {
        text-align: center;
        color: #e0e0e0;
    }
    
    .todo-input {
        display: flex;
        justify-content: space-between;
        margin-bottom: 1.25rem;
    }
    
    .todo-input input {
        flex: 1;
        padding: 0.625rem;
        border: 0.0625rem solid #333;
        border-radius: 0.25rem;
        margin-right: 0.625rem;
        background-color: #2c2c2c;
        color: #e0e0e0;
    }
    
    .todo-input .add-button {
        padding: 0.625rem 1.25rem;
        background-color: #007bff;
        color: #fff;
        border: none;
        border-radius: 0.25rem;
        cursor: pointer;
    }
    
    .todo-input .add-button:hover {
        background-color: #0056b3;
    }
    
    .todo-list ol {
        list-style-type: none;
        padding: 0;
    }
    
    .todo-list li {
        display: flex;
        justify-content: space-between;
        align-items: center;
        padding: 0.625rem;
        border-bottom: 0.0625rem solid #333;
    }
    
    .todo-list li:last-child {
        border-bottom: none;
    }
    
    .todo-list .text {
        flex: 1;
    }
    
    .todo-list li button {
        background: none;
        border: none;
        cursor: pointer;
        font-size: 1rem;
        margin-left: 0.625rem;
        color: #e0e0e0;
    }
    
    .todo-list li button:hover {
        color: #007bff;
    }
    
    .todo-list li button.delete-button {
        color: #ff4d4d;
    }
    
    .todo-list li button.up-button,
    .todo-list li button.down-button {
        color: #4caf50;
    }
    ```

1. Next, edit *TodoList.jsx* to add the following import at the top of the file.

    ```jsx
    import './TodoList.css';
    ```

1. Refresh the browser after saving the changes. This should improve the styling of the app. The app should look like the following.

   :::image type="content" source="media/vs-2022/react-running-app-final.png" alt-text="Screenshot showing the final version of the app running.":::

   Now you've built a working to-do list app that stores the to-do items in memory. From this point, you could update the app to store the to-do items in [localStorage](https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage)/[IndexedDb](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API), or integrate this with a server-side database, or other backend, for more permanent storage.

## Summary

In this tutorial, you created a new React app using Visual Studio. The app consists of a to-do list, which includes support to add tasks, delete tasks, and reorder them. You created two new React components and used those throughout this tutorial.

## Resources

- Code for this sample at [ToDoJSWebApp](https://go.microsoft.com/fwlink/?linkid=2291103&clcid=0x409)
- [Visual Studio JavaScript and TypeScript projects](/visualstudio/javascript)
