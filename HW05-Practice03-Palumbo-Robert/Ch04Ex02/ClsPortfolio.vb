'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch04Ex02
'File:          ClsPortfolio.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for a investor's stock 
'               Portfolio which is used within the Ch04Ex02 Visual 
'               Basic program.
'               Each instance created represents one investor's
'               specific stock portfolio.
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

Public Class Portfolio

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mNumStocks As Integer
    Private mValue As Decimal

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

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    Public ReadOnly Property numStocks As Integer
        Get
            Return _numStocks
        End Get
    End Property

    Public ReadOnly Property value As Decimal
        Get
            Return _value
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _numStocks As Integer
        Get
            Return mNumStocks
        End Get
        Set(pValue As Integer)
            mNumStocks = pValue
        End Set
    End Property

    Private Property _value As Decimal
        Get
            Return mValue
        End Get
        Set(pValue As Decimal)
            mValue = pValue
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
    Public Sub buy(ByVal pShares As Integer, ByVal pStock As Stock)

        _buy(pShares, pStock)

    End Sub 'buy(pShares,pStock)

    'ToString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Public Overrides Function ToString() As String

        'ToString() returns a string version of the object.
        'It is a standard method that should be provided for *all* classes.

        'This is the public method; 
        'it depends on the private method to actually do the work.

        Return _toString()

    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods     

    '_buy() is the workhorse procedure that is used to buy the specified
    'number of shares of stock from the market and updates the portfolio
    'with the results
    Private Sub _buy( _
            ByVal pShares As Integer,
            ByVal pStock As Stock)

        'Update the stock counter in the portfolio
        _numStocks += 1

        'Calculate the value of the purchase
        Dim pfi = New PortfolioItem(pStock, pShares)
        _value += pfi.value
    End Sub '_buy(...)


    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim tmpStr As String

        tmpStr = "Portfolio: " _
            & " #ofStocks: " & _numStocks.ToString("N2") _
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

End Class 'Portfolio
