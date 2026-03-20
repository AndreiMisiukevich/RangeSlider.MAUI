# PanRangeSlider: A Versatile Range Slider for .NET MAUI Applications

![Range Slider Banner](https://via.placeholder.com/1200x600.png?text=PanRangeSlider+for+.NET+MAUI)

## Introduction

In modern mobile and desktop applications, sliders are a common UI component that allow users to select a value from a continuous range. However, standard sliders typically only allow selection of a single value. Enter **PanRangeSlider** - a highly customizable dual-thumb range slider for .NET MAUI applications that enables users to select a range of values with lower and upper bounds.

## Key Features

PanRangeSlider offers a rich set of features that make it stand out from standard slider controls:

- **Dual Thumbs**: Select both lower and upper values to define a range
- **Pan Gesture Support**: Intuitive touch/mouse interaction for adjusting values
- **Extensive Customization**: Control colors, sizes, borders, and more
- **Value Labels**: Display current values with customizable formatting
- **Custom Thumb Views**: Replace default thumbs with your own custom views
- **Accessibility**: Designed with usability in mind

## Getting Started

Adding PanRangeSlider to your .NET MAUI application is straightforward. First, install the package:

```bash
dotnet add package PanRangeSlider
```

Then, add the namespace to your XAML:

```xml
xmlns:pan="clr-namespace:PanRangeSlider;assembly=PanRangeSlider"
```

Now you can use the control in your XAML:

```xml
<pan:RangeSlider
    MinimumValue="0"
    MaximumValue="100"
    LowerValue="20"
    UpperValue="80"
    ThumbColor="Blue"
    TrackColor="LightGray"
    TrackHighlightColor="SkyBlue"
    ValueLabelStringFormat="{0:0}" />
```

## Customization Options

PanRangeSlider provides extensive customization options:

- **Colors**: Customize thumb, track, and highlight colors
- **Sizes**: Adjust thumb and track sizes to match your UI
- **Borders**: Add borders with custom colors to thumbs and tracks
- **Radius**: Control the corner radius of thumbs and tracks
- **Labels**: Style value labels with custom fonts and formatting
- **Custom Views**: Replace default thumbs with your own custom views

## Event Handling

The control provides several events to respond to user interactions:

- **ValueChanged**: Triggered when either value changes
- **LowerValueChanged/UpperValueChanged**: Specific value change events
- **DragStarted/DragCompleted**: Track when user starts/finishes dragging
- **LowerDragStarted/UpperDragStarted**: Specific thumb drag start events
- **LowerDragCompleted/UpperDragCompleted**: Specific thumb drag completion events

## Real-World Applications

PanRangeSlider is ideal for scenarios like:

- **Price Range Filters**: Allow users to set minimum and maximum prices
- **Date Range Selection**: Select start and end dates on a timeline
- **Audio/Video Editing**: Define clip start and end points
- **Data Visualization**: Filter data by a range of values
- **Settings Controls**: Adjust minimum and maximum thresholds

## Performance Considerations

The control is designed with performance in mind, using efficient layout calculations and gesture handling to ensure smooth operation even on lower-end devices.

## Conclusion

PanRangeSlider fills an important gap in the .NET MAUI UI toolkit by providing a polished, customizable range selection control. Whether you're building e-commerce apps, data visualization tools, or media applications, this control offers an intuitive way for users to select ranges of values.

Give it a try in your next .NET MAUI project and enhance your user interface with this powerful control!

---

*This article is part of our series on custom UI controls for .NET MAUI. Check out our other articles for more insights into building beautiful cross-platform applications.* 