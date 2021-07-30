
Public Class frmInput

    'When clicked, this button will add an extra field to the csv file
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim tag As String 'Identifies what tag the recipe should hold
        If rbDessert.Checked Then
            tag = "dessert"
        ElseIf rbDinner.Checked Then
            tag = "dinner"
        ElseIf rbIndo.Checked Then
            tag = "indo"
        ElseIf rbLunch.Checked Then
            tag = "lunch"
        Else
            tag = "nothing"
        End If

        'Validate if data has been inputted into each text box (existence check)
        If txtIngredients.Text <> "" And txtMethod.Text <> "" And txtRecipeName.Text <> "" Then 'If every textbox has been filled out
            If My.Computer.FileSystem.ReadAllText("recipes.xml") <> Nothing Then 'Make sure the file is not empty to avoid the program crashing
                ReadFile("recipes.xml") 'Read the file into the array for when the user wants to add more 
            End If

            'Add this new recipe to the array for it to be written
            If arrMyRecipes(0).strRecipeTitle <> Nothing Then 'If the array is not empty
                ReDim Preserve arrMyRecipes(arrMyRecipes.Length)
                arrMyRecipes(arrMyRecipes.Length - 1).strRecipeTitle = txtRecipeName.Text
                arrMyRecipes(arrMyRecipes.Length - 1).strIngredients = txtIngredients.Text
                arrMyRecipes(arrMyRecipes.Length - 1).strMethod = txtMethod.Text
                arrMyRecipes(arrMyRecipes.Length - 1).strTag = tag
            Else 'If the array is empty (there are no recipes in the file)
                arrMyRecipes(0).strRecipeTitle = txtRecipeName.Text
                arrMyRecipes(0).strIngredients = txtIngredients.Text
                arrMyRecipes(0).strMethod = txtMethod.Text
                arrMyRecipes(arrMyRecipes.Length - 1).strTag = tag
            End If

            WriteFile() 'Save this array to the file

            'Clear the input sections for the user to input more recipes
            txtIngredients.Clear()
            txtMethod.Clear()
            txtRecipeName.Clear()
            rbDessert.Checked = False
            rbDinner.Checked = False
            rbIndo.Checked = False
            rbLunch.Checked = False
        Else 'If one of the texboxes has not been filled out
            MsgBox("Please fill every field before adding a recipe.") 'Alert the user
        End If
    End Sub

    'Closes the form when the exit button is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMain.Focus() 'Focus on frmMain which the user is returning to
        Me.Hide()
    End Sub
End Class