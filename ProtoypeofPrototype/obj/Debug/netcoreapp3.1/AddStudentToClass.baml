   M S B A M L   `   `   `  ����N  JProtoypeofPrototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProtoypeofPrototypeProtoypeofPrototype  5   	   +    %ProtoypeofPrototype.AddStudentToClass   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ProtoypeofPrototype     5   	     � Title$  	COSC 9001��5   	   $	��500��6   $	��400��6)   .��5	      � .+�5
   
   � $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��235* �6    �� 5      $
��229* �6     � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      $��80 �6#   �� 5      $��* �6#   .+�5      �� $��1��6   $��2��6&   $��	5,235,0,0q�66   $��2��6I   �� 5      -   5         ��Name$ lstNames��5   #   $��1��6   $��2��67   �� 5      -   5        $ stuID��5   3   $��1��6   $��1��6#   $��2��6B   �� 5      -   5         ��Name$ 
stuNameBox��5      $��2��6*   $
��Left=�6:   $��21��6U   $��0,25,0,0q�6a   $��2��6s   $�� ��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��140��6�   �� 5      -   5        $ stuIDBox��5      $��2��6(   $
��Left=�68   $��22��6S   $��0,78,0,0q�6_   $��2��6q   $�� ��6�   $
 Wrap=�6�   $	��Top=�6�   $	��140��6�   �� 5      $��Student Name��6   $��2��6+   $
��Left=�6;   $��25��6V   $��2��6b   $	��Top=�6s   $	��140��6�   �� 5      $��
Student ID��6   $��2��6)   $
��Left=�69   $��32��6T   $��0,46,0,0q�6`   $��2��6r   $	��Top=�6�   $	��140��6�   �� 5      $��2��6   $
��Left=�6)   $��77��6D   $��	5,118,0,0q�6P   $��2��6c   $	��Top=�6t   $	��136��6�   .+�5      �� -   5         ��Name$ ButtonAddName_Click��5      $��Add Student��66   $��27��6L   $	��136��6X   6d   5      5!      5"      5#      