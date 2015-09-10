'Copyright (c) 2009-2015 Dan Turk

#Region "Class / File Comment Header block"
'Program:   Ch02Ex03 (practice program)
'File:      FrmMain.vb
'Author:    Robert Palumbo         
'Description:   This is the main user interface form for the 
'               Ch02Ex03 practice program. It allows the user
'               to input information for an inventory mgmt
'               system.  It is comprised of 2 Tabs: 
'                  1) Inventory List
'                  2) Inventory Management
'               which are used to manage the system.
'
'Date:      09/02/2015 
'               - Initial creation
'
'Tier:      User Interface       
'Exceptions:           N/A
'Exception-Handling:   N/A
'Events:               N/A
'Event-Handling:       N/A
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class FrmMain

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    'No Attributes are currently defined.

    '********** Module-level constants

    '********** Module-level variables

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    'No Get/Set Methods are currently defined.

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    'No Behavioral Methods are currently defined.

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '_closeAppl() is used to simply close the application when
    'requested.
    Private Sub _closeAppl()

        Dim msg = "Program exiting...press OK to continue."
        Dim style = MsgBoxStyle.OkOnly

        'Notify the user application is closing
        MsgBox(msg, style)

        Me.Close()

    End Sub '_closeAppl()

    '********** Public Non-Shared Behavioral Methods

    '********** Private Non-Shared Behavioral Methods

    '_initializeInvMgmtTabItemList is used to initialize the 
    'inventory mgmt tab combo box that store inventory items.
    Private Sub _initializeInvMgmtTabItemList()
        Debug.Print("Initializing item list combo box")

        'duplicate the same item list as defined in Inventory
        'List tab
        cboInvItem.Items.Add("Air Cleaners")
        cboInvItem.Items.Add("Air Filters")
        cboInvItem.Items.Add("Air Fresheners")
        cboInvItem.Items.Add("Anti Freeze")
        cboInvItem.Items.Add("Batteries")
        cboInvItem.Items.Add("Brake Pads")
        cboInvItem.Items.Add("Car Polish")
        cboInvItem.Items.Add("Car Wax")
        cboInvItem.Items.Add("Floor Mats")
        cboInvItem.Items.Add("Fog-lights")
        cboInvItem.Items.Add("Fuel Filter")
        cboInvItem.Items.Add("Head-lights")
        cboInvItem.Items.Add("Mirrors")
        cboInvItem.Items.Add("Mufflers")
        cboInvItem.Items.Add("Oil")
        cboInvItem.Items.Add("Oil Filters")
        cboInvItem.Items.Add("Power Steering Fluid")
        cboInvItem.Items.Add("Radiators")
        cboInvItem.Items.Add("Spark Plugs")
        cboInvItem.Items.Add("Tail-lights")
        cboInvItem.Items.Add("Tires")
        cboInvItem.Items.Add("Touchup Paint")
        cboInvItem.Items.Add("Transmission Fluid")
        cboInvItem.Items.Add("Wiper Blades")

        'Set the list index to the first item
        cboInvItem.SelectedIndex = 0

    End Sub '_initializeInvMgmtTabItemList

    '_initializeToolTips to assist the user
    Private Sub _initializeToolTips()

        'Create a tooltip object shared for each control
        Dim toolTip As New ToolTip()

        'Configure the toolTip object with appropriate delays.
        toolTip.AutoPopDelay = 5000
        toolTip.InitialDelay = 1000
        toolTip.ReshowDelay = 500
        toolTip.ShowAlways = True

        'Create a tooltip for each control on the form
        toolTip.SetToolTip(Me.tabpInvList, "Inventory List Page")
        toolTip.SetToolTip(Me.tabpInvMgmt, "Inventory Management Page")
        toolTip.SetToolTip(Me.btnExit, "Click on button to Exit the program")
        toolTip.SetToolTip(Me.updQty, "Enter item quantity to add")
        toolTip.SetToolTip(Me.cboInvItem, "Select item to be added from list")
        toolTip.SetToolTip(Me.btnAdd, "Click to add item(s) to inventory")
        toolTip.SetToolTip(Me.btnRemove, "Click to remove item from inventory")

    End Sub '_initializeToolTips()

    '_initializeBusinessLogic() is used to initialize the program business
    'data/logic to a known good starting state.
    Private Sub _initializeBusinessLogic()

        'Do Nothing for Now

    End Sub '_initializeBusinessLogic()

    '_initializeUserInterface() is used to instantiate the user interface
    'so it is ready for user interaction.
    Private Sub _initializeUserInterface()

        'Initialize the inventor item list for the inventory mgmt tab
        _initializeInvMgmtTabItemList()

    End Sub 'initializeUserInterface()


#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

    'No Event Procedures are currently defined.
    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '_frmMain_Load() is the first method that is invoked when the program
    'starts execution.  It is responsbile for initializing any business
    'logic data to a known good state as well as initializing the user
    'interface to ready it for user interaction.
    Private Sub _frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Assign CancelButtons to the form based buttons so the 'Enter'
        'key will activate the button if the user tabs to it
        Me.CancelButton = btnExit

        'Center the main form on the display
        Me.StartPosition = FormStartPosition.CenterScreen

        'Initalize tool tips for specific controls
        _initializeToolTips()

        'Initialize the program business logic
        _initializeBusinessLogic()

        'Initialize the user interface
        _initializeUserInterface()

    End Sub '_frmMain_Load(sender, e)

    '_btnExit_Click() is the event procedure that gets called when the
    'user clicks on the Exit button or by using Alt-E hot key sequence.
    'It is used to notify the user and formally terminate the program.
    Private Sub _btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Terminate the program
        _closeAppl()

    End Sub '_btnExit_Click(sender, e)

    '_mnuFileExit() is the event procedure that gets called when the user selects
    'File->Exit from the main menu.
    Private Sub _mnuFileExit(sender As Object, e As EventArgs) Handles mnuOptionFileExit.Click

        'Program terminated from main menu selection
        _closeAppl()

    End Sub

    Private Sub lblInvList_Click(sender As Object, e As EventArgs) Handles lblInvList.Click

    End Sub

    Private Sub lstInvItems_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboInvItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInvItem.SelectedIndexChanged

    End Sub

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

End Class 'FrmMain