Imports System.Xml

'Author: Erick Hadi
'Date: 11/07/2021
'Purpose: This form can direct the user to other forms for functionality
'         The form lets the user search for and then select recipes by their title, then sorts it

Public Class frmMain
    'Opens a new form for data input
    Private Sub AddRecipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecipeToolStripMenuItem.Click
        frmInput.Show() 'Opens a separate form
    End Sub

    'Uses openfiledialogue to open a file on the user's system and adds the information in the file to recipes.xml
    Private Sub UploadFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadFileToolStripMenuItem.Click
        'Copy the current file contents to a temporary array so that it can be added onto the newly read data later
        ReadFile("recipes.xml")
        Dim arrCopy(arrMyRecipes.Length - 1) As MyRecipes
        Array.Copy(arrMyRecipes, arrCopy, arrMyRecipes.Length)

        ofdMain.ShowDialog() 'Let the user select a file
        Dim strFileName = ofdMain.FileName 'Store the file name that was selected

        Try
            ReDim arrMyRecipes(0) 'Clear the array so that the contents do not duplicate
            ReadFile(strFileName) 'Read the selected file into the array

            intIndex = arrMyRecipes.Count 'Resets intIndex for the new array
            For Each recipe In arrCopy 'Adds all of the original file data onto the newly read data in the array
                Try
                    arrMyRecipes(intIndex).strRecipeTitle = recipe.strRecipeTitle
                    arrMyRecipes(intIndex).strIngredients = recipe.strIngredients
                    arrMyRecipes(intIndex).strMethod = recipe.strMethod
                    arrMyRecipes(intIndex).strTag = recipe.strTag
                    intIndex += 1
                Catch ex As Exception
                    ReDim Preserve arrMyRecipes(arrMyRecipes.Length)
                    arrMyRecipes(intIndex).strRecipeTitle = recipe.strRecipeTitle
                    arrMyRecipes(intIndex).strIngredients = recipe.strIngredients
                    arrMyRecipes(intIndex).strMethod = recipe.strMethod
                    arrMyRecipes(intIndex).strTag = recipe.strTag
                    intIndex += 1
                End Try
            Next
            WriteFile() 'Writes the contents of the complete array into the file
        Catch ex As Exception
            MsgBox("The file is in an invalid format, or the file has an incorrect amount of records or fields. Please fix these issues and try again") 'Notify the user that the file was not compatible with the program
        End Try


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lsbResults.Items.Clear() 'Clears the listbox to make way for new search results

        'Validate if the user is searching for a string of characters
        'If the text can be converted to an integer, then it is a number and should not be searched
        'Otherwise, let the user search
        Try
            Dim check = CInt(txtSearch.Text)
            MsgBox("Please input a word or character into the search bar instead of a number.")
        Catch ex As Exception
            Dim title_search As String = txtSearch.Text 'Stores the string that the user wants to search with
            Dim tag As String 'Used by the search function to determine if a recipe matches the tags selected when the user searches

            'Records the tag chosen by the user to be used in the search function
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

            'The RecipeSearch function takes what the user typed in (Str) and what tags the users checked (Str) as parameters
            RecipeSearch(title_search, tag) 'Searches for recipes, then displays them in a listbox
        End Try
    End Sub

    'Opens a new form when the user selects a recipe shown from the listbox
    Private Sub lsbResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbResults.MouseDoubleClick
        strSelectedRecipe = lsbResults.SelectedItem 'Records which recipe was opened
        intSelectedRecipeIndex = lsbResults.SelectedIndex 'Records the index of the recipe opened in the array
        frmRecipe.Show()
        frmRecipe.Activate() 'Opens and activates frmRecipe
    End Sub

    'Clears elements for ease of use and as a way to reset the radio buttons
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rbDessert.Checked = False
        rbDinner.Checked = False
        rbIndo.Checked = False
        rbLunch.Checked = False
        lsbResults.Items.Clear()
        txtSearch.Clear()
    End Sub

    'Ends the program when clicked
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    'Making sure that the program fully closes when the form is closed
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub

    'Brings a message box which outlines the functionalities of the program
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("This is the main page for the program. You can search for recipes by their name by typing into the search bar. Searches are not case sensitive. Alongside this, you can search for recipes by their tags by clicking one of the options below the search bar. Use the clear button to reset the search bar and buttons. Search by clicking the magnifying glass" + vbNewLine + vbNewLine + "To list every recipe in the program, search without entering anything into the search bar. Recipes are automatically sorted by alphabetical order." + vbNewLine + vbNewLine + "To view a recipe, double click on the recipe inside the search result box. This will allow you to read, edit and delete indiviual recipes.")
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        ReadFile("recipes.xml") 'Reads the file and loads the array
        SortArray(0, arrMyRecipes.Length - 1) 'Does a quick sort of each element in arrMyRecipes by alphabetical order (kinda), done by comparing ASCII values of the first character of the recipe name
        lsbResults.Items.Clear() 'Clears the listbox to allow for the sorted array to be displayed
        'Displays sorted array in the results listbox
        For Each recipe In arrMyRecipes
            lsbResults.Items.Add(recipe.strRecipeTitle)
        Next
    End Sub
End Class