'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test03-Palumbo-Robert
'File:          FrmMain.vb
'Author:        Robert Palumbo
'Description:   This is the main user interface form for the 
'               "Test03-Palumbo-Robert" Visual Basic program. 
'
'Date:          11/20/2015
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
    'Bank Name
    Private Const mBANK_ID As String = "B01"
    Private Const mBANK_NAME As String = "CIS605 Bank Of Commerce"

    'System level error message
    Private Const mSYS_ERR_MSG As String = "Internal System Error: Object creation Failed"

    '********** Module-level variables
    Private WithEvents mBank As Bank = Nothing

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

    Private Property _theBank() As Bank
        Get
            Return mBank
        End Get
        Set(pValue As Bank)
            mBank = pValue
        End Set
    End Property

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
        txtTransLogFrmMain.Text &= pLogMsg & vbCrLf
    End Sub '_writeTransLog(...)

    '_closeAppl() is used to simply close the application when
    'requested.
    Private Sub _closeAppl()
        Me.Close()
    End Sub '_closeAppl()

    '_initializeBusinessLogic() is used to initialize the program business
    'data/logic to a known good starting state.
    Private Sub _initializeBusinessLogic()

        'Create a Bank instance
        _theBank = New Bank(mBANK_ID, mBANK_NAME, 0, 0)

    End Sub '_initializeBusinessLogic()

    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    Private Sub _initializeUserInterface()

        'Assign CancelButton to the form's Exit button
        Me.CancelButton = btnExitFrmMain

        'Assign AcceptButtong to the form's "Process Test Data" button
        Me.AcceptButton = btnPrcTestDataFrmMain

        'Display the current state of the bank at startup
        _writeTransLog("- Bank CREATED: " & Me._theBank.ToString)
        _writeTransLog(Nothing)

    End Sub '_initializeUserInterface()

    '_processTestData() is used to exercise basic functionality of the
    'program sending output to the transaction log.
    Private Sub _processTestData()
        'Create 1 Bank
        Me._theBank = New Bank("B01", "CIS605 Bank Of Commerce", 0, 0)

        'Create 3 Customers
        Dim cust1 As Customer = New Customer("C01", "Sarah")
        Dim cust2 As Customer = New Customer("C02", "Bill")
        Dim cust3 As Customer = New Customer("C03", "Jolene")

        _theBank.createCustomer(cust1.id, cust1.custName)
        _theBank.createCustomer(cust2.id, cust2.custName)
        _theBank.createCustomer(cust3.id, cust3.custName)

        'Create 5 Accounts - I believe these variables are placeholders for the FINAL
        'else I am not sure why we need to create hard coded variables here when we
        'can just as easily pass the data directly to the createAccount() function.
        Dim acct1 As Account = New Account("A01", "Savings", "Sarah's Savings", cust1)
        Dim acct2 As Account = New Account("A02", "Savings", "House Down Payment", cust2)
        Dim acct3 As Account = New Account("A03", "Checking", "Jolene's Checking", cust3)
        Dim acct4 As Account = New Account("A04", "Loan", "Car loan", cust3)
        Dim acct5 As Account = New Account("A05", "Loan", "Home loan", cust1)

        _theBank.createAccount(acct1.id, acct1.type, acct1.name, cust1)
        _theBank.createAccount(acct2.id, acct2.type, acct2.name, cust2)
        _theBank.createAccount(acct3.id, acct3.type, acct3.name, cust3)
        _theBank.createAccount(acct4.id, acct4.type, acct4.name, cust3)
        _theBank.createAccount(acct5.id, acct5.type, acct5.name, cust1)

        _writeTransLog("- Bank: STATUS: " & _theBank.ToString)
        '**** System Test Completed ****'
    End Sub '_processTestData()


#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

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
        Me.Text = "Test03-" & My.Application.Info.AssemblyName

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

    '****************************************************************************************
    '_createCustomer() handles processing for the Bank_CreateCustomer
    ' event that is generated when a new customer is added to the
    'system.
    '****************************************************************************************
    Private Sub _createCustomer(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) _
        Handles mBank.Bank_CreateCustomer

        'Declare variables
        Dim Test03_EventArgs_CreateCustomer As Bank_EventArgs_CreateCustomer
        Dim cust As Customer

        'Get/validate data
        Test03_EventArgs_CreateCustomer = CType(e, Bank_EventArgs_CreateCustomer)

        'Use the past in object to populate the necessary system components
        cust = Test03_EventArgs_CreateCustomer.cust

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If cust Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        _writeTransLog("- Customer CREATED: " & vbCrLf _
                     & "  + TOSTRING: " & cust.ToString & vbCrLf _
                     & "  + INDIVIDUAL FIELDS:" & vbCrLf _
                     & "    > C ID='" & cust.id & "'" & vbCrLf _
                     & "    > C Name='" & cust.custName & "'" & vbCrLf)

    End Sub '_createCustomer(...)

    '****************************************************************************************
    '_createAccount() handles processing for the Bank_CreateAccount
    ' event that is generated when a new account is added to the
    'system.
    '****************************************************************************************
    Private Sub _createAccount(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
        Handles mBank.Bank_CreateAccount

        'Declare variables
        Dim Test03_EventArgs_CreateAccount As Bank_EventArgs_CreateAccount
        Dim acct As Account

        'Get/validate data
        Test03_EventArgs_CreateAccount = CType(e, Bank_EventArgs_CreateAccount)

        'Use the past in object to populate the necessary system components
        acct = Test03_EventArgs_CreateAccount.acct

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If acct Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim aMsg As String = " unknown account type !"

        If acct.isChecking() Then
            aMsg = "You have $" & acct.balance.ToString("N2") & " in your checking account"
        ElseIf acct.isSavings Then
            aMsg = "You have $" & acct.balance.ToString("N2") & " in your savings account"
        ElseIf acct.isLoan Then
            aMsg = "You owe $" & acct.balance.ToString("N2") & " on your loan"
        End If

        _writeTransLog("- Account CREATED: " & vbCrLf _
                     & "  + TOSTRING: " & acct.ToString & ", " & aMsg & vbCrLf _
                     & "  + INDIVIDUAL FIELDS:" & vbCrLf _
                     & "    > A ID='" & acct.id & "'" & vbCrLf _
                     & "    > A Type='" & acct.name & "'" & vbCrLf _
                     & "    > A Cust='" & acct.cust.ToString & "'" & vbCrLf _
                     & "    > A Bal='" & acct.balance().ToString("N2") & "'" & vbCrLf)

    End Sub '_createAcct(...)

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'FrmMain