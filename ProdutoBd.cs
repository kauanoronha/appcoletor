using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;

public static class ProdutoBd
{
	public static void GravarProduto(string proBarras, string proNome)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		SqlCeConnection val = null;
		try
		{
			val = new SqlCeConnection("Data Source = \\Program Files\\Coletor\\Connection\\Dados.sdf;");
			((DbConnection)(object)val).Open();
			SqlCeCommand val2 = val.CreateCommand();
			SqlCeDataAdapter val3 = new SqlCeDataAdapter();
			new DataSet();
			((DbCommand)(object)val2).CommandText = $"INSERT INTO Produto(Probarras, [ProNome]) VALUES ('{proBarras}','{proNome}');";
			val3.InsertCommand = val2;
			((DbCommand)(object)val2).ExecuteNonQuery();
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			((DbConnection)(object)val).Close();
		}
	}

	public static void ExcluirProduto()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		SqlCeConnection val = null;
		try
		{
			val = new SqlCeConnection("Data Source = \\Program Files\\Coletor\\Connection\\Dados.sdf;");
			((DbConnection)(object)val).Open();
			SqlCeCommand val2 = val.CreateCommand();
			SqlCeDataAdapter val3 = new SqlCeDataAdapter();
			new DataSet();
			((DbCommand)(object)val2).CommandText = $"DELETE FROM Produto;";
			val3.DeleteCommand = val2;
			((DbCommand)(object)val2).ExecuteNonQuery();
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			((DbConnection)(object)val).Close();
		}
	}

	public static string ObterNomeProduto(string barras)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		SqlCeConnection val = null;
		try
		{
			val = new SqlCeConnection("Data Source = \\Program Files\\Coletor\\Connection\\Dados.sdf;");
			((DbConnection)(object)val).Open();
			SqlCeCommand val2 = val.CreateCommand();
			SqlCeDataAdapter val3 = new SqlCeDataAdapter();
			DataSet dataSet = new DataSet();
			((DbCommand)(object)val2).CommandText = "SELECT * FROM PRODUTO WHERE PROBARRAS = '" + barras + "'";
			val3.SelectCommand = val2;
			val2.ExecuteReader();
			((DataAdapter)(object)val3).Fill(dataSet);
			if (dataSet.Tables[0].Rows.Count > 0)
			{
				return dataSet.Tables[0].Rows[0]["ProNome"].ToString();
			}
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			((DbConnection)(object)val).Close();
		}
		return "";
	}

	public static string ObterTotalDeProdutos()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		SqlCeConnection val = null;
		try
		{
			val = new SqlCeConnection("Data Source = \\Program Files\\Coletor\\Connection\\Dados.sdf;");
			((DbConnection)(object)val).Open();
			SqlCeCommand val2 = val.CreateCommand();
			SqlCeDataAdapter val3 = new SqlCeDataAdapter();
			DataSet dataSet = new DataSet();
			((DbCommand)(object)val2).CommandText = "SELECT Count(*) AS Total FROM PRODUTO";
			val3.SelectCommand = val2;
			val2.ExecuteReader();
			((DataAdapter)(object)val3).Fill(dataSet);
			if (dataSet.Tables[0].Rows.Count > 0)
			{
				return dataSet.Tables[0].Rows[0]["Total"].ToString();
			}
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			((DbConnection)(object)val).Close();
		}
		return "0";
	}
}
