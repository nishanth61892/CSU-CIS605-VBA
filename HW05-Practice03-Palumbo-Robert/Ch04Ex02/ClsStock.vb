'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch04Ex02
'File:          ClsStock.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for a Stock which is
'               used within the Ch04Ex02 Visual Basic program. 
'               Each instance created represents and invididual stock
'               within the Stock Market Portfolio Management system.
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

Public Class Stock

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mStkSym As String
    Private mStkName As String
    Private mStkPrice As Decimal

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
    Public Sub New(ByVal pStkSym As String, _
                   ByVal pStkName As String, _
                   ByVal pStkPrice As Decimal
                   )

        'Create a new stock and initialize it with the specified
        'parameters
        MyBase.New()

        mStkSym = pStkSym
        mStkName = pStkName
        mStkPrice = pStkPrice
    End Sub 'New(...)

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public Property stkSym() As String
        Get
            Return _stkSym
        End Get
        Set(pValue As String)
            _stkSym = pValue
        End Set
    End Property

    Public Property stkName() As String
        Get
            Return _stkName
        End Get
        Set(pValue As String)
            _stkName = pValue
        End Set
    End Property

    Public Property stkPrice() As Decimal
        Get
            Return _stkPrice
        End Get
        Set(pValue As Decimal)
            _stkPrice = pValue
        End Set
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _stkSym() As String
        Get
            Return mStkSym
        End Get
        Set(pValue As String)
            mStkSym = pValue
        End Set
    End Property

    Private Property _stkName() As String
        Get
            Return mStkName
        End Get
        Set(pValue As String)
            mStkName = pValue
        End Set
    End Property

    Private Property _stkPrice() As Decimal
        Get
            Return mStkPrice
        End Get
        Set(pValue As Decimal)
            mStkPrice = pValue
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

    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function

    '********** Private Non-Shared Behavioral Methods

    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim tmpStr As String = ""

        tmpStr = "Stock: " _
            & " Symbol: " & _stkSym _
            & ", Name: " & _stkName _
            & ", Price: " & _stkPrice.ToString("N2")

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

End Class 'Stock
