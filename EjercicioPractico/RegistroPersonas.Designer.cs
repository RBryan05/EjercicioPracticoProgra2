namespace EjercicioPractico
{
    partial class RegistroPersonas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label personTypeLabel;
            System.Windows.Forms.Label nameStyleLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label suffixLabel;
            System.Windows.Forms.Label emailPromotionLabel;
            System.Windows.Forms.Label additionalContactInfoLabel;
            System.Windows.Forms.Label demographicsLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.brnAgregar = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPersonType = new System.Windows.Forms.TextBox();
            this.ckbNameStyle = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.txtEmailPromotion = new System.Windows.Forms.TextBox();
            this.txtAdditionalContactInfo = new System.Windows.Forms.TextBox();
            this.txtDemographics = new System.Windows.Forms.TextBox();
            this.txtRowguid = new System.Windows.Forms.TextBox();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            personTypeLabel = new System.Windows.Forms.Label();
            nameStyleLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            suffixLabel = new System.Windows.Forms.Label();
            emailPromotionLabel = new System.Windows.Forms.Label();
            additionalContactInfoLabel = new System.Windows.Forms.Label();
            demographicsLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // personTypeLabel
            // 
            personTypeLabel.AutoSize = true;
            personTypeLabel.Location = new System.Drawing.Point(969, 168);
            personTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            personTypeLabel.Name = "personTypeLabel";
            personTypeLabel.Size = new System.Drawing.Size(70, 13);
            personTypeLabel.TabIndex = 51;
            personTypeLabel.Text = "Person Type:";
            // 
            // nameStyleLabel
            // 
            nameStyleLabel.AutoSize = true;
            nameStyleLabel.Location = new System.Drawing.Point(969, 190);
            nameStyleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameStyleLabel.Name = "nameStyleLabel";
            nameStyleLabel.Size = new System.Drawing.Size(64, 13);
            nameStyleLabel.TabIndex = 53;
            nameStyleLabel.Text = "Name Style:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(969, 209);
            titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 55;
            titleLabel.Text = "Title:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(969, 230);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 57;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(969, 251);
            middleNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(72, 13);
            middleNameLabel.TabIndex = 59;
            middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(969, 271);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 61;
            lastNameLabel.Text = "Last Name:";
            // 
            // suffixLabel
            // 
            suffixLabel.AutoSize = true;
            suffixLabel.Location = new System.Drawing.Point(969, 292);
            suffixLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            suffixLabel.Name = "suffixLabel";
            suffixLabel.Size = new System.Drawing.Size(36, 13);
            suffixLabel.TabIndex = 63;
            suffixLabel.Text = "Suffix:";
            // 
            // emailPromotionLabel
            // 
            emailPromotionLabel.AutoSize = true;
            emailPromotionLabel.Location = new System.Drawing.Point(969, 313);
            emailPromotionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailPromotionLabel.Name = "emailPromotionLabel";
            emailPromotionLabel.Size = new System.Drawing.Size(85, 13);
            emailPromotionLabel.TabIndex = 65;
            emailPromotionLabel.Text = "Email Promotion:";
            // 
            // additionalContactInfoLabel
            // 
            additionalContactInfoLabel.AutoSize = true;
            additionalContactInfoLabel.Location = new System.Drawing.Point(969, 334);
            additionalContactInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            additionalContactInfoLabel.Name = "additionalContactInfoLabel";
            additionalContactInfoLabel.Size = new System.Drawing.Size(117, 13);
            additionalContactInfoLabel.TabIndex = 67;
            additionalContactInfoLabel.Text = "Additional Contact Info:";
            // 
            // demographicsLabel
            // 
            demographicsLabel.AutoSize = true;
            demographicsLabel.Location = new System.Drawing.Point(969, 355);
            demographicsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            demographicsLabel.Name = "demographicsLabel";
            demographicsLabel.Size = new System.Drawing.Size(78, 13);
            demographicsLabel.TabIndex = 69;
            demographicsLabel.Text = "Demographics:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(969, 375);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 13);
            label3.TabIndex = 71;
            label3.Text = "RowGuid:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(969, 399);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 13);
            label4.TabIndex = 73;
            label4.Text = "Fecha de modificacion:";
            // 
            // brnAgregar
            // 
            this.brnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.brnAgregar.Location = new System.Drawing.Point(387, 603);
            this.brnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnAgregar.Name = "brnAgregar";
            this.brnAgregar.Size = new System.Drawing.Size(170, 33);
            this.brnAgregar.TabIndex = 0;
            this.brnAgregar.Text = "Actualizar Tabla";
            this.brnAgregar.UseVisualStyleBackColor = true;
            this.brnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvPersons.Location = new System.Drawing.Point(22, 89);
            this.dgvPersons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersWidth = 100;
            this.dgvPersons.RowTemplate.Height = 28;
            this.dgvPersons.Size = new System.Drawing.Size(931, 493);
            this.dgvPersons.TabIndex = 1;
            this.dgvPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Suffix";
            this.dataGridViewTextBoxColumn2.HeaderText = "Suffix";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AdditionalContactInfo";
            this.dataGridViewTextBoxColumn3.HeaderText = "AdditionalContactInfo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Suffix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Suffix";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 109;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AdditionalContactInfo";
            this.dataGridViewTextBoxColumn6.HeaderText = "AdditionalContactInfo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por Primer Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(174, 37);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(144, 20);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1099, 103);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(190, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(969, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Business Entity ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(972, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(317, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar Persona";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPersonType
            // 
            this.txtPersonType.Location = new System.Drawing.Point(1090, 166);
            this.txtPersonType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPersonType.Name = "txtPersonType";
            this.txtPersonType.Size = new System.Drawing.Size(199, 20);
            this.txtPersonType.TabIndex = 52;
            // 
            // ckbNameStyle
            // 
            this.ckbNameStyle.Location = new System.Drawing.Point(1090, 187);
            this.ckbNameStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbNameStyle.Name = "ckbNameStyle";
            this.ckbNameStyle.Size = new System.Drawing.Size(197, 16);
            this.ckbNameStyle.TabIndex = 54;
            this.ckbNameStyle.Text = "Verdadero";
            this.ckbNameStyle.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(1090, 207);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(199, 20);
            this.txtTitle.TabIndex = 56;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(1090, 228);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 20);
            this.txtFirstName.TabIndex = 58;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(1090, 249);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(199, 20);
            this.txtMiddleName.TabIndex = 60;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1090, 270);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 20);
            this.txtLastName.TabIndex = 62;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(1090, 290);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(199, 20);
            this.txtSuffix.TabIndex = 64;
            // 
            // txtEmailPromotion
            // 
            this.txtEmailPromotion.Location = new System.Drawing.Point(1090, 311);
            this.txtEmailPromotion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailPromotion.Name = "txtEmailPromotion";
            this.txtEmailPromotion.Size = new System.Drawing.Size(199, 20);
            this.txtEmailPromotion.TabIndex = 66;
            // 
            // txtAdditionalContactInfo
            // 
            this.txtAdditionalContactInfo.Location = new System.Drawing.Point(1090, 332);
            this.txtAdditionalContactInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdditionalContactInfo.Name = "txtAdditionalContactInfo";
            this.txtAdditionalContactInfo.Size = new System.Drawing.Size(199, 20);
            this.txtAdditionalContactInfo.TabIndex = 68;
            // 
            // txtDemographics
            // 
            this.txtDemographics.Location = new System.Drawing.Point(1090, 353);
            this.txtDemographics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDemographics.Name = "txtDemographics";
            this.txtDemographics.Size = new System.Drawing.Size(199, 20);
            this.txtDemographics.TabIndex = 70;
            // 
            // txtRowguid
            // 
            this.txtRowguid.Location = new System.Drawing.Point(1090, 374);
            this.txtRowguid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRowguid.Name = "txtRowguid";
            this.txtRowguid.ReadOnly = true;
            this.txtRowguid.Size = new System.Drawing.Size(199, 20);
            this.txtRowguid.TabIndex = 72;
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.Enabled = false;
            this.dtpFechaModificacion.Location = new System.Drawing.Point(1089, 395);
            this.dtpFechaModificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaModificacion.TabIndex = 74;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsertar.Location = new System.Drawing.Point(972, 463);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(129, 60);
            this.btnInsertar.TabIndex = 75;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Location = new System.Drawing.Point(1158, 463);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 60);
            this.btnActualizar.TabIndex = 76;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // RegistroPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 647);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtpFechaModificacion);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtRowguid);
            this.Controls.Add(personTypeLabel);
            this.Controls.Add(this.txtPersonType);
            this.Controls.Add(nameStyleLabel);
            this.Controls.Add(this.ckbNameStyle);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(suffixLabel);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(emailPromotionLabel);
            this.Controls.Add(this.txtEmailPromotion);
            this.Controls.Add(additionalContactInfoLabel);
            this.Controls.Add(this.txtAdditionalContactInfo);
            this.Controls.Add(demographicsLabel);
            this.Controls.Add(this.txtDemographics);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.brnAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1142, 680);
            this.Name = "RegistroPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnAgregar;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPersonType;
        private System.Windows.Forms.CheckBox ckbNameStyle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.TextBox txtEmailPromotion;
        private System.Windows.Forms.TextBox txtAdditionalContactInfo;
        private System.Windows.Forms.TextBox txtDemographics;
        private System.Windows.Forms.TextBox txtRowguid;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

