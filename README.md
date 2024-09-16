## RangeSlider.MAUI
Range Slider control allows to select ranges in .NET MAUI apps.

![sample](https://github.com/AndreiMisiukevich/RangeSlider.MAUI/blob/main/images/sample.gif?raw=true)

## Setup
* Available on NuGet: [RangeSlider](http://www.nuget.org/packages/RangeSlider.Maui) [![NuGet](https://img.shields.io/nuget/v/RangeSlider.Maui.svg?label=NuGet)](https://www.nuget.org/packages/RangeSlider.Maui)

```xaml
<ContentPage xmlns:slider="clr-namespace:PanRangeSlider;assembly=PanRangeSlider">
  <slider:RangeSlider />
</ContentPage>
```

## Sample
The sample you can find [here](https://github.com/AndreiMisiukevich/RangeSlider.MAUI/tree/master/PanRangeSliderSample)

## Supported Properties

| Name                        | Default Value | Description |
| --------------------------- | ----------- | ----------- |
| LowerValue                  | 0.0         | Current lower value |
| UpperValue                  | 1.0         | Current upper value |
| MinimumValue                | 0.0         | Minimum value |
| MaximumValue                | 1.0         | Maximum value |
| ThumbSize                   | 30.0        | Thumb size *(if you want to set the same value for Lower & Upper Thumbs)* |
| LowerThumbSize              | -1.0        | Lower Thumb size |
| UpperThumbSize              | -1.0        | Upper Thumb size |
| TrackSize                   | 3.0         | Track size |
| ThumbColor                  | Default     | Thumb color *(if you want to set the same value for Lower & Upper Thumbs)* |
| LowerThumbColor             | Default     | Lower Thumb color |
| UpperThumbColor             | Default     | Upper Thumb color |
| TrackColor                  | Default     | Track color |
| TrackHighlightColor         | Default     | Track highlight color |
| ThumbBorderColor            | Default     | Thumb border color *(if you want to set the same value for Lower & Upper Thumbs)* |
| LowerThumbBorderColor       | Default     | Lower Thumb border color |
| UpperThumbBorderColor       | Default     | Upper Thumb border color |
| TrackBorderColor            | Default     | Track border color |
| TrackHighlightBorderColor   | Default     | Track highlight border color |
| ValueLabelStyle             | Default     | Value label style *(if you want to set the same value for Lower & Upper Thumbs)* |
| LowerValueLabelStyle        | null        | Lower Value label style |
| UpperValueLabelStyle        | null        | Upper Value label style |
| ValueLabelStringFormat      | {0:0.##}    | Value Label String Format |
| LowerThumbView              | null        | Lower Thumb View |
| UpperThumbView              | null        | Upper Thumb View |
| ValueLabelSpacing           | 5.0         | Value label spacing *(from thumb to value label)* |
| ThumbRadius                 | -1.0        | Thumb radius *(if you want to set the same value for Lower & Upper Thumbs)* |
| LowerThumbRadius            | -1.0        | Lower Thumb radius |
| UpperThumbRadius            | -1.0        | Upper Thumb radius |
| TrackRadius                 | -1.0        | Track radius |

## License
The MIT License (MIT) see [License file](LICENSE)

## Contribution
Feel free to create issues and PRs 😃
