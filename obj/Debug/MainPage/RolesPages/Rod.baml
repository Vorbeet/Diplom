   M S B A M L   `   `   `  ����E  ADiplomnaya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Diplomnaya.MainPage.RolesPagesDiplomnaya.MainPage.RolesPages  5      (    "Diplomnaya.MainPage.RolesPages.Rod   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Diplomnaya.MainPage.RolesPages     5        N� Title$	  Rod��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $	��650 �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $
��0 10q�6;   .+�5      �� -   5        $��Mother��5      $��Матери��68   $��10q�6I   $	��200��6U   $��40��6a   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   �� 5      -   5        $��Father��5      $��Отцы��68   $��10q�6G   $	��200��6S   $��40��6_   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   5      �� 5   
   -   5        $��	BtnOtchet��5      $��
Отчет��6:   $��0��6J   $��10q�6W   $��Right=�6c   $	��200��6   $��40��6�   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DGridStudents��5         AutoGenerateColumns .     
IsReadOnly . $��1��6V   $
��20 0q�6c   $��2q�6q   $��22(�6�   $��
ExtraLight"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$1 +Семейный идентификатор��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *id+6\     5      $ Имя��6%   $
 auto 6K    62   �� *Name+6K     5      $ Фамилия��6%   $
 auto 6R    66   �� *	Surname+6R     5      $ Отчество��6%   $
 auto 6V    67   �� *
Patronymic+6V     5      $ Место работы��6%   $
 auto 6S    6;   �� *Job+6S     5      $ Статус��6%   $ * 6P    65   �� *Status+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 220 6)   	   CellTemplate	 5      �� 5       .R�5!      �� $��BtnEdit��6P   -   5        $��Информация��5!   %   
�������
����������#67a3db6�   5"      5$      5&      �� 5'   
   $ 
Horizontal=�6   $��2��6/   $��Center=�6=   $��Center=�6Z   .+�5(      o� .@�5)      �� $��Поиск:��6   �� 5*      -   5        $��TBoxSearch1��5*   2   $	��400��6   $��35��6&   $��22(�6l   $��DemiBold"�6z   5+      5,      �� 5-   
   -   5        $��BtnAdd��5-      $��Добавить��64   $��2��6G   $
��Left=�6T   $	��200��6o   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   �� 5.   
   -   5        $��BtnDel��5.      $��Удалить��64   $��2��6F   $��Right=�6S   $	��200��6o   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   5/      50      