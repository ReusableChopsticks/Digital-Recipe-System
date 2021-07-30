Module GlobalVariables
    Public Structure MyRecipes
        Public strRecipeTitle As String
        Public strIngredients As String
        Public strMethod As String
        Public strTag As String
    End Structure

    Public intIndex As Integer = 0 'element index
    Public arrMyRecipes(0) As MyRecipes 'array to store entered information

    'variables that are needed across frmMain and frmRecipe
    Public strSelectedRecipe As String
    Public intSelectedRecipeIndex As Integer
End Module
