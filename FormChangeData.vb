Public Class FormChangeData

    Private productGlobal As New Product
    Private companyGlobal As String
    Private newDateLast As Date
    Private listProductGlobal As New List(Of Product)

    Public Sub New(ByRef newDateLast As Date, ByRef productGlobal As Product, ByRef companyGlobal As String)
        InitializeComponent()
        Me.productGlobal = productGlobal
        Me.companyGlobal = companyGlobal
        Me.newDateLast = newDateLast
    End Sub
    Public Property NewProduct As New Product
    Public Property NewDate As String

    Private Sub FormChangeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewProduct = productGlobal
        TextBoxNameProduct.Text = NewProduct.Name
        TextBoxCod.Text = NewProduct.Code
        TextBoxQuantityProduct.Text = NewProduct.Quantity
        TextBoxValueProduct.Text = NewProduct.ValueUnit.ToString("R$###,###,###.00")
        TextBoxNewValueProduct.Text = NewProduct.ValueUnit.ToString("###,###,###.00")
        TextBoxCompany.Text = companyGlobal
        If newDateLast.Year > 2000 Then DateTimePicker1.Value = newDateLast
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click

        Dim totalValue As Double

        Dim valueUnit As String

        valueUnit = TextBoxQuantityProduct.Text.Replace(".", ",").Trim()

        totalValue = (TextBoxNewValueProduct.Text * valueUnit)

        NewProduct.Name = TextBoxNameProduct.Text
        NewProduct.Code = TextBoxCod.Text
        NewProduct.Quantity = TextBoxQuantityProduct.Text
        NewProduct.ValueUnit = TextBoxNewValueProduct.Text
        NewProduct.ValueTotal = totalValue
        NewDate = DateTimePicker1.Value
        listProductGlobal.Add(NewProduct)
        Me.Hide()
    End Sub

    Private Sub TextBoxNewValueProduct_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBoxNewValueProduct.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub


End Class