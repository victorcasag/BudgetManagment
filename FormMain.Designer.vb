<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSelectFile = New System.Windows.Forms.Button()
        Me.ButtonManual = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçõesToolStripMenuItem, Me.RelatoriosToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(605, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarEmpresaToolStripMenuItem})
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'AdicionarEmpresaToolStripMenuItem
        '
        Me.AdicionarEmpresaToolStripMenuItem.Name = "AdicionarEmpresaToolStripMenuItem"
        Me.AdicionarEmpresaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdicionarEmpresaToolStripMenuItem.Text = "Adicionar Empresa"
        '
        'RelatoriosToolStripMenuItem
        '
        Me.RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem"
        Me.RelatoriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatoriosToolStripMenuItem.Text = "Relatorios"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentaçãoToolStripMenuItem, Me.SuporteToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'DocumentaçãoToolStripMenuItem
        '
        Me.DocumentaçãoToolStripMenuItem.Name = "DocumentaçãoToolStripMenuItem"
        Me.DocumentaçãoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DocumentaçãoToolStripMenuItem.Text = "Documentação"
        '
        'SuporteToolStripMenuItem
        '
        Me.SuporteToolStripMenuItem.Name = "SuporteToolStripMenuItem"
        Me.SuporteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SuporteToolStripMenuItem.Text = "Suporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Arraste o Arquivo Aqui!"
        '
        'ButtonSelectFile
        '
        Me.ButtonSelectFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonSelectFile.Location = New System.Drawing.Point(422, 120)
        Me.ButtonSelectFile.Name = "ButtonSelectFile"
        Me.ButtonSelectFile.Size = New System.Drawing.Size(171, 38)
        Me.ButtonSelectFile.TabIndex = 2
        Me.ButtonSelectFile.Text = "Selecionar o arquivo"
        Me.ButtonSelectFile.UseVisualStyleBackColor = True
        '
        'ButtonManual
        '
        Me.ButtonManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonManual.Location = New System.Drawing.Point(12, 120)
        Me.ButtonManual.Name = "ButtonManual"
        Me.ButtonManual.Size = New System.Drawing.Size(171, 38)
        Me.ButtonManual.TabIndex = 3
        Me.ButtonManual.Text = "Manual"
        Me.ButtonManual.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AcceptButton = Me.ButtonSelectFile
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(605, 170)
        Me.Controls.Add(Me.ButtonManual)
        Me.Controls.Add(Me.ButtonSelectFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSelectFile As Button
    Friend WithEvents RelatoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonManual As Button
End Class
