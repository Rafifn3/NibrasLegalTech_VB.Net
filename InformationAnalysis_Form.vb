Imports System.Text.RegularExpressions
Imports Newtonsoft.Json


Imports System.Media
Imports System.Speech.Synthesis  ' For Text-to-Speech
Imports System.Globalization


Public Class InformationAnalysis_Form
    Public FormID As Integer
    Dim tokenCount As Integer
    Dim Text_New As String


    'لغايات الصوت والكلام
    Dim typeSound As SoundPlayer
    Dim synthesizer As New SpeechSynthesizer()

    Dim reader As New SpeechSynthesizer()

    Public SelectedNodeLevel As Integer
    Public NibrasLegspot_Text As String = ""

    Private Sub InformationAnalysis_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "كود جلب بلد المنشأ"
        C_AddressTableAdapter.Fill(DataSet1.C_Address)
        CAddressBindingSource.Filter = " Country_InetialContryID = '" & "1" & "'"
#End Region

#Region "كود إظهار عدد الرموز المستهلك والمتبقي"
        Me.AIInformationBasicDefentionTableAdapter.Fill(Me.DataSet1.AIInformationBasicDefention)
        InfoAnalysis_ConsumerMST1.Text = AIInformation_NumberOfTokensConsumed.Text
        InfoAnalysis_RemainMST1.Text = AIInformation_NumberOfTokensRemaining.Text
#End Region

