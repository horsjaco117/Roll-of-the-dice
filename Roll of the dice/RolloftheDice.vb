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
        Dim beanCounter(14) As Integer
        TestRandomness(beanCounter)
        DisplayBoard(beanCounter)
    End Sub

    Sub TestRandomness(ByRef beanCounter() As Integer)

        For i = 1 To 1000

            beanCounter(randomNumberBetween(1, 13)) += 1 'the return is the pointer for the array


        Next

        For i = LBound(beanCounter) To UBound(beanCounter)

            Console.WriteLine($"{i} | {beanCounter(i)}")

        Next

    End Sub


    Function randomNumberBetween(max As Integer, min As Integer) As Integer 'We need to declare return type
        Dim temp As Single 'The single type helps work with the randomize stuff
        Randomize()
        temp = Rnd()
        temp = temp * (max - min + 1) + min
        'establish range 
        'temp *= (max + 1) - min  'supposedly adding the one increase the max by 1. to fix inclusivity of max/min

        'temp += min - 1 'This is supposed to shift the min down by 1
        'Return CInt(temp) 'bad randomness
        'Return CInt(Int(temp)) 'Randomness is ok, but max isn't included
        'Return CInt(Math.Floor(temp)) 'randomness is ok, but max isn't included
        Return CInt(Math.Floor(temp)) 'min isn't included
        'Return CInt(Math.Ceiling(temp)) 'Always remember a function needs to return
    End Function

    Sub DisplayBoard(beanCounter() As Integer)
        'Dim temp As String = "X |"
        Dim heading() As String = {"2 |", "3 |", "4 |", "5 |", "6 |", "7 |", "8 |", "9 |", "10 |", "11 |", "12 |"}
        Dim board(4, 4) As String
        Dim counterIndex As Integer = 0

        For i = 0 To 4
            For j = 0 To 4
                If counterIndex <= 12 Then
                    board(i, j) = beanCounter(counterIndex).ToString().PadLeft(3)
                    counterIndex += 1
                Else
                    board(i, j) = "x"
                End If
            Next
        Next

        Console.Write("| ")

        For Each letter In heading
            Console.Write(letter.PadLeft(3).PadRight(5))
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(25, "_"))
        For i = 0 To 4
            For j = 0 To 4
                Console.Write(board(i, j).PadLeft(5))
                'temp = temp.PadLeft(5)
                'Console.Write(temp)
            Next
            Console.WriteLine()
        Next
    End Sub



End Module
