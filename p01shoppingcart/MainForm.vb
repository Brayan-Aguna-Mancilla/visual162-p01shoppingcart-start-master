Public Class MainForm
    Dim C1, C2, C3, C4, Total As Integer
    Private Sub btnFlecha11_Click(sender As Object, e As EventArgs) Handles btnFlecha11.Click
        If CInt(lblCant1.Text) > 0 Then
            C1 = C1 - 1
            lblCant1.Text = CStr(C1)
            Total = Total - 120
            lblTotal.Text = "$" & CStr(Total)
        Else
            If C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 Then
                C1 = C1
                lblCant1.Text = CStr(C1)
                lblTotal.Text = "$ 0"
            Else
                C1 = C1
                lblCant1.Text = CStr(C1)
            End If
        End If
    End Sub

    Private Sub btnFlecha21_Click(sender As Object, e As EventArgs) Handles btnFlecha21.Click
        If CInt(lblCant2.Text) > 0 Then
            C2 = C2 - 1
            lblCant2.Text = CStr(C2)
            Total = Total - 240
            lblTotal.Text = "$" & CStr(Total)
        Else
            If C1 = 0 AndAlso C3 = 0 AndAlso C4 = 0 Then
                C2 = C2
                lblCant2.Text = CStr(C2)
                lblTotal.Text = "$ 0"
            Else
                C2 = C2
                lblCant2.Text = CStr(C2)
            End If
        End If
    End Sub

    Private Sub btnFlecha22_Click(sender As Object, e As EventArgs) Handles btnFlecha22.Click
        If CInt(lblCant2.Text) >= 0 Then
            C2 = C2 + 1
            lblCant2.Text = CStr(C2)
            Total = Total + 240
            lblTotal.Text = "$" & CStr(Total)
        End If
    End Sub

    Private Sub btnFlecha31_Click(sender As Object, e As EventArgs) Handles btnFlecha31.Click
        If CInt(lblCant3.Text) > 0 Then
            C3 = C3 - 1
            lblCant3.Text = CStr(C3)
            Total = Total - 160
            lblTotal.Text = "$" & CStr(Total)
        Else
            If C2 = 0 AndAlso C1 = 0 AndAlso C4 = 0 Then
                C3 = C3
                lblCant3.Text = CStr(C3)
                lblTotal.Text = "$ 0"
            Else
                C3 = C3
                lblCant3.Text = CStr(C3)
            End If
        End If
    End Sub

    Private Sub btnComprar1_Click(sender As Object, e As EventArgs) Handles btnComprar1.Click
        PictureBox1.Image = ilProductos.Images.Item(0)
        lblPrecio.Text = "$ 120"
    End Sub

    Private Sub btnComprar2_Click(sender As Object, e As EventArgs) Handles btnComprar2.Click
        PictureBox1.Image = ilProductos.Images.Item(1)
        lblPrecio.Text = "$ 240"
    End Sub

    Private Sub btnComprar3_Click(sender As Object, e As EventArgs) Handles btnComprar3.Click
        PictureBox1.Image = ilProductos.Images.Item(2)
        lblPrecio.Text = "$ 160"
    End Sub

    Private Sub btnComprar4_Click(sender As Object, e As EventArgs) Handles btnComprar4.Click
        PictureBox1.Image = ilProductos.Images.Item(3)
        lblPrecio.Text = "$ 70"
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        'Me.Show(MensajeDeCompraExitosa)
    End Sub

    Private Sub btnFlecha32_Click(sender As Object, e As EventArgs) Handles btnFlecha32.Click
        If CInt(lblCant3.Text) >= 0 Then
            C3 = C3 + 1
            lblCant3.Text = CStr(C3)
            Total = Total + 160
            lblTotal.Text = "$" & CStr(Total)
        End If
    End Sub

    Private Sub btnFlecha41_Click(sender As Object, e As EventArgs) Handles btnFlecha41.Click
        If CInt(lblCant4.Text) > 0 Then
            C4 = C4 - 1
            lblCant4.Text = CStr(C4)
            Total = Total - 70
            lblTotal.Text = "$" & CStr(Total)
        Else
            If C2 = 0 AndAlso C3 = 0 AndAlso C1 = 0 Then
                C4 = C4
                lblCant4.Text = CStr(C4)
                lblTotal.Text = "$ 0"
            Else
                C4 = C4
                lblCant4.Text = CStr(C4)
            End If
        End If
    End Sub

    Private Sub btnFlecha42_Click(sender As Object, e As EventArgs) Handles btnFlecha42.Click
        If CInt(lblCant4.Text) >= 0 Then
            C4 = C4 + 1
            lblCant4.Text = CStr(C4)
            Total = Total + 70
            lblTotal.Text = "$" & CStr(Total)
        End If
    End Sub

    Private Sub btnFlecha12_Click(sender As Object, e As EventArgs) Handles btnFlecha12.Click
        If CInt(lblCant1.Text) >= 0 Then
            C1 = C1 + 1
            lblCant1.Text = CStr(C1)
            Total = Total + 120
            lblTotal.Text = "$" & CStr(Total)
        End If
    End Sub
End Class