#Region "كود تشغيل اسم الفورم مع الصوت"
        Me.Text = " Welcome to NIBRAS Legal Managment System NIBRAS Lexibot............. "
        Dim text As String = Me.Text
        If Not String.IsNullOrWhiteSpace(text) Then
            reader.SpeakAsync(text)
        Else
            MessageBox.Show("الرجاء إدخال نص باللغة العربية للقراءة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
#End Region
        If FormID = 2 Then
            'شاشة تعريف أسماء المحامين Lawyer_Info1
            Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك في معرفة تفاصيل أكثر عن "
        ElseIf FormID = 17 Then
            'شاشة تعريف هيكلية النظام القضائي judiciary
            If Judiciary.TabControlNo = "1" Then
                'الدخول إلى الصفحة الاولى
                Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك لمعرفة معلومات تفصيلية عن أسس النظام القضائي "
            ElseIf Judiciary.TabControlNo = "2" Then
                'الدخول إلى الصفحة الثانية
                Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك لمعرفة معلومات تفصيلية عن أنواع النظام القضائي "
            ElseIf Judiciary.TabControlNo = "3" Then
                'الدخول إلى الصفحة الثالثة
                Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك لمعرفة معلومات تفصيلية عن أسماء النظام القضائي "
            ElseIf Judiciary.TabControlNo = "4" Then
                'الدخول إلى الصفحة الرابعة
                Title_Text.Text = ""
            Else
                'لا يوجد دخول
                Title_Text.Text = ""
            End If
        ElseIf FormID = 31 Or FormID = 16 Then
            'شاشة اماكن تقديم الخدمة الرئيسية
            'شاشة المرجعيات الرئيسية لأماكن تقديم الخدمات Law1 form
            Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك في معرفة تفاصيل أكثر عن أماكن تقديم الخدمة "
        ElseIf FormID = 123 Then
            'شاشة تعريف حالات ومواضيع الموكلين / تعريف تفاصيل الحالات / إدخال أسماء محامين الزيارة والموضوع Caseslawyerform
            Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك في معرفة تفاصيل أكثر عن "
        ElseIf FormID = 10000 Then
            'شاشة المرجعيات المخصصة للبحث LawFullStructure
            Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك في معرفة تفاصيل أكثر عن التشريعات والمرجعيات "
        ElseIf FormID = 204 Or FormID = 1952 Then
            'شاشة تعريف النماذج للإجراءات الرئيسية/تعريف نص نموذج الإجراء الرئيسي/إنشاء المستند
            'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
            Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك في انشاء الوثائق "
        ElseIf FormID = 34 Then
            'شاشة تعريف مسمى المرجعيات ClassificationRefrences_Form
            Title_Text.Text = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك لمعرفة معلومات تفصيلية عن مرجعية التشريعات "
        Else
            'باقي الشاشات
#Region "كود تشغيل المقدمة اثناء التشغيل"
            Dim title_TextTemp As String = "انا نبراس الذكي اقدم لك خيارات ذكية تساعدك في التحليل وصنع القرارات "
            Title_Text.Clear()
            Result_Header.Clear()
            HeaderText.Text = " جاري تحميل NIBRAS Lexibot "
            Result_Header.Text = " ماذا تريدني أنا أفعل لك "
            ' عرض الأحرف واحدًا تلو الآخر
            For Each ch As Char In title_TextTemp
                Result_Header.AppendText(".")
                HeaderText.AppendText(".")
                Title_Text.AppendText(ch)
                Application.DoEvents()
                'Threading.Thread.Sleep(1) ' تأخير زمني بسيط (100 ملي ثانية)
            Next
#End Region
        End If

        Dim Note_Info As String

        Dim SL_ID As Integer
        Dim SL_Name As String

        If FormID = "1" Then
            'ملف تحليل القرارات والاحكام
            If FormID = "1" Then
                HeaderText.Text = " تحليل القرار / الحكم القضائي لموضوع " & Cases_Form1.CasesSupjectAndLawSuits_Des.Text
                MenuStrip_InformationMST2.Visible = True
                InfoAnalysis_AnalysisJudicialMST2.Visible = True
                MenuStrip_InformationMST2.Location = New Point(12, 80)

                rtbOutput.Size = New Size(Size.Width - 40, 570)
                rtbOutput.Location = New Point(12, 110)

                Result_Header.Visible = False
                Result_Header.Text = " ماذا تريدني أن أفعل لك في قرار الحكم أعلاه "
                Information_Text.Text = AnalysisJudicialRulings_Form.AnalysisJudicialRulings_SATAdjudicationTextDes.Text

                InfoAnalyisi_LawExplanationMST2.PerformClick()


            Else
            End If
        ElseIf FormID = 2 Then
            'شاشة تعريف أسماء المحامين Lawyer_Info1
            If FormID = 2 Then
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "معلومات تفصيلية عن أسماء المحامين"


                rtbOutput.Size = New Size(Size.Width - 40, 570)
                rtbOutput.Location = New Point(12, 110)

                Me.LawyerInfoTableAdapter.Fill(Me.DataSet1.LawyerInfo)
                LawyerInfoBindingSource.Filter = " ID =  '" & Lawyer_Info1.IDTextBox.Text & "'"
                PBox_LawyerPic.Visible = True
                PBox_LawyerPic.Size = New Size(111, 117)
                PBox_LawyerPic.Location = New Point(35, 118)

                Dim Lawyer_JopPlace As String
                If Lawyer_Info1.Lawyer_FromUserIntID.Text = "1" Then
                    'محامي خارجي
                    If Lawyer_Info1.LofficeID.Text = "0" Then
                        Lawyer_JopPlace = ""
                    Else
                        Lawyer_JopPlace = "يعمل لدى " & Lawyer_Info1.LOffice_txtb.Text
                    End If
                Else
                    'مكتب المحاماة
                    Lawyer_JopPlace = "يعمل لدى " & Lawyer_Info1.LOffice_txtb.Text
                End If

                Note_Info = " اســم المحامـــي " & Lawyer_Info1.Law_TitlePrefixDes.Text & " " & Lawyer_Info1.Law_FullN.Text & " " & Lawyer_Info1.Law_TitleSuffixDes.Text &
                vbNewLine & " جنــس المحامـــي " & Lawyer_Info1.Law_GenderDesCBox.Text &
                vbNewLine & " محامي مسجل لدى نقابة المحاميين الاردنيين رقم نقابي  " & Lawyer_Info1.LAssoc_IDTxtb.Text & " وعنوانه " &
                vbNewLine & " رقم الهــــــاتف " & Lawyer_Info1.LPhone2.Text &
                vbNewLine & " رقم الفــــــاكس " & Lawyer_Info1.LFaxNo.Text &
                vbNewLine & " رقم الموبايــــل " & Lawyer_Info1.LPhone1.Text &
                vbNewLine & " البريد الإلكتروني " & Lawyer_Info1.LEmailTextBox.Text &
                vbNewLine & " موقـع المحامـــي " & Lawyer_Info1.LAdress.Text & Lawyer_Info1.LAdress_detailTextBox.Text &
                vbNewLine & Lawyer_JopPlace &
                vbNewLine & Lawyer_Info1.Lawyer_History

                Information_Text.Text = "معلومات عامة عن " & Lawyer_Info1.Law_TitlePrefixDes.Text & " " & Lawyer_Info1.Law_FullN.Text & " في " & Tem_CountryName.Text
                Information_Text.Size = New Size(0, 0)

                If Note_Info = "" Then
                    'لا يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم تشغيل كود NIBRAS_LexiBot
                    InfoAnalyisi_LawExplanationMST2.PerformClick()
                Else
                    'يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم جلب المعلومات من الملف المخزن في حقل ال NOTE
                    rtbOutput.Text = Note_Info
                End If

                Title_Text.Visible = True
                Title_Text.Size = New Size(1040, 80)
                Title_Text.Location = New Point(300, 30)
                Title_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Title_Text.Text = Title_Text.Text & "  " & Lawyer_Info1.Law_TitlePrefixDes.Text & " " & Lawyer_Info1.Law_FullN.Text & " " & Lawyer_Info1.Law_TitleSuffixDes.Text
            Else
            End If
        ElseIf FormID = 16 Then
            'شاشة المرجعيات الرئيسية لأماكن تقديم الخدمات Law1 form
            If FormID = 16 Then
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "تحليل بيانات المرجعيات والتشريعات "
                'Title_Text.Visible = False

                rtbOutput.Size = New Size(Size.Width - 40, 570)
                rtbOutput.Location = New Point(12, 110)

                If Law1.RefreshID = -2 Then
                    'صفحة أماكن تقديم الخدمة
                    SL_ID = Law1.SL_ID.Text
                    SL_Name = Law1.SL_Name.Text & " في " & Tem_CountryName.Text
                    Service_LocationTableAdapter.Fill(DataSet1.Service_Location)
                    ServiceLocationBindingSource.Filter = " SL_ID =   '" & SL_ID & "'"
                    Note_Info = Law1.Tem_SL_NoteBS0.Text
                ElseIf Law1.RefreshID = -1 Then
                    'صفحة مرجعيات أماكن تقديم الخدمة
                    Note_Info = Law1.Ref_Note.Text
                    Main_RefrencesTableAdapter.Fill(DataSet1.Main_Refrences)
                    MainRefrencesBindingSource.Filter = " Ref_ID =  '" & Law1.Ref_ID.Text & "'"
                ElseIf Law1.RefreshID = 0 Then
                    'صفحة اسماء التشريعات الرئيسية
                    Note_Info = Law1.Legislation_Note.Text
                    Legislation_MainTableAdapter.Fill(DataSet1.Legislation_Main)
                    LegislationMainBindingSource.Filter = " Legislation_ID = '" & Law1.Legislation_ID.Text & "'"
                ElseIf Law1.RefreshID = 16001 Then
                    'صفحة إصدارات التشريع
                    Note_Info = Law1.Law_Note.Text
                    Law_ListTableAdapter.Fill(DataSet1.Law_List)
                    LawListBindingSource.Filter = " ID =  '" & Law1.ID.Text & "'"
                ElseIf Law1.RefreshID = 160011 Then
                    'صفحة إصدارات التشريع/التشريعات المعدلة
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    Note_Info = ""
                ElseIf Law1.RefreshID = 16002 Then
                    'صفحة كتب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    Note_Info = ""
                ElseIf Law1.RefreshID = 16003 Then
                    'صفحة ابواب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    Note_Info = ""
                ElseIf Law1.RefreshID = 16004 Then
                    'صفحة اقسام التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    Note_Info = ""
                ElseIf Law1.RefreshID = 16005 Then
                    'صفحة فصول التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    Note_Info = ""
                ElseIf Law1.RefreshID = 16006 Then
                    'صفحة تعريف تصنيف التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    Note_Info = ""
                ElseIf Law1.RefreshID = 16007 Then
                    'صفحة مواد التشريع
                    Note_Info = Law1.Article_Note.Text
                    Criminal_Law_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Article)
                    CriminalLawArticleBindingSource.Filter = " ArticleID = '" & Law1.ArticleID.Text & "'"
                ElseIf Law1.RefreshID = 16008 Then
                    ' صفحة تعريف فقرات مواد التشريع
                    Note_Info = Law1.Filtersub1_Note.Text
                    Criminal_Law_Filter_Sub1_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Filter_Sub1_Article)
                    CriminalLawFilterSub1ArticleBindingSource.Filter = " Filtersub1_ID = '" & Law1.Filtersub1_ID.Text & "'"
                ElseIf Law1.RefreshID = 16009 Then
                    ' صفحة تعريف بنود فقرة مواد التشريع
                    Note_Info = Law1.Filtersub2_Note.Text
                    Criminal_Law_filter_Sub2_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_filter_Sub2_Article)
                    CriminalLawfilterSub2ArticleBindingSource.Filter = " Filtersub2_ID =  '" & Law1.Filtersub2_ID.Text & "'"
                ElseIf Law1.RefreshID = 16010 Then
                    ' صفحة إستعراض مواد التشريع
                    If Law1.View_DefineLegType.Text = "0" Then
                        If Law1.View_ArticleID.Text = "" Then
                            Note_Info = ""
                        Else
                            Note_Info = Law1.View_ArticleArticleNote.Text
                            Criminal_Law_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Article)
                            CriminalLawArticleBindingSource.Filter = " ArticleID = '" & Law1.View_ArticleID.Text & "'"
                        End If
                    ElseIf Law1.View_DefineLegType.Text = "1" Then
                        If Law1.View_Filtersub1ID.Text = "" Then
                            Note_Info = ""
                        Else
                            Note_Info = Law1.View_Filtersub1Note.Text
                            Criminal_Law_Filter_Sub1_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Filter_Sub1_Article)
                            CriminalLawFilterSub1ArticleBindingSource.Filter = " Filtersub1_ID = '" & Law1.View_Filtersub1ID.Text & "'"
                        End If
                    ElseIf Law1.View_DefineLegType.Text = "2" Then
                        If Law1.View_Filtersub2ID.Text = "" Then
                            Note_Info = ""
                        Else
                            Note_Info = Law1.View_Filtersub2Note.Text
                            Criminal_Law_filter_Sub2_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_filter_Sub2_Article)
                            CriminalLawfilterSub2ArticleBindingSource.Filter = " Filtersub2_ID =  '" & Law1.View_Filtersub2ID.Text & "'"
                        End If
                    Else
                        Note_Info = ""
                    End If
                ElseIf Law1.RefreshID = 16011 Then
                    ' صفحة إستعراض صور التشريع
                    Note_Info = ""
                Else
                    Note_Info = ""
                End If
                Information_Text.Text = Law1.Extention_Text & " في " & Tem_CountryName.Text
                Information_Text.Location = New Point(12, 400)

                If Note_Info = "" Then
                    'لا يوجد معلومة مخزنة في ملف الملاحظات
                    'يتم تشغيل كود NIBRAS_LexiBot
                    InfoAnalyisi_LawExplanationMST2.PerformClick()
                Else
                    'ويجد معلومة مخزنة في ملف الملاحظات
                    'يتم جلب المعلومات من الملف المخزن في حقل ال NOTE
                    rtbOutput.Text = Note_Info
                End If
                Title_Text.Visible = True
                Title_Text.Size = New Size(1040, 80)
                Title_Text.Location = New Point(300, 30)
                Title_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Title_Text.Text = " معلومات عامة عن  " & Information_Text.Text
            Else
            End If
        ElseIf FormID = 17 Then
            'شاشة تعريف هيكلية النظام القضائي judiciary
            If FormID = 17 Then
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "معلومات تفصيلية عن هيكلية النظام القضائي"

                rtbOutput.Size = New Size(Size.Width - 40, 570)
                rtbOutput.Location = New Point(12, 110)
                If Judiciary.TabControlNo = "1" Then
                    'الدخول إلى الصفحة الاولى
                    Note_Info = Judiciary.Judiciary_Notes.Text
                    Judiciary_BasicsTableAdapter.Fill(DataSet1.Judiciary_Basics)
                    JudiciaryBasicsBindingSource.Filter = " ID = '" & Judiciary.Judiciary_ID.Text & "'"
                ElseIf Judiciary.TabControlNo = "2" Then
                    'الدخول إلى الصفحة الثانية
                    Note_Info = Judiciary.JudType_Note.Text
                    Judiciary_TypesTableAdapter.Fill(DataSet1.Judiciary_Types)
                    JudiciaryTypesBindingSource.Filter = " JudType_ID = '" & Judiciary.JudType_ID.Text & "'"
                ElseIf Judiciary.TabControlNo = "3" Then
                    'الدخول إلى الصفحة الثالثة
                    Note_Info = Judiciary.JSC_Notes.Text
                    Judiciary_CourtsTypesTableAdapter.Fill(DataSet1.Judiciary_CourtsTypes)
                    JudiciaryCourtsTypesBindingSource.Filter = " ID = '" & Judiciary.JSC_ID.Text & "'"
                ElseIf Judiciary.TabControlNo = "4" Then
                    'الدخول إلى الصفحة الرابعة
                    Note_Info = ""
                Else
                    'لا يوجد دخول
                    Note_Info = ""
                End If
                Information_Text.Text = Judiciary.Extention_Text & " في " & Tem_CountryName.Text
                If Note_Info = "" Then
                    'لا يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم تشغيل كود NIBRAS_LexiBot
                    InfoAnalyisi_LawExplanationMST2.PerformClick()
                Else
                    'يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم جلب المعلومات من الملف المخزن في حقل ال NOTE
                    rtbOutput.Text = Note_Info
                End If

                Title_Text.Visible = True
                Title_Text.Size = New Size(1040, 80)
                Title_Text.Location = New Point(300, 30)
                Title_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Title_Text.Text = Title_Text.Text & "  " & Information_Text.Text
            Else
            End If
        ElseIf FormID = 31 Then
            'شاشة اماكن تقديم الخدمة الرئيسية
            If FormID = 31 Then
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "تحليل بيانات أماكن تقديم الخدمة"
                Title_Text.Visible = False
                rtbOutput.Size = New Size(Size.Width - 40, 614)
                rtbOutput.Location = New Point(12, 64)

                SL_ID = Service_Location.SL_ID.Text
                SL_Name = Service_Location.SL_Corporation_Name.Text & " في " & Tem_CountryName.Text
                Note_Info = Service_Location.SL_Note.Text
                Information_Text.Text = SL_Name
                If Note_Info = "" Then
                    'لا يوجد معلومة مخزنة في ملف الشركات والمؤسسات
                    'يتم تشغيل كود NIBRAS_LexiBot
                    InfoAnalyisi_LawExplanationMST2.PerformClick()
                Else
                    'ويجد معلومة مخزنة في ملف الشركات والمؤسسات
                    'يتم جلب المعلومات من الملف المخزن في حقل ال NOTE
                    rtbOutput.Text = Service_Location.SL_Note.Text
                End If
                Service_LocationTableAdapter.Fill(DataSet1.Service_Location)
                ServiceLocationBindingSource.Filter = " SL_ID =   '" & SL_ID & "'"

                Result_Header.Visible = True
                Result_Header.Location = New Point(336, 45)
                Result_Header.Text = " معلومات عامة عن  " & SL_Name
            Else
            End If
        ElseIf FormID = 34 Then
            'شاشة تعريف مسمى المرجعيات ClassificationRefrences_Form
            If FormID = 34 Then
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "معلومات تفصيلية عن مرجعية التشريعات"
                Title_Text.Visible = False
                rtbOutput.Size = New Size(Size.Width - 40, 614)
                rtbOutput.Location = New Point(12, 64)
                Note_Info = ClassificationRefrences_Form.Class_Note.Text
                Information_Text.Text = ClassificationRefrences_Form.Class_Des.Text
                If Note_Info = "" Then
                    'لا يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم تشغيل كود NIBRAS_LexiBot
                    InfoAnalyisi_LawExplanationMST2.PerformClick()
                Else
                    'يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم جلب المعلومات من الملف المخزن في حقل ال NOTE
                    rtbOutput.Text = ClassificationRefrences_Form.Class_Note.Text
                End If
                Classification_RefrenceTableAdapter.Fill(DataSet1.Classification_Refrence)
                ClassificationRefrenceBindingSource.Filter = " Class_ID = '" & ClassificationRefrences_Form.Class_ID.Text & "'"

                Result_Header.Visible = True
                Result_Header.Location = New Point(336, 45)
                Result_Header.Text = " معلومات عامة عن مصطلح  " & Information_Text.Text
            Else
            End If
        ElseIf FormID = 123 Then
            'شاشة تعريف حالات ومواضيع الموكلين / تعريف تفاصيل الحالات / إدخال أسماء محامين الزيارة والموضوع Caseslawyerform
            If FormID = 123 Then
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "معلومات تفصيلية عن أسماء محامين الموضوع"
                rtbOutput.Size = New Size(Size.Width - 40, 570)
                rtbOutput.Location = New Point(12, 110)
                Me.LawyerInfoTableAdapter.Fill(Me.DataSet1.LawyerInfo)
                LawyerInfoBindingSource.Filter = " ID =  '" & Caseslawyerform.Lawyer_LawyerID.Text & "'"
                PBox_LawyerPic.Visible = True
                PBox_LawyerPic.Size = New Size(111, 117)
                PBox_LawyerPic.Location = New Point(35, 118)

                Me.Full_AddressTableAdapter.Fill(Me.DataSet1.Full_Address)
                FullAddressBindingSource.Filter = "ID_Area = '" & Caseslawyerform.Tem_LawyerAdressNo.Text & "'"

                Dim Lawyer_JopPlace As String
                If Tem_LawyerInfoFromUserIntID.Text = "1" Then
                    'محامي خارجي
                    If Tem_LawyerInfoOfficeID.Text = "0" Then
                        Lawyer_JopPlace = ""
                    Else
                        Lawyer_JopPlace = "يعمل لدى " & Caseslawyerform.Lofficename.Text
                    End If
                Else
                    'مكتب المحاماة
                    Lawyer_JopPlace = "يعمل لدى " & Caseslawyerform.Lofficename.Text
                End If

                Note_Info = " اســم المحامـــي " & Caseslawyerform.Tem_LawyerTitleSuffix.Text & " " & Caseslawyerform.Lawyer_LawyerDes.Text & " " & Caseslawyerform.Tem_LawyerTitlePrefix.Text &
                vbNewLine & " جنــس المحامـــي " & Caseslawyerform.Tem_LawyerGenderDes.Text &
                vbNewLine & " محامي مسجل لدى نقابة المحاميين الاردنيين رقم نقابي  " & Tem_LawyerInfoLAssocID.Text & " وعنوانه " &
                vbNewLine & " رقم الهــــــاتف " & Caseslawyerform.Tem_LawyerPhone2.Text &
                vbNewLine & " رقم الفــــــاكس " & Caseslawyerform.Tem_LawyerFaxNo.Text &
                vbNewLine & " رقم الموبايــــل " & Caseslawyerform.Tem_LawyerMobilePhone1.Text &
                vbNewLine & " البريد الإلكتروني " & Caseslawyerform.Tem_LawyerEmail.Text &
                vbNewLine & " موقـع المحامـــي " & Tem_FullAdressCountryDes.Text & " / " & Tem_FullAdressGovDes.Text & " / " & Tem_FullAdressCityDes.Text & " / " & Tem_FullAdressAreaAddress.Text &
                vbNewLine & Lawyer_JopPlace &
                vbNewLine & Caseslawyerform.Lawyer_History

                Information_Text.Text = "معلومات عامة عن " & Caseslawyerform.Tem_LawyerTitleSuffix.Text & " " & Caseslawyerform.Lawyer_LawyerDes.Text & " في " & Tem_CountryName.Text
                Information_Text.Size = New Size(0, 0)
                If Note_Info = "" Then
                    'لا يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم تشغيل كود NIBRAS_LexiBot
                    InfoAnalyisi_LawExplanationMST2.PerformClick()
                Else
                    'يوجد معلومة مخزنة في ملف مرجعية التشريعات
                    'يتم جلب المعلومات من الملف المخزن في حقل ال NOTE
                    rtbOutput.Text = Note_Info
                End If

                Title_Text.Visible = True
                Title_Text.Size = New Size(1040, 80)
                Title_Text.Location = New Point(300, 30)
                Title_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Title_Text.Text = Title_Text.Text & "  " & Caseslawyerform.Tem_LawyerTitleSuffix.Text & " " & Caseslawyerform.Lawyer_LawyerDes.Text & " " & Caseslawyerform.Tem_LawyerTitlePrefix.Text
            Else
            End If
        ElseIf FormID = 204 Or FormID = 1952 Then
            'شاشة تعريف النماذج للإجراءات الرئيسية/تعريف نص نموذج الإجراء الرئيسي/إنشاء المستند
            'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
            If FormID = 204 Or FormID = 1952 Then
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "انشاء نموذج جديد"

                rtbOutput.Size = New Size(Size.Width - 40, 614)
                rtbOutput.Location = New Point(12, 110)

                If FormID = 204 Then
                    'شاشة تعريف النماذج للإجراءات الرئيسية/تعريف نص نموذج الإجراء الرئيسي/إنشاء المستند
                    Information_Text.Text = Doc_Templates.DocTemp_Form_H.Text & " في " & Tem_CountryName.Text
                ElseIf FormID = 1952 Then
                    'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
                    'Information_Text.Text = ActionForm_Drafting.DPD_Form_H.Text & " في " & Tem_CountryName.Text
                    'Information_Text.Text = ProceduresAdd_Form.ActionProcedure_ProcedureDes.Text &
                    '                                          " " & ProceduresAdd_Form.ActionProcedure_LawSuitesName.Text &
                    '                                          " " & " والمقدمة من " & ProceduresAdd_Form.ActionProcedure_TitleAndNumberDes.Text & " " & ProceduresAdd_Form.ActionProcedure_ClientDes.Text &
                    '                                          " " & " إلى " & ProceduresAdd_Form.ActionProcedure_JudSystemName.Text &
                    '                                          " " & " في " & Tem_CountryName.Text

                    'يجب مناداة ملف انشاء الوثيقة
                    'يوجد شروط خاصة تتعلق بانشاء وثيقة عقد ايجار و انابة

                    ' MsgBox(111111111)


                    ProceduresAdd_Form.Enabled = True
                    ProceduresAdd_Form.Procedure_CreatDocumentMST1.PerformClick()


                    'MsgBox(" رقم الدخول لنبراس الذكي " & ProceduresAdd_Form.AccessParameter_LexiPot)

                    If ProceduresAdd_Form.AccessParameter_LexiPot = 1 Then
                        'تخطى كافة الشروط المطلوبة لغايات فتح ملف انشاء الوثائق
                        'يسمح باستكمال إجراءات طلب نبراس الذكي
                        'MsgBox(222222222222)
                        'MsgBox(" النص الذي تم نقله الى ملف نبراس الذكي " & NibrasLegspot_Text)
                        Information_Text.Text = NibrasLegspot_Text
                        BringToFront()
                        'MsgBox(3333333333333)
                        ProceduresAdd_Form.Enabled = False
                        CreatDocument.Close()
                    Else
                        'لايسمح باستكمال نبراس الذكي 
                        'MsgBox(4444444)
                        ProceduresAdd_Form.Enabled = False
                        CreatDocument.Close()
                        Exit_Form()
                        Close()
                        Exit Sub
                    End If
                Else
                End If
                Information_Text.Location = New Point(12, 400)

                Title_Text.Visible = True
                Title_Text.Size = New Size(1040, 80)
                Title_Text.Location = New Point(300, 30)
                Title_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Title_Text.Text = " نموذج مقترح لـِ  " & Information_Text.Text

                InfoAnalyisi_LawExplanationMST2.PerformClick()

            Else
            End If
        ElseIf FormID = 10000 Then
            'شاشة المرجعيات المخصصة للبحث LawFullStructure
            If FormID = 10000 Then
                LawFullStructure.SelectedNodeLevel = LawFullStructure.TreeView1.SelectedNode.Level
                Result_Header.Visible = False
                MenuStrip_InformationMST2.SendToBack()
                MenuStrip_InformationMST2.Location = New Point(15, 400)
                HeaderText.Text = "تحليل بيانات المرجعيات والتشريعات "
                'Title_Text.Visible = False

                rtbOutput.Size = New Size(Size.Width - 40, 570)
                rtbOutput.Location = New Point(12, 110)

                If LawFullStructure.TabControlNo = "1" Then
                    'الدخول إلى الصفحة الاولى
                    If LawFullStructure.TreeView1.SelectedNode.Level = "0" Then
                        'صفحة أماكن تقديم الخدمة
                        Note_Info = LawFullStructure.Tem_SLNoteBS100.Text
                        Service_LocationTableAdapter.Fill(DataSet1.Service_Location)
                        ServiceLocationBindingSource.Filter = " SL_ID =   '" & LawFullStructure.Tem_SLMainIDBS100.Text & "'"
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "1" Then
                        'صفحة مرجعيات أماكن تقديم الخدمة
                        Note_Info = LawFullStructure.Tem_MainRefNoteBS100.Text
                        Main_RefrencesTableAdapter.Fill(DataSet1.Main_Refrences)
                        MainRefrencesBindingSource.Filter = " Ref_ID =  '" & LawFullStructure.Tem_MainRefMainIDBS100.Text & "'"
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "2" Then
                        'صفحة اسماء التشريعات الرئيسية
                        Note_Info = LawFullStructure.Tem_MainLegeslationNoteBS100.Text
                        Legislation_MainTableAdapter.Fill(DataSet1.Legislation_Main)
                        LegislationMainBindingSource.Filter = " Legislation_ID = '" & LawFullStructure.Tem_MainLegeslationMainIDBS100.Text & "'"
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "3" Then
                        'صفحة إصدارات التشريع
                        Note_Info = LawFullStructure.Tem_IssuedLawNoteBS100.Text
                        Law_ListTableAdapter.Fill(DataSet1.Law_List)
                        LawListBindingSource.Filter = " ID =  '" & LawFullStructure.Tem_IssuedLawMainIDBS100.Text & "'"
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "4" Then
                        'صفحة كتب التشريع
                        'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                        Note_Info = ""
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "5" Then
                        'صفحة ابواب التشريع
                        'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                        Note_Info = ""
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "6" Then
                        'صفحة اقسام التشريع
                        'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                        Note_Info = ""
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "7" Then
                        'صفحة فصول التشريع
                        'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                        Note_Info = ""
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "8" Then
                        'صفحة تعريف تصنيف التشريع
                        'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                        Note_Info = ""
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "9" Or LawFullStructure.TreeView1.SelectedNode.Level = "10" Then
                        'صفحة مواد التشريع

                        Note_Info = LawFullStructure.Tem_LawArticleNoteBS100.Text
                        Criminal_Law_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Article)
                        CriminalLawArticleBindingSource.Filter = " ArticleID = '" & LawFullStructure.Tem_LawArticleMainIDBS100.Text & "'"
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "11" Then
                        ' صفحة تعريف فقرات مواد التشريع
                        Note_Info = LawFullStructure.Tem_LawSub1NoteBS100.Text
                        Criminal_Law_Filter_Sub1_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Filter_Sub1_Article)
                        CriminalLawFilterSub1ArticleBindingSource.Filter = " Filtersub1_ID = '" & LawFullStructure.Tem_LawSub1MainIDBS100.Text & "'"
                    ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "12" Then
                        ' صفحة تعريف بنود فقرة مواد التشريع
                        Note_Info = LawFullStructure.Tem_LawSub2NoteBS100.Text
                        Criminal_Law_filter_Sub2_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_filter_Sub2_Article)
                        CriminalLawfilterSub2ArticleBindingSource.Filter = " Filtersub2_ID =  '" & LawFullStructure.Tem_LawSub2MainIDBS100.Text & "'"
                    Else
                        Note_Info = ""
                    End If
                ElseIf LawFullStructure.TabControlNo = "2" Then
                    'الدخول إلى الصفحة الثانية
                    Note_Info = ""
                ElseIf LawFullStructure.TabControlNo = "3" Then
                    'الدخول إلى الصفحة الثالثة
                    Note_Info = ""
                ElseIf LawFullStructure.TabControlNo = "4" Then
                    'الدخول إلى الصفحة الرابعة
                    Note_Info = ""
                Else
                    'لا يوجد دخول
                    Note_Info = ""
                End If

                Information_Text.Text = LawFullStructure.Extention_Text & " في " & Tem_CountryName.Text
                Information_Text.Location = New Point(12, 400)

                If Note_Info = "" Then
                    'لا يوجد معلومة مخزنة في ملف الملاحظات
                    'يتم تشغيل كود NIBRAS_LexiBot
                    InfoAnalyisi_LawExplanationMST2.PerformClick()
                Else
                    'ويجد معلومة مخزنة في ملف الملاحظات
                    'يتم جلب المعلومات من الملف المخزن في حقل ال NOTE
                    rtbOutput.Text = Note_Info
                End If
                Title_Text.Visible = True
                Title_Text.Size = New Size(1040, 80)
                Title_Text.Location = New Point(300, 30)
                Title_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Title_Text.Text = " معلومات عامة عن  " & Information_Text.Text
            Else
            End If
        Else
        End If
    End Sub
    Private Sub InformationAnalysis_Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Exit_Form()
    End Sub

    Sub Information_Save()
        If FormID = 1 Then
            'ملف تحليل القرارات والاحكام
        ElseIf FormID = 2 Then
            'شاشة تعريف أسماء المحامين Lawyer_Info1
            Tem_LawyerInfoNote.Text = rtbOutput.Text
            ValidateChildren()
            LawyerInfoBindingSource.EndEdit()
            LawyerInfoTableAdapter.Update(DataSet1.LawyerInfo)
            LawyerInfoTableAdapter.Fill(DataSet1.LawyerInfo)
        ElseIf FormID = 16 Then
            If Law1.RefreshID = -2 Then
                'صفحة أماكن تقديم الخدمة
                Tem_SL_NoteBS0.Text = rtbOutput.Text
                ValidateChildren()
                ServiceLocationBindingSource.EndEdit()
                Service_LocationTableAdapter.Update(DataSet1.Service_Location)
                Service_LocationTableAdapter.Fill(DataSet1.Service_Location)
            ElseIf Law1.RefreshID = -1 Then
                'صفحة مرجعيات أماكن تقديم الخدمة
                Tem_MainRefNote.Text = rtbOutput.Text
                ValidateChildren()
                MainRefrencesBindingSource.EndEdit()
                Main_RefrencesTableAdapter.Update(DataSet1.Main_Refrences)
                Main_RefrencesTableAdapter.Fill(DataSet1.Main_Refrences)
            ElseIf Law1.RefreshID = 0 Then
                'صفحة اسماء التشريعات الرئيسية
                Tem_LegislationMainNote.Text = rtbOutput.Text
                ValidateChildren()
                LegislationMainBindingSource.EndEdit()
                Legislation_MainTableAdapter.Update(DataSet1.Legislation_Main)
                Legislation_MainTableAdapter.Fill(DataSet1.Legislation_Main)
            ElseIf Law1.RefreshID = 16001 Then
                'صفحة إصدارات التشريع
                Tem_LawListNote.Text = rtbOutput.Text
                ValidateChildren()
                LawListBindingSource.EndEdit()
                Law_ListTableAdapter.Update(DataSet1.Law_List)
                Law_ListTableAdapter.Fill(DataSet1.Law_List)
            ElseIf Law1.RefreshID = 160011 Then
                'صفحة إصدارات التشريع/التشريعات المعدلة
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf Law1.RefreshID = 16002 Then
                'صفحة كتب التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf Law1.RefreshID = 16003 Then
                'صفحة ابواب التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf Law1.RefreshID = 16004 Then
                'صفحة اقسام التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf Law1.RefreshID = 16005 Then
                'صفحة فصول التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf Law1.RefreshID = 16006 Then
                'صفحة تعريف تصنيف التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf Law1.RefreshID = 16007 Then
                'صفحة مواد التشريع
                Tem_LawArticleNote.Text = rtbOutput.Text
                ValidateChildren()
                CriminalLawArticleBindingSource.EndEdit()
                Criminal_Law_ArticleTableAdapter.Update(DataSet1.Criminal_Law_Article)
                Criminal_Law_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Article)
            ElseIf Law1.RefreshID = 16008 Then
                ' صفحة تعريف فقرات مواد التشريع
                Tem_Filtersub1Note.Text = rtbOutput.Text
                ValidateChildren()
                CriminalLawFilterSub1ArticleBindingSource.EndEdit()
                Criminal_Law_Filter_Sub1_ArticleTableAdapter.Update(DataSet1.Criminal_Law_Filter_Sub1_Article)
                Criminal_Law_Filter_Sub1_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Filter_Sub1_Article)
            ElseIf Law1.RefreshID = 16009 Then
                ' صفحة تعريف بنود فقرة مواد التشريع
                Tem_Filtersub2Note.Text = rtbOutput.Text
                ValidateChildren()
                CriminalLawfilterSub2ArticleBindingSource.EndEdit()
                Criminal_Law_filter_Sub2_ArticleTableAdapter.Update(DataSet1.Criminal_Law_filter_Sub2_Article)
                Criminal_Law_filter_Sub2_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_filter_Sub2_Article)
            ElseIf Law1.RefreshID = 16010 Then
                ' صفحة إستعراض مواد التشريع
                If Law1.View_DefineLegType.Text = "0" Then
                    If Law1.View_ArticleID.Text = "" Then

                    Else
                        Tem_LawArticleNote.Text = rtbOutput.Text
                        ValidateChildren()
                        CriminalLawArticleBindingSource.EndEdit()
                        Criminal_Law_ArticleTableAdapter.Update(DataSet1.Criminal_Law_Article)
                        Criminal_Law_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Article)
                    End If
                ElseIf Law1.View_DefineLegType.Text = "1" Then
                    If Law1.View_Filtersub1ID.Text = "" Then

                    Else
                        Tem_Filtersub1Note.Text = rtbOutput.Text
                        ValidateChildren()
                        CriminalLawFilterSub1ArticleBindingSource.EndEdit()
                        Criminal_Law_Filter_Sub1_ArticleTableAdapter.Update(DataSet1.Criminal_Law_Filter_Sub1_Article)
                        Criminal_Law_Filter_Sub1_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Filter_Sub1_Article)
                    End If
                ElseIf Law1.View_DefineLegType.Text = "2" Then
                    If Law1.View_Filtersub2ID.Text = "" Then

                    Else
                        Tem_Filtersub2Note.Text = rtbOutput.Text
                        ValidateChildren()
                        CriminalLawfilterSub2ArticleBindingSource.EndEdit()
                        Criminal_Law_filter_Sub2_ArticleTableAdapter.Update(DataSet1.Criminal_Law_filter_Sub2_Article)
                        Criminal_Law_filter_Sub2_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_filter_Sub2_Article)
                    End If
                Else

                End If
            ElseIf Law1.RefreshID = 16011 Then
                ' صفحة إستعراض صور التشريع
            Else
            End If

        ElseIf FormID = 17 Then
            'شاشة تعريف هيكلية النظام القضائي judiciary
            If Judiciary.TabControlNo = "1" Then
                'الدخول إلى الصفحة الاولى
                Tem_JudBasicNote.Text = rtbOutput.Text
                ValidateChildren()
                JudiciaryBasicsBindingSource.EndEdit()
                Judiciary_BasicsTableAdapter.Update(DataSet1.Judiciary_Basics)
                Judiciary_BasicsTableAdapter.Fill(DataSet1.Judiciary_Basics)
            ElseIf Judiciary.TabControlNo = "2" Then
                'الدخول إلى الصفحة الثانية
                Tem_JudTypesNote.Text = rtbOutput.Text
                ValidateChildren()
                JudiciaryTypesBindingSource.EndEdit()
                Judiciary_TypesTableAdapter.Update(DataSet1.Judiciary_Types)
                Judiciary_TypesTableAdapter.Fill(DataSet1.Judiciary_Types)
            ElseIf Judiciary.TabControlNo = "3" Then
                'الدخول إلى الصفحة الثالثة
                Tem_JudCourtTypeNote.Text = rtbOutput.Text
                ValidateChildren()
                JudiciaryCourtsTypesBindingSource.EndEdit()
                Judiciary_CourtsTypesTableAdapter.Update(DataSet1.Judiciary_CourtsTypes)
                Judiciary_CourtsTypesTableAdapter.Fill(DataSet1.Judiciary_CourtsTypes)
            ElseIf Judiciary.TabControlNo = "4" Then
                'الدخول إلى الصفحة الرابعة

            Else
                'لا يوجد دخول

            End If
        ElseIf FormID = 31 Then
            'شاشة اماكن تقديم الخدمة الرئيسية
            'تم جلب بيانات 
            'وبالتالي يتم الحفظ
            Tem_SL_NoteBS0.Text = rtbOutput.Text
            ValidateChildren()
            ServiceLocationBindingSource.EndEdit()
            Service_LocationTableAdapter.Update(DataSet1.Service_Location)
            Service_LocationTableAdapter.Fill(DataSet1.Service_Location)
        ElseIf FormID = 34 Then
            'شاشة تعريف مسمى المرجعيات ClassificationRefrences_Form
            Tem_ClassRefNote.Text = rtbOutput.Text
            ValidateChildren()
            ClassificationRefrenceBindingSource.EndEdit()
            Classification_RefrenceTableAdapter.Update(DataSet1.Classification_Refrence)
            Classification_RefrenceTableAdapter.Fill(DataSet1.Classification_Refrence)
        ElseIf FormID = 123 Then
            'شاشة تعريف حالات ومواضيع الموكلين / تعريف تفاصيل الحالات / إدخال أسماء محامين الزيارة والموضوع Caseslawyerform
            If FormID = 123 Then
                'الكود لايعمل هنا
            Else
            End If
        ElseIf FormID = 204 Or FormID = 1952 Then
            'شاشة تعريف النماذج للإجراءات الرئيسية/تعريف نص نموذج الإجراء الرئيسي/إنشاء المستند
            'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
        ElseIf FormID = 10000 Then
            'شاشة المرجعيات المخصصة للبحث LawFullStructure
            If LawFullStructure.TreeView1.SelectedNode.Level = "0" Then
                'صفحة أماكن تقديم الخدمة
                Tem_SL_NoteBS0.Text = rtbOutput.Text
                ValidateChildren()
                ServiceLocationBindingSource.EndEdit()
                Service_LocationTableAdapter.Update(DataSet1.Service_Location)
                Service_LocationTableAdapter.Fill(DataSet1.Service_Location)
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "1" Then
                'صفحة مرجعيات أماكن تقديم الخدمة
                Tem_MainRefNote.Text = rtbOutput.Text
                ValidateChildren()
                MainRefrencesBindingSource.EndEdit()
                Main_RefrencesTableAdapter.Update(DataSet1.Main_Refrences)
                Main_RefrencesTableAdapter.Fill(DataSet1.Main_Refrences)
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "2" Then
                'صفحة اسماء التشريعات الرئيسية
                Tem_LegislationMainNote.Text = rtbOutput.Text
                ValidateChildren()
                LegislationMainBindingSource.EndEdit()
                Legislation_MainTableAdapter.Update(DataSet1.Legislation_Main)
                Legislation_MainTableAdapter.Fill(DataSet1.Legislation_Main)
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "3" Then
                'صفحة إصدارات التشريع
                Tem_LawListNote.Text = rtbOutput.Text
                ValidateChildren()
                LawListBindingSource.EndEdit()
                Law_ListTableAdapter.Update(DataSet1.Law_List)
                Law_ListTableAdapter.Fill(DataSet1.Law_List)

            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "4" Then
                'صفحة كتب التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "5" Then
                'صفحة ابواب التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "6" Then
                'صفحة اقسام التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "7" Then
                'صفحة فصول التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "8" Then
                'صفحة تعريف تصنيف التشريع
                'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "9" Or LawFullStructure.TreeView1.SelectedNode.Level = "10" Then
                'صفحة مواد التشريع
                Tem_LawArticleNote.Text = rtbOutput.Text
                ValidateChildren()
                CriminalLawArticleBindingSource.EndEdit()
                Criminal_Law_ArticleTableAdapter.Update(DataSet1.Criminal_Law_Article)
                Criminal_Law_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Article)
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "11" Then
                ' صفحة تعريف فقرات مواد التشريع
                Tem_Filtersub1Note.Text = rtbOutput.Text
                ValidateChildren()
                CriminalLawFilterSub1ArticleBindingSource.EndEdit()
                Criminal_Law_Filter_Sub1_ArticleTableAdapter.Update(DataSet1.Criminal_Law_Filter_Sub1_Article)
                Criminal_Law_Filter_Sub1_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_Filter_Sub1_Article)
            ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "12" Then
                ' صفحة تعريف بنود فقرة مواد التشريع
                Tem_Filtersub2Note.Text = rtbOutput.Text
                ValidateChildren()
                CriminalLawfilterSub2ArticleBindingSource.EndEdit()
                Criminal_Law_filter_Sub2_ArticleTableAdapter.Update(DataSet1.Criminal_Law_filter_Sub2_Article)
                Criminal_Law_filter_Sub2_ArticleTableAdapter.Fill(DataSet1.Criminal_Law_filter_Sub2_Article)
            Else
            End If
        Else
        End If
    End Sub

