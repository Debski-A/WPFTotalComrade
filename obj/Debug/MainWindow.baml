   M S B A M L   `   `   `  ����G  CTotalComrade, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TotalComradeTotalComrade  5   	       TotalComrade.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TotalComrade     5   	     � Title$  TOTAL COMRADE V.1.0��5   	   $	��450��6%   $	��800��62   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��8* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   (� $��Stretch=�6   $��0��60   $��2��6=   $��Stretch=�6Q   .��5      �� $
��Bold"�6   
���  ��TOTAL COMRADE5      5      R� 5   
   -   5         R�Name$ 
FolderView��5      $��1��6E   $��0��6R   ��6'   �� *Items+��5      �� 5       �� 
TargetType" Q�6   .�5      ��  �� Property �@Q�
IsExpanded �� Value 63   �� *
IsExpanded+ �� Mode$ TwoWay=��� 5       �@Q�
IsSelected 63   �� *
IsSelected+5      ��5!      �� 5"       �� ItemsSource 6+   �� *
Children+.R�5#      �� 	 �� Orientation$	 
Horizontal=�6!   .+�5$      �� $��40��6    $��3q�6+   ��5%   %   �� *	ImageName+)   #TotalComrade.HeaderToImageConverter
   Instance �� 	Converter# Z
 �� 5'      $��Center=�6$   ��6?   �� *Name+5(      5)      5+      &   System.Windows.Controls.DataGrid  5-   
   $��1��6   $��1��6$   .@�5/      �� $��1* �6   �� 50      $��1* �6   �� 51      $��1* �6   �� 52      $��8* �6   (� 54      .��55      �� $	 
Horizontal=�6   $��0��66   .+�56      �� 
Rozmiar:6*   �� 57      2346%   58      59      5:      5<      5=      