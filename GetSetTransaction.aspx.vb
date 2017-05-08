Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Partial Class GetSetTransaction
    Inherits System.Web.UI.Page
    Public strcon As String
    Public _olecon As OleDbConnection = Nothing
    Public _olecom As OleDbCommand = Nothing
    Public _oledbadp As OleDbDataAdapter = Nothing
    Public _dset As DataSet = Nothing
    Public _oledbreader As OleDbDataReader
    Public _strquery As String = Nothing
    Public _strcon As String = Nothing
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        _strcon = Convert.ToString(ConfigurationManager.ConnectionStrings("TechConWV").ConnectionString)
        _olecon = New OleDbConnection(_strcon)
        _dset = New DataSet
        If Not IsPostBack Then

            drpLocation.Items.Add("West Virginia")
            drpLocation.Items.Add("Tucson")
            drpLocation.Items.Add("Macon")


            ' _olecom = New OleDbCommand

        End If

    End Sub
    Protected Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click
        Try
            ' _olecon = New OleDbConnection(_strcon)
            _olecon.Open()
            ' _dset = New DataSet
            showTransactionStatus(Trim(txtEmployeeNum.Text), Trim(txtToolNum.Text))
            lblDisplayStatus.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            _olecon.Close()
            _olecom = Nothing
            _olecon = Nothing
        End Try

    End Sub

    Private Sub showTransactionStatus(ByVal EmpNumber As String, ByVal ToolNumber As String)

        '_strquery = "select ID,EmpNum as Emp Num,EmpName as Emp Name,ToolNum as Tool Num,Trans_Status as Transaction Status,Job as Job,Oper_Num as Operation Num from ToolTransactionStatus where EmpNum = '" & EmpNumber & "' and ToolNum = '" & ToolNumber & "'"
        _strquery = "select ID,EmpNum,EmpName,ToolNum,Trans_Status,Job,Oper_Num from ToolTransactionStatus where EmpNum = '" & EmpNumber & "' and ToolNum = '" & ToolNumber & "'"
        _dset.Clear()
        _olecom = New OleDbCommand(_strquery, _olecon)
        _oledbadp = New OleDbDataAdapter(_olecom)
        _oledbadp.Fill(_dset)
        DGViewTransaction.DataSource = _dset
        DGViewTransaction.DataMember = Convert.ToString(_dset.Tables(0))
        DGViewTransaction.DataBind()
    End Sub
    Protected Sub drpLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpLocation.SelectedIndexChanged
        If drpLocation.SelectedItem.ToString = "West Virginia" Then
            _strcon = Convert.ToString(ConfigurationManager.ConnectionStrings("TechConWV").ConnectionString)
        ElseIf drpLocation.SelectedItem.ToString = "Tucson" Then
            _strcon = Convert.ToString(ConfigurationManager.ConnectionStrings("TechConTUC").ConnectionString)
        Else
            _strcon = Convert.ToString(ConfigurationManager.ConnectionStrings("TechConMAC").ConnectionString)
        End If
    End Sub
    Protected Sub btnReleaseTool_Click(sender As Object, e As EventArgs) Handles btnReleaseTool.Click
        Try
            If Convert.ToString(DGViewTransaction.Rows(0).Cells(4).Text) = "Returned" Then
                lblDisplayStatus.Text = "Tool  " & txtToolNum.Text & " is already released from employee " & txtEmployeeNum.Text & "."
                Return
            End If
            _olecon = New OleDbConnection(_strcon)
            _olecon.Open()
            _strquery = "Update ToolTransactionStatus set Trans_Status='Returned' where EmpNum = '" & Trim(txtEmployeeNum.Text) & "' and ToolNum = '" & Trim(txtToolNum.Text) & "' "
            _olecom = New OleDbCommand(_strquery, _olecon)
                _olecom.ExecuteNonQuery()
            showTransactionStatus(Trim(txtEmployeeNum.Text), Trim(txtToolNum.Text))
            lblDisplayStatus.Text = "Tool  " & txtToolNum.Text & " is now released from employee " & txtEmployeeNum.Text & "."
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            '_olecon.Close()
            _olecom = Nothing
            _olecon = Nothing

        End Try
    End Sub
End Class
