Public Class MainForm
    Dim Hombre As Boolean = True
    Dim Mujer As Boolean = True
    Dim Calzado As Boolean = True
    Dim Accesorio As Boolean = True
    Dim C1, C2, C3, C4, Total As Integer
    Dim M1, M2, M3, M4 As Integer
    Private Sub btnFlecha11_Click(sender As Object, e As EventArgs) Handles btnFlecha11.Click
        If CInt(lblCant1.Text) > 0 Then
            If Hombre Then
                C1 = C1 - 1
                lblCant1.Text = CStr(C1)
                Total = Total - 120
            ElseIf Mujer Then
                M1 = M1 - 1
                lblCant1.Text = CStr(M1)
                Total = Total - 80
            End If
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
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(0)
            lblPrecio.Text = "$ 120"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(0)
            lblPrecio.Text = "$ 80"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(0)
            lblPrecio.Text = "$ 120"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(0)
            lblPrecio.Text = "$ 380"
        End If
    End Sub

    Private Sub btnComprar2_Click(sender As Object, e As EventArgs) Handles btnComprar2.Click
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(1)
            lblPrecio.Text = "$ 240"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(1)
            lblPrecio.Text = "$ 150"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(1)
            lblPrecio.Text = "$ 140"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(1)
            lblPrecio.Text = "$ 70"
        End If

    End Sub

    Private Sub btnComprar3_Click(sender As Object, e As EventArgs) Handles btnComprar3.Click
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(2)
            lblPrecio.Text = "$ 160"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(2)
            lblPrecio.Text = "$ 220"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(2)
            lblPrecio.Text = "$ 160"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(2)
            lblPrecio.Text = "$ 190"
        End If

    End Sub

    Private Sub btnComprar4_Click(sender As Object, e As EventArgs) Handles btnComprar4.Click
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(3)
            lblPrecio.Text = "$ 70"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(3)
            lblPrecio.Text = "$ 270"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(3)
            lblPrecio.Text = "$ 80"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(3)
            lblPrecio.Text = "$ 50"
        End If
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
            If Hombre Then
                Total = Total + 120
            ElseIf Mujer Then
                Total = Total + 80
            End If
            lblTotal.Text = "$" & CStr(Total)
            End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click
        Hombre = True
        Mujer = False
        Calzado = False
        Accesorio = False
        lblCant1.Text = CStr(C1)
        lblCant2.Text = CStr(C2)
        lblCant3.Text = CStr(C3)
        lblCant4.Text = CStr(C4)
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA HOMBRES, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilHombres.Images.Item(0)
        Label2.Text = "XS  S  M  L  XL"
        lblPrecio.Text = "$ 120"
        lblCamisaDeAlgodon.Text = "Camisa de Algodón"
        lblPrecioCamisaAlgodon.Text = "$ 120"

        lblBlazer.Text = "Blazer Mezcla de Lana"
        lblPrecioBlazer.Text = "$ 240"

        lblJersey.Text = "Jersey Cuello Pico"
        lblPrecioJersey.Text = "$ 160"

        lblPolo.Text = "Polo Cuello Redondo"
        lblPrecioPolo.Text = "$ 80"
    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        Hombre = False
        Mujer = True
        Calzado = False
        Accesorio = False
        lblCant1.Text = CStr(M1)
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA MUJERES, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilMujeres.Images.Item(0)
        Label2.Text = "XS  S  M  L  XL"
        lblPrecio.Text = "$ 80"
        lblCamisaDeAlgodon.Text = "Polo Rayas Cuello Redondo"
        lblPrecioCamisaAlgodon.Text = "$ 80"

        lblBlazer.Text = "Chompa Lana Cuello Redondo"
        lblPrecioBlazer.Text = "$ 150"

        lblJersey.Text = "Casaca de Jean"
        lblPrecioJersey.Text = "$ 220"

        lblPolo.Text = "Abrigo Mezcla Lana"
        lblPrecioPolo.Text = "$ 270"
    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click
        Hombre = False
        Mujer = False
        Calzado = True
        Accesorio = False
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA CALZADOS, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilCalzado.Images.Item(0)
        Label2.Text = "37  38  40  42  44"
        lblPrecio.Text = "$ 120"
        lblCamisaDeAlgodon.Text = "Zapatos Oxfords"
        lblPrecioCamisaAlgodon.Text = "$ 120"

        lblBlazer.Text = "Zapatos Derby"
        lblPrecioBlazer.Text = "$ 140"

        lblJersey.Text = "Botines"
        lblPrecioJersey.Text = "$ 160"

        lblPolo.Text = "Loafers"
        lblPrecioPolo.Text = "$ 80"
    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        Hombre = False
        Mujer = False
        Calzado = False
        Accesorio = True
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA CALZADOS, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilAccesorio.Images.Item(0)
        Label2.Text = "XS  S  M  L  XL"
        lblPrecio.Text = "$ 380"
        lblCamisaDeAlgodon.Text = "Reloj de Acero"
        lblPrecioCamisaAlgodon.Text = "$ 380"

        lblBlazer.Text = "Cinturon de Cuero"
        lblPrecioBlazer.Text = "$ 70"

        lblJersey.Text = "Billetera de Cuero"
        lblPrecioJersey.Text = "$ 190"

        lblPolo.Text = "Gorra Clasica"
        lblPrecioPolo.Text = "$ 50"
    End Sub
End Class