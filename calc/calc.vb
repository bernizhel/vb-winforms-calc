Public Class Calculator
    Public Sub AppendDigit(Digit As Integer)
        Dim Current As String = TextIO.Text
        If (Current.Length = 0 Or Current = "0") Then
            SetField(Digit)
        Else
            TextIO.Text = Current + Str(Digit)
        End If
    End Sub
    Public Sub SetField(Value As Double)
        TextIO.Text = Format(Value, "g")
    End Sub
    Public Function GetField() As Double
        GetField = Val(TextIO.Text)
    End Function
    Public Sub ClearField()
        SetField(0)
    End Sub
    Public Function OperationAdd(First As Double, Second As Double) As Double
        OperationAdd = First + Second
    End Function
    Public Function OperationSubtract(First As Double, Second As Double) As Double
        OperationSubtract = First - Second
    End Function
    Public Function OperationMultiply(First As Double, Second As Double) As Double
        OperationMultiply = First * Second
    End Function
    Public Function OperationDivide(First As Double, Second As Double) As Double
        OperationDivide = First / Second
    End Function
    Public Function GetOperationSign(Oper As EOperation) As String
        Select Case Oper
            Case Is = EOperation.Add
                Return "+"
            Case Is = EOperation.Subtract
                Return "-"
            Case Is = EOperation.Multiply
                Return "*"
            Case Is = EOperation.Divide
                Return "/"
            Case Else
                Return "something went wrong"
        End Select
    End Function
    Public Enum EOperation
        Add
        Subtract
        Multiply
        Divide
    End Enum
    Public Operation As EOperation
    Public FirstOperand As Double
    Public SecondOperand As Double
    Public IsCalculating As Boolean = False
    Public Const PI As Double = Math.PI
    Public Sub SetFirstOperand(Oper As EOperation)
        SecondOperandLabel.Text = "0"
        If (Not IsCalculating) Then
            IsCalculating = True
            FirstOperand = GetField()
            FirstOperandLabel.Text = FirstOperand
            Operation = Oper
            OperationLabel.Text = GetOperationSign(Operation)
        End If
    End Sub
    Public Sub SetSecondOperand()
        If (IsCalculating) Then
            SecondOperand = GetField()
            SecondOperandLabel.Text = SecondOperand
        End If
    End Sub
    Public Sub EndCalculation(EndValue As Double)
        If (IsCalculating) Then
            FirstOperand = EndValue
            SecondOperand = EndValue
            IsCalculating = False
        End If
    End Sub
    Public Sub SetAnswer()
        If (IsCalculating) Then
            If (Operation = EOperation.Add) Then
                SetField(OperationAdd(FirstOperand, SecondOperand))
            ElseIf (Operation = EOperation.Subtract) Then
                SetField(OperationSubtract(FirstOperand, SecondOperand))
            ElseIf (Operation = EOperation.Multiply) Then
                SetField(OperationMultiply(FirstOperand, SecondOperand))
            ElseIf (Operation = EOperation.Divide) Then
                SetField(OperationDivide(FirstOperand, SecondOperand))
            End If
        End If
    End Sub
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        SetFirstOperand(EOperation.Add)
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        SetFirstOperand(EOperation.Subtract)
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        SetFirstOperand(EOperation.Multiply)
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        SetFirstOperand(EOperation.Divide)
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        SetSecondOperand()
        SetAnswer()
        EndCalculation(GetField())
    End Sub

    Private Sub ButtonDigit1_Click(sender As Object, e As EventArgs) Handles ButtonDigit1.Click
        AppendDigit(1)
    End Sub

    Private Sub ButtonDigit0_Click(sender As Object, e As EventArgs) Handles ButtonDigit0.Click
        AppendDigit(0)
    End Sub

    Private Sub ButtonDigit2_Click(sender As Object, e As EventArgs) Handles ButtonDigit2.Click
        AppendDigit(2)
    End Sub

    Private Sub ButtonDigit3_Click(sender As Object, e As EventArgs) Handles ButtonDigit3.Click
        AppendDigit(3)
    End Sub

    Private Sub ButtonDigit4_Click(sender As Object, e As EventArgs) Handles ButtonDigit4.Click
        AppendDigit(4)
    End Sub

    Private Sub ButtonDigit5_Click(sender As Object, e As EventArgs) Handles ButtonDigit5.Click
        AppendDigit(5)
    End Sub

    Private Sub ButtonDigit6_Click(sender As Object, e As EventArgs) Handles ButtonDigit6.Click
        AppendDigit(6)
    End Sub

    Private Sub ButtonDigit7_Click(sender As Object, e As EventArgs) Handles ButtonDigit7.Click
        AppendDigit(7)
    End Sub

    Private Sub ButtonDigit8_Click(sender As Object, e As EventArgs) Handles ButtonDigit8.Click
        AppendDigit(8)
    End Sub

    Private Sub ButtonDigit9_Click(sender As Object, e As EventArgs) Handles ButtonDigit9.Click
        AppendDigit(9)
    End Sub
End Class
