namespace lookaway
{
  partial class CountDown
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
      this.components = new System.ComponentModel.Container();
      this.label = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // label
      // 
      this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label.ForeColor = System.Drawing.Color.Red;
      this.label.Location = new System.Drawing.Point(2, 9);
      this.label.Name = "label";
      this.label.Size = new System.Drawing.Size(759, 533);
      this.label.TabIndex = 0;
      this.label.Text = "20";
      this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timer
      // 
      this.timer.Tick += new System.EventHandler(this.Tick);
      // 
      // CountDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(773, 551);
      this.Controls.Add(this.label);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "CountDown";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "CountDown";
      this.Load += new System.EventHandler(this.CountDown_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label;
    private System.Windows.Forms.Timer timer;
  }
}