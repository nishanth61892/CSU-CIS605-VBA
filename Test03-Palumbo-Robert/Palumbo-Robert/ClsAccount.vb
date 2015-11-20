'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test03-Palumbo-Robert
'File:          ClsAccount.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for Account which is  
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

Public Class Account

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants
    Private mCHECKING_ACCT As String = "Checking"
    Private mSAVINGS_ACCT As String = "Savings"
    Private mLOAN_ACCT As String = "Loan"

    'Unique Account Id
    Private mId As String

    'Accout Name
    Private mName As String

    'Account type
    Private mType As String

    'Account Balance
    Private mBalance As Decimal = 0D

    'Account customer
    Private mCust As Customer

    '********** Module-level variables

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'These are all public.

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    Public Sub New(ByVal pAcctId As String, _
                   ByVal pAcctType As String, _
                   ByVal pAcctName As String, _
                   ByVal pAcctCust As Customer)

        'invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _id = pAcctId.Trim
        _type = pAcctType.Trim
        _name = pAcctName.Trim
        _cust = pAcctCust

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
    Public ReadOnly Property id() As String
        Get
            Return _id
        End Get
    End Property

    Public Property name() As String
        Get
            Return _name
        End Get
        Set(pValue As String)
            _name = pValue
        End Set
    End Property

    Public Property type() As String
        Get
            Return _type
        End Get
        Set(pValue As String)
            _type = pValue
        End Set
    End Property

    Public Property bal() As Decimal
        Get
            Return _bal
        End Get
        Set(pValue As Decimal)
            _bal = pValue
        End Set
    End Property

    Public Property cust() As Customer
        Get
            Return _cust
        End Get
        Set(pValue As Customer)
            _cust = pValue
        End Set
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _id() As String
        Get
            Return mId
        End Get
        Set(pValue As String)
            mId = pValue
        End Set
    End Property

    Private Property _name() As String
        Get
            Return mName
        End Get
        Set(pValue As String)
            mName = pValue
        End Set
    End Property

    Private Property _type() As String
        Get
            Return mType
        End Get
        Set(pValue As String)
            mType = pValue
        End Set
    End Property

    Private Property _bal() As Decimal
        Get
            Return mBalance
        End Get
        Set(pValue As Decimal)
            mBalance = pValue
        End Set
    End Property

    Private Property _cust() As Customer
        Get
            Return mCust
        End Get
        Set(pValue As Customer)
            mCust = pValue
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
    'isChecking() returns true if the account is a checking
    'account, false otherwise
    Public Function isChecking() As Boolean
        Return _isChecking()
    End Function 'isChecking(...)

    'isSavings() returns true if the account is a savings
    'account, false otherwise
    Public Function isSavings() As Boolean
        Return _isSavings()
    End Function 'isSavings(...)

    '_isChecking() returns true if the account is a loan
    'account, false otherwise
    Public Function isLoan() As Boolean
        Return _isLoan()
    End Function '_isLoan(...)

    'balance() is a method that simply returns the current balance
    'in the account.  For this test the balance is always 0 since 
    'we have no means to store persistent data.
    Public Function balance() As Decimal
        Return _balance()
    End Function 'balance(...)

    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function

    '********** Private Non-Shared Behavioral Methods
    '_isChecking() returns true if the account is a checking
    'account, false otherwise
    Public Function _isChecking() As Boolean
        Return _type = mCHECKING_ACCT
    End Function '_isChecking(...)

    '_isSavings() returns true if the account is a savings
    'account, false otherwise
    Public Function _isSavings() As Boolean
        Return _type = mSAVINGS_ACCT
    End Function '_isSavings(...)

    '_isChecking() returns true if the account is a loan
    'account, false otherwise
    Public Function _isLoan() As Boolean
        Return _type = mLOAN_ACCT
    End Function '_isLoan(...)

    'balance() is a method that simply returns the current balance
    'in the account.  For this test the balance is always 0 since 
    'we have no means to store persistent data.
    Public Function _balance() As Decimal
        Return _bal
    End Function 'balance(...)

    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim _tmpStr As String = ""

        _tmpStr = "(ACCOUNT: " _
            & " ID=" & _id _
            & ", Type='" & _type & "'" _
            & ", Name='" & _name & "'" _
            & ", Cust='" & _cust.ToString & "')"

        Return _tmpStr
    End Function

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

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

End Class 'Account