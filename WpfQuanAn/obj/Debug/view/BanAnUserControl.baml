   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5      %    WpfQuanAn.view.BanAnUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfQuanAn.view     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          >�Name$  BanAnUC��5
         BanAnVM � DataContext# [  5        MaterialDesignBody#���  5      $��Regular"�5      $��15(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedCommand+   CommandParameter 5   $   �� 	 �� ElementName$	 BanAnUC��5      .��5      � -   5        
 �Name$
 
gridParent��5       � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   �� 5       $
��auto �6   6,   .+�5#   
   � $��0��6   .+�5$      � .+�5%      �� -   5        $��50��5%   ]   $��
 50 10 0 0q�6h   ��6   Z� ��6/   Z� .��5&      �� $��../Assets/logo.png��6   $��25��68   $��40��6D   5'      �� 5(      $��ĂN VẶT BEN BEN��6   $��
 50 10 0 0q�61   $
��Bold"�6E   
����  �6W   5*      #  MaterialDesignThemes.Wpf.Card  5+      $��Right=�6"   $��70 0 0 0q�6>   .��5,      � .+�5-      �� $��../Assets/drink.png��6   $��20��69   $��	0 10 10 0q�6E   �� 5.      $��Bàn đang phục vụ��6   $��	0 10 10 0q�67   6L   �� 5/      $��	0 10 10 0q�6;   
����  ���6    �� *	BanPhucVu+6b   50      51      52      � 54   
   $��1��6   .+�55      �� -   5         ��Name$ ic��55      $
��Left=�6u   ��6"   �� *	ListBan+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���56      �� 57      .R�58      � 59      ��5;      �� 5<      .R�5=      � .+�5>      ��  ��Name$ ic��6�   -   5        $	��190��5>   %   $��50��61   $��15 15 15 15q�6=   ��6R   �� *	tinhtrang+  
convertMau �� 	Converter# [ .��5?   "   � .+�5@   &   �� ��6,   �� *	tinhtrang+  
ConvertImg# [ �� 5A   &   $��	15 10 0 0q�6G   $
��Bold"�6Z   ��6,   �� *tenban+6n   5B   #   5C      5D      5E      5G      5f      5h      5i      