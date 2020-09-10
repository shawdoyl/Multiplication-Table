'Doyle Shaw
'RCET0265
'Fall 2020
'Multiplication Table
'https://github.com/shawdoyl/Multiplication-Table
Imports System.CodeDom.Compiler

Module MultiplicationTable
    Public limitNumber As Integer

    Sub Main()
        Dim promptUser As Boolean

        promptUser = True

        Console.WriteLine("Please enter a number for the array.")
        Do While promptUser = True
            Try
                limitNumber = CInt(Console.ReadLine())
                promptUser = False
            Catch ex As Exception
                Console.WriteLine("Please Enter a Whole Number.")
                promptUser = True
            End Try
        Loop

        Console.Clear()
        Console.WriteLine("Here is your " & limitNumber & "x" & limitNumber & " Multiplication table:")
        Console.WriteLine()
        MultiplicationTableArray()
        Console.ReadLine()
    End Sub
    Sub MultiplicationTableArray()
        Dim myArray(limitNumber, limitNumber) As Integer

        For i = 1 To limitNumber
            For j = 1 To limitNumber
                myArray(i, j) = i * j
                Console.Write(CStr(myArray(i, j)).PadRight(6))
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
