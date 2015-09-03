'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:   Ch02Ex02 (practice program)
'File:      FrmMain.vb
'Author:    Robert Palumbo         
'Description:   This is the main user interface form for the 
'               Ch02Ex02 practice program. It allows the user
'               to input information about a business!
'
'Date:      09/02/2015 
'               - Initial creation
'
'Tier:      User Interface       
'Exceptions:           N/A
'Exception-Handling:   N/A
'Events:               N/A
'Event-Handling:       N/A
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class FrmMain

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    'No Get/Set Methods are currently defined.

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    'No Behavioral Methods are currently defined.

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    '********** Private Non-Shared Behavioral Methods


    '_initializeToolTips to assist the user
    Private Sub _initializeToolTips()
        'Create a tooltip object shared for each control
        Dim toolTip As New ToolTip()

        'Configure the toolTip object with appropriate delays.
        toolTip.AutoPopDelay = 5000
        toolTip.InitialDelay = 1000
        toolTip.ReshowDelay = 500
        toolTip.ShowAlways = True

        'Create a tooltip for each control on the form
        toolTip.SetToolTip(Me.txtOwnerName, "Please enter your full name")
        toolTip.SetToolTip(Me.grbBizType, "Please select type of business")
        toolTip.SetToolTip(Me.grbBizCharacteristics, "Please select business characteristics")
        toolTip.SetToolTip(Me.picBizLogo, "Company logo")
        toolTip.SetToolTip(Me.btnAccept, "Click on button to Accept input")
        toolTip.SetToolTip(Me.btnExit, "Click on button to Exit the program")

    End Sub '_initializeToolTips()

    '_initializeBusinessLogic() is used to initialize the program business
    'data/logic to a known good starting state.
    Private Sub _initializeBusinessLogic()
        'Do Nothing For Now
    End Sub '_initializeBusinessLogic()

    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    Private Sub _initializeUserInterface()
        'Do Nothing for Now
    End Sub 'initializeUserInterface()


#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

    'No Event Procedures are currently defined.
    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    Private Sub _frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Assign Accept/CancelButtons to the form based buttons so the 'Enter'
        'key will activate either buttong if the user tabs to one of them
        Me.AcceptButton = btnAccept
        Me.CancelButton = btnExit

        ''Center the main form on the display
        'Me.StartPosition = FormStartPosition.CenterScreen

        'Initalize tool tips for specific controls
        _initializeToolTips()

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()

    End Sub '_frmMain_Load(sender, e)

    'btnExit_Click() is the event procedure that gets called when the
    'user clicks on the Exit button or by using Alt-E hot key sequence.
    'It is used to notify the user and formally terminate the program.
    Private Sub _btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim msg = "Program exiting...press OK to continue."
        Dim style = MsgBoxStyle.OkOnly

        'Notify the user application is closing
        MsgBox(msg, style)

        'Terminate the program
        Me.Close()

    End Sub '_btnExit_Click(sender, e)

    'btnAccept_Click() is the event procedure that gets called when the
    'user clicks on the Accept button or by using Alt-A hot key sequence.
    'It is used to notify the user and formally terminate the program.
    Private Sub _btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        Dim msg = "Input Accepted...press OK to continue."
        Dim style = MsgBoxStyle.OkOnly

        'Notify the user application is closing
        MsgBox(msg, style)

    End Sub '_btnAccept_Click(sender, e)

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'FrmMain
