Option Strict On
Public Class Hotel
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextDate.Text = Now.ToString("D")
        TextTime.Text = Now.ToString("T")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        TextFood.Clear()
        TextName.Clear()
        TextAddrs.Clear()
        TextProof.Clear()
        TextcPhone.Clear()
        TextProof.Clear()
        TextTax.Clear()
        TextRoomno.Clear()
        TextRates.Clear()
        TextRoomcharges.Clear()
        TextAdd.Clear()
        TextTotal.Clear()
        TextSub.Clear()
        TextNights.Clear()
        TextFeed.Clear()
        TextMis.Clear()
        TextPhone.Clear()
        TextService.Clear()
        TextName.Focus()
        TextFeed.Clear()


    End Sub

    Private Sub ButTotal_Click(sender As Object, e As EventArgs) Handles ButTotal.Click
        Dim introom As Integer = 0
        Dim intmem As Integer = 0
        Dim deccphone As Decimal = 0
        Dim intNights As Integer = 0
        Dim decRoomcharges As Decimal = 0
        Dim decService As Decimal = 0
        Dim decPhone As Decimal = 0
        Dim decMis As Decimal = 0
        Dim decSub As Decimal = 0
        Dim decAdd As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim decRates As Decimal = 0
        Dim decTax As Decimal = 10
        Dim decFood As Decimal = 0

        Try
            intNights = CInt(TextNights.Text)
            decRoomcharges = CDec(TextRoomcharges.Text)
            decService = CDec(TextService.Text)
            decPhone = CDec(TextPhone.Text)
            decMis = CDec(TextMis.Text)
            decRates = CDec(TextRates.Text)
            decFood = CDec(TextFeed.Text)

        Catch ex As Exception
            TextNights.SelectAll()
            TextNights.Focus()
        End Try


        decRoomcharges = intNights * decRates
        decAdd = decService + decMis + decPhone + decFood
        decSub = decAdd + decRoomcharges
        decTax = decSub + decTax
        decTotal = decTotal + decTax

        'storing 

        TextRoomcharges.Text = decRoomcharges.ToString("C")
        TextAdd.Text = decAdd.ToString("C")
        TextSub.Text = decSub.ToString("C")
        TextTax.Text = decTax.ToString("C")
        TextTotal.Text = decTotal.ToString("C")

    End Sub

    Private Sub Hotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.Cust' table. You can move, or remove it, as needed.

        Me.CustTableAdapter.Fill(Me.CustomerDataSet.Cust)

       
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click


        CustBindingSource.AddNew()
       

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client As New ServiceReference.ServiceSoapClient("ServiceSoap")
        CustBindingSource.EndEdit()
        MessageBox.Show("Data added !!")

        CustTableAdapter.Update(CustomerDataSet.Cust)

       

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim client As New ServiceReference.ServiceSoapClient("ServiceSoap")
        CustBindingSource.RemoveCurrent()
        MessageBox.Show("Data Removed.")
        

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim client As New ServiceReference.ServiceSoapClient("ServiceSoap")
        CustTableAdapter.Update(CustomerDataSet.Cust)
       
    End Sub
End Class
