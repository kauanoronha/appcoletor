using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;

public static class ConferenciaBd
{
	public static void GravarConferencia(string proBarras, string proNome, decimal proQuantidade)
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
			((DbCommand)(object)val2).CommandText = $"INSERT INTO Conferencia(Probarras, [ProNome], ProQuantidade) VALUES ('{proBarras}','{proNome}',{proQuantidade});";
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

	public static DataTable ObterProdutoConferencia(string proBarra)
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
			((DbCommand)(object)val2).CommandText = string.Format("SELECT SUM(ProQuantidade) AS ProQuantidade, ProBarras, ProNome FROM CONFERENCIA WHERE PROBARRAS = '" + proBarra + "' GROUP BY ProBarras, ProNome");
			val3.SelectCommand = val2;
			val2.ExecuteReader();
			((DataAdapter)(object)val3).Fill(dataSet);
			return dataSet.Tables[0];
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

	public static void ExluirProdutoConferencia(string proBarra)
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
			((DbCommand)(object)val2).CommandText = $"DELETE FROM CONFERENCIA WHERE PROBARRAS = '{proBarra}';";
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

	public static void ExcluirConferencia()
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
			((DbCommand)(object)val2).CommandText = $"DELETE FROM CONFERENCIA;";
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

	public static DataTable ObterConferencia()
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
			((DbCommand)(object)val2).CommandText = $"SELECT SUM(ProQuantidade) AS ProQuantidade, ProBarras, ProNome FROM CONFERENCIA GROUP BY ProBarras, ProNome";
			val3.SelectCommand = val2;
			val2.ExecuteReader();
			((DataAdapter)(object)val3).Fill(dataSet);
			return dataSet.Tables[0];
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
}
