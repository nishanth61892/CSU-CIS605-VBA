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
    Private Const mSYS_ERR_OBJ_CREATE_MSG As String = _
        "Error: Object Creation Failed"
    Private Const mSYS_ERR_OBJ_LOOKUP_MSG As String = _
        "Error: Object Lookup Failed"
    Private Const mSYS_ERR_TRANX_CREATE_MSG As String = _
        "Error: Transaction Creation Failed"
    Private Const mSYS_ERR_DATASTORE_ACCESS_MSG As String = _
        "Error: Internal data store access error"

    'Transaction Record types
    Private Const mTRANSX_OBJECT_TYPE As String = "OBJECT"
    Private Const mTRANSX_CUST_TYPE As String = "CUSTOMER"
    Private Const mTRANSX_FEAT_TYPE As String = "FEATURE"
    Private Const mTRANSX_PASSBK_TYPE As String = "PASSBOOK"
    Private Const mTRANSX_PASSBKFEAT_TYPE As String = "PASSBOOK_FEATURE"
    Private Const mTRANSX_ACTION_CREATE As String = "CREATE"
    Private Const mTRANSX_ACTION_PURCH As String = "PURCHASE"
    Private Const mTRANSX_ACTION_USE As String = "USE"
    Private Const mTRANSX_ACTION_UPDATE As String = "UPDATE"

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

    'Key performance indicator object used to calculate KPIs for the system
    Private kpi As KeyPerfInd

    'FileIO object to import/export of data
    Private fileIO As FileIO

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

        'Key performance indicator object
        kpi = New KeyPerfInd(Me)

        'Key performance indicator object
        fileIO = New FileIO(Me)

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

    Public ReadOnly Property sysObjCreateErr() As String
        Get
            Return _SYS_OBJ_CREATE_ERR_MSG
        End Get
    End Property

    Public ReadOnly Property sysObjLookupErr() As String
        Get
            Return _SYS_LOOKUP_ERR_MSG
        End Get
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

    Public ReadOnly Property TRANSX_OBJECT_TYPE As String
        Get
            Return _TRANSX_OBJECT_TYPE
        End Get
    End Property

    Public ReadOnly Property TRANSX_CUST_TYPE As String
        Get
            Return _TRANSX_CUST_TYPE
        End Get
    End Property

    Public ReadOnly Property TRANSX_FEAT_TYPE As String
        Get
            Return _TRANSX_FEAT_TYPE
        End Get
    End Property

    Public ReadOnly Property TRANSX_PASSBK_TYPE As String
        Get
            Return _TRANSX_PASSBK_TYPE
        End Get
    End Property

    Public ReadOnly Property TRANSX_PASSBKFEAT_TYPE As String
        Get
            Return _TRANSX_PASSBKFEAT_TYPE
        End Get
    End Property

    Public ReadOnly Property TRANSX_ACTION_CREATE As String
        Get
            Return _TRANSX_ACTION_CREATE
        End Get
    End Property

    Public ReadOnly Property TRANSX_ACTION_PURCH As String
        Get
            Return _TRANSX_ACTION_PURCH
        End Get
    End Property

    Public ReadOnly Property TRANSX_ACTION_USE As String
        Get
            Return _TRANSX_ACTION_USE
        End Get
    End Property

    Public ReadOnly Property TRANSX_ACTION_UPDATE As String
        Get
            Return _TRANSX_ACTION_UPDATE
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
    Private Property _themeParkName As String
        Get
            Return mThemeParkName
        End Get
        Set(pValue As String)
            mThemeParkName = pValue
        End Set
    End Property

    Private ReadOnly Property _SYS_OBJ_CREATE_ERR_MSG As String
        Get
            Return mSYS_ERR_OBJ_CREATE_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_LOOKUP_ERR_MSG As String
        Get
            Return mSYS_ERR_OBJ_LOOKUP_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_ERR_DATASTORE_ACCESS_MSG As String
        Get
            Return mSYS_ERR_DATASTORE_ACCESS_MSG
        End Get
    End Property

    Private ReadOnly Property _SYS_TRANX_CREATE_ERR_MSG As String
        Get
            Return mSYS_ERR_TRANX_CREATE_MSG
        End Get
    End Property

    Private Property _numCusts As Integer
        Get
            Return mNumCusts
        End Get
        Set(pValue As Integer)
            mNumCusts = pValue
        End Set
    End Property

    Private Property _numPassbks As Integer
        Get
            Return mNumPassbks
        End Get
        Set(pValue As Integer)
            mNumPassbks = pValue
        End Set
    End Property

    Private Property _numFeats As Integer
        Get
            Return mNumFeats
        End Get
        Set(pValue As Integer)
            mNumFeats = pValue
        End Set
    End Property

    Private Property _numPassbkFeats As Integer
        Get
            Return mNumPassbkFeats
        End Get
        Set(pValue As Integer)
            mNumPassbkFeats = pValue
        End Set
    End Property

    Private Property _numUsedFeats As Integer
        Get
            Return mNumUsedFeats
        End Get
        Set(pValue As Integer)
            mNumUsedFeats = pValue
        End Set
    End Property

    Private Property _numTransx As Integer
        Get
            Return mNumTransx
        End Get
        Set(pValue As Integer)
            mNumTransx = pValue
        End Set
    End Property

    Private ReadOnly Property _TRANSX_OBJECT_TYPE As String
        Get
            Return mTRANSX_OBJECT_TYPE
        End Get
    End Property

    Private ReadOnly Property _TRANSX_CUST_TYPE As String
        Get
            Return mTRANSX_CUST_TYPE
        End Get
    End Property

    Private ReadOnly Property _TRANSX_FEAT_TYPE As String
        Get
            Return mTRANSX_FEAT_TYPE
        End Get
    End Property

    Private ReadOnly Property _TRANSX_PASSBK_TYPE As String
        Get
            Return mTRANSX_PASSBK_TYPE
        End Get
    End Property

    Private ReadOnly Property _TRANSX_PASSBKFEAT_TYPE As String
        Get
            Return mTRANSX_PASSBKFEAT_TYPE
        End Get
    End Property

    Private ReadOnly Property _TRANSX_ACTION_CREATE As String
        Get
            Return mTRANSX_ACTION_CREATE
        End Get
    End Property

    Private ReadOnly Property _TRANSX_ACTION_PURCH As String
        Get
            Return mTRANSX_ACTION_PURCH
        End Get
    End Property

    Private ReadOnly Property _TRANSX_ACTION_USE As String
        Get
            Return mTRANSX_ACTION_USE
        End Get
    End Property

    Private ReadOnly Property _TRANSX_ACTION_UPDATE As String
        Get
            Return mTRANSX_ACTION_UPDATE
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

    'importData() imports data records from the transactions-in.txt
    'data file.  It is used to populate the system with a predefined  
    'data set and is invoked from the 'Process Test Data' button on
    'the System Test tab.
    Public Sub importData(ByVal pInpFileName As String,
                          ByVal pErrFileName As String)
        fileIO.importData(pInpFileName, pErrFileName)
    End Sub 'importData()

    '_importData() exports data records from the transactions array
    'to the output data file transactions-out.txt.  It is invoked 
    'from the 'Process Test Data' button on the System Test tab.
    Public Sub exportData(ByVal pFileName As String,
                                 ByVal pAppend As Boolean)
        fileIO.exportData(pFileName, pAppend)
    End Sub 'exportData()


    '****************************************************************************************
    'writeTransxRec() is used to format a transaction record and store it in the tranx rec
    'database.
    '****************************************************************************************
    Public Sub writeTransxRec(ByVal pType As String,
                              ByVal pSubType As String,
                              ByVal pObj As Object)
        _writeTransxRec(pType, pSubType, pObj)
    End Sub 'writeTransxRec(...)

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

    '****************************************************************************************
    'calcAvgBalUnusedFeat()
    '   - calculates the avg unused feature balance
    '****************************************************************************************
    Public Function calcAvgBalUnusedFeat() As Decimal
        Return kpi.calcAvgBalUnusedFeat()
    End Function 'calcAvgBalUnusedFeat()

    '****************************************************************************************
    'calcTotBalUnusedFeat()
    '   - function that calculates the total unused feature balance
    '****************************************************************************************
    Public Function calcTotBalUnusedFeat() As Decimal
        Return kpi.calcTotBalUnusedFeat()
    End Function 'calcTotBalUnusedFeat()

    '****************************************************************************************
    'calcAvgPassbkPerCust()
    '   - function that calculates the total unused feature balance
    '****************************************************************************************
    Public Function calcAvgPassbkPerCust() As Decimal
        Return kpi.calcAvgPassbkPerCust()
    End Function 'calcAvgPassbkPerCust()

    '****************************************************************************************
    'calcMostPopFeat()
    '   - function that calculates the most popular purchase feature
    '****************************************************************************************
    Public Function calcMostPopFeat() As String
        Return kpi.calcMostPopFeat()
    End Function 'calcMostPopFeat()

    '****************************************************************************************
    'calcPctPassbkFeatUsed()
    '   - Percent of passbook features used (used / total)
    '****************************************************************************************
    Public Function calcPctPassbkFeatUsed() As Decimal
        Return kpi.calcPctPassbkFeatUsed()
    End Function 'calcPctPassbkFeatUsed()

    '****************************************************************************************
    'calcAvgPassbkHolderAge()
    '   - Average age of all passbook holders
    '****************************************************************************************
    Public Function calcAvgPassbkHolderAge() As Decimal
        Return kpi.calcAvgPassbkHolderAge()
    End Function 'calcAvgPassbkHolderAge()

    '****************************************************************************************
    'calcNumPassbkHolderBdaysInCurrMon()
    '   - Average age of all passbook holders
    '****************************************************************************************
    Public Function calcNumPassbkHolderBdaysInCurrMon() As Integer
        Return kpi.calcNumPassbkHolderBdaysInCurrMon()
    End Function 'calcNumPassbkHolderBdaysInCurrMon()

    '****************************************************************************************
    '_postTransx() is used to post the specified transaction to the transaction data 
    ' store.
    '****************************************************************************************
    Private Sub _postTransx(ByVal obj As Object)

        If _numTransx >= _transxArrayMax Then
            _transxArrayMax += _TRANSX_ARRAY_INC_DFLT
            ReDim Preserve mTransx(_passbookArrayMax - 1)
        End If

        Try
            _ithTransx(_numTransx) = obj.ToString
            _numTransx += 1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub '_postTransx(...)

    '****************************************************************************************
    '_writeTranxRec() is used to format a transaction record and store it in the tranx rec
    'database.  It is the workhorse method called by writeTranxRec().
    '****************************************************************************************
    Private Sub _writeTransxRec(ByVal pType As String,
                                ByVal pSubType As String,
                                ByVal pObj As Object)
        Dim now As Date = now
        Dim tStr As String = ""

        'Depending on the tranx type pObj will be cast approriately to extract the 
        'specific details of this transaction to be written out
        Select Case pType
            Case _TRANSX_OBJECT_TYPE
                Dim obj As String = CType(pObj, String)
                _postTransx(obj)

                Console.WriteLine("WriteTranxRec: " & obj.ToString)

            Case _TRANSX_CUST_TYPE
                Dim cust As Customer = CType(pObj, Customer)
                Console.WriteLine("WriteTranxRec: " & cust.ToString)

            Case _TRANSX_FEAT_TYPE
                Dim feat As Feature = CType(pObj, Feature)
                Console.WriteLine("WriteTranxRec: " & feat.ToString)

            Case _TRANSX_PASSBK_TYPE
                Dim passBk As Passbook = CType(pObj, Passbook)
                Console.WriteLine("WriteTranxRec: " & passBk.ToString)

            Case _TRANSX_PASSBKFEAT_TYPE
                Select Case pSubType
                    Case _TRANSX_ACTION_PURCH
                        Dim passbkFeat As PassbookFeature = CType(pObj, PassbookFeature)
                        Console.WriteLine("WriteTranxRecPurch: " & passbkFeat.ToString)

                    Case _TRANSX_ACTION_UPDATE
                        Dim passbkFeat As PassbookFeature = CType(pObj, PassbookFeature)
                        Console.WriteLine("WriteTranxRecUpdt: " & passbkFeat.ToString)

                    Case _TRANSX_ACTION_USE
                        Dim usedFeat As UsedFeature = CType(pObj, UsedFeature)
                        Console.WriteLine("WriteTranxRecUse: " & usedFeat.ToString)
                End Select
            Case Else
                MsgBox(mSYS_ERR_TRANX_CREATE_MSG, MsgBoxStyle.Exclamation)
        End Select
    End Sub '_writeTranxRec(...)

    '****************************************************************************************
    '_findCust() is used to locate a customer by ID from the customer database. 
    'It is the workhorse function called by findCust().
    'Returns a customer reference if found, otherwise Nothing.
    '****************************************************************************************
    Private Function _findCust(ByVal pCustId As String) As Customer
        Dim i As Integer

        If Not IsNothing(pCustId) Then
            Try
                For i = 0 To _numCusts - 1
                    If _ithCust(i).custId.ToUpper = pCustId.ToUpper Then
                        Return _ithCust(i)
                    End If
                Next i
            Catch ex As Exception
                'XRLP - MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
                Throw New IndexOutOfRangeException
                Exit Function
            End Try
        End If

        Return Nothing
    End Function '_findCust(...)

    '****************************************************************************************
    '_findFeat() is used to locate a feature by ID from the feature database.  
    'It is the workhorse function called by findFeat().
    'Returns a feature reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findFeat(ByVal pFeatId As String) As Feature
        Dim i As Integer

        If Not IsNothing(pFeatId) Then
            Try
                For i = 0 To _numFeats - 1
                    If _ithFeat(i).featId.ToUpper = pFeatId.ToUpper Then
                        Return _ithFeat(i)
                    End If
                Next i
            Catch ex As Exception
                'XRLP - MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
                Throw New IndexOutOfRangeException
                Exit Function
            End Try
        End If

        Return Nothing
    End Function '_findFeat(...)

    '****************************************************************************************
    'findPassbk() is used to locate a Passbook by ID from the passbook database.  
    'It is the workhorse function called by findPassbk().
    'Returns a passbook reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findPassbk(ByVal pPassbkId As String) As Passbook
        Dim i As Integer

        If Not IsNothing(pPassbkId) Then
            Try
                For i = 0 To _numPassbks - 1
                    If _ithPassbk(i).passbkId.ToUpper = pPassbkId.ToUpper Then
                        Return _ithPassbk(i)
                    End If
                Next i
            Catch ex As Exception
                'XRLP - MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
                Throw New IndexOutOfRangeException
                Exit Function
            End Try
        End If

        Return Nothing
    End Function '_findPassbk(...)

    '****************************************************************************************
    '_findPassbkFeat() is used to locate a Passbook Feature by ID from the Feature database.  
    'It is the workhorse function called by findPassbkFeat().
    'Returns a passbook feature reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findPassbkFeat(ByVal pPassbkFeatId As String) As PassbookFeature
        Dim i As Integer

        If Not IsNothing(pPassbkFeatId) Then
            Try
                For i = 0 To _numPassbkFeats - 1
                    If _ithPassbkFeat(i).id.ToUpper = pPassbkFeatId.ToUpper Then
                        Return _ithPassbkFeat(i)
                    End If
                Next i
            Catch ex As Exception
                'XRLP - MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
                Throw New IndexOutOfRangeException
                Exit Function
            End Try
        End If

        Return Nothing
    End Function '_findPassbkFeat(...)

    '****************************************************************************************
    '_findUsedFeat() is used to locate a Used Feature by ID from the Used Feature database.  
    'It is the workhorse function called by findUsedFeat().
    'Returns a used feature reference if found, otherwise Nothing
    '****************************************************************************************
    Private Function _findUsedFeat(ByVal pUsedFeatId As String) As UsedFeature
        Dim i As Integer

        If Not IsNothing(pUsedFeatId) Then
            Try
                For i = 0 To _numUsedFeats - 1
                    If _ithUsedFeat(i).id.ToUpper = pUsedFeatId.ToUpper Then
                        Return _ithUsedFeat(i)
                    End If
                Next i
            Catch ex As Exception
                ''XRLP - MsgBox(mSYS_LOOKUP_ERR_MSG, MsgBoxStyle.Exclamation)
                Throw New IndexOutOfRangeException
                Exit Function
            End Try
        End If

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
                            ByVal pCustName As String)
        'Trap duplicates here and don't create - this can happen from system test data
        If String.IsNullOrEmpty(pCustId) Then
            Dim logMsg As String = "[InputDataError]: Customer ID not specified"

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim cust As Customer
        Try
            cust = _findCust(pCustId)
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        If Not IsNothing(cust) Then
            Dim logMsg As String = "[InputDataError]: Attempt to create duplicate Customer, ID=" & pCustId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If String.IsNullOrEmpty(pCustName) Then
            Dim logMsg As String = "[InputDataError]: Customer Name not specified, ID=" & pCustId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        cust = New Customer(pCustId,
                            pCustName)

        'Make sure we actually have customer object.  There is the slight chance
        'that the New () could have failed.
        If cust Is Nothing Then
            MsgBox(mSYS_ERR_OBJ_CREATE_MSG, MsgBoxStyle.Critical)
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
                            ByVal pChildPrice As Decimal)
        'Trap duplicates here and don't create - this can happen from system test data
        If String.IsNullOrEmpty(pFeatId) Then
            Dim logMsg As String = "[InputDataError]: Feature ID not specified"

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim feat As Feature
        Try
            feat = _findFeat(pFeatId)
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        If Not IsNothing(feat) Then
            Dim logMsg As String = "[InputDataError]: Attempt to create duplicate Feature, ID=" & pFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If String.IsNullOrEmpty(pFeatName) Then
            Dim logMsg As String = "[InputDataError]: Feature Name not specified, ID=" & pFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If String.IsNullOrEmpty(pUnitOfMeas) Then
            Dim logMsg As String = "[InputDataError]: Unit of Measure not specified, ID=" & pFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If pAdultPrice <= 0 Then
            Dim logMsg As String = "[InputDataError]: Invalid Adult Price, ID=" & pFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If pChildPrice < 0 Then
            Dim logMsg As String = "[InputDataError]: Invalid Child Price, ID=" & pFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        feat = New Feature(pFeatId, _
                           pFeatName, _
                           pUnitOfMeas, _
                           pAdultPrice, _
                           pChildPrice)

        'Make sure we actually have feature object.  There is the slight chance
        'that the New () could have failed.
        If feat Is Nothing Then
            MsgBox(mSYS_ERR_OBJ_CREATE_MSG, MsgBoxStyle.Critical)
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
                              ByVal pVisIsChild As Boolean)
        'Trap duplicates here and don't create - this can happen from system test data
        If String.IsNullOrEmpty(pPassbkId) Then
            Dim logMsg As String = "[InputDataError]: Passbook ID not specified"

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim passbk As Passbook
        Try
            passbk = _findPassbk(pPassbkId)
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        If Not IsNothing(passbk) Then
            Dim logMsg As String = "[InputDataError]: Attempt to create duplicate Passbook, ID=" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        'Because data can be input into the system in several ways we
        'have to check that the passbook feature specified is already
        'in the system.  If so that feature has to be used
        If IsNothing(pOwner) Then
            Dim logMsg As String = "[InputDataError]: No Passbook Owner specified, ID=" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If String.IsNullOrEmpty(pVisName) Then
            Dim logMsg As String = "[InputDataError]: Passbook Visitor Name not specified" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If IsNothing(pVisDob) Then
            Dim logMsg As String = "[InputDataError]: Passbook Visitor-DOB not specified" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        'Verify DOB not in future
        If Date.Compare(pVisDob, Now) > 0 Then
            Dim logMsg As String = "[InputDataError]: Passbook Visitor-DOB cannot be in the future" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        If IsNothing(pDatePurch) Then
            Dim logMsg As String = "[InputDataError]: Passbook Date Purchased not specified" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        'Verify Purchase date not in future
        If Date.Compare(pDatePurch, Now) > 0 Then
            Dim logMsg As String = "[InputDataError]: Passbook Date Purchase cannot be in the future" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        'Verify validate DOB not in future
        'The price to use is based on DOB compared with the current date
        Dim visAge As Integer = Utils.calcAge(pVisDob)
        If visAge <> pVisAge Then
            Dim logMsg As String = "[InputDataError]: Passbook Visitor Age is incorrect for DOB" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim visIsChild As Boolean = Utils.isAdult(visAge)
        If visIsChild <> pVisIsChild Then
            Dim logMsg As String = "[InputDataError]: Passbook Visitor isChild flag" & pPassbkId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim passbook As Passbook = New Passbook(pPassbkId, _
                                                pOwner, _
                                                pDatePurch, _
                                                pVisName, _
                                                pVisDob, _
                                                pVisAge, _
                                                pVisIsChild)

        'Make sure we actually have passbook object.  There is the slight chance
        'that the New () could have failed.
        If passbook Is Nothing Then
            MsgBox(mSYS_ERR_OBJ_CREATE_MSG, MsgBoxStyle.Critical)
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
    '_purchPassbkFeat() 
    'This is the work-horse function that creates a new passbook feature purchase
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _purchPassbkFeat(ByVal pPassbkFeatId As String, _
                                 ByVal pFeature As Feature, _
                                 ByVal pPassbk As Passbook, _
                                 ByVal pQtyPurch As Decimal)
        'Trap duplicates here and don't create - this can happen from system test data
        If String.IsNullOrEmpty(pPassbkFeatId) Then
            Dim logMsg As String = "[InputDataError]: Passbook Feature ID not specified"

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim passbkFeat As PassbookFeature
        Try
            passbkFeat = _findPassbkFeat(pPassbkFeatId)
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        If Not IsNothing(passbkFeat) Then
            Dim logMsg As String = "[InputDataError]: Attempt to create duplicate Passbook Feature, ID=" & pPassbkFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        'Because data can be input into the system in several ways we
        'have to check that the passbook and feature specified are already
        'in the system.  If so we have to use those - but there actually
        'has to be an object first.
        If IsNothing(pFeature) Then
            Dim logMsg As String = "[InputDataError]: No Feature specified, ID=" & pPassbkFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim feat As Feature = _findFeat(pFeature.featId)
        If IsNothing(feat) Then
            feat = pFeature
        End If

        If IsNothing(pPassbk) Then
            Dim logMsg As String = "[InputDataError]: No Passbook specified, ID=" & pPassbkFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        Dim passbk As Passbook = _findPassbk(pPassbk.passbkId)
        If IsNothing(passbk) Then
            passbk = pPassbk
        End If

        passbkFeat = New PassbookFeature(pPassbkFeatId, _
                                         feat, _
                                         passbk, _
                                         pQtyPurch)
        'Make sure we actually have passbook feature object.  There is the slight chance
        'that the New () could have failed.
        If passbkFeat Is Nothing Then
            MsgBox(_SYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
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
    End Sub '_purchPassbkFeat(...)

    '****************************************************************************************
    '_updtPassbkFeat()
    'This is the work-horse function that updates a passbook feature
    'and raises an event to alert any listeners to handle the rest
    'of the associated processed based on this event
    '****************************************************************************************
    Private Sub _updtPassbkFeat(ByVal pPassbkFeatId As String, _
                                ByVal pUpdtQty As Decimal)
        Dim passbkFeat As PassbookFeature

        Try
            passbkFeat = _findPassbkFeat(pPassbkFeatId)
        Catch ex As Exception
            MsgBox(mSYS_ERR_OBJ_CREATE_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        'Make sure we actually have passbook feature object.  There is the slight chance
        'that the New () could have failed.
        If passbkFeat Is Nothing Then
            MsgBox(_SYS_LOOKUP_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Update the quantity purchased
        If pUpdtQty >= passbkFeat.qtyRemain Then
            passbkFeat.qtyPurch += (pUpdtQty - passbkFeat.qtyRemain)
        Else
            passbkFeat.qtyPurch -= (passbkFeat.qtyRemain - pUpdtQty)
        End If

        'Update the remaining quantity
        passbkFeat.qtyRemain = pUpdtQty

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
    Private Sub _usedFeat(ByVal pUsedFeatId As String, _
                          ByVal pPassbkFeat As PassbookFeature, _
                          ByVal pDateUsed As Date, _
                          ByVal pQtyUsed As Decimal, _
                          ByVal pLoc As String)
        'Trap duplicates here and don't create - this can happen from system test data
        Dim usedFeat As UsedFeature
        Try
            usedFeat = _findUsedFeat(pUsedFeatId)
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        If Not IsNothing(usedFeat) Then
            Dim logMsg As String = "ERROR: Attempt to create duplicate Used Feature, ID=" & pUsedFeatId

            'Raise and event to let the listeners of this event it happened
            RaiseEvent ThemePark_LogTran(Me,
                                         New ThemePark_EventArgs_LogMsg(logMsg))
            Exit Sub
        End If

        'Because data can be input into the system in several ways we
        'have to check that the passbook feature specified is already
        'in the system.  If so that feature has to be used
        Dim passbkFeat As PassbookFeature
        Try
            passbkFeat = _findPassbkFeat(pPassbkFeat.id)
        Catch ex As Exception
            Throw New IndexOutOfRangeException
            Exit Sub
        End Try

        If IsNothing(passbkFeat) Then
            passbkFeat = pPassbkFeat
        End If

        usedFeat = New UsedFeature(pUsedFeatId, _
                                   passbkFeat, _
                                   pQtyUsed, _
                                   pLoc, _
                                   pDateUsed)

        'Make sure we actually have used feature object.  There is the slight chance
        'that the New () could have failed.
        If IsNothing(usedFeat) Then
            MsgBox(_SYS_OBJ_CREATE_ERR_MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If

        'update the passbook feature reference
        passbkFeat.qtyRemain -= pQtyUsed

        'Sanity check
        If passbkFeat.qtyRemain < 0 Then
            passbkFeat.qtyRemain = 0
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