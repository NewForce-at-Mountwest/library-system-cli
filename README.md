# Library System Command Line Interface

## About this project
This is a command line application designed for librarians to manage their inventory at the Huntington Library.

It's also a way to learn how to contribute to open source projects. We're building this app together. Everyone can fix bugs, pull tickets, and suggest new pieces of functionality.

You can read more about contributing to open source projects [here](https://hackernoon.com/how-to-get-started-with-open-source-2b705e726fea) and [here](https://codeburst.io/how-to-start-contributing-to-open-source-d9e38b01a5e1).


## Instructions to Run
### To get this project up and running, you'll need a few tools already installed:
1. [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
1. [.NET Core](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install)
1. A code editor of your choice


### To configure your repo, you should:
1. Fork this repo
1. Clone down your forked repo
1. [Point your newly forked repo towards this original repo so that you can sync any changes we make here](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/configuring-a-remote-for-a-fork)
1. Make a branch off of your forked repo and start working
1. When you're ready to make a pull request, you'll request to merge your changes into `upstrea master`. Feel free to ask for help when you get to this point.


### Set up your database
1. Open your project in Visual Studio
1. Open the SQL Server Object Explorer and connect to your instance of SQL Server
1. Right click on the "Databases" folder and select "New Database"
1. Name your database `Library-System`
1. Run [this SQL script](Library-System-CLI/library_system_cli.sql) to create your tables and seed your datbase

### Before you start coding:
Run the following commands in `./LIbrary-System-CLI`:
```
dotnet add package System.Data.SqlClient
dotnet restore
```


## Contributing Guidelines
First of all, thank you for contributing to the Huntington Library System CLI!

Following these guidelines helps to communicate that you respect the time of the developers managing and developing this open source project. In return, they should reciprocate that respect in addressing your issue, assessing changes, and helping you finalize your pull requests.

We love to receive contributions from our community — you! There are many ways to contribute, from writing tutorials or blog posts, improving the documentation, submitting bug reports and feature requests or writing code which can be incorporated into the CLI itself.

### Ground Rules
1. If you want to suggest a new feature or major change, create an feature ticket and tag the core contributors.
1. If you notice a bug in the code base, create a bug ticket.
1. If you start working on a ticket, assign it to yourself so that other people know it's spoken for.
1. The core contributors review Pull Requests and new tickets on a weekly basis.

### Your first contribution
Unsure where to start? You can sort through our issues for beginner and help wanted tags. Beginner issues should involve only a few lines of code. Help wanted issues are slightly more involved.

At this point, you're ready to make your first contribution! Feel free to ask for help-- everybody's a beginner at some point!

### Ready to move on to real world projects? Here are some resources:
1. [A list of open source projects for beginners](https://github.com/MunGell/awesome-for-beginners)
1. [Get an email every day about open issues in projects you want to follow](https://www.codetriage.com/)
1. [List of cool open source JavaScript projects](https://medium.mybridge.co/48-amazing-javascript-open-source-for-the-past-year-v-2019-ce51cdd10fb9)



