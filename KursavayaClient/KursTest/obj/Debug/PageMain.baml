   M S B A M L   `   `   `  ����C  ?KursTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Kursavaya	Kursavaya  5   	       KursTest.PageMain   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Kursavaya     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	    N� Title$ 
MainWindow��5   	   $
��auto��6   $
��auto��6*   .��5      � $	��627��6   $	��408��6   $
��auto��6*   $
��auto��68   ��5   
   �� 5       �� ImageSource$ bin/Debug/lines.jpg��6   .+�5   
   �� -   5         ��Name$ butLogin_MainPage��5      $��
Войти��6,   $��488,247,0,0q�6<   $��34��6Q   $
��Left=�6]   $	��115��6x   $	��Top=�6�   6�   �� 5   
   -   5         ��Name$ LogIn��5      $��
Войти��6   $��
512,58,0,0q�6/   
���  ��$
��Bold"�6j   $��14.667(�6|   $
��Left=�6�   $��79��6�   $��29��6�   $	��Top=�6�   ��6C   Z� ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   � 5      $
 	#FFF72525��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$ tbLogin��5      $��
488,92,0,0q�6#    �� TextWrapping$
 Wrap=�67   ���	#FF080808
���  �� � ToolTip$ Login��6t   $
��Left=�6�   $	��120��6�   $��28��6�   $	��Top=�6�   
������  �� SelectionBrush �	#FF9E241E �� MaxLines$ 1��6   �� 	MaxLength$ 10��6   �� IsUndoEnabled .  6  �� 5    
   -   5        $ label��5       $��Login��6   $��
409,97,0,0q�6/   
���  ��$
��Left=�6T   $��52��6o   $��27��6z   $	��Top=�6�   �� 5!   
   -   5        $ 
label_Copy��5!      $��Password��6$   $��409,143,0,0q�67   
���  ��$
��Left=�6]   $��69��6x   $��27��6�   $	��Top=�6�   �� 5"   
   -   5        $ butRegistr_MainPage��5"      $��Регистрация��6.   $��346,247,0,0q�6D   $��34��6Y   $
��Left=�6e   $	��115��6�   $	��Top=�6�    J� RenderTransformOrigin$ 
0.36,1.155&�6�   �� 5#   
   -   5        $
 tbIP��5#      $��488,188,0,0q�6    $
 Wrap=�65   ���	#FF080808
���  ��$ 	Ip Adress��6r   $
��Left=�6�   $	��120��6�   $��27��6�   $	��Top=�6�    . $ 0.508,0.531&�6�   
������  �	#FF9E241E$��	127.0.0.1��6>  �� 5$   
   -   5        $ label_Copy1��5$      $��IP��6%   $��409,184,0,0q�62   
���  ��$
��Left=�6X   $��52��6s   $��38��6~   $	��Top=�6�   $��14.667(�6�   G� 5%   
   -	   5         G�Name$ 
tbPassword��5%      $��488,143,0,0q�6*   ���	#FF080808
���  ��$ Password��6h   $
��Left=�6{   $	��120��6�   $��27��6�   $	��Top=�6�   
������  G� SelectionBrush �	#FF9E241E G� 	MaxLength$ 16��6�    G� PasswordChar$	 ●��6	  $��12(�6  �� 5&   
   -
   5        $ btRememberPas��5&      $��Забыли пароль��6(   $
��Left=�6@   $��409,301,0,0q�6[   $	��Top=�6p   $	��133��6�   $��32��6�   6�   5)      5*      