Imports System.Xml

'Purpose: A module for public functions and procedures used throughout the entire solution
Module CommonCode

    'Saves the contents of recipes.xml into an array
    Public Sub ReadFile(ByVal file_name As String)
        If IO.File.Exists(file_name) Then
            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader(file_name)
            intIndex = 0
            While document.Read()
                Dim type = document.NodeType
                'if node type was element As each line is a single element in the array structure
                If (type = XmlNodeType.Element) Then
                    Try
                        'if the loop found a <Name> tag
                        If (document.Name = "RecipeTitle") Then
                            arrMyRecipes(intIndex).strRecipeTitle = document.ReadInnerXml.ToString()
                        End If
                        If (document.Name = "Ingredients") Then
                            arrMyRecipes(intIndex).strIngredients = document.ReadInnerXml.ToString()
                        End If
                        If (document.Name = "Method") Then
                            arrMyRecipes(intIndex).strMethod = document.ReadInnerXml.ToString()
                        End If
                        If (document.Name = "Tag") Then
                            arrMyRecipes(intIndex).strTag = document.ReadInnerXml.ToString()
                            intIndex += 1
                        End If
                    Catch ex As IndexOutOfRangeException
                        ReDim Preserve arrMyRecipes(arrMyRecipes.Length)
                        'if the loop found a <Name> tag
                        If (document.Name = "RecipeTitle") Then
                            arrMyRecipes(intIndex).strRecipeTitle = document.ReadInnerXml.ToString()
                        End If
                        If (document.Name = "Ingredients") Then
                            arrMyRecipes(intIndex).strIngredients = document.ReadInnerXml.ToString()
                        End If
                        If (document.Name = "Method") Then
                            arrMyRecipes(intIndex).strMethod = document.ReadInnerXml.ToString()
                        End If
                        If (document.Name = "Tag") Then
                            arrMyRecipes(intIndex).strTag = document.ReadInnerXml.ToString()
                            intIndex += 1
                        End If
                    End Try
                End If
            End While
            document.Close()
        End If
    End Sub

    'This procedure writes whatever is stored in arrMyRecipes into a csv file
    Public Sub WriteFile()
        ' updated xml file saved automatically
        ' no records added in this form so no resizing of file needed
        'declare our xmlwritersettings object
        Dim settings As New XmlWriterSettings()
        'lets tell to our xmlwritersettings that it must use indention for our xml
        settings.Indent = True
        'lets create the MyXML.xml document, the first parameter was the Path/filename of xml file this saves in into the same folder as the exe file
        ' the second parameter was our xml settings
        Dim WriteXML As XmlWriter = XmlWriter.Create("recipes.xml", settings)
        'This writes the document header, comment/description and the root element to the xml file
        ' Write the Xml declaration.
        WriteXML.WriteStartDocument() ' This adds <?xml version="1.0" encoding="utf-8"?> to the start of the file this is the encoding declaration
        ' Write a comment.
        WriteXML.WriteComment("XML Database.") ' Comment only occures once as part of the header for the file, useful in distinguishing what the contents are Not necessary
        ' Write the root element. Make sure none of the tags are duplicate, upper and lower case are different eg data is different From Data

        WriteXML.WriteStartElement("Data")
        ' The person nodes
        ' this loops through the array writing the structural components to the xml file
        For i = 0 To UBound(arrMyRecipes)
            WriteXML.WriteStartElement("Record") ' This is the title element of the xml file this identifies the equilivent of a record in the XML File
            WriteXML.WriteStartElement("RecipeTitle") ' This is the elements from within the structure
            WriteXML.WriteString(arrMyRecipes(i).strRecipeTitle)
            WriteXML.WriteEndElement()
            WriteXML.WriteStartElement("Ingredients") ' This is the elements from within the structure
            WriteXML.WriteString(arrMyRecipes(i).strIngredients)
            WriteXML.WriteEndElement()
            WriteXML.WriteStartElement("Method") ' This is the elements from within the structure
            WriteXML.WriteString(arrMyRecipes(i).strMethod)
            WriteXML.WriteEndElement()
            WriteXML.WriteStartElement("Tag") ' This is the elements from within the structure
            WriteXML.WriteString(arrMyRecipes(i).strTag)
            WriteXML.WriteEndElement()
            WriteXML.WriteEndElement() ' this ends this record
        Next
        WriteXML.WriteEndElement() ' This writes the end to the last element
        WriteXML.Close() 'Closes the XML File
        WriteXML.Dispose() 'Disposes any resources still being used so nothing is carried over for next time
    End Sub


    'Does a linear search of the recipes stored in the file
    'Then displays them in a listbox for the user to interact with
    Public Sub RecipeSearch(ByVal search_query As String, ByVal search_tag As String)
        Dim search_results As New List(Of MyRecipes) 'Declares a list that will store every search result. It is more effective than an array because the amount of matching recipes is unknown
        ReadFile("recipes.xml") 'Reads the file content before searching
        For Each recipe In arrMyRecipes
            Try
                If LCase(CStr(recipe.strRecipeTitle)).Contains(LCase(CStr(search_query))) = True Then 'If a recipe title contains the search query as a substring (converts everything to lowercase so that the user does not have to worry about case sensitivity)
                    If recipe.strTag = search_tag Or search_tag = "nothing" Then 'If this recipe matches the selected tag, or if the user has specified no tags
                        search_results.Add(recipe) 'Add the recipe to a list of search results
                    End If
                End If
            Catch ex As Exception
                Exit For 'Exits the loop because the file is empty
            End Try
        Next

        If search_results.Count <> 0 Then 'If there was at least one matching recipe
            For Each match In search_results
                frmMain.lsbResults.Items.Add(match.strRecipeTitle) 'Display each matching recipe in a list box
            Next
        Else
            MsgBox("No matching recipes were found.") 'Alert the user
        End If
    End Sub

    'Sorts arrMyRecipes alphabetically by the ASCII value of the first character in the recipe name using a quick sort algorithm
    Public Sub SortArray(ByVal intLowEnd As Integer, ByVal intHighEnd As Integer)
        'WIP
        If intLowEnd < intHighEnd Then
            'Figure out where to split the array (what index value)
            Dim split = PartitionArray(intLowEnd, intHighEnd)
            'Quick sort the lower end of the split array (recursion)
            SortArray(intLowEnd, split - 1)
            'Quick sort the lower end of the split array (recursion)
            SortArray(split + 1, intHighEnd)
        End If
    End Sub

    'A partition function required by the SortArray procedure.
    'Returns the low end after being incremented
    Public Function PartitionArray(ByVal intLowEnd As Integer, ByVal intHighEnd As Integer)
        Dim pivot = Asc(LCase(arrMyRecipes(intHighEnd).strRecipeTitle.Substring(0))) 'Set the pivot as the high end element of arrMyRecipes. Get the ASCII value of the first character of the recipe title.
        'Convert to lower case so that upper case letters are not ordered before lower case letters due to their ASCII values.

        For index As Integer = intLowEnd To intHighEnd
            If Asc(LCase(arrMyRecipes(index).strRecipeTitle.Substring(0))) < pivot Then
                If intLowEnd <> index Then
                    'Swap the elements at the lower and current index position
                    Dim swaplow = arrMyRecipes(intLowEnd)
                    Dim swapindex = arrMyRecipes(index)
                    arrMyRecipes(intLowEnd) = swapindex
                    arrMyRecipes(index) = swaplow
                End If
                intLowEnd += 1 'Increment the low end
            End If
        Next
        'Swap the elements at the high and low position
        Dim swap1 = arrMyRecipes(intLowEnd)
        Dim swap2 = arrMyRecipes(intHighEnd)
        arrMyRecipes(intLowEnd) = swap2
        arrMyRecipes(intHighEnd) = swap1

        Return intLowEnd 'Returns intLowEnd to be used by QuickSort again because of recursion
    End Function
End Module
