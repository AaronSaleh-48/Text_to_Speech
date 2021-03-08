namespace Speeeech100
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.rtxText = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBruh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnAddText = new System.Windows.Forms.Button();
            this.grbExtern = new System.Windows.Forms.GroupBox();
            this.grbSpeechSettings = new System.Windows.Forms.GroupBox();
            this.lblLanguageText = new System.Windows.Forms.Label();
            this.cmbLanguages = new System.Windows.Forms.ComboBox();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.lblVolumeText = new System.Windows.Forms.Label();
            this.lblSpeedText = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSaveAudio = new System.Windows.Forms.Button();
            this.grbRecord = new System.Windows.Forms.GroupBox();
            this.grbExtern.SuspendLayout();
            this.grbSpeechSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.grbRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rtxText
            // 
            resources.ApplyResources(this.rtxText, "rtxText");
            this.rtxText.Name = "rtxText";
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBruh
            // 
            resources.ApplyResources(this.btnBruh, "btnBruh");
            this.btnBruh.Name = "btnBruh";
            this.btnBruh.UseVisualStyleBackColor = true;
            this.btnBruh.Click += new System.EventHandler(this.btnBruh_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenFile
            // 
            resources.ApplyResources(this.btnOpenFile, "btnOpenFile");
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            resources.ApplyResources(this.txtFileName, "txtFileName");
            this.txtFileName.Name = "txtFileName";
            // 
            // btnAddText
            // 
            resources.ApplyResources(this.btnAddText, "btnAddText");
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbExtern
            // 
            this.grbExtern.Controls.Add(this.btnOpenFile);
            this.grbExtern.Controls.Add(this.btnAddText);
            this.grbExtern.Controls.Add(this.txtFileName);
            resources.ApplyResources(this.grbExtern, "grbExtern");
            this.grbExtern.Name = "grbExtern";
            this.grbExtern.TabStop = false;
            // 
            // grbSpeechSettings
            // 
            this.grbSpeechSettings.Controls.Add(this.lblLanguageText);
            this.grbSpeechSettings.Controls.Add(this.cmbLanguages);
            this.grbSpeechSettings.Controls.Add(this.trbVolume);
            this.grbSpeechSettings.Controls.Add(this.trbSpeed);
            this.grbSpeechSettings.Controls.Add(this.lblVolumeText);
            this.grbSpeechSettings.Controls.Add(this.lblSpeedText);
            resources.ApplyResources(this.grbSpeechSettings, "grbSpeechSettings");
            this.grbSpeechSettings.Name = "grbSpeechSettings";
            this.grbSpeechSettings.TabStop = false;
            // 
            // lblLanguageText
            // 
            resources.ApplyResources(this.lblLanguageText, "lblLanguageText");
            this.lblLanguageText.Name = "lblLanguageText";
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.FormattingEnabled = true;
            resources.ApplyResources(this.cmbLanguages, "cmbLanguages");
            this.cmbLanguages.Name = "cmbLanguages";
            // 
            // trbVolume
            // 
            resources.ApplyResources(this.trbVolume, "trbVolume");
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Value = 50;
            // 
            // trbSpeed
            // 
            resources.ApplyResources(this.trbSpeed, "trbSpeed");
            this.trbSpeed.Minimum = -10;
            this.trbSpeed.Name = "trbSpeed";
            // 
            // lblVolumeText
            // 
            resources.ApplyResources(this.lblVolumeText, "lblVolumeText");
            this.lblVolumeText.Name = "lblVolumeText";
            // 
            // lblSpeedText
            // 
            resources.ApplyResources(this.lblSpeedText, "lblSpeedText");
            this.lblSpeedText.Name = "lblSpeedText";
            // 
            // btnSaveAudio
            // 
            resources.ApplyResources(this.btnSaveAudio, "btnSaveAudio");
            this.btnSaveAudio.Name = "btnSaveAudio";
            this.btnSaveAudio.UseVisualStyleBackColor = true;
            this.btnSaveAudio.Click += new System.EventHandler(this.btnSaveAudio_Click);
            // 
            // grbRecord
            // 
            this.grbRecord.Controls.Add(this.btnSaveAudio);
            resources.ApplyResources(this.grbRecord, "grbRecord");
            this.grbRecord.Name = "grbRecord";
            this.grbRecord.TabStop = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbRecord);
            this.Controls.Add(this.grbSpeechSettings);
            this.Controls.Add(this.grbExtern);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBruh);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.rtxText);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbExtern.ResumeLayout(false);
            this.grbExtern.PerformLayout();
            this.grbSpeechSettings.ResumeLayout(false);
            this.grbSpeechSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            this.grbRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RichTextBox rtxText;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBruh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.GroupBox grbExtern;
        private System.Windows.Forms.GroupBox grbSpeechSettings;
        private System.Windows.Forms.Label lblVolumeText;
        private System.Windows.Forms.Label lblSpeedText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.TrackBar trbSpeed;
        private System.Windows.Forms.Button btnSaveAudio;
        private System.Windows.Forms.GroupBox grbRecord;
        private System.Windows.Forms.Label lblLanguageText;
        private System.Windows.Forms.ComboBox cmbLanguages;
    }
}

