   M S B A M L   `   `   `  ����G  CWpfAppListes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfAppListesWpfAppListes  5   	   ?$clr-namespace:WpfAppListes.ViewModelWpfAppListes.ViewModel  5   	       WpfAppListes.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfAppListes     5   	   3vm$clr-namespace:WpfAppListes.ViewModel     5   	     � Title$'  !MainWindow - Collection Obsevable��5	   	   $	��450��63   $	��800��6@   ���	#FFE07D7D$��Times New Roman)�6c   $��16(�6�    � DataContext 5      ,  &WpfAppListes.ViewModel.GestionAdherent  5   
   .��5      � .+�5   
   �� $��Numero��6   $
��Left=�6!   $��33��6<   $��
100,37,0,0q�6H   $	��Top=�6\   $��87��6t   �� 5   
   $	��Nom��6   $
��Left=�6   $��33��69   $��100,130,0,0q�6E   $	��Top=�6Z   $��87��6r   �� 5   
   $��Prenom��6   $
��Left=�6!   $��33��6<   $��
100,90,0,0q�6H   $	��Top=�6\   $��87��6t   �� 5   
   -   5         ��Name$ 	txtNumero��5      $
��Left=�6&   $��33��6A   $��
260,37,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��150��6�   �� 5   
   -   5        $ txtNom��5      $
��Left=�6#   $��33��6>   $��260,150,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��150��6�   �� 5   
   -   5        $ 	txtPrenom��5      $
��Left=�6&   $��33��6A   $��
260,90,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��150��6�   �� 5   
   -   5         ��Name$ ImgPhoto��5      $
��Left=�6"   $	��125��6=   $��
584,37,0,0q�6J   $	��Top=�6^   $��/Images/Durkheim.jpg��6v   $	��127��6�   $
��Fill=�6�   6�   �� 5   
   $
��Left=�65   $	��164��6P   $��	0,255,0,0q�6]   $	��Top=�6p   $	��792��6�   ���	#FFDE6474��6   �� *	Adherents+��5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6!   .+�5$      �� ��6    ��  �� Path$ Numero��� 5%      ��6    �� $	 Nom��� 5&      ��6    �� $ Prenom��� 5'      $��50��6>   $��50��6I   $
��Fill=�6U   ��6    �� $ Photo�6U   5(      5*      5-      �� 5/   
   -   5        $��Ajouter��5/      $
��Left=�6#   $��24��6>   $��260,204,0,0q�6J   $	��Top=�6_   $	��186��6w   6�   �� 50   
   -   5        $��Test DB��50      $
��Left=�6#   $��446,206,0,0q�6>   $	��Top=�6S   $	��155��6k   6w   51      52      