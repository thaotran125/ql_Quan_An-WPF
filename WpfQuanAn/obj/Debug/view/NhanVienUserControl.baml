   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      (    "WpfQuanAn.view.NhanVienUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         
NhanVienVM  � DataContext#  [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��15(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#      Mode$ Light=�60   .��5      �� $��20��6   6"   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5       6&   �� 5!      $
��auto �6#   63   .+�5#      � .+�5$      #  MaterialDesignThemes.Wpf.Card  $��0��6'   $��2��67   .��5%      � .+�5&      �� $	��300��6"   $��5q�6w   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên nhân viên��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6.   �� *tenNV+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5'      $	��300��6"   $��5q�6w   $ Số điện thoại��6�   #��[ 6�   ��6.   �� *sdtnv+$ PropertyChanged=�$ TwoWay=�6�   �� 5(      $	��300��6"   $��5q�6v   $	 mai��6�   #��[ 6�   ��6.   �� *mail+$ PropertyChanged=�$ TwoWay=�6�   �� 5)      $	��300��6"   $��5q�6v   $ Địa chỉ��6�   #��[ 6�   ��6.   �� *dcnv+$ PropertyChanged=�$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5*      $��
5, 5, 5, 5q�6%   $��Center=�69   $	��100��6�   $ Ngày sinh��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�   	   SelectedDate	 6T   �� *
ngaysinh+$ PropertyChanged=�
 �� StringFormat$
 
dd mm yyyy��6�   5+      5,      5-        5.      $��0��6"   $��70��60   $��70��6<   $��730,20,0,10q�6G   .��5/      �� $��95��6   .+�50      	�  	� 	GroupName$ gt��6"   $	��nam��6�   $��5, 5, 10, 5q�6�    # MaterialDesignAccentRadioButton#��[ 6�    d� 	IsChecked 61   �� *radio1+$ TwoWay=�$ PropertyChanged=�6�   	� 51      $ gt��6"   $
��nữ��6�   $��
5, 5, 5, 5q�6�   #��[ 6�    61   �� *radio2+$ TwoWay=�$ PropertyChanged=�6�   52      53      54        57   
   $��2��6   $��5q�6+   .��58      � .+�59      �� $��Thêm��68   $��5q�6G   $	��100��6R   ���#0074cf$
��Bold"�6s   ��6   �� *
AddCommand+6s   �� 5:      $��Sửa��69   $��5q�6G   $	��100��6R   ���#0074cf$
��Bold"�6s   ��6   �� *EditCommand+6�   �� 5;      $
��Xóa��6;   $��5q�6I   $	��100��6T   ���#0074cf$
��Bold"�6u   
���  ����6   �� *DeleteCommand+6�   �� 5<      $��Refish��65   $��5q�6F   $	��100��6Q   ���#0074cf$
��Bold"�6r   ��6   �� *	Restart+6�     5>      $ Standard=�5?   	   $��8 4 8 4q�5@   	      CornerRadius$ 2��5A   	    K� ZIndex$ 1��5B   	   $��16 0 0 0q�5C   	   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5D   	   .��5E      �  5F      �� 5G      $
��Auto �5H      �� 5I      $��* �5J      �� 5K      $
��Auto �5L      .+�5N      ��   MaterialDesignToolButton#���  5O      .��5P      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�5Q       J� Opacity$	 .56Q�5R      5S      �� 5T      $��1��5U      $��8 0 0 0q�5V      $ Build a search ��5W      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5X      $��0q�5Y      $	��200��5Z      $��Center=�5[      ��5T   "   �� *	TxtSearch+$ TwoWay=�$ PropertyChanged=�.��5[   )   5]      �� 5^      #���  5_      $��2��5`      .��5a        $ 
Microphone=�5b      $	 .56Q�5c      $��8 0 0 0q�5d      5e      5f      5g      5h      5i      � 5l   
   $��3��6   $��Center=�6   .+�5m      &	   System.Windows.Controls.DataGrid	  $��5,5,5,5q�6    	  AutoGenerateColumns .   	  
IsReadOnly . ��6V   �� *List+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedItem+ � 	Resources 5n      *
  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '
        �� 5o      " 
 6    5p      P� 5q       �@
 
IsSelected . . �5r   "   ��  � �� �	#FF5273F36?   �� 5s   "    � ��$
 Bold"�6?   6N   5t      5v      5w       	  Columns 5y      4  .System.Windows.Controls.DataGridTemplateColumn  5z      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6.      Header$ id nhân viên��68       
IsReadOnly  . !   HeaderStyle! 5{      �� 5|      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$   .�5}   "   ��  � ��$ Center=�6O   6`   �� 5~   "    � ��$ Segoe UI)�6?   6R   �� 5   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�      "   CellTemplate" 5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *idnv+6`   5�      5�        5�      $ * 6.   $ Tên nhân viên��68     . ! 5�      �� 5�      "  6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�      " 5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *tennv+6a   5�      5�        5�      $ * 6.   $ Số điện thoại��68     . ! 5�      �� 5�      "  6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�      " 5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *sdtnv+6a   5�      5�        5�      $ * 6.   $ Email��68     . ! 5�      �� 5�      "  6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�      " 5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *mail+6`   5�      5�        5�      $ * 6.   $ Địa chỉ��68     . ! 5�      �� 5�      "  6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�      " 5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *dcnv+6`   5�      5�        5�      $ * 6.   $ 
Ngày sinh��68     . ! 5�      �� 5�      "  6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�      " 5�      �� 5�      .R�5�   "   �� $��Center=�6,   ��6I   �� *
ngaysinh+$
 
dd/MM/yyyy��6�   5�      5�        5�      $ * 6.   $ Giới tính��68     . ! 5�      �� 5�      "  6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�      " 5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *
gioitinh+6d   5�      5�      5�      5�      5�      5�      