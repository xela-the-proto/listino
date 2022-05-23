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
End Class
