   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   
   M IWpfPageTransitions, Version=1.0.0.1, Culture=neutral, PublicKeyToken=nullS<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitionsWpfPageTransitions 5   	        WpfQuanAn.view.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfQuanAn.view     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   3system&clr-namespace:System;assembly=mscorlib  5   
   b	 ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      RpageTransitions<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitions 	 5   	   -   5        $��loginWindow��5   	     � Title$  LoginWD��5	   	   $	��500��6   $	��350��6&      LoginVM � DataContext# [  5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5   	     MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedWindowCommand+	   CommandParameter	 5   $   �� 
 �� ElementName$
 loginWindow��5      .��5      � .+�5   
   �� $	��500��6   $��Center=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5       �  � Color$ #ffffff��6#   � 5!      $
 Blue��6#    � Offset$ 1Q�60   5"      5&      �� 5(   
   $	��280��6   $	��300��6    
�������  MaterialDesignShadowDepth5 J� Effect# �  6:    �� RadiusX$ 13.667��6p    �� RadiusY$ 13.667��6�   5*      �� 5+   
   $��../Assets/login.png��6   $��90��6-   $��90��68   $��	0,0,0,300q�6D     MaterialDesignShadowDepth3# �  6W   � 5,   
   $	��280��6   $	��288��6   $	��Top=�6(   $��35,104,35,0q�6@   .+�5-      �� $��LOGIN��6   $	��top=�6%   $��Center=�6=   $��50q�6Z   $
��Bold"�6f   $��20(�6x   ���#3333996�   �� 5.      $��Center=�6Q   $��	15,0,15,0q�6l   $	��100��6    +� FocusedElement 6   �� $	
 Box��.+�5/      �� 
���  ��$��10(�6B   ��6   �� *mess+6S   �� 50      -   5        $	��Box��50      ) 	 #MaterialDesignThemes.Wpf.HintAssist   Hint$ useName��6?    % !MaterialDesignFloatingHintTextBox#��[ 6h   $��37��6�   ��6%   �� *
userName+6�   G� 51      -   5         G�Name$ FloatingPasswordBox��51      $ PassWord��52   "    ) %MaterialDesignFloatingHintPasswordBox#��[ 53   "   $��37��6a    54        55      $ PasswordChanged��6)   . 56         64   �� *PasswordChangedCommand+	 57   $   �� $
 FloatingPasswordBox��58      5:      5;      � 5<      .+�5=      ��  �� 	IsDefault . $	��Top=�6�   $��Login��6�   $��40,229,40,0q�6�   $��37��6�     MaterialDesignShadowDepth2# �  6�   
�������$
��Bold"�6  ���	#FF5656F6��6   �� *ICommandlogin+��6;   �� $
 loginWindow��6%  �� 5>      $	��Top=�6q   $��Cancel��6�   $��10,229,40,0q�6�   $��37��6�   # �  6�   
�������$
��Bold"�6  ���	#FF5656F6��6   �� *ICommandCancel+��6<   �� $
 loginWindow��6  5?      5A      5B      5C      