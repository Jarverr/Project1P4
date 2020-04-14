namespace Project1ListaPrzebojów
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateDB = new System.Windows.Forms.Button();
            this.GoToDB = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorCreation = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateDB
            // 
            this.CreateDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateDB.Location = new System.Drawing.Point(3, 3);
            this.CreateDB.Name = "CreateDB";
            this.CreateDB.Size = new System.Drawing.Size(423, 100);
            this.CreateDB.TabIndex = 0;
            this.CreateDB.Text = "Utwórz Bazę Danych";
            this.CreateDB.UseVisualStyleBackColor = true;
            this.CreateDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoToDB
            // 
            this.GoToDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoToDB.Location = new System.Drawing.Point(432, 3);
            this.GoToDB.Name = "GoToDB";
            this.GoToDB.Size = new System.Drawing.Size(423, 100);
            this.GoToDB.TabIndex = 1;
            this.GoToDB.Text = "Przejdź do Bazy Danych";
            this.GoToDB.UseVisualStyleBackColor = true;
            this.GoToDB.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GoToDB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreateDB, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 294);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 106);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ErrorCreation
            // 
            this.ErrorCreation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider1.SetError(this.ErrorCreation, "Nie można utworzyć bazy danych, gdyż została ona wykryta jako utworzona.");
            this.ErrorCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorCreation.Location = new System.Drawing.Point(300, 258);
            this.ErrorCreation.Name = "ErrorCreation";
            this.ErrorCreation.ReadOnly = true;
            this.ErrorCreation.Size = new System.Drawing.Size(351, 30);
            this.ErrorCreation.TabIndex = 3;
            this.ErrorCreation.Text = "Baza danych już istnieje!";
            this.ErrorCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ErrorCreation.Visible = false;
            this.ErrorCreation.TextChanged += new System.EventHandler(this.ErrorCreation_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project1ListaPrzebojów.Properties.Resources.logoNuta;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(229, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista Twoich Przebojów";
            // 
            // Form1
            // 
            this.AcceptButton = this.GoToDB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ErrorCreation);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(900, 459);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDB;
        private System.Windows.Forms.Button GoToDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ErrorCreation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

