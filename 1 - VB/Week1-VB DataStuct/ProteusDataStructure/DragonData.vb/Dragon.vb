Class Dragon

    Public name as String 
    Private weight as Double 
    Private species as String
    public dim favFoods() as String
    
    public sub New(newName as String)
        name = newName
        favFoods = {"dog", "coconut"}
     end sub

    sub printName()
        Console.WriteLine(name)
    end sub

    sub printFavFoods()
        Console.WriteLine(favFoods)
        for Each value as String in favFoods
                Console.WriteLine(value)
        next
    end sub
End Class
