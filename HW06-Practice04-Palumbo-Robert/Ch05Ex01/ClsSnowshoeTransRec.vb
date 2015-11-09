'Copyright (c) 2009-2014 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Ch05Ex01
'File:          ClsSnowshoeTransRec.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for the SnowshoeTransRec.  This
'               class is used to maintain state information for each 
'               snowshoe transaction: rental vs purchase
'
'Date:          11/08/2015
'                  - Initial creation
'
'Tier:          User Interface
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

Public Class SnowshoeTransRec

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants
    'Member discount rate off of price
    Private Const mMEM_DISCNT_RATE As Decimal = 0.15D
    'Sales tax rate
    Private Const mSALES_TAX_RATE As Decimal = 0.0375D

    '********** Module-level variables

    'Snowshoe type / brand
    Private mSnowshoe As Snowshoe
    'Number of pairs in the transaction
    Private mPairsCnt As Integer
    'True if rental transaction otherwise False for a purchase
    Private mIsRental As Boolean
    'Number of days in the rental period, 0 if a purchase
    Private mDaysToRent As Integer
    'True if customer is a member, False otherwise
    Private mIsMember As Boolean

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

    Public Sub New(ByVal pSnowshoe As Snowshoe, _
                   ByVal pPairsCnt As Integer, _
                   ByVal pIsRental As Boolean, _
                   ByVal pDaysToRent As Integer, _
                   ByVal pIsMember As Boolean _
                   )
        MyBase.New()

        _snowshoe = pSnowshoe
        _pairsCnt = pPairsCnt
        _isRental = pIsRental
        _daysToRent = pDaysToRent
        _isMember = pIsMember
    End Sub 'New(...)

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    Public ReadOnly Property snowshoe As Snowshoe
        Get
            Return _snowshoe
        End Get
    End Property

    Public ReadOnly Property pairsCnt As Integer
        Get
            Return _pairsCnt
        End Get
    End Property

    Public ReadOnly Property isRental As Boolean
        Get
            Return _isRental
        End Get
    End Property

    Public ReadOnly Property daysToRents As Integer
        Get
            Return _daysToRent
        End Get
    End Property

    Public ReadOnly Property isMember As Boolean
        Get
            Return _isMember
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private ReadOnly Property _MEM_DISCNT_RATE As Decimal
        Get
            Return mMEM_DISCNT_RATE
        End Get
    End Property

    Private ReadOnly Property _SALES_TAX_RATE As Decimal
        Get
            Return mSALES_TAX_RATE
        End Get
    End Property

    Private Property _snowshoe As Snowshoe
        Get
            Return mSnowshoe
        End Get
        Set(ByVal value As Snowshoe)
            mSnowshoe = value
        End Set
    End Property

    Private Property _pairsCnt As Integer
        Get
            Return mPairsCnt
        End Get
        Set(ByVal value As Integer)
            mPairsCnt = value
        End Set
    End Property

    Private Property _isRental As Boolean
        Get
            Return mIsRental
        End Get
        Set(ByVal value As Boolean)
            mIsRental = value
        End Set
    End Property

    Private Property _daysToRent As Integer
        Get
            Return mDaysToRent
        End Get
        Set(ByVal value As Integer)
            mDaysToRent = value
        End Set
    End Property

    Private Property _isMember As Boolean
        Get
            Return mIsMember
        End Get
        Set(ByVal value As Boolean)
            mIsMember = value
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
    'extPrice() calculates the base price of the transaction, rental vs purchase.
    'If rental then 
    '   (rent price * pair cnt * days to rent)
    'otherwise
    '   (purch price * pair cnt)
    '****************************************************************************************
    Public Function extPrice() As Decimal
        Return _extPrice()
    End Function 'extPrice()

    '****************************************************************************************
    'memDiscnt() calculates any applicable member discount.  Customer must be a member and
    'it must be a rental transaction to receive the discount, otherwise 0 discount.
    '****************************************************************************************
    Public Function memDiscnt() As Decimal
        Return _memDiscnt()
    End Function 'memDiscnt()

    '****************************************************************************************
    'preTaxPrice() calculates the pre-tax price for the transaction.
    '   extPrice - memDiscnt
    '****************************************************************************************
    Public Function preTaxPrice() As Decimal
        Return _preTaxPrice()
    End Function 'preTaxPrice()

    '****************************************************************************************
    'salesTax() calculates the total sales tax for the transaction.
    '   preTaxPrice * _SALES_TAX_RATE
    '****************************************************************************************
    Public Function salesTax() As Decimal
        Return _salesTax()
    End Function 'salesTax()

    '****************************************************************************************
    'totalTransCost() calculates the overall cost for the transaction
    '   preTaxPrice + salesTaxPrice
    '****************************************************************************************
    Public Function totalTransCost() As Decimal
        Return _totalTransCost()
    End Function 'totalTransCost()

    '****************************************************************************************
    'ToString() is the public interface that provides a String 
    'version of the data stored in the class attributes.
    '****************************************************************************************
    Public Overrides Function ToString() As String
        Return _toString()
    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods

    '****************************************************************************************
    '_extPrice() is the worker procedure that performs the actual
    'base cost calculation for the transaction based on whether it is
    'a purchase vs rental.
    '****************************************************************************************
    Private Function _extPrice() As Decimal
        If _isRental Then
            Return _snowshoe.rentPrice * _pairsCnt * _daysToRent
        Else
            Return _snowshoe.purchPrice * _pairsCnt
        End If
    End Function '_extPrice()


    '****************************************************************************************
    '_memDiscnt() is the worker procedure that calculates a member discount for rentals.
    'If customer is not a member then no discount is available.
    '****************************************************************************************
    Private Function _memDiscnt() As Decimal
        'Customer must be a member and it must be a rental transaction for the
        'discount to be applied.
        Dim amt As Decimal = 0D

        If _isMember And _isRental Then
            amt = _extPrice() * _MEM_DISCNT_RATE
        End If

        Return amt
    End Function '_memDiscnt()

    '****************************************************************************************
    '_preTaxPrice() is the worker procedure that calculates the pre-tax price for the 
    'transaction.  This is the extended price less any member discount.
    '****************************************************************************************
    Private Function _preTaxPrice() As Decimal
        Return _extPrice() - _memDiscnt()
    End Function '_preTaxPrice()

    '****************************************************************************************
    '_salesTax() is the worker procedure that calculates the sale-tax amount for the
    'transaction.  This is the pre-tax price * SALES_TAX_RATE
    '****************************************************************************************
    Private Function _salesTax() As Decimal
        Return _preTaxPrice() * _SALES_TAX_RATE
    End Function '_salesTax()

    '****************************************************************************************
    '_totalTransCost() is the worker procedure that calculates the total price for the
    'transaction.  This is the pre-tax price + sales tax
    '****************************************************************************************
    Private Function _totalTransCost() As Decimal
        Return _preTaxPrice() + _salesTax()
    End Function '_totalTransCost()

    '****************************************************************************************
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String

        tmpStr = "[SnowshoeTransaction] -> " _
            & "Snowshoe=" & _snowshoe.ToString _
            & ", PairCnt=" & _pairsCnt.ToString("N0") _
            & ", IsRental?=" & _isRental.ToString() _
            & ", DaysToRent=" & _daysToRent.ToString("N0") _
            & ", IsMember?=" & _isMember.ToString() _
            & ", PricePerDay=$" & _extPrice.ToString("N2") _
            & ", MemberDiscnt$" & _memDiscnt.ToString("N2") _
            & ", PreTaxPrice=$" & _preTaxPrice.ToString("N2") _
            & ", SalesTaxAmt=$" & _salesTax.ToString("N2") _
            & ", TotalCost=$" & _totalTransCost.ToString("N2") _
            & " )"

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

End Class 'SnowshoeTransRec