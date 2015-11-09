'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch05Ex01
'File:          ClsSnowshoeStore.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for SnowshoeStore which is  
'               used within the Ch05Ex01 Visual Basic program. 
'               This is a practice/learning assignment. It is used to
'               simulate the sale/rental of snowshoes from Snowshoe
'               Store.
'
'Date:          11/08/2015     
'
'Tier:          Business Logic
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

Public Class SnowshoeStore

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mSnowshoeCnt As Integer
    Private mSnowshoeTransCnt As Integer

    'Cumulative type totals
    Private mExtPriceTotal As Decimal
    'Running dollar amount of member discounts for all transactions
    Private mMemDiscntTotal As Decimal
    'Running dollar amount of pre-tax transactions
    Private mPreTaxTotal As Decimal
    'Running dollar amount from all transaction taxes
    Private mTaxTotal As Decimal
    'Running dollar amount of all transactions
    Private mTotPriceTotal As Decimal


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

    Public ReadOnly Property snowshoeCnt() As Integer
        Get
            Return _snowshoeCnt
        End Get
    End Property

    Public ReadOnly Property snowshoeTransCnt() As Integer
        Get
            Return _snowshoeTransCnt
        End Get
    End Property

    Public ReadOnly Property extPriceTotal() As Decimal
        Get
            Return _extPriceTotal
        End Get
    End Property

    Public ReadOnly Property membDiscntTotal() As Decimal
        Get
            Return _memDiscntTotal
        End Get
    End Property

    Public ReadOnly Property preTaxTotal() As Decimal
        Get
            Return _preTaxTotal
        End Get
    End Property

    Public ReadOnly Property taxTotal() As Decimal
        Get
            Return _taxTotal
        End Get
    End Property

    Public ReadOnly Property totPriceTotal() As Decimal
        Get
            Return _totPriceTotal
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _snowshoeCnt() As Integer
        Get
            Return mSnowshoeCnt
        End Get
        Set(ByVal value As Integer)
            mSnowshoeCnt = value
        End Set
    End Property

    Private Property _snowshoeTransCnt() As Integer
        Get
            Return mSnowshoeTransCnt
        End Get
        Set(ByVal value As Integer)
            mSnowshoeTransCnt = value
        End Set
    End Property

    Private Property _extPriceTotal() As Decimal
        Get
            Return mExtPriceTotal
        End Get
        Set(ByVal value As Decimal)
            mExtPriceTotal = value
        End Set
    End Property

    Private Property _memDiscntTotal() As Decimal
        Get
            Return mMemDiscntTotal
        End Get
        Set(ByVal value As Decimal)
            mMemDiscntTotal = value
        End Set
    End Property

    Private Property _preTaxTotal() As Decimal
        Get
            Return mPreTaxTotal
        End Get
        Set(ByVal value As Decimal)
            mPreTaxTotal = value
        End Set
    End Property

    Private Property _taxTotal() As Decimal
        Get
            Return mTaxTotal
        End Get
        Set(ByVal value As Decimal)
            mTaxTotal = value
        End Set
    End Property

    Private Property _totPriceTotal() As Decimal
        Get
            Return mTotPriceTotal
        End Get
        Set(ByVal value As Decimal)
            mTotPriceTotal = value
        End Set
    End Property


