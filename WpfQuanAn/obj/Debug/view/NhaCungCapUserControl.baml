   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      *    $WpfQuanAn.view.NhaCungCapUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         	NhaCungVM  � DataContext#  [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      � .+�5      #  MaterialDesignThemes.Wpf.Card  $��2��6&   .��5      � .+�5      �� $��5q�6j   $	��300��6u   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên nhà cung cấp��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6"   �� *ten+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5       $��5q�6i   $	��300��6u   $ Số điện thoại��6�   #��[ 6�   ��6"   �� *sdt+$ PropertyChanged=�$ TwoWay=�6�   �� 5!      $��5q�6j   $	��300��6u   $
 Mail��6�   #��[ 6�   ��6"   �� *mail+$ PropertyChanged=�$ TwoWay=�6�   �� 5"      $��5q�6h   $	��300��6t   $ Địa chỉ��6�   #��[ 6�   ��6"   �� *dc+$ PropertyChanged=�$ TwoWay=�6�   5#      5$      5%      5&        5)   
   $��1��6   $��5q�6+   .��5*      � .+�5+      �� $��Thêm��68   $��5q�6G   $	��100��6R   ���#0074cf$
��Bold"�6s   ��6   �� *
AddCommand+6s   �� 5,      $��Sửa��69   $��5q�6G   $	��100��6R   ���#0074cf$
��Bold"�6s   ��6   �� *EditCommand+6�   �� 5-      $
��Xóa��6;   $��5q�6I   $	��100��6T   ���#0074cf$
��Bold"�6u   
���  ����6   �� *DeleteCommand+6�   �� 5.      $��Refish��65   $��5q�6F   $	��100��6Q   ���#0074cf$
��Bold"�6r   ��6   �� *	Restart+6�   5/      50      � 53   
   $��2��6   $��Center=�6   .+�54      &   System.Windows.Controls.DataGrid  $��5,5,5,5q�6      AutoGenerateColumns .     
IsReadOnly . ��6V   �� *List+$ TwoWay=�$ PropertyChanged=�	 �� SelectedItem	 6�   �� *SelectedItem+
 � 	Resources
 55      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 56      "  6    57      P� 58       �@ 
IsSelected . . �59   "   ��  � �� �	#FF5273F36?   �� 5:   "    � ��$
 Bold"�6?   6N   5;      5=      5>         Columns 5@      4  .System.Windows.Controls.DataGridTemplateColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6.      Header$ id nhà cung��68      
IsReadOnly .    HeaderStyle 5B      �� 5C      =	  7System.Windows.Controls.Primitives.DataGridColumnHeader" 	 6$   .�5D   "   ��  � ��$ Center=�6O   6`   �� 5E   "    � ��$ Segoe UI)�6?   6R   �� 5F   "    � ��$ 15(�6=   6J   �� 5G   "    � ��$
 Bold"�6?   6N   �� 5H   "    � ��
 ��  �6N   5I         CellTemplate 5K      �� 5L      .R�5M   "   �� $��Center=�6(   ��6E   �� *	idnhacc+6c   5N      5P        5R      $ * 6.   $ Tên nhà cung��68    .  5S      �� 5T      " 	 6$   .�5U   "   ��  � ��$ Center=�6O   6`   �� 5V   "    � ��$ Segoe UI)�6?   6R   �� 5W   "    � ��$ 15(�6=   6J   �� 5X   "    � ��$
 Bold"�6?   6N   �� 5Y   "    � ��
 ��  �6N   5Z       5\      �� 5]      .R�5^   "   �� $��Center=�6(   ��6E   �� *
tennhacung+6f   5_      5a        5c      $ * 6.   $ Số điện thoại��68    .  5d      �� 5e      " 	 6$   .�5f   "   ��  � ��$ Center=�6O   6`   �� 5g   "    � ��$ Segoe UI)�6?   6R   �� 5h   "    � ��$ 15(�6=   6J   �� 5i   "    � ��$
 Bold"�6?   6N   �� 5j   "    � ��
 ��  �6N   5k       5m      �� 5n      .R�5o   "   �� $��Center=�6(   ��6E   �� *sdtncc+6b   5p      5r        5t      $ * 6.   $
 Mail��68    .  5u      �� 5v      " 	 6$   .�5w   "   ��  � ��$ Center=�6O   6`   �� 5x   "    � ��$ Segoe UI)�6?   6R   �� 5y   "    � ��$ 15(�6=   6J   �� 5z   "    � ��$
 Bold"�6?   6N   �� 5{   "    � ��
 ��  �6N   5|       5~      �� 5      .R�5�   "   �� $��Center=�6(   ��6E   �� *	mailncc+6c   5�      5�        5�      $ * 6.   $ Địa chỉ��68    .  5�      �� 5�      " 	 6$   .�5�   "   ��  � ��$ Center=�6O   6`   �� 5�   "    � ��$ Segoe UI)�6?   6R   �� 5�   "    � ��$ 15(�6=   6J   �� 5�   "    � ��$
 Bold"�6?   6N   �� 5�   "    � ��
 ��  �6N   5�       5�      �� 5�      .R�5�   "   �� $��Center=�6(   ��6E   �� *dcncc+6a   5�      5�      5�      5�      5�      5�      