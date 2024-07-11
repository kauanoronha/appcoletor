using System.Text.RegularExpressions;

namespace Coletor.Class.Utils;

public class Validacao
{
	public static bool ValidaNumero(string numero)
	{
		Regex regex = new Regex("^\\d+$");
		return regex.IsMatch(numero);
	}
}
