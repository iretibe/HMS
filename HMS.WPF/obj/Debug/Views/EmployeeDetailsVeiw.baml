   M S B A M L   `   `   `  ����B  >HMS.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HMS.WPF.ViewsHMS.WPF.Views  5      U QSystem.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 6�   '    !HMS.WPF.Views.EmployeeDetailsVeiw   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:HMS.WPF.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  68   9system,clr-namespace:System;assembly=System.Runtime  6�   .��5
      �  
  GreyBG#��[  6   .+�5   
   �   � ColumnDefinitions  5      �� 5      �� 5       � RowDefinitions 5      �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��* �6    .+�5      �� $��0��6   $��0��6)   .+�5      �� $��24(�6;     DetailsInfoTitle#��[ 6I     PrimaryColor#��[ 6s   ��6   �� *EmployeeName+6s   �� 5      #��[ 6;   $��15 0 0 0q�6e   ��6   �� *EmployeeRole+6e   5      �� 5      $��1��6   $��0��6)    �� Orientation$ 
Horizontal=�66   $��Right=�6O   .+�5      ��   DetailsButton#��[ 6   )  #MaterialDesignThemes.Wpf.DialogHost   OpenDialogCommand#��Z 6@   $��15 0 0 0q�6�   .��6�   EDIT��5      �� 5      $��16q�6%   .+�5       �� -   5         ��Name$ EditEmployeeNameTextBox��5    �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Employee Name��6P    % !MaterialDesignFloatingHintTextBox#��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6&   �� *EditEmployeeNameTextBox+6�   �� 5!      -   5        $  EditEmployeeAddressTextBox��5!   �   $ Employee Address��6R   #��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6&   �� *EditEmployeeAddressTextBox+6�   (  "System.Windows.Controls.DatePicker  5"      -   5          Name$! EditEmployeeBirthDatePicker��5"     $ Employee BirthDate��6Y    ( $MaterialDesignFloatingHintDatePicker#��[ 6�   $��0 15 0 0q�6�   $
��Left=�6�   $	��200��6�      SelectedDate 6)   �� *EditEmployeeDatePicker+6  �� 5#      -   5        $ EditEmployeeSalaryTextBox��5#   �   $ Employee salary��6Q   #��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6&   �� *EditEmployeeSalaryTextBox+6�   �� 5$      -   5         ��Name$$ EditEmployeeDepartmentComboBox��5/   !   $ Employee Department��5%   !   	 �� DisplayMemberPath$	 Value��5(   !   
 �� SelectedValuePath$	
 Key��5)   !    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 5+   3   $��0 8 0 0q�5,   !   $
��Left=�5-   !   $	��200��5.   !   ��5&   !   �� *EditDepartmentComboBox+ �� Text 5'   !   �� *SetEditDepartmentComboBox+ �� SelectedItem 5*   !   �� *EditEmployeeDepartment+5/   !   �� 50      -   5        $��isHeadCheckBox��50   :   $��0 8 0 0q�6'   y�6P   �� *
IsDoctor+ d� 	IsChecked 6q   �� *isHeadCheck+.��6�   Department Head6�   �� 51      -   5         ��Name$ 
validation��51   {   $��0 0 0 0q�6(     ErrorMsg#��[ 6Y   ��69   �� *textValidation+6{   �� 53      $ 
Horizontal=�6)   $��Right=�6B   .+�54   "   ��   MaterialDesignFlatButton#��[ 6)    �� 	IsDefault . $��0 8 8 0q�57   %   ��56   %   �� *editEmployee+��58   &   ��59   *   True��6?   .��5:   ?   SUBMIT5<   #   �� 5=   "   #��[ 6)    �� IsCancel . $��0 8 8 0q�5?   %   $2��,materialDesign:DialogHost.CloseDialogCommand��5@   %   ��5A   &   ��5B   *   	False��6@   .��5C   ?   CANCEL5E   #   5F      5G      5I      �� 5J      #��[ 5K      $��	15 0 50 0q�5M      ��5L      �� *deleteEmployee+.��5M   -   DELETE5O      5P      �� 5Q      $��1��6   $��0��6&   .+�5R      �� $��Addres��6   #��[ 6*   �� 5S       	 DetailsInfoValue#��[	 6=   ��6   �� *EmployeeAddress+6=   5T      �� 5U      $��1��6   $��1��6'   .+�5V      �� $��	BirthDate��6   #��[ 6-   �� 5W      #��[	 6?   ��6   �� *EmployeeBirthDate+6?   5X      �� 5Y      $��0��6   $��2��6)   .+�5Z      �� $��
Department��6   #��[ 6.   �� 5[      #��[	 6@   ��6   �� *EmployeeDepartment+6@   5\      �� 5]      $��2��6   $��1��6'   .+�5^      �� $��Employment Date��6   #��[ 63   �� 5_      #��[	 6E   ��6   �� *EmployeeEmploymentDate+6E   5`      �� 5a      $��0��6   $��3��6)   .+�5b      �� $��Salary��6   #��[ 6*   �� 5c      #��[	 6<   ��6   �� *EmployeeSalary+6<   5d      �� 5f      $��0��6   $��4��6)   .+�5g        $
��Left=�6-   $��15 0 0 0q�6H   $��Center=�6Z   .��5h      ��  
 DetailsDialogHostBorder#��[
 6   ._�5i      �  5j      �� 5k   "   $��* �60   �� 5l   "   $
