﻿'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj01 - Theme Park Managament System  
'File:          FrmMain.vb
'Author:        Robert Palumbo     
'Description:   This is the main user interface form for the
'               semester project - Part 1: User Interface
'
'Date:          09/17/2015
'                  - Initial creation
'                  - Code for the first phase of the course project (Proj01)
'               10/05/2015
'                   - Modifications to support the second phase of
'                   course project (Proj02)
'
'Tier:          User Interface     
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

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '_closeAppl() is used to simply close the application when
    'requested.
    Private Sub _closeAppl()

        Dim msg = "System shutting down...press OK to continue."
        Dim style = MsgBoxStyle.OkOnly

        'Notify the user application is closing
        MsgBox(msg, style)

        Me.Close()

    End Sub '_closeAppl()


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

    End Sub '_initializeToolTips()

    '_initializeBusinessLogic() is used to initialize the program business
    'data/logic to a known good starting state.
    Private Sub _initializeBusinessLogic()

        'Do Nothing for Now

    End Sub '_initializeBusinessLogic()

    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    Private Sub _initializeUserInterface()

        'Assign CancelButton to the form based buttons so the 'Esc'
        'key will activate the exit functionality when on the main form. 
        Me.CancelButton = btnExitFrmMain

        'Center the main form on the display
        Me.StartPosition = FormStartPosition.CenterScreen

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

    '_btnExitFrmMain_Click() is the event procedure that gets called when the
    'user clicks on the Exit button or by using Alt-E hot key sequence.
    'It is used to notify the user and formally terminate the program.
    Private Sub btnExitFrmMain_Click(sender As Object, e As EventArgs) Handles btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()

    End Sub '_btnExitFrmMain_Click(sender As Object, e As EventArgs)

    '_mnuFileExit() is the event procedure that gets called when the user selects
    'File->Exit from the main menu.
    Private Sub _mnuExitFileFrmMain_Click(sender As Object, e As EventArgs) Handles mnuExitFileFrmMain.Click

        'Program terminated from main menu selection
        _closeAppl()

    End Sub '_mnuExitFileFrmMain_Click(sender As Object, e As EventArgs) 

    '_btnTesttFrmMain_Click() is the event procedure that gets called when the user selects
    'File->Exit from the main menu.
    Private Sub _btnTesttFrmMain_Click(sender As Object, e As EventArgs)

        'Notify the user application is closing
        MsgBox("Reserved for future test scenarios", MsgBoxStyle.Exclamation)

    End Sub '_btnTesttFrmMain_Click(sender As Object, e As EventArgs)



    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    Private Sub _frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initalize tool tips for specific controls
        _initializeToolTips()

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()

    End Sub '_frmMain_Load(sender, e)

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