   M S B A M L   `   `   `  ����C  ?KursTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Kursavaya	Kursavaya  5   	       KursTest.PageAdmin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Kursavaya     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	    N� Title$ 
MainWindow��5   	   $
��auto��6   $
��auto��6*   .��5      � $	��627��6   $	��408��6   $
��auto��6*   $
��auto��68    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��627��6,   �� 5      $
��Auto �6   ��5   
   �� 5       �� ImageSource$ bin/Debug/admin2.jpg��6   .+�5   
   �� -   5         ��Name$ btLoadUsers��5      $8��2    Загрузить 
пользователей��6&   $
��Left=�6Q   $��
10,333,0,0q�6l   $	��Top=�6�   $	��143��6�   $��44��6�   $��Center=�6�   $��Center=�6�   ���	#FFB70000���	#FF08C1FF
�������6=  �� 5   
   -   5        $ btDel��5      $3��-     Удалить
 пользователя��6    $
��Left=�6I   $��243,333,0,0q�6d   $	��Top=�6y   $	��139��6�   $��44��6�   ���	#FFB70000
����������	#FF08C1FF6�   �� 5   
   -   5         ��Name$ tbInfo��5      $
��Left=�6"   $��29��6=   $��
243,21,0,0q�6I   	 �� TextWrapping$
	 Wrap=�6]   $	��Top=�6q   $	��201��6�   
�������
���  ��
 �� 
IsReadOnly
 . ��6�   Z� 6�   �� 5   
   -   5        $��
Выход��5      $
��Left=�6!   $��
504,10,0,0q�6<   $	��Top=�6P   $��97��6h   
���  ��$��16(�6�   $
��Bold"�6�   ��6�   Z� ��6�   Z� 6�   �� 5   
   -   5        $ tbViewMessages��5      $
��Left=�6*   $	��106��6E   $��243,222,0,0q�6R   $
	 Wrap=�6g   $	��Top=�6|   $	��201��6�   
 . 
���  ��
���������6�   Z� 6�   �� 5   
   -   5         ��Name$ lbtest��5      $
��Left=�6"   $	��263��6=   $��	10,65,0,0q�6J   $	��Top=�6]   $	��199��6u   
���������6�   Z� �� 5   
   $��№               Login��6   $
��Left=�60   $��	10,33,0,0q�6K   $	��Top=�6^   $	��199��6v   
���  ��6�   5"      5#      