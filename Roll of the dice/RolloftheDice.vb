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
        TestRandomness()
    End Sub

    Sub TestRandomness()
        Dim beanCounter(10) As Integer

        For i = 1 To 1000

            beanCounter(randomNumberBetween(2, 10)) += 1 'the return is the pointer for the array


        Next

        For i = LBound(beanCounter) To UBound(beanCounter)

            Console.WriteLine($"{i} | {beanCounter(i)}")

        Next

    End Sub


    Function randomNumberBetween(max As Integer, min As Integer) As Integer 'We need to declare return type
        Dim temp As Single 'The single type helps work with the randomize stuff
        Randomize()
        temp = Rnd()
        'establish range 
        temp *= (max + 1) - min  'supposedly adding the one increase the max by 1. to fix inclusivity of max/min

        temp += min - 1 'This is supposed to shift the min down by 1
        'Return CInt(temp) 'bad randomness
        'Return CInt(Int(temp)) 'Randomness is ok, but max isn't included
        'Return CInt(Math.Floor(temp)) 'randomness is ok, but max isn't included
        Return CInt(Math.Floor(temp)) 'min isn't included
        'Return CInt(Math.Ceiling(temp)) 'Always remember a function needs to return
    End Function




End Module