#Region "احتساب قيمة الرموز في النص "
    Function EstimateTokens(text As String) As Integer
        ' إزالة الفراغات الزائدة
        text = text.Trim()
        ' تقسيم الجملة إلى كلمات
        Dim words() As String = text.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        ' تقريب عدد الرموز بناءً على اللغة
        ' هنا نفترض أن كل كلمة = 1.33 رمز (تقريبًا)
        Dim tokenEstimate As Integer = CInt(words.Length * 1.33)
        Return tokenEstimate
    End Function
    Private Sub InfoAnalysis_CountTokenEstimateMST1_Click(sender As Object, e As EventArgs) Handles InfoAnalysis_CountTokenEstimateMST2.Click
        Dim inputText As String = Information_Text.Text   '"مرحباً، كيف أستخدم API الخاص بـ ChatGPT؟"
        tokenCount = EstimateTokens(inputText)
        MessageBox.Show("عدد الرموز التقريبي: " & tokenCount)
    End Sub
    Sub Token_SaveCalculate()
        Me.AIInformationBasicDefentionTableAdapter.Fill(Me.DataSet1.AIInformationBasicDefention)
        Dim inputText As String = Information_Text.Text   '"مرحباً، كيف أستخدم API الخاص بـ ChatGPT؟"
        tokenCount = EstimateTokens(inputText)
        If tokenCount = "0" Then
            'لا يوجد تعديل
        Else
            'يوجد تعديل
            AIInformation_NumberOfTokensConsumed.Text = AIInformation_NumberOfTokensConsumed.Text + tokenCount
            AIInformation_NumberOfTokensRemaining.Text = AIInformation_NumberOfTokensRemaining.Text - tokenCount
            'البدء بحفظ البيانات

            ValidateChildren()

            AIInformationBasicDefentionBindingSource.EndEdit()
            AIInformationBasicDefentionTableAdapter.Update(DataSet1.AIInformationBasicDefention)
            AIInformationBasicDefentionTableAdapter.Fill(DataSet1.AIInformationBasicDefention)

            InfoAnalysis_ConsumerMST1.Text = AIInformation_NumberOfTokensConsumed.Text
            InfoAnalysis_RemainMST1.Text = AIInformation_NumberOfTokensRemaining.Text

        End If
    End Sub
    Private Sub InfoAnalysis_CountTokenEstimateMST1_MouseHover(sender As Object, e As EventArgs) Handles InfoAnalysis_CountTokenEstimateMST2.MouseHover
        Dim Text As String
        If Main_Screen.MS_ActionBarLanguage.Text = "" Then
            Text = ""
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "عربي" Then
            Text = "إضغط هنا لمعرفة عدد الرموز التقريبي " & Me.Text
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "إنجليزي" Then
            Text = "Press Here To Get Tokens No. " & Me.Text
        Else
            Text = ""
        End If
        ToolTip1.SetToolTip(MenuStrip_InformationMST2, Text)
    End Sub
