Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        
        dim friend1 as Dragon = new Dragon("jimmydean")
        friend1.printName()
        friend1.printFavFoods()

    End Sub
End Module
