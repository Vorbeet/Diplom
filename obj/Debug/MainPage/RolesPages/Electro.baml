   M S B A M L   `   `   `  ����E  ADiplomnaya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Diplomnaya.MainPage.RolesPagesDiplomnaya.MainPage.RolesPages  5      ,    &Diplomnaya.MainPage.RolesPages.Electro   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Diplomnaya.MainPage.RolesPages     5        N� Title$  Electro��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $	��670 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $
��0 10q�6;   .+�5      �� $��	Students:��6   $��24(�6(   $
��10 0q�66   ���	#FFF1F1F2$��DemiBold"�6[   �� 5      -   5        $��cb_students��5       �� DisplayMemberPath$ 	NameGroup��6Z   $��24(�6x   $��Center=�6�   $
��10 0q�6�   $	��250��6�   ���#064b66$��DemiBold"�6�   5      5      �� 5   
   -   5        $��	BtnOtchet��5      $��
Отчет��6:   $��0��6J   $��10q�6W   $��Right=�6c   $	��200��6   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DGridStudents��5         AutoGenerateColumns .     
IsReadOnly . $��1��6V   $
��20 0q�6c   $��2q�6q   $��22(�6�   $��
ExtraLight"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6K   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *Name+6K     5      $ Фамилия��6%   $
 auto 6R   	 66   �� *	Surname+6R     5      $ Отчество��6%   $
 auto 6V   	 67   �� *
Patronymic+6V     5      $ Дата рождения��6%   $
 auto 6f   	 6<   �� *Birth+
 �� StringFormat$
 d��6f     5      $% Место проживания��6%   $
 auto 6]   	 6?   �� *	Residence+6]     5      $! Место прописки��6%   $ * 6X   	 6=   �� *Adress+6X     5      $ Паспорт��6%   $ * 6S   	 66   �� *
Passport+6S     5       $! Номер телефона��6%   $ * 6[   	 6=   �� *	Telephone+6[     5!      $ Статус��6%   $ * 6P   	 65   �� *Status+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $	 220 6)      CellTemplate 5#      �� 5$      .R�5%      �� $��BtnEdit��6P   -   5        $��Информация��5%   %   
�������
����������#67a3db6�   5&      5(      5*      �� 5+   
   $ 
Horizontal=�6   $��2��6/   $��Center=�6=   $��Center=�6Z   .+�5,      o� .@�5-      �� $��Поиск:��6   �� 5.      -   5        $��TBoxSearch1��5.   2   $	��400��6   $��35��6&   $��22(�6l   $��DemiBold"�6z   5/      50      �� 51   
   -   5        $��BtnAdd��51      $��Добавить��64   $��2��6G   $
��Left=�6T   $	��200��6o   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   �� 52   
   -   5        $��BtnDel��52      $��Удалить��64   $��2��6F   $��Right=�6S   $	��200��6o   
�������
����������#67a3db$��28(�6�   $��DemiBold"�6�   53      54      