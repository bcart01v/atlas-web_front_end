# Atlas
Web Front End

Developer Tools



## Developer Tools Project Overview

This project serves as an introduction to the Developer Tools used in web development. Being relatively new to Mac, I am still familiarizing myself with Safari's Developer features, so I chose to use the Chrome web browser for this project.

The project offers an intuitive intro to the features and functions of Developer Tools. It highlights various tabs and options, demonstrating their utility in web development tasks.

#### Key Components:
* Elements Tab: Inspect and modify HTML and CSS directly within the browser.
* Console Tab: Execute JavaScript commands and debug scripts in real-time.
* Network Tab: Monitor network requests, analyze loading times, and optimize resource management.
* Performance Tab: Profile and enhance the performance of web applications.
* Application Tab: Inspect storage, service workers, and other resources.


By working through this project, I gained practical experience with the tools essential for efficient web development and debugging.


## Learning Objectives

#### What Developer Tools in your browser are
Developer Tools (DevTools) are a set of web authoring and debugging tools built into web browsers. These tools allow developers to inspect and edit the HTML and CSS of a webpage, debug JavaScript code, monitor network activity, analyze page performance, and much more. They provide a comprehensive environment for web development and troubleshooting.

#### How to open the Developer Tools on Chrome, Firefox, Safari, and Edge.

In Browser options, the keyboard shortcuts are the same with the exception of the Mac. The Mac follows the same Keyboard Shortcuts as the mac options for other browsers, with the exception of the function key. 

Press `F12` or `Ctrl + Shift + I` (Windows/Linux) or `Cmd + Option + I` (Mac).

#### How to use the elements tab to edit HTML and CSS
When in the `Elements` Tab, you can right click -> select the element you wish to edit which will bring you to the HTML for that element. You can then edit that HTML from the inspector. For CSS, you switch to the Styles tab and edit existing CSS properties, or add new ones!

#### How to audit a page according to the tips suggested by Lighthouse

In Chrome Web Developer Tools, there is a `Lighthouse` tab you can select. From there, you select the type of audit you wish to run such as Performance, Accessibility, Best Practices, SEO, or PWA. You can also choose the type of device the audit will emulate (Desktop or Mobile).

#### How to create and run snippets on a page

From the `Sources` tab, there is a `Snippets` Pane. Some Browsers have a 'New' option, and some have the '+' option to create a snippet. You can name the snippet whatever you wish, and enter the logic you want to run in your snippet. From there, some browsers have a `Run` option, and some have a play button. Alternatively, you can use `Ctrl + Enter` (Or `Cmd + Enter` on a Mac)

#### How to get information about files and server configurations

From the `Network` tab, if you re-load the page it will display all things required to complete the layout and styling of the webpage. On Chrome, you can right click your reload button for additional reload options, like Clear Cache and reload, or Hard Reload so everything reloads entirely. You can click on individual network requests to see their detailed information You can also select the Headers tab to view request and response headers, including the server configurations. The Preview and Response tabs shows the content of the files. 

#### How to block requests

Also in the Network tab, you can right click on any request and select `Block Request URL`

#### How to know how much JavaScript or CSS is used on a page

In the `Sources` tab, you can run the Coverage tool by using the Keyboard shortcut `Ctrl + Shift + P` (Windows/Linux) or `Cmd + Shift + P` (Mac) to open the `Command Menu`, type `Coverage` and select `Show Coverage`. Click the Reload button in the `Coverage` tab to start capturing data. 

#### How to detect 404 issues

In the `Network` tab, reload the page. You have the option to filter by status code `404` to show only requests that returned a 404 Status code. Alternatively, any entry with a red status code indicates it returned a 404 Status code.

#### How to move elements on a webpage

You can right click an element you want to move and select `Inspect`. In the `Elements` tab, you can click and hold the Element to move, and drag it in a new location in the DOM tree. 
