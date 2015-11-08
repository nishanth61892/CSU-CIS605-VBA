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
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property snowshoeStore As SnowshoeStore
        Get
            Return mSnowshoeStore
        End Get
        Set(pValue As SnowshoeStore)
            mSnowshoeStore = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    '********** Private Non-Shared Behavioral Methods

    '_closeAppl() is used to simply close the application when requested.
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

  
    End Sub '_initializeBusinessLogic()

    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    Private Sub _initializeUserInterface()

        'Assign CancelButton to the form based buttons so the 'Esc'
        'key will activate the exit functionality when on the main form. 
        Me.CancelButton = btnExitFrmMain

        'Center the main form on the display
        Me.StartPosition = FormStartPosition.CenterScreen

        'This is only enabled for rentals
        nudRentalDaysGrpPurch.Enabled = False
    End Sub 'initializeUserInterface()

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


    '******************************************************************
    '_dispStkMktState() procedure that simply displays the
    'current state of the Snowshoe Marketplace state in the 
    'transaction log.
    '******************************************************************
    Private Sub _dispStoreState()
        _writeTransLog("[DISPLAY] " & "FILL IN WITH SOMETHING")
    End Sub 'dispStoreState()

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
    Private Sub _btnExitFrmMain_Click(sender As Object, e As EventArgs) _
        Handles btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()
    End Sub '_btnExitFrmMain_Click(sender As Object, e As EventArgs)

    '_chkRental_CheckedChanged() is the event procedure that gets called when the user toggles
    'the 'Rent?' check box.  This event triggers the toggling of the 'Rental Days?' indicator
    'as well.  This is only enabled if the user wants to rent snowshoes
    Private Sub _chkRental_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkRentalGrpPurch.CheckedChanged

        nudRentalDaysGrpPurch.Enabled = CBool(IIf(chkRentalGrpPurch.Checked = True, True, False))
    End Sub '_chkRental_CheckedChanged

    '_btnRunTestData_Click() is the event procedure that gets called when the user clicks 
    'on the 'Run Test-Data' button or by using the Alt-R hotkey sequence.  It populates
    'the system with sample test data to verify system integrity.
    Private Sub _btnClearGrpPurch_Click(sender As Object, e As EventArgs) _
        Handles btnClearGrpPurch.Click

        lstSnowshoeNameGrpPurch.SelectedIndex = 0
        lstSnowshoePurchPriceGrpPurch.SelectedIndex = 0
        lstSnowshoeRentPriceGrpPurch.SelectedIndex = 0

        nudNumPairsGrpPurch.Value = 0
        nudRentalDaysGrpPurch.Value = 0
        chkMemberGrpPurch.Checked = False
        chkRentalGrpPurch.Checked = False
    End Sub '_btnClearGrpPurch_Click(...)

    '_btnDispStoreInfo_Click() is the event procedure that gets called when the user 
    'clicks on the 'Display Store Info' button or by using the Alt-D hotkey sequence.
    'It simply outputs the current state of the system in the transaction log for viewing.
    Private Sub _btnDispStoreInfo_Click(sender As Object, e As EventArgs) _
        Handles btnDispStoreInfo.Click

        _dispStoreState()
    End Sub '_btnDispStoreInfo_Click(...)

    '_btnRunTestData_Click() is the event procedure that gets called when the user clicks 
    'on the 'Run Test-Data' button or by using the Alt-R hotkey sequence.  It populates
    'the system with sample test data to verify system integrity.
    Private Sub _btnRunTestData_Click(sender As Object, e As EventArgs)


        'Dim stk1 = New Stock("ABC", "ABC Inc.", 10.5D)
        'Dim stk2 = New Stock("DEF", "DEF Inc.", 75.33D)
        'Dim stk3 = New Stock("GHI", "GHI Company", 117.26D)
        'Dim stk4 = New Stock("JKL", "JKL Investments", 1.5D)

        ''Offer up some stocks
        '_stockMarket._offerStock(stk1)
        '_processStockOffer(stk1)
        '_stockMarket._offerStock(stk2)
        '_processStockOffer(stk2)
        '_stockMarket._offerStock(stk3)
        '_processStockOffer(stk3)
        '_stockMarket._offerStock(stk4)
        '_processStockOffer(stk4)

        ''display the stock market and portfolio status
        '_dispStkMktState()
        '_dispPortfolioState()

        ''Buy some stocks
        ''Create a portfolio item
        'Dim portItem = New PortfolioItem(stk1)

        ''Now buy the shares
        'portItem.buy(5)
        ''Update the portfolio as well
        '_portfolio.buy(5, stk1)
        ''Process the buy order
        '_processStockBuy(stk1, portItem)

        ''display the stock market and portfolio status
        '_dispStkMktState()
        '_dispPortfolioState()

        ''Create a portfolio item
        'portItem = New PortfolioItem(stk4)

        ''Now buy the shares
        'portItem.buy(10)
        ''Update the portfolio as well
        '_portfolio.buy(10, stk4)
        ''Process the buy order
        '_processStockBuy(stk4, portItem)

        ''display the stock market and portfolio status
        '_dispStkMktState()
        '_dispPortfolioState()

        ''Create a portfolio item
        'portItem = New PortfolioItem(stk2)

        ''Now buy the shares
        'portItem.buy(200)
        ''Update the portfolio as well
        '_portfolio.buy(200, stk2)
        ''Process the buy order
        '_processStockBuy(stk2, portItem)

        ''display the stock market and portfolio status
        '_dispStkMktState()
        '_dispPortfolioState()

        ''Create a portfolio item
        'portItem = New PortfolioItem(stk3)

        ''Now buy the shares
        'portItem.buy(1000)
        ''Update the portfolio as well
        '_portfolio.buy(1000, stk3)
        ''Process the buy order
        '_processStockBuy(stk3, portItem)

        ''display the stock market and portfolio status
        '_dispStkMktState()
        '_dispPortfolioState()
    End Sub '_btnRunTestData_Click(...)

    '_lstSnowshoeName_SelectedIndexChanged() is the event procedure that gets called 
    'when the user selects a specific snowshoe from the list.  It is used to map the
    'price and rental list selections to the same index
    Private Sub _lstSnowshoeName_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstSnowshoeNameGrpPurch.SelectedIndexChanged

        Dim idx As Integer

        idx = lstSnowshoeNameGrpPurch.SelectedIndex
        lstSnowshoePurchPriceGrpPurch.SelectedIndex = idx
        lstSnowshoeRentPriceGrpPurch.SelectedIndex = idx
    End Sub '_lstSnowshoeName_SelectedIndexChanged(...)

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    Private Sub _frmMain_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        'Initalize tool tips for specific controls
        _initializeToolTips()

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()
    End Sub '_frmMain_Load(sender, e)

    '******************************************************************
    '_txtTransLogFrmMain_TextChanged() is the event procedure the is called when
    'the transaction log text box is modified.  Basically it enables the display text to scroll.
    '******************************************************************
    Private Sub _txtTransLogFrmMain_TextChanged(sender As Object, e As EventArgs) _
        Handles txtTransLogFrmMain.TextChanged

        txtTransLogFrmMain.SelectionStart = _
            txtTransLogFrmMain.TextLength
        txtTransLogFrmMain.ScrollToCaret()
    End Sub '_txtTransLogFrmMain_TextChanged

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