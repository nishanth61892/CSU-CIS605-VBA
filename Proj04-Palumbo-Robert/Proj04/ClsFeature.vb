'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
'File:          ClsPassbookFeature.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for ThemePark which is  
'               used within the Theme Park Management System
'               Visual Basic program. 
'
'               This class defines the overall structure for a
'               specific Feature instance.
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

Public Class Feature

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Unique feature identifier
    Private mFeatId As String

    'Specific feature name
    Private mFeatName As String

    'Unit of measure to which pricing is applied (day/week/hour/etc)
    Private mUnitOfMeas As String

    'Adult price for one unit of the feature
    Private mAdultPrice As Decimal

    'Child price for one unit of the feature
    Private mChildPrice As Decimal

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
    Public Sub New(ByVal pFeatId As String, _
                   ByVal pFeatName As String, _
                   ByVal pUnitOfMeas As String, _
                   ByVal pAdultPrice As Decimal, _
                   ByVal pChildPrice As Decimal
                   )

        'invoke the default constructor to invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _featId = pFeatId
        _featName = pFeatName
        _unitOfMeas = pUnitOfMeas
        _adultPrice = pAdultPrice
        _childPrice = pChildPrice
    End Sub 'New()

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    Public ReadOnly Property featId() As String
        Get
            Return _featId
        End Get
    End Property

    Public Property featName() As String
        Get
            Return _featName
        End Get
        Set(pValue As String)
            _featName = pValue
        End Set
    End Property

    Public Property unitOfMeas() As String
        Get
            Return _unitOfMeas
        End Get
        Set(pValue As String)
            _unitOfMeas = pValue
        End Set
    End Property

    Public Property adultPrice() As Decimal
        Get
            Return _adultPrice
        End Get
        Set(pValue As Decimal)
            _adultPrice = pValue
        End Set
    End Property

    Public Property childPrice() As Decimal
        Get
            Return _childPrice
        End Get
        Set(pValue As Decimal)
            _childPrice = pValue
        End Set
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _featId() As String
        Get
            Return mFeatId
        End Get
        Set(pValue As String)
            mFeatId = pValue
        End Set
    End Property

    Private Property _featName() As String
        Get
            Return mFeatName
        End Get
        Set(pValue As String)
            mFeatName = pValue
        End Set
    End Property

    Private Property _unitOfMeas() As String
        Get
            Return mUnitOfMeas
        End Get
        Set(pValue As String)
            mUnitOfMeas = pValue
        End Set
    End Property

    Private Property _adultPrice() As Decimal
        Get
            Return mAdultPrice
        End Get
        Set(pValue As Decimal)
            mAdultPrice = pValue
        End Set
    End Property

    Private Property _childPrice() As Decimal
        Get
            Return mChildPrice
        End Get
        Set(pValue As Decimal)
            mChildPrice = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '****************************************************************************************
    'Behavioral Methods
    '****************************************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    '****************************************************************************************
    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    '****************************************************************************************
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods

    '****************************************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String = ""

        tmpStr = "[Feature] -> " _
            & " Id=" & _featId _
            & ", Name=" & _featName _
            & ", UnitOfMeas=" & _unitOfMeas _
            & ", AdultPrice=" & _adultPrice _
            & ", ChildPrice=" & _childPrice

        Return tmpStr
    End Function '_toString()

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

End Class 'Feature