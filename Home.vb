Public Class Home
    Dim phonePlan As New Plan
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDataPlan.Maximum = phonePlan.phoneCount
        lblPhoneCount.Text = "Phone Count" & vbNewLine & phonePlan.phoneCount
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        UpdateLabel(True)
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        UpdateLabel(False)
    End Sub
    Private Sub UpdateLabel(increase As Boolean)
        If Not increase Then
            If phonePlan.phoneCount > 1 Then
                phonePlan.phoneCount -= 1
            End If
        Else
            phonePlan.phoneCount += 1
        End If

        txtDataPlan.Maximum = phonePlan.phoneCount

        lblPhoneCount.Text = "Phone Count" & vbNewLine & phonePlan.phoneCount

        UpdateTotals()
    End Sub

    Private Sub textMessages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbTxt400.CheckedChanged, rbTxt1000.CheckedChanged, rbTxtUnlimited.CheckedChanged, rbTxtNone.CheckedChanged
        If (CType(sender, RadioButton)).Checked Then
            Dim rb As RadioButton = CType(sender, RadioButton)

            phonePlan.textMessages = rb.Tag
        End If

        UpdateTotals()
    End Sub

    Private Sub voiceMinutes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbVoice300.CheckedChanged, rbVoice750.CheckedChanged, rbVoiceUnlimited.CheckedChanged, rbVoiceNone.CheckedChanged
        If (CType(sender, RadioButton)).Checked Then
            Dim rb As RadioButton = CType(sender, RadioButton)

            phonePlan.voiceMinutes = rb.Tag
        End If

        UpdateTotals()
    End Sub

    Private Sub CbVoicemail_CheckedChanged(sender As Object, e As EventArgs) Handles cbVoicemail.CheckedChanged
        If cbVoicemail.Checked Then
            phonePlan.voiceMail = True
        Else
            phonePlan.voiceMail = False
        End If

        UpdateTotals()
    End Sub

    Private Sub TxtDataPlan_ValueChanged(sender As Object, e As EventArgs) Handles txtDataPlan.ValueChanged
        phonePlan.dataPlan = txtDataPlan.Value
        UpdateTotals()
    End Sub


    Private Sub UpdateTotals()
        txtSubtotalPhones.Text = FormatCurrency(phonePlan.GetSubtotalPhones(), 2)
        txtSubtotalOther.Text = FormatCurrency(phonePlan.GetSubtotalOther(), 2)
        txtTaxAmount.Text = FormatCurrency(phonePlan.GetTaxAmount(), 2)
        txtGrandTotal.Text = FormatCurrency(phonePlan.GetGrandTotal(), 2)
    End Sub

End Class
