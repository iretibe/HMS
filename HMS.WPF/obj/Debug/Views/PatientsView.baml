   M S B A M L   `   `   `  ����B  >HMS.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HMS.WPF.ViewsHMS.WPF.Views  5      U QSystem.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 6�   C&clr-namespace:HMS.WPF.Views.ComponentsHMS.WPF.Views.Components  6�        HMS.WPF.Views.PatientsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:HMS.WPF.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  68   9system,clr-namespace:System;assembly=System.Runtime  6�   7
Components&clr-namespace:HMS.WPF.Views.Components  6�   .��5
      �  
  GreyBG#��[  6     � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��0��6   
������� � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      � $��0��6   $��20 0 0 0q�6#    5      �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5      �� $��0��6   $��8 0 0 0q�6*   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Type to search��5         HintOpacity$	 0.4Q�5      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5      $��0q�5      $	��200��5       $��Center=�6)     DarkText#��[ 5!      ��5      �� *SearchQuery+ �� UpdateSourceTrigger$ PropertyChanged=�.��5!   A    J� InputBindings 5"      �� 5#      
 �� Key$ Return��6F    �� Command 6%   �� *SearchAction+6F   .��5$   -   5%      �� 5&        MaterialDesignToolButton#���  6   $��1��6m   ��6L   �� *SearchAction+.��5'      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Magnify=�6.   
 J� Opacity$	
 .56Q�6=   5(      5)      �� 5*       �� Orientation$ 
Horizontal=�6   $��2��62   $��Center=�6B   $��0 0 20 0q�6]   .+�5+      ��   	LightText#��[ 6   $��0 0 10 0q�6D   $��Center=�6V   Filter6y   �� 5,      #���  6   $��0q�6L   .��5-        $	 FilterVariant=�6.   #��[ 6C   5.      5/      50      �� 51   
   $��1��6   .��52      � .+�53      �� ��6   �� *FilteredPatients+��54      �� 55      .R�56      *   $HMS.WPF.Views.Components.PatientCard  57      ��59      �� 5:      .R�5;      � $��patientList��6(    � Orientation$ 
Horizontal=�6;   $��Center=�6T   $��0 10 0 0q�6q   5<      5>      5?      5@      �� 5A   
   )  #MaterialDesignThemes.Wpf.DialogHost   DialogClosingAttached& "Sample2_DialogHost_OnDialogClosing5B      $��	0 0 35 20q�5C      $��2��5D        PrimaryColor#��[ 5E      $��0q�5F      
������ +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5H       & "MaterialDesignFloatingActionButton#��[ 5I         OpenDialogCommand#��Z 5J      $��Bottom=�5K      $��Right=�5L      .��5M        $
	 Plus=�6&   ��5N      �� 5O      .+�5P      �� $��16q�6!   .+�5Q      �� -   5         ��Name$ PatientNameTextBox��5Q   �   $ Patient Name��6F    % !MaterialDesignFloatingHintTextBox#��[ 6u   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6"   �� *PatientNameTextBox+6�   �� 5R      -   5        $ PatientAddressTextBox��5R   �   $ Patient Address��6I   #��[ 6{   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6"   �� *PatientAddressTextBox+6�   (  "System.Windows.Controls.DatePicker  5S      -   5          Name$! PatientBirthDatetDatePicker��5S     $ Employee BirthDate��6U    ( $MaterialDesignFloatingHintDatePicker#��[ 6�   $��0 15 0 0q�6�   $
��Left=�6�   $	��200��6�      SelectedDate 6%   �� *PatientBirthDatePicker+6  �� 5T      -   5        $ PatientDiagnosis��5T   �   $ Patient Diagnosis��6K   #��[ 6   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6"   �� *PatientDiagnosisTextBox+6�   �� 5U      -   5         ��Name$ PatientTypeComboBox��5U   �   $ Patient Type��6I    & "MaterialDesignFloatingHintComboBox#��[ 6x   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�    �� Text 6#   �� *PatientTypeComboBox+.@�5V      �� .��6+   Resident Patient6=   �� 5W      .��6+   Appointment Patient6@   5X      �� 5Y      -   5        $��RoomNumberComboBox��5\       �� 
IsEditable . $ Patient Room Number��5^      #��[ 5_      $��0 8 0 0q�6Z   $
��Left=�6k   $	��200��6�    �� DisplayMemberPath$ Value��5a       �� SelectedValuePath$	 Key��5b       �� SelectedItem 5Z      �� *
RoomNumber+y�5[      �� *
IsResident+��5`      �� *ComboBoxItems+5b      �� 5c      -   5        $��PatientDepartmentCombobox��5f       . $ Patient Department��5h      #��[ 5i      $��0 8 0 0q�5j      $
��Left=�6.   $	��200��6J   $ Value��5l      $	 Key��5m       5d      �� *PatientDepartment+y�5e      �� *
IsResident+��5k      �� *PatientDepartmentItems+5m      �� 5n      -   5         ��Name$ 
validation��5n   g    	 ErrorMsg#��[	 6E   ��6%   �� *textValidation+6g   5p      �� 5q      $ 
Horizontal=�6!   $��Center=�6:   .+�5r      ��  
 MaterialDesignFlatButton#��[
 6!   $��Bottom=�5s   %   $
��left=�5t   %    �� 	IsDefault . $��0 8 0 0q�5v   %   ��5w   %   �� *addNewPatient+��5x      ��5y   "   True��67   .��5z   7   SUBMIT5|      �� 5}      #��[
 6!    �� IsCancel . $��0 8 0 0q�5   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   )   ��5�      ��5�   "   	False��68   .��5�   7   CANCEL5�      5�      5�      5�      5�      5�      