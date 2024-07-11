using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Coletor;

public class frmConsultarProdutoColetado : Form
{
	private IContainer components;

	private Label label1;

	private TextBox txtCodigoBarra;

	private Label label2;

	private Label label3;

	private Label lblDescricao;

	private Label lblQuantidade;

	private Panel panel1;

	private Button btnSair;

	private Button btnExcluir;

	private Label lblBarras;

	private Label label4;

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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		label1 = new Label();
		txtCodigoBarra = new TextBox();
		label2 = new Label();
		label3 = new Label();
		lblDescricao = new Label();
		lblQuantidade = new Label();
		panel1 = new Panel();
		btnSair = new Button();
		btnExcluir = new Button();
		lblBarras = new Label();
		label4 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).ForeColor = Color.White;
		((Control)label1).Location = new Point(6, 11);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(100, 14);
		((Control)label1).Text = "Código de Barras";
		((Control)txtCodigoBarra).BackColor = Color.White;
		((Control)txtCodigoBarra).Location = new Point(6, 28);
		((Control)txtCodigoBarra).Name = "txtCodigoBarra";
		((Control)txtCodigoBarra).Size = new Size(234, 21);
		((Control)txtCodigoBarra).TabIndex = 0;
		((Control)txtCodigoBarra).KeyDown += new KeyEventHandler(frmConsultarProdutoColetado_KeyDown);
		((Control)txtCodigoBarra).KeyPress += new KeyPressEventHandler(txtCodigoBarra_KeyPress);
		((Control)label2).ForeColor = Color.White;
		((Control)label2).Location = new Point(6, 88);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(70, 18);
		((Control)label2).Text = "Descrição:";
		((Control)label3).ForeColor = Color.White;
		((Control)label3).Location = new Point(6, 70);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(54, 18);
		((Control)label3).Text = "Quant.:";
		((Control)lblDescricao).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)lblDescricao).ForeColor = Color.White;
		((Control)lblDescricao).Location = new Point(6, 106);
		((Control)lblDescricao).Name = "lblDescricao";
		((Control)lblDescricao).Size = new Size(227, 33);
		((Control)lblQuantidade).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)lblQuantidade).ForeColor = Color.White;
		((Control)lblQuantidade).Location = new Point(66, 71);
		((Control)lblQuantidade).Name = "lblQuantidade";
		((Control)lblQuantidade).Size = new Size(147, 17);
		((Control)panel1).BackColor = Color.Transparent;
		((Control)panel1).Controls.Add((Control)(object)btnSair);
		((Control)panel1).Controls.Add((Control)(object)btnExcluir);
		((Control)panel1).Dock = (DockStyle)2;
		((Control)panel1).Location = new Point(0, 253);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(240, 41);
		((Control)btnSair).Location = new Point(127, 3);
		((Control)btnSair).Name = "btnSair";
		((Control)btnSair).Size = new Size(106, 32);
		((Control)btnSair).TabIndex = 7;
		((Control)btnSair).Text = "ESC-Sair";
		((Control)btnSair).Click += btnSair_Click;
		((Control)btnSair).KeyDown += new KeyEventHandler(frmConsultarProdutoColetado_KeyDown);
		((Control)btnExcluir).Location = new Point(4, 3);
		((Control)btnExcluir).Name = "btnExcluir";
		((Control)btnExcluir).Size = new Size(117, 32);
		((Control)btnExcluir).TabIndex = 6;
		((Control)btnExcluir).Text = "Excluir";
		((Control)btnExcluir).Click += btnExcluir_Click;
		((Control)btnExcluir).KeyDown += new KeyEventHandler(frmConsultarProdutoColetado_KeyDown);
		((Control)lblBarras).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)lblBarras).ForeColor = Color.White;
		((Control)lblBarras).Location = new Point(59, 53);
		((Control)lblBarras).Name = "lblBarras";
		((Control)lblBarras).Size = new Size(154, 18);
		((Control)label4).ForeColor = Color.White;
		((Control)label4).Location = new Point(6, 52);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(47, 18);
		((Control)label4).Text = "Código:";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).BackColor = Color.DimGray;
		((Control)this).ClientSize = new Size(240, 294);
		((Control)this).Controls.Add((Control)(object)lblBarras);
		((Control)this).Controls.Add((Control)(object)label4);
		((Control)this).Controls.Add((Control)(object)panel1);
		((Control)this).Controls.Add((Control)(object)lblQuantidade);
		((Control)this).Controls.Add((Control)(object)lblDescricao);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)txtCodigoBarra);
		((Control)this).Name = "frmConsultarProdutoColetado";
		((Control)this).Text = "Consultar Produto Coletado";
		((Control)this).KeyDown += new KeyEventHandler(frmConsultarProdutoColetado_KeyDown);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public frmConsultarProdutoColetado()
	{
		InitializeComponent();
		((Control)txtCodigoBarra).Focus();
	}

	private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
	{
		try
		{
			if (e.KeyChar == '\r')
			{
				((Control)lblDescricao).Text = string.Empty;
				((Control)lblQuantidade).Text = string.Empty;
				((Control)lblBarras).Text = string.Empty;
				DataTable dataTable = ConferenciaBd.ObterProdutoConferencia(((Control)txtCodigoBarra).Text.Trim());
				if (dataTable.Rows.Count > 0)
				{
					((Control)lblDescricao).Text = dataTable.Rows[0]["ProNome"].ToString();
					((Control)lblQuantidade).Text = dataTable.Rows[0]["ProQuantidade"].ToString();
					((Control)lblBarras).Text = dataTable.Rows[0]["Probarras"].ToString();
				}
				((Control)txtCodigoBarra).Text = string.Empty;
			}
		}
		catch (Exception ex)
		{
			Mensagem.MensagemExclamacao();
			((Control)lblDescricao).Text = ex.Message;
		}
	}

	private void frmConsultarProdutoColetado_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
		_ = e.KeyCode;
		_ = 40;
		_ = e.KeyCode;
		_ = 37;
		_ = e.KeyCode;
		_ = 39;
		_ = e.KeyCode;
		_ = 13;
	}

	private void btnExcluir_Click(object sender, EventArgs e)
	{
		try
		{
			if (string.IsNullOrEmpty(((Control)lblBarras).Text.Trim()))
			{
				Mensagem.MensagemExclamacao();
				return;
			}
			ConferenciaBd.ExluirProdutoConferencia(((Control)lblBarras).Text);
			((Control)txtCodigoBarra).Text = string.Empty;
			((Control)lblDescricao).Text = "Produto excluído";
			((Control)lblQuantidade).Text = string.Empty;
			((Control)lblBarras).Text = string.Empty;
			Mensagem.MensagemAsterisk();
		}
		catch (Exception ex)
		{
			Mensagem.MensagemExclamacao();
			((Control)txtCodigoBarra).Text = string.Empty;
			((Control)lblDescricao).Text = ex.Message;
			((Control)lblQuantidade).Text = string.Empty;
		}
	}

	private void btnSair_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
