'Jacob Horsley
'RCET 0265
'Spring 2025
'Roll of the Dice
'URL:

'[ ] Create array from 2 to 12
'[ ] Have it roll a thousand time 
'[ ] Format things into columns and headers 
'[ ] Ensure the total amount of rolls shows up 
Module RolloftheDice

    Sub Main()
        Dim beanCounter(12) As Integer
        ' TestRandomness(beanCounter)
        DisplayBoard(beanCounter)
    End Sub

    Sub TestRandomness(ByRef beanCounter() As Integer)

        For i = 1 To 1000

            beanCounter(randomNumberBetween(1, 13)) += 1 'the return is the pointer for the array

        Next

        For i = 2 To UBound(beanCounter)

            Console.WriteLine($"{i}|{beanCounter(i)}")

        Next

    End Sub


    Function randomNumberBetween(max As Integer, min As Integer) As Integer 'We need to declare return type
        Dim temp As Single 'The single type helps work with the randomize stuff
        Randomize()
        temp = Rnd()
        temp = temp * (max - min + 1) + min
        Return CInt(Math.Floor(temp)) 'min isn't included
        'Return CInt(Math.Ceiling(temp)) 'Always remember a function needs to return
    End Function

    Sub DisplayBoard(beanCounter() As Integer)
        Dim heading() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        Dim columnWidth As Integer = 6 ' Set a consistent width for alignment
        Console.WriteLine("                          Roll of the Dice")
        Console.WriteLine(StrDup((columnWidth + 1) * heading.Length + 1, "-"))

        'Console.Write(heading(0))
        ' Print header
        Console.Write("|")
        For Each number In heading
            Console.Write(number.PadLeft(columnWidth) & "|")
        Next
        Console.WriteLine()

        ' Print separator line
        Console.WriteLine(StrDup((columnWidth + 1) * heading.Length + 1, "-"))

        ' Print values
        Console.Write("|")
        For i = 2 To UBound(beanCounter)
            Console.Write(beanCounter(i).ToString().PadLeft(columnWidth) & "|")
        Next
        Console.WriteLine()
    End Sub
End Module