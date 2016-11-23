using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace filtersource
{
  public class aboutform : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;

    public aboutform()
    {
      this.InitializeComponent();
    }

    private void AboutformLoad(object sender, EventArgs e)
    {
      this.label1.Text = "Filtersource Ver1.2Beta POC" + Environment.NewLine + Environment.NewLine + "Written by Spoonie" + Environment.NewLine + "If you find any bugs or add/missing filter numbers" + Environment.NewLine + "Please email sexy_b14@hotmail.com" + Environment.NewLine + Environment.NewLine + "Written in C# against Mircosoft .NET 3.5" + Environment.NewLine + "IDE SharpDevelop http://www.icsharpcode.net" + Environment.NewLine + "Linux and MacOXS ports built against mono http://www.mono-project.com";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.SuspendLayout();
      this.label1.BackColor = SystemColors.Window;
      this.label1.BorderStyle = BorderStyle.FixedSingle;
      this.label1.FlatStyle = FlatStyle.Flat;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(553, 237);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(577, (int) byte.MaxValue);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "aboutform";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "About Filtersource";
      this.Load += new EventHandler(this.AboutformLoad);
      this.ResumeLayout(false);
    }
  }
}
