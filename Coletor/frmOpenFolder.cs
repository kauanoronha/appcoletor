using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Coletor.Class.Utils;

namespace Coletor;

public class frmOpenFolder : Form
{
	private IContainer components;

	private TextBox txtArquivo;

	private Label label1;

	private Button btnOpenFolder;

	private Button btnGravar;

	private SaveFileDialog saveFileDialog1;

	private CheckBox chkDescricao;

	private Button btnVoltar;

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
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		txtArquivo = new TextBox();
		label1 = new Label();
		btnOpenFolder = new Button();
		btnGravar = new Button();
		saveFileDialog1 = new SaveFileDialog();
		chkDescricao = new CheckBox();
		btnVoltar = new Button();
		((Control)this).SuspendLayout();
		((Control)txtArquivo).BackColor = Color.Gainsboro;
		((Control)txtArquivo).Location = new Point(3, 29);
		((Control)txtArquivo).Name = "txtArquivo";
		((TextBoxBase)txtArquivo).ReadOnly = true;
		((Control)txtArquivo).Size = new Size(205, 21);
		((Control)txtArquivo).TabIndex = 6;
		((Control)label1).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)label1).ForeColor = Color.White;
		((Control)label1).Location = new Point(3, 11);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(205, 15);
		((Control)label1).Text = "Selecione o local do arquivo";
		((Control)btnOpenFolder).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnOpenFolder).Location = new Point(214, 29);
		((Control)btnOpenFolder).Name = "btnOpenFolder";
		((Control)btnOpenFolder).Size = new Size(20, 21);
		((Control)btnOpenFolder).TabIndex = 8;
		((Control)btnOpenFolder).Text = "..";
		((Control)btnOpenFolder).Click += btnOpenFolder_Click;
		((Control)btnGravar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnGravar).Location = new Point(0, 82);
		((Control)btnGravar).Name = "btnGravar";
		((Control)btnGravar).Size = new Size(234, 27);
		((Control)btnGravar).TabIndex = 9;
		((Control)btnGravar).Text = "Exportar";
		((Control)btnGravar).Click += btnGravar_Click_1;
		((FileDialog)saveFileDialog1).FileName = "Coleta";
		((FileDialog)saveFileDialog1).Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\";";
		chkDescricao.Checked = true;
		chkDescricao.CheckState = (CheckState)1;
		((Control)chkDescricao).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)chkDescricao).ForeColor = Color.White;
		((Control)chkDescricao).Location = new Point(-1, 52);
		((Control)chkDescricao).Name = "chkDescricao";
		((Control)chkDescricao).Size = new Size(199, 21);
		((Control)chkDescricao).TabIndex = 11;
		((Control)chkDescricao).Text = "Exportar com descrição";
		((Control)btnVoltar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnVoltar).Location = new Point(0, 112);
		((Control)btnVoltar).Name = "btnVoltar";
		((Control)btnVoltar).Size = new Size(234, 27);
		((Control)btnVoltar).TabIndex = 13;
		((Control)btnVoltar).Text = "Voltar";
		((Control)btnVoltar).Click += btnVoltar_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).BackColor = Color.DimGray;
		((Control)this).ClientSize = new Size(240, 294);
		((Control)this).Controls.Add((Control)(object)btnVoltar);
		((Control)this).Controls.Add((Control)(object)chkDescricao);
		((Control)this).Controls.Add((Control)(object)btnGravar);
		((Control)this).Controls.Add((Control)(object)btnOpenFolder);
		((Control)this).Controls.Add((Control)(object)txtArquivo);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Name = "frmOpenFolder";
		((Control)this).Text = "Exportar Coleta";
		((Control)this).ResumeLayout(false);
	}

	public frmOpenFolder()
	{
		InitializeComponent();
		((Control)txtArquivo).Text = Program.ConfiguracaoSistema.PathArquivoExportaColeta;
	}

	private void btnGravar_Click_1(object sender, EventArgs e)
	{
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)txtArquivo).Text;
		DataTable dataTable = ConferenciaBd.ObterConferencia();
		if (dataTable.Rows.Count > 0)
		{
			TextWriter textWriter = new StreamWriter(text);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				string value = ((!chkDescricao.Checked) ? string.Format("{0},{1}", dataTable.Rows[i]["ProBarras"].ToString(), dataTable.Rows[i]["ProQuantidade"].ToString()) : string.Format("{0},{1},{2}", dataTable.Rows[i]["ProBarras"].ToString(), dataTable.Rows[i]["ProNome"].ToString(), dataTable.Rows[i]["ProQuantidade"].ToString()));
				textWriter.WriteLine(value);
			}
			textWriter.Close();
			Program.ConfiguracaoSistema.PathArquivoExportaColeta = ((Control)txtArquivo).Text;
			Utilis.SerializarConfiguracaoSistema();
			ConferenciaBd.ExcluirConferencia();
			MessageBox.Show("Coleta exportada com sucesso!", "Atenção!", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
		else
		{
			MessageBox.Show("Nenhum produto coletado!", "Atenção!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
		}
	}

	private void btnOpenFolder_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)saveFileDialog1).ShowDialog();
		((Control)txtArquivo).Text = ((FileDialog)saveFileDialog1).FileName;
	}

	private void btnVoltar_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
