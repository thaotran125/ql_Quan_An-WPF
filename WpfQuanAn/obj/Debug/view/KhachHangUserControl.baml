   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      )    #WpfQuanAn.view.KhachHangUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         KhachHangVM  � DataContext#  [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#      Mode$ Light=�60   .��5      �� $��20��6   6"   5      � 5   
   $��1��6   .+�5!      � .+�5"      #  MaterialDesignThemes.Wpf.Card  $��0��6&   $��2��63   .��5#      � .+�5$      �� $	��300��6"   $��5q�6w   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên khách hàng��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6.   �� *tenkh+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5%      $	��300��6"   $��5q�6w   $ Số điện thoại��6�   #��[ 6�   ��6.   �� *sdtkh+$ PropertyChanged=�$ TwoWay=�6�   �� 5&      $	��300��6"   $��5q�6v   $ điểm��6�   #��[ 6�   ��6.   �� *diem+$ PropertyChanged=�$ TwoWay=�6�   5'      5(        5)      $��0��6&   $��1��63   $��10, 3, 10,3q�6C   .��5*      �� .+�5+      	�  	� 	GroupName$ gt��6&   $	��nam��6�   $��5, 5, 10, 5q�6�    # MaterialDesignAccentRadioButton#��[ 6�   	 d� 	IsChecked	 65   �� 
 �� Path$
 radio1�$ TwoWay=�$ PropertyChanged=�6�   	� 5,      $ gt��6&   $
��nữ��6�   $��
5, 5, 5, 5q�6�   #��[ 6�   	 65   �� $
 radio2�$ TwoWay=�$ PropertyChanged=�6�   5-      5.      5/      50        53   
   $��2��6   $��5q�6+   .��54      � .+�55      �� $��Thêm��68   $��5q�6G   $	��100��6R   ���#0074cf$
��Bold"�6s   ��6   �� *
AddCommand+6s   �� 56      $��Sửa��69   $��5q�6G   $	��100��6R   ���#0074cf$
��Bold"�6s   ��6   �� *EditCommand+6�   �� 57      $
��Xóa��6;   $��5q�6I   $	��100��6T   ���#0074cf$
��Bold"�6u   
���  ����6   �� *DeleteCommand+6�   �� 58      $��Refish��65   $��5q�6F   $	��100��6Q   ���#0074cf$
��Bold"�6r   ��6   �� *	Restart+6�   59      5:      � 5=   
   $��3��6   $��Center=�6   .+�5>      &   System.Windows.Controls.DataGrid  $��5,5,5,5q�6      AutoGenerateColumns .     
IsReadOnly . ��6V   �� *List+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedItem+ � 	Resources 5?      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5@      "  6    5A      P� 5B       �@ 
IsSelected . . �5C   "   ��  � �� �	#FF5273F36?   �� 5D   "    � ��$
 Bold"�6?   6N   5E      5G      5H         Columns 5J      4  .System.Windows.Controls.DataGridTemplateColumn  5K      ,  &System.Windows.Controls.DataGridColumn   Width5	  /System.Windows.Controls.DataGridLengthConverter$ *	 6.      Header$ id khách hàng��68      
IsReadOnly .    HeaderStyle 5L      �� 5M      =
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 6$   .�5N   "   ��  � ��$ Center=�6O   6`   �� 5O   "    � ��$ Segoe UI)�6?   6R   �� 5P   "    � ��$ 15(�6=   6J   �� 5Q   "    � ��$
 Bold"�6?   6N   �� 5R   "    � ��
 ��  �6N   5S         CellTemplate 5U      �� 5V      .R�5W   "   �� $��Center=�6(   ��6E   �� *idkh+6`   5X      5Z        5\      $ *	 6.   $ Tên khách hàng��68    .  5]      �� 5^      " 
 6$   .�5_   "   ��  � ��$ Center=�6O   6`   �� 5`   "    � ��$ Segoe UI)�6?   6R   �� 5a   "    � ��$ 15(�6=   6J   �� 5b   "    � ��$
 Bold"�6?   6N   �� 5c   "    � ��
 ��  �6N   5d       5f      �� 5g      .R�5h   "   �� $��Center=�6(   ��6E   �� *tenkh+6a   5i      5k        5m      $ *	 6.   $ Số điện thoại��68    .  5n      �� 5o      " 
 6$   .�5p   "   ��  � ��$ Center=�6O   6`   �� 5q   "    � ��$ Segoe UI)�6?   6R   �� 5r   "    � ��$ 15(�6=   6J   �� 5s   "    � ��$
 Bold"�6?   6N   �� 5t   "    � ��
 ��  �6N   5u       5w      �� 5x      .R�5y   "   �� $��Center=�6(   ��6E   �� *sdtkh+6a   5z      5|        5~      $ *	 6.   $ Điểm��68    .  5      �� 5�      " 
 6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�       5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *diem+6`   5�      5�        5�      $ *	 6.   $ Giới tính��68    .  5�      �� 5�      " 
 6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�       5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *phai+6`   5�      5�      5�      5�      5�      5�      