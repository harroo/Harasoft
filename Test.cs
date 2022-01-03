
using System;

using Harasoft;

public static class TestProgram {

    public static void Main (string[] args) {

        Console.WriteLine("\nTesting::  Logging"); TestLogging();
        Console.WriteLine("\nTesting::  SplitString"); SplitString();
        Console.WriteLine("\nTesting::  Timers"); Timers();
        Console.WriteLine("\nTesting::  Serialization"); SerializationTest();
        Console.WriteLine("\nTesting::  Encryption"); EncryptionTest();
        Console.WriteLine("\nTesting::  Hashing"); HashingTest();

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

    public static void EncryptionTest () {

        string value = "hi im a secret message";
        Console.WriteLine(value);

        byte[] data0 = System.Text.Encoding.ASCII.GetBytes(value);
        byte[] data1 = Encryption.Encrypt(data0, "testkey012345678");
        // byte[] data2 = Encryption.Decrypt(data0, "wrongtestkey1234");
        byte[] data3 = Encryption.Decrypt(data1, "testkey012345678");

        Console.WriteLine(data0.Length.ToString() + ": " + System.Text.Encoding.ASCII.GetString(data0));
        Console.WriteLine(data1.Length.ToString() + ": " + System.Text.Encoding.ASCII.GetString(data1));
        // Console.WriteLine(data2.Length.ToString() + ": " + System.Text.Encoding.ASCII.GetString(data2));
        Console.WriteLine(data3.Length.ToString() + ": " + System.Text.Encoding.ASCII.GetString(data3));
    }

    public static void HashingTest () {

        string value = "hi im a secret message";

        Console.WriteLine(value);
        Console.WriteLine(Hashing.Sha256Hash(value));
    }

    [Serializable]
    public class TestClass {

        public string text;
        public int x;
    }
}
