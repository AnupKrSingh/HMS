<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hotel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotel))
        Me.ButTotal = New System.Windows.Forms.Button()
        Me.labcname = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextFeed = New System.Windows.Forms.RichTextBox()
        Me.CustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New HMS.CustomerDataSet()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.labcadd = New System.Windows.Forms.Label()
        Me.TextAddrs = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.TextcPhone = New System.Windows.Forms.TextBox()
        Me.labcphone = New System.Windows.Forms.Label()
        Me.TextProof = New System.Windows.Forms.TextBox()
        Me.labcproof = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextTime = New System.Windows.Forms.TextBox()
        Me.TextDate = New System.Windows.Forms.TextBox()
        Me.ltime = New System.Windows.Forms.Label()
        Me.ldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButClear = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabFood = New System.Windows.Forms.Label()
        Me.TextFood = New System.Windows.Forms.TextBox()
        Me.TextRoomno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextPhone = New System.Windows.Forms.TextBox()
        Me.LabPhone = New System.Windows.Forms.Label()
        Me.TextMis = New System.Windows.Forms.TextBox()
        Me.LabMis = New System.Windows.Forms.Label()
        Me.TextService = New System.Windows.Forms.TextBox()
        Me.LabService = New System.Windows.Forms.Label()
        Me.TextNights = New System.Windows.Forms.TextBox()
        Me.LabNights = New System.Windows.Forms.Label()
        Me.TextRates = New System.Windows.Forms.TextBox()
        Me.rates = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextTax = New System.Windows.Forms.TextBox()
        Me.labtax = New System.Windows.Forms.Label()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabAdd = New System.Windows.Forms.Label()
        Me.TextSub = New System.Windows.Forms.TextBox()
        Me.TextRoomcharges = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextAdd = New System.Windows.Forms.TextBox()
        Me.CustTableAdapter = New HMS.CustomerDataSetTableAdapters.CustTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDProofDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneBillDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomChargesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBillDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        CType(Me.CustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButTotal
        '
        Me.ButTotal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButTotal.Image = Global.HMS.My.Resources.Resources.City_Bank_icon
        Me.ButTotal.Location = New System.Drawing.Point(990, 581)
        Me.ButTotal.Name = "ButTotal"
        Me.ButTotal.Size = New System.Drawing.Size(88, 83)
        Me.ButTotal.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ButTotal, "Total Bill")
        Me.ButTotal.UseVisualStyleBackColor = True
        '
        'labcname
        '
        Me.labcname.AutoSize = True
        Me.labcname.Location = New System.Drawing.Point(22, 36)
        Me.labcname.Name = "labcname"
        Me.labcname.Size = New System.Drawing.Size(82, 13)
        Me.labcname.TabIndex = 1
        Me.labcname.Text = "Customer &Name"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(68, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cash"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextFeed
        '
        Me.TextFeed.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextFeed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Feedback", True))
        Me.TextFeed.Location = New System.Drawing.Point(37, 30)
        Me.TextFeed.Name = "TextFeed"
        Me.TextFeed.Size = New System.Drawing.Size(195, 53)
        Me.TextFeed.TabIndex = 3
        Me.TextFeed.Text = ""
        '
        'CustBindingSource
        '
        Me.CustBindingSource.DataMember = "Cust"
        Me.CustBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextName
        '
        Me.TextName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Customer Name", True))
        Me.TextName.Location = New System.Drawing.Point(156, 29)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(179, 20)
        Me.TextName.TabIndex = 4
        '
        'labcadd
        '
        Me.labcadd.AutoSize = True
        Me.labcadd.Location = New System.Drawing.Point(22, 67)
        Me.labcadd.Name = "labcadd"
        Me.labcadd.Size = New System.Drawing.Size(92, 13)
        Me.labcadd.TabIndex = 6
        Me.labcadd.Text = "Customer &Address"
        '
        'TextAddrs
        '
        Me.TextAddrs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Customer Address", True))
        Me.TextAddrs.Location = New System.Drawing.Point(156, 60)
        Me.TextAddrs.Multiline = True
        Me.TextAddrs.Name = "TextAddrs"
        Me.TextAddrs.Size = New System.Drawing.Size(179, 20)
        Me.TextAddrs.TabIndex = 7
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(68, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Debit Card"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(68, 38)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Credit Card"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'TextcPhone
        '
        Me.TextcPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Customer Phone No", True))
        Me.TextcPhone.Location = New System.Drawing.Point(156, 128)
        Me.TextcPhone.Name = "TextcPhone"
        Me.TextcPhone.Size = New System.Drawing.Size(179, 20)
        Me.TextcPhone.TabIndex = 11
        '
        'labcphone
        '
        Me.labcphone.AutoSize = True
        Me.labcphone.Location = New System.Drawing.Point(22, 131)
        Me.labcphone.Name = "labcphone"
        Me.labcphone.Size = New System.Drawing.Size(102, 13)
        Me.labcphone.TabIndex = 10
        Me.labcphone.Text = "Customer &Phone No"
        '
        'TextProof
        '
        Me.TextProof.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Customer ID Proof", True))
        Me.TextProof.Location = New System.Drawing.Point(156, 97)
        Me.TextProof.Name = "TextProof"
        Me.TextProof.Size = New System.Drawing.Size(179, 20)
        Me.TextProof.TabIndex = 9
        '
        'labcproof
        '
        Me.labcproof.AutoSize = True
        Me.labcproof.Location = New System.Drawing.Point(22, 100)
        Me.labcproof.Name = "labcproof"
        Me.labcproof.Size = New System.Drawing.Size(93, 13)
        Me.labcproof.TabIndex = 8
        Me.labcproof.Text = "Customer &ID Proof"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.HMS.My.Resources.Resources.cooltext1487320549
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(425, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 61)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'TextTime
        '
        Me.TextTime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Time", True))
        Me.TextTime.Location = New System.Drawing.Point(90, 169)
        Me.TextTime.Name = "TextTime"
        Me.TextTime.Size = New System.Drawing.Size(130, 20)
        Me.TextTime.TabIndex = 39
        '
        'TextDate
        '
        Me.TextDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Date", True))
        Me.TextDate.Location = New System.Drawing.Point(90, 139)
        Me.TextDate.Name = "TextDate"
        Me.TextDate.Size = New System.Drawing.Size(130, 20)
        Me.TextDate.TabIndex = 38
        '
        'ltime
        '
        Me.ltime.AutoSize = True
        Me.ltime.Location = New System.Drawing.Point(11, 65)
        Me.ltime.Name = "ltime"
        Me.ltime.Size = New System.Drawing.Size(30, 13)
        Me.ltime.TabIndex = 37
        Me.ltime.Text = "Time"
        '
        'ldate
        '
        Me.ldate.AutoSize = True
        Me.ldate.Location = New System.Drawing.Point(11, 35)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(30, 13)
        Me.ldate.TabIndex = 36
        Me.ldate.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ButClear
        '
        Me.ButClear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClear.Image = Global.HMS.My.Resources.Resources.Actions_trash_empty_icon
        Me.ButClear.Location = New System.Drawing.Point(833, 594)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(62, 58)
        Me.ButClear.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.ButClear, "Clear All")
        Me.ButClear.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(70, 45)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "&Lunch"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(69, 74)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "&Dinner"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(70, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "&Breakfast"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 443)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Food Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Location = New System.Drawing.Point(514, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Methods"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TextcPhone)
        Me.GroupBox3.Controls.Add(Me.labcname)
        Me.GroupBox3.Controls.Add(Me.labcphone)
        Me.GroupBox3.Controls.Add(Me.labcadd)
        Me.GroupBox3.Controls.Add(Me.TextProof)
        Me.GroupBox3.Controls.Add(Me.TextName)
        Me.GroupBox3.Controls.Add(Me.labcproof)
        Me.GroupBox3.Controls.Add(Me.TextAddrs)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 179)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.LabFood)
        Me.GroupBox4.Controls.Add(Me.TextFood)
        Me.GroupBox4.Controls.Add(Me.TextRoomno)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextPhone)
        Me.GroupBox4.Controls.Add(Me.LabPhone)
        Me.GroupBox4.Controls.Add(Me.TextMis)
        Me.GroupBox4.Controls.Add(Me.LabMis)
        Me.GroupBox4.Controls.Add(Me.TextService)
        Me.GroupBox4.Controls.Add(Me.LabService)
        Me.GroupBox4.Controls.Add(Me.TextNights)
        Me.GroupBox4.Controls.Add(Me.LabNights)
        Me.GroupBox4.Controls.Add(Me.TextRates)
        Me.GroupBox4.Controls.Add(Me.rates)
        Me.GroupBox4.Location = New System.Drawing.Point(514, 275)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(235, 257)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Room "
        '
        'LabFood
        '
        Me.LabFood.AutoSize = True
        Me.LabFood.Location = New System.Drawing.Point(25, 18)
        Me.LabFood.Name = "LabFood"
        Me.LabFood.Size = New System.Drawing.Size(73, 13)
        Me.LabFood.TabIndex = 36
        Me.LabFood.Text = "&Food Charges"
        '
        'TextFood
        '
        Me.TextFood.Location = New System.Drawing.Point(121, 18)
        Me.TextFood.Name = "TextFood"
        Me.TextFood.Size = New System.Drawing.Size(77, 20)
        Me.TextFood.TabIndex = 37
        Me.TextFood.Text = "0"
        '
        'TextRoomno
        '
        Me.TextRoomno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Room No", True))
        Me.TextRoomno.Location = New System.Drawing.Point(122, 48)
        Me.TextRoomno.Name = "TextRoomno"
        Me.TextRoomno.Size = New System.Drawing.Size(77, 20)
        Me.TextRoomno.TabIndex = 35
        Me.TextRoomno.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Room No."
        '
        'TextPhone
        '
        Me.TextPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Phone Bill", True))
        Me.TextPhone.Location = New System.Drawing.Point(121, 181)
        Me.TextPhone.Name = "TextPhone"
        Me.TextPhone.Size = New System.Drawing.Size(77, 20)
        Me.TextPhone.TabIndex = 33
        Me.TextPhone.Text = "0"
        '
        'LabPhone
        '
        Me.LabPhone.AutoSize = True
        Me.LabPhone.Location = New System.Drawing.Point(24, 184)
        Me.LabPhone.Name = "LabPhone"
        Me.LabPhone.Size = New System.Drawing.Size(54, 13)
        Me.LabPhone.TabIndex = 32
        Me.LabPhone.Text = "Phone &Bill"
        '
        'TextMis
        '
        Me.TextMis.Location = New System.Drawing.Point(121, 213)
        Me.TextMis.Name = "TextMis"
        Me.TextMis.Size = New System.Drawing.Size(77, 20)
        Me.TextMis.TabIndex = 31
        Me.TextMis.Text = "0"
        '
        'LabMis
        '
        Me.LabMis.AutoSize = True
        Me.LabMis.Location = New System.Drawing.Point(24, 220)
        Me.LabMis.Name = "LabMis"
        Me.LabMis.Size = New System.Drawing.Size(23, 13)
        Me.LabMis.TabIndex = 30
        Me.LabMis.Text = "&Mis"
        '
        'TextService
        '
        Me.TextService.Location = New System.Drawing.Point(121, 144)
        Me.TextService.Name = "TextService"
        Me.TextService.Size = New System.Drawing.Size(77, 20)
        Me.TextService.TabIndex = 29
        Me.TextService.Text = "0"
        '
        'LabService
        '
        Me.LabService.AutoSize = True
        Me.LabService.Location = New System.Drawing.Point(24, 147)
        Me.LabService.Name = "LabService"
        Me.LabService.Size = New System.Drawing.Size(74, 13)
        Me.LabService.TabIndex = 28
        Me.LabService.Text = "Room &Service"
        '
        'TextNights
        '
        Me.TextNights.Location = New System.Drawing.Point(121, 78)
        Me.TextNights.Name = "TextNights"
        Me.TextNights.Size = New System.Drawing.Size(77, 20)
        Me.TextNights.TabIndex = 27
        Me.TextNights.Text = "0"
        '
        'LabNights
        '
        Me.LabNights.AutoSize = True
        Me.LabNights.Location = New System.Drawing.Point(24, 81)
        Me.LabNights.Name = "LabNights"
        Me.LabNights.Size = New System.Drawing.Size(66, 13)
        Me.LabNights.TabIndex = 26
        Me.LabNights.Text = "&Days/Nights"
        '
        'TextRates
        '
        Me.TextRates.Location = New System.Drawing.Point(122, 112)
        Me.TextRates.Name = "TextRates"
        Me.TextRates.Size = New System.Drawing.Size(77, 20)
        Me.TextRates.TabIndex = 25
        Me.TextRates.Text = "0"
        '
        'rates
        '
        Me.rates.AutoSize = True
        Me.rates.Location = New System.Drawing.Point(25, 117)
        Me.rates.Name = "rates"
        Me.rates.Size = New System.Drawing.Size(72, 13)
        Me.rates.TabIndex = 20
        Me.rates.Text = "Default &Rates"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.TextTax)
        Me.GroupBox5.Controls.Add(Me.labtax)
        Me.GroupBox5.Controls.Add(Me.TextTotal)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.LabAdd)
        Me.GroupBox5.Controls.Add(Me.TextSub)
        Me.GroupBox5.Controls.Add(Me.TextRoomcharges)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.TextAdd)
        Me.GroupBox5.Location = New System.Drawing.Point(950, 139)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(297, 197)
        Me.GroupBox5.TabIndex = 48
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Charges"
        '
        'TextTax
        '
        Me.TextTax.Location = New System.Drawing.Point(154, 129)
        Me.TextTax.Name = "TextTax"
        Me.TextTax.Size = New System.Drawing.Size(112, 20)
        Me.TextTax.TabIndex = 26
        Me.TextTax.Text = "0"
        '
        'labtax
        '
        Me.labtax.AutoSize = True
        Me.labtax.Location = New System.Drawing.Point(16, 132)
        Me.labtax.Name = "labtax"
        Me.labtax.Size = New System.Drawing.Size(25, 13)
        Me.labtax.TabIndex = 25
        Me.labtax.Text = "&Tax"
        '
        'TextTotal
        '
        Me.TextTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Total Bill", True))
        Me.TextTotal.Location = New System.Drawing.Point(154, 161)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(112, 20)
        Me.TextTotal.TabIndex = 19
        Me.TextTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "&Room Charges"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "&Total Bill"
        '
        'LabAdd
        '
        Me.LabAdd.AutoSize = True
        Me.LabAdd.Location = New System.Drawing.Point(16, 73)
        Me.LabAdd.Name = "LabAdd"
        Me.LabAdd.Size = New System.Drawing.Size(95, 13)
        Me.LabAdd.TabIndex = 14
        Me.LabAdd.Text = "&Additional Charges"
        '
        'TextSub
        '
        Me.TextSub.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Sub Total", True))
        Me.TextSub.Location = New System.Drawing.Point(154, 99)
        Me.TextSub.Name = "TextSub"
        Me.TextSub.Size = New System.Drawing.Size(112, 20)
        Me.TextSub.TabIndex = 17
        Me.TextSub.Text = "0"
        '
        'TextRoomcharges
        '
        Me.TextRoomcharges.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustBindingSource, "Room Charges", True))
        Me.TextRoomcharges.Location = New System.Drawing.Point(154, 35)
        Me.TextRoomcharges.Name = "TextRoomcharges"
        Me.TextRoomcharges.Size = New System.Drawing.Size(112, 20)
        Me.TextRoomcharges.TabIndex = 13
        Me.TextRoomcharges.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "&Sub Total "
        '
        'TextAdd
        '
        Me.TextAdd.Location = New System.Drawing.Point(154, 66)
        Me.TextAdd.Multiline = True
        Me.TextAdd.Name = "TextAdd"
        Me.TextAdd.Size = New System.Drawing.Size(112, 20)
        Me.TextAdd.TabIndex = 15
        Me.TextAdd.Text = "0"
        '
        'CustTableAdapter
        '
        Me.CustTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.HMS.My.Resources.Resources.save_icon
        Me.Button1.Location = New System.Drawing.Point(633, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 58)
        Me.Button1.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.Button1, "Save Customer Data")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.HMS.My.Resources.Resources.add_contact_icon
        Me.Button2.Location = New System.Drawing.Point(497, 595)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 57)
        Me.Button2.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.Button2, "Add New Costomer")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn1, Me.TimeDataGridViewTextBoxColumn1, Me.CustomerNameDataGridViewTextBoxColumn1, Me.CustomerAddressDataGridViewTextBoxColumn1, Me.CustomerPhoneNoDataGridViewTextBoxColumn1, Me.CustomerIDProofDataGridViewTextBoxColumn1, Me.RoomNoDataGridViewTextBoxColumn1, Me.PhoneBillDataGridViewTextBoxColumn1, Me.RoomChargesDataGridViewTextBoxColumn1, Me.SubTotalDataGridViewTextBoxColumn1, Me.TotalBillDataGridViewTextBoxColumn1, Me.FeedbackDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.CustBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(17, 21)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(453, 150)
        Me.DataGridView2.TabIndex = 52
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        '
        'TimeDataGridViewTextBoxColumn1
        '
        Me.TimeDataGridViewTextBoxColumn1.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn1.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn1.Name = "TimeDataGridViewTextBoxColumn1"
        '
        'CustomerNameDataGridViewTextBoxColumn1
        '
        Me.CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn1.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1"
        '
        'CustomerAddressDataGridViewTextBoxColumn1
        '
        Me.CustomerAddressDataGridViewTextBoxColumn1.DataPropertyName = "Customer Address"
        Me.CustomerAddressDataGridViewTextBoxColumn1.HeaderText = "Customer Address"
        Me.CustomerAddressDataGridViewTextBoxColumn1.Name = "CustomerAddressDataGridViewTextBoxColumn1"
        '
        'CustomerPhoneNoDataGridViewTextBoxColumn1
        '
        Me.CustomerPhoneNoDataGridViewTextBoxColumn1.DataPropertyName = "Customer Phone No"
        Me.CustomerPhoneNoDataGridViewTextBoxColumn1.HeaderText = "Customer Phone No"
        Me.CustomerPhoneNoDataGridViewTextBoxColumn1.Name = "CustomerPhoneNoDataGridViewTextBoxColumn1"
        '
        'CustomerIDProofDataGridViewTextBoxColumn1
        '
        Me.CustomerIDProofDataGridViewTextBoxColumn1.DataPropertyName = "Customer ID Proof"
        Me.CustomerIDProofDataGridViewTextBoxColumn1.HeaderText = "Customer ID Proof"
        Me.CustomerIDProofDataGridViewTextBoxColumn1.Name = "CustomerIDProofDataGridViewTextBoxColumn1"
        '
        'RoomNoDataGridViewTextBoxColumn1
        '
        Me.RoomNoDataGridViewTextBoxColumn1.DataPropertyName = "Room No"
        Me.RoomNoDataGridViewTextBoxColumn1.HeaderText = "Room No"
        Me.RoomNoDataGridViewTextBoxColumn1.Name = "RoomNoDataGridViewTextBoxColumn1"
        '
        'PhoneBillDataGridViewTextBoxColumn1
        '
        Me.PhoneBillDataGridViewTextBoxColumn1.DataPropertyName = "Phone Bill"
        Me.PhoneBillDataGridViewTextBoxColumn1.HeaderText = "Phone Bill"
        Me.PhoneBillDataGridViewTextBoxColumn1.Name = "PhoneBillDataGridViewTextBoxColumn1"
        '
        'RoomChargesDataGridViewTextBoxColumn1
        '
        Me.RoomChargesDataGridViewTextBoxColumn1.DataPropertyName = "Room Charges"
        Me.RoomChargesDataGridViewTextBoxColumn1.HeaderText = "Room Charges"
        Me.RoomChargesDataGridViewTextBoxColumn1.Name = "RoomChargesDataGridViewTextBoxColumn1"
        '
        'SubTotalDataGridViewTextBoxColumn1
        '
        Me.SubTotalDataGridViewTextBoxColumn1.DataPropertyName = "Sub Total"
        Me.SubTotalDataGridViewTextBoxColumn1.HeaderText = "Sub Total"
        Me.SubTotalDataGridViewTextBoxColumn1.Name = "SubTotalDataGridViewTextBoxColumn1"
        '
        'TotalBillDataGridViewTextBoxColumn1
        '
        Me.TotalBillDataGridViewTextBoxColumn1.DataPropertyName = "Total Bill"
        Me.TotalBillDataGridViewTextBoxColumn1.HeaderText = "Total Bill"
        Me.TotalBillDataGridViewTextBoxColumn1.Name = "TotalBillDataGridViewTextBoxColumn1"
        '
        'FeedbackDataGridViewTextBoxColumn1
        '
        Me.FeedbackDataGridViewTextBoxColumn1.DataPropertyName = "Feedback"
        Me.FeedbackDataGridViewTextBoxColumn1.HeaderText = "Feedback"
        Me.FeedbackDataGridViewTextBoxColumn1.Name = "FeedbackDataGridViewTextBoxColumn1"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.HMS.My.Resources.Resources.Button_Delete_icon
        Me.Button3.Location = New System.Drawing.Point(567, 595)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 57)
        Me.Button3.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Button3, "Delete Customer Data")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.HMS.My.Resources.Resources.no_icon
        Me.Button4.Location = New System.Drawing.Point(906, 594)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 58)
        Me.Button4.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.Button4, "Exit")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.HMS.My.Resources.Resources.Button_Refresh_icon
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(702, 595)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 58)
        Me.Button5.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.Button5, "Refresh Data")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.ldate)
        Me.GroupBox6.Controls.Add(Me.ltime)
        Me.GroupBox6.Location = New System.Drawing.Point(23, 111)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(224, 90)
        Me.GroupBox6.TabIndex = 55
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Date & Time"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Silver
        Me.GroupBox7.Controls.Add(Me.TextFeed)
        Me.GroupBox7.Location = New System.Drawing.Point(48, 564)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(267, 100)
        Me.GroupBox7.TabIndex = 56
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Customer Feedback"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox8.Controls.Add(Me.DataGridView2)
        Me.GroupBox8.Location = New System.Drawing.Point(845, 372)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(488, 187)
        Me.GroupBox8.TabIndex = 57
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Customer's Data"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox10.Location = New System.Drawing.Point(477, 564)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(305, 111)
        Me.GroupBox10.TabIndex = 59
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Data"
        '
        'Hotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HMS.My.Resources.Resources.hotelSTAY
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButClear)
        Me.Controls.Add(Me.TextTime)
        Me.Controls.Add(Me.TextDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButTotal)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Hotel"
        Me.Text = " TAJ PALACE HOTEL"
        CType(Me.CustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButTotal As System.Windows.Forms.Button
    Friend WithEvents labcname As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextFeed As System.Windows.Forms.RichTextBox
    Friend WithEvents TextName As System.Windows.Forms.TextBox
    Friend WithEvents labcadd As System.Windows.Forms.Label
    Friend WithEvents TextAddrs As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents TextProof As System.Windows.Forms.TextBox
    Friend WithEvents labcproof As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextTime As System.Windows.Forms.TextBox
    Friend WithEvents TextDate As System.Windows.Forms.TextBox
    Friend WithEvents ltime As System.Windows.Forms.Label
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButClear As System.Windows.Forms.Button
    Friend WithEvents TextcPhone As System.Windows.Forms.TextBox
    Friend WithEvents labcphone As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextRates As System.Windows.Forms.TextBox
    Friend WithEvents rates As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabAdd As System.Windows.Forms.Label
    Friend WithEvents TextSub As System.Windows.Forms.TextBox
    Friend WithEvents TextRoomcharges As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextAdd As System.Windows.Forms.TextBox
    Friend WithEvents TextNights As System.Windows.Forms.TextBox
    Friend WithEvents LabNights As System.Windows.Forms.Label
    Friend WithEvents TextService As System.Windows.Forms.TextBox
    Friend WithEvents LabService As System.Windows.Forms.Label
    Friend WithEvents TextMis As System.Windows.Forms.TextBox
    Friend WithEvents LabMis As System.Windows.Forms.Label
    Friend WithEvents TextTax As System.Windows.Forms.TextBox
    Friend WithEvents labtax As System.Windows.Forms.Label
    Friend WithEvents TextPhone As System.Windows.Forms.TextBox
    Friend WithEvents LabPhone As System.Windows.Forms.Label
    Friend WithEvents CustomerDataSet As HMS.CustomerDataSet
    Friend WithEvents CustBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustTableAdapter As HMS.CustomerDataSetTableAdapters.CustTableAdapter
    Friend WithEvents TextRoomno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LabFood As System.Windows.Forms.Label
    Friend WithEvents TextFood As System.Windows.Forms.TextBox
    Friend WithEvents DateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDProofDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneBillDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomChargesDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalBillDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeedbackDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox

End Class
