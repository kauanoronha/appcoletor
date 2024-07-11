using System;

namespace Coletor.Class.Utils;

public static class Utilis
{
	internal static void SerializarConfiguracaoSistema()
	{
		try
		{
			Serializacao.Gravar(typeof(ConfiguracaoSistema), Program.ConfiguracaoSistema, Diretorio.DiretorioCorrente() + "\\Config.xml");
		}
		catch (Exception)
		{
			throw;
		}
	}
}
