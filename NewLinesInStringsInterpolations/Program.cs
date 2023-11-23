var Name = "Andropov Ajebua";
Console.WriteLine($"""

    Hello, "{Name}"!
    """);

//if we need to see the curly braces in our code 
Console.WriteLine($$"""
    Hello, "{Name}"!
    Hello, "{{{Name}}}"!
    Hello, "{{{Name.ToLower()}}}"!
    """);

//using pattern matching expression (switch)
Console.Write("Enter an interger: ");
 var  Count = Int32.Parse(Console.ReadLine());
Console.WriteLine($"""
    
     The number is : "{ Count  switch {
           1 =>1, //"one",
           2 => "two",
           3 => "three",
           _ => "default number"
        }
    }"!
    """);