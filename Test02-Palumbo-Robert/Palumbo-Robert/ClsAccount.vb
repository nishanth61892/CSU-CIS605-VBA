'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test02-Palumbo-Robert
'File:          ClsAccount.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for Account which is  
'               used within the Test02 Visual Basic program. 
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

Public Class Account

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    'Unique Account Id
    Private mAcctId As String

    'Accout Name
    Private mAcctName As String

    'Account type
    Private mAcctType As String

    'Account Balance
    Private mAcctBal As Decimal = 0D

    'Account customer
    Private mAcctCust As Customer

    '********** Module-level variables

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


    End Sub 'New()

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    Public Sub New(ByVal pAcctId As String, _
                   ByVal pAcctName As String, _
                   ByVal pAcctType As String, _
                   ByVal pAcctCust As Customer)

        'invoke the parent object constructor
        MyBase.New()

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
    Public ReadOnly Property acctId() As String
        Get
            Return _acctId
        End Get
    End Property

    Public Property acctName() As String
        Get
            Return _acctName
        End Get
        Set(pValue As String)
            _acctName = pValue
        End Set
    End Property

    Private Property acctType() As String
        Get
            Return _acctType
        End Get
        Set(pValue As String)
            _acctType = pValue
        End Set
    End Property

    Private Property acctBal() As Decimal
        Get
            Return _acctBal
        End Get
        Set(pValue As Decimal)
            _acctBal = pValue
        End Set
    End Property

    Private Property acctCust() As Customer
        Get
            Return _acctCust
        End Get
        Set(pValue As Customer)
            _acctCust = pValue
        End Set
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _acctId() As String
        Get
            Return mAcctId
        End Get
        Set(pValue As String)
            mAcctId = pValue
        End Set
    End Property

    Private Property _acctName() As String
        Get
            Return mAcctName
        End Get
        Set(pValue As String)
            mAcctName = pValue
        End Set
    End Property

    Private Property _acctType() As String
        Get
            Return mAcctType
        End Get
        Set(pValue As String)
            mAcctType = pValue
        End Set
    End Property

    Private Property _acctBal() As Decimal
        Get
            Return mAcctBal
        End Get
        Set(pValue As Decimal)
            mAcctBal = pValue
        End Set
    End Property

    Private Property _acctCust() As Customer
        Get
            Return mAcctCust
        End Get
        Set(pValue As Customer)
            mAcctCust = pValue
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
        Dim _tmpStr As String = ""

        Return _tmpStr
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

End Class 'Account