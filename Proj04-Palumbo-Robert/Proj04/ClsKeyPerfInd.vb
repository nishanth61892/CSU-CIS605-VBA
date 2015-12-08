'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:       Proj04 - Theme Park Management System
'File:          ClsKeyPerfInd.vb
'Author:        Robert Palumbo
'Description:   This is the class definiton for the KeyPerfInd which is used
'               to calculate key performance indicators within the system
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

Public Class KeyPerfInd

#Region "Attributes"
    '****************************************************************************************
    'Attributes + Module-level Constants+Variables
    '****************************************************************************************

    '********** Module-level constants

    '********** Module-level variables

    'Internal class used to assist with finding the most popular feature
    Private Class MostPopFeat
        Private mFeatId As String
        Private mFeatName As String
        Private mFeatCnt As Integer

        'Public Getter / setter
        Public Property featId() As String
            Get
                Return _featId
            End Get
            Set(value As String)
                _featId = value
            End Set
        End Property

        Public Property featName() As String
            Get
                Return _featName
            End Get
            Set(value As String)
                _featName = value
            End Set
        End Property

        Public Property featCnt() As Integer
            Get
                Return _featCnt
            End Get
            Set(value As Integer)
                _featCnt = value
            End Set
        End Property

        'Private Getter / setter
        Private Property _featId() As String
            Get
                Return mFeatId
            End Get
            Set(value As String)
                mFeatId = value
            End Set
        End Property

        Private Property _featName() As String
            Get
                Return mFeatName
            End Get
            Set(value As String)
                mFeatName = value
            End Set
        End Property

        Private Property _featCnt() As Integer
            Get
                Return mFeatCnt
            End Get
            Set(value As Integer)
                mFeatCnt = value
            End Set
        End Property


    End Class

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

    'Themepark reference
    Private themePark As ThemePark
#End Region 'Attributes

