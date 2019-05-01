using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace Dharmatech.WpfExtensionMethods
{
    public static class Extensions
    {
        public static T SetDock<T>(this T element, Dock dock) where T : UIElement
        {
            DockPanel.SetDock(element, dock);

            return element;
        }

        public static T1 AddColumnDefinitions<T1, T2>(this T1 grid, params T2[] column_definitions) where T1 : Grid where T2 : ColumnDefinition
        {
            foreach (var elt in column_definitions)
                grid.ColumnDefinitions.Add(elt);

            return grid;
        }

        public static T SetColumn<T>(this T element, int value) where T : UIElement
        {
            Grid.SetColumn(element, value);

            return element;
        }

        public static T SetValue_<T>(this T factory, DependencyProperty dp, object value) where T : FrameworkElementFactory
        {
            factory.SetValue(dp, value);

            return factory;
        }

        public static T AppendChildren<T>(this T factory, params FrameworkElementFactory[] children) where T : FrameworkElementFactory
        {
            foreach (var child in children)
                factory.AppendChild(child);

            return factory;
        }

        public static T SetVisualTree<T>(this T template, FrameworkElementFactory factory) where T : FrameworkTemplate
        {
            template.VisualTree = factory;

            return template;
        }

        public static T1 SetItemsPanel<T1, T2>(this T1 control, T2 template) where T1 : ItemsControl where T2 : ItemsPanelTemplate
        {
            control.ItemsPanel = template;

            return control;
        }

        public static T AddItems<T>(this T control, params object[] items) where T : ItemsControl
        {
            foreach (var item in items)
                control.Items.Add(item);

            return control;
        }


        public static T1 AddClick<T1>(this T1 button_base, RoutedEventHandler handler) where T1 : ButtonBase
        {
            button_base.Click += handler;

            return button_base;
        }



        public static T AddSelectionChanged<T>(this T obj, RoutedEventHandler handler) where T : TextBoxBase
        {
            obj.SelectionChanged += handler;

            return obj;
        }

        public static T1 AddChildren<T1>(this T1 panel, params UIElement[] elements) where T1 : Panel
        {
            foreach (var elt in elements)
                panel.Children.Add(elt);

            return panel;
        }

        public static T1 AddSetter<T1, T2>(this T1 data_trigger, T2 setter_base) where T1 : DataTrigger where T2 : SetterBase
        {
            data_trigger.Setters.Add(setter_base);

            return data_trigger;
        }

        //public static T1 AddSetter<T1, T2>(this T1 style, T2 setter_base) where T1 : Style where T2 : SetterBase
        //{
        //    style.Setters.Add(setter_base);

        //    return style;
        //}

        public static Style AddSetter<T1>(this Style style, T1 setter_base) where T1 : SetterBase
        {
            style.Setters.Add(setter_base);

            return style;
        }

        public static T1 AddTrigger<T1, T2>(this T1 style, T2 trigger_base) where T1 : Style where T2 : TriggerBase
        {
            style.Triggers.Add(trigger_base);

            return style;
        }

        public static T1 AddResource<T1>(this T1 element, object key, object value) where T1 : FrameworkElement
        {
            element.Resources.Add(key, value);

            return element;
        }

        //public static T1 AddColumns<T1,T2>(this T1 data_grid, params T2[] data_grid_columns) where T1 : DataGrid where T2 : DataGridColumn
        //{
        //    foreach (var column in data_grid_columns)
        //        data_grid.Columns.Add(column);

        //    return data_grid;
        //}

        public static T1 AddColumns<T1>(this T1 data_grid, params DataGridColumn[] data_grid_columns) where T1 : DataGrid
        {
            foreach (var column in data_grid_columns)
                data_grid.Columns.Add(column);

            return data_grid;
        }


        public static T1 AddInlines<T1>(this T1 span, String str) where T1 : Span
        {
            span.Inlines.Add(str);

            return span;
        }

        public static T1 AddInlines<T1>(this T1 span, Inline obj) where T1 : Span
        {
            span.Inlines.Add(obj);

            return span;
        }

        public static T1 AddInlines<T1>(this T1 span, UIElement obj) where T1 : Span
        {
            span.Inlines.Add(obj);

            return span;
        }



        public static TextBlock AddInlines(this TextBlock text_block, String obj)
        {
            text_block.Inlines.Add(obj);

            return text_block;
        }

        public static TextBlock AddInlines(this TextBlock text_block, Inline obj)
        {
            text_block.Inlines.Add(obj);

            return text_block;
        }

        public static TextBlock AddInlines(this TextBlock text_block, UIElement obj)
        {
            text_block.Inlines.Add(obj);

            return text_block;
        }



        public static T1 AddRequestNavigate<T1>(this T1 hyperlink, RequestNavigateEventHandler handler) where T1 : Hyperlink
        {
            hyperlink.RequestNavigate += handler;

            return hyperlink;
        }


    }
}
