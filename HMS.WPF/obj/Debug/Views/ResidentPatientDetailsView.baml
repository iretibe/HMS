   M S B A M L   `   `   `  ����B  >HMS.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HMS.WPF.ViewsHMS.WPF.Views  5      U QSystem.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 6�   .    (HMS.WPF.Views.ResidentPatientDetailsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:HMS.WPF.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  68   9system,clr-namespace:System;assembly=System.Runtime  6�   .��5
      �  
  GreyBG#��[  6   .+�5   
   �� $��2��6   $��5��6+   .��5      �   � ColumnDefinitions  5      �� 5      �� 5       � RowDefinitions 5      �� 5      $��70 �6$   �� 5      $��70 �6$   �� 5      $��70 �6$   �� 5      $��70 �6$   �� 5      $��* �6$   .+�5      �� $��0��6   $��0��6*   .+�5      �� $��24(�6>     DetailsInfoTitle#��[ 6L     PrimaryColor#��[ 6v   ��6!   �� *PatientName+6v   �� 5      #��[ 6>   $��15 0 0 0q�6h   ��6    �� *PatientType+6h   5      �� 5      $��2��6   $��0��6-    �� Orientation$ 
Horizontal=�6:   $��Right=�6S   .+�5      �� )  #MaterialDesignThemes.Wpf.DialogHost   DialogClosingAttached ClearEditResident6      OpenDialogCommand#��Z 6a     DetailsButton#��[ 6�   $��	15,19,0,0q�6�   $	��Top=�6�   .��6�   EDIT��5      �� 5       .+�5!   "   �� $��16q�6-   .+�5"   &   �� -   5         ��Name$ PatientNameTextBox��5"   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Patient Name��6V    % !MaterialDesignFloatingHintTextBox#��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6.   �� *EditPatientNameTextBox+6�   �� 5#   &   -   5        $ PatientAddressTextBox��5#      $ Patient Address��6Y   #��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6.   �� *EditPatientAddressTextBox+6   (  "System.Windows.Controls.DatePicker  5$   &   -   5          Name$! PatientBirthDatetDatePicker��5$     $ Patient BirthDate��6e    ( $MaterialDesignFloatingHintDatePicker#��[ 6�   $��0 15 0 0q�6�   $
��Left=�6�   $	��200��6     SelectedDate 61   �� *EditPatientBirthDatePicker+6  �� 5%   &   -   5        $ PatientDiagnosisTextBox��5%     $ Patient Diagnosis��6[   #��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��6.   �� *EditPatientDiagnosisTextBox+6  �� 5&   &   -   5        	 ��Name$	 PatientRoomNumberComboBox��50   4   
 �� 
IsEditable
 . $ Patient Room Number��5(   4    & "MaterialDesignFloatingHintComboBox#��[ 5)   4   $��0 8 0 0q�5*   4    �� DisplayMemberPath$ Value��5+   4    �� SelectedValuePath$	 Key��5,   4   $
��Left=�5-   4   $	��200��5.   4    �� SelectedItem 5&   0   �� *EditRoomNumberComboBox+��5/   4   �� *PatientRoomNumberComboBox+50   4   �� 51   &   -   5        $	 PatientDepartmentComboBox��5<   %   $ Patient Department��52   %   $ Value��55   %   $	 Key��56   %   
 . #��[ 58   7   $��0 8 0 0q�59   %   $
��Left=�5:   %   $	��200��5;   %   ��53   %   �� *EditDepartmentComboBox+ �� Text 54   %   �� *SetEditDepartmentComboBox+ 57   %   �� *EditPatientDepartment+5<   %   �� 5=   &   -   5         ��Name$ 
validation��5=   s     ErrorMsg#��[ 6Q   ��61   �� *textValidation+6s   �� 5?   &   $ 
Horizontal=�61   $��Center=�6J   .+�5@   *   ��   MaterialDesignFlatButton#��[ 61   $��Bottom=�5A   1   $
��left=�5B   1    �� 	IsDefault . $��0 8 0 0q�5D   1   ��5E   1   �� *editResidentPatient+��5G   .   ��5H   2   True��6G   .��5I   G   SUBMIT5K   +   �� 5L   *   #��[ 61    �� IsCancel . $��Bottom=�5N   5   $��0 8 8 0q�5O   5   $2��,materialDesign:DialogHost.CloseDialogCommand��5P   5   ��5Q   .   ��5R   2   	False��6H   .��5S   G   CANCEL5U   +   5V   '   5W   #   5X      5Z      �� 5[      #��[ 5\      $��	15 0 50 0q�5^      ��5]      �� *deleteResidentPatient+.��5^   -   DELETE5`      5a      �� 5b      $��1��6   $��0��6*   .+�5c      �� $��Address��6    #��[ 6/   �� 5d       	 DetailsInfoValue#��[	 6@   ��6    �� *PatientAddress+6@   5e      �� 5f      $��1��6   $��1��6+   .+�5g      �� $��	BirthDate��6    #��[ 61   �� 5h      #��[	 6B   ��6    �� *PatientBirthDate+6B   5i      �� 5j      $��0��6   $��2��6-   .+�5k      �� $��	Diagnosis��6!   #��[ 62   �� 5l      #��[	 6B   ��6    �� *PatientDiagnosis+6B   5m      �� 5n      $��1��6   $��2��6-   .+�5o      �� $��Room Number��6!   #��[ 64   �� 5p      #��[	 6C   ��6    �� *PatientRoomNumber+6C   5q      �� 5r      $��0��6   $��3��6-   .+�5s      �� $
��Bill��6!   #��[ 6-   �� 5t      #��[	 6=   ��6    �� *PatientBill+6=   5u      �� 5v      $��1��6   $��3��6-   .+�5w      �� $��
Department��6!   #��[ 63   �� 5x      #��[	 6C   ��6    �� *PatientDepartment+6C   5y      �� 5{      $ Vertical=�6   $��0��64   $��4��6D   .+�5|        $
��Left=�61   $��15 0 0 0q�6L   $��Center=�6^   .��5}      ��  
 DetailsDialogHostBorder#��[
 6"   ._�5~      �  5   "   �� 5�   &   $��* �64   �� 5�   &   $
