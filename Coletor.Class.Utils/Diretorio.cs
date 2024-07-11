using System.IO;
using System.Reflection;

namespace Coletor.Class.Utils;

public static class Diretorio
{
	public static string DiretorioCorrente()
	{
		return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
	}
}
