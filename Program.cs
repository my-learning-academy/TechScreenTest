using TechTest;

Console.WriteLine(Test.SimpleMethod("{}")); // true
Console.WriteLine(Test.SimpleMethod("}{")); // false
Console.WriteLine(Test.SimpleMethod("{}{}{}")); // true
Console.WriteLine(Test.SimpleMethod("{}}{{}")); // false
Console.WriteLine(Test.SimpleMethod("{{}{}}}")); // false
Console.WriteLine(Test.SimpleMethod("}{}{}{")); // false
Console.WriteLine(Test.SimpleMethod("{{}{}}")); //true
Console.WriteLine(Test.SimpleMethod("{{}{}}}{")); //false
Console.WriteLine(Test.SimpleMethod("{}}{{}")); //false
Console.WriteLine(Test.SimpleMethod("{}}{{}")); // false
