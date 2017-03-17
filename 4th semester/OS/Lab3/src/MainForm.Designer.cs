namespace Lab3
{
    partial class MainForm
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
            this.initialList = new System.Windows.Forms.ListBox();
            this.inititalGroup = new System.Windows.Forms.GroupBox();
            this.sortedGroup = new System.Windows.Forms.GroupBox();
            this.sortedList = new System.Windows.Forms.ListBox();
            this.generateGroup = new System.Windows.Forms.GroupBox();
            this.generate = new System.Windows.Forms.Button();
            this.arraySize = new System.Windows.Forms.NumericUpDown();
            this.generateLabel = new System.Windows.Forms.Label();
            this.sortGroup = new System.Windows.Forms.GroupBox();
            this.sortIncDec = new System.Windows.Forms.Button();
            this.sortDecreasing = new System.Windows.Forms.Button();
            this.useCritical = new System.Windows.Forms.CheckBox();
            this.sortParallel = new System.Windows.Forms.Button();
            this.sortSelection = new System.Windows.Forms.Button();
            this.sortBubble = new System.Windows.Forms.Button();
            this.parallelSortedGroup = new System.Windows.Forms.GroupBox();
            this.parallelSortedList = new System.Windows.Forms.ListBox();
            this.inititalGroup.SuspendLayout();
            this.sortedGroup.SuspendLayout();
            this.generateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).BeginInit();
            this.sortGroup.SuspendLayout();
            this.parallelSortedGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialList
            // 
            this.initialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialList.FormattingEnabled = true;
            this.initialList.Location = new System.Drawing.Point(3, 16);
            this.initialList.Name = "initialList";
            this.initialList.Size = new System.Drawing.Size(149, 268);
            this.initialList.TabIndex = 0;
            // 
            // inititalGroup
            // 
            this.inititalGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inititalGroup.Controls.Add(this.initialList);
            this.inititalGroup.Location = new System.Drawing.Point(258, 12);
            this.inititalGroup.Name = "inititalGroup";
            this.inititalGroup.Size = new System.Drawing.Size(155, 287);
            this.inititalGroup.TabIndex = 1;
            this.inititalGroup.TabStop = false;
            this.inititalGroup.Text = "Изначальный массив:";
            // 
            // sortedGroup
            // 
            this.sortedGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sortedGroup.Controls.Add(this.sortedList);
            this.sortedGroup.Location = new System.Drawing.Point(419, 12);
            this.sortedGroup.Name = "sortedGroup";
            this.sortedGroup.Size = new System.Drawing.Size(155, 287);
            this.sortedGroup.TabIndex = 2;
            this.sortedGroup.TabStop = false;
            this.sortedGroup.Text = "Сортированный массив:";
            // 
            // sortedList
            // 
            this.sortedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortedList.FormattingEnabled = true;
            this.sortedList.Location = new System.Drawing.Point(3, 16);
            this.sortedList.Name = "sortedList";
            this.sortedList.Size = new System.Drawing.Size(149, 268);
            this.sortedList.TabIndex = 0;
            // 
            // generateGroup
            // 
            this.generateGroup.Controls.Add(this.generate);
            this.generateGroup.Controls.Add(this.arraySize);
            this.generateGroup.Controls.Add(this.generateLabel);
            this.generateGroup.Location = new System.Drawing.Point(12, 12);
            this.generateGroup.Name = "generateGroup";
            this.generateGroup.Size = new System.Drawing.Size(240, 71);
            this.generateGroup.TabIndex = 3;
            this.generateGroup.TabStop = false;
            this.generateGroup.Text = "Генерация массива";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(121, 40);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(93, 23);
            this.generate.TabIndex = 1;
            this.generate.Text = "Сгенерировать";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(108, 14);
            this.arraySize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.arraySize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(106, 20);
            this.arraySize.TabIndex = 4;
            this.arraySize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // generateLabel
            // 
            this.generateLabel.AutoSize = true;
            this.generateLabel.Location = new System.Drawing.Point(6, 16);
            this.generateLabel.Name = "generateLabel";
            this.generateLabel.Size = new System.Drawing.Size(96, 13);
            this.generateLabel.TabIndex = 4;
            this.generateLabel.Text = "Размер массива:";
            // 
            // sortGroup
            // 
            this.sortGroup.Controls.Add(this.sortIncDec);
            this.sortGroup.Controls.Add(this.sortDecreasing);
            this.sortGroup.Controls.Add(this.useCritical);
            this.sortGroup.Controls.Add(this.sortParallel);
            this.sortGroup.Controls.Add(this.sortSelection);
            this.sortGroup.Controls.Add(this.sortBubble);
            this.sortGroup.Location = new System.Drawing.Point(12, 89);
            this.sortGroup.Name = "sortGroup";
            this.sortGroup.Size = new System.Drawing.Size(240, 207);
            this.sortGroup.TabIndex = 1;
            this.sortGroup.TabStop = false;
            this.sortGroup.Text = "Сортировка";
            // 
            // sortIncDec
            // 
            this.sortIncDec.Location = new System.Drawing.Point(6, 178);
            this.sortIncDec.Name = "sortIncDec";
            this.sortIncDec.Size = new System.Drawing.Size(228, 23);
            this.sortIncDec.TabIndex = 1;
            this.sortIncDec.Text = "Сортировка по возрастанию и убыванию";
            this.sortIncDec.UseVisualStyleBackColor = true;
            this.sortIncDec.Click += new System.EventHandler(this.sortIncDec_Click);
            // 
            // sortDecreasing
            // 
            this.sortDecreasing.Location = new System.Drawing.Point(6, 149);
            this.sortDecreasing.Name = "sortDecreasing";
            this.sortDecreasing.Size = new System.Drawing.Size(228, 23);
            this.sortDecreasing.TabIndex = 1;
            this.sortDecreasing.Text = "Сортировка пузырьком по убыванию";
            this.sortDecreasing.UseVisualStyleBackColor = true;
            this.sortDecreasing.Click += new System.EventHandler(this.sortDecreasing_Click);
            // 
            // useCritical
            // 
            this.useCritical.AutoSize = true;
            this.useCritical.Location = new System.Drawing.Point(9, 77);
            this.useCritical.Name = "useCritical";
            this.useCritical.Size = new System.Drawing.Size(205, 17);
            this.useCritical.TabIndex = 1;
            this.useCritical.Text = "Использовать критические секции";
            this.useCritical.UseVisualStyleBackColor = true;
            // 
            // sortParallel
            // 
            this.sortParallel.Location = new System.Drawing.Point(6, 100);
            this.sortParallel.Name = "sortParallel";
            this.sortParallel.Size = new System.Drawing.Size(228, 23);
            this.sortParallel.TabIndex = 1;
            this.sortParallel.Text = "Сортировка пузырьком и выбором";
            this.sortParallel.UseVisualStyleBackColor = true;
            this.sortParallel.Click += new System.EventHandler(this.sortParallel_Click);
            // 
            // sortSelection
            // 
            this.sortSelection.Location = new System.Drawing.Point(6, 48);
            this.sortSelection.Name = "sortSelection";
            this.sortSelection.Size = new System.Drawing.Size(228, 23);
            this.sortSelection.TabIndex = 1;
            this.sortSelection.Text = "Сортировка выбором";
            this.sortSelection.UseVisualStyleBackColor = true;
            this.sortSelection.Click += new System.EventHandler(this.sortSelection_Click);
            // 
            // sortBubble
            // 
            this.sortBubble.Location = new System.Drawing.Point(6, 19);
            this.sortBubble.Name = "sortBubble";
            this.sortBubble.Size = new System.Drawing.Size(228, 23);
            this.sortBubble.TabIndex = 1;
            this.sortBubble.Text = "Сортировать пузырьком";
            this.sortBubble.UseVisualStyleBackColor = true;
            this.sortBubble.Click += new System.EventHandler(this.sortBubble_Click);
            // 
            // parallelSortedGroup
            // 
            this.parallelSortedGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.parallelSortedGroup.Controls.Add(this.parallelSortedList);
            this.parallelSortedGroup.Location = new System.Drawing.Point(580, 12);
            this.parallelSortedGroup.Name = "parallelSortedGroup";
            this.parallelSortedGroup.Size = new System.Drawing.Size(163, 287);
            this.parallelSortedGroup.TabIndex = 4;
            this.parallelSortedGroup.TabStop = false;
            this.parallelSortedGroup.Text = "П. сортированный массив:";
            // 
            // parallelSortedList
            // 
            this.parallelSortedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parallelSortedList.FormattingEnabled = true;
            this.parallelSortedList.Location = new System.Drawing.Point(3, 16);
            this.parallelSortedList.Name = "parallelSortedList";
            this.parallelSortedList.Size = new System.Drawing.Size(157, 268);
            this.parallelSortedList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 313);
            this.Controls.Add(this.parallelSortedGroup);
            this.Controls.Add(this.sortGroup);
            this.Controls.Add(this.generateGroup);
            this.Controls.Add(this.sortedGroup);
            this.Controls.Add(this.inititalGroup);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №3";
            this.inititalGroup.ResumeLayout(false);
            this.sortedGroup.ResumeLayout(false);
            this.generateGroup.ResumeLayout(false);
            this.generateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).EndInit();
            this.sortGroup.ResumeLayout(false);
            this.sortGroup.PerformLayout();
            this.parallelSortedGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox initialList;
        private System.Windows.Forms.GroupBox inititalGroup;
        private System.Windows.Forms.GroupBox sortedGroup;
        private System.Windows.Forms.ListBox sortedList;
        private System.Windows.Forms.GroupBox generateGroup;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.NumericUpDown arraySize;
        private System.Windows.Forms.Label generateLabel;
        private System.Windows.Forms.GroupBox sortGroup;
        private System.Windows.Forms.CheckBox useCritical;
        private System.Windows.Forms.Button sortParallel;
        private System.Windows.Forms.Button sortSelection;
        private System.Windows.Forms.Button sortBubble;
        private System.Windows.Forms.GroupBox parallelSortedGroup;
        private System.Windows.Forms.ListBox parallelSortedList;
        private System.Windows.Forms.Button sortIncDec;
        private System.Windows.Forms.Button sortDecreasing;
    }
}

