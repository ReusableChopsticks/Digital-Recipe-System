'Purpose: this module stores global structures and variables which are used across multiple forms

Module GlobalVariables
    'A record that stores all the necessary information the user will input about a recipe into the program
    Public Structure MyRecipes
        Public strRecipeTitle As String
        Public strIngredients As String
        Public strMethod As String
        Public strTag As String
    End Structure

    Public intIndex As Integer = 0 'Element index used to keep track of the current index of arrMyRecipes
    Public arrMyRecipes(0) As MyRecipes 'Array to store entered recipes

    'Variables that are needed across frmMain and frmRecipe
    Public strSelectedRecipe As String
    Public intSelectedRecipeIndex As Integer
End Module
