﻿namespace Mir_4_Launcher
{
    partial class SettingsForm
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
            DX11Button = new PictureBox();
            FullscreenButton = new PictureBox();
            WindowedButton = new PictureBox();
            DX12Button = new PictureBox();
            MainSettingsLabel = new Label();
            DirectXLabel = new Label();
            ResolutionLabel = new Label();
            GraphicsLabel = new Label();
            CloseImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DX11Button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FullscreenButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WindowedButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DX12Button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseImage).BeginInit();
            SuspendLayout();
            // 
            // DX11Button
            // 
            DX11Button.Image = Properties.Resources.DX11;
            DX11Button.Location = new Point(185, 105);
            DX11Button.Name = "DX11Button";
            DX11Button.Size = new Size(118, 38);
            DX11Button.TabIndex = 0;
            DX11Button.TabStop = false;
            DX11Button.Click += DX11Button_Click;
            // 
            // FullscreenButton
            // 
            FullscreenButton.Image = Properties.Resources.WindowedButton;
            FullscreenButton.Location = new Point(185, 174);
            FullscreenButton.Name = "FullscreenButton";
            FullscreenButton.Size = new Size(118, 38);
            FullscreenButton.TabIndex = 1;
            FullscreenButton.TabStop = false;
            FullscreenButton.Click += FullscreenButton_Click;
            // 
            // WindowedButton
            // 
            WindowedButton.Image = Properties.Resources.FullscreenButton;
            WindowedButton.Location = new Point(365, 174);
            WindowedButton.Name = "WindowedButton";
            WindowedButton.Size = new Size(118, 38);
            WindowedButton.TabIndex = 3;
            WindowedButton.TabStop = false;
            WindowedButton.Click += WindowedButton_Click;
            // 
            // DX12Button
            // 
            DX12Button.Image = Properties.Resources.DX12;
            DX12Button.Location = new Point(365, 105);
            DX12Button.Name = "DX12Button";
            DX12Button.Size = new Size(118, 38);
            DX12Button.TabIndex = 2;
            DX12Button.TabStop = false;
            DX12Button.Click += DX12Button_Click;
            // 
            // MainSettingsLabel
            // 
            MainSettingsLabel.AutoSize = true;
            MainSettingsLabel.BackColor = Color.Transparent;
            MainSettingsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            MainSettingsLabel.ForeColor = Color.White;
            MainSettingsLabel.Location = new Point(189, 0);
            MainSettingsLabel.Name = "MainSettingsLabel";
            MainSettingsLabel.Size = new Size(122, 37);
            MainSettingsLabel.TabIndex = 4;
            MainSettingsLabel.Text = "Settings";
            // 
            // DirectXLabel
            // 
            DirectXLabel.AutoSize = true;
            DirectXLabel.BackColor = Color.Transparent;
            DirectXLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            DirectXLabel.ForeColor = Color.White;
            DirectXLabel.Location = new Point(26, 106);
            DirectXLabel.Name = "DirectXLabel";
            DirectXLabel.Size = new Size(106, 32);
            DirectXLabel.TabIndex = 5;
            DirectXLabel.Text = "Direct X";
            // 
            // ResolutionLabel
            // 
            ResolutionLabel.AutoSize = true;
            ResolutionLabel.BackColor = Color.Transparent;
            ResolutionLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ResolutionLabel.ForeColor = Color.White;
            ResolutionLabel.Location = new Point(26, 174);
            ResolutionLabel.Name = "ResolutionLabel";
            ResolutionLabel.Size = new Size(136, 32);
            ResolutionLabel.TabIndex = 6;
            ResolutionLabel.Text = "Resolution";
            // 
            // GraphicsLabel
            // 
            GraphicsLabel.AutoSize = true;
            GraphicsLabel.BackColor = Color.Transparent;
            GraphicsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            GraphicsLabel.ForeColor = Color.White;
            GraphicsLabel.Location = new Point(12, 52);
            GraphicsLabel.Name = "GraphicsLabel";
            GraphicsLabel.Size = new Size(113, 32);
            GraphicsLabel.TabIndex = 7;
            GraphicsLabel.Text = "Graphics";
            // 
            // CloseImage
            // 
            CloseImage.BackColor = Color.Transparent;
            CloseImage.BackgroundImageLayout = ImageLayout.Center;
            CloseImage.Image = Properties.Resources.SettingsClose;
            CloseImage.Location = new Point(473, 12);
            CloseImage.Name = "CloseImage";
            CloseImage.Size = new Size(15, 15);
            CloseImage.TabIndex = 11;
            CloseImage.TabStop = false;
            CloseImage.Click += CloseImage_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.SettingsBackdrop;
            ClientSize = new Size(500, 219);
            Controls.Add(CloseImage);
            Controls.Add(GraphicsLabel);
            Controls.Add(ResolutionLabel);
            Controls.Add(DirectXLabel);
            Controls.Add(MainSettingsLabel);
            Controls.Add(WindowedButton);
            Controls.Add(DX12Button);
            Controls.Add(FullscreenButton);
            Controls.Add(DX11Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)DX11Button).EndInit();
            ((System.ComponentModel.ISupportInitialize)FullscreenButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)WindowedButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)DX12Button).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DX11Button;
        private PictureBox FullscreenButton;
        private PictureBox WindowedButton;
        private PictureBox DX12Button;
        private Label MainSettingsLabel;
        private Label DirectXLabel;
        private Label ResolutionLabel;
        private Label GraphicsLabel;
        private PictureBox CloseImage;
    }
}