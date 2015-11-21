'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
'File:          ClsThemePark_EventArgs_CreateFeat.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for the ThemePark_EventArgs_CreateFeat
'               custom event.  This event is raised when a new feature is added
'               to the system to inform any listeners of the event.  
'               It is the job of the listener to handle the event and process it.
'
'Date:          10/05/2015
'                   - initial creation
'                   - Code for Proj02 - second phase of the course project.
'               10/29/2015
'                   - Modifications to support the third phase of
'                   course project (Proj03)
'               11/20/2015
'                   - Modifications to support the fourth phase of
'                   course project (Proj04)
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

Public Class ThemePark_EventArgs_CreateFeat
    Inherits System.EventArgs

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Need to accept the received customer object
    Private mFeat As Feature

#End Region 'Attributes

#Region "Constructors"
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

    'Default constructor - no parameters

    'Special constructor(s) - typically constructors have parameters 
    '                         that are used to initialize attributes

    Public Sub New( _
            ByVal pFeat As Feature
            )

        'Special constructor - create the EventArgs object.

        MyBase.New()

        _feat = pFeat

    End Sub 'New(...)

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    Public ReadOnly Property feat As Feature
        Get
            Return _feat
        End Get
    End Property

    'Private Get/Set Methods - access attributes, 
    '                          begin name with underscore (_)

    Private Property _feat As Feature
        Get
            Return mFeat
        End Get
        Set(pValue As Feature)
            mFeat = pValue
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

        tmpStr = "[Feat-Event] -> " _
            & " Feat=" & _feat.ToString

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

End Class 'ThemePark_EventArgs_CreateFeat