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

    'Minimum age to be considered an adult. Less than this age is 
    'thusly considered a child
    Private Const mADULT_MIN_AGE As Integer = 13

    'Used to reference the main UI tab control tabs
    Private Const mTBC_MAIN_TAB_DASHBOARD As Integer = 0
    Private Const mTBC_MAIN_TAB_CUSTOMER As Integer = 1
    Private Const mTBC_MAIN_TAB_FEATURE As Integer = 2
    Private Const mTBC_MAIN_TAB_PASSBK As Integer = 3
    Private Const mTBC_MAIN_TAB_PASSBKFEAT As Integer = 4
    Private Const mTBC_MAIN_TAB_TRANSLOG As Integer = 5
    Private Const mTBC_MAIN_TAB_SYSTEST As Integer = 6

    'Used to reference the Passbook Feature tab control tabs
    Private Const mTBC_PASSBKFEAT_TAB_ADD As Integer = 0
    Private Const mTBC_PASSBKFEAT_TAB_UPDT As Integer = 1
    Private Const mTBC_PASSBKFEAT_TAB_POST As Integer = 2

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

        Dim msg = "Shutting down the system.  Click OK to continue, otherwise Cancel"
        Dim style = MsgBoxStyle.OkCancel

        'Notify the user application is closing
        Dim choice As MsgBoxResult

        choice = MsgBox(msg, style)

        If choice = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub '_closeAppl()


    '********** Public Non-Shared Behavioral Methods

    '********** Private Non-Shared Behavioral Methods

    '_runSystemTest() is the procedure that executes the applications automated system test logic.
    'It is invoked either from the main UI menu or from the System Test tab.
    Private Sub _runSystemTest()
        _writeTransLog(Nothing)
        _writeTransLog("[Test Processing Started]: ********************************* ")

        '**** Test Theme Park creation ****
        Dim themePark As ThemePark = New ThemePark("World's Of Fun Theme Park")
        _writeTransLog("<CREATED>: " & themePark.ToString())

        '**** Test Customer creation ****
        _writeTransLog("**** CREATING TEST CUSTOMERS ****")

        Dim cust1 As Customer = themePark.createCustomer("0001", "Smith, John")
        _writeTransLog("<CREATED>: " & cust1.ToString())
        Dim cust2 As Customer = themePark.createCustomer("0002", "Jone, James")
        _writeTransLog("<CREATED>: " & cust2.ToString())
        Dim cust3 As Customer = themePark.createCustomer("0003", "Johnson, Robert")
        _writeTransLog("<CREATED>: " & cust3.ToString())

        _writeTransLog("<STATUS>: " & themePark.ToString)

        '**** Test Feature creation ****
        _writeTransLog("**** CREATING TEST FEATURES ****")

        Dim feat1 As Feature = themePark.createFeature("1001", "Parking Pass", "Day", 12.5D, 0)
        _writeTransLog("<CREATED>: " & feat1.ToString())
        Dim feat2 As Feature = themePark.createFeature("1002", "Gate Pass", "Day", 35.95D, 22.95D)
        _writeTransLog("<CREATED>: " & feat2.ToString())
        Dim feat3 As Feature = themePark.createFeature("1003", "Meal Plan", "Week", 65.95D, 31.95D)
        _writeTransLog("<CREATED>: " & feat3.ToString())

        _writeTransLog("<STATUS>: " & themePark.ToString)

        '**** Test Passbook creation ****
        _writeTransLog("**** CREATING TEST PASSBOOKS ****")

        Dim passbk1 As Passbook = themePark.createPassbook("2001", cust1, #2/8/2014#, "Smith, Will", #3/14/2001#, 14, False)
        _writeTransLog("<CREATED>: " & passbk1.ToString())
        Dim passbk2 As Passbook = themePark.createPassbook("2002", cust2, #6/14/2015#, "Jones, Jennifer", #7/21/1975#, 40, False)
        _writeTransLog("<CREATED>: " & passbk2.ToString())
        Dim passbk3 As Passbook = themePark.createPassbook("2003", cust3, #11/23/2011#, "Johnson, Brian", #12/14/2008#, 7, True)
        _writeTransLog("<CREATED>: " & passbk3.ToString())

        _writeTransLog("<STATUS>: " & themePark.ToString)

        '**** Test Passbook Feature purchase ****'
        _writeTransLog("**** CREATING TEST PASSBOOK FEATURE PURCHASES ****")

        Dim passbkFeat1 As PassbookFeature = themePark.purchaseFeature("3001", feat1.adultPrice * 2, feat1, passbk1, 2, 0)
        _writeTransLog("<PURCHASED>: " & passbkFeat1.ToString())
        Dim passbkFeat2 As PassbookFeature = themePark.purchaseFeature("3002", feat2.adultPrice * 1, feat2, passbk2, 1, 0)
        _writeTransLog("<PURCHASED>: " & passbkFeat2.ToString())
        Dim passbkFeat3 As PassbookFeature = themePark.purchaseFeature("3003", feat3.childPrice * 2, feat3, passbk3, 2, 0)
        _writeTransLog("<PURCHASED>: " & passbkFeat3.ToString())

        _writeTransLog("<STATUS>: " & themePark.ToString)

        _writeTransLog("[Test Processing Completed]: ********************************* ")
        _writeTransLog(Nothing)

        MsgBox("Test Processing completed.  Click to view the transaction", MsgBoxStyle.OkOnly)

        'Switch UI directly to the Transaction log tab
        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_TRANSLOG)
    End Sub '_runSystemTest()

    '_writeTransLog() procedure does all the work to write a 
    'message to the transaction log.hat write the specified string to 
    'the transaction log.
    Private Sub _writeTransLog(ByVal pLogMsg As String)
        txtTransLogTabTransLogTbcMainFrmMain.Text &= _
            DateAndTime.DateString & ":" & DateAndTime.TimeString & "::"

        txtTransLogTabTransLogTbcMainFrmMain.Text &= pLogMsg & vbCrLf
    End Sub '_writeTransLog(...)

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
    Private Sub _btnExitFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()
    End Sub '_btnExitFrmMain_Click(...)

    '_mnuFileExit() is the event procedure that gets called when the user selects
    'File->Exit from the main menu.
    Private Sub _mnuExitFileFrmMain_Click(sender As Object, e As EventArgs) Handles _
        mnuExitFileFrmMain.Click

        'Program terminated from main menu selection
        _closeAppl()
    End Sub '_mnuExitFileFrmMain_Click(...) 

    '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Customer tab. It validates and then
    'submits the data to create a new customer.
    Private Sub _btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
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
            Return
        End If

        If String.IsNullOrEmpty(custName) Then
            MsgBox("Please enter a valid Customer Name (ex: Doe, John)", MsgBoxStyle.OkOnly)
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.SelectAll()
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.Focus()
            Return
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult

        choice = MsgBox("To create a new Customer with these attributes Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                        & "--> Id=" & custId & vbCrLf _
                        & "--> Name=" & custName & vbCrLf,
                        MsgBoxStyle.OkCancel
                        )

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok Then
            'Create a new Customer
            newCust = _theThemePark.createCustomer(
                            custId,
                            custName
                            )

            _writeTransLog("<CREATED>: " & newCust.ToString())
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Customer creation was successful!", MsgBoxStyle.OkOnly)

            'Reset the input fields to allow for another possible customer entry
            _resetCustomerInput()
        End If

    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '_resetCustomerInput() is used to reset all the customer input fields to allow the user 
    'to start over with input.
    Private Sub _resetCustomerInput()
        'Reset the fields and focus to allow for another feature to be added
        txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text = ""
        txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text = ""
        txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
    End Sub '_resetCustomerInput()

    '_btnResetGrpCustInfoTabCustTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    Private Sub _btnResetGrpCustInfoTabCustTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnResetGrpCustInfoTabCustTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another feature to be added
        _resetCustomerInput()
    End Sub '_btnResetGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '_btnSubmitGrpAddFeatTabFeatTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Feature tab. It validates and then
    'submits the data to create a new feature.
    Private Sub _btnSubmitGrpAddFeatTabFeatTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
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

        'Verify the purchase before committing
        Dim choice As MsgBoxResult

        choice = MsgBox("To create a new Feature with these attributes Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                        & "--> Id=" & featId & vbCrLf _
                        & "--> Name=" & featName & vbCrLf _
                        & "--> UnitMeasure=" & unitOfMeas & vbCrLf _
                        & "--> AdultPrice=" & adultPrice & vbCrLf _
                        & "--> ChildPrice=" & childPrice & vbCrLf,
                        MsgBoxStyle.OkCancel
                        )

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok Then
            'Create a new Feature
            newFeat = _theThemePark.createFeature(featId, _
                                                  featName, _
                                                  unitOfMeas, _
                                                  decAdultPrice, _
                                                  decChildPrice
                                                  )

            _writeTransLog("<CREATED>: " & newFeat.ToString())
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Feature creation was successful!", MsgBoxStyle.OkOnly)

            'Reset the input fields to allow for another possible feature entry
            _resetFeatureInput()
        End If
    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '_resetFeatureInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    Private Sub _resetFeatureInput()
        'Reset the fields and focus to allow for another feature to be added
        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
    End Sub '_resetFeatureInput()

    '_btnResetGrpAddFeatTabFeatTbcMainFrmMain() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    Private Sub _btnResetGrpAddFeatTabFeatTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnResetGrpAddFeatTabFeatTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another feature to be added
        _resetFeatureInput()
    End Sub '_btnResetGrpAddFeatTabFeatTbcMainFrmMain(...)

    '_btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Passbook tab. It validates and then
    'submits the data to create a new passbook.
    Private Sub _btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain.Click

        Dim newPassbk As Passbook = Nothing

        'Used as shortcut names to access the data
        Dim passbkId As String = txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text
        Dim visName As String = txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text
        Dim visDob As String = txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text
        Dim custList As ListBox = lstCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain
        Dim visDobValue As Date

        'Validate all the fields
        If String.IsNullOrEmpty(passbkId) Then
            MsgBox("Please enter a unique Passbook ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.SelectAll()
            txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Return
        End If

        If String.IsNullOrEmpty(visName) Then
            MsgBox("Please enter a Visitor Name (ex: Doe, John)", MsgBoxStyle.OkOnly)
            txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.SelectAll()
            txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Return
        End If

        If Not DateTime.TryParse(visDob, visDobValue) Then
            MsgBox("Please select a valid date from the calendar", MsgBoxStyle.OkOnly)
            txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Return
        End If

        'Determine if the visitor is a child (< 13 years old)
        Dim datePurch As Date = DateTime.Now
        Dim visAge As Long = DateDiff(DateInterval.Year, visDobValue, datePurch)
        Dim visIsChild As Boolean = (visAge < mADULT_MIN_AGE)

        'PBO - this customer object is tempary until the next phase of the project
        Dim tempCust As Customer = New Customer("9999", "Test Customer")

        'Verify the purchase before committing
        Dim choice As MsgBoxResult

        choice = MsgBox("To create a new Passbook with these attributes Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                        & "--> Id=" & passbkId & vbCrLf _
                        & "--> Owner=" & tempCust.custName & vbCrLf _
                        & "--> VisitorName=" & visName & vbCrLf _
                        & "--> VisitorDOB=" & visDob & vbCrLf _
                        & "--> VistorAge=" & visAge & vbCrLf _
                        & "--> VistorIsChild? " & visIsChild.ToString & vbCrLf _
                        & "--> DatePurchased=" & datePurch & vbCrLf,
                        MsgBoxStyle.OkCancel
                        )

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok Then
            'Create a new Passbook
            newPassbk = _theThemePark.createPassbook(passbkId, _
                                                     tempCust, _
                                                     datePurch, _
                                                     visName, _
                                                     visDobValue, _
                                                     Convert.ToInt32(visAge), _
                                                     visIsChild
                                                     )

            _writeTransLog("<CREATED>: " & newPassbk.ToString())
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook creation was successful!", MsgBoxStyle.OkOnly)

            'Reset the input fields to allow for another possible feature entry
            _resetPassbkInput()
        End If
    End Sub '_btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click(...)

    '_resetPassbkInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    Private Sub _resetPassbkInput()
        'Reset the fields and focus to allow for another feature to be added
        txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
    End Sub '_resetPassbkInput()

    'btnResetGrpAddFeatTabFeatTbcMainFrmMain() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    Private Sub _btnResetGrpAddPassbkTabPassbkTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnResetGrpAddPassbkTabPassbkTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another passbook to be added
        _resetPassbkInput()
    End Sub '_btnResetGrpAddPassbkTabPassbkTbcMainFrmMain_Click

    '_btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets called when the user
    'clicks on the Submit button from the Add Passbook Feature tab.  It validates and then submit the data
    'to add a purchased feature to a customer passbook.
    Private Sub _btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, e As EventArgs) Handles _
        btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain.Click

        Dim newPassbkFeat As PassbookFeature = Nothing

        'Temporary for Phase 2 requirements
        Dim tempCust As Customer = New Customer("0001", "Doe, John")
        Dim tempPassbk As Passbook = New Passbook("0001", tempCust, DateTime.Now, "Doe, James",
                                                  #2/21/2005#, 10, True)
        Dim tempFeat As Feature = New Feature("0001", "Park Pass", "Day", 12.5D, 7.5D)

        'Used as shortcut names to access the data
        Dim featId As String = txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim qtyPurch As String = txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim decQtyPurch As Decimal
        Dim decQtyRemain As Decimal = 0D

        'Validate all the fields
        If String.IsNullOrEmpty(featId) Then
            MsgBox("Please enter unique Passbook Feature Id (ex: 0001)", MsgBoxStyle.OkOnly)
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Return
        End If

        If Not Decimal.TryParse(qtyPurch, decQtyPurch) Then
            MsgBox("Please enter a numeric Quantity > 0 to purchase (ex: 3)", MsgBoxStyle.OkOnly)
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Return
        End If

        'Calculate total price - based on age 
        Dim totPurchPrice As Decimal
        Dim unitPurchPrice As Decimal

        If tempPassbk.visIsChild = True Then
            unitPurchPrice = tempFeat.childPrice
        Else
            unitPurchPrice = tempFeat.adultPrice
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult

        totPurchPrice = unitPurchPrice * decQtyPurch

        choice = MsgBox("To puchase the following Passbook Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                        & "--> PassbookFeatureId=" & featId & vbCrLf _
                        & "--> Feature=" & tempFeat.featName & vbCrLf _
                        & "--> UnitPrice=" & unitPurchPrice & vbCrLf _
                        & "--> QtyPurchased=" & decQtyPurch & vbCrLf _
                        & "--> TotalPurchasePrice=" & totPurchPrice & vbCrLf _
                        & "--> QtyRemain=" & decQtyRemain & vbCrLf _
                        & "--> Passbook=" & tempPassbk.passbkId & vbCrLf,
                        MsgBoxStyle.OkCancel
                        )

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok Then
            'Create a new Passbook Feature
            newPassbkFeat = _theThemePark.purchaseFeature(featId, _
                                                          totPurchPrice, _
                                                          tempFeat, _
                                                          tempPassbk, _
                                                          decQtyPurch, _
                                                          decQtyRemain
                                                          )

            _writeTransLog("<PURCHASED>: " & newPassbkFeat.ToString())
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook Feature purchase was successful!", MsgBoxStyle.OkOnly)

            'Reset the fields and focus to allow for another feature to be added
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        End If
    End Sub '_btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click(...)

    '_btnClearTabTransLogTbcMainFrmMain_Click() is the event procedure that gets called when the user
    'clicks on the Clear button from the Tranaaction log tab.  It clears the log.
    Private Sub _btnClearTabTransLogTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnClearTabTransLogTbcMainFrmMain.Click

        'Reset the transaction log
        txtTransLogTabTransLogTbcMainFrmMain.Text = ""
    End Sub '_btnClearTabTransLogTbcMainFrmMain_Click(...)

    '_tbcMainFrmMain_SelectedIndexChanged() is used to set control attribute when specific
    'tab on the UI are selected.  This is form the main program tab control.
    Private Sub _tbcMainFrmMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
        tbcMainFrmMain.SelectedIndexChanged

        Console.WriteLine("Calling Main tab control")

        Select Case tbcMainFrmMain.SelectedIndex
            Case mTBC_MAIN_TAB_DASHBOARD
                Console.WriteLine("Dashboard Tab")

                'Nothing to do for this tab

            Case mTBC_MAIN_TAB_CUSTOMER
                Console.WriteLine("Customer Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitGrpCustInfoTabCustTbcMainFrmMain

                'Set the focus to the first input field
                txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()

            Case mTBC_MAIN_TAB_FEATURE
                Console.WriteLine("Feature Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitGrpAddFeatTabFeatTbcMainFrmMain

                'Set the focus to the first input field
                txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()

            Case mTBC_MAIN_TAB_PASSBK
                Console.WriteLine("Passbook Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain

                'Set the focus to the first input field
                lstCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()

            Case mTBC_MAIN_TAB_PASSBKFEAT
                Console.WriteLine("Passbook Feature Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain

                'Set the focus to the first input field
                lstPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_MAIN_TAB_TRANSLOG
                Console.WriteLine("Transaction Log Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnClearTabTransLogTbcMainFrmMain

            Case mTBC_MAIN_TAB_SYSTEST
                Console.WriteLine("System Test Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain
        End Select
    End Sub 'tbcMainFrmMain_SelectedIndexChanged(...)

    '_tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged() is used to set 
    'control attribute when specific tab on the UI are selected.  This is for the 
    'Passboo Feature tab control.
    Private Sub _tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
        tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndexChanged

        Console.WriteLine("Calling Passbook Feature tab control")

        Select Case tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndex
            Case mTBC_PASSBKFEAT_TAB_ADD
                Console.WriteLine("Add Tab")

                'Set the focus to the first input field
                lstPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_UPDT
                Console.WriteLine("Update Tab")

                'Set the focus to the first input field
                lstFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_POST
                Console.WriteLine("Post Tab")

                'Set the focus to the first input field
                lstPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
        End Select
    End Sub '_tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(...)

    '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click() is the event procedure that gets called when 
    'the user clicks on the 'Process Test Data' button from the System Test tab.  It automates testing of 
    'existing functionality of the system.  Results are output in the transaction log.
    Private Sub _btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain.Click

        'Execute the system test procedure
        _runSystemTest()
    End Sub '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(...)

    '_mnuTransLogViewFrmMain_Click() is the event procedure that gets called when the user selects
    '"View -> Transaction Log' from the main menu.  It will automically switch the UI to the
    'Transaction log tab.
    Private Sub _mnuTransLogViewFrmMain_Click(sender As Object, e As EventArgs) Handles _
        mnuTransLogViewFrmMain.Click

        'Switch UI directly to the Transaction log tab
        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_TRANSLOG)
    End Sub '_mnuTransLogViewFrmMain_Click(...)

    '_mnuRunSysTestTestFrmMain_Click() is the event procedure that gets called when the user selects
    '"Test -> Run System Test' from the main menu.  It will initiate the automated test procedure.
    Private Sub _mnuRunSysTestTestFrmMain_Click(sender As Object, e As EventArgs) Handles _
        mnuRunSysTestTestFrmMain.Click

        'Execute the system test procedure
        _runSystemTest()
    End Sub '_mnuRunSysTestTestFrmMain_Click(...)

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
    End Sub '_frmMain_Load(...)

    '_txtTransLogTabTransLogTbcMainFrmMain_TextChanged() is the event procedure the is called when
    'the transaction log text box is modified.  Basically it enables the display text to scroll.
    Private Sub _txtTransLogTabTransLogTbcMainFrmMain_TextChanged(sender As Object, e As EventArgs) Handles _
        txtTransLogTabTransLogTbcMainFrmMain.TextChanged

        txtTransLogTabTransLogTbcMainFrmMain.SelectionStart = _
            txtTransLogTabTransLogTbcMainFrmMain.TextLength
        txtTransLogTabTransLogTbcMainFrmMain.ScrollToCaret()
    End Sub '_txtTransLogTabTransLogTbcMainFrmMain_TextChanged(...)


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