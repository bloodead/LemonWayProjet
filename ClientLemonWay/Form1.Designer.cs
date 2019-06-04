namespace ClientLemonWay
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_FiboService = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Label_load = new System.Windows.Forms.Label();
            this.LoaderGif = new System.Windows.Forms.PictureBox();
            this.Btn_min = new System.Windows.Forms.Button();
            this.Btn_maxWin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_XmlToJson = new System.Windows.Forms.Button();
            this.XmlContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XmlToJsonPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbt_Fibo = new System.Windows.Forms.TextBox();
            this.Fibo_Panel = new System.Windows.Forms.Panel();
            this.Btn_fibo10 = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Fibo_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_FiboService
            // 
            this.Btn_FiboService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_FiboService.Location = new System.Drawing.Point(154, 224);
            this.Btn_FiboService.Name = "Btn_FiboService";
            this.Btn_FiboService.Size = new System.Drawing.Size(75, 23);
            this.Btn_FiboService.TabIndex = 0;
            this.Btn_FiboService.Text = "FiboAction";
            this.Btn_FiboService.UseVisualStyleBackColor = true;
            this.Btn_FiboService.Click += new System.EventHandler(this.FiboCallWeb_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(237)))), ((int)(((byte)(125)))));
            this.HeaderPanel.Controls.Add(this.Label_load);
            this.HeaderPanel.Controls.Add(this.LoaderGif);
            this.HeaderPanel.Controls.Add(this.Btn_min);
            this.HeaderPanel.Controls.Add(this.Btn_maxWin);
            this.HeaderPanel.Controls.Add(this.button1);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 32);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            this.HeaderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseUp);
            // 
            // Label_load
            // 
            this.Label_load.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_load.AutoSize = true;
            this.Label_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(237)))), ((int)(((byte)(125)))));
            this.Label_load.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_load.ForeColor = System.Drawing.Color.White;
            this.Label_load.Location = new System.Drawing.Point(40, 9);
            this.Label_load.Name = "Label_load";
            this.Label_load.Size = new System.Drawing.Size(154, 21);
            this.Label_load.TabIndex = 5;
            this.Label_load.Text = "Requesting...";
            this.Label_load.Visible = false;
            // 
            // LoaderGif
            // 
            this.LoaderGif.Location = new System.Drawing.Point(4, 2);
            this.LoaderGif.Name = "LoaderGif";
            this.LoaderGif.Size = new System.Drawing.Size(30, 30);
            this.LoaderGif.TabIndex = 5;
            this.LoaderGif.TabStop = false;
            // 
            // Btn_min
            // 
            this.Btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_min.BackgroundImage = global::ClientLemonWay.Properties.Resources.icons8_minimize_window_32px;
            this.Btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_min.FlatAppearance.BorderSize = 0;
            this.Btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_min.Location = new System.Drawing.Point(693, 2);
            this.Btn_min.Name = "Btn_min";
            this.Btn_min.Size = new System.Drawing.Size(30, 29);
            this.Btn_min.TabIndex = 4;
            this.Btn_min.UseVisualStyleBackColor = true;
            this.Btn_min.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_min_MouseUp);
            // 
            // Btn_maxWin
            // 
            this.Btn_maxWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_maxWin.BackgroundImage = global::ClientLemonWay.Properties.Resources.icons8_maximize_window_32px;
            this.Btn_maxWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_maxWin.FlatAppearance.BorderSize = 0;
            this.Btn_maxWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_maxWin.Location = new System.Drawing.Point(729, 2);
            this.Btn_maxWin.Name = "Btn_maxWin";
            this.Btn_maxWin.Size = new System.Drawing.Size(30, 29);
            this.Btn_maxWin.TabIndex = 3;
            this.Btn_maxWin.UseVisualStyleBackColor = true;
            this.Btn_maxWin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MaxWin_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::ClientLemonWay.Properties.Resources.icons8_cancel_32px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(765, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_XmlToJson);
            this.splitContainer1.Panel1.Controls.Add(this.XmlContent);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.XmlToJsonPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.Tbt_Fibo);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_FiboService);
            this.splitContainer1.Panel2.Controls.Add(this.Fibo_Panel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 418);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 5;
            // 
            // Btn_XmlToJson
            // 
            this.Btn_XmlToJson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_XmlToJson.Location = new System.Drawing.Point(131, 302);
            this.Btn_XmlToJson.Name = "Btn_XmlToJson";
            this.Btn_XmlToJson.Size = new System.Drawing.Size(75, 23);
            this.Btn_XmlToJson.TabIndex = 3;
            this.Btn_XmlToJson.Text = "FiboAction";
            this.Btn_XmlToJson.UseVisualStyleBackColor = true;
            this.Btn_XmlToJson.Click += new System.EventHandler(this.Btn_XmlToJson_Click);
            // 
            // XmlContent
            // 
            this.XmlContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.XmlContent.Location = new System.Drawing.Point(79, 187);
            this.XmlContent.Name = "XmlContent";
            this.XmlContent.Size = new System.Drawing.Size(211, 109);
            this.XmlContent.TabIndex = 4;
            this.XmlContent.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(157)))));
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(75, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "XmlToJson Service";
            // 
            // XmlToJsonPanel
            // 
            this.XmlToJsonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(157)))));
            this.XmlToJsonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XmlToJsonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XmlToJsonPanel.Location = new System.Drawing.Point(0, 0);
            this.XmlToJsonPanel.Name = "XmlToJsonPanel";
            this.XmlToJsonPanel.Size = new System.Drawing.Size(409, 418);
            this.XmlToJsonPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(157)))));
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(110, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fibonacci Service";
            // 
            // Tbt_Fibo
            // 
            this.Tbt_Fibo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Tbt_Fibo.Location = new System.Drawing.Point(144, 187);
            this.Tbt_Fibo.Name = "Tbt_Fibo";
            this.Tbt_Fibo.Size = new System.Drawing.Size(100, 20);
            this.Tbt_Fibo.TabIndex = 1;
            // 
            // Fibo_Panel
            // 
            this.Fibo_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(157)))));
            this.Fibo_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fibo_Panel.Controls.Add(this.Btn_fibo10);
            this.Fibo_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fibo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Fibo_Panel.Name = "Fibo_Panel";
            this.Fibo_Panel.Size = new System.Drawing.Size(387, 418);
            this.Fibo_Panel.TabIndex = 3;
            // 
            // Btn_fibo10
            // 
            this.Btn_fibo10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_fibo10.Location = new System.Drawing.Point(113, 252);
            this.Btn_fibo10.Name = "Btn_fibo10";
            this.Btn_fibo10.Size = new System.Drawing.Size(156, 23);
            this.Btn_fibo10.TabIndex = 4;
            this.Btn_fibo10.Text = "Compute Fibonancci(10)";
            this.Btn_fibo10.UseVisualStyleBackColor = true;
            this.Btn_fibo10.Click += new System.EventHandler(this.Btn_fibo10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderGif)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Fibo_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_FiboService;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button Btn_min;
        private System.Windows.Forms.Button Btn_maxWin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbt_Fibo;
        private System.Windows.Forms.Button Btn_XmlToJson;
        private System.Windows.Forms.RichTextBox XmlContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel XmlToJsonPanel;
        private System.Windows.Forms.Panel Fibo_Panel;
        private System.Windows.Forms.PictureBox LoaderGif;
        private System.Windows.Forms.Label Label_load;
        private System.Windows.Forms.Button Btn_fibo10;
    }
}