#Region "Constructors"
    '****************************************************************************************
    'Constructors
    '****************************************************************************************

    'No formal constructors are required

    'Default constructor - no parameters

    'Special constructor(s) - typically constructors have parameters 
    '                         that are used to initialize attributes
    Public Sub New(ByVal pThemePark As ThemePark)
        themePark = pThemePark
    End Sub

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
        Dim val As Decimal = 0
        Dim bal As Decimal = 0
        Dim unusedCnt As Integer = 0

        'If there are no passbook features there is nothing to calculate
        If themePark.numPassbkFeats > 0 Then
            For Each passbkFeat As PassbookFeature In themePark.iteratePassbkFeat
                'Make sure passbk reference is valid - skip if error
                If IsNothing(passbkFeat.passbk) Then
                    Dim s As String = themePark.sysObjLookupErr
                    MsgBox(s, MsgBoxStyle.Critical)
                    Continue For
                End If

                'Calculate unused amount and skip if all used
                If passbkFeat.qtyRemain > 0 Then
                    'Keep track of # of unused feature
                    unusedCnt = CInt(unusedCnt + passbkFeat.qtyRemain)

                    'Running total of the unused balance
                    bal += passbkFeat.unitPrice * passbkFeat.qtyRemain
                    'Console.WriteLine("Tot Unused Balance" & bal.ToString("C") & "  UnusedCnt=" & unusedCnt)
                End If
            Next passbkFeat

            'Now calculate and return the averge age
            val = bal / themePark.numPassbkFeats
        End If

        Return val
    End Function '_calcAvgBalUnusedFeat()

    '_calcTotBalUnusedFeat()
    '   - workhorse function that calculates the total unused feature balance
    '   on behalf of calcTotBalUnusedFeat()
    Public Function _calcTotBalUnusedFeat() As Decimal
        Dim val As Decimal = 0D
        Dim bal As Decimal = 0
        Dim unusedCnt As Integer = 0

        'If there are no passbook features there is nothing to calculate
        If themePark.numPassbkFeats > 0 Then
            For Each passbkFeat As PassbookFeature In themePark.iteratePassbkFeat
                'Calculate unused amount and skip if all used
                If passbkFeat.qtyRemain > 0 Then
                    'Keep track of # of unused feature
                    unusedCnt = CInt(unusedCnt + passbkFeat.qtyRemain)

                    'Running total of the unused balance
                    bal += passbkFeat.unitPrice * passbkFeat.qtyRemain
                    'Console.WriteLine("Tot Unused Balance" & bal.ToString("C") & "  UnusedCnt=" & unusedCnt)
                End If
            Next passbkFeat

            'Set the calculated balance
            val = bal
        End If

        Return val
    End Function '_calcTotBalUnusedFeat()

    '_calcAvgPassbkPerCust()
    '   - workhorse function that calculates the avg number of passbooks per customer
    '   on behalf of calcAvgPassbkPerCust()
    Public Function _calcAvgPassbkPerCust() As Decimal
        Dim val As Decimal = 0

        'Simply number of passbooks / number of customers
        'If there are no customers there is nothing to calculate
        If themePark.numCusts > 0 Then
            'Now calculate and return the averge age
            val = CDec(themePark.numPassbks / themePark.numCusts)
        End If

        Return val
    End Function '_calcAvgPassbkPerCust()

    '_calcPctPassbkFeatUsed()
    '   - workhorse function that calculates the percent of passbook features 
    '   used (used / total) on behalf of calcPctPassbkFeatUsed()
    Public Function _calcPctPassbkFeatUsed() As Decimal
        Dim val As Decimal = 0
        Dim totPurchBal As Decimal = 0
        Dim totUsedBal As Decimal = 0
        Dim unusedCnt As Integer = 0

        'If there are no passbook features there is nothing to calculate
        If themePark.numPassbkFeats > 0 Then

            'First calculate up the total balance of features purchased
            'Unit price is based on visIsChild at time of purchase
            For Each passbkFeat As PassbookFeature In themePark.iteratePassbkFeat
                'Make sure passbk reference is valid since we need visitor info
                If IsNothing(passbkFeat.passbk) Then
                    Dim s As String = themePark.sysObjLookupErr
                    MsgBox(s, MsgBoxStyle.Critical)
                    Continue For
                End If

                'Calculate balance for this purchase unused amount and skip if all used
                'Note - Minor vs Adult pricing was determined at the time of purchase
                'so the data in the object already has the correct total purchase price
                'based on age
                totPurchBal += passbkFeat.unitPrice * passbkFeat.qtyPurch
                totUsedBal += passbkFeat.unitPrice * (passbkFeat.qtyPurch - passbkFeat.qtyRemain)
                'Console.WriteLine("TotPurchBal=" & totPurchBal.ToString("C") & " QtyPurch=" & passbkFeat.qtyPurch & " TotUsedBal=" & totUsedBal.ToString("C")                       & " QtyUsed=" & (passbkFeat.qtyPurch - passbkFeat.qtyRemain))
            Next passbkFeat

            'Set the calculated balance
            val = (totUsedBal / totPurchBal) * 100D
        End If

        Return val
    End Function '_calcPctPassbkFeatUsed()

    '_calcAvgPassbkHolderAge()
    '   - workhorse function that calculates the avg age of all passbook holders
    '   on behalf of calcAvgPassbkHolderAge()
    Public Function _calcAvgPassbkHolderAge() As Decimal
        Dim val As Decimal = 0D
        Dim age As Integer = 0

        'If there are no passbook holders there is nothing to calculate
        If themePark.numPassbks > 0 Then
            For Each passbk As Passbook In themePark.iteratePassbk
                age += _kpiAgeCalc(passbk.visDob)
            Next passbk

            'Now calculate and return the averge age
            val = CDec(age / themePark.numPassbks)
        End If

        Return val
    End Function '_calcAvgPassbkHolderAge()

    '_calcNumPassbkHolderBdaysInCurrMon()
    '   - workhorse function that calculates the number of passbook holders that 
    '   have a birthday in the current month on behalf of calcNumPassbkHolderBdaysInCurrMon()
    Public Function _calcNumPassbkHolderBdaysInCurrMon() As Integer
        Dim val As Integer = 0

        For Each passbk As Passbook In themePark.iteratePassbk
            If passbk.visDob.Month = Now.Month Then
                val += 1
            End If
        Next passbk

        Return val
    End Function '_calcNumPassbkHolderBdaysInCurrMon()

    '_calcMostPopFeat()
    '   - workhorse function that calculates the most popular purchased feature
    '   on behalf of calcMostPopFeat()
    Public Function _calcMostPopFeat() As String
        Dim val As String = Nothing

        'If there are no features there is nothing to calculate
        If themePark.numFeats > 0 AndAlso themePark.numPassbkFeats > 0 Then
            'Allocate an array to keep track of cnt of each unique feature
            Dim mostPopFeat(themePark.numFeats - 1) As MostPopFeat

            'Now populate the array with the feature ids that are in the system
            Dim feat As Feature
            Dim i As Integer
            Dim j As Integer

            For i = 0 To mostPopFeat.Length - 1
                'allocate space for the each new feature to add
                mostPopFeat(i) = New MostPopFeat
                feat = CType(themePark.iterateFeat.ElementAt(i), Feature)
                mostPopFeat(i).featId = feat.featId
                mostPopFeat(i).featName = feat.featName
                mostPopFeat(i).featCnt = 0
            Next i

            'Debug
            For i = 0 To mostPopFeat.Length - 1
                'Console.WriteLine("Filled: mostPop(" & i & ").id=" & mostPopFeat(i).featId & " cnt=" & mostPopFeat(i).featCnt)
            Next i

            'Now parse thru the passbook feature array and tally up matching features
            'with the mostPopFeat array.  Require a loop inside a loop
            Dim passbkFeat As PassbookFeature
            For i = 0 To mostPopFeat.Length - 1
                For j = 0 To themePark.numPassbkFeats - 1
                    passbkFeat = CType(themePark.iteratePassbkFeat.ElementAt(j), PassbookFeature)
                    feat = passbkFeat.feature

                    'sanity check
                    If Not IsNothing(feat) Then
                        If feat.featId = mostPopFeat(i).featId Then
                            mostPopFeat(i).featCnt = CInt(mostPopFeat(i).featCnt + passbkFeat.qtyPurch)
                        End If
                    Else
                        'Console.Error.WriteLine(themePark.sysObjLookupErr)
                    End If
                Next j
            Next i

            'Debug
            For i = 0 To mostPopFeat.Length - 1
                'Console.WriteLine("Updated: mostPop(" & i & ").id=" & mostPopFeat(i).featId & " cnt=" & mostPopFeat(i).featCnt)
            Next i

            'Now just find the max of all the feature cnts and that is the most popular 
            'pick the first feature in case of ties
            Dim maxVal As Integer = -1
            For i = 0 To mostPopFeat.Length - 1
                'Console.WriteLine("Max: mostPop(" & i & ").id=" & mostPopFeat(i).featId & " cnt=" & mostPopFeat(i).featCnt & " MaxVal=" & maxVal                             & " CurrVal=" & val)

                If mostPopFeat(i).featCnt > maxVal Then
                    maxVal = mostPopFeat(i).featCnt
                    val = mostPopFeat(i).featName
                End If
            Next i
        End If

        Return val
    End Function '_calcMostPopFeat()


    Private Function _kpiAgeCalc(ByVal pVisDoB As Date) As Integer
        Dim age As Integer = 0
        Dim dateNow As Date = Now

        'Need to compensate for DoB in the current year 
        Dim dobYear As Integer = pVisDoB.Year
        Dim nowYear As Integer = Now.Year

        age = nowYear - dobYear
        If pVisDoB.AddYears(age) > dateNow Then
            age -= 1
        End If

        Return age
    End Function '_kpiAgeCalc(...)



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

End Class 'KeyPerfInd