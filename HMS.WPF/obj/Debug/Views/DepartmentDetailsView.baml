   M S B A M L   `   `   `  ����B  >HMS.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HMS.WPF.ViewsHMS.WPF.Views  5      U QSystem.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 6�   )    #HMS.WPF.Views.DepartmentDetailsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:HMS.WPF.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  68   9system,clr-namespace:System;assembly=System.Runtime  6�   .��5
      �  
  GreyBG#��[  6   .+�5   
   �� $��2��6   $��4��6+   .��5      �   � ColumnDefinitions  5      �� 5      �� 5       � RowDefinitions 5      �� 5      $��70 �6$   �� 5      $��70 �6$   �� 5      $��* �6$   .+�5      �� $��0��6   $��0��6-   .+�5      �� $��24(�6A     DetailsInfoTitle#��[ 6O     PrimaryColor#��[ 6y   ��6!   �� *DepartmentName+6y   5      �� 5      $��0��6   $��1��6-   .+�5      �� $��	Head Name��6    #��[ 61   �� 5      #��[ 6;   $��15 0 0 0q�6f   #��[ 6x   ��6    �� *
HeadName+6x   5      �� 5!      $��1��6   $��0��6-    �� Orientation$ 
Horizontal=�6:   $��Right=�6S   .+�5"      �� )  #MaterialDesignThemes.Wpf.DialogHost   DialogClosingAttached ClearEditDepartment6     DetailsButton#��[ 6c   $��15 0 0 0q�6�      OpenDialogCommand#��Z 6�   .��6�   EDIT��5#      �� 5$      .+�5%   "   �� $��16q�6-   .+�5&   &   �� -   5         ��Name$ DepartmentNameTextBox��5&   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Department Name��6S    % !MaterialDesignFloatingHintTextBox#��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6/   �� *EditDepartmentName+6�   �� 5'   &   -   5         ��Name$ 
validation��5'   s     ErrorMsg#��[ 6Q   ��61   �� *textValidation+6s   5(   #   �� 5)   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5*   &   ��   MaterialDesignFlatButton#��[ 6-    �� 	IsDefault . $��0 8 8 0q�5,   -   ��5-   -   �� *EditDepartment+��5.   *   ��5/   .   True��6C   .��50   C   Edit52   '   �� 53   &   #��[ 6-   	 �� IsCancel	 . $��0 8 0 0q�55   -   $2��,materialDesign:DialogHost.CloseDialogCommand��56   -   ��57   *   ��58   .   	False��6D   .��59   C   CANCEL5;   '   5<   #   5=      5?      �� 5@      #��[ 6   $��	15 0 40 0q�6E   ��6X   �� *DeleteDepartment+.��6}   DELETE5B      5C      �� 5F      $��0��6   $��2��6-   .+�5H        -   5        $��addDoctorDialog��5H   0   $
��Left=�6H   $��15 0 0 0q�6c   $��Center=�6u   .��5I      ��   DetailsDialogHostBorder#��[ 6!   ._�5J      �   5K   "   �� 5L   &   $
��170* �67   �� 5M   &   $	��64* �67   �� 5N   &   $	��21* �67    5P   "   �� 5Q   &   $	��205 �64   �� 5R   &   $
��Auto �64   .+�5T   "   �� -   5        
 ��Name$
 DoctorsList��5T   �   
�������#��[ 6a   $��3��6�   ��6*   �� *DoctorsList+5U   #   (  "MaterialDesignThemes.Wpf.ColorZone  5V   "   $��2��6;   
����d�  MaterialDesignShadowDepth5 J� Effect# �  6d   $��3��6�   .��5W   &   �� 
�������$��16q�6a   ��60   �� *DoctorsCount+6a   5X   #   5Y      5Z      5[        5]      $
��Left=�61   $��
15 15 0 30q�6L   $	��Top=�6`   .��5^      �� $��Bottom=�6!   #��[ 6<   ._�5_      �  5`   "   �� 5a   &   $	��205 �64   �� 5b   &   $
��Auto �64   .+�5d   "   �� -   5        $
 PatientList��5d   �   
�������#��[ 6c   ��6+   �� *PatientsList+6�     5e   "   ���#0e263e$��1��6P   # �  6]   .��5f   &   �� 
�������$��16q�6b   ��60   �� *PatientsCount+6b   5g   #   5h      5i      5j      5k      �� 5m      $��1��6   $��2��6-   .+�5n        $
��Left=�61   $��15 0 0 0q�6L   $��Center=�6^   .��5o      �� #��[ 6!   ._�5p      �  5q   "   �� 5r   &   $	��205 �64   �� 5s   &   $
��Auto �64   .+�5u   "   �� -   5        $
 
NursesList��5u   �   
�������#��[ 6`   ��6*   �� *
NursesList+6�     5v   "   
����d�$��1��6W   # �  6d   .��5w   &   �� 
�������$��16q�6`   ��60   �� *NursesCount+6`   5x   #   5z      5{      5|      5}      5      5�      5�      5�      