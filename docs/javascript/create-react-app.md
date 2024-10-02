---
title: Create a React app in Visual Studio
description: Create, build, and run a simple React front-end web application project from a Visual Studio template, and set basic properties for the project.
ms.date: 10/02/2024
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

In this tutorial, you create a React front-end for a ToDo list web app using JavaScript and Visual Studio 2022. The code for this app can be found at [sayedihashimi/todojswebapp](https://github.com/sayedihashimi/todojswebapp).

## Prerequisites

Make sure to install the following:

- Visual Studio 2022 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page to install it for free.
- npm ([`https://www.npmjs.com/`](https://www.npmjs.com/package/npm)), which is included with Node.js.

## Create the React ToDo list app

1. In Visual Studio, select **File > New > Project** to open the Create a New Project dialog, select the **React App** JavaScript template, and then choose **Next**.

   :::image type="content" source="media/vs-2022/react-choose-standalone-template.png" alt-text="Screenshot showing choosing a template":::

1. Name the project `TodoWebApp` and select **Create**.

   This creates the JavaScript project using the [vite command line tool](https://vitejs.dev/). 

1. In Solution Explorer, right-click the `src` folder and choose **Add > New Folder**. and create a new folder named `components`.

   It’s a common convention to place components in a components folder, but this is not required. 

1. Right-click the new folder, select **Add > React JSX Component File**, name it `TodoList`, and click **Add**.

   :::image type="content" source="media/vs-2022/react-add-jsx-component.png" alt-text="Screenshot showing adding a JSX component":::

   This creates a new JSX file in the components folder.

1. Open the `TodoList` component and replace the default content with the following:

     ```jsx
     function TodoList() {
       return (
         <h2>TODO app contents</h2>
       );
     }
     ```

   This component displays a header, which you will replace later.

   Next, wire up this component in the app. `App.jsx` is the main component that is loaded, which represents the todo application. This component is used in the `main.jsx` file. 

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

1. To add the TodoList component, place your cursor inside the fragment and then type `<TodoL RETURN`. This adds the component and the import statement.

   :::image type="content" source="media/vs-2022/react-add-jsx-component-to-app.gif" alt-text="Screenshot showing adding a JSX component to the app":::

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

## Run the App

Select the **Start Debugging** button from the toolbar or press the F5 keyboard shortcut.

## Add functionality to the ToDo list app

1. **Update `TodoList.jsx`**
   - Add the UI needed to show and manage todo entries:
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

2. **Use `useState` Hook**
   - Import `useState` and create state variables:
     ```jsx
     import { useState } from 'react';

     const [tasks, setTasks] = useState(["Drink some coffee", "Create a TODO app", "Drink some more coffee"]);
     const [newTaskText, setNewTaskText] = useState("");
     ```

3. **Handle Input and Add Task**
   - Add functions to handle input change and add tasks:
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

4. **Update the View**
   - Add buttons for delete, move up, and move down:
     ```jsx
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
     ```

5. **Refactor to Use `TodoItem` Component**
   - Create a new component `TodoItem` and update `TodoList` to use it:
     ```jsx
     import PropTypes from 'prop-types';

     function TodoItem({ task, deleteTaskCallback, moveTaskUpCallback, moveTaskDownCallback }) {
       return (
         <li aria-label="task">
           <span className="text">{task}</span>
           <button type="button" aria-label="Delete task" className="delete-button" onClick={() => deleteTaskCallback()}>🗑️</button>
           <button type="button" aria-label="Move task up" className="up-button" onClick={() => moveTaskUpCallback()}>⇧</button>
           <button type="button" aria-label="Move task down" className="down-button" onClick={() => moveTaskDownCallback()}>⇩</button>
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

6. **Add Styling**
   - Create `TodoList.css` and add styles:
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

## Resources

- Code for this sample
- Visual Studio JavaScript and TypeScript projects

## Feedback

You can share feedback with us via Developer Community: report any bugs or issues via report a problem and share your suggestions for new features or improvements to existing ones. You can also leave a comment here or reach out to Sayed on Twitter at @SayedIHashimi.
