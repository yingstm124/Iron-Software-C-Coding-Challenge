# 📦 C# Coding challenge

A console app that demostrates the old phone keypad with alphabetical letters, a backspace key, send button.

```
                     |``|
 ____________________|__|
|  ___________________  |
| |                   | |
| |      Codeing      | |
| |     Challenge     | |
| |___________________| |
|  _____  _____  _____  |
|  1 &'(  2 abc  3 def  |
|  4 ghi  5 jkl  6 mno  |
|  7 pqrs 8 tuv  9 wxyz |
|  * <    0 ─    # >    |
|                       |
|_______________________|

```
## Project Structure
```
Iron-Software-C-Coding-Challenge
│
├── challenge/
|   ├── Phone.cs           # oldphone pad implementation
|   ├── Program.cs         # phone promp input
|   └── challenge.csproj      
├── challenge.Tests/
|   ├── UnitTest.cs           
|   └── challenge.Tests.csproj             
└── README.md            
```

## Getting Started
### Prerequisites

- [.NET SDK 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

### Installation
1. Clone the repository
```
git clone https://github.com/yingstm124/Iron-Software-C-Coding-Challenge.git
```
2. Restore dependencies and build the project
```
cd challenge
dotnet restore
dotnet build
```
3. Run the program
```
dotnet run
```

### Running Tests
```
cd challenge.Tests
dotnet test
```