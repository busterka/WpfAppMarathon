   M S B A M L   `   `   `  ����I  EWpfAppMarathon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.UserControl5WpfAppMarathon.Pages.AdminPages.UserPages.UserControl  5      K    EWpfAppMarathon.Pages.AdminPages.UserPages.UserControl.ControlUserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.UserControl     5      -   5          N� Title$  ControlUserPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��150 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $7��1Управление пользователями��6   $��2��64   $��30(�6H   $��Center=�6V   �� 5   
   -   5         ��Name$ 
AddNewUser��5      $/��)Добавить пользователя��6%   $��1��6E   $��50��6R   $	��171��6^   $
��Left=�6j   $��	0,50,0,50q�6�   �� 5   
   $��1��6   $��1��6"   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� $"��Фильтр по ролям��6   $��15(�62   $	��250��6@   �� 5      -   5        $��	RoleCombo��5   '   $	��150��6    �� DisplayMemberPath$ RoleName��68   ��6U   �� *RoleOptions+5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� $!��Сортировать по��6   $��15(�61   $	��250��6?   �� 5      -   5        $��	SortCombo��5   '   $	��150��6   6'   5       �� 5!      $ 
Horizontal=�6   $��Right=�62   .+�5"      �� $��
Поиск��6   $��15(�6(   $	��250��66   �� 5#      -   5        $��	SearchTXB��5#   &   $	��150��6   6&   5$      �� 5%      -   5        $ 	UpdateBtn��5%      $��Обновить��6(   $	��135��6;   $��30��6G   $��10q�6S   6_   5&      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ DGUser��5(   b   $��2��6   $��2��6       AutoGenerateColumns .     
IsReadOnly . ��6r   �� *
UserView+	   Columns	 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *	FirstName+6P     5+      $
 Фамилия��6%   $ * 6S    66   �� *
LastName+6S     5,      $
 Email��6%   $ * 6N    64   �� *Email+6N     5-      $
 Роль��6%   $ * 6U    63   �� *Role.RoleName+6U   4  .System.Windows.Controls.DataGridTemplateColumn  5.      $ 60 6)      CellTemplate 5/      �� 50      .R�51      �� $ 
EditButton��6%   -   5        $��EditBtn��51   9   6K   52      54      56      57      58      