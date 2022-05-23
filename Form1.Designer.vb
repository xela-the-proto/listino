<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listino
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lst_listino = New System.Windows.Forms.ListBox()
        Me.btn_visualizza = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numProdotti = New System.Windows.Forms.TextBox()
        Me.btn_procediCaricamento = New System.Windows.Forms.Button()
        Me.grp_prodotto = New System.Windows.Forms.GroupBox()
        Me.txt_prezzo = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_codice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_caricaProdotto = New System.Windows.Forms.Button()
        Me.btn_esci = New System.Windows.Forms.Button()
        Me.grp_prodotto.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_listino
        '
        Me.lst_listino.FormattingEnabled = True
        Me.lst_listino.ItemHeight = 15
        Me.lst_listino.Location = New System.Drawing.Point(478, 41)
        Me.lst_listino.Name = "lst_listino"
        Me.lst_listino.Size = New System.Drawing.Size(310, 199)
        Me.lst_listino.TabIndex = 0
        '
        'btn_visualizza
        '
        Me.btn_visualizza.Location = New System.Drawing.Point(478, 12)
        Me.btn_visualizza.Name = "btn_visualizza"
        Me.btn_visualizza.Size = New System.Drawing.Size(75, 23)
        Me.btn_visualizza.TabIndex = 1
        Me.btn_visualizza.Text = "Visualizza"
        Me.btn_visualizza.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero di prodotti da caricare:"
        '
        'txt_numProdotti
        '
        Me.txt_numProdotti.Location = New System.Drawing.Point(188, 6)
        Me.txt_numProdotti.Name = "txt_numProdotti"
        Me.txt_numProdotti.Size = New System.Drawing.Size(100, 23)
        Me.txt_numProdotti.TabIndex = 3
        '
        'btn_procediCaricamento
        '
        Me.btn_procediCaricamento.Location = New System.Drawing.Point(12, 41)
        Me.btn_procediCaricamento.Name = "btn_procediCaricamento"
        Me.btn_procediCaricamento.Size = New System.Drawing.Size(173, 23)
        Me.btn_procediCaricamento.TabIndex = 4
        Me.btn_procediCaricamento.Text = "Procedi con il caricamento"
        Me.btn_procediCaricamento.UseVisualStyleBackColor = True
        '
        'grp_prodotto
        '
        Me.grp_prodotto.Controls.Add(Me.txt_prezzo)
        Me.grp_prodotto.Controls.Add(Me.txt_nome)
        Me.grp_prodotto.Controls.Add(Me.txt_codice)
        Me.grp_prodotto.Controls.Add(Me.Label4)
        Me.grp_prodotto.Controls.Add(Me.Label3)
        Me.grp_prodotto.Controls.Add(Me.Label2)
        Me.grp_prodotto.Location = New System.Drawing.Point(12, 118)
        Me.grp_prodotto.Name = "grp_prodotto"
        Me.grp_prodotto.Size = New System.Drawing.Size(254, 122)
        Me.grp_prodotto.TabIndex = 5
        Me.grp_prodotto.TabStop = False
        Me.grp_prodotto.Text = "Dati del prodotto"
        '
        'txt_prezzo
        '
        Me.txt_prezzo.Location = New System.Drawing.Point(58, 76)
        Me.txt_prezzo.Name = "txt_prezzo"
        Me.txt_prezzo.Size = New System.Drawing.Size(100, 23)
        Me.txt_prezzo.TabIndex = 5
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(58, 49)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(100, 23)
        Me.txt_nome.TabIndex = 4
        '
        'txt_codice
        '
        Me.txt_codice.Location = New System.Drawing.Point(58, 23)
        Me.txt_codice.Name = "txt_codice"
        Me.txt_codice.Size = New System.Drawing.Size(100, 23)
        Me.txt_codice.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Prezzo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codice"
        '
        'btn_caricaProdotto
        '
        Me.btn_caricaProdotto.Location = New System.Drawing.Point(12, 246)
        Me.btn_caricaProdotto.Name = "btn_caricaProdotto"
        Me.btn_caricaProdotto.Size = New System.Drawing.Size(75, 23)
        Me.btn_caricaProdotto.TabIndex = 6
        Me.btn_caricaProdotto.Text = "Carica"
        Me.btn_caricaProdotto.UseVisualStyleBackColor = True
        '
        'btn_esci
        '
        Me.btn_esci.Location = New System.Drawing.Point(713, 246)
        Me.btn_esci.Name = "btn_esci"
        Me.btn_esci.Size = New System.Drawing.Size(75, 23)
        Me.btn_esci.TabIndex = 7
        Me.btn_esci.Text = "Esci"
        Me.btn_esci.UseVisualStyleBackColor = True
        '
        'frm_listino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 277)
        Me.Controls.Add(Me.btn_esci)
        Me.Controls.Add(Me.btn_caricaProdotto)
        Me.Controls.Add(Me.grp_prodotto)
        Me.Controls.Add(Me.btn_procediCaricamento)
        Me.Controls.Add(Me.txt_numProdotti)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_visualizza)
        Me.Controls.Add(Me.lst_listino)
        Me.Name = "frm_listino"
        Me.Text = "Listino"
        Me.grp_prodotto.ResumeLayout(False)
        Me.grp_prodotto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_listino As ListBox
    Friend WithEvents btn_visualizza As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_numProdotti As TextBox
    Friend WithEvents btn_procediCaricamento As Button
    Friend WithEvents grp_prodotto As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_prezzo As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_codice As TextBox
    Friend WithEvents btn_caricaProdotto As Button
    Friend WithEvents btn_esci As Button
End Class
