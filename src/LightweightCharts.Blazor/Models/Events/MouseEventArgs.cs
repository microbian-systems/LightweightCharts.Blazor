﻿using LightweightCharts.Blazor.DataItems;
using LightweightCharts.Blazor.Series;
using System.Collections.Generic;

namespace LightweightCharts.Blazor.Models.Events
{
	/// <summary>
	/// Series price at the mouse location.
	/// </summary>
	public class SeriesPrice
	{
		/// <summary>
		/// The series to which this price point belongs to.
		/// </summary>
		public ISeriesApi SeriesApi { get; init; }

		/// <summary>
		/// Pricd data at current mouse point.
		/// </summary>
		public WhitespaceData DataItem { get; init; }
	}

	/// <summary>
	/// Represents a mouse event.<br/>
	/// https://tradingview.github.io/lightweight-charts/docs/api/interfaces/MouseEventParams
	/// </summary>
	public class MouseEventArgs
	{
		/// <summary>
		/// The ID of the marker at the point of the mouse event.
		/// </summary>
		public string HoveredMarkerId { get; init; }

		/// <summary>
		/// Time of the data at the location of the mouse event.
		/// The value will be null if the location of the event in the chart is outside the range of available data.
		/// </summary>
		public long? Time { get; init; }

		/// <summary>
		/// Location of the event in the chart.
		/// The value will be undefined if the event is fired outside the chart, for example a mouse leave event.
		/// </summary>
		public Point Point { get; init; }

		/// <summary>
		/// Prices of all series at the location of the event in the chart.
		/// </summary>
		public IEnumerable<SeriesPrice> SeriesPrices { get; init; }

		/// <summary>
		/// The ISeriesApi for the series at the point of the mouse event.
		/// </summary>
		public ISeriesApi HoveredSeries { get; init; }
	}
}
