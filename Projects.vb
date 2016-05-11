Imports Microsoft.VisualBasic

Public Class Project
    'This Class will build the basic componets of Daily, Weekly or Monthly Projects that I wish to do around the house
    Dim daily As String
    Dim weekly As String
    Dim monthly As String
    Dim budget As Integer
    'Vars to cover what will be done around the house
    'trying to cover the room as well as the number of projects per room in the house and the total cost of the projects.
    Dim livingRoom As String
    Dim livingRmProjects As Integer
    Dim livingRmCost As Decimal
    Dim kitchen As String
    Dim kitchenRmProjects As Integer
    Dim kitchenRmCost As Decimal
    Dim masterBed As String
    Dim masterBedRmProjects As Integer
    Dim masterBedRmCost As Decimal
    Dim boysRoom As String
    Dim boysRmProjects As Integer
    Dim boysRmCost As Decimal
    Dim bonusRoom As String
    Dim bonusRmProjects As Integer
    Dim bonusRmCost As Decimal
    Dim outside As String
    Dim outsideProjects As Integer
    Dim outsideCost As Decimal
    'Wanting to call this class and the functions of this class from my main form.
    'May have to create a seperate form for each room of the house.



    Sub Main()
        'Create a list of daily Chores
        Dim chores = GetChores()
        'Display the chores in the List
        DisplayList(chores)
        'need to add code to do something with this list
    End Sub
    'creating a list of Functions that I am going to learn how to do in VB that I want to use on my form
    'just a first run of things that I am thinking about on how to use this application around the house.

    Function addProject(x As String, y As Integer)

    End Function

    Function AddCost()

    End Function
    Function FinishedProject()

    End Function
    Function RemoveProject()

    End Function

End Class
