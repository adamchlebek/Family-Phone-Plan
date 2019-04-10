Public Class Plan
    Public phoneCount As Integer
    Public dataPlan As Integer
    Public voiceMail As Boolean
    Public textMessages As Decimal
    Public voiceMinutes As Decimal

    Public Sub New()
        phoneCount = 1
        dataPlan = 0
    End Sub

    Public Function GetSubtotalPhones() As Decimal
        Dim subtotal As Decimal = 0

        If phoneCount > 0 Then
            subtotal += (9.99 * (phoneCount - 1))
            subtotal += 14.99
        End If

        Return subtotal
    End Function

    Public Function GetSubtotalOther() As Decimal
        If voiceMail Then
            Return (dataPlan * 5.99) + textMessages + voiceMinutes + 3.95
        Else
            Return (dataPlan * 5.99) + textMessages + voiceMinutes
        End If
    End Function

    Public Function GetTaxAmount() As Decimal
        Return (GetSubtotalOther() + GetSubtotalPhones()) * 0.0325
    End Function

    Public Function GetGrandTotal() As Decimal
        Return GetTaxAmount() + GetSubtotalOther() + GetSubtotalPhones()
    End Function
End Class
