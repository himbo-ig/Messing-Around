Public Class Form1
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click ' Calculate basic pay by entering hours and pay rate.
        ' Declaring all variables
        Dim Hours As Integer
        Dim Rate As Single
        Dim Total As Single

        ' Grabbing the user's input from text boxes and assigning them to the corresponding variables
        Hours = Val(txthours.Text)
        Rate = Val(txtrate.Text)

        ' Calculate the user's pay
        Total = Hours * Rate

        ' Show the user their pay
        lbltotal.Text = "£" & Total
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click ' Easily apply a 20% discount to a given price.
        ' Declaring all variables
        Dim Price As Single
        Dim Discount As Boolean
        Dim FinalPrice As Single

        ' Getting the user's input from the text box and assigning it to the correct variable
        Price = Val(txtprice.Text)

        ' Setting the discount status, depending on user preference
        If CheckBox1.Checked Then
            Discount = True
        Else
            Discount = False
        End If

        ' Calculate the final discounted(or not discounted) price and assigning it to the variable
        If Discount = True Then
            FinalPrice = Price * 0.8
        Else
            FinalPrice = Price
        End If

        ' Display the final price to the user
        lblfinalprice.Text = "£" & FinalPrice
    End Sub

    Private Sub btnfigureout_Click(sender As Object, e As EventArgs) Handles btnfigureout.Click ' Calculate the area of a triangle with minimal effort.
        ' Declaring all variables
        Dim Base As Single
        Dim Height As Single
        Dim Area As Single

        ' Taking the input from the text boxes and assigning them to the correct variables
        Base = Val(txtbase.Text)
        Height = Val(txtheight.Text)

        ' Calculate the area of the triangle
        Area = 0.5 * Base * Height

        ' Output the area to the user with the default units
        lblarea.Text = Area & "cm²"
    End Sub

    Private Sub btnbegin_Click(sender As Object, e As EventArgs) Handles btnbegin.Click ' Game where you have to guess the correct random num from 0-20
        ' Declaring all variables
        Dim UserGuess As Integer
        Dim RandomNum As Integer

        ' Get the user input from the text boxes and assigning them to the correct variables
        UserGuess = Val(txtguess.Text)

        ' Assign a random number to the RandomNum variable
        RandomNum = Int((21 * Rnd()) + 0)

        ' Figure out if the user's guess is correct, and giving them the appropriate response
        If UserGuess = RandomNum Then
            lblanswer.Text = "Correct! The random number was " & RandomNum
        Else
            lblanswer.Text = "Sorry, the random number was " & RandomNum & ". Better luck next time!"
        End If
    End Sub
End Class
