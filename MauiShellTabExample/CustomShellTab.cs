using MauiShellTabExample.Views;
using Microsoft.Maui.Controls;
using System.Collections;

namespace MauiShellTabExample;

/// <summary>
/// Custom Shelltab
/// <see cref="Tab"/>
/// </summary>
public class CustomShellTab : Tab
{


    public static BindableProperty ItemSourceProperty =
        BindableProperty.Create(
            nameof(ItemSource),
            typeof(IEnumerable),
            typeof(CustomShellTab),
            defaultValue: _ = Array.Empty<object>(),
            propertyChanged: ItemSourceChanged);
    public CustomShellTab()
    {

    }


    public IEnumerable ItemSource
    {
        get
        {
            return (IEnumerable)GetValue(ItemSourceProperty);
        }
        set
        {
            SetValue(ItemSourceProperty, value);
        }
    }


    /// <summary>
    /// set shellcontent to items
    /// </summary>
    public void UpdateItemSource()
    {

        foreach (string item in ItemSource)
        {
            var datatemplate = new DataTemplate(typeof(PageA));
            this.Items.Add(new ShellContent { ContentTemplate = datatemplate, Title = item });
        }
    }
    static void ItemSourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var tab = bindable as CustomShellTab;

        if (tab == null)
            return;

        if (newValue == null)
            return;

        tab.UpdateItemSource();

    }
}