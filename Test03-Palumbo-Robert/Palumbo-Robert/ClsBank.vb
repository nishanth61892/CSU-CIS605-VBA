'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test03-Palumbo-Robert
'File:          ClsBank.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for Bank which is  
'               used within the "Test03-Palumbo-Robert" Visual
'               Basic program. 
'
'Date:          10/12/2015
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

Public Class Bank
    Inherits System.EventArgs

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    'Unique Bank Id
    Private mId As String

    'Bank Name
    Private mName As String

    'Number of customers
    Private mNumCusts As Integer = 0

    'Number of accounts
    Private mNumAccts As Integer = 0

    'Bank Value
    Private mValue As Decimal = 0D

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

    Public Sub New(ByVal pId As String, _
                   ByVal pName As String, _
                   ByVal pNumCusts As Integer, _
                   ByVal pNumAccts As Integer
                   )

        'invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _id = pId
        _name = pName
        _numCusts = pNumCusts
        _numAccts = pNumAccts
        _value = 0D

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

    Public ReadOnly Property numCusts() As Integer
        Get
            Return _numCusts
        End Get
    End Property

    Public ReadOnly Property numAccts() As Integer
        Get
            Return _numAccts
        End Get
    End Property

    Public Property value() As Decimal
        Get
            Return _value
        End Get
        Set(pValue As Decimal)
            _value = pValue
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

    Private Property _numCusts() As Integer
        Get
            Return mNumCusts
        End Get
        Set(pValue As Integer)
            mNumCusts = pValue
        End Set
    End Property

    Private Property _numAccts() As Integer
        Get
            Return mNumAccts
        End Get
        Set(pValue As Integer)
            mNumAccts = pValue
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

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods
    'Creates a new bank account
    Public Sub createAccount(ByVal pAcctId As String,
                                  ByVal pAcctType As String,
                                  ByVal pAcctName As String,
                                  ByVal pCust As Customer)
        'Call the worker function
        _createAccount(pAcctId,
                       pAcctType,
                       pAcctName,
                       pCust)
    End Sub 'createAccount()

    'Creates a new bank customer
    Public Sub createCustomer(ByVal pCustId As String,
                              ByVal pCustName As String)
        'Call the worker function
        _createCustomer(pCustId, pCustName)
    End Sub 'createCustomer()

    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function

    '********** Private Non-Shared Behavioral Methods

    'Create a new bank account
    Private Sub _createAccount(ByVal pAcctId As String,
                               ByVal pAcctType As String,
                               ByVal pAcctName As String,
                               ByVal pCust As Customer)
        Dim newAcct As Account = New Account(pAcctId,
                                             pAcctType,
                                             pAcctName,
                                             pCust)

        'keep track of number of accounts
        _numAccts += 1

        'Raise and event to let the listeners of this event it happened
        RaiseEvent Bank_CreateAccount(Me,
                                      New Bank_EventArgs_CreateAccount(newAcct))
    End Sub 'createAccount()

    'Create a new customer
    Private Sub _createCustomer(ByVal pCustId As String,
                                     ByVal pCustName As String)
        Dim newCust As Customer = New Customer(pCustId, pCustName)

        'keep track of number of customers
        _numCusts += 1

        'Raise and event to let the listeners of this event it happened
        RaiseEvent Bank_CreateCustomer(Me,
                                       New Bank_EventArgs_CreateCustomer(newCust))
    End Sub '_createCustomer()


    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim _tmpStr As String = ""

        _tmpStr = "(" _
            & " BANK: ID=" & _id _
            & ", Name=" & _name _
            & ", #Cust=" & _numCusts _
            & ", #Acct=" & _numAccts _
            & ")"

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

    'These are all public.

    'Define the new customer event
    Public Event Bank_CreateCustomer(ByVal sender As Object, _
                                     ByVal e As System.EventArgs
                                     )

    'Define the new account event
    Public Event Bank_CreateAccount(ByVal sender As Object, _
                                    ByVal e As System.EventArgs
                                    )

#End Region 'Events

End Class 'Bank