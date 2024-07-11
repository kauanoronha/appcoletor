using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Coletor;

public class frmMenuColetar : Form
{
	private IContainer components;

	private Button btnCarregar;

	private Button btnColetar;

	private Button btnConsultaColeta;

	private Button btnExportar;

	private Label lblTotalProdutos;

	private Button btnSair;

	private MainMenu mainMenu1;

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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		btnCarregar = new Button();
		btnColetar = new Button();
		btnConsultaColeta = new Button();
		btnExportar = new Button();
		lblTotalProdutos = new Label();
		btnSair = new Button();
		mainMenu1 = new MainMenu();
		((Control)this).SuspendLayout();
		((Control)btnCarregar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnCarregar).Dock = (DockStyle)1;
		((Control)btnCarregar).ForeColor = Color.Black;
		((Control)btnCarregar).Location = new Point(0, 0);
		((Control)btnCarregar).Name = "btnCarregar";
		((Control)btnCarregar).Size = new Size(240, 29);
		((Control)btnCarregar).TabIndex = 6;
		((Control)btnCarregar).Text = "Importar Cadastros";
		((Control)btnCarregar).Click += btnCarregar_Click;
		((Control)btnColetar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnColetar).Dock = (DockStyle)1;
		((Control)btnColetar).ForeColor = Color.Black;
		((Control)btnColetar).Location = new Point(0, 29);
		((Control)btnColetar).Name = "btnColetar";
		((Control)btnColetar).Size = new Size(240, 29);
		((Control)btnColetar).TabIndex = 7;
		((Control)btnColetar).Text = "Coletar Produtos";
		((Control)btnColetar).Click += btnColetar_Click;
		((Control)btnConsultaColeta).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnConsultaColeta).Dock = (DockStyle)1;
		((Control)btnConsultaColeta).ForeColor = Color.Black;
		((Control)btnConsultaColeta).Location = new Point(0, 58);
		((Control)btnConsultaColeta).Name = "btnConsultaColeta";
		((Control)btnConsultaColeta).Size = new Size(240, 29);
		((Control)btnConsultaColeta).TabIndex = 10;
		((Control)btnConsultaColeta).Text = "Consultar Coleta";
		((Control)btnConsultaColeta).Click += btnConsultaColeta_Click;
		((Control)btnExportar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnExportar).Dock = (DockStyle)1;
		((Control)btnExportar).ForeColor = Color.Black;
		((Control)btnExportar).Location = new Point(0, 87);
		((Control)btnExportar).Name = "btnExportar";
		((Control)btnExportar).Size = new Size(240, 29);
		((Control)btnExportar).TabIndex = 11;
		((Control)btnExportar).Text = "Exportar Coleta";
		((Control)btnExportar).Click += btnExportar_Click;
		((Control)lblTotalProdutos).BackColor = Color.DimGray;
		((Control)lblTotalProdutos).Dock = (DockStyle)2;
		((Control)lblTotalProdutos).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)lblTotalProdutos).ForeColor = Color.White;
		((Control)lblTotalProdutos).Location = new Point(0, 247);
		((Control)lblTotalProdutos).Name = "lblTotalProdutos";
		((Control)lblTotalProdutos).Size = new Size(240, 21);
		((Control)lblTotalProdutos).Text = "Produtos Importados: 0";
		((Control)btnSair).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnSair).Dock = (DockStyle)1;
		((Control)btnSair).ForeColor = Color.Black;
		((Control)btnSair).Location = new Point(0, 116);
		((Control)btnSair).Name = "btnSair";
		((Control)btnSair).Size = new Size(240, 29);
		((Control)btnSair).TabIndex = 12;
		((Control)btnSair).Text = "Voltar";
		((Control)btnSair).Click += btnSair_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).BackColor = Color.DimGray;
		((Control)this).ClientSize = new Size(240, 268);
		((Control)this).Controls.Add((Control)(object)lblTotalProdutos);
		((Control)this).Controls.Add((Control)(object)btnSair);
		((Control)this).Controls.Add((Control)(object)btnExportar);
		((Control)this).Controls.Add((Control)(object)btnConsultaColeta);
		((Control)this).Controls.Add((Control)(object)btnColetar);
		((Control)this).Controls.Add((Control)(object)btnCarregar);
		((Form)this).Menu = mainMenu1;
		((Control)this).Name = "frmMenuColetar";
		((Control)this).Text = "Coletar";
		((Control)this).ResumeLayout(false);
	}

	public frmMenuColetar()
	{
		InitializeComponent();
		((Control)lblTotalProdutos).Text = "Produtos Importados: " + ProdutoBd.ObterTotalDeProdutos();
	}

	private void btnCarregar_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmOpenFile frmOpenFile2 = new frmOpenFile();
		((Form)frmOpenFile2).ShowDialog();
		((Control)lblTotalProdutos).Text = "Produtos Importados: " + ProdutoBd.ObterTotalDeProdutos();
	}

	private void btnColetar_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmColetarProduto frmColetarProduto2 = new frmColetarProduto();
		((Form)frmColetarProduto2).ShowDialog();
	}

	private void btnSair_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void btnExportar_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmOpenFolder frmOpenFolder2 = new frmOpenFolder();
		try
		{
			((Form)frmOpenFolder2).ShowDialog();
		}
		finally
		{
			((IDisposable)frmOpenFolder2)?.Dispose();
		}
	}

	private void btnConsultaColeta_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		frmConsultarProdutoColetado frmConsultarProdutoColetado2 = new frmConsultarProdutoColetado();
		try
		{
			((Form)frmConsultarProdutoColetado2).ShowDialog();
		}
		finally
		{
			((IDisposable)frmConsultarProdutoColetado2)?.Dispose();
		}
	}
}
