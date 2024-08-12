<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReviewNF
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SequenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelNameEmit = New System.Windows.Forms.Label()
        Me.LabelNameDest = New System.Windows.Forms.Label()
        Me.LabelPDDE = New System.Windows.Forms.Label()
        Me.LabelValueTotalNF = New System.Windows.Forms.Label()
        Me.TextBoxNameEmit = New System.Windows.Forms.TextBox()
        Me.TextBoxNameDest = New System.Windows.Forms.TextBox()
        Me.TextBoxPDDE = New System.Windows.Forms.TextBox()
        Me.TextBoxValueTotalNF = New System.Windows.Forms.TextBox()
        Me.TextBoxValueTotalProducts = New System.Windows.Forms.TextBox()
        Me.ButtonAdvance = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxPrint = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SequenceDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.ValueUnitDataGridViewTextBoxColumn, Me.ValueTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSourceProduct
        Me.DataGridView1.Location = New System.Drawing.Point(15, 133)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'SequenceDataGridViewTextBoxColumn
        '
        Me.SequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence"
        Me.SequenceDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.SequenceDataGridViewTextBoxColumn.Name = "SequenceDataGridViewTextBoxColumn"
        Me.SequenceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SequenceDataGridViewTextBoxColumn.Width = 52
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 60
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 71
        '
        'ValueUnitDataGridViewTextBoxColumn
        '
        Me.ValueUnitDataGridViewTextBoxColumn.DataPropertyName = "ValueUnit"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValueUnitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValueUnitDataGridViewTextBoxColumn.HeaderText = "ValueUnit"
        Me.ValueUnitDataGridViewTextBoxColumn.Name = "ValueUnitDataGridViewTextBoxColumn"
        Me.ValueUnitDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValueUnitDataGridViewTextBoxColumn.Width = 78
        '
        'ValueTotalDataGridViewTextBoxColumn
        '
        Me.ValueTotalDataGridViewTextBoxColumn.DataPropertyName = "ValueTotal"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ValueTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ValueTotalDataGridViewTextBoxColumn.HeaderText = "ValueTotal"
        Me.ValueTotalDataGridViewTextBoxColumn.Name = "ValueTotalDataGridViewTextBoxColumn"
        Me.ValueTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValueTotalDataGridViewTextBoxColumn.Width = 83
        '
        'BindingSourceProduct
        '
        Me.BindingSourceProduct.DataSource = GetType(BudgetManagement.Product)
        '
        'LabelNameEmit
        '
        Me.LabelNameEmit.AutoSize = True
        Me.LabelNameEmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelNameEmit.Location = New System.Drawing.Point(12, 16)
        Me.LabelNameEmit.Name = "LabelNameEmit"
        Me.LabelNameEmit.Size = New System.Drawing.Size(105, 17)
        Me.LabelNameEmit.TabIndex = 1
        Me.LabelNameEmit.Text = "Nome Empresa"
        '
        'LabelNameDest
        '
        Me.LabelNameDest.AutoSize = True
        Me.LabelNameDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelNameDest.Location = New System.Drawing.Point(12, 49)
        Me.LabelNameDest.Name = "LabelNameDest"
        Me.LabelNameDest.Size = New System.Drawing.Size(91, 17)
        Me.LabelNameDest.TabIndex = 2
        Me.LabelNameDest.Text = "Nome Escola"
        '
        'LabelPDDE
        '
        Me.LabelPDDE.AutoSize = True
        Me.LabelPDDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelPDDE.Location = New System.Drawing.Point(12, 87)
        Me.LabelPDDE.Name = "LabelPDDE"
        Me.LabelPDDE.Size = New System.Drawing.Size(46, 17)
        Me.LabelPDDE.TabIndex = 3
        Me.LabelPDDE.Text = "PDDE"
        '
        'LabelValueTotalNF
        '
        Me.LabelValueTotalNF.AutoSize = True
        Me.LabelValueTotalNF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelValueTotalNF.Location = New System.Drawing.Point(519, 16)
        Me.LabelValueTotalNF.Name = "LabelValueTotalNF"
        Me.LabelValueTotalNF.Size = New System.Drawing.Size(119, 17)
        Me.LabelValueTotalNF.TabIndex = 4
        Me.LabelValueTotalNF.Text = "Valor Total da NF"
        '
        'TextBoxNameEmit
        '
        Me.TextBoxNameEmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxNameEmit.Location = New System.Drawing.Point(120, 13)
        Me.TextBoxNameEmit.Name = "TextBoxNameEmit"
        Me.TextBoxNameEmit.Size = New System.Drawing.Size(384, 23)
        Me.TextBoxNameEmit.TabIndex = 6
        '
        'TextBoxNameDest
        '
        Me.TextBoxNameDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxNameDest.Location = New System.Drawing.Point(120, 46)
        Me.TextBoxNameDest.Name = "TextBoxNameDest"
        Me.TextBoxNameDest.Size = New System.Drawing.Size(384, 23)
        Me.TextBoxNameDest.TabIndex = 7
        '
        'TextBoxPDDE
        '
        Me.TextBoxPDDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxPDDE.Location = New System.Drawing.Point(120, 84)
        Me.TextBoxPDDE.Name = "TextBoxPDDE"
        Me.TextBoxPDDE.Size = New System.Drawing.Size(384, 23)
        Me.TextBoxPDDE.TabIndex = 8
        '
        'TextBoxValueTotalNF
        '
        Me.TextBoxValueTotalNF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxValueTotalNF.Location = New System.Drawing.Point(690, 13)
        Me.TextBoxValueTotalNF.Name = "TextBoxValueTotalNF"
        Me.TextBoxValueTotalNF.ReadOnly = True
        Me.TextBoxValueTotalNF.Size = New System.Drawing.Size(92, 23)
        Me.TextBoxValueTotalNF.TabIndex = 9
        '
        'TextBoxValueTotalProducts
        '
        Me.TextBoxValueTotalProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxValueTotalProducts.Location = New System.Drawing.Point(690, 46)
        Me.TextBoxValueTotalProducts.Name = "TextBoxValueTotalProducts"
        Me.TextBoxValueTotalProducts.ReadOnly = True
        Me.TextBoxValueTotalProducts.Size = New System.Drawing.Size(92, 23)
        Me.TextBoxValueTotalProducts.TabIndex = 10
        '
        'ButtonAdvance
        '
        Me.ButtonAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAdvance.Location = New System.Drawing.Point(921, 491)
        Me.ButtonAdvance.Name = "ButtonAdvance"
        Me.ButtonAdvance.Size = New System.Drawing.Size(104, 51)
        Me.ButtonAdvance.TabIndex = 11
        Me.ButtonAdvance.Text = "Avançar"
        Me.ButtonAdvance.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonCancel.Location = New System.Drawing.Point(15, 491)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(104, 51)
        Me.ButtonCancel.TabIndex = 12
        Me.ButtonCancel.Text = "Cancelar"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(519, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Valor Total dos Produtos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(519, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Data do Orçamento"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Marli", "Adelino", "Decore", "GRT", "Marybook"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(827, 28)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(91, 79)
        Me.CheckedListBox1.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(690, 87)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(93, 20)
        Me.DateTimePicker1.TabIndex = 17
        Me.DateTimePicker1.Value = New Date(2023, 9, 18, 0, 0, 0, 0)
        '
        'CheckBoxPrint
        '
        Me.CheckBoxPrint.AutoSize = True
        Me.CheckBoxPrint.Checked = True
        Me.CheckBoxPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPrint.Location = New System.Drawing.Point(933, 28)
        Me.CheckBoxPrint.Name = "CheckBoxPrint"
        Me.CheckBoxPrint.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxPrint.TabIndex = 18
        Me.CheckBoxPrint.Text = "Imprimir?"
        Me.CheckBoxPrint.UseVisualStyleBackColor = True
        '
        'FormReviewNF
        '
        Me.AcceptButton = Me.ButtonAdvance
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(1037, 558)
        Me.Controls.Add(Me.CheckBoxPrint)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAdvance)
        Me.Controls.Add(Me.TextBoxValueTotalProducts)
        Me.Controls.Add(Me.TextBoxValueTotalNF)
        Me.Controls.Add(Me.TextBoxPDDE)
        Me.Controls.Add(Me.TextBoxNameDest)
        Me.Controls.Add(Me.TextBoxNameEmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelValueTotalNF)
        Me.Controls.Add(Me.LabelPDDE)
        Me.Controls.Add(Me.LabelNameDest)
        Me.Controls.Add(Me.LabelNameEmit)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "FormReviewNF"
        Me.Text = "Revisar NF"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelNameEmit As Label
    Friend WithEvents LabelNameDest As Label
    Friend WithEvents LabelPDDE As Label
    Friend WithEvents LabelValueTotalNF As Label
    Friend WithEvents TextBoxNameEmit As TextBox
    Friend WithEvents TextBoxNameDest As TextBox
    Friend WithEvents TextBoxPDDE As TextBox
    Friend WithEvents TextBoxValueTotalNF As TextBox
    Friend WithEvents TextBoxValueTotalProducts As TextBox
    Friend WithEvents ButtonAdvance As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents BindingSourceProduct As BindingSource
    Friend WithEvents SequenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValueUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValueTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBoxPrint As CheckBox
End Class
