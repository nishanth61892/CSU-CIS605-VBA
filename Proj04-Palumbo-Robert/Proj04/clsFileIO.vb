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
    Private mThemePark As ThemePark

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'These are all public.

    '********** Default constructor
    '             - no parameters
    Public Sub New(ByVal pThemePark As ThemePark)
        _themePark = pThemePark
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

    Private Property _themePark As ThemePark
        Get
            Return mThemePark
        End Get
        Set(value As ThemePark)
            mThemePark = value
        End Set
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

    'exportData() exports data records from the transactions array
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


    '_writeTransxErrRec() write a error record to the transaction
    'error file for each input data record that is found to 
    'contains format errors.
    Private Sub _writeTransxErrRec(ByVal pErrObj As String)
        _errFile.WriteLine(pErrObj)
    End Sub '_writeTransxErrRec(...)


    '_parseCust() processes a customer data record
    '
    'Format:
    '<date>;<time>;CUSTOMER;CREATE;<custid>;<custname>
    '
    Private Sub _parseCust(ByVal pInpLine As String,
                           ByVal pLineCnt As Integer,
                           ByVal field() As String)
        Dim errFlag As Boolean = False

        Dim trxDate As String = field(0)
        Dim trxTime As String = field(1)
        Dim trxType As String = field(2)
        Dim trxAction As String = field(3)

        '1st 4 fields are always valid according to Dr. Turks 
        'requirements.  For a customer record there must be 6
        'fields
        If field.Length = 6 Then
            Dim custId As String = field(4)
            Dim custName As String = field(5)

            'Validation is complete - if no errors we can add the customer
            '          If errFlag = False Then
            _themePark.createCust(custId, custName)
            'End If
        Else
            errFlag = True
        End If

        'If any error were detected write an error to the transaction error
        'log file.
        If errFlag = True Then
            Dim errStr As String = _
                "Line=" & pLineCnt & ", " & pInpLine & vbCrLf
            _writeTransxErrRec(errStr)
        End If
    End Sub '_parseCust(...)

    '_parseFeat() processes a feature data record
    Private Sub _parseFeat(ByVal pInpLine As String,
                           ByVal pLineCnt As Integer,
                           ByVal field() As String)

        Dim errFlag As Boolean = False

        Dim trxDate As String = field(0)
        Dim trxTime As String = field(1)
        Dim trxType As String = field(2)
        Dim trxAction As String = field(3)

        '1st 4 fields are always valid according to Dr. Turks 
        'requirements.  For a customer record there must be 6
        'fields
        If field.Length = 9 Then
            Dim featId As String = field(4)
            Dim featName As String = field(5)
            Dim featUnit As String = field(6)
            Dim featAdultPrice As String = field(7)
            Dim featChildPrice As String = field(8)

            Dim adultPrice As Decimal = -1D
            Dim childPrice As Decimal = -1D

            If Not IsNumeric(featAdultPrice) Then
                errFlag = True
            Else
                adultPrice = Decimal.Parse(featAdultPrice)
                If adultPrice < 0D Then
                    errFlag = True
                End If
            End If

            If Not IsNumeric(featChildPrice) Then
                errFlag = True
            Else
                childPrice = Decimal.Parse(featChildPrice)
                If childPrice < 0D Then
                    errFlag = True
                End If
            End If

            'Validation is complete - if no errors we can add the customer
            '          If errFlag = False Then
            _themePark.createFeat(featId,
                                   featName,
                                   featUnit,
                                   adultPrice,
                                   childPrice)
        Else
            errFlag = True
        End If

        'If any error were detected write an error to the transaction error
        'log file.
        If errFlag = True Then
            Dim errStr As String = _
                "Line=" & pLineCnt & ", " & pInpLine & vbCrLf
            _writeTransxErrRec(errStr)
        End If
    End Sub '_parseFeat(...)

    '_parsePassbk() processes a passbook data record
    Private Sub _parsePassbk(ByVal pInpLine As String,
                             ByVal pLineCnt As Integer,
                             ByVal field() As String)
        Dim errFlag As Boolean = False

        Dim trxDate As String = field(0)
        Dim trxTime As String = field(1)
        Dim trxType As String = field(2)
        Dim trxAction As String = field(3)

        '1st 4 fields are always valid according to Dr. Turks 
        'requirements.  For a customer record there must be 6
        'fields
        If field.Length = 6 Then
            'Validation is complete - if no errors we can add the customer
            '          If errFlag = False Then
        Else
            errFlag = True
        End If

        'If any error were detected write an error to the transaction error
        'log file.
        If errFlag = True Then
            Dim errStr As String = _
                "Line=" & pLineCnt & ", " & pInpLine & vbCrLf
            _writeTransxErrRec(errStr)
        End If

    End Sub '_parsePassbk(...)

    '_parsePassbkFeat() processes a passbook feature data record
    Private Sub _parsePassbkFeat(ByVal pInpLine As String,
                                 ByVal pLineCnt As Integer,
                                 ByVal field() As String)

    End Sub '_parsePassbkFeat(...)

    '_parseUsedFeat() processes a used feature data record
    Private Sub _parseUsedFeat(ByVal pInpLine As String,
                               ByVal pLineCnt As Integer,
                               ByVal field() As String)

    End Sub '_parseUsedFeat(...)


    '_parseInpFields() processes each line per the format that is
    'reflected by the data type and action fields
    Private Sub _parseInpFields(ByVal pInpLine As String,
                                ByVal pLineCnt As Integer,
                                ByVal field() As String)

        'We can skip comments (1st char=#) but write trans rec
        If pInpLine(0) = "#" Then
            _themePark.writeTransxRec(_themePark.transxObjType,
                                       Nothing,
                                       pInpLine)
        Else
            Select Case field(2).ToUpper
                Case _themePark.transxCustType
                    Console.WriteLine("CUSTOMER INPUT DATA")
                    _parseCust(pInpLine, pLineCnt, field)
                Case _themePark.transxFeatType
                    Console.WriteLine("FEATURE INPUT DATA")
                    _parseFeat(pInpLine, pLineCnt, field)
                Case _themePark.transxPassbkType
                    Console.WriteLine("PASSBOOK INPUT DATA")
                    _parsePassbk(pInpLine, pLineCnt, field)
                Case _themePark.transxPassbkFeatType
                    Console.WriteLine("PASSBOOK FEATURE INPUT DATA")
                    _parsePassbkFeat(pInpLine, pLineCnt, field)
            End Select
        End If
    End Sub '_parseInpFields(...)

    '_parseInpLine() processes the current input line by parsing it
    'out per data file format requirements.
    Private Sub _parseInpLine(ByVal pInpLine As String,
                              ByVal pLineCnt As Integer)
        Dim inpFields() As String

        If Not String.IsNullOrEmpty(pInpLine) Then
            inpFields = Split(pInpLine, ";")

            'Strip off all leading/trailing whitespace from each field
            For i = 0 To inpFields.Length - 1
                inpFields(i) = inpFields(i).Trim
                Console.WriteLine(inpFields(i))
            Next i

            'Now handle each data line format
            _parseInpFields(pInpLine, pLineCnt, inpFields)
        End If
    End Sub '_processInputLine(...)

    '_importData() imports data records from the transactions-in.txt
    'data file.  It is used to populate the system with a predefined  
    'data set.
    Private Sub _importData(ByVal pInpFileName As String,
                            ByVal pErrFileName As String)
        Dim lineCnt As Integer = 0

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
            lineCnt += 1
            Try
                _parseInpLine(_inFile.ReadLine, lineCnt)
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