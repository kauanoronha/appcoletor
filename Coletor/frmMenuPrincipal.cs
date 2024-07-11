using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Coletor;

public class frmMenuPrincipal : Form
{
	private IContainer components;

	private PictureBox pictureBox1;

	private Button cmdConfigurar;

	private Button cmdColetar;

	private MainMenu mainMenu1;

	private Button btnConferencia;

	private Button cmdSair;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMenuPrincipal));
		pictureBox1 = new PictureBox();
		cmdConfigurar = new Button();
		cmdColetar = new Button();
		mainMenu1 = new MainMenu();
		btnConferencia = new Button();
		cmdSair = new Button();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).Dock = (DockStyle)1;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		((Control)pictureBox1).Location = new Point(0, 0);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(240, 47);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		((Control)cmdConfigurar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)cmdConfigurar).Dock = (DockStyle)1;
		((Control)cmdConfigurar).Location = new Point(0, 76);
		((Control)cmdConfigurar).Name = "cmdConfigurar";
		((Control)cmdConfigurar).Size = new Size(240, 29);
		((Control)cmdConfigurar).TabIndex = 6;
		((Control)cmdConfigurar).Text = "Configurar";
		((Control)cmdConfigurar).Click += cmdConfigurar_Click;
		((Control)cmdColetar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)cmdColetar).Dock = (DockStyle)1;
		((Control)cmdColetar).ForeColor = Color.Black;
		((Control)cmdColetar).Location = new Point(0, 47);
		((Control)cmdColetar).Name = "cmdColetar";
		((Control)cmdColetar).Size = new Size(240, 29);
		((Control)cmdColetar).TabIndex = 5;
		((Control)cmdColetar).Text = "Consultar";
		((Control)cmdColetar).Click += cmdColetar_Click;
		((Control)btnConferencia).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnConferencia).Dock = (DockStyle)1;
		((Control)btnConferencia).Location = new Point(0, 105);
		((Control)btnConferencia).Name = "btnConferencia";
		((Control)btnConferencia).Size = new Size(240, 29);
		((Control)btnConferencia).TabIndex = 7;
		((Control)btnConferencia).Text = "Coletar";
		((Control)btnConferencia).Click += btnConferencia_Click;
		((Control)cmdSair).BackColor = Color.FromArgb(240, 181, 34);
		((Control)cmdSair).Dock = (DockStyle)1;
		((Control)cmdSair).Location = new Point(0, 134);
		((Control)cmdSair).Name = "cmdSair";
		((Control)cmdSair).Size = new Size(240, 29);
		((Control)cmdSair).TabIndex = 13;
		((Control)cmdSair).Text = "Sair";
		((Control)cmdSair).Click += cmdSair_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).BackColor = Color.DimGray;
		((Control)this).ClientSize = new Size(240, 268);
		((Control)this).Controls.Add((Control)(object)cmdSair);
		((Control)this).Controls.Add((Control)(object)btnConferencia);
		((Control)this).Controls.Add((Control)(object)cmdConfigurar);
		((Control)this).Controls.Add((Control)(object)cmdColetar);
		((Control)this).Controls.Add((Control)(object)pictureBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).KeyPreview = true;
		((Form)this).Menu = mainMenu1;
		((Control)this).Name = "frmMenuPrincipal";
		((Control)this).Text = "Suporte";
		((Control)this).ResumeLayout(false);
	}

	public frmMenuPrincipal()
	{
		InitializeComponent();
	}

	private void cmdColetar_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmColetar frmColetar2 = new frmColetar();
		try
		{
			((Form)frmColetar2).ShowDialog();
		}
		finally
		{
			((IDisposable)frmColetar2)?.Dispose();
		}
	}

	private void cmdConfigurar_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmConfigurar frmConfigurar2 = new frmConfigurar();
		try
		{
			((Form)frmConfigurar2).ShowDialog();
		}
		finally
		{
			((IDisposable)frmConfigurar2)?.Dispose();
		}
	}

	private void cmdSair_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void btnConferencia_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmMenuColetar frmMenuColetar2 = new frmMenuColetar();
		try
		{
			((Form)frmMenuColetar2).ShowDialog();
		}
		finally
		{
			((IDisposable)frmMenuColetar2)?.Dispose();
		}
	}
}
