   M S B A M L   `   `   `  ����C  ?KursTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KursTestKursTest  5   	       KursTest.PageChat   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:KursTest     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	    N� Title$ Window1��5   	   $
��auto��6   $
��auto��6'   .��5      � $	��627��6   $	��408��6   $
��auto��6*   $
��auto��68   ��5   
   �� 5       �� ImageSource$ bin/Debug/chat.jpg��6   .+�5   
   �� -   5         ��Name$ tbSend��5      $
��Left=�6"   $��87��6=   $��
10,293,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��407��6�   
������� �� SelectionBrush �	#FF00FFF3���	#FF00FFDC���	#84000000$��20(�6�   	 �� 	MaxLength$	 70��6>  
 �� MinLines$
 3��6M  " �� VerticalScrollBarVisibility$
 Auto=�6Z  �� 5   
   -   5         ��Name$ butExit_ChatPage��5      $��
Выход��6+   $��
504,46,0,0q�6;   $��32��6O   $
��Left=�6[   $	��101��6v   $	��Top=�6�   ���	#FF000717���	#FF8ADCFA$
��-2,4q�6�   ���	#FF00FFF36�   �� 5   
   -   5        $ btSend��5      $��Оправить��6!   $
��Left=�64   $��322,385,0,0q�6O   $	��Top=�6d   $��95��6|   $��35��6�    J� RenderTransformOrigin$ 	-0.31,1.3&�6�   ���	#FF8ADCFA���	#FF000717���	#FF00FFF36�   �� 5   
   $��
13,0,0,193q�6   $
 Wrap=�6&   $ 0.5,0.5&�6:   $
��Left=�6Z   $	��458��6u   ���	#87000000$��Bottom=�6�   $	��209��6�   .��6�    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 36Q�6   .��5      z�5      V� 5      .~�5      �� �� 5      �� 5        �� Angle$ 0.127Q�6&   T� 5!      5"      .��5#   '   5$      �� 5%   
   -   5        $ tbChat��5%      $
��Left=�6"   $	��222��6=   $
 Wrap=�6J   $	��Top=�6_   $	��462��6w   ���	#FF00F3FF
�������$��	10,46,0,0q�6�   $��22(�6�   $��Adobe Hebrew)�6   $��2��6   �� 
IsReadOnly . ��6�   Z�  �� TextDecorations 6�   Z� 6.  �� 5&   
   -   5        $ tbCount��5&      $
��Left=�6#   $��45��6>   $��417,293,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $��55��6�   
����������	#84000000���	#FF00FFDC �	#FF00FFF3 . 6�   5(      5)      