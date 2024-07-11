using System.Reflection;

namespace DadosDataSetUtil;

public class DesignerUtil
{
	public static bool IsDesignTime()
	{
		Assembly assembly = typeof(int).Assembly;
		if ((object)assembly != null && assembly.FullName.ToUpper().EndsWith("B77A5C561934E089"))
		{
			return true;
		}
		return false;
	}

	public static bool IsRunTime()
	{
		Assembly assembly = typeof(int).Assembly;
		if ((object)assembly != null && assembly.FullName.ToUpper().EndsWith("969DB8053D3322AC"))
		{
			return true;
		}
		return false;
	}
}
