   M S B A M L   `   `   `  ����N  JCuentarrevoluciones, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CuentarrevolucionesCuentarrevoluciones  5   	   $    Cuentarrevoluciones.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Cuentarrevoluciones     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.Pressed.Background  Button.Pressed.Border  BaseButtonStyle �� 
TargetType �� 
TargetType	 ��Name
 ��Name �� Triggers P� Property P� Value �� 
TargetName  RepeatButtonStyle1 �� BasedOn  FocusVisual1 	 Button.Static.Background1 
 Button.Static.Border1   Button.MouseOver.Background1  Button.MouseOver.Border  Button.Pressed.Background1  Button.Pressed.Border1  BaseButtonStyle1  RepeatButtonStyle2��%�
  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    7   7  7  &	 Q    7  &	 �    &		 \    &	
     &	 �    &	 �    &	 �    &	     &	 .    7  7 	 7 
 &	 &	    7  '�� �	    �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   " ��6(   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5        � ��$ 1q�6(   �� 5!       � �� 5"      �� 5#      " ��6&   .R�5$      �� $	 border��6!   #��z��61   #��z��6[   #��z��6�    . ._�5%      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5&       5'      P� 5(       �@��IsDefaulted . . �5)   "   �� $ border��6@   # � ��6T    � ��5*      P� 5+       � {� .  5,      5.      50      51      �� 52   
   8   " ��6V   .�53      ��  �@��IsPressAndHoldEnabled .  6=   54      �� 55   
   .�56      ��  � �� 57      �� 58      .R�59      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5:      5<      5=      �� 5>   
   $ 	#FFDDDDDD��6<   �� 5?   
   $ 	#FF707070��68   �� 5@   
   $ 	#FFBEE6FD��6?   �� 5A   
   $ 	#FF3C7FB1��6:   �� 5B   
   $ 	#FFC4E5F6��6=   �� 5C   
   $ 	#FF2C628B��69   �� 5D   
   " ��6)   .�5E      ��  �@�FocusVisualStyle8   61   �� 5F       � ��8  6+   �� 5G       � ��8  6,   �� 5H       � ��# � ��6+   �� 5I       � ��$ 1q�60   �� 5J       � ��$ Center=�6;   �� 5K       � ��$ Center=�69   �� 5L       � ��$ 1q�6(   �� 5M       � �� 5N      �� 5O      " ��6&   .R�5P      �� $	 border��6!   #��z��61   #��z��6[   #��z��6�    . ._�5Q      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5R       5S      P� 5T       �@��IsDefaulted . . �5U   "   �� $ border��6@   # � ��6T    � ��5V      P� 5W       � {� .  5X      5Z      5\      5]      �� 5^   
   8   " ��6W   .�5_      ��  �@��IsPressAndHoldEnabled .  6=   5`      �� 5a   
   " ��6   .�5b      ��  �@��SelectedIndex$ 0��6.   5c      5d      .��5f      �  5g   
     
acelerador �� ImageSource j� Stretch 	 freno��%�   &	       &	 K     �� 5h      $ placa-del-acelerador.png��6,   $ UniformToFill=�6S   �� 5i      $ 	freno.png��6'   $ UniformToFill=�6?   5j      .+�5k   
   � .+�5l      �� -   5         ��Name$ button_Acelerar��5l      #���  64   $��414,335,301,0q�5m      #��[ 5n       �� Interval$ 50��5o       �� Delay$ 0��5p      {�.  6   �� 5r      -   5        $ button_Freno��5r      #���  61   $��336,335,386,0q�5s      #��[ 5t      $ 50��5u      $ 0��5v      {�.  6-   �� 5w      $��
274,36,0,0q�6   $��/tacometro-sinfondo.png��6(   $
��Fill=�6I   $
��Left=�6X   $	��287��6s   $	��181��6   $	��Top=�6�   �� 5x      -   5         ��Name$ 
img_flecha��5x      $��
359,94,0,0q�6(   $��/flecha-izquierda.png��6<   $
��Fill=�6[    J� RenderTransformOrigin$ 0.959,0.487&�6j   $
��Left=�6�   $��62��6�   $��65��6�   $	��Top=�6�   z�5y      V� 5z      .~�5{      �� �� 5|      �� 5}      -   5        
rotaFlecha�� �� Angle$ -43.991Q�5}   >   T� 5~       T� X$ -1.344Q�6-    T� Y$
 1.75Q�68   5      5�      �� 5�      
���   �$
��Left=�6%   $��40��6@   $��360,235,0,0q�6L   
���   �$	��Top=�6p   $	��108��6�   �� 5�      -   5         ��Name$ label_Revoluciones��5�      $��0��60   ���	#9BC1EED5$��Center=�6S   $��Center=�6w   $
��Left=�6�   $��367,239,0,0q�6�   $	��Top=�6�   $ -0.052,0.03&�6�   $��32��6  $��94��6  �� 5�      -   5        $ img_strat_stop��5�      $��/boton_apagado.png��6,   $
��Left=�6H   $��72��6c   $��597,122,0,0q�6o   $	��Top=�6�   $��80��6�   $
��Fill=�6�   �� 5�      -   5         ��Name$ desplegable_cv��5�      $
��Left=�6/   $��
99,253,0,0q�6J   $	��Top=�6^   $	��120��6v   .@�5�      �� $��50 CV��6   �� 5�      $��100 CV��6   �� 5�      $��150 CV��6   5�      �� 5�      -   5         ��Name$ progreso��5�      $
��Left=�6*   $��4��6E   $	��196��6Y   $��
216,28,0,0q�6f   $	��Top=�6{   $��53��6�   ��5�      �� 5�       �� EndPoint$ 	0.5, 0.75&�6*    �� 
StartPoint$ 0.5,0&�6?   .��5�      �  � Color$	 Red��6'     � Offset$  0Q�63   � 5�      $ GreenYellow��6'   $  1Q�6;   5�      ��5�      �� 5�      $ 	0.5, 0.75&�6*   $ 0.5, 0&�6?   .��5�      � $	 Red��6'   $  0Q�63   � 5�      $ GreenYellow��6'   $  1Q�6;   5�      ! J� OpacityMask! 5�      �� 5�      -	   5        opacityMask��$
 1, 3&�5�   ?   $
 1, 1&�6O   .��5�      � $ Transparent��6'   $  0Q�6;   � 5�      $ Black��6'   $  0.0001Q�65   5�      5�      5�      5�      5�      