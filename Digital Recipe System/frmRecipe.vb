'Author: Erick Hadi
'Date: 11/07/2021
'Purpose: Displays the recipe that the user selected and allows them to delete and edit them.

Public Class frmRecipe
    'Whenever the form is opened by a user double clicking a recipe, display the recipe details
    Private Sub frmRecipe_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim recipe As MyRecipes = Array.Find(arrMyRecipes, Function(x) x.strRecipeTitle.Equals(strSelectedRecipe))
        lblRecipeName.Text = recipe.strRecipeTitle
        txtIngredients.Text = recipe.strIngredients
        txtMethod.Text = recipe.strMethod
    End Sub

    'When clicked, reveals various buttons which allows the user to edit and delete recipes in the program
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnChangeName.Visible = True
        btnDelete.Visible = True
        btnSave.Visible = True
        btnEdit.Enabled = False
        btnBack.Enabled = False
        'Allow the user to edit the text of the program
        txtIngredients.ReadOnly = False
        txtMethod.ReadOnly = False
    End Sub

    'Hides the form from the user when clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide() 'Hides the form
    End Sub

    'Uses an InputBox to allow the user to change the name of the recipe
    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click
        Dim strNewName As String = InputBox("Enter a new name for this recipe:")

        If strNewName <> Nothing Then 'Existence check
            If strNewName.Length >= 4 And strNewName.Length <= 30 Then
                Try 'Type check
                    Console.WriteLine(CInt(strNewName))
                    MsgBox("Please do not use numbers as recipe names")
                Catch ex As Exception 'When the new name has passed all of the data validation
                    'Change the name of the recipe
                    arrMyRecipes(intSelectedRecipeIndex).strRecipeTitle = strNewName
                End Try
            Else
                MsgBox("Please keep recipe names between 4 and 30 characters.")
            End If
        Else
            MsgBox("Please input a new name for this recipe.")
        End If

        lblRecipeName.Text = arrMyRecipes(intSelectedRecipeIndex).strRecipeTitle 'Display the recipe name
        strSelectedRecipe = arrMyRecipes(intSelectedRecipeIndex).strRecipeTitle 'Update the global variable accordingly
    End Sub

    'Deletes the current recipe from the file when clicked
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim confirm = MsgBox("Are you sure you want to delete this recipe?", vbQuestion + vbYesNo + vbDefaultButton2) 'Double check if the user wants to delete the recipe for usability

        If confirm = vbYes Then 'If the user confirms that they want to delete the recipe
            Dim intIndex As Integer = 0
            Dim arrDeleted(0) As MyRecipes 'A temporary array which will exclude the deleted item
            For Each recipe In arrMyRecipes
                If recipe.strRecipeTitle <> strSelectedRecipe Then 'Only add the recipe into the array if it has not been deleted
                    Try
                        arrDeleted(intIndex) = recipe
                        intIndex += 1
                    Catch ex As Exception
                        ReDim Preserve arrDeleted(arrDeleted.Length)
                        arrDeleted(intIndex) = recipe
                        intIndex += 1
                    End Try
                End If
            Next
            ReDim arrMyRecipes(arrDeleted.Length - 1)
            Array.Copy(arrDeleted, arrMyRecipes, arrDeleted.Length) 'Copy this edited array to the original array
            WriteFile() 'Write this new array to the file

            'Prepare the form for next use and close it (because the recipe has been deleted, there is nothing left to view)
            btnBack.Enabled = True
            btnEdit.Enabled = True
            btnChangeName.Visible = False
            btnDelete.Visible = False
            btnSave.Visible = False
            frmMain.lsbResults.Items.Clear() 'Clear the results listbox so that the deleted recipe is not displayed anymore
            Me.Hide()
        End If
    End Sub

    'Validates changes made to ingredients and method, then saves these to the file
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim strNewIngredients As String = txtIngredients.Text
        If strNewIngredients <> Nothing Then 'Existence check
            If strNewIngredients.Length <= 10000 Then
                Try 'Type check
                    Console.WriteLine(CInt(strNewIngredients))
                    MsgBox("Numbers are not valid inputs")
                Catch ex As Exception 'When the new name has passed all of the data validation
                    'Change the name of the recipe
                    arrMyRecipes(intSelectedRecipeIndex).strIngredients = strNewIngredients
                End Try
            Else
                MsgBox("Please keep recipe ingredients below 10000 characters.")
            End If
        Else
            MsgBox("Please input new ingredients for this recipe.")
        End If


        Dim strNewMethod As String = txtMethod.Text
        If strNewMethod <> Nothing Then 'Existence check
            If strNewMethod.Length <= 10000 Then
                Try 'Type check
                    Console.WriteLine(CInt(strNewMethod))
                    MsgBox("Numbers are not valid inputs")
                Catch ex As Exception 'When the new name has passed all of the data validation
                    'Change the name of the recipe
                    arrMyRecipes(intSelectedRecipeIndex).strMethod = strNewMethod
                End Try
            Else
                MsgBox("Please keep recipe ingredients below 10000 characters.") 'Notify user of why their data was invalid
            End If
        Else
            MsgBox("Please input new ingredients for this recipe.") 'Notify user of why their data was invalid
        End If

        WriteFile() 'Save these changes to the file
        frmMain.lsbResults.Items.Clear() 'Clears the search results so data is not outdated

        'Reset all of the buttons and textboxes back to normal for viewing purposes
        btnBack.Enabled = True
        btnEdit.Enabled = True
        btnChangeName.Visible = False
        btnDelete.Visible = False
        btnSave.Visible = False
        txtIngredients.ReadOnly = True
        txtMethod.ReadOnly = True
    End Sub
End Class