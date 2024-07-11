using System;
using System.IO;
using System.Xml.Serialization;

namespace Coletor.Class.Utils;

public class Serializacao
{
	public static void Gravar(Type tipo, object objeto, string path)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(tipo);
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		Stream stream = new FileStream(path, FileMode.Create);
		xmlSerializer.Serialize(stream, objeto);
		stream.Close();
	}

	public static object Ler(Type tipo, string path)
	{
		TextReader textReader = null;
		XmlSerializer xmlSerializer = null;
		FileStream fileStream = null;
		try
		{
			xmlSerializer = new XmlSerializer(tipo);
			fileStream = new FileStream(path, FileMode.OpenOrCreate);
			textReader = new StreamReader(fileStream);
			return xmlSerializer.Deserialize(textReader);
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			textReader.Close();
			fileStream.Close();
		}
	}
}
