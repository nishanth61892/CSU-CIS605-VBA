'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj02 - Theme Park Management System
'File:          ClsThemePark.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for ThemePark which is  
'               used within the Theme Park Management System
'               Visual Basic program. 
'
'               This class defines the overall structure for a
'               specific Theme Park instance.
'
'Date:          10/05/2015
'                   - initial creation
'                   - Code for Proj02 - second phase of the course project.
'
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

Public Class ThemePark

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants
    Private mTHEME_PARK_NAME As String = "Palumbo-Park"

    '********** Module-level variables

    'Theme park name for the one theme park instance
    Private mThemeParkName As String = mTHEME_PARK_NAME

    'Number of customers in the system
    Private mNumCusts As Integer

    'Number of passbooks in the system
    Private mNumPassbks As Integer

    'Number of features in the system
    Private mNumFeats As Integer

    'Number of passbook features in the system
    Private mNumPassbkFeats As Integer

    'Number of used features in the system
    Private mNumUsedFeats As Integer


#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'These are all public.

    '********** Default constructor
    '             - no parameters
    Public Sub New()

        'invoke the parent object constructor
        MyBase.New()

    End Sub 'New()

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes
    Public Sub New(ByVal pParkName As String)

        'invoke the default constructor to invoke the parent object constructor
        Me.New()

        'Initialize the attributes
        _themeParkName = pParkName
        _numCusts = 0
        _numFeats = 0
        _numPassbks = 0
        _numPassbkFeats = 0
        _numUsedFeats = 0
    End Sub 'New()

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    Public Property themeParkName() As String
        Get
            Return _themeParkName
        End Get
        Set(pValue As String)
            _themeParkName = pValue
        End Set
    End Property

    Public Property numCusts() As Integer
        Get
            Return _numCusts
        End Get
        Set(pValue As Integer)
            _numCusts = pValue
        End Set
    End Property

    Private Property numPassbks() As Integer
        Get
            Return _numPassbks
        End Get
        Set(pValue As Integer)
            _numPassbks = pValue
        End Set
    End Property

    Private Property numFeats() As Integer
        Get
            Return _numFeats
        End Get
        Set(pValue As Integer)
            _numFeats = pValue
        End Set
    End Property

    Private Property numPassbkFeats() As Integer
        Get
            Return _numPassbkFeats
        End Get
        Set(pValue As Integer)
            _numPassbkFeats = pValue
        End Set
    End Property

    Private Property numUsedFeats() As Integer
        Get
            Return _numUsedFeats
        End Get
        Set(pValue As Integer)
            _numUsedFeats = pValue
        End Set
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _themeParkName() As String
        Get
            Return mThemeParkName
        End Get
        Set(pValue As String)
            mThemeParkName = pValue
        End Set
    End Property

    Private Property _numCusts() As Integer
        Get
            Return mNumCusts
        End Get
        Set(pValue As Integer)
            mNumCusts = pValue
        End Set
    End Property

    Private Property _numPassbks() As Integer
        Get
            Return mNumPassbks
        End Get
        Set(pValue As Integer)
            mNumPassbks = pValue
        End Set
    End Property

    Private Property _numFeats() As Integer
        Get
            Return mNumFeats
        End Get
        Set(pValue As Integer)
            mNumFeats = pValue
        End Set
    End Property

    Private Property _numPassbkFeats() As Integer
        Get
            Return mNumPassbkFeats
        End Get
        Set(pValue As Integer)
            mNumPassbkFeats = pValue
        End Set
    End Property

    Private Property _numUsedFeats() As Integer
        Get
            Return mNumUsedFeats
        End Get
        Set(pValue As Integer)
            mNumUsedFeats = pValue
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

    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'ToString()

    'createCustomer() creates and returns a new Customer object
    Public Function createCustomer(ByVal pCustId As String, _
                                   ByVal pCustName As String
                                   ) As Customer

        'Call the worker procedure to do the work
        Return _createCustomer(pCustId, pCustName)
    End Function 'createCustomer(...)

    'createFeature() creates and returns a new Feature
    Public Function createFeature(ByVal pFeatId As String, _
                                  ByVal pFeatName As String, _
                                  ByVal pUnitOfMeas As String, _
                                  ByVal pAdultPrice As Decimal, _
                                  ByVal pChildPrice As Decimal
                                  ) As Feature

        'Call the worker procedure to do the work
        Return _createFeature(pFeatId, _
                              pFeatName, _
                              pUnitOfMeas, _
                              pAdultPrice, _
                              pChildPrice
                              )
    End Function 'createFeature(...)

    'createPassbook() creates and returns a new Passbook
    Public Function createPassbook(ByVal pPassbkId As String, _
                                   ByVal pOwner As Customer, _
                                   ByVal pDatePurch As Date, _
                                   ByVal pVisName As String, _
                                   ByVal pVisDob As Date, _
                                   ByVal pVisAge As Integer, _
                                   ByVal pVisIsChild As Boolean
                                   ) As Passbook

        'Call the worker procedure to do the work
        Return _createPassbook(pPassbkId, _
                               pOwner, _
                               pDatePurch, _
                               pVisName, _
                               pVisDob, _
                               pVisAge, _
                               pVisIsChild
                               )
    End Function 'createPassbook(...)

    'purchaseFeature() creates and returns a new Passbook
    Public Function purchaseFeature(ByVal pPassbkFeatId As String, _
                                    ByVal pPurchPrice As Decimal, _
                                    ByVal pFeature As Feature, _
                                    ByVal pPassbk As Passbook, _
                                    ByVal pQtyPurch As Decimal, _
                                    ByVal pQtyRemain As Decimal
                                    ) As PassbookFeature

        'Call the worker procedure to do the work
        Return _purchaseFeature(pPassbkFeatId, _
                                pPurchPrice, _
                                pFeature, _
                                pPassbk, _
                                pQtyPurch, _
                                pQtyRemain
                                )
    End Function 'purchaseFeature(...)

    'usedFeature() creates and returns a new Passbook
    Public Function usedFeature(ByVal pId As String, _
                                ByVal pPassbkFeatId As PassbookFeature, _
                                ByVal pDateUsed As Date, _
                                ByVal pQtyUsed As Decimal, _
                                ByVal pLoc As String
                                ) As UsedFeature

        'Call the worker procedure to do the work
        Return _usedFeature(pId, _
                            pPassbkFeatId, _
                            pDateUsed, _
                            pQtyUsed, _
                            pLoc
                            )
    End Function 'usedFeature(...)


    '********** Private Non-Shared Behavioral Methods

    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    Private Function _toString() As String
        Dim _tmpStr As String = ""

        _tmpStr = "[Theme Park] -> " _
            & " Name=" & _themeParkName _
            & ", #Customers=" & _numCusts _
            & ", #Passbooks=" & _numPassbks _
            & ", #Features=" & _numFeats _
            & ", #PassbookkFeatures=" & _numPassbkFeats _
            & ", #UsedFeaturess=" & _numUsedFeats

        Return _tmpStr
    End Function '_toString(...)

    '_createCustomer() creates and returns a new Customer object.
    'This is the work-horse function that does all the work for 
    '_createCustomer().
    Private Function _createCustomer(ByVal pCustId As String, _
                                     ByVal pCustName As String
                                     ) As Customer
        Dim cust As Customer = New Customer(pCustId, pCustName)

        'update the customer cnt in the system
        _numCusts += 1

        Return cust
    End Function '_createCustomer(...)

    '_createFeature() creates and returns a new Feature object.
    'This is the work-horse function that does all the work for 
    'createFeature().
    Private Function _createFeature(ByVal pFeatId As String, _
                                    ByVal pFeatName As String, _
                                    ByVal pUnitOfMeas As String, _
                                    ByVal pAdultPrice As Decimal, _
                                    ByVal pChildPrice As Decimal
                                    ) As Feature

        Dim newFeat As Feature = New Feature(pFeatId, _
                                             pFeatName, _
                                             pUnitOfMeas, _
                                             pAdultPrice, _
                                             pChildPrice
                                             )

        'update the feature cnt in the system
        _numFeats += 1

        Return newFeat
    End Function '_createFeature(...)

    '_createPassbook() creates and returns a new Passbook object.
    'This is the work-horse function that does all the work for 
    'createPassbook().
    Private Function _createPassbook(ByVal pPassbkId As String, _
                                     ByVal pOwner As Customer, _
                                     ByVal pDatePurch As Date, _
                                     ByVal pVisName As String, _
                                     ByVal pVisDob As Date, _
                                     ByVal pVisAge As Integer, _
                                     ByVal pVisIsChild As Boolean
                                     ) As Passbook

        Dim newPassbk As Passbook = New Passbook(pPassbkId, _
                                                 pOwner, _
                                                 pDatePurch, _
                                                 pVisName, _
                                                 pVisDob, _
                                                 pVisAge, _
                                                 pVisIsChild
                                                 )
        'update the passbook cnt in the system
        _numPassbks += 1

        Return newPassbk
    End Function '_createPassbook(...)

    '_purchaseFeature() creates and returns a new Passbook Feature
    'object. This is the work-horse function that does all the work for 
    'purchaseFeature().
    Private Function _purchaseFeature(ByVal pPassbkFeatId As String, _
                                      ByVal pPurchPrice As Decimal, _
                                      ByVal pFeature As Feature, _
                                      ByVal pPassbk As Passbook, _
                                      ByVal pQtyPurch As Decimal, _
                                      ByVal pQtyRemain As Decimal _
                                      ) As PassbookFeature

        Dim newPassbkFeat As PassbookFeature = New PassbookFeature(pPassbkFeatId, _
                                                                   pPurchPrice, _
                                                                   pFeature, _
                                                                   pPassbk, _
                                                                   pQtyPurch, _
                                                                   pQtyRemain
                                                                   )
        'update the passbook cnt in the system
        _numPassbkFeats += 1

        Return newPassbkFeat
    End Function '_purchaseFeature(...)

    '_usedFeature() creates and returns a new Used Passbook Feature
    'object. This is the work-horse function that does all the work for 
    'postFeature(). This is accounting for when a customer 'uses' a
    'feature previously purchased and added to a passbook owned by the
    'customer.
    Private Function _usedFeature(ByVal pId As String, _
                                  ByVal pPassbkFeatId As PassbookFeature, _
                                  ByVal pDateUsed As Date, _
                                  ByVal pQtyUsed As Decimal, _
                                  ByVal pLoc As String
                                  ) As UsedFeature

        Dim usedFeature As UsedFeature = New UsedFeature(pId, _
                                                         pPassbkFeatId, _
                                                         pQtyUsed, _
                                                         pLoc, _
                                                         pDateUsed
                                                         )
        'update the passbook cnt in the system
        _numUsedFeats += 1

        Return usedFeature
    End Function '_usedFeature(...)


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

End Class 'ThemePark