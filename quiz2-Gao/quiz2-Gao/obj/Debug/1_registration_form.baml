   M S B A M L   `   `   `  ����D  @quiz2-Gao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:quiz2_Gao	quiz2_Gao  5   	   $    quiz2_Gao._1_registration_form   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:quiz2_Gao     5   	     � Title$  1_registration_form��5   	   $	��350��6%   $	��600��62   .��5	      � 
����ح� � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ lblFirstName��5      $��Right=�6R   $��Center=�5      $��0��6+   
��� � �$
��Bold"�6K    �� Target 5   &   ��  �� ElementName$ txtFirstName��.��5   ]   First Name:6j   �� 5   
   -   5        $ lblLastName��5      $��Right=�6Q   $��Center=�5      $��1��6+   
��� � �$
��Bold"�6K    5   &   �� $ txtLastName��.��5   ]   
Last Name:6i   �� 5   
   -   5        $ lblPhoneNumber��5      $��Right=�6T   $��Center=�5      $��2��6+   
��� � �$
��Bold"�6K    5   )   �� $ txtLastName��.��5   ]   Phone Number:6l   �� 5    
   -   5         ��Name$ txtFirstName��5       $
��Left=�6(   $��23��6C   $	��120��5!      $��0��6   $��1��6+   6=   �� 5"   
   -   5        $ txtLastName��5"      $
��Left=�6'   $��23��6B   $	��120��5#      $��1��6   $��1��6+   6=   �� 5$   
   -   5        $ txtPhoneNumber��5$      $
��Left=�6*   $��23��6E   $	��120��5%      $��2��6   $��1��6+   6=   �� 5'   
   -   5         ��Name$ btnReset��5'      $��80��6#   $��50��6.   $��3��6:   $��0��6G   .��6n   Reset6u   �� 5(   
   -   5        $ btnSave��5(      $��80��6"   $��50��6-   $��3��69   $��1��6F   .��6l   Save6r   5*      5+      