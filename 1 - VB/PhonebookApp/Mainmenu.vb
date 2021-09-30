Class MainMenu

    Implements IMenu
    sub Initialize() Implements IMenu.Start
        Console.WriteLine("Hello World!")
            dim repeat as Boolean = True 
            do while repeat
                Console.WriteLine("What would you like to do?")
                Console.WriteLine("[0] say hello")
                Console.WriteLine("[x] Exit")
                Dim input as String= Console.Readline()
                Select Case input
                    Case "0"
                        Console.WriteLine("Hello")
                    Case "x"
                        Console.WriteLine("Goodbye")
                        repeat = False
                end Select
            Loop
    end sub        
End Class
