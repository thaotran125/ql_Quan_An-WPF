   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      (    "WpfQuanAn.view.AccountUserControl1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         	accountVM  � DataContext#  [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��15(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#      Mode$ Light=�60   .��5      �� $��20��6   6"   5      � 5    
   $��1��6   5'      #  MaterialDesignThemes.Wpf.Card  5*   
   $��2��6   $��5q�6+   .��5+      � .+�5,      �� $��Thêm��68   $��5q�6G   $	��100��6R   ���#0074cf$
��Bold"�6s   ��6   �� *
AddCommand+6s   �� 5-      $��Reset PassWord��69   $��5q�6R   $	��100��6]   ���#0074cf$
��Bold"�6~   ��6   �� *EditCommand+6�   �� 5.      $
��Xóa��6;   $��5q�6I   $	��100��6T   ���#0074cf$
��Bold"�6u   
���  ����6   �� *DeleteCommand+6�   �� 5/      $��Refish��65   $��5q�6F   $	��100��6Q   ���#0074cf$
��Bold"�6r   ��6   �� *	Restart+6�   50      51      � 54   
   $��3��6   $��Center=�6    � ColumnDefinitions 55      �� 56      6%   �� 57      $	��400 �6#   61   .+�59      � $��0��6   $
��Left=�6#    5:      �� 5;      $
��auto �6'   �� 5<      $
��auto �6'   �� 5=      $
��auto �6'   �� 5>      .+�5@      &   System.Windows.Controls.DataGrid  $��5,5,5,5q�6      AutoGenerateColumns .     
IsReadOnly . $��4��6�   ��6[   �� *List+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� SelectedItem
 6�   �� *SelectedItem+ � 	Resources 5A      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5B      "  6     5C      P� 5D   "    �@ 
IsSelected . . �5E   &   ��  � �� �	#FF5273F36C   �� 5F   &    � ��$
 Bold"�6C   6R   5G   #   5I      5J         Columns 5L      4  .System.Windows.Controls.DataGridTemplateColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 62      Header$ UserName��6<      
IsReadOnly .    HeaderStyle 5N      �� 5O   "   =	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6(   .�5P   &   ��  � ��$ Center=�6S   6d   �� 5Q   &    � ��$ Segoe UI)�6C   6V   �� 5R   &    � ��$ 15(�6A   6N   �� 5S   &    � ��$
 Bold"�6C   6R   �� 5T   &    � ��
 ��  �6R   5U   #      CellTemplate 5W      �� 5X   "   .R�5Y   &   �� $��Center=�6,   ��6I   �� *	userNanme+6i   5Z   #   5\        5^      $ * 62   $ Tên nhân viên��6<    .  5_      �� 5`   "   " 	 6(   .�5a   &   ��  � ��$ Center=�6S   6d   �� 5b   &    � ��$ Segoe UI)�6C   6V   �� 5c   &    � ��$ 15(�6A   6N   �� 5d   &    � ��$
 Bold"�6C   6R   �� 5e   &    � ��
 ��  �6R   5f   #    5h      �� 5i   "   .R�5j   &   �� $��Center=�6,   ��6I   �� *NHANVIEN.tennv+6n   5k   #   5m      5p      5q      � 5s      $��1��6    5t      �� 5u      $
��auto �6$   64   �� 5v      $
��auto �6$   64   �� 5w      $
��auto �6$   64   �� 5x      $
��auto �6$   64   �� 5y      $
��auto �6$   64   �� 5z      $
��auto �6$   64   .+�5|      � $��0��6   .+�5}      �� $�� 5q�6   $��Tên Nhân Viên��6(   
����  �$
��Bold"�6R   6f   �� 5~      $�� 5q�6    $
��Bold"�6C   ��6,   �� *tenNV+6W   5      � 5�      $��1��6   .+�5�      �� $�� 5q�6   $��Số Điện Thoại��6(   
����  �$
��Bold"�6R   6f   �� 5�      $�� 5q�6    $
��Bold"�6C   ��6,   �� *sdtnv+6W   5�      � 5�      $��2��6   .+�5�      �� $�� 5q�6   $
��Mail��6(   
����  �$
��Bold"�6I   6]   �� 5�      $�� 5q�6    $
��Bold"�6B   ��6,   �� *mail+6V   5�      � 5�      $��3��6   .+�5�      �� $�� 5q�6   $��Địa Chỉ��6(   
����  �$
��Bold"�6L   6`   �� 5�      $�� 5q�6    $
��Bold"�6B   ��6,   �� *dcnv+6V   5�      � 5�      $��4��6   .+�5�      �� $�� 5q�6   $��
Ngày Sinh��6(   
����  �$
��Bold"�6N   6b   �� 5�      $�� 5q�6    $
��Bold"�6F   ��6,   �� *
ngaysinh+6Z   5�      � 5�      $��5��6   .+�5�      �� $�� 5q�6   $��Giới Tính��6(   
����  �$
��Bold"�6N   6b   �� 5�      $�� 5q�6    $
��Bold"�6F   ��6,   �� *
gioiTInh+6Z   5�      5�      5�      5�      5�      