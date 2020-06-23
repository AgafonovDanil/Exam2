namespace Экзамен__2_
{
    partial class Form1
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
            this.textDlit = new System.Windows.Forms.TextBox();
            this.comboNedel = new System.Windows.Forms.ComboBox();
            this.labelDlit = new System.Windows.Forms.Label();
            this.labelNedel = new System.Windows.Forms.Label();
            this.labelItog = new System.Windows.Forms.Label();
            this.btnRashet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDlit
            // 
            this.textDlit.Location = new System.Drawing.Point(155, 50);
            this.textDlit.Name = "textDlit";
            this.textDlit.Size = new System.Drawing.Size(121, 20);
            this.textDlit.TabIndex = 0;
            this.textDlit.TextChanged += new System.EventHandler(this.textDlit_TextChanged);
            this.textDlit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDlit_KeyPress);
            // 
            // comboNedel
            // 
            this.comboNedel.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboNedel.FormattingEnabled = true;
            this.comboNedel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboNedel.Location = new System.Drawing.Point(155, 111);
            this.comboNedel.Name = "comboNedel";
            this.comboNedel.Size = new System.Drawing.Size(121, 21);
            this.comboNedel.TabIndex = 1;
            // 
            // labelDlit
            // 
            this.labelDlit.AutoSize = true;
            this.labelDlit.Location = new System.Drawing.Point(27, 53);
            this.labelDlit.Name = "labelDlit";
            this.labelDlit.Size = new System.Drawing.Size(122, 26);
            this.labelDlit.TabIndex = 2;
            this.labelDlit.Text = "Введите длительность\r\nразговора";
            // 
            // labelNedel
            // 
            this.labelNedel.AutoSize = true;
            this.labelNedel.Location = new System.Drawing.Point(39, 114);
            this.labelNedel.Name = "labelNedel";
            this.labelNedel.Size = new System.Drawing.Size(87, 26);
            this.labelNedel.TabIndex = 3;
            this.labelNedel.Text = "Выберите день \r\nнедели\r\n";
            // 
            // labelItog
            // 
            this.labelItog.Location = new System.Drawing.Point(12, 226);
            this.labelItog.Name = "labelItog";
            this.labelItog.Size = new System.Drawing.Size(433, 73);
            this.labelItog.TabIndex = 4;
            // 
            // btnRashet
            // 
            this.btnRashet.Enabled = false;
            this.btnRashet.Location = new System.Drawing.Point(315, 50);
            this.btnRashet.Name = "btnRashet";
            this.btnRashet.Size = new System.Drawing.Size(80, 23);
            this.btnRashet.TabIndex = 5;
            this.btnRashet.Text = "Вычислить";
            this.btnRashet.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRashet.UseVisualStyleBackColor = true;
            this.btnRashet.Click += new System.EventHandler(this.btnRashet_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(315, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 308);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRashet);
            this.Controls.Add(this.labelItog);
            this.Controls.Add(this.labelNedel);
            this.Controls.Add(this.labelDlit);
            this.Controls.Add(this.comboNedel);
            this.Controls.Add(this.textDlit);
            this.Name = "Form1";
            this.Text = "exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDlit;
        private System.Windows.Forms.ComboBox comboNedel;
        private System.Windows.Forms.Label labelDlit;
        private System.Windows.Forms.Label labelNedel;
        private System.Windows.Forms.Label labelItog;
        private System.Windows.Forms.Button btnRashet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

