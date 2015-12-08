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

    'Input file stream object
    Private mInFile As StreamReader

    'Output transaction file stream object
    Private mOutFile As StreamWriter

    'Output error file stream object
    Private mErrFile As StreamWriter


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

    Private Property _inFile As StreamReader
        Get
            Return mInFile
        End Get
        Set(value As StreamReader)
            mInFile = value
        End Set
    End Property

    Private Property _outFile As StreamWriter
        Get
            Return mOutFile
        End Get
        Set(value As StreamWriter)
            mOutFile = value
        End Set
    End Property

    Private Property _errFile As StreamWriter
        Get
            Return mErrFile
        End Get
        Set(value As StreamWriter)
            mErrFile = value
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

    'importData() imports data records from the transactions-in.txt
    'data file.  It is used to populate the system with a predefined  
    'data set and is invoked from the 'Process Test Data' button on
    'the System Test tab.
    Public Sub importData(ByVal pInpFileName As String,
                          ByVal pErrFileName As String)
        _importData(pInpFileName, pErrFileName)
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

    '_parseInpLineFmt() processes each line per the format that is
    'reflected by the data type and action fields
    Private Sub _parseInpLineFmt(ByVal pInpLine As String,
                                 ByVal pSary() As String)

    End Sub '_parseInpLineFmt(...)

    '_parseInpLine() processes the current input line by parsing it
    'out per data file format requirements.
    Private Sub _parseInpLine(ByVal pInpLine As String)
        Console.WriteLine("INP=" & pInpLine)
        Dim inpFields() As String

        If Not String.IsNullOrEmpty(pInpLine) Then
            inpFields = Split(pInpLine, ";")

            'String leading/trailing whitespace off each element
            For Each f In inpFields
                f = f.Trim
                Console.WriteLine(f)
            Next

            'We can skip comments (1st char=#) but write trans rec
            If pInpLine(0) = "#" Then
                themePark.writeTransxRec(themePark.transxObjType,
                                           Nothing,
                                           pInpLine)
                Exit Sub
            End If

            'Now handle each data line format
            _parseInpLineFmt(pInpLine, inpFields)
        End If
    End Sub '_processInputLine(...)

    '_importData() imports data records from the transactions-in.txt
    'data file.  It is used to populate the system with a predefined  
    'data set.
    Private Sub _importData(ByVal pInpFileName As String,
                            ByVal pErrFileName As String)
        'Open the input data file
        Try
            _inFile = New StreamReader(pInpFileName)
        Catch ex As IOException
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Throw ex
            Exit Sub
        End Try

        'Open the transaction error file
        Try
            _errFile = New StreamWriter(pErrFileName)
        Catch ex As IOException
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Throw ex
            _inFile.Close()
            Exit Sub
        End Try

        'Start parse the input data file line by line
        While Not _inFile.EndOfStream
            Try
                _parseInpLine(_inFile.ReadLine)
            Catch ex As Exception
                Throw ex
                _inFile.Close()
                _errFile.Close()
                Exit Sub
            End Try
        End While

        'Close both files before exiting else we can't reopen them on
        'another pass through this method
        _inFile.Close()
        _errFile.Close()

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