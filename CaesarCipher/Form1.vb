Imports System.Text
Imports System.IO
Public Class Form1

    Sub tampilan()
        If cmbpilih.SelectedIndex = 0 Then
            inputlbl.Text = "INPUT"
            outputlbl.Text = "OUTPUT"
            btnproses.BackColor = Color.Gray
            gmbrnotif.BringToFront()
        ElseIf cmbpilih.SelectedIndex = 1 Then
            inputlbl.Text = "Plain Text"
            outputlbl.Text = "Cipher Text"
            gmbrnotif.SendToBack()
            btnproses.BackColor = Color.White
        ElseIf cmbpilih.SelectedIndex = 2 Then
            inputlbl.Text = "Cipher Text"
            outputlbl.Text = "Plain Text"
            gmbrnotif.SendToBack()
            btnproses.BackColor = Color.White
        End If
    End Sub 'Hanya untu tampilan (Opsional)

    Sub isipilihan()
        cmbpilih.Items.Add("-PILIHAN-")
        cmbpilih.Items.Add("ENCRYPT")
        cmbpilih.Items.Add("DECRYPT")
        cmbpilih.SelectedIndex = 0
    End Sub

    Sub pilih()
        If cmbpilih.SelectedIndex = 0 Then
            btnproses.Enabled = False
            intxt.Enabled = False
            outtxt.Enabled = False
            btnproses.Text = "PILIH PROSES"
            keytxt.Text = 3
            tampilan() '<---Hanya untuk tampilan (Opsional)
        ElseIf cmbpilih.SelectedIndex = 1 Then
            btnproses.Enabled = True
            intxt.Enabled = True
            outtxt.Enabled = True
            btnproses.Text = "ENCRYPT"
            tampilan() '<--- Hanya untuk tampilan (Opsional) 
            intxt.Focus()
        ElseIf cmbpilih.SelectedIndex = 2 Then
            btnproses.Enabled = True
            intxt.Enabled = True
            outtxt.Enabled = True
            btnproses.Text = "DECRYPT"
            tampilan() '<--- Hanya untuk tampilan (Opsional) 
            intxt.Focus()
        End If
    End Sub

    Sub bersih()
        intxt.Clear()
        outtxt.Clear()
        cmbpilih.SelectedIndex = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isipilihan()
        bersih()
    End Sub

    Private Sub cmbpilih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpilih.SelectedIndexChanged
        pilih()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        bersih()
        intxt.Focus()
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        If keytxt.Text = "" Or intxt.Text = "" Then
            MsgBox("KEY ATAU TEXT MASIH KOSONG")
        ElseIf keytxt.Text > 26 Then
            MsgBox("CEK KEMBALI KEY NYA")
        Else
            If btnproses.Text = "ENCRYPT" Then
                Timer1.Start()
                outtxt.Text = intxt.Text
                outtxt.Text = Encipher(outtxt.Text, keytxt.Text)
            ElseIf btnproses.Text = "DECRYPT" Then
                Timer1.Start()
                outtxt.Text = intxt.Text
                outtxt.Text = Decipher(outtxt.Text, keytxt.Text)
            End If
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        bersih()
    End Sub

    Private Const FilterTxt As String = "Text Files(*.txt)|*.txt"

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim od As New OpenFileDialog()
        Dim sr As StreamReader

        With od

            If .ShowDialog().Equals(DialogResult.OK) Then
                'Open text file in editor.
                sr = New StreamReader(.FileName)
                intxt.Text = sr.ReadToEnd()
                sr.Close()
            End If
        End With

    End Sub

    Private Sub KELUARAPPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARAPPToolStripMenuItem.Click
        Dim tny As String = MsgBox("KELUAR APLIKASI ???", vbYesNo, "Konfirmasi")
        If tny = vbYes Then
            Close()
        End If
    End Sub

    Private Sub keytxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keytxt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or
                Asc(e.KeyChar) > 58 Then
                e.Handled = True
            End If
        End If
    End Sub

    'UNTUK PROGRESS BAR
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 200 Then
            notif.Text = "ok"
            Dim tny As String = MsgBox("Success", vbOKOnly, "Notifikasi")
            If tny = vbOK Then
                Me.Enabled = True
                notif.Text = "ee"
            End If
        Else
            Me.Enabled = False
            ProgressBar1.Value = ProgressBar1.Value + 20
        End If
    End Sub

    Private Sub notif_TextChanged1(sender As Object, e As EventArgs) Handles notif.TextChanged
        Timer1.Stop()
        ProgressBar1.Value = 0
    End Sub

    Private Sub intxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles intxt.KeyPress
        If e.KeyChar = Chr(13) Then
            btnproses_Click(sender, e)
        End If
    End Sub

    Private Sub minime_Click(sender As Object, e As EventArgs) Handles minime.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub MenuStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub MenuStrip1_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseUp
        drag = False
    End Sub

    
End Class
