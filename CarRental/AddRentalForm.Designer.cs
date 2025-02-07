namespace CarRental
{
    partial class AddRentalForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.BtnExistClient = new System.Windows.Forms.Button();
            this.BtnExistCar = new System.Windows.Forms.Button();
            this.textBoxIdCar = new System.Windows.Forms.TextBox();
            this.BtnAddCarForm = new System.Windows.Forms.Button();
            this.carIsInDB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdCar = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxChair = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxKASKO = new System.Windows.Forms.CheckBox();
            this.checkBoxnNav = new System.Windows.Forms.CheckBox();
            this.dateStartTimer = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEndTimer = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectDateBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddRentalBut = new System.Windows.Forms.Button();
            this.CalculatePrice = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент есть в базе?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(57, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Да";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnIsClientInDB);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(313, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Нет";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnOpenAddClientForm);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(6, 123);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 20);
            this.labelId.TabIndex = 21;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxId.Location = new System.Drawing.Point(57, 120);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(164, 26);
            this.textBoxId.TabIndex = 20;
            // 
            // BtnExistClient
            // 
            this.BtnExistClient.BackColor = System.Drawing.SystemColors.Info;
            this.BtnExistClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExistClient.Location = new System.Drawing.Point(57, 168);
            this.BtnExistClient.Name = "BtnExistClient";
            this.BtnExistClient.Size = new System.Drawing.Size(164, 37);
            this.BtnExistClient.TabIndex = 22;
            this.BtnExistClient.Text = "Найти клиента";
            this.BtnExistClient.UseVisualStyleBackColor = false;
            this.BtnExistClient.Click += new System.EventHandler(this.BtnExistClient_Click);
            // 
            // BtnExistCar
            // 
            this.BtnExistCar.BackColor = System.Drawing.SystemColors.Info;
            this.BtnExistCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExistCar.Location = new System.Drawing.Point(57, 370);
            this.BtnExistCar.Name = "BtnExistCar";
            this.BtnExistCar.Size = new System.Drawing.Size(164, 37);
            this.BtnExistCar.TabIndex = 27;
            this.BtnExistCar.Text = "Найти машину";
            this.BtnExistCar.UseVisualStyleBackColor = false;
            this.BtnExistCar.Click += new System.EventHandler(this.BtnExistCar_Click);
            // 
            // textBoxIdCar
            // 
            this.textBoxIdCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdCar.Location = new System.Drawing.Point(57, 322);
            this.textBoxIdCar.Name = "textBoxIdCar";
            this.textBoxIdCar.Size = new System.Drawing.Size(164, 26);
            this.textBoxIdCar.TabIndex = 26;
            // 
            // BtnAddCarForm
            // 
            this.BtnAddCarForm.BackColor = System.Drawing.SystemColors.Info;
            this.BtnAddCarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddCarForm.Location = new System.Drawing.Point(313, 260);
            this.BtnAddCarForm.Name = "BtnAddCarForm";
            this.BtnAddCarForm.Size = new System.Drawing.Size(146, 43);
            this.BtnAddCarForm.TabIndex = 25;
            this.BtnAddCarForm.Text = "Нет";
            this.BtnAddCarForm.UseVisualStyleBackColor = false;
            this.BtnAddCarForm.Click += new System.EventHandler(this.BtnAddCarForm_Click);
            // 
            // carIsInDB
            // 
            this.carIsInDB.BackColor = System.Drawing.SystemColors.Info;
            this.carIsInDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carIsInDB.Location = new System.Drawing.Point(57, 260);
            this.carIsInDB.Name = "carIsInDB";
            this.carIsInDB.Size = new System.Drawing.Size(146, 43);
            this.carIsInDB.TabIndex = 24;
            this.carIsInDB.Text = "Да";
            this.carIsInDB.UseVisualStyleBackColor = false;
            this.carIsInDB.Click += new System.EventHandler(this.carIsInDB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Машина есть в базе?";
            // 
            // labelIdCar
            // 
            this.labelIdCar.AutoSize = true;
            this.labelIdCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdCar.Location = new System.Drawing.Point(6, 322);
            this.labelIdCar.Name = "labelIdCar";
            this.labelIdCar.Size = new System.Drawing.Size(23, 20);
            this.labelIdCar.TabIndex = 28;
            this.labelIdCar.Text = "Id";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // checkBoxChair
            // 
            this.checkBoxChair.AutoSize = true;
            this.checkBoxChair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChair.Location = new System.Drawing.Point(9, 1);
            this.checkBoxChair.Name = "checkBoxChair";
            this.checkBoxChair.Size = new System.Drawing.Size(149, 24);
            this.checkBoxChair.TabIndex = 29;
            this.checkBoxChair.Text = "Детское кресло";
            this.checkBoxChair.UseVisualStyleBackColor = true;
            this.checkBoxChair.CheckedChanged += new System.EventHandler(this.checkBoxChair_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Выберите необходимые доп услуги";
            // 
            // checkBoxKASKO
            // 
            this.checkBoxKASKO.AutoSize = true;
            this.checkBoxKASKO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxKASKO.Location = new System.Drawing.Point(9, 31);
            this.checkBoxKASKO.Name = "checkBoxKASKO";
            this.checkBoxKASKO.Size = new System.Drawing.Size(82, 24);
            this.checkBoxKASKO.TabIndex = 31;
            this.checkBoxKASKO.Text = "КАСКО";
            this.checkBoxKASKO.UseVisualStyleBackColor = true;
            this.checkBoxKASKO.CheckedChanged += new System.EventHandler(this.checkBoxKASKO_CheckedChanged);
            // 
            // checkBoxnNav
            // 
            this.checkBoxnNav.AutoSize = true;
            this.checkBoxnNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxnNav.Location = new System.Drawing.Point(9, 61);
            this.checkBoxnNav.Name = "checkBoxnNav";
            this.checkBoxnNav.Size = new System.Drawing.Size(146, 24);
            this.checkBoxnNav.TabIndex = 32;
            this.checkBoxnNav.Text = "GPS-навигатор";
            this.checkBoxnNav.UseVisualStyleBackColor = true;
            this.checkBoxnNav.CheckedChanged += new System.EventHandler(this.checkBoxnNav_CheckedChanged);
            // 
            // dateStartTimer
            // 
            this.dateStartTimer.Location = new System.Drawing.Point(122, 70);
            this.dateStartTimer.Name = "dateStartTimer";
            this.dateStartTimer.Size = new System.Drawing.Size(200, 22);
            this.dateStartTimer.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Выберите период аренды";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Начало";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Конец";
            // 
            // dateEndTimer
            // 
            this.dateEndTimer.Location = new System.Drawing.Point(122, 103);
            this.dateEndTimer.Name = "dateEndTimer";
            this.dateEndTimer.Size = new System.Drawing.Size(200, 22);
            this.dateEndTimer.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.SelectDateBut);
            this.groupBox1.Controls.Add(this.dateEndTimer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateStartTimer);
            this.groupBox1.Location = new System.Drawing.Point(516, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 185);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // SelectDateBut
            // 
            this.SelectDateBut.BackColor = System.Drawing.SystemColors.Info;
            this.SelectDateBut.Location = new System.Drawing.Point(29, 137);
            this.SelectDateBut.Name = "SelectDateBut";
            this.SelectDateBut.Size = new System.Drawing.Size(137, 31);
            this.SelectDateBut.TabIndex = 38;
            this.SelectDateBut.Text = "Выбрать";
            this.SelectDateBut.UseVisualStyleBackColor = false;
            this.SelectDateBut.Click += new System.EventHandler(this.SelectDateBut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.checkBoxnNav);
            this.panel1.Controls.Add(this.checkBoxKASKO);
            this.panel1.Controls.Add(this.checkBoxChair);
            this.panel1.Location = new System.Drawing.Point(57, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 117);
            this.panel1.TabIndex = 39;
            // 
            // AddRentalBut
            // 
            this.AddRentalBut.BackColor = System.Drawing.SystemColors.Info;
            this.AddRentalBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRentalBut.Location = new System.Drawing.Point(516, 641);
            this.AddRentalBut.Name = "AddRentalBut";
            this.AddRentalBut.Size = new System.Drawing.Size(306, 58);
            this.AddRentalBut.TabIndex = 43;
            this.AddRentalBut.Text = "Добавить аренду";
            this.AddRentalBut.UseVisualStyleBackColor = false;
            this.AddRentalBut.Click += new System.EventHandler(this.AddRentalBut_Click);
            // 
            // CalculatePrice
            // 
            this.CalculatePrice.BackColor = System.Drawing.SystemColors.Info;
            this.CalculatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatePrice.Location = new System.Drawing.Point(57, 604);
            this.CalculatePrice.Name = "CalculatePrice";
            this.CalculatePrice.Size = new System.Drawing.Size(308, 37);
            this.CalculatePrice.TabIndex = 44;
            this.CalculatePrice.Text = "Расчитать стоимость";
            this.CalculatePrice.UseVisualStyleBackColor = false;
            this.CalculatePrice.Click += new System.EventHandler(this.CalculatePrice_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(161, 658);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(244, 26);
            this.textBoxPrice.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(62, 658);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Цена";
            // 
            // AddRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 756);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.CalculatePrice);
            this.Controls.Add(this.AddRentalBut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIdCar);
            this.Controls.Add(this.BtnExistCar);
            this.Controls.Add(this.textBoxIdCar);
            this.Controls.Add(this.BtnAddCarForm);
            this.Controls.Add(this.carIsInDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExistClient);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AddRentalForm";
            this.Text = "Добавление аренды";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button BtnExistClient;
        private System.Windows.Forms.Button BtnExistCar;
        private System.Windows.Forms.TextBox textBoxIdCar;
        private System.Windows.Forms.Button BtnAddCarForm;
        private System.Windows.Forms.Button carIsInDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIdCar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxChair;
        private System.Windows.Forms.CheckBox checkBoxnNav;
        private System.Windows.Forms.CheckBox checkBoxKASKO;
        private System.Windows.Forms.DateTimePicker dateStartTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateEndTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelectDateBut;
        private System.Windows.Forms.Button AddRentalBut;
        private System.Windows.Forms.Button CalculatePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}