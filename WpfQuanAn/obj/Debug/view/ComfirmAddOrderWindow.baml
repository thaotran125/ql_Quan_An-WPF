   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5   	   *    $WpfQuanAn.view.ComfirmAddOrderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfQuanAn.view     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   -   5          �Name$  
ConfirmAdd��5	   
      	banHangVM � DataContext# [  5   	    � WindowStyle$
 None=�5       � Title$ DelAccountComfirm��5   
   $	��350��6$   $	��500��61     MaterialDesignBody#���  5      $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5   
     MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase	   Actions.	 5      6  0System.Windows.Interactivity.InvokeCommandAction  
   Command
 6$   �� *LoadedAddOrderCommand+   CommandParameter 5   $   ��  �� ElementName$ 
ConfirmAdd��5      .��5      ��  �� CornerRadius$ 30��6   
����  �$��1q�63   ._�5    
   �  � RowDefinitions 5!      �� 5"      $
��50px �6    60   �� 5#      $
��auto �6    60   �� 5$      6"   .+�5'      � $��0��6   
����  �.+�5(      �� $��Confirm Delete Food��6   $��	60,18,0,0q�68   $
��Bold"�6K   6_   5)      � 5+      $��1��6   .+�5,      � $��50,20,20,20q�6   .+�5.      �� $��10q�6j   $	��300��6v   $
��Bold"�6�   
����  ���6   �� *	tenfood+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5/      -   5         ��Name$ txtSL��5/      $��Center=�6-   $	��250��6Q   $��5q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Số Lượng Order��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6]   �� *
slOrderAdd+$ PropertyChanged=�$ TwoWay=�.��6"   50        51      $ TextChanged��6-   .	 52   "     
 68   �� *TextChangedSLCommand+ 53   8   �� $ txtSL��54      .��55   2   56      �� 57      ��6   Z� ��63   Z� ��6J   �� *
CommandTru+.��58      �� $��/Assets/minus.png��6    59      �� 5:      ��6   Z� ��63   Z� ��6J   �� *CommandCong+.��5;      �� $��/Assets/add.png��6    5<      5=      5>      � 5?      $��2��6   .+�5@      � $��	 0 40 0 0q�6   .+�5A      �� $	��Top=�6{   $��OK��6�   $	��100��6�   $��	90 0 70 0q�6�   
�������$
��Bold"�6�   ���	#FF5656F6��6   �� *ComfirmAddFoodCommand+��6G   �� $ 
ConfirmAdd��6�   �� 5B      $	��Top=�6t   $��Cancel��6�   $	��100��6�     MaterialDesignShadowDepth2 J� Effect# �  6�   
�������$
��Bold"�6�   ���	#FF7373F6��6   �� *ICommandCancel+��6@   �� $ 
ConfirmAdd��6  5D      5E      5F      5G      5H      