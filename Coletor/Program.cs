using System;
using System.IO;
using System.Windows.Forms;
using Coletor.Class.Utils;

namespace Coletor;

internal static class Program
{
	public static ConfiguracaoSistema ConfiguracaoSistema;

	[MTAThread]
	private static void Main()
	{
		if (File.Exists(Diretorio.DiretorioCorrente() + "\\Config.xml"))
		{
			ConfiguracaoSistema = (ConfiguracaoSistema)Serializacao.Ler(typeof(ConfiguracaoSistema), Diretorio.DiretorioCorrente() + "\\Config.xml");
		}
		if (ConfiguracaoSistema == null)
		{
			ConfiguracaoSistema = new ConfiguracaoSistema();
			Utilis.SerializarConfiguracaoSistema();
		}
		Application.Run((Form)(object)new frmMenuPrincipal());
		Utilis.SerializarConfiguracaoSistema();
	}
}