��Auto �64   .+�5�   "   �� -   5         ��Name$ DoctorsList��5�   %   
�������#��[ 5�   %   $ Value��5�   %   $	 Key��5�   %   ��5�   %   �� *DoctorsList+ 5�   %   �� *ListSelectedDoctor+5�   %   (  "MaterialDesignThemes.Wpf.ColorZone  5�   "   
����d�$��1��6W     MaterialDesignShadowDepth5 J� Effect# �  6d   .��5�   &   �� 
�������$��16q�6b   ��60   �� *DoctorsNumber+6b   5�   #   �� 5�   "    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6)   #��Z 5�   )   $��Bottom=�5�   )   $��Right=�6D   $��0��5�   )   $��
0 0 28 -20q�66   $��0q�5�   )   
������ +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5�   )   #��[ 5�   )   ��5�   &   �� 5�   *   $��16q�65   .+�5�   .   �� -	   5        $	 DoctorsComboBox��5�   5   
 . $ 
Add Doctor��5�   5   #��[ 5�   5   $��0 8 0 0q�5�   5   $
��Left=�5�   5   $	��200��5�   5   $ Value��5�   5   $	 Key��5�   5    5�   5   �� *DoctorComboBox+��5�   5   �� *DoctorsComboBox+5�   5   �� 5�   .   $ 
Horizontal=�69   $��Right=�6R   .+�5�   2   �� #��[ 69    . $��0 8 8 0q�5�   9   ��5�   9   �� *assignDoctor+��5�   6   ��5�   :   True��6O   .��5�   O   SUBMIT5�   3   �� 5�   2   #��[ 69    . $��0 8 8 0q�5�   =   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   >   ��5�   6   ��5�   :   	False��6P   .��5�   O   CANCEL5�   3   5�   /   5�   +   .��5�   &   (� $��22��6.   $��22��69   .��5�   *   �� $��24��61   $��24��6<   .+�5�   .   F� |������!@]� �@]� @]� �@]� ��!��ا ��!��ا @]� �@KL @]� �@KL �ا ��ا �ا ��ا @KL �@]� @KL �@]� �ا ���!�ا ���!@]� 	��6d   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType$ ButtonL� �� Path$ 
Foreground�5�   +   5�   '   5�   #   5�      5�      5�        5�      $��
15 30 0 15q�61   $
��Left=�6F   $��Center=�6a   .��5�      �� #��[
 6"   ._�5�      �  5�   "   �� 5�   &   $��* �64   �� 5�   &   $
