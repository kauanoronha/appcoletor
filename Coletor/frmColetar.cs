using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmartDeviceProject1;

namespace Coletor;

public class frmColetar : Form
{
    private IContainer components;

    private MainMenu mainMenu1;

    private TextBox txtCodigoBarra;

    private Label label1;

    private Label lblProduto;

    private Label label2;

    private Label label3;

    private Label lblValor;

    private Label lblInicPromocao;

    private Label lblFimPromocao;

    private Label lblInicPromocaoObj;

    private Label lblFimPromocaoObj;

    private Label lblEmPromocao;

    public frmColetar()
    {
        InitializeComponent();
    }

    private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
    {
        HttpWebResponse httpWebResponse = null;
        StreamReader streamReader = null;
        try
        {
            if (e.KeyChar == '\r')
            {
                ((Control)lblInicPromocao).Visible = false;
                ((Control)lblInicPromocaoObj).Visible = false;
                ((Control)lblFimPromocao).Visible = false;
                ((Control)lblFimPromocaoObj).Visible = false;
                ((Control)lblEmPromocao).Visible = false;
                string linkWebservice = Program.ConfiguracaoSistema.LinkWebservice;
                linkWebservice += $"/{((Control)txtCodigoBarra).Text}";
                ((Control)txtCodigoBarra).Text = "";
                ((Control)txtCodigoBarra).Focus();
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(linkWebservice));
                httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
                httpWebRequest.ContentType = "application/json";
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                streamReader = new StreamReader(responseStream);
                string text = streamReader.ReadToEnd();

                // Parse the JSON response to extract the product data
                var jsonResponse = JObject.Parse(text);
                var produtoData = jsonResponse["data"]?[0]?["attributes"];
                if (produtoData != null)
                {
                    BuscarPrecoVendaProduto buscarPrecoVendaProduto = produtoData.ToObject<BuscarPrecoVendaProduto>();
                    ((Control)lblProduto).Text = buscarPrecoVendaProduto.Pronome.ToString();
                    ((Control)lblValor).Text = "R$ " + buscarPrecoVendaProduto.Provalor.ToString("N2");
                    if (buscarPrecoVendaProduto.EmPromocao)
                    {
                        ((Control)lblEmPromocao).Visible = true;
                        ((Control)lblInicPromocao).Visible = true;
                        ((Control)lblInicPromocaoObj).Visible = true;
                        DateTime value = buscarPrecoVendaProduto.InicioDaPromocao.Value;
                        DateTime value2 = buscarPrecoVendaProduto.FinalDaPromocao.Value;
                        ((Control)lblInicPromocaoObj).Text = value.ToString("dd/MM/yyyy");
                        ((Control)lblFimPromocao).Visible = true;
                        ((Control)lblFimPromocaoObj).Visible = true;
                        ((Control)lblFimPromocaoObj).Text = value2.ToString("dd/MM/yyyy");
                    }
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }
            }
        }
        catch (WebException ex)
        {
            httpWebResponse = (HttpWebResponse)ex.Response;
            Mensagem.MensagemExclamacao();
            if (httpWebResponse == null)
            {
                ((Control)lblProduto).Text = ex.Message;
            }
            else if (httpWebResponse.StatusCode == HttpStatusCode.InternalServerError)
            {
                ((Control)lblProduto).Text = "Produto não encontrado";
            }
            else if (httpWebResponse.StatusCode == HttpStatusCode.NotFound)
            {
                ((Control)lblProduto).Text = "HttpStatusCode.NotFound";
            }
            ((Control)lblInicPromocaoObj).Text = string.Empty;
            ((Control)lblFimPromocaoObj).Text = string.Empty;
            ((Control)lblValor).Text = string.Empty;
            ((Control)lblEmPromocao).Visible = false;
            ((Control)lblInicPromocao).Visible = false;
            ((Control)lblInicPromocaoObj).Visible = false;
            ((Control)lblFimPromocao).Visible = false;
            ((Control)lblFimPromocaoObj).Visible = false;
            ((Control)txtCodigoBarra).Text = "";
            ((Control)txtCodigoBarra).Focus();
        }
        catch (Exception ex2)
        {
            Mensagem.MensagemExclamacao();
            ((Control)lblValor).Text = string.Empty;
            ((Control)lblProduto).Text = ex2.Message;
            ((Control)lblEmPromocao).Visible = false;
            ((Control)lblInicPromocao).Visible = false;
            ((Control)lblInicPromocaoObj).Visible = false;
            ((Control)lblFimPromocao).Visible = false;
            ((Control)lblFimPromocaoObj).Visible = false;
            ((Control)txtCodigoBarra).Text = "";
            ((Control)txtCodigoBarra).Focus();
        }
        finally
        {
            streamReader?.Close();
            if (streamReader != null)
            {
                httpWebResponse.Close();
            }
        }
    }

    private string Format(object p)
    {
        throw new NotImplementedException();
    }

    private object CDate(DateTime dateTime)
    {
        throw new NotImplementedException();
    }

    private object CDate()
    {
        throw new NotImplementedException();
    }

    private string Date(string p)
    {
        throw new NotImplementedException();
    }

    private string DateTime(string p)
    {
        throw new NotImplementedException();
    }

    private string Char(int p)
    {
        throw new NotImplementedException();
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
        //IL_00ed: Unknown result type (might be due to invalid IL or missing references)
        //IL_00f7: Expected O, but got Unknown
        //IL_017d: Unknown result type (might be due to invalid IL or missing references)
        //IL_0187: Expected O, but got Unknown
        //IL_029f: Unknown result type (might be due to invalid IL or missing references)
        //IL_02a9: Expected O, but got Unknown
        //IL_03e3: Unknown result type (might be due to invalid IL or missing references)
        //IL_03ed: Expected O, but got Unknown
        //IL_0463: Unknown result type (might be due to invalid IL or missing references)
        //IL_046d: Expected O, but got Unknown
        //IL_04c8: Unknown result type (might be due to invalid IL or missing references)
        //IL_04d2: Expected O, but got Unknown
        mainMenu1 = new MainMenu();
        txtCodigoBarra = new TextBox();
        label1 = new Label();
        lblProduto = new Label();
        label2 = new Label();
        label3 = new Label();
        lblValor = new Label();
        lblInicPromocao = new Label();
        lblFimPromocao = new Label();
        lblInicPromocaoObj = new Label();
        lblFimPromocaoObj = new Label();
        lblEmPromocao = new Label();
        ((Control)this).SuspendLayout();
        ((Control)txtCodigoBarra).BackColor = Color.White;
        ((Control)txtCodigoBarra).Location = new Point(3, 21);
        ((Control)txtCodigoBarra).Name = "txtCodigoBarra";
        ((Control)txtCodigoBarra).Size = new Size(234, 21);
        ((Control)txtCodigoBarra).TabIndex = 2;
        ((Control)txtCodigoBarra).KeyPress += new KeyPressEventHandler(txtCodigoBarra_KeyPress);
        ((Control)label1).ForeColor = Color.White;
        ((Control)label1).Location = new Point(3, 4);
        ((Control)label1).Name = "label1";
        ((Control)label1).Size = new Size(100, 14);
        ((Control)label1).Text = "Código de Barras";
        ((Control)lblProduto).BackColor = Color.FromArgb(255, 255, 192);
        ((Control)lblProduto).Font = new Font("Tahoma", 14f, (FontStyle)0);
        ((Control)lblProduto).Location = new Point(3, 60);
        ((Control)lblProduto).Name = "lblProduto";
        ((Control)lblProduto).Size = new Size(234, 46);
        ((Control)label2).ForeColor = Color.White;
        ((Control)label2).Location = new Point(3, 44);
        ((Control)label2).Name = "label2";
        ((Control)label2).Size = new Size(100, 16);
        ((Control)label2).Text = "Descrição";
        ((Control)label3).ForeColor = Color.White;
        ((Control)label3).Location = new Point(3, 108);
        ((Control)label3).Name = "label3";
        ((Control)label3).Size = new Size(100, 16);
        ((Control)label3).Text = "Valor";
        ((Control)lblValor).BackColor = Color.FromArgb(255, 255, 192);
        ((Control)lblValor).Font = new Font("Tahoma", 14f, (FontStyle)0);
        ((Control)lblValor).Location = new Point(3, 124);
        ((Control)lblValor).Name = "lblValor";
        ((Control)lblValor).Size = new Size(234, 25);
        ((Control)lblInicPromocao).ForeColor = Color.White;
        ((Control)lblInicPromocao).Location = new Point(3, 151);
        ((Control)lblInicPromocao).Name = "lblInicPromocao";
        ((Control)lblInicPromocao).Size = new Size(100, 17);
        ((Control)lblInicPromocao).Text = "Ínic. Promoção";
        ((Control)lblInicPromocao).Visible = false;
        ((Control)lblFimPromocao).ForeColor = Color.White;
        ((Control)lblFimPromocao).Location = new Point(136, 151);
        ((Control)lblFimPromocao).Name = "lblFimPromocao";
        ((Control)lblFimPromocao).Size = new Size(84, 17);
        ((Control)lblFimPromocao).Text = "Fim Promoção";
        ((Control)lblFimPromocao).Visible = false;
        ((Control)lblInicPromocaoObj).BackColor = Color.FromArgb(255, 255, 192);
        ((Control)lblInicPromocaoObj).Font = new Font("Tahoma", 12f, (FontStyle)0);
        ((Control)lblInicPromocaoObj).Location = new Point(3, 168);
        ((Control)lblInicPromocaoObj).Name = "lblInicPromocaoObj";
        ((Control)lblInicPromocaoObj).Size = new Size(97, 23);
        ((Control)lblInicPromocaoObj).Visible = false;
        ((Control)lblFimPromocaoObj).BackColor = Color.FromArgb(255, 255, 192);
        ((Control)lblFimPromocaoObj).Font = new Font("Tahoma", 12f, (FontStyle)0);
        ((Control)lblFimPromocaoObj).Location = new Point(136, 168);
        ((Control)lblFimPromocaoObj).Name = "lblFimPromocaoObj";
        ((Control)lblFimPromocaoObj).Size = new Size(100, 24);
        ((Control)lblFimPromocaoObj).Visible = false;
        ((Control)lblEmPromocao).Font = new Font("Tahoma", 9f, (FontStyle)1);
        ((Control)lblEmPromocao).ForeColor = Color.White;
        ((Control)lblEmPromocao).Location = new Point(119, 45);
        ((Control)lblEmPromocao).Name = "lblEmPromocao";
        ((Control)lblEmPromocao).Size = new Size(101, 15);
        ((Control)lblEmPromocao).Text = "* Em Promoção";
        ((Control)lblEmPromocao).Visible = false;
        ((ContainerControl)this).AutoScaleDimensions = new SizeF(96f, 96f);
        ((ContainerControl)this).AutoScaleMode = (AutoScaleMode)2;
        ((ScrollableControl)this).AutoScroll = true;
        ((Control)this).BackColor = Color.Gray;
        ((Control)this).ClientSize = new Size(240, 268);
        ((Control)this).Controls.Add((Control)(object)lblEmPromocao);
        ((Control)this).Controls.Add((Control)(object)lblFimPromocaoObj);
        ((Control)this).Controls.Add((Control)(object)lblInicPromocaoObj);
        ((Control)this).Controls.Add((Control)(object)lblFimPromocao);
        ((Control)this).Controls.Add((Control)(object)lblInicPromocao);
        ((Control)this).Controls.Add((Control)(object)lblValor);
        ((Control)this).Controls.Add((Control)(object)label3);
        ((Control)this).Controls.Add((Control)(object)label2);
        ((Control)this).Controls.Add((Control)(object)lblProduto);
        ((Control)this).Controls.Add((Control)(object)label1);
        ((Control)this).Controls.Add((Control)(object)txtCodigoBarra);
        ((Form)this).Menu = mainMenu1;
        ((Control)this).Name = "frmColetar";
        ((Control)this).Text = "Consultar";
        ((Control)this).ResumeLayout(false);
    }
}
