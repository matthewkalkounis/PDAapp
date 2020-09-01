Imports System.Data.SqlClient

Public Class Product

#Region "Private Variables"
    Private mvarProductID As Integer
    Private mvarProductName As String
    Private mvarProductPrice As Double
    Private mvarProductCategory As ProductCategory
    Private mvarProductDescription As String
#End Region
#Region "Public Properties"
    Public Property ProductID As Integer
        Get
            ProductID = mvarProductID
        End Get
        Set(value As Integer)
            mvarProductID = value
        End Set
    End Property
    Public Property ProductName As String
        Get
            ProductName = mvarProductName
        End Get
        Set(value As String)
            mvarProductName = value
        End Set
    End Property
    Public Property ProductPrice As Double
        Get
            ProductPrice = mvarProductPrice
        End Get
        Set(value As Double)
            mvarProductPrice = value
        End Set
    End Property
    Public Property ProductCategory As ProductCategory
        Get
            ProductCategory = mvarProductCategory
        End Get
        Set(value As ProductCategory)
            mvarProductCategory = value
        End Set
    End Property
    Public Property ProductDescription As String
        Get
            ProductDescription = mvarProductDescription
        End Get
        Set(value As String)
            mvarProductDescription = value
        End Set
    End Property
#End Region
#Region "Constructor"
    Public Sub New()
        mvarProductID = 0
        mvarProductName = ""
        mvarProductPrice = 0
        mvarProductCategory = New ProductCategory
        mvarProductDescription = ""
    End Sub
#End Region
#Region "Public Methods"
    Public Sub AddProduct()
        'Dim connect As String = String.Format()
        Dim sConnection As New SqlConnection("server=localhost);uid=postgres;pwd=asassjsjs;")
        Dim command As SqlCommand = sConnection.CreateCommand

        Try
            Dim Query As String = ""
            Dim parameter(4) As SqlParameter

            parameter(0).ParameterName = "@ProductID"
            parameter(0).SqlDbType = SqlDbType.Int
            parameter(0).Direction = ParameterDirection.Input
            parameter(0).Value = mvarProductID


            parameter(1).ParameterName = "@ProductName"
            parameter(1).SqlDbType = SqlDbType.NVarChar
            parameter(1).Direction = ParameterDirection.Input
            'parameter(1).Size = 50
            parameter(1).Value = mvarProductName

            parameter(2).ParameterName = "@ProductPrice"
            parameter(2).SqlDbType = SqlDbType.Decimal
            parameter(2).Direction = ParameterDirection.Input
            'parameter(2).Size = 50
            parameter(2).Value = mvarProductPrice

            parameter(3).ParameterName = "@ProductCategory"
            parameter(3).SqlDbType = SqlDbType.Int
            parameter(3).Direction = ParameterDirection.Input
            'parameter(3).Size = 50
            'parameter(3).Value = mvarProductCategory.ProductCategoryID

            parameter(4).ParameterName = "@ProductDescription"
            parameter(4).SqlDbType = SqlDbType.NVarChar
            parameter(4).Direction = ParameterDirection.Input
            'parameter(4).Size = 250
            parameter(4).Value = mvarProductDescription

            Query += vbCrLf + "SET IDENTITY INSERT ON" + Space(1) + "SET ARITHABORT ON"
            Query += vbCrLf + "INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductCategory, ProductDescription) values( @ProductID, @ProductName, @ProductPrice, @ProdutcCategory, @ProductDescription)"
            Query += vbCrLf + "SET IDENTITY INSERT OFF" + Space(1) + "SET ARITHABORT OFF"


            sConnection.Open()

            command.CommandText = Query

            command.Parameters.AddRange(parameter)

            Dim result As Integer = command.ExecuteNonQuery()

            If result <= 0 Then

            End If

        Catch ex As Exception

        Finally
            sConnection.Close()
            command.Dispose()
        End Try
    End Sub
#End Region

End Class
