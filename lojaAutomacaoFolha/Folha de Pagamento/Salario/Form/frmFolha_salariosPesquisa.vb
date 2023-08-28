Imports MySql.Data.MySqlClient
Public Class frmFolha_salariosPesquisa
    Private Sub frmFolha_salariosPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String
        query = "Select "
        query += "folha_salario_base_Setor as setor"
        query += ",setor.folha_setor_descricao"
        query += ",folha_salario_base_Cargo as cargo"
        query += ",cargo.folha_cargo_descricao"
        query += ",folha_salario_base_minimo as Sal_Minimo"
        query += ",folha_salario_base_media as Sal_Medio"
        query += ", folha_salario_base_Maximo as Sal_Maximo"
        query += " from "
        query += "  comercio.folha_salario_base SL"
        query += ",comercio.folha_Setor 		Setor"
        query += ",comercio.folha_Cargo        Cargo"
        query += " where "
        query += "  SL.folha_salario_base_Setor = Setor.folha_setor_codigo"
        query += "  And "
        query += "  SL.folha_salario_base_Setor = Cargo.folha_cargo_setor "
        query += "  And "
        query += "  SL.folha_salario_base_Cargo = Cargo.folha_cargo_Codigo "
        query += "  order by "
        query += "  folha_salario_base_Setor"
        query += " ,folha_salario_base_Cargo"

        Dim CMD As New MySqlCommand(query, Conn)
        Dim DTReader As MySqlDataReader
        If OpenDB() Then
            Try
                DTReader = CMD.ExecuteReader
                ListView1.Items.Clear()

                While DTReader.Read()
                    With ListView1
                        .Items.Add(DTReader.GetValue(0))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(1))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(2))
                        .Items(.Items.Count - 1).SubItems.Add(DTReader.GetValue(3))
                        .Items(.Items.Count - 1).SubItems.Add(MoneyLatino(DTReader.GetValue(4)))
                        .Items(.Items.Count - 1).SubItems.Add(MoneyLatino(DTReader.GetValue(5)))
                        .Items(.Items.Count - 1).SubItems.Add(MoneyLatino(DTReader.GetValue(6)))
                    End With

                End While


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conn.Close()

        End If

    End Sub
End Class