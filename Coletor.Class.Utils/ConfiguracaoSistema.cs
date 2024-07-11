namespace Coletor.Class.Utils;

public class ConfiguracaoSistema
{
	private string pathArquivoBancoDados;

	private string pathArquivoExportaColeta;

	private string pathSistema;

	private string linkWebservice;

	private bool permiteIncluirDescricaoColeta;

	private decimal empresa;

	public string PathSistema
	{
		get
		{
			return pathSistema;
		}
		set
		{
			pathSistema = value;
		}
	}

	public string LinkWebservice
	{
		get
		{
			return linkWebservice;
		}
		set
		{
			linkWebservice = value;
		}
	}

	public decimal Empresa
	{
		get
		{
			return empresa;
		}
		set
		{
			empresa = value;
		}
	}

	public string PathArquivoBancoDados
	{
		get
		{
			return pathArquivoBancoDados;
		}
		set
		{
			pathArquivoBancoDados = value;
		}
	}

	public string PathArquivoExportaColeta
	{
		get
		{
			return pathArquivoExportaColeta;
		}
		set
		{
			pathArquivoExportaColeta = value;
		}
	}

	public bool PermiteIncluirDescricaoColeta
	{
		get
		{
			return permiteIncluirDescricaoColeta;
		}
		set
		{
			permiteIncluirDescricaoColeta = value;
		}
	}

	public ConfiguracaoSistema()
	{
		pathSistema = Diretorio.DiretorioCorrente() + "\\";
		linkWebservice = "\\\\localhost:8080\\api\\produto\\";
		permiteIncluirDescricaoColeta = false;
		empresa = 1m;
	}
}
