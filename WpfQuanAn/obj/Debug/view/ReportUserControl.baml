   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      &     WpfQuanAn.view.ReportUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      -   5          >�Name$  ReportUC��5	         ReportVM � DataContext# [  5        MaterialDesignBody#���  5      $��Regular"�5      $��15(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedCommand+   CommandParameter 5   $   �� 	 �� ElementName$	 ReportUC��5      .��5      � 
 � RowDefinitions
 5   
   �� 5      $
��auto �6   6,   �� 5       6   .+�5"   
   � $��0��6   .+�5#      #  MaterialDesignThemes.Wpf.Card  ���#03a9f4$��10q�68   
�������$��0q�5$   :   $	��200��6F   .��5%      � 
 5&      �� 5'      $
��Auto �6(   �� 5(      $
��Auto �6(   �� 5)      $
��Auto �6(   .+�5+      � $��0��6    .+�5,      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CurrencyUsd=�62   $��	25 20 5 4q�6E   �� 5-      $��	5 16 16 4q�6$   $��	Doanh thu��67   $
��Bold"�6I      MaterialDesignBody1TextBlock#��[ 6[   6�   5.      �� 5/      $��1��6       MaterialDesignLightSeparator#��[ 6-   �� 50      $��2��6    $��	50 0 16 8q�6K   $��Center=�6^   $
��Left=�6z   #��[ 6�   ��6-   �� *doanhThuNgay+6�   '  !MaterialDesignThemes.Wpf.PopupBox  51      $��Right=�6.   $��2 0 2 0q�6J      PopupContent. 52      �� .+�53      �� -   5        $��Doanh thu theo tháng��53   b   ��6%   �� *CommandReportThang+6�   �� 54      -   5        $��Doanh thu ngày tháng��54   `   ��6%   �� *CommandReportNgay+6�   55      56      57      58        5:      ���#03a9f4$��5q�68   
�������$��0q�5;   :   $	��200��6F   .��5<      � 
 5=      �� 5>      $
��Auto �6(   �� 5?      $
��Auto �6(   �� 5@      $
��Auto �6(   .+�5B      � $��0��6    .+�5C        $ CoffeeOutline=�62   $��	25 20 5 4q�6G   �� 5D      $��	5 16 16 4q�6$   $��Sản phẩm nổi bật��67   $
��Bold"�6P   #��[ 6c   6�   5E      �� 5F      $��1��6    $��	50 0 16 8q�6H   $��Center=�6[   $
��Left=�6w   #��[ 6�   ��6-   �� *	spBanChay+6�   �� 5G      $��2��6    $��15(�6D   $��	50 0 16 8q�6R   $��Center=�6e   $
��Left=�6�   #��[ 6�   ��6-   �� *slBan+6�   5J      5K      �� 5M      -   5        $��0q�5M   *   $
��auto��66   ��6D   Z� ��6Z   Z� .��5N        ���#03a9f4$��5 0 0 0q�6<   $	��200��6M   
�������$��0q�5O   :   .��5P      � 
 5Q      �� 5R      $
��Auto �6,   �� 5S      $
��Auto �6,   �� 5T      $
��Auto �6,   .+�5V      � $��0��6$   .+�5W        $ ShapeOutline=�66   $��	25 20 5 4q�6J   �� 5X      $��	5 16 16 4q�6(   $��Tổng loại SP��6;   $
��Bold"�6P   #��[ 6c   6�   5Y      �� 5Z      $��1��6$   #��[ 61   �� 5[      $��2��6$   $��	50 0 16 8q�6K   $��Center=�6^   $
��Left=�6z   #��[ 6�   ��61   �� *
TongLoai+6�   5]      5^      5_      �� 5a      -   5        $��0q�5a   -   $
��auto��69   ��6G   Z� ��6]   Z� .��5b        ���#03a9f4$��5 0 0 0q�6<   $	��200��6M   
�������$��0q�5c   :   .��5d      � 
 5e      �� 5f      $
��Auto �6,   �� 5g      $
��Auto �6,   �� 5h      $
��Auto �6,   .+�5j      � $��0��6$   .+�5k        $ Cupcake=�66   $��	25 20 5 4q�6E   �� 5l      $��	5 16 16 4q�6(   $��Tổng sản phẩm��6;   $
��Bold"�6Q   #��[ 6d   6�   5m      �� 5n      $��1��6$   #��[ 61   �� 5o      $��2��6$   $��	50 0 16 8q�6I   $��Center=�6\   $
��Left=�6x   #��[ 6�   ��61   �� *tongSP+6�   5q      5r      5s      5t      � 5v   
   -   5         �Name$ 
GridReport��5v      $��1��6   $��Stretch=�60   $��Stretch=�6N   .+�5x      #	  LiveCharts.Wpf.CartesianChart	  $��3,48,48,24.333q�6E   $��1��6]   &
   LiveCharts.Wpf.Charts.Base.Chart 
  Series 6&   �� *senderChart+ 
  AxisX 5z        LiveCharts.Wpf.Axis     Labels 6#   �� *AxisListName+   	Separator 5{        LiveCharts.Wpf.Separator  5|   "      Step$ 1Q�60      Stroke 69   Z� 5~      5�      5�      5�      5�      