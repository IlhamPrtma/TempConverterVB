Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AwalCB.Items.AddRange({"Celcius", "Fahrenheit", "Reamur", "Kelvin"})
        AwalCB.DropDownStyle = ComboBoxStyle.DropDownList

        HasilCB.Items.AddRange({"Celcius", "Fahrenheit", "Reamur", "Kelvin"})
        HasilCB.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Convert_Click(sender As Object, e As EventArgs) Handles Convert.Click
        ' Deklarasi objek Converter
        Dim objConv As New RefTugasMod8.Converter

        ' Mendapatkan nilai dan jenis suhu awal dari TextBox dan ComboBox
        If String.IsNullOrEmpty(AwalTB.Text) OrElse AwalCB.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in the value and select the temperature type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nilaiAwal As Double = CDbl(AwalTB.Text)
        Dim jenisAwal As String = AwalCB.SelectedItem.ToString()

        ' Mendapatkan jenis suhu hasil dari ComboBox Hasil
        If HasilCB.SelectedItem Is Nothing Then
            MessageBox.Show("Please select the result temperature type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim jenisHasil As String = HasilCB.SelectedItem.ToString()

        ' Melakukan konversi berdasarkan jenis suhu awal dan hasil
        Dim hasil As Double = 0.0

        Select Case jenisAwal
            Case "Celcius"
                Select Case jenisHasil
                    Case "Celcius"
                        hasil = objConv.cToC(nilaiAwal)
                    Case "Fahrenheit"
                        hasil = objConv.cToF(nilaiAwal)
                    Case "Reamur"
                        hasil = objConv.cToR(nilaiAwal)
                    Case "Kelvin"
                        hasil = objConv.cToK(nilaiAwal)
                End Select
            Case "Fahrenheit"
                Select Case jenisHasil
                    Case "Celcius"
                        hasil = objConv.fToC(nilaiAwal)
                    Case "Fahrenheit"
                        hasil = objConv.fToF(nilaiAwal)
                    Case "Reamur"
                        hasil = objConv.fToR(nilaiAwal)
                    Case "Kelvin"
                        hasil = objConv.fToK(nilaiAwal)
                End Select
            Case "Reamur"
                Select Case jenisHasil
                    Case "Celcius"
                        hasil = objConv.rToC(nilaiAwal)
                    Case "Fahrenheit"
                        hasil = objConv.rToF(nilaiAwal)
                    Case "Reamur"
                        hasil = objConv.rToR(nilaiAwal)
                    Case "Kelvin"
                        hasil = objConv.rToK(nilaiAwal)
                End Select
            Case "Kelvin"
                Select Case jenisHasil
                    Case "Celcius"
                        hasil = objConv.kToC(nilaiAwal)
                    Case "Fahrenheit"
                        hasil = objConv.kToF(nilaiAwal)
                    Case "Reamur"
                        hasil = objConv.kToR(nilaiAwal)
                    Case "Kelvin"
                        hasil = objConv.kToK(nilaiAwal)
                End Select
        End Select

        ' Menampilkan hasil konversi ke TextBox Hasil
        HasilTB.Text = hasil.ToString()
    End Sub
End Class
