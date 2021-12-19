# Harasoft
A C# Library to make C# development life easier.

# How to Install / Setup..

There are two ways setup this library.

**Download Harasoft.dll** [Recommended]
- To download and install Harasoft this way, simply check the releases on this page, and download the latest `dll`.
- [Harasoft Releases](https://github.com/harroo/Harasoft/releases)

**Compile Harasoft.dll**
- Clone this repository and once in the Root-Directory, run `make`.
- This will require `make` and `mcs`.

In all cases the `namespace` is `Harasoft`.
```cs
using Harasoft;
```

# Docs

## `Harasoft.Logging`
```cs
// This is necessary to perform Log calls..
Logging.StartLog();

// Logging is rather simple.
Logging.Log("This is a Log-Message!");

// Not necessary as the Logging clears itself.
// This is simply for peace of mind.
Logging.StopLog();
```
For use in Unity, simply change `Console.WriteLine` to `Debug.Log` in Harasoft/Logging/Logging.cs

## `Harasoft.Miscellaneous`

### `Harasoft.Misc.SplitString(string input, char marker)`
```cs
// Works the same as string.Split(char c);
string[] values = Misc.SplitString("my string", ' ');
```

## `Harasoft.Timer`
```cs
// Start a timer with the Id of 22.
Timer.Start(22);

// Do something... //

// Stop the timer with the Id of 22.
// Returns the resulted Milliseconds.
double ms = Timer.Stop(22);

// Do something with the result.
Console.WriteLine(ms.ToString());
```
Note: This will be within 1 or 2 milliseconds of accuracy.

## `Harasoft.Serialization`
```cs
// Serialize an object.
byte[] data = Serialization.Serialize(className);

// De-serialize an object.
ClassName className = (ClassName)Serialization.Deserialize(data);
```
Works with ANYthing.
