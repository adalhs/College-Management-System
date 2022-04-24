Module GlobalVariables
    'This variable will be used by different forms to send a code to the FormCustomMsgBox, so that if the user clicks the Yes button,
    'confirming the information to be entered/altered, FormCustomMsgBox can send the user back to the form he came from
    Public CustomMsgBoxCode As String

    'This will be used by Form Login to send a code to which buttons on the Menu are visible depending on the user,
    'as well as change the label so it says Admissions Portal, Student Portal, etc
    Public MenuCode As String
End Module
