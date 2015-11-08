'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch05Ex01
'File:          ClsSnowshoe.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for Snowshoe which is  
'               used within the Ch05Ex01 Visual Basic program. 
'               This is a practice/learning assignment. It is used to
'               simulate the sale/rental of snowshoes from Snowshoe
'               Store.
'
'Date:          11/08/2015     
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

Public Class Snowshoe

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mSnowshoeName As String
    Private mPurchPrice As Decimal
    Private mRentPrice As Decimal

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

    Sub New(ByVal pSnowshoeName As String, _
            ByVal pPurchPrice As Decimal, _
            ByVal pRentPrice As Decimal _
           )

        MyBase.New()

        _snowshoeName = pSnowshoeName
        _purchPrice = pPurchPrice
        _rentPrice = pRentPrice
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

    Public ReadOnly Property snowshoeName() As String
        Get
            Return _snowshoeName
        End Get
    End Property

    Public ReadOnly Property purchPrice() As Decimal
        Get
            Return _purchPrice
        End Get
    End Property

    Public ReadOnly Property rentPrice() As Decimal
        Get
            Return _rentPrice
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _snowshoeName() As String
        Get
            Return mSnowshoeName
        End Get
        Set(ByVal value As String)
            mSnowshoeName = value
        End Set
    End Property

    Private Property _purchPrice() As Decimal
        Get
            Return mPurchPrice
        End Get
        Set(ByVal value As Decimal)
            mPurchPrice = value
        End Set
    End Property

    Private Property _rentPrice() As Decimal
        Get
            Return mRentPrice
        End Get
        Set(ByVal value As Decimal)
            mRentPrice = value
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

    'ToString() is the public interface that provides a String 
    'version of the data stored in the class attributes.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods

    'Private Non-Shared Behavioral Methods

    '****************************************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String

        tmpStr = "[Snowshoe] -> " _
            & "SnowshoeName=" & _snowshoeName _
            & ", PurchPrice=" & _purchPrice.ToString("C") _
            & ", RentPrice=" & _rentPrice.ToString("C")

        Return tmpStr
    End Function '_toString()

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

End Class 'Snowshoe