namespace Grade_calculator
{
    partial class Form1
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
            this.text_id_student = new System.Windows.Forms.TextBox();
            this.student_id_label = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.text_point = new System.Windows.Forms.TextBox();
            this.point_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.group_enter_data_box = new System.Windows.Forms.GroupBox();
            this.avg_point_label = new System.Windows.Forms.Label();
            this.text_avg_point = new System.Windows.Forms.TextBox();
            this.max_point_label = new System.Windows.Forms.Label();
            this.text_point_min = new System.Windows.Forms.TextBox();
            this.min_point_label = new System.Windows.Forms.Label();
            this.text_point_max = new System.Windows.Forms.TextBox();
            this.student_id_label2 = new System.Windows.Forms.Label();
            this.text_name_max = new System.Windows.Forms.TextBox();
            this.name_label2 = new System.Windows.Forms.Label();
            this.text_id_student_min = new System.Windows.Forms.TextBox();
            this.point_label2 = new System.Windows.Forms.Label();
            this.text_id_student_max = new System.Windows.Forms.TextBox();
            this.text_name_min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gradeA = new System.Windows.Forms.TextBox();
            this.gradeBB = new System.Windows.Forms.TextBox();
            this.gradeB = new System.Windows.Forms.TextBox();
            this.gradeC = new System.Windows.Forms.TextBox();
            this.gradeDD = new System.Windows.Forms.TextBox();
            this.gradeF = new System.Windows.Forms.TextBox();
            this.gradeCC = new System.Windows.Forms.TextBox();
            this.gradeD = new System.Windows.Forms.TextBox();
            this.GPA = new System.Windows.Forms.TextBox();
            this.group_result_box = new System.Windows.Forms.GroupBox();
            this.group_enter_data_box.SuspendLayout();
            this.group_result_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_id_student
            // 
            this.text_id_student.Location = new System.Drawing.Point(168, 35);
            this.text_id_student.Name = "text_id_student";
            this.text_id_student.Size = new System.Drawing.Size(100, 27);
            this.text_id_student.TabIndex = 1;
            // 
            // student_id_label
            // 
            this.student_id_label.AutoSize = true;
            this.student_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label.Location = new System.Drawing.Point(68, 37);
            this.student_id_label.Name = "student_id_label";
            this.student_id_label.Size = new System.Drawing.Size(94, 20);
            this.student_id_label.TabIndex = 2;
            this.student_id_label.Text = "รหัสนักศึกษา";
            this.student_id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(168, 80);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 27);
            this.text_name.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(68, 82);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(91, 20);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "ชื่อ-นามสกุล";
            // 
            // text_point
            // 
            this.text_point.Location = new System.Drawing.Point(168, 131);
            this.text_point.Name = "text_point";
            this.text_point.Size = new System.Drawing.Size(100, 27);
            this.text_point.TabIndex = 5;
            // 
            // point_label
            // 
            this.point_label.AutoSize = true;
            this.point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label.Location = new System.Drawing.Point(68, 133);
            this.point_label.Name = "point_label";
            this.point_label.Size = new System.Drawing.Size(58, 20);
            this.point_label.TabIndex = 6;
            this.point_label.Text = "คะแนน";
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(178, 177);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(79, 32);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = " บักทึก";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // group_enter_data_box
            // 
            this.group_enter_data_box.Controls.Add(this.student_id_label);
            this.group_enter_data_box.Controls.Add(this.text_id_student);
            this.group_enter_data_box.Controls.Add(this.text_name);
            this.group_enter_data_box.Controls.Add(this.name_label);
            this.group_enter_data_box.Controls.Add(this.text_point);
            this.group_enter_data_box.Controls.Add(this.point_label);
            this.group_enter_data_box.Controls.Add(this.Save_button);
            this.group_enter_data_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_enter_data_box.Location = new System.Drawing.Point(57, 82);
            this.group_enter_data_box.Name = "group_enter_data_box";
            this.group_enter_data_box.Size = new System.Drawing.Size(335, 254);
            this.group_enter_data_box.TabIndex = 20;
            this.group_enter_data_box.TabStop = false;
            this.group_enter_data_box.Text = "กรอกข้อมูล";
            // 
            // avg_point_label
            // 
            this.avg_point_label.AutoSize = true;
            this.avg_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_point_label.Location = new System.Drawing.Point(570, 204);
            this.avg_point_label.Name = "avg_point_label";
            this.avg_point_label.Size = new System.Drawing.Size(93, 20);
            this.avg_point_label.TabIndex = 14;
            this.avg_point_label.Text = "คะแนนเฉลี่ย";
            // 
            // text_avg_point
            // 
            this.text_avg_point.Location = new System.Drawing.Point(695, 202);
            this.text_avg_point.Name = "text_avg_point";
            this.text_avg_point.Size = new System.Drawing.Size(100, 27);
            this.text_avg_point.TabIndex = 13;
            this.text_avg_point.TextChanged += new System.EventHandler(this.text_avg_point_TextChanged);
            // 
            // max_point_label
            // 
            this.max_point_label.AutoSize = true;
            this.max_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_point_label.Location = new System.Drawing.Point(313, 99);
            this.max_point_label.Name = "max_point_label";
            this.max_point_label.Size = new System.Drawing.Size(94, 20);
            this.max_point_label.TabIndex = 15;
            this.max_point_label.Text = "คะแนนสูงสุด";
            // 
            // text_point_min
            // 
            this.text_point_min.Location = new System.Drawing.Point(695, 148);
            this.text_point_min.Name = "text_point_min";
            this.text_point_min.Size = new System.Drawing.Size(100, 27);
            this.text_point_min.TabIndex = 12;
            this.text_point_min.TextChanged += new System.EventHandler(this.text_point_min_TextChanged);
            // 
            // min_point_label
            // 
            this.min_point_label.AutoSize = true;
            this.min_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_point_label.Location = new System.Drawing.Point(313, 150);
            this.min_point_label.Name = "min_point_label";
            this.min_point_label.Size = new System.Drawing.Size(95, 20);
            this.min_point_label.TabIndex = 16;
            this.min_point_label.Text = "คะแนนต่ำสุด";
            // 
            // text_point_max
            // 
            this.text_point_max.Location = new System.Drawing.Point(695, 97);
            this.text_point_max.Name = "text_point_max";
            this.text_point_max.Size = new System.Drawing.Size(100, 27);
            this.text_point_max.TabIndex = 11;
            this.text_point_max.TextChanged += new System.EventHandler(this.text_point_max_TextChanged);
            // 
            // student_id_label2
            // 
            this.student_id_label2.AutoSize = true;
            this.student_id_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label2.Location = new System.Drawing.Point(427, 50);
            this.student_id_label2.Name = "student_id_label2";
            this.student_id_label2.Size = new System.Drawing.Size(94, 20);
            this.student_id_label2.TabIndex = 17;
            this.student_id_label2.Text = "รหัสนักศึกษา";
            // 
            // text_name_max
            // 
            this.text_name_max.Location = new System.Drawing.Point(563, 97);
            this.text_name_max.Name = "text_name_max";
            this.text_name_max.Size = new System.Drawing.Size(100, 27);
            this.text_name_max.TabIndex = 9;
            this.text_name_max.TextChanged += new System.EventHandler(this.text_name_max_TextChanged);
            // 
            // name_label2
            // 
            this.name_label2.AutoSize = true;
            this.name_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label2.Location = new System.Drawing.Point(570, 50);
            this.name_label2.Name = "name_label2";
            this.name_label2.Size = new System.Drawing.Size(91, 20);
            this.name_label2.TabIndex = 18;
            this.name_label2.Text = "ชื่อ-นามสกุล";
            // 
            // text_id_student_min
            // 
            this.text_id_student_min.Location = new System.Drawing.Point(431, 146);
            this.text_id_student_min.Name = "text_id_student_min";
            this.text_id_student_min.Size = new System.Drawing.Size(100, 27);
            this.text_id_student_min.TabIndex = 9;
            this.text_id_student_min.TextChanged += new System.EventHandler(this.text_id_student_min_TextChanged);
            // 
            // point_label2
            // 
            this.point_label2.AutoSize = true;
            this.point_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label2.Location = new System.Drawing.Point(701, 50);
            this.point_label2.Name = "point_label2";
            this.point_label2.Size = new System.Drawing.Size(58, 20);
            this.point_label2.TabIndex = 19;
            this.point_label2.Text = "คะแนน";
            // 
            // text_id_student_max
            // 
            this.text_id_student_max.Location = new System.Drawing.Point(431, 97);
            this.text_id_student_max.Name = "text_id_student_max";
            this.text_id_student_max.Size = new System.Drawing.Size(100, 27);
            this.text_id_student_max.TabIndex = 8;
            this.text_id_student_max.TextChanged += new System.EventHandler(this.text_id_student_max_TextChanged);
            // 
            // text_name_min
            // 
            this.text_name_min.Location = new System.Drawing.Point(563, 148);
            this.text_name_min.Name = "text_name_min";
            this.text_name_min.Size = new System.Drawing.Size(100, 27);
            this.text_name_min.TabIndex = 10;
            this.text_name_min.TextChanged += new System.EventHandler(this.text_name_min_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "คะแนนสูงสุด";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "B+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "C+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "D+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "F";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "เกรดเฉลี่ย";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // gradeA
            // 
            this.gradeA.Location = new System.Drawing.Point(97, 76);
            this.gradeA.Name = "gradeA";
            this.gradeA.Size = new System.Drawing.Size(100, 27);
            this.gradeA.TabIndex = 30;
            this.gradeA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gradeBB
            // 
            this.gradeBB.Location = new System.Drawing.Point(97, 109);
            this.gradeBB.Name = "gradeBB";
            this.gradeBB.Size = new System.Drawing.Size(100, 27);
            this.gradeBB.TabIndex = 31;
            // 
            // gradeB
            // 
            this.gradeB.Location = new System.Drawing.Point(97, 142);
            this.gradeB.Name = "gradeB";
            this.gradeB.Size = new System.Drawing.Size(100, 27);
            this.gradeB.TabIndex = 34;
            // 
            // gradeC
            // 
            this.gradeC.Location = new System.Drawing.Point(97, 205);
            this.gradeC.Name = "gradeC";
            this.gradeC.Size = new System.Drawing.Size(100, 27);
            this.gradeC.TabIndex = 31;
            // 
            // gradeDD
            // 
            this.gradeDD.Location = new System.Drawing.Point(97, 238);
            this.gradeDD.Name = "gradeDD";
            this.gradeDD.Size = new System.Drawing.Size(100, 27);
            this.gradeDD.TabIndex = 34;
            // 
            // gradeF
            // 
            this.gradeF.Location = new System.Drawing.Point(97, 307);
            this.gradeF.Name = "gradeF";
            this.gradeF.Size = new System.Drawing.Size(100, 27);
            this.gradeF.TabIndex = 34;
            // 
            // gradeCC
            // 
            this.gradeCC.Location = new System.Drawing.Point(97, 175);
            this.gradeCC.Name = "gradeCC";
            this.gradeCC.Size = new System.Drawing.Size(100, 27);
            this.gradeCC.TabIndex = 35;
            // 
            // gradeD
            // 
            this.gradeD.Location = new System.Drawing.Point(97, 271);
            this.gradeD.Name = "gradeD";
            this.gradeD.Size = new System.Drawing.Size(100, 27);
            this.gradeD.TabIndex = 35;
            // 
            // GPA
            // 
            this.GPA.Location = new System.Drawing.Point(97, 340);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(100, 27);
            this.GPA.TabIndex = 35;
            // 
            // group_result_box
            // 
            this.group_result_box.Controls.Add(this.GPA);
            this.group_result_box.Controls.Add(this.gradeD);
            this.group_result_box.Controls.Add(this.gradeCC);
            this.group_result_box.Controls.Add(this.gradeF);
            this.group_result_box.Controls.Add(this.gradeDD);
            this.group_result_box.Controls.Add(this.gradeC);
            this.group_result_box.Controls.Add(this.gradeB);
            this.group_result_box.Controls.Add(this.gradeBB);
            this.group_result_box.Controls.Add(this.gradeA);
            this.group_result_box.Controls.Add(this.label10);
            this.group_result_box.Controls.Add(this.label9);
            this.group_result_box.Controls.Add(this.label8);
            this.group_result_box.Controls.Add(this.label7);
            this.group_result_box.Controls.Add(this.label6);
            this.group_result_box.Controls.Add(this.label5);
            this.group_result_box.Controls.Add(this.label4);
            this.group_result_box.Controls.Add(this.label3);
            this.group_result_box.Controls.Add(this.label2);
            this.group_result_box.Controls.Add(this.label1);
            this.group_result_box.Controls.Add(this.text_name_min);
            this.group_result_box.Controls.Add(this.text_id_student_max);
            this.group_result_box.Controls.Add(this.point_label2);
            this.group_result_box.Controls.Add(this.text_id_student_min);
            this.group_result_box.Controls.Add(this.name_label2);
            this.group_result_box.Controls.Add(this.text_name_max);
            this.group_result_box.Controls.Add(this.student_id_label2);
            this.group_result_box.Controls.Add(this.text_point_max);
            this.group_result_box.Controls.Add(this.min_point_label);
            this.group_result_box.Controls.Add(this.text_point_min);
            this.group_result_box.Controls.Add(this.max_point_label);
            this.group_result_box.Controls.Add(this.text_avg_point);
            this.group_result_box.Controls.Add(this.avg_point_label);
            this.group_result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_result_box.Location = new System.Drawing.Point(484, 93);
            this.group_result_box.Name = "group_result_box";
            this.group_result_box.Size = new System.Drawing.Size(831, 400);
            this.group_result_box.TabIndex = 21;
            this.group_result_box.TabStop = false;
            this.group_result_box.Text = "ผลลัพธ์";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 604);
            this.Controls.Add(this.group_result_box);
            this.Controls.Add(this.group_enter_data_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_enter_data_box.ResumeLayout(false);
            this.group_enter_data_box.PerformLayout();
            this.group_result_box.ResumeLayout(false);
            this.group_result_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_id_student;
        private System.Windows.Forms.Label student_id_label;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox text_point;
        private System.Windows.Forms.Label point_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.GroupBox group_enter_data_box;
        private System.Windows.Forms.Label avg_point_label;
        private System.Windows.Forms.TextBox text_avg_point;
        private System.Windows.Forms.Label max_point_label;
        private System.Windows.Forms.TextBox text_point_min;
        private System.Windows.Forms.Label min_point_label;
        private System.Windows.Forms.TextBox text_point_max;
        private System.Windows.Forms.Label student_id_label2;
        private System.Windows.Forms.TextBox text_name_max;
        private System.Windows.Forms.Label name_label2;
        private System.Windows.Forms.TextBox text_id_student_min;
        private System.Windows.Forms.Label point_label2;
        private System.Windows.Forms.TextBox text_id_student_max;
        private System.Windows.Forms.TextBox text_name_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox gradeA;
        private System.Windows.Forms.TextBox gradeBB;
        private System.Windows.Forms.TextBox gradeB;
        private System.Windows.Forms.TextBox gradeC;
        private System.Windows.Forms.TextBox gradeDD;
        private System.Windows.Forms.TextBox gradeF;
        private System.Windows.Forms.TextBox gradeCC;
        private System.Windows.Forms.TextBox gradeD;
        private System.Windows.Forms.TextBox GPA;
        private System.Windows.Forms.GroupBox group_result_box;
    }
}

