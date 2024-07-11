using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Coletor;

public class frmColetarProduto : Form
{
	private IContainer components;

	private Label label1;

	private TextBox txtCodigoBarra;

	private Label label2;

	private Panel panel1;

	private Button btnAdd;

	private Button btnSair;

	private Button btnQtde;

	private TextBox txtProduto;

	private Label label4;

	private Label lblQtde;

	private Label label3;

	private Label label5;

	private Label lblBarras;

	private Label lblQtdeTotal;

	private Label label7;

	public frmColetarProduto()
	{
		InitializeComponent();
	}

	private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (e.KeyChar == '\r')
			{
				ValidarBarras();
				((Control)txtProduto).Text = string.Empty;
				((Control)txtProduto).Text = ProdutoBd.ObterNomeProduto(((Control)txtCodigoBarra).Text);
				if (string.IsNullOrEmpty(((Control)txtProduto).Text.Trim()) && Program.ConfiguracaoSistema.PermiteIncluirDescricaoColeta)
				{
					Mensagem.MensagemExclamacao();
					((Control)txtProduto).Focus();
				}
				else
				{
					Gravar();
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Atenção!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
		}
	}

	private void Gravar()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (string.IsNullOrEmpty(((Control)lblQtde).Text))
			{
				throw new Exception("Quantidade informada é inválida!");
			}
			if (string.IsNullOrEmpty(((Control)txtCodigoBarra).Text))
			{
				throw new Exception("Produto não informado!");
			}
			ConferenciaBd.GravarConferencia(((Control)txtCodigoBarra).Text, ((Control)txtProduto).Text, Convert.ToDecimal(0 + ((Control)lblQtde).Text.Trim()));
			((Control)lblQtdeTotal).Text = ((Control)lblQtde).Text;
			((Control)lblBarras).Text = ((Control)txtCodigoBarra).Text;
			((Control)txtProduto).Text = string.Empty;
			((Control)txtCodigoBarra).Text = string.Empty;
			((Control)lblQtde).Text = "1";
			((Control)txtCodigoBarra).Focus();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Atenção!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
		}
	}

	private void frmColetarConferencia_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 113)
		{
			AdicionarQuantidade();
			((Control)txtCodigoBarra).Focus();
		}
		if ((int)e.KeyCode == 27)
		{
			((Form)this).Close();
		}
		if ((int)e.KeyCode == 114)
		{
			try
			{
				ValidarBarras();
				Gravar();
				((Control)txtCodigoBarra).Focus();
			}
			catch (Exception ex)
			{
				((Control)txtProduto).Text = ex.Message;
			}
		}
		_ = e.KeyCode;
		_ = 39;
		_ = e.KeyCode;
		_ = 13;
	}

	private void btnQtde_Click(object sender, EventArgs e)
	{
		AdicionarQuantidade();
		((Control)txtCodigoBarra).Focus();
	}

	private void AdicionarQuantidade()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ValidarQuantidade();
			((Control)lblQtde).Text = ((Control)txtCodigoBarra).Text;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Atenção!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
		}
		finally
		{
			((Control)txtCodigoBarra).Text = string.Empty;
		}
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		Gravar();
		Mensagem.MensagemHand();
	}

	private void btnSair_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ValidarQuantidade()
	{
		try
		{
			Convert.ToDecimal(((Control)txtCodigoBarra).Text);
		}
		catch (Exception)
		{
			throw new Exception("Quantidade informada é inválida!");
		}
	}

	private void ValidarBarras()
	{
		try
		{
			Convert.ToDecimal(((Control)txtCodigoBarra).Text);
		}
		catch (Exception)
		{
			throw new Exception("Código de barras informado é inválido!");
		}
	}

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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected O, but got Unknown
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected O, but got Unknown
		label1 = new Label();
		txtCodigoBarra = new TextBox();
		label2 = new Label();
		panel1 = new Panel();
		btnAdd = new Button();
		btnSair = new Button();
		btnQtde = new Button();
		txtProduto = new TextBox();
		label4 = new Label();
		lblQtde = new Label();
		label3 = new Label();
		label5 = new Label();
		lblBarras = new Label();
		lblQtdeTotal = new Label();
		label7 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).ForeColor = Color.White;
		((Control)label1).Location = new Point(0, 2);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(100, 14);
		((Control)label1).Text = "Código de Barras";
		((Control)txtCodigoBarra).BackColor = Color.White;
		((Control)txtCodigoBarra).Location = new Point(0, 19);
		((Control)txtCodigoBarra).Name = "txtCodigoBarra";
		((Control)txtCodigoBarra).Size = new Size(234, 21);
		((Control)txtCodigoBarra).TabIndex = 0;
		((Control)txtCodigoBarra).KeyDown += new KeyEventHandler(frmColetarConferencia_KeyDown);
		((Control)txtCodigoBarra).KeyPress += new KeyPressEventHandler(txtCodigoBarra_KeyPress);
		((Control)label2).ForeColor = Color.White;
		((Control)label2).Location = new Point(0, 40);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(100, 16);
		((Control)label2).Text = "Descrição";
		((Control)panel1).BackColor = Color.Transparent;
		((Control)panel1).Controls.Add((Control)(object)btnAdd);
		((Control)panel1).Controls.Add((Control)(object)btnSair);
		((Control)panel1).Controls.Add((Control)(object)btnQtde);
		((Control)panel1).Dock = (DockStyle)2;
		((Control)panel1).Location = new Point(0, 256);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(240, 38);
		((Control)btnAdd).Anchor = (AnchorStyles)9;
		((Control)btnAdd).Location = new Point(84, 3);
		((Control)btnAdd).Name = "btnAdd";
		((Control)btnAdd).Size = new Size(72, 32);
		((Control)btnAdd).TabIndex = 3;
		((Control)btnAdd).TabStop = false;
		((Control)btnAdd).Text = "F3-Adic.";
		((Control)btnAdd).Click += btnAdd_Click;
		((Control)btnAdd).KeyDown += new KeyEventHandler(frmColetarConferencia_KeyDown);
		((Control)btnSair).Anchor = (AnchorStyles)9;
		((Control)btnSair).Location = new Point(162, 3);
		((Control)btnSair).Name = "btnSair";
		((Control)btnSair).Size = new Size(72, 32);
		((Control)btnSair).TabIndex = 2;
		((Control)btnSair).TabStop = false;
		((Control)btnSair).Text = "ESC-Sair";
		((Control)btnSair).Click += btnSair_Click;
		((Control)btnSair).KeyDown += new KeyEventHandler(frmColetarConferencia_KeyDown);
		((Control)btnQtde).Location = new Point(3, 3);
		((Control)btnQtde).Name = "btnQtde";
		((Control)btnQtde).Size = new Size(72, 32);
		((Control)btnQtde).TabIndex = 0;
		((Control)btnQtde).TabStop = false;
		((Control)btnQtde).Text = "F2-Quant";
		((Control)btnQtde).Click += btnQtde_Click;
		((Control)btnQtde).KeyDown += new KeyEventHandler(frmColetarConferencia_KeyDown);
		((Control)txtProduto).BackColor = Color.FromArgb(255, 255, 192);
		((Control)txtProduto).Location = new Point(0, 54);
		((TextBoxBase)txtProduto).Multiline = true;
		((Control)txtProduto).Name = "txtProduto";
		((Control)txtProduto).Size = new Size(234, 34);
		((Control)txtProduto).TabIndex = 6;
		((Control)txtProduto).KeyDown += new KeyEventHandler(frmColetarConferencia_KeyDown);
		((Control)label4).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)label4).ForeColor = Color.White;
		((Control)label4).Location = new Point(0, 91);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(75, 18);
		((Control)label4).Text = "Quant.: +";
		((Control)lblQtde).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)lblQtde).ForeColor = Color.White;
		((Control)lblQtde).Location = new Point(65, 91);
		((Control)lblQtde).Name = "lblQtde";
		((Control)lblQtde).Size = new Size(59, 18);
		((Control)lblQtde).Text = "1";
		((Control)label3).ForeColor = Color.White;
		((Control)label3).Location = new Point(2, 122);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(47, 18);
		((Control)label3).Text = "Código:";
		((Control)label5).ForeColor = Color.White;
		((Control)label5).Location = new Point(3, 152);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(47, 18);
		((Control)label5).Text = "Quant.:";
		((Control)lblBarras).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)lblBarras).ForeColor = Color.White;
		((Control)lblBarras).Location = new Point(55, 122);
		((Control)lblBarras).Name = "lblBarras";
		((Control)lblBarras).Size = new Size(154, 18);
		((Control)lblQtdeTotal).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)lblQtdeTotal).ForeColor = Color.White;
		((Control)lblQtdeTotal).Location = new Point(65, 152);
		((Control)lblQtdeTotal).Name = "lblQtdeTotal";
		((Control)lblQtdeTotal).Size = new Size(154, 18);
		((Control)label7).ForeColor = Color.White;
		((Control)label7).Location = new Point(3, 106);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(231, 16);
		((Control)label7).Text = "____________________________________";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).BackColor = Color.Gray;
		((Control)this).ClientSize = new Size(240, 294);
		((Control)this).Controls.Add((Control)(object)lblQtde);
		((Control)this).Controls.Add((Control)(object)label4);
		((Control)this).Controls.Add((Control)(object)lblQtdeTotal);
		((Control)this).Controls.Add((Control)(object)lblBarras);
		((Control)this).Controls.Add((Control)(object)label5);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)txtProduto);
		((Control)this).Controls.Add((Control)(object)panel1);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)txtCodigoBarra);
		((Control)this).Controls.Add((Control)(object)label7);
		((Control)this).Name = "frmColetarConferencia";
		((Control)this).Text = "Coletar Conferência";
		((Control)this).KeyDown += new KeyEventHandler(frmColetarConferencia_KeyDown);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
