﻿using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace AvaloniaControls.Samples.Chat;

public class DateTimeConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is DateTime dateTime)
        {
            return dateTime.ToLocalTime().ToString("HH:mm");
        }
        
        return AvaloniaProperty.UnsetValue;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}