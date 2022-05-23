Public Class frm_listino
    Private Structure Prodotto
        Dim codice As String
        Dim nome As String
        Dim prezzo As Single
    End Structure

    Dim Listino() As Prodotto

    Dim i As Byte

    Private Sub btn_esci_Click(sender As Object, e As EventArgs) Handles btn_esci.Click
        End
    End Sub

    Private Sub frm_listino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_procediCaricamento.Enabled = True
        txt_numProdotti.Enabled = True
        grp_prodotto.Enabled = False
        btn_caricaProdotto.Enabled = False

        i = 0

    End Sub

    Private Sub btn_procediCaricamento_Click(sender As Object, e As EventArgs) Handles btn_procediCaricamento.Click
        ReDim Listino(Val(txt_numProdotti.Text) - 1)

        btn_procediCaricamento.Enabled = False
        txt_numProdotti.Enabled = False
        grp_prodotto.Enabled = True
        btn_caricaProdotto.Enabled = True
    End Sub

    Private Sub btn_caricaProdotto_Click(sender As Object, e As EventArgs) Handles btn_caricaProdotto.Click
        With Listino(i)
            .codice = txt_codice.Text
            .nome = txt_nome.Text
            .prezzo = Val(txt_prezzo.Text)
        End With

        i = i + 1

        If i = Val(txt_numProdotti.Text) Then
            btn_caricaProdotto.Enabled = False
            grp_prodotto.Enabled = False
        Else
            txt_codice.Text = ""
            txt_nome.Text = ""
            txt_prezzo.Text = ""
            txt_codice.Focus()
        End If
    End Sub

    Private Sub btn_visualizza_Click(sender As Object, e As EventArgs) Handles btn_visualizza.Click
        Dim indice As Byte
        lst_listino.Items.Add("CODICE".PadRight(15) & "NOME".PadRight(20) & "PREZZO".PadRight(15))
        lst_listino.Items.Add("".PadRight(50, ""))
        For indice = 0 To Val(txt_numProdotti.Text) - 1
            With Listino(indice)
                lst_listino.Items.Add(.codice.PadRight(15) & .nome.PadRight(20) & CStr(Format(.prezzo, "###,##0.00")).PadLeft(15))
            End With
        Next indice
    End Sub
End Class
