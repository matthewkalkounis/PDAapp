Imports System.Security.Cryptography

Public Class frmMain
    Private Sub bttnOrders_MouseEnter(sender As Object, e As EventArgs) Handles bttnOrders.MouseEnter
        bttnOrders.BackColor = ColorTranslator.FromHtml("#1d3557")
    End Sub

    Private Sub bttnProducts_MouseEnter(sender As Object, e As EventArgs) Handles bttnProducts.MouseEnter
        bttnProducts.BackColor = ColorTranslator.FromHtml("#1d3557")
    End Sub

    Private Sub bttnPrices_MouseEnter(sender As Object, e As EventArgs) Handles bttnPrices.MouseEnter
        bttnPrices.BackColor = ColorTranslator.FromHtml("#1d3557")
    End Sub

    Private Sub bttnWarehouse_MouseEnter(sender As Object, e As EventArgs) Handles bttnWarehouse.MouseEnter
        bttnWarehouse.BackColor = ColorTranslator.FromHtml("#1d3557")
    End Sub

    Private Sub bttnOrders_MouseLeave(sender As Object, e As EventArgs) Handles bttnOrders.MouseLeave
        bttnOrders.BackColor = ColorTranslator.FromHtml("#1a1b1e")
    End Sub

    Private Sub bttnProducts_MouseLeave(sender As Object, e As EventArgs) Handles bttnProducts.MouseLeave
        bttnProducts.BackColor = ColorTranslator.FromHtml("#1a1b1e")
    End Sub

    Private Sub bttnPrices_MouseLeave(sender As Object, e As EventArgs) Handles bttnPrices.MouseLeave
        bttnPrices.BackColor = ColorTranslator.FromHtml("#1a1b1e")
    End Sub

    Private Sub bttnWarehouse_MouseLeave(sender As Object, e As EventArgs) Handles bttnWarehouse.MouseLeave
        bttnWarehouse.BackColor = ColorTranslator.FromHtml("#1a1b1e")
    End Sub

    Private Sub bttnMenu_MouseEnter(sender As Object, e As EventArgs) Handles bttnMenu.MouseEnter
        bttnMenu.BackColor = ColorTranslator.FromHtml("#1d3557")
    End Sub

    Private Sub bttnMenu_MouseLeave(sender As Object, e As EventArgs) Handles bttnMenu.MouseLeave
        bttnMenu.BackColor = ColorTranslator.FromHtml("#1a1b1e")
    End Sub

    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub bttnClose_MouseEnter(sender As Object, e As EventArgs) Handles bttnClose.MouseEnter
        bttnClose.BackColor = ColorTranslator.FromHtml("#e63946")
    End Sub

    Private Sub bttnClose_MouseLeave(sender As Object, e As EventArgs) Handles bttnClose.MouseLeave
        bttnClose.BackColor = ColorTranslator.FromHtml("#2f3e46")
    End Sub

    Private Sub bttnMenu_MouseClick(sender As Object, e As MouseEventArgs) Handles bttnMenu.MouseClick
        If pnlMenu.Width = 308 Then
            pnlMenu.Width = 45
            bttnMenu.Location = New Point(2, 6)
        Else
            pnlMenu.Width = 308
            bttnMenu.Location = New Point(264, 6)
        End If
    End Sub

    Private Sub bttnProducts_Click(sender As Object, e As EventArgs) Handles bttnProducts.Click
        pnlForms.Controls.Clear()
        frmProduct.TopLevel = False
        pnlForms.Controls.Add(frmProduct)
        frmProduct.Dock = DockStyle.Fill
        frmProduct.Show()
    End Sub
End Class