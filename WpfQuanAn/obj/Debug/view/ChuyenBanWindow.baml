   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5   	   $    WpfQuanAn.view.ChuyenBanWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfQuanAn.view     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          �Name$  ChuyenBanWD��5   	    � WindowStyle$
 None=�5
   	      	banHangVM � DataContext# [  5   	    � Title$ ChuyenBanWindow��5   	   $	��300��6!   $	��600��6.    � 
ResizeMode$ NoResize=�5   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   .+�5      �� $��	5,10,5,10q�6   $��Center=�6'   $��Segoe UI)�6K   $��15(�6a   $
��Bold"�6o   
����  �$ ��Chọn bàn cần chuyển��6�   6�   �� 5      $��	5,10,5,10q�6   $��Center=�6*    �� DisplayMemberPath$ tenban��6�   $��1��6�   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Chọn bàn��6  ��6N   �� *listBanCoNguoi+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *selectedbanChuyen+$
 OneWayToSource=�68  �� 5      $��Segoe UI)�6x   $��15(�6�   $
��Bold"�6�   ���#0074cf
�������$��Chuyển��6�    $  MaterialDesignRaisedAccentButton#��[ 6�   $��5,5,5,5q�6"  $��0��63  ��6   �� *ComfirmChuyenBanCommand+��6B   ��  �� ElementName$ ChuyenBanWD��6E  5       �� 5"   
   $��1��6   .+�5#      �� $��	5,10,5,10q�6   $��Center=�6'   $��Segoe UI)�6K   $��15(�6a   $
��Bold"�6o   
����  �$��Chọn bàn trống��6�   6�   �� 5$      $��	5,10,5,10q�6   $��Center=�6*   $ tenban��6�   $��1��6�   $	 Chọn bàn��6  ��6N   �� *listBanTrong+$
 TwoWay=�$ PropertyChanged=� 6�   �� *selectedbanSeChuyen+$
 OneWayToSource=�68  �� 5%      $��Segoe UI)�6n   $��15(�6�   $
��Bold"�6�   
���   �$��Cancel��6�   #��[ 6�   $��5,5,5,5q�6  $��0��6  ��6   �� *ICommandCancel+��69   �� $ ChuyenBanWD��6'  5&      5'      5(      