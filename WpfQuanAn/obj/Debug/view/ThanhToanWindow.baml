   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5   	   $    WpfQuanAn.view.ThanhToanWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfQuanAn.view     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          �Name$  WDThanhToan��5	   	    � WindowStyle$
 None=�5   
    � Title$ Thanh Toan Bill��5   	   $	��330��6!   $	��300��6.      	banHangVM � DataContext# [  5   	     MaterialDesignBody#���  5      $��Regular"�5      $��15(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      ��  �� CornerRadius$ 20��6   ���	#FFADDFED
����  �$��0q�6I   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      6"   .+�5      � $��0��6    5      �� 5       $
��50px �6$   64   �� 5!      6&   �� 5"      6&   �� 5#      6&   �� 5$      6&   �� 5%      6&   .+�5'      � $��0��6   ���	#FF9CB0FE.+�5(      �� $��THANH TOÁN BILL��6    $
��Bold"�67   $��	60,18,0,0q�6J   6`   5)      � 5*      $��1��6   .+�5+      �� $��5q�6   $��Tổng Tiền:��6'   ���	#FFA70707$
��Bold"�6S   ��6e   Z� 6~   �� 5,      $��5q�6   $
��Bold"�6x   ��6(   �� *
TongTien+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   5-      � 5/      $��Center=�6   $��2��67   .+�50      �� $��5q�6   $��Tổng Chiết Khấu:��6'   ���	#FFA70707$
��Bold"�6Y   6n   �� 51      $��5q�6   $
��Bold"�6|   ��6'   �� *tongChietKhau+$	 TwoWay=�$
 PropertyChanged=�6�   52      � 54      $��3��6   .+�55      �� $��5q�6   $��Thành Tiền:��6'   
���  ��$
��Bold"�6N   6c   �� 56      $��5q�6   $
��Bold"�6x   ��6'   �� *	thanhTien+$	 TwoWay=�$
 PropertyChanged=�6�   57      � 59      $��Center=�6   $��4��67   .+�5:      �� $��0,5,0,0q�6   $��Tiền Khách Đưa:��6-   ���	#FFA70707$
��Bold"�6^   6s   �� 5;      $��Center=�6   $	��160��6C   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tiền Khách Đưa��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ���	#FFF2E6E6��6O   �� *tienKhachDua+$
 PropertyChanged=�$	 TwoWay=�.��6!  .  (System.Windows.Interactivity.Interaction   Triggers 5<      /  )System.Windows.Interactivity.EventTrigger  5=         	EventName$ TextChanged��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 5>   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *TextChangedCommand+5?      .��5@   2   5A      5B      � 5E      $��Center=�6   $��5��67   .+�5F      �� $��5q�6   $��Tiền Trả Khách:��6'   ���	#FFA70707$
��Bold"�6X   ��6j   Z� 6�   �� 5G      $��5q�6    ��6+   �� *
tienTraLai+$	 TwoWay=�$
 PropertyChanged=�6y   5H      5K      � 5L      $��1��6   $
��auto��6    $��18q�6.    � ColumnDefinitions 5M      �� 5N      �� 5O      .+�5Q      �� $	��Top=�6   $��Segoe UI)�6�   $��15(�6�   $
��Bold"�6�   
����������	#FF5656F6$��In Bill��6�     MaterialDesignShadowDepth2 J� Effect# [ 6  $��5q�6;  $��0��6F  ��61   �� *ComfirmThanhToanCommand+��6]   ��  �� ElementName$ WDThanhToan��6X  �� 5R      $	��Top=�6   $��Segoe UI)�6�   $��15(�6�   $
��Bold"�6�   
����������	#FF7373F6$��Cancel��6�   # [ 6�   $��5q�60  $��1��6;  ��61   �� *ICommandCancel+��6T   �� $ WDThanhToan��6M  5T      5U      5V      5W      