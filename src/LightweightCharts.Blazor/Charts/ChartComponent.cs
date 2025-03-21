﻿using LightweightCharts.Blazor.Customization;
using LightweightCharts.Blazor.Customization.Chart;
using LightweightCharts.Blazor.Customization.Enums;
using LightweightCharts.Blazor.Customization.Series;
using LightweightCharts.Blazor.DataItems;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace LightweightCharts.Blazor.Charts
{
	/// <summary>
	/// The main interface of a single chart using time for horizontal scale.<br/>
	/// <see href="https://tradingview.github.io/lightweight-charts/docs/api/interfaces/IChartApi"/>
	/// </summary>
	public interface IChartApi : IChartApiBase<long>, ICustomizableObject<ChartOptions>
	{

	}

	/// <summary>
	/// implementation for <see cref="IChartApi"/>
	/// </summary>
	public class ChartComponent : ChartComponentBase<long, ChartOptions>, IChartApi, IAsyncDisposable
	{
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns><inheritdoc/></returns>
		protected override ValueTask<IJSObjectReference> CreateChart()
			=> JsModule.CreateChart(JsRuntime, Id, new ChartOptions());

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <typeparam name="O"><inheritdoc/></typeparam>
		/// <param name="type"><inheritdoc/></param>
		/// <returns><inheritdoc/></returns>
		/// <exception cref="NotImplementedException"></exception>
		protected override Type ValidateAndResolveSeries<O>(SeriesType type)
		{
			switch (type)
			{
				case SeriesType.Line:
					{
						ThrowIfOptionsTypeDoesntMatch<O, LineStyleOptions>(type);
						return typeof(LineData<long>);
					}
				case SeriesType.Area:
					{
						ThrowIfOptionsTypeDoesntMatch<O, AreaStyleOptions>(type);
						return typeof(AreaData<long>);
					}
				case SeriesType.Bar:
					{
						ThrowIfOptionsTypeDoesntMatch<O, BarStyleOptions>(type);
						return typeof(BarData<long>);
					}
				case SeriesType.Candlestick:
					{
						ThrowIfOptionsTypeDoesntMatch<O, CandlestickStyleOptions>(type);
						return typeof(CandlestickData<long>);
					}
				case SeriesType.Histogram:
					{
						ThrowIfOptionsTypeDoesntMatch<O, HistogramStyleOptions>(type);
						return typeof(HistogramData<long>);
					}
				case SeriesType.Baseline:
					{
						ThrowIfOptionsTypeDoesntMatch<O, BaselineStyleOptions>(type);
						return typeof(BaselineData<long>);
					}
				default:
					throw new NotImplementedException("chart type not handled");
			};
		}
	}
}
