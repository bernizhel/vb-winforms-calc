Public Class Calculator
    Public Sub AppendDigit(Digit As Integer)
        Dim Current As String = TextIO.Text
        If (Current.Length = 0 Or Current = "0") Then
            SetField(Digit)
        Else
            TextIO.Text = Current & Trim(Str(Digit))
        End If
    End Sub
    Public Sub PopDigit()
        Dim Current As String = TextIO.Text
        If (Current.Length < 2 Or Current = "0") Then
            ClearField()
        Else
            TextIO.Text = Current.Substring(0, Current.Length - 1)
        End If
    End Sub
    Public Sub AppendPeriod()
        Dim Current As String = TextIO.Text
        If (Not Current.Contains(Period)) Then
            If (Current.Length = 0) Then
                TextIO.Text = "0" & Period
            Else
                TextIO.Text = Current & Period
            End If
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
    Public Function OperationPower(First As Double, Second As Double) As Double
        OperationPower = First ^ Second
    End Function
    Public Function GetOperationSign(Oper As EOperation) As String
        Return Signs(Oper)
    End Function
    Public Enum EOperation
        Add = 0
        Subtract
        Multiply
        Divide
        Power
    End Enum
    Public Operation As EOperation
    Public Signs = New String() {"+", "-", "*", "/", "^"}
    Public FirstOperand As Double
    Public SecondOperand As Double
    Public IsCalculating As Boolean = False
    Public Const PI As Double = Math.PI
    Public Const Period As String = "."
    Public Sub SetFirstOperand(Oper As EOperation)
        If (Not IsCalculating) Then
            IsCalculating = True
            FirstOperand = GetField()
            FirstOperandLabel.Text = FirstOperand
            Operation = Oper
            OperationLabel.Text = GetOperationSign(Operation)
            ClearField()
        Else
            SetSecondOperand()
            SetAnswer()
            Operation = Oper
            OperationLabel.Text = GetOperationSign(Operation)
            FirstOperand = GetField()
            FirstOperandLabel.Text = FirstOperand
            ClearField()
        End If
    End Sub
    Public Sub SetSecondOperand()
        If (IsCalculating) Then
            SecondOperand = GetField()
        End If
    End Sub
    Public Sub EndCalculation(EndValue As Double)
        If (IsCalculating) Then
            ClearStore()
            IsCalculating = False
        End If
    End Sub
    Public Sub ClearStore()
        FirstOperand = 0
        FirstOperandLabel.Text = FirstOperand
        SecondOperand = 0
        Operation = EOperation.Add
        OperationLabel.Text = ""
        IsCalculating = False
    End Sub
    Public Sub SetAnswer()
        If (IsCalculating) Then
            Select Case Operation
                Case EOperation.Add
                    SetField(OperationAdd(FirstOperand, SecondOperand))
                Case EOperation.Subtract
                    SetField(OperationSubtract(FirstOperand, SecondOperand))
                Case EOperation.Multiply
                    SetField(OperationMultiply(FirstOperand, SecondOperand))
                Case EOperation.Divide
                    SetField(OperationDivide(FirstOperand, SecondOperand))
                Case EOperation.Power
                    SetField(OperationPower(FirstOperand, SecondOperand))
            End Select
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

    Private Sub ButtonBackspace_Click(sender As Object, e As EventArgs) Handles ButtonBackspace.Click
        PopDigit()
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        ClearField()
    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        ClearField()
        ClearStore()
    End Sub

    Private Sub ButtonPeriod_Click(sender As Object, e As EventArgs) Handles ButtonPeriod.Click
        AppendPeriod()
    End Sub

    Private Sub ButtonPower_Click(sender As Object, e As EventArgs) Handles ButtonPower.Click
        SetFirstOperand(EOperation.Power)
    End Sub
End Class
