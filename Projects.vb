Imports Microsoft.VisualBasic

Public Class Project
    'This Class will build the basic componets of Daily, Weekly or Monthly Projects that I wish to do around the house
    Dim daily As String
    Dim weekly As String
    Dim monthly As String
    Dim budget As Integer




    Sub Main()
        'Create a list of daily Chores
        Dim chores = GetChores()
        'Display the chores in the List
        DisplayList(chores)
        'need to add code to do something with this list
    End Sub

    


End Class
