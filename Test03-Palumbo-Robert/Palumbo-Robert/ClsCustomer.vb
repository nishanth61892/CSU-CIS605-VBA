'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test03-Palumbo-Robert
'File:          ClsCustomer.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for Customer which is  
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

Public Class Customer

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    'Unique Customer Id
    Private mId As String

    'Customer Name
    Private mName As String

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

    Public Sub New(ByVal pCustId As String, _
                   ByVal pCustName As String)

        'invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _id = pCustId.Trim
        _name = pCustName.Trim

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

    Public Property custName() As String
        Get
            Return _name
        End Get
        Set(pValue As String)
            _name = pValue
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
        Dim _tmpStr As String = ""

        _tmpStr = "(CUSTOMER: " _
            & " ID='" & _id & "'" _
            & ", Name='" & _name & "'" _
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

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'Customer