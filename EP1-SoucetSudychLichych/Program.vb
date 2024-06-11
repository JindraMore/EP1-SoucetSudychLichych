Module Module1

    Sub Main()
        Dim input As String
        Dim numbers As New List(Of Integer)
        Dim evenSum As Integer = 0
        Dim oddSum As Integer = 0
        Dim evenCount As Integer = 0
        Dim oddCount As Integer = 0
        Do
            Console.WriteLine("Zadejte libovolný počet kladných celých čísel. Pro ukončení zadejte 'konec'.")

            Do
                input = Console.ReadLine()

                If input.ToLower() = "konec" Then
                    Exit Do
                End If

                Dim number As Integer
                If Integer.TryParse(input, number) Then
                    If number < 0 Then
                        Console.WriteLine("Prosím, zadejte kladné celé číslo.")
                    Else
                        numbers.Add(number)
                    End If
                Else
                    Console.WriteLine("Prosím, zadejte platné celé číslo nebo 'konec' pro ukončení.")
                End If
            Loop

            For Each num As Integer In numbers
                If num Mod 2 = 0 Then
                    evenSum += num
                    evenCount += 1
                Else
                    oddSum += num
                    oddCount += 1
                End If
            Next


            Console.WriteLine("Součet sudých čísel: " & evenSum)
            Console.WriteLine("Počet sudých čísel: " & evenCount)
            Console.WriteLine("Součet lichých čísel: " & oddSum)
            Console.WriteLine("Počet lichých čísel: " & oddCount)
        Loop


    End Sub

End Module
