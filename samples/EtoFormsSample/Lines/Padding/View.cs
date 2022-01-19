﻿using Eto.Forms;
using LiveChartsCore.SkiaSharpView.Eto.Forms;
using ViewModelsSamples.Lines.Padding;

namespace EtoFormsSample.Lines.Padding;

public class View : Panel
{
    private readonly CartesianChart cartesianChart;

    public View()
    {
        InitializeComponent();
        Size = new Eto.Drawing.Size(50, 50);

        var viewModel = new ViewModel();

        cartesianChart = new CartesianChart
        {
            Series = viewModel.Series,
            DrawMarginFrame = viewModel.DrawMarginFrame,

            // out of livecharts properties...
            Location = new Eto.Drawing.Point(0, 0),
            Size = new Eto.Drawing.Size(50, 50),
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
        };

        Controls.Add(cartesianChart);
    }
}
