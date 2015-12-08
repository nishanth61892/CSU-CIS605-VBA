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
    Private Const mSYS_ERR_MSG As String = _
        "Error: Object Creation Failed"
    Private Const mSYS_ERR_LOOKUP_MSG As String = _
        "Error: Object Lookup Failed"
    Private Const mSYS_ERR_CUSTID_EXISTS_MSG As String = _
        "Error: Customer ID already exists, ID="
    Private Const mSYS_ERR_CUSTOREF_INVALID_MSG As String = _
        "Error: Customer Object Reference is Invalid"
    Private Const mSYS_ERR_FEATID_EXISTS_MSG As String = _
        "Error: Feature ID already exists, ID="
    Private Const mSYS_ERR_FEATOREF_INVALID_MSG As String = _
        "Error: Feature Object Reference is Invalid"
    Private Const mSYS_ERR_PASSBKID_EXISTS_MSG As String = _
        "Error: Passbook ID already exists, ID="
    Private Const mSYS_ERR_PASSBKOREF_INVALID_MSG As String = _
        "Error: Passbook Object Reference is Invalid"
    Private Const mSYS_ERR_PASSBKFEATID_EXISTS_MSG As String = _
        "Error: Passbook Feature ID already exists, ID="
    Private Const mSYS_ERR_USEDFEATID_EXISTS_MSG As String = _
        "Error: Used Feature ID already exists, ID="
    Private Const mSYS_ERR_DATASTORE_ACCESS_MSG As String = _
        "Error: Internal data store access error"
    Private Const mSYS_ERR_FILEIO_MSG As String = _
        "Error: File I/O Error"

    'Input/Output file names
    Private Const mIMPORT_FILENAME As String = "Transactions-in.txt"
    Private Const mEXPORT_FILENAME As String = "Transactions-out.txt"
    Private Const mERROR_FILENAME As String = "Transactions-error.txt"

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

    'Private references to be used during combo/list box processing
    Private mPassBk As Passbook = Nothing
    Private mFeat As Feature = Nothing
    Private mUnitPrice As Decimal = 0D
    Private mQtyPurch As Decimal = 1D
    Private mQtyUsed As Decimal = 0D

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

    Public ReadOnly Property IMPORT_FILENAME() As String
        Get
            Return _IMPORT_FILENAME
        End Get
    End Property

    Public ReadOnly Property EXPORT_FILENAME() As String
        Get
            Return _EXPORT_FILENAME
        End Get
    End Property

    Public ReadOnly Property ERROR_FILENAME() As String
        Get
            Return _ERROR_FILENAME
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

    Private ReadOnly Property _IMPORT_FILENAME As String
        Get
            Return mIMPORT_FILENAME
        End Get
    End Property

    Private ReadOnly Property _EXPORT_FILENAME As String
        Get
            Return mEXPORT_FILENAME
        End Get
    End Property

    Private ReadOnly Property _ERROR_FILENAME As String
        Get
            Return mERROR_FILENAME
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_MSG As String
        Get
            Return mSYS_ERR_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_LOOKUP_MSG As String
        Get
            Return mSYS_ERR_LOOKUP_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_DATASTORE_ACCESS_MSG As String
        Get
            Return mSYS_ERR_DATASTORE_ACCESS_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_CUSTID_EXISTS_MSG As String
        Get
            Return mSYS_ERR_CUSTID_EXISTS_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_CUSTOREF_INVALID_MSG As String
        Get
            Return mSYS_ERR_CUSTOREF_INVALID_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_FEATID_EXISTS_MSG As String
        Get
            Return mSYS_ERR_FEATID_EXISTS_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_FEATOREF_INVALID_MSG As String
        Get
            Return mSYS_ERR_FEATOREF_INVALID_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_PASSBKID_EXISTS_MSG As String
        Get
            Return mSYS_ERR_PASSBKID_EXISTS_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_PASSBKOREF_INVALID_MSG As String
        Get
            Return mSYS_ERR_PASSBKOREF_INVALID_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_PASSBKFEATID_EXISTS_MSG As String
        Get
            Return mSYS_ERR_PASSBKFEATID_EXISTS_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_USEDFEATID_EXISTS_MSG As String
        Get
            Return mSYS_ERR_USEDFEATID_EXISTS_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_FILEIO_MSG As String
        Get
            Return mSYS_ERR_FILEIO_MSG
        End Get
    End Property

    Private Property _themeParkName As String
        Get
            Return mThemeParkName
        End Get
        Set(pValue As String)
            mThemeParkName = pValue
        End Set
    End Property

    Private Property _sysTestActive As Boolean
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
    'Private Function _findCust(ByVal pCustId As String) As Customer
    '    Dim cust As Customer = Nothing

    '    Try
    '        cust = _theThemePark.findCust(pCustId)
    '    Catch ex As Exception
    '        MsgBox(_SYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
    '    End Try

    '    Return cust
    'End Function '_findCust(...)

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

        _writeTransLog("[ThemePark]: using System Theme Park ==> " & _theThemePark.ToString())

        '**** Test Feature creation ****
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: CREATE FEATURES]")
        _writeTransLog(Nothing)

        Dim f01 As Feature = New Feature("F01(t)", "Park Pass", "Day", 100D, 80D)
        Dim f02 As Feature = New Feature("F02(t)", "Early Entry Pass", "Day", 10D, 5D)
        Dim f03 As Feature = New Feature("F03(t)", "Meal Plan", "Meal", 30D, 20D)

        _theThemePark.createFeat(f01.featId, f01.featName, f01.unitOfMeas, f01.adultPrice, f01.childPrice)
        _theThemePark.createFeat(f02.featId, f02.featName, f02.unitOfMeas, f02.adultPrice, f02.childPrice)
        _theThemePark.createFeat(f03.featId, f03.featName, f03.unitOfMeas, f03.adultPrice, f03.childPrice)

        '**** Test Customer creation ****
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: CREATE CUSTOMERS]")
        _writeTransLog(Nothing)

        Dim c01 As Customer = New Customer("C01(t)", "CName01")
        Dim c02 As Customer = New Customer("C02(t)", "CName02")
        Dim c03 As Customer = New Customer("C03(t)", "Customer Name 03")

        _theThemePark.createCust(c01.custId, c01.custName)
        _theThemePark.createCust(c02.custId, c02.custName)
        _theThemePark.createCust(c03.custId, c03.custName)

        '**** Test Passbook creation ****
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: CREATE PASSBOOKS]")
        _writeTransLog(Nothing)

        Dim pb01 As Passbook = New Passbook("PB01(t)", c01, #9/15/2015#, "self", #1/1/1980#, 35, False)
        Dim pb02 As Passbook = New Passbook("PB02(t)", c02, #9/16/2015#, "self", #6/1/1985#, 30, False)
        Dim pb03 As Passbook = New Passbook("PB03(t)", c02, #9/17/2015#, "CO2 Visitor", #12/1/2003#, 12, True)
        Dim pb04 As Passbook = New Passbook("PB04(t)", c03, #8/15/2015#, "self", #1/1/1975#, 40, False)
        Dim pb05 As Passbook = New Passbook("PB05(t)", c03, #9/15/2015#, "CO3 Visitor 1", #10/7/2002#, 13, False)
        Dim pb06 As Passbook = New Passbook("PB06(t)", c03, #10/15/2015#, "CO3 Visitor 2", #10/8/2002#, 13, False)

        _theThemePark.createPassbk(pb01.passbkId, pb01.owner, pb01.datePurch, _
                               pb01.visName, pb01.visDob, pb01.visAge, pb01.visIsChild)
        _theThemePark.createPassbk(pb02.passbkId, pb02.owner, pb02.datePurch, _
                               pb02.visName, pb02.visDob, pb02.visAge, pb02.visIsChild)
        _theThemePark.createPassbk(pb03.passbkId, pb03.owner, pb03.datePurch, _
                               pb03.visName, pb03.visDob, pb03.visAge, pb03.visIsChild)
        _theThemePark.createPassbk(pb04.passbkId, pb04.owner, pb04.datePurch, _
                               pb04.visName, pb04.visDob, pb04.visAge, pb04.visIsChild)
        _theThemePark.createPassbk(pb05.passbkId, pb05.owner, pb05.datePurch, _
                               pb05.visName, pb05.visDob, pb05.visAge, pb05.visIsChild)
        _theThemePark.createPassbk(pb06.passbkId, pb06.owner, pb06.datePurch, _
                               pb06.visName, pb06.visDob, pb06.visAge, pb06.visIsChild)

        '**** Test Passbook Feature purchase ****'
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: PURCHASE FEATURE]")
        _writeTransLog(Nothing)

        Dim pbf01 As PassbookFeature = New PassbookFeature("PBF01(t)", f01, pb01, 1)
        Dim pbf02 As PassbookFeature = New PassbookFeature("PBF02(t)", f01, pb02, 2)
        Dim pbf03 As PassbookFeature = New PassbookFeature("PBF03(t)", f01, pb03, 3)
        Dim pbf04 As PassbookFeature = New PassbookFeature("PBF04(t)", f01, pb04, 1)
        Dim pbf05 As PassbookFeature = New PassbookFeature("PBF05(t)", f01, pb05, 1)
        Dim pbf06 As PassbookFeature = New PassbookFeature("PBF06(t)", f01, pb06, 1)
        Dim pbf07 As PassbookFeature = New PassbookFeature("PBF07(t)", f02, pb03, 3)
        Dim pbf08 As PassbookFeature = New PassbookFeature("PBF08(t)", f03, pb03, 9)
        Dim pbf09 As PassbookFeature = New PassbookFeature("PBF09(t)", f01, pb04, 1)
        Dim pbf10 As PassbookFeature = New PassbookFeature("PBF10(t)", f01, pb04, 3)

        _theThemePark.purchPassbkFeat(pbf01.id, pbf01.feature, pbf01.passbk, pbf01.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf02.id, pbf02.feature, pbf02.passbk, pbf02.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf03.id, pbf03.feature, pbf03.passbk, pbf03.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf04.id, pbf04.feature, pbf04.passbk, pbf04.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf05.id, pbf05.feature, pbf05.passbk, pbf05.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf06.id, pbf06.feature, pbf06.passbk, pbf06.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf07.id, pbf07.feature, pbf07.passbk, pbf07.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf08.id, pbf08.feature, pbf08.passbk, pbf08.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf09.id, pbf09.feature, pbf09.passbk, pbf09.qtyPurch)
        _theThemePark.purchPassbkFeat(pbf10.id, pbf10.feature, pbf10.passbk, pbf10.qtyPurch)

        '**** Test Use Passbook Feature ****'
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: USE PASSBOOK FEATURE]")
        _writeTransLog(Nothing)

        _theThemePark.usedFeat("UF01(t)", pbf01, #10/20/2015#, 1, "Epcot Center")
        _theThemePark.usedFeat("UF02(t)", pbf02, #10/20/2015#, 1, "West Parking")
        _theThemePark.usedFeat("UF03(t)", pbf03, #10/20/2015#, 2, "France")
        _theThemePark.usedFeat("UF04(t)", pbf03, #10/20/2015#, 1, "American Pavillion")

        '**** Test Update Passbook Feature ****'
        _writeTransLog(Nothing)
        _writeTransLog("[SYSTEM-TEST: UPDATE PASSBOOK FEATURE")
        _writeTransLog(Nothing)

        _theThemePark.updtPassbkFeat(pbf03.id, 1)

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

        'don't allow multiple runs of the system test data
        btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain.Enabled = False
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
            MsgBox(_SYS_ERR_MSG & ", Theme Park could not be instantiated")

            'Terminate the program
            _closeAppl()
        End If

        _writeTransLog("<CREATED>: " & _theThemePark.ToString())

        'Update the KPI for the first time just to populate the fields with N/A
        _dispKpi()
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

    '_dispKpi()
    '   - Used to update the GUI with the current Key Performance Indicators
    Private Sub _dispKpi()

        'Calculate and display avergage $balance of unused feature 
        Dim avgBal As Decimal = _theThemePark.calcAvgBalUnusedFeat

        If avgBal > 0 Then
            txtAvgBalUnusedFeatTabDashboardTbcMain.Text = avgBal.ToString("C")
        Else
            txtAvgBalUnusedFeatTabDashboardTbcMain.Text = "N/A"
        End If

        'Calculate and display total $balance of unused feature 
        Dim totBalUnused As Decimal = _theThemePark.calcTotBalUnusedFeat

        If totBalUnused > 0 Then
            txtTotBalUnusedFeatTabDashboardTbcMain.Text = totBalUnused.ToString("C")
        Else
            txtTotBalUnusedFeatTabDashboardTbcMain.Text = "N/A"
        End If

        'Calculate and display average number of passbooks per customer 
        Dim avgNumPbPerCust As Decimal = _theThemePark.calcAvgPassbkPerCust

        If avgNumPbPerCust > 0 Then
            txtAvgNumPassbkPerCustTabDashboardTbcMain.Text = avgNumPbPerCust.ToString("N2")
        Else
            txtAvgNumPassbkPerCustTabDashboardTbcMain.Text = "N/A"
        End If

        'Calculate and display percentage of unused passbook features 
        Dim featUsedPct As Decimal = _theThemePark.calcPctPassbkFeatUsed

        If featUsedPct > 0 Then
            txtFeatUsedPctTabDashboardTbcMain.Text = featUsedPct.ToString("N2")
        Else
            txtFeatUsedPctTabDashboardTbcMain.Text = "N/A"
        End If

        'Calculate and display avergage passbook holder age 
        Dim avgPbhAge As Decimal = _theThemePark.calcAvgPassbkHolderAge

        If avgPbhAge > 0 Then
            txtAvgPassbkHolderAgeTabDashboardTbcMain.Text = avgPbhAge.ToString("N2")
        Else
            txtAvgPassbkHolderAgeTabDashboardTbcMain.Text = "N/A"
        End If

        'Calculate and display number of passbook holders with birthdays in the current month 
        Dim currMonBdays As Integer = _theThemePark.calcNumPassbkHolderBdaysInCurrMon

        If currMonBdays > 0 Then
            txtCurrMonBdaysTabDashboardTbcMain.Text = currMonBdays.ToString("N0")
        Else
            txtCurrMonBdaysTabDashboardTbcMain.Text = "N/A"
        End If

        'Calculate and display most popular purchase feature 
        Dim mostPopFeat As String = _theThemePark.calcMostPopFeat

        If Not IsNothing(mostPopFeat) Then
            txtMostPopFeatTabDashboardTbcMain.Text = mostPopFeat
        Else
            txtMostPopFeatTabDashboardTbcMain.Text = "N/A"
        End If
    End Sub '_dispKpi()

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
    '_btnSubmitGrpAddCustTabFeatTbcMainFrmMain_Click() is the event procedure that gets called 
    'when the user click on the Submit button from the Customer tab. It validates and then
    'submits the data to create a new customer.
    '****************************************************************************************
    Private Sub _btnSubmitGrpAddCustTabFeatTbcMainFrmMain_Click(sender As Object, _
                                                                e As EventArgs) _
        Handles btnSubmitGrpAddCustTabFeatTbcMainFrmMain.Click

        Dim custId As String
        Dim custName As String

        custId = txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text.Trim
        custName = txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text.Trim

        'Validate the id and name field to make sure they contain data
        If String.IsNullOrEmpty(custId) Then
            MsgBox("ERROR: Please enter a unqiue Customer ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.SelectAll()
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Check for duplicate customer (by ID of course).  Duplicates are 
        'not allowed
        Try
            If Not IsNothing(_theThemePark.findCust(custId)) Then
                MsgBox(_SYS_ERR_CUSTID_EXISTS_MSG & custId, MsgBoxStyle.Exclamation)
                txtCustIdGrpAddCustTabCustTbcMainFrmMain.SelectAll()
                txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
                Exit Sub
            End If
        Catch
            MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End Try

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
                MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            End Try

            'Reset the input fields to allow for another possible customer entry
            _resetCustomerInput()
        End If
    End Sub '_btnSubmitGrpAddCustTabFeatTbcMainFrmMain_Click(...)

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
        Dim featId As String = txtFeatIdAddFeatTabFeatTbcMainFrmMain.Text.Trim
        Dim featName As String = txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Text.Trim
        Dim unitOfMeas As String = txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Text.Trim
        Dim adultPrice As String = txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text.Trim
        Dim childPrice As String = txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text.Trim

        'Validate all the fields
        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please enter a unique Feature ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.SelectAll()
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Check for duplicate feature (by ID of course).  Duplicates are 
        'not allowed
        Try
            If Not IsNothing(_theThemePark.findFeat(featId)) Then
                MsgBox(_SYS_ERR_FEATID_EXISTS_MSG & featId, MsgBoxStyle.Exclamation)
                txtFeatIdAddFeatTabFeatTbcMainFrmMain.SelectAll()
                txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

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
                            & "--> Unit-Measure=" & unitOfMeas & vbCrLf _
                            & "--> Adult-Price=" & adultPrice & vbCrLf _
                            & "--> Child-Price=" & childPrice & vbCrLf,
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
                MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
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
        Dim passbkId As String = txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text.Trim
        Dim visName As String = txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text.Trim
        Dim visDob As String = txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text.Trim
        Dim visDobValue As Date

        'Validate all the fields
        If _theThemePark.numCusts = 0 Then
            MsgBox("ERROR: There are no Customers defined" _
                   & vbCrLf & "Please add a Customer", MsgBoxStyle.OkOnly)
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_CUSTOMER)
            Exit Sub
        End If

        If String.IsNullOrEmpty(custList.Text) Then
            MsgBox("ERROR: Please seleect a Customer ID from the list", MsgBoxStyle.OkOnly)
            cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Make sure customer id is valid
        Dim cust As Customer
        Try
            cust = _theThemePark.findCust(custList.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        If cust Is Nothing Then
            Dim s As String = "ERROR: Customer '" & custList.SelectedItem.ToString & "' is invalid" _
                                  & vbCrLf & "Please select a different ID"
            MsgBox(s, MsgBoxStyle.OkOnly)
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(passbkId) Then
            MsgBox("ERROR: Please enter a unique Passbook ID (ex: 0001)", MsgBoxStyle.OkOnly)
            txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.SelectAll()
            txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            Exit Sub
        End If

        'Check for duplicate passbook (by ID of course).  Duplicates are 
        'not allowed
        If Not IsNothing(_theThemePark.findPassbk(passbkId)) Then
            MsgBox(_SYS_ERR_PASSBKID_EXISTS_MSG & passbkId, MsgBoxStyle.Exclamation)
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
            MsgBox("ERROR: Visitor DOB is in the future" _
                   & vbCrLf & "Please re-enter date", MsgBoxStyle.OkOnly)
            txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text = Now.ToString
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
                            & "--> Visitor-Name=" & visName & vbCrLf _
                            & "--> Visitor-DOB=" & visDob & vbCrLf _
                            & "--> Vistor-Age=" & visAge & vbCrLf _
                            & "--> Vistor-IsChild? " & visIsChild.ToString & vbCrLf _
                            & "--> Date-Purchased=" & datePurch & vbCrLf,
                            MsgBoxStyle.OkCancel
                            )
        End If

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok And _sysTestActive = False Then
            'Create a new passbook. It will be persistent within the ThemePark object.
            'But need to trap any insertion acceptions which could happen based on 
            'the state of the system
            Try
                _theThemePark.createPassbk(passbkId, _
                                           cust, _
                                           datePurch, _
                                           visName, _
                                           visDobValue, _
                                           visAge, _
                                           visIsChild
                                           )
            Catch ex As Exception
                MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
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
        cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.SelectedIndex = -1

        txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtToStringGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        txtCustToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""

        cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
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
    '_btnSubmitTabPurchFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Submit button from the Purchase Passbook Feature tab.  
    'It validates and then submits the data to add a purchased feature to a customer passbook.
    '****************************************************************************************
    Private Sub _btnSubmitTabPurchFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                     e As EventArgs) _
        Handles btnSubmitTabPurchFeatTbcPassbkFeatMainTbcMain.Click

        'Combo list accessors
        Dim passbkList As ComboBox = cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain
        Dim featList As ComboBox = cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain

        'Used as shortcut names to access the data
        Dim passbkId As String = passbkList.Text.Trim
        Dim featId As String = featList.Text.Trim
        Dim passbkFeatId As String = txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text.Trim
        Dim decQtyRemain As Decimal = 0D

        'Validate all the fields
        If _theThemePark.numPassbks = 0 Then
            MsgBox("ERROR: There are no Passbooks defined" _
                   & vbCrLf & "Please add a Passbook", MsgBoxStyle.OkOnly)
            cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBK)
            Exit Sub
        End If

        If String.IsNullOrEmpty(passbkId) Then
            MsgBox("ERROR: Please select a Passbook ID from the list", MsgBoxStyle.OkOnly)
            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Make sure passbook reference is valid
        Dim passbk As Passbook
        Try
            passbk = _theThemePark.findPassbk(passbkId)
        Catch
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        If passbk Is Nothing Then
            Dim s As String = "ERROR: Passbook '" & passbkId & "' is invalid" _
                              & vbCrLf & "Please select a different ID"
            MsgBox(s, MsgBoxStyle.OkOnly)
            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If _theThemePark.numFeats = 0 Then
            MsgBox("ERROR: There are no Features defined" _
                   & vbCrLf & "Please add a Feature", MsgBoxStyle.OkOnly)
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_FEATURE)
            Exit Sub
        End If

        If String.IsNullOrEmpty(featId) Then
            MsgBox("ERROR: Please select a Feature ID from the list", MsgBoxStyle.OkOnly)
            cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Make sure the feature reference is valid
        Dim feat As Feature
        Try
            feat = _theThemePark.findFeat(featId)
        Catch ex As Exception
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        If feat Is Nothing Then
            Dim s As String = "ERROR: Feature '" & featId & "' is invalid" _
                              & vbCrLf & "Please select a different ID"
            MsgBox(s, MsgBoxStyle.OkOnly)
            cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(passbkFeatId) Then
            MsgBox("ERROR: Please enter unique Passbook Feature ID (ex: PBF001)", MsgBoxStyle.OkOnly)
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Check for duplicate passbook features (by ID of course).  Duplicates are 
        'not allowed
        If Not IsNothing(_theThemePark.findPassbkFeat(passbkFeatId)) Then
            MsgBox(_SYS_ERR_PASSBKFEATID_EXISTS_MSG & passbkFeatId, MsgBoxStyle.Exclamation)
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'If Not Decimal.TryParse(qtyPurch, decQtyPurch) Or decQtyPurch <= 0 Then
        If mQtyPurch = 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity > 0 to purchase (ex: 3)", MsgBoxStyle.OkOnly)
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Calculate total price - based on age 
        Dim totPurchPrice As Decimal

        'Update purchase totals
        totPurchPrice = mUnitPrice * mQtyPurch
        txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = totPurchPrice.ToString("C")

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To purchase the following Passbook Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                            & "--> Passbook-FeatureId=" & passbkFeatId & vbCrLf _
                            & "--> Feature=" & feat.featName & vbCrLf _
                            & "--> Unit-Price=" & mUnitPrice.ToString("C") & vbCrLf _
                            & "--> Qty-Purchased=" & mQtyPurch.ToString("N0") & vbCrLf _
                            & "--> Total-Purchase-Price=" & totPurchPrice.ToString("C") & vbCrLf _
                            & "--> Passbook=" & passbk.passbkId & vbCrLf,
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
                _theThemePark.purchPassbkFeat(passbkFeatId, _
                                              feat, _
                                              passbk, _
                                              mQtyPurch
                                              )
            Catch ex As Exception
                MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            End Try

            'Reset the fields and focus to allow for another feature to be added
            _resetPassbkPurchFeatInput()
        End If
    End Sub '_btnSubmitTabPurchFeatTbcPassbkFeatMainTbcMain_Click(...)

    '****************************************************************************************
    '_resetPassbkFeatPurchInput() is used to reset all the feature input fields to allow the 
    'user to start over with input.
    '****************************************************************************************
    Private Sub _resetPassbkPurchFeatInput()
        'Reset the fields and focus to allow for another feature to be added
        cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1
        cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1

        txtCustToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtVisToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtFeatToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text = "1"
        txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtUnitPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""

        mPassBk = Nothing
        mFeat = Nothing
        mQtyPurch = 1
        mUnitPrice = 0

        cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
    End Sub '_resetPassbkPurchInput()

    '****************************************************************************************
    '_btnResetTabAddFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Reset button from the 'Passbook Features | Add' tab. 
    'It clears all input fields to allow the user to reenter the data from scratch.
    '****************************************************************************************
    Private Sub _btnResetTabPurchFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                    e As EventArgs) _
        Handles btnResetTabPurchFeatTbcPassbkFeatMainTbcMain.Click

        'Reset the fields and focus to allow for another passbook featurd addition
        _resetPassbkPurchFeatInput()
    End Sub '_btnResetTabPurchFeatTbcPassbkFeatMainTbcMain_Click(...)

    '****************************************************************************************
    '_btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets 
    'called when the user clicks on the Submit button from the Update Passbook Feature tab.  
    'It validates and then submits the data to update a customer passbook feature.
    '****************************************************************************************
    Private Sub _btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, _
                                                                    e As EventArgs) _
        Handles btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain.Click

        'Used as shortcut names to access the data
        Dim featId As String = cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Text.Trim
        Dim totUpdtQty As String = txtTotUpdtQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text.Trim
        Dim decTotUpdtQty As Decimal = 0D

        'Validate all the fields
        If _theThemePark.numPassbkFeats = 0 Then
            MsgBox("ERROR: There are no Passbook Features defined" _
                   & vbCrLf & "Please add a Passbook Feature", MsgBoxStyle.OkOnly)
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

        'Make sure passbook feature reference is valid
        Dim passbkFeat As PassbookFeature
        Try
            passbkFeat = _theThemePark.findPassbkFeat(featId)
        Catch ex As Exception
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        If IsNothing(passbkFeat) Then
            Dim s As String = "ERROR: Passbook Feature Id'" & featId & "' is invalid" _
                               & vbCrLf & "Please select a different ID"
            MsgBox(s, MsgBoxStyle.OkOnly)
            _resetPassbkUpdtFeatInput()
            Exit Sub
        End If

        If IsNothing(passbkFeat.passbk) Then
            Dim s As String = _SYS_ERR_PASSBKOREF_INVALID_MSG
            MsgBox(s, MsgBoxStyle.OkOnly)
            _resetPassbkUpdtFeatInput()
            Exit Sub
        End If

        If Not Decimal.TryParse(totUpdtQty, decTotUpdtQty) Or decTotUpdtQty < 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity >= 0 (ex: 3)", MsgBoxStyle.OkOnly)
            txtTotUpdtQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtTotUpdtQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        Dim totQtyPrice As Decimal
        Dim unitPrice As Decimal
        Dim refund As Boolean = False
        Dim qtyReturned As Decimal
        Dim qtyAdded As Decimal
        Dim qtyPurch As Decimal

        'The price to use is based on DOB compared with the current date
        Dim visAge As Integer = _calcAge(passbkFeat.passbk.visDob)
        Dim visIsChild As Boolean = visAge < mADULT_MIN_AGE

        'Calculate total price - based on unit price by age 
        If visIsChild = True Then
            unitPrice = passbkFeat.feature.childPrice
        Else
            unitPrice = passbkFeat.feature.adultPrice
        End If

        'Calculate the display values based on the update quantity entered
        If decTotUpdtQty >= passbkFeat.qtyRemain Then
            qtyAdded = decTotUpdtQty - passbkFeat.qtyRemain
            qtyPurch = passbkFeat.qtyPurch + qtyAdded
            totQtyPrice = unitPrice * qtyAdded
        Else
            qtyReturned = (passbkFeat.qtyRemain - decTotUpdtQty)
            qtyPurch = passbkFeat.qtyPurch - qtyReturned
            totQtyPrice = unitPrice * qtyReturned
            refund = True
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            If Not refund Then
                choice = MsgBox("To update the following Passbook Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                                & "--> Passbook-FeatureId=" & featId & vbCrLf _
                                & "--> New-Quantity-Added=" & qtyAdded.ToString("N0") & vbCrLf _
                                & "--> Unit-Price=" & unitPrice.ToString("C") & vbCrLf _
                                & "--> Total-Cost=" & totQtyPrice.ToString("C") & vbCrLf _
                                & "--> New-Quantity-Remaining=" & decTotUpdtQty.ToString("N0") & vbCrLf,
                                MsgBoxStyle.OkCancel
                                )
            Else
                choice = MsgBox("To update the following Passbook Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                                & "--> Passbook-FeatureId=" & featId & vbCrLf _
                                & "--> Quantity-Returned=" & qtyReturned.ToString("N0") & vbCrLf _
                                & "--> Unit-Price=" & unitPrice.ToString("C") & vbCrLf _
                                & "--> Refund-Amount-Due=" & totQtyPrice.ToString("C") & vbCrLf _
                                & "--> New-Quantity-Remaining=" & decTotUpdtQty.ToString("N0") & vbCrLf,
                                MsgBoxStyle.OkCancel
                                )
            End If
        End If

        'If OK selected proceed with the submission
        If choice = MsgBoxResult.Ok And _sysTestActive = False Then
            'Create a new Passbook Feature
            _theThemePark.updtPassbkFeat(featId, _
                                         decTotUpdtQty
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
        txtUnitPriceTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtTotUpdtQtyTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = "0"
        txtTotQtyRemTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = "0"

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

        Dim passbkFeatIdList As ComboBox = cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain

        'Used as shortcut names to access the data
        Dim postId As String = txtPostIdTabPostFeatTbcPassbkFeatMainTbcMain.Text.Trim
        Dim passbkFeatId As String = cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain.Text.Trim
        Dim qtyUsed As String = txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Text.Trim
        Dim loc As String = txtLocTabPostFeatTbcPassbkFeatMainTbcMain.Text.Trim

        'validate all the fields
        If _theThemePark.numPassbkFeats = 0 Then
            MsgBox("ERROR: There are no Passbook Features defined" _
                   & vbCrLf & "Please add a Passbook Feature", MsgBoxStyle.OkOnly)
            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            tbcMainFrmMain.SelectTab(mTBC_MAIN_TAB_PASSBKFEAT)
            tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectTab(mTBC_PASSBKFEAT_TAB_ADD)
            Exit Sub
        End If

        If String.IsNullOrEmpty(passbkFeatId) Then
            MsgBox("ERROR: Please select a Passbook Feature ID from the list", MsgBoxStyle.OkOnly)
            cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'make sure passbook feature reference is valid
        Dim passbkfeat As PassbookFeature
        Try
            passbkfeat = _theThemePark.findPassbkFeat(passbkFeatId)
        Catch ex As Exception
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        If IsNothing(passbkfeat) Then
            Dim s As String = "ERROR: Passbook Feature ID '" & passbkFeatId & "' is invalid" _
                              & vbCrLf & "Please select a different ID"
            MsgBox(s, MsgBoxStyle.OkOnly)
            _resetPassbkUsedFeatInput()
            Exit Sub
        End If

        'can't post to an acct that has no quantity remaining, the feature was totally used
        If passbkfeat.qtyRemain = 0 Then
            Dim s As String = "ERROR: There are no available unit of this Feature remaining" _
                              & vbCrLf & "Please select a different ID"
            MsgBox(s, MsgBoxStyle.OkOnly)
            passbkFeatIdList.SelectedIndex = -1
            Exit Sub
        End If

        Dim decQtyUsed As Decimal

        If Not Decimal.TryParse(qtyUsed, decQtyUsed) Or decQtyUsed <= 0 Then
            MsgBox("ERROR: Please enter a numeric quantity >= 1 (ex: 3)", MsgBoxStyle.OkOnly)
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If decQtyUsed > passbkfeat.qtyRemain Then
            MsgBox("ERROR: Quantity used is > quantity remaining" _
                   & vbCrLf & "Please enter a quantity <= " _
                   & passbkfeat.qtyRemain.ToString("n0"), MsgBoxStyle.OkOnly)
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(loc) Then
            MsgBox("ERROR: Please specify the Location where Feature was used (ex: Main Parking Lot)", MsgBoxStyle.OkOnly)
            txtLocTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
            txtLocTabPostFeatTbcPassbkFeatMainTbcMain.Text = ""
            Exit Sub
        End If

        If String.IsNullOrEmpty(postId) Then
            MsgBox("ERROR: Please enter a unique Post ID for this transaction (ex: UF001)", MsgBoxStyle.OkOnly)
            txtPostIdTabPostFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtPostIdTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Check for duplicate used feature (by ID of course).  Duplicates are 
        'not allowed
        If Not IsNothing(_theThemePark.findUsedFeat(postId)) Then
            MsgBox(_SYS_ERR_USEDFEATID_EXISTS_MSG, MsgBoxStyle.Exclamation)
            txtPostIdTabPostFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtPostIdTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Verify the purchase before committing
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            Dim newQtyRemain As Decimal = passbkfeat.qtyRemain - decQtyUsed

            choice = MsgBox("To post the following Used Feature Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
                            & "--> PostId=" & postId & vbCrLf _
                            & "--> PassbookFeatureId=" & passbkFeatId & vbCrLf _
                            & "--> QtyPurchased=" & passbkfeat.qtyPurch.ToString("N0") & vbCrLf _
                            & "--> QtyUsed=" & decQtyUsed.ToString("N0") & vbCrLf _
                            & "--> QtyRemain=" & newQtyRemain.ToString("N0") & vbCrLf _
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
                _theThemePark.usedFeat(postId, passbkfeat, DateTime.Now, decQtyUsed, loc)
            Catch ex As Exception
                MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Exclamation)
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
        cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1

        txtCustToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtVisToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtFeatToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPrevUsedToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtQtyRemTabPostFeatTbcPassbkFeatMainTbcMain.Text = "0"
        txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Text = "0"
        txtLocTabPostFeatTbcPassbkFeatMainTbcMain.Text = ""
        txtPostIdTabPostFeatTbcPassbkFeatMainTbcMain.Text = ""

        cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
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
        Handles btnClearTabTransLogTbcMain.Click

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

        'Console.WriteLine("Calling Main tab control")

        Select Case tbcMainFrmMain.SelectedIndex
            Case mTBC_MAIN_TAB_DASHBOARD
                'Console.WriteLine("Dashboard Tab")

                'Nothing to do for this tab

            Case mTBC_MAIN_TAB_CUSTOMER
                'Console.WriteLine("Customer Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitGrpAddCustTabFeatTbcMainFrmMain

                'Set the focus to the first input field
                txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()

            Case mTBC_MAIN_TAB_FEATURE
                'Console.WriteLine("Feature Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitGrpAddFeatTabFeatTbcMainFrmMain

                'Set the focus to the first input field
                txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()

            Case mTBC_MAIN_TAB_PASSBK
                'Console.WriteLine("Passbook Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain

                'Set the focus to the first input field
                cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Focus()

            Case mTBC_MAIN_TAB_PASSBKFEAT
                'Console.WriteLine("Passbook Feature Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnSubmitTabPurchFeatTbcPassbkFeatMainTbcMain

                'Set the focus to the first input field
                cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_MAIN_TAB_TRANSLOG
                'Console.WriteLine("Transaction Log Tab")

                'Assign AcceptButton to this tab's Submit button for convenience
                Me.AcceptButton = btnClearTabTransLogTbcMain

                'Push the caret to the end of the log file
                _txtTransLogTabTransLogTbcMainFrmMain_TextChanged(Me, Nothing)

            Case mTBC_MAIN_TAB_SYSTEST
                'Console.WriteLine("System Test Tab")

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

        'Console.WriteLine("Calling Passbook Feature tab control")

        Select Case tbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain.SelectedIndex
            Case mTBC_PASSBKFEAT_TAB_ADD
                'Console.WriteLine("Add Tab")

                'Set the focus to the first input field
                cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_UPDT
                'Console.WriteLine("Update Tab")

                'Set the focus to the first input field
                cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()

            Case mTBC_PASSBKFEAT_TAB_POST
                'Console.WriteLine("Post Tab")

                'Set the focus to the first input field
                cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
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

        'Only process if selected item is valid
        If lstCustTabDashboardTbcMain.SelectedIndex <> -1 Then
            Dim lstVal As String = lstCustTabDashboardTbcMain.SelectedItem.ToString
            Dim cust As Customer = _theThemePark.findCust(lstVal)

            If Not IsNothing(cust) Then
                txtToStringTabDashboardTbcMain.Text = cust.ToString & vbCrLf
            Else
                txtToStringTabDashboardTbcMain.Text = _
                    "No Customer info found for ID=" & lstVal & vbCrLf
            End If
        End If

        'unselect the other list choices
        lstFeatTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkFeatTabDashboardTbcMain.SelectedIndex = -1
        lstUsedFeatTabDashboardTbcMain.SelectedIndex = -1
    End Sub '_lstCustTabDashboardTbcMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_lstFeatTabDashboardTbcMain_SelectedIndexChanged() is the event 
    'procedure the is called when the user selects a feature from the 
    'Dashboard tab.  Feature info is displayed in the associated text 
    'field.
    '****************************************************************************************
    Private Sub _lstFeatTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstFeatTabDashboardTbcMain.SelectedIndexChanged

        'Only process if selected item is valid
        If lstFeatTabDashboardTbcMain.SelectedIndex <> -1 Then
            Dim lstVal As String = _
                  lstFeatTabDashboardTbcMain.SelectedItem.ToString
            Dim feat As Feature = _theThemePark.findFeat(lstVal)

            If Not IsNothing(feat) Then
                txtToStringTabDashboardTbcMain.Text = feat.ToString & vbCrLf
            Else
                txtToStringTabDashboardTbcMain.Text = _
                    "No Feature info found for ID=" & lstVal & vbCrLf
            End If
        End If

        'unselect the other list choices
        lstCustTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkFeatTabDashboardTbcMain.SelectedIndex = -1
        lstUsedFeatTabDashboardTbcMain.SelectedIndex = -1
    End Sub '_lstFeatTabDashboardTbcMain_SelectedIndexChanged

    '****************************************************************************************
    '_lstPassbkTabDashboardTbcMain_SelectedIndexChanged() is the event 
    'procedure the is called when the user selects a passbook from 
    'the Dashboard tab.  Passbook info is displayed in the associated 
    'text field.
    '****************************************************************************************
    Private Sub _lstPassbkTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstPassbkTabDashboardTbcMain.SelectedIndexChanged

        'Only process if selected item is valid
        If lstPassbkTabDashboardTbcMain.SelectedIndex <> -1 Then
            Dim lstVal As String = _
                   lstPassbkTabDashboardTbcMain.SelectedItem.ToString
            Dim passbk As Passbook = _theThemePark.findPassbk(lstVal)

            If Not IsNothing(passbk) Then
                txtToStringTabDashboardTbcMain.Text = passbk.ToString & vbCrLf
            Else
                txtToStringTabDashboardTbcMain.Text = _
                    "No Passbook info found for ID=" & lstVal & vbCrLf
            End If
        End If

        'unselect the other list choices
        lstCustTabDashboardTbcMain.SelectedIndex = -1
        lstFeatTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkFeatTabDashboardTbcMain.SelectedIndex = -1
        lstUsedFeatTabDashboardTbcMain.SelectedIndex = -1
    End Sub '_lstPassbkTabDashboardTbcMain_SelectedIndexChanged(...)


    '****************************************************************************************
    '_lstPassbkFeatTabDashboardTbcMain_SelectedIndexChanged() is the 
    'event procedure the is called when the user selects a passbook from 
    'the Dashboard tab.  Passbook info is displayed in the associated 
    'text field.
    '****************************************************************************************
    Private Sub _lstPassbkFeatTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstPassbkFeatTabDashboardTbcMain.SelectedIndexChanged

        'Only process if selected item is valid
        If lstPassbkFeatTabDashboardTbcMain.SelectedIndex <> -1 Then
            Dim lstVal As String = _
                lstPassbkFeatTabDashboardTbcMain.SelectedItem.ToString
            Dim passbkFeat As PassbookFeature = _theThemePark.findPassbkFeat(lstVal)

            If Not IsNothing(passbkFeat) Then
                txtToStringTabDashboardTbcMain.Text = passbkFeat.ToString & vbCrLf
            Else
                txtToStringTabDashboardTbcMain.Text = _
                    "No Passbook Feature info found for ID=" & lstVal & vbCrLf
            End If
        End If

        'unselect the other list choices
        lstCustTabDashboardTbcMain.SelectedIndex = -1
        lstFeatTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkTabDashboardTbcMain.SelectedIndex = -1
        lstUsedFeatTabDashboardTbcMain.SelectedIndex = -1
    End Sub '_lstPassbkFeatTabDashboardTbcMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_lstUsedFeatTabDashboardTbcMain_SelectedIndexChanged() is the 
    'event procedure the is called when the user selects a used
    'feature from the Dashboard tab.  Used feature info is displayed in 
    'the associated text field.
    '****************************************************************************************
    Private Sub _lstUsedFeatTabDashboardTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstUsedFeatTabDashboardTbcMain.SelectedIndexChanged

        'Only process if selected item is valid
        If lstUsedFeatTabDashboardTbcMain.SelectedIndex <> -1 Then
            Dim lstVal As String = _
                lstUsedFeatTabDashboardTbcMain.SelectedItem.ToString
            Dim usedFeat As UsedFeature = _theThemePark.findUsedFeat(lstVal)

            If Not IsNothing(usedFeat) Then
                txtToStringTabDashboardTbcMain.Text = usedFeat.ToString & vbCrLf
            Else
                txtToStringTabDashboardTbcMain.Text = _
                    "No Used Feature info found for ID=" & lstVal & vbCrLf
            End If
        End If

        'unselect the other list choices
        lstCustTabDashboardTbcMain.SelectedIndex = -1
        lstFeatTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkTabDashboardTbcMain.SelectedIndex = -1
        lstPassbkFeatTabDashboardTbcMain.SelectedIndex = -1
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
                MsgBox(_SYS_ERR_LOOKUP_MSG, MsgBoxStyle.Exclamation)
                Exit Sub
            End Try

            If Not IsNothing(cust) Then
                txtToStringGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Text = _
                    cust.ToString & vbCrLf
            Else
                Dim s As String = "ERROR: Customer Id '" & cboVal & "' is invalid. Please select a different ID"
                MsgBox(s, MsgBoxStyle.Exclamation)
                _resetPassbkInput()
                Exit Sub
            End If
        End If
    End Sub '_cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged() 
    'is the event procedure the is called when the user selects a 
    'passbook id from the Purchase Passbook Feature tab. Customer, Visitor and 
    'Feature info is displayed in the associated text fields.
    '****************************************************************************************
    Private Sub _cboPassbkIdGrpPassbkTabAddFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndexChanged

        'Internal reference needs to be reset first
        mPassBk = Nothing

        If Not cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1 Then
            Dim cboVal As String = _
                cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedItem.ToString

            Try
                mPassBk = _theThemePark.findPassbk(cboVal)
            Catch ex As Exception
                MsgBox(_SYS_ERR_LOOKUP_MSG, MsgBoxStyle.Exclamation)
                Exit Sub
            End Try

            If Not IsNothing(mPassBk) Then
                'Double check cust ref is not nothing before using it
                If Not IsNothing(mPassBk.owner) Then
                    txtCustToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = _
                        mPassBk.owner.ToString & vbCrLf
                Else
                    MsgBox(_SYS_ERR_CUSTOREF_INVALID_MSG, MsgBoxStyle.Critical)
                    _resetPassbkPurchFeatInput()
                    Exit Sub
                End If
            Else
                Dim s As String = "ERROR: Passbook '" & cboVal & "' is invalid. Please select a different ID"
                MsgBox(s, MsgBoxStyle.Exclamation)
                _resetPassbkPurchFeatInput()
                Exit Sub
            End If

            'Determine if the visitor is a child (< 13 years old) based on the current date/time
            mPassBk.visAge = _calcAge(mPassBk.visDob)
            mPassBk.visIsChild = mPassBk.visAge < mADULT_MIN_AGE

            txtVisToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = "[Visitor] -> " _
                & mPassBk.visName & ", DOB: " & mPassBk.visDob & ", Age: " & mPassBk.visAge _
                & ", IsChild (<13yo): " & IIf(mPassBk.visIsChild, "True", "False").ToString

            'If a feature was selected prior to the passbook being selected we can go
            'ahead and prefill in data on the Purchase Feature tab
            If Not IsNothing(mFeat) Then
                'Determine unit price based on age of Visitor holding the passbook
                If mPassBk.visIsChild = True Then
                    mUnitPrice = mFeat.childPrice
                Else
                    mUnitPrice = mFeat.adultPrice
                End If
                txtUnitPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = mUnitPrice.ToString("C")

                Dim purchPrice As Decimal = mQtyPurch * mUnitPrice
                txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = purchPrice.ToString("C")
            Else
                mUnitPrice = 0D
            End If
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

        'Internal reference needs to be reset first
        mFeat = Nothing

        If Not cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedIndex = -1 Then
            Dim cboVal As String = _
                cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.SelectedItem.ToString

            Try
                mFeat = _theThemePark.findFeat(cboVal)
            Catch ex As Exception
                MsgBox(_SYS_ERR_LOOKUP_MSG, MsgBoxStyle.Exclamation)
                Exit Sub
            End Try

            If Not IsNothing(mFeat) Then
                txtFeatToStringTabAddFeatTbcPassbkFeatMainTbcMain.Text = mFeat.ToString & vbCrLf
            Else
                Dim s As String = "ERROR: Feature '" & cboVal & "' is invalid. Please select a different ID"
                MsgBox(s, MsgBoxStyle.Exclamation)
                cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
                Exit Sub
            End If

            'If a passbook was selected prior to the feature being selected we can go
            'ahead and prefill in data on the Purchase Feature tab
            If Not IsNothing(mPassBk) Then
                'Determine unit price based on age of Visitor holding the passbook
                If mPassBk.visIsChild = True Then
                    mUnitPrice = mFeat.childPrice
                Else
                    mUnitPrice = mFeat.adultPrice
                End If
                txtUnitPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = mUnitPrice.ToString("C")

                Dim purchPrice As Decimal = mQtyPurch * mUnitPrice
                txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = purchPrice.ToString("C")
            Else
                mUnitPrice = 0D
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

        Dim passbkFeatIdList As ComboBox = cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain

        'Internal reference needs to be reset first
        Dim passbkFeat As PassbookFeature

        'This require a lot of work.  Need to first locate the passbook feature by id.  If found
        'then need to use the passbook reference and find it and the feature reference to find
        'the feature.  Once the passbook is found use the customer reference to locate the 
        'customer.
        If Not passbkFeatIdList.SelectedIndex = -1 Then
            Dim cboVal As String = _
                passbkFeatIdList.SelectedItem.ToString

            Try
                passbkFeat = _theThemePark.findPassbkFeat(cboVal)
            Catch ex As Exception
                MsgBox(_SYS_ERR_LOOKUP_MSG, MsgBoxStyle.Exclamation)
                Exit Sub
            End Try

            If Not IsNothing(passbkFeat) Then
                'Double check passbook ref is not nothing before using it
                If Not IsNothing(passbkFeat.passbk) AndAlso Not IsNothing(passbkFeat.passbk.owner) Then
                    txtCustToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = _
                        passbkFeat.passbk.owner.ToString & vbCrLf
                Else
                    Dim s As String
                    If IsNothing(passbkFeat.passbk) Then
                        s = _SYS_ERR_PASSBKOREF_INVALID_MSG
                    Else
                        s = _SYS_ERR_CUSTOREF_INVALID_MSG
                    End If
                    MsgBox(s, MsgBoxStyle.Critical)
                    'Reset the fields and focus to allow for another passbook feature update
                    _resetPassbkUpdtFeatInput()
                    Exit Sub
                End If

                'Double check the feature ref is not nothing before using it
                If Not IsNothing(passbkFeat.feature) Then
                    txtFeatToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = passbkFeat.feature.ToString & vbCrLf
                Else
                    MsgBox(_SYS_ERR_FEATOREF_INVALID_MSG, MsgBoxStyle.Critical)
                    'Reset the fields and focus to allow for another passbook feature update
                    _resetPassbkUpdtFeatInput()
                    Exit Sub
                End If

                'Determine if the visitor is a child (< 13 years old) based on the current date/time
                passbkFeat.passbk.visAge = _calcAge(passbkFeat.passbk.visDob)
                passbkFeat.passbk.visIsChild = passbkFeat.passbk.visAge < mADULT_MIN_AGE

                'Populate the visitor text field
                txtVisToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = _
                    "[Visitor] -> " & passbkFeat.passbk.visName _
                    & ", DOB: " & passbkFeat.passbk.visDob _
                    & ", Age: " & passbkFeat.passbk.visAge _
                    & ", IsChild (<13yo): " & IIf(passbkFeat.passbk.visIsChild, "True", "False").ToString

                txtUnitPriceTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = passbkFeat.unitPrice.ToString("C")
                txtTotQtyRemTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = passbkFeat.qtyRemain.ToString("N0")

                'Finally populate the previously used text box
                txtPrevUsedToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Clear()

                Try
                    For Each usedFeat As UsedFeature In _theThemePark.iterateUsedFeat
                        If Not IsNothing(usedFeat.passbkFeat) Then
                            If usedFeat.passbkFeat.id.ToUpper = passbkFeat.id.ToUpper Then
                                txtPrevUsedToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text &= _
                                    usedFeat.ToString & vbCrLf & vbCrLf
                            End If
                        End If
                    Next usedFeat
                Catch ex As Exception
                    MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                    Exit Sub
                End Try

                'If no previously used features were found then just display a default msg
                If txtPrevUsedToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = "" Then
                    txtPrevUsedToStringTabUpdtFeatTbcPassbkFeatMainTbcMain.Text = _
                        "No previously used features have been found"
                End If
            Else
                Dim s As String = "ERROR: PassbookFeature '" & cboVal & "' is invalid. Please select a different ID"
                MsgBox(s, MsgBoxStyle.Exclamation)
                _resetPassbkUpdtFeatInput()
                Exit Sub
            End If
        End If
    End Sub '_cboFeatIdGrpPassbkTabUpdtFeatTbcPassbkFeatMainTbcMain_SelectedIndexChanged(...)

    '****************************************************************************************
    '_cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged() 
    'is the event procedure the is called when the user selects a 
    'passbook feature id from the Update Feature tab. Feature info is 
    'displayed in the associated text fields.
    '****************************************************************************************
    Private Sub _cboPassbkFeatIdTabPostFeatTbcPassbkFeatMainTabPassbkFeatTbcMainFrmMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
          Handles cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain.SelectedIndexChanged

        Dim passbkFeatIdList As ComboBox = cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain

        Dim passbkFeat As PassbookFeature

        'This require a lot of work.  Need to first locate the passbook feature by id.  If found
        'then need to use the passbook reference and find it and the feature reference to find
        'the feature.  Once the passbook is found use the customer reference to locate the 
        'customer.
        If Not passbkFeatIdList.SelectedIndex = -1 Then
            Dim cboVal As String = passbkFeatIdList.SelectedItem.ToString

            'Find the passbook feature by Id
            passbkFeat = _theThemePark.findPassbkFeat(cboVal)

            If Not IsNothing(passbkFeat) Then
                'Can't post to an acct that has no quantity remaining, the feature was totally used
                If passbkFeat.qtyRemain = 0 Then
                    Dim s As String = "INFO: This Passbook Feature has been completedly used.  Please make another selection"
                    MsgBox(s, MsgBoxStyle.OkOnly)
                    txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Enabled = False
                    txtLocTabPostFeatTbcPassbkFeatMainTbcMain.Enabled = False
                Else
                    'Make sure these fields are enabled again in the event they were 
                    txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Enabled = True
                    txtLocTabPostFeatTbcPassbkFeatMainTbcMain.Enabled = True
                End If

                'Double check passbook ref is not nothing before using it
                If Not IsNothing(passbkFeat.passbk) AndAlso Not IsNothing(passbkFeat.passbk.owner) Then
                    txtCustToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = _
                        passbkFeat.passbk.owner.ToString & vbCrLf
                Else
                    Dim s As String
                    If IsNothing(passbkFeat.passbk) Then
                        s = _SYS_ERR_PASSBKOREF_INVALID_MSG
                    Else
                        s = _SYS_ERR_CUSTOREF_INVALID_MSG
                    End If
                    MsgBox(s, MsgBoxStyle.Critical)
                    'Reset the fields and focus to allow for another passbook feature update
                    _resetPassbkUsedFeatInput()
                    Exit Sub
                End If

                'Double check the feature ref is not nothing before using it
                If Not IsNothing(passbkFeat.feature) Then
                    txtFeatToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = passbkFeat.feature.ToString & vbCrLf
                Else
                    MsgBox(_SYS_ERR_FEATOREF_INVALID_MSG, MsgBoxStyle.Critical)
                    'Reset the fields and focus to allow for another passbook feature update
                    _resetPassbkUsedFeatInput()
                    Exit Sub
                End If

                'Populate the visitor text field
                txtVisToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = _
                    "[Visitor] -> " & passbkFeat.passbk.visName _
                    & ", DOB: " & passbkFeat.passbk.visDob _
                    & ", Age: " & passbkFeat.passbk.visAge _
                    & ", IsChild (<13yo): " & IIf(passbkFeat.passbk.visIsChild, "True", "False").ToString

                txtQtyRemTabPostFeatTbcPassbkFeatMainTbcMain.Text = passbkFeat.qtyRemain.ToString("N0")

                'Finally populate the previously used text box
                txtPrevUsedToStringTabPostFeatTbcPassbkFeatMainTbcMain.Clear()
                Try
                    For Each usedFeat As UsedFeature In _theThemePark.iterateUsedFeat
                        If usedFeat.passbkFeat.id = passbkFeat.id Then
                            txtPrevUsedToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text &= _
                                usedFeat.ToString & vbCrLf & vbCrLf
                        End If
                    Next usedFeat
                Catch ex As Exception
                    MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                    Exit Sub
                End Try

                'If no previously used features were found then just display a default msg
                If txtPrevUsedToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = "" Then
                    txtPrevUsedToStringTabPostFeatTbcPassbkFeatMainTbcMain.Text = _
                       "No previously used features have been found"
                End If
            Else
                Dim s As String = "ERROR: UsedFeature '" & cboVal & "' is invalid. Please select a different ID"
                MsgBox(s, MsgBoxStyle.Exclamation)
                _resetPassbkUsedFeatInput()
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
                & vbCrLf & "Project:" & vbTab & "PP04" _
                & vbCrLf _
                & vbCrLf & "Credits:" & vbTab & "Dr. Dan Turk, Dr. Ramadan Abdunabi"

        'MsgBox(about, MsgBoxStyle.OkOnly)
        MessageBox.Show(about, "About '" & _theThemePark.themeParkName & "'", _
           MessageBoxButtons.OK, MessageBoxIcon.Information)

        _writeTransLog(about)
    End Sub '_mnuAboutHelpFrmMain_Click

    '****************************************************************************************
    '_txtQtyTabAddFeatTbcPassbkFeatMainTbcMain_TextChanged() 
    'is the event procedure the is called when the enters a value in the Quantity field of
    'the Purchase Passbook Feature Tab. 
    '****************************************************************************************
    Private Sub _txtQtyTabAddFeatTbcPassbkFeatMainTbcMain_TextChanged(sender As Object, e As EventArgs) _
        Handles txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.TextChanged
        Dim qtyPurch As String = txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text

        ''Need to have a passbook feature selected first
        'If mPassbkFeatUpdt Is Nothing Then
        '    MsgBox("INFO: Please select a Passbook Feature from the list", MsgBoxStyle.Information)
        '    cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Focus()
        '    Exit Sub
        'End If

        'Validate the entered value - it must be an integer value > 0
        If Not Decimal.TryParse(qtyPurch, mQtyPurch) Or mQtyPurch <= 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity > 0 to purchase (ex: 3)", MsgBoxStyle.OkOnly)
            mQtyPurch = 0D
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If

        'Valid quantity was entered so update the unit/purchase price if a feat/passbk have
        'been selected
        If Not IsNothing(mPassBk) AndAlso Not IsNothing(mFeat) Then
            Dim purchPrice As Decimal = mUnitPrice * mQtyPurch
            txtPriceTabAddFeatTbcPassbkFeatMainTbcMain.Text = purchPrice.ToString("C")
        End If
    End Sub '_txtQtyTabAddFeatTbcPassbkFeatMainTbcMain_TextChanged(...)

    '****************************************************************************************
    '_txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain_TextChanged() 
    'is the event procedure the is called when the enters a value in the Quantity field of
    'the Purchase Passbook Feature Tab. 
    '****************************************************************************************
    Private Sub _txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain_TextChanged(sender As Object, e As EventArgs) _
          Handles txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.TextChanged
        Dim qtyUsed As String = txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Text

        'Validate the entered value - it must be an integer value > 0
        If Not Decimal.TryParse(qtyUsed, mQtyUsed) Or mQtyUsed < 0 Then
            MsgBox("ERROR: Please enter a numeric Quantity > 0 to post (ex: 3)", MsgBoxStyle.OkOnly)
            mQtyUsed = 0D
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.SelectAll()
            txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain.Focus()
            Exit Sub
        End If
    End Sub '_txtQtyUsedTabPostFeatTbcPassbkFeatMainTbcMain_TextChanged(...)

    '****************************************************************************************
    '_btnImportDataTabSysTestTbcMainFrmMain_Click() 
    'is the event procedure the is called when the clicks on the 'Import Data' button from
    'the System Test tab. It is used to import a predefined data set into the system.
    '****************************************************************************************
    Private Sub _btnImportDataTabSysTestTbcMainFrmMain_Click(sender As Object, e As EventArgs) _
        Handles btnImportDataTabSysTestTbcMainFrmMain.Click

        'Give user the option to abort the import
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To continue with the Import from '" & IMPORT_FILENAME _
                            & "' Click OK, otherwise Cancel", MsgBoxStyle.OkCancel)

            'If OK selected proceed with the submission assuming not test data
            If choice = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        End If

        Try
            'Indicate to that the system test is running
            _sysTestActive = True

            _theThemePark.importData(IMPORT_FILENAME, ERROR_FILENAME)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        Finally
            'Indicate to that the system test is complete
            _sysTestActive = False
        End Try
    End Sub '_btnImportDataTabSysTestTbcMainFrmMain_Click(...)

    '****************************************************************************************
    '_btnExportDataGrpSysTestTabSysTestTbcMainFrmMain_Click() 
    'is the event procedure the is called when the clicks on the 'Export Data' button from
    'the System Test tab. It is used to export the current set of transactions to a file.
    '****************************************************************************************
    Private Sub _btnExportDataGrpSysTestTabSysTestTbcMainFrmMain_Click(sender As Object, e As EventArgs) _
        Handles btnExportDataGrpSysTestTabSysTestTbcMainFrmMain.Click
        Dim append As Boolean = chkAppendTabSysTestTbcMainFrmMain.Checked

        'Give user the option to abort the import
        Dim choice As MsgBoxResult = MsgBoxResult.Ok

        'The following is only needed if system test data is NOT being processed
        If _sysTestActive = False Then
            choice = MsgBox("To continue with the Export to '" & EXPORT_FILENAME _
                            & "' Click OK, otherwise Cancel", MsgBoxStyle.OkCancel)

            'If OK selected proceed with the submission assuming not test data
            If choice = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        End If

        _theThemePark.exportData(EXPORT_FILENAME, append)
    End Sub '_btnExportDataGrpSysTestTabSysTestTbcMainFrmMain_Click(...)


    '****************************************************************************************
    '_btnParkStatTabTransLogTbcMain_Click() 
    'is the event procedure the is called when the clicks on the 'Park Status' button from
    'the Transaction Log tab. It is used to show the current park status.
    '****************************************************************************************
    Private Sub _btnParkStatTabTransLogTbcMain_Click(sender As Object, e As EventArgs) _
        Handles btnParkStatTabTransLogTbcMain.Click
        _writeTransLog(_theThemePark.ToString)
    End Sub '_btnParkStatTabTransLogTbcMain_Click(...)



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
        If IsNothing(cust) Then
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Update associated UI components with component values
        With cust
            lstCustTabDashboardTbcMain.Items.Add(.custId)
            txtCustCntTabDashboardTbcMain.Text = _
                lstCustTabDashboardTbcMain.Items.Count.ToString

            cboCustIdGrpCustInfoGrpAddPassbkTabPassbkTbcMainFrmMain.Items.Add(.custId)
        End With

        'Update the KPI - not really needed here but do it anyway
        _dispKpi()

        'Write transaction record and log info
        _theThemePark.writeTransxRec(_theThemePark.transxCustType, Nothing, cust)
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
        If IsNothing(feat) Then
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Update associated UI components with component values
        With feat
            lstFeatTabDashboardTbcMain.Items.Add(.featId)
            txtFeatCntTabDashboardTbcMain.Text = _
                lstFeatTabDashboardTbcMain.Items.Count.ToString

            cboFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Items.Add(.featId)
        End With

        'Update the KPI - not really needed here but do it anyway
        _dispKpi()

        'Write transaction record and log info
        _theThemePark.writeTransxRec(_theThemePark.transxFeatType, Nothing, feat)
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
        Dim passbk As Passbook

        'Get/validate data
        themePark_EventArgs_CreatePassbk = CType(e, ThemePark_EventArgs_CreatePassbk)

        'Use the past in object to populate the necessary system components
        passbk = themePark_EventArgs_CreatePassbk.passbook

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If IsNothing(passbk) Then
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Update associated UI components with component values
        With passbk
            lstPassbkTabDashboardTbcMain.Items.Add(.passbkId)
            txtPassbkCntTabDashboardTbcMain.Text =
                lstPassbkTabDashboardTbcMain.Items.Count.ToString

            cboPassbkIdTabAddFeatTbcPassbkFeatMainTbcMain.Items.Add(.passbkId)
        End With

        'Update the KPI
        _dispKpi()

        'Write transaction record and log info
        _theThemePark.writeTransxRec(_theThemePark.transxPassbkType, Nothing, passbk)
        _writeTransLog("<CREATED>: " & passbk.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook creation submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_createPassbk(...)

    '****************************************************************************************
    '_purchPassbkFeat() handles processing for the ThemePark_PurchFeat
    ' event that is generated when a feature has been purchased fo
    'a specified passbook
    '****************************************************************************************
    Private Sub _purchPassbkFeat(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_PurchPassbkFeat

        'Declare variables
        Dim themePark_EventArgs_PurchFeat As ThemePark_EventArgs_PurchPassbkFeat
        Dim passbkFeat As PassbookFeature

        'Get/validate data
        themePark_EventArgs_PurchFeat = CType(e, ThemePark_EventArgs_PurchPassbkFeat)

        'Use the past in object to populate the necessary system components
        passbkFeat = themePark_EventArgs_PurchFeat.passbkFeat

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If IsNothing(passbkFeat) Then
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Update associated UI components with component values
        With passbkFeat
            lstPassbkFeatTabDashboardTbcMain.Items.Add(.id)
            txtPassbkFeatCntTabDashboardTbcMain.Text =
                lstPassbkFeatTabDashboardTbcMain.Items.Count.ToString()

            cboFeatIdTabUpdtFeatTbcPassbkFeatMainTbcMain.Items.Add(.id)
            cboFeatIdTabPostFeatTbcPassbkFeatMainTbcMain.Items.Add(.id)
        End With

        'Update the KPI
        _dispKpi()

        'Write transaction record and log info
        _theThemePark.writeTransxRec(_theThemePark.transxPassbkFeatType,
                                    _theThemePark.transxPbfPurchType,
                                    passbkFeat)
        _writeTransLog("<PURCHASED>: " & passbkFeat.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Passbook Feature submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_purchPassbkFeat(...)

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

        'Make sure we actually have passbk object.  There is the slight chance
        'that the New () could have failed.
        If IsNothing(passbkFeat) Then
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Update the KPI
        _dispKpi()

        'Write transaction record and log info
        _theThemePark.writeTransxRec(_theThemePark.transxPassbkFeatType,
                                    _theThemePark.transxPbfUpdtType,
                                    passbkFeat)
        _writeTransLog("<UPDATED>: " & passbkFeat.ToString)

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
        If IsNothing(usedFeat) AndAlso IsNothing(usedFeat.passbkFeat) Then
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Validate the input
        'If _validatePostData(usedFeat.id, usedFeat.passbkFeat.id, _
        '                     usedFeat.qtyUsed.ToString, usedFeat.loc) Then
        '    'Update associated UI components with component values
        With usedFeat
            lstUsedFeatTabDashboardTbcMain.Items.Add(.id)
            lstUsedFeatCntTabDashboardTbcMain.Text =
                lstUsedFeatTabDashboardTbcMain.Items.Count.ToString
        End With

        'Update the KPI
        _dispKpi()

        'Write transaction record and log info
        _theThemePark.writeTransxRec(_theThemePark.transxPassbkFeatType,
                                    _theThemePark.transxPbfUseType,
                                    usedFeat)
        _writeTransLog("<USED>: " & usedFeat.ToString())

        'Not needed if object was created from system test data
        If _sysTestActive = False Then
            _writeTransLog("<STATUS>: " & _theThemePark.ToString())

            MsgBox("Used Passbook Feature submission was successful!", MsgBoxStyle.OkOnly)
        End If
    End Sub '_usedFeat(...)

    '****************************************************************************************
    '_logTran() handles processing for the ThemePark_LogTran
    ' event that is generated as necessary by the ThemePark object
    '****************************************************************************************
    Private Sub _logTran(ByVal sender As System.Object, _
                         ByVal e As System.EventArgs) _
        Handles mThemePark.ThemePark_LogTran

        'Declare variables
        Dim themePark_EventArgs_LogTran As ThemePark_EventArgs_LogMsg
        Dim logMsg As String

        'Get/validate data
        themePark_EventArgs_LogTran = CType(e, ThemePark_EventArgs_LogMsg)

        'Use the past in object to populate the necessary system components
        logMsg = themePark_EventArgs_LogTran.logMsg

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If IsNothing(logMsg) Then
            MsgBox(_SYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        _writeTransLog("<LOGTRAN>: " & logMsg)
    End Sub '_logTran(...)

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
        Handles btnShowCust.Click

        'Clear out old contents
        txtDebug.Clear()

        If _theThemePark.numCusts = 0 Then
            txtDebug.Text = "No Customer data to display" & vbCrLf
        Else
            Try
                For Each cust As Customer In _theThemePark.iterateCust
                    txtDebug.Text &= cust.ToString & vbCrLf
                Next cust
            Catch ex As Exception
                MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub _btnShowPassbk_Click(sender As Object, e As EventArgs) _
    Handles btnShowPassbk.Click

        'Clear out old contents
        txtDebug.Clear()

        If _theThemePark.numPassbks = 0 Then
            txtDebug.Text = "No Passbook data to display" & vbCrLf
        Else
            Try
                For Each passbk As Passbook In _theThemePark.iteratePassbk
                    txtDebug.Text &= passbk.ToString & vbCrLf
                Next passbk
            Catch ex As Exception
                MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub _btnShowFeat_Click(sender As Object, e As EventArgs) _
        Handles btnShowFeat.Click

        'Clear out old contents
        txtDebug.Clear()

        If _theThemePark.numFeats = 0 Then
            txtDebug.Text = "No Feature data to display" & vbCrLf
        Else
            Try
                For Each feat As Feature In _theThemePark.iterateFeat
                    txtDebug.Text &= feat.ToString & vbCrLf
                Next feat
            Catch ex As Exception
                MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub _btnShowPassbkFeat_Click(sender As Object, e As EventArgs) _
        Handles btnShowPassbkFeat.Click

        'Clear out old contents
        txtDebug.Clear()

        If _theThemePark.numPassbkFeats = 0 Then
            txtDebug.Text = "No Passbook Feature data to display" & vbCrLf
        Else
            Try
                For Each passbkFeat As PassbookFeature In _theThemePark.iteratePassbkFeat
                    txtDebug.Text &= passbkFeat.ToString & vbCrLf
                Next passbkFeat
            Catch ex As Exception
                MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub _btnShowUsedFeat_Click(sender As Object, e As EventArgs) _
        Handles btnShowUsedFeat.Click

        'Clear out old contents
        txtDebug.Clear()

        If _theThemePark.numUsedFeats = 0 Then
            txtDebug.Text = "No Used Feature data to display" & vbCrLf
        Else
            Try
                For Each usedFeat As UsedFeature In _theThemePark.iterateUsedFeat
                    txtDebug.Text &= usedFeat.ToString & vbCrLf
                Next usedFeat
            Catch ex As Exception
                MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub _btnShowTransx_Click(sender As Object, e As EventArgs) _
        Handles btnShowTransx.Click

        'Clear out old contents
        txtDebug.Clear()

        If _theThemePark.numTransx = 0 Then
            txtDebug.Text = "No Transactions to display" & vbCrLf
        Else
            Try
                For Each transx As String In _theThemePark.iterateTransx
                    txtDebug.Text &= transx.ToString & vbCrLf
                Next transx
            Catch ex As Exception
                MsgBox(_SYS_ERR_DATASTORE_ACCESS_MSG, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub _btnRecalcCntTabDashboardTbcMain_Click(sender As Object, e As EventArgs) _
        Handles btnRecalcCntTabDashboardTbcMain.Click
        '.WriteLine("Calculate the KPIs")
        _dispKpi()
    End Sub '_btnRecalcCntTabDashboardTbcMain_Click(...)

#End Region 'Palumbo-Debug

End Class 'FrmMain