#End Region

#Region "كود تحليل نص الحكم باستخدام الذكاء الاصطناعي"
    Private ReadOnly _ai As New AiClient()
    Private Function TryExtractJson(text As String) As String
        ' يحاول استخراج أول كائن JSON من النص
        Dim startIdx = text.IndexOf("{")
        Dim endIdx = text.LastIndexOf("}")
        If startIdx >= 0 AndAlso endIdx > startIdx Then
            Return text.Substring(startIdx, endIdx - startIdx + 1)
        End If
        Return text ' قد يكون أصلاً JSON نظيف
    End Function
    Private Async Sub InfoAnalysis_AnalysisJudicialMST2_Click(sender As Object, e As EventArgs) Handles InfoAnalysis_AnalysisJudicialMST2.Click
#Region "كود قديم وشغال "
        'Try
        '    'MsgBox(11111111111111)

        '    InfoAnalysis_AnalysisJudicialMST1.Enabled = False
        '    rtbOutput.Clear()
        '    Dim fullText = Information_Text.Text
        '    If String.IsNullOrWhiteSpace(fullText) Then
        '        MessageBox.Show("الرجاء لصق نص الحكم أولاً.")
        '        Return
        '    End If
        '    'MsgBox(2222222222)
        '    ' 1) تقسيم إلى مقاطع
        '    Dim chunks = LegalAnalysis.SplitIntoChunks(fullText, 6000)
        '    'MsgBox(333333333333)
        '    ' 2) استدعاء الذكاء الاصطناعي على كل مقطع وإعادة الدمج
        '    Dim partialJsons As New List(Of String)()
        '    'MsgBox(44444444444444)
        '    'MsgBox(chunks.Count)
        '    For i = 0 To chunks.Count - 1
        '        'MsgBox(555555555)
        '        Dim sys = LegalAnalysis.BuildSystemPrompt()
        '        'MsgBox(5555555551111)
        '        Dim usr = LegalAnalysis.BuildUserPrompt(chunks(i))
        '        'MsgBox(55555555522222)
        '        Dim aiText = Await _ai.ChatAsync(sys, usr, 0.2)
        '        'MsgBox(6666666666)
        '        ' تأكد أن المخرجات JSON فقط. إن وُجد نص زائد حاول اقتطاع أول/آخر قوسين {}.
        '        Dim cleaned = TryExtractJson(aiText)
        '        'MsgBox(7777777777)
        '        partialJsons.Add(cleaned)
        '        'MsgBox(888888888888)
        '        rtbOutput.AppendText($"تم تحليل المقطع {i + 1}/{chunks.Count}.{Environment.NewLine}")
        '    Next
        '    'MsgBox(99999999999)
        '    ' 3) دمج
        '    Dim merged = LegalAnalysis.MergeResults(partialJsons)
        '    ' 4) عرض JSON النهائي + عرض نص مقروء
        '    Dim finalJson = JsonConvert.SerializeObject(merged, Formatting.Indented)

        '    rtbOutput.AppendText(Environment.NewLine & "===== JSON النهائي =====" & Environment.NewLine)
        '    rtbOutput.AppendText(finalJson & Environment.NewLine)


        '    rtbOutput.AppendText(Environment.NewLine & "===== عرض مقروء =====" & Environment.NewLine)
        '    rtbOutput.AppendText(LegalAnalysis.ResultToPrettyText(merged))
        '    'MsgBox(10101010101)
        'Catch ex As Exception
        '    MessageBox.Show("خطأ: " & ex.Message)
        'Finally
        '    InfoAnalysis_AnalysisJudicialMST1.Enabled = True
        '    Token_SaveCalculate()
        'End Try


#End Region

        Try
            Result_Header.Text = " جاري العمل على تحليل نص القرار........... "
            Result_Header.ForeColor = Color.DarkRed
            rtbOutput.Text = ""
            Dim client As New AiClient() '(txtApiKey.Text)
            Dim systemPrompt As String = "أنت خبير قانوني يشرح نص الحكم بالعربية المبسطة."
            Dim userPrompt As String = "اريد تحليل معمق لقرار نص الحكم القضائي بالتفصيل: " & vbCrLf & Information_Text.Text
            Dim result As String = Await client.ChatAsync(systemPrompt, userPrompt)
            'rtbOutput.Text = result
            Text_New = result
            If Text_New = "" Then
            Else
                'Information_Text.Clear()
                'Dim Text As String = Information_Text.Text
                ' عرض الأحرف واحدًا تلو الآخر
                For Each ch As Char In Text_New
                    rtbOutput.AppendText(ch)
                    Application.DoEvents()
                    'Threading.Thread.Sleep(0) ' تأخير زمني بسيط (100 ملي ثانية)
                Next
            End If
            Result_Header.Text = "تم الإتهاء من تحليل الحكم القضائي هل ترغب بأن أقوم لك بعمل شيئ آخر "
        Catch ex As Exception
            rtbOutput.Text = "خطأ: " & ex.Message
            Exit Sub
        End Try
        Token_SaveCalculate()
    End Sub
    Private Sub InfoAnalysis_AnalysisJudicialMST2_MouseHover(sender As Object, e As EventArgs) Handles InfoAnalysis_AnalysisJudicialMST2.MouseHover
        Dim Text As String
        If Main_Screen.MS_ActionBarLanguage.Text = "" Then
            Text = ""
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "عربي" Then
            Text = "إضغط هنا لتحليل نص الحكم " & HeaderText.Text
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "إنجليزي" Then
            Text = "Press here to analyze the ruling  " & HeaderText.Text
        Else
            Text = ""
        End If
        ToolTip1.SetToolTip(MenuStrip_InformationMST2, Text)
    End Sub
