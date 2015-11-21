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
'               specific Passbook Feature instance.
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

Public Class PassbookFeature

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables
    'Unique passbook feature ID
    Private mId As String

    'Total purchase price
    Private mPurchPrice As Decimal

    'Passbook to add feature to
    Private mPassbk As Passbook

    'Feature being added
    Private mFeature As Feature

    'Quantity purchased
    Private mQtyPurch As Decimal

    'Quantity remaining
    Private mQtyRemain As Decimal

#End Region 'Attributes

#Region "Constructors"
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes
    Public Sub New(ByVal pId As String, _
                   ByVal pFeature As Feature, _
                   ByVal pPassbk As Passbook, _
                   ByVal pQtyPurch As Decimal
                   )
        'invoke the default constructor to invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _id = pId
        _feature = pFeature
        _passbk = pPassbk

        If Not pFeature Is Nothing Then
            _purchPrice = CDec(IIf(pPassbk.visIsChild = False, _
                                   pFeature.adultPrice, pFeature.childPrice))
        End If

        _qtyPurch = pQtyPurch
        _qtyRemain -= pQtyPurch
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
            Return _id
        End Get
    End Property

    Public Property purchPrice() As Decimal
        Get
            Return _purchPrice
        End Get
        Set(pValue As Decimal)
            _purchPrice = pValue
        End Set
    End Property

    Public Property passbk() As Passbook
        Get
            Return _passbk
        End Get
        Set(pValue As Passbook)
            _passbk = pValue
        End Set
    End Property

    Public Property feature() As Feature
        Get
            Return _feature
        End Get
        Set(pValue As Feature)
            _feature = pValue
        End Set
    End Property

    Public Property qtyPurch() As Decimal
        Get
            Return _qtyPurch
        End Get
        Set(pValue As Decimal)
            _qtyPurch = pValue
        End Set
    End Property

    Public Property qtyRemain() As Decimal
        Get
            Return _qtyRemain
        End Get
        Set(pValue As Decimal)
            _qtyRemain = pValue
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

    Private Property _purchPrice() As Decimal
        Get
            Return mPurchPrice
        End Get
        Set(pValue As Decimal)
            mPurchPrice = pValue
        End Set
    End Property

    Private Property _passbk() As Passbook
        Get
            Return mPassbk
        End Get
        Set(pValue As Passbook)
            mPassbk = pValue
        End Set
    End Property

    Private Property _feature() As Feature
        Get
            Return mFeature
        End Get
        Set(pValue As Feature)
            mFeature = pValue
        End Set
    End Property

    Private Property _qtyPurch() As Decimal
        Get
            Return mQtyPurch
        End Get
        Set(pValue As Decimal)
            mQtyPurch = pValue
        End Set
    End Property

    Private Property _qtyRemain() As Decimal
        Get
            Return mQtyRemain
        End Get
        Set(pValue As Decimal)
            mQtyRemain = pValue
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

    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim _tmpStr As String = ""

        _tmpStr = "[PurchaseFeature] -> " _
            & " Id=" & _id _
            & ", Feature=" & _feature.ToString _
            & ", Passbk=" & _passbk.ToString _
            & ", PurchasePrice=" & _purchPrice _
            & ", QtyPurchased=" & _qtyPurch _
            & ", QtyRemain=" & _qtyRemain

        Return _tmpStr
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

End Class 'PassbookFeature