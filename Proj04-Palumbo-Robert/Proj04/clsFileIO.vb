'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
'File:          ClsFileIO.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for FileIO which is  
'               used within the Theme Park Management System to
'               read/write data/transaction records to the
'               required input/ouput files.
'
'Date:          12/07/2015
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
Option Strict On        'Must perform explicit data type conversions
Imports System.IO       'File I/O processing'
#End Region 'Option / Imports

Public Class FileIO

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants
    Private mSYS_FILEOPEN_ERR_MSG As String = _
        "ERROR: File OPEN Error, file="
    Private mSYS_FILECLOSE_ERR_MSG As String = _
        "ERROR: File CLOSE Error, file="
    Private mSYS_FILEREAD_ERR_MSG As String = _
        "ERROR: File READ Error, file="
    Private mSYS_FILEWRITE_ERR_MSG As String = _
        "ERROR: File WRITE Error, file="

    '********** Module-level variables
    'Themepark reference
    Private themePark As ThemePark

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'These are all public.

    '********** Default constructor
    '             - no parameters
    Public Sub New(ByVal pThemePark As ThemePark)
        themePark = pThemePark
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

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private ReadOnly Property _FILEOPEN_ERR As String
        Get
            Return mSYS_FILEOPEN_ERR_MSG
        End Get
    End Property

    Private ReadOnly Property _FILECLOSE_ERR As String
        Get
            Return mSYS_FILECLOSE_ERR_MSG
        End Get
    End Property

    Private ReadOnly Property _FILEREAD_ERR As String
        Get
            Return mSYS_FILEREAD_ERR_MSG
        End Get
    End Property

    Private ReadOnly Property _FILEWRITE_ERR As String
        Get
            Return mSYS_FILEWRITE_ERR_MSG
        End Get
    End Property
#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    'importData() imports data records from the transactions-in.txt
    'data file.  It is used to populate the system with a predefined  
    'data set and is invoked from the 'Process Test Data' button on
    'the System Test tab.
    Public Sub importData(ByVal pFileName As String)
        _importData(pFileName)
    End Sub 'importData()

    '_importData() exports data records from the transactions array
    'to the output data file transactions-out.txt.  It is invoked 
    'from the 'Process Test Data' button on the System Test tab.
    Public Sub exportData(ByVal pFileName As String,
                                 ByVal pAppend As Boolean)
        _exportData(pFileName, pAppend)
    End Sub 'exportData()

    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function

    '********** Private Non-Shared Behavioral Methods

    '_importData() imports data records from the transactions-in.txt
    'data file.  It is used to populate the system with a predefined  
    'data set.
    Private Sub _importData(ByVal pFileName As String)
        Dim inF As StreamReader

        MsgBox("ImportData: file=" & pFileName)

        Try
            inF = New StreamReader(pFileName)
        Catch ex As Exception
            MsgBox(_FILEOPEN_ERR & "'" & pFileName & "'", MsgBoxStyle.Exclamation)

        End Try
    End Sub '_importData()

    '_importData() exports data records from the transactions array
    'to the output data file transactions-out.txt.  This data file
    'can be used as an input file as well.
    Private Sub _exportData(ByVal pFileName As String,
                                 ByVal pAppend As Boolean)
        MsgBox("ExportData: file=" & pFileName & ", Append=" & pAppend.ToString)
    End Sub ''_importData()

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

End Class 'FileIO