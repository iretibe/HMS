   M S B A M L   `   `   `  ����B  >HMS.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HMS.WPF.ViewsHMS.WPF.Views  5      U QSystem.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 68   #    HMS.WPF.Views.RoomDetailsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:HMS.WPF.Views     5      ?system,clr-namespace:System;assembly=System.Runtime     68   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6t   .��5
      �  
  GreyBG#��[  6   .+�5   
   �   � ColumnDefinitions  5      �� 5      �� 5       � RowDefinitions 5      �� 5      $��70 �6    �� 5      $	��120 �6    �� 5      $��* �6    .+�5      �� $��0��6   $��0��6)   .+�5      �� $��30(�69     DetailsInfoTitle#��[ 6G     PrimaryColor#��[ 6q   ��6   �� *
RoomNumber+6q   �� 5      #��[ 66   $��15 0 0 0q�6`   ��6   �� *
RoomType+6`   5      �� 5      $��1��6   $��0��6)    �� Orientation$ 
Horizontal=�66   $��Right=�6O   .+�5      �� )  #MaterialDesignThemes.Wpf.DialogHost   DialogClosingAttached ClearEditRoom6     DetailsButton#��[ 6Y   $��15 0 0 0q�6�      OpenDialogCommand#��Z 6�   .��6�   Edit��5      �� 5      .+�5      �� $��16q�6)   .+�5   "   �� -   5         ��Name$ RoomNumberTextBox��5   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Room Number��6M    % !MaterialDesignFloatingHintTextBox#��[ 6{   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6*   �� *editedRoomNumber+6�   �� 5    "   -   5         ��Name$ 
validation��5    o     ErrorMsg#��[ 6M   ��6-   �� *textValidation+6o   5!      �� 5"      $ 
Horizontal=�6)   $��Center=�6B   .+�5#   "   ��   MaterialDesignFlatButton#��[ 6)    �� 	IsDefault . $��0 8 8 0q�5%   %   ��5&   %   �� *
EditRoom+��5'   &   ��5(   *   True��6?   .��5)   ?   EDIT5+   #   �� 5,   "   #��[ 6)   	 �� IsCancel	 . $��0 8 0 0q�5.   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5/   )   ��50   &   ��51   *   	False��6@   .��52   ?   CANCEL54   #   55      56      58      �� 59      #��[ 6   $��	15 0 40 0q�6A   ��6T   �� *
DeleteRoom+.��6s   Delete5;      5<      �� 5=      $��0��6   $��1��6)   $��	0 15 0 0 q�66   .+�5>      �� $��
Room Price��6   #��[ 6.   �� 5?        DetailsInfoValue#��[ 67   ��6   �� *	roomPrice+67   5@      �� 5A      $��1��6   $��1��6'   $��0 15 0 0q�67   .+�5B      �� $��Room Capacity��6   #��[ 61   �� 5C      #��[ 6;   ��6   �� *roomCapacity+6;   5D      �� 5E      $��0��6   $��4��6)   .+�5F        $
��Left=�6-   $��	15 40 0 0q�6H   $��Center=�6[   .��5G      ��   DetailsDialogHostBorder#��[ 6   ._�5H      �  5I      �� 5J   "   $��* �60   �� 5K   "   $
��Auto �60   .+�5M      �� -   5        
 ��Name$
 PatientsList��5P   d    �� DisplayMemberPath$ Value��5N   &    �� SelectedValuePath$	 Key��5O   &   
�������#��[ 5P   9   ��5M   &   �� *PatientsList+5P   |   (  "MaterialDesignThemes.Wpf.ColorZone  5Q      
����d�$��1��6S    	 MaterialDesignShadowDepth5 J� Effect# � 	 6`   .��5R   "   �� 
�������$��16q�6_   ��6,   �� *PatientsNumber+6_   5S      5T      5U      5V      5W      �� 5X      $��1��6   $��4��6)   .+�5Y        $
��Left=�6-   $��Center=�6H   $��	15 40 0 0q�6c   .��5Z      �� #��[ 6   ._�5[      �  5\      �� 5]   "   $��* �60   �� 5^   "   $
��Auto �60   .+�5`      �� -   5        $
 
NursesList��5e   d   $ Value��5a   &   $	 Key��5c   &   
�������#��[ 5e   9   ��5`   &   �� *
NursesList+ �� SelectedItem 5b   &   �� *ListSelectedNurse+5e   z     5f      
����d�$��1��6S   # � 	 6`   .��5g   "   �� 
�������$��16q�6]   ��6,   �� *NursesNumber+6]   5h      �� 5i       0
 ,MaterialDesignFloatingActionMiniAccentButton#��[
 6%   #��Z 5j   !   $��Bottom=�5k   !   $��Right=�6<   $��0��5l   !   $��
0 0 28 -20q�6.   $��0q�5m   !   
������ +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5o   !   #��[ 5p   !   ��5q   "   �� 5r   &   $��16q�61   .+�5s   *   �� -   5         ��Name$ NursesComboBoxItems��5u   e   $ Nurses Names��5s   `    & "MaterialDesignFloatingHintComboBox#��[ 5t   +   $��0 8 0 0q�5u   -   $
��Left=�6>   $	��200��6Y   $ Value��5v   -   $	 Key��5w   1   ��5s   3   �� *NursesComboBoxItems+ 5x   *   �� *NurseSelectedItem+5y   +   �� 5z   *   $ 
Horizontal=�65   $��Center=�6N   .+�5{   .   �� #��[ 65    . $��0 8 8 0q�5}   1   ��5~   0   �� *assignNurse+��5   2   ��5�   6   True��6K   .��5�   K   ADD5�   /   �� 5�   .   #��[ 65   	 . $��0 8 8 0q�5�   1   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   1   ��5�   2   ��5�   6   	False��6L   .��5�   K   CANCEL5�   /   5�   +   5�   '   .��5�   "   (� $��22��6*   $��22��65   .��5�   &   �� $��24��6-   $��24��68   .+�5�   *   F� |������!@]� �@]� @]� �@]� ��!��ا ��!��ا @]� �@KL @]� �@KL �ا ��ا �ا ��ا @KL �@]� @KL �@]� �ا ���!�ا ���!@]� 	��6`   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType$ ButtonL� �� Path$ 
Foreground�5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      