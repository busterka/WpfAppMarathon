   M S B A M L   `   `   `  ����I  EWpfAppMarathon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.UserControl5WpfAppMarathon.Pages.AdminPages.UserPages.UserControl  5      G    AWpfAppMarathon.Pages.AdminPages.UserPages.UserControl.AddUserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.UserControl     5        N� Title$  AddUserPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $3��-Добавление пользователя��6   $��30(�62   $��2��6@   $��Center=�6T   �� 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�5      �� $��Email��6   $��18(�6(   �� 5      -   5         ��Name$ EmailTxb��5      $	��150��6,   $
��42 0q�68   5      �� 5      $ 
Horizontal=�6   $��5q�62   .+�5      �� $��Имя��6   $��18(�6&   �� 5      -   5        $ NameTxb��5      $	��150��6+   $
��50 0q�67   5       �� 5!      $ 
Horizontal=�6   $��5q�62   .+�5"      �� $��Фамилия��6   $��18(�6*   �� 5#      -   5        $ LastNameTxb��5#      $	��150��6/   $
��11 0q�6;   5$      �� 5%      $ 
Horizontal=�6   $��5q�62   .+�5&      �� $��Роль��6   $��18(�6'   �� 5'      -   5         ��Name$ RoleCmb��5'      $	��150��6,   $
��46 0q�68    �� DisplayMemberPath$ RoleName��6F    �� Text 6c   �� *
RoleName+5(      5)      �� 5*   
   $��1��6   $��1��6#   .+�5+      �� $��Новый пароль��6   $��25(�6+   $��Center=�69   �� 5,      $ 
Horizontal=�6   $��Right=�62   .+�5-      �� $��Пароль��6   $��15(�6)   G� 5.      -   5         G�Name$ Pass1��5.      $	��150��6-   $	��5 0q�69   5/      �� 50      $ 
Horizontal=�6   $��Right=�62   .+�51      �� $%��Повторите пароль��6   $��15(�63   G� 52      -   5        $ Pass2��52      $	��150��6-   $	��5 0q�69   53      54      �� 55   
   $ 
Horizontal=�6   $��Center=�6.   $��2��6K   $��2��6X   .+�56      �� -   5        	 ��Name$	 SaveBtn��56      $��Сохранить��6&   $��50��6:   $��10q�6F   $	��153��6h   �� 57      -   5        $	 	CancelBtn��57      $��Отмена��6(   $��50��69   $��10q�6E   $	��161��6i   58      59      5:      