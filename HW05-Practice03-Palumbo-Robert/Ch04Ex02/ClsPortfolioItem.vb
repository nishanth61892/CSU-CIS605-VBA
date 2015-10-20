'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch04Ex02
'File:          ClsPortfolioItem.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for a Portfolio item
'               which is used within the Ch04Ex02 Visual Basic program. 
'               Each instance created represents an individidual 
'               portfolio item within the Stock Market Portfolio 
'               Management system.
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

Public Class PortfolioItem

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mStock As Stock
    Private mNumShares As Integer

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes
    Public Sub New(ByVal pStock As Stock)

        MyBase.New()

        _stock = pStock

    End Sub 'New(...)

    Public Sub New(ByVal pStock As Stock, ByVal pShares As Integer)

        MyBase.New()

        _stock = pStock
        _numShares = pShares

    End Sub 'New(pStock,pShares)


    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    Public ReadOnly Property stock As Stock
        Get
            Return _stock
        End Get
    End Property

    Public ReadOnly Property shares As Integer
        Get
            Return _numShares
        End Get
    End Property

    Public ReadOnly Property value As Decimal
        Get
            Return _value
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _stock As Stock
        Get
            Return mStock
        End Get
        Set(pValue As Stock)
            mStock = pValue
        End Set
    End Property

    Private Property _numShares As Integer
        Get
            Return mNumShares
        End Get
        Set(pValue As Integer)
            mNumShares = pValue
        End Set
    End Property

    Private ReadOnly Property _value As Decimal
        Get
            Return _stock.stkPrice * _numShares
        End Get
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    'buy() is used to buy the specified number of shares off the stock
    'market.
    Public Sub buy(ByVal pShares As Integer)
        'Call the workhorse procedure to do the work
        _buy(pShares)
    End Sub 'buy(...)

    'ToString() creates and returns a String version of the data
    'stored in the object.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods

    '_buy() is the workhorse procedure that is used to 'buy' shares
    'from the stock market
    Private Sub _buy(ByVal pShares As Integer)
        _numShares += pShares
    End Sub '_buy(...)

    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim tmpStr As String

        tmpStr = "Portfolio Item: " _
            & " (" & _stock.ToString & ")" _
            & ", #ofShares: " & _numShares.ToString("N0") _
            & ", Value: " & _value.ToString("N2")

        Return tmpStr
    End Function '_toString()

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

End Class 'PortfolioItem
