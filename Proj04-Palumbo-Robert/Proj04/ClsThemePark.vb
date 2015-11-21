'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
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
'               10/29/2015
'                   - Modifications to support the third phase of
'                   course project (Proj03)
'               11/20/2015
'                   - Modifications to support the fourth phase of
'                   course project (Proj04)
'
'Tier:          Business Logic
'
'Exceptions:          All array accessor method (_ith<?>) will throw IndexOutOfRangeException
'                     for any index access outside the size of the defined array
'
'Exception-Handling:  TBD
'Events:              TBD
'Event-Handling:      TBD
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On  'Must declare variables before using them
Option Strict On    'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class ThemePark
    Inherits System.EventArgs

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************
    'System level error message
    Private Const mSYS_ERR_MSG As String = "Internal System Error: Object Creation Failed"
    Private Const mSYS_LOOKUP_ERR_MSG As String = "Internal System Error: Object Lookup Failed"

    'Input/Output file names
    Private Const mINPUT_FILENAME As String = "Transactions-in.txt"
    Private Const mOUTPUT_FILENAME As String = "Transactions-out.txt"

    'Array constants
    Private Const mCUSTOMER_ARRAY_SIZE_DFLT As Integer = 100
    Private Const mCUSTOMER_ARRAY_INC_DFLT As Integer = 50

    Private Const mPASSBK_ARRAY_SIZE_DFLT As Integer = 100
    Private Const mPASSBL_ARRAY_INC_DFLT As Integer = 50

    Private Const mFEATURE_ARRAY_SIZE_DFLT As Integer = 200
    Private Const mFEATURE_ARRAY_INC_DFLT As Integer = 50

    Private Const mPASSBKFEATURE_ARRAY_SIZE_DFLT As Integer = 100
    Private Const mPASSBKFEATURE_ARRAY_INC_DFLT As Integer = 50

    Private Const mUSED_FEATURE_ARRAY_SIZE_DFLT As Integer = 100
    Private Const mUSED_FEATURE_ARRAY_INC_DFLT As Integer = 50

    Private Const mTRANSX_ARRAY_SIZE_DFLT As Integer = 300
    Private Const mTRANSX_ARRAY_INC_DFLT As Integer = 100

    '********** Module-level variables

    'Theme park name for the one theme park instance
    Private mThemeParkName As String

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

    'Tracks customer array utilization
    Private mCustArrayMax As Integer

    'Tracks feature array utilization
    Private mFeatureArrayMax As Integer

    'Tracks passbook array utilization
    Private mPassbookArrayMax As Integer

    'Tracks passbook feature array utilization 
    Private mPassbookFeatureArrayMax As Integer

    'Tracks used feature array utilization
    Private mUsedFeatureArrayMax As Integer

    'Tracks transaction array utilization
    Private mTranxArrayMax As Integer

    '****************************************************************************************
    'Array Definitions
    '****************************************************************************************

    'Array to hold customers
    Private mCustomer() As Customer

    'Array to hold passbooks
    Private mPassbook() As Passbook

    'Array to hold features
    Private mFeature() As Feature

    'Array to hold passbook features
    Private mPassbookFeature() As PassbookFeature

    'Array to hold used features
    Private mUsedFeature() As UsedFeature

    'Array to hold transactions
    Private mTransx() As String


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
    Public Sub New(ByVal pParkName As String)

        'invoke the default constructor to invoke the parent object constructor
        MyBase.New()

        'Initialize the attributes
        _themeParkName = pParkName
        _numCusts = 0
        _numFeats = 0
        _numPassbks = 0
        _numPassbkFeats = 0
        _numUsedFeats = 0

        'Initialize array attributes
        _custArrayMax = _CUSTOMER_ARRAY_SIZE_DFLT
        _featureArrayMax = _FEATURE_ARRAY_SIZE_DFLT
        _passbookArrayMax = _PASSBK_ARRAY_SIZE_DFLT
        _passbookFeatureArrayMax = _PASSBKFEATURE_ARRAY_SIZE_DFLT
        _usedFeatureArrayMax = _USED_FEATURE_ARRAY_SIZE_DFLT
        _tranxArrayMax = _TRANSX_ARRAY_SIZE_DFLT

        'Array to hold passbooks
        ReDim mCustomer(_custArrayMax - 1)
        ReDim mFeature(_featureArrayMax - 1)
        ReDim mPassbook(_passbookArrayMax - 1)
        ReDim mPassbookFeature(_passbookArrayMax - 1)
        ReDim mUsedFeature(_usedFeatureArrayMax - 1)
        ReDim mTransx(_tranxArrayMax - 1)

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

    Public Property numPassbks() As Integer
        Get
            Return _numPassbks
        End Get
        Set(pValue As Integer)
            _numPassbks = pValue
        End Set
    End Property

    Public Property numFeats() As Integer
        Get
            Return _numFeats
        End Get
        Set(pValue As Integer)
            _numFeats = pValue
        End Set
    End Property

    Public Property numPassbkFeats() As Integer
        Get
            Return _numPassbkFeats
        End Get
        Set(pValue As Integer)
            _numPassbkFeats = pValue
        End Set
    End Property

    Public Property numUsedFeats() As Integer
        Get
            Return _numUsedFeats
        End Get
        Set(pValue As Integer)
            _numUsedFeats = pValue
        End Set
    End Property

    'Customer array accessor
    Public ReadOnly Property ithCust(ByVal pN As Integer) As Customer
        Get
            Return _ithCust(pN)
        End Get
    End Property

    'Feature array accessor
    Public ReadOnly Property ithFeat(ByVal pN As Integer) As Feature
        Get
            Return _ithFeat(pN)
        End Get
    End Property

    'Passbook array accessor
    Public ReadOnly Property ithPassbk(ByVal pN As Integer) As Passbook
        Get
            Return _ithPassbk(pN)
        End Get
    End Property

    'Passbook Feature array accessor
    Public ReadOnly Property ithPassbkFeat(ByVal pN As Integer) As PassbookFeature
        Get
            Return _ithPassbkFeat(pN)
        End Get
    End Property

    'Update Feature array accessor
    Public ReadOnly Property ithUsedFeat(ByVal pN As Integer) As UsedFeature
        Get
            Return _ithUsedFeat(pN)
        End Get
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

    Private ReadOnly Property _CUSTOMER_ARRAY_SIZE_DFLT As Integer
        Get
            Return mCUSTOMER_ARRAY_SIZE_DFLT
        End Get
    End Property

    Private ReadOnly Property _CUSTOMER_ARRAY_INC_DFLT As Integer
        Get
            Return mCUSTOMER_ARRAY_INC_DFLT
        End Get
    End Property

    Private ReadOnly Property _PASSBK_ARRAY_SIZE_DFLT As Integer
        Get
            Return mPASSBK_ARRAY_SIZE_DFLT
        End Get
    End Property

    Private ReadOnly Property _PASSBL_ARRAY_INC_DFLT As Integer
        Get
            Return mPASSBL_ARRAY_INC_DFLT
        End Get
    End Property

    Private ReadOnly Property _FEATURE_ARRAY_SIZE_DFLT As Integer
        Get
            Return mFEATURE_ARRAY_SIZE_DFLT
        End Get
    End Property

    Private ReadOnly Property _FEATURE_ARRAY_INC_DFLT As Integer
        Get
            Return mFEATURE_ARRAY_INC_DFLT
        End Get
    End Property

    Private ReadOnly Property _PASSBKFEATURE_ARRAY_SIZE_DFLT As Integer
        Get
            Return mPASSBKFEATURE_ARRAY_SIZE_DFLT
        End Get
    End Property

    Private ReadOnly Property _PASSBKFEATURE_ARRAY_INC_DFLT As Integer
        Get
            Return mPASSBKFEATURE_ARRAY_INC_DFLT
        End Get
    End Property

    Private ReadOnly Property _USED_FEATURE_ARRAY_SIZE_DFLT As Integer
        Get
            Return mUSED_FEATURE_ARRAY_SIZE_DFLT
        End Get
    End Property

    Private ReadOnly Property _USED_FEATURE_ARRAY_INC_DFLT As Integer
        Get
            Return mUSED_FEATURE_ARRAY_INC_DFLT
        End Get
    End Property

    Private ReadOnly Property _TRANSX_ARRAY_SIZE_DFLT As Integer
        Get
            Return mTRANSX_ARRAY_SIZE_DFLT
        End Get
    End Property

    Private ReadOnly Property _TRANSX_ARRAY_INC_DFLT As Integer
        Get
            Return mTRANSX_ARRAY_INC_DFLT
        End Get
    End Property

    Private Property _custArrayMax As Integer
        Get
            Return mCustArrayMax
        End Get
        Set(value As Integer)
            mCustArrayMax = value
        End Set
    End Property

    Private Property _featureArrayMax As Integer
        Get
            Return mFeatureArrayMax
        End Get
        Set(value As Integer)
            mFeatureArrayMax = value
        End Set
    End Property

    Private Property _passbookArrayMax As Integer
        Get
            Return mPassbookArrayMax
        End Get
        Set(value As Integer)
            mPassbookArrayMax = value
        End Set
    End Property

    Private Property _passbookFeatureArrayMax As Integer
        Get
            Return mPassbookFeatureArrayMax
        End Get
        Set(value As Integer)
            mPassbookFeatureArrayMax = value
        End Set
    End Property

    Private Property _usedFeatureArrayMax As Integer
        Get
            Return mUsedFeatureArrayMax
        End Get
        Set(value As Integer)
            mUsedFeatureArrayMax = value
        End Set
    End Property

    Private Property _tranxArrayMax As Integer
        Get
            Return mTranxArrayMax
        End Get
        Set(value As Integer)
            mTranxArrayMax = value
        End Set
    End Property

    'Customer array accessor
    Private Property _ithCust(ByVal pN As Integer) As Customer
        'Assumes: 0 <= pN < _custArrayMax
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pN >= 0 And pN < _custArrayMax Then
                Return mCustomer(pN)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Customer)
            If pN >= 0 And pN < _custArrayMax Then
                mCustomer(pN) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    'Feature array accessor
    Private Property _ithFeat(ByVal pN As Integer) As Feature
        'Assumes: 0 <= pN < _featureArrayMax
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pN >= 0 And pN < _featureArrayMax Then
                Return mFeature(pN)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Feature)
            If pN >= 0 And pN < _featureArrayMax Then
                mFeature(pN) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    'Passbook array accessor
    Private Property _ithPassbk(ByVal pN As Integer) As Passbook
        'Assumes: 0 <= pN < _featureArrayMax
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pN >= 0 And pN < _passbookArrayMax Then
                Return mPassbook(pN)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Passbook)
            If pN >= 0 And pN < _passbookArrayMax Then
                mPassbook(pN) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    'PassbookFeature array accessor
    Private Property _ithPassbkFeat(ByVal pN As Integer) As PassbookFeature
        'Assumes: 0 <= pN < _passbookFeatureArrayMax
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pN >= 0 And pN < _passbookFeatureArrayMax Then
                Return mPassbookFeature(pN)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As PassbookFeature)
            If pN >= 0 And pN < _passbookFeatureArrayMax Then
                mPassbookFeature(pN) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    'Used feature array accessor
    Private Property _ithUsedFeat(ByVal pN As Integer) As UsedFeature
        'Assumes: 0 <= pN < _usedFeatureArrayMax
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pN >= 0 And pN < _usedFeatureArrayMax Then
                Return mUsedFeature(pN)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As UsedFeature)
            If pN >= 0 And pN < _usedFeatureArrayMax Then
                mUsedFeature(pN) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    'Transaction array accessor
    Private Property _ithTranx(ByVal pN As Integer) As String
        'Assumes: 0 <= pN < _tranxArrayMax
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pN >= 0 And pN < _tranxArrayMax Then
                Return mTransx(pN)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As String)
            If pN >= 0 And pN < _tranxArrayMax Then
                mTransx(pN) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
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
    'findCust() is used to locate a customer by ID from the customer database.  
    'Returns a customer reference if found, otherwise Nothing.
    '****************************************************************************************
    Public Function findCust(ByVal pCustId As String) As Customer
        Dim i As Integer

        Try
            For i = 0 To _numCusts - 1
                If _ithCust(i).custId = pCustId Then
                    Return _ithCust(i)
                End If
            Next i
        Catch ex As Exception
            MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
        End Try

        Return Nothing
    End Function 'findCust(...)

    '****************************************************************************************
    'findFeat() is used to locate a feature by ID from the feature database.  
    'Returns a feature reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findFeat(ByVal pFeatId As String) As Feature
        Dim i As Integer

        Try
            For i = 0 To _numFeats - 1
                If _ithFeat(i).featId = pFeatId Then
                    Return _ithFeat(i)
                End If
            Next i
        Catch ex As Exception
            MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
        End Try

        Return Nothing
    End Function 'findFeat(...)

    '****************************************************************************************
    'findPassbk() is used to locate a Passbook by ID from the passbook database.  
    'Returns a passbook reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findPassbk(ByVal pPassbkId As String) As Passbook
        Dim i As Integer

        Try
            For i = 0 To _numPassbks - 1
                If _ithPassbk(i).passbkId = pPassbkId Then
                    Return _ithPassbk(i)
                End If
            Next i
        Catch ex As Exception
            MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
        End Try

        Return Nothing
    End Function 'findPassbk(...)

    '****************************************************************************************
    'findPassbkFeat() is used to locate a Passbook Feature by ID from the Feature database.  
    'Returns a passbook feature reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findPassbkFeat(ByVal pPassbkFeatId As String) As PassbookFeature
        Dim i As Integer

        Try
            For i = 0 To _numPassbkFeats - 1
                If _ithPassbkFeat(i).id = pPassbkFeatId Then
                    Return _ithPassbkFeat(i)
                End If
            Next i
        Catch ex As Exception
            MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
        End Try

        Return Nothing
    End Function 'findPassbkFeat(...)

    '****************************************************************************************
    'findUsedFeat() is used to locate a Used Feature by ID from the Used Feature database.  
    'Returns a used feature reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findUsedFeat(ByVal pUsedFeatId As String) As UsedFeature
        Dim i As Integer

        Try
            For i = 0 To _numUsedFeats - 1
                If _ithUsedFeat(i).id = pUsedFeatId Then
                    Return _ithUsedFeat(i)
                End If
            Next i
        Catch ex As Exception
            MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
        End Try

        Return Nothing
    End Function 'findUsedFeat(...)

    '****************************************************************************************
    'ToString() overrides the parent object function to return a 
    'string representation of this object.
    '****************************************************************************************
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'ToString()

    '****************************************************************************************
    'createCust() generates a new customer transaction
    '****************************************************************************************
    Public Sub createCust(ByVal pCustId As String, _
                          ByVal pCustName As String
                          )

        'Call the worker procedure to do the work
        _createCust(pCustId,
                    pCustName
                    )
    End Sub 'createCust(...)

    '****************************************************************************************
    'createFeat() generates a new feature transaction
    '****************************************************************************************
    Public Sub createFeat(ByVal pFeatId As String, _
                          ByVal pFeatName As String, _
                          ByVal pUnitOfMeas As String, _
                          ByVal pAdultPrice As Decimal, _
                          ByVal pChildPrice As Decimal
                          )

        'Call the worker procedure to do the work
        _createFeat(pFeatId, _
                    pFeatName, _
                    pUnitOfMeas, _
                    pAdultPrice, _
                    pChildPrice
                    )
    End Sub 'createFeat(...)

    '****************************************************************************************
    'createPassbk() generates a new passbook transaction
    '****************************************************************************************
    Public Sub createPassbk(ByVal pPassbkId As String, _
                            ByVal pOwner As Customer, _
                            ByVal pDatePurch As Date, _
                            ByVal pVisName As String, _
                            ByVal pVisDob As Date, _
                            ByVal pVisAge As Integer, _
                            ByVal pVisIsChild As Boolean
                            )

        'Call the worker procedure to do the work
        _createPassbk(pPassbkId, _
                      pOwner, _
                      pDatePurch, _
                      pVisName, _
                      pVisDob, _
                      pVisAge, _
                      pVisIsChild
                      )
    End Sub 'createPassbk(...)

    '****************************************************************************************
    'addPassbkFeat() generates an add passbook feature transaction
    '****************************************************************************************
    Public Sub addPassbkFeat(ByVal pPassbkFeatId As String, _
                             ByVal pFeature As Feature, _
                             ByVal pPassbk As Passbook, _
                             ByVal pQtyPurch As Decimal
                             )

        'Call the worker procedure to do the work
        _addPassbkFeat(pPassbkFeatId, _
                       pFeature, _
                       pPassbk, _
                       pQtyPurch
                       )
    End Sub 'addPassbkFeat(...)

    '****************************************************************************************
    'updtPassbkFeat() generates an update passbook feature transaction
    '****************************************************************************************
    Public Sub updtPassbkFeat(ByVal pPassbkFeatId As String, _
                              ByVal pQty As Decimal
                              )

        'Call the worker procedure to do the work
        _updtPassbkFeat(pPassbkFeatId,
                        pQty
                        )
    End Sub 'updtPassbkFeat(...)

    '****************************************************************************************
    'usedFeat() generates a used passbook feature transaction
    '****************************************************************************************
    Public Sub usedFeat(ByVal pId As String, _
                        ByVal pPassbkFeatId As PassbookFeature, _
                        ByVal pDateUsed As Date, _
                        ByVal pQtyUsed As Decimal, _
                        ByVal pLoc As String
                        )

        'Call the worker procedure to do the work
        _usedFeat(pId, _
                  pPassbkFeatId, _
                  pDateUsed, _
                  pQtyUsed, _
                  pLoc
                  )
    End Sub 'usedFeat(...)


    '********** Private Non-Shared Behavioral Methods

    '****************************************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String = ""

        tmpStr = "[Theme Park] -> " _
            & " Name=" & _themeParkName _
            & ", #Customers=" & _numCusts _
            & ", #Passbooks=" & _numPassbks _
            & ", #Features=" & _numFeats _
            & ", #PassbookkFeatures=" & _numPassbkFeats _
            & ", #UsedFeaturess=" & _numUsedFeats

        Return tmpStr
    End Function '_toString(...)

    '****************************************************************************************
    '_createCust()
    'This is the work-horse function that creates a new customer
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _createCust(ByVal pCustId As String, _
                            ByVal pCustName As String
                            )
        Dim cust As Customer = New Customer(pCustId,
                                            pCustName
                                            )

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If cust Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'May need to dynamically resize internal customer storage as needed
        If _numCusts >= _custArrayMax Then
            _custArrayMax += _CUSTOMER_ARRAY_INC_DFLT
            ReDim Preserve mCustomer(_custArrayMax - 1)
        End If

        'Attempt to add the customer object to the internal storage and trap
        'any potential exceptions which will be passed up the call stack
        'for processing.
        Try
            _ithCust(_numCusts) = cust
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        'update the customer cnt in the system
        _numCusts += 1

        'Raise and event to let the listeners of this event it happened
        RaiseEvent ThemePark_CreateCust(Me,
                                        New ThemePark_EventArgs_CreateCust(cust))
    End Sub '_createCust(...)

    '****************************************************************************************
    '_createFeat()
    'This is the work-horse function that creates a new feature
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _createFeat(ByVal pFeatId As String, _
                            ByVal pFeatName As String, _
                            ByVal pUnitOfMeas As String, _
                            ByVal pAdultPrice As Decimal, _
                            ByVal pChildPrice As Decimal
                            )

        Dim feat As Feature = New Feature(pFeatId, _
                                          pFeatName, _
                                          pUnitOfMeas, _
                                          pAdultPrice, _
                                          pChildPrice
                                          )

        'Make sure we actually have feature object.  There is the slight chance
        'that the New () could have failed.
        If feat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'May need to dynamically resize internal feature storage as needed
        If _numFeats >= _featureArrayMax Then
            _featureArrayMax += _FEATURE_ARRAY_INC_DFLT
            ReDim Preserve mFeature(_featureArrayMax - 1)
        End If

        'Attempt to add the feature object to the internal storage and trap
        'any potential exceptions which will be passed up the call stack
        'for processing.
        Try
            _ithFeat(_numFeats) = feat
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        'update the feature cnt in the system
        _numFeats += 1

        'Raise and event to let the listeners of this event it happened
        RaiseEvent ThemePark_CreateFeat(Me,
                                        New ThemePark_EventArgs_CreateFeat(feat))
    End Sub '_createFeat(...)

    '****************************************************************************************
    '_createPassbk()
    'This is the work-horse function that creates a new passbook
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _createPassbk(ByVal pPassbkId As String, _
                              ByVal pOwner As Customer, _
                              ByVal pDatePurch As Date, _
                              ByVal pVisName As String, _
                              ByVal pVisDob As Date, _
                              ByVal pVisAge As Integer, _
                              ByVal pVisIsChild As Boolean
                              )

        Dim passbook As Passbook = New Passbook(pPassbkId, _
                                                pOwner, _
                                                pDatePurch, _
                                                pVisName, _
                                                pVisDob, _
                                                pVisAge, _
                                                pVisIsChild
                                                )

        'Make sure we actually have passbook object.  There is the slight chance
        'that the New () could have failed.
        If passbook Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'May need to dynamically resize internal passbook storage as needed
        If _numPassbks >= _passbookArrayMax Then
            _passbookArrayMax += _PASSBL_ARRAY_INC_DFLT
            ReDim Preserve mPassbook(_passbookArrayMax - 1)
        End If

        'Attempt to add the passbook object to the internal storage and trap
        'any potential exceptions which will be passed up the call stack
        'for processing.
        Try
            _ithPassbk(_numPassbks) = passbook
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        'update the passbook cnt in the system
        _numPassbks += 1

        'Raise and event to let the listeners of this event it happened
        RaiseEvent ThemePark_CreatePassbk(Me,
                                          New ThemePark_EventArgs_CreatePassbk(passbook))
    End Sub '_createPassbk(...)

    '****************************************************************************************
    '_addPassbkFeat() 
    'This is the work-horse function that creates a new passbook feature
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _addPassbkFeat(ByVal pPassbkFeatId As String, _
                               ByVal pFeature As Feature, _
                               ByVal pPassbk As Passbook, _
                               ByVal pQtyPurch As Decimal
                               )

        Dim passbkFeat As PassbookFeature = New PassbookFeature(pPassbkFeatId, _
                                                                pFeature, _
                                                                pPassbk, _
                                                                pQtyPurch
                                                                )
        'Make sure we actually have passbook feature object.  There is the slight chance
        'that the New () could have failed.
        If passbkFeat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'May need to dynamically resize internal passbook feature storage as needed
        If _numPassbkFeats >= _passbookFeatureArrayMax Then
            _passbookFeatureArrayMax += _PASSBKFEATURE_ARRAY_INC_DFLT
            ReDim Preserve mPassbookFeature(_passbookFeatureArrayMax - 1)
        End If

        'Attempt to add the passbook feature object to the internal storage and trap
        'any potential exceptions which will be passed up the call stack
        'for processing.
        Try
            _ithPassbkFeat(_numPassbkFeats) = passbkFeat
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        'update the passbook cnt in the system
        _numPassbkFeats += 1

        'Raise and event to let the listeners of this event it happened
        RaiseEvent ThemePark_AddPassbkFeat(Me,
                                           New ThemePark_EventArgs_AddPassbkFeat(passbkFeat))
    End Sub '_addPassbkFeat(...)

    '****************************************************************************************
    '_updtPassbkFeat()
    'This is the work-horse function that updates a passbook feature
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _updtPassbkFeat(ByVal pPassbkFeatId As String, _
                                ByVal pQty As Decimal
                                )

        Dim passbkFeat As PassbookFeature = New PassbookFeature(pPassbkFeatId, _
                                                                Nothing, _
                                                                Nothing, _
                                                                pQty
                                                                )

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If passbkFeat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Raise and event to let the listeners of this event it happened
        RaiseEvent ThemePark_UpdtPassbkFeat(Me,
                                            New ThemePark_EventArgs_UpdtPassbkFeat(passbkFeat))
    End Sub '_updtPassbkFeat(...)


    '****************************************************************************************
    '_usedFeat()
    'This is the work-horse function that posts a used passbook feature
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _usedFeat(ByVal pId As String, _
                          ByVal pPassbkFeatId As PassbookFeature, _
                          ByVal pDateUsed As Date, _
                          ByVal pQtyUsed As Decimal, _
                          ByVal pLoc As String
                          )

        Dim usedFeat As UsedFeature = New UsedFeature(pId, _
                                                      pPassbkFeatId, _
                                                      pQtyUsed, _
                                                      pLoc, _
                                                      pDateUsed
                                                      )

        'Make sure we actually have used feature object.  There is the slight chance
        'that the New () could have failed.
        If usedFeat Is Nothing Then
            MsgBox(mSYS_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'May need to dynamically resize internal passbook feature storage as needed
        If _numUsedFeats >= _usedFeatureArrayMax Then
            _usedFeatureArrayMax += _USED_FEATURE_ARRAY_INC_DFLT
            ReDim Preserve mUsedFeature(_usedFeatureArrayMax - 1)
        End If

        'Attempt to add the passbook feature object to the internal storage and trap
        'any potential exceptions which will be passed up the call stack
        'for processing.
        Try
            _ithUsedFeat(_numUsedFeats) = usedFeat
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        'update the passbook cnt in the system
        _numUsedFeats += 1

        'Raise and event to let the listeners of this event it happened
        RaiseEvent ThemePark_UsedFeat(Me,
                                      New ThemePark_EventArgs_UsedFeat(usedFeat))
    End Sub '_usedFeat(...)


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

    'These are all public.

    'Define the new customer event
    Public Event ThemePark_CreateCust(ByVal sender As Object, _
                                      ByVal e As System.EventArgs
                                      )

    'Define the new feature event
    Public Event ThemePark_CreateFeat(ByVal sender As Object, _
                                      ByVal e As System.EventArgs
                                      )

    'Define the new passbook event
    Public Event ThemePark_CreatePassbk(ByVal sender As Object, _
                                        ByVal e As System.EventArgs
                                        )

    'Define the new purchase passbook feature event
    Public Event ThemePark_AddPassbkFeat(ByVal sender As Object, _
                                         ByVal e As System.EventArgs
                                         )

    'Define the new purchase passbook feature event
    Public Event ThemePark_UpdtPassbkFeat(ByVal sender As Object, _
                                          ByVal e As System.EventArgs
                                          )

    'Define the new purchase passbook feature event
    Public Event ThemePark_UsedFeat(ByVal sender As Object, _
                                    ByVal e As System.EventArgs
                                    )

#End Region 'Events

End Class 'ThemePark