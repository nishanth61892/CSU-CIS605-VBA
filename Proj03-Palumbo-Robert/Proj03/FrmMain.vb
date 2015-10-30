'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj03 - Theme Park Managament System  
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
'               10/29/2015
'                   - Modifications to support the third phase of
'                   course project (Proj03)
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
    Private WithEvents mThemePark As ThemePark

    'Name of the theme park
    Private mThemeParkName As String

    'Flag that is enabled when the user has initiated system test
    'processing.  Used to prevent confirmation dialogs from popping
    'up when new objects are added to the system.  No need for this
    'given it is test date that needs to be added
    Private mSysTestActive As Boolean = False
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

    Public ReadOnly Property themeParkName() As String
        Get
            Return _themeParkName
        End Get
    End Property

    Private ReadOnly Property sysTestActive() As Boolean
        Get
            Return mSysTestActive
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _theThemePark() As ThemePark
        Get
            Return mThemePark
        End Get
        Set(pValue As ThemePark)
            mThemePark = pValue
        End Set
    End Property

    Private Property _themeParkName() As String
        Get
            Return mThemeParkName
        End Get
        Set(pValue As String)
            mThemeParkName = pValue
        End Set
    End Property

    Private Property _sysTestActive() As Boolean
        Get
            Return mSysTestActive
        End Get
        Set(pValue As Boolean)
            mSysTestActive = pValue
        End Set
    End Property


