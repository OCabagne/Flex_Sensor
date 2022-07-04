namespace flexoSensor
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.connect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.binario = new System.Windows.Forms.Label();
            this.Grados = new System.Windows.Forms.Label();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(192)))));
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Location = new System.Drawing.Point(21, 375);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(204, 53);
            this.connect.TabIndex = 0;
            this.connect.Text = "Conectar";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 38);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(868, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(192)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(907, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 32);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // binario
            // 
            this.binario.AutoSize = true;
            this.binario.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.binario.Location = new System.Drawing.Point(57, 255);
            this.binario.Name = "binario";
            this.binario.Size = new System.Drawing.Size(124, 28);
            this.binario.TabIndex = 2;
            this.binario.Text = "10101010";
            this.binario.UseWaitCursor = true;
            // 
            // Grados
            // 
            this.Grados.AutoSize = true;
            this.Grados.Font = new System.Drawing.Font("Century", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Grados.Location = new System.Drawing.Point(68, 163);
            this.Grados.Name = "Grados";
            this.Grados.Size = new System.Drawing.Size(138, 80);
            this.Grados.TabIndex = 3;
            this.Grados.Text = "45°";
            this.Grados.UseWaitCursor = true;
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.grafica.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.grafica.BorderlineColor = System.Drawing.Color.Transparent;
            this.grafica.BorderlineWidth = 0;
            this.grafica.BorderSkin.BackColor = System.Drawing.Color.White;
            this.grafica.BorderSkin.PageColor = System.Drawing.Color.Maroon;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.grafica.Legends.Add(legend4);
            this.grafica.Location = new System.Drawing.Point(261, 86);
            this.grafica.Name = "grafica";
            this.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Aqua;
            series4.Legend = "Legend1";
            series4.Name = "Grafica";
            series4.YValuesPerPoint = 4;
            this.grafica.Series.Add(series4);
            this.grafica.Size = new System.Drawing.Size(628, 320);
            this.grafica.TabIndex = 4;
            this.grafica.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(258, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ángulo °";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(849, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo (s)";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(57, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Flexo-Sensor";
            this.label3.UseWaitCursor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.Grados);
            this.Controls.Add(this.binario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label binario;
        private System.Windows.Forms.Label Grados;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

