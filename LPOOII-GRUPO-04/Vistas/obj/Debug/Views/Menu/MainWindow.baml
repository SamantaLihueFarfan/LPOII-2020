   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	   "    Vistas.Views.Menu.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Vistas     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$
  Menu��5	   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/    � WindowState$ 	Maximized=�6T   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2��65   $��Stretch=�6I   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   	 � Offset$	 0.981Q�65   � 5      $ 	#FF34268A��6#   $	 1Q�65   5      .��5      � .+�5      '  !MaterialDesignThemes.Wpf.PopupBox  
   PlacementMode$
 BottomAndAlignRightEdges=�6*   $��Right=�6S   $��10q�6o   5      5      � 5   
   $��Stretch=�6   $��1��6-   ���	#FF8401CF 5       �� 5!      $��70 �6    �� 5"      $
��326* �6    .+�5$      � $��0��6   
�������.+�5%      �� $��../../Assets/logo.png��6   5&      �� 5'      $��Stretch=�6   $��Disabled=�69   $
��Auto=�6b   $��1��6�   ��5(      �� 5)      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5*      � $ 	#FF2281D1��6'   � 5+      $ 	#FF322A8C��6'   $	 1Q�69   5,      .��5.      �� -   5         ��Name$
 Menu��5.      $��10q�6+   5/      50      �� 51   
   -   5        $ StackPanelMain��51      $��1��6-   $��1��6:   $��Stretch=�6J   ���	#FFCFCCCC6h   52      53      