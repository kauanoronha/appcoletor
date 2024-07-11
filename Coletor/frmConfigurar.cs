using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coletor.Class.Utils;

namespace Coletor;

public class frmConfigurar : Form
{
	private IContainer components;

	private MainMenu mainMenu1;

	private TextBox txtRede;

	private Button button1;

	private Label lblRede;

	private NumericUpDown txtEmpresa;

	private Label label1;

	private Label label4;

	private Label label5;

	private Label label7;

	private Label label6;

	private CheckBox chkDescricao;

	private Label label2;

	private Label label3;

	public frmConfigurar()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Program.ConfiguracaoSistema.LinkWebservice = ((Control)txtRede).Text;
		Program.ConfiguracaoSistema.Empresa = txtEmpresa.Value;
		Program.ConfiguracaoSistema.PermiteIncluirDescricaoColeta = chkDescricao.Checked;
		Utilis.SerializarConfiguracaoSistema();
		((Form)this).Close();
	}

	private void frmConfigurar_Load(object sender, EventArgs e)
	{
		((Control)this).Text = "Configuração";
		((Control)txtRede).Text = Program.ConfiguracaoSistema.LinkWebservice;
		txtEmpresa.Value = Program.ConfiguracaoSistema.Empresa;
		chkDescricao.Checked = Program.ConfiguracaoSistema.PermiteIncluirDescricaoColeta;
	}

	private void frmConfigurar_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			Program.ConfiguracaoSistema.LinkWebservice = ((Control)txtRede).Text;
			Program.ConfiguracaoSistema.Empresa = txtEmpresa.Value;
			Utilis.SerializarConfiguracaoSistema();
			((Form)this).Close();
		}
	}

	private void txtRede_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			((Control)txtEmpresa).Focus();
		}
	}

	private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			((Control)button1).Focus();
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
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		mainMenu1 = new MainMenu();
		txtRede = new TextBox();
		button1 = new Button();
		lblRede = new Label();
		txtEmpresa = new NumericUpDown();
		label1 = new Label();
		label4 = new Label();
		label5 = new Label();
		label7 = new Label();
		label6 = new Label();
		chkDescricao = new CheckBox();
		label2 = new Label();
		label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)txtRede).Location = new Point(61, 22);
		((Control)txtRede).Name = "txtRede";
		((Control)txtRede).Size = new Size(166, 21);
		((Control)txtRede).TabIndex = 1;
		((Control)txtRede).KeyPress += new KeyPressEventHandler(txtRede_KeyPress);
		((Control)button1).BackColor = Color.FromArgb(240, 181, 34);
		((Control)button1).Location = new Point(0, 139);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(227, 24);
		((Control)button1).TabIndex = 2;
		((Control)button1).Text = "Salvar";
		((Control)button1).Click += button1_Click;
		((Control)lblRede).ForeColor = Color.White;
		((Control)lblRede).Location = new Point(3, 23);
		((Control)lblRede).Name = "lblRede";
		((Control)lblRede).Size = new Size(55, 15);
		((Control)lblRede).Text = "Caminho";
		((Control)txtEmpresa).Location = new Point(62, 46);
		((Control)txtEmpresa).Name = "txtEmpresa";
		((Control)txtEmpresa).Size = new Size(61, 22);
		((Control)txtEmpresa).TabIndex = 4;
		((Control)txtEmpresa).KeyPress += new KeyPressEventHandler(txtEmpresa_KeyPress);
		((Control)label1).ForeColor = Color.White;
		((Control)label1).Location = new Point(6, 49);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(52, 15);
		((Control)label1).Text = "Empresa";
		((Control)label4).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)label4).ForeColor = Color.White;
		((Control)label4).Location = new Point(1, 80);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(115, 15);
		((Control)label4).Text = "Coletor";
		((Control)label5).ForeColor = Color.White;
		((Control)label5).Location = new Point(1, 85);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(226, 19);
		((Control)label5).Text = "__________________________________";
		((Control)label7).ForeColor = Color.White;
		((Control)label7).Location = new Point(22, 121);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(203, 18);
		((Control)label7).Text = "quando não estiver na base local.";
		((Control)label6).ForeColor = Color.White;
		((Control)label6).Location = new Point(21, 106);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(203, 18);
		((Control)label6).Text = "Permitir incluir descrição do produto";
		chkDescricao.Checked = true;
		chkDescricao.CheckState = (CheckState)1;
		((Control)chkDescricao).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)chkDescricao).ForeColor = Color.White;
		((Control)chkDescricao).Location = new Point(1, 100);
		((Control)chkDescricao).Name = "chkDescricao";
		((Control)chkDescricao).Size = new Size(24, 27);
		((Control)chkDescricao).TabIndex = 19;
		((Control)label2).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)label2).ForeColor = Color.White;
		((Control)label2).Location = new Point(3, 0);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(115, 15);
		((Control)label2).Text = "Consultar";
		((Control)label3).ForeColor = Color.White;
		((Control)label3).Location = new Point(3, 5);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(225, 23);
		((Control)label3).Text = "__________________________________";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).BackColor = Color.Gray;
		((Control)this).ClientSize = new Size(240, 269);
		((Control)this).Controls.Add((Control)(object)txtRede);
		((Control)this).Controls.Add((Control)(object)lblRede);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)label4);
		((Control)this).Controls.Add((Control)(object)label5);
		((Control)this).Controls.Add((Control)(object)label7);
		((Control)this).Controls.Add((Control)(object)label6);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)txtEmpresa);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)chkDescricao);
		((Form)this).Menu = mainMenu1;
		((Control)this).Name = "frmConfigurar";
		((Control)this).Text = "Configurar";
		((Form)this).Load += frmConfigurar_Load;
		((Control)this).KeyPress += new KeyPressEventHandler(frmConfigurar_KeyPress);
		((Control)this).ResumeLayout(false);
	}
}
