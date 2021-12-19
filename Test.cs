
using System;

using Harasoft;

public static class TestProgram {

    public static void Main (string[] args) {

        Console.WriteLine("Testing::  Logging"); TestLogging();
        Console.WriteLine("Testing::  SplitString"); SplitString();
        Console.WriteLine("Testing::  Timers"); Timers();
        Console.WriteLine("Testing::  Serialization"); SerializationTest();

        Console.WriteLine("Tests concluded.");
    }

    public static void TestLogging () {

        Logging.StartLog();

        Logging.Log("testing logging");
        Logging.Log("yea i think this is working if u can see this message :]");

        Logging.Log("SENDER VALUE CUSTOMTHINGthing", "custom sender test, successfu;l if u can see ");

        Logging.StopLog();
    }

    public static void SplitString () {

        string test = "jimyHisHasdashdH1H2H2H lol    H :}";

        Console.WriteLine("SRTING: " + test);
        Console.WriteLine("splitting at H char");

        foreach (string s in Misc.SplitString(test, 'H'))
            Console.WriteLine(s);
    }

    public static void Timers () {

        Timer.Start(69);

        System.Threading.Thread.Sleep(123);

        double ms = Timer.Stop(69);

        Console.WriteLine(ms.ToString());
    }

    public static void SerializationTest () {

        TestClass ts = new TestClass();
        ts.text = "this is a message";
        ts.x = 69420;

        byte[] data = Serialization.Serialize(ts);

        TestClass y = (TestClass)Serialization.Deserialize(data);

        Console.WriteLine(y.x.ToString() + ": " + y.text);
    }

    [Serializable]
    public class TestClass {

        public string text;
        public int x;
    }
}
