namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.contract_tb = new System.Windows.Forms.RichTextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.objective4_rtb = new System.Windows.Forms.RichTextBox();
            this.goal4_tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.details4_rtb = new System.Windows.Forms.RichTextBox();
            this.goal4EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal4StartTime = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.objective3_rtb = new System.Windows.Forms.RichTextBox();
            this.goal3_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.details3_rtb = new System.Windows.Forms.RichTextBox();
            this.goal3EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal3StartTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.objective2_rtb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.objective1_rtb = new System.Windows.Forms.RichTextBox();
            this.goal2_tb = new System.Windows.Forms.TextBox();
            this.goal1_tb = new System.Windows.Forms.TextBox();
            this.details2_rtb = new System.Windows.Forms.RichTextBox();
            this.goal2EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal2StartTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.participantName_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.details1_rtb = new System.Windows.Forms.RichTextBox();
            this.goal1EndTime = new System.Windows.Forms.DateTimePicker();
            this.goal1StartTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new progress note";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contract_tb
            // 
            this.contract_tb.EnableAutoDragDrop = true;
            this.contract_tb.Location = new System.Drawing.Point(22, 53);
            this.contract_tb.Name = "contract_tb";
            this.contract_tb.Size = new System.Drawing.Size(418, 570);
            this.contract_tb.TabIndex = 1;
            this.contract_tb.Text = "";
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(62, 629);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(125, 44);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(268, 629);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 44);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.objective4_rtb);
            this.panel1.Controls.Add(this.goal4_tb);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.details4_rtb);
            this.panel1.Controls.Add(this.goal4EndTime);
            this.panel1.Controls.Add(this.goal4StartTime);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.objective3_rtb);
            this.panel1.Controls.Add(this.goal3_tb);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.details3_rtb);
            this.panel1.Controls.Add(this.goal3EndTime);
            this.panel1.Controls.Add(this.goal3StartTime);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.objective2_rtb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.objective1_rtb);
            this.panel1.Controls.Add(this.goal2_tb);
            this.panel1.Controls.Add(this.goal1_tb);
            this.panel1.Controls.Add(this.details2_rtb);
            this.panel1.Controls.Add(this.goal2EndTime);
            this.panel1.Controls.Add(this.goal2StartTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.participantName_tb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.details1_rtb);
            this.panel1.Controls.Add(this.goal1EndTime);
            this.panel1.Controls.Add(this.goal1StartTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(455, 9);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(823, 614);
            this.panel1.TabIndex = 4;
            // 
            // objective4_rtb
            // 
            this.objective4_rtb.Location = new System.Drawing.Point(428, 429);
            this.objective4_rtb.Name = "objective4_rtb";
            this.objective4_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective4_rtb.TabIndex = 20;
            this.objective4_rtb.Text = "";
            // 
            // goal4_tb
            // 
            this.goal4_tb.Location = new System.Drawing.Point(610, 406);
            this.goal4_tb.MaxLength = 4;
            this.goal4_tb.Name = "goal4_tb";
            this.goal4_tb.Size = new System.Drawing.Size(35, 20);
            this.goal4_tb.TabIndex = 19;
            this.goal4_tb.Text = "(D1)";
            this.goal4_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(424, 485);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(245, 20);
            this.label16.TabIndex = 55;
            this.label16.Text = "Details about this objective today:";
            // 
            // details4_rtb
            // 
            this.details4_rtb.Location = new System.Drawing.Point(428, 506);
            this.details4_rtb.Name = "details4_rtb";
            this.details4_rtb.Size = new System.Drawing.Size(365, 51);
            this.details4_rtb.TabIndex = 21;
            this.details4_rtb.Text = "";
            // 
            // goal4EndTime
            // 
            this.goal4EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal4EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal4EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal4EndTime.Location = new System.Drawing.Point(628, 563);
            this.goal4EndTime.Name = "goal4EndTime";
            this.goal4EndTime.Size = new System.Drawing.Size(97, 20);
            this.goal4EndTime.TabIndex = 23;
            this.goal4EndTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // goal4StartTime
            // 
            this.goal4StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal4StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal4StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal4StartTime.Location = new System.Drawing.Point(477, 563);
            this.goal4StartTime.Name = "goal4StartTime";
            this.goal4StartTime.Size = new System.Drawing.Size(97, 20);
            this.goal4StartTime.TabIndex = 22;
            this.goal4StartTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(580, 562);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 20);
            this.label17.TabIndex = 51;
            this.label17.Text = "End:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(423, 563);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "Start:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(424, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 20);
            this.label19.TabIndex = 49;
            this.label19.Text = "Participant\'s Objective 4";
            // 
            // objective3_rtb
            // 
            this.objective3_rtb.Location = new System.Drawing.Point(45, 429);
            this.objective3_rtb.Name = "objective3_rtb";
            this.objective3_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective3_rtb.TabIndex = 15;
            this.objective3_rtb.Text = "";
            // 
            // goal3_tb
            // 
            this.goal3_tb.Location = new System.Drawing.Point(227, 406);
            this.goal3_tb.MaxLength = 4;
            this.goal3_tb.Name = "goal3_tb";
            this.goal3_tb.Size = new System.Drawing.Size(35, 20);
            this.goal3_tb.TabIndex = 14;
            this.goal3_tb.Text = "(C1)";
            this.goal3_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Details about this objective today:";
            // 
            // details3_rtb
            // 
            this.details3_rtb.Location = new System.Drawing.Point(45, 506);
            this.details3_rtb.Name = "details3_rtb";
            this.details3_rtb.Size = new System.Drawing.Size(365, 51);
            this.details3_rtb.TabIndex = 16;
            this.details3_rtb.Text = "";
            // 
            // goal3EndTime
            // 
            this.goal3EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal3EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal3EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal3EndTime.Location = new System.Drawing.Point(245, 563);
            this.goal3EndTime.Name = "goal3EndTime";
            this.goal3EndTime.Size = new System.Drawing.Size(97, 20);
            this.goal3EndTime.TabIndex = 18;
            this.goal3EndTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // goal3StartTime
            // 
            this.goal3StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal3StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal3StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal3StartTime.Location = new System.Drawing.Point(94, 563);
            this.goal3StartTime.Name = "goal3StartTime";
            this.goal3StartTime.Size = new System.Drawing.Size(97, 20);
            this.goal3StartTime.TabIndex = 17;
            this.goal3StartTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(197, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "End:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 563);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Start:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 406);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Participant\'s Objective 3";
            // 
            // objective2_rtb
            // 
            this.objective2_rtb.Location = new System.Drawing.Point(428, 235);
            this.objective2_rtb.Name = "objective2_rtb";
            this.objective2_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective2_rtb.TabIndex = 9;
            this.objective2_rtb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Details about this objective today:";
            // 
            // objective1_rtb
            // 
            this.objective1_rtb.Location = new System.Drawing.Point(45, 235);
            this.objective1_rtb.Name = "objective1_rtb";
            this.objective1_rtb.Size = new System.Drawing.Size(365, 51);
            this.objective1_rtb.TabIndex = 4;
            this.objective1_rtb.Text = "";
            // 
            // goal2_tb
            // 
            this.goal2_tb.Location = new System.Drawing.Point(610, 212);
            this.goal2_tb.MaxLength = 4;
            this.goal2_tb.Name = "goal2_tb";
            this.goal2_tb.Size = new System.Drawing.Size(35, 20);
            this.goal2_tb.TabIndex = 8;
            this.goal2_tb.Text = "(B1)";
            this.goal2_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goal1_tb
            // 
            this.goal1_tb.Location = new System.Drawing.Point(227, 212);
            this.goal1_tb.MaxLength = 4;
            this.goal1_tb.Name = "goal1_tb";
            this.goal1_tb.Size = new System.Drawing.Size(35, 20);
            this.goal1_tb.TabIndex = 3;
            this.goal1_tb.Text = "(A1)";
            this.goal1_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // details2_rtb
            // 
            this.details2_rtb.Location = new System.Drawing.Point(428, 312);
            this.details2_rtb.Name = "details2_rtb";
            this.details2_rtb.Size = new System.Drawing.Size(365, 50);
            this.details2_rtb.TabIndex = 10;
            this.details2_rtb.Text = "";
            // 
            // goal2EndTime
            // 
            this.goal2EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal2EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal2EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal2EndTime.Location = new System.Drawing.Point(635, 369);
            this.goal2EndTime.Name = "goal2EndTime";
            this.goal2EndTime.Size = new System.Drawing.Size(97, 20);
            this.goal2EndTime.TabIndex = 13;
            this.goal2EndTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // goal2StartTime
            // 
            this.goal2StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal2StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal2StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal2StartTime.Location = new System.Drawing.Point(484, 369);
            this.goal2StartTime.Name = "goal2StartTime";
            this.goal2StartTime.Size = new System.Drawing.Size(97, 20);
            this.goal2StartTime.TabIndex = 12;
            this.goal2StartTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "End:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(430, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Start:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Participant\'s Objective 2";
            // 
            // participantName_tb
            // 
            this.participantName_tb.Location = new System.Drawing.Point(618, 34);
            this.participantName_tb.Name = "participantName_tb";
            this.participantName_tb.Size = new System.Drawing.Size(194, 20);
            this.participantName_tb.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Participant\'s Full Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Details about this objective today:";
            // 
            // details1_rtb
            // 
            this.details1_rtb.Location = new System.Drawing.Point(45, 312);
            this.details1_rtb.Name = "details1_rtb";
            this.details1_rtb.Size = new System.Drawing.Size(365, 51);
            this.details1_rtb.TabIndex = 5;
            this.details1_rtb.Text = "";
            // 
            // goal1EndTime
            // 
            this.goal1EndTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal1EndTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal1EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal1EndTime.Location = new System.Drawing.Point(245, 369);
            this.goal1EndTime.Name = "goal1EndTime";
            this.goal1EndTime.Size = new System.Drawing.Size(97, 20);
            this.goal1EndTime.TabIndex = 7;
            this.goal1EndTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // goal1StartTime
            // 
            this.goal1StartTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.goal1StartTime.CalendarForeColor = System.Drawing.Color.Coral;
            this.goal1StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.goal1StartTime.Location = new System.Drawing.Point(94, 369);
            this.goal1StartTime.Name = "goal1StartTime";
            this.goal1StartTime.Size = new System.Drawing.Size(97, 20);
            this.goal1StartTime.TabIndex = 6;
            this.goal1StartTime.Value = new System.DateTime(2015, 10, 12, 16, 27, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "End:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please Select Todays Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Participant\'s Objective 1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1153, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next >>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "save as pdf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1290, 680);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.contract_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox contract_tb;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker goal1EndTime;
        private System.Windows.Forms.DateTimePicker goal1StartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox details1_rtb;
        private System.Windows.Forms.TextBox goal1_tb;
        private System.Windows.Forms.RichTextBox details2_rtb;
        private System.Windows.Forms.DateTimePicker goal2EndTime;
        private System.Windows.Forms.DateTimePicker goal2StartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox participantName_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox goal2_tb;
        private System.Windows.Forms.RichTextBox objective4_rtb;
        private System.Windows.Forms.TextBox goal4_tb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox details4_rtb;
        private System.Windows.Forms.DateTimePicker goal4EndTime;
        private System.Windows.Forms.DateTimePicker goal4StartTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox objective3_rtb;
        private System.Windows.Forms.TextBox goal3_tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox details3_rtb;
        private System.Windows.Forms.DateTimePicker goal3EndTime;
        private System.Windows.Forms.DateTimePicker goal3StartTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox objective2_rtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox objective1_rtb;
        private System.Windows.Forms.Button button2;
    }
}