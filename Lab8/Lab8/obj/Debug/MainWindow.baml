   M S B A M L   `   `   `  ����?  ;Lab8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab8Lab8  5   	       Lab8.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab8     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��0* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��110* �6   �� 5      $
��300* �6   .+�5   
   �� -   5        $��
Book_Title��5      $��0��6$   $
��Left=�64   $��23��6O   $��	10,36,0,0q�6[   $��1��6n    �� TextWrapping$
 Wrap=�6{   $	��Top=�6�   $	��186��6�   �� 5   
   -   5        $��Book_Author��5      $��0��6%   $
��Left=�65   $��23��6P   $��	11,90,0,0q�6\   $��1��6o   $
 Wrap=�6|   $	��Top=�6�   $	��185��6�   �� 5   
   -   5        $��
Insert_btn��5   "   $��Incert��6   $��0��64   $
��Left=�6D   $��
11,136,0,0q�6_   $	��Top=�6s   $��85��6�   $��20��6�   $��1��6�   �� 5   
   -   5        $��
Delete_btn��5   "   $��Delete��6   $��0��64   $
��Left=�6D   $��111,136,0,0q�6_   $	��Top=�6t   $��85��6�   $��20��6�   $��2��6�   �� 5   
   $��Title��6   $��0��6    $
��Left=�60   $��	10,10,0,0q�6K   $��1��6^   $	��Top=�6k   $��26��6�   $��32��6�   �� 5   
   $��Author��6   $��0��6!   $
��Left=�61   $��	10,64,0,0q�6L   $��1��6_   $	��Top=�6l   $��26��6�   $��47��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Output��5   v      AutoGenerateColumns .  $��0,0,0,0q�6H   $��1��6Y   $��1��6i   ��6   ��    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$ 25 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6H     5"      $ Title��6?   $	 265 6N    6%   �� *Title+6N     5#      $ Author��6@   $	 265 6P    6%   �� *Author+6P   5%      5&      5(      