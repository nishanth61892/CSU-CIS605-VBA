'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Automobile Simulator
'File:          ClsAutomobile.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for Automobile which is  
'               used within the Ch04Ex01 Visual Basic program. 
'
'Date:          09/22/15
'                 - initial release
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

Public Class Automobile

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables
    Private mOdometer As Integer
    Private mSpeed As Integer
    Private mTime As Decimal
    Private mDistance As Integer

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

        'Initialize class variables
        mOdometer = 0

    End Sub 'New()

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

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

    'Get/Set
    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    'Procedure to update the odometer by the distance specified
    Public Sub drive(ByVal pDistance As Integer)

        If pDistance >= 0 Then
            mOdometer += pDistance
            FrmMain.updateOdometer(mOdometer)
        End If
        '        MsgBox("Update the odometer by the " & pDistance.ToString & " mile(s)", MsgBoxStyle.Information)

    End Sub

    'Procedure to calculate the distrance driven using the specified
    'speed and time.  Odometer is updated accordingly
    Public Sub drive(ByVal pSpeed As Integer, pTime As Decimal)

        mOdometer += distance(pSpeed, pTime)
        FrmMain.updateOdometer(mOdometer)

        '       MsgBox("Calculate distance using Speed=" & pSpeed.ToString & " and Time=" &
        '       pTime.ToString, MsgBoxStyle.Information)

    End Sub

    'Procedure ToString() is the public method that calls the private method
    'to convert the data in the object to a String.  It overrides the inherited
    'Object ToString().
    Public Overrides Function ToString() As String

        Return _toString()

    End Function 'ToString()

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    'Function_toString() creates and returns a String version of the
    'data stored in the current oject.
    Private Function _toString() As String
        Dim _tmpStr As String

        _tmpStr = "Convert 'this' object to a String to display"

        MsgBox(_tmpStr)

        Return _tmpStr

    End Function
    '********** Private Non-Shared Behavioral Methods

    'Procedure to calculate the distrance driven using the specified
    'speed and time.  Odometer is updated accordingly
    Public Shared Function distance(ByVal pSpeed As Integer, pTime As Decimal) As Integer
        Dim _distance As Decimal = 0

        Try
            _distance = Convert.ToDecimal(pSpeed) * pTime
        Catch
            MsgBox("Division Exception: pTime = 0")
        End Try

        Return Convert.ToInt16(_distance)

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

End Class 'Automobile