��Auto �60   .+�5n      �� -   5         ��Name$ PatientsList��5s   "   
�������#��[ 5r   "   $	 Value��5t   "   $	
 Key��5u   "   ��5n   &   �� *PatientsList+ 5p   "   �� *ListSelectedPatient+5u   "   (  "MaterialDesignThemes.Wpf.ColorZone  5v      
����d�$��1��6S     MaterialDesignShadowDepth5 J� Effect# �  6`   .��5w   "   �� 
�������$��16q�6_   ��6,   �� *PatientsNumber+6_   5x      �� 5y       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6%   #��Z 5z   !   $��Bottom=�5{   !   $��Right=�6<   $��0��5|   !   $��
0 0 28 -20q�6.   $��0q�5}   !   
������ +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5�   !   #��[ 5�   !   y�5   !   �� *
IsDoctor+��5�   "   �� 5�   &   $��16q�61   .+�5�   *   �� -	   5        $ PatientsComboBox��5�   1   $	 Value��5�   1   $	
 Key��5�   1    . $ Add Patient��5�   1   #��[ 5�   1   $��0 8 0 0q�5�   1   $
��Left=�5�   1   $	��200��5�   1    5�   1   �� *PatientComboBox+��5�   1   �� *PatientsComboBox+5�   1   �� 5�   *   $ 
Horizontal=�65   $��Right=�6N   .+�5�   .   �� #��[ 65    . $��0 8 8 0q�5�   9   ��5�   9   �� *assignPatient+��5�   2   ��5�   6   True��6K   .��5�   K   SUBMIT5�   /   �� 5�   .   #��[ 65    . $��0 8 8 0q�5�   9   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   9   ��5�   2   ��5�   6   	False��6L   .��5�   K   CANCEL5�   /   5�   +   5�   '   .��5�   "   (� $��22��6*   $��22��65   .��5�   &   �� $��24��6-   $��24��68   .+�5�   *   F� |������!@]� �@]� @]� �@]� ��!��ا ��!��ا @]� �@KL @]� �@KL �ا ��ا �ا ��ا @KL �@]� @KL �@]� �ا ���!�ا ���!@]� 	��6`   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType$ ButtonL� �� Path$ 
Foreground�5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�      $��1��6   $��4��6)   .+�5�        $
��Left=�6-   $��Center=�6H   $��15 0 0 0q�6c   .��5�      �� #��[
 6>   y�6   �� *
IsDoctor+._�5�      �  5�      �� 5�   "   $��* �60   �� 5�   "   $
��Auto �60   .+�5�      �� -
   5        $ AppointmentsList��5�   #   
�������#��[ 5�   #   $	 Value��5�   $   $	
 Key��5�   %   ��5�   &   �� *AppointmentsList+5�   %     5�      ���#0e263e$��1��6L   # �  6Y   .��5�   "   �� 
�������$��16q�6c   ��6,   �� *AppointmentsNumber+6c   5�      5�      5�      5�      5�      �� 5�      $��1��6   $��4��6)   .+�5�        $
��Left=�6-   $��Center=�6H   $��15 0 0 0q�6c   .��5�      �� #��[
 6<   y�6   �� *	IsNurse+._�5�      �  5�      �� 5�   "   $��* �60   �� 5�   "   $
��Auto �60   .+�5�      �� -   5        $ 	RoomsList��5�   "   
�������#��[ 5�   "   $	 Value��5�   #   $	
 Key��5�   %   ��5�   &   �� *	RoomsList+ 5�   &   �� *ListSelectedRoom+5�   %     5�      
����d�$��1��6S   # �  6`   .��5�   "   �� 
�������$��16q�6\   ��6,   �� *RoomsNumber+6\   5�      �� 5�      #��[ 6%   #��Z 5�   )   $��Bottom=�5�   )   $��Right=�6D   $��0��5�   )   $��
0 0 28 -20q�66   $��0q�5�   )   
������ $ Depth0=�5�   )   #��[ 5�   )   ��5�   "   �� 5�   &   $��16q�61   .+�5�   *   �� -   5        $ RoomsComboBox��5�   1    . $ Add Room��5�   1   #��[ 5�   1   $��0 8 0 0q�5�   1   $
��Left=�5�   1   $	��200��5�   1   $	 Value��5�   1   $	
 Key��5�   1    5�   1   �� *RoomComboBox+��5�   1   �� *RoomsComboBox+5�   1   �� 5�   *   $ 
Horizontal=�65   $��Right=�6N   .+�5�   .   �� #��[ 65    . $��0 8 8 0q�5�   9   ��5�   9   �� *
assignRoom+��5�   2   ��5�   6   True��6K   .��5�   K   ACCEPT5�   /   �� 5�   .   #��[ 65    . $��0 8 8 0q�5�   9   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   9   ��5�   2   ��5�   6   	False��6L   .��5   K   CANCEL5  /   5  +   5  '   .��5  "   (� $��22��6*   $��22��65   .��5  &   �� $��24��6-   $��24��68   .+�5  *   F� |������!@]� �@]� @]� �@]� ��!��ا ��!��ا @]� �@KL @]� �@KL �ا ��ا �ا ��ا @KL �@]� @KL �@]� �ا ���!�ا ���!@]� 	��6`   ��  �� *FindAncestor+$ ButtonL�$ 
Foreground�5	  '   5
  #   5     5     5     5     5     5     5     5     