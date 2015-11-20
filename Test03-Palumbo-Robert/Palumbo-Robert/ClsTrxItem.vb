'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test03-Palumbo-Robert
'File:          ClsTrxItem.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for a Transaction Item which is  
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

Public Class TrxItem

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables
    'Unique Tranaction Id
    Private mTrxId As String

    'Transaction reference
    Private mTrx As Trx

    'Account number reference
    Private mAccount As Account

    'Description of the transaction
    Private mDesc As String

    'Amount of the transaction
    Private mAmt As Decimal

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

    Public Property trxId() As String
        Get
            Return _trxId
        End Get
        Set(pValue As String)
            _trxId = pValue
        End Set
    End Property

    Public Property trx() As Trx
        Get
            Return _trx
        End Get
        Set(pValue As Trx)
            _trx = pValue
        End Set
    End Property

    Public Property account() As Account
        Get
            Return _account
        End Get
        Set(pValue As Account)
            _account = pValue
        End Set
    End Property

    Public Property desc() As String
        Get
            Return _desc
        End Get
        Set(pValue As String)
            _Desc = pValue
        End Set
    End Property

    Public Property amt() As Decimal
        Get
            Return _amt
        End Get
        Set(pValue As Decimal)
            _amt = pValue
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

    Private Property _trx() As Trx
        Get
            Return mTrx
        End Get
        Set(pValue As Trx)
            mTrx = pValue
        End Set
    End Property

    Private Property _account() As Account
        Get
            Return mAccount
        End Get
        Set(pValue As Account)
            mAccount = pValue
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

    Private Property _amt() As Decimal
        Get
            Return mAmt
        End Get
        Set(pValue As Decimal)
            mAmt = pValue
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
        Dim tmpStr As String

        tmpStr = "[TrxItem] -> " _
            & " Id=" & _trxId _
            & ", Trx=" & _trx.ToString _
            & ", Acct=" & _account.ToString _
            & ", Desc=" & _desc _
            & ", Amt=" & _amt.ToString("N2")

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

End Class 'TrxItem