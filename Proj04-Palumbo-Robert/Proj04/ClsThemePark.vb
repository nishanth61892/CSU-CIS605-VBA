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
    Private Const mSYS_OBJ_CREATE_ERR_MSG As String = "Internal System Error: Object Creation Failed"
    Private Const mSYS_LOOKUP_ERR_MSG As String = "Internal System Error: Object Lookup Failed"
    Private Const mSYS_TRANX_CREATE_ERR_MSG As String = "Internal System Error: Transaction Creation Failed"

    'Transaction Record types
    Private Const mTRANSX_CUST_TYPE As String = "CUSTOMER"
    Private Const mTRANSX_FEAT_TYPE As String = "FEATURE"
    Private Const mTRANSX_PASSBK_TYPE As String = "PASSBOOK"
    Private Const mTRANSX_PASSBKFEAT_TYPE As String = "PASSBOOK_FEATURE"
    Private Const mTRANSX_PBF_PURCH_TYPE As String = "PURCHASE"
    Private Const mTRANSX_PBF_USE_TYPE As String = "USE"
    Private Const mTRANSX_PBF_UPDT_TYPE As String = "UPDATE"

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

    'Number of transactions in the system
    Private mNumTransx As Integer

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
    Private mTransxArrayMax As Integer

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
        _numTransx = 0

        'Initialize array attributes
        _custArrayMax = _CUSTOMER_ARRAY_SIZE_DFLT
        _featureArrayMax = _FEATURE_ARRAY_SIZE_DFLT
        _passbookArrayMax = _PASSBK_ARRAY_SIZE_DFLT
        _passbookFeatureArrayMax = _PASSBKFEATURE_ARRAY_SIZE_DFLT
        _usedFeatureArrayMax = _USED_FEATURE_ARRAY_SIZE_DFLT
        _transxArrayMax = _TRANSX_ARRAY_SIZE_DFLT

        'Array to hold passbooks
        ReDim Preserve mCustomer(_custArrayMax - 1)
        ReDim Preserve mFeature(_featureArrayMax - 1)
        ReDim Preserve mPassbook(_passbookArrayMax - 1)
        ReDim Preserve mPassbookFeature(_passbookArrayMax - 1)
        ReDim Preserve mUsedFeature(_usedFeatureArrayMax - 1)
        ReDim Preserve mTransx(_transxArrayMax - 1)
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

    Public Property numTransx() As Integer
        Get
            Return _numTransx
        End Get
        Set(pValue As Integer)
            _numTransx = pValue
        End Set
    End Property

    Public ReadOnly Property transxCustType() As String
        Get
            Return _transxCustType
        End Get
    End Property

    Public ReadOnly Property transxFeatType() As String
        Get
            Return _transxFeatType
        End Get
    End Property

    Public ReadOnly Property transxPassbkType() As String
        Get
            Return _transxPassbkType
        End Get
    End Property

    Public ReadOnly Property transxPassbkFeatType() As String
        Get
            Return _transxPassbkFeatType
        End Get
    End Property

    Public ReadOnly Property transxPbfPurchType() As String
        Get
            Return _transxPbfPurchType
        End Get
    End Property

    Public ReadOnly Property transxPbfUseType() As String
        Get
            Return _transxPbfUseType
        End Get
    End Property

    Public ReadOnly Property transxPbfUpdtType() As String
        Get
            Return _transxPbfUpdtType
        End Get
    End Property

    'Customer data store iterator 
    Public Iterator Function iterateCust() As IEnumerable(Of Object)
        Dim cust As Customer

        For Each cust In _iterateCust()
            Yield cust
        Next cust
    End Function 'iterateCust()

    'Feature data store iterator 
    Public Iterator Function iterateFeat() As IEnumerable(Of Object)
        Dim feat As Feature

        For Each feat In _iterateFeat()
            Yield feat
        Next feat
    End Function 'iterateFeat()

    'Passbook data store iterator 
    Public Iterator Function iteratePassbk() As IEnumerable(Of Object)
        Dim passbk As Passbook

        For Each passbk In _iteratePassbk()
            Yield passbk
        Next passbk
    End Function 'iteratePassbk()

    'Passbook Feature data store iterator 
    Public Iterator Function iteratePassbkFeat() As IEnumerable(Of Object)
        Dim passbkFeat As PassbookFeature

        For Each passbkFeat In _iteratePassbkFeat()
            Yield passbkFeat
        Next passbkFeat
    End Function 'iteratePassbkFeat()

    'Used Feature data store iterator 
    Public Iterator Function iterateUsedFeat() As IEnumerable(Of Object)
        Dim usedFeat As UsedFeature

        For Each usedFeat In _iterateUsedFeat()
            Yield usedFeat
        Next usedFeat
    End Function 'iterateUsedFeat()

    'Transx data store iterator 
    Public Iterator Function iterateTransx() As IEnumerable(Of Object)
        Dim transx As String

        For Each transx In _iterateTransx()
            Yield transx
        Next transx
    End Function 'iterateTransx()


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

    Private Property _numTransx() As Integer
        Get
            Return mNumTransx
        End Get
        Set(pValue As Integer)
            mNumTransx = pValue
        End Set
    End Property

    Private ReadOnly Property _transxCustType() As String
        Get
            Return mTRANSX_CUST_TYPE
        End Get
    End Property

    Private ReadOnly Property _transxFeatType() As String
        Get
            Return mTRANSX_FEAT_TYPE
        End Get
    End Property

    Private ReadOnly Property _transxPassbkType() As String
        Get
            Return mTRANSX_PASSBK_TYPE
        End Get
    End Property

    Private ReadOnly Property _transxPbfPurchType() As String
        Get
            Return mTRANSX_PBF_PURCH_TYPE
        End Get
    End Property

    Private ReadOnly Property _transxPbfUseType() As String
        Get
            Return mTRANSX_PBF_USE_TYPE
        End Get
    End Property

    Private ReadOnly Property _transxPbfUpdtType() As String
        Get
            Return mTRANSX_PBF_UPDT_TYPE
        End Get
    End Property

    Private ReadOnly Property _transxPassbkFeatType() As String
        Get
            Return mTRANSX_PASSBKFEAT_TYPE
        End Get
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

    Private Property _transxArrayMax As Integer
        Get
            Return mTransxArrayMax
        End Get
        Set(value As Integer)
            mTransxArrayMax = value
        End Set
    End Property


    'Customer array iterator 
    Private Iterator Function _iterateCust() As IEnumerable(Of Object)
        Dim i As Integer

        For i = 0 To _numCusts - 1
            Yield _ithCust(i)
        Next i
    End Function '_iterateCust()

    'Feature array iterator 
    Private Iterator Function _iterateFeat() As IEnumerable(Of Object)
        Dim i As Integer

        For i = 0 To _numFeats - 1
            Yield _ithFeat(i)
        Next i
    End Function '_iterateFeat()

    'Passbook array iterator 
    Private Iterator Function _iteratePassbk() As IEnumerable(Of Object)
        Dim i As Integer

        For i = 0 To _numPassbks - 1
            Yield _ithPassbk(i)
        Next i
    End Function '_iteratePassbk()

    'Passbook Feature array iterator 
    Private Iterator Function _iteratePassbkFeat() As IEnumerable(Of Object)
        Dim i As Integer

        For i = 0 To _numPassbkFeats - 1
            Yield _ithPassbkFeat(i)
        Next i
    End Function '_iteratePassbkFeat()

    'Used Feature array iterator 
    Private Iterator Function _iterateUsedFeat() As IEnumerable(Of Object)
        Dim i As Integer

        For i = 0 To _numUsedFeats - 1
            Yield _ithUsedFeat(i)
        Next i
    End Function '_iterateUsedFeat()

    'Transx array iterator 
    Private Iterator Function _iterateTransx() As IEnumerable(Of Object)
        Dim i As Integer

        For i = 0 To _numTransx - 1
            Yield _ithTransx(i)
        Next i
    End Function '_iterateTransx()


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
    Private Property _ithTransx(ByVal pN As Integer) As String
        'Assumes: 0 <= pN < _tranxArrayMax
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pN >= 0 And pN < _transxArrayMax Then
                Return mTransx(pN)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As String)
            If pN >= 0 And pN < _transxArrayMax Then
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
    'writeTranxRec() is used to format a transaction record and store it in the tranx rec
    'database.
    '****************************************************************************************
    Public Sub writeTranxRec(ByVal pType As String,
                             ByVal pSubType As String,
                             ByVal pObj As Object)
        _writeTranxRec(pType, pSubType, pObj)
    End Sub 'writeTranxRec(...)

    '****************************************************************************************
    'findCust() is used to locate a customer by ID from the customer database.  
    'Returns a customer reference if found, otherwise Nothing.
    '****************************************************************************************
    Public Function findCust(ByVal pCustId As String) As Customer
        Return _findCust(pCustId)
    End Function 'findCust(...)

    '****************************************************************************************
    'findFeat() is used to locate a feature by ID from the feature database.  
    'Returns a feature reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findFeat(ByVal pFeatId As String) As Feature
        Return _findFeat(pFeatId)
    End Function 'findFeat(...)

    '****************************************************************************************
    'findPassbk() is used to locate a Passbook by ID from the passbook database.  
    'Returns a passbook reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findPassbk(ByVal pPassbkId As String) As Passbook
        Return _findPassbk(pPassbkId)
    End Function 'findPassbk(...)

    '****************************************************************************************
    'findPassbkFeat() is used to locate a Passbook Feature by ID from the Feature database.  
    'Returns a passbook feature reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findPassbkFeat(ByVal pPassbkFeatId As String) As PassbookFeature
        Return _findPassbkFeat(pPassbkFeatId)
    End Function 'findPassbkFeat(...)

    '****************************************************************************************
    'findUsedFeat() is used to locate a Used Feature by ID from the Used Feature database.  
    'Returns a used feature reference if found, otherwise Nothing
    '****************************************************************************************
    Public Function findUsedFeat(ByVal pUsedFeatId As String) As UsedFeature
        Return _findUsedFeat(pUsedFeatId)
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
    'purchPassbkFeat() generates a purchase passbook feature transaction
    '****************************************************************************************
    Public Sub purchPassbkFeat(ByVal pPassbkFeatId As String, _
                               ByVal pFeature As Feature, _
                               ByVal pPassbk As Passbook, _
                               ByVal pQtyPurch As Decimal
                               )

        'Call the worker procedure to do the work
        _purchPassbkFeat(pPassbkFeatId, _
                         pFeature, _
                         pPassbk, _
                         pQtyPurch
                         )
    End Sub 'purchPassbkFeat(...)

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
    '_writeTranxRec() is used to format a transaction record and store it in the tranx rec
    'database.
    'It is the workhorse method called by writeTranxRec().
    '****************************************************************************************
    Private Sub _writeTranxRec(ByVal pType As String,
                               ByVal pSubType As String,
                               ByVal pObj As Object)
        Dim now As Date = now
        Dim tStr As String = ""

        'Depending on the tranx type pObj will be cast approriately to extract the 
        'specific details of this transaction to be written out
        Select Case pType
            Case _transxCustType
                Dim cust As Customer = CType(pObj, Customer)
                Console.WriteLine("WriteTranxRec: " & cust.ToString)

            Case _transxFeatType
                Dim feat As Feature = CType(pObj, Feature)
                Console.WriteLine("WriteTranxRec: " & feat.ToString)

            Case _transxPassbkType
                Dim passBk As Passbook = CType(pObj, Passbook)
                Console.WriteLine("WriteTranxRec: " & passBk.ToString)

            Case _transxPassbkFeatType
                Select Case pSubType
                    Case _transxPbfPurchType
                        Dim passbkFeat As PassbookFeature = CType(pObj, PassbookFeature)
                        Console.WriteLine("WriteTranxRecPurch: " & passbkFeat.ToString)

                    Case _transxPbfUpdtType
                        Dim passbkFeat As PassbookFeature = CType(pObj, PassbookFeature)
                        Console.WriteLine("WriteTranxRecUpdt: " & passbkFeat.ToString)

                    Case _transxPbfUseType
                        Dim usedFeat As UsedFeature = CType(pObj, UsedFeature)
                        Console.WriteLine("WriteTranxRecUse: " & usedFeat.ToString)
                End Select
            Case Else
                MsgBox(mSYS_TRANX_CREATE_ERR_MSG, MsgBoxStyle.Exclamation)
        End Select
    End Sub '_writeTranxRec(...)

    '****************************************************************************************
    '_findCust() is used to locate a customer by ID from the customer database. 
    'It is the workhorse function called by findCust().
    'Returns a customer reference if found, otherwise Nothing.
    '****************************************************************************************
    Private Function _findCust(ByVal pCustId As String) As Customer
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
    End Function '_findCust(...)

    '****************************************************************************************
    'findFeat() is used to locate a feature by ID from the feature database.  
    'It is the workhorse function called by findFeat().
    'Returns a feature reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findFeat(ByVal pFeatId As String) As Feature
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
    End Function '_findFeat(...)

    '****************************************************************************************
    'findPassbk() is used to locate a Passbook by ID from the passbook database.  
    'It is the workhorse function called by findPassbk().
    'Returns a passbook reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findPassbk(ByVal pPassbkId As String) As Passbook
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
    End Function '_findPassbk(...)

    '****************************************************************************************
    '_findPassbkFeat() is used to locate a Passbook Feature by ID from the Feature database.  
    'It is the workhorse function called by findPassbkFeat().
    'Returns a passbook feature reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findPassbkFeat(ByVal pPassbkFeatId As String) As PassbookFeature
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
    End Function '_findPassbkFeat(...)

    '****************************************************************************************
    '_findUsedFeat() is used to locate a Used Feature by ID from the Used Feature database.  
    'It is the workhorse function called by findUsedFeat().
    'Returns a used feature reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findUsedFeat(ByVal pUsedFeatId As String) As UsedFeature
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
    End Function '_findUsedFeat(...)


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
            MsgBox(mSYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
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

        'Trap duplicates here and don't create - this can happen from system test data
        If Not _findFeat(pFeatId) Is Nothing Then
            Dim logMsg As String = "ERROR: Attempt to create duplicate feature, Id=" & pFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim feat As Feature = New Feature(pFeatId, _
                                          pFeatName, _
                                          pUnitOfMeas, _
                                          pAdultPrice, _
                                          pChildPrice
                                          )

        'Make sure we actually have feature object.  There is the slight chance
        'that the New () could have failed.
        If feat Is Nothing Then
            MsgBox(mSYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
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
            MsgBox(mSYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
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
    '_createPassbkFeat() 
    'This is the work-horse function that creates a new passbook feature purchase
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _purchPassbkFeat(ByVal pPassbkFeatId As String, _
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
            MsgBox(mSYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
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
        RaiseEvent ThemePark_PurchPassbkFeat(Me,
                                             New ThemePark_EventArgs_PurchPassbkFeat(passbkFeat))
    End Sub '_createPassbkFeat(...)

    '****************************************************************************************
    '_updtPassbkFeat()
    'This is the work-horse function that updates a passbook feature
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _updtPassbkFeat(ByVal pPassbkFeatId As String, _
                                ByVal pQty As Decimal
                                )

        Dim passbkFeat As PassbookFeature = _findPassbkFeat(pPassbkFeatId)

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If passbkFeat Is Nothing Then
            MsgBox(mSYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Update the quantity purchased
        passbkFeat.qtyPurch = pQty
        passbkFeat.qtyRemain = pQty

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
            MsgBox(mSYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
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
    Public Event ThemePark_PurchPassbkFeat(ByVal sender As Object, _
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

    'Define the log transaction msg event
    Public Event ThemePark_LogTran(ByVal sender As Object, _
                                    ByVal e As System.EventArgs
                                    )

#End Region 'Events

End Class 'ThemePark