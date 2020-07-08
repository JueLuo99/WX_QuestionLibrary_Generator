namespace WX_QuestionLibrary_Generator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxSelection = new System.Windows.Forms.TextBox();
            this.buttonAddThisSelection = new System.Windows.Forms.Button();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxAnswer = new System.Windows.Forms.ListBox();
            this.listBoxAllSelections = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSaveQuestionLibrary = new System.Windows.Forms.Button();
            this.buttonLoadQuestionLibrary = new System.Windows.Forms.Button();
            this.listBoxLibrary = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelPreviewInfo = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(6, 20);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(338, 161);
            this.textBoxQuestion.TabIndex = 1;
            // 
            // textBoxSelection
            // 
            this.textBoxSelection.Location = new System.Drawing.Point(6, 20);
            this.textBoxSelection.Multiline = true;
            this.textBoxSelection.Name = "textBoxSelection";
            this.textBoxSelection.Size = new System.Drawing.Size(338, 107);
            this.textBoxSelection.TabIndex = 3;
            // 
            // buttonAddThisSelection
            // 
            this.buttonAddThisSelection.Location = new System.Drawing.Point(350, 20);
            this.buttonAddThisSelection.Name = "buttonAddThisSelection";
            this.buttonAddThisSelection.Size = new System.Drawing.Size(116, 34);
            this.buttonAddThisSelection.TabIndex = 4;
            this.buttonAddThisSelection.Text = "添加该选项";
            this.buttonAddThisSelection.UseVisualStyleBackColor = true;
            this.buttonAddThisSelection.Click += new System.EventHandler(this.buttonAddThisSelection_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(6, 20);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.Size = new System.Drawing.Size(267, 400);
            this.textBoxPreview.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddQuestion);
            this.groupBox1.Controls.Add(this.textBoxQuestion);
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一步：输入题目";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(350, 20);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(116, 37);
            this.buttonAddQuestion.TabIndex = 2;
            this.buttonAddQuestion.Text = "确认添加题目";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddThisSelection);
            this.groupBox2.Controls.Add(this.textBoxSelection);
            this.groupBox2.Location = new System.Drawing.Point(14, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 141);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二步：输入选项";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDeleteSelected);
            this.groupBox3.Controls.Add(this.buttonRemove);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.listBoxAnswer);
            this.groupBox3.Controls.Add(this.listBoxAllSelections);
            this.groupBox3.Location = new System.Drawing.Point(14, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 172);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第三步：选择正确答案";
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(178, 108);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(117, 30);
            this.buttonDeleteSelected.TabIndex = 4;
            this.buttonDeleteSelected.Text = "删除该选项";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(177, 71);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(118, 30);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "取消正确答案";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(177, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "选为正确答案";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxAnswer
            // 
            this.listBoxAnswer.FormattingEnabled = true;
            this.listBoxAnswer.ItemHeight = 12;
            this.listBoxAnswer.Location = new System.Drawing.Point(301, 18);
            this.listBoxAnswer.Name = "listBoxAnswer";
            this.listBoxAnswer.Size = new System.Drawing.Size(165, 148);
            this.listBoxAnswer.TabIndex = 1;
            // 
            // listBoxAllSelections
            // 
            this.listBoxAllSelections.FormattingEnabled = true;
            this.listBoxAllSelections.ItemHeight = 12;
            this.listBoxAllSelections.Location = new System.Drawing.Point(6, 18);
            this.listBoxAllSelections.Name = "listBoxAllSelections";
            this.listBoxAllSelections.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAllSelections.Size = new System.Drawing.Size(165, 148);
            this.listBoxAllSelections.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSaveQuestionLibrary);
            this.groupBox4.Controls.Add(this.buttonLoadQuestionLibrary);
            this.groupBox4.Controls.Add(this.listBoxLibrary);
            this.groupBox4.Location = new System.Drawing.Point(798, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 512);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "题库列表";
            // 
            // buttonSaveQuestionLibrary
            // 
            this.buttonSaveQuestionLibrary.Location = new System.Drawing.Point(172, 465);
            this.buttonSaveQuestionLibrary.Name = "buttonSaveQuestionLibrary";
            this.buttonSaveQuestionLibrary.Size = new System.Drawing.Size(71, 41);
            this.buttonSaveQuestionLibrary.TabIndex = 2;
            this.buttonSaveQuestionLibrary.Text = "保存题库";
            this.buttonSaveQuestionLibrary.UseVisualStyleBackColor = true;
            this.buttonSaveQuestionLibrary.Click += new System.EventHandler(this.buttonSaveQuestionLibrary_Click);
            // 
            // buttonLoadQuestionLibrary
            // 
            this.buttonLoadQuestionLibrary.Location = new System.Drawing.Point(18, 465);
            this.buttonLoadQuestionLibrary.Name = "buttonLoadQuestionLibrary";
            this.buttonLoadQuestionLibrary.Size = new System.Drawing.Size(71, 41);
            this.buttonLoadQuestionLibrary.TabIndex = 1;
            this.buttonLoadQuestionLibrary.Text = "加载题库";
            this.buttonLoadQuestionLibrary.UseVisualStyleBackColor = true;
            this.buttonLoadQuestionLibrary.Click += new System.EventHandler(this.buttonLoadQuestionLibrary_Click);
            // 
            // listBoxLibrary
            // 
            this.listBoxLibrary.FormattingEnabled = true;
            this.listBoxLibrary.ItemHeight = 12;
            this.listBoxLibrary.Location = new System.Drawing.Point(6, 20);
            this.listBoxLibrary.Name = "listBoxLibrary";
            this.listBoxLibrary.Size = new System.Drawing.Size(237, 400);
            this.listBoxLibrary.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelPreviewInfo);
            this.groupBox5.Controls.Add(this.buttonSubmit);
            this.groupBox5.Controls.Add(this.textBoxPreview);
            this.groupBox5.Location = new System.Drawing.Point(503, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 512);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "第四步：题目预览和提交";
            // 
            // labelPreviewInfo
            // 
            this.labelPreviewInfo.AutoSize = true;
            this.labelPreviewInfo.Location = new System.Drawing.Point(7, 439);
            this.labelPreviewInfo.Name = "labelPreviewInfo";
            this.labelPreviewInfo.Size = new System.Drawing.Size(0, 12);
            this.labelPreviewInfo.TabIndex = 8;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(6, 465);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(267, 41);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "添加/修改本题到题库";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 543);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "小程序配套题库生成器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxSelection;
        private System.Windows.Forms.Button buttonAddThisSelection;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonConfirmAnswer;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxAnswer;
        private System.Windows.Forms.ListBox listBoxAllSelections;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSaveQuestionLibrary;
        private System.Windows.Forms.Button buttonLoadQuestionLibrary;
        private System.Windows.Forms.ListBox listBoxLibrary;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelPreviewInfo;
        private System.Windows.Forms.Button buttonDeleteSelected;
    }
}

