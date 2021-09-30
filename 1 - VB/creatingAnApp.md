# creating console app
1. using the dotnet new comman create a new console app in vb
    - run 'dotnet new console --language vb -o <Name of your application>'
    `--language` is a flag for letting the cli know that you want to use vb syntax
    `-o` is a flag for letting the cli know that you want that project in a specific folder
2. create .gitignore file for ignoring build output
    - run `dotnet new gitignore`
    - OR you can create your own gitignore file, got to gitignore.io and copy what it gives you in the .gitignore file you just created
3. Run you new app
    - cd into the folder that contains your application
    - run the command `dotnet run` or you can run `dotnet run --project <path to your project folder`

    - If you get an error `could not find project to run` you are probably in the incorrect directory