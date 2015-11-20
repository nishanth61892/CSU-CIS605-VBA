'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Test03-Palumbo-Robert
'File:          ClsBank_EventArgs_CreateAccount.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for the Bank_EventArgs_CreateAccount
'               custom event.  This event is raised when a new account is added
'               to the system to inform any listeners of the event.  
'               It is the job of the listener to handle the event and process it.
'
'Date:          11/20/2015
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
Option Strict On    'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class Bank_EventArgs_CreateAccount
    Inherits System.EventArgs

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Need to accept the received account object
    Private mAcct As Account

#End Region 'Attributes

#Region "Constructors"
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

    'Default constructor - no parameters

    'Special constructor(s) - typically constructors have parameters 
    '                         that are used to initialize attributes

    Public Sub New(ByVal pAcct As Account
                   )

        'Special constructor - create the EventArgs object.

        MyBase.New()

        _acct = pAcct

    End Sub 'New(...)

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    Public ReadOnly Property acct As Account
        Get
            Return _acct
        End Get
    End Property

    'Private Get/Set Methods - access attributes, 
    '                          begin name with underscore (_)

    Private Property _acct As Account
        Get
            Return mAcct
        End Get
        Set(pValue As Account)
            mAcct = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '****************************************************************************************
    'Behavioral Methods
    '****************************************************************************************

    'Public Shared Behavioral Methods

    'Private Shared Behavioral Methods

    'Public Non-Shared Behavioral Methods

    Public Overrides Function ToString() As String

        'ToString() is the public interface that
        'provides a String version of the data
        'stored in the class attributes.

        Return _toString()

    End Function 'ToString()

    'Private Non-Shared Behavioral Methods

    '****************************************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String

        tmpStr = "[Create-Account-Event] -> " _
            & " Account=" & _acct.ToString

        Return tmpStr
    End Function '_toString()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '****************************************************************************************
    'Event Procedures
    '****************************************************************************************

    'No Event Procedures are currently defined

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '****************************************************************************************
    'Events
    '****************************************************************************************

#End Region 'Events

End Class 'Bank_EventArgs_CreateAccount