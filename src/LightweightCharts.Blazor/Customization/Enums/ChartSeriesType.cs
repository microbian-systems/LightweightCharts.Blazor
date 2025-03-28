﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using LightweightCharts.Blazor.Converters;

namespace LightweightCharts.Blazor.Customization.Enums
{
	/// <summary>
	/// <see href="https://tradingview.github.io/lightweight-charts/docs/api/interfaces/SeriesOptionsMap"/>
	/// </summary>
	[JsonConverter(typeof(SeriesTypeConverter))]
	public enum SeriesType
	{
		/// <summary>
		/// Line
		/// </summary>
		Line,

		/// <summary>
		/// Area
		/// </summary>
		Area,

		/// <summary>
		/// Bar
		/// </summary>
		Bar,

		/// <summary>
		/// Candlestick
		/// </summary>
		Candlestick,

		/// <summary>
		/// Histogram
		/// </summary>
		Histogram,

		/// <summary>
		/// Baseline
		/// </summary>
		Baseline
	}

	internal class SeriesTypeConverter : BaseEnumJsonConverter<SeriesType>
	{
		protected override Dictionary<SeriesType, string> GetEnumMapping() => new Dictionary<SeriesType, string>
		{
			[SeriesType.Line] = "Line",
			[SeriesType.Area] = "Area",
			[SeriesType.Bar] = "Bar",
			[SeriesType.Candlestick] = "Candlestick",
			[SeriesType.Histogram] = "Histogram",
			[SeriesType.Baseline] = "Baseline"
		};
	}
}
