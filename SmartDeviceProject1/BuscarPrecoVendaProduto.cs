using System;

namespace SmartDeviceProject1;

public class BuscarPrecoVendaProduto
{
	public long Procodigo { get; set; }

	public string Pronome { get; set; }

	public decimal Provalor { get; set; }

	public bool EmPromocao { get; set; }

	public DateTime? InicioDaPromocao { get; set; }

	public DateTime? FinalDaPromocao { get; set; }
}
