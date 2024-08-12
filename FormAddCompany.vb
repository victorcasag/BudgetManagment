Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports Npgsql

Public Class FormAddCompany
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try

            Dim con As NpgsqlConnection = DatabaseConnection.Instance.OpenConnection()

            SaveCompany(con, SaveBank(con), SaveAddress(con))

            DatabaseConnection.Instance.CloseConnection()

            MessageBox.Show("Dados inseridos com sucesso!")

        Catch ex As Exception
            MessageBox.Show("Erro ao inserir dados: " & ex.Message)
        End Try
    End Sub
    Private Function SaveAddress(ByVal con As NpgsqlConnection)
        Dim address As New Address() With {
            .City = TextBoxAddress.Text,
            .Number = TextBoxNumber.Text,
            .Street = TextBoxCity.Text
        }

        Dim addressService As New AddressService(con)
        Return addressService.InsertAddress(address)

    End Function

    Private Function SaveBank(ByVal con As NpgsqlConnection)

        Dim bank As New Bank() With {
            .Agency = TextBoxAgency.Text,
            .Name = TextBoxBank.Text,
            .CurrentAccount = TextBoxAccount.Text
        }

        Dim bankService As New BankService(con)
        Return bankService.InsertBank(bank)

    End Function

    Private Function SaveCompany(ByVal con As NpgsqlConnection, ByVal lastIdBank As Integer, ByVal lastIdAddress As Integer)

        Dim company As New Company() With {
            .Name = TextBoxName.Text,
            .Phone = MaskedTextBoxPhone.Text,
            .CNPJ = MaskedTextBoxCNPJ.Text.Replace(",", "."),
            .IdBank = lastIdBank,
            .IdAddress = lastIdAddress
        }

        Dim companyService As New CompanyService(con)
        Return companyService.InsertCompany(company)

    End Function

End Class