   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          �Name$  Главная��5   	    � Title$ 
MainWindow��5   	   $	��400��6   $	��615��6)   $	��620��65   $	��400��6D   $	��620��6T   $	��400��6c   .��5	      ��  �� Orientation$ 
Horizontal=�6   $��Center=�6*   .+�5
   
   �� -   5         ��Name$ dg��5
      $	��408��6   ��6+   ��  �� Path$ DataList� �� View 5      �� 5      .P�5      ��  �� Width$	 132��6%   $��Имя��6_    �� DisplayMemberBinding 61   �� $
 name�6_   �� 5      $	 132��6%   $��Фамилия��6a    61   �� $ surname�6a   �� 5      $	 132��6%   $��Зачетка��6`    61   �� $ number�6`   5      5      � 5   
   $	��210��6   .+�5      �� -   5         ��Name$
 name��5      $��Center=�6$   $��0,99,0,0q�6A   	 �� TextWrapping$
	 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5      -   5        $ surname��5      $��Center=�6'   $��	0,174,0,0q�6D   $
	 Wrap=�6W   $	��Top=�6k   $	��120��6�   �� 5      -   5        $ number��5      $��Center=�6&   $��	0,240,0,0q�6C   $
	 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5      $��Имя��6   $
��Left=�6"   $��	45,73,0,0q�6=   $	��Top=�6P   �� 5      $��Фамилия��6   $
��Left=�6&   $��
45,143,0,0q�6A   $	��Top=�6U   �� 5      $��Номер зачетки��6   $
��Left=�6,   $��
45,209,0,0q�6G   $	��Top=�6[   �� 5      -   5        $��Добавить��5      $��Center=�6(   $��	0,287,0,0q�6E   $	��Top=�6X   $��25��6p   $��76��6|   6�   5      5      5      