Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=lomba22"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim cek As MySqlDataReader
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim jenkel, hobi As String

    Sub tidakaktif()
        txtno.Enabled = False
        txtnama.Enabled = False
        txtlahir.Enabled = False
        dtplahir.Enabled = False
        rb1.Enabled = False
        rb2.Enabled = False
        cmbagama.Enabled = False
        txtnotelp.Enabled = False
        cb1.Enabled = False
        cb2.Enabled = False
        txtalamat.Enabled = False

        txtno.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray
        txtlahir.BackColor = Color.Gray
        rb1.BackColor = Color.Gray
        rb2.BackColor = Color.Gray
        cmbagama.BackColor = Color.Gray
        txtnotelp.BackColor = Color.Gray
        cb1.BackColor = Color.Gray
        cb2.BackColor = Color.Gray
        txtalamat.BackColor = Color.Gray

        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
    End Sub

    Sub aktif()
        txtno.Enabled = True
        txtnama.Enabled = True
        txtlahir.Enabled = True
        dtplahir.Enabled = True
        rb1.Enabled = True
        rb2.Enabled = True
        cmbagama.Enabled = True
        txtnotelp.Enabled = True
        cb1.Enabled = True
        cb2.Enabled = True
        txtalamat.Enabled = True

        txtno.BackColor = Color.White
        txtnama.BackColor = Color.White
        txtlahir.BackColor = Color.White
        rb1.BackColor = Color.White
        rb2.BackColor = Color.White
        cmbagama.BackColor = Color.White
        txtnotelp.BackColor = Color.White
        cb1.BackColor = Color.White
        cb2.BackColor = Color.White
        txtalamat.BackColor = Color.White

        btnsimpan.Enabled = True
        btnbatal.Enabled = True
        btnhapus.Enabled = True
        btnupdate.Enabled = True
    End Sub

    Sub bersih()
        txtno.Text = ""
        txtnama.Text = ""
        txtlahir.Text = ""
        cmbagama.Text = ""
        txtnotelp.Text = ""
        txtalamat.Text = ""
        rb1.Checked = False
        rb2.Checked = False
        cb1.Checked = False
        cb2.Checked = False
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from peserta"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "peserta")
        dgtampil.DataSource = ds.Tables("peserta")
        kon.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        aktif()
        txtno.Focus()
        btntambah.Enabled = False
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If rb1.Checked = True Then
            jenkel = "Laki - Laki"
        Else
            jenkel = "Perempuan"
        End If
        If cb1.Checked = True Then
            hobi = "Membaca"
        End If
        If cb2.Checked = True Then
            hobi = "Menulis"
        End If
        If cb1.Checked = True And cb2.Checked = True Then
            hobi = cb1.Text & "-" & cb2.Text
        End If

        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into peserta values " &
        " ('" & txtno.Text & "','" & txtnama.Text & "', " &
        " '" & txtlahir.Text & "','" & Format(dtplahir.Value, "yyyy-MM-dd") & "', " &
        " '" & jenkel & "','" & cmbagama.Text & "','" & txtnotelp.Text & "', " &
        " '" & hobi & "','" & txtalamat.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        btntambah.Enabled = True

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If rb1.Checked = True Then
            jenkel = "Laki - Laki"
        Else
            jenkel = "Perempuan"
        End If
        If cb1.Checked = True Then
            hobi = "Membaca"
        End If
        If cb2.Checked = True Then
            hobi = "Menulis"
        End If
        If cb1.Checked = True And cb2.Checked = True Then
            hobi = cb1.Text & "-" & cb2.Text
        End If
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "update peserta set Nama = '" & txtnama.Text & "', " &
        " Tempatlahir = '" & txtlahir.Text & "', Tanggallahir = '" & Format(dtplahir.Value, "yyyy-MM-dd") & "', " &
        " JenisKelamin = '" & jenkel & "', Agama = '" & cmbagama.Text & "', NoTelp = '" & txtnotelp.Text & "', " &
        " Hobi = '" & hobi & "', Alamat = '" & txtalamat.Text & "' where NoPeserta = '" & txtno.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        btntambah.Enabled = True
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        tidakaktif()
        bersih()
        btntambah.Enabled = True
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from peserta where NoPeserta='" & txtno.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
        btntambah.Enabled = True
    End Sub

    Private Sub txtno_TextChanged(sender As Object, e As EventArgs) Handles txtno.TextChanged
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from peserta where Nopeserta='" & txtno.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnama.Text = cek.Item("Nama")
            txtlahir.Text = cek.Item("Tempatlahir")
            dtplahir.Value = cek.Item("Tanggallahir")
            jenkel = cek.Item("JenisKelamin")
            If jenkel = "Laki-laki" Then
                rb1.Checked = True
            Else
                rb2.Checked = True
            End If
            cmbagama.Text = cek.Item("Agama")
            txtnotelp.Text = cek.Item("NoTelp")
            hobi = cek.Item("Hobi")
            If hobi = "Membaca" Then
                cb1.Checked = True
            End If
            If hobi = "Menulis" Then
                cb2.Checked = True
            End If
            If hobi = "Membaca" And hobi = "Menulis" Then
                cb1.Checked = True
                cb2.Checked = True
            End If
            txtalamat.Text = cek.Item("Alamat")
        End If
        kon.Close()

    End Sub




End Class
