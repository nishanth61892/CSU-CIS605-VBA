'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj03 - Theme Park Management System
'File:          ClsPassbook.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for ThemePark which is  
'               used within the Theme Park Management System
'               Visual Basic program. 
'
'               This class defines the overall structure for a
'               specific Passbook instance.
'
'Date:          10/05/2015
'                   - initial creation
'                   - Code for Proj02 - second phase of the course project.
'               10/29/2015
'                   - Modifications to support the third phase of
'                   course project (Proj03)
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

Public Class Passbook

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Unique passbook identifier
    Private mPassbkId As String

    'Owner of the passbook
    Private mOwner As Customer

    'Date the passbook was purchased/created
    Private mDatePurch As Date

    'Associated visitor name
    Private mVisName As String

    'Associated visitor birthdate
    Private mVisDob As Date

    'Age of visitor
    Private mVisAge As Integer

    'True is visitor is a child (< 13 y/o) false otherwise
    Private mVisIsChild As Boolean

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
    Public Sub New(ByVal pPasskdId As String, _
                   ByVal pOwner As Customer, _
                   ByVal pDatePurch As Date, _
                   ByVal pVisName As String, _
                   ByVal pVisDob As Date, _
                   ByVal pVisAge As Integer, _
                   ByVal pVisIsChild As Boolean _
                   )

        'invoke the default constructor to invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _passbkId = pPasskdId
        _owner = pOwner
        _datePurch = pDatePurch
        _visName = pVisName
        _visDob = pVisDob
        _visAge = pVisAge
        _visIsChild = pVisIsChild

    End Sub

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    Public ReadOnly Property passbkId() As String
        Get
            Return _passbkId
        End Get
    End Property

    Public Property owner() As Customer
        Get
            Return _owner
        End Get
        Set(pValue As Customer)
            _owner = pValue
        End Set
    End Property

    Public Property datePurch() As Date
        Get
            Return _datePurch
        End Get
        Set(pValue As Date)
            _datePurch = pValue
        End Set
    End Property

    Public Property visName() As String
        Get
            Return _visName
        End Get
        Set(pValue As String)
            _visName = pValue
        End Set
    End Property

    Public Property visDob() As Date
        Get
            Return _visDob
        End Get
        Set(pValue As Date)
            _visDob = pValue
        End Set
    End Property

    Public Property visAge() As Integer
        Get
            Return _visAge
        End Get
        Set(pValue As Integer)
            _visAge = pValue
        End Set
    End Property

    Public Property visIsChild() As Boolean
        Get
            Return _visIsChild
        End Get
        Set(pValue As Boolean)
            _visIsChild = pValue
        End Set
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _passbkId() As String
        Get
            Return mPassbkId
        End Get
        Set(pValue As String)
            mPassbkId = pValue
        End Set
    End Property

    Private Property _owner() As Customer
        Get
            Return mOwner
        End Get
        Set(pValue As Customer)
            mOwner = pValue
        End Set
    End Property

    Private Property _datePurch() As Date
        Get
            Return mDatePurch
        End Get
        Set(pValue As Date)
            mDatePurch = pValue
        End Set
    End Property

    Private Property _visName() As String
        Get
            Return mVisName
        End Get
        Set(pValue As String)
            mVisName = pValue
        End Set
    End Property

    Private Property _visDob() As Date
        Get
            Return mVisDob
        End Get
        Set(pValue As Date)
            mVisDob = pValue
        End Set
    End Property

    Private Property _visAge() As Integer
        Get
            Return mVisAge
        End Get
        Set(pValue As Integer)
            mVisAge = pValue
        End Set
    End Property

    Private Property _visIsChild() As Boolean
        Get
            Return mVisIsChild
        End Get
        Set(pValue As Boolean)
            mVisIsChild = pValue
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

    '******************************************************************
    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    '******************************************************************
    Public Overrides Function ToString() As String
        Return _toString()
    End Function

    '********** Private Non-Shared Behavioral Methods

    '******************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '******************************************************************
    Private Function _toString() As String
        Dim tmpStr As String = ""

        tmpStr = "[Passbook] -> " _
            & " Id=" & _passbkId _
            & ", Owner=" & _owner.ToString _
            & ", PurchaseDate=" & _datePurch _
            & ", VisitorName=" & _visName _
            & ", VisitorDOB=" & _visDob _
            & ", VisitorAge=" & _visAge _
            & ", VisitorIsChild? " & _visIsChild

        Return tmpStr
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

End Class 'Passbook