��Auto �64   .+�5�   "   �� -
   5        $ MedicalHistoryList��5�   %   
�������#��[ 5�   %   $ Value��5�   %   $	 Key��5�   %   ��5�   %   �� *MedicalHistoryList+ 5�   %   �� *ListSelectedMedicine+5�   %     5�   "   ���#0e263e$��1��6P   # �  6]   .��5�   &   �� $��Medical History��60   
�������$��16q�6Z   5�   #   �� 5�   "   #��[ 6)   #��Z 5�   )   $��Bottom=�5�   )   $��Right=�6D   $��0��5�   )   $��
0 0 28 -20q�66   $��0q�5�   )   
������ $ Depth0=�5�   )   #��[ 5�   )   ��5�   &   �� 5�   *   $��16q�65   .+�5�   .   �� -   5        $ medicineName��5�   �   $ Medicine Name��6T   #��[ 6�   $��0 8 0 0q�6�   $
��Left=�6�   $	��200��6�   ��66   �� *MedicineName+6�     5�   .   -   5        $ 	StartDate��5�   	  $ Medicine StartDate��6]   #��[ 6�   $��0 15 0 0q�6�   $
��Left=�6�   $	��200��6�      Text 69   �� *MedicineStartDate+6	    5�   .   -   5        $ EndDate��5�     $ Medicine EndDate��6Z   #��[ 6�   $��0 15 0 0q�6�   $
��Left=�6�   $	��200��6�    69   �� *MedicineEndDate+6  �� 5�   .   $ 
Horizontal=�69   $��Right=�6R   .+�5�   2   �� #��[ 69    . $��0 8 8 0q�5�   9   ��5�   9   �� *addMedicine+��5�   6   ��5�   :   True��6O   .��5�   O   SUBMIT5�   3   �� 5�   2   #��[ 69    . $��0 8 8 0q�5�   =   $2��,materialDesign:DialogHost.CloseDialogCommand��5�   =   ��5�   6   ��5�   :   	False��6P   .��5�   O   CANCEL5�   3   5�   /   5�   +   .��5�   &   (� $��22��6.   $��22��69   .��5�   *   �� $��24��61   $��24��6<   .+�5�   .   F� |������!@]� �@]� @]� �@]� ��!��ا ��!��ا @]� �@KL @]� �@KL �ا ��ا �ا ��ا @KL �@]� @KL �@]� �ا ���!�ا ���!@]� 	��6d   ��  �� *FindAncestor+$ ButtonL�$ 
Foreground�5�   +   5�   '   5   #   5     5     5     5     �� 5     $��1��6   $��4��6-   .+�5       $
��Left=�61   $��15 0 0 0q�6L   $��Center=�6^   .��5     �� #��[
 6!   ._�5	     �  5
  "   �� 5  &   $��* �64   �� 5  &   $
��Auto �64   .+�5  "   �� -   5        $ 
NursesList��5  %   
�������#��[ 5  %   $ Value��5  %   $	 Key��5  %   ��5  %   �� *
NursesList+5  %     5  "   
����d�$��1��6W   # �  6d   .��5  &   �� 
�������$��16q�6a   ��60   �� *NursesNumber+6a   5  #   5     5     5     5     5     5     5     5     