
using System;

using Harasoft;

public static class TestProgram {

    public static void Main (string[] args) {

        Console.WriteLine("Testing::  Logging"); TestLogging();

        Console.WriteLine("Tests concluded.");
    }

    public static void TestLogging () {

        Logging.StartLog();

        Logging.Log("testing logging");
        Logging.Log("yea i think this is working if u can see this message :]");

        Logging.Log("SENDER VALUE CUSTOMTHINGthing", "custom sender test, successfu;l if u can see ");

        Logging.StopLog();
    }
}
