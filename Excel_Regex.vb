Private Sub RegExp_Replace()

    Dim RegExp As Object
    Dim SearchRange As Range, Cell As Range    
    
    Set RegExp = CreateObject("vbscript.regexp")
    RegExp.Pattern = "[0-9]{5}"     
    
    Set SearchRange = ActiveSheet.Range("A1:A99")    
   
    For Each Cell In SearchRange
        Set Matches = RegExp.Execute(Cell.Value)
        If Matches.Count >= 1 Then
            Set Match = Matches(0)
            Cell.Value = RegExp.Replace(Cell.Value, "")
        End If
    Next

End Sub
