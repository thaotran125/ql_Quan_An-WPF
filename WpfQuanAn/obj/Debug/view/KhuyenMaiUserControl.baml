   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      )    #WpfQuanAn.view.KhuyenMaiUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         KhuyenMaiVM  � DataContext#  [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � -   5         �Name$ Grid_parent��5      .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      6"   .+�5      � $��0��6   .+�5      � .+�5      �� $��Center=�6h   $��5q�6�   $	��300��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên sự kiện��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *tenkm+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5      $��
5, 5, 5, 5q�6!   $��Center=�65   $	��250��6�   $ Ngày bắt đàu��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6P   �� *ngayBD+$ PropertyChanged=�6�     5      $��
5, 5, 5, 5q�6!   $��Center=�65   $	��250��6�   $ Ngày kết thúc��6�   #��[ 6�    6P   �� *ngayKT+$ PropertyChanged=�6�   �� 5       $��5q�6k   $��Center=�6v   $	��150��6�   $ Chiết khấu��6�   #��[ 6�   ��6   �� *	chietKhau+$ PropertyChanged=�$ TwoWay=�6�   �� 5!      $��Center=�6i   $��5q�6�   $	��800��6�   $ ghi chú��6�   #��[ 6�   ��6   �� *ghiChu+$ PropertyChanged=�$ TwoWay=�6�   5"      5#      #  MaterialDesignThemes.Wpf.Card  5%      $��1��6"   $��5q�6/   .��5&      � .+�5'      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ���#0074cf$
��Bold"�6w   ��6   �� *
AddCommand+6w   �� 5(      $��Sửa��6=   $��5q�6K   $	��100��6V   ���#0074cf$
��Bold"�6w   ��6   �� *EditCommand+6�   �� 5)      $
��Xóa��6?   $��5q�6M   $	��100��6X   ���#0074cf$
��Bold"�6y   
���  ����6   �� *DeleteCommand+6�   �� 5*      $��Refish��69   $��5q�6J   $	��100��6U   ���#0074cf$
��Bold"�6v   ��6   �� *	Restart+6�   5+      5,      � 5.      $��2��6   $��Center=�6!   	 � ColumnDefinitions	 5/      �� 50      $��6* �6'   �� 51      $	��29* �6'   .+�53      &   System.Windows.Controls.DataGrid  $��	10,10,0,0q�6   
   AutoGenerateColumns
 .     
IsReadOnly . $��2��6�   ��6\   �� *List+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedItem+ � 	Resources 54      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 55      "  6     56      P� 57   "    �@ 
IsSelected . . �58   &   ��  � �� �	#FF5273F36C   �� 59   &    � ��$
 Bold"�6C   6R   5:   #   5<      5=         Columns 5?      4  .System.Windows.Controls.DataGridTemplateColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Width5	  /System.Windows.Controls.DataGridLengthConverter$	 100	 62      Header$ id��6>      
IsReadOnly .    HeaderStyle 5A      �� 5B   "   =
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 6(   .�5C   &   ��  � ��$ Center=�6S   6d   �� 5D   &    � ��$ Segoe UI)�6C   6V   �� 5E   &    � ��$ 15(�6A   6N   �� 5F   &    � ��$
 Bold"�6C   6R   �� 5G   &    � ��
 ��  �6R   5H   #      CellTemplate 5J      �� 5K   "   .R�5L   &   �� $��Center=�6,   ��6I   �� *idkm+6d   5M   #   5O        5Q      $ *	 62   $ Tên Sự Kiện��6<    .  5R      �� 5S   "   " 
 6(   .�5T   &   ��  � ��$ Center=�6S   6d   �� 5U   &    � ��$ Segoe UI)�6C   6V   �� 5V   &    � ��$ 15(�6A   6N   �� 5W   &    � ��$
 Bold"�6C   6R   �� 5X   &    � ��
 ��  �6R   5Y   #    5[      �� 5\   "   .R�5]   &   �� $��Center=�6,   ��6I   �� *tenkm+6e   5^   #   5`        5b      $ *	 62   $ Ngày băt đầu��6<    .  5c      �� 5d   "   " 
 6(   .�5e   &   ��  � ��$ Center=�6S   6d   �� 5f   &    � ��$ Segoe UI)�6C   6V   �� 5g   &    � ��$ 15(�6A   6N   �� 5h   &    � ��$
 Bold"�6C   6R   �� 5i   &    � ��
 ��  �6R   5j   #    5l      �� 5m   "   .R�5n   &   �� $��Center=�60   ��6M   �� *ngayBD+ �� StringFormat$ {0:dd.MM.yy HH:mm:ss}��6�   5o   #   5q        5s      $ *	 62   $ Ngày kết thúc��6<    .  5t      �� 5u   "   " 
 6(   .�5v   &   ��  � ��$ Center=�6S   6d   �� 5w   &    � ��$ Segoe UI)�6C   6V   �� 5x   &    � ��$ 15(�6A   6N   �� 5y   &    � ��$
 Bold"�6C   6R   �� 5z   &    � ��
 ��  �6R   5{   #    5}      �� 5~   "   .R�5   &   �� ��60   �� *ngayKT+$ {0:dd.MM.yy HH:mm:ss}��6q   5�   #   5�        5�      $ *	 62   $ Ghi chú��6<    .  5�      �� 5�   "   " 
 6(   .�5�   &   ��  � ��$ Center=�6S   6d   �� 5�   &    � ��$ Segoe UI)�6C   6V   �� 5�   &    � ��$ 15(�6A   6N   �� 5�   &    � ��$
 Bold"�6C   6R   �� 5�   &    � ��
 ��  �6R   5�   #    5�      �� 5�   "   .R�5�   &   �� $��Center=�6,   ��6I   �� *ghichu+6f   5�   #   5�        5�      $ *	 62   $ Chiết khấu��6<    .  5�      �� 5�   "   " 
 6(   .�5�   &   ��  � ��$ Center=�6S   6d   �� 5�   &    � ��$ Segoe UI)�6C   6V   �� 5�   &    � ��$ 15(�6A   6N   �� 5�   &    � ��$
 Bold"�6C   6R   �� 5�   &    � ��
 ��  �6R   5�   #    5�      �� 5�   "   .R�5�   &   �� $��Center=�6,   ��6I   �� *	chietKhau+$ {0:#.##}��6�   5�   #   5�      5�      5�      5�      5�      5�      