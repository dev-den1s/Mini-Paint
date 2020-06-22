namespace Project2_Savchenko51908
{
    partial class FiguryGeometryczne
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dstbN = new System.Windows.Forms.TextBox();
            this.dsbtnStart = new System.Windows.Forms.Button();
            this.dsbtnPrzesunFigury = new System.Windows.Forms.Button();
            this.dschlbFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.dspbRysownica = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dsbtnslajderOn = new System.Windows.Forms.Button();
            this.dsbtnnastepny = new System.Windows.Forms.Button();
            this.dsbtnpoprzedni = new System.Windows.Forms.Button();
            this.dsbtnSlajderOff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dstbpokazfigur = new System.Windows.Forms.TextBox();
            this.dsbtngbPokazfigur = new System.Windows.Forms.GroupBox();
            this.dsrbManual = new System.Windows.Forms.RadioButton();
            this.dsrbautomat = new System.Windows.Forms.RadioButton();
            this.dsgbMysza = new System.Windows.Forms.GroupBox();
            this.dsrbwielokat = new System.Windows.Forms.RadioButton();
            this.dsrbkwadrat = new System.Windows.Forms.RadioButton();
            this.dsrbprostokat = new System.Windows.Forms.RadioButton();
            this.dsrbokrag = new System.Windows.Forms.RadioButton();
            this.dsrbelips = new System.Windows.Forms.RadioButton();
            this.dsrblinia = new System.Windows.Forms.RadioButton();
            this.dsrbPunkt = new System.Windows.Forms.RadioButton();
            this.dsbtnzmienlokalizacjemysza = new System.Windows.Forms.Button();
            this.dsbtnzmienatrybutymysz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dstbX = new System.Windows.Forms.TextBox();
            this.dstbY = new System.Windows.Forms.TextBox();
            this.dsbtnzmienatrybuty = new System.Windows.Forms.Button();
            this.dsbtnwyczysc = new System.Windows.Forms.Button();
            this.dsbtnReset = new System.Windows.Forms.Button();
            this.dsrbbez = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dspbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.dsbtngbPokazfigur.SuspendLayout();
            this.dsgbMysza.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj liczbę figur geometrycznych";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(842, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaznać figury geometryczne, które mają być losowane i wyświetlane na planży grafi" +
    "cznej.";
            // 
            // dstbN
            // 
            this.dstbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dstbN.Location = new System.Drawing.Point(29, 101);
            this.dstbN.Name = "dstbN";
            this.dstbN.Size = new System.Drawing.Size(100, 20);
            this.dstbN.TabIndex = 2;
            // 
            // dsbtnStart
            // 
            this.dsbtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnStart.Location = new System.Drawing.Point(40, 127);
            this.dsbtnStart.Name = "dsbtnStart";
            this.dsbtnStart.Size = new System.Drawing.Size(75, 23);
            this.dsbtnStart.TabIndex = 3;
            this.dsbtnStart.Text = "START";
            this.dsbtnStart.UseVisualStyleBackColor = true;
            this.dsbtnStart.Click += new System.EventHandler(this.dsbtnStart_Click);
            // 
            // dsbtnPrzesunFigury
            // 
            this.dsbtnPrzesunFigury.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnPrzesunFigury.Location = new System.Drawing.Point(22, 163);
            this.dsbtnPrzesunFigury.Name = "dsbtnPrzesunFigury";
            this.dsbtnPrzesunFigury.Size = new System.Drawing.Size(112, 60);
            this.dsbtnPrzesunFigury.TabIndex = 4;
            this.dsbtnPrzesunFigury.Text = "Zmień lokalizację figur geometrycznych";
            this.dsbtnPrzesunFigury.UseVisualStyleBackColor = true;
            this.dsbtnPrzesunFigury.Click += new System.EventHandler(this.dsbtnPrzesunFigury_Click);
            // 
            // dschlbFiguryGeometryczne
            // 
            this.dschlbFiguryGeometryczne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dschlbFiguryGeometryczne.FormattingEnabled = true;
            this.dschlbFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Ellips",
            "Okrąg",
            "Prostokąt",
            "Kwadrat",
            "Wielokąt foremny"});
            this.dschlbFiguryGeometryczne.Location = new System.Drawing.Point(834, 106);
            this.dschlbFiguryGeometryczne.Name = "dschlbFiguryGeometryczne";
            this.dschlbFiguryGeometryczne.Size = new System.Drawing.Size(165, 109);
            this.dschlbFiguryGeometryczne.TabIndex = 5;
            // 
            // dspbRysownica
            // 
            this.dspbRysownica.BackColor = System.Drawing.SystemColors.Info;
            this.dspbRysownica.Location = new System.Drawing.Point(151, 53);
            this.dspbRysownica.Name = "dspbRysownica";
            this.dspbRysownica.Size = new System.Drawing.Size(677, 376);
            this.dspbRysownica.TabIndex = 6;
            this.dspbRysownica.TabStop = false;
            this.dspbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dspbRysownica_MouseDown);
            this.dspbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dspbRysownica_MouseMove);
            this.dspbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dspbRysownica_MouseUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "0";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dsbtnslajderOn
            // 
            this.dsbtnslajderOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnslajderOn.Location = new System.Drawing.Point(23, 343);
            this.dsbtnslajderOn.Name = "dsbtnslajderOn";
            this.dsbtnslajderOn.Size = new System.Drawing.Size(106, 56);
            this.dsbtnslajderOn.TabIndex = 7;
            this.dsbtnslajderOn.Text = "Włącz slajder figur geometrycznych";
            this.dsbtnslajderOn.UseVisualStyleBackColor = true;
            this.dsbtnslajderOn.Click += new System.EventHandler(this.dsbtnslajderOn_Click);
            // 
            // dsbtnnastepny
            // 
            this.dsbtnnastepny.Enabled = false;
            this.dsbtnnastepny.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnnastepny.Location = new System.Drawing.Point(570, 442);
            this.dsbtnnastepny.Name = "dsbtnnastepny";
            this.dsbtnnastepny.Size = new System.Drawing.Size(75, 40);
            this.dsbtnnastepny.TabIndex = 8;
            this.dsbtnnastepny.Text = "Następny";
            this.dsbtnnastepny.UseVisualStyleBackColor = true;
            this.dsbtnnastepny.Click += new System.EventHandler(this.dsbtnnastepny_Click);
            // 
            // dsbtnpoprzedni
            // 
            this.dsbtnpoprzedni.Enabled = false;
            this.dsbtnpoprzedni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnpoprzedni.Location = new System.Drawing.Point(735, 442);
            this.dsbtnpoprzedni.Name = "dsbtnpoprzedni";
            this.dsbtnpoprzedni.Size = new System.Drawing.Size(75, 40);
            this.dsbtnpoprzedni.TabIndex = 9;
            this.dsbtnpoprzedni.Text = "Poprzedni";
            this.dsbtnpoprzedni.UseVisualStyleBackColor = true;
            this.dsbtnpoprzedni.Click += new System.EventHandler(this.dsbtnpoprzedni_Click);
            // 
            // dsbtnSlajderOff
            // 
            this.dsbtnSlajderOff.Enabled = false;
            this.dsbtnSlajderOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnSlajderOff.Location = new System.Drawing.Point(23, 418);
            this.dsbtnSlajderOff.Name = "dsbtnSlajderOff";
            this.dsbtnSlajderOff.Size = new System.Drawing.Size(106, 56);
            this.dsbtnSlajderOff.TabIndex = 10;
            this.dsbtnSlajderOff.Text = "Wyłącz slajder figur geometrycznych";
            this.dsbtnSlajderOff.UseVisualStyleBackColor = true;
            this.dsbtnSlajderOff.Click += new System.EventHandler(this.dsbtnSlajderOff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(651, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numer Figury";
            // 
            // dstbpokazfigur
            // 
            this.dstbpokazfigur.Location = new System.Drawing.Point(651, 451);
            this.dstbpokazfigur.Name = "dstbpokazfigur";
            this.dstbpokazfigur.Size = new System.Drawing.Size(78, 20);
            this.dstbpokazfigur.TabIndex = 12;
            this.dstbpokazfigur.TextChanged += new System.EventHandler(this.dstbpokazfigur_TextChanged);
            // 
            // dsbtngbPokazfigur
            // 
            this.dsbtngbPokazfigur.Controls.Add(this.dsrbManual);
            this.dsbtngbPokazfigur.Controls.Add(this.dsrbautomat);
            this.dsbtngbPokazfigur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtngbPokazfigur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsbtngbPokazfigur.Location = new System.Drawing.Point(166, 435);
            this.dsbtngbPokazfigur.Name = "dsbtngbPokazfigur";
            this.dsbtngbPokazfigur.Size = new System.Drawing.Size(353, 52);
            this.dsbtngbPokazfigur.TabIndex = 13;
            this.dsbtngbPokazfigur.TabStop = false;
            this.dsbtngbPokazfigur.Text = "Pokaz figur";
            // 
            // dsrbManual
            // 
            this.dsrbManual.AutoSize = true;
            this.dsrbManual.Location = new System.Drawing.Point(176, 19);
            this.dsrbManual.Name = "dsrbManual";
            this.dsrbManual.Size = new System.Drawing.Size(160, 17);
            this.dsrbManual.TabIndex = 1;
            this.dsrbManual.TabStop = true;
            this.dsrbManual.Text = "Manualny (Przyciskowy)";
            this.dsrbManual.UseVisualStyleBackColor = true;
            // 
            // dsrbautomat
            // 
            this.dsrbautomat.AutoSize = true;
            this.dsrbautomat.Checked = true;
            this.dsrbautomat.Location = new System.Drawing.Point(25, 19);
            this.dsrbautomat.Name = "dsrbautomat";
            this.dsrbautomat.Size = new System.Drawing.Size(103, 17);
            this.dsrbautomat.TabIndex = 0;
            this.dsrbautomat.TabStop = true;
            this.dsrbautomat.Text = "Automatyczny";
            this.dsrbautomat.UseVisualStyleBackColor = true;
            // 
            // dsgbMysza
            // 
            this.dsgbMysza.Controls.Add(this.dsrbbez);
            this.dsgbMysza.Controls.Add(this.dsrbwielokat);
            this.dsgbMysza.Controls.Add(this.dsrbkwadrat);
            this.dsgbMysza.Controls.Add(this.dsrbprostokat);
            this.dsgbMysza.Controls.Add(this.dsrbokrag);
            this.dsgbMysza.Controls.Add(this.dsrbelips);
            this.dsgbMysza.Controls.Add(this.dsrblinia);
            this.dsgbMysza.Controls.Add(this.dsrbPunkt);
            this.dsgbMysza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsgbMysza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsgbMysza.Location = new System.Drawing.Point(836, 238);
            this.dsgbMysza.Name = "dsgbMysza";
            this.dsgbMysza.Size = new System.Drawing.Size(193, 172);
            this.dsgbMysza.TabIndex = 14;
            this.dsgbMysza.TabStop = false;
            this.dsgbMysza.Text = "Wybierz figurę do kreślenia myszą:";
            // 
            // dsrbwielokat
            // 
            this.dsrbwielokat.Location = new System.Drawing.Point(89, 94);
            this.dsrbwielokat.Name = "dsrbwielokat";
            this.dsrbwielokat.Size = new System.Drawing.Size(85, 32);
            this.dsrbwielokat.TabIndex = 6;
            this.dsrbwielokat.Text = "Wielokąt foremny";
            this.dsrbwielokat.UseVisualStyleBackColor = true;
            // 
            // dsrbkwadrat
            // 
            this.dsrbkwadrat.AutoSize = true;
            this.dsrbkwadrat.Location = new System.Drawing.Point(89, 71);
            this.dsrbkwadrat.Name = "dsrbkwadrat";
            this.dsrbkwadrat.Size = new System.Drawing.Size(71, 17);
            this.dsrbkwadrat.TabIndex = 5;
            this.dsrbkwadrat.Text = "Kwadrat";
            this.dsrbkwadrat.UseVisualStyleBackColor = true;
            // 
            // dsrbprostokat
            // 
            this.dsrbprostokat.AutoSize = true;
            this.dsrbprostokat.Location = new System.Drawing.Point(89, 37);
            this.dsrbprostokat.Name = "dsrbprostokat";
            this.dsrbprostokat.Size = new System.Drawing.Size(79, 17);
            this.dsrbprostokat.TabIndex = 4;
            this.dsrbprostokat.Text = "Prostokąt";
            this.dsrbprostokat.UseVisualStyleBackColor = true;
            // 
            // dsrbokrag
            // 
            this.dsrbokrag.AutoSize = true;
            this.dsrbokrag.Location = new System.Drawing.Point(17, 106);
            this.dsrbokrag.Name = "dsrbokrag";
            this.dsrbokrag.Size = new System.Drawing.Size(59, 17);
            this.dsrbokrag.TabIndex = 3;
            this.dsrbokrag.Text = "Okrąg";
            this.dsrbokrag.UseVisualStyleBackColor = true;
            // 
            // dsrbelips
            // 
            this.dsrbelips.AutoSize = true;
            this.dsrbelips.Location = new System.Drawing.Point(17, 83);
            this.dsrbelips.Name = "dsrbelips";
            this.dsrbelips.Size = new System.Drawing.Size(52, 17);
            this.dsrbelips.TabIndex = 2;
            this.dsrbelips.Text = "Elips";
            this.dsrbelips.UseVisualStyleBackColor = true;
            // 
            // dsrblinia
            // 
            this.dsrblinia.AutoSize = true;
            this.dsrblinia.Location = new System.Drawing.Point(17, 60);
            this.dsrblinia.Name = "dsrblinia";
            this.dsrblinia.Size = new System.Drawing.Size(52, 17);
            this.dsrblinia.TabIndex = 1;
            this.dsrblinia.Text = "Linia";
            this.dsrblinia.UseVisualStyleBackColor = true;
            // 
            // dsrbPunkt
            // 
            this.dsrbPunkt.AutoSize = true;
            this.dsrbPunkt.Checked = true;
            this.dsrbPunkt.Location = new System.Drawing.Point(17, 37);
            this.dsrbPunkt.Name = "dsrbPunkt";
            this.dsrbPunkt.Size = new System.Drawing.Size(58, 17);
            this.dsrbPunkt.TabIndex = 0;
            this.dsrbPunkt.TabStop = true;
            this.dsrbPunkt.Text = "Punkt";
            this.dsrbPunkt.UseVisualStyleBackColor = true;
            // 
            // dsbtnzmienlokalizacjemysza
            // 
            this.dsbtnzmienlokalizacjemysza.Location = new System.Drawing.Point(836, 409);
            this.dsbtnzmienlokalizacjemysza.Name = "dsbtnzmienlokalizacjemysza";
            this.dsbtnzmienlokalizacjemysza.Size = new System.Drawing.Size(94, 62);
            this.dsbtnzmienlokalizacjemysza.TabIndex = 15;
            this.dsbtnzmienlokalizacjemysza.Text = "Zmień losowo lokalizację figur (Myszą)";
            this.dsbtnzmienlokalizacjemysza.UseVisualStyleBackColor = true;
            this.dsbtnzmienlokalizacjemysza.Click += new System.EventHandler(this.dsbtnzmienlokalizacjemysza_Click);
            // 
            // dsbtnzmienatrybutymysz
            // 
            this.dsbtnzmienatrybutymysz.Location = new System.Drawing.Point(936, 409);
            this.dsbtnzmienatrybutymysz.Name = "dsbtnzmienatrybutymysz";
            this.dsbtnzmienatrybutymysz.Size = new System.Drawing.Size(93, 62);
            this.dsbtnzmienatrybutymysz.TabIndex = 16;
            this.dsbtnzmienatrybutymysz.Text = "Zmień losowo atrybuty figur (Myszą)";
            this.dsbtnzmienatrybutymysz.UseVisualStyleBackColor = true;
            this.dsbtnzmienatrybutymysz.Click += new System.EventHandler(this.dsbtnzmienatrybutymysz_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(286, 14);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(214, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Współrzędne (x,y) połozenia myszy:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(530, 14);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(22, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "X:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(598, 14);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(25, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseMnemonic = false;
            // 
            // dstbX
            // 
            this.dstbX.Enabled = false;
            this.dstbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dstbX.Location = new System.Drawing.Point(555, 19);
            this.dstbX.Name = "dstbX";
            this.dstbX.Size = new System.Drawing.Size(37, 20);
            this.dstbX.TabIndex = 20;
            // 
            // dstbY
            // 
            this.dstbY.Enabled = false;
            this.dstbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dstbY.Location = new System.Drawing.Point(629, 19);
            this.dstbY.Name = "dstbY";
            this.dstbY.Size = new System.Drawing.Size(37, 20);
            this.dstbY.TabIndex = 21;
            // 
            // dsbtnzmienatrybuty
            // 
            this.dsbtnzmienatrybuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnzmienatrybuty.Location = new System.Drawing.Point(22, 238);
            this.dsbtnzmienatrybuty.Name = "dsbtnzmienatrybuty";
            this.dsbtnzmienatrybuty.Size = new System.Drawing.Size(112, 60);
            this.dsbtnzmienatrybuty.TabIndex = 22;
            this.dsbtnzmienatrybuty.Text = "Zmień atrybuty figur geometrycznych";
            this.dsbtnzmienatrybuty.UseVisualStyleBackColor = true;
            this.dsbtnzmienatrybuty.Click += new System.EventHandler(this.dsbtnzmienatrybuty_Click);
            // 
            // dsbtnwyczysc
            // 
            this.dsbtnwyczysc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsbtnwyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnwyczysc.Location = new System.Drawing.Point(12, 8);
            this.dsbtnwyczysc.Name = "dsbtnwyczysc";
            this.dsbtnwyczysc.Size = new System.Drawing.Size(112, 39);
            this.dsbtnwyczysc.TabIndex = 23;
            this.dsbtnwyczysc.Text = "Wyczyść rysownicę";
            this.dsbtnwyczysc.UseVisualStyleBackColor = false;
            this.dsbtnwyczysc.Click += new System.EventHandler(this.dsbtnwyczysc_Click);
            // 
            // dsbtnReset
            // 
            this.dsbtnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsbtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnReset.Location = new System.Drawing.Point(130, 8);
            this.dsbtnReset.Name = "dsbtnReset";
            this.dsbtnReset.Size = new System.Drawing.Size(66, 39);
            this.dsbtnReset.TabIndex = 24;
            this.dsbtnReset.Text = "Reset";
            this.dsbtnReset.UseVisualStyleBackColor = false;
            this.dsbtnReset.Click += new System.EventHandler(this.dsbtnReset_Click);
            // 
            // dsrbbez
            // 
            this.dsrbbez.Location = new System.Drawing.Point(30, 132);
            this.dsrbbez.Name = "dsrbbez";
            this.dsrbbez.Size = new System.Drawing.Size(111, 28);
            this.dsrbbez.TabIndex = 7;
            this.dsrbbez.TabStop = true;
            this.dsrbbez.Text = "Krzywa Bezjera\r\n";
            this.dsrbbez.UseVisualStyleBackColor = true;
            // 
            // FiguryGeometryczne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 492);
            this.Controls.Add(this.dsbtnReset);
            this.Controls.Add(this.dsbtnwyczysc);
            this.Controls.Add(this.dsbtnzmienatrybuty);
            this.Controls.Add(this.dstbY);
            this.Controls.Add(this.dstbX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dsbtnzmienatrybutymysz);
            this.Controls.Add(this.dsbtnzmienlokalizacjemysza);
            this.Controls.Add(this.dsgbMysza);
            this.Controls.Add(this.dsbtngbPokazfigur);
            this.Controls.Add(this.dstbpokazfigur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dsbtnSlajderOff);
            this.Controls.Add(this.dsbtnpoprzedni);
            this.Controls.Add(this.dsbtnnastepny);
            this.Controls.Add(this.dsbtnslajderOn);
            this.Controls.Add(this.dspbRysownica);
            this.Controls.Add(this.dschlbFiguryGeometryczne);
            this.Controls.Add(this.dsbtnPrzesunFigury);
            this.Controls.Add(this.dsbtnStart);
            this.Controls.Add(this.dstbN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FiguryGeometryczne";
            this.Text = "Losowa prezentacja wybranych figur geometrycznych";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FiguryGeometryczne_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dspbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.dsbtngbPokazfigur.ResumeLayout(false);
            this.dsbtngbPokazfigur.PerformLayout();
            this.dsgbMysza.ResumeLayout(false);
            this.dsgbMysza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dstbN;
        private System.Windows.Forms.Button dsbtnStart;
        private System.Windows.Forms.Button dsbtnPrzesunFigury;
        private System.Windows.Forms.CheckedListBox dschlbFiguryGeometryczne;
        private System.Windows.Forms.PictureBox dspbRysownica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox dsbtngbPokazfigur;
        private System.Windows.Forms.RadioButton dsrbManual;
        private System.Windows.Forms.RadioButton dsrbautomat;
        private System.Windows.Forms.TextBox dstbpokazfigur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dsbtnSlajderOff;
        private System.Windows.Forms.Button dsbtnpoprzedni;
        private System.Windows.Forms.Button dsbtnnastepny;
        private System.Windows.Forms.Button dsbtnslajderOn;
        private System.Windows.Forms.GroupBox dsgbMysza;
        private System.Windows.Forms.RadioButton dsrbwielokat;
        private System.Windows.Forms.RadioButton dsrbkwadrat;
        private System.Windows.Forms.RadioButton dsrbprostokat;
        private System.Windows.Forms.RadioButton dsrbokrag;
        private System.Windows.Forms.RadioButton dsrbelips;
        private System.Windows.Forms.RadioButton dsrblinia;
        private System.Windows.Forms.RadioButton dsrbPunkt;
        private System.Windows.Forms.Button dsbtnzmienatrybutymysz;
        private System.Windows.Forms.Button dsbtnzmienlokalizacjemysza;
        private System.Windows.Forms.TextBox dstbY;
        private System.Windows.Forms.TextBox dstbX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dsbtnzmienatrybuty;
        private System.Windows.Forms.Button dsbtnwyczysc;
        private System.Windows.Forms.Button dsbtnReset;
        private System.Windows.Forms.RadioButton dsrbbez;
    }
}

