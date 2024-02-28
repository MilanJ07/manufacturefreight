# Manufacture Freight

## Solution Structure
- src
    - Api - .net core web api project
    - BusinessLogic - application layer with business logic and services
    - DataAccess* - data layer and data entities
    - Models - common model objects
    - Utilities - common shared components
- tests
    - Api.Tests - api layer tests
    - BusinessLogic.Tests - business layer tests
    - DataAccess.Tests* - data layer tests
    - Models.Tests - model object tests
    - Utilities.Tests - utilities tests
	
## Features
- Swagger
- Unhandled Exception handler
- Invalid ModelState Response Factory - creates correct 400-BadRequest responses
- [Automapper](https://automapper.org/) to convert objects between Business layer and Data Access layer
- Logging
    - Serilog 
        - Text formatter in 'Development' environment
- Supported IDE
    - Visual Studio
        - [Unit Test Boilerplate Generator](https://marketplace.visualstudio.com/items?itemName=RandomEngy.UnitTestBoilerplateGenerator) recommended extension 
    - Visual Studio Code
        - .code-workspace file
        - debugging, build, and test tasks
        - launch is configured to open swagger in browser
        - [.Net Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer) recommended extension
- Unit Tests - Tests follow pattern used by [Unit Test Boilerplate Generator Extension](https://marketplace.visualstudio.com/items?itemName=RandomEngy.UnitTestBoilerplateGenerator)
    - xUnit
    - Moq