'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
'File:          ClsUsedFeature.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for ThemePark which is  
'               used within the Theme Park Management System
'               Visual Basic program. 
'
'               This class defines the overall structure for a
'               specific Used-Feature instance.
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

Public Class UsedFeature

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Unique identifier associated with the used feature
    Private mId As String

    'Passbook feature to apply transaction on
    Private mPassbkFeat As PassbookFeature

    'Date feature was used
    Private mDateUsed As Date

    'Location where feature was used
    Private mLoc As String

    'Quantity used
    Private mQtyUsed As Decimal

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
    Public Sub New(ByVal pId As String, _
                   ByVal pPassbkFeat As PassbookFeature, _
                   ByVal pQtyUsed As Decimal, _
                   ByVal pLoc As String, _
                   ByVal pDateUsed As Date
                   )

        'invoke the default constructor to invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _id = pId
        _passbkFeat = pPassbkFeat
        _dateUsed = pDateUsed
        _loc = pLoc
        _qtyUsed = pQtyUsed
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
    Public ReadOnly Property id() As String
        Get
            Return mId
        End Get
    End Property

    Public Property passbkFeat() As PassbookFeature
        Get
            Return _passbkFeat
        End Get
        Set(pValue As PassbookFeature)
            _passbkFeat = pValue
        End Set
    End Property

    Public Property dateUsed() As Date
        Get
            Return _dateUsed
        End Get
        Set(pValue As Date)
            _dateUsed = pValue
        End Set
    End Property

    Public Property loc() As String
        Get
            Return _loc
        End Get
        Set(pValue As String)
            _loc = pValue
        End Set
    End Property

    Public Property qtyUsed() As Decimal
        Get
            Return _qtyUsed
        End Get
        Set(pValue As Decimal)
            _qtyUsed = pValue
        End Set
    End Property


    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _id() As String
        Get
            Return mId
        End Get
        Set(pValue As String)
            mId = pValue
        End Set
    End Property

    Private Property _passbkFeat() As PassbookFeature
        Get
            Return mPassbkFeat
        End Get
        Set(pValue As PassbookFeature)
            mPassbkFeat = pValue
        End Set
    End Property

    Private Property _dateUsed() As Date
        Get
            Return mDateUsed
        End Get
        Set(pValue As Date)
            mDateUsed = pValue
        End Set
    End Property

    Private Property _loc() As String
        Get
            Return mLoc
        End Get
        Set(pValue As String)
            mLoc = pValue
        End Set
    End Property

    Private Property _qtyUsed() As Decimal
        Get
            Return mQtyUsed
        End Get
        Set(pValue As Decimal)
            mQtyUsed = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '****************************************************************************************
    'Behavioral Methods
    '****************************************************************************************

    'No Behavioral Methods are currently defined.

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

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
        Dim tmpStr As String = ""
        Dim passbkFeatStr As String = ""


        'Make sure passbook feature is defined for the object
        If Not IsNothing(_passbkFeat) Then
            passbkFeatStr = passbkFeat.ToString
        Else
            passbkFeatStr = "No-Passbook-Feature-Reference-Found"
        End If

        tmpStr = "[UsedFeat::" _
            & "Id=" & _id _
            & ", Location=" & _loc _
            & ", QtyUsed=" & _qtyUsed _
            & ", DateUsed=" & _dateUsed _
            & ", Feature=" & passbkFeatStr _
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

End Class 'UsedFeature