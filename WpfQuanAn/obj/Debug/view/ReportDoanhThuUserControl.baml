   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5
      .    (WpfQuanAn.view.ReportDoanhThuUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5
      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5         RPDoanhThuThang  � DataContext#  [  5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��10q�6!   $��Center=�6-   $��34(�6J   $��THỐNG KÊ DOANH THU��6X   �� 5   
   -   5         ��Name$ cbMonth��5      $��1��6$   $��10q�61   $��Center=�6=   $��18(�6Z   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Chọn Tháng��5       �� 
IsEditable . $	��150��5       & "MaterialDesignFloatingHintComboBox#��[ 5       �� SelectedValuePath$ Content��5       �� Text 5   h   �� *thang+ �� SelectedValue 5      �� *SelectedItem+ �� Mode$ TwoWay=�.  (System.Windows.Interactivity.Interaction	   Triggers	 5      /  )System.Windows.Interactivity.EventTrigger  5      
   	EventName$
 SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5       6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *SelectionChangedCommand+5!      .@�5$      ��  �� 
IsSelected . $��1��6-   �� 5%      $��2��6   �� 5&      $��3��6   �� 5'      $��4��6   �� 5(      $��5��6   �� 5)      $��6��6   �� 5*      $��7��6   �� 5+      $��8��6   �� 5,      $��9��6   �� 5-      $��10��6   �� 5.      $��11��6   �� 5/      $��12��6   51      #  LiveCharts.Wpf.CartesianChart  52   
   $��2��6   
���   �&   LiveCharts.Wpf.Charts.Base.Chart   Series 54      !  LiveCharts.Wpf.ColumnSeries  	  LiveCharts.Wpf.Series 	  Title$ revenue��6$    	  Values 64   �� *columDoanhThu+ �� UpdateSourceTrigger$ PropertyChanged=�$ TwoWay=�58         AxisX 5<      
  LiveCharts.Wpf.Axis
   
  Title$ ngày��6    
  Labels 6(   �� *
Axisngay+$ PropertyChanged=�$ TwoWay=�6y      AxisY 5@      
  $ 	doanh thu��6    6-   �� *columDoanhThu+6P   5B      5C      5D      