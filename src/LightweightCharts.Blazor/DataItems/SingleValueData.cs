﻿using System.Text.Json.Serialization;

namespace LightweightCharts.Blazor.DataItems
{
	/// <summary>
	/// A base interface for a data point of single-value series.<br/>
	/// https://tradingview.github.io/lightweight-charts/docs/api/interfaces/SingleValueData
	/// </summary>	
	public class SingleValueData : WhitespaceData
	{
		/// <summary>
		/// Price value of the data.
		/// </summary>
		[JsonPropertyName("value")]
		public double Value { get; set; }
	}
}
