'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
'File:          ClsThemePark_KeyPerfInd.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for the ThemePark_KeyPerfInd which
'               is used to calculate key performance indicators within the system
'               which are displayed on the main form.
'
'Date:          10/05/2015
'                   - initial creation
'                   - Code for Proj02 - second phase of the course project.
'               10/29/2015
'                   - Modifications to support the third phase of
'                   course project (Proj03)
'               12/02/2015
'                   - Initial creation
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

Public Class ThemePark_KeyPerfInd

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Avg $ balance of unused features 
    Private mAvgBalUnusedFeat As Decimal

    'Tot $ balance of unused features
    Private mTotBalUnusedFeat As Decimal

    'Avg number of passbooks per customer
    Private mAvgPassbkPerCust As Decimal

    'Most populate feature purchased
    Private mMostPopFeat As String

    'Percent of passbook features used (used / total)
    Private mPctPassbkFeatUsed As Decimal

    'Average age of all passbook holders
    Private mAvgPassbkHolderAge As Decimal

    'Number of passbook holders with a bday in current month
    Private mNumPassbkHolderBdaysInCurrMon As Integer

#End Region 'Attributes

#Region "Constructors"
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

    'No formal constructors are required

    'Default constructor - no parameters

    'Special constructor(s) - typically constructors have parameters 
    '                         that are used to initialize attributes

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '****************************************************************************************
    'Get/Set Methods
    '****************************************************************************************

    'Public  Get/Set Methods - access attributes

    'Private Get/Set Methods - access attributes, 
    '                          begin name with underscore (_)

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '****************************************************************************************
    'Behavioral Methods
    '****************************************************************************************

    'Public Shared Behavioral Methods

    'Private Shared Behavioral Methods

    'Public Non-Shared Behavioral Methods

    'calcAvgBalUnusedFeat()
    '   - calculates the avg unused feature balance
    Public Function calcAvgBalUnusedFeat() As Decimal
        Return _calcAvgBalUnusedFeat()
    End Function 'calcAvgBalUnusedFeat()

    'calcTotBalUnusedFeat()
    '   - function that calculates the total unused feature balance
    Public Function calcTotBalUnusedFeat() As Decimal
        Return _calcTotBalUnusedFeat()
    End Function 'calcTotBalUnusedFeat()

    'calcAvgPassbkPerCust()
    '   - function that calculates the total unused feature balance
    Public Function calcAvgPassbkPerCust() As Decimal
        Return _calcAvgPassbkPerCust()
    End Function 'calcAvgPassbkPerCust()

    'calcMostPopFeat()
    '   - function that calculates the most popular purchase feature
    Public Function calcMostPopFeat() As String
        Return _calcMostPopFeat()
    End Function 'calcMostPopFeat()

    'calcPctPassbkFeatUsed()
    '   - Percent of passbook features used (used / total)
    Public Function calcPctPassbkFeatUsed() As Decimal
        Return _calcPctPassbkFeatUsed()
    End Function 'calcPctPassbkFeatUsed()

    'calcAvgPassbkHolderAge()
    '   - Average age of all passbook holders
    Public Function calcAvgPassbkHolderAge() As Decimal
        Return _calcAvgPassbkHolderAge()
    End Function 'calcAvgPassbkHolderAge()

    'calcNumPassbkHolderBdaysInCurrMon()
    '   - Average age of all passbook holders
    Public Function calcNumPassbkHolderBdaysInCurrMon() As Integer
        Return _calcNumPassbkHolderBdaysInCurrMon()
    End Function 'calcNumPassbkHolderBdaysInCurrMon()


    Public Overrides Function ToString() As String

        'ToString() is the public interface that
        'provides a String version of the data
        'stored in the class attributes.

        Return _toString()

    End Function 'ToString()

    'Private Non-Shared Behavioral Methods

    '_calcAvgBalUnusedFeat()
    '   - workhorse function that calculates the avg unused feature balance
    '   on behalf of calcAvgBalUnusedFeat()
    Public Function _calcAvgBalUnusedFeat() As Decimal
        Dim val As Decimal = 120.5D
        Return val
    End Function '_calcAvgBalUnusedFeat()

    '_calcTotBalUnusedFeat()
    '   - workhorse function that calculates the total unused feature balance
    '   on behalf of calcTotBalUnusedFeat()
    Public Function _calcTotBalUnusedFeat() As Decimal
        Dim val As Decimal = 5500.5D
        Return val
    End Function '_calcTotBalUnusedFeat()

    '_calcAvgPassbkPerCust()
    '   - workhorse function that calculates the avg number of passbooks per customer
    '   on behalf of calcAvgPassbkPerCust()
    Public Function _calcAvgPassbkPerCust() As Decimal
        Dim val As Decimal = 3.25D
        Return val
    End Function '_calcAvgPassbkPerCust()

    '_calcMostPopFeat()
    '   - workhorse function that calculates the most popular purchased feature
    '   on behalf of calcMostPopFeat()
    Public Function _calcMostPopFeat() As String
        Dim val As String = "Parking Pass"
        Return val
    End Function '_calcMostPopFeat()

    '_calcPctPassbkFeatUsed()
    '   - workhorse function that calculates the percent of passbook features 
    '   used (used / total) on behalf of calcPctPassbkFeatUsed()
    Public Function _calcPctPassbkFeatUsed() As Decimal
        Dim val As Decimal = 37.4D
        Return val
    End Function '_calcPctPassbkFeatUsed()

    '_calcAvgPassbkHolderAge()
    '   - workhorse function that calculates the avg age of all passbook holders
    '   on behalf of calcAvgPassbkHolderAge()
    Public Function _calcAvgPassbkHolderAge() As Decimal
        Dim val As Decimal = 27.23D
        Return val
    End Function '_calcAvgPassbkHolderAge()

    '_calcNumPassbkHolderBdaysInCurrMon()
    '   - workhorse function that calculates the number of passbook holders that 
    '   have a birthday in the current month on behalf of calcNumPassbkHolderBdaysInCurrMon()
    Public Function _calcNumPassbkHolderBdaysInCurrMon() As Integer
        Dim val As Integer = 11
        Return val
    End Function '_calcNumPassbkHolderBdaysInCurrMon()


    '****************************************************************************************
    '_toString() creates and returns a String version of the data
    'stored in the object.  This is the work-horse function that
    'does all the work for ToString().
    '****************************************************************************************
    Private Function _toString() As String
        Dim tmpStr As String

        tmpStr = ""

        Return tmpStr
    End Function '_toString()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '****************************************************************************************
    'Event Procedures
    '****************************************************************************************

    'No Event Procedures are currently defined

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

#End Region 'Events

End Class 'ThemePark_KeyPerfInd