<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformationAnalysis_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label62 As System.Windows.Forms.Label
        Dim Label61 As System.Windows.Forms.Label
        Dim Label60 As System.Windows.Forms.Label
        Dim Label59 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformationAnalysis_Form))
        Me.MenuStrip_InformationMST2 = New System.Windows.Forms.MenuStrip()
        Me.InfoAnalyisi_LawExplanationMST2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoAnalysis_AnalysisJudicialMST2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoAnalysis_CountTokenEstimateMST2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoAnalysis_TashkeelTextMST2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoAnlysis_ReadMeMST2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.Information_Text = New System.Windows.Forms.RichTextBox()
        Me.HeaderText = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataSet1 = New fad5.DataSet1()
        Me.AIInformationBasicDefentionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AIInformationBasicDefentionTableAdapter = New fad5.DataSet1TableAdapters.AIInformationBasicDefentionTableAdapter()
        Me.AIInformation_MainID = New System.Windows.Forms.TextBox()
        Me.AIInformation_NumberOfTokensRemaining = New System.Windows.Forms.TextBox()
        Me.AIInformation_NumberOfTokensConsumed = New System.Windows.Forms.TextBox()
        Me.AIInformation_InitialNumberOfTolkensAllowed = New System.Windows.Forms.TextBox()
        Me.Result_Header = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Title_Text = New System.Windows.Forms.TextBox()
        Me.MenuStrip_InformationMST1 = New System.Windows.Forms.MenuStrip()
        Me.InfoAnalysis_ExitMST1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoAnalysis_ConsumerMST1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoAnalysis_RemainMST1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tem_FullAdressAreaAddress = New System.Windows.Forms.TextBox()
        Me.FullAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_FullAdressCityDes = New System.Windows.Forms.TextBox()
        Me.Tem_FullAdressGovDes = New System.Windows.Forms.TextBox()
        Me.Tem_FullAdressCountryDes = New System.Windows.Forms.TextBox()
        Me.Tem_FullAddresID_Area = New System.Windows.Forms.TextBox()
        Me.Tem_LawyerInfoLAssocID = New System.Windows.Forms.TextBox()
        Me.LawyerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_LawyerInfoGenderDes = New System.Windows.Forms.TextBox()
        Me.Tem_LawyerInfoFromUserIntID = New System.Windows.Forms.TextBox()
        Me.Tem_LawyerInfoOfficeID = New System.Windows.Forms.TextBox()
        Me.Tem_OfficeLawName = New System.Windows.Forms.TextBox()
        Me.LawyerOfficeInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_OfficeLawNotes = New System.Windows.Forms.TextBox()
        Me.Tem_OfficeLawMainID = New System.Windows.Forms.TextBox()
        Me.Tem_LawyerInfoNote = New System.Windows.Forms.TextBox()
        Me.Tem_LawyerInfoMainID = New System.Windows.Forms.TextBox()
        Me.Tem_JudCourtTypeNote = New System.Windows.Forms.TextBox()
        Me.JudiciaryCourtsTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_JudCourtTypeMainID = New System.Windows.Forms.TextBox()
        Me.Tem_JudTypesNote = New System.Windows.Forms.TextBox()
        Me.JudiciaryTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_JudTypesMainID = New System.Windows.Forms.TextBox()
        Me.Tem_JudBasicNote = New System.Windows.Forms.TextBox()
        Me.JudiciaryBasicsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_JudBasicMainID = New System.Windows.Forms.TextBox()
        Me.Tem_ClassRefNote = New System.Windows.Forms.TextBox()
        Me.ClassificationRefrenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_ClassRefMainID = New System.Windows.Forms.TextBox()
        Me.Tem_Filtersub2Note = New System.Windows.Forms.TextBox()
        Me.CriminalLawfilterSub2ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_Filtersub2MainID = New System.Windows.Forms.TextBox()
        Me.Tem_Filtersub1Note = New System.Windows.Forms.TextBox()
        Me.CriminalLawFilterSub1ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_Filtersub1MainID = New System.Windows.Forms.TextBox()
        Me.Tem_LawArticleNote = New System.Windows.Forms.TextBox()
        Me.CriminalLawArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_LawArticleMainID = New System.Windows.Forms.TextBox()
        Me.Tem_LawListNote = New System.Windows.Forms.TextBox()
        Me.LawListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_LawListMainID = New System.Windows.Forms.TextBox()
        Me.Tem_LegislationMainNote = New System.Windows.Forms.TextBox()
        Me.LegislationMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_LegislationMainMainID = New System.Windows.Forms.TextBox()
        Me.Tem_MainRefNote = New System.Windows.Forms.TextBox()
        Me.MainRefrencesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_MainRefMainID = New System.Windows.Forms.TextBox()
        Me.Tem_SL_DetailAddressBS0 = New System.Windows.Forms.TextBox()
        Me.ServiceLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_SL_FullAddressBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_SL_EmailBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_SL_WebsiteBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_SL_MobileBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_SL_FaxBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_SL_PhoneBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_SL_CorpRefClassBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_CountryName = New System.Windows.Forms.TextBox()
        Me.CAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tem_CountryID = New System.Windows.Forms.TextBox()
        Me.Tem_SL_NoteBS0 = New System.Windows.Forms.TextBox()
        Me.Tem_SL_MainIDBS0 = New System.Windows.Forms.TextBox()
        Me.Service_LocationTableAdapter = New fad5.DataSet1TableAdapters.Service_LocationTableAdapter()
        Me.C_AddressTableAdapter = New fad5.DataSet1TableAdapters.C_AddressTableAdapter()
        Me.Main_RefrencesTableAdapter = New fad5.DataSet1TableAdapters.Main_RefrencesTableAdapter()
        Me.Legislation_MainTableAdapter = New fad5.DataSet1TableAdapters.Legislation_MainTableAdapter()
        Me.Law_ListTableAdapter = New fad5.DataSet1TableAdapters.Law_ListTableAdapter()
        Me.Criminal_Law_ArticleTableAdapter = New fad5.DataSet1TableAdapters.Criminal_Law_ArticleTableAdapter()
        Me.Criminal_Law_Filter_Sub1_ArticleTableAdapter = New fad5.DataSet1TableAdapters.Criminal_Law_Filter_Sub1_ArticleTableAdapter()
        Me.Criminal_Law_filter_Sub2_ArticleTableAdapter = New fad5.DataSet1TableAdapters.Criminal_Law_filter_Sub2_ArticleTableAdapter()
        Me.Classification_RefrenceTableAdapter = New fad5.DataSet1TableAdapters.Classification_RefrenceTableAdapter()
        Me.Judiciary_BasicsTableAdapter = New fad5.DataSet1TableAdapters.Judiciary_BasicsTableAdapter()
        Me.Judiciary_TypesTableAdapter = New fad5.DataSet1TableAdapters.Judiciary_TypesTableAdapter()
        Me.Judiciary_CourtsTypesTableAdapter = New fad5.DataSet1TableAdapters.Judiciary_CourtsTypesTableAdapter()
        Me.LawyerInfoTableAdapter = New fad5.DataSet1TableAdapters.LawyerInfoTableAdapter()
        Me.PBox_LawyerPic = New System.Windows.Forms.PictureBox()
        Me.LawyerOfficeInfoTableAdapter = New fad5.DataSet1TableAdapters.LawyerOfficeInfoTableAdapter()
        Me.Full_AddressTableAdapter = New fad5.DataSet1TableAdapters.Full_AddressTableAdapter()
        Label62 = New System.Windows.Forms.Label()
        Label61 = New System.Windows.Forms.Label()
        Label60 = New System.Windows.Forms.Label()
        Label59 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Me.MenuStrip_InformationMST2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIInformationBasicDefentionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip_InformationMST1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FullAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LawyerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LawyerOfficeInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JudiciaryCourtsTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JudiciaryTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JudiciaryBasicsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassificationRefrenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriminalLawfilterSub2ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriminalLawFilterSub1ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriminalLawArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LawListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegislationMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainRefrencesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBox_LawyerPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label62
        '
        Label62.BackColor = System.Drawing.SystemColors.ActiveCaption
        Label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label62.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label62.ForeColor = System.Drawing.Color.MidnightBlue
        Label62.Location = New System.Drawing.Point(559, 221)
        Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label62.Name = "Label62"
        Label62.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label62.Size = New System.Drawing.Size(150, 23)
        Label62.TabIndex = 2571
        Label62.Text = "التسلسل"
        Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Label61.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label61.BackColor = System.Drawing.SystemColors.ActiveCaption
        Label61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label61.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label61.ForeColor = System.Drawing.Color.MidnightBlue
        Label61.Location = New System.Drawing.Point(-113, 291)
        Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label61.Name = "Label61"
        Label61.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label61.Size = New System.Drawing.Size(106, 23)
        Label61.TabIndex = 2568
        Label61.Text = "عدد الرموز المتبقي"
        Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Label60.BackColor = System.Drawing.SystemColors.ActiveCaption
        Label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label60.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label60.ForeColor = System.Drawing.Color.MidnightBlue
        Label60.Location = New System.Drawing.Point(594, 268)
        Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label60.Name = "Label60"
        Label60.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label60.Size = New System.Drawing.Size(115, 23)
        Label60.TabIndex = 2566
        Label60.Text = "عدد الرموز المستهلك"
        Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Label59.BackColor = System.Drawing.SystemColors.ActiveCaption
        Label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label59.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label59.ForeColor = System.Drawing.Color.MidnightBlue
        Label59.Location = New System.Drawing.Point(559, 245)
        Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label59.Name = "Label59"
        Label59.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label59.Size = New System.Drawing.Size(150, 23)
        Label59.TabIndex = 2565
        Label59.Text = "عدد الرموز الاولي المتاح"
        Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Label1.Location = New System.Drawing.Point(459, 7)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label1.Size = New System.Drawing.Size(150, 23)
        Label1.TabIndex = 2578
        Label1.Text = "ملف الشركات والمؤسسات"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Label2.Location = New System.Drawing.Point(618, 31)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label2.Size = New System.Drawing.Size(150, 23)
        Label2.TabIndex = 2581
        Label2.Text = "ملف الدول"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.MistyRose
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Label3.Location = New System.Drawing.Point(618, 54)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label3.Size = New System.Drawing.Size(150, 23)
        Label3.TabIndex = 2593
        Label3.Text = "ملف مرجعيات اماكن تقديم الخدمة"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.MistyRose
        Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Label4.Location = New System.Drawing.Point(618, 77)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label4.Size = New System.Drawing.Size(150, 23)
        Label4.TabIndex = 2596
        Label4.Text = "ملف أسماء التشريعات العامة"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.MistyRose
        Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Label5.Location = New System.Drawing.Point(359, 33)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label5.Size = New System.Drawing.Size(150, 23)
        Label5.TabIndex = 2599
        Label5.Text = "ملف إصدارات التشريعات"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Label6.BackColor = System.Drawing.Color.MistyRose
        Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Label6.Location = New System.Drawing.Point(359, 56)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label6.Size = New System.Drawing.Size(150, 23)
        Label6.TabIndex = 2602
        Label6.Text = "ملف مواد التشريع"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.BackColor = System.Drawing.Color.MistyRose
        Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Label7.Location = New System.Drawing.Point(359, 79)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label7.Size = New System.Drawing.Size(150, 23)
        Label7.TabIndex = 2605
        Label7.Text = "ملف فقرات مواد التشريع"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Label8.BackColor = System.Drawing.Color.MistyRose
        Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Label8.Location = New System.Drawing.Point(105, 33)
        Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label8.Size = New System.Drawing.Size(150, 23)
        Label8.TabIndex = 2608
        Label8.Text = "ملف بنود فقرات مواد التشريع"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.Color.MistyRose
        Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Label9.Location = New System.Drawing.Point(618, 100)
        Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label9.Size = New System.Drawing.Size(150, 23)
        Label9.TabIndex = 2611
        Label9.Text = "تصنيف مرجعية التشريعات"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Label10.BackColor = System.Drawing.Color.White
        Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Label10.Location = New System.Drawing.Point(618, 123)
        Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label10.Size = New System.Drawing.Size(150, 23)
        Label10.TabIndex = 2614
        Label10.Text = "أسس النظام القضائي"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Label11.BackColor = System.Drawing.Color.White
        Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Label11.Location = New System.Drawing.Point(359, 123)
        Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label11.Size = New System.Drawing.Size(150, 23)
        Label11.TabIndex = 2617
        Label11.Text = "أنواع النظام القضائي"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Label12.BackColor = System.Drawing.Color.White
        Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Label12.Location = New System.Drawing.Point(105, 123)
        Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label12.Size = New System.Drawing.Size(150, 23)
        Label12.TabIndex = 2620
        Label12.Text = "أسماء النظام القضائي"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Label13.BackColor = System.Drawing.Color.MistyRose
        Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Label13.Location = New System.Drawing.Point(618, 146)
        Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label13.Size = New System.Drawing.Size(150, 23)
        Label13.TabIndex = 2623
        Label13.Text = "ملف المحامين"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Label14.BackColor = System.Drawing.Color.MistyRose
        Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label14.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Label14.Location = New System.Drawing.Point(359, 146)
        Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label14.Size = New System.Drawing.Size(150, 23)
        Label14.TabIndex = 2626
        Label14.Text = "ملف مكاتب المحاماة"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Label15.BackColor = System.Drawing.Color.MistyRose
        Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label15.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Label15.Location = New System.Drawing.Point(105, 146)
        Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Label15.Size = New System.Drawing.Size(150, 23)
        Label15.TabIndex = 2634
        Label15.Text = "ملف العنوانين الكامل"
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip_InformationMST2
        '
        Me.MenuStrip_InformationMST2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuStrip_InformationMST2.AutoSize = False
        Me.MenuStrip_InformationMST2.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip_InformationMST2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip_InformationMST2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip_InformationMST2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip_InformationMST2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip_InformationMST2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoAnalyisi_LawExplanationMST2, Me.InfoAnalysis_AnalysisJudicialMST2, Me.InfoAnalysis_CountTokenEstimateMST2, Me.InfoAnalysis_TashkeelTextMST2, Me.InfoAnlysis_ReadMeMST2})
        Me.MenuStrip_InformationMST2.Location = New System.Drawing.Point(15, 248)
        Me.MenuStrip_InformationMST2.Name = "MenuStrip_InformationMST2"
        Me.MenuStrip_InformationMST2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip_InformationMST2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip_InformationMST2.Size = New System.Drawing.Size(158, 26)
        Me.MenuStrip_InformationMST2.TabIndex = 2556
        Me.MenuStrip_InformationMST2.Text = "MenuStrip1"
        '
        'InfoAnalyisi_LawExplanationMST2
        '
        Me.InfoAnalyisi_LawExplanationMST2.AutoSize = False
        Me.InfoAnalyisi_LawExplanationMST2.BackColor = System.Drawing.Color.Transparent
        Me.InfoAnalyisi_LawExplanationMST2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfoAnalyisi_LawExplanationMST2.Checked = True
        Me.InfoAnalyisi_LawExplanationMST2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InfoAnalyisi_LawExplanationMST2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InfoAnalyisi_LawExplanationMST2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.InfoAnalyisi_LawExplanationMST2.Image = CType(resources.GetObject("InfoAnalyisi_LawExplanationMST2.Image"), System.Drawing.Image)
        Me.InfoAnalyisi_LawExplanationMST2.MergeIndex = 1
        Me.InfoAnalyisi_LawExplanationMST2.Name = "InfoAnalyisi_LawExplanationMST2"
        Me.InfoAnalyisi_LawExplanationMST2.Size = New System.Drawing.Size(26, 26)
        Me.InfoAnalyisi_LawExplanationMST2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'InfoAnalysis_AnalysisJudicialMST2
        '
        Me.InfoAnalysis_AnalysisJudicialMST2.AutoSize = False
        Me.InfoAnalysis_AnalysisJudicialMST2.BackColor = System.Drawing.Color.Transparent
        Me.InfoAnalysis_AnalysisJudicialMST2.Checked = True
        Me.InfoAnalysis_AnalysisJudicialMST2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InfoAnalysis_AnalysisJudicialMST2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InfoAnalysis_AnalysisJudicialMST2.Image = CType(resources.GetObject("InfoAnalysis_AnalysisJudicialMST2.Image"), System.Drawing.Image)
        Me.InfoAnalysis_AnalysisJudicialMST2.MergeIndex = 1
        Me.InfoAnalysis_AnalysisJudicialMST2.Name = "InfoAnalysis_AnalysisJudicialMST2"
        Me.InfoAnalysis_AnalysisJudicialMST2.Size = New System.Drawing.Size(26, 26)
        Me.InfoAnalysis_AnalysisJudicialMST2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.InfoAnalysis_AnalysisJudicialMST2.Visible = False
        '
        'InfoAnalysis_CountTokenEstimateMST2
        '
        Me.InfoAnalysis_CountTokenEstimateMST2.AutoSize = False
        Me.InfoAnalysis_CountTokenEstimateMST2.BackColor = System.Drawing.Color.Transparent
        Me.InfoAnalysis_CountTokenEstimateMST2.Image = CType(resources.GetObject("InfoAnalysis_CountTokenEstimateMST2.Image"), System.Drawing.Image)
        Me.InfoAnalysis_CountTokenEstimateMST2.MergeIndex = 1
        Me.InfoAnalysis_CountTokenEstimateMST2.Name = "InfoAnalysis_CountTokenEstimateMST2"
        Me.InfoAnalysis_CountTokenEstimateMST2.Size = New System.Drawing.Size(26, 26)
        Me.InfoAnalysis_CountTokenEstimateMST2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.InfoAnalysis_CountTokenEstimateMST2.Visible = False
        '
        'InfoAnalysis_TashkeelTextMST2
        '
        Me.InfoAnalysis_TashkeelTextMST2.AutoSize = False
        Me.InfoAnalysis_TashkeelTextMST2.Image = CType(resources.GetObject("InfoAnalysis_TashkeelTextMST2.Image"), System.Drawing.Image)
        Me.InfoAnalysis_TashkeelTextMST2.MergeIndex = 1
        Me.InfoAnalysis_TashkeelTextMST2.Name = "InfoAnalysis_TashkeelTextMST2"
        Me.InfoAnalysis_TashkeelTextMST2.Size = New System.Drawing.Size(26, 26)
        Me.InfoAnalysis_TashkeelTextMST2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.InfoAnalysis_TashkeelTextMST2.Visible = False
        '
        'InfoAnlysis_ReadMeMST2
        '
        Me.InfoAnlysis_ReadMeMST2.Name = "InfoAnlysis_ReadMeMST2"
        Me.InfoAnlysis_ReadMeMST2.Size = New System.Drawing.Size(36, 22)
        Me.InfoAnlysis_ReadMeMST2.Text = "أقرأ"
        Me.InfoAnlysis_ReadMeMST2.Visible = False
        '
        'rtbOutput
        '
        Me.rtbOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbOutput.BackColor = System.Drawing.SystemColors.Window
        Me.rtbOutput.Font = New System.Drawing.Font("Arabic Typesetting", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOutput.ForeColor = System.Drawing.Color.MediumBlue
        Me.rtbOutput.Location = New System.Drawing.Point(8, 271)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.ReadOnly = True
        Me.rtbOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rtbOutput.Size = New System.Drawing.Size(779, 38)
        Me.rtbOutput.TabIndex = 2562
        Me.rtbOutput.Text = ""
        '
        'Information_Text
        '
        Me.Information_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Information_Text.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Information_Text.Location = New System.Drawing.Point(12, 67)
        Me.Information_Text.Name = "Information_Text"
        Me.Information_Text.ReadOnly = True
        Me.Information_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Information_Text.Size = New System.Drawing.Size(776, 178)
        Me.Information_Text.TabIndex = 2561
        Me.Information_Text.Text = ""
        '
        'HeaderText
        '
        Me.HeaderText.AllowDrop = True
        Me.HeaderText.BackColor = System.Drawing.SystemColors.Window
        Me.HeaderText.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderText.ForeColor = System.Drawing.Color.MidnightBlue
        Me.HeaderText.Location = New System.Drawing.Point(0, 0)
        Me.HeaderText.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.HeaderText.Multiline = True
        Me.HeaderText.Name = "HeaderText"
        Me.HeaderText.ReadOnly = True
        Me.HeaderText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.HeaderText.Size = New System.Drawing.Size(800, 30)
        Me.HeaderText.TabIndex = 2563
        Me.HeaderText.TabStop = False
        Me.HeaderText.Text = "شاشة تحليل الحكم؟؟؟؟؟ "
        Me.HeaderText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AIInformationBasicDefentionBindingSource
        '
        Me.AIInformationBasicDefentionBindingSource.DataMember = "AIInformationBasicDefention"
        Me.AIInformationBasicDefentionBindingSource.DataSource = Me.DataSet1
        '
        'AIInformationBasicDefentionTableAdapter
        '
        Me.AIInformationBasicDefentionTableAdapter.ClearBeforeFill = True
        '
        'AIInformation_MainID
        '
        Me.AIInformation_MainID.BackColor = System.Drawing.SystemColors.Control
        Me.AIInformation_MainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AIInformationBasicDefentionBindingSource, "AIInformation_MainID", True))
        Me.AIInformation_MainID.Enabled = False
        Me.AIInformation_MainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIInformation_MainID.Location = New System.Drawing.Point(466, 221)
        Me.AIInformation_MainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AIInformation_MainID.Name = "AIInformation_MainID"
        Me.AIInformation_MainID.ReadOnly = True
        Me.AIInformation_MainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AIInformation_MainID.Size = New System.Drawing.Size(89, 23)
        Me.AIInformation_MainID.TabIndex = 2570
        Me.AIInformation_MainID.TabStop = False
        '
        'AIInformation_NumberOfTokensRemaining
        '
        Me.AIInformation_NumberOfTokensRemaining.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AIInformation_NumberOfTokensRemaining.BackColor = System.Drawing.Color.Lavender
        Me.AIInformation_NumberOfTokensRemaining.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AIInformationBasicDefentionBindingSource, "AIInformation_NumberOfTokensRemaining", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.AIInformation_NumberOfTokensRemaining.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIInformation_NumberOfTokensRemaining.ForeColor = System.Drawing.Color.DarkRed
        Me.AIInformation_NumberOfTokensRemaining.Location = New System.Drawing.Point(-206, 291)
        Me.AIInformation_NumberOfTokensRemaining.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AIInformation_NumberOfTokensRemaining.Name = "AIInformation_NumberOfTokensRemaining"
        Me.AIInformation_NumberOfTokensRemaining.ReadOnly = True
        Me.AIInformation_NumberOfTokensRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AIInformation_NumberOfTokensRemaining.Size = New System.Drawing.Size(89, 23)
        Me.AIInformation_NumberOfTokensRemaining.TabIndex = 2569
        Me.AIInformation_NumberOfTokensRemaining.TabStop = False
        Me.AIInformation_NumberOfTokensRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AIInformation_NumberOfTokensConsumed
        '
        Me.AIInformation_NumberOfTokensConsumed.BackColor = System.Drawing.Color.Lavender
        Me.AIInformation_NumberOfTokensConsumed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AIInformationBasicDefentionBindingSource, "AIInformation_NumberOfTokensConsumed", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.AIInformation_NumberOfTokensConsumed.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIInformation_NumberOfTokensConsumed.ForeColor = System.Drawing.Color.DarkRed
        Me.AIInformation_NumberOfTokensConsumed.Location = New System.Drawing.Point(502, 268)
        Me.AIInformation_NumberOfTokensConsumed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AIInformation_NumberOfTokensConsumed.Name = "AIInformation_NumberOfTokensConsumed"
        Me.AIInformation_NumberOfTokensConsumed.ReadOnly = True
        Me.AIInformation_NumberOfTokensConsumed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AIInformation_NumberOfTokensConsumed.Size = New System.Drawing.Size(89, 23)
        Me.AIInformation_NumberOfTokensConsumed.TabIndex = 2567
        Me.AIInformation_NumberOfTokensConsumed.TabStop = False
        Me.AIInformation_NumberOfTokensConsumed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AIInformation_InitialNumberOfTolkensAllowed
        '
        Me.AIInformation_InitialNumberOfTolkensAllowed.BackColor = System.Drawing.SystemColors.Control
        Me.AIInformation_InitialNumberOfTolkensAllowed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AIInformationBasicDefentionBindingSource, "AIInformation_InitialNumberOfTolkensAllowed", True))
        Me.AIInformation_InitialNumberOfTolkensAllowed.Enabled = False
        Me.AIInformation_InitialNumberOfTolkensAllowed.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIInformation_InitialNumberOfTolkensAllowed.Location = New System.Drawing.Point(466, 245)
        Me.AIInformation_InitialNumberOfTolkensAllowed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AIInformation_InitialNumberOfTolkensAllowed.Name = "AIInformation_InitialNumberOfTolkensAllowed"
        Me.AIInformation_InitialNumberOfTolkensAllowed.ReadOnly = True
        Me.AIInformation_InitialNumberOfTolkensAllowed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AIInformation_InitialNumberOfTolkensAllowed.Size = New System.Drawing.Size(89, 23)
        Me.AIInformation_InitialNumberOfTolkensAllowed.TabIndex = 2564
        Me.AIInformation_InitialNumberOfTolkensAllowed.TabStop = False
        '
        'Result_Header
        '
        Me.Result_Header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Result_Header.BackColor = System.Drawing.Color.Lavender
        Me.Result_Header.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Result_Header.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Result_Header.ForeColor = System.Drawing.Color.MediumBlue
        Me.Result_Header.Location = New System.Drawing.Point(336, 252)
        Me.Result_Header.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Result_Header.Multiline = True
        Me.Result_Header.Name = "Result_Header"
        Me.Result_Header.ReadOnly = True
        Me.Result_Header.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Result_Header.Size = New System.Drawing.Size(452, 20)
        Me.Result_Header.TabIndex = 2572
        Me.Result_Header.TabStop = False
        Me.Result_Header.Text = "نتائج التحليل ??????"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(130, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2573
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Title_Text
        '
        Me.Title_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title_Text.BackColor = System.Drawing.Color.Lavender
        Me.Title_Text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Title_Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Title_Text.ForeColor = System.Drawing.Color.Black
        Me.Title_Text.Location = New System.Drawing.Point(357, 41)
        Me.Title_Text.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Title_Text.Multiline = True
        Me.Title_Text.Name = "Title_Text"
        Me.Title_Text.ReadOnly = True
        Me.Title_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Title_Text.Size = New System.Drawing.Size(431, 20)
        Me.Title_Text.TabIndex = 2574
        Me.Title_Text.TabStop = False
        Me.Title_Text.Text = "انا نبراس الذكي ؟؟؟؟"
        '
        'MenuStrip_InformationMST1
        '
        Me.MenuStrip_InformationMST1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuStrip_InformationMST1.AutoSize = False
        Me.MenuStrip_InformationMST1.BackColor = System.Drawing.Color.Lavender
        Me.MenuStrip_InformationMST1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip_InformationMST1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip_InformationMST1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip_InformationMST1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip_InformationMST1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoAnalysis_ExitMST1, Me.InfoAnalysis_ConsumerMST1, Me.InfoAnalysis_RemainMST1})
        Me.MenuStrip_InformationMST1.Location = New System.Drawing.Point(5, 39)
        Me.MenuStrip_InformationMST1.Name = "MenuStrip_InformationMST1"
        Me.MenuStrip_InformationMST1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip_InformationMST1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip_InformationMST1.Size = New System.Drawing.Size(208, 26)
        Me.MenuStrip_InformationMST1.TabIndex = 2575
        Me.MenuStrip_InformationMST1.Text = "MenuStrip1"
        '
        'InfoAnalysis_ExitMST1
        '
        Me.InfoAnalysis_ExitMST1.AutoSize = False
        Me.InfoAnalysis_ExitMST1.BackColor = System.Drawing.Color.Transparent
        Me.InfoAnalysis_ExitMST1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfoAnalysis_ExitMST1.Checked = True
        Me.InfoAnalysis_ExitMST1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InfoAnalysis_ExitMST1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InfoAnalysis_ExitMST1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.InfoAnalysis_ExitMST1.Image = CType(resources.GetObject("InfoAnalysis_ExitMST1.Image"), System.Drawing.Image)
        Me.InfoAnalysis_ExitMST1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InfoAnalysis_ExitMST1.MergeIndex = 1
        Me.InfoAnalysis_ExitMST1.Name = "InfoAnalysis_ExitMST1"
        Me.InfoAnalysis_ExitMST1.Size = New System.Drawing.Size(26, 26)
        Me.InfoAnalysis_ExitMST1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'InfoAnalysis_ConsumerMST1
        '
        Me.InfoAnalysis_ConsumerMST1.Name = "InfoAnalysis_ConsumerMST1"
        Me.InfoAnalysis_ConsumerMST1.Size = New System.Drawing.Size(62, 22)
        Me.InfoAnalysis_ConsumerMST1.Text = "المستهلك"
        '
        'InfoAnalysis_RemainMST1
        '
        Me.InfoAnalysis_RemainMST1.Name = "InfoAnalysis_RemainMST1"
        Me.InfoAnalysis_RemainMST1.Size = New System.Drawing.Size(53, 22)
        Me.InfoAnalysis_RemainMST1.Text = "المتبقي"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tem_FullAdressAreaAddress)
        Me.GroupBox1.Controls.Add(Me.Tem_FullAdressCityDes)
        Me.GroupBox1.Controls.Add(Me.Tem_FullAdressGovDes)
        Me.GroupBox1.Controls.Add(Me.Tem_FullAdressCountryDes)
        Me.GroupBox1.Controls.Add(Label15)
        Me.GroupBox1.Controls.Add(Me.Tem_FullAddresID_Area)
        Me.GroupBox1.Controls.Add(Me.Tem_LawyerInfoLAssocID)
        Me.GroupBox1.Controls.Add(Me.Tem_LawyerInfoGenderDes)
        Me.GroupBox1.Controls.Add(Me.Tem_LawyerInfoFromUserIntID)
        Me.GroupBox1.Controls.Add(Me.Tem_LawyerInfoOfficeID)
        Me.GroupBox1.Controls.Add(Me.Tem_OfficeLawName)
        Me.GroupBox1.Controls.Add(Me.Tem_OfficeLawNotes)
        Me.GroupBox1.Controls.Add(Label14)
        Me.GroupBox1.Controls.Add(Me.Tem_OfficeLawMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_LawyerInfoNote)
        Me.GroupBox1.Controls.Add(Label13)
        Me.GroupBox1.Controls.Add(Me.Tem_LawyerInfoMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_JudCourtTypeNote)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Me.Tem_JudCourtTypeMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_JudTypesNote)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.Tem_JudTypesMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_JudBasicNote)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.Tem_JudBasicMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_ClassRefNote)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Me.Tem_ClassRefMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_Filtersub2Note)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Me.Tem_Filtersub2MainID)
        Me.GroupBox1.Controls.Add(Me.Tem_Filtersub1Note)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.Tem_Filtersub1MainID)
        Me.GroupBox1.Controls.Add(Me.Tem_LawArticleNote)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.Tem_LawArticleMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_LawListNote)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.Tem_LawListMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_LegislationMainNote)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.Tem_LegislationMainMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_MainRefNote)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.Tem_MainRefMainID)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_DetailAddressBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_FullAddressBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_EmailBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_WebsiteBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_MobileBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_FaxBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_PhoneBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_CorpRefClassBS0)
        Me.GroupBox1.Controls.Add(Me.Tem_CountryName)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.Tem_CountryID)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_NoteBS0)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.Tem_SL_MainIDBS0)
        Me.GroupBox1.Controls.Add(Me.AIInformation_NumberOfTokensRemaining)
        Me.GroupBox1.Controls.Add(Label62)
        Me.GroupBox1.Controls.Add(Label61)
        Me.GroupBox1.Controls.Add(Me.AIInformation_InitialNumberOfTolkensAllowed)
        Me.GroupBox1.Controls.Add(Me.AIInformation_NumberOfTokensConsumed)
        Me.GroupBox1.Controls.Add(Label59)
        Me.GroupBox1.Controls.Add(Label60)
        Me.GroupBox1.Controls.Add(Me.AIInformation_MainID)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 347)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(10, 18)
        Me.GroupBox1.TabIndex = 2576
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "الحاضنة للمعلومات التي سوف يتم تخزينها لاخقا"
        '
        'Tem_FullAdressAreaAddress
        '
        Me.Tem_FullAdressAreaAddress.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_FullAdressAreaAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FullAddressBindingSource, "Area_Address", True))
        Me.Tem_FullAdressAreaAddress.Enabled = False
        Me.Tem_FullAdressAreaAddress.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_FullAdressAreaAddress.Location = New System.Drawing.Point(75, 146)
        Me.Tem_FullAdressAreaAddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_FullAdressAreaAddress.Name = "Tem_FullAdressAreaAddress"
        Me.Tem_FullAdressAreaAddress.ReadOnly = True
        Me.Tem_FullAdressAreaAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_FullAdressAreaAddress.Size = New System.Drawing.Size(16, 23)
        Me.Tem_FullAdressAreaAddress.TabIndex = 2638
        Me.Tem_FullAdressAreaAddress.TabStop = False
        '
        'FullAddressBindingSource
        '
        Me.FullAddressBindingSource.DataMember = "Full_Address"
        Me.FullAddressBindingSource.DataSource = Me.DataSet1
        '
        'Tem_FullAdressCityDes
        '
        Me.Tem_FullAdressCityDes.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_FullAdressCityDes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FullAddressBindingSource, "City_Des", True))
        Me.Tem_FullAdressCityDes.Enabled = False
        Me.Tem_FullAdressCityDes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_FullAdressCityDes.Location = New System.Drawing.Point(55, 146)
        Me.Tem_FullAdressCityDes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_FullAdressCityDes.Name = "Tem_FullAdressCityDes"
        Me.Tem_FullAdressCityDes.ReadOnly = True
        Me.Tem_FullAdressCityDes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_FullAdressCityDes.Size = New System.Drawing.Size(16, 23)
        Me.Tem_FullAdressCityDes.TabIndex = 2637
        Me.Tem_FullAdressCityDes.TabStop = False
        '
        'Tem_FullAdressGovDes
        '
        Me.Tem_FullAdressGovDes.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_FullAdressGovDes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FullAddressBindingSource, "Gov_Des", True))
        Me.Tem_FullAdressGovDes.Enabled = False
        Me.Tem_FullAdressGovDes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_FullAdressGovDes.Location = New System.Drawing.Point(35, 146)
        Me.Tem_FullAdressGovDes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_FullAdressGovDes.Name = "Tem_FullAdressGovDes"
        Me.Tem_FullAdressGovDes.ReadOnly = True
        Me.Tem_FullAdressGovDes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_FullAdressGovDes.Size = New System.Drawing.Size(16, 23)
        Me.Tem_FullAdressGovDes.TabIndex = 2636
        Me.Tem_FullAdressGovDes.TabStop = False
        '
        'Tem_FullAdressCountryDes
        '
        Me.Tem_FullAdressCountryDes.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_FullAdressCountryDes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FullAddressBindingSource, "Country_Des", True))
        Me.Tem_FullAdressCountryDes.Enabled = False
        Me.Tem_FullAdressCountryDes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_FullAdressCountryDes.Location = New System.Drawing.Point(17, 146)
        Me.Tem_FullAdressCountryDes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_FullAdressCountryDes.Name = "Tem_FullAdressCountryDes"
        Me.Tem_FullAdressCountryDes.ReadOnly = True
        Me.Tem_FullAdressCountryDes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_FullAdressCountryDes.Size = New System.Drawing.Size(16, 23)
        Me.Tem_FullAdressCountryDes.TabIndex = 2635
        Me.Tem_FullAdressCountryDes.TabStop = False
        '
        'Tem_FullAddresID_Area
        '
        Me.Tem_FullAddresID_Area.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_FullAddresID_Area.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FullAddressBindingSource, "ID_Area", True))
        Me.Tem_FullAddresID_Area.Enabled = False
        Me.Tem_FullAddresID_Area.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_FullAddresID_Area.Location = New System.Drawing.Point(1, 146)
        Me.Tem_FullAddresID_Area.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_FullAddresID_Area.Name = "Tem_FullAddresID_Area"
        Me.Tem_FullAddresID_Area.ReadOnly = True
        Me.Tem_FullAddresID_Area.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_FullAddresID_Area.Size = New System.Drawing.Size(16, 23)
        Me.Tem_FullAddresID_Area.TabIndex = 2633
        Me.Tem_FullAddresID_Area.TabStop = False
        '
        'Tem_LawyerInfoLAssocID
        '
        Me.Tem_LawyerInfoLAssocID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawyerInfoLAssocID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerInfoBindingSource, "LAssoc_ID", True))
        Me.Tem_LawyerInfoLAssocID.Enabled = False
        Me.Tem_LawyerInfoLAssocID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawyerInfoLAssocID.Location = New System.Drawing.Point(544, 146)
        Me.Tem_LawyerInfoLAssocID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawyerInfoLAssocID.Name = "Tem_LawyerInfoLAssocID"
        Me.Tem_LawyerInfoLAssocID.ReadOnly = True
        Me.Tem_LawyerInfoLAssocID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawyerInfoLAssocID.Size = New System.Drawing.Size(17, 23)
        Me.Tem_LawyerInfoLAssocID.TabIndex = 2632
        Me.Tem_LawyerInfoLAssocID.TabStop = False
        '
        'LawyerInfoBindingSource
        '
        Me.LawyerInfoBindingSource.DataMember = "LawyerInfo"
        Me.LawyerInfoBindingSource.DataSource = Me.DataSet1
        '
        'Tem_LawyerInfoGenderDes
        '
        Me.Tem_LawyerInfoGenderDes.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawyerInfoGenderDes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerInfoBindingSource, "Law_GenderDesCBox", True))
        Me.Tem_LawyerInfoGenderDes.Enabled = False
        Me.Tem_LawyerInfoGenderDes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawyerInfoGenderDes.Location = New System.Drawing.Point(578, 146)
        Me.Tem_LawyerInfoGenderDes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawyerInfoGenderDes.Name = "Tem_LawyerInfoGenderDes"
        Me.Tem_LawyerInfoGenderDes.ReadOnly = True
        Me.Tem_LawyerInfoGenderDes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawyerInfoGenderDes.Size = New System.Drawing.Size(16, 23)
        Me.Tem_LawyerInfoGenderDes.TabIndex = 2631
        Me.Tem_LawyerInfoGenderDes.TabStop = False
        '
        'Tem_LawyerInfoFromUserIntID
        '
        Me.Tem_LawyerInfoFromUserIntID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawyerInfoFromUserIntID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerInfoBindingSource, "Lawyer_FromUserIntID", True))
        Me.Tem_LawyerInfoFromUserIntID.Enabled = False
        Me.Tem_LawyerInfoFromUserIntID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawyerInfoFromUserIntID.Location = New System.Drawing.Point(562, 146)
        Me.Tem_LawyerInfoFromUserIntID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawyerInfoFromUserIntID.Name = "Tem_LawyerInfoFromUserIntID"
        Me.Tem_LawyerInfoFromUserIntID.ReadOnly = True
        Me.Tem_LawyerInfoFromUserIntID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawyerInfoFromUserIntID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_LawyerInfoFromUserIntID.TabIndex = 2630
        Me.Tem_LawyerInfoFromUserIntID.TabStop = False
        '
        'Tem_LawyerInfoOfficeID
        '
        Me.Tem_LawyerInfoOfficeID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawyerInfoOfficeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerInfoBindingSource, "LofficeID", True))
        Me.Tem_LawyerInfoOfficeID.Enabled = False
        Me.Tem_LawyerInfoOfficeID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawyerInfoOfficeID.Location = New System.Drawing.Point(598, 146)
        Me.Tem_LawyerInfoOfficeID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawyerInfoOfficeID.Name = "Tem_LawyerInfoOfficeID"
        Me.Tem_LawyerInfoOfficeID.ReadOnly = True
        Me.Tem_LawyerInfoOfficeID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawyerInfoOfficeID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_LawyerInfoOfficeID.TabIndex = 2629
        Me.Tem_LawyerInfoOfficeID.TabStop = False
        '
        'Tem_OfficeLawName
        '
        Me.Tem_OfficeLawName.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_OfficeLawName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerOfficeInfoBindingSource, "LOfficeName", True))
        Me.Tem_OfficeLawName.Enabled = False
        Me.Tem_OfficeLawName.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_OfficeLawName.Location = New System.Drawing.Point(341, 146)
        Me.Tem_OfficeLawName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_OfficeLawName.Name = "Tem_OfficeLawName"
        Me.Tem_OfficeLawName.ReadOnly = True
        Me.Tem_OfficeLawName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_OfficeLawName.Size = New System.Drawing.Size(16, 23)
        Me.Tem_OfficeLawName.TabIndex = 2628
        Me.Tem_OfficeLawName.TabStop = False
        '
        'LawyerOfficeInfoBindingSource
        '
        Me.LawyerOfficeInfoBindingSource.DataMember = "LawyerOfficeInfo"
        Me.LawyerOfficeInfoBindingSource.DataSource = Me.DataSet1
        '
        'Tem_OfficeLawNotes
        '
        Me.Tem_OfficeLawNotes.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_OfficeLawNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerOfficeInfoBindingSource, "LONotes", True))
        Me.Tem_OfficeLawNotes.Enabled = False
        Me.Tem_OfficeLawNotes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_OfficeLawNotes.Location = New System.Drawing.Point(269, 146)
        Me.Tem_OfficeLawNotes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_OfficeLawNotes.Name = "Tem_OfficeLawNotes"
        Me.Tem_OfficeLawNotes.ReadOnly = True
        Me.Tem_OfficeLawNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_OfficeLawNotes.Size = New System.Drawing.Size(72, 23)
        Me.Tem_OfficeLawNotes.TabIndex = 2627
        Me.Tem_OfficeLawNotes.TabStop = False
        '
        'Tem_OfficeLawMainID
        '
        Me.Tem_OfficeLawMainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_OfficeLawMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerOfficeInfoBindingSource, "ID", True))
        Me.Tem_OfficeLawMainID.Enabled = False
        Me.Tem_OfficeLawMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_OfficeLawMainID.Location = New System.Drawing.Point(253, 146)
        Me.Tem_OfficeLawMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_OfficeLawMainID.Name = "Tem_OfficeLawMainID"
        Me.Tem_OfficeLawMainID.ReadOnly = True
        Me.Tem_OfficeLawMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_OfficeLawMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_OfficeLawMainID.TabIndex = 2625
        Me.Tem_OfficeLawMainID.TabStop = False
        '
        'Tem_LawyerInfoNote
        '
        Me.Tem_LawyerInfoNote.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawyerInfoNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerInfoBindingSource, "LNote", True))
        Me.Tem_LawyerInfoNote.Enabled = False
        Me.Tem_LawyerInfoNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawyerInfoNote.Location = New System.Drawing.Point(528, 146)
        Me.Tem_LawyerInfoNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawyerInfoNote.Name = "Tem_LawyerInfoNote"
        Me.Tem_LawyerInfoNote.ReadOnly = True
        Me.Tem_LawyerInfoNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawyerInfoNote.Size = New System.Drawing.Size(17, 23)
        Me.Tem_LawyerInfoNote.TabIndex = 2624
        Me.Tem_LawyerInfoNote.TabStop = False
        '
        'Tem_LawyerInfoMainID
        '
        Me.Tem_LawyerInfoMainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawyerInfoMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawyerInfoBindingSource, "ID", True))
        Me.Tem_LawyerInfoMainID.Enabled = False
        Me.Tem_LawyerInfoMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawyerInfoMainID.Location = New System.Drawing.Point(512, 146)
        Me.Tem_LawyerInfoMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawyerInfoMainID.Name = "Tem_LawyerInfoMainID"
        Me.Tem_LawyerInfoMainID.ReadOnly = True
        Me.Tem_LawyerInfoMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawyerInfoMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_LawyerInfoMainID.TabIndex = 2622
        Me.Tem_LawyerInfoMainID.TabStop = False
        '
        'Tem_JudCourtTypeNote
        '
        Me.Tem_JudCourtTypeNote.BackColor = System.Drawing.Color.White
        Me.Tem_JudCourtTypeNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JudiciaryCourtsTypesBindingSource, "JSCourttypes_Notes", True))
        Me.Tem_JudCourtTypeNote.Enabled = False
        Me.Tem_JudCourtTypeNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_JudCourtTypeNote.Location = New System.Drawing.Point(17, 123)
        Me.Tem_JudCourtTypeNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_JudCourtTypeNote.Name = "Tem_JudCourtTypeNote"
        Me.Tem_JudCourtTypeNote.ReadOnly = True
        Me.Tem_JudCourtTypeNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_JudCourtTypeNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_JudCourtTypeNote.TabIndex = 2621
        Me.Tem_JudCourtTypeNote.TabStop = False
        '
        'JudiciaryCourtsTypesBindingSource
        '
        Me.JudiciaryCourtsTypesBindingSource.DataMember = "Judiciary_CourtsTypes"
        Me.JudiciaryCourtsTypesBindingSource.DataSource = Me.DataSet1
        '
        'Tem_JudCourtTypeMainID
        '
        Me.Tem_JudCourtTypeMainID.BackColor = System.Drawing.Color.White
        Me.Tem_JudCourtTypeMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JudiciaryCourtsTypesBindingSource, "ID", True))
        Me.Tem_JudCourtTypeMainID.Enabled = False
        Me.Tem_JudCourtTypeMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_JudCourtTypeMainID.Location = New System.Drawing.Point(1, 123)
        Me.Tem_JudCourtTypeMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_JudCourtTypeMainID.Name = "Tem_JudCourtTypeMainID"
        Me.Tem_JudCourtTypeMainID.ReadOnly = True
        Me.Tem_JudCourtTypeMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_JudCourtTypeMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_JudCourtTypeMainID.TabIndex = 2619
        Me.Tem_JudCourtTypeMainID.TabStop = False
        '
        'Tem_JudTypesNote
        '
        Me.Tem_JudTypesNote.BackColor = System.Drawing.Color.White
        Me.Tem_JudTypesNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JudiciaryTypesBindingSource, "JudType_Note", True))
        Me.Tem_JudTypesNote.Enabled = False
        Me.Tem_JudTypesNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_JudTypesNote.Location = New System.Drawing.Point(271, 123)
        Me.Tem_JudTypesNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_JudTypesNote.Name = "Tem_JudTypesNote"
        Me.Tem_JudTypesNote.ReadOnly = True
        Me.Tem_JudTypesNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_JudTypesNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_JudTypesNote.TabIndex = 2618
        Me.Tem_JudTypesNote.TabStop = False
        '
        'JudiciaryTypesBindingSource
        '
        Me.JudiciaryTypesBindingSource.DataMember = "Judiciary_Types"
        Me.JudiciaryTypesBindingSource.DataSource = Me.DataSet1
        '
        'Tem_JudTypesMainID
        '
        Me.Tem_JudTypesMainID.BackColor = System.Drawing.Color.White
        Me.Tem_JudTypesMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JudiciaryTypesBindingSource, "JudType_ID", True))
        Me.Tem_JudTypesMainID.Enabled = False
        Me.Tem_JudTypesMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_JudTypesMainID.Location = New System.Drawing.Point(255, 123)
        Me.Tem_JudTypesMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_JudTypesMainID.Name = "Tem_JudTypesMainID"
        Me.Tem_JudTypesMainID.ReadOnly = True
        Me.Tem_JudTypesMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_JudTypesMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_JudTypesMainID.TabIndex = 2616
        Me.Tem_JudTypesMainID.TabStop = False
        '
        'Tem_JudBasicNote
        '
        Me.Tem_JudBasicNote.BackColor = System.Drawing.Color.White
        Me.Tem_JudBasicNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JudiciaryBasicsBindingSource, "Judiciary_Notes", True))
        Me.Tem_JudBasicNote.Enabled = False
        Me.Tem_JudBasicNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_JudBasicNote.Location = New System.Drawing.Point(528, 123)
        Me.Tem_JudBasicNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_JudBasicNote.Name = "Tem_JudBasicNote"
        Me.Tem_JudBasicNote.ReadOnly = True
        Me.Tem_JudBasicNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_JudBasicNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_JudBasicNote.TabIndex = 2615
        Me.Tem_JudBasicNote.TabStop = False
        '
        'JudiciaryBasicsBindingSource
        '
        Me.JudiciaryBasicsBindingSource.DataMember = "Judiciary_Basics"
        Me.JudiciaryBasicsBindingSource.DataSource = Me.DataSet1
        '
        'Tem_JudBasicMainID
        '
        Me.Tem_JudBasicMainID.BackColor = System.Drawing.Color.White
        Me.Tem_JudBasicMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JudiciaryBasicsBindingSource, "ID", True))
        Me.Tem_JudBasicMainID.Enabled = False
        Me.Tem_JudBasicMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_JudBasicMainID.Location = New System.Drawing.Point(512, 123)
        Me.Tem_JudBasicMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_JudBasicMainID.Name = "Tem_JudBasicMainID"
        Me.Tem_JudBasicMainID.ReadOnly = True
        Me.Tem_JudBasicMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_JudBasicMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_JudBasicMainID.TabIndex = 2613
        Me.Tem_JudBasicMainID.TabStop = False
        '
        'Tem_ClassRefNote
        '
        Me.Tem_ClassRefNote.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_ClassRefNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassificationRefrenceBindingSource, "Class_Note", True))
        Me.Tem_ClassRefNote.Enabled = False
        Me.Tem_ClassRefNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_ClassRefNote.Location = New System.Drawing.Point(528, 100)
        Me.Tem_ClassRefNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_ClassRefNote.Name = "Tem_ClassRefNote"
        Me.Tem_ClassRefNote.ReadOnly = True
        Me.Tem_ClassRefNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_ClassRefNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_ClassRefNote.TabIndex = 2612
        Me.Tem_ClassRefNote.TabStop = False
        '
        'ClassificationRefrenceBindingSource
        '
        Me.ClassificationRefrenceBindingSource.DataMember = "Classification_Refrence"
        Me.ClassificationRefrenceBindingSource.DataSource = Me.DataSet1
        '
        'Tem_ClassRefMainID
        '
        Me.Tem_ClassRefMainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_ClassRefMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassificationRefrenceBindingSource, "Class_ID", True))
        Me.Tem_ClassRefMainID.Enabled = False
        Me.Tem_ClassRefMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_ClassRefMainID.Location = New System.Drawing.Point(512, 100)
        Me.Tem_ClassRefMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_ClassRefMainID.Name = "Tem_ClassRefMainID"
        Me.Tem_ClassRefMainID.ReadOnly = True
        Me.Tem_ClassRefMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_ClassRefMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_ClassRefMainID.TabIndex = 2610
        Me.Tem_ClassRefMainID.TabStop = False
        '
        'Tem_Filtersub2Note
        '
        Me.Tem_Filtersub2Note.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_Filtersub2Note.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriminalLawfilterSub2ArticleBindingSource, "Filtersub2_Note", True))
        Me.Tem_Filtersub2Note.Enabled = False
        Me.Tem_Filtersub2Note.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_Filtersub2Note.Location = New System.Drawing.Point(17, 33)
        Me.Tem_Filtersub2Note.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_Filtersub2Note.Name = "Tem_Filtersub2Note"
        Me.Tem_Filtersub2Note.ReadOnly = True
        Me.Tem_Filtersub2Note.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_Filtersub2Note.Size = New System.Drawing.Size(86, 23)
        Me.Tem_Filtersub2Note.TabIndex = 2609
        Me.Tem_Filtersub2Note.TabStop = False
        '
        'CriminalLawfilterSub2ArticleBindingSource
        '
        Me.CriminalLawfilterSub2ArticleBindingSource.DataMember = "Criminal_Law_filter_Sub2_Article"
        Me.CriminalLawfilterSub2ArticleBindingSource.DataSource = Me.DataSet1
        '
        'Tem_Filtersub2MainID
        '
        Me.Tem_Filtersub2MainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_Filtersub2MainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriminalLawfilterSub2ArticleBindingSource, "Filtersub2_ID", True))
        Me.Tem_Filtersub2MainID.Enabled = False
        Me.Tem_Filtersub2MainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_Filtersub2MainID.Location = New System.Drawing.Point(1, 33)
        Me.Tem_Filtersub2MainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_Filtersub2MainID.Name = "Tem_Filtersub2MainID"
        Me.Tem_Filtersub2MainID.ReadOnly = True
        Me.Tem_Filtersub2MainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_Filtersub2MainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_Filtersub2MainID.TabIndex = 2607
        Me.Tem_Filtersub2MainID.TabStop = False
        '
        'Tem_Filtersub1Note
        '
        Me.Tem_Filtersub1Note.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_Filtersub1Note.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriminalLawFilterSub1ArticleBindingSource, "Filtersub1_Note", True))
        Me.Tem_Filtersub1Note.Enabled = False
        Me.Tem_Filtersub1Note.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_Filtersub1Note.Location = New System.Drawing.Point(271, 79)
        Me.Tem_Filtersub1Note.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_Filtersub1Note.Name = "Tem_Filtersub1Note"
        Me.Tem_Filtersub1Note.ReadOnly = True
        Me.Tem_Filtersub1Note.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_Filtersub1Note.Size = New System.Drawing.Size(86, 23)
        Me.Tem_Filtersub1Note.TabIndex = 2606
        Me.Tem_Filtersub1Note.TabStop = False
        '
        'CriminalLawFilterSub1ArticleBindingSource
        '
        Me.CriminalLawFilterSub1ArticleBindingSource.DataMember = "Criminal_Law_Filter_Sub1_Article"
        Me.CriminalLawFilterSub1ArticleBindingSource.DataSource = Me.DataSet1
        '
        'Tem_Filtersub1MainID
        '
        Me.Tem_Filtersub1MainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_Filtersub1MainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriminalLawFilterSub1ArticleBindingSource, "Filtersub1_ID", True))
        Me.Tem_Filtersub1MainID.Enabled = False
        Me.Tem_Filtersub1MainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_Filtersub1MainID.Location = New System.Drawing.Point(255, 79)
        Me.Tem_Filtersub1MainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_Filtersub1MainID.Name = "Tem_Filtersub1MainID"
        Me.Tem_Filtersub1MainID.ReadOnly = True
        Me.Tem_Filtersub1MainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_Filtersub1MainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_Filtersub1MainID.TabIndex = 2604
        Me.Tem_Filtersub1MainID.TabStop = False
        '
        'Tem_LawArticleNote
        '
        Me.Tem_LawArticleNote.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawArticleNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriminalLawArticleBindingSource, "Article_Note", True))
        Me.Tem_LawArticleNote.Enabled = False
        Me.Tem_LawArticleNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawArticleNote.Location = New System.Drawing.Point(271, 56)
        Me.Tem_LawArticleNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawArticleNote.Name = "Tem_LawArticleNote"
        Me.Tem_LawArticleNote.ReadOnly = True
        Me.Tem_LawArticleNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawArticleNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_LawArticleNote.TabIndex = 2603
        Me.Tem_LawArticleNote.TabStop = False
        '
        'CriminalLawArticleBindingSource
        '
        Me.CriminalLawArticleBindingSource.DataMember = "Criminal_Law_Article"
        Me.CriminalLawArticleBindingSource.DataSource = Me.DataSet1
        '
        'Tem_LawArticleMainID
        '
        Me.Tem_LawArticleMainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawArticleMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CriminalLawArticleBindingSource, "ArticleID", True))
        Me.Tem_LawArticleMainID.Enabled = False
        Me.Tem_LawArticleMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawArticleMainID.Location = New System.Drawing.Point(255, 56)
        Me.Tem_LawArticleMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawArticleMainID.Name = "Tem_LawArticleMainID"
        Me.Tem_LawArticleMainID.ReadOnly = True
        Me.Tem_LawArticleMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawArticleMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_LawArticleMainID.TabIndex = 2601
        Me.Tem_LawArticleMainID.TabStop = False
        '
        'Tem_LawListNote
        '
        Me.Tem_LawListNote.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawListNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawListBindingSource, "Law_Note", True))
        Me.Tem_LawListNote.Enabled = False
        Me.Tem_LawListNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawListNote.Location = New System.Drawing.Point(271, 33)
        Me.Tem_LawListNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawListNote.Name = "Tem_LawListNote"
        Me.Tem_LawListNote.ReadOnly = True
        Me.Tem_LawListNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawListNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_LawListNote.TabIndex = 2600
        Me.Tem_LawListNote.TabStop = False
        '
        'LawListBindingSource
        '
        Me.LawListBindingSource.DataMember = "Law_List"
        Me.LawListBindingSource.DataSource = Me.DataSet1
        '
        'Tem_LawListMainID
        '
        Me.Tem_LawListMainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LawListMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LawListBindingSource, "ID", True))
        Me.Tem_LawListMainID.Enabled = False
        Me.Tem_LawListMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LawListMainID.Location = New System.Drawing.Point(255, 33)
        Me.Tem_LawListMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LawListMainID.Name = "Tem_LawListMainID"
        Me.Tem_LawListMainID.ReadOnly = True
        Me.Tem_LawListMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LawListMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_LawListMainID.TabIndex = 2598
        Me.Tem_LawListMainID.TabStop = False
        '
        'Tem_LegislationMainNote
        '
        Me.Tem_LegislationMainNote.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LegislationMainNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LegislationMainBindingSource, "Legislation_Note", True))
        Me.Tem_LegislationMainNote.Enabled = False
        Me.Tem_LegislationMainNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LegislationMainNote.Location = New System.Drawing.Point(528, 77)
        Me.Tem_LegislationMainNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LegislationMainNote.Name = "Tem_LegislationMainNote"
        Me.Tem_LegislationMainNote.ReadOnly = True
        Me.Tem_LegislationMainNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LegislationMainNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_LegislationMainNote.TabIndex = 2597
        Me.Tem_LegislationMainNote.TabStop = False
        '
        'LegislationMainBindingSource
        '
        Me.LegislationMainBindingSource.DataMember = "Legislation_Main"
        Me.LegislationMainBindingSource.DataSource = Me.DataSet1
        '
        'Tem_LegislationMainMainID
        '
        Me.Tem_LegislationMainMainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_LegislationMainMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LegislationMainBindingSource, "Legislation_ID", True))
        Me.Tem_LegislationMainMainID.Enabled = False
        Me.Tem_LegislationMainMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_LegislationMainMainID.Location = New System.Drawing.Point(512, 77)
        Me.Tem_LegislationMainMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_LegislationMainMainID.Name = "Tem_LegislationMainMainID"
        Me.Tem_LegislationMainMainID.ReadOnly = True
        Me.Tem_LegislationMainMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_LegislationMainMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_LegislationMainMainID.TabIndex = 2595
        Me.Tem_LegislationMainMainID.TabStop = False
        '
        'Tem_MainRefNote
        '
        Me.Tem_MainRefNote.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_MainRefNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainRefrencesBindingSource, "Ref_Note", True))
        Me.Tem_MainRefNote.Enabled = False
        Me.Tem_MainRefNote.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_MainRefNote.Location = New System.Drawing.Point(528, 54)
        Me.Tem_MainRefNote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_MainRefNote.Name = "Tem_MainRefNote"
        Me.Tem_MainRefNote.ReadOnly = True
        Me.Tem_MainRefNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_MainRefNote.Size = New System.Drawing.Size(86, 23)
        Me.Tem_MainRefNote.TabIndex = 2594
        Me.Tem_MainRefNote.TabStop = False
        '
        'MainRefrencesBindingSource
        '
        Me.MainRefrencesBindingSource.DataMember = "Main_Refrences"
        Me.MainRefrencesBindingSource.DataSource = Me.DataSet1
        '
        'Tem_MainRefMainID
        '
        Me.Tem_MainRefMainID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_MainRefMainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MainRefrencesBindingSource, "Ref_ID", True))
        Me.Tem_MainRefMainID.Enabled = False
        Me.Tem_MainRefMainID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_MainRefMainID.Location = New System.Drawing.Point(512, 54)
        Me.Tem_MainRefMainID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_MainRefMainID.Name = "Tem_MainRefMainID"
        Me.Tem_MainRefMainID.ReadOnly = True
        Me.Tem_MainRefMainID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_MainRefMainID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_MainRefMainID.TabIndex = 2592
        Me.Tem_MainRefMainID.TabStop = False
        '
        'Tem_SL_DetailAddressBS0
        '
        Me.Tem_SL_DetailAddressBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_DetailAddressBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Detail_address", True))
        Me.Tem_SL_DetailAddressBS0.Enabled = False
        Me.Tem_SL_DetailAddressBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_DetailAddressBS0.Location = New System.Drawing.Point(439, 7)
        Me.Tem_SL_DetailAddressBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_DetailAddressBS0.Name = "Tem_SL_DetailAddressBS0"
        Me.Tem_SL_DetailAddressBS0.ReadOnly = True
        Me.Tem_SL_DetailAddressBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_DetailAddressBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_DetailAddressBS0.TabIndex = 2591
        Me.Tem_SL_DetailAddressBS0.TabStop = False
        '
        'ServiceLocationBindingSource
        '
        Me.ServiceLocationBindingSource.DataMember = "Service_Location"
        Me.ServiceLocationBindingSource.DataSource = Me.DataSet1
        '
        'Tem_SL_FullAddressBS0
        '
        Me.Tem_SL_FullAddressBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_FullAddressBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Full_Address", True))
        Me.Tem_SL_FullAddressBS0.Enabled = False
        Me.Tem_SL_FullAddressBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_FullAddressBS0.Location = New System.Drawing.Point(423, 7)
        Me.Tem_SL_FullAddressBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_FullAddressBS0.Name = "Tem_SL_FullAddressBS0"
        Me.Tem_SL_FullAddressBS0.ReadOnly = True
        Me.Tem_SL_FullAddressBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_FullAddressBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_FullAddressBS0.TabIndex = 2589
        Me.Tem_SL_FullAddressBS0.TabStop = False
        '
        'Tem_SL_EmailBS0
        '
        Me.Tem_SL_EmailBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_EmailBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Email", True))
        Me.Tem_SL_EmailBS0.Enabled = False
        Me.Tem_SL_EmailBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_EmailBS0.Location = New System.Drawing.Point(407, 7)
        Me.Tem_SL_EmailBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_EmailBS0.Name = "Tem_SL_EmailBS0"
        Me.Tem_SL_EmailBS0.ReadOnly = True
        Me.Tem_SL_EmailBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_EmailBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_EmailBS0.TabIndex = 2588
        Me.Tem_SL_EmailBS0.TabStop = False
        '
        'Tem_SL_WebsiteBS0
        '
        Me.Tem_SL_WebsiteBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_WebsiteBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Website", True))
        Me.Tem_SL_WebsiteBS0.Enabled = False
        Me.Tem_SL_WebsiteBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_WebsiteBS0.Location = New System.Drawing.Point(391, 7)
        Me.Tem_SL_WebsiteBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_WebsiteBS0.Name = "Tem_SL_WebsiteBS0"
        Me.Tem_SL_WebsiteBS0.ReadOnly = True
        Me.Tem_SL_WebsiteBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_WebsiteBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_WebsiteBS0.TabIndex = 2587
        Me.Tem_SL_WebsiteBS0.TabStop = False
        '
        'Tem_SL_MobileBS0
        '
        Me.Tem_SL_MobileBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_MobileBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Mobile", True))
        Me.Tem_SL_MobileBS0.Enabled = False
        Me.Tem_SL_MobileBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_MobileBS0.Location = New System.Drawing.Point(375, 7)
        Me.Tem_SL_MobileBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_MobileBS0.Name = "Tem_SL_MobileBS0"
        Me.Tem_SL_MobileBS0.ReadOnly = True
        Me.Tem_SL_MobileBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_MobileBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_MobileBS0.TabIndex = 2586
        Me.Tem_SL_MobileBS0.TabStop = False
        '
        'Tem_SL_FaxBS0
        '
        Me.Tem_SL_FaxBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_FaxBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Fax", True))
        Me.Tem_SL_FaxBS0.Enabled = False
        Me.Tem_SL_FaxBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_FaxBS0.Location = New System.Drawing.Point(359, 7)
        Me.Tem_SL_FaxBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_FaxBS0.Name = "Tem_SL_FaxBS0"
        Me.Tem_SL_FaxBS0.ReadOnly = True
        Me.Tem_SL_FaxBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_FaxBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_FaxBS0.TabIndex = 2585
        Me.Tem_SL_FaxBS0.TabStop = False
        '
        'Tem_SL_PhoneBS0
        '
        Me.Tem_SL_PhoneBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_PhoneBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Phone", True))
        Me.Tem_SL_PhoneBS0.Enabled = False
        Me.Tem_SL_PhoneBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_PhoneBS0.Location = New System.Drawing.Point(343, 7)
        Me.Tem_SL_PhoneBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_PhoneBS0.Name = "Tem_SL_PhoneBS0"
        Me.Tem_SL_PhoneBS0.ReadOnly = True
        Me.Tem_SL_PhoneBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_PhoneBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_PhoneBS0.TabIndex = 2584
        Me.Tem_SL_PhoneBS0.TabStop = False
        '
        'Tem_SL_CorpRefClassBS0
        '
        Me.Tem_SL_CorpRefClassBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_CorpRefClassBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Corp_RefClass", True))
        Me.Tem_SL_CorpRefClassBS0.Enabled = False
        Me.Tem_SL_CorpRefClassBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_CorpRefClassBS0.Location = New System.Drawing.Point(327, 7)
        Me.Tem_SL_CorpRefClassBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_CorpRefClassBS0.Name = "Tem_SL_CorpRefClassBS0"
        Me.Tem_SL_CorpRefClassBS0.ReadOnly = True
        Me.Tem_SL_CorpRefClassBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_CorpRefClassBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_CorpRefClassBS0.TabIndex = 2583
        Me.Tem_SL_CorpRefClassBS0.TabStop = False
        '
        'Tem_CountryName
        '
        Me.Tem_CountryName.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_CountryName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAddressBindingSource, "Country_Des", True))
        Me.Tem_CountryName.Enabled = False
        Me.Tem_CountryName.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_CountryName.Location = New System.Drawing.Point(528, 31)
        Me.Tem_CountryName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_CountryName.Name = "Tem_CountryName"
        Me.Tem_CountryName.ReadOnly = True
        Me.Tem_CountryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_CountryName.Size = New System.Drawing.Size(86, 23)
        Me.Tem_CountryName.TabIndex = 2582
        Me.Tem_CountryName.TabStop = False
        '
        'CAddressBindingSource
        '
        Me.CAddressBindingSource.DataMember = "C_Address"
        Me.CAddressBindingSource.DataSource = Me.DataSet1
        '
        'Tem_CountryID
        '
        Me.Tem_CountryID.BackColor = System.Drawing.Color.MistyRose
        Me.Tem_CountryID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAddressBindingSource, "ID_Country", True))
        Me.Tem_CountryID.Enabled = False
        Me.Tem_CountryID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_CountryID.Location = New System.Drawing.Point(512, 31)
        Me.Tem_CountryID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_CountryID.Name = "Tem_CountryID"
        Me.Tem_CountryID.ReadOnly = True
        Me.Tem_CountryID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_CountryID.Size = New System.Drawing.Size(16, 23)
        Me.Tem_CountryID.TabIndex = 2580
        Me.Tem_CountryID.TabStop = False
        '
        'Tem_SL_NoteBS0
        '
        Me.Tem_SL_NoteBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_NoteBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_Note", True))
        Me.Tem_SL_NoteBS0.Enabled = False
        Me.Tem_SL_NoteBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_NoteBS0.Location = New System.Drawing.Point(241, 7)
        Me.Tem_SL_NoteBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_NoteBS0.Name = "Tem_SL_NoteBS0"
        Me.Tem_SL_NoteBS0.ReadOnly = True
        Me.Tem_SL_NoteBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_NoteBS0.Size = New System.Drawing.Size(86, 23)
        Me.Tem_SL_NoteBS0.TabIndex = 2579
        Me.Tem_SL_NoteBS0.TabStop = False
        '
        'Tem_SL_MainIDBS0
        '
        Me.Tem_SL_MainIDBS0.BackColor = System.Drawing.SystemColors.Control
        Me.Tem_SL_MainIDBS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiceLocationBindingSource, "SL_ID", True))
        Me.Tem_SL_MainIDBS0.Enabled = False
        Me.Tem_SL_MainIDBS0.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tem_SL_MainIDBS0.Location = New System.Drawing.Point(225, 7)
        Me.Tem_SL_MainIDBS0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Tem_SL_MainIDBS0.Name = "Tem_SL_MainIDBS0"
        Me.Tem_SL_MainIDBS0.ReadOnly = True
        Me.Tem_SL_MainIDBS0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tem_SL_MainIDBS0.Size = New System.Drawing.Size(16, 23)
        Me.Tem_SL_MainIDBS0.TabIndex = 2577
        Me.Tem_SL_MainIDBS0.TabStop = False
        '
        'Service_LocationTableAdapter
        '
        Me.Service_LocationTableAdapter.ClearBeforeFill = True
        '
        'C_AddressTableAdapter
        '
        Me.C_AddressTableAdapter.ClearBeforeFill = True
        '
        'Main_RefrencesTableAdapter
        '
        Me.Main_RefrencesTableAdapter.ClearBeforeFill = True
        '
        'Legislation_MainTableAdapter
        '
        Me.Legislation_MainTableAdapter.ClearBeforeFill = True
        '
        'Law_ListTableAdapter
        '
        Me.Law_ListTableAdapter.ClearBeforeFill = True
        '
        'Criminal_Law_ArticleTableAdapter
        '
        Me.Criminal_Law_ArticleTableAdapter.ClearBeforeFill = True
        '
        'Criminal_Law_Filter_Sub1_ArticleTableAdapter
        '
        Me.Criminal_Law_Filter_Sub1_ArticleTableAdapter.ClearBeforeFill = True
        '
        'Criminal_Law_filter_Sub2_ArticleTableAdapter
        '
        Me.Criminal_Law_filter_Sub2_ArticleTableAdapter.ClearBeforeFill = True
        '
        'Classification_RefrenceTableAdapter
        '
        Me.Classification_RefrenceTableAdapter.ClearBeforeFill = True
        '
        'Judiciary_BasicsTableAdapter
        '
        Me.Judiciary_BasicsTableAdapter.ClearBeforeFill = True
        '
        'Judiciary_TypesTableAdapter
        '
        Me.Judiciary_TypesTableAdapter.ClearBeforeFill = True
        '
        'Judiciary_CourtsTypesTableAdapter
        '
        Me.Judiciary_CourtsTypesTableAdapter.ClearBeforeFill = True
        '
        'LawyerInfoTableAdapter
        '
        Me.LawyerInfoTableAdapter.ClearBeforeFill = True
        '
        'PBox_LawyerPic
        '
        Me.PBox_LawyerPic.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.LawyerInfoBindingSource, "LAttach2", True))
        Me.PBox_LawyerPic.InitialImage = CType(resources.GetObject("PBox_LawyerPic.InitialImage"), System.Drawing.Image)
        Me.PBox_LawyerPic.Location = New System.Drawing.Point(12, 68)
        Me.PBox_LawyerPic.Name = "PBox_LawyerPic"
        Me.PBox_LawyerPic.Size = New System.Drawing.Size(20, 25)
        Me.PBox_LawyerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBox_LawyerPic.TabIndex = 2577
        Me.PBox_LawyerPic.TabStop = False
        Me.PBox_LawyerPic.Visible = False
        '
        'LawyerOfficeInfoTableAdapter
        '
        Me.LawyerOfficeInfoTableAdapter.ClearBeforeFill = True
        '
        'Full_AddressTableAdapter
        '
        Me.Full_AddressTableAdapter.ClearBeforeFill = True
        '
        'InformationAnalysis_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.PBox_LawyerPic)
        Me.Controls.Add(Me.Title_Text)
        Me.Controls.Add(Me.Result_Header)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.MenuStrip_InformationMST1)
        Me.Controls.Add(Me.HeaderText)
        Me.Controls.Add(Me.Information_Text)
        Me.Controls.Add(Me.MenuStrip_InformationMST2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformationAnalysis_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "شاشة تحليل المعلومات ؟؟؟؟؟"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip_InformationMST2.ResumeLayout(False)
        Me.MenuStrip_InformationMST2.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIInformationBasicDefentionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip_InformationMST1.ResumeLayout(False)
        Me.MenuStrip_InformationMST1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FullAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LawyerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LawyerOfficeInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JudiciaryCourtsTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JudiciaryTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JudiciaryBasicsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassificationRefrenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriminalLawfilterSub2ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriminalLawFilterSub1ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriminalLawArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LawListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegislationMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainRefrencesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBox_LawyerPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip_InformationMST2 As MenuStrip
    Friend WithEvents InfoAnalyisi_LawExplanationMST2 As ToolStripMenuItem
    Friend WithEvents InfoAnalysis_AnalysisJudicialMST2 As ToolStripMenuItem
    Friend WithEvents InfoAnalysis_CountTokenEstimateMST2 As ToolStripMenuItem
    Friend WithEvents InfoAnalysis_TashkeelTextMST2 As ToolStripMenuItem
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents Information_Text As RichTextBox
    Public WithEvents HeaderText As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents AIInformationBasicDefentionBindingSource As BindingSource
    Friend WithEvents AIInformationBasicDefentionTableAdapter As DataSet1TableAdapters.AIInformationBasicDefentionTableAdapter
    Friend WithEvents AIInformation_MainID As TextBox
    Friend WithEvents AIInformation_NumberOfTokensRemaining As TextBox
    Friend WithEvents AIInformation_NumberOfTokensConsumed As TextBox
    Friend WithEvents AIInformation_InitialNumberOfTolkensAllowed As TextBox
    Friend WithEvents Result_Header As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents InfoAnlysis_ReadMeMST2 As ToolStripMenuItem
    Friend WithEvents Title_Text As TextBox
    Friend WithEvents MenuStrip_InformationMST1 As MenuStrip
    Friend WithEvents InfoAnalysis_ExitMST1 As ToolStripMenuItem
    Friend WithEvents InfoAnalysis_ConsumerMST1 As ToolStripMenuItem
    Friend WithEvents InfoAnalysis_RemainMST1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tem_SL_MainIDBS0 As TextBox
    Friend WithEvents ServiceLocationBindingSource As BindingSource
    Friend WithEvents Service_LocationTableAdapter As DataSet1TableAdapters.Service_LocationTableAdapter
    Friend WithEvents Tem_SL_NoteBS0 As TextBox
    Friend WithEvents Tem_CountryID As TextBox
    Friend WithEvents CAddressBindingSource As BindingSource
    Friend WithEvents C_AddressTableAdapter As DataSet1TableAdapters.C_AddressTableAdapter
    Friend WithEvents Tem_CountryName As TextBox
    Friend WithEvents Tem_SL_CorpRefClassBS0 As TextBox
    Friend WithEvents Tem_SL_PhoneBS0 As TextBox
    Friend WithEvents Tem_SL_FaxBS0 As TextBox
    Friend WithEvents Tem_SL_MobileBS0 As TextBox
    Friend WithEvents Tem_SL_WebsiteBS0 As TextBox
    Friend WithEvents Tem_SL_EmailBS0 As TextBox
    Friend WithEvents Tem_SL_FullAddressBS0 As TextBox
    Friend WithEvents Tem_SL_DetailAddressBS0 As TextBox
    Friend WithEvents Tem_MainRefNote As TextBox
    Friend WithEvents Tem_MainRefMainID As TextBox
    Friend WithEvents MainRefrencesBindingSource As BindingSource
    Friend WithEvents Main_RefrencesTableAdapter As DataSet1TableAdapters.Main_RefrencesTableAdapter
    Friend WithEvents Tem_LegislationMainNote As TextBox
    Friend WithEvents Tem_LegislationMainMainID As TextBox
    Friend WithEvents LegislationMainBindingSource As BindingSource
    Friend WithEvents Legislation_MainTableAdapter As DataSet1TableAdapters.Legislation_MainTableAdapter
    Friend WithEvents Tem_LawListNote As TextBox
    Friend WithEvents Tem_LawListMainID As TextBox
    Friend WithEvents LawListBindingSource As BindingSource
    Friend WithEvents Law_ListTableAdapter As DataSet1TableAdapters.Law_ListTableAdapter
    Friend WithEvents Tem_LawArticleNote As TextBox
    Friend WithEvents Tem_LawArticleMainID As TextBox
    Friend WithEvents CriminalLawArticleBindingSource As BindingSource
    Friend WithEvents Criminal_Law_ArticleTableAdapter As DataSet1TableAdapters.Criminal_Law_ArticleTableAdapter
    Friend WithEvents Tem_Filtersub1Note As TextBox
    Friend WithEvents Tem_Filtersub1MainID As TextBox
    Friend WithEvents CriminalLawFilterSub1ArticleBindingSource As BindingSource
    Friend WithEvents Criminal_Law_Filter_Sub1_ArticleTableAdapter As DataSet1TableAdapters.Criminal_Law_Filter_Sub1_ArticleTableAdapter
    Friend WithEvents Tem_Filtersub2Note As TextBox
    Friend WithEvents Tem_Filtersub2MainID As TextBox
    Friend WithEvents CriminalLawfilterSub2ArticleBindingSource As BindingSource
    Friend WithEvents Criminal_Law_filter_Sub2_ArticleTableAdapter As DataSet1TableAdapters.Criminal_Law_filter_Sub2_ArticleTableAdapter
    Friend WithEvents Tem_ClassRefNote As TextBox
    Friend WithEvents Tem_ClassRefMainID As TextBox
    Friend WithEvents ClassificationRefrenceBindingSource As BindingSource
    Friend WithEvents Classification_RefrenceTableAdapter As DataSet1TableAdapters.Classification_RefrenceTableAdapter
    Friend WithEvents Tem_JudBasicNote As TextBox
    Friend WithEvents Tem_JudBasicMainID As TextBox
    Friend WithEvents JudiciaryBasicsBindingSource As BindingSource
    Friend WithEvents Judiciary_BasicsTableAdapter As DataSet1TableAdapters.Judiciary_BasicsTableAdapter
    Friend WithEvents Tem_JudTypesNote As TextBox
    Friend WithEvents Tem_JudTypesMainID As TextBox
    Friend WithEvents JudiciaryTypesBindingSource As BindingSource
    Friend WithEvents Judiciary_TypesTableAdapter As DataSet1TableAdapters.Judiciary_TypesTableAdapter
    Friend WithEvents Tem_JudCourtTypeNote As TextBox
    Friend WithEvents Tem_JudCourtTypeMainID As TextBox
    Friend WithEvents JudiciaryCourtsTypesBindingSource As BindingSource
    Friend WithEvents Judiciary_CourtsTypesTableAdapter As DataSet1TableAdapters.Judiciary_CourtsTypesTableAdapter
    Friend WithEvents Tem_LawyerInfoNote As TextBox
    Friend WithEvents Tem_LawyerInfoMainID As TextBox
    Friend WithEvents LawyerInfoBindingSource As BindingSource
    Friend WithEvents LawyerInfoTableAdapter As DataSet1TableAdapters.LawyerInfoTableAdapter
    Friend WithEvents PBox_LawyerPic As PictureBox
    Friend WithEvents Tem_OfficeLawNotes As TextBox
    Friend WithEvents Tem_OfficeLawMainID As TextBox
    Friend WithEvents LawyerOfficeInfoBindingSource As BindingSource
    Friend WithEvents LawyerOfficeInfoTableAdapter As DataSet1TableAdapters.LawyerOfficeInfoTableAdapter
    Friend WithEvents Tem_OfficeLawName As TextBox
    Friend WithEvents Tem_LawyerInfoOfficeID As TextBox
    Friend WithEvents Tem_LawyerInfoFromUserIntID As TextBox
    Friend WithEvents Tem_LawyerInfoGenderDes As TextBox
    Friend WithEvents Tem_LawyerInfoLAssocID As TextBox
    Friend WithEvents Tem_FullAdressCountryDes As TextBox
    Friend WithEvents Tem_FullAddresID_Area As TextBox
    Friend WithEvents FullAddressBindingSource As BindingSource
    Friend WithEvents Full_AddressTableAdapter As DataSet1TableAdapters.Full_AddressTableAdapter
    Friend WithEvents Tem_FullAdressAreaAddress As TextBox
    Friend WithEvents Tem_FullAdressCityDes As TextBox
    Friend WithEvents Tem_FullAdressGovDes As TextBox
End Class
