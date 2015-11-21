'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Managament System  
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
'               11/20/2015
'                   - Modifications to support the fourth phase of
'                   course project (Proj04)
'
'Tier:          User Interface     
'Exceptions:           N/A
'Exception-Handling:   N/A
'Events:               N/A
'Event-Handling:       N/A
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On    'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class FrmMain

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************
    'System level error message
    Private Const mSYS_ERR_MSG As String = "Internal System Error: Object Creation Failed"
    Private Const mSYS_LOOKUP_ERR_MSG As String = "Internal System Error: Object Lookup Failed"

    '********** Module-level constants
    'Theme Park Name
    Private Const mTHEME_PARK_NAME As String = "CIS605 Theme Park"

    'Minimum age to be considered an adult. Less than this age is 
    'thusly considered a child
    Private Const mADULT_MIN_AGE As Integer = (13)

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
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

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
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

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
    '****************************************************************************************
    'Behavioral Methods
    '****************************************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    '********** Private Non-Shared Behavioral Methods

    '****************************************************************************************
    '_closeAppl() is used to simply close the application when
    'requested.
    '****************************************************************************************
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

    '****************************************************************************************
    'findCust() is used to locate a customer by ID from the ThemePark customer database.  
    'Returns a customer reference if found, otherwise Nothing.  
    'If exception is caught display a UI message and return Nothing
    '****************************************************************************************
    Private Function _findCust(ByVal pCustId As String) As Customer
        Dim cust As Customer = Nothing

        Try
            cust = _theThemePark.findCust(pCustId)
        Catch ex As Exception
            MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
        End Try

        Return cust
    End Function '_findCust(...)

    '****************************************************************************************
    '_runSystemTest() is the procedure that executes the applications automated test logic.
    'It is invoked either from the main UI menu or from the System Test tab.
    '****************************************************************************************
    Private Sub _runSystemTest(ByVal showMsgBox As Boolean)
        'Indicate to that the system test is running
        _sysTestActive = True

        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: PROCESSING STARTED]")
        _writeTransLog(Nothing)

        '**** Test Theme Park creation ****

        'Use a temporary local theme park object if the associated check box has been
        'checked, otherwise use the system theme park object
        Dim themePark As ThemePark

        If chkUseTestParkGrpSysTestTabSysTestTbcMainFrmMain.CheckState = CheckState.Checked Then
            themePark = New ThemePark("PALUMBO Test Theme Park")
            _writeTransLog("[ThemePark]: successfully created ==> " & themePark.ToString())
        Else
            themePark = Me._theThemePark
            _writeTransLog("[ThemePark]: using System Theme Park ==> " & themePark.ToString())
        End If


        '**** Test Feature creation ****
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: CREATE FEATURES]")
        _writeTransLog(Nothing)

        Dim f01 As Feature = New Feature("F01", "Park Pass", "Day", 100D, 80D)
        Dim f02 As Feature = New Feature("F02", "Early Entry Pass", "Day", 10D, 5D)
        Dim f03 As Feature = New Feature("F03", "Meal Plan", "Meal", 30D, 20D)

        themePark.createFeat(f01.featId, f01.featName, f01.unitOfMeas, f01.adultPrice, f01.childPrice)
        themePark.createFeat(f02.featId, f02.featName, f02.unitOfMeas, f02.adultPrice, f02.childPrice)
        themePark.createFeat(f03.featId, f03.featName, f03.unitOfMeas, f03.adultPrice, f03.childPrice)

        _writeTransLog(Nothing)
        _writeTransLog("<CURRENT-PARK-STATUS>: " & themePark.ToString)


        '**** Test Customer creation ****
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: CREATE CUSTOMERS]")
        _writeTransLog(Nothing)

        Dim c01 As Customer = New Customer("C01", "CName01")
        Dim c02 As Customer = New Customer("C02", "CName02")
        Dim c03 As Customer = New Customer("C03", "Customer Name 03")

        themePark.createCust(c01.custId, c01.custName)
        themePark.createCust(c02.custId, c02.custName)
        themePark.createCust(c03.custId, c03.custName)

        _writeTransLog(Nothing)
        _writeTransLog("<CURRENT-PARK-STATUS>: " & themePark.ToString)


        '**** Test Passbook creation ****
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: CREATE PASSBOOKS]")
        _writeTransLog(Nothing)

        Dim pb01 As Passbook = New Passbook("PB01", c01, #9/15/2015#, "self", #1/1/1980#, 35, False)
        Dim pb02 As Passbook = New Passbook("PB02", c02, #9/16/2015#, "self", #6/1/1985#, 30, False)
        Dim pb03 As Passbook = New Passbook("PB03", c02, #9/17/2015#, "CO2 Visitor", #12/1/2003#, 12, True)
        Dim pb04 As Passbook = New Passbook("PB04", c03, #8/15/2015#, "self", #1/1/1975#, 40, False)
        Dim pb05 As Passbook = New Passbook("PB05", c03, #9/15/2015#, "CO3 Visitor 1", #10/7/2002#, 13, False)
        Dim pb06 As Passbook = New Passbook("PB06", c03, #10/15/2015#, "CO3 Visitor 2", #10/8/2002#, 13, False)

        themePark.createPassbk(pb01.passbkId, pb01.owner, pb01.datePurch, _
                               pb01.visName, pb01.visDob, pb01.visAge, pb01.visIsChild)
        themePark.createPassbk(pb02.passbkId, pb02.owner, pb02.datePurch, _
                               pb02.visName, pb02.visDob, pb02.visAge, pb02.visIsChild)
        themePark.createPassbk(pb03.passbkId, pb03.owner, pb03.datePurch, _
                               pb03.visName, pb03.visDob, pb03.visAge, pb03.visIsChild)
        themePark.createPassbk(pb04.passbkId, pb04.owner, pb04.datePurch, _
                               pb04.visName, pb04.visDob, pb04.visAge, pb04.visIsChild)
        themePark.createPassbk(pb05.passbkId, pb05.owner, pb05.datePurch, _
                               pb05.visName, pb05.visDob, pb05.visAge, pb05.visIsChild)
        themePark.createPassbk(pb06.passbkId, pb06.owner, pb06.datePurch, _
                               pb06.visName, pb06.visDob, pb06.visAge, pb06.visIsChild)

        _writeTransLog(Nothing)
        _writeTransLog("<CURRENT-PARK-STATUS>: " & themePark.ToString)


        '**** Test Passbook Feature purchase ****'
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: PURCHASE FEATURE]")
        _writeTransLog(Nothing)


        Dim pbf01 As PassbookFeature = New PassbookFeature("PBF01", f01, pb01, 1)
        Dim pbf02 As PassbookFeature = New PassbookFeature("PBF02", f01, pb02, 2)
        Dim pbf03 As PassbookFeature = New PassbookFeature("PBF03", f01, pb03, 3)
        Dim pbf04 As PassbookFeature = New PassbookFeature("PBF04", f01, pb04, 1)
        Dim pbf05 As PassbookFeature = New PassbookFeature("PBF05", f01, pb05, 1)
        Dim pbf06 As PassbookFeature = New PassbookFeature("PBF06", f01, pb06, 1)
        Dim pbf07 As PassbookFeature = New PassbookFeature("PBF07", f02, pb03, 3)
        Dim pbf08 As PassbookFeature = New PassbookFeature("PBF08", f03, pb03, 9)
        Dim pbf09 As PassbookFeature = New PassbookFeature("PBF09", f01, pb04, 1)
        Dim pbf10 As PassbookFeature = New PassbookFeature("PBF10", f01, pb04, 3)

        themePark.addPassbkFeat(pbf01.id, pbf01.feature, pbf01.passbk, pbf01.qtyPurch)
        themePark.addPassbkFeat(pbf02.id, pbf02.feature, pbf02.passbk, pbf02.qtyPurch)
        themePark.addPassbkFeat(pbf03.id, pbf03.feature, pbf03.passbk, pbf03.qtyPurch)
        themePark.addPassbkFeat(pbf04.id, pbf04.feature, pbf04.passbk, pbf04.qtyPurch)
        themePark.addPassbkFeat(pbf05.id, pbf05.feature, pbf05.passbk, pbf05.qtyPurch)
        themePark.addPassbkFeat(pbf06.id, pbf06.feature, pbf06.passbk, pbf06.qtyPurch)
        themePark.addPassbkFeat(pbf07.id, pbf07.feature, pbf07.passbk, pbf07.qtyPurch)
        themePark.addPassbkFeat(pbf08.id, pbf08.feature, pbf08.passbk, pbf08.qtyPurch)
        themePark.addPassbkFeat(pbf09.id, pbf09.feature, pbf09.passbk, pbf09.qtyPurch)
        themePark.addPassbkFeat(pbf10.id, pbf10.feature, pbf10.passbk, pbf10.qtyPurch)

        _writeTransLog(Nothing)
        _writeTransLog("<CURRENT-PARK-STATUS>: " & themePark.ToString)


        '**** Test Use Passbook Feature ****'
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: USE PASSBOOK FEATURE]")
        _writeTransLog(Nothing)

        themePark.usedFeat("UF01", pbf01, #10/20/2015#, 1, "Epcot Center")
        themePark.usedFeat("UF02", pbf02, #10/20/2015#, 1, "West Parking")
        themePark.usedFeat("UF03", pbf03, #10/20/2015#, 2, "France")
        themePark.usedFeat("UF04", pbf03, #10/20/2015#, 1, "American Pavillion")

        _writeTransLog(Nothing)
        _writeTransLog("<CURRENT-PARK-STATUS>: " & themePark.ToString)


        '**** Test Update Passbook Feature ****'
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: UPDATE PASSBOOK FEATURE")
        _writeTransLog(Nothing)

        themePark.updtPassbkFeat(pbf03.id, 1)

        '**** System Test Completed ****'
        _writeTransLog(Nothing)
        _writeTransLog("[TEST PROCESSING COMPLETED]")
        _writeTransLog(Nothing)

        If (showMsgBox = True) Then
            MsgBox("Test Processing completed.  Click to view the transaction", MsgBoxStyle.OkOnly)

            'Switch UI directly to the Transaction log tab
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_TRANSLOG)
        End If

        'Indicate the system test has completed
        _sysTestActive = False
    End Sub '_runSystemTest()

    '****************************************************************************************
    '_writeTransLog() procedure does all the work to write a 
    'message to the transaction log.hat write the specified string to 
    'the transaction log.
    '****************************************************************************************
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

    '****************************************************************************************
    '_initializeBusinessLogic() is used to initialize the program business
    'data/logic to a known good starting state.
    '****************************************************************************************
    Private Sub _initializeBusinessLogic()
        'Create a theme park instance
        _theThemePark = New ThemePark(mTHEME_PARK_NAME)

        If _theThemePark Is Nothing Then
            MsgBox(mSYS_ERR_MSG & ", Theme Park could not be instantiated")

            'Terminate the program
            _closeAppl()
        End If

        _writeTransLog("<CREATED>: " & _theThemePark.ToString())

        'Run the system test to populate with hard coded data 
        _runSystemTest(False)
    End Sub '_initializeBusinessLogic()

    '****************************************************************************************
    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    '****************************************************************************************
    Private Sub _initializeUserInterface()
        'Assign CancelButton to the form based buttons so the 'Esc'
        'key will activate the exit functionality when on the main form. 
        Me.CancelButton = btnExitFrmMain

        'Center the main form on the display
        Me.StartPosition = FormStartPosition.CenterScreen

        lblThemeParkMgmtSysFrmMain.Text = _theThemePark.themeParkName
        Me.Text = _theThemePark.themeParkName
    End Sub 'initializeUserInterface()


    '****************************************************************************************
    '_calcAge() is used to calculate the age in years for a visitor being added to a 
    'passbook purchase - age is calculate relative to the current system time (i.e. Now)
    '****************************************************************************************
    Private Function _calcAge(ByVal pVisDoB As Date) As Integer
        Dim age As Integer = 0
        Dim dateNow As Date = Now

        'Need to compensate for DoB in the current year 
        Dim dobYear As Integer = pVisDoB.Year
        Dim nowYear As Integer = Now.Year

        age = nowYear - dobYear
        If pVisDoB.AddYears(age) > dateNow Then
            age -= 1
        End If

        Return age
    End Function '_calcAge(...)


#End Region 'Behavioral Methods

#Region "Event Procedures"
    '****************************************************************************************
    'Event Procedures
    '****************************************************************************************

    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '****************************************************************************************
    '_btnExitFrmMain_Click() is the event procedure that gets called when
    'the user clicks on the Exit button or by using Alt-E hot key sequence.
    'It is used to notify the user and formally terminate the program.
    '****************************************************************************************
    Private Sub _btnExitFrmMain_Click(sender As Object, _
                                      e As EventArgs) _
        Handles btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()
    End Sub '_btnExitFrmMain_Click(...)

    '****************************************************************************************
    '_mnuFileExit() is the event procedure that gets called when the user selects
    'File->Exit from the main menu.
    '****************************************************************************************
    Private Sub _mnuExitFileFrmMain_Click(sender As Object, _
                                          e As EventArgs) _
        Handles mnuExitFileFrmMain.Click

        'Program terminated from main menu selection
        _closeAppl()
    End Sub '_mnuExitFileFrmMain_Click(...) 

    '****************************************************************************************
    '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Customer tab. It validates and then
    'submits the data to create a new customer.
    '****************************************************************************************
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

            'Create a new customer. It will be persistent within the ThemePark object.
            'But need to trap any insertion acceptions which could happen based on 
            'the state of the system
            Try
                _theThemePark.createCust(custId, custName)
            Catch ex As Exception
                MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Exclamation)
            End Try

            'Reset the input fields to allow for another possible customer entry
            _resetCustomerInput()
        End If
    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '****************************************************************************************
    '_resetCustomerInput() is used to reset all the customer input fields to allow the user 
    'to start over with input.
    '****************************************************************************************
    Private Sub _resetCustomerInput()
        'Reset the fields and focus to allow for another feature to be added
        txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text = ""
        txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text = ""

        txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
    End Sub '_resetCustomerInput()

    '****************************************************************************************
    '_btnResetGrpCustInfoTabCustTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    '****************************************************************************************
    Private Sub _btnResetGrpCustInfoTabCustTbcMainFrmMain_Click(sender As Object, _
                                                                e As EventArgs) _
        Handles btnResetGrpCustInfoTabCustTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another feature to be added
        _resetCustomerInput()
    End Sub '_btnResetGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '****************************************************************************************
    '_btnSubmitGrpAddFeatTabFeatTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Feature tab. It validates and then
    'submits the data to create a new feature.
    '****************************************************************************************
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
        If decAdultPrice <= 0 Then
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
        If decChildPrice < 0 Then
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
            'Create a new feature. It will be persistent within the ThemePark object.
            'But need to trap any insertion acceptions which could happen based on 
            'the state of the system
            Try
                _theThemePark.createFeat(featId, _
                                         featName, _
                                         unitOfMeas, _
                                         decAdultPrice, _
                                         decChildPrice
                                         )
            Catch ex As Exception
                MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Exclamation)
            End Try

            'Reset the input fields to allow for another possible feature entry
            _resetFeatureInput()
        End If

    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

    '****************************************************************************************
    '_resetFeatureInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    '****************************************************************************************
    Private Sub _resetFeatureInput()
        'Reset the fields and focus to allow for another feature to be added
        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
        txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = ""

        txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
    End Sub '_resetFeatureInput()

    '****************************************************************************************
    '_btnResetGrpAddFeatTabFeatTbcMainFrmMain() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    '****************************************************************************************
    Private Sub _btnResetGrpAddFeatTabFeatTbcMainFrmMain_Click(sender As Object, _
                                                               e As EventArgs) _
        Handles btnResetGrpAddFeatTabFeatTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another feature to be added
        _resetFeatureInput()
    End Sub '_btnResetGrpAddFeatTabFeatTbcMainFrmMain(...)

    '****************************************************************************************
    '_btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Passbook tab. It validates and then
    'submits the data to create a new passbook.
    '****************************************************************************************
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
        If custList.Items.Count = 0 Then
            MsgBox("ERROR: There are no Customers defined, please add a Customer", MsgBoxStyle.OkOnly)
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_CUSTOMER)
            Exit Sub
        End If

        If String.IsNullOrEmpty(custList.Text) Then
            MsgBox("ERROR: Please seleect a Customer Id from the list", MsgBoxStyle.OkOnly)
            cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
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

        'Validate the visitor date of birth - can't be in the future, child is < 13yo
        Dim datePurch As Date = DateTime.Now

        If DateTime.Compare(visDobValue, datePurch) > 0 Then
            MsgBox("ERROR: Visitor DOB is in the future, please re-enter date", MsgBoxStyle.OkOnly)
            txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Determine if the visitor is a child (< 13 years old)
        Dim visAge As Integer = _calcAge(visDobValue)
        Dim visIsChild As Boolean = visAge < mADULT_MIN_AGE

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

            'Create a new passbook. It will be persistent within the ThemePark object.
            'But need to trap any insertion acceptions which could happen based on 
            'the state of the system
            Try
                _theThemePark.createPassbk(passbkId, _
                                           tempCust, _
                                           datePurch, _
                                           visName, _
                                           visDobValue, _
                                           visAge, _
                                           visIsChild
                                           )
            Catch ex As Exception
                MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Exclamation)
            End Try

            'Reset the input fields to allow for another possible feature entry
            _resetPassbkInput()
        End If
    End Sub '_btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click(...)

    '****************************************************************************************
    '_resetPassbkInput() is used to reset all the feature input fields to allow the user 
    'to start over with input.
    '****************************************************************************************
    Private Sub _resetPassbkInput()
        'Reset the fields and focus to allow for another feature to be added
        cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.SelectedIndex = -1

        txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtToStringGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""

        txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
    End Sub '_resetPassbkInput()

    '****************************************************************************************
    'btnResetGrpAddFeatTabFeatTbcMainFrmMain() is the event procedure that gets called 
    'when the user click on the Reset button from the Customer tab. It clears all input fields
    'to allow the user to reenter the data from scratch.
    '****************************************************************************************
    Private Sub _btnResetGrpAddPassbkTabPassbkTbcMainFrmMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnResetGrpAddPassbkTabPassbkTbcMainFrmMain.Click

        'Reset the fields and focus to allow for another passbook to be added
        _resetPassbkInput()
    End Sub '_btnResetGrpAddPassbkTabPassbkTbcMainFrmMain_Click

    '****************************************************************************************
    '_btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Submit button from the Add Passbook Feature tab.  
    'It validates and then submits the data to add a purchased feature to a customer passbook.
    '****************************************************************************************
    Private Sub _btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain.Click

        'Temporary for Phase 2 requirements
        Dim tempCust As Customer = New Customer("0001", "Doe, John")
        Dim tempPassbk As Passbook = New Passbook("0001", tempCust, DateTime.Now, "Doe, James",
                                                  #2/21/2005#, 10, True)
        Dim tempFeat As Feature = New Feature("0001", "Park Pass", "Day", 12.5D, 7.5D)

        'Used as shortcut names to access the data
        Dim passbkFeatId As String = txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim passbkId As String = cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim featId As String = cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim qtyPurch As String = txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text
        Dim decQtyPurch As Decimal
        Dim decQtyRemain As Decimal = 0D

        'Validate all the fields
        If cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Items.Count = 0 Then
            MsgBox("ERROR: There are no Passbooks defined, please add a Passbook", MsgBoxStyle.OkOnly)
            cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBK)
            Exit Sub
        End If

        If String.IsNullOrEmpty(passbkId) Then
            MsgBox("ERROR: Please select a Passbook Id from the list", MsgBoxStyle.OkOnly)
            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Items.Count = 0 Then
            MsgBox("ERROR: There are no Features defined, please add a Feature", MsgBoxStyle.OkOnly)
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_FEATURE)
            Exit Sub
        End If

        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please select a Feature Id from the list", MsgBoxStyle.OkOnly)
            cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
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
            'Create a new passbook feature. It will be persistent within the ThemePark object.
            'But need to trap any insertion acceptions which could happen based on 
            'the state of the system
            Try
                'Create a new Passbook Feature
                _theThemePark.addPassbkFeat(passbkFeatId, _
                                            tempFeat, _
                                            tempPassbk, _
                                            decQtyPurch
                                            )
            Catch ex As Exception
                MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Exclamation)
            End Try

            'Reset the fields and focus to allow for another feature to be added
            _resetPassbkAddFeatInput()
        End If
    End Sub '_btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click(...)

    '****************************************************************************************
    '_resetPassbkFeatAddInput() is used to reset all the feature input fields to allow the 
    'user to start over with input.
    '****************************************************************************************
    Private Sub _resetPassbkAddFeatInput()
        'Reset the fields and focus to allow for another feature to be added
        cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1
        cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1

        txtCustToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtVisToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtFeatToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""

        cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
    End Sub '_resetPassbkAddInput()

    '****************************************************************************************
    '_btnResetTabAddFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Reset button from the 'Passbook Features | Add' tab. 
    'It clears all input fields to allow the user to reenter the data from scratch.
    '****************************************************************************************
    Private Sub _btnResetTabAddFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                  e As EventArgs) _
        Handles btnResetTabAddFeatTbcPassbkFeatMainTbcMain.Click

        'Reset the fields and focus to allow for another passbook featurd addition
        _resetPassbkAddFeatInput()
    End Sub '_btnResetTabAddFeatTbcPassbkFeatMainTbcMain_Click(...)

    '****************************************************************************************
    '_btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Submit button from the Update Passbook Feature tab.  
    'It validates and then submits the data to update a customer passbook feature.
    '****************************************************************************************
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
        Dim featId As String = cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Text
        Dim price As Decimal = tempFeat.adultPrice
        Dim newQty As String = txtNewQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text
        Dim remainQty As String = txtRemQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text
        Dim decNewQty As Decimal
        Dim decRemainQty As Decimal = 0D

        'Validate all the fields
        If cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Items.Count = 0 Then
            MsgBox("ERROR: There are no Passbook Features defined, please add a Passbook Feature", MsgBoxStyle.OkOnly)
            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBKFEAT)
            tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectTab(mTBC_PASSBKFEAT_TAB_ADD)
            Exit Sub
        End If

        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please select a Passbook Feature Id from the list", MsgBoxStyle.OkOnly)
            cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()
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
                                         decNewQty
                                         )

            'Reset the fields and focus to allow for another feature to be added
            _resetPassbkUpdtFeatInput()
        End If
    End Sub '_btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click(...)

    '****************************************************************************************
    '_resetPassbkFeatUpdtInput() is used to reset all the feature input fields to allow the
    'user to start over with input.
    '****************************************************************************************
    Private Sub _resetPassbkUpdtFeatInput()
        'Reset the fields and focus to allow for another feature to be added
        cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1

        txtCustToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtVisToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtFeatToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPrevUsedToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPriceTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtRemQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtNewQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""

        cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
    End Sub '_resetPassbkAddInput()

    '****************************************************************************************
    '_btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain() is the event procedure that gets called 
    'when the user clicks on the Reset button from the 'Passbook Features | Update' tab. 
    'It clears all input fields to allow the user to reenter the data from scratch.
    '****************************************************************************************
    Private Sub _btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain.Click

        'Reset the fields and focus to allow for another passbook feature update
        _resetPassbkUpdtFeatInput()
    End Sub '_btnResetTabUpdtFeatTbcPassbkFeatMainTbcMain(...)


    '****************************************************************************************
    '_btnSubmitTabPostFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Submit button from the Post Used Feature tab.  
    'It validates and then submits the data to post a used customer passbook feature.
    '****************************************************************************************
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
        Dim tempPassbkFeat As PassbookFeature = New PassbookFeature("0001", tempFeat, tempPassbk, 5)

        'Used as shortcut names to access the data
        Dim featId As String = cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text
        Dim qtyUsed As String = txtQtyUsedTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text
        Dim loc As String = txtLocTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text
        Dim decQtyUsed As Decimal
        Dim decQtyRemain As Decimal = 0D

        'Validate all the fields
        If cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Items.Count = 0 Then
            MsgBox("ERROR: There are no Passbook Features defined, please add a Passbook Feature", MsgBoxStyle.OkOnly)
            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBKFEAT)
            tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectTab(mTBC_PASSBKFEAT_TAB_ADD)
            Exit Sub
        End If

        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please select a Passbook Feature Id from the list", MsgBoxStyle.OkOnly)
            cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(qtyUsed, decQtyUsed) Or decQtyUsed <= 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity > 0 (ex: 3)", MsgBoxStyle.OkOnly)
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectAll()
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(loc) Then
            MsgBox("ERROR: Please specify the location where feature was used", MsgBoxStyle.OkOnly)
            txtLocTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
            txtLocTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
            Exit Sub
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To post the following Used Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                            & "--> PassbookFeatureId=" & featId & vbCrLf _
                            & "--> QtyUsed=" & decQtyUsed.ToString & vbCrLf _
                            & "--> QtyRemain=" & decQtyRemain.ToString & vbCrLf _
                            & "--> Location=" & loc & vbCrLf,
                            MsgBoxStyle.OkCancel
                            )
        End If

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok And _sysTestActive = False Then
            'Create a new used feature. It will be persistent within the ThemePark object.
            'But need to trap any insertion acceptions which could happen based on 
            'the state of the system
            Try
                _theThemePark.usedFeat("PP03-NOTUSED", tempPassbkFeat, DateTime.Now, decQtyUsed, loc)
            Catch ex As Exception
                MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Exclamation)
            End Try

            'Reset the fields and focus to allow for another used feature to be submitted
            _resetPassbkUsedFeatInput()
        End If
    End Sub '_btnSubmitTabPostFeatTbcPassbkFeatMainTbcMain_Click(...)

    '****************************************************************************************
    '_resetPassbkPostFeatInput() is used to reset all the feature input fields to allow the 
    'user to start over with input.
    '****************************************************************************************
    Private Sub _resetPassbkUsedFeatInput()
        'Reset the fields and focus to allow for another feature to be added
        cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndex = -1

        txtCustToStringTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtVisToStringTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtFeatToStringTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtPrevUsedTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtRemQuantTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtQtyUsedTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""
        txtLocTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = ""

        cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
    End Sub '_resetPassbkPostFeatInput()

    '****************************************************************************************
    '_btnResetTabPostFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Reset button from the 'Passbook Features | Post' tab. 
    'It clears all input fields to allow the user to reenter the data from scratch.
    '****************************************************************************************
    Private Sub _btnResetTabPostFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                   e As EventArgs) _
        Handles btnResetTabPostFeatTbcPassbkFeatMainTbcMain.Click

        'Reset the fields and focus to allow for another passbook featurd addition
        _resetPassbkUsedFeatInput()
    End Sub '_btnPostTabUpdtFeatTbcPassbkFeatMainTbcMain(...)


    '****************************************************************************************
    '_btnClearTabTransLogTbcMainFrmMain_Click() is the event procedure that gets called when 
    'the user clicks on the Clear button from the Tranaaction log tab.  It clears the log.
    '****************************************************************************************
    Private Sub _btnClearTabTransLogTbcMainFrmMain_Click(sender As Object, _
                                                         e As EventArgs) _
        Handles btnClearTabTransLogTbcMainFrmMain.Click

        'Reset the transaction log
        txtTransLogTabTransLogTbcMainFrmMain.Text = ""
    End Sub '_btnClearTabTransLogTbcMainFrmMain_Click(...)

    '****************************************************************************************
    '_tbcMainFrmMain_SelectedIndexChanged() is used to set control attribute when specific
    'tab on the UI are selected.  This is form the main program tab control.
    '****************************************************************************************
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
                cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

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

    '****************************************************************************************
    '_tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged() is used to set 
    'control attribute when specific tab on the UI are selected.  This is for the 
    'Passboo Feature tab control.
    '****************************************************************************************
    Private Sub _tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(sender As Object, _
                                                                                   e As EventArgs) _
        Handles tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndexChanged

        Console.WriteLine("Calling Passbook Feature tab control")

        Select Case tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndex
            Case mTBC_PASSBKFEAT_TAB_ADD
                Console.WriteLine("Add Tab")

                'Set the focus to the first input field
                cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_UPDT
                Console.WriteLine("Update Tab")

                'Set the focus to the first input field
                cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_POST
                Console.WriteLine("Post Tab")

                'Set the focus to the first input field
                cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Focus()
        End Select
    End Sub '_tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click() is the event procedure that 
    'gets called when the user clicks on the 'Process Test Data' button from the System Test 
    'tab.  It automates testing of existing functionality of the system.  Results are output 
    'in the transaction log.
    '****************************************************************************************
    Private Sub _btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(sender As Object, _
                                                                         e As EventArgs) _
        Handles btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain.Click

        'Execute the system test procedure
        _runSystemTest(True)
    End Sub '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(...)

    '****************************************************************************************
    '_mnuTransLogViewFrmMain_Click() is the event procedure that gets called when the user 
    'selects"View -> Transaction Log' from the main menu.  It will automically switch the UI
    'to the Transaction log tab.
    '****************************************************************************************
    Private Sub _mnuTransLogViewFrmMain_Click(sender As Object, _
                                              e As EventArgs) _
        Handles mnuTransLogViewFrmMain.Click

        'Switch UI directly to the Transaction log tab
        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_TRANSLOG)
    End Sub '_mnuTransLogViewFrmMain_Click(...)

    '****************************************************************************************
    '_mnuTransLogViewFrmMain_Click() is the event procedure that gets called when the user 
    'selects "View -> Dashboard from the main menu.  It will automically switch the UI to the
    'Dashboard tab.
    '****************************************************************************************
    Private Sub _mnuDashboardViewFrmMain_Click(sender As Object, _
                                               e As EventArgs) _
        Handles mnuDashboardViewFrmMain.Click

        'Switch UI directly to the Dashboard tab
        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_DASHBOARD)
    End Sub '_mnuDashboardViewFrmMain_Click(...)

    '****************************************************************************************
    '_mnuRunSysTestTestFrmMain_Click() is the event procedure that gets called when the user 
    'selects "Test -> Run System Test' from the main menu.  It will initiate the automated 
    'test procedure.
    '****************************************************************************************
    Private Sub _mnuRunSysTestTestFrmMain_Click(sender As Object, _
                                                e As EventArgs) _
        Handles mnuRunSysTestTestFrmMain.Click

        'Execute the system test procedure
        _runSystemTest(True)
    End Sub '_mnuRunSysTestTestFrmMain_Click(...)

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '****************************************************************************************
    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    '****************************************************************************************
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

    '****************************************************************************************
    '_txtTransLogTabTransLogTbcMainFrmMain_TextChanged() is the event 
    'procedure the is called when the transaction log text box is 
    'modified.  Basically it enables the display text to scroll.
    '****************************************************************************************
    Private Sub _txtTransLogTabTransLogTbcMainFrmMain_TextChanged(sender As Object, _
                                                                  e As EventArgs) _
        Handles txtTransLogTabTransLogTbcMainFrmMain.TextChanged

        txtTransLogTabTransLogTbcMainFrmMain.SelectionStart = _
            txtTransLogTabTransLogTbcMainFrmMain.TextLength
        txtTransLogTabTransLogTbcMainFrmMain.ScrollToCaret()
    End Sub '_txtTransLogTabTransLogTbcMainFrmMain_TextChanged(...)

    '****************************************************************************************
    '_mnuPurchasePassbooksFrmMain_Click() is the event procedure the is 
    'called when the user selects Passbooks->Add New from the main menu.
    'It transitions the GUI to the Passbook tab.
    '****************************************************************************************
    Private Sub _mnuPurchasePassbooksFrmMain_Click(sender As Object, e As EventArgs) _
        Handles mnuPurchasePassbooksFrmMain.Click

        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBK)
    End Sub '_mnuPurchasePassbooksFrmMain_Click(...)

    '****************************************************************************************
    '_mnuAddFeaturesPassbooksFrmMain_Click() is the event procedure the 
    'is called when the user selects Passbooks->Feature->Purchase from 
    'the main menu. It transitions the GUI to the Passbook Feature 
    'Purchase tab.
    '****************************************************************************************
    Private Sub _mnuAddFeaturesPassbooksFrmMain_Click(sender As Object, e As EventArgs) _
        Handles mnuAddFeaturesPassbooksFrmMain.Click

        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBKFEAT)
        tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectTab(mTBC_PASSBKFEAT_TAB_ADD)
    End Sub '_mnuAddFeaturesPassbooksFrmMain_Click(...)

    '****************************************************************************************
    '_mnuUpdateFeaturesPassbooksFrmMain_Click() is the event procedure 
    'the is called when the user selects Passbooks->Feature->Update 
    'from the main menu. It transitions the GUI to the Passbook Feature 
    'Update tab.
    '****************************************************************************************
    Private Sub _mnuUpdateFeaturesPassbooksFrmMain_Click(sender As Object, e As EventArgs) _
        Handles mnuUpdateFeaturesPassbooksFrmMain.Click

        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBKFEAT)
        tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectTab(mTBC_PASSBKFEAT_TAB_UPDT)
    End Sub '_mnuAddFeaturesPassbooksFrmMain_Click(...)

    '****************************************************************************************
    '_mnuUseFeaturesPassbooksFrmMain_Click() is the event procedure the is called when
    'the user selects Passbooks->Feature->Post from the main menu.
    'It transitions the GUI to the Passbook Feature Post tab.
    '****************************************************************************************
    Private Sub _mnuUseFeaturesPassbooksFrmMain_Click(sender As Object, e As EventArgs) _
        Handles mnuUseFeaturesPassbooksFrmMain.Click

        tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBKFEAT)
        tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectTab(mTBC_PASSBKFEAT_TAB_POST)
    End Sub '_mnuUseFeaturesPassbooksFrmMain_Click(...)

    '****************************************************************************************
    '_lstCustTabDashboardTbcMain_SelectedIndexChanged() is the event 
    'procedure the is called when the user selects a customer from 
    'the Dashboard tab.  Customer info is displayed in the associated 
    'text field.
    '****************************************************************************************
    Private Sub _lstCustTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstCustTabDashboardTbcMain.SelectedIndexChanged

        Dim lstVal As String = lstCustTabDashboardTbcMain.SelectedItem.ToString
        Dim cust As Customer = _theThemePark.findCust(lstVal)

        If Not cust Is Nothing Then
            txtToStringTabDashboardTbcMain.Text = cust.ToString & vbCrLf
        Else
            txtToStringTabDashboardTbcMain.Text = _
                "No Customer info found for CustId=" & lstVal & vbCrLf
        End If
    End Sub '_lstCustTabDashboardTbcMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_lstFeatTabDashboardTbcMain_SelectedIndexChanged() is the event 
    'procedure the is called when the user selects a feature from the 
    'Dashboard tab.  Feature info is displayed in the associated text 
    'field.
    '****************************************************************************************
    Private Sub _lstFeatTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstFeatTabDashboardTbcMain.SelectedIndexChanged

        Dim lstVal As String = _
            lstFeatTabDashboardTbcMain.SelectedItem.ToString
        Dim feat As Feature = _theThemePark.findFeat(lstVal)

        If Not feat Is Nothing Then
            txtToStringTabDashboardTbcMain.Text = feat.ToString & vbCrLf
        Else
            txtToStringTabDashboardTbcMain.Text = _
                "No Feature info found for FeatId=" & lstVal & vbCrLf
        End If
    End Sub '_lstFeatTabDashboardTbcMain_SelectedIndexChanged

    '****************************************************************************************
    '_lstPassbkTabDashboardTbcMain_SelectedIndexChanged() is the event 
    'procedure the is called when the user selects a passbook from 
    'the Dashboard tab.  Passbook info is displayed in the associated 
    'text field.
    '****************************************************************************************
    Private Sub _lstPassbkTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstPassbkTabDashboardTbcMain.SelectedIndexChanged

        Dim lstVal As String = _
            lstPassbkTabDashboardTbcMain.SelectedItem.ToString
        Dim passbk As Passbook = _theThemePark.findPassbk(lstVal)

        If Not passbk Is Nothing Then
            txtToStringTabDashboardTbcMain.Text = passbk.ToString & vbCrLf
        Else
            txtToStringTabDashboardTbcMain.Text = _
                "No Passbook info found for FeatId=" & lstVal & vbCrLf
        End If
    End Sub '_lstPassbkTabDashboardTbcMain_SelectedIndexChanged(...)


    '****************************************************************************************
    '_lstPassbkFeatTabDashboardTbcMain_SelectedIndexChanged() is the 
    'event procedure the is called when the user selects a passbook from 
    'the Dashboard tab.  Passbook info is displayed in the associated 
    'text field.
    '****************************************************************************************
    Private Sub _lstPassbkFeatTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstPassbkFeatTabDashboardTbcMain.SelectedIndexChanged

        Dim lstVal As String = _
            lstPassbkFeatTabDashboardTbcMain.SelectedItem.ToString
        Dim passbkFeat As PassbookFeature = _theThemePark.findPassbkFeat(lstVal)

        If Not passbkFeat Is Nothing Then
            txtToStringTabDashboardTbcMain.Text = passbkFeat.ToString & vbCrLf
        Else
            txtToStringTabDashboardTbcMain.Text = _
                "No Passbook Feature info found for PassbkFeatId=" & lstVal & vbCrLf
        End If
    End Sub '_lstPassbkFeatTabDashboardTbcMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_lstUsedFeatTabDashboardTbcMain_SelectedIndexChanged() is the 
    'event procedure the is called when the user selects a used
    'feature from the Dashboard tab.  Used feature info is displayed in 
    'the associated text field.
    '****************************************************************************************
    Private Sub _lstUsedFeatTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstUsedFeatTabDashboardTbcMain.SelectedIndexChanged

        Dim lstVal As String = _
            lstUsedFeatTabDashboardTbcMain.SelectedItem.ToString
        Dim usedFeat As UsedFeature = _theThemePark.findUsedFeat(lstVal)

        If Not usedFeat Is Nothing Then
            txtToStringTabDashboardTbcMain.Text = usedFeat.ToString & vbCrLf
        Else
            txtToStringTabDashboardTbcMain.Text = _
                "No Used Feature info found for PassbkFeatId=" & lstVal & vbCrLf
        End If
    End Sub '_lstUsedFeatTabDashboardTbcMain_SelectedIndexChanged(...)


    '****************************************************************************************
    '_cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain_SelectedIndexChanged() 
    'is the event procedure the is called when the user selects a used
    'customer from the Add Passbook tab. Customer info is displayed in 
    'the associated text field.
    '****************************************************************************************
    Private Sub _cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.SelectedIndexChanged

        If Not cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.SelectedIndex = -1 Then
            Dim cboVal As String = _
                cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.SelectedItem.ToString
            Dim cust As Customer

            Try
                cust = _theThemePark.findCust(cboVal)
            Catch ex As Exception
                MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
                Exit Sub
            End Try

            If Not cust Is Nothing Then
                txtToStringGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Text = _
                    cust.ToString & vbCrLf
            Else
                txtToStringGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Text = _
                    "No customer info found for CustId=" & cboVal & vbCrLf
            End If
        End If
    End Sub '_cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged() 
    'is the event procedure the is called when the user selects a 
    'passbook id from the Update Feature tab. Customer and Visitor info 
    'is displayed in the associated text fields.
    '****************************************************************************************
    Private Sub _cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndexChanged

        'PBO: TEMPORARY AND MUST BE REFACTORED FOR PP04
        If Not cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1 Then
            Dim info As String = "Customer-Info: "
            Dim cboVal As String = _
                cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedItem.ToString

            txtCustToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = _
                info & cboVal & ", completed full info in PP04"

            info = "Visitor-Info"
            txtVisToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = _
                info & cboVal & ", completed full info in PP04"
        End If
    End Sub '_cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged

    '****************************************************************************************
    '_cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged() 
    'is the event procedure the is called when the user selects a 
    'feature id from the Update Feature tab. Feature info is displayed 
    'in the associated text fields.
    '****************************************************************************************
    Private Sub _cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndexChanged

        'PBO: TEMPORARY AND MUST BE REFACTORED FOR PP04
        If Not cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1 Then
            Dim cboVal As String = _
                cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedItem.ToString
            Dim feat As Feature

            Try
                feat = _theThemePark.findFeat(cboVal)
            Catch ex As Exception
                MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
                Exit Sub
            End Try

            If Not feat Is Nothing Then
                txtFeatToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = feat.ToString & vbCrLf
            Else
                txtFeatToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = _
                    "No Feature info found for FeatId=" & cboVal & vbCrLf
            End If
        End If
    End Sub '_cboFeatIdGrpFeatTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged() 
    'is the event procedure the is called when the user selects a 
    'passbook feature id from the Update Feature tab. Feature info is 
    'displayed in the associated text fields.
    '****************************************************************************************
    Private Sub _cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.SelectedIndexChanged

        'PBO: TEMPORARY AND MUST BE REFACTORED FOR PP04
        If Not cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1 Then
            Dim info As String = "Customer-Info: "
            Dim cboVal As String = _
                cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.SelectedItem.ToString

            txtCustToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = _
                info & cboVal & ", completed full info in PP04"

            info = "Visitor-Info: "
            txtVisToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = _
                info & cboVal & ", completed full info in PP04"

            info = "Feature-Info: "
            txtFeatToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = _
                info & cboVal & ", completed full info in PP04"

            info = "PrevUsed-Info: "
            txtPrevUsedToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text =
                info & cboVal & ", completed full info in PP04"

            txtPriceTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = "$TBD"
            txtRemQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = "3"
        End If
    End Sub '_cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged() 
    'is the event procedure the is called when the user selects a 
    'passbook feature id from the Update Feature tab. Feature info is 
    'displayed in the associated text fields.
    '****************************************************************************************
    Private Sub _cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
          Handles cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndexChanged

        'This require a lot of work.  Need to first locate the passbook feature by id.  If found
        'then need to use the passbook reference and find it and the feature reference to find
        'the feature.  Once the passbook is found use the customer reference to locate the 
        'customer.
        If Not cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndex = -1 Then
            Dim cboVal As String = _
                cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedItem.ToString

            Dim passbkFeat As PassbookFeature
            Dim cust As Customer
            Dim feat As Feature
            Dim passbk As Passbook

            'Find the passbook feature by Id
            passbkFeat = _theThemePark.findPassbkFeat(cboVal)

            If Not passbkFeat Is Nothing Then
                'Find the passbook from the reference contained in the passbook feature object
                If Not passbkFeat.passbk Is Nothing Then
                    passbk = _theThemePark.findPassbk(passbkFeat.passbk.passbkId)
                Else
                    MsgBox("Failed to associate a Passbook with this Passbook Feature",
                           MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                'Find the feature from the reference contained in the passbook object 
                If Not passbkFeat.feature Is Nothing Then
                    feat = _theThemePark.findFeat(passbkFeat.feature.featId)
                Else
                    MsgBox("Failed to associate a Feature with this Passbook Feature",
                           MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                'Find the owner of the passbook from the customer reference contained object
                If Not passbk.owner Is Nothing Then
                    cust = _theThemePark.findCust(passbk.owner.custId)
                Else
                    MsgBox("Failed to associate a Customer with the referenced Passbook",
                           MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                'Made it this far, update the relevant text boxes with current info
                txtCustToStringTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = _
                    cust.ToString
                txtVisToStringTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = _
                    "VisitorName: " & passbk.visName & "  RLP: add AGE DOB ETC"
                txtFeatToStringTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = _
                    feat.ToString
                txtPrevUsedTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text =
                    cboVal & ", RLP MUST BE COMPLETED"

                txtRemQuantTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Text = "3"
            Else
                MsgBox("Failed to locate Passbook Feature in the System", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
    End Sub '_cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_mnuAboutHelpFrmMain_Click() 
    'is the event procedure the is called when the user selects the About option from the
    'main program menu.  It simply displays credit information.
    '****************************************************************************************
    Private Sub _mnuAboutHelpFrmMain_Click(sender As Object, e As EventArgs) _
        Handles mnuAboutHelpFrmMain.Click

        Dim about As String

        about = _theThemePark.themeParkName & " Management System" _
                & vbCrLf _
                & vbCrLf & "Course:" & vbTab & "CIS605 Visual Business Applications" _
                & vbCrLf & "Author:" & vbTab & "Robert L Palumbo" _
                & vbCrLf & "Date:" & vbTab & "Fall Semester 2015" _
                & vbCrLf & "Project:" & vbTab & "PP03" _
                & vbCrLf _
                & vbCrLf & "Credits:" & vbTab & "Dr. Dan Turk, Dr. Ramadan Abdunabi"

        'MsgBox(about, MsgBoxStyle.OkOnly)
        MessageBox.Show(about, "About '" & _theThemePark.themeParkName & "'", _
           MessageBoxButtons.OK, MessageBoxIcon.Information)

        _writeTransLog(about)
    End Sub '_mnuAboutHelpFrmMain_Click


    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

    '****************************************************************************************
    '_createCust() handles processing for the  ThemePark_CreateCust
    ' event that is generated when a new customer is added to the
    'system.
    '****************************************************************************************
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

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If cust Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        With cust
            lstCustTabDashboardTbcMain.Items.Add(.custId)
            txtCustCntTabDashboardTbcMain.Text = _
                lstCustTabDashboardTbcMain.Items.Count.ToString

            cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Items.Add(.custId)
        End With

        _writeTransLog("<CREATED>: " & cust.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Customer creation submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_createCust(...)


    '****************************************************************************************
    '_createFeat() handles processing for the ThemePark_CreateFeat
    ' event that is generated when a new Feature is added to the
    'system.
    '****************************************************************************************
    Private Sub _createFeat(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_CreateFeat

        'Declare variables
        Dim themePark_EventArgs_CreateFeat As ThemePark_EventArgs_CreateFeat
        Dim feat As Feature

        'Get/validate data
        themePark_EventArgs_CreateFeat = CType(e, ThemePark_EventArgs_CreateFeat)

        'Use the past in object to populate the necessary system components
        feat = themePark_EventArgs_CreateFeat.feat

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If feat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        With feat
            lstFeatTabDashboardTbcMain.Items.Add(.featId)
            txtFeatCntTabDashboardTbcMain.Text = _
                lstFeatTabDashboardTbcMain.Items.Count.ToString

            cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Items.Add(.featId)
        End With

        _writeTransLog("<CREATED>: " & feat.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Feature creation submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_createFeat(...)

    '****************************************************************************************
    '_createPassbk() handles processing for the ThemePark_CreatePassbook
    ' event that is generated when a new passbook is added to the
    'system.
    '****************************************************************************************
    Private Sub _createPassbk(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_CreatePassbk

        'Declare variables
        Dim themePark_EventArgs_CreatePassbk As ThemePark_EventArgs_CreatePassbk
        Dim passbook As Passbook

        'Get/validate data
        themePark_EventArgs_CreatePassbk = CType(e, ThemePark_EventArgs_CreatePassbk)

        'Use the past in object to populate the necessary system components
        passbook = themePark_EventArgs_CreatePassbk.passbook

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If passbook Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        With passbook
            lstPassbkTabDashboardTbcMain.Items.Add(.passbkId)
            txtPassbkCntTabDashboardTbcMain.Text =
                lstPassbkTabDashboardTbcMain.Items.Count.ToString

            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Items.Add(.passbkId)
        End With

        _writeTransLog("<CREATED>: " & passbook.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook creation submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_createPassbk(...)

    '****************************************************************************************
    '_addPassbkFeat() handles processing for the ThemePark_PurchFeat
    ' event that is generated when a feature has been purchased fo
    'a specified passbook
    '****************************************************************************************
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

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If passbkFeat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        With passbkFeat
            lstPassbkFeatTabDashboardTbcMain.Items.Add(.id)
            txtPassbkFeatCntTabDashboardTbcMain.Text =
                lstPassbkFeatTabDashboardTbcMain.Items.Count.ToString()

            cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Items.Add(.id)
            cboPassbkFeatIdTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.Items.Add(.id)
        End With

        _writeTransLog("<PURCHASED>: " & passbkFeat.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook Feature submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_addPassbkFeat(...)

    '****************************************************************************************
    '_updtPassbkFeat() handles processing for the ThemePark_UpdtPassbkFeat
    ' event that is generated when a passbook feature is updated
    '****************************************************************************************
    Private Sub _updtPassbkFeat(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_UpdtPassbkFeat

        'Declare variables
        Dim themePark_EventArgs_UpdtPassbkFeat As ThemePark_EventArgs_UpdtPassbkFeat
        Dim passbkFeat As PassbookFeature

        'Get/validate data
        themePark_EventArgs_UpdtPassbkFeat = CType(e, ThemePark_EventArgs_UpdtPassbkFeat)

        'Use the past in object to populate the necessary system components
        passbkFeat = themePark_EventArgs_UpdtPassbkFeat.passbkFeat

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If passbkFeat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If


        With passbkFeat
            '            lstPassbkFeatTabDashboardTbcMain.Items.Add(.id)
            '            lstPassbkTabDashboardTbcMain.Items.Add(.id)

            '           txtPassbkFeatCntTabDashboardTbcMain.Text =
            'lstPassbkTabDashboardTbcMain.Items.Count.ToString()
        End With

        _writeTransLog("<UPDATED>: " & passbkFeat.id & " temporary place holder for this project")

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook Feature update submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_updtPassbkFeat(...)

    '****************************************************************************************
    '_usedFeat() handles processing for the ThemePark_UsedFeat
    ' event that is generated when a used feature is submitted
    '****************************************************************************************
    Private Sub _usedFeat(ByVal sender As System.Object, _
                          ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_UsedFeat

        'Declare variables
        Dim themePark_EventArgs_UsedFeat As ThemePark_EventArgs_UsedFeat
        Dim usedFeat As UsedFeature

        'Get/validate data
        themePark_EventArgs_UsedFeat = CType(e, ThemePark_EventArgs_UsedFeat)

        'Use the past in object to populate the necessary system components
        usedFeat = themePark_EventArgs_UsedFeat.usedFeat

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If usedFeat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        With usedFeat
            lstUsedFeatTabDashboardTbcMain.Items.Add(.id)
            lstUsedFeatCntTabDashboardTbcMain.Text =
                lstUsedFeatTabDashboardTbcMain.Items.Count.ToString

        End With

        _writeTransLog("<USED>: " & usedFeat.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Used Passbook Feature submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_usedFeat(...)

#End Region 'Event Procedures

#Region "Events"
    '****************************************************************************************
    'Events
    '****************************************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

#Region "Palumbo-Debug"
    '****************************************************************************************
    'THIS REGION IS STRICTLY FOR MY OWN DEBUG CODE AND IS NOT APPLICABLE FOR GRADING.
    '****************************************************************************************
    Private Sub _txtDebug_TextChanged(sender As Object, e As EventArgs) _
        Handles txtDebug.TextChanged

        txtDebug.SelectionStart = txtDebug.TextLength
        txtDebug.ScrollToCaret()
    End Sub '_txtDebug_TextChanged(...)

    Private Sub _btnResetView_Click(sender As Object, e As EventArgs) _
        Handles btnResetView.Click
        txtDebug.Clear()
    End Sub '_btnResetView_Click

    Private Sub _btnDispCustArray_Click(sender As Object, e As EventArgs) _
        Handles btnDispCustArray.Click

        If _theThemePark.numCusts = 0 Then
            txtDebug.Text &= "No Customer data to display" & vbCrLf
        Else
            Dim i As Integer
            For i = 0 To _theThemePark.numCusts - 1
                txtDebug.Text &= _theThemePark.ithCust(i).ToString & vbCrLf
            Next i
        End If
    End Sub

    Private Sub _btnShowPassbk_Click(sender As Object, e As EventArgs) _
    Handles btnShowPassbk.Click

        If _theThemePark.numPassbks = 0 Then
            txtDebug.Text &= "No Passbook data to display" & vbCrLf
        Else
            Dim i As Integer
            For i = 0 To _theThemePark.numPassbks - 1
                txtDebug.Text &= _theThemePark.ithPassbk(i).ToString & vbCrLf
            Next i
        End If
    End Sub

    Private Sub _btnShowFeat_Click(sender As Object, e As EventArgs) _
        Handles btnShowFeat.Click

        If _theThemePark.numFeats = 0 Then
            txtDebug.Text &= "No Feature data to display" & vbCrLf
        Else
            Dim i As Integer
            For i = 0 To _theThemePark.numFeats - 1
                txtDebug.Text &= _theThemePark.ithFeat(i).ToString & vbCrLf
            Next i
        End If
    End Sub

    Private Sub _btnShowPassbkFeat_Click(sender As Object, e As EventArgs) _
        Handles btnShowPassbkFeat.Click

        If _theThemePark.numPassbkFeats = 0 Then
            txtDebug.Text &= "No Passbook Feature data to display" & vbCrLf
        Else
            Dim i As Integer
            For i = 0 To _theThemePark.numPassbkFeats - 1
                txtDebug.Text &= _theThemePark.ithPassbkFeat(i).ToString & vbCrLf
            Next i
        End If
    End Sub

    Private Sub _btnShowUsedFeat_Click(sender As Object, e As EventArgs) _
        Handles btnShowUsedFeat.Click

        If _theThemePark.numUsedFeats = 0 Then
            txtDebug.Text &= "No Used Feature data to display" & vbCrLf
        Else
            Dim i As Integer
            For i = 0 To _theThemePark.numUsedFeats - 1
                txtDebug.Text &= _theThemePark.ithUsedFeat(i).ToString & vbCrLf
            Next i
        End If
    End Sub

#End Region 'Palumbo-Debug

End Class 'FrmMain