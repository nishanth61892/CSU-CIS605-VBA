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

    'Minimum age to be considered an adult. Less than this age is 
    'thusly considered a child
    Private Const mADULT_MIN_AGE As Integer = 13

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

    '_tabPostFeatTbcPassbkFeatMainTbcMain_Enter() simply assigns the AcceptButton to the
    'Submit button on this tab.
    Private Sub _tabPostFeatTbcPassbkFeatMainTbcMain_Enter(sender As Object, e As EventArgs) Handles _
        tabPostFeatTbcPassbkFeatMainTbcMain.Enter

        'Assign AcceptButton to this tab's Submit button for convenience
        Me.AcceptButton = btnSubmitTabPostFeatTbcPassbkFeatMainTbcMain
    End Sub '_tabPostFeatTbcPassbkFeatMainTbcMain_Enter(...)

    '_tabUpdtFeatTbcPassbkFeatMainTbcMain_Enter() simply assigns the AcceptButton to the
    'Submit button on this tab.
    Private Sub _tabUpdtFeatTbcPassbkFeatMainTbcMain_Enter(sender As Object, e As EventArgs) Handles tabUpdtFeatTbcPassbkFeatMainTbcMain.Enter

        'Assign AcceptButton to this tab's Submit button for convenience
        Me.AcceptButton = btnSubmitTabUpdtFeatTbcPassbkFeatMainTbcMain
    End Sub '_tabUpdtFeatTbcPassbkFeatMainTbcMain_Enter(...)

    '_tabPassbkFeatTbcMainFrmMain_Enter() simply assigns the AcceptButton to the
    'Submit button on the Add Feature tab. This is when the user enter the Passbook
    'Feature tab for the first time.
    Private Sub _tabPassbkFeatTbcMainFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        tabPassbkFeatTbcMainFrmMain.Enter

        _tabAddFeatTbcPassbkFeatMainTbcMain_Enter(sender, e)
    End Sub '_tabPassbkFeatTbcMainFrmMain_Enter(...)

    '_tabAddFeatTbcPassbkFeatMainTbcMain_Enter() simply assigns the AcceptButton to the
    'Submit button on this tab.
    Private Sub _tabAddFeatTbcPassbkFeatMainTbcMain_Enter(sender As Object, e As EventArgs) Handles _
        tabAddFeatTbcPassbkFeatMainTbcMain.Enter

        'Assign AcceptButton to this tab's Submit button for convenience
        Me.AcceptButton = btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain
    End Sub '_tabAddFeatTbcPassbkFeatMainTbcMain_Enter(...)

    '_tabSysTestTbcMainFrmMain_Enter() simply assigns the AcceptButton to the
    'Clear button on this tab.
    Private Sub _tabSysTestTbcMainFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        tabSysTestTbcMainFrmMain.Enter

        'Assign AcceptButton to this tab's 'Process Test Data' button for convenience
        Me.AcceptButton = btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain
    End Sub '_tabSysTestTbcMainFrmMain_Enter(...)

    '_tabTransLogTbcMainFrmMain_Enter() simply assigns the AcceptButton to the
    'Clear button on this tab.
    Private Sub _tabTransLogTbcMainFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        tabTransLogTbcMainFrmMain.Enter

        'Assign AcceptButton to this tab's Clear button for convenience
        Me.AcceptButton = btnClearTabTransLogTbcMainFrmMain
    End Sub '_tabTransLogTbcMainFrmMain_Enter(...)

    '_tabPassbkTbcMainFrmMain_Enter() simply assigns the AcceptButton to the
    'Submit button on this tab.
    Private Sub _tabPassbkTbcMainFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        tabPassbkTbcMainFrmMain.Enter

        'Assign AcceptButton to this tab's Submit button for convenience
        Me.AcceptButton = btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain
    End Sub '_tabPassbkTbcMainFrmMain_Enter(...)

    '_tabFeatTbcMainFrmMain_Enter() simply assigns the AcceptButton to the
    'Submit button on this tab.
    Private Sub _tabFeatTbcMainFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        tabFeatTbcMainFrmMain.Enter

        'Assign AcceptButton to this tab's Submit button for convenience
        Me.AcceptButton = btnSubmitGrpAddFeatTabFeatTbcMainFrmMain
    End Sub '_tabFeatTbcMainFrmMain_Enter(...)

    '_tabCustTbcMainFrmMain_Enter() simply assigns the AcceptButton to the
    'Submit button on this tab.
    Private Sub _tabCustTbcMainFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        tabCustTbcMainFrmMain.Enter

        'Assign AcceptButton to this tab's Submit button for convenience
        Me.AcceptButton = btnSubmitGrpCustInfoTabCustTbcMainFrmMain
    End Sub '_tabFeatTbcMainFrmMain_Enter(...)

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

        choice = MsgBox("To create a new Feature with these attribute Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
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

            writeTransLog("<CREATED>: " & newCust.ToString())

            MsgBox("Customer creation was successful!", MsgBoxStyle.OkOnly)

            'Reset the fields and focus to allow for another feature to be added
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Text = ""
            txtCustNameGrpAddCustTabCustTbcMainFrmMain.Text = ""
            txtCustIdGrpAddCustTabCustTbcMainFrmMain.Focus()
        End If

    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

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

        choice = MsgBox("To create a new Feature with these attribute Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
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

            writeTransLog("<CREATED>: " & newFeat.ToString())

            MsgBox("Feature creation was successful!", MsgBoxStyle.OkOnly)

            'Reset the fields and focus to allow for another feature to be added
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtFeatNameGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtUnifOfMeasGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceAdultGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtPriceChildGrpAddFeatTabFeatTbcMainFrmMain.Text = ""
            txtFeatIdAddFeatTabFeatTbcMainFrmMain.Focus()
        End If

    End Sub '_btnSubmitGrpCustInfoTabCustTbcMainFrmMain_Click(...)

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

        choice = MsgBox("To create a new Passbook with these attribute Click OK, otherwise Cancel" & vbCrLf & vbCrLf _
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

            writeTransLog("<CREATED>: " & newPassbk.ToString())

            MsgBox("Passbook creation was successful!", MsgBoxStyle.OkOnly)

            'Reset the fields and focus to allow for another feature to be added
            txtPassbkIdGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
            txtVisNameGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
            txtVisDobGrpAddPassbkTabPassbkTbcMainFrmMain.Text = ""
        End If

    End Sub '_btnSubmitGrpAddPassbkTabPassbkTbcMainFrmMain_Click(...)

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

        totPurchPrice = unitPurchPrice * decQtyPurch

        'Verify the purchase before committing
        Dim choice As MsgBoxResult

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

            writeTransLog("<PURCHASED>: " & newPassbkFeat.ToString())

            MsgBox("Passbook Feature purchase was successful!", MsgBoxStyle.OkOnly)

            'Reset the fields and focus to allow for another feature to be added
            txtPassBkFeatIdTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
            txtQtyTabAddFeatTbcPassbkFeatMainTbcMain.Text = ""
        End If

    End Sub '_btnSubmitTabAddFeatTbcPassbkFeatMainTbcMain_Click(...)

    '_btnCalcTabAddFeatTbcPassbkFeatMainTbcMain_Click() is the event procedure that gets called when the user
    'clicks on the Calc button from the Add Feature tab.  It calculates and display the current total cost
    'to purchase the selected feature based on age and quantity.
    Private Sub _btnCalcTabAddFeatTbcPassbkFeatMainTbcMain_Click(sender As Object, e As EventArgs) Handles _
            btnCalcTabAddFeatTbcPassbkFeatMainTbcMain.Click

    End Sub '_btnCalcTabAddFeatTbcPassbkFeatMainTbcMain_Click(...)

    '_btnClearTabTransLogTbcMainFrmMain_Click() is the event procedure that gets called when the user
    'clicks on the Clear button from the Tranaaction log tab.  It clears the log.
    Private Sub _btnClearTabTransLogTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnClearTabTransLogTbcMainFrmMain.Click

        'Reset the transaction log
        txtTransLogTabTransLogTbcMainFrmMain.Text = ""
    End Sub '_btnClearTabTransLogTbcMainFrmMain_Click(...)

    '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click() is the event procedure that gets called when 
    'the user clicks on the 'Process Test Data' button from the System Test tab.  It automates testing of 
    'existing functionality of the system.  Results are output in the transaction log.
    Private Sub _btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain.Click

        'The theme park
        Dim themePark As ThemePark = New ThemePark("World's Of Fun Theme Park")

        'Customers
        themePark.createCustomer("0001", "Smith, John")
        themePark.createCustomer("0002", "Jone, James")
        themePark.createCustomer("0003", "Johnson, Robert")

        Dim cust1 As Customer = New Customer("0001", "Smith, John")
        Dim cust2 As Customer = New Customer("0002", "Jones, James")
        Dim cust3 As Customer = New Customer("0003", "Johnson, Robert")

        'Features
        Dim feat1 As Feature = New Feature("1001", "Park Pass", "Day", 12.5D, 0)
        Dim feat2 As Feature = New Feature("1002", "Gate Pass", "Day", 35.95D, 22.95D)
        Dim feat3 As Feature = New Feature("1003", "Meal Plan", "Week", 65.95D, 31.95D)

        'Passbooks
        Dim passbk1 As Passbook = New Passbook("2001", cust1, #2/8/2014#, "Smith, Will", #3/14/2001#, 14, False)
        Dim passbk2 As Passbook = New Passbook("2002", cust2, #6/14/2015#, "Jones, Jennifer", #7/21/1975#, 40, False)
        Dim passbk3 As Passbook = New Passbook("2003", cust3, #11/23/2011#, "Johnson, Brian", #12/14/2008#, 7, True)
    End Sub '_btnProcTestDataGrpSysTestTabSysTestTbcMainFrmMain_Click(...)

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