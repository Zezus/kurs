   M S B A M L   `   `   `  ����C  ?KursTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Kursavaya	Kursavaya  5   	       KursTest.RemindPassword   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Kursavaya     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	    N� Title$ 
MainWindow��5   	   $
��auto��6   $
��auto��6*   .��5      � -   5        $��t��5      $	��627��6   $	��408��6#   $
��auto��63   $
��auto��6A    � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      $	��43* �6   ��5   
   �� 5       �� ImageSource$ bin/Debug/remind.jpg��6   .+�5   
   �� $D��>Введите логин для восстановления ��6   $
��Left=�6<   $��272,371,0,0q�6W   $	��Top=�6l   $	��213��6�   �� 5   
   -   5         ��Name$ tbLogin��5      $
��Left=�6#   $��37��6>   $��	13,18,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��213��6�   $��1��6�   �� 5   
   -   5        	 ��Name$
	 btOK��5      $��Получить
 код��6   $
��Left=�6@   $��	27,60,0,0q�6[   $	��Top=�6n   $	��134��6�   $��1��6�   $��54��6�   �� 5   
   -   5        $ tbKod��5      $
��Left=�6!   $��37��6<   $��
13,182,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   $��1��6�   �� 5   
   -   5        $	 
btKodEnter��5      $��Отправить код��6%   $
��Left=�6=   $��
13,242,0,0q�6X   $	��Top=�6l   $	��134��6�   $��1��6�   �� 5   
   -   5        $ tbPas��5      $
��Left=�6!   $��33��6<   $��452,114,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��147��6�   $��1��6�   
 �� 	MaxLength$
 16��6�   �� 5   
   -   5         ��Name$ LabKod��5      $��введите код��6    $
��Left=�66   $��
13,149,0,0q�6Q   $	��Top=�6e   $	��120��6}   $��1��6�   �� 5    
   -   5        $ 	LabNewPas��5       $,��&введите новый пароль��6#   $
��Left=�6B   $��
455,84,0,0q�6]   $	��Top=�6q   $	��147��6�   $��1��6�   �� 5!   
   -	   5        $ 	LabRepPas��5!      $%��повторите пароль��6#   $
��Left=�6>   $��452,146,0,0q�6Y   $	��Top=�6n   $	��147��6�   $��1��6�   �� 5"   
   -
   5        $ tbRepPas��5"      $
��Left=�6$   $��33��6?   $��452,178,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��147��6�   $��1��6�   $
 16��6�   �� 5#   
   -   5        $	 btChangePas��5#      $��Применить��6&   $
��Left=�6:   $��455,225,0,0q�6U   $	��Top=�6j   $��92��6�   $��1��6�   �� 5$   
   -   5        $��
Выход��5$      $
��Left=�6!   $��
507,30,0,0q�6<   $	��Top=�6P   $��75��6h   6s   5&      5'      