#End Region

#Region "كود تشكيل النص"
    Private Async Sub InfoAnalysis_TashkeelTextMST2_Click(sender As Object, e As EventArgs) Handles InfoAnalysis_TashkeelTextMST2.Click
        Dim input As String = Information_Text.Text.Trim()
        If String.IsNullOrEmpty(input) Then
            MessageBox.Show("الرجاء إدخال نص لتشكيله", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
            Exit Sub
        End If
        rtbOutput.Text = "جاري التشكيل..."
        Dim result As String = Await _ai.DiacritizeAsync(input)
        rtbOutput.Text = result

        Token_SaveCalculate()

    End Sub
    Private Sub InfoAnalysis_TashkeelTextMST2_MouseHover(sender As Object, e As EventArgs) Handles InfoAnalysis_TashkeelTextMST2.MouseHover
        Dim Text As String
        If Main_Screen.MS_ActionBarLanguage.Text = "" Then
            Text = ""
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "عربي" Then
            Text = "إضغط هنا لتشكيل النص "
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "إنجليزي" Then
            Text = "Press here to Tashkeel The Text  "
        Else
            Text = ""
        End If
        ToolTip1.SetToolTip(MenuStrip_InformationMST2, Text)
    End Sub
#End Region

#Region "كود شرح نص القانون"
    Private Async Sub InfoAnalyisi_LawExplanationMST2_Click(sender As Object, e As EventArgs) Handles InfoAnalyisi_LawExplanationMST2.Click
        Try
            rtbOutput.Text = "جاري المعالجة..."
            Dim client As New AiClient() '(txtApiKey.Text)
            Dim systemPrompt As String = ""
            Dim userPrompt As String = ""

            Dim SP As String = ""
            Dim UP As String = ""


            If FormID = 1 Then
                SP = "أنت خبير قانوني يشرح نص الحكم بالعربية المبسطة."
                UP = "اريد تحليل معمق لقرار نص الحكم القضائي بالتفصيل: "
            ElseIf FormID = 2 Then
                'شاشة تعريف أسماء المحامين Lawyer_Info1
                SP = "أنت مساعد ذكي مختص في تقديم معلومات عامة وموثوقة عن المحامين" &
                                               " عند ذكر المعلومات، احرص على " &
                                    vbNewLine & "ذكر التخصص" &
                                    vbNewLine & "ذكر العنوان التفصيلي" &
                                    vbNewLine & "ذكر الخبرات المهنية" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للقانون"
                UP = "أريد معلومات عن المحامي [اسم المحامي]. أود معرفة تخصصه، موقع مكتبه، وخبرته المهنية بالعربية المبسطة: "
            ElseIf FormID = 16 Then
                'شاشة المرجعيات الرئيسية لأماكن تقديم الخدمات Law1 form
                If Law1.RefreshID = -2 Then
                    'صفحة أماكن تقديم الخدمة
                    SP = "أنت مساعد ذكي مختص في تقديم معلومات عامة وموثوقة عن المؤسسات والشركات العامة والخاصة، مثل ، ، ، . يجب احترام الخصوصية وعدم تقديم معلومات حساسة أو غير متاحة للعامة. كن دقيقًا ومحترمًا في الإجابة بالعربية المبسطة." &
                     " عند ذكر المعلومات، احرص على " &
                     vbNewLine & "ذكر مجالات عملها" &
                     vbNewLine & "ذكر العنوان والموقع الجغرافي" &
                     vbNewLine & "ذكر الخدمات التي تقدمها" &
                     vbNewLine & "ذكر الهيكل التنظيمي" &
                     vbNewLine & "ذكر تاريخ تاسيسها" &
                     vbNewLine & "ذكر الخدمات الإلكترونية" &
                     vbNewLine & "ذكر الأدلة الإرشادية" &
                     vbNewLine & "ذكر التشريعات وتفصيلاتها"

                    UP = "أريد معلومات عن الشركة/المؤسسة [اسم الشركة أو المؤسسة] الخدمات بشكل مفصل بالعربية المبسطة: "
                ElseIf Law1.RefreshID = -1 Then
                    'صفحة مرجعيات أماكن تقديم الخدمة
                    SP = "أنت خبير بدوائر المؤسسات بالعربية المبسطة."
                    UP = "أعطني شرحا مفصلا عن اسم الدائرة بشكل مفصل بالعربية المبسطة: "
                ElseIf Law1.RefreshID = 0 Then
                    'صفحة اسماء التشريعات الرئيسية
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية و متخصص في تحليل وشرح التشريعات. وظيفتك تقديم شروحات دقيقة ومبسطة للتشريعات وفق السياق القانوني المعتمد " &
                                               " عند شرح التشريع، احرص على " &
                                    vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                    vbNewLine & "توضح اسم القانون الكامل وتاريخه إن وُجد" &
                                    vbNewLine & "تبيّن هدف القانون والجهة المُصدِرة له" &
                                    vbNewLine & "تُقسّمه إلى إصداراته الرئيسية مع تاريخ الإصدار" &
                                    vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                    vbNewLine & "تُقارن إن أمكن بقوانين مشابهة في دول أخرى" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للقانون"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم ومفصل بالعربية المبسطة"
                ElseIf Law1.RefreshID = 16001 Then
                    'صفحة إصدارات التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل التشريعات بحسب اسم التشريع، رقمه، وسنة صدوره. عندما يُطلب منك توضيح تشريع معين. وظيفتك تقديم شروحات دقيقة ومبسطة للتشريعات وفق السياق القانوني المعتمد " &
                                               " عند شرح إصدار التشريع، احرص على " &
                                    vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                    vbNewLine & "توضح اسم التشريع الكامل وتاريخه إن وُجد" &
                                    vbNewLine & "تبيّن هدف التشريع والجهة المُصدِرة له" &
                                    vbNewLine & "تبيّن التعديلات التي طرأت على التشريع" &
                                    vbNewLine & "تُقسّمه إلى كتبه" &
                                    vbNewLine & "تُقسّمه إلى أبوابه" &
                                    vbNewLine & "تُقسّمه إلى فصوله" &
                                    vbNewLine & "تُقسّمه إلى أقسامه" &
                                    vbNewLine & "تُقسّمه إلى مواد القانون" &
                                    vbNewLine & "تشرح أهم المواد أو المبادئ التي يقوم عليها" &
                                    vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                    vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للتشريع"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & " مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                ElseIf Law1.RefreshID = 160011 Then
                    'صفحة إصدارات التشريع/التشريعات المعدلة
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf Law1.RefreshID = 16002 Then
                    'صفحة كتب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf Law1.RefreshID = 16003 Then
                    'صفحة ابواب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf Law1.RefreshID = 16004 Then
                    'صفحة اقسام التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf Law1.RefreshID = 16005 Then
                    'صفحة فصول التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf Law1.RefreshID = 16006 Then
                    'صفحة تعريف تصنيف التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf Law1.RefreshID = 16007 Then
                    'صفحة مواد التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية و متخصص في شرح وتحليل المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح مادة قانونية معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للتشريعات وفق السياق القانوني المعتمد " &
                                               " عند شرح مادة التشريع، احرص على " &
                                   vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                   vbNewLine & "تذكر النص الكامل للمادة (إن أمكن)" &
                                   vbNewLine & "تشرح المقصود من المادة بلغة مبسطة ودقيقة" &
                                   vbNewLine & "تبيّن التعديلات التي طرأت على المادة" &
                                   vbNewLine & "تبيّن السياق القانوني الذي تندرج فيه المادة (مثلاً: الباب أو الفصل)" &
                                   vbNewLine & "توضّح الهدف من المادة ودورها في النظام القانوني" &
                                   vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                   vbNewLine & "توضح ما إذا كانت المادة خضعت لتعديل أو إن كانت هناك مواد مرتبطة بها" &
                                   vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالمواد" &
                                   vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة بها" &
                                   vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                   vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                   vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                   vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للمواد"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & " مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                ElseIf Law1.RefreshID = 16008 Then
                    ' صفحة تعريف فقرات مواد التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل فقرات المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح فقرة مادة تشريع معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للفقرة وفق السياق القانوني المعتمد " &
                                               " عند شرح فقرة مادة التشريع، احرص على " &
                                    vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                    vbNewLine & "تذكر النص الكامل للفقرة (إن أمكن)" &
                                    vbNewLine & "تشرح المقصود من الفقرة بلغة مبسطة ودقيقة" &
                                    vbNewLine & "تبيّن التعديلات التي طرأت على الفقرة" &
                                    vbNewLine & "تبيّن السياق القانوني الذي تندرج فيه الفقرة (مثلاً: بند)" &
                                    vbNewLine & "توضّح الهدف من االفقرة ودورها في النظام القانوني" &
                                    vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                    vbNewLine & "توضح ما إذا كانت الفقرة خضعت لتعديل أو إن كانت هناك مواد أو فقرات مرتبطة بها" &
                                    vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالفقرات" &
                                    vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                    vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للفقرة"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                ElseIf Law1.RefreshID = 16009 Then
                    ' صفحة تعريف بنود فقرة مواد التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل بنود فقرات المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح بند فقرة مادة تشريع معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للبند وفق السياق القانوني المعتمد " &
                                               " عند شرح بند فقرة مادة التشريع، احرص على " &
                                                vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                                vbNewLine & "تذكر النص الكامل للبند (إن أمكن)" &
                                                vbNewLine & "تشرح المقصود من البند بلغة مبسطة ودقيقة" &
                                                vbNewLine & "تبيّن التعديلات التي طرأت على البند" &
                                                vbNewLine & "تبيّن السياق القانوني الذي يندرج فيه البند " &
                                                vbNewLine & "توضّح الهدف من البند ودوره في النظام القانوني" &
                                                vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                                vbNewLine & "توضح ما إذا كان البند خضع لتعديل أو إن كانت هناك مواد أو فقرات او بنود مرتبطة بها" &
                                                vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالبنود" &
                                                vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                                vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                                vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                                vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                                vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للبند"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                ElseIf Law1.RefreshID = 16010 Then
                    ' صفحة إستعراض مواد التشريع
                    If Law1.View_DefineLegType.Text = "0" Then
                        If Law1.View_ArticleID.Text = "" Then
                            SP = ""
                            UP = ""
                        Else
                            SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية و متخصص في شرح وتحليل المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح مادة قانونية معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للتشريعات وفق السياق القانوني المعتمد " &
                                               " عند شرح مادة التشريع، احرص على " &
                                   vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                   vbNewLine & "تذكر النص الكامل للمادة (إن أمكن)" &
                                   vbNewLine & "تشرح المقصود من المادة بلغة مبسطة ودقيقة" &
                                   vbNewLine & "تبيّن التعديلات التي طرأت على المادة" &
                                   vbNewLine & "تبيّن السياق القانوني الذي تندرج فيه المادة (مثلاً: الباب أو الفصل)" &
                                   vbNewLine & "توضّح الهدف من المادة ودورها في النظام القانوني" &
                                   vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                   vbNewLine & "توضح ما إذا كانت المادة خضعت لتعديل أو إن كانت هناك مواد مرتبطة بها" &
                                   vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالمواد" &
                                   vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة بها" &
                                   vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                   vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                   vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                   vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للمواد"
                            UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & " مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                        End If
                    ElseIf Law1.View_DefineLegType.Text = "1" Then
                        If Law1.View_Filtersub1ID.Text = "" Then
                            SP = ""
                            UP = ""
                        Else
                            SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل فقرات المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح فقرة مادة تشريع معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للفقرة وفق السياق القانوني المعتمد " &
                                               " عند شرح فقرة مادة التشريع، احرص على " &
                                    vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                    vbNewLine & "تذكر النص الكامل للفقرة (إن أمكن)" &
                                    vbNewLine & "تشرح المقصود من الفقرة بلغة مبسطة ودقيقة" &
                                    vbNewLine & "تبيّن التعديلات التي طرأت على الفقرة" &
                                    vbNewLine & "تبيّن السياق القانوني الذي تندرج فيه الفقرة (مثلاً: بند)" &
                                    vbNewLine & "توضّح الهدف من االفقرة ودورها في النظام القانوني" &
                                    vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                    vbNewLine & "توضح ما إذا كانت الفقرة خضعت لتعديل أو إن كانت هناك مواد أو فقرات مرتبطة بها" &
                                    vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالفقرات" &
                                    vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                    vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للفقرة"
                            UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                        End If
                    ElseIf Law1.View_DefineLegType.Text = "2" Then
                        If Law1.View_Filtersub2ID.Text = "" Then
                            SP = ""
                            UP = ""
                        Else
                            SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل بنود فقرات المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح بند فقرة مادة تشريع معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للبند وفق السياق القانوني المعتمد " &
                                               " عند شرح بند فقرة مادة التشريع، احرص على " &
                                                vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                                vbNewLine & "تذكر النص الكامل للبند (إن أمكن)" &
                                                vbNewLine & "تشرح المقصود من البند بلغة مبسطة ودقيقة" &
                                                vbNewLine & "تبيّن التعديلات التي طرأت على البند" &
                                                vbNewLine & "تبيّن السياق القانوني الذي يندرج فيه البند " &
                                                vbNewLine & "توضّح الهدف من البند ودوره في النظام القانوني" &
                                                vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                                vbNewLine & "توضح ما إذا كان البند خضع لتعديل أو إن كانت هناك مواد أو فقرات او بنود مرتبطة بها" &
                                                vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالبنود" &
                                                vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                                vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                                vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                                vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                                vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للبند"
                            UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                        End If
                    Else
                        SP = ""
                        UP = ""
                    End If
                ElseIf Law1.RefreshID = 16011 Then
                    ' صفحة إستعراض صور التشريع
                    SP = ""
                    UP = ""
                Else
                End If
            ElseIf FormID = 17 Then
                'شاشة تعريف هيكلية النظام القضائي judiciary
                If Judiciary.TabControlNo = "1" Then
                    'الدخول إلى الصفحة الاولى
                    SP = "أنت مساعد ذكي مختص في تقديم معلومات دقيقة وموثوقة عن النظام القضائي، هيكل المحاكم، أنواع المحاكم، اختصاصاتها، ودورها ضمن النظام القانوني. يجب أن تكون الإجابات واضحة، مفصلة، وموضوعية، مع احترام الخصوصية والقوانين المعمول بها."
                    UP = "اشرح أساس النظام القضائي التالي مع ذكر التشريعات القانونية بشكل مفصل بالعربية المبسطة: "
                ElseIf Judiciary.TabControlNo = "2" Then
                    'الدخول إلى الصفحة الثانية
                    SP = "أنت خبير قانوني يشرح أنواع الأنظمة الفضائية بالعربية المبسطة."
                    UP = "اشرح نوع النظام القضائي التالي مع ذكر التشريعات القانونية بشكل مفصل بالعربية المبسطة: "
                ElseIf Judiciary.TabControlNo = "3" Then
                    'الدخول إلى الصفحة الثالثة
                    SP = "أنت خبير قانوني يشرح أسماء الأنظمة الفضائية بالعربية المبسطة."
                    UP = "اشرح أسم النظام القضائي التالي مع ذكر التشريعات القانونية بشكل مفصل بالعربية المبسطة: "
                ElseIf Judiciary.TabControlNo = "4" Then
                    'الدخول إلى الصفحة الرابعة
                    SP = ""
                    UP = ""
                Else
                    'لا يوجد دخول
                    SP = ""
                    UP = ""
                End If
            ElseIf FormID = 31 Then
                'شاشة اماكن تقديم الخدمة الرئيسية
                SP = "أنت مساعد ذكي مختص في تقديم معلومات عامة وموثوقة عن المؤسسات والشركات العامة والخاصة، مثل ، ، ، . يجب احترام الخصوصية وعدم تقديم معلومات حساسة أو غير متاحة للعامة. كن دقيقًا ومحترمًا في الإجابة بالعربية المبسطة." &
                     " عند ذكر المعلومات، احرص على " &
                     vbNewLine & "ذكر مجالات عملها" &
                     vbNewLine & "ذكر العنوان والموقع الجغرافي" &
                     vbNewLine & "ذكر الخدمات التي تقدمها" &
                     vbNewLine & "ذكر الهيكل التنظيمي" &
                     vbNewLine & "ذكر تاريخ تاسيسها" &
                     vbNewLine & "ذكر الخدمات الإلكترونية" &
                     vbNewLine & "ذكر الأدلة الإرشادية" &
                     vbNewLine & "ذكر التشريعات وتفصيلاتها"
                UP = "أريد معلومات عن الشركة/المؤسسة [اسم الشركة أو المؤسسة] الخدمات بشكل مفصل بالعربية المبسطة: "
            ElseIf FormID = 34 Then
                'شاشة تعريف مسمى المرجعيات ClassificationRefrences_Form
                SP = "أنت خبير بمرجعية التشريعات بالعربية المبسطة."
                UP = "اشرح عن مرجعية التشريع بشكل مفصل بالعربية المبسطة: "
            ElseIf FormID = 123 Then
                'شاشة تعريف حالات ومواضيع الموكلين / تعريف تفاصيل الحالات / إدخال أسماء محامين الزيارة والموضوع Caseslawyerform
                If FormID = 123 Then
                    'الكود لايعمل هنا
                Else
                End If
            ElseIf FormID = 204 Or FormID = 1952 Then
                'شاشة تعريف النماذج للإجراءات الرئيسية/تعريف نص نموذج الإجراء الرئيسي/إنشاء المستند
                'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
                SP = "أنت خبير بالنماذج القانونية بالعربية المعمقة."
                UP = "اريد نموذج وثيقة قانونية مع التشريعات القانونية بشكل مفصل بالعربية المعمقة: "
            ElseIf FormID = 10000 Then
                'شاشة المرجعيات المخصصة للبحث LawFullStructure
                If LawFullStructure.TreeView1.SelectedNode.Level = "0" Then
                    'صفحة أماكن تقديم الخدمة
                    SP = "أنت مساعد ذكي مختص في تقديم معلومات عامة وموثوقة عن المؤسسات والشركات العامة والخاصة، مثل ، ، ، . يجب احترام الخصوصية وعدم تقديم معلومات حساسة أو غير متاحة للعامة. كن دقيقًا ومحترمًا في الإجابة بالعربية المبسطة." &
                     " عند ذكر المعلومات، احرص على " &
                     vbNewLine & "ذكر مجالات عملها" &
                     vbNewLine & "ذكر العنوان والموقع الجغرافي" &
                     vbNewLine & "ذكر الخدمات التي تقدمها" &
                     vbNewLine & "ذكر الهيكل التنظيمي" &
                     vbNewLine & "ذكر تاريخ تاسيسها" &
                     vbNewLine & "ذكر الخدمات الإلكترونية" &
                     vbNewLine & "ذكر الأدلة الإرشادية" &
                     vbNewLine & "ذكر التشريعات وتفصيلاتها"
                    UP = "أريد معلومات عن الشركة/المؤسسة [اسم الشركة أو المؤسسة] الخدمات بشكل مفصل بالعربية المبسطة: "
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "1" Then
                    'صفحة مرجعيات أماكن تقديم الخدمة
                    SP = "أنت خبير بدوائر المؤسسات بالعربية المبسطة."
                    UP = "أعطني شرحا مفصلا عن اسم الدائرة بشكل مفصل بالعربية المبسطة: "
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "2" Then
                    'صفحة اسماء التشريعات الرئيسية
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية و متخصص في تحليل وشرح التشريعات. وظيفتك تقديم شروحات دقيقة ومبسطة للتشريعات وفق السياق القانوني المعتمد " &
                                               " عند شرح التشريع، احرص على " &
                                    vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                    vbNewLine & "توضح اسم القانون الكامل وتاريخه إن وُجد" &
                                    vbNewLine & "تبيّن هدف القانون والجهة المُصدِرة له" &
                                    vbNewLine & "تُقسّمه إلى إصداراته الرئيسية مع تاريخ الإصدار" &
                                    vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                    vbNewLine & "تُقارن إن أمكن بقوانين مشابهة في دول أخرى" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للقانون"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم ومفصل بالعربية المبسطة"
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "3" Then
                    'صفحة إصدارات التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل التشريعات بحسب اسم التشريع، رقمه، وسنة صدوره. عندما يُطلب منك توضيح تشريع معين. وظيفتك تقديم شروحات دقيقة ومبسطة للتشريعات وفق السياق القانوني المعتمد " &
                                               " عند شرح إصدار التشريع، احرص على " &
                                    vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                    vbNewLine & "توضح اسم التشريع الكامل وتاريخه إن وُجد" &
                                    vbNewLine & "تبيّن هدف التشريع والجهة المُصدِرة له" &
                                    vbNewLine & "تبيّن التعديلات التي طرأت على التشريع" &
                                    vbNewLine & "تُقسّمه إلى كتبه" &
                                    vbNewLine & "تُقسّمه إلى أبوابه" &
                                    vbNewLine & "تُقسّمه إلى فصوله" &
                                    vbNewLine & "تُقسّمه إلى أقسامه" &
                                    vbNewLine & "تُقسّمه إلى مواد القانون" &
                                    vbNewLine & "تشرح أهم المواد أو المبادئ التي يقوم عليها" &
                                    vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                    vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للتشريع"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & " مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "4" Then
                    'صفحة كتب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "5" Then
                    'صفحة ابواب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "6" Then
                    'صفحة اقسام التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "7" Then
                    'صفحة فصول التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "8" Then
                    'صفحة تعريف تصنيف التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                    SP = ""
                    UP = ""
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "9" Or LawFullStructure.TreeView1.SelectedNode.Level = "10" Then
                    'صفحة مواد التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية و متخصص في شرح وتحليل المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح مادة قانونية معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للتشريعات وفق السياق القانوني المعتمد " &
                                               " عند شرح مادة التشريع، احرص على " &
                                   vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                   vbNewLine & "تذكر النص الكامل للمادة (إن أمكن)" &
                                   vbNewLine & "تشرح المقصود من المادة بلغة مبسطة ودقيقة" &
                                   vbNewLine & "تبيّن التعديلات التي طرأت على المادة" &
                                   vbNewLine & "تبيّن السياق القانوني الذي تندرج فيه المادة (مثلاً: الباب أو الفصل)" &
                                   vbNewLine & "توضّح الهدف من المادة ودورها في النظام القانوني" &
                                   vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                   vbNewLine & "توضح ما إذا كانت المادة خضعت لتعديل أو إن كانت هناك مواد مرتبطة بها" &
                                   vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالمواد" &
                                   vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة بها" &
                                   vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                   vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                   vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                   vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للمواد"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & " مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "11" Then
                    ' صفحة تعريف فقرات مواد التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل فقرات المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح فقرة مادة تشريع معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للفقرة وفق السياق القانوني المعتمد " &
                                               " عند شرح فقرة مادة التشريع، احرص على " &
                                    vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                    vbNewLine & "تذكر النص الكامل للفقرة (إن أمكن)" &
                                    vbNewLine & "تشرح المقصود من الفقرة بلغة مبسطة ودقيقة" &
                                    vbNewLine & "تبيّن التعديلات التي طرأت على الفقرة" &
                                    vbNewLine & "تبيّن السياق القانوني الذي تندرج فيه الفقرة (مثلاً: بند)" &
                                    vbNewLine & "توضّح الهدف من االفقرة ودورها في النظام القانوني" &
                                    vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                    vbNewLine & "توضح ما إذا كانت الفقرة خضعت لتعديل أو إن كانت هناك مواد أو فقرات مرتبطة بها" &
                                    vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالفقرات" &
                                    vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                    vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                    vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                    vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                    vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للفقرة"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "12" Then
                    ' صفحة تعريف بنود فقرة مواد التشريع
                    SP = "أنت مساعد قانوني ذكي وخبير في شرح المفاهيم القانونية والتشريعية ومتخصص في شرح وتحليل بنود فقرات المواد القانونية من القوانين والتشريعات المختلفة. عندما يُطلب منك شرح بند فقرة مادة تشريع معينة. وظيفتك تقديم شروحات دقيقة ومبسطة للبند وفق السياق القانوني المعتمد " &
                                               " عند شرح بند فقرة مادة التشريع، احرص على " &
                                                vbNewLine & "اشرح لي محتوى النص التشريعي والهيكل الداخلي له بالتفصيل" &
                                                vbNewLine & "تذكر النص الكامل للبند (إن أمكن)" &
                                                vbNewLine & "تشرح المقصود من البند بلغة مبسطة ودقيقة" &
                                                vbNewLine & "تبيّن التعديلات التي طرأت على البند" &
                                                vbNewLine & "تبيّن السياق القانوني الذي يندرج فيه البند " &
                                                vbNewLine & "توضّح الهدف من البند ودوره في النظام القانوني" &
                                                vbNewLine & "تذكر أمثلة أو تطبيقات عملية إن وُجدت (مثل تطبيق قضائي، أو حالة عملية)" &
                                                vbNewLine & "توضح ما إذا كان البند خضع لتعديل أو إن كانت هناك مواد أو فقرات او بنود مرتبطة بها" &
                                                vbNewLine & "تُحافظ على أسلوب مهني، قانوني، وواضح للجمهور القانوني أو المهتمين بالبنود" &
                                                vbNewLine & "تذكر أبرز التطبيقات أو القضايا المتعلقة به" &
                                                vbNewLine & "تُقارن إن أمكن بتشريعات مشابهة في دول أخرى" &
                                                vbNewLine & "لا تستخدم أي معلومات غير مؤكدة" &
                                                vbNewLine & "مع ذكر قرارات محكمة التمييز وارقامها ان وجدت وذكر القرار مع الشرح وذكر المرجع القانوني" &
                                                vbNewLine & "استخدم لغة قانونية مبسطة لكنها دقيقة، وركّز على الفهم العملي للبند"
                    UP = "أريد شرحا تفصيليا لِ" & Information_Text.Text & "مع الشرح بشكل رسمي ومنظم و مفصل بالعربية المبسطة"
                Else
                    SP = ""
                    UP = ""
                    rtbOutput.Text = "لا يوجد نص مدخل الرجاء ادخال نص : "
                    Exit Sub
                End If
            Else
                SP = ""
                UP = ""
                rtbOutput.Text = "لا يوجد نص مدخل الرجاء ادخال نص : "
                Exit Sub
            End If


            If SP = "" Or UP = "" Then
                rtbOutput.Text = "لا يوجد نص مدخل الرجاء ادخال نص : "
                Exit Sub
            Else
                'استكمال الفحص
            End If

            systemPrompt = SP
            userPrompt = UP & vbCrLf & Information_Text.Text
            Dim result As String = Await client.ChatAsync(systemPrompt, userPrompt)

            Dim start_info As String = ""
            If FormID = 1 Then

            ElseIf FormID = 2 Then
                'شاشة تعريف أسماء المحامين Lawyer_Info1
                start_info = "أسم " & Lawyer_Info1.Law_TitlePrefixDes.Text & " " & Lawyer_Info1.Law_FullN.Text & " " & Lawyer_Info1.Law_TitleSuffixDes.Text
            ElseIf FormID = 16 Then
                'شاشة المرجعيات الرئيسية لأماكن تقديم الخدمات Law1 form
                If Law1.RefreshID = -2 Then
                    'صفحة أماكن تقديم الخدمة
                    start_info = " مرجعية الخدمـــة " & Tem_SL_CorpRefClassBS0.Text &
                     vbNewLine & " رقم الهــــــاتف " & Tem_SL_PhoneBS0.Text &
                     vbNewLine & " رقم الفــــــاكس " & Tem_SL_FaxBS0.Text &
                     vbNewLine & " رقم الموبايــــل " & Tem_SL_MobileBS0.Text &
                     vbNewLine & " الموقع الإلكتروني " & Tem_SL_WebsiteBS0.Text &
                     vbNewLine & " البريد الإلكتروني " & Tem_SL_EmailBS0.Text &
                     vbNewLine & " عنوان المنشـــأة " & Tem_SL_FullAddressBS0.Text & " " & Tem_SL_DetailAddressBS0.Text
                ElseIf Law1.RefreshID = -1 Then
                    'صفحة مرجعيات أماكن تقديم الخدمة
                    start_info = " مكان تقديم الخدمة " & Law1.SL_HeaderDes.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & Law1.SL_HeaderRefCatDes.Text
                ElseIf Law1.RefreshID = 0 Then
                    'صفحة اسماء التشريعات الرئيسية
                    start_info = " مكان تقديم الخدمة " & Law1.SL_HeaderDes.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & Law1.SL_HeaderRefCatDes.Text &
                     vbNewLine & " مرجعية التشريـــع " & Law1.Legislation_HeaderMRefDes.Text
                ElseIf Law1.RefreshID = 16001 Then
                    'صفحة إصدارات التشريع
                    start_info = " مكان تقديم الخدمة " & Law1.SL_HeaderDes.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & Law1.SL_HeaderRefCatDes.Text &
                     vbNewLine & " مرجعية التشريـــع " & Law1.Legislation_HeaderMRefDes.Text &
                     vbNewLine & " التشريع الرئيــسي " & Law1.Law_HeadLegislationDes.Text &
                     vbNewLine & Law1.Law_IssuanceInfo.Text & " العدد رقم  " & Law1.Law_IssuanceLegislationSerialNo.Text
                ElseIf Law1.RefreshID = 160011 Then
                    'صفحة إصدارات التشريع/التشريعات المعدلة
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf Law1.RefreshID = 16002 Then
                    'صفحة كتب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf Law1.RefreshID = 16003 Then
                    'صفحة ابواب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf Law1.RefreshID = 16004 Then
                    'صفحة اقسام التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf Law1.RefreshID = 16005 Then
                    'صفحة فصول التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf Law1.RefreshID = 16006 Then
                    'صفحة تعريف تصنيف التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf Law1.RefreshID = 16007 Then
                    'صفحة مواد التشريع
                    start_info = " مكان تقديم الخدمة " & Law1.LawHeadline_SLDes.Text &
                    vbNewLine & " تصنيف المرجعيـــة " & Law1.LawHeadline_RefCatDes.Text &
                    vbNewLine & " مرجعية التشريـــع " & Law1.LawHeadline_LawDes.Text &
                    vbNewLine & " التشريع الرئيــسي " & Law1.TextBox3.Text &
                    vbNewLine & " التشريع المصـــدر " & Law1.LawMainAddress_Lawname.Text &
                    vbNewLine & Law1.Law_IssuanceInfo.Text & " العدد رقم  " & Law1.Law_IssuanceLegislationSerialNo.Text &
                    vbNewLine & Law1.Article_Serial.Text &
                    vbNewLine & Law1.Article_Description7.Text & " " & Law1.Article_Description8.Text
                ElseIf Law1.RefreshID = 16008 Then
                    ' صفحة تعريف فقرات مواد التشريع
                    start_info = " مكان تقديم الخدمة " & Law1.LawHeadline_SLDes.Text &
                   vbNewLine & " تصنيف المرجعيـــة " & Law1.LawHeadline_RefCatDes.Text &
                   vbNewLine & " مرجعية التشريـــع " & Law1.LawHeadline_LawDes.Text &
                   vbNewLine & " التشريع الرئيــسي " & Law1.TextBox3.Text &
                   vbNewLine & " التشريع المصـــدر " & Law1.LawMainAddress_Lawname.Text &
                   vbNewLine & Law1.Law_IssuanceInfo.Text & " العدد رقم  " & Law1.Law_IssuanceLegislationSerialNo.Text &
                   vbNewLine & Law1.Filtersub1_Serial.Text &
                   vbNewLine & Law1.Article_Description7.Text & " " & Law1.Filtersub1_Decribtion9.Text & " " & Law1.Filtersub1_Description10Des.Text
                ElseIf Law1.RefreshID = 16009 Then
                    ' صفحة تعريف بنود فقرة مواد التشريع
                    start_info = " مكان تقديم الخدمة " & Law1.LawHeadline_SLDes.Text &
                   vbNewLine & " تصنيف المرجعيـــة " & Law1.LawHeadline_RefCatDes.Text &
                   vbNewLine & " مرجعية التشريـــع " & Law1.LawHeadline_LawDes.Text &
                   vbNewLine & " التشريع الرئيــسي " & Law1.TextBox3.Text &
                   vbNewLine & " التشريع المصـــدر " & Law1.LawMainAddress_Lawname.Text &
                   vbNewLine & Law1.Law_IssuanceInfo.Text & " العدد رقم  " & Law1.Law_IssuanceLegislationSerialNo.Text &
                   vbNewLine & Law1.Filtersub2_Serial.Text &
                   vbNewLine & Law1.Article_Description7.Text & " " & Law1.Filtersub1_Decribtion9.Text & " " & Law1.Filtersub2_Description11.Text & " " & Law1.Filtersub2_Description12.Text
                ElseIf Law1.RefreshID = 16010 Then
                    ' صفحة إستعراض مواد التشريع
                    If Law1.View_DefineLegType.Text = "0" Then
                        If Law1.View_ArticleID.Text = "" Then

                        Else
                            start_info = " مكان تقديم الخدمة " & Law1.Article_HeaderSLDes.Text &
                            vbNewLine & " تصنيف المرجعيـــة " & Law1.Article_HeaderRefCatDes.Text &
                            vbNewLine & " مرجعية التشريـــع " & Law1.Article_HeaderRefDes.Text &
                            vbNewLine & " التشريع الرئيــسي " & Law1.TextBox6.Text &
                            vbNewLine & " التشريع المصـــدر " & Law1.Article_HeaderLawDes.Text &
                            vbNewLine & Law1.Law_IssuanceInfo.Text & " العدد رقم  " & Law1.Law_IssuanceLegislationSerialNo.Text &
                            vbNewLine & Law1.View_ArticleBookDes.Text & " / " & Law1.View_ArticleChapterDes.Text & " / " & Law1.View_ArticleSectionDes.Text & " / " & Law1.View_ArticlePartDes.Text & " / " & Law1.View_ArticleCatDes.Text &
                            vbNewLine & Law1.View_ArticleArticleNameDes.Text & " " & Law1.View_ArticleArticleDes.Text
                        End If
                    ElseIf Law1.View_DefineLegType.Text = "1" Then
                        If Law1.View_Filtersub1ID.Text = "" Then

                        Else
                            start_info = " مكان تقديم الخدمة " & Law1.Article_HeaderSLDes.Text &
                            vbNewLine & " تصنيف المرجعيـــة " & Law1.Article_HeaderRefCatDes.Text &
                            vbNewLine & " مرجعية التشريـــع " & Law1.Article_HeaderRefDes.Text &
                            vbNewLine & " التشريع الرئيــسي " & Law1.TextBox6.Text &
                            vbNewLine & " التشريع المصـــدر " & Law1.Article_HeaderLawDes.Text &
                            vbNewLine & Law1.Law_IssuanceInfo.Text & " العدد رقم  " & Law1.Law_IssuanceLegislationSerialNo.Text &
                            vbNewLine & Law1.View_ArticleBookDes.Text & " / " & Law1.View_ArticleChapterDes.Text & " / " & Law1.View_ArticleSectionDes.Text & " / " & Law1.View_ArticlePartDes.Text & " / " & Law1.View_ArticleCatDes.Text &
                            vbNewLine & Law1.View_Filtersub1NameDes.Text & " " & Law1.View_Filtersub1Des.Text
                        End If
                    ElseIf Law1.View_DefineLegType.Text = "2" Then
                        If Law1.View_Filtersub2ID.Text = "" Then

                        Else
                            start_info = " مكان تقديم الخدمة " & Law1.Article_HeaderSLDes.Text &
                            vbNewLine & " تصنيف المرجعيـــة " & Law1.Article_HeaderRefCatDes.Text &
                            vbNewLine & " مرجعية التشريـــع " & Law1.Article_HeaderRefDes.Text &
                            vbNewLine & " التشريع الرئيــسي " & Law1.TextBox6.Text &
                            vbNewLine & " التشريع المصـــدر " & Law1.Article_HeaderLawDes.Text &
                            vbNewLine & Law1.Law_IssuanceInfo.Text & " العدد رقم  " & Law1.Law_IssuanceLegislationSerialNo.Text &
                            vbNewLine & Law1.View_ArticleBookDes.Text & " / " & Law1.View_ArticleChapterDes.Text & " / " & Law1.View_ArticleSectionDes.Text & " / " & Law1.View_ArticlePartDes.Text & " / " & Law1.View_ArticleCatDes.Text &
                            vbNewLine & Law1.View_Filtersub2NameDes.Text & " " & Law1.View_Filtersub2Des.Text
                        End If
                    Else

                    End If
                ElseIf Law1.RefreshID = 16011 Then
                    ' صفحة إستعراض صور التشريع

                Else
                End If
            ElseIf FormID = 17 Then
                'شاشة تعريف هيكلية النظام القضائي judiciary
                If Judiciary.TabControlNo = "1" Then
                    'الدخول إلى الصفحة الاولى
                    start_info = "أساس النظام القضائي " & Judiciary.JudiciaryBasics.Text
                ElseIf Judiciary.TabControlNo = "2" Then
                    'الدخول إلى الصفحة الثانية
                    start_info = "أساس النظام القضائي " & Judiciary.JudiciaryBasics.Text &
                     vbNewLine & "نـوع النظام القضائي " & Judiciary.JudType_Des.Text
                ElseIf Judiciary.TabControlNo = "3" Then
                    'الدخول إلى الصفحة الثالثة
                    start_info = "أساس النظام القضائي " & Judiciary.JudiciaryBasics.Text &
                     vbNewLine & "نـوع النظام القضائي " & Judiciary.JudType_Des.Text &
                     vbNewLine & "اسـم النظام القضائي " & Judiciary.JSC_Sp.Text
                ElseIf Judiciary.TabControlNo = "4" Then
                    'الدخول إلى الصفحة الرابعة
                    start_info = ""
                Else
                    'لا يوجد دخول
                    start_info = ""
                End If
            ElseIf FormID = 31 Then
                'شاشة اماكن تقديم الخدمة الرئيسية
                start_info = " مرجعية الخدمـــة " & Tem_SL_CorpRefClassBS0.Text &
                 vbNewLine & " رقم الهــــــاتف " & Tem_SL_PhoneBS0.Text &
                 vbNewLine & " رقم الفــــــاكس " & Tem_SL_FaxBS0.Text &
                 vbNewLine & " رقم الموبايــــل " & Tem_SL_MobileBS0.Text &
                 vbNewLine & " الموقع الإلكتروني " & Tem_SL_WebsiteBS0.Text &
                 vbNewLine & " البريد الإلكتروني " & Tem_SL_EmailBS0.Text &
                 vbNewLine & " عنوان المنشـــأة " & Tem_SL_FullAddressBS0.Text & " " & Tem_SL_DetailAddressBS0.Text
            ElseIf FormID = 34 Then
                'شاشة تعريف مسمى المرجعيات ClassificationRefrences_Form
                start_info = ""
            ElseIf FormID = 123 Then
                'شاشة تعريف حالات ومواضيع الموكلين / تعريف تفاصيل الحالات / إدخال أسماء محامين الزيارة والموضوع Caseslawyerform
                If FormID = 123 Then
                    'الكود لايعمل هنا
                Else
                End If
            ElseIf FormID = 204 Or FormID = 1952 Then
                'شاشة تعريف النماذج للإجراءات الرئيسية/تعريف نص نموذج الإجراء الرئيسي/إنشاء المستند
                'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
                start_info = ""
            ElseIf FormID = 10000 Then
                'شاشة المرجعيات المخصصة للبحث LawFullStructure
                If LawFullStructure.TreeView1.SelectedNode.Level = "0" Then
                    'صفحة أماكن تقديم الخدمة
                    start_info = " مرجعية الخدمـــة " & Tem_SL_CorpRefClassBS0.Text &
                     vbNewLine & " رقم الهــــــاتف " & Tem_SL_PhoneBS0.Text &
                     vbNewLine & " رقم الفــــــاكس " & Tem_SL_FaxBS0.Text &
                     vbNewLine & " رقم الموبايــــل " & Tem_SL_MobileBS0.Text &
                     vbNewLine & " الموقع الإلكتروني " & Tem_SL_WebsiteBS0.Text &
                     vbNewLine & " البريد الإلكتروني " & Tem_SL_EmailBS0.Text &
                     vbNewLine & " عنوان المنشـــأة " & Tem_SL_FullAddressBS0.Text & " " & Tem_SL_DetailAddressBS0.Text
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "1" Then
                    'صفحة مرجعيات أماكن تقديم الخدمة
                    start_info = " مكان تقديم الخدمة " & LawFullStructure.Tem_SLDesBS100.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & LawFullStructure.Tem_MainRefSyscodeDesBS100.Text
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "2" Then
                    'صفحة اسماء التشريعات الرئيسية
                    start_info = " مكان تقديم الخدمة " & LawFullStructure.Tem_SLDesBS100.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & LawFullStructure.Tem_MainRefSyscodeDesBS100.Text &
                     vbNewLine & " مرجعية التشريـــع " & LawFullStructure.Tem_MainRefDesBS100.Text
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "3" Then
                    'صفحة إصدارات التشريع
                    start_info = " مكان تقديم الخدمة " & LawFullStructure.Tem_SLDesBS100.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & LawFullStructure.Tem_MainRefSyscodeDesBS100.Text &
                     vbNewLine & " مرجعية التشريـــع " & LawFullStructure.Tem_MainRefDesBS100.Text &
                     vbNewLine & " التشريع الرئيــسي " & LawFullStructure.Tem_MainLegeslationDesBS100.Text &
                     vbNewLine & LawFullStructure.IssuanceLeg_Des.Text &
                                                       " العدد رقم  " & LawFullStructure.Tem_IssuedLawIssuedSerialNoBS100.Text
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "4" Then
                    'صفحة كتب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "5" Then
                    'صفحة ابواب التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "6" Then
                    'صفحة اقسام التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "7" Then
                    'صفحة فصول التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "8" Then
                    'صفحة تعريف تصنيف التشريع
                    'لا يجوز طلب التفصيلات من هنا ويمنع من الدخول من ملف التشريعات والمرجعيات
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "9" Or LawFullStructure.TreeView1.SelectedNode.Level = "10" Then
                    'صفحة مواد التشريع
                    start_info = " مكان تقديم الخدمة " & LawFullStructure.Tem_SLDesBS100.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & LawFullStructure.Tem_MainRefSyscodeDesBS100.Text &
                     vbNewLine & " مرجعية التشريـــع " & LawFullStructure.Tem_MainRefDesBS100.Text &
                     vbNewLine & " التشريع الرئيــسي " & LawFullStructure.Tem_MainLegeslationDesBS100.Text &
                     vbNewLine & " التشريع المصـــدر " & LawFullStructure.Tem_IssuedLawDesBS100.Text &
                     vbNewLine & LawFullStructure.IssuanceLeg_Des.Text & " العدد رقم  " & LawFullStructure.Tem_IssuedLawIssuedSerialNoBS100.Text &
                     vbNewLine & LawFullStructure.Tem_LawBookDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawChapterDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSectionDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawPartDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawCatDesBS100.Text &
                    vbNewLine & LawFullStructure.Tem_LawArticleDes7BS100.Text &
                                                                       " " & LawFullStructure.Tem_LawArticleDes8BS100.Text
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "11" Then
                    ' صفحة تعريف فقرات مواد التشريع
                    start_info = " مكان تقديم الخدمة " & LawFullStructure.Tem_SLDesBS100.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & LawFullStructure.Tem_MainRefSyscodeDesBS100.Text &
                     vbNewLine & " مرجعية التشريـــع " & LawFullStructure.Tem_MainRefDesBS100.Text &
                     vbNewLine & " التشريع الرئيــسي " & LawFullStructure.Tem_MainLegeslationDesBS100.Text &
                     vbNewLine & " التشريع المصـــدر " & LawFullStructure.Tem_IssuedLawDesBS100.Text &
                     vbNewLine & LawFullStructure.IssuanceLeg_Des.Text &
                                                           " العدد رقم  " & LawFullStructure.Tem_IssuedLawIssuedSerialNoBS100.Text &
                     vbNewLine & LawFullStructure.Tem_LawBookDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawChapterDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSectionDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawPartDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawCatDesBS100.Text &
                     vbNewLine & LawFullStructure.Tem_LawArticleDes7BS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSub1Des9BS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSub1Des10BS100.Text
                ElseIf LawFullStructure.TreeView1.SelectedNode.Level = "12" Then
                    ' صفحة تعريف بنود فقرة مواد التشريع
                    start_info = " مكان تقديم الخدمة " & LawFullStructure.Tem_SLDesBS100.Text &
                     vbNewLine & " تصنيف المرجعيـــة " & LawFullStructure.Tem_MainRefSyscodeDesBS100.Text &
                     vbNewLine & " مرجعية التشريـــع " & LawFullStructure.Tem_MainRefDesBS100.Text &
                     vbNewLine & " التشريع الرئيــسي " & LawFullStructure.Tem_MainLegeslationDesBS100.Text &
                     vbNewLine & " التشريع المصـــدر " & LawFullStructure.Tem_IssuedLawDesBS100.Text &
                     vbNewLine & LawFullStructure.IssuanceLeg_Des.Text &
                                                           " العدد رقم  " & LawFullStructure.Tem_IssuedLawIssuedSerialNoBS100.Text &
                     vbNewLine & LawFullStructure.Tem_LawBookDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawChapterDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSectionDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawPartDesBS100.Text &
                                                                       " " & LawFullStructure.Tem_LawCatDesBS100.Text &
                    vbNewLine & LawFullStructure.Tem_LawArticleDes7BS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSub1Des9BS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSub2Des11BS100.Text &
                                                                       " " & LawFullStructure.Tem_LawSub2Des12BS100.Text
                Else
                End If
            Else
                Exit Sub
            End If
            rtbOutput.Text = start_info &
                                     vbNewLine & result

        Catch ex As Exception
            rtbOutput.Text = "خطأ: " & ex.Message
            Exit Sub
        End Try
        Token_SaveCalculate()
        If rtbOutput.Text = "" Then
            'لم يتم جلب أية بيانات
        Else
            Information_Save()
        End If
    End Sub
    Private Sub InfoAnalyisi_LawExplanationMST2_MouseHover(sender As Object, e As EventArgs) Handles InfoAnalyisi_LawExplanationMST2.MouseHover
        Dim Text As String
        If Main_Screen.MS_ActionBarLanguage.Text = "" Then
            Text = ""
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "عربي" Then
            Text = "إضغط هنا لشرح تفصيلي للتشريع " & HeaderText.Text
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "إنجليزي" Then
            Text = "Press Here To Explanation The Legislation " & HeaderText.Text
        Else
            Text = ""
        End If
        ToolTip1.SetToolTip(MenuStrip_InformationMST2, Text)
    End Sub

#End Region



#Region "كود الخروج من الشاشة"
    Sub Exit_Form()
        If formID = "1" Then
            'ملف تحليل القرارات والاحكام
            AnalysisJudicialRulings_Form.Enabled = True
            AnalysisJudicialRulings_Form.BringToFront()
        ElseIf FormID = 2 Then
            'شاشة تعريف أسماء المحامين Lawyer_Info1
            Lawyer_Info1.Enabled = True
            Lawyer_Info1.BringToFront()
            Lawyer_Info1.Fill_Table()

            If Lawyer_Info1.FormID = 21 Then
                'فتح الملف من شاشة ملفات الموكلين
                Lawyer_Info1.Close()
                Cases_Form1.Enabled = True
                Cases_Form1.BringToFront()
            Else
            End If
        ElseIf FormID = 16 Then
            'شاشة المرجعيات الرئيسية لأماكن تقديم الخدمات Law1 form
            Law1.Enabled = True
            Law1.BringToFront()
            Law1.Fill_Table()
        ElseIf FormID = 17 Then
            'شاشة تعريف هيكلية النظام القضائي judiciary
            Judiciary.Enabled = True
            Judiciary.BringToFront()
            Judiciary.Fill_Table


        ElseIf FormID = 31 Then
            'شاشة اماكن تقديم الخدمة الرئيسية
            Service_Location.Enabled = True
            Service_Location.BringToFront()
            Service_Location.Fill_Table()
        ElseIf FormID = 34 Then
            'شاشة تعريف مسمى المرجعيات ClassificationRefrences_Form
            ClassificationRefrences_Form.Enabled = True
            ClassificationRefrences_Form.BringToFront()
            ClassificationRefrences_Form.Fill_Table
        ElseIf FormID = 123 Then
            'شاشة تعريف حالات ومواضيع الموكلين / تعريف تفاصيل الحالات / إدخال أسماء محامين الزيارة والموضوع Caseslawyerform
            If FormID = 123 Then
                Caseslawyerform.Enabled = True
                Caseslawyerform.BringToFront()
            Else
            End If
        ElseIf FormID = 195 Then
            'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
            ActionForm_Drafting.Enabled = True
            ActionForm_Drafting.BringToFront()
        ElseIf FormID = 204 Then
            'شاشة تعريف النماذج للإجراءات الرئيسية/تعريف نص نموذج الإجراء الرئيسي/إنشاء المستند
            Doc_Templates.Enabled = True
            Doc_Templates.BringToFront()
        ElseIf FormID = 1952 Then
            'شاشة تعريف الإجراءات والمتابعات/صفحة إدخال الإجراءات المطلوبة للموضوع/شاشة طلب نماذج الوثائق
            ActionForm_Drafting.Enabled = True
            ActionForm_Drafting.BringToFront()
        ElseIf FormID = 10000 Then
            'شاشة المرجعيات المخصصة للبحث LawFullStructure
            LawFullStructure.Enabled = True
            LawFullStructure.BringToFront()
            SendToBack()
            'MsgBox(LawFullStructure.formID)
            LawFullStructure.Fill_Table()
        Else
        End If
    End Sub
    Private Sub InfoAnalysis_ExitMST2_Click(sender As Object, e As EventArgs) Handles InfoAnalysis_ExitMST1.Click
        Exit_Form()
        Close()
    End Sub
    Private Sub InfoAnalysis_ExitMST1_MouseHover(sender As Object, e As EventArgs) Handles InfoAnalysis_ExitMST1.MouseHover
        Dim Text As String
        If Main_Screen.MS_ActionBarLanguage.Text = "" Then
            Text = ""
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "عربي" Then
            Text = "إضغط هنا للخروج من " & HeaderText.Text
        ElseIf Main_Screen.MS_ActionBarLanguage.Text = "إنجليزي" Then
            Text = "Press Here To Exit From " & HeaderText.Text
        Else
            Text = ""
        End If
        ToolTip1.SetToolTip(MenuStrip_InformationMST2, Text)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ككود لتفعيل زر ال ESC للخروج من الشاشة
        Exit_Form()
        Close()
    End Sub
#End Region

#Region "كود تشغيل الصوت"

    Private Sub ReadMeMST1_Click(sender As Object, e As EventArgs) Handles InfoAnlysis_ReadMeMST2.Click

        'بحاجة إلى إعادة هيكلية



        'Dim Text_Sound As String = rtbOutput.Text
        ''RichTextBox1.Clear()

        'For Each ch As Char In Text_Sound
        '    rtbOutput.AppendText(ch)
        '    'PlayTypewriterSound()
        '    Application.DoEvents()
        '    Threading.Thread.Sleep(100)
        'Next

        '' Read the final text after displaying all characters
        'ReadTextAloud(rtbOutput.Text)


#Region "كود التحقق من وجود الصوت العربي"
        Dim arabicVoiceFound As Boolean = False

        For Each voice In reader.GetInstalledVoices()
            Dim info = voice.VoiceInfo
            If info.Culture.Name.StartsWith("ar") Then
                arabicVoiceFound = True
                MessageBox.Show("✅ تم العثور على صوت عربي: " & info.Name, "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit For
            End If
        Next

        If Not arabicVoiceFound Then
            MessageBox.Show("❌ لم يتم العثور على صوت عربي في النظام. يرجى تثبيت صوت عربي من إعدادات ويندوز.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
        End If
#End Region



        Dim text As String = Information_Text.Text
        If Not String.IsNullOrWhiteSpace(text) Then
            reader.SpeakAsync(text)
        Else
            MessageBox.Show("الرجاء إدخال نص باللغة العربية للقراءة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    'Private Sub PlayTypewriterSound()
    '    Try
    '        If typeSound IsNot Nothing Then
    '            typeSound.Play()
    '        End If
    '    Catch ex As Exception
    '        ' Ignore playback errors
    '    End Try
    'End Sub
    Private Sub ReadTextAloud(text As String)
        Try
            synthesizer.SpeakAsync(text)
        Catch ex As Exception
            MessageBox.Show("Text-to-Speech failed: " & ex.Message)
        End Try
    End Sub
#End Region






End Class