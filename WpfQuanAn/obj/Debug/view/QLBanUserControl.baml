   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      %    WpfQuanAn.view.QLBanUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         BanAnVM  � DataContext#  [  5	        MaterialDesignBody#���  5      $��Regular"�5      $��15(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   �� $��0��6   $��30 5 0 5q�6"   .+�5      �� $��10q�6d   ��6   �� *	TongSoBan+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6r   �� 5      $��Center=�6h   $��
75,5,235,5q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Tổng số bàn thêm/xóa��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *tongSoBanThem+$ PropertyChanged=�$ TwoWay=�6�   5      � 5   
   $��1��6   $��30 5 5 0q�6!   .+�5      �� $��Thêm��64   $��5q�6C   $	��100��6N   ���#0074cf$
��Bold"�6o   ��6   �� *
AddCommand+6o   �� 5      $
��Xóa��67   $��5q�6E   $	��100��6P   ���#0074cf$
��Bold"�6q   
���  ����6   �� *DeleteCommand+6�   �� 5       $��Refesh��61   $��5q�6B   $	��100��6M   ���#0074cf$
��Bold"�6n   ��6   �� *	Restart+6�   5!      5"      5#      