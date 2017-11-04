---
title: "Language Server Protocol Overview | Microsoft Docs"
ms.custom: ""
ms.date: "11/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6a7d93c2-31ea-4bae-8b29-6988a567ddf2
caps.latest.revision: 1
author: "gregvanl"
ms.author: "gregvanl"
manager: "ghogen"
---
# Language Server Protocol

## What is the Language Server Protocol?

Supporting rich editing features like code auto-completions or "Go to Definition" for a programming language in an editor or IDE is traditionally very challenging and time consuming. Usually it requires writing a domain model (a scanner, a parser, a type checker, a builder and more) in the programming language of the editor or IDE. For example, the Eclipse CDT plugin, which provides support for C/C++ in the Eclipse IDE is written in Java since the Eclipse IDE itself is written in Java. Following this approach, it would have meant implementing a C/C++ domain model in TypeScript for Visual Studio Code, and a separate domain model in C# for Visual Studio. Things would be a lot easier if a development tool could reuse existing libraries. However, these libraries are usually implemented in the programming language itself (for example, good C/C++ domain models are implemented in C/C++). Integrating a C/C++ library into an editor written in TypeScript is technically possible but hard to do. Alternatively, we can run the library in its own process and use inter-process communication to talk to it. The messages sent back and forth form a protocol. The language server protocol (LSP) is the product of standardizing the messages exchanged between a development tool and a language server process.

Using language servers or demons is not a new or novel idea. Editors like Vim and Emacs have been doing this for some time to provide semantic auto-completion support. The goal of the LSP was to simplify these sorts of integrations and provide a useful framework for exposing language features to a variety of tools.

Having a common protocol allows the integration of programming language features into a development tool with minimal fuss by reusing an existing implementation of the language's domain model. A language server back-end could be written in PHP, Python or Java and the LSP lets it be easily integrated into a variety of tools. The protocol works at a common level of abstraction so that a tool can offer rich language services without needing to fully understand the nuances specific to the underlying domain model.

## How work on the LSP started

The LSP has evolved over time and today we are at Version 3.0. Our first efforts started when the concept of a language server was picked up by OmniSharp to provide rich editing features for C#. Initially, OmniSharp used the http protocol with a JSON payload and has been integrated into several editors including [Visual Studio Code](https://code.visualstudio.com).

Around the same time, Microsoft started the work on a TypeScript language server, with the idea of supporting TypeScript in editors like Emacs and Sublime Text. In this implementation, an editor communicates through stdin/stdout with the TypeScript server process and uses a JSON payload inspired by the V8 debugger protocol for requests and responses. The TypeScript server has been integrated into the TypeScript Sublime plugin and VS Code uses this language server for its rich TypeScript editing experience.

After having consumed two different language servers in VS Code, we started to explore a common language server protocol for editors and IDEs. A common protocol enables a language provider to create a single language server that can be consumed by different IDEs. A language server consumer only has to implement the client side of the protocol once. This results in a win-win situation for both the language provider and the language consumer.

We started with the language protocol used by the TypeScript server and made it more general and language neutral. In the next step, we enriched the protocol with more language features using the VS Code language API for inspiration. The protocol itself is backed with JSON-RPC for remote invocation due to its simplicity and support libraries for many programming languages.

We started dogfooding the protocol with what we called linter language servers. A linter language server responds to requests to lint a file and returns a set of detected warnings and errors. We wanted to lint a file as the user edits in a document which means that VS Code will emit many linting requests during an editor session. We therefore wanted to keep a server up and running so that we did not need to start a new linting process for each user edit. We have implemented several linter servers. Examples are VS Code's ESLint and TSLint extensions. These two linter servers are both implemented in TypeScript/JavaScript and run on Node.js. They share a library that implements the client and server part of the protocol.

Soon after, the PowerShell team became interested in adding PowerShell support for VS Code. They had already extracted their language support into a separate server implemented in C#. We then collaborated with them to evolve this PowerShell language server into a server that supports the common language protocol. During this effort, we completed the client side consumption of the language server protocol in VS Code. The result was the first complete common language server protocol implementation, available as the now popular PowerShell extension for VS Code.

## How the LSP works

A language server runs in its own process, and tools like VS or VS Code communicate with the server using the language protocol over JSON-RPC. Another nice side effect of the language server operating in a dedicated process is that performance issues related to a single process model are avoided. The actual transport channel can either be stdio, sockets, named pipes, or node ipc if both the client and server are written in Node.js.

Below is an example for how a tool and a language server communicate during a routine editing session:

![lsp flow diagram](media/lsp-flow-diagram.png)

* **The user opens a file (referred to as a document) in the tool**: The tool notifies the language server that a document is open ('textDocument/didOpen'). From now on, the truth about the contents of the document is no longer on the file system but kept by the tool in memory.

* **The user makes edits**: The tool notifies the server about the document change ('textDocument/didChange') and the semantic information of the program is updated by the language server. As this happens, the language server analyses this information and notifies the tool with the detected errors and warnings ('textDocument/publishDiagnostics').

* **The user executes "Go to Definition" on a symbol in the editor**: The tool sends a 'textDocument/definition' request with two parameters: (1) the document URI and (2) the text position from where the Go to Definition request was initiated to the server. The server responds with the document URI and the position of the symbol's definition inside the document.

* **The user closes the document (file)**: A 'textDocument/didClose' notification is sent from the tool, informing the language server that the document is now no longer in memory and that the current contents is now up to date on the file system.

This example illustrates how the protocol communicates with the language server at the level of editor features like "Go to Definition", "Find all References". The data types used by the protocol are editor or IDE 'data types' like the currently open text document and the position of the cursor. The data types are not at the level of a programming language domain model which would usually provide abstract syntax trees and compiler symbols (for example, resolved types, namespaces, ...). This simplifies the protocol significantly.

Now let's look at the 'textDocument/definition' request in more detail. Below are the payloads that go between the client tool and the language server for the "Go to Definition" request in a C++ document.

This is the request:

```json
{
    "jsonrpc": "2.0",
    "id" : 1,
    "method": "textDocument/definition",
    "params": {
        "textDocument": {
            "uri": "file:///p%3A/mseng/VSCode/Playgrounds/cpp/use.cpp"
        },
        "position": {
            "line": 3,
            "character": 12
        }
    }
}
```

This is the response:

```json
{
    "jsonrpc": "2.0",
    "id": "1",
    "result": {
        "uri": "file:///p%3A/mseng/VSCode/Playgrounds/cpp/provide.cpp",
        "range": {
            "start": {
                "line": 0,
                "character": 4
            },
            "end": {
                "line": 0,
                "character": 11
            }
        }
    }
}
```

In retrospect, describing the data types at the level of the editor rather than at the level of the programming language model is one of the reasons for the success of the language server protocol. It is much simpler to standardize a text document URI or a cursor position compared with standardizing an abstract syntax tree and compiler symbols across different programming languages.

When a user is working with different languages, VS Code typically starts a language server for each programming language. The example below shows a session where the user works on Java and SASS files.

![java and sass](media/lsp-java-and-sass.png)

We quickly learned that not every language server can support all features defined by the protocol. We therefore introduced the concept of 'capabilities'. With capabilities, the client and server announces their supported feature set. As an example, a server announces that it can handle the 'textDocument/definition' request, but it might not handle the 'workspace/symbol' request. Similarly, clients can announce that they are able to provide 'about to save' notifications before a document is saved, so that a server can compute textual edits to automatically format the edited document.

The actual integration of a language server into a particular tool is not defined by the language server protocol and is left to the tool implementors. Some tools integrate language servers generically by having an extension that can start and talk to any kind of language server. Others, like VS Code, create a custom extension per language server, so that an extension is still able to provide some custom language features.

To simplify the implementation of language servers and clients, there are libraries or SDKs for the client and server parts. These libraries are provided for different languages. For example, we maintain a [language client npm module](https://www.npmjs.com/package/vscode-languageclient) to ease the integration of a language server into a VS Code extension and another [language server npm module](https://www.npmjs.com/package/vscode-languageserver) to write a language server using Node.js. This is the current [list](https://github.com/Microsoft/language-server-protocol/wiki/Protocol-Implementations) of support libraries.

## Going forward with the LSP

Version 3.0 of the protocol has been around for some time. Our current focus is to stabilize and clarify the specification. This is expressed by the backlog for the next minor release. We also have a good backlog of requests for the 4.0 version of the protocol. Now is a good time for the community to come together and help shape what should be next by weighing in on the scenarios that are most important to you.

## Using the Language Server Protocol in Visual Studio

* [Adding a Language Server Protocol extension](adding-an-lsp-extension.md) - Learn about integrating a language server into Visual Studio.
