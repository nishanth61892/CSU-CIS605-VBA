'Copyright (c) 2009-2015 Dan Turk

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

    'Reference object for a theme park
    Private mThemePark As ThemePark


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
    Public Property _theThemePark() As ThemePark
        Get
            Return mThemePark
        End Get
        Set(pValue As ThemePark)
            mThemePark = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    'writeTransLog() procedure used to write a log message to 
    'the transaction log.
    Public Sub writeTransLog(ByVal plogMsg As String)
        'call the worker procedure to do the work
        _writeTransLog(plogMsg)
    End Sub

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

    '_writeTransLog() procedure does all the work to write a 
    'message to the transaction log.hat write the specified string to 
    'the transaction log.
    Private Sub _writeTransLog(ByVal pLogMsg As String)
        txtTransLogTabTransLogTbcMainFrmMain.Text &= _
            DateAndTime.DateString & ":" & DateAndTime.TimeString & "::"

        txtTransLogTabTransLogTbcMainFrmMain.Text &= pLogMsg & vbCrLf
    End Sub


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

        'Create a theme park instance
        _theThemePark = New ThemePark("Palumbo's Party Park")

        _writeTransLog("<CREATED>: " & _theThemePark.ToString())

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

    'btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Customer tab. It validates and then
    'submits the data to create a new customer.
    Private Sub btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnSubmitGrpCustInfoTabCustTbcMainFrmMain.Click
        Dim newCust As Customer
        Dim custId As String
        Dim custName As String

        custId = txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text
        custName = txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text

        'Validate the id and name field to make sure they contain data
        If String.IsNullOrEmpty(custId) Then
            MsgBox("Please enter a unqiue Customer ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.SelectAll()
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
        ElseIf String.IsNullOrEmpty(custName) Then
            MsgBox("Please enter a valid Customer Name (ex: Doe, John)", MsgBoxStyle.OkOnly)
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.SelectAll()
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.Focus()
        Else
            'Create a new Customer
            newCust = _theThemePark.createCustomer(
                            custId,
                            custName
                            )

            writeTransLog("<CREATED>: " & newCust.ToString())

            MsgBox("Customer has been successfully added to the system" & vbCrLf _
                   & "--> Id: " & custId & vbCrLf _
                   & "--> Name: " & custName & vbCrLf,
                   MsgBoxStyle.OkOnly
                   )

            'Reset the fields and focus to allow for another feature to be added
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text = ""
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text = ""
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
        End If

    End Sub 'btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(sender As Object, e As EventArgs)

    'btnSubmitGrpAddFeatTabFeatTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Feature tab. It validates and then
    'submits the data to create a new feature.
    Private Sub btnSubmitGrpAddFeatTabFeatTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnSubmitGrpAddFeatTabFeatTbcMainFrmMain.Click

        Dim newFeat As Feature = Nothing
        Dim decAdultPrice As Decimal
        Dim decChildPrice As Decimal

        'Used as shortcut names to access the data
        Dim featId As String = txtFeatIdAddFeatTabFeatTbcMainFrmMain.Text
        Dim featName As String = txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Text
        Dim unitOfMeas As String = txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Text
        Dim adultPrice As String = txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text
        Dim childPrice As String = txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text

        'Validate all the fields
        If String.IsNullOrEmpty(featId) Then
            MsgBox("Please enter a unique Feature ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
            Return
        End If

        If String.IsNullOrEmpty(featName) Then
            MsgBox("Please enter a valid Feature Name (ex: Park Pass)", MsgBoxStyle.OkOnly)
            txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Return
        End If

        If String.IsNullOrEmpty(unitOfMeas) Then
            MsgBox("Please enter a specific Unit of Measure (ex: Day)", MsgBoxStyle.OkOnly)
            txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Return
        End If

        'These must be converted to decimal values
        If Not IsNumeric(adultPrice) Then
            MsgBox("Please enter a numeric Adult price (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Return
        End If

        decAdultPrice = Decimal.Parse(adultPrice)
        If decAdultPrice <= 0 Then
            MsgBox("Adult price must be greater than 0.0 (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Return
        End If

        'These must be converted to decimal values
        If Not IsNumeric(childPrice) Then
            MsgBox("Please enter a numeric Child price (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Return
        End If

        decChildPrice = Decimal.Parse(childPrice)
        If decChildPrice <= 0 Then
            MsgBox("Child price must be greater than 0.0 (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = "0"
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Return
        End If

        'Create a new Feature
        newFeat = _theThemePark.createFeature(featId, _
                                              featName, _
                                              unitOfMeas, _
                                              decAdultPrice, _
                                              decChildPrice
                                              )

        writeTransLog("<CREATED>: " & newFeat.ToString())

        MsgBox("Feature has been successfully added to the system" & vbCrLf _
               & "--> Id: " & featId & vbCrLf _
               & "--> Name: " & featName & vbCrLf _
               & "--> Unit Measure: " & unitOfMeas & vbCrLf _
               & "--> Adult Price: " & adultPrice & vbCrLf _
               & "--> Child Price: " & childPrice & vbCrLf,
               MsgBoxStyle.OkOnly
               )

        'Reset the fields and focus to allow for another feature to be added
        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()

    End Sub 'btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click()

    'btnClearTabTransLogTbcMainFrmMain_Click() is the event procedure that gets called when the user
    'clicks on the Clear button from the Tranaaction log tab.  It clears the log.
    Private Sub btnClearTabTransLogTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles btnClearTabTransLogTbcMainFrmMain.Click
        'Reset the transactio log
        txtTransLogTabTransLogTbcMainFrmMain.Text = ""
    End Sub ' btnClearTabTransLogTbcMainFrmMain_Click(sender As Object, e As EventArgs)


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

    'txtTransLogTabTransLogTbcMainFrmMain_TextChanged() is the event procedure the is called when
    'the transaction log text box is modified.  Basically it enables the display text to scroll.
    Private Sub txtTransLogTabTransLogTbcMainFrmMain_TextChanged(sender As Object, e As EventArgs) Handles _
        txtTransLogTabTransLogTbcMainFrmMain.TextChanged

        txtTransLogTabTransLogTbcMainFrmMain.SelectionStart = _
            txtTransLogTabTransLogTbcMainFrmMain.TextLength
        txtTransLogTabTransLogTbcMainFrmMain.ScrollToCaret()

    End Sub 'txtTransLogTabTransLogTbcMainFrmMain_TextChanged(sender As Object, e As EventArgs)

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