   M S B A M L   `   `   `  ����G  CWPF_TodoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF_TodoListWPF_TodoList  5   	       WPF_TodoList.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF_TodoList     5   	     � Title$  Todo App��5   	   $	��450��6   $	��400��6'    � 
ResizeMode$ NoResize=�63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��10 �6   �� 5      $��75 �6   �� 5      $��10 �6   �� 5      $��50 �6   �� 5      $��10 �6   .+�5   
   �� -   5        $��5��5      $��1��6   $��Create TODO��6.   6D   �� 5   
   -   5         ��Name$ 	TodoInput��5      $��3��6%   $��1��62   
���   �
�������6V   �� 5   
   $��1��6   $��1��6$   $
��Auto=�64   .��5      �� -   5        $��TodoList��5      ���	#FF3F403F6B   5      5      5      