# Link

-   https://docs.microsoft.com/en-us/dotnet/core/tutorials/using-on-macos

## Tutorial Steps

1. Create a dir then cd into that dir
2. run `dotnet new sln` to create `golden.sln`
3. run `dotnet new classlib -o library` produces two files,`library.csproj` and `Class1.cs`, in the library folder
4. run `dotnet sln` to add the newly created `library.csproj` project to the solution
5. run `dotnet add library package Newtonsoft.Json` to add Package Reference to Item Group in library file.
6. run `dotnet restore` similar to npm install

## Notes

-   Our library methods serialize and deserialize objects in JSON format
-   To support JSON serialization and deserialization, add a reference to the `Newtonsoft.Json` NuGet package
-   The `dotnet add` command adds new items to a project.
-   To add a reference to a NuGet package, use the `dotnet add package` command and specify the name of the package. (step 5)
-   `dotnet restore` restores dependencies and creates an obj folder inside library with three files in it, plus a `project.assets.json` file
