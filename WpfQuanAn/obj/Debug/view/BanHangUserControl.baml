   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      '    !WpfQuanAn.view.BanHangUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          >�Name$  	banHangUC��5         	banHangVM � DataContext# [  5
        MaterialDesignBody#���  5      $��Regular"�5      $��15(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedCommand+   CommandParameter 5   $   �� 	 �� ElementName$	 	banHangUC��5      .��5      � -   5        
 �Name$
 GridBHdParent��5   E   $��Stretch=�6   $��Stretch=�6)    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   �� 5       $
��auto �6   6,   .+�5"   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#      Mode$ Light=�60   .��5#      � .+�5$      �� -   5        $��50��5$   �   $��
 50 10 0 0q�6�   ��6   Z� ��6/   Z� ��6]   �� *backHomeCommand+.��5%      �� $��../Assets/logo.png��6   $��25��68   $��40��6D   5&      �� 5'      $��ĂN VẶT BEN BEN��6   $��
 50 10 0 0q�61   $
��Bold"�6E   
����  �6W   �� 5(      $��	30 10 0 0q�6f   ��6   �� *tenban+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6{   5)      5*      � 5,   
   $��1��6   $��5q�6    � ColumnDefinitions 5-      �� 5.      $
��auto �6#   62   �� 5/      $
��auto �6#   62   �� 50      $	��350 �6#   61   .+�54      � $��0��6   $
��Left=�6#   $��50 0 0 0q�6>    55      �� 56      $
��Auto �6$   64   �� 57      $
��Auto �6$   64   .+�59      �� $��0��6   $��5,5,5,5q�6)   $��Center=�6:    �� DisplayMemberPath$ tenloaifood��6�   $��15(�6  $
��Bold"�6  $��Segoe UI)�6"  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Danh mục thực đơn��68  ��6^   �� *listLoaiFood+ �� SelectedItem 6�   �� *SelectedItemLoaiFood+$ TwoWay=�$ PropertyChanged=�6m  &   System.Windows.Controls.DataGrid  5;      $��5,5,5,5q�6   $��1��6,      
IsReadOnly .    AutoGenerateColumns .  $��Bottom=�6  ��6K   �� *
ListFood+$ TwoWay=�$ PropertyChanged=� 6�   �� *SelectedItemMonAn+$ TwoWay=�$ PropertyChanged=� � 	Resources 5<      *	  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '	        �� 5=      " 	 6     5>      P� 5?   "    �@	 
IsSelected . . �5@   &   ��  � �� �	#FF5273F36C   �� 5A   &    � ��$
 Bold"�6C   6R   5B   #   5D      5E         Columns 5F      4
  .System.Windows.Controls.DataGridTemplateColumn
  5H      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 61      Header$ 	Tên Món��6>      HeaderStyle 5I      �� 5J   "   =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6(   .�5K   &   ��  � ��$ Center=�6S   6d   �� 5L   &    � ��$ Segoe UI)�6C   6V   �� 5M   &    � ��$ 15(�6A   6N   �� 5N   &    � ��$
 Bold"�6C   6R   �� 5O   &    � ��
 ��  �6R   5P   #     
  CellTemplate  5S      �� 5T   "   .R�5U   &   �� $��Center=�6H   ��6,   �� *	tenfood+6n   5V   #   5X      
  5Z      $	 100 61   $
 Size��6=    5[      �� 5\   "   "  6(   .�5]   &   ��  � ��$ Center=�6S   6d   �� 5^   &    � ��$ Segoe UI)�6C   6V   �� 5_   &    � ��$ 15(�6A   6N   �� 5`   &    � ��$
 Bold"�6C   6R   �� 5a   &    � ��
 ��  �6R   5b   #     5e      �� 5f   "   .R�5g   &   �� $��Center=�6E   ��6,   �� *size+6k   5h   #   5j      
  5l      $	 100 61   $ 
Đơn giá��6=    5m      �� 5n   "   "  6(   .�5o   &   ��  � ��$ Center=�6S   6d   �� 5p   &    � ��$ Segoe UI)�6C   6V   �� 5q   &    � ��$ 15(�6A   6N   �� 5r   &    � ��$
 Bold"�6C   6R   �� 5s   &    � ��
 ��  �6R   5t   #     5w      �� 5x   "   .R�5y   &   �� $��Center=�6D   ��6,   �� *gia+6j   5z   #   5|      
  5~      $	 100 61   $ Khuyến mãi��6=    5      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   6d   �� 5�   &    � ��$ Segoe UI)�6C   6V   �� 5�   &    � ��$ 15(�6A   6N   �� 5�   &    � ��$
 Bold"�6C   6R   �� 5�   &    � ��
 ��  �6R   5�   #     5�      �� 5�   "   .R�5�   &   �� $��Center=�6�   ��6,   �� *KHUYENMAI.chietKhau+$ TwoWay=�$ PropertyChanged=�! �� StringFormat$! {0:#.##}��6�   5�   #   5�      5�      5�      � 5�      $��1��6   $��Right=�6#    5�      �� 5�      $
��auto �6$   64   �� 5�      6&   .+�5�      �� $��0��6   $��Center=�6&   $
��Bold"�6�   ��6J   �� *
lbTieuDe+$ TwoWay=�$ PropertyChanged=�6�     5�      $��1��6    . $��30 0 0 0q�6;    .  ��6M   �� *
listCtbill+$ TwoWay=�$ PropertyChanged=� 6�   �� *SelectedItemCTBill+$ TwoWay=�$ PropertyChanged=� 5�      ��%�   '	        �� 5�      " 	 6     5�      P� 5�   "    �@	 
IsSelected . . �5�   &   ��  � �� �	#FF5273F36C   �� 5�   &    � ��$
 Bold"�6C   6R   5�   #   5�      5�       5�      
  5�      $
 auto 61   $ 	Tên Món��6>    5�      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   6d   �� 5�   &    � ��$ Segoe UI)�6C   6V   �� 5�   &    � ��$ 15(�6A   6N   �� 5�   &    � ��$
 Bold"�6C   6R   �� 5�   &    � ��
 ��  �6R   5�   #     5�      �� 5�   "   .R�5�   &   �� $��Center=�6M   ��6,   �� *FOOD.tenfood+6s   5�   #   5�      
  5�      $	 100 61   $
 Size��6=    5�      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   6d   �� 5�   &    � ��$ Segoe UI)�6C   6V   �� 5�   &    � ��$ 15(�6A   6N   �� 5�   &    � ��$
 Bold"�6C   6R   �� 5�   &    � ��
 ��  �6R   5�   #     5�      �� 5�   "   .R�5�   &   �� $��Center=�6J   ��6,   �� *	FOOD.size+6p   5�   #   5�      
  5�      $	 100 61   $ 
Đơn giá��6=    5�      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   6d   �� 5�   &    � ��$ Segoe UI)�6C   6V   �� 5�   &    � ��$ 15(�6A   6N   �� 5�   &    � ��$
 Bold"�6C   6R   �� 5�   &    � ��
 ��  �6R   5�   #     5�      �� 5�   "   .R�5�   &   �� $��Center=�6I   ��6,   �� *
FOOD.gia+6o   5�   #   5�      
  5�      $	 100 61   $ Số Lượng��6=   "   
IsReadOnly" .   5�      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   6d   �� 5�   &    � ��$ Segoe UI)�6C   6V   �� 5�   &    � ��$ 15(�6A   6N   �� 5�   &    � ��$
 Bold"�6C   6R   �� 5�   &    � ��
 ��  �6R   5�   #     5�      �� 5�   "   .R�5�   &   �� $��Center=�6z   ��6,   �� *	slOrder+$ PropertyChanged=�$ TwoWay=�6�   5�   #   5�      5�      5�      � 5�      $��2��6   $
��Left=�6#    5�      �� 5�      $
��auto �6$   64   �� 5�      $
��auto �6$   64   �� 5�      $
��auto �6$   64   �� 5�      6&   .+�5�      � $��0��6   .+�5�      � .+�5�      �� $��0��6$   $��5,5,5,5q�61   $	��250��6B   $��Center=�6N   $ tenkh��6�   $��15(�6  $
��Bold"�6  $��Segoe UI)�6$  $ Danh mục khách hàng��6:  ��6r   �� *ListKH+ 6�   �� *SelectedItemKH+$ TwoWay=�$ PropertyChanged=�6q  �� 5�      $��Center=�6"   $	��250��6F   $��5q�6�   $ Số Lượng Order��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6R   �� *	slOrder+$ PropertyChanged=�$ TwoWay=�.��6  5�      5�      5�      � 5      $��1��6   $��3��6)   .+�5     �� $��5,5,5,5q�6?   +  %MaterialDesignThemes.Wpf.ShadowAssist#   ShadowDepth$# Depth5=�6P   $��Segoe UI)�6�   $��15(�6�   $
��Bold"�6�   ���#0074cf
���  ��$��	Xóa món��6�   ��6   �� *XoaMonCommand+6�   �� 5     $��Sửa��6@   $��5q�6N   $	��100��6Y   ���#0074cf$
��Bold"�6z   ��6   �� *EditMonCommand+6�   5     � 5     $��2��6   $��3��6)   $
��Left=�69   $ � Orientation$$ 
Horizontal=�6T   $��10q�6m   .+�5     �� $��5,5,5,5q�6C   $# Depth5=�6T   $��Segoe UI)�6�   $��15(�6�   $
��Bold"�6�   ���#0074cf
�������$��Chuyển bàn��6�   ��6   �� *ChuyenBanCommand+6�   �� 5     $��5,5,5,5q�6@   $# Depth5=�6Q   $��Segoe UI)�6�   $��15(�6�   $
��Bold"�6�   ���#0074cf
�������$��
Gộp bàn��6�   ��6   �� *GopBanCommand+6�   �� 5     -   5        % ��Name$% btThanhToan��5     $��5,5,5,5q�6X   $# Depth5=�6i   $��Segoe UI)�6�   $��15(�6�   $
��Bold"�6�   ���#0074cf
�������$��Thanh toán��6�   ��62   �� *ThanhToanCommand+6  5     �� 5
     $��3��6   $��Bottom=�6*   $��10q�6E   .+�5     �� $
��Left=�6   $��Segoe UI)�6�   $��15(�6�   $
��Bold"�6�   
���  ����6?   �� *
TongTien+$ TwoWay=�$ PropertyChanged=�6�   �� 5     $��Segoe UI)�6d   $��15(�6z   $
��Bold"�6�   
���  ����6    �� *tongChietKhau+$ PropertyChanged=�6�   5     5     5     5     5     