'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch05Ex01
'File:          FrmMain.vb
'Author:        Robert Palumbo
'Description:   This is the main user interface form for the 
'               Ch05Ex01 Visual Basic program which simulates
'               a Snowshoe Marketplace System.
'
'Date:          11/08/2015
'                  - Initial creation
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

    '********** Module-level constants

    '********** Module-level variables

    'The Snowshoe Store Object
    Private WithEvents mSnowshoeStore As SnowshoeStore

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
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _snowshoeStore As SnowshoeStore
        Get
            Return mSnowshoeStore
        End Get
        Set(pValue As SnowshoeStore)
            mSnowshoeStore = pValue
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
    '_closeAppl() is used to simply close the application when requested.
    '****************************************************************************************
    Private Sub _closeAppl()
        'Notify the user application is closing
        MsgBox("Closing application...press OK to continue.",
                MsgBoxStyle.OkOnly)

        Me.Close()
    End Sub '_closeAppl()

    '****************************************************************************************
    '_initializeToolTips to assist the user
    '****************************************************************************************
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
        'Create the Snowshoe Store for now
        _snowshoeStore = New SnowshoeStore
        _writeTransLog("[SnowshoeStore-Created] -> " & _snowshoeStore.ToString)

        'load some test data, user can add more later
        _processTestData()
    End Sub '_initializeBusinessLogic()

    '****************************************************************************************
    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    '****************************************************************************************
    Private Sub _initializeUserInterface()
        'Assign CancelButton so the 'Esc' key will activate the 'Exit' button
        Me.CancelButton = btnExitFrmMain

        'Assign the AcceptButton so the 'Enter' key will activate the 'Confirm' button
        'Center the main form on the display
        Me.StartPosition = FormStartPosition.CenterScreen

        'This is only enabled for rentals
        nudRentalDaysGrpTransDetail.Enabled = False

        'select the first snowshoe by default
        If lstSnowshoeNameGrpTransDetail.Items.Count > 0 Then
            lstSnowshoeNameGrpTransDetail.SelectedIndex = 0
        End If
    End Sub 'initializeUserInterface()

    '****************************************************************************************
    '_writeTransLog() procedure does all the work to write a 
    'message to the transaction log.hat write the specified string to 
    'the transaction log.
    '****************************************************************************************
    Private Sub _writeTransLog(ByVal pLogMsg As String)
        txtTransLogFrmMain.Text &= _
            DateAndTime.DateString & ":" & DateAndTime.TimeString & "::"

        txtTransLogFrmMain.Text &= pLogMsg & vbCrLf
    End Sub '_writeTransLog(...)

    '****************************************************************************************
    '_dispStkMktState() procedure that simply displays the
    'current state of the Snowshoe Marketplace state in the 
    'transaction log.
    '****************************************************************************************
    Private Sub _dispStoreState()
        _writeTransLog("[SnowshoeStore-CurrentState] " & _snowshoeStore.ToString)
    End Sub 'dispStoreState()

    '****************************************************************************************
    '_updateSummaryCurrent() is the procedure that updates current transaction amounts
    '****************************************************************************************
    Private Sub _updateSummaryCurrent(ByVal pTransRec As SnowshoeTransRec)
        Dim extPrice As Decimal = 0D
        Dim memDiscnt As Decimal = 0D
        Dim preTaxPrice As Decimal = 0D
        Dim salesTaxPrice As Decimal = 0D
        Dim totalCost As Decimal = 0D

        'If there is transaction record we can update the UI with current info
        'otherwise just reset the values
        If Not IsNothing(pTransRec) Then
            With pTransRec
                extPrice = .extPrice
                memDiscnt = .memDiscnt
                preTaxPrice = .preTaxPrice
                salesTaxPrice = .preTaxPrice
                totalCost = .totalTransCost
            End With
        End If

        'display output
        txtExtPriceCurrTransSummaryInfo.Text = extPrice.ToString("N2")
        txtMemDiscntCurrGrpSummaryInfo.Text = memDiscnt.ToString("N2")
        txtPreTaxCurrGrpSummaryInfo.Text = preTaxPrice.ToString("N2")
        txtTaxCurrGrpSummaryInfo.Text = salesTaxPrice.ToString("N2")
        txtTotalCostCurrGrpSummaryInfo.Text = totalCost.ToString("N2")
    End Sub '_updateSummaryInfo()

    '****************************************************************************************
    '_updateSummaryInfoTotals() is the procedure that updates total transaction amounts
    '****************************************************************************************
    Private Sub _updateSummaryInfoTotals(ByVal pSnowshoeStore As SnowshoeStore)
        Dim extPrice As Decimal
        Dim memDiscnt As Decimal
        Dim preTaxPrice As Decimal
        Dim salesTax As Decimal
        Dim totalCost As Decimal
        Dim transCnt As Integer

        'If there is transaction record we can update the UI with current info
        'otherwise just reset the values
        If Not IsNothing(pSnowshoeStore) Then
            With pSnowshoeStore
                extPrice = .extPriceTotal
                memDiscnt = .membDiscntTotal
                preTaxPrice = .preTaxTotal
                salesTax = .taxTotal
                totalCost = .totPriceTotal
                transCnt = .snowshoeTransCnt
            End With
        End If

        'display output
        txtExtPriceTotalGrpSummaryInfo.Text = extPrice.ToString("N2")
        txtMemDiscntTotalGrpSummaryInfo.Text = memDiscnt.ToString("N2")
        txtPreTaxTotalGrpSummaryInfo.Text = preTaxPrice.ToString("N2")
        txtTaxTotalGrpSummaryInfo.Text = salesTax.ToString("N2")
        txtTotalCostTotalGrpSummaryInfo.Text = totalCost.ToString("N2")
        txtTransCntTotalGrpSummaryInfo.Text = transCnt.ToString()
    End Sub '_updateSummaryInfoTotals()

    '****************************************************************************************
    '_updateSummaryInfoCurrent() is the procedure that the transaction summary group information
    'based upon input field changes made by the user.
    '****************************************************************************************
    Private Sub _updateSummaryInfoCurrent(ByVal pTransRec As SnowshoeTransRec)
        Dim extPrice As Decimal
        Dim memDiscnt As Decimal
        Dim preTaxPrice As Decimal
        Dim salesTax As Decimal
        Dim totalCost As Decimal

        'If there is transaction record we can update the UI with current info
        'otherwise just reset the values
        If Not IsNothing(pTransRec) Then
            With pTransRec
                extPrice = .extPrice
                memDiscnt = .memDiscnt
                preTaxPrice = .preTaxPrice
                salesTax = .salesTax
                totalCost = .totalTransCost
            End With
        End If

        'display output
        txtExtPriceCurrTransSummaryInfo.Text = extPrice.ToString("N2")
        txtMemDiscntCurrGrpSummaryInfo.Text = memDiscnt.ToString("N2")
        txtPreTaxCurrGrpSummaryInfo.Text = preTaxPrice.ToString("N2")
        txtTaxCurrGrpSummaryInfo.Text = salesTax.ToString("N2")
        txtTotalCostCurrGrpSummaryInfo.Text = totalCost.ToString("N2")
    End Sub '_updateSummaryInfoCurrent()


    '****************************************************************************************
    '_updateFromUserInputs() is the procedure that determines which fields on the UI that the
    'user has modified and processes them according to the required business logic.
    '****************************************************************************************
    Private Sub _updateFromUserInputs()
        Dim snowshoeName As String = ""
        Dim snowshoePurchPrice As Decimal
        Dim snowshoeRentalPrice As Decimal
        Dim pairsCnt As Integer
        Dim daysToRent As Integer
        Dim isMember As Boolean
        Dim isRental As Boolean

        'First update based on any snowshoe selection from the list
        If lstSnowshoeNameGrpTransDetail.SelectedIndex >= 0 Then
            snowshoeName = lstSnowshoeNameGrpTransDetail.SelectedItem.ToString
            snowshoePurchPrice = Convert.ToDecimal(lstSnowshoePurchPriceGrpTransDetail.SelectedItem)
            snowshoeRentalPrice = Convert.ToDecimal(lstSnowshoeRentPriceGrpTransDetail.SelectedItem)
        End If

        pairsCnt = Convert.ToInt16(nudPairsCntGrpTransDetail.Value)
        isRental = chkIsRentalGrpTransDetail.Checked
        isMember = chkIsMemberGrpTransDetail.Checked
        daysToRent = Convert.ToInt16(nudRentalDaysGrpTransDetail.Value)

        'We have all the info we need to simulate a transaction/update system as needed
        Dim snowshoe = New Snowshoe(snowshoeName, snowshoePurchPrice, snowshoeRentalPrice)
        Dim snowshoeTransRec = New SnowshoeTransRec(snowshoe, pairsCnt, isRental, daysToRent, isMember)

        '_update the user interface summary info
        _updateSummaryInfoCurrent(snowshoeTransRec)
        _updateSummaryInfoTotals(_snowshoeStore)
    End Sub '_updateFromUserInputs()

    '****************************************************************************************
    '_resetUserInputs() is used to reset user inputs back to the default settings.
    '****************************************************************************************
    Private Sub _resetUserInputs()
        'only set the primary list control to 0 (first element) if there are actually
        'elements in the list
        If (lstSnowshoeNameGrpTransDetail.Items.Count > 0) Then
            lstSnowshoeNameGrpTransDetail.SelectedIndex = 0
        End If

        nudPairsCntGrpTransDetail.Value = 1
        nudRentalDaysGrpTransDetail.Value = 1
        chkIsMemberGrpTransDetail.Checked = False
        chkIsRentalGrpTransDetail.Checked = False
    End Sub '_resetUserInputs(...)

    '****************************************************************************************
    '_userInputChanged() is used to make any UI updates based on the fact that the user
    'has modified 1 or more input field changes.  This one procedure handles all input
    'field updates.
    '****************************************************************************************
    Private Sub _userInputChanged( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) _
    Handles _
        lstSnowshoeNameGrpTransDetail.SelectedIndexChanged, _
        chkIsRentalGrpTransDetail.CheckedChanged, _
        chkIsMemberGrpTransDetail.CheckedChanged, _
        nudPairsCntGrpTransDetail.ValueChanged, _
        nudRentalDaysGrpTransDetail.ValueChanged

        'The user has modified something on the GUI so it has to be processed
        _updateFromUserInputs()
    End Sub '_userInputChanged()

    '****************************************************************************************
    '_processTestData() is the procedure loads the system with specific test data as a 
    'result of the user clicking on the 'Process Test Data' button.
    '****************************************************************************************
    Private Sub _processTestData()
        Static Dim firstTime As Boolean = True
        Dim snowshoe1 As Snowshoe
        Dim snowshoe2 As Snowshoe
        Dim snowshoe3 As Snowshoe
        Dim snowshoe4 As Snowshoe
        Dim snowshoe5 As Snowshoe
        Dim snowshoe6 As Snowshoe

        If firstTime = True Then
            snowshoe1 = New Snowshoe("MSR Lightning Ascent", 295.95D, 12D)
            snowshoe2 = New Snowshoe("Tubbs Mountaineer 30", 259.95D, 10D)
            snowshoe3 = New Snowshoe("MSR Denali Evo Ascent", 224.95D, 8D)
            snowshoe4 = New Snowshoe("Yukon Charlie's Trail 930", 99.95D, 7D)
            snowshoe5 = New Snowshoe("MSR Denali Tyker - Kids", 55.95D, 6D)
            snowshoe6 = New Snowshoe("Redfeather Snowpaws - Kids", 25.5D, 5D)
            firstTime = False
        Else
            snowshoe1 = New Snowshoe("MSR Lightning Ascent II", 395.95D, 18D)
            snowshoe2 = New Snowshoe("Tubbs Mountaineer 75", 359.95D, 15D)
            snowshoe3 = New Snowshoe("MSR Everest 1000", 245.95D, 10D)
            snowshoe4 = New Snowshoe("Tubbs Mountaineer 60", 120D, 9D)
            snowshoe5 = New Snowshoe("MSR Everest 100 - Kids", 55.95D, 6D)
            snowshoe6 = New Snowshoe("Redfeather Snowpaws III - Kids", 15.5D, 3D)
        End If

        Dim snowshoeTrans1 As SnowshoeTransRec = _
            New SnowshoeTransRec(snowshoe4, 10, True, 10, True)
        Dim snowshoeTrans2 As SnowshoeTransRec = _
            New SnowshoeTransRec(snowshoe4, 10, True, 10, False)
        Dim snowshoeTrans3 As SnowshoeTransRec = _
            New SnowshoeTransRec(snowshoe4, 10, False, 10, False)
        Dim snowshoeTrans4 As SnowshoeTransRec = _
            New SnowshoeTransRec(snowshoe4, 10, False, 10, True)

        'Add Snowshoes
        _snowshoeStore.snowshoeAdd(snowshoe1)
        _snowshoeStore.snowshoeAdd(snowshoe2)
        _snowshoeStore.snowshoeAdd(snowshoe3)
        _snowshoeStore.snowshoeAdd(snowshoe4)
        _snowshoeStore.snowshoeAdd(snowshoe5)
        _snowshoeStore.snowshoeAdd(snowshoe6)

        'Transactions
        _snowshoeStore.snowshoePurchase(snowshoeTrans1)
        _snowshoeStore.snowshoePurchase(snowshoeTrans2)
        _snowshoeStore.snowshoeRental(snowshoeTrans3)
        _snowshoeStore.snowshoeRental(snowshoeTrans4)
        _snowshoeStore.snowshoePurchase(snowshoeTrans3)
        _snowshoeStore.snowshoePurchase(snowshoeTrans4)
        _snowshoeStore.snowshoeRental(snowshoeTrans1)
        _snowshoeStore.snowshoeRental(snowshoeTrans2)
    End Sub '_processTestData()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '****************************************************************************************
    'Event Procedures
    '****************************************************************************************

    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '****************************************************************************************
    '_btnExitFrmMain_Click() is the event procedure that gets called when the
    'user clicks on the Exit button or by using Alt-E hotkey sequence.
    'It is used to notify the user and formally terminate the program.
    '****************************************************************************************
    Private Sub _btnExitFrmMain_Click(sender As Object, e As EventArgs) _
        Handles btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()
    End Sub '_btnExitFrmMain_Click(...)

    '****************************************************************************************
    '_chkRental_CheckedChanged() is the event procedure that gets called when the user toggles
    'the 'Rent?' check box.  This event triggers the toggling of the 'Rental Days?' indicator
    'as well.  This is only enabled if the user wants to rent snowshoes
    '****************************************************************************************
    Private Sub _chkRental_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkIsRentalGrpTransDetail.CheckedChanged

        nudRentalDaysGrpTransDetail.Enabled = CBool(IIf(chkIsRentalGrpTransDetail.Checked = True, True, False))
    End Sub '_chkRental_CheckedChanged(...)

    '****************************************************************************************
    '_btnRunTestData_Click() is the event procedure that gets called when the user clicks 
    'on the 'Run Test-Data' button or by using the Alt-R hotkey sequence.  It populates
    'the system with sample test data to verify system integrity.
    '****************************************************************************************
    Private Sub _btnClearGrpPurch_Click(sender As Object, e As EventArgs) _
        Handles btnClearGrpTransDetail.Click

        _resetUserInputs()
    End Sub '_btnClearGrpPurch_Click(...)

    '****************************************************************************************
    '_btnDispStoreInfo_Click() is the event procedure that gets called when the user 
    'clicks on the 'Display Store Info' button or by using the Alt-D hotkey sequence.
    'It simply outputs the current state of the system in the transaction log for viewing.
    '****************************************************************************************
    Private Sub _btnDispStoreInfo_Click(sender As Object, e As EventArgs) _
        Handles btnDispStoreInfo.Click

        _dispStoreState()
    End Sub '_btnDispStoreInfo_Click(...)

    '****************************************************************************************
    '_btnProcessTestData_Click() is the event procedure that gets called when the user clicks 
    'on the 'Run Test-Data' button or by using the Alt-R hotkey sequence.  It populates
    'the system with sample test data to verify system integrity.
    '****************************************************************************************
    Private Sub _btnProcessTestData_Click(sender As Object, e As EventArgs) _
        Handles btnProcessTestData.Click

        'Run the test data thru the system
        _processTestData()
    End Sub '_btnProcessTestData_Click(...)

    '****************************************************************************************
    '_btnConfirmGrpTransDetail_Click() is the event procedure that gets called when the 
    'user clicks on the 'Confirm' button or by using the Alt-C hotkey sequence.  It confirms
    'the current transaction settings and create either a purchase or rental transaction.
    '****************************************************************************************
    Private Sub _btnConfirmGrpTransDetail_Click(sender As Object, e As EventArgs) _
        Handles btnConfirmGrpTransDetail.Click

        Dim snowshoeName As String
        Dim snowshoePurchasePrice As Decimal
        Dim snowshoeRentalPrice As Decimal
        Dim pairsCnt As Integer
        Dim isRental As Boolean
        Dim daysToRent As Integer
        Dim isMember As Boolean

        'Make sure a snowshoe was selected
        If lstSnowshoeNameGrpTransDetail.SelectedIndex = -1 Then
            MessageBox.Show("Please select a snowshoe from the list")
            lstSnowshoeNameGrpTransDetail.Focus()
            Exit Sub
        End If

        'Pull input data from the UI
        snowshoeName = lstSnowshoeNameGrpTransDetail.SelectedItem.ToString
        snowshoePurchasePrice = Convert.ToDecimal(lstSnowshoePurchPriceGrpTransDetail.SelectedItem)
        snowshoeRentalPrice = Convert.ToDecimal(lstSnowshoeRentPriceGrpTransDetail.SelectedItem)
        pairsCnt = Convert.ToInt16(nudPairsCntGrpTransDetail.Value)
        isRental = chkIsRentalGrpTransDetail.Checked
        daysToRent = Convert.ToInt16(nudRentalDaysGrpTransDetail.Value)
        isMember = chkIsMemberGrpTransDetail.Checked

        'Creat a transaction based on purchase vs rental
        Dim snowshoe As Snowshoe = New Snowshoe(snowshoeName, snowshoePurchasePrice, snowshoeRentalPrice)
        Dim snowshoeTransRec As SnowshoeTransRec = New SnowshoeTransRec(snowshoe, pairsCnt, isRental, daysToRent, isMember)

        If isRental = True Then
            _snowshoeStore.snowshoeRental(snowshoeTransRec)
        Else
            _snowshoeStore.snowshoePurchase(snowshoeTransRec)
        End If
    End Sub '_btnConfirmGrpTransDetail_Click(...)

    '****************************************************************************************
    '_lstSnowshoeName_SelectedIndexChanged() is the event procedure that gets called 
    'when the user selects a specific snowshoe from the list.  It is used to map the
    'price and rental list selections to the same index
    '****************************************************************************************
    Private Sub _lstSnowshoeName_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstSnowshoeNameGrpTransDetail.SelectedIndexChanged

        Dim idx As Integer

        idx = lstSnowshoeNameGrpTransDetail.SelectedIndex
        lstSnowshoePurchPriceGrpTransDetail.SelectedIndex = idx
        lstSnowshoeRentPriceGrpTransDetail.SelectedIndex = idx
    End Sub '_lstSnowshoeName_SelectedIndexChanged(...)



    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '****************************************************************************************
    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    '****************************************************************************************
    Private Sub _frmMain_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        'Initalize tool tips for specific controls
        _initializeToolTips()

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()

        'get/validate input
        _updateFromUserInputs()
    End Sub '_frmMain_Load(...)

    '****************************************************************************************
    '_txtTransLogFrmMain_TextChanged() is the event procedure the is called when
    'the transaction log text box is modified.  Basically it enables the display text to scroll.
    '****************************************************************************************
    Private Sub _txtTransLogFrmMain_TextChanged(sender As Object, e As EventArgs) _
        Handles txtTransLogFrmMain.TextChanged

        txtTransLogFrmMain.SelectionStart = txtTransLogFrmMain.TextLength
        txtTransLogFrmMain.ScrollToCaret()
    End Sub '_txtTransLogFrmMain_TextChanged(...)


    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

    '****************************************************************************************
    '_snowshoeAdded() is the event procedure that handles the processing for when a snowshoe
    ''Add' event is raised.
    '****************************************************************************************
    Private Sub _snowshoeAdded(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
        Handles mSnowshoeStore.SnowshoeStore_SnowshoeAdded

        Dim snowshoeStore_EventArgs_SnowshoeAdded As SnowshoeStore_EventArgs_SnowshoeAdded
        Dim snowshoe As Snowshoe

        snowshoeStore_EventArgs_SnowshoeAdded = CType(e, SnowshoeStore_EventArgs_SnowshoeAdded)
        snowshoe = snowshoeStore_EventArgs_SnowshoeAdded.snowshoe

        With snowshoe
            lstSnowshoeNameGrpTransDetail.Items.Add(.snowshoeName)
            lstSnowshoePurchPriceGrpTransDetail.Items.Add(.purchPrice.ToString("N2"))
            lstSnowshoeRentPriceGrpTransDetail.Items.Add(.rentPrice.ToString("N2"))
        End With

        lstSnowshoeNameGrpTransDetail.SelectedIndex =
            lstSnowshoeNameGrpTransDetail.Items.Count - 1

        'Create a transaction log record
        _writeTransLog("[Snowshoe-Added] -> " & snowshoe.ToString)
    End Sub '_snowshoeAdded(...)

    '****************************************************************************************
    '_snowshoeRental() is the event procedure that handles the processing for when a 
    'snowshoe 'Rental' event is raised.
    '****************************************************************************************
    Private Sub _snowshoeRental( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
        Handles mSnowshoeStore.SnowshoeStore_SnowshoeRental

        Dim snowshoeStore_EventArgs_SnowshoeRental As Snowshoe_EventArgs_SnowshoeRental
        Dim snowshoeTransRec As SnowshoeTransRec

        snowshoeStore_EventArgs_SnowshoeRental = CType(e, Snowshoe_EventArgs_SnowshoeRental)
        snowshoeTransRec = snowshoeStore_EventArgs_SnowshoeRental.snowshoeTransRec

        'Nothing to really do so just write a transaction record to the log
        _writeTransLog("[Snowshoe-Rental] -> " & snowshoeTransRec.ToString)

        'Update the UI
        _updateSummaryInfoTotals(_snowshoeStore)
    End Sub '_snowshoeRental(...)

    '****************************************************************************************
    '_snowshoePurchase() is the event procedure that handles the processing for when a 
    'snowshoe 'Purchase' event is raised.
    '****************************************************************************************
    Private Sub _snowshoePurchase( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
        Handles mSnowshoeStore.SnowshoeStore_SnowshoePurchase

        Dim snowshoeStore_EventArgs_SnowshoePurchase As Snowshoe_EventArgs_SnowshoePurchase
        Dim snowshoeTransRec As SnowshoeTransRec

        snowshoeStore_EventArgs_SnowshoePurchase = CType(e, Snowshoe_EventArgs_SnowshoePurchase)
        snowshoeTransRec = snowshoeStore_EventArgs_SnowshoePurchase.snowshoeTransRec

        'Nothing to really do so just write a transaction record to the log
        _writeTransLog("[Snowshoe-Purchase] -> " & snowshoeTransRec.ToString)

        'Update the UI
        _updateSummaryInfoTotals(_snowshoeStore)
    End Sub '_snowshoePurchase(...)


#End Region 'Event Procedures

#Region "Events"
    '****************************************************************************************
    'Events
    '****************************************************************************************
    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'FrmMain