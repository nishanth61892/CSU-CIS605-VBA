'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
'File:          ClsUtils.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for Utils which is  
'               used within the Theme Park Management System
'               Visual Basic program.
'
'               It contains utility functions that are used by
'               all the classes in the system.
'
'               This class defines the overall structure for a
'               specific Utils instance.
'
'Date:          12/08/15
'                   - initial creation
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

Public Class Utils

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Minimum age to be considered an adult. Less than this age is 
    'thusly considered a child
    Private Const mADULT_MIN_AGE As Integer = (13)


#End Region 'Attributes

#Region "Constructors"
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Shared ReadOnly Property _ADULT_MIN_AGE As Integer
        Get
            Return mADULT_MIN_AGE
        End Get
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '****************************************************************************************
    'Behavioral Methods
    '****************************************************************************************

    '********** Public Shared Behavioral Methods

    '****************************************************************************************
    'calcAge() is used to calculate the age in years based upon a given date and NOW.
    '****************************************************************************************
    Public Shared Function calcAge(ByVal pDate As Date) As Integer
        Return _calcAge(pDate)
    End Function 'calcAge(...)


    '****************************************************************************************
    'isAdult() is used to determine if a reference age indicates an adult or minor
    '****************************************************************************************
    Public Shared Function isAdult(ByVal pAge As Integer) As Boolean
        Return _isAdult(pAge)
    End Function 'isAdult(...)




    '********** Private Shared Behavioral Methods

    '****************************************************************************************
    '_calcAge() is used to calculate the age in years based upon a given date and NOW.
    '****************************************************************************************
    Private Shared Function _calcAge(ByVal pVisDoB As Date) As Integer
        Dim age As Integer = 0
        Dim dateNow As Date = Now

        'Need to compensate for DoB in the current year 
        Dim dobYear As Integer = pVisDoB.Year
        Dim nowYear As Integer = Now.Year

        age = nowYear - dobYear
        If pVisDoB.AddYears(age) > dateNow Then
            age -= 1
        End If

        Return age
    End Function '_calcAge(...)

    '****************************************************************************************
    '_isAdult() is used to determine if a reference age indicates an adult or minor
    '****************************************************************************************
    Private Shared Function _isAdult(ByVal pAge As Integer) As Boolean
        Return pAge < _ADULT_MIN_AGE
    End Function '_isAdult(...)


    '********** Public Non-Shared Behavioral Methods

    '****************************************************************************************
    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    '****************************************************************************************
    Public Overrides Function ToString() As String
        Return _toString()
    End Function

    '********** Private Non-Shared Behavioral Methods

    '****************************************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String

        tmpStr = "[Utils:: N/A" _
            & "]"

        Return tmpStr
    End Function

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '****************************************************************************************
    'Event Procedures
    '****************************************************************************************

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
    '****************************************************************************************
    'Events
    '****************************************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'Utils