namespace Algoritmo_Banquero_02_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Word", "3", "2", "1" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Excel", "1", "2", "2" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Spotify", "1", "0", "1" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Word", "1", "2", "0" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Excel", "2", "0", "2" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Spotify", "5", "0", "1" }, -1);
            button1 = new Button();
            PBar_Recurso1 = new ProgressBar();
            labelR1 = new Label();
            labelR2 = new Label();
            PBar_Recurso2 = new ProgressBar();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            list_EstadoInicial = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button2 = new Button();
            labelProgreso1 = new Label();
            labelProgreso2 = new Label();
            labelProgreso3 = new Label();
            labelR3 = new Label();
            PBar_Recurso3 = new ProgressBar();
            list_EstadoFinal = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(353, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 1;
            button1.Text = "Iniciar Algoritmo";
            button1.UseVisualStyleBackColor = true;
            // 
            // PBar_Recurso1
            // 
            PBar_Recurso1.Location = new Point(102, 236);
            PBar_Recurso1.MarqueeAnimationSpeed = 0;
            PBar_Recurso1.Name = "PBar_Recurso1";
            PBar_Recurso1.Size = new Size(94, 15);
            PBar_Recurso1.Style = ProgressBarStyle.Continuous;
            PBar_Recurso1.TabIndex = 2;
            // 
            // labelR1
            // 
            labelR1.AutoSize = true;
            labelR1.Location = new Point(18, 236);
            labelR1.Name = "labelR1";
            labelR1.Size = new Size(84, 15);
            labelR1.TabIndex = 3;
            labelR1.Text = "Recurso 1 = 10";
            // 
            // labelR2
            // 
            labelR2.AutoSize = true;
            labelR2.Location = new Point(18, 257);
            labelR2.Name = "labelR2";
            labelR2.Size = new Size(78, 15);
            labelR2.TabIndex = 5;
            labelR2.Text = "Recurso 2 = 4";
            // 
            // PBar_Recurso2
            // 
            PBar_Recurso2.Location = new Point(102, 257);
            PBar_Recurso2.MarqueeAnimationSpeed = 10;
            PBar_Recurso2.Name = "PBar_Recurso2";
            PBar_Recurso2.Size = new Size(94, 15);
            PBar_Recurso2.Style = ProgressBarStyle.Continuous;
            PBar_Recurso2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 9);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 7;
            label3.Text = "Requisito de Recurso 1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 23);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 9);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 9;
            label4.Text = "Requisito de Recurso 2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(7, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 9);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 11;
            label5.Text = "Nombre del Proceso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 106);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 13;
            label6.Text = "Estado Inicial";
            // 
            // list_EstadoInicial
            // 
            list_EstadoInicial.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader7 });
            list_EstadoInicial.GridLines = true;
            list_EstadoInicial.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            list_EstadoInicial.LabelEdit = true;
            list_EstadoInicial.Location = new Point(16, 124);
            list_EstadoInicial.Name = "list_EstadoInicial";
            list_EstadoInicial.Size = new Size(325, 90);
            list_EstadoInicial.TabIndex = 14;
            list_EstadoInicial.UseCompatibleStateImageBehavior = false;
            list_EstadoInicial.View = View.Details;
            list_EstadoInicial.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Recurso 1";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Recurso 2";
            columnHeader3.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Recurso 3";
            columnHeader7.Width = 80;
            // 
            // button2
            // 
            button2.Location = new Point(266, 246);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 17;
            button2.Text = "Verificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelProgreso1
            // 
            labelProgreso1.AutoSize = true;
            labelProgreso1.BackColor = Color.Transparent;
            labelProgreso1.Location = new Point(202, 236);
            labelProgreso1.Name = "labelProgreso1";
            labelProgreso1.Size = new Size(36, 15);
            labelProgreso1.TabIndex = 18;
            labelProgreso1.Text = "0/100";
            // 
            // labelProgreso2
            // 
            labelProgreso2.AutoSize = true;
            labelProgreso2.BackColor = Color.Transparent;
            labelProgreso2.Location = new Point(202, 257);
            labelProgreso2.Name = "labelProgreso2";
            labelProgreso2.Size = new Size(36, 15);
            labelProgreso2.TabIndex = 19;
            labelProgreso2.Text = "0/100";
            // 
            // labelProgreso3
            // 
            labelProgreso3.AutoSize = true;
            labelProgreso3.BackColor = Color.Transparent;
            labelProgreso3.Location = new Point(202, 278);
            labelProgreso3.Name = "labelProgreso3";
            labelProgreso3.Size = new Size(36, 15);
            labelProgreso3.TabIndex = 22;
            labelProgreso3.Text = "0/100";
            // 
            // labelR3
            // 
            labelR3.AutoSize = true;
            labelR3.Location = new Point(18, 278);
            labelR3.Name = "labelR3";
            labelR3.Size = new Size(78, 15);
            labelR3.TabIndex = 21;
            labelR3.Text = "Recurso 2 = 5";
            labelR3.Click += label9_Click;
            // 
            // PBar_Recurso3
            // 
            PBar_Recurso3.Location = new Point(102, 278);
            PBar_Recurso3.MarqueeAnimationSpeed = 0;
            PBar_Recurso3.Name = "PBar_Recurso3";
            PBar_Recurso3.Size = new Size(94, 15);
            PBar_Recurso3.Style = ProgressBarStyle.Continuous;
            PBar_Recurso3.TabIndex = 20;
            // 
            // list_EstadoFinal
            // 
            list_EstadoFinal.CheckBoxes = true;
            list_EstadoFinal.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader8 });
            list_EstadoFinal.FullRowSelect = true;
            list_EstadoFinal.GridLines = true;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            list_EstadoFinal.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            list_EstadoFinal.LabelEdit = true;
            list_EstadoFinal.Location = new Point(404, 124);
            list_EstadoFinal.Name = "list_EstadoFinal";
            list_EstadoFinal.Size = new Size(325, 90);
            list_EstadoFinal.TabIndex = 24;
            list_EstadoFinal.UseCompatibleStateImageBehavior = false;
            list_EstadoFinal.View = View.Details;
            list_EstadoFinal.ItemCheck += list_EstadoFinal_ItemCheck;
            list_EstadoFinal.ItemChecked += list_EstadoFinal_ItemChecked;
            list_EstadoFinal.SelectedIndexChanged += list_EstadoFinal_SelectedIndexChanged;
            list_EstadoFinal.MouseDown += list_EstadoFinal_MouseDown;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nombre";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Recurso 1";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Recurso 2";
            columnHeader6.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Recurso 3";
            columnHeader8.Width = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 106);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 23;
            label7.Text = "Estado Final";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 376);
            Controls.Add(list_EstadoFinal);
            Controls.Add(label7);
            Controls.Add(labelProgreso3);
            Controls.Add(labelR3);
            Controls.Add(PBar_Recurso3);
            Controls.Add(labelProgreso2);
            Controls.Add(labelProgreso1);
            Controls.Add(button2);
            Controls.Add(list_EstadoInicial);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(labelR2);
            Controls.Add(PBar_Recurso2);
            Controls.Add(labelR1);
            Controls.Add(PBar_Recurso1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ProgressBar PBar_Recurso1;
        private Label labelR1;
        private Label labelR2;
        private ProgressBar PBar_Recurso2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private ListView list_EstadoInicial;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button2;
        private Label labelProgreso1;
        private Label labelProgreso2;
        private Label labelProgreso3;
        private Label labelR3;
        private ProgressBar PBar_Recurso3;
        private ColumnHeader columnHeader7;
        private ListView list_EstadoFinal;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private Label label7;
    }
}
