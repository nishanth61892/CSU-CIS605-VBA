'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch04Ex02
'File:          ClsStockMarket.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for the Stock Market
'               used within the Ch04Ex02 Visual Basic program. 
'               There really should be only one instance of the
'               stock market that all investor's utilize within
'               the Stock Market Portfolio Management system.
'
'Date:          10/04/2015
'                   - initial creation
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

Public Class StockMarket

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Count of the available ticker symbols (individual stocks) available
    'in the stock market
    Private mStockCnt As Integer = 0

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

    Public Property stockCnt() As Integer
        Get
            Return _stockCnt
        End Get
        Set(pValue As Integer)
            _stockCnt = pValue
        End Set
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _stockCnt() As Integer
        Get
            Return mStockCnt
        End Get
        Set(pValue As Integer)
            mStockCnt = pValue
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

    'offerStock() simulates the offering of a new stock on the
    'Stock Market.
    Public Sub offerStock(ByVal pStock As Stock)
        'Call the worker procedure
        _offerStock(pStock)
    End Sub 'offerStock(ByVal pStock As Stock)

    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function

    '********** Private Non-Shared Behavioral Methods

    '_offerStock() is the private work-horse method that does
    'all the work for offering a stock.
    Public Sub _offerStock(ByVal pStock As Stock)

        'Update the stock counter
        _stockCnt += 1

    End Sub 'offerStock(ByVal pStock As Stock)

    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim tmpStr As String = ""

        tmpStr = "Stock Market: " _
            & "# of Stocks: " & _stockCnt.ToString

        Return tmpStr
    End Function

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

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
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'StockMarket
