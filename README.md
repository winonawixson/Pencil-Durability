# Pencil-Durability

## Pre-Requisites
.Net Core - This project was built using .Net Core version 2.1, but can run on the latest stable version (2.2).
You can visit the following website and download the latest .Net Core SDK
https://dotnet.microsoft.com/download

## How to Build Solution
1. After cloning the repo, navigate into the repo and into the 'Pencil-Durability' folder. 
   'cd Pencil-Durability/PencilDurability/'
2. Run command 'dotnet build'.
3. This should gather dependencies and create a MSBuild file.

## How to Run Solution
1. First build the solution as directed above, then navigate into the Console Application. 
   'cd Pencil-Durability/'
2. Run command 'dotnet run'.
3. This should just output "Hello World!" - validates the solution is built properly.

## How To Run Tests for Solution
1. Navigate into the PencilDurabilityTests directory. If you last ran the solution, you'll need to up a directory first. 
   'cd ../PencilDurabilityTests/'
2. Run command 'dotnet test' or 'dotnet test -v n' for more details about the tests.
3. There should be 22 successful tests. 