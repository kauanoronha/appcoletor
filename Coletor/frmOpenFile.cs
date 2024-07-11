using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Coletor.Class.Utils;

namespace Coletor;

public class frmOpenFile : Form
{
	private IContainer components;

	private Label label1;

	private Button btnOpenFile;

	private Button btnGravar;

	private TextBox txtArquivo;

	private OpenFileDialog openFileDialog1;

	private Button btnVoltar;

	private ProgressBar progressBar1;

	private string fileName;

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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		label1 = new Label();
		btnOpenFile = new Button();
		btnGravar = new Button();
		txtArquivo = new TextBox();
		openFileDialog1 = new OpenFileDialog();
		btnVoltar = new Button();
		progressBar1 = new ProgressBar();
		((Control)this).SuspendLayout();
		((Control)label1).Font = new Font("Tahoma", 9f, (FontStyle)1);
		((Control)label1).ForeColor = Color.White;
		((Control)label1).Location = new Point(6, 8);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(205, 15);
		((Control)label1).Text = "Selecione um arquivo";
		((Control)btnOpenFile).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnOpenFile).Location = new Point(217, 26);
		((Control)btnOpenFile).Name = "btnOpenFile";
		((Control)btnOpenFile).Size = new Size(20, 21);
		((Control)btnOpenFile).TabIndex = 1;
		((Control)btnOpenFile).Text = "..";
		((Control)btnOpenFile).Click += button1_Click;
		((Control)btnGravar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnGravar).Location = new Point(6, 49);
		((Control)btnGravar).Name = "btnGravar";
		((Control)btnGravar).Size = new Size(234, 27);
		((Control)btnGravar).TabIndex = 2;
		((Control)btnGravar).Text = "Importar";
		((Control)btnGravar).Click += btnGravar_Click;
		((Control)txtArquivo).BackColor = Color.Gainsboro;
		((Control)txtArquivo).Location = new Point(6, 26);
		((Control)txtArquivo).Name = "txtArquivo";
		((TextBoxBase)txtArquivo).ReadOnly = true;
		((Control)txtArquivo).Size = new Size(205, 21);
		((Control)txtArquivo).TabIndex = 4;
		((FileDialog)openFileDialog1).FileName = "openFileDialog1";
		((FileDialog)openFileDialog1).Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\";";
		((Control)btnVoltar).BackColor = Color.FromArgb(240, 181, 34);
		((Control)btnVoltar).Location = new Point(6, 78);
		((Control)btnVoltar).Name = "btnVoltar";
		((Control)btnVoltar).Size = new Size(234, 27);
		((Control)btnVoltar).TabIndex = 7;
		((Control)btnVoltar).Text = "Voltar";
		((Control)btnVoltar).Click += btnVoltar_Click;
		((Control)progressBar1).Dock = (DockStyle)2;
		((Control)progressBar1).Location = new Point(0, 270);
		((Control)progressBar1).Name = "progressBar1";
		((Control)progressBar1).Size = new Size(240, 24);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
		((ScrollableControl)this).AutoScroll = true;
		((Control)this).BackColor = Color.DimGray;
		((Control)this).ClientSize = new Size(240, 294);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)progressBar1);
		((Control)this).Controls.Add((Control)(object)btnVoltar);
		((Control)this).Controls.Add((Control)(object)txtArquivo);
		((Control)this).Controls.Add((Control)(object)btnGravar);
		((Control)this).Controls.Add((Control)(object)btnOpenFile);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Name = "frmOpenFile";
		((Control)this).Text = "Importar Cadastro";
		((Control)this).ResumeLayout(false);
	}

	public frmOpenFile()
	{
		InitializeComponent();
		((Control)txtArquivo).Text = Program.ConfiguracaoSistema.PathArquivoBancoDados;
		fileName = ((Control)txtArquivo).Text;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			fileName = ((FileDialog)openFileDialog1).FileName;
			((Control)txtArquivo).Text = fileName;
		}
	}

	private void btnGravar_Click(object sender, EventArgs e)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ProdutoBd.ExcluirProduto();
			((Control)btnGravar).Enabled = false;
			((Control)btnVoltar).Enabled = false;
			StreamReader streamReader = new StreamReader(fileName);
			StringBuilder stringBuilder = new StringBuilder(streamReader.ReadToEnd());
			string[] array = stringBuilder.ToString().Split(new char[1] { '\n' });
			progressBar1.Maximum = array.Count();
			progressBar1.Value = 0;
			for (int i = 0; i < array.Count(); i++)
			{
				string[] array2 = array[i].Split(new char[1] { ';' });
				if (array2.Length > 1)
				{
					ProdutoBd.GravarProduto(array2[0], array2[1].Replace('\r', ' ').ToString());
				}
				ProgressBar obj = progressBar1;
				obj.Value += 1;
			}
			MessageBox.Show("Arquivo importado com sucesso!", "Importar", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Atenção!", (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
		}
		finally
		{
			((Control)btnGravar).Enabled = true;
			((Control)btnVoltar).Enabled = true;
			Program.ConfiguracaoSistema.PathArquivoBancoDados = ((Control)txtArquivo).Text;
			Utilis.SerializarConfiguracaoSistema();
		}
	}

	private void btnVoltar_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
