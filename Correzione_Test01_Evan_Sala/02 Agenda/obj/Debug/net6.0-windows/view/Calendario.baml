   M S B A M L   `   `   `  ����D  @02 Agenda, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:_02_Agenda.view_02_Agenda.view  5           _02_Agenda.view.Calendario   5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:_02_Agenda.view     5        N� Title$  
Calendario��5
      .��5      �  � ShowGridLines$
 True��6    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $
 True��6    � ColumnDefinitions 5      �� 5      $��2* �6#   60   �� 5      $��* �6#   6/   5      *  $MahApps.Metro.Controls.NumericUpDown  5   
   $��	535,0,0,0q�6!   $��30��64   $	��265��6@   6N   &   System.Windows.Controls.Calendar  5   
   $��0��6   $��0��6#   $��	200,0,0,0q�60   6E   � 5   
   $��
210,30,0,0q�6   $��1��6(   .+�5      �� $��NUOVO��6   $
��bold"�6%   $	��100��67   $��0,0,40,0q�6C   6W   �� 5      $��MODIFICA��6   $
��bold"�6(   $	��100��6:   $��0,0,40,0q�6F   6Z   �� 5      $��ELIMINA��6   $
��bold"�6'   $	��100��69   6G   5      5      5      