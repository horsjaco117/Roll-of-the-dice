'Jacob Horsley
'RCET 0265
'Spring 2025
'Roll of the Dice
'URL:https://github.com/horsjaco117/Roll-of-the-dice

'[x] Create array from 2 to 12
'[x] Have it roll a thousand time 
'[x] Format things into columns and headers 
'[x] Ensure the total amount of rolls shows up 
'[x] Randomness
Module RolloftheDice

    Sub Main()
        Dim beanCounter(12) As Integer
        TestRandomness(beanCounter) 'This runs the random number generator
        DisplayBoard(beanCounter) 'Things are organized into a board
    End Sub

    Sub TestRandomness(ByRef beanCounter() As Integer) 'Random generator

        For i = 1 To 1000

            beanCounter(randomNumberBetween(1, 13)) += 1 'the return is the pointer for the array

        Next

    End Sub


    Function randomNumberBetween(max As Integer, min As Integer) As Integer
        Dim temp As Single 'The single type helps work with the randomize stuff
        Randomize()
        temp = Rnd()
        temp = temp * (max - min + 1) + min
        Return CInt(Math.Floor(temp)) 'min isn't included
    End Function

    Sub DisplayBoard(diceCounter() As Integer) 'The board for the dice rolls
        Dim heading() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        Dim columnWidth As Integer = 6 ' Set a consistent width for alignment
        Console.WriteLine("                             Roll of the Dice")
        Console.WriteLine(StrDup((columnWidth + 1) * heading.Length + 1, "-"))

        Console.Write("|") 'Line dividers
        For Each number In heading
            Console.Write(number.PadLeft(columnWidth) & "|")
        Next

        Console.WriteLine()

        ' Print separator line
        Console.WriteLine(StrDup((columnWidth + 1) * heading.Length + 1, "-"))

        ' Print values
        Console.Write("|") 'Adjustments for spacing
        For i = 2 To UBound(diceCounter)
            Console.Write(diceCounter(i).ToString().PadLeft(columnWidth) & "|")
        Next
        Console.WriteLine()
    End Sub
End Module