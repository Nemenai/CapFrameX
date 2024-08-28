using CapFrameX.Extensions.NetStandard.Attributes;
using System.ComponentModel;

namespace CapFrameX.Statistics.NetStandard.Contracts
{
	public enum EMetric
	{
		[Description("Maximum")]
		[ShortDescription("Max")]
		Max = 1,
		[Description("99% percentile")]
		[ShortDescription("P99")]
		P99 = 2,
		[Description("95% percentile")]
		[ShortDescription("P95")]
		P95 = 3,
		[Description("Average")]
		[ShortDescription("Avg")]
		Average = 4,
        [Description("GPU Active Average")]
        [ShortDescription("GPU Avg")]
        GpuActiveAverage = 5, 
		[Description("Integral Average")]
        [ShortDescription("Integral")]
        Integral = 6,
        [Description("GPU Active Integral Average")]
        [ShortDescription("GPU Integral")]
        GpuActiveIntegral = 7,
        [Description("Median")]
		[ShortDescription("Med")]
		Median = 8,
		[Description("5% percentile")]
		[ShortDescription("P5")]
		P5 = 9,
		[Description("1% percentile")]
		[ShortDescription("P1")]
		P1 = 10,
        [Description("GPU Active 1% percentile")]
        [ShortDescription("GPU P1")]
        GpuActiveP1 = 11,
        [Description("0.2% percentile")]
		[ShortDescription("P0.2")]
		P0dot2 = 12,
		[Description("0.1% percentile")]
		[ShortDescription("P0.1")]
		P0dot1 = 13,
		[Description("1% low average")]
		[ShortDescription("1% Low Avg")]
		OnePercentLowAverage = 14,
        [Description("GPU Active 1% low average")]
        [ShortDescription("GPU 1% Low Avg")]
        GpuActiveOnePercentLowAverage = 15,
        [Description("0.2% low average")]
		[ShortDescription("0.2% Low Avg")]
		ZerodotTwoPercentLowAverage = 16,
		[Description("0.1% low average")]
		[ShortDescription("0.1% Low Avg")]
		ZerodotOnePercentLowAverage = 17,
        [Description("1% low integral")]
        [ShortDescription("1% Low Int")]
        OnePercentLowIntegral = 18,
		[Description("0.2% low integral")]
		[ShortDescription("0.2% Low Int")]
		ZerodotTwoPercentLowIntegral = 19,
		[Description("0.1% low integral")]
        [ShortDescription("0.1% Low Int")]
        ZerodotOnePercentLowIntegral = 20,
        [Description("Minimum")]
		[ShortDescription("Min")]
		Min = 21,
		[Description("Adaptive STDEV")]
		[ShortDescription("Adp STDEV")]
		AdaptiveStd = 22,
		[Description("CPU FPS per 10 Watts")]
		[ShortDescription("CPU FPS/10W")]
		CpuFpsPerWatt = 23,
        [Description("GPU FPS per 10 Watts")]
        [ShortDescription("GPU FPS/10W")]
        GpuFpsPerWatt = 24,
        [Description("None")]
		[ShortDescription("None")]
		None = 25,
	}
}