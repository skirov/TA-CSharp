using System;
using System.Reflection;

[Version("5.0")]
public class VersionsDemo
{
    [Version("5.4")]
    public static void SayHello()
    {
        Console.WriteLine("SayHello");
    }

    [Version("12.1")]
    public enum WeekDays
    {
        Saturday,
        Sunday
    }

    [Version("1.0")]
    public interface IDemo
    {
        void DemoMetohod();
    }

    static void Main()
    {
        Type type = typeof(VersionsDemo);
        //Dysplay Class info
        object[] classCustomAttributes = type.GetCustomAttributes(false);
        Console.WriteLine("Class -> version is {0}", (classCustomAttributes[0] as VersionAttribute).Version);

        //Dysplay Method info
        MethodInfo[] methodsInfo = type.GetMethods(BindingFlags.Static | BindingFlags.Public);
        object[] methodCustomAttributes = methodsInfo[0].GetCustomAttributes(false);
        Console.WriteLine("Method {0} -> version is {1}", methodsInfo[0].Name, (methodCustomAttributes[0] as VersionAttribute).Version);

        //Dysplay Enumeration info
        Type enumInfo = type.GetNestedType("WeekDays", BindingFlags.Public);
        object[] enumCustomAttributes = enumInfo.GetCustomAttributes(false);
        Console.WriteLine("Enumeration {0} -> version {1}", enumInfo.Name, (enumCustomAttributes[0] as VersionAttribute).Version);

        //Dysplay Interface info
        Type interfaceInfo = type.GetNestedType("IDemo", BindingFlags.Public);
        object[] interfaceCustomAttributes = interfaceInfo.GetCustomAttributes(false);
        Console.WriteLine("Interface {0} -> version {1}", interfaceInfo.Name, (interfaceCustomAttributes[0] as VersionAttribute).Version);
    }
}