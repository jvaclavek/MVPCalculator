namespace MVPCalculator
{
  partial class CalcView
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
      this.txtNumber1 = new System.Windows.Forms.TextBox();
      this.txtNumber2 = new System.Windows.Forms.TextBox();
      this.txtNumber3 = new System.Windows.Forms.TextBox();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.txtRunningTotal = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtNumber1
      // 
      this.txtNumber1.Location = new System.Drawing.Point(101, 55);
      this.txtNumber1.Name = "txtNumber1";
      this.txtNumber1.Size = new System.Drawing.Size(203, 23);
      this.txtNumber1.TabIndex = 0;
      // 
      // txtNumber2
      // 
      this.txtNumber2.Location = new System.Drawing.Point(101, 84);
      this.txtNumber2.Name = "txtNumber2";
      this.txtNumber2.Size = new System.Drawing.Size(203, 23);
      this.txtNumber2.TabIndex = 1;
      // 
      // txtNumber3
      // 
      this.txtNumber3.Location = new System.Drawing.Point(101, 113);
      this.txtNumber3.Name = "txtNumber3";
      this.txtNumber3.Size = new System.Drawing.Size(203, 23);
      this.txtNumber3.TabIndex = 2;
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(101, 142);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(203, 23);
      this.txtTotal.TabIndex = 3;
      // 
      // txtRunningTotal
      // 
      this.txtRunningTotal.Location = new System.Drawing.Point(376, 113);
      this.txtRunningTotal.Name = "txtRunningTotal";
      this.txtRunningTotal.ReadOnly = true;
      this.txtRunningTotal.Size = new System.Drawing.Size(203, 23);
      this.txtRunningTotal.TabIndex = 4;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(101, 232);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(229, 232);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 23);
      this.btnReset.TabIndex = 6;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      // 
      // CalcView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtRunningTotal);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.txtNumber3);
      this.Controls.Add(this.txtNumber2);
      this.Controls.Add(this.txtNumber1);
      this.Name = "CalcView";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNumber1;
    private System.Windows.Forms.TextBox txtNumber2;
    private System.Windows.Forms.TextBox txtNumber3;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.TextBox txtRunningTotal;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnReset;
  }
}