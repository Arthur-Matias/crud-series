## Series Crud

A Series CRUD Made with C#

### How to run:

To tun this app you will need the .NET package wich can be found on this [link](https://dotnet.microsoft.com/download).

Clone the repo with:

```bash
  git clone https://github.com/Arthur-Matias/crud-series.git
  cd crud-series
```
then just

```bash
  dotnet run
```

The application interface is in Portuguese.

### How to use:

When you first run the application, the series list will be empty, you will see a list of options that you can enter

```bash
  1 - List Series
```
Returns a list of the Added series with their respective ID's

```bash
  2 - Add new
```
Add new Series 

It asks for

 - The genre
 - The title
 - Year of launch
 - Series Description(Sinopsis)

```bash
  3 - Update Series
```
Pretty much the same of the `Add new` except it doesn't add just update a existing one.
```bash
  4 - Delete Series
```
Delete an entry by its ID.
```bash
  5 - Get series info
```
Retrieve all infos of an entry by it's ID
```bash
  C - Clear console
```
Clear the current console screen
```bash
  X - Exit
```
Exit the application
