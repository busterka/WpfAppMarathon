   M S B A M L   `   `   `  ����  WpfAppMarathonO    IWpfAppMarathon.Pages.AdminPages.UserPages.RunnerControl.ControlRunnerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ControlRunnerPage��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6!   $+��%Управление бегунами��65   $��Center=�6P   $��10q�6m   $��18(�6y   �� 5   
   $��1��6   $��0��6    $2��,Сортировка и фильтрация��60   $��10q�6Q   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�66   .+�5      �� $��Статус:��6    $��70��6/   �� 5      $	��150��6    �� DisplayMemberPath$ .��6�   ��6+   �� *StatusOptions+ �� SelectedValue 6Q   �� *SelectedStatus+ �� Mode$ TwoWay=�6�   5       �� 5!      $ 
Horizontal=�6   $��5q�66   .+�5"      �� $��Дистанция:��6    $��70��62   �� 5#      $	��150��6   $ .��6�   ��6+   �� *DistanceOptions+ 6S   �� *SelectedDistance+$ TwoWay=�6�   5$      �� 5%      $ 
Horizontal=�6   $��5q�66   .+�5&      �� $��Сортировать:��6    $��70��64   �� 5'      $	��150��6   ��6+   �� *SortOptions+�� 5(      $��Обновить��6   $��5,0,0,0q�60   5)      5*      5+      �� 5-   
   $��1��6   $��1��6    $��Выгрузка��60   $��10q�6B   .��5.      �� .+�5/      �� -   5        $3��-Детальной информация (CSV)��5/      $��5q�6>   6I   �� 50      $��E-mail список��6   $��5q�61   51      52      �� 54   
   $��2��6   $��2��6!   $��Total runners: 123��65   $��Center=�6O   $��10q�6l   &   System.Windows.Controls.DataGrid  56   
   -   5        $��DGRunner��56   n   $��4��6   $��2��6       AutoGenerateColumns .     
IsReadOnly . $��10q�6b   ��6~   �� *
RunnerView+	   Columns	 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Runner.User.FirstName+6\     59      $
 Фамилия��6%   $ * 6_    66   �� *Runner.User.LastName+6_     5:      $
 Email��6%   $ * 6Z    64   �� *Runner.User.Email+6Z     5;      $
 Статус��6%   $ * 6c    65   �� *RegistrationStatus.Status+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5<      $
  ��6)   $ 75 63      CellTemplate 5=      �� 5>      .R�5?      ��  ��Name$ BTNEdit��6%   -   5        $
��edit��5?   6   6E   5@      5B      5D      5G      5H      