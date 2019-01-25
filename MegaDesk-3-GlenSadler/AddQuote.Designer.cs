namespace MegaDesk_3_GlenSadler
{
    partial class AddQuote
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
            this.customerName = new System.Windows.Forms.Label();
            this.groupBoxSurfaceArea = new System.Windows.Forms.GroupBox();
            this.groupBoxShipping = new System.Windows.Forms.GroupBox();
            this.radioBtnShippingStandard = new System.Windows.Forms.RadioButton();
            this.radioBtnShipping7days = new System.Windows.Forms.RadioButton();
            this.radioBtnShipping5days = new System.Windows.Forms.RadioButton();
            this.radioBtnShipping3days = new System.Windows.Forms.RadioButton();
            this.groupSurfaceMaterial = new System.Windows.Forms.GroupBox();
            this.radioBtnMaterialRosewood = new System.Windows.Forms.RadioButton();
            this.radioBtnMaterialPine = new System.Windows.Forms.RadioButton();
            this.radioBtnMaterialLaminate = new System.Windows.Forms.RadioButton();
            this.radioBtnMaterialOak = new System.Windows.Forms.RadioButton();
            this.radioBtnMaterialVeneer = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.labelSurfaceArea = new System.Windows.Forms.Label();
            this.labelSurfaceAreaCalc = new System.Windows.Forms.Label();
            this.groupBoxDrawer = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSuraceAreaCalcNumber = new System.Windows.Forms.Label();
            this.labelSurfaceAreaTotal = new System.Windows.Forms.Label();
            this.labelMaterialCalcNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDrawersCalcNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalCostNumber = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelShippingCalcNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBoxSurfaceArea.SuspendLayout();
            this.groupBoxShipping.SuspendLayout();
            this.groupSurfaceMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            this.groupBoxDrawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(28, 23);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(51, 20);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "Name";
            // 
            // groupBoxSurfaceArea
            // 
            this.groupBoxSurfaceArea.Controls.Add(this.labelSurfaceAreaCalc);
            this.groupBoxSurfaceArea.Controls.Add(this.labelSurfaceArea);
            this.groupBoxSurfaceArea.Controls.Add(this.numericUpDownDepth);
            this.groupBoxSurfaceArea.Controls.Add(this.numericUpDownWidth);
            this.groupBoxSurfaceArea.Controls.Add(this.labelDepth);
            this.groupBoxSurfaceArea.Controls.Add(this.labelWidth);
            this.groupBoxSurfaceArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSurfaceArea.Location = new System.Drawing.Point(31, 56);
            this.groupBoxSurfaceArea.Name = "groupBoxSurfaceArea";
            this.groupBoxSurfaceArea.Size = new System.Drawing.Size(268, 139);
            this.groupBoxSurfaceArea.TabIndex = 1;
            this.groupBoxSurfaceArea.TabStop = false;
            this.groupBoxSurfaceArea.Text = "Surface Area";
            // 
            // groupBoxShipping
            // 
            this.groupBoxShipping.Controls.Add(this.radioBtnShipping3days);
            this.groupBoxShipping.Controls.Add(this.radioBtnShipping5days);
            this.groupBoxShipping.Controls.Add(this.radioBtnShipping7days);
            this.groupBoxShipping.Controls.Add(this.radioBtnShippingStandard);
            this.groupBoxShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShipping.Location = new System.Drawing.Point(32, 290);
            this.groupBoxShipping.Name = "groupBoxShipping";
            this.groupBoxShipping.Size = new System.Drawing.Size(268, 148);
            this.groupBoxShipping.TabIndex = 2;
            this.groupBoxShipping.TabStop = false;
            this.groupBoxShipping.Text = "Shipping";
            // 
            // radioBtnShippingStandard
            // 
            this.radioBtnShippingStandard.AutoSize = true;
            this.radioBtnShippingStandard.Location = new System.Drawing.Point(11, 25);
            this.radioBtnShippingStandard.Name = "radioBtnShippingStandard";
            this.radioBtnShippingStandard.Size = new System.Drawing.Size(165, 24);
            this.radioBtnShippingStandard.TabIndex = 3;
            this.radioBtnShippingStandard.TabStop = true;
            this.radioBtnShippingStandard.Text = "Standard (14 Days)";
            this.radioBtnShippingStandard.UseVisualStyleBackColor = true;
            // 
            // radioBtnShipping7days
            // 
            this.radioBtnShipping7days.AutoSize = true;
            this.radioBtnShipping7days.Location = new System.Drawing.Point(11, 55);
            this.radioBtnShipping7days.Name = "radioBtnShipping7days";
            this.radioBtnShipping7days.Size = new System.Drawing.Size(77, 24);
            this.radioBtnShipping7days.TabIndex = 3;
            this.radioBtnShipping7days.TabStop = true;
            this.radioBtnShipping7days.Text = "7-Days";
            this.radioBtnShipping7days.UseVisualStyleBackColor = true;
            // 
            // radioBtnShipping5days
            // 
            this.radioBtnShipping5days.AutoSize = true;
            this.radioBtnShipping5days.Location = new System.Drawing.Point(11, 85);
            this.radioBtnShipping5days.Name = "radioBtnShipping5days";
            this.radioBtnShipping5days.Size = new System.Drawing.Size(77, 24);
            this.radioBtnShipping5days.TabIndex = 4;
            this.radioBtnShipping5days.TabStop = true;
            this.radioBtnShipping5days.Text = "5-Days";
            this.radioBtnShipping5days.UseVisualStyleBackColor = true;
            // 
            // radioBtnShipping3days
            // 
            this.radioBtnShipping3days.AutoSize = true;
            this.radioBtnShipping3days.Location = new System.Drawing.Point(11, 115);
            this.radioBtnShipping3days.Name = "radioBtnShipping3days";
            this.radioBtnShipping3days.Size = new System.Drawing.Size(77, 24);
            this.radioBtnShipping3days.TabIndex = 5;
            this.radioBtnShipping3days.TabStop = true;
            this.radioBtnShipping3days.Text = "3-Days";
            this.radioBtnShipping3days.UseVisualStyleBackColor = true;
            // 
            // groupSurfaceMaterial
            // 
            this.groupSurfaceMaterial.Controls.Add(this.radioBtnMaterialVeneer);
            this.groupSurfaceMaterial.Controls.Add(this.radioBtnMaterialRosewood);
            this.groupSurfaceMaterial.Controls.Add(this.radioBtnMaterialPine);
            this.groupSurfaceMaterial.Controls.Add(this.radioBtnMaterialLaminate);
            this.groupSurfaceMaterial.Controls.Add(this.radioBtnMaterialOak);
            this.groupSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSurfaceMaterial.Location = new System.Drawing.Point(355, 56);
            this.groupSurfaceMaterial.Name = "groupSurfaceMaterial";
            this.groupSurfaceMaterial.Size = new System.Drawing.Size(200, 193);
            this.groupSurfaceMaterial.TabIndex = 6;
            this.groupSurfaceMaterial.TabStop = false;
            this.groupSurfaceMaterial.Text = "Surface Material";
            // 
            // radioBtnMaterialRosewood
            // 
            this.radioBtnMaterialRosewood.AutoSize = true;
            this.radioBtnMaterialRosewood.Location = new System.Drawing.Point(8, 115);
            this.radioBtnMaterialRosewood.Name = "radioBtnMaterialRosewood";
            this.radioBtnMaterialRosewood.Size = new System.Drawing.Size(103, 24);
            this.radioBtnMaterialRosewood.TabIndex = 5;
            this.radioBtnMaterialRosewood.TabStop = true;
            this.radioBtnMaterialRosewood.Text = "Rosewood";
            this.radioBtnMaterialRosewood.UseVisualStyleBackColor = true;
            // 
            // radioBtnMaterialPine
            // 
            this.radioBtnMaterialPine.AutoSize = true;
            this.radioBtnMaterialPine.Location = new System.Drawing.Point(8, 85);
            this.radioBtnMaterialPine.Name = "radioBtnMaterialPine";
            this.radioBtnMaterialPine.Size = new System.Drawing.Size(58, 24);
            this.radioBtnMaterialPine.TabIndex = 4;
            this.radioBtnMaterialPine.TabStop = true;
            this.radioBtnMaterialPine.Text = "Pine";
            this.radioBtnMaterialPine.UseVisualStyleBackColor = true;
            // 
            // radioBtnMaterialLaminate
            // 
            this.radioBtnMaterialLaminate.AutoSize = true;
            this.radioBtnMaterialLaminate.Location = new System.Drawing.Point(8, 55);
            this.radioBtnMaterialLaminate.Name = "radioBtnMaterialLaminate";
            this.radioBtnMaterialLaminate.Size = new System.Drawing.Size(93, 24);
            this.radioBtnMaterialLaminate.TabIndex = 3;
            this.radioBtnMaterialLaminate.TabStop = true;
            this.radioBtnMaterialLaminate.Text = "Laminate";
            this.radioBtnMaterialLaminate.UseVisualStyleBackColor = true;
            // 
            // radioBtnMaterialOak
            // 
            this.radioBtnMaterialOak.AutoSize = true;
            this.radioBtnMaterialOak.Location = new System.Drawing.Point(8, 25);
            this.radioBtnMaterialOak.Name = "radioBtnMaterialOak";
            this.radioBtnMaterialOak.Size = new System.Drawing.Size(56, 24);
            this.radioBtnMaterialOak.TabIndex = 3;
            this.radioBtnMaterialOak.TabStop = true;
            this.radioBtnMaterialOak.Text = "Oak";
            this.radioBtnMaterialOak.UseVisualStyleBackColor = true;
            // 
            // radioBtnMaterialVeneer
            // 
            this.radioBtnMaterialVeneer.AutoSize = true;
            this.radioBtnMaterialVeneer.Location = new System.Drawing.Point(8, 145);
            this.radioBtnMaterialVeneer.Name = "radioBtnMaterialVeneer";
            this.radioBtnMaterialVeneer.Size = new System.Drawing.Size(79, 24);
            this.radioBtnMaterialVeneer.TabIndex = 6;
            this.radioBtnMaterialVeneer.TabStop = true;
            this.radioBtnMaterialVeneer.Text = "Veneer";
            this.radioBtnMaterialVeneer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 7;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(7, 29);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(110, 20);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width (inches)";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(7, 65);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(113, 20);
            this.labelDepth.TabIndex = 1;
            this.labelDepth.Text = "Depth (inches)";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(130, 27);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownWidth.TabIndex = 2;
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(130, 63);
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDepth.TabIndex = 3;
            // 
            // labelSurfaceArea
            // 
            this.labelSurfaceArea.AutoSize = true;
            this.labelSurfaceArea.Location = new System.Drawing.Point(7, 103);
            this.labelSurfaceArea.Name = "labelSurfaceArea";
            this.labelSurfaceArea.Size = new System.Drawing.Size(103, 20);
            this.labelSurfaceArea.TabIndex = 4;
            this.labelSurfaceArea.Text = "Surface Area";
            // 
            // labelSurfaceAreaCalc
            // 
            this.labelSurfaceAreaCalc.AutoSize = true;
            this.labelSurfaceAreaCalc.Location = new System.Drawing.Point(134, 107);
            this.labelSurfaceAreaCalc.Name = "labelSurfaceAreaCalc";
            this.labelSurfaceAreaCalc.Size = new System.Drawing.Size(49, 20);
            this.labelSurfaceAreaCalc.TabIndex = 5;
            this.labelSurfaceAreaCalc.Text = "? sq \"";
            // 
            // groupBoxDrawer
            // 
            this.groupBoxDrawer.Controls.Add(this.numericUpDown1);
            this.groupBoxDrawer.Controls.Add(this.label1);
            this.groupBoxDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDrawer.Location = new System.Drawing.Point(32, 209);
            this.groupBoxDrawer.Name = "groupBoxDrawer";
            this.groupBoxDrawer.Size = new System.Drawing.Size(267, 64);
            this.groupBoxDrawer.TabIndex = 8;
            this.groupBoxDrawer.TabStop = false;
            this.groupBoxDrawer.Text = "Number of Drawers";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(129, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width (in)";
            // 
            // labelSuraceAreaCalcNumber
            // 
            this.labelSuraceAreaCalcNumber.AutoSize = true;
            this.labelSuraceAreaCalcNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuraceAreaCalcNumber.Location = new System.Drawing.Point(479, 269);
            this.labelSuraceAreaCalcNumber.Name = "labelSuraceAreaCalcNumber";
            this.labelSuraceAreaCalcNumber.Size = new System.Drawing.Size(18, 20);
            this.labelSuraceAreaCalcNumber.TabIndex = 10;
            this.labelSuraceAreaCalcNumber.Text = "?";
            // 
            // labelSurfaceAreaTotal
            // 
            this.labelSurfaceAreaTotal.AutoSize = true;
            this.labelSurfaceAreaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurfaceAreaTotal.Location = new System.Drawing.Point(359, 269);
            this.labelSurfaceAreaTotal.Name = "labelSurfaceAreaTotal";
            this.labelSurfaceAreaTotal.Size = new System.Drawing.Size(111, 20);
            this.labelSurfaceAreaTotal.TabIndex = 9;
            this.labelSurfaceAreaTotal.Text = "Surface Area :";
            // 
            // labelMaterialCalcNumber
            // 
            this.labelMaterialCalcNumber.AutoSize = true;
            this.labelMaterialCalcNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterialCalcNumber.Location = new System.Drawing.Point(479, 306);
            this.labelMaterialCalcNumber.Name = "labelMaterialCalcNumber";
            this.labelMaterialCalcNumber.Size = new System.Drawing.Size(18, 20);
            this.labelMaterialCalcNumber.TabIndex = 12;
            this.labelMaterialCalcNumber.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Drawers :";
            // 
            // labelDrawersCalcNumber
            // 
            this.labelDrawersCalcNumber.AutoSize = true;
            this.labelDrawersCalcNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawersCalcNumber.Location = new System.Drawing.Point(479, 336);
            this.labelDrawersCalcNumber.Name = "labelDrawersCalcNumber";
            this.labelDrawersCalcNumber.Size = new System.Drawing.Size(18, 20);
            this.labelDrawersCalcNumber.TabIndex = 14;
            this.labelDrawersCalcNumber.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Materials :";
            // 
            // labelTotalCostNumber
            // 
            this.labelTotalCostNumber.AutoSize = true;
            this.labelTotalCostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCostNumber.Location = new System.Drawing.Point(479, 400);
            this.labelTotalCostNumber.Name = "labelTotalCostNumber";
            this.labelTotalCostNumber.Size = new System.Drawing.Size(18, 20);
            this.labelTotalCostNumber.TabIndex = 16;
            this.labelTotalCostNumber.Text = "?";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.Location = new System.Drawing.Point(381, 397);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(89, 20);
            this.labelTotalCost.TabIndex = 15;
            this.labelTotalCost.Text = "Total Cost :";
            // 
            // labelShippingCalcNumber
            // 
            this.labelShippingCalcNumber.AutoSize = true;
            this.labelShippingCalcNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShippingCalcNumber.Location = new System.Drawing.Point(479, 364);
            this.labelShippingCalcNumber.Name = "labelShippingCalcNumber";
            this.labelShippingCalcNumber.Size = new System.Drawing.Size(18, 20);
            this.labelShippingCalcNumber.TabIndex = 18;
            this.labelShippingCalcNumber.Text = "?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Shipping :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(199, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(342, 474);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 539);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelShippingCalcNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalCostNumber);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelDrawersCalcNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMaterialCalcNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSuraceAreaCalcNumber);
            this.Controls.Add(this.labelSurfaceAreaTotal);
            this.Controls.Add(this.groupBoxDrawer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupSurfaceMaterial);
            this.Controls.Add(this.groupBoxShipping);
            this.Controls.Add(this.groupBoxSurfaceArea);
            this.Controls.Add(this.customerName);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.groupBoxSurfaceArea.ResumeLayout(false);
            this.groupBoxSurfaceArea.PerformLayout();
            this.groupBoxShipping.ResumeLayout(false);
            this.groupBoxShipping.PerformLayout();
            this.groupSurfaceMaterial.ResumeLayout(false);
            this.groupSurfaceMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            this.groupBoxDrawer.ResumeLayout(false);
            this.groupBoxDrawer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.GroupBox groupBoxSurfaceArea;
        private System.Windows.Forms.Label labelSurfaceAreaCalc;
        private System.Windows.Forms.Label labelSurfaceArea;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.GroupBox groupBoxShipping;
        private System.Windows.Forms.RadioButton radioBtnShipping3days;
        private System.Windows.Forms.RadioButton radioBtnShipping5days;
        private System.Windows.Forms.RadioButton radioBtnShipping7days;
        private System.Windows.Forms.RadioButton radioBtnShippingStandard;
        private System.Windows.Forms.GroupBox groupSurfaceMaterial;
        private System.Windows.Forms.RadioButton radioBtnMaterialVeneer;
        private System.Windows.Forms.RadioButton radioBtnMaterialRosewood;
        private System.Windows.Forms.RadioButton radioBtnMaterialPine;
        private System.Windows.Forms.RadioButton radioBtnMaterialLaminate;
        private System.Windows.Forms.RadioButton radioBtnMaterialOak;
        private System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.GroupBox groupBoxDrawer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSuraceAreaCalcNumber;
        private System.Windows.Forms.Label labelSurfaceAreaTotal;
        private System.Windows.Forms.Label labelMaterialCalcNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDrawersCalcNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalCostNumber;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelShippingCalcNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}