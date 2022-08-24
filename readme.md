

Clone the repo

Navigate to solution directory in PowerShell and run the following command
```
dotnet new --install .
```

To see descripton of template with optional parameters (none added as of yet)
```
dotnet new MayvueProblemTemplate -h
```

Create a new folder with whatever name you want for the solution
```
mkdir NewProblem
```

Create a new solution using the template
```
dotnet new MayvueProblemTemplate
```
The created solution will use the name of the folder your currently in and the project we use for our solutions will share the same name.
