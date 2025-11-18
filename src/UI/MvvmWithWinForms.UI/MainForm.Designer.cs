namespace MvvmWithWinForms.UI;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // Designer fields for controls
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.TextBox textBoxPath;
    private System.Windows.Forms.Label labelCode;
    private System.Windows.Forms.TextBox textBoxCode;
    private System.Windows.Forms.Button buttonGenerate;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "MainForm";

        this.labelPath = new System.Windows.Forms.Label();
        this.textBoxPath = new System.Windows.Forms.TextBox();
        this.labelCode = new System.Windows.Forms.Label();
        this.textBoxCode = new System.Windows.Forms.TextBox();
        this.buttonGenerate = new System.Windows.Forms.Button();

        // 
        // labelPath
        // 
        this.labelPath.AutoSize = true;
        this.labelPath.Location = new System.Drawing.Point(12, 15);
        this.labelPath.Name = "labelPath";
        this.labelPath.Size = new System.Drawing.Size(31, 15);
        this.labelPath.TabIndex = 0;
        this.labelPath.Text = "Path";

        // 
        // textBoxPath
        // 
        this.textBoxPath.Location = new System.Drawing.Point(60, 12);
        this.textBoxPath.Name = "textBoxPath";
        this.textBoxPath.Size = new System.Drawing.Size(600, 23);
        this.textBoxPath.TabIndex = 1;

        // 
        // labelCode
        // 
        this.labelCode.AutoSize = true;
        this.labelCode.Location = new System.Drawing.Point(12, 50);
        this.labelCode.Name = "labelCode";
        this.labelCode.Size = new System.Drawing.Size(35, 15);
        this.labelCode.TabIndex = 2;
        this.labelCode.Text = "Code";

        // 
        // textBoxCode
        // 
        this.textBoxCode.Location = new System.Drawing.Point(60, 47);
        this.textBoxCode.Multiline = true;
        this.textBoxCode.Name = "textBoxCode";
        this.textBoxCode.Size = new System.Drawing.Size(600, 200);
        this.textBoxCode.TabIndex = 3;

        // 
        // buttonGenerate
        // 
        this.buttonGenerate.Location = new System.Drawing.Point(680, 12);
        this.buttonGenerate.Name = "buttonGenerate";
        this.buttonGenerate.Size = new System.Drawing.Size(100, 30);
        this.buttonGenerate.TabIndex = 4;
        this.buttonGenerate.Text = "Generate";
        this.buttonGenerate.UseVisualStyleBackColor = true;

        // Add controls to the form
        this.Controls.Add(this.labelPath);
        this.Controls.Add(this.textBoxPath);
        this.Controls.Add(this.labelCode);
        this.Controls.Add(this.textBoxCode);
        this.Controls.Add(this.buttonGenerate);
    }

    #endregion
}