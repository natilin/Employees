namespace Employees
{
    partial class EmployeeForm
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
            textBox_lName = new TextBox();
            textBox_fName = new TextBox();
            textBox_tz = new TextBox();
            textBox_id = new TextBox();
            main_lable = new Label();
            dateTimePicker_dob = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            קוד = new Label();
            groupBox_gender = new GroupBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            groupBox_status = new GroupBox();
            radioButton_widower = new RadioButton();
            radioButton_divorsd = new RadioButton();
            radioButton_married = new RadioButton();
            radioButton_single = new RadioButton();
            button_previus = new Button();
            button_next = new Button();
            label_mobile_phone = new Label();
            label_phone = new Label();
            label_st = new Label();
            label_st_num = new Label();
            label_city = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button_new = new Button();
            button_add_employee = new Button();
            button_update = new Button();
            button_delete = new Button();
            button_search_by_code = new Button();
            button_search_by_tz = new Button();
            pictureBox1 = new PictureBox();
            groupBox_gender.SuspendLayout();
            groupBox_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_lName
            // 
            textBox_lName.Location = new Point(606, 109);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.Size = new Size(150, 31);
            textBox_lName.TabIndex = 0;
            // 
            // textBox_fName
            // 
            textBox_fName.Location = new Point(418, 109);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(150, 31);
            textBox_fName.TabIndex = 1;
            // 
            // textBox_tz
            // 
            textBox_tz.Location = new Point(233, 111);
            textBox_tz.Name = "textBox_tz";
            textBox_tz.Size = new Size(150, 31);
            textBox_tz.TabIndex = 2;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(87, 111);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(93, 31);
            textBox_id.TabIndex = 3;
            textBox_id.Text = "1";
            // 
            // main_lable
            // 
            main_lable.AutoSize = true;
            main_lable.Location = new Point(462, 9);
            main_lable.Name = "main_lable";
            main_lable.Size = new Size(64, 25);
            main_lable.TabIndex = 4;
            main_lable.Text = "עובדים";
            main_lable.Font = new Font(main_lable.Font, FontStyle.Bold);

            // 
            // dateTimePicker_dob
            // 
            dateTimePicker_dob.Location = new Point(794, 109);
            dateTimePicker_dob.Name = "dateTimePicker_dob";
            dateTimePicker_dob.Size = new Size(132, 31);
            dateTimePicker_dob.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(808, 68);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 6;
            label2.Text = "תאריך לידה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 68);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 7;
            label3.Text = "שם משפחה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 68);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 8;
            label4.Text = "שם פרטי";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 68);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 9;
            label5.Text = "תעודת זהות";
            // 
            // קוד
            // 
            קוד.AutoSize = true;
            קוד.Location = new Point(115, 68);
            קוד.Name = "קוד";
            קוד.Size = new Size(38, 25);
            קוד.TabIndex = 10;
            קוד.Text = "קוד";
            // 
            // groupBox_gender
            // 
            groupBox_gender.Controls.Add(radioButton_female);
            groupBox_gender.Controls.Add(radioButton_male);
            groupBox_gender.Location = new Point(138, 169);
            groupBox_gender.Name = "groupBox_gender";
            groupBox_gender.Size = new Size(126, 141);
            groupBox_gender.TabIndex = 11;
            groupBox_gender.TabStop = false;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(28, 87);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(78, 29);
            radioButton_female.TabIndex = 2;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "נקבה";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Location = new Point(43, 30);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(63, 29);
            radioButton_male.TabIndex = 1;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "זכר";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // groupBox_status
            // 
            groupBox_status.Controls.Add(radioButton_widower);
            groupBox_status.Controls.Add(radioButton_divorsd);
            groupBox_status.Controls.Add(radioButton_married);
            groupBox_status.Controls.Add(radioButton_single);
            groupBox_status.Location = new Point(358, 148);
            groupBox_status.Name = "groupBox_status";
            groupBox_status.Size = new Size(110, 188);
            groupBox_status.TabIndex = 12;
            groupBox_status.TabStop = false;
            // 
            // radioButton_widower
            // 
            radioButton_widower.AutoSize = true;
            radioButton_widower.Location = new Point(14, 133);
            radioButton_widower.Name = "radioButton_widower";
            radioButton_widower.Size = new Size(75, 29);
            radioButton_widower.TabIndex = 3;
            radioButton_widower.TabStop = true;
            radioButton_widower.Text = "אלמן";
            radioButton_widower.UseVisualStyleBackColor = true;
            // 
            // radioButton_divorsd
            // 
            radioButton_divorsd.AutoSize = true;
            radioButton_divorsd.Location = new Point(14, 98);
            radioButton_divorsd.Name = "radioButton_divorsd";
            radioButton_divorsd.Size = new Size(74, 29);
            radioButton_divorsd.TabIndex = 2;
            radioButton_divorsd.TabStop = true;
            radioButton_divorsd.Text = "גרוש";
            radioButton_divorsd.UseVisualStyleBackColor = true;
            // 
            // radioButton_married
            // 
            radioButton_married.AutoSize = true;
            radioButton_married.Location = new Point(20, 63);
            radioButton_married.Name = "radioButton_married";
            radioButton_married.Size = new Size(68, 29);
            radioButton_married.TabIndex = 1;
            radioButton_married.TabStop = true;
            radioButton_married.Text = "נשוי";
            radioButton_married.UseVisualStyleBackColor = true;
            // 
            // radioButton_single
            // 
            radioButton_single.AutoSize = true;
            radioButton_single.Location = new Point(19, 28);
            radioButton_single.Name = "radioButton_single";
            radioButton_single.Size = new Size(69, 29);
            radioButton_single.TabIndex = 0;
            radioButton_single.TabStop = true;
            radioButton_single.Text = "רווק";
            radioButton_single.UseVisualStyleBackColor = true;
            // 
            // button_previus
            // 
            button_previus.Location = new Point(278, 389);
            button_previus.Name = "button_previus";
            button_previus.Size = new Size(170, 48);
            button_previus.TabIndex = 13;
            button_previus.Text = "<<";
            button_previus.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            button_next.Location = new Point(543, 389);
            button_next.Name = "button_next";
            button_next.Size = new Size(170, 48);
            button_next.TabIndex = 14;
            button_next.Text = ">>";
            button_next.UseVisualStyleBackColor = true;
            // 
            // label_mobile_phone
            // 
            label_mobile_phone.AutoSize = true;
            label_mobile_phone.Location = new Point(166, 461);
            label_mobile_phone.Name = "label_mobile_phone";
            label_mobile_phone.Size = new Size(86, 25);
            label_mobile_phone.TabIndex = 15;
            label_mobile_phone.Text = "טלפון נייד";
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new Point(335, 461);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(98, 25);
            label_phone.TabIndex = 16;
            label_phone.Text = "טלפון בבית";
            // 
            // label_st
            // 
            label_st.AutoSize = true;
            label_st.Location = new Point(498, 461);
            label_st.Name = "label_st";
            label_st.Size = new Size(49, 25);
            label_st.TabIndex = 17;
            label_st.Text = "רחוב";
            // 
            // label_st_num
            // 
            label_st_num.AutoSize = true;
            label_st_num.Location = new Point(626, 461);
            label_st_num.Name = "label_st_num";
            label_st_num.Size = new Size(57, 25);
            label_st_num.TabIndex = 18;
            label_st_num.Text = "מספר";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new Point(765, 461);
            label_city.Name = "label_city";
            label_city.Size = new Size(38, 25);
            label_city.TabIndex = 19;
            label_city.Text = "עיר";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 503);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 31);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 503);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 31);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(475, 503);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 31);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(614, 503);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 31);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(726, 503);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(103, 31);
            textBox5.TabIndex = 24;
            // 
            // button_new
            // 
            button_new.Location = new Point(158, 569);
            button_new.Name = "button_new";
            button_new.Size = new Size(112, 34);
            button_new.TabIndex = 25;
            button_new.Text = "חדש";
            button_new.UseVisualStyleBackColor = true;
            // 
            // button_add_employee
            // 
            button_add_employee.Location = new Point(335, 569);
            button_add_employee.Name = "button_add_employee";
            button_add_employee.Size = new Size(145, 34);
            button_add_employee.TabIndex = 26;
            button_add_employee.Text = "הוספת עובד";
            button_add_employee.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            button_update.Location = new Point(543, 569);
            button_update.Name = "button_update";
            button_update.Size = new Size(112, 34);
            button_update.TabIndex = 27;
            button_update.Text = "עדכון";
            button_update.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(705, 569);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(147, 34);
            button_delete.TabIndex = 28;
            button_delete.Text = "מחיקת עובד";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // button_search_by_code
            // 
            button_search_by_code.Location = new Point(214, 629);
            button_search_by_code.Name = "button_search_by_code";
            button_search_by_code.Size = new Size(266, 34);
            button_search_by_code.TabIndex = 29;
            button_search_by_code.Text = "חיפוש עובד לפי קוד";
            button_search_by_code.UseVisualStyleBackColor = true;
            // 
            // button_search_by_tz
            // 
            button_search_by_tz.Location = new Point(595, 629);
            button_search_by_tz.Name = "button_search_by_tz";
            button_search_by_tz.Size = new Size(257, 34);
            button_search_by_tz.TabIndex = 30;
            button_search_by_tz.Text = "חיפוש עובד לפי תעודת זהות";
            button_search_by_tz.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Owner\\Downloads\\5555.png";
            pictureBox1.Location = new Point(668, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 167);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 693);
            Controls.Add(pictureBox1);
            Controls.Add(button_search_by_tz);
            Controls.Add(button_search_by_code);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add_employee);
            Controls.Add(button_new);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_city);
            Controls.Add(label_st_num);
            Controls.Add(label_st);
            Controls.Add(label_phone);
            Controls.Add(label_mobile_phone);
            Controls.Add(button_next);
            Controls.Add(button_previus);
            Controls.Add(groupBox_status);
            Controls.Add(groupBox_gender);
            Controls.Add(קוד);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker_dob);
            Controls.Add(main_lable);
            Controls.Add(textBox_id);
            Controls.Add(textBox_tz);
            Controls.Add(textBox_fName);
            Controls.Add(textBox_lName);
            Name = "EmployeeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "EmployeeForm";
            groupBox_gender.ResumeLayout(false);
            groupBox_gender.PerformLayout();
            groupBox_status.ResumeLayout(false);
            groupBox_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_lName;
        private TextBox textBox_fName;
        private TextBox textBox_tz;
        private TextBox textBox_id;
        private Label main_lable;
        private DateTimePicker dateTimePicker_dob;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label קוד;
        private GroupBox groupBox_gender;
        private GroupBox groupBox_status;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private RadioButton radioButton_widower;
        private RadioButton radioButton_divorsd;
        private RadioButton radioButton_married;
        private RadioButton radioButton_single;
        private Button button_previus;
        private Button button_next;
        private Label label_mobile_phone;
        private Label label_phone;
        private Label label_st;
        private Label label_st_num;
        private Label label_city;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button_new;
        private Button button_add_employee;
        private Button button_update;
        private Button button_delete;
        private Button button_search_by_code;
        private Button button_search_by_tz;
        private PictureBox pictureBox1;
    }
}