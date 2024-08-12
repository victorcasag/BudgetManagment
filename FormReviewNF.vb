Imports System.IO
Imports Npgsql
Imports Excel = Microsoft.Office.Interop.Excel

Public Class FormReviewNF
    Private company As New Company
    Private bank As New Bank
    Private school As New School
    Private address As New Address
    Private listProductGlobal As New List(Of Product)
    Private note As New Note

    Public Sub New(ByRef company As Company, ByRef school As School, ByRef listProductGlobal As List(Of Product), ByRef note As Note, ByRef address As Address)
        InitializeComponent()
        Me.company = company
        Me.school = school
        Me.listProductGlobal = listProductGlobal
        Me.note = note
        Me.address = address
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If school.Name.Contains("/") Then
            Dim strPart As String() = school.Name.Split("/"c)

            Dim nameSchool As String = strPart(0)
            Dim PDDE As String = strPart(1)

            TextBoxNameDest.Text = nameSchool
            school.Name = nameSchool
            TextBoxPDDE.Text = PDDE
            note.PDDE = PDDE
        Else
            TextBoxNameDest.Text = school.Name
        End If

        TextBoxNameEmit.Text = company.Name
        TextBoxValueTotalNF.Text = "R$ " & note.Total.ToString("0.00")
        TextBoxValueTotalProducts.Text = "R$ " & note.TotalProducts.ToString("0.00")

        BindingSourceProduct.DataSource = listProductGlobal

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Dispose()
    End Sub

    Private Sub SaveBudget(ByVal listProduct As List(Of Product))
        Try
            Dim con As NpgsqlConnection = DatabaseConnection.Instance.OpenConnection()

            Dim addressService As New AddressService(con)
            Dim budgetService As New BudgetService(con)
            Dim companyService As New CompanyService(con)
            Dim noteService As New NoteService(con)
            Dim productService As New ProductService(con)
            Dim schoolService As New SchoolService(con)

            Dim companyId As Integer = companyService.FindId(company)

            Dim schoolId As Integer = schoolService.FindId(school)

            Dim noteId As Integer = noteService.FindId(note)

            If schoolId = 0 Then
                school.IdAddress = addressService.InsertAddress(address)
                schoolId = schoolService.CreateSchool(school)
            End If

            note.SchoolId = schoolId
            note.CompanyId = companyId

            If noteId = 0 Then
                noteService.CreateNote(note)
            Else
                DatabaseConnection.Instance.CloseConnection()
                Exit Sub
            End If

            For Each product In listProduct
                product.Quantity = product.Quantity.ToString().TrimEnd("0"c).TrimEnd("."c)
                product.NoteId = noteId
                product.SchoolId = schoolId
                product.CompanyId = companyId
                productService.CreateProduct(product)
            Next

            Dim budget As New BudgetDTO With {
                .CompanyId = companyId,
                .NoteId = noteId,
                .SchoolId = schoolId
            }

            budgetService.CreateBudget(budget)

            DatabaseConnection.Instance.CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Erro: ")
        End Try
    End Sub


    Private Sub ButtonAdvance_Click(sender As Object, e As EventArgs) Handles ButtonAdvance.Click

        Dim listProductLocal As New List(Of Product)

        note.PDDE = TextBoxPDDE.Text
        note.DateBudget = DateTimePicker1.Text


        SaveBudget(listProductGlobal)

        If CheckBoxPrint.Checked Then
            MakeReportExcelAndPrint(company.Name, listProductGlobal, "Arial", 9)
            MessageBox.Show("Orçamento de Otomar está feito!")
        End If

        company = New Company()
        note = New Note()
        address = New Address()
        bank = New Bank

        If CheckedListBox1.GetItemChecked(0) Then ' Marli

            For Each product In listProductGlobal
                Dim formChangeData As New FormChangeData(note.DateBudget, product, "Marli")
                formChangeData.ShowDialog()
                note.DateBudget = formChangeData.NewDate
                listProductLocal.Add(formChangeData.NewProduct)
            Next

            note.Discount = 0
            note.TotalProducts = listProductLocal.Sum(Function(prod) prod.ValueTotal)
            note.Total = note.TotalProducts - note.Discount

            MakeReportExcelAndPrint("Marli", listProductLocal, "Abadi Extra Light", 9)

            SaveBudget(listProductLocal)

            MessageBox.Show("Orçamento de Marli está feito!")

            listProductLocal.Clear()
        End If

        If CheckedListBox1.GetItemChecked(1) Then ' Adelino

            For Each product In listProductGlobal

                Dim formChangeData As New FormChangeData(note.DateBudget, product, "Adelino")
                formChangeData.ShowDialog()
                note.DateBudget = formChangeData.NewDate
                listProductLocal.Add(formChangeData.NewProduct)
            Next
            note.Discount = 0
            note.TotalProducts = listProductLocal.Sum(Function(prod) prod.ValueTotal)
            note.Total = note.TotalProducts - note.Discount

            MakeReportExcelAndPrint("Adelino", listProductLocal, "Calibri", 9)
            MessageBox.Show("Orçamento de Adelino está feito!")
            listProductLocal.Clear()
        End If

        If CheckedListBox1.GetItemChecked(2) Then ' Decore

            For Each product In listProductGlobal

                Dim formChangeData As New FormChangeData(note.DateBudget, product, "Decore")
                formChangeData.ShowDialog()
                note.DateBudget = formChangeData.NewDate
                listProductLocal.Add(formChangeData.NewProduct)
            Next
            note.Discount = 0
            note.TotalProducts = listProductLocal.Sum(Function(prod) prod.ValueTotal)
            note.Total = note.TotalProducts - note.Discount

            MakeReportExcelAndPrint("Decore", listProductLocal, "Consolas", 9)
            MessageBox.Show("Orçamento de Decore está feito!")
            listProductLocal.Clear()
        End If

        If CheckedListBox1.GetItemChecked(3) Then ' GRT

            For Each product In listProductGlobal
                Dim formChangeData As New FormChangeData(note.DateBudget, product, "GRT")
                formChangeData.ShowDialog()
                note.DateBudget = formChangeData.NewDate
                listProductLocal.Add(formChangeData.NewProduct)
            Next

            note.Discount = 0
            note.TotalProducts = listProductLocal.Sum(Function(prod) prod.ValueTotal)
            note.Total = note.TotalProducts - note.Discount

            MakeReportExcelAndPrint("GRT", listProductLocal, "Amasis MT Pro", 9)

            MessageBox.Show("Orçamento de GRT está feito!")

            listProductLocal.Clear()

        End If

        If CheckedListBox1.GetItemChecked(4) Then ' Marybook

            For Each product In listProductGlobal
                Dim formChangeData As New FormChangeData(note.DateBudget, product, "Marybook")
                formChangeData.ShowDialog()
                note.DateBudget = formChangeData.NewDate
                listProductLocal.Add(formChangeData.NewProduct)
            Next
            note.Discount = 0
            note.TotalProducts = listProductLocal.Sum(Function(prod) prod.ValueTotal)
            note.Total = note.TotalProducts - note.Discount

            MakeReportExcelAndPrint("Marybook", listProductLocal, "Corbel", 10)
            MessageBox.Show("Orçamento de Marybook está feito!")
            listProductLocal.Clear()
        End If

    End Sub

    Private Sub MakeReportExcelAndPrint(ByVal nameCompany As String, ByVal listProduct As List(Of Product), ByVal font As String, ByVal size As Integer)
        Try
            Dim strPath As String = "C:\temp\BudgetManagement\padroes\padrao.xlsx"

            Dim con As NpgsqlConnection = DatabaseConnection.Instance.OpenConnection()
            Dim noteService As New NoteService(con)
            Dim companyService As New CompanyService(con)
            Dim bankService As New BankService(con)
            Dim addressService As New AddressService(con)
            Dim schoolService As New SchoolService(con)

            Dim formatCNPJClient As String = school.CNPJ.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-")

            Dim strPathNew As String = "C:\temp\BudgetManagement\orcametos\" & nameCompany & "\" & school.Name.Trim() & "\" & note.NumberNote & " - " & noteService.FindId(note) & ".xlsx"

            Dim directoryPath As String = Path.GetDirectoryName(strPathNew)

            If Not Directory.Exists(directoryPath) Then
                Directory.CreateDirectory(directoryPath)
            End If

            Dim excelApp As New Excel.Application()
            Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Open(strPath)
            Dim excelWorksheet As Excel.Worksheet = excelWorkbook.Sheets(1)

            Dim rowIndex As Integer = 18

            'Cabeçalho Empresa  
            company.Name = nameCompany
            company = companyService.FindCompany(company)

            bank.Id = company.IdBank
            bank = bankService.FindById(bank)

            address.Id = company.IdAddress
            address = addressService.FindById(address)

            Dim startCellCompanyPhone As Excel.Range = excelWorksheet.Cells(6, 2)
            Dim endCellCompanyPhone As Excel.Range = excelWorksheet.Cells(6, 4)
            excelWorksheet.Range(startCellCompanyPhone, endCellCompanyPhone).Merge()

            excelWorksheet.Cells(1, 2).Value = company.Name
            excelWorksheet.Cells(2, 2).Value = address.Street & ", " & address.Number
            excelWorksheet.Cells(3, 2).Value = address.City
            excelWorksheet.Cells(4, 2).Value = bank.Name
            excelWorksheet.Cells(5, 2).Value = bank.Agency
            excelWorksheet.Cells(5, 4).Value = bank.CurrentAccount
            excelWorksheet.Cells(6, 2).Value = company.Phone


            'Cabeçalho Escola

            Dim startCellClientPhone As Excel.Range = excelWorksheet.Cells(11, 2)
            Dim endCellClientPhone As Excel.Range = excelWorksheet.Cells(11, 7)
            excelWorksheet.Range(startCellClientPhone, endCellClientPhone).Merge()

            Dim startCellClientCNPJ As Excel.Range = excelWorksheet.Cells(12, 2)
            Dim endCellClientCNPJ As Excel.Range = excelWorksheet.Cells(12, 7)
            excelWorksheet.Range(startCellClientCNPJ, endCellClientCNPJ).Merge()

            school = schoolService.FindById(school)

            address.Id = school.IdAddress
            address = addressService.FindById(address)

            excelWorksheet.Cells(8, 2).Value = school.Name
            excelWorksheet.Cells(9, 2).Value = address.Street & ", " & address.Number
            excelWorksheet.Cells(10, 2).Value = address.City
            excelWorksheet.Cells(11, 2).Value = school.Phone
            excelWorksheet.Cells(12, 2).Value = formatCNPJClient
            excelWorksheet.Cells(13, 2).Value = note.PDDE

            'Produtos

            For Each product As Product In listProduct
                excelWorksheet.Cells(rowIndex, 1).EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)

                Dim startCell As Excel.Range = excelWorksheet.Cells(rowIndex, 2)
                Dim endCell As Excel.Range = excelWorksheet.Cells(rowIndex, 5)
                Dim mergedRange As Excel.Range = excelWorksheet.Range(startCell, endCell)
                mergedRange.Merge()
                mergedRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                Dim unitMoneyRange As Excel.Range = excelWorksheet.Cells(rowIndex, 7)
                Dim totalMoneyRange As Excel.Range = excelWorksheet.Cells(rowIndex, 8)
                unitMoneyRange.NumberFormat = "$ #,##0.00"
                totalMoneyRange.NumberFormat = "$ #,##0.00"

                excelWorksheet.Cells(rowIndex, 1).Value = product.Sequence
                excelWorksheet.Cells(rowIndex, 2).Value = product.Name
                excelWorksheet.Cells(rowIndex, 6).Value = product.Quantity

                unitMoneyRange.Value = product.ValueUnit
                totalMoneyRange.Value = product.ValueTotal

                rowIndex += 1
            Next

            'Rodapé Orçamento

            Dim actualYear As Integer = DateTime.Now.Year
            Dim lastDayOnYear As DateTime = New DateTime(actualYear, 12, 31)

            excelWorksheet.Cells(rowIndex + 2, 1).Value = note.DateBudget
            excelWorksheet.Cells(rowIndex + 2, 5).Value = note.TotalProducts
            excelWorksheet.Cells(rowIndex + 2, 8).Value = note.Total
            excelWorksheet.Cells(rowIndex + 3, 6).Value = note.Discount
            excelWorksheet.Cells(rowIndex + 1, 6).Value = lastDayOnYear.ToShortDateString()

            excelWorkbook.SaveAs(strPathNew)
            excelWorkbook.Close()
            excelApp.Quit()

            'PrintPDF(strPathNew)

            KillExcel()

            DatabaseConnection.Instance.CloseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub KillExcel()
        Dim xlp() As Process = Process.GetProcessesByName("EXCEL")
        For Each Process As Process In xlp
            Process.Kill()
        Next
    End Sub

    Private Sub PrintPDF(ByVal DocumentName)
        Dim proc As New Process
        proc.StartInfo.FileName = DocumentName
        proc.StartInfo.Verb = "Print"
        proc.StartInfo.CreateNoWindow = False
        proc.Start()
        System.Threading.Thread.Sleep(10000)
    End Sub

End Class