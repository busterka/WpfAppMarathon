   M S B A M L   `   `   `  ����I  EWpfAppMarathon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Eclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.RunnerControl7WpfAppMarathon.Pages.AdminPages.UserPages.RunnerControl  5      L    FWpfAppMarathon.Pages.AdminPages.UserPages.RunnerControl.EditRunnerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      WlocalEclr-namespace:WpfAppMarathon.Pages.AdminPages.UserPages.RunnerControl     5        N� Title$  EditRunnerPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��50 �6   .+�5   
   �� $>��8Редактирование профиля бегуна��6   $��Center=�68   $��2��6U   $��30(�6i   �� 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Email��6   �� 5      $
��46 0q�6D   $��25(�6R   ��6   �� *Curr.Runner.User.Email+6R   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Имя��6   �� 5      -   5         ��Name$ TxtName��5      $	��150��6W   $
��50 0q�6c   ��6+   �� *Curr.Runner.User.FirstName+6c   5      �� 5      $ 
Horizontal=�6   .+�5       �� $��Фамилия��6   �� 5!      -   5        $ TxtLName��5!      $	��150��6W   $
��24 0q�6c   ��6,   �� *Curr.Runner.User.LastName+6c   5"      �� 5#      $ 
Horizontal=�6   .+�5$      �� $��Пол��6   �� 5%      -   5        $��	CMBGender��5%      $	��150��6,   $��51.5 0q�68    �� DisplayMemberPath$ Gender��6H    �� Text 6c   �� *Genders.Gender+5&      �� 5'      $ 
Horizontal=�6   .+�5(      �� $��Дата Рождения��6   (  "System.Windows.Controls.DatePicker  5)      -   5        $��DPDate��5)      $	��150��6+   5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� $��Страна��6   �� 5-      -   5         ��Name$ 
CMBCountry��5-      $	��150��6/   $
��35 0q�6;   $ CountryName��6I    6i   �� *!Curr.Runner.Country.CountryName+5.      �� 5/      $1��+Регистрационный статус��6   $��Center=�65   $��25(�6R   �� 50      -   5        $ 	CMBStatus��50      $	��150��6*   $ Status��66    6Q   �� *RegistrationStatus.Status+51      �� 53   
   $��1��6   $��1��6"   .+�54      �� $��80��6   $	��100��6#   
������$��Right=�6B   $
��50 0q�6^   �� 55      .+�56      �� $��Фото файл:��6   $��20(�6-   �� 57      $ 
Horizontal=�6   $��Center=�66   .+�58      �� $	��150��6   $��5q�6*   �� 59      -   5        $��FileBut��59   0   $��Просмотр��6   $��5q�6?   $��30��6J   5:      �� 5;      .+�5<      �� $��Смена пароля��6   $��25(�63   $��Center=�6A   �� 5=      $
��Wrap=�6    $���~Оставьте эти поля, незаполненными, если вы не хотите изменять пароль.��64   $��15(�6�   $��Center=�6�   
�������6�   �� 5>      $ 
Horizontal=�6!   $��Right=�6:   .+�5?      �� $��Пароль��6    $��15(�61   G� 5@      -   5         G�Name$ Pass1��5@   &   $	��150��65   $	��5 0q�6A   5A      �� 5B      $ 
Horizontal=�6!   $��Right=�6:   .+�5C      �� $%��Повторите пароль��6    $��15(�6;   G� 5D      -	   5        $ Pass2��5D   &   $	��150��65   $	��5 0q�6A   5E      5F      5G      5H      �� 5I   
   $ 
Horizontal=�6   $��2��6.   $��2��6;   $��Center=�6O   .+�5J      �� -
   5        	 ��Name$	 SaveBtn��5J      $��Сохранить��6&   $��5q�6:   6E   �� 5K      -   5        $	 	CancelBtn��5K      $��Отмена��6(   $��5q�69   6D   5L      5M      5N      