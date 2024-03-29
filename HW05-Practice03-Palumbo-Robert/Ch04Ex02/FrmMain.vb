﻿'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch04Ex02
'File:          FrmMain.vb
'Author:        Robert Palumbo
'Description:   This is the main user interface form for the 
'               Ch04Ex02 Visual Basic program which simulates
'               a Stock Market Management System.
'
'Date:               
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

    'The Stock Market
    Private mStockMarket As StockMarket

    'A customer portfolio
    Private mPortfolio As Portfolio

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

    Private Property _stockMarket As StockMarket
        Get
            Return mStockMarket
        End Get
        Set(pValue As StockMarket)
            mStockMarket = pValue
        End Set
    End Property

    Private Property _portfolio As Portfolio
        Get
            Return mPortfolio
        End Get
        Set(pValue As Portfolio)
            mPortfolio = pValue
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

    '_closeAppl() is used to simply close the application when
    'requested.
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

        'Allocate the stock market
        _stockMarket = New StockMarket()

        'Allocate a portfolio
        _portfolio = New Portfolio()

        'Dont allow buying of stock until there is actually stock available
        grpPtfItemFrmMain.Enabled = False

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
    '_processStockOffer() procedure that process a new stock that has
    'been offered.
    '******************************************************************
    Private Sub _processStockOffer(ByVal stock As Stock)
        'Update the stock market info for display
        lstStkSymGrpStkMktFrmMain.Items.Add(stock.stkSym)
        lstStkNameGrpStkMktFrmMain.Items.Add(stock.stkName)
        lstStkPriceGrpStkMktFrmMain.Items.Add(stock.stkPrice.ToString("N2"))
        txtCntGrpStkMktFrmMain.Text = _stockMarket.stockCnt.ToString("N0")

        'Update the corresponding row indices so they highlight the new stock
        'Item idices are zero based
        lstStkNameGrpStkMktFrmMain.SelectedIndex = _
            lstStkNameGrpStkMktFrmMain.Items.Count - 1
        lstStkPriceGrpStkMktFrmMain.SelectedIndex =
            lstStkPriceGrpStkMktFrmMain.Items.Count - 1
        lstStkSymGrpStkMktFrmMain.SelectedIndex = _
            lstStkSymGrpStkMktFrmMain.Items.Count - 1

        'Clear out input field to get allow for another stock offering if needed
        txtStkSymGrpStockFrmMain.Clear()
        txtStkNameGrpStockFrmMain.Clear()
        txtStkPriceGrpStockFrmMain.Clear()
        txtStkSymGrpStockFrmMain.Focus()

        'Now its ok to buy stock
        grpPtfItemFrmMain.Enabled = True

        'Log this transaction
        _writeTransLog("[OFFER-STOCK] " & stock.ToString)
    End Sub '_processStockOffer(...)

    '******************************************************************
    '_processStockBuy() procedure that process a new stock that has
    'been bought.
    '******************************************************************
    Private Sub _processStockBuy(ByVal stock As Stock,
                                 ByVal portItem As PortfolioItem)

        lstStkNameGrpPortfolioFrmMain.Items.Add(stock.stkName)
        lstStkSharesGrpPortfolioFrmMain.Items.Add(portItem.shares.ToString("N0"))
        lstStkPriceGrpPortfolioFrmMain.Items.Add(stock.stkPrice.ToString("N2"))
        lstStkValueGrpPortfolioFrmMain.Items.Add(portItem.value.ToString("N2"))
        lstStkSymGrpPortfolioFrmMain.Items.Add(stock.stkSym)
        txtCntGrpPortfolioFrmMain.Text = _portfolio.numStocks.ToString("N0")
        txtValueGrpPortfolioFrmMain.Text = _portfolio.value.ToString("N2")

        'Clear the input fields
        txtSharesGrpPtfItemFrmMain.Clear()

        'Log the transaction
        _writeTransLog("[BUY-STOCK] " & portItem.ToString)
    End Sub '_processStockBuy(...)

    '******************************************************************
    '_dispStkMktState() procedure that simply displays the
    'current state of the stock market in the transaction log.
    '******************************************************************
    Private Sub _dispStkMktState()
        _writeTransLog("[DISPLAY] " & _stockMarket.ToString)
    End Sub 'dispStkMktState()

    '******************************************************************
    '_dispPortfolioState() procedure that simply displays the
    'current state of the portfolio in the transaction log.
    '******************************************************************
    Private Sub _dispPortfolioState()
        _writeTransLog("[DISPLAY] " & _portfolio.ToString)
    End Sub 'dispPortfolioState()

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
    Private Sub _btnExitFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnExitFrmMain.Click

        'Terminate the program
        _closeAppl()

    End Sub '_btnExitFrmMain_Click(sender As Object, e As EventArgs)

    '_btnOfferGrpStockFrmMain_Click() is the event procedure that gets called 
    'when the user clicks on the 'Offer' button or by using the Alt-O hotkey
    'sequence.
    Private Sub _btnOfferGrpStockFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnOfferGrpStockFrmMain.Click

        'local variables
        Dim stkSym As String
        Dim stkName As String
        Dim stkPrice As Decimal

        'Validate the input
        stkSym = txtStkSymGrpStockFrmMain.Text
        stkName = txtStkNameGrpStockFrmMain.Text

        If String.IsNullOrEmpty(stkSym) Then
            MessageBox.Show("Please enter a stock ticker symbol (ex: STX)")

            txtStkSymGrpStockFrmMain.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(stkName) Then
            MessageBox.Show("Please enter a stock name (ex: Stock X)")

            txtStkNameGrpStockFrmMain.Focus()
            Exit Sub
        End If

        Try
            stkPrice = Decimal.Parse(txtStkPriceGrpStockFrmMain.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a decimal value for the stock price (ex: 12.75)")

            txtStkPriceGrpStockFrmMain.Focus()
            txtStkPriceGrpStockFrmMain.SelectAll()
            Exit Sub
        End Try

        'Create the new stock object
        Dim stock As Stock = New Stock(stkSym, stkName, stkPrice)

        'Offer the stock on the stock market
        _stockMarket.offerStock(stock)

        'Process the new stock offer
        _processStockOffer(stock)
    End Sub '_btnOfferGrpStockFrmMain_Click(sender As Object, e As EventArgs)

    '_btnBuyGrpPtfItemFrmMain_Click() is the event procedure that gets called 
    'when the user clicks on the 'Buy' button or by using the Alt-B hotkey
    'sequence.
    Private Sub _btnBuyGrpPtfItemFrmMain_Click(sender As Object, e As EventArgs) Handles _
           btnBuyGrpPtfItemFrmMain.Click

        'local variables
        Dim shares As Integer
        Dim stkName As String = txtStkNameGrpPtfItemFrmMain.Text
        Dim stkSym As String = txtStkSymGrpPtfItemFrmMain.Text
        'Already validated from when stock was input into the system
        Dim stkPrice As Decimal = Decimal.Parse(txtStkPriceGrpPtfItemFrmMain.Text)

        Try
            shares = Integer.Parse(txtSharesGrpPtfItemFrmMain.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter an integer value for number of shares (ex: 10)")

            txtSharesGrpPtfItemFrmMain.Focus()
            txtSharesGrpPtfItemFrmMain.SelectAll()
            Exit Sub
        End Try

        'Allocate a new stock for the purchase
        Dim stock = New Stock(stkSym, stkName, stkPrice)

        'Create a portfolio item
        Dim portItem = New PortfolioItem(stock)

        'Now buy the shares
        portItem.buy(shares)

        'Update the portfolio as well
        _portfolio.buy(shares, stock)

        'Process the stock buy
        _processStockBuy(stock, portItem)
    End Sub '_btnBuyGrpPtfItemFrmMain_Click(...)

    '_btnDispPortGrpPortfolioFrmMain_Click() is the event procedure that gets called 
    'when the user clicks on the 'Display Portfolio' button or by using the Alt-P hotkey
    'sequence.  Simply writes the contents of the portfolio to the transaction log
    Private Sub _btnDispPortGrpPortfolioFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnDispPortGrpPortfolioFrmMain.Click

        _dispPortfolioState()
    End Sub '_btnDispPortGrpPortfolioFrmMain_Click(...)

    '_btnDispStkMktGrpStkMktFrmMain_Click() is the event procedure that gets called 
    'when the user clicks on the 'Display Stock Market' button or by using the Alt-M hotkey
    'sequence.  Simply writes the contents of the stock market to the transaction log
    Private Sub _btnDispStkMktGrpStkMktFrmMain_Click(sender As Object, e As EventArgs) Handles _
        btnDispStkMktGrpStkMktFrmMain.Click

        _dispStkMktState()
    End Sub '_btnDispStkMktGrpStkMktFrmMain_Click(...)

    '_lstStkSymGrpPortfolioFrmMain_SelectedIndexChanged() is the event procedure that gets
    'called when the user selects a list box entry.  It is used to move the indices of the 
    'other associated list boxes in parallel with this one.
    Private Sub _lstStkSymGrpPortfolioFrmMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
        lstStkSymGrpPortfolioFrmMain.SelectedIndexChanged

        Dim index As Integer = lstStkSymGrpPortfolioFrmMain.SelectedIndex

        lstStkNameGrpPortfolioFrmMain.SelectedIndex = index
        lstStkPriceGrpPortfolioFrmMain.SelectedIndex = index
        lstStkSharesGrpPortfolioFrmMain.SelectedIndex = index
        lstStkValueGrpPortfolioFrmMain.SelectedIndex = index
    End Sub '_lstStkSymGrpPortfolioFrmMain_SelectedIndexChanged

    '******************************************************************
    '_lstTkrSymGrpStkMktFrmMain_SelectedIndexChanged() is the event procedure the is 
    'called when the index changes for this list.  Here we need to update the 
    'indices of the associated stock name and price.  Likewise we place the current
    'value into the 'buy' group fields so the user has the option to buy shares
    'if desired.
    '******************************************************************
    Private Sub _lstStkSymGrpStkMktFrmMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
        lstStkSymGrpStkMktFrmMain.SelectedIndexChanged

        Dim index As Integer = lstStkSymGrpStkMktFrmMain.SelectedIndex

        lstStkNameGrpStkMktFrmMain.SelectedIndex = index
        lstStkPriceGrpStkMktFrmMain.SelectedIndex = index

        txtStkSymGrpPtfItemFrmMain.Text = lstStkSymGrpStkMktFrmMain.SelectedItem.ToString
        txtStkNameGrpPtfItemFrmMain.Text = lstStkNameGrpStkMktFrmMain.SelectedItem.ToString
        txtStkPriceGrpPtfItemFrmMain.Text = lstStkPriceGrpStkMktFrmMain.SelectedItem.ToString
    End Sub
    '    End Sub 'lstTkrSymGrpStkMktFrmMain_SelectedIndexChanged(...)

    '_btnRunTestData_Click() is the event procedure that gets called when the user clicks 
    'on the 'Run Test-Data' button or by using the Alt-R hotkey sequence.  It populates
    'the system with sample test data to verify system integrity.
    Private Sub _btnRunTestData_Click(sender As Object, e As EventArgs) Handles _
        btnRunTestData.Click

        Dim stk1 = New Stock("ABC", "ABC Inc.", 10.5D)
        Dim stk2 = New Stock("DEF", "DEF Inc.", 75.33D)
        Dim stk3 = New Stock("GHI", "GHI Company", 117.26D)
        Dim stk4 = New Stock("JKL", "JKL Investments", 1.5D)

        'Offer up some stocks
        _stockMarket._offerStock(stk1)
        _processStockOffer(stk1)
        _stockMarket._offerStock(stk2)
        _processStockOffer(stk2)
        _stockMarket._offerStock(stk3)
        _processStockOffer(stk3)
        _stockMarket._offerStock(stk4)
        _processStockOffer(stk4)

        'display the stock market and portfolio status
        _dispStkMktState()
        _dispPortfolioState()

        'Buy some stocks
        'Create a portfolio item
        Dim portItem = New PortfolioItem(stk1)

        'Now buy the shares
        portItem.buy(5)
        'Update the portfolio as well
        _portfolio.buy(5, stk1)
        'Process the buy order
        _processStockBuy(stk1, portItem)

        'display the stock market and portfolio status
        _dispStkMktState()
        _dispPortfolioState()

        'Create a portfolio item
        portItem = New PortfolioItem(stk4)

        'Now buy the shares
        portItem.buy(10)
        'Update the portfolio as well
        _portfolio.buy(10, stk4)
        'Process the buy order
        _processStockBuy(stk4, portItem)

        'display the stock market and portfolio status
        _dispStkMktState()
        _dispPortfolioState()

        'Create a portfolio item
        portItem = New PortfolioItem(stk2)

        'Now buy the shares
        portItem.buy(200)
        'Update the portfolio as well
        _portfolio.buy(200, stk2)
        'Process the buy order
        _processStockBuy(stk2, portItem)

        'display the stock market and portfolio status
        _dispStkMktState()
        _dispPortfolioState()

        'Create a portfolio item
        portItem = New PortfolioItem(stk3)

        'Now buy the shares
        portItem.buy(1000)
        'Update the portfolio as well
        _portfolio.buy(1000, stk3)
        'Process the buy order
        _processStockBuy(stk3, portItem)

        'display the stock market and portfolio status
        _dispStkMktState()
        _dispPortfolioState()
    End Sub '_btnRunTestData_Click(...)

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    Private Sub _frmMain_Load(sender As Object, e As EventArgs) Handles _
        MyBase.Load

        'Initalize tool tips for specific controls
        _initializeToolTips()

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()

    End Sub '_frmMain_Load(sender, e)

    '_grpStockFrmMain_Enter()  is used to map the 'Offer' button as the 'AcceptButton'
    'on the form
    Private Sub _grpStockFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        grpStockFrmMain.Enter

        Me.AcceptButton = btnOfferGrpStockFrmMain

    End Sub '_grpStockFrmMain_Enter(...)

    '_grpPtfItemFrmMain_Enter()  is used to map the 'Buy' button as the 'AcceptButton'
    'on the form
    Private Sub _grpPtfItemFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        grpPtfItemFrmMain.Enter

        Me.AcceptButton = btnBuyGrpPtfItemFrmMain

    End Sub '_grpPtfItemFrmMain_Enter(...)

    '_grpStkMktFrmMain_Enter()  is used to map the 'Display Stock Market' button as 
    'the 'AcceptButton on the form
    Private Sub _grpStkMktFrmMain_Enter(sender As Object, e As EventArgs) Handles _
        grpStkMktFrmMain.Enter

        Me.AcceptButton = btnDispStkMktGrpStkMktFrmMain

    End Sub '_grpStkMktFrmMain_Enter

    '******************************************************************
    '_txtTransLogFrmMain_TextChanged() is the event procedure the is called when
    'the transaction log text box is modified.  Basically it enables the display text to scroll.
    '******************************************************************
    Private Sub _txtTransLogFrmMain_TextChanged(sender As Object, e As EventArgs) Handles _
       txtTransLogFrmMain.TextChanged

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