#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '******************************************************************
    '_closeAppl() is used to simply close the application when
    'requested.
    '******************************************************************
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

    '******************************************************************
    '_runSystemTest() is the procedure that executes the applications automated system test logic.
    'It is invoked either from the main UI menu or from the System Test tab.
    '******************************************************************
    Private Sub _runSystemTest()
        'Indicate to that the system test is running
        _sysTestActive = True

        _writeTransLog(Nothing)
        _writeTransLog("[Test Processing Started]: ********************************* ")
        _writeTransLog(Nothing)

        '**** Test Theme Park creation ****
        'Use a temporary local theme park object if the associated check box has been
        'checked, otherwise use the system theme park object
        Dim themePark As ThemePark

        If chkUseTestParkGrpSysTestTabSysTestTbcMainFrmMain.CheckState = CheckState.Checked Then
            themePark = New ThemePark("World's Of Fun Theme Park")
            _writeTransLog("[ThemePark]: successfully created ==> " & themePark.ToString())
        Else
            themePark = Me._theThemePark
            _writeTransLog("[ThemePark]: using System Theme Park ==> " & themePark.ToString())
        End If

        '**** Test Customer creation ****
        _writeTransLog(Nothing)
        _writeTransLog("**** CREATING TEST CUSTOMERS ****")
        _writeTransLog(Nothing)

        Dim cust1 As Customer = New Customer("0001", "Smith, John")
        Dim cust2 As Customer = New Customer("0002", "Jone, James")
        Dim cust3 As Customer = New Customer("0003", "Johnson, Robert")

        themePark.createCust("0001", "Smith, John")
        themePark.createCust("0002", "Jones, James")
        themePark.createCust("0003", "Johnson, Robert")

        _writeTransLog("<PARK-STATUS>: " & themePark.ToString)

        '**** Test Feature creation ****
        _writeTransLog(Nothing)
        _writeTransLog("**** CREATING TEST FEATURES ****")
        _writeTransLog(Nothing)

        Dim feat1 As Feature = New Feature("1001", "Parking Pass", "Day", 12.5D, 0)
        Dim feat2 As Feature = New Feature("1002", "Gate Pass", "Day", 35.95D, 22.95D)
        Dim feat3 As Feature = New Feature("1003", "Meal Plan", "Week", 65.95D, 31.95D)

        themePark.createFeat("1001", "Parking Pass", "Day", 12.5D, 0)
        themePark.createFeat("1002", "Gate Pass", "Day", 35.95D, 22.95D)
        themePark.createFeat("1003", "Meal Plan", "Week", 65.95D, 31.95D)

        _writeTransLog("<PARK-STATUS>: " & themePark.ToString)

        '**** Test Passbook creation ****
        _writeTransLog(Nothing)
        _writeTransLog("**** CREATING TEST PASSBOOKS ****")
        _writeTransLog(Nothing)

        Dim passbk1 As Passbook = New Passbook("2001", cust1, #2/8/2014#, "Smith, Will", #3/14/2001#, 14, False)
        Dim passbk2 As Passbook = New Passbook("2002", cust2, #6/14/2015#, "Jones, Jennifer", #7/21/1975#, 40, False)
        Dim passbk3 As Passbook = New Passbook("2003", cust3, #11/23/2011#, "Johnson, Brian", #12/14/2008#, 7, True)

        themePark.createPassbk("2001", cust1, #2/8/2014#, "Smith, Will", #3/14/2001#, 14, False)
        themePark.createPassbk("2002", cust2, #6/14/2015#, "Jones, Jennifer", #7/21/1975#, 40, False)
        themePark.createPassbk("2003", cust3, #11/23/2011#, "Johnson, Brian", #12/14/2008#, 7, True)

        _writeTransLog("<PARK-STATUS>: " & themePark.ToString)

        '**** Test Passbook Feature purchase ****'
        _writeTransLog(Nothing)
        _writeTransLog("**** CREATING TEST PASSBOOK FEATURE PURCHASES ****")
        _writeTransLog(Nothing)

        Dim passbkFeat1 As PassbookFeature = New PassbookFeature("3001", feat1.adultPrice * 2, feat1, passbk1, 2, 0)
        Dim passbkFeat2 As PassbookFeature = New PassbookFeature("3002", feat2.adultPrice * 1, feat2, passbk2, 1, 0)
        Dim passbkFeat3 As PassbookFeature = New PassbookFeature("3003", feat3.childPrice * 2, feat3, passbk3, 2, 0)

        themePark.addPassbkFeat("3001", feat1.adultPrice * 2, feat1, passbk1, 2, 0)
        themePark.addPassbkFeat("3002", feat2.adultPrice * 1, feat2, passbk2, 1, 0)
        themePark.addPassbkFeat("3003", feat3.childPrice * 2, feat3, passbk3, 2, 0)

        _writeTransLog("<PARK-STATUS>: " & themePark.ToString)

        '**** Test Passbook Feature Update ****'
        _writeTransLog(Nothing)
        _writeTransLog("**** CREATING TEST USED PASSBOOK FEATURE ****")
        _writeTransLog(Nothing)

        Dim usedFeat1 As UsedFeature = themePark.usedFeat("4001", passbkFeat1, DateTime.Now, 2, "Chicago IL")
        Dim usedFeat2 As UsedFeature = themePark.usedFeat("4002", passbkFeat2, DateTime.Now, 1, "Denver CO")
        Dim usedFeat3 As UsedFeature = themePark.usedFeat("4003", passbkFeat3, DateTime.Now, 3, "Center Circle Park")

        _writeTransLog("<PARK-STATUS>: " & themePark.ToString)

        _writeTransLog(Nothing)
        _writeTransLog("[Test Processing Completed]: ********************************* ")
        _writeTransLog(Nothing)

        MsgBox("Test Processing completed.  Click to view the transaction", MsgBoxStyle.OkOnly)

        'Switch UI directly to the Transaction log tab
        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_TRANSLOG)

        'Indicate the system test has completed
        _sysTestActive = False
    End Sub '_runSystemTest()

    '******************************************************************
    '_writeTransLog() procedure does all the work to write a 
    'message to the transaction log.hat write the specified string to 
    'the transaction log.
    '******************************************************************
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

    '******************************************************************
    '_initializeBusinessLogic() is used to initialize the program business
    'data/logic to a known good starting state.
    '******************************************************************
    Private Sub _initializeBusinessLogic()
        'Create a theme park instance
        _theThemePark = New ThemePark("Palumbo's Party Park")

        _writeTransLog("<CREATED>: " & _theThemePark.ToString())
    End Sub '_initializeBusinessLogic()

    '******************************************************************
    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    '******************************************************************
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

    '******************************************************************
    '_btnExitFrmMain_Click() is the event procedure that gets called when the
    'user clicks on the Exit button or by using Alt-E hot key sequence.
    'It is used to notify the user and formally terminate the program.
    '******************************************************************
    Private Sub _btnExitFrmMain_Click(sender As Object, _
                                      e As EventArgs) _
        Handles btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()
    End Sub '_btnExitFrmMain_Click(...)

    '******************************************************************
    '_mnuFileExit() is the event procedure that gets called when the user selects
    'File->Exit from the main menu.
    '******************************************************************
    Private Sub _mnuExitFileFrmMain_Click(sender As Object, _
                                          e As EventArgs) _
        Handles mnuExitFileFrmMain.Click

        'Program terminated from main menu selection
        _closeAppl()
    End Sub '_mnuExitFileFrmMain_Click(...) 

    '******************************************************************
    '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Customer tab. It validates and then
    'submits the data to create a new customer.
    '******************************************************************
    Private Sub _btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(sender As Object, _
                                                                 e As EventArgs) _
        Handles btnSubmitGrpCustInfoTabCustTbcMainFrmMain.Click

        Dim custId As String
        Dim custName As String

        custId = txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text
        custName = txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text

        'Validate the id and name field to make sure they contain data
        If String.IsNullOrEmpty(custId) Then
            MsgBox("ERROR: Please enter a unqiue Customer ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.SelectAll()
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(custName) Then
            MsgBox("ERROR: Please enter a valid Customer Name (ex: Doe, John)", MsgBoxStyle.OkOnly)
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.SelectAll()
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult

        choice = MsgBox("To create a new Customer with these attributes Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                        & "--> Id=" & custId & vbCrLf _
                        & "--> Name=" & custName & vbCrLf,
                        MsgBoxStyle.OkCancel
                        )

        'If OK selected proceed with the submission assuming not test data
        If choice = MsgBoxResult.Ok Then
            'Create a new Customer
            _theThemePark.createCust(custId,
                                     custName
                                     )

            'Reset the input fields to allow for another possible customer entry
            _resetCustomerInput()
        End If
    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '******************************************************************
    '_resetCustomerInput() is used to reset all the customer input fields to allow the user 
    'to start over with input.
    '******************************************************************
    Private Sub _resetCustomerInput()
        'Reset the fields and focus to allow for another feature to be added
        txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text = ""
        txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text = ""
        txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
    End Sub '_resetCustomerInput()

    '******************************************************************
    '_btnResetGrpCustInfoTabCustTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    '******************************************************************
    Private Sub _btnResetGrpCustInfoTabCustTbcMainFrmMain_Click(sender As Object, _
                                                                e As EventArgs) _
        Handles btnResetGrpCustInfoTabCustTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another feature to be added
        _resetCustomerInput()
    End Sub '_btnResetGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '******************************************************************
    '_btnSubmitGrpAddFeatTabFeatTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Feature tab. It validates and then
    'submits the data to create a new feature.
    '******************************************************************
    Private Sub _btnSubmitGrpAddFeatTabFeatTbcMainFrmMain_Click(sender As Object, _
                                                                e As EventArgs) _
        Handles btnSubmitGrpAddFeatTabFeatTbcMainFrmMain.Click

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
            MsgBox("ERROR: Please enter a unique Feature ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(featName) Then
            MsgBox("ERROR: Please enter a valid Feature Name (ex: Park Pass)", MsgBoxStyle.OkOnly)
            txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(unitOfMeas) Then
            MsgBox("ERROR: Please enter a specific Unit of Measure (ex: Day)", MsgBoxStyle.OkOnly)
            txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'These must be converted to decimal values
        If Not IsNumeric(adultPrice) Then
            MsgBox("ERROR: Please enter a numeric Adult price (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        decAdultPrice = Decimal.Parse(adultPrice)
        If decAdultPrice < 0 Then
            MsgBox("ERROR: Adult price must be greater than 0.0 (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'These must be converted to decimal values
        If Not IsNumeric(childPrice) Then
            MsgBox("ERROR: Please enter a numeric Child price (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        decChildPrice = Decimal.Parse(childPrice)
        If decChildPrice <= 0 Then
            MsgBox("ERROR: Child price must be greater than 0.0 (ex: 20.50)", MsgBoxStyle.OkOnly)
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = "0"
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To create a new Feature with these attributes Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                            & "--> Id=" & featId & vbCrLf _
                            & "--> Name=" & featName & vbCrLf _
                            & "--> UnitMeasure=" & unitOfMeas & vbCrLf _
                            & "--> AdultPrice=" & adultPrice & vbCrLf _
                            & "--> ChildPrice=" & childPrice & vbCrLf,
                            MsgBoxStyle.OkCancel
                            )
        End If

        'If OK selected proceed with the submission assuming not test data
        If choice = MsgBoxResult.Ok And _sysTestActive = False Then
            'Create a new Feature
            _theThemePark.createFeat(featId, _
                                     featName, _
                                     unitOfMeas, _
                                     decAdultPrice, _
                                     decChildPrice
                                     )
            'Reset the input fields to allow for another possible feature entry
            _resetFeatureInput()
        End If

    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '******************************************************************
    '_resetFeatureInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    '******************************************************************
    Private Sub _resetFeatureInput()
        'Reset the fields and focus to allow for another feature to be added
        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
    End Sub '_resetFeatureInput()

    '******************************************************************
    '_btnResetGrpAddFeatTabFeatTbcMainFrmMain() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    '******************************************************************
    Private Sub _btnResetGrpAddFeatTabFeatTbcMainFrmMain_Click(sender As Object, _
                                                               e As EventArgs) _
        Handles btnResetGrpAddFeatTabFeatTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another feature to be added
        _resetFeatureInput()
    End Sub '_btnResetGrpAddFeatTabFeatTbcMainFrmMain(...)

    '******************************************************************
    '_btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Passbook tab. It validates and then
    'submits the data to create a new passbook.
    '******************************************************************
    Private Sub _btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click(sender As Object, _
                                                                    e As EventArgs) _
        Handles btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain.Click

        Dim newPassbk As Passbook = Nothing

        'Used as shortcut names to access the data
        Dim custList As ComboBox = cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain
        Dim passbkId As String = txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text
        Dim visName As String = txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text
        Dim visDob As String = txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text
        Dim visDobValue As Date

        'Validate all the fields
        If String.IsNullOrEmpty(custList.Text) Then
            MsgBox("ERROR: Please seleect a Customer Id from the list", MsgBoxStyle.OkOnly)
            txtToStringGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.SelectAll()
            txtToStringGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(passbkId) Then
            MsgBox("ERROR: Please enter a unique Passbook ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.SelectAll()
            txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(visName) Then
            MsgBox("ERROR: Please enter a Visitor Name (ex: Doe, John)", MsgBoxStyle.OkOnly)
            txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.SelectAll()
            txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If Not DateTime.TryParse(visDob, visDobValue) Then
            MsgBox("ERROR: Please select a valid date from the calendar", MsgBoxStyle.OkOnly)
            txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Determine if the visitor is a child (< 13 years old)
        Dim datePurch As Date = DateTime.Now
        Dim visAge As Long = DateDiff(DateInterval.Year, visDobValue, datePurch)
        Dim visIsChild As Boolean = (visAge < mADULT_MIN_AGE)

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To create a new Passbook with these attributes Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                            & "--> Id=" & passbkId & vbCrLf _
                            & "--> Owner=" & custList.Text & vbCrLf _
                            & "--> VisitorName=" & visName & vbCrLf _
                            & "--> VisitorDOB=" & visDob & vbCrLf _
                            & "--> VistorAge=" & visAge & vbCrLf _
                            & "--> VistorIsChild? " & visIsChild.ToString & vbCrLf _
                            & "--> DatePurchased=" & datePurch & vbCrLf,
                            MsgBoxStyle.OkCancel
                            )
        End If

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok And _sysTestActive = False Then
            'PBO - this customer object is tempary until the next phase of the project
            Dim tempCust As Customer = New Customer("9999", custList.Text)

            'Create a new Passbook
            _theThemePark.createPassbk(passbkId, _
                                       tempCust, _
                                       datePurch, _
                                       visName, _
                                       visDobValue, _
                                       Convert.ToInt32(visAge), _
                                       visIsChild
                                       )

            'Reset the input fields to allow for another possible feature entry
            _resetPassbkInput()
        End If
    End Sub '_btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click(...)

    '******************************************************************
    '_resetPassbkInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    '******************************************************************
    Private Sub _resetPassbkInput()
        'Reset the fields and focus to allow for another feature to be added
        cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
    End Sub '_resetPassbkInput()

    '******************************************************************
    'btnResetGrpAddFeatTabFeatTbcMainFrmMain() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    '******************************************************************
    Private Sub _btnResetGrpAddPassbkTabPassbkTbcMainFrmMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnResetGrpAddPassbkTabPassbkTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another passbook to be added
        _resetPassbkInput()
    End Sub '_btnResetGrpAddPassbkTabPassbkTbcMainFrmMain_Click

    '******************************************************************
    '_btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets called when the user
    'clicks on the Submit button from the Add Passbook Feature tab.  It validates and then submits the data
    'to add a purchased feature to a customer passbook.
    '******************************************************************
    Private Sub _btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain.Click

        Dim newPassbkFeat As PassbookFeature = Nothing

        'Temporary for Phase 2 requirements
        Dim tempCust As Customer = New Customer("0001", "Doe, John")
        Dim tempPassbk As Passbook = New Passbook("0001", tempCust, DateTime.Now, "Doe, James",
                                                  #2/21/2005#, 10, True)
        Dim tempFeat As Feature = New Feature("0001", "Park Pass", "Day", 12.5D, 7.5D)

        'Used as shortcut names to access the data
        Dim passbkFeatId As String = txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim passbkId As String = cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim featId As String = cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim qtyPurch As String = txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim decQtyPurch As Decimal
        Dim decQtyRemain As Decimal = 0D

        'Validate all the fields
        If String.IsNullOrEmpty(passbkId) Then
            MsgBox("ERROR: Please select a Passbook Id from the list", MsgBoxStyle.OkOnly)
            cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please select a Feature Id from the list", MsgBoxStyle.OkOnly)
            cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(passbkFeatId) Then
            MsgBox("ERROR: Please enter unique Passbook Feature Id (ex: 0001)", MsgBoxStyle.OkOnly)
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(qtyPurch, decQtyPurch) Or decQtyPurch <= 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity > 0 to purchase (ex: 3)", MsgBoxStyle.OkOnly)
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Calculate total price - based on age 
        Dim totPurchPrice As Decimal
        Dim unitPurchPrice As Decimal

        If tempPassbk.visIsChild = True Then
            unitPurchPrice = tempFeat.childPrice
        Else
            unitPurchPrice = tempFeat.adultPrice
        End If

        totPurchPrice = unitPurchPrice * decQtyPurch

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To purchase the following Passbook Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                            & "--> PassbookFeatureId=" & passbkFeatId & vbCrLf _
                            & "--> Feature=" & tempFeat.featName & vbCrLf _
                            & "--> UnitPrice=" & unitPurchPrice & vbCrLf _
                            & "--> QtyPurchased=" & decQtyPurch & vbCrLf _
                            & "--> TotalPurchasePrice=" & totPurchPrice & vbCrLf _
                            & "--> QtyRemain=" & decQtyRemain & vbCrLf _
                            & "--> Passbook=" & tempPassbk.passbkId & vbCrLf,
                            MsgBoxStyle.OkCancel
                            )
        End If

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok And _sysTestActive = False Then
            'Create a new Passbook Feature
            _theThemePark.addPassbkFeat(featId, _
                                        totPurchPrice, _
                                        tempFeat, _
                                        tempPassbk, _
                                        decQtyPurch, _
                                        decQtyRemain
                                        )

            'Reset the fields and focus to allow for another feature to be added
            _resetPassbkAddFeatInput()
        End If
    End Sub '_btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click(...)

    '******************************************************************
    '_resetPassbkFeatAddInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    '******************************************************************
    Private Sub _resetPassbkAddFeatInput()
        'Reset the fields and focus to allow for another feature to be added
        cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtCustToStringGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtVisToStringGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtFeatToStringGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
    End Sub '_resetPassbkAddInput()

    '******************************************************************
    '_btnResetTabAddFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets called 
    'when the user clicks on the Reset button from the 'Passbook Features | Add' tab. It clears all input
    'fields to allow the user to reenter the data from scratch.
    '******************************************************************
    Private Sub _btnResetTabAddFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                  e As EventArgs) _
        Handles btnResetTabAddFeatTbcPassbkFeatMainTbcMain.Click

        'Reset the fields and focus to allow for another passbook featurd addition
        _resetPassbkAddFeatInput()
    End Sub '_btnResetTabAddFeatTbcPassbkFeatMainTbcMain_Click(...)

    '******************************************************************
    '_btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets called when the user
    'clicks on the Submit button from the Update Passbook Feature tab.  It validates and then submits the data
    'to update a customer passbook feature.
    '******************************************************************
    Private Sub _btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                    e As EventArgs) _
        Handles btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain.Click

        Dim newPassbkFeat As PassbookFeature = Nothing

        'Temporary for Phase 2 requirements
        Dim tempCust As Customer = New Customer("0001", "Doe, John")
        Dim tempPassbk As Passbook = New Passbook("0001", tempCust, DateTime.Now, "Doe, James",
                                                  #2/21/2005#, 10, True)
        Dim tempFeat As Feature = New Feature("0001", "Park Pass", "Day", 12.5D, 7.5D)

        'Used as shortcut names to access the data
        Dim featId As String = cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain.Text
        Dim price As Decimal = tempFeat.adultPrice
        Dim newQty As String = txtNewQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text
        Dim remainQty As String = txtRemQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text
        Dim decNewQty As Decimal
        Dim decRemainQty As Decimal = 0D

        'Validate all the fields
        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please select a Passbook Feature Id from the list", MsgBoxStyle.OkOnly)
            cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(newQty, decNewQty) Or decNewQty <= 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity > 0 (ex: 3)", MsgBoxStyle.OkOnly)
            txtNewQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtNewQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Calculate total price - based on age 
        Dim totPurchPrice As Decimal
        Dim unitPurchPrice As Decimal

        If tempPassbk.visIsChild = True Then
            unitPurchPrice = tempFeat.childPrice
        Else
            unitPurchPrice = tempFeat.adultPrice
        End If

        totPurchPrice = unitPurchPrice * decNewQty

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To update the following Passbook Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                            & "--> PassbookFeatureId=" & featId & vbCrLf _
                            & "--> NewQuantity=" & decNewQty.ToString & vbCrLf _
                            & "--> UnitPrice=" & unitPurchPrice.ToString & vbCrLf _
                            & "--> RemainQuantity=" & decRemainQty.ToString & vbCrLf _
                            & "--> Price=" & price.ToString & vbCrLf,
                            MsgBoxStyle.OkCancel
                            )
        End If

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok And _sysTestActive = False Then
            'Create a new Passbook Feature
            _theThemePark.updtPassbkFeat(featId, _
                                         totPurchPrice, _
                                         tempFeat, _
                                         tempPassbk, _
                                         decNewQty, _
                                         decRemainQty
                                         )

            _writeTransLog("<UPDATED>: " & newPassbkFeat.ToString())
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook Feature update submission was successful!", MsgBoxStyle.OkOnly)

            'Reset the fields and focus to allow for another feature to be added
            _resetPassbkUpdtFeatInput()
        End If
    End Sub '_btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click(...)

    '******************************************************************
    '_resetPassbkFeatUpdtInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    '******************************************************************
    Private Sub _resetPassbkUpdtFeatInput()
        'Reset the fields and focus to allow for another feature to be added
        cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtCustToStringGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtVisToStringGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtFeatToStringGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
    End Sub '_resetPassbkAddInput()

    '******************************************************************
    '_btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain() is the event procedure that gets called 
    'when the user clicks on the Reset button from the 'Passbook Features | Update' tab. It clears all input
    'fields to allow the user to reenter the data from scratch.
    '******************************************************************
    Private Sub _btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain.Click

        'Reset the fields and focus to allow for another passbook feature update
        _resetPassbkUpdtFeatInput()
    End Sub '_btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain(...)


    '******************************************************************
    '_btnSubmitTabPostFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets called when the user
    'clicks on the Submit button from the Post Used Feature tab.  It validates and then submits the data
    'to post a used customer passbook feature.
    '******************************************************************
    Private Sub _btnSubmitTabPostFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                    e As EventArgs) _
        Handles btnSubmitTabPostFeatTbcPassbkFeatMainTbcMain.Click

        'Local variables
        Dim newUsedFeat As UsedFeature = Nothing

        'Temporary for Phase 2 requirements
        Dim tempCust As Customer = New Customer("0001", "Doe, John")
        Dim tempPassbk As Passbook = New Passbook("0001", tempCust, DateTime.Now, "Doe, James",
                                                 #2/21/2005#, 10, True)
        Dim tempFeat As Feature = New Feature("0001", "Park Pass", "Day", 12.5D, 7.5D)
        Dim tempPassbkFeat As PassbookFeature = New PassbookFeature("0001", 12.5D, tempFeat, tempPassbk, 5, 3)

        'Used as shortcut names to access the data
        Dim featId As String = cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text
        Dim qtyUsed As String = txtQtyUsedGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text
        Dim loc As String = txtLocGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text
        Dim decQtyUsed As Decimal
        Dim decQtyRemain As Decimal = 0D

        'Validate all the fields
        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please select a Passbook Feature Id from the list", MsgBoxStyle.OkOnly)
            cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(qtyUsed, decQtyUsed) Or decQtyUsed <= 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity > 0 (ex: 3)", MsgBoxStyle.OkOnly)
            txtQtyUsedGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectAll()
            txtQtyUsedGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(loc) Then
            MsgBox("ERROR: Please specify the location where feature was used", MsgBoxStyle.OkOnly)
            txtLocGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
            txtLocGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
            Exit Sub
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult

        choice = MsgBox("To post the following Used Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                        & "--> PassbookFeatureId=" & featId & vbCrLf _
                        & "--> QtyUsed=" & decQtyUsed.ToString & vbCrLf _
                        & "--> QtyRemain=" & decQtyRemain.ToString & vbCrLf _
                        & "--> Location=" & loc & vbCrLf,
                        MsgBoxStyle.OkCancel
                        )

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok Then
            'Create a new Used Feature
            newUsedFeat = _theThemePark.usedFeat("NOTUSED??", tempPassbkFeat, DateTime.Now, decQtyUsed, loc)

            _writeTransLog("<POST>: " & newUsedFeat.ToString())
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Used Passbook Feature submission was successful!", MsgBoxStyle.OkOnly)

            'Reset the fields and focus to allow for another feature to be added
            cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()
            cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
            txtNewQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        End If
    End Sub '_btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click(...)

    '******************************************************************
    '_resetPassbkPostFeatInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    '******************************************************************
    Private Sub _resetPassbkPostFeatInput()
        'Reset the fields and focus to allow for another feature to be added
        cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtCustToStringTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtVisToStringGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtFeatToStringGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtPrevUsedGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtRemQuantTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtQtyUsedGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtLocGrpPassbkTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
    End Sub '_resetPassbkPostFeatInput()

    '******************************************************************
    '_btnResetTabPostFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets called 
    'when the user clicks on the Reset button from the 'Passbook Features | Post' tab. It clears all input
    'fields to allow the user to reenter the data from scratch.
    '******************************************************************
    Private Sub _btnResetTabPostFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain.Click

        'Reset the fields and focus to allow for another passbook featurd addition
        _resetPassbkPostFeatInput()
    End Sub '_btnPostTabUpdtFeatTbcPassbkFeatMainTbcMain(...)


    '******************************************************************
    '_btnClearTabTransLogTbcMainFrmMain_Click() is the event procedure that gets called when the user
    'clicks on the Clear button from the Tranaaction log tab.  It clears the log.
    '******************************************************************
    Private Sub _btnClearTabTransLogTbcMainFrmMain_Click(sender As Object, _
                                                         e As EventArgs) _
        Handles btnClearTabTransLogTbcMainFrmMain.Click

        'Reset the transaction log
        txtTransLogTabTransLogTbcMainFrmMain.Text = ""
    End Sub '_btnClearTabTransLogTbcMainFrmMain_Click(...)

    '******************************************************************
    '_tbcMainFrmMain_SelectedIndexChanged() is used to set control attribute when specific
    'tab on the UI are selected.  This is form the main program tab control.
    '******************************************************************
    Private Sub _tbcMainFrmMain_SelectedIndexChanged(sender As Object, _
                                                     e As EventArgs) _
        Handles tbcMainFrmMain.SelectedIndexChanged

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
                cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()

            Case mTBC_MAIN_TAB_PASSBKFEAT
                Console.WriteLine("Passbook Feature Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain

                'Set the focus to the first input field
                cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_MAIN_TAB_TRANSLOG
                Console.WriteLine("Transaction Log Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnClearTabTransLogTbcMainFrmMain

                'Push the caret to the end of the log file
                _txtTransLogTabTransLogTbcMainFrmMain_TextChanged(Me, Nothing)

            Case mTBC_MAIN_TAB_SYSTEST
                Console.WriteLine("System Test Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain
        End Select
    End Sub 'tbcMainFrmMain_SelectedIndexChanged(...)

    '******************************************************************
    '_tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged() is used to set 
    'control attribute when specific tab on the UI are selected.  This is for the 
    'Passboo Feature tab control.
    '******************************************************************
    Private Sub _tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(sender As Object, _
                                                                                   e As EventArgs) _
        Handles tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndexChanged

        Console.WriteLine("Calling Passbook Feature tab control")

        Select Case tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndex
            Case mTBC_PASSBKFEAT_TAB_ADD
                Console.WriteLine("Add Tab")

                'Set the focus to the first input field
                cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_UPDT
                Console.WriteLine("Update Tab")

                'Set the focus to the first input field
                cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_POST
                Console.WriteLine("Post Tab")

                'Set the focus to the first input field
                cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
        End Select
    End Sub '_tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(...)

    '******************************************************************
    '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click() is the event procedure that gets called when 
    'the user clicks on the 'Process Test Data' button from the System Test tab.  It automates testing of 
    'existing functionality of the system.  Results are output in the transaction log.
    '******************************************************************
    Private Sub _btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(sender As Object, _
                                                                         e As EventArgs) _
        Handles btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain.Click

        'Execute the system test procedure
        _runSystemTest()
    End Sub '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(...)

    '******************************************************************
    '_mnuTransLogViewFrmMain_Click() is the event procedure that gets called when the user selects
    '"View -> Transaction Log' from the main menu.  It will automically switch the UI to the
    'Transaction log tab.
    '******************************************************************
    Private Sub _mnuTransLogViewFrmMain_Click(sender As Object, _
                                              e As EventArgs) _
        Handles mnuTransLogViewFrmMain.Click

        'Switch UI directly to the Transaction log tab
        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_TRANSLOG)
    End Sub '_mnuTransLogViewFrmMain_Click(...)

    '******************************************************************
    '_mnuTransLogViewFrmMain_Click() is the event procedure that gets called when the user selects
    '"View -> Dashboard from the main menu.  It will automically switch the UI to the
    'Dashboard tab.
    '******************************************************************
    Private Sub _mnuDashboardViewFrmMain_Click(sender As Object, _
                                               e As EventArgs) _
        Handles mnuDashboardViewFrmMain.Click

        'Switch UI directly to the Dashboard tab
        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_DASHBOARD)
    End Sub '_mnuDashboardViewFrmMain_Click(...)

    '******************************************************************
    '_mnuRunSysTestTestFrmMain_Click() is the event procedure that gets called when the user selects
    '"Test -> Run System Test' from the main menu.  It will initiate the automated test procedure.
    '******************************************************************
    Private Sub _mnuRunSysTestTestFrmMain_Click(sender As Object, _
                                                e As EventArgs) _
        Handles mnuRunSysTestTestFrmMain.Click

        'Execute the system test procedure
        _runSystemTest()
    End Sub '_mnuRunSysTestTestFrmMain_Click(...)

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '******************************************************************
    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    '******************************************************************
    Private Sub _frmMain_Load(sender As Object, _
                              e As EventArgs) _
        Handles MyBase.Load

        'Initalize tool tips for specific controls
        _initializeToolTips()

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()
    End Sub '_frmMain_Load(...)

    '******************************************************************
    '_txtTransLogTabTransLogTbcMainFrmMain_TextChanged() is the event procedure the is called when
    'the transaction log text box is modified.  Basically it enables the display text to scroll.
    '******************************************************************
    Private Sub _txtTransLogTabTransLogTbcMainFrmMain_TextChanged(sender As Object, _
                                                                  e As EventArgs) _
        Handles txtTransLogTabTransLogTbcMainFrmMain.TextChanged

        txtTransLogTabTransLogTbcMainFrmMain.SelectionStart = _
            txtTransLogTabTransLogTbcMainFrmMain.TextLength
        txtTransLogTabTransLogTbcMainFrmMain.ScrollToCaret()
    End Sub '_txtTransLogTabTransLogTbcMainFrmMain_TextChanged(...)


    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

    '******************************************************************
    '_createCust() handles processing for the  ThemePark_CreateCust
    ' event that is generated when a new customer is added to the
    'system.
    '******************************************************************
    Private Sub _createCust(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_CreateCust

        'Declare variables
        Dim themePark_EventArgs_CreateCust As ThemePark_EventArgs_CreateCust
        Dim cust As Customer

        'Get/validate data
        themePark_EventArgs_CreateCust = CType(e, ThemePark_EventArgs_CreateCust)

        'Use the past in object to populate the necessary system components
        cust = themePark_EventArgs_CreateCust.cust

        With cust
            lstCustTabDashboardTbcMain.Items.Add(.custId)
            txtCustCntTabDashboardTbcMain.Text = _
                lstCustTabDashboardTbcMain.Items.Count.ToString

            cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Items.Add(.custId)
        End With

        _writeTransLog("<CREATED>: " & cust.ToString())
        _writeTransLog("<STATUS>: " & _theThemePark.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            MsgBox("Customer creation submission was successful!", MsgBoxStyle.OkOnly)
        End If

    End Sub '_createCust(...)


    '******************************************************************
    '_createFeat() handles processing for the ThemePark_CreateFeat
    ' event that is generated when a new Feature is added to the
    'system.
    '******************************************************************
    Private Sub _createFeature(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_CreateFeat

        'Declare variables
        Dim themePark_EventArgs_CreateFeat As ThemePark_EventArgs_CreateFeat
        Dim feat As Feature

        'Get/validate data
        themePark_EventArgs_CreateFeat = CType(e, ThemePark_EventArgs_CreateFeat)

        'Use the past in object to populate the necessary system components
        feat = themePark_EventArgs_CreateFeat.feat

        With feat
            lstFeatTabDashboardTbcMain.Items.Add(.featId)
            txtFeatCntTabDashboardTbcMain.Text = _
                lstFeatTabDashboardTbcMain.Items.Count.ToString

            cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain.Items.Add(.featId)
        End With

        _writeTransLog("<CREATED>: " & feat.ToString())
        _writeTransLog("<STATUS>: " & _theThemePark.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            MsgBox("Feature creation submission was successful!", MsgBoxStyle.OkOnly)
        End If

    End Sub '_createFeat(...)

    '******************************************************************
    '_createPassbook() handles processing for the ThemePark_CreatePassbook
    ' event that is generated when a new passbook is added to the
    'system.
    '******************************************************************
    Private Sub _createPassbook(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_CreatePassbk

        'Declare variables
        Dim themePark_EventArgs_CreatePassbk As ThemePark_EventArgs_CreatePassbk
        Dim passbook As Passbook

        'Get/validate data
        themePark_EventArgs_CreatePassbk = CType(e, ThemePark_EventArgs_CreatePassbk)

        'Use the past in object to populate the necessary system components
        passbook = themePark_EventArgs_CreatePassbk.passbook

        With passbook
            lstPassbkTabDashboardTbcMain.Items.Add(.passbkId)
            txtPassbkCntTabDashboardTbcMain.Text =
                lstPassbkTabDashboardTbcMain.Items.Count.ToString

            cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Items.Add(.passbkId)
        End With

        _writeTransLog("<CREATED>: " & passbook.ToString())
        _writeTransLog("<STATUS>: " & _theThemePark.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            MsgBox("Passbook creation submission was successful!", MsgBoxStyle.OkOnly)
        End If

    End Sub '_createPassbook(...)

    '******************************************************************
    '_addPassbkFeat() handles processing for the ThemePark_PurchFeat
    ' event that is generated when a feature has been purchased fo
    'a specified passbook
    '******************************************************************
    Private Sub _addPassbkFeat(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_AddPassbkFeat

        'Declare variables
        Dim themePark_EventArgs_PurchFeat As ThemePark_EventArgs_AddPassbkFeat
        Dim passbkFeat As PassbookFeature

        'Get/validate data
        themePark_EventArgs_PurchFeat = CType(e, ThemePark_EventArgs_AddPassbkFeat)

        'Use the past in object to populate the necessary system components
        passbkFeat = themePark_EventArgs_PurchFeat.passbkFeat

        With passbkFeat
            lstPassbkFeatTabDashboardTbcMain.Items.Add(.id)
            txtPassbkFeatCntTabDashboardTbcMain.Text =
                lstPassbkFeatTabDashboardTbcMain.Items.Count.ToString()

            cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain.Items.Add(.id)
            cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain.Items.Add(.id)
        End With

        _writeTransLog("<PURCHASED>: " & passbkFeat.ToString())
        _writeTransLog("<STATUS>: " & _theThemePark.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            MsgBox("Passbook Feature submission was successful!", MsgBoxStyle.OkOnly)
        End If

    End Sub '_addPassbkFeat(...)

    '******************************************************************
    '_updtPassbkFeat() handles processing for the ThemePark_UpdtPassbkFeat
    ' event that is generated when a passbook feature is updated
    '******************************************************************
    Private Sub _updtPassbkFeat(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_UpdtPassbkFeat

        'Declare variables
        Dim themePark_EventArgs_UpdtPassbkFeat As ThemePark_EventArgs_UpdtPassbkFeat
        Dim passbkFeat As PassbookFeature

        'Get/validate data
        themePark_EventArgs_UpdtPassbkFeat = CType(e, ThemePark_EventArgs_UpdtPassbkFeat)

        'Use the past in object to populate the necessary system components
        passbkFeat = ThemePark_EventArgs_UpdtPassbkFeat.passbkFeat

        With passbkFeat
            '            lstPassbkFeatTabDashboardTbcMain.Items.Add(.id)
            '            lstPassbkTabDashboardTbcMain.Items.Add(.id)

            '           txtPassbkFeatCntTabDashboardTbcMain.Text =
            'lstPassbkTabDashboardTbcMain.Items.Count.ToString()
        End With

        _writeTransLog("<UPDATED>: " & passbkFeat.ToString())
        _writeTransLog("<STATUS>: " & _theThemePark.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            MsgBox("Passbook Feature purchase submission was successful!", MsgBoxStyle.OkOnly)
        End If

    End Sub '_updtPassbkFeat(...)


#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'FrmMain