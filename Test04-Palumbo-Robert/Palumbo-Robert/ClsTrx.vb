'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test03-Palumbo-Robert
'File:          ClsTrx.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for a Transaction which is  
'               used within the "Test03-Palumbo-Robert" Visual 
'               Basic program. 
'
'Date:          11/20/2015
'                   - Initial Creation
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

Public Class Trx

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    'Unique Tranaction Id
    Private mTrxId As String

    'Transaction date
    Private mDate As Date

    'Description of the transaction
    Private mDesc As String

    'Number of transactions
    Private mNumTrxs As Integer

    'Value of all transactions (calculated)
    Private mValue As Decimal

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters
    Public Sub New()

        MyBase.New()

    End Sub 'New()

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    Public Sub New(ByVal pCustId As String, _
                   ByVal pCustName As String)

        'invoke the default constructor to invoke the parent object constructor
        Me.New()

        'Initialize the attributes

    End Sub 'New(...)

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

    Private Property trxId() As String
        Get
            Return _trxId
        End Get
        Set(pValue As String)
            _trxId = pValue
        End Set
    End Property

    Private Property trxDate() As Date
        Get
            Return _trxDate
        End Get
        Set(pValue As Date)
            _trxDate = pValue
        End Set
    End Property

    Private Property desc() As String
        Get
            Return _desc
        End Get
        Set(pValue As String)
            _desc = pValue
        End Set
    End Property

    Private Property numTrxs() As Integer
        Get
            Return _numTrxs
        End Get
        Set(pValue As Integer)
            _numTrxs = pValue
        End Set
    End Property

    Private Property value() As Decimal
        Get
            Return _value
        End Get
        Set(pValue As Decimal)
            _value = pValue
        End Set
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _trxId() As String
        Get
            Return mTrxId
        End Get
        Set(pValue As String)
            mTrxId = pValue
        End Set
    End Property

    Private Property _trxDate() As Date
        Get
            Return mDate
        End Get
        Set(pValue As Date)
            mDate = pValue
        End Set
    End Property

    Private Property _desc() As String
        Get
            Return mDesc
        End Get
        Set(pValue As String)
            mDesc = pValue
        End Set
    End Property

    Private Property _numTrxs() As Integer
        Get
            Return mNumTrxs
        End Get
        Set(pValue As Integer)
            mNumTrxs = pValue
        End Set
    End Property

    Private Property _value() As Decimal
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

    'No Behavioral Methods are currently defined.

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

        tmpStr = "[Trx] -> " _
            & " Id=" & _trxId _
            & ", Date=" & _trxDate.ToString _
            & ", Desc=" & _desc _
            & ", NumTrxs=" & _numTrxs _
            & ", Value=" & _value.ToString("N2")

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

End Class 'Trx