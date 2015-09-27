'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       HW04 - Practice 02
'File:          FrmMain.vb
'Author:        Robert Palumbo
'Description:   This is the main user interface form for the 
'               Ch04Ex01 Visual Basic program. 
'               It is the first foray into separating user interface
'               and business logic into separate classes.
'
'Date:          09/22/2015
'                 - initial release
'
'Tier:          User Interace     
'
'Exceptions:         
'Exception-Handling: 
'Events:             
'Event-Handling:     
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

    'This object is used to hold the main form drive specs and to
    'perform drive calculations based on the specified data and user
    'options
    Private mAutomobile As New Automobile  'holds main form drive info


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

    'updateOdometer() is a procedure that is used to update the
    'odometer field on the display
    Public Sub updateOdometer(ByVal pMiles As Integer)

        txtOdometerGrpOdometerFrmMain.Text = pMiles.ToString

    End Sub 'updateOdometer(ByVal pMiles as Integer)

    'updateTrxLog() is a procedure that is used to update the
    'Transaction log with pertinent drive info base on user 
    'selection.
    Public Sub updateTrxLog(ByVal pTrxLog As String)

        txtTrxLogFrmMain.Text &= pTrxLog & vbCrLf

    End Sub 'updateTrxLog(ByVal pTrxLog As String)

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    '********** Private Non-Shared Behavioral Methods

    '_closeAppl() is used to simply close the application when
    'requested.
    Private Sub _closeAppl()

        'Notify the user application is closing
        MsgBox("Closing application...press OK to continue.",
               MsgBoxStyle.OkOnly)

        Me.Close()

    End Sub '_closeAppl()

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

        'Assign AcceptButton to the form based buttons so the 'Enter'
        'key will activate the exit functionality when on the main form. 
        Me.AcceptButton = btnExitFrmMain

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

    ' _btnDriveGrSpeedTimeFrmMain_Click() is the event procedure that gets called when the
    'user clicks on the 'Calc Speed' button or by using Alt-S hot key sequence.
    'It leverages Automobile to do the heavy work.
    Private Sub _btnDriveGrSpeedTimeFrmMain_Click(sender As Object, e As EventArgs) Handles btnDriveGrSpeedTimeFrmMain.Click

        If mAutomobile IsNot Nothing Then
            mAutomobile.drive(Integer.Parse(txtSpeedGrpSpeedTimeFrmMain.Text),
                              Decimal.Parse(txtTimeGrpSpeedTimeFrmMain.Text))
        End If

    End Sub ' _btnDriveGrSpeedTimeFrmMain_Click(sender As Object, e As EventArgs)

    '_btnCalcDistFrmMain_Click() is the event procedure that gets called when the
    'user clicks on the 'Calc Dist' button or by using Alt-D hot key sequence.
    'It leverages Automobile to do the heavy work.
    Private Sub _btnDriveGrpDistFrmMain_Click(sender As Object, e As EventArgs) Handles btnDriveGrpDistFrmMain.Click

        If mAutomobile IsNot Nothing Then
            mAutomobile.drive(Integer.Parse(txtDistGrpDistFrmMain.Text))
        End If

    End Sub '_btnCalcDistFrmMain_Click(sender As Object, e As EventArgs)

    Private Sub _txtDistGrpDistFrmMain_Enter(sender As Object, e As EventArgs) Handles txtDistGrpDistFrmMain.Enter

        txtDistGrpDistFrmMain.SelectAll()

    End Sub 'txtDistGrpDistFrmMain_Enter(sender As Object, e As EventArgs)

    Private Sub _txtSpeedGrpSpeedTimeFrmMain_Enter(sender As Object, e As EventArgs) Handles txtSpeedGrpSpeedTimeFrmMain.Enter

        txtSpeedGrpSpeedTimeFrmMain.SelectAll()

    End Sub '_txtSpeedGrpSpeedTimeFrmMain_Enter(sender As Object, e As EventArgs)

    Private Sub _txtTimeGrpSpeedTimeFrmMain_Enter(sender As Object, e As EventArgs) Handles txtTimeGrpSpeedTimeFrmMain.Enter

        txtTimeGrpSpeedTimeFrmMain.SelectAll()

    End Sub


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

    '_txtDriveDistFrmMain_Validated() is the input validation procedure for drive distance field.
    Private Sub _txtDriveDistFrmMain_Validated(sender As Object, e As EventArgs) Handles txtDistGrpDistFrmMain.Validated

        If Not IsNumeric(txtDistGrpDistFrmMain.Text) Then
            MsgBox("Distance to drive must be an integer value (e.g. 50) (miles)", MsgBoxStyle.OkOnly)
            txtDistGrpDistFrmMain.Text = "0"
            txtDistGrpDistFrmMain.SelectAll()
            txtDistGrpDistFrmMain.Focus()
        Else
            If Integer.Parse(txtDistGrpDistFrmMain.Text) < 0 Then
                MsgBox("Distance to drive cannot be negative", MsgBoxStyle.OkOnly)
                txtDistGrpDistFrmMain.Text = "0"
                txtDistGrpDistFrmMain.SelectAll()
                txtDistGrpDistFrmMain.Focus()
            End If
        End If

    End Sub '_txtDriveDistFrmMain_Validated(sender As Object, e As EventArgs) 


    '_txtDriveSpeed_Validated() is the input validation procedure for drive speed field.
    Private Sub _txtDriveSpeed_Validated(sender As Object, e As EventArgs) Handles txtSpeedGrpSpeedTimeFrmMain.Validated

        If Not IsNumeric(txtSpeedGrpSpeedTimeFrmMain.Text) Then
            MsgBox("Speed to drive must be an integer value (e.g 55) (mph)", MsgBoxStyle.OkOnly)
            txtSpeedGrpSpeedTimeFrmMain.Text = "0"
            txtSpeedGrpSpeedTimeFrmMain.SelectAll()
            txtSpeedGrpSpeedTimeFrmMain.Focus()
        Else
            If Integer.Parse(txtSpeedGrpSpeedTimeFrmMain.Text) < 0 Then
                MsgBox("Speed to drive cannot be negative", MsgBoxStyle.OkOnly)
                txtSpeedGrpSpeedTimeFrmMain.Text = "0"
                txtSpeedGrpSpeedTimeFrmMain.SelectAll()
                txtSpeedGrpSpeedTimeFrmMain.Focus()
            End If
        End If

    End Sub '_txtDriveSpeed_Validated(sender As Object, e As EventArgs)

    '_txtDriveSpeed_Validated() is the input validation procedure for drive time field.
    Private Sub _txtTimeGrpSpeedTimeFrmMain_Validated(sender As Object, e As EventArgs) Handles txtTimeGrpSpeedTimeFrmMain.Validated

        If Not IsNumeric(txtTimeGrpSpeedTimeFrmMain.Text) Then
            MsgBox("Time to drive must be a decimal value (e.g 1.5) (hrs)", MsgBoxStyle.OkOnly)
            txtTimeGrpSpeedTimeFrmMain.Text = "0.0"
            txtTimeGrpSpeedTimeFrmMain.SelectAll()
            txtTimeGrpSpeedTimeFrmMain.Focus()
        Else
            If Decimal.Parse(txtTimeGrpSpeedTimeFrmMain.Text) < 0.0 Then
                MsgBox("Time to drive cannot be negative", MsgBoxStyle.OkOnly)
                txtTimeGrpSpeedTimeFrmMain.Text = "0.0"
                txtTimeGrpSpeedTimeFrmMain.SelectAll()
                txtTimeGrpSpeedTimeFrmMain.Focus()
            End If
        End If

    End Sub

    Private Sub _txtTrxLogFrmMain_TextChanged(sender As Object, e As EventArgs) Handles txtTrxLogFrmMain.TextChanged

        txtTrxLogFrmMain.SelectionStart = txtTrxLogFrmMain.TextLength
        txtTrxLogFrmMain.ScrollToCaret()

    End Sub '_txtTrxLog_TextChanged(sender,e)

    Private Sub _grpSpeedTimeFrmMain_Enter(sender As Object, e As EventArgs) Handles grpSpeedTimeFrmMain.Enter

        'Assign AcceptButton to the form based buttons so the 'Enter'
        'key will activate the local Drive button by default 
        Me.AcceptButton = btnDriveGrSpeedTimeFrmMain

    End Sub

    Private Sub _grpSpeedTimeFrmMain_Leave(sender As Object, e As EventArgs) Handles grpSpeedTimeFrmMain.Leave

        'Assign AcceptButton to the form based buttons so the 'Enter'
        'key will activate the main form Exit buttong by default 
        Me.AcceptButton = btnExitFrmMain

    End Sub

    Private Sub _grpDistFrmMain_Enter(sender As Object, e As EventArgs) Handles grpDistFrmMain.Enter

        'Assign AcceptButton to the form based buttons so the 'Enter'
        'key will activate the local Drive button by default 
        Me.AcceptButton = btnDriveGrpDistFrmMain

    End Sub

    Private Sub _grpDistFrmMain_Leave(sender As Object, e As EventArgs) Handles grpDistFrmMain.Leave

        'Assign AcceptButton to the form based buttons so the 'Enter'
        'key will activate the main form Exit buttong by default 
        Me.AcceptButton = btnExitFrmMain

    End Sub

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