#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '****************************************************************************************
    'Behavioral Methods
    '****************************************************************************************

    'No Behavioral Methods are currently defined.

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    '****************************************************************************************
    'snowshoeAdd() is used by the system to add a snowshoe item to the list of snowshoes 
    'made avaiable to the customer.  It calls the worker procedure to perform the actual
    'work needed which also raises the associated event to notify any listeners.
    '****************************************************************************************
    Public Sub snowshoeAdd(ByVal pSnowshoe As Snowshoe)
        _snowshoeAdd(pSnowshoe)
    End Sub 'snowshoeAdd(...)

    '****************************************************************************************
    'snowshoePurchase() is used by the system to simulate a snowshoe purchase transaction. 
    'It calls the worker procedure to perform the actual work needed which also raises the 
    'associated event to notify any listeners.
    '****************************************************************************************
    Public Sub snowshoePurchase(ByVal pSnowshoeTransRec As SnowshoeTransRec)
        _snowshoePurchase(pSnowshoeTransRec)
    End Sub 'snowshoePurchase(...)

    '****************************************************************************************
    'snowshoeRental() is used by the system to simulate a snowshoe rental transaction. 
    'It calls the worker procedure to perform the actual work needed which also raises the 
    'associated event to notify any listeners.
    '****************************************************************************************
    Public Sub snowshoeRental(ByVal pSnowshoeTransRec As SnowshoeTransRec)
        _snowshoeRental(pSnowshoeTransRec)
    End Sub 'snowshoeRental(...)


    '****************************************************************************************
    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    '****************************************************************************************
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'ToString()


    '********** Private Non-Shared Behavioral Methods

    '_snowshoePurchase() is called by snowshoePurchase() and is the 
    'worker procedure that is used to simlulate a snowshoe purchase transasction.
    'It calculates appropriate pricing information and raises the associated purchase
    'event to allow any listeners to perform subsequent actions based up the 
    'occurrence of the event.
    '****************************************************************************************
    Private Sub _snowshoePurchase(ByVal pSnowshoeTransRec As SnowshoeTransRec)
        _snowshoeTransCnt += 1

        _extPriceTotal += pSnowshoeTransRec.extPrice
        _memDiscntTotal += pSnowshoeTransRec.memDiscnt
        _preTaxTotal += pSnowshoeTransRec.preTaxPrice
        _taxTotal += pSnowshoeTransRec.salesTaxPrice
        _totPriceTotal += pSnowshoeTransRec.totalTransCost

        RaiseEvent SnowshoeStore_SnowshoePurchase(Me, _
                                                  New Snowshoe_EventArgs_SnowshoePurchase(pSnowshoeTransRec))
    End Sub '_rentBuySnowPurchase(...)


    '****************************************************************************************
    '_snowshoeRental() is called by snowshoeRental() and is the 
    'worker procedure that is used to simlulate a snowshoe rental transasction.
    'It calculates appropriate pricing information and raises the associated rental
    'event to allow any listeners to perform subsequent actions based up the 
    'occurrence of the event.
    '****************************************************************************************
    Private Sub _snowshoeRental(ByVal pSnowshoeTransRec As SnowshoeTransRec)
        _snowshoeTransCnt += 1

        _extPriceTotal += pSnowshoeTransRec.extPrice
        _memDiscntTotal += pSnowshoeTransRec.memDiscnt
        _preTaxTotal += pSnowshoeTransRec.preTaxPrice
        _taxTotal += pSnowshoeTransRec.salesTaxPrice
        _totPriceTotal += pSnowshoeTransRec.totalTransCost

        RaiseEvent SnowshoeStore_SnowshoeRental(Me, _
                                                New Snowshoe_EventArgs_SnowshoeRental(pSnowshoeTransRec))
    End Sub '_rentBuySnowshoes(...)


    '****************************************************************************************
    '_addSnowshoe() is called by addSnowshoe() and is the worker procedure that is used 
    'to physically add a new snowshoe to the system.  For now it can only keep a count of 
    'the total number of snowshoes in the system and raises the associated add event
    'to allow any listeners to perform subsequent actions based up the occurrence of 
    'the event.
    '****************************************************************************************
    Private Sub _snowshoeAdd(ByVal pSnowshoe As Snowshoe)
        _snowshoeCnt += 1

        RaiseEvent SnowshoeStore_SnowshoeAdded(Me, _
                                               New SnowshoeStore_EventArgs_SnowshoeAdded(pSnowshoe))
    End Sub '_snowshoeAdd(...)

    '****************************************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String = ""

        tmpStr = "[SnowshoeStore-Status] -> " _
            & "SnowshoeCnt=" & _snowshoeCnt.ToString("N0") _
            & ", TransactionCnt=" & _snowshoeTransCnt.ToString("N0") _
            & ", ExtPriceTot=$" & _extPriceTotal.ToString("N2") _
            & ", MemDiscntTot=$" & _memDiscntTotal.ToString("N2") _
            & ", TotalPreTaxes=$" & _preTaxTotal.ToString("N2") _
            & ", TotalTaxes=$" & _taxTotal.ToString("N2") _
            & ", TotalCost=$" & _totPriceTotal.ToString("N2")

        Return tmpStr
    End Function '_toString()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '****************************************************************************************
    'Event Procedures
    '****************************************************************************************

    'No Event Procedures are currently defined.
    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '****************************************************************************************
    'Events
    '****************************************************************************************

    'These are all public.

    'Event raised when snowshoe is added to the system
    Public Event SnowshoeStore_SnowshoeAdded(ByVal sender As System.Object, _
                                             ByVal e As System.EventArgs)

    'Event raised when snowshow is purchased
    Public Event SnowshoeStore_SnowshoePurchase(ByVal sender As System.Object, _
                                                ByVal e As System.EventArgs)

    'Event raised when snowshow is rented
    Public Event SnowshoeStore_SnowshoeRental(ByVal sender As System.Object, _
                                              ByVal e As System.EventArgs)

#End Region 'Events

End Class 'SnowshoeStore