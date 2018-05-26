Module umum
    Private Function Cipher(ch As Char, key As Integer) As Char
        If Not Char.IsLetter(ch) Then
            Return ch
        End If

        Dim offset As Integer = Convert.ToInt32(If(Char.IsUpper(ch), "A"c, "a"c))
        Return ChrW((((Convert.ToInt32(ch) + key) - offset) Mod 26) + offset)
    End Function

    Public Function Encipher(input As String, key As Integer) As String
        Dim output As String = String.Empty

        For Each ch As Char In input
            output += Cipher(ch, key)
        Next

        Return output
    End Function

    Public Function Decipher(input As String, key As Integer) As String
        Return Encipher(input, 26 - key)
    End Function
End Module
