Imports System.Xml

Public Class FormMain
    Private Sub FormMain_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            ReadXML(path)
        Next
    End Sub

    Private Sub FormMain_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Function OpenFileDialog() As String
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\Users\victo\OneDrive\Documentos\Projeto Otomar"
        fd.Filter = "XML|*.xml|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Return strFileName
        End If
        Return Nothing
    End Function

    Private Sub ButtonSelectFile_Click(sender As Object, e As EventArgs) Handles ButtonSelectFile.Click

        ReadXML(OpenFileDialog())

    End Sub

    Private Sub ReadXML(filepath As String)
        If filepath Is Nothing Then Exit Sub
        Dim company As New Company()
        Dim address As New Address()
        Dim school As New School()
        Dim listProduct As New List(Of Product)
        Dim product As New Product()
        Dim note As New Note()

        Dim ide As Boolean = False
        Dim emit As Boolean = False
        Dim enderEmit As Boolean = False
        Dim dest As Boolean = False
        Dim enderDest As Boolean = False
        Dim det As Boolean = False
        Dim prod As Boolean = False
        Dim total As Boolean = False
        Dim ICMSTot As Boolean = False

        Try

            Using xml = XmlReader.Create(filepath)
                While xml.Read()
                    If xml.NodeType = XmlNodeType.Element Or xml.NodeType = XmlNodeType.EndElement Then

                        If xml.Name = "ide" Then
                            ide = True
                        End If

                        If xml.Name = "nNF" AndAlso ide Then
                            note.NumberNote = xml.ReadElementContentAsLong()
                            ide = False
                        End If

                        'emit (Quem está emitindo a NF) COMEÇA
                        If xml.Name = "emit" Then
                            emit = True

                        End If

                        If xml.Name = "CNPJ" AndAlso emit Then
                            company.CNPJ = xml.ReadElementContentAsString()
                        End If

                        If xml.Name = "xNome" AndAlso emit AndAlso xml.NodeType = XmlNodeType.Element Then
                            company.Name = xml.ReadElementContentAsString()
                        End If

                        'enderEmit (endereço emitente) COMEÇA | Está dentro de emit

                        If xml.Name = "enderEmit" AndAlso emit Then
                            enderEmit = True
                        End If
                        If xml.Name = "xLgr" AndAlso enderEmit Then
                            address.Street = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "nro" AndAlso enderEmit Then
                            address.Number = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "xBairro" AndAlso enderEmit Then
                            address.Neighborhood = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "xMun" AndAlso enderEmit Then
                            address.City = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "fone" AndAlso enderEmit Then
                            company.Phone = xml.ReadElementContentAsString()
                            enderEmit = False
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "enderEmit" Then
                            enderEmit = False
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "emit" Then
                            emit = False
                        End If

                        'enderEmit TERMINA

                        'dest Começa

                        If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "dest" Then
                            dest = True
                        End If
                        If xml.Name = "CNPJ" AndAlso dest Then
                            school.CNPJ = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "xNome" AndAlso dest AndAlso xml.NodeType = XmlNodeType.Element Then
                            school.Name = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "enderDest" AndAlso dest Then
                            enderDest = True
                        End If
                        If xml.Name = "xLgr" AndAlso enderDest AndAlso dest Then
                            address.Street = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "nro" AndAlso enderDest AndAlso dest Then
                            address.Number = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "xBairro" AndAlso enderDest AndAlso dest Then
                            address.Neighborhood = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "xMun" AndAlso enderDest AndAlso dest Then
                            address.City = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "fone" AndAlso enderDest AndAlso dest Then
                            school.Phone = xml.ReadElementContentAsString()
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "enderDest" Then
                            enderDest = False
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "dest" Then
                            dest = False
                        End If

                        'dest TERMINA

                        'det COMEÇA (PRODUTO)

                        If xml.NodeType = XmlNodeType.Element And xml.Name = "det" Then
                            det = True

                            product = New Product()

                            product.Sequence = xml.GetAttribute("nItem")
                        End If
                        If xml.Name = "prod" And det Then
                            prod = True
                        End If
                        If xml.Name = "cProd" And det Then
                            product.Code = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "xProd" AndAlso det Then
                            product.Name = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "qCom" AndAlso det AndAlso prod Then
                            product.Quantity = xml.ReadElementContentAsString()
                        End If
                        If xml.Name = "vUnTrib" AndAlso det AndAlso prod Then
                            product.ValueUnit = xml.ReadElementContentAsDouble()
                        End If
                        If xml.Name = "vProd" AndAlso det AndAlso prod Then
                            product.ValueTotal = xml.ReadElementContentAsDouble()
                            listProduct.Add(product)
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "prod" Then
                            prod = False
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "det" Then
                            det = False
                        End If

                        'det TERMINA

                        'total COMEÇA

                        If xml.NodeType = XmlNodeType.Element And xml.Name = "total" Then
                            total = True
                        End If
                        If xml.Name = "ICMSTot" And total Then
                            ICMSTot = True
                        End If
                        If xml.Name = "vProd" And total And ICMSTot Then
                            note.TotalProducts = xml.ReadElementContentAsDouble()
                        End If
                        If xml.Name = "vDesc" And total And ICMSTot Then
                            note.Discount = xml.ReadElementContentAsDouble()
                        End If
                        If xml.Name = "vNF" And total And ICMSTot Then
                            note.Total = xml.ReadElementContentAsDouble()
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "ICMSTot" Then
                            ICMSTot = False
                        End If
                        If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "total" Then
                            total = False
                        End If
                    End If
                    'total TERMINA
                End While
            End Using

            OpenFormReview(company, school, listProduct, note, address)

            company = Nothing
            school = Nothing
            listProduct = Nothing
            product = Nothing
            note = Nothing

        Catch ex As Exception
            MessageBox.Show("ERROR " & ex.Message)
        End Try
    End Sub

    Private Sub OpenFormReview(ByRef company As Company, ByRef school As School, ByRef listProduct As List(Of Product), ByRef note As Note, ByRef address As Address)
        Me.Visible() = False
        Dim formReview As New FormReviewNF(company, school, listProduct, note, address)
        formReview.ShowDialog()
        Me.Visible = True

    End Sub

    Private Sub AdicionarEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarEmpresaToolStripMenuItem.Click
        Me.Visible() = False
        Dim formAdd As New FormAddCompany()
        formAdd.ShowDialog()
        Me.Visible = True

    End Sub

    Private Sub ButtonManual_Click(sender As Object, e As EventArgs) Handles ButtonManual.Click

    End Sub
End Class
