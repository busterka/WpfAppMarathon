   M S B A M L   `   `   `  ����I  EWpfAppMarathon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.UserControl5WpfAppMarathon.Pages.AdminPages.UserPages.UserControl  5      H    BWpfAppMarathon.Pages.AdminPages.UserPages.UserControl.UserEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.UserControl     5        N� Title$  UserEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $;��5Редактирование пользователя��6   $��30(�66   $��2��6D   $��Center=�6X   �� 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�5      �� $��Email��6   $��18(�6(   �� 5      $
��50 0q�68   $��15(�6F   ��6   �� *
Curr.Email+6F   5      �� 5      $ 
Horizontal=�6   $��5q�62   .+�5      �� $��Имя��6   $��18(�6&   �� 5      -   5         ��Name$ NameTxb��5      $	��150��6K   $
��50 0q�6W   ��6+   �� *Curr.FirstName+6e   5       �� 5!      $ 
Horizontal=�6   $��5q�62   .+�5"      �� $��Фамилия��6   $��18(�6*   �� 5#      -   5        $ LastNameTxb��5#      $	��150��6N   $
��11 0q�6Z   ��6/   �� *Curr.LastName+6Z   5$      �� 5%      $ 
Horizontal=�6   $��5q�62   .+�5&      �� $��Роль��6   $��18(�6'   �� 5'      -   5         ��Name$ RoleCmb��5'      $	��150��6,   $
��46 0q�68    �� DisplayMemberPath$ RoleName��6F    �� Text 6c   �� *Curr.Role.RoleName+5(      5)      �� 5*   
   $��1��6   $��1��6#   .+�5+      �� $��Смена пароля��6   $��25(�6+   $��Center=�69   �� 5,      $
��Wrap=�6   $���~Оставьте эти поля, незаполненными, если вы не хотите изменять пароль.��6-   
�������$��40��6�   $	��264��6�   �� 5-      $ 
Horizontal=�6   $��Right=�62   .+�5.      �� $��Пароль��6   $��15(�6)   G� 5/      -   5         G�Name$ Pass1��5/      $	��150��6-   $	��5 0q�69   50      �� 51      $ 
Horizontal=�6   $��Right=�62   .+�52      �� $%��Повторите пароль��6   $��15(�63   G� 53      -   5        $ Pass2��53      $	��150��6-   $	��5 0q�69   54      55      �� 56   
   $ 
Horizontal=�6   $��Center=�6.   $��2��6K   $��2��6X   .+�57      �� -   5        	 ��Name$	 SaveBtn��57      $��Сохранить��6&   $��50��6:   $��10q�6F   $	��178��6h   �� 58      -   5        $	 	CancelBtn��58      $��Отмена��6(   $��50��69   $��10q�6E   $	��174��6i   59      5:      5;      