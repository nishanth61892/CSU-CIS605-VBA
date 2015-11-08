'Copyright (c) 2009-2014 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch05Ex01
'File:          ClsSnowshoeStore_EventArgs_SnowshoeAdded.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for the SnowshoeStore_EventArgs_SnowshoeAdded
'               custom event.  This event is raised when a snowshoe is added 
'               to the system to inform any listeners of the event.
'               It is the job of the listener to handle the event and process it.
'
'Date:          11/08/2015
'                  - Initial creation
'
'Tier:          User Interface
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

Public Class OutdoorStore_EventArgs_SnowshoeAdded
    Inherits System.EventArgs

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    Private mSnowshoe As Snowshoe

#End Region 'Attributes

#Region "Constructors"
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

    'Default constructor - no parameters

    'Special constructor(s) - typically constructors have parameters 
    '                         that are used to initialize attributes

    Public Sub New(ByVal pSnowshoe As Snowshoe)
        MyBase.New()

        _snowshoe = pSnowshoe
    End Sub 'New(pSnowshoe)

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    Public ReadOnly Property snowshoe As Snowshoe
        Get
            Return _snowshoe
        End Get
    End Property

    'Private Get/Set Methods - access attributes, 
    '                          begin name with underscore (_)

    Private Property _snowshoe As Snowshoe
        Get
            Return mSnowshoe
        End Get
        Set(pValue As Snowshoe)
            mSnowshoe = pValue
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

    '****************************************************************************************
    'ToString() is the public interface that provides a String 
    'version of the data stored in the class attributes.
    '****************************************************************************************
    Public Overrides Function ToString() As String
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

        tmpStr = "[AddSnowshoe-Event] -> " _
            & "Snowshoe=" & _snowshoe.ToString

        Return tmpStr
    End Function '_toString()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

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
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.

#End Region 'Events

End Class 'OutdoorStore_EventArgs_SnowshoeAdded