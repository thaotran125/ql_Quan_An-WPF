   M S B A M L   `   `   `  ����D  @WpfQuanAn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfQuanAn.viewWpfQuanAn.view  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   
   M IWpfPageTransitions, Version=1.0.0.1, Culture=neutral, PublicKeyToken=nullS<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitionsWpfPageTransitions 5   	   !    WpfQuanAn.view.SignUpWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfQuanAn.view     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      3system&clr-namespace:System;assembly=mscorlib  5   
   b	 ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      RpageTransitions<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitions 	 5   	   -   5          �Name$  SignupWindown��5   	   $	��550��5   
   $	��350��6    � WindowStyle$
 None=�5
   
      	accountVM � DataContext# [  5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5   	     MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � .+�5   
   � .+�5      �� $	��500��6   $��Center=�6%   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ #ffffff��6'   � 5      $
 Blue��6'   	 � Offset$	 1Q�64   5      5"      �� 5$      $	��280��6   
�������  MaterialDesignShadowDepth5
 J� Effect#
 �  61    �� RadiusX$ 13.667��6g    �� RadiusY$ 13.667��6x   $��32,110,31.333,40.667q�6�   �� 5%      $��../Assets/account.png��6   $��90��63   $��90��6>   $��	0,0,0,300q�6J     MaterialDesignShadowDepth3#
 �  6]   � 5&      $	��280��6   $
��auto��6   $	��Top=�6-   $��35,104,35,0q�6E   .+�5'      �� $��SIGNUP��6   $	��top=�6*   $��Center=�6B   $��50q�6_   $
��Bold"�6k   $��20(�6}   ���#3333996�   �� 5(      $��Center=�6   $��	15,0,15,0q�68   $
��auto��6K   .+�5)      �� 
���  ��$��10(�6F   $��5q�6T   $��30��6_   ��6   �� *mess+6n   �� 5*      ) 	 #MaterialDesignThemes.Wpf.HintAssist   Hint$ UserNmae��6j    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *
userName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   G� 5+      -   5         G�Name$ PassWordBox��5+   "   $ Password��67    ) %MaterialDesignFloatingHintPasswordBox#��[ 6a   .  (System.Windows.Interactivity.Interaction   Triggers 5,      /  )System.Windows.Interactivity.EventTrigger  5-         	EventName$ PasswordChanged��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 5.   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *PasswordChangedCommand+   CommandParameter 5/   $   ��  �� ElementName$ PassWordBox��50      52      G� 53      -   5        $ ConfirmPassWordBox��53   "   $ Confirm Password��6>   #��[ 6p    54        55      $ PasswordChanged��6-   . 56   "      68   �� *ComfirmPasswordChangedCommand+ 57   $   �� $ ConfirmPassWordBox��58      5:      �� 5;       �� DisplayMemberPath$ tennv��6�    �� SelectedValuePath$
 idnv��6�   $ 	Full Name��6�    & "MaterialDesignFloatingHintComboBox#��[ 6�   ��6   �� *ListNV+ �� SelectedItem 6>   �� *SelectedItemNV+$ TwoWay=�$ PropertyChanged=�64  � 5<      $��37��6    .+�5=      ��    MaterialDesignAccentCheckBox#��[ 6D    d� 	IsChecked 6#   �� *
IsSelected+6|   �� 5>      $��IS Admin��6    $��50��63   $
��Left=�6>   $��	10,0,20,0q�6Y   6n   5?      5A      � 5B      .+�5C      �� $	��Top=�6w   $��Sign up��6�   $��30,320,40,0q�6�   $��37��6�    	 MaterialDesignShadowDepth2#
 � 	 6�   
�������$
��Bold"�6  ���	#FF5656F6��6   �� *ICommandSingup+��6@   �� $ SignupWindown��6  �� 5D      $	��Top=�6w   $��Cancel��6�   $��10,320,40,0q�6�   $��37��6�   #
 � 	 6�   
�������$
��Bold"�6  ���	#FF5656F6��6   �� *ICommandCancel+��6@   �� $ SignupWindown��6  5F      5G      5I      5J      5K      