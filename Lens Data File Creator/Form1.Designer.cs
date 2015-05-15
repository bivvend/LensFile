namespace Lens_Data_File_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBoxHeader = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveHeader = new System.Windows.Forms.Button();
            this.buttonLoadHeader = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRMat22 = new System.Windows.Forms.TextBox();
            this.textBoxRMat12 = new System.Windows.Forms.TextBox();
            this.textBoxRMat21 = new System.Windows.Forms.TextBox();
            this.textBoxRMat11 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonApplyRotation = new System.Windows.Forms.Button();
            this.textBoxMat22 = new System.Windows.Forms.TextBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.textBoxMat12 = new System.Windows.Forms.TextBox();
            this.buttonSaveDataAsText = new System.Windows.Forms.Button();
            this.textBoxMat21 = new System.Windows.Forms.TextBox();
            this.buttonLoadDataFromText = new System.Windows.Forms.Button();
            this.textBoxMat11 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumberOfPoints = new System.Windows.Forms.Label();
            this.richTextBoxFull = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSaveFullText = new System.Windows.Forms.Button();
            this.buttonFullFileNoRotate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxHeader
            // 
            this.richTextBoxHeader.Location = new System.Drawing.Point(4, 18);
            this.richTextBoxHeader.Name = "richTextBoxHeader";
            this.richTextBoxHeader.Size = new System.Drawing.Size(232, 295);
            this.richTextBoxHeader.TabIndex = 1;
            this.richTextBoxHeader.Text = resources.GetString("richTextBoxHeader.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveHeader);
            this.groupBox1.Controls.Add(this.buttonLoadHeader);
            this.groupBox1.Controls.Add(this.richTextBoxHeader);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // buttonSaveHeader
            // 
            this.buttonSaveHeader.Location = new System.Drawing.Point(91, 327);
            this.buttonSaveHeader.Name = "buttonSaveHeader";
            this.buttonSaveHeader.Size = new System.Drawing.Size(81, 32);
            this.buttonSaveHeader.TabIndex = 3;
            this.buttonSaveHeader.Text = "Save Header";
            this.buttonSaveHeader.UseVisualStyleBackColor = true;
            this.buttonSaveHeader.Click += new System.EventHandler(this.buttonSaveHeader_Click);
            // 
            // buttonLoadHeader
            // 
            this.buttonLoadHeader.Location = new System.Drawing.Point(4, 327);
            this.buttonLoadHeader.Name = "buttonLoadHeader";
            this.buttonLoadHeader.Size = new System.Drawing.Size(81, 32);
            this.buttonLoadHeader.TabIndex = 2;
            this.buttonLoadHeader.Text = "Load Header";
            this.buttonLoadHeader.UseVisualStyleBackColor = true;
            this.buttonLoadHeader.Click += new System.EventHandler(this.buttonLoadHeader_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRMat22);
            this.groupBox2.Controls.Add(this.textBoxRMat12);
            this.groupBox2.Controls.Add(this.textBoxRMat21);
            this.groupBox2.Controls.Add(this.textBoxRMat11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonApplyRotation);
            this.groupBox2.Controls.Add(this.textBoxMat22);
            this.groupBox2.Controls.Add(this.buttonLoadData);
            this.groupBox2.Controls.Add(this.textBoxMat12);
            this.groupBox2.Controls.Add(this.buttonSaveDataAsText);
            this.groupBox2.Controls.Add(this.textBoxMat21);
            this.groupBox2.Controls.Add(this.buttonLoadDataFromText);
            this.groupBox2.Controls.Add(this.textBoxMat11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.richTextBoxBody);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 375);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Body";
            // 
            // textBoxRMat22
            // 
            this.textBoxRMat22.Location = new System.Drawing.Point(85, 301);
            this.textBoxRMat22.Name = "textBoxRMat22";
            this.textBoxRMat22.Size = new System.Drawing.Size(62, 20);
            this.textBoxRMat22.TabIndex = 19;
            // 
            // textBoxRMat12
            // 
            this.textBoxRMat12.Location = new System.Drawing.Point(17, 301);
            this.textBoxRMat12.Name = "textBoxRMat12";
            this.textBoxRMat12.Size = new System.Drawing.Size(62, 20);
            this.textBoxRMat12.TabIndex = 18;
            // 
            // textBoxRMat21
            // 
            this.textBoxRMat21.Location = new System.Drawing.Point(85, 275);
            this.textBoxRMat21.Name = "textBoxRMat21";
            this.textBoxRMat21.Size = new System.Drawing.Size(62, 20);
            this.textBoxRMat21.TabIndex = 17;
            // 
            // textBoxRMat11
            // 
            this.textBoxRMat11.Location = new System.Drawing.Point(17, 275);
            this.textBoxRMat11.Name = "textBoxRMat11";
            this.textBoxRMat11.Size = new System.Drawing.Size(62, 20);
            this.textBoxRMat11.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data Inverse Rotation Matrix";
            // 
            // buttonApplyRotation
            // 
            this.buttonApplyRotation.Location = new System.Drawing.Point(176, 237);
            this.buttonApplyRotation.Name = "buttonApplyRotation";
            this.buttonApplyRotation.Size = new System.Drawing.Size(65, 46);
            this.buttonApplyRotation.TabIndex = 14;
            this.buttonApplyRotation.Text = "Apply Rotations";
            this.buttonApplyRotation.UseVisualStyleBackColor = true;
            this.buttonApplyRotation.Click += new System.EventHandler(this.buttonApplyRotation_Click);
            // 
            // textBoxMat22
            // 
            this.textBoxMat22.Location = new System.Drawing.Point(84, 229);
            this.textBoxMat22.Name = "textBoxMat22";
            this.textBoxMat22.Size = new System.Drawing.Size(62, 20);
            this.textBoxMat22.TabIndex = 13;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(12, 327);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(66, 32);
            this.buttonLoadData.TabIndex = 6;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // textBoxMat12
            // 
            this.textBoxMat12.Location = new System.Drawing.Point(16, 229);
            this.textBoxMat12.Name = "textBoxMat12";
            this.textBoxMat12.Size = new System.Drawing.Size(62, 20);
            this.textBoxMat12.TabIndex = 12;
            // 
            // buttonSaveDataAsText
            // 
            this.buttonSaveDataAsText.Location = new System.Drawing.Point(176, 327);
            this.buttonSaveDataAsText.Name = "buttonSaveDataAsText";
            this.buttonSaveDataAsText.Size = new System.Drawing.Size(66, 32);
            this.buttonSaveDataAsText.TabIndex = 5;
            this.buttonSaveDataAsText.Text = "Save Text";
            this.buttonSaveDataAsText.UseVisualStyleBackColor = true;
            this.buttonSaveDataAsText.Click += new System.EventHandler(this.buttonSaveDataAsText_Click);
            // 
            // textBoxMat21
            // 
            this.textBoxMat21.Location = new System.Drawing.Point(84, 203);
            this.textBoxMat21.Name = "textBoxMat21";
            this.textBoxMat21.Size = new System.Drawing.Size(62, 20);
            this.textBoxMat21.TabIndex = 11;
            // 
            // buttonLoadDataFromText
            // 
            this.buttonLoadDataFromText.Location = new System.Drawing.Point(94, 327);
            this.buttonLoadDataFromText.Name = "buttonLoadDataFromText";
            this.buttonLoadDataFromText.Size = new System.Drawing.Size(66, 32);
            this.buttonLoadDataFromText.TabIndex = 4;
            this.buttonLoadDataFromText.Text = "Load Text";
            this.buttonLoadDataFromText.UseVisualStyleBackColor = true;
            this.buttonLoadDataFromText.Click += new System.EventHandler(this.buttonLoadDataFromText_Click);
            // 
            // textBoxMat11
            // 
            this.textBoxMat11.Location = new System.Drawing.Point(16, 203);
            this.textBoxMat11.Name = "textBoxMat11";
            this.textBoxMat11.Size = new System.Drawing.Size(62, 20);
            this.textBoxMat11.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Index Inverse Rotation Matrix";
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Location = new System.Drawing.Point(4, 18);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(232, 159);
            this.richTextBoxBody.TabIndex = 1;
            this.richTextBoxBody.Text = "";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(726, 301);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(84, 35);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Points:";
            // 
            // labelNumberOfPoints
            // 
            this.labelNumberOfPoints.AutoSize = true;
            this.labelNumberOfPoints.Location = new System.Drawing.Point(629, 312);
            this.labelNumberOfPoints.Name = "labelNumberOfPoints";
            this.labelNumberOfPoints.Size = new System.Drawing.Size(13, 13);
            this.labelNumberOfPoints.TabIndex = 6;
            this.labelNumberOfPoints.Text = "0";
            // 
            // richTextBoxFull
            // 
            this.richTextBoxFull.Location = new System.Drawing.Point(8, 14);
            this.richTextBoxFull.Name = "richTextBoxFull";
            this.richTextBoxFull.Size = new System.Drawing.Size(265, 213);
            this.richTextBoxFull.TabIndex = 7;
            this.richTextBoxFull.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSaveFullText);
            this.groupBox3.Controls.Add(this.buttonFullFileNoRotate);
            this.groupBox3.Controls.Add(this.richTextBoxFull);
            this.groupBox3.Location = new System.Drawing.Point(527, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 283);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Full File";
            // 
            // buttonSaveFullText
            // 
            this.buttonSaveFullText.Location = new System.Drawing.Point(180, 233);
            this.buttonSaveFullText.Name = "buttonSaveFullText";
            this.buttonSaveFullText.Size = new System.Drawing.Size(93, 29);
            this.buttonSaveFullText.TabIndex = 8;
            this.buttonSaveFullText.Text = "Save Text";
            this.buttonSaveFullText.UseVisualStyleBackColor = true;
            this.buttonSaveFullText.Click += new System.EventHandler(this.buttonSaveFullText_Click);
            // 
            // buttonFullFileNoRotate
            // 
            this.buttonFullFileNoRotate.Location = new System.Drawing.Point(15, 233);
            this.buttonFullFileNoRotate.Name = "buttonFullFileNoRotate";
            this.buttonFullFileNoRotate.Size = new System.Drawing.Size(93, 29);
            this.buttonFullFileNoRotate.TabIndex = 7;
            this.buttonFullFileNoRotate.Text = "Create Full File";
            this.buttonFullFileNoRotate.UseVisualStyleBackColor = true;
            this.buttonFullFileNoRotate.Click += new System.EventHandler(this.buttonFullFileNoRotate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelNumberOfPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Data File Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveHeader;
        private System.Windows.Forms.Button buttonLoadHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSaveDataAsText;
        private System.Windows.Forms.Button buttonLoadDataFromText;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumberOfPoints;
        private System.Windows.Forms.RichTextBox richTextBoxFull;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFullFileNoRotate;
        private System.Windows.Forms.Button buttonSaveFullText;
        private System.Windows.Forms.Button buttonApplyRotation;
        private System.Windows.Forms.TextBox textBoxMat22;
        private System.Windows.Forms.TextBox textBoxMat12;
        private System.Windows.Forms.TextBox textBoxMat21;
        private System.Windows.Forms.TextBox textBoxMat11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRMat22;
        private System.Windows.Forms.TextBox textBoxRMat12;
        private System.Windows.Forms.TextBox textBoxRMat21;
        private System.Windows.Forms.TextBox textBoxRMat11;
        private System.Windows.Forms.Label label3;
    }
}

