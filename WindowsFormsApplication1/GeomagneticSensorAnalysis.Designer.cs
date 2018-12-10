namespace MLInVehSensorAnalysis
{
    partial class GeomagneticSensorAnalysis
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeomagneticSensorAnalysis));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonForSerialOpenClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxForStopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxForCheckBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxForDataBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxForBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxForSerialPort = new System.Windows.Forms.ComboBox();
            this.timerForSerialAutoScan = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartForXYZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxOrdinate = new System.Windows.Forms.CheckBox();
            this.checkBoxAbscissa = new System.Windows.Forms.CheckBox();
            this.checkBoxZMark = new System.Windows.Forms.CheckBox();
            this.checkBoxYMark = new System.Windows.Forms.CheckBox();
            this.checkBoxXMark = new System.Windows.Forms.CheckBox();
            this.checkBoxZDisplay = new System.Windows.Forms.CheckBox();
            this.checkBoxYDisplay = new System.Windows.Forms.CheckBox();
            this.checkBoxXDisplay = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonImportDataPosChange = new System.Windows.Forms.Button();
            this.buttonSaveDataPosChange = new System.Windows.Forms.Button();
            this.textBoxImportDataPos = new System.Windows.Forms.TextBox();
            this.textBoxSaveDataPos = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForXYZ)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonForSerialOpenClose);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxForStopBit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxForCheckBit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxForDataBit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxForBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxForSerialPort);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // buttonForSerialOpenClose
            // 
            this.buttonForSerialOpenClose.ForeColor = System.Drawing.Color.Black;
            this.buttonForSerialOpenClose.Location = new System.Drawing.Point(26, 149);
            this.buttonForSerialOpenClose.Name = "buttonForSerialOpenClose";
            this.buttonForSerialOpenClose.Size = new System.Drawing.Size(75, 23);
            this.buttonForSerialOpenClose.TabIndex = 3;
            this.buttonForSerialOpenClose.Text = "打开串口";
            this.buttonForSerialOpenClose.UseVisualStyleBackColor = true;
            this.buttonForSerialOpenClose.Click += new System.EventHandler(this.serialPort_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(4, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "停止位：";
            // 
            // comboBoxForStopBit
            // 
            this.comboBoxForStopBit.FormattingEnabled = true;
            this.comboBoxForStopBit.Location = new System.Drawing.Point(59, 121);
            this.comboBoxForStopBit.Name = "comboBoxForStopBit";
            this.comboBoxForStopBit.Size = new System.Drawing.Size(65, 20);
            this.comboBoxForStopBit.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "校验位：";
            // 
            // comboBoxForCheckBit
            // 
            this.comboBoxForCheckBit.FormattingEnabled = true;
            this.comboBoxForCheckBit.Location = new System.Drawing.Point(59, 95);
            this.comboBoxForCheckBit.Name = "comboBoxForCheckBit";
            this.comboBoxForCheckBit.Size = new System.Drawing.Size(65, 20);
            this.comboBoxForCheckBit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据位：";
            // 
            // comboBoxForDataBit
            // 
            this.comboBoxForDataBit.FormattingEnabled = true;
            this.comboBoxForDataBit.Location = new System.Drawing.Point(59, 69);
            this.comboBoxForDataBit.Name = "comboBoxForDataBit";
            this.comboBoxForDataBit.Size = new System.Drawing.Size(65, 20);
            this.comboBoxForDataBit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "波特率：";
            // 
            // comboBoxForBaudRate
            // 
            this.comboBoxForBaudRate.FormattingEnabled = true;
            this.comboBoxForBaudRate.Location = new System.Drawing.Point(59, 43);
            this.comboBoxForBaudRate.Name = "comboBoxForBaudRate";
            this.comboBoxForBaudRate.Size = new System.Drawing.Size(65, 20);
            this.comboBoxForBaudRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "端  口：";
            // 
            // comboBoxForSerialPort
            // 
            this.comboBoxForSerialPort.FormattingEnabled = true;
            this.comboBoxForSerialPort.Location = new System.Drawing.Point(59, 17);
            this.comboBoxForSerialPort.Name = "comboBoxForSerialPort";
            this.comboBoxForSerialPort.Size = new System.Drawing.Size(65, 20);
            this.comboBoxForSerialPort.TabIndex = 0;
            this.comboBoxForSerialPort.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // timerForSerialAutoScan
            // 
            this.timerForSerialAutoScan.Enabled = true;
            this.timerForSerialAutoScan.Interval = 400;
            this.timerForSerialAutoScan.Tick += new System.EventHandler(this.timerForSerialAutoScan_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartForXYZ);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(162, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 347);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XYZ磁轴波形图";
            // 
            // chartForXYZ
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.BackColor = System.Drawing.SystemColors.ButtonFace;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.chartForXYZ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartForXYZ.Legends.Add(legend1);
            this.chartForXYZ.Location = new System.Drawing.Point(3, 13);
            this.chartForXYZ.Name = "chartForXYZ";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "X";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.DodgerBlue;
            series3.Legend = "Legend1";
            series3.Name = "Z";
            this.chartForXYZ.Series.Add(series1);
            this.chartForXYZ.Series.Add(series2);
            this.chartForXYZ.Series.Add(series3);
            this.chartForXYZ.Size = new System.Drawing.Size(827, 328);
            this.chartForXYZ.TabIndex = 0;
            this.chartForXYZ.Text = "chart1";
            this.chartForXYZ.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chartForXYZ_GetToolTipText);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxOrdinate);
            this.groupBox3.Controls.Add(this.checkBoxAbscissa);
            this.groupBox3.Controls.Add(this.checkBoxZMark);
            this.groupBox3.Controls.Add(this.checkBoxYMark);
            this.groupBox3.Controls.Add(this.checkBoxXMark);
            this.groupBox3.Controls.Add(this.checkBoxZDisplay);
            this.groupBox3.Controls.Add(this.checkBoxYDisplay);
            this.groupBox3.Controls.Add(this.checkBoxXDisplay);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 164);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "显示设置";
            // 
            // checkBoxOrdinate
            // 
            this.checkBoxOrdinate.AutoSize = true;
            this.checkBoxOrdinate.Location = new System.Drawing.Point(26, 128);
            this.checkBoxOrdinate.Name = "checkBoxOrdinate";
            this.checkBoxOrdinate.Size = new System.Drawing.Size(84, 16);
            this.checkBoxOrdinate.TabIndex = 7;
            this.checkBoxOrdinate.Text = "纵坐标网格";
            this.checkBoxOrdinate.UseVisualStyleBackColor = true;
            this.checkBoxOrdinate.CheckedChanged += new System.EventHandler(this.checkBoxOrdinate_CheckedChanged);
            // 
            // checkBoxAbscissa
            // 
            this.checkBoxAbscissa.AutoSize = true;
            this.checkBoxAbscissa.Location = new System.Drawing.Point(26, 97);
            this.checkBoxAbscissa.Name = "checkBoxAbscissa";
            this.checkBoxAbscissa.Size = new System.Drawing.Size(84, 16);
            this.checkBoxAbscissa.TabIndex = 6;
            this.checkBoxAbscissa.Text = "横坐标网格";
            this.checkBoxAbscissa.UseVisualStyleBackColor = true;
            this.checkBoxAbscissa.CheckedChanged += new System.EventHandler(this.checkBoxAbscissa_CheckedChanged);
            // 
            // checkBoxZMark
            // 
            this.checkBoxZMark.AutoSize = true;
            this.checkBoxZMark.Location = new System.Drawing.Point(48, 64);
            this.checkBoxZMark.Name = "checkBoxZMark";
            this.checkBoxZMark.Size = new System.Drawing.Size(90, 16);
            this.checkBoxZMark.TabIndex = 5;
            this.checkBoxZMark.Text = "Z轴数据标记";
            this.checkBoxZMark.UseVisualStyleBackColor = true;
            this.checkBoxZMark.CheckedChanged += new System.EventHandler(this.AxisZMark_CheckedChanged);
            // 
            // checkBoxYMark
            // 
            this.checkBoxYMark.AutoSize = true;
            this.checkBoxYMark.Location = new System.Drawing.Point(48, 42);
            this.checkBoxYMark.Name = "checkBoxYMark";
            this.checkBoxYMark.Size = new System.Drawing.Size(90, 16);
            this.checkBoxYMark.TabIndex = 4;
            this.checkBoxYMark.Text = "Y轴数据标记";
            this.checkBoxYMark.UseVisualStyleBackColor = true;
            this.checkBoxYMark.CheckedChanged += new System.EventHandler(this.AxisYMark_CheckedChanged);
            // 
            // checkBoxXMark
            // 
            this.checkBoxXMark.AutoSize = true;
            this.checkBoxXMark.Location = new System.Drawing.Point(48, 20);
            this.checkBoxXMark.Name = "checkBoxXMark";
            this.checkBoxXMark.Size = new System.Drawing.Size(90, 16);
            this.checkBoxXMark.TabIndex = 3;
            this.checkBoxXMark.Text = "X轴数据标记";
            this.checkBoxXMark.UseVisualStyleBackColor = true;
            this.checkBoxXMark.CheckedChanged += new System.EventHandler(this.AxisXMark_CheckedChanged);
            // 
            // checkBoxZDisplay
            // 
            this.checkBoxZDisplay.AutoSize = true;
            this.checkBoxZDisplay.Location = new System.Drawing.Point(6, 64);
            this.checkBoxZDisplay.Name = "checkBoxZDisplay";
            this.checkBoxZDisplay.Size = new System.Drawing.Size(42, 16);
            this.checkBoxZDisplay.TabIndex = 2;
            this.checkBoxZDisplay.Text = "Z轴";
            this.checkBoxZDisplay.UseVisualStyleBackColor = true;
            this.checkBoxZDisplay.CheckedChanged += new System.EventHandler(this.AxisZDisplay_CheckedChanged);
            // 
            // checkBoxYDisplay
            // 
            this.checkBoxYDisplay.AutoSize = true;
            this.checkBoxYDisplay.Location = new System.Drawing.Point(6, 42);
            this.checkBoxYDisplay.Name = "checkBoxYDisplay";
            this.checkBoxYDisplay.Size = new System.Drawing.Size(42, 16);
            this.checkBoxYDisplay.TabIndex = 1;
            this.checkBoxYDisplay.Text = "Y轴";
            this.checkBoxYDisplay.UseVisualStyleBackColor = true;
            this.checkBoxYDisplay.CheckedChanged += new System.EventHandler(this.AxisYDisplay_CheckedChanged);
            // 
            // checkBoxXDisplay
            // 
            this.checkBoxXDisplay.AutoSize = true;
            this.checkBoxXDisplay.Location = new System.Drawing.Point(6, 20);
            this.checkBoxXDisplay.Name = "checkBoxXDisplay";
            this.checkBoxXDisplay.Size = new System.Drawing.Size(42, 16);
            this.checkBoxXDisplay.TabIndex = 0;
            this.checkBoxXDisplay.Text = "X轴";
            this.checkBoxXDisplay.UseVisualStyleBackColor = true;
            this.checkBoxXDisplay.CheckedChanged += new System.EventHandler(this.AxisXDisplay_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonImportDataPosChange);
            this.groupBox4.Controls.Add(this.buttonSaveDataPosChange);
            this.groupBox4.Controls.Add(this.textBoxImportDataPos);
            this.groupBox4.Controls.Add(this.textBoxSaveDataPos);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.buttonSaveData);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 174);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据选项";
            // 
            // buttonImportDataPosChange
            // 
            this.buttonImportDataPosChange.ForeColor = System.Drawing.Color.Black;
            this.buttonImportDataPosChange.Location = new System.Drawing.Point(101, 102);
            this.buttonImportDataPosChange.Name = "buttonImportDataPosChange";
            this.buttonImportDataPosChange.Size = new System.Drawing.Size(37, 23);
            this.buttonImportDataPosChange.TabIndex = 5;
            this.buttonImportDataPosChange.Text = "更改";
            this.buttonImportDataPosChange.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDataPosChange
            // 
            this.buttonSaveDataPosChange.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveDataPosChange.Location = new System.Drawing.Point(101, 29);
            this.buttonSaveDataPosChange.Name = "buttonSaveDataPosChange";
            this.buttonSaveDataPosChange.Size = new System.Drawing.Size(37, 23);
            this.buttonSaveDataPosChange.TabIndex = 4;
            this.buttonSaveDataPosChange.Text = "更改";
            this.buttonSaveDataPosChange.UseVisualStyleBackColor = true;
            this.buttonSaveDataPosChange.Click += new System.EventHandler(this.buttonSaveDataPosChange_Click);
            // 
            // textBoxImportDataPos
            // 
            this.textBoxImportDataPos.Location = new System.Drawing.Point(6, 131);
            this.textBoxImportDataPos.Name = "textBoxImportDataPos";
            this.textBoxImportDataPos.Size = new System.Drawing.Size(132, 21);
            this.textBoxImportDataPos.TabIndex = 3;
            // 
            // textBoxSaveDataPos
            // 
            this.textBoxSaveDataPos.Location = new System.Drawing.Point(6, 58);
            this.textBoxSaveDataPos.Name = "textBoxSaveDataPos";
            this.textBoxSaveDataPos.Size = new System.Drawing.Size(132, 21);
            this.textBoxSaveDataPos.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "数据导入";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveData.Location = new System.Drawing.Point(6, 29);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveData.TabIndex = 0;
            this.buttonSaveData.Text = "保存数据";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(821, 148);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox1);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(165, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(833, 174);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "实时数据";
            // 
            // GeomagneticSensorAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1009, 552);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeomagneticSensorAnalysis";
            this.Text = "MLInVeh SensorAnalysis";
            this.Load += new System.EventHandler(this.GeomagneticSensorAnalysis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartForXYZ)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxForDataBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxForBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxForSerialPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxForCheckBit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxForStopBit;
        private System.Windows.Forms.Button buttonForSerialOpenClose;
        private System.Windows.Forms.Timer timerForSerialAutoScan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForXYZ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxZDisplay;
        private System.Windows.Forms.CheckBox checkBoxYDisplay;
        private System.Windows.Forms.CheckBox checkBoxXDisplay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBoxZMark;
        private System.Windows.Forms.CheckBox checkBoxYMark;
        private System.Windows.Forms.CheckBox checkBoxXMark;
        private System.Windows.Forms.TextBox textBoxImportDataPos;
        private System.Windows.Forms.TextBox textBoxSaveDataPos;
        private System.Windows.Forms.Button buttonImportDataPosChange;
        private System.Windows.Forms.Button buttonSaveDataPosChange;
        private System.Windows.Forms.CheckBox checkBoxAbscissa;
        private System.Windows.Forms.CheckBox checkBoxOrdinate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

