'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test02-Palumbo-Robert
'File:          FrmMain.vb
'Author:        Robert Palumbo
'Description:   This is the main user interface form for the 
'               "Test02-Palumbo-Robert" Visual Basic program. 
'
'Date:          10/12/2015
'                   - Initial Creation
'
'Tier:          User Interface
'
'Exceptions:          TBD
'Exception-Handling:  TBD
'Events:              TBD
'Event-Handling:      TBD
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

    '******************************************************************
    '_writeTransLog() procedure does all the work to write a 
    'message to the transaction log.hat write the specified string to 
    'the transaction log.
    '******************************************************************
    Private Sub _writeTransLog(ByVal pLogMsg As String)
        txtTransLogFrmMain.Text &= _
            DateAndTime.DateString & ":" & DateAndTime.TimeString & "::"

        txtTransLogFrmMain.Text &= pLogMsg & vbCrLf
    End Sub '_writeTransLog(...)

    '_closeAppl() is used to simply close the application when
    'requested.
    Private Sub _closeAppl()

        'Notify the user application is closing
        MsgBox("Closing application...press OK to continue.",
                MsgBoxStyle.OkOnly)

        Me.Close()

    End Sub '_closeAppl()

    '_initializeBusinessLogic() is used to initialize the program business
    'data/logic to a known good starting state.
    Private Sub _initializeBusinessLogic()

        'Do Nothing for Now

    End Sub '_initializeBusinessLogic()

    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    Private Sub _initializeUserInterface()

        'Assign CancelButton to the form's Exit button
        Me.CancelButton = btnExitFrmMain

        'Assign AcceptButtong to the form's "Process Test Data" button
        Me.AcceptButton = btnPrcTestDataFrmMain

    End Sub '_initializeUserInterface()

    '_processTestData() is used to exercise basic functionality of the
    'program sending output to the transaction log.
    Private Sub _processTestData()

        _writeTransLog("[********* Processing Test Data - Started **********]")
        _writeTransLog(Nothing)
        _writeTransLog(Nothing)

        'Create 1 Bank
        Dim theBank As Bank = New Bank("B01", "CIS605 Bank Of Commerce", 0, 0, 0)
        _writeTransLog("<CREATED BANK> => " & theBank.ToString)
        _writeTransLog(Nothing)

        'Create 3 Customers
        Dim cust1 As Customer = theBank.createCustomer("C01", "Sarah")
        _writeTransLog("<CREATED CUSTOMER> => " & cust1.ToString)
        _writeTransLog("<UPDATED BANK STATUS> => " & theBank.ToString)
        _writeTransLog(Nothing)

        Dim cust2 As Customer = theBank.createCustomer("C02", "Bill")
        _writeTransLog("<CREATED CUSTOMER> => " & cust2.ToString)
        _writeTransLog("<UPDATED BANK STATUS> => " & theBank.ToString)
        _writeTransLog(Nothing)

        Dim cust3 As Customer = theBank.createCustomer("C03", "Jolene")
        _writeTransLog("<CREATED CUSTOMER> => " & cust3.ToString)
        _writeTransLog("<UPDATED BANK STATUS> => " & theBank.ToString)
        _writeTransLog(Nothing)

        'Create 4 Accounts
        Dim acct1 As Account = theBank.createAccount("A01", "Savings", "Sarah's Savings", cust1)
        _writeTransLog("<CREATED ACCOUNT> => " & acct1.ToString)
        _writeTransLog("<UPDATED BANK STATUS> => " & theBank.ToString)
        _writeTransLog(Nothing)

        Dim acct2 As Account = theBank.createAccount("A02", "Savings", "House Down Payment", cust2)
        _writeTransLog("<CREATED ACCOUNT> => " & acct2.ToString)
        _writeTransLog("<UPDATED BANK STATUS> => " & theBank.ToString)
        _writeTransLog(Nothing)

        Dim acct3 As Account = theBank.createAccount("A03", "Checking", "Jolene's Checking", cust3)
        _writeTransLog("<CREATED ACCOUNT> => " & acct3.ToString)
        _writeTransLog("<UPDATED BANK STATUS> => " & theBank.ToString)
        _writeTransLog(Nothing)

        Dim acct4 As Account = theBank.createAccount("A04", "Loan", "Car Loan", cust3)
        _writeTransLog("<CREATED ACCOUNT> => " & acct4.ToString)
        _writeTransLog("<UPDATED BANK STATUS> => " & theBank.ToString)
        _writeTransLog(Nothing)

        _writeTransLog(Nothing)
        _writeTransLog("[********* Processing Test Data - Completed **********]")

    End Sub '_processTestData()


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
    'user clicks on the Exit button or by using Alt-E hotkey sequence.
    'It is used to notify the user and formally terminate the program.
    Private Sub btnExitFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()

    End Sub '_btnExitFrmMain_Click(sender As Object, e As EventArgs)

    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    Private Sub _frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set the form title per the test requirements
        Me.Text = "Test02-Palumbo-Robert"

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()

    End Sub '_frmMain_Load(sender, e)

    '******************************************************************
    '_txtTransLogFrmMain_TextChanged() is the event procedure the is 
    'called when the transaction log text box is modified.  Basically 
    'it enables the display text to scroll.
    '******************************************************************
    Private Sub _txtTransLogFrmMain_TextChanged(sender As Object, e As EventArgs) Handles _
        txtTransLogFrmMain.TextChanged

        txtTransLogFrmMain.SelectionStart = txtTransLogFrmMain.TextLength
        txtTransLogFrmMain.ScrollToCaret()
    End Sub '_txtTransLogFrmMain_TextChanged(...)

    '******************************************************************
    '_btnPrcTestDataFrmMain_Click() is the event procedure the is 
    'called when the "Process Test Button" is clicked. It will auto-
    'matically exercise functionality of the system outputing the 
    'result to the transaction log on the main application form.
    '******************************************************************
    Private Sub _btnPrcTestDataFrmMain_Click(sender As Object, e As EventArgs) Handles _
         btnPrcTestDataFrmMain.Click

        'call the workhorse procedure
        _processTestData()

    End Sub '_btnPrcTestDataFrmMain_